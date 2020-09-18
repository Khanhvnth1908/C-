using Practice.Model;
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

namespace Practice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private List<Icons> Icons;
        private ObservableCollection<Product> Products;
        public MainPage()
        {
            this.InitializeComponent();

            Icons = new List<Icons>();

            Icons.Add(new Icons { IconPath = "Assets/music1.jpeg" });
            Icons.Add(new Icons { IconPath = "Assets/music2.jpeg" });
            Icons.Add(new Icons { IconPath = "Assets/music3.jpeg" });
            Icons.Add(new Icons { IconPath = "Assets/music4.jpeg" });
            Icons.Add(new Icons { IconPath = "Assets/music5.jpeg" });

            Products = new ObservableCollection<Product>();
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string image = ((Icons)ImageComboBox.SelectedValue).IconPath;
            Products.Add(new Product { Title = TitleTextBox.Text, Content = ContentTextBox.Text,Image = image });

            TitleTextBox.Text = "";
            ContentTextBox.Text = "";
            ImageComboBox.SelectedIndex = -1;

            TitleTextBox.Focus(FocusState.Programmatic);
        }
    }
}
