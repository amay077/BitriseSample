using Xamarin.Forms;

namespace BitriseSample
{
    public partial class BitriseSamplePage : ContentPage
    {
        public BitriseSamplePage()
        {
            InitializeComponent();
            button.Clicked += (sender, e) => label.Text = "PUSHED!!!";
        }
    }
}

