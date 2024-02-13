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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Memory
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
        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
        private void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }
        private void MenuFlyoutItem_Click_2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Image1(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://img.wattpad.com/ddc8d21cf88e48a9fa4ab0dce5f83e74580b66b3/68747470733a2f2f73332e616d617a6f6e6177732e636f6d2f776174747061642d6d656469612d736572766963652f53746f7279496d6167652f33575a765730494d7049465f6a413d3d2d3730383635343933362e313538643365393465383965393234363238343630373532363032352e6a7067?s=fit&w=720&h=720"));
        }

        private void Image2(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://i.pinimg.com/736x/75/c7/8c/75c78c74ea0feeeeb7fe5c27d58b072c.jpg"));
        }

        private void Image3(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://www.boredpanda.com/blog/wp-content/uploads/2023/03/16-640b0e36e0c22__700.jpg"));
        }

        private void Image4(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://www.boredpanda.com/blog/wp-content/uploads/2023/03/16-640b0e36e0c22__700.jpg"));
        }

        private void Image5(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://img.wattpad.com/ddc8d21cf88e48a9fa4ab0dce5f83e74580b66b3/68747470733a2f2f73332e616d617a6f6e6177732e636f6d2f776174747061642d6d656469612d736572766963652f53746f7279496d6167652f33575a765730494d7049465f6a413d3d2d3730383635343933362e313538643365393465383965393234363238343630373532363032352e6a7067?s=fit&w=720&h=720"));
        }

        private void Image6(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://media.istockphoto.com/id/1166706121/photo/portrait-of-a-professional-chef-holding-an-empty-plate-isolated-on-light-blue.jpg?s=612x612&w=0&k=20&c=m8s1izKyn1UPnOYv3HXvKKcdKY5F_hStp7BC5ojYfbk="));
        }

        private void Image7(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://media.istockphoto.com/id/187722063/photo/funny-man-with-watermelon-helmet-and-goggles.jpg?s=612x612&w=0&k=20&c=gRAm8vtLqdOU8a-mJVt6m_Wnv8pLpa3TBh2vRQP4208="));
        }

        private void Image8(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://media.istockphoto.com/id/1166706121/photo/portrait-of-a-professional-chef-holding-an-empty-plate-isolated-on-light-blue.jpg?s=612x612&w=0&k=20&c=m8s1izKyn1UPnOYv3HXvKKcdKY5F_hStp7BC5ojYfbk="));
        }

        private void Image9(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://i.pinimg.com/736x/75/c7/8c/75c78c74ea0feeeeb7fe5c27d58b072c.jpg"));
        }

        private void Image10(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://as2.ftcdn.net/v2/jpg/00/65/21/89/1000_F_65218950_8gGgy60Q1BFQvz13RLAJOCBtydFwJxFH.jpg"));
        }

        private void Image11(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://gratisography.com/wp-content/uploads/2023/06/gratisography-dj-gorilla-free-stock-photo-800x525.jpg"));
        }

        private void Image12(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://i.kym-cdn.com/entries/icons/facebook/000/017/883/gdfgdf.jpg"));
        }

        private void Image13(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://media.istockphoto.com/id/187722063/photo/funny-man-with-watermelon-helmet-and-goggles.jpg?s=612x612&w=0&k=20&c=gRAm8vtLqdOU8a-mJVt6m_Wnv8pLpa3TBh2vRQP4208="));
        }

        private void Image14(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://gratisography.com/wp-content/uploads/2023/06/gratisography-dj-gorilla-free-stock-photo-800x525.jpg"));
        }

        private void Image15(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://as2.ftcdn.net/v2/jpg/00/65/21/89/1000_F_65218950_8gGgy60Q1BFQvz13RLAJOCBtydFwJxFH.jpg"));
        }

        private void Image16(object sender, TappedRoutedEventArgs e)
        {
            (sender as Image).Source = new BitmapImage(new Uri("https://i.kym-cdn.com/entries/icons/facebook/000/017/883/gdfgdf.jpg"));
        }
    }
}
