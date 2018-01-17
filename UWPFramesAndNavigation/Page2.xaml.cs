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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPFramesAndNavigation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        // Enables the "back" btn only if there is a page to go back to.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Comment/uncomment next line to manipulate the stack, see what happens when there's no page to go back to.
            // Could use this line to not allow user to return to a previous page.
            this.Frame.BackStack.RemoveAt(this.Frame.BackStack.Count - 1);

            // Normal code for a "go back" button
            base.OnNavigatedTo(e);
            this.btn3.IsEnabled = this.Frame.BackStack.Any();
        }
    }
}
