using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPFramesAndNavigation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page2));
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page2));
        }

        // Disables go back button when page loads because there's nothing to go back to.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            innerFrame.Navigate(typeof(BlankSubPage1));
            this.btn3.IsEnabled = innerFrame.BackStack.Any();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            innerFrame.Navigate(typeof(BlankSubPage1));
            this.btn3.IsEnabled = innerFrame.BackStack.Any();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            innerFrame.Navigate(typeof(BlankSubPage2));
            this.btn3.IsEnabled = innerFrame.BackStack.Any();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            innerFrame.GoBack();
            this.btn3.IsEnabled = innerFrame.BackStack.Any();
        }
    }
}
