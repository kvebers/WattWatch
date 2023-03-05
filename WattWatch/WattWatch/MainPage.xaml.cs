using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WattWatch
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnImageButtonClicked(object sender, EventArgs e)
        {
            // Set the background color of the clicked button to a different color
            ImageButton clickedButton = (ImageButton)sender;
            clickedButton.BackgroundColor = Color.Yellow;
        }
    }
}
