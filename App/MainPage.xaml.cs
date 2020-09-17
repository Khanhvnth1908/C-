using App.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<NewItems> NewItems;
        public MainPage()
        {
            this.InitializeComponent();
            NewItems = new ObservableCollection<NewItems>();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Music.IsSelected)
            {
                NewManager.GetItems("Music", NewItems);
                TitleTextBlock.Text = "Music";
            }else if (Food.IsSelected)
            {
                NewManager.GetItems("Food", NewItems);
                TitleTextBlock.Text = "Food";
            }
        }

        public void Page_Loaded(Object sender, RoutedEventArgs e)
        {
            Music.IsSelected = true;
        }
    }
}
