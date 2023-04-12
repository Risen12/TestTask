using System.Collections.Generic;
using Xamarin.Forms;
using System.Xml;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Text;

namespace TestTask
{
    public partial class MainPage : ContentPage
    {
        List<Offer> offersList;
        List<string> Id;
        public MainPage()
        {
            InitializeComponent();
            Id = new List<string>();
            offersList = new List<Offer>();
        }


        async void GetId(object sender, EventArgs e)
        {
            StartLoading();
            XmlDocument doc = new XmlDocument();
            await GetXml("https://partner.market.yandex.ru/pages/help/YML.xml", doc);
            XmlNodeList offers = GetOffersList(doc);
            ParseXml(offers, offersList);
            SetIdList(offersList);
            SetupListView();
            EndLoading();
        }

        void SetupListView()
        {
            var template = new DataTemplate(typeof(TextCell));
            template.SetValue(TextCell.TextColorProperty, Color.Black);
            template.SetBinding(TextCell.TextProperty, ".");
            IdList.ItemTemplate = template;
            IdList.ItemsSource = Id;
        }

        XmlNodeList GetOffersList(XmlDocument document)
        {
            XmlNodeList offers = document.GetElementsByTagName("offer");
            return offers;
        }

        void SetIdList(List<Offer> offers)
        {
            foreach (Offer offer in offers)
            {
                Id.Add(offer.ID.ToString());
            }
        }

        async Task GetXml(string Url, XmlDocument document)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetByteArrayAsync(Url);
            var responseString = Encoding.GetEncoding("windows-1251").GetString(response,0,response.Length - 1);
            document.LoadXml(responseString);
        }

        void ParseXml(XmlNodeList list, List<Offer> offers)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Offer));
            StringReader reader = null;
            foreach (XmlElement element in list)
            {
                reader = new StringReader(element.OuterXml);
                switch (element.GetAttribute("type").ToString())
                {
                    case "artist.title":
                        serializer = new XmlSerializer(typeof(ArtistTitleOffer));
                        offers.Add((ArtistTitleOffer)serializer.Deserialize(reader));
                        break;
                    case "tour":
                        serializer = new XmlSerializer(typeof(TourOffer));
                        offers.Add((TourOffer)serializer.Deserialize(reader));
                        break;
                    case "audiobook":
                        serializer = new XmlSerializer(typeof(AudioBookOffer));
                        offers.Add((AudioBookOffer)serializer.Deserialize(reader));
                        break;
                    case "book":
                        serializer = new XmlSerializer(typeof(BookOffer));
                        offers.Add((BookOffer)serializer.Deserialize(reader));
                        break;
                    case "vendor.model":
                        serializer = new XmlSerializer(typeof(VendorOffer));
                        offers.Add((VendorOffer)serializer.Deserialize(reader));
                        break;
                    case "event-ticket":
                        serializer = new XmlSerializer(typeof(EventOffer));
                        offers.Add((EventOffer)serializer.Deserialize(reader));
                        break;
                    default:
                        offers.Add((Offer)serializer.Deserialize(reader));
                        break;
                }
            }
        }

        async void OfferSelected(object sender, ItemTappedEventArgs e)
        {
            var view = sender as View;
            view.SetValue(BackgroundColorProperty,Color.Transparent);
            var item = e.Item.ToString();
            var offer = offersList.Where(x => x.ID.ToString() == item).Single();
            await Navigation.PushModalAsync(new OfferPage(offer));
        }

        void StartLoading()
        {
            Loading.IsRunning = true;
            Loading.IsVisible = true;
        }

        void EndLoading()
        {
            Loading.IsRunning = false;
            Loading.IsVisible = false;
        }

    }
}
