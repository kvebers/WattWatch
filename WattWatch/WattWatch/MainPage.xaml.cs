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
        private ImageButton selectedButton;

        private void OnImageButtonClicked(object sender, EventArgs e)
        {
            // Reset the background color of the previously selected button
            if (selectedButton != null)
            {
                selectedButton.BackgroundColor = Color.FromHex("#001E33");
            }

            // Set the background color of the clicked button to a different color
            ImageButton clickedButton = (ImageButton)sender;
            clickedButton.BackgroundColor = Color.White;

            // Set the selected button to the clicked button
            selectedButton = clickedButton;
        }
    }
}
