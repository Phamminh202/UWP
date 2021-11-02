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
using T2010A.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2010A.Lab_s2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Menu : Page
    {
        public Menu()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(Lab_s2.Home));
            var home = new MenuItem() { Name = "Home", MenuPage = "homepage", Icon = "\uE80F" };
            var contact = new MenuItem() { Name = "Contact", MenuPage = "contactpage", Icon = "\uE7EE" };
            var customer = new MenuItem() { Name = "Customer", MenuPage = "customerpage", Icon = "\uE77B" };
            var mail = new MenuItem() { Name = "Mail", MenuPage = "mailpage", Icon = "\uE715" };

            Menus.Items.Add(home);
            Menus.Items.Add(contact);
            Menus.Items.Add(customer);
            Menus.Items.Add(mail);
        }

        private void IconCLick_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Layout.IsPaneOpen = !Layout.IsPaneOpen;
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)Menus.SelectedItem;
            switch (menuItem.MenuPage)
            {
                case "homepage":MainFrame.Navigate(typeof(Lab_s2.Home));break;
                case "contactpage":MainFrame.Navigate(typeof(Lab_s2.Contact));break;
                case "customerpage":MainFrame.Navigate(typeof(Lab_s2.Customer));break;
                case "mailpage":MainFrame.Navigate(typeof(Lab_s2.Mail));break;
            }
        }
    }
}
