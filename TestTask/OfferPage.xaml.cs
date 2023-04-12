using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestTask
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfferPage : ContentPage
    {
        public OfferPage(Offer offer)
        {
            var SelectedOffer = offer;
            InitializeComponent();
            UnpackOffer(ref SelectedOffer);
            ShowOfferJson(SelectedOffer);
        }

        async void BackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }


        void UnpackOffer(ref Offer offer)
        {
            var UnpackedOffer = offer;
            switch (offer.Type)
            {
                case "artist.title":
                    UnpackedOffer = (ArtistTitleOffer)offer;
                    break;
                case "tour":
                    UnpackedOffer = (TourOffer)offer;
                    break;
                case "audiobook":
                    UnpackedOffer = (AudioBookOffer)offer;
                    break;
                case "book":
                    UnpackedOffer = (BookOffer)offer;
                    break;
                case "vendor.model":
                    UnpackedOffer = (VendorOffer)offer;
                    break;
                case "event-ticket":
                    UnpackedOffer = (EventOffer)offer;
                    break;
            }
        }

        async void ShowOfferJson(Offer offer)
        {
            await Task.Run(() => 
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    string JsonString = JsonConvert.SerializeObject(offer, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                    JsonString = JsonString.Replace(",", ",\n");
                    JsonOfferText.Text = JsonString;
                });
            });
        }
    }
}