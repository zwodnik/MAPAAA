using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Maps
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }
        private double wsp1 = 50.0, wsp2 = 20.0;
        private void MapLauncher_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            //  Launcher.LaunchUriAsync(new Uri("bingmaps:?cp=50.068308~19.911654&lvl=17"));
            Launcher.LaunchUriAsync(new Uri("bingmaps:?cp=" + wsp1.ToString() + "~" + wsp2.ToString() + "&lvl=17"));
        }

        private void wsp1_TB_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                wsp1 = double.Parse(((TextBox)sender).Text);
            }
            catch (Exception ex) { }

        }

        private void wsp2_TB_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                wsp2 = double.Parse(((TextBox)sender).Text);
            }
            catch (Exception ex) { }
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
    }
}
