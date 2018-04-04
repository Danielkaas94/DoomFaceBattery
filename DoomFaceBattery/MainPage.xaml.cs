using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
//using Windows.Devices.Power;
using DoomFaceBattery.Resources;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Threading;

namespace DoomFaceBattery
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            ChangeFace();
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void button_GetPercent_Click(object sender, RoutedEventArgs e)
        {
            // Worth a read: Quickstart: Update a live tile from a background task https://msdn.microsoft.com/en-us/library/windows/apps/xaml/jj991805.aspx
            // This is good: https://blog.jayway.com/2014/04/23/windows-phone-8-1-for-developers-multitasking-and-background-tasks/

            ChangeFace();
        }


        private async void ChangeFace()
        {
            ShellTile tileToFind = ShellTile.ActiveTiles.First();
            StandardTileData newTileData = new StandardTileData();
            int percentPoint;

            percentPoint = int.Parse(Windows.Phone.Devices.Power.Battery.GetDefault().RemainingChargePercent.ToString());
            newTileData.Title = percentPoint.ToString() + " %";

            textBlock_Percent.Text = percentPoint.ToString() + " %";
            BitmapImage btImage = new BitmapImage();


            if (percentPoint <= 100 && percentPoint >= 80)
            {
                newTileData.BackgroundImage = new Uri("/Assets/ImageFace/DoomGoodFace.png", UriKind.Relative);
                newTileData.BackBackgroundImage = new Uri("/Assets/ImageFace/DoomGoodFaceS.png", UriKind.Relative);

                tileToFind.Update(newTileData);

                for (int i = 0; i < 5; i++)
                {
                    btImage.UriSource = new Uri("/Assets/ImageFace/DoomGoodFaceL.png", UriKind.Relative);
                    image_Face.Source = btImage;
                    await System.Threading.Tasks.Task.Delay(1100);
                    btImage.UriSource = new Uri("/Assets/ImageFace/DoomGoodFace.png", UriKind.Relative);
                    image_Face.Source = btImage;
                    await System.Threading.Tasks.Task.Delay(1100);
                    btImage.UriSource = new Uri("/Assets/ImageFace/DoomGoodFaceS.png", UriKind.Relative);
                    image_Face.Source = btImage;
                    await System.Threading.Tasks.Task.Delay(1100);
                }

            }
            else if (percentPoint <= 79 && percentPoint >= 60)
            {
                newTileData.BackgroundImage = new Uri("/Assets/ImageFace/DoomMussed.png", UriKind.Relative);
                newTileData.BackBackgroundImage = new Uri("/Assets/ImageFace/DoomMussedS.png", UriKind.Relative);

                tileToFind.Update(newTileData);

                for (int i = 0; i < 5; i++)
                {

                    btImage.UriSource = new Uri("/Assets/ImageFace/DoomMussedL.png", UriKind.Relative);
                    image_Face.Source = btImage;
                    await System.Threading.Tasks.Task.Delay(1100);
                    btImage.UriSource = new Uri("/Assets/ImageFace/DoomMussed.png", UriKind.Relative);
                    image_Face.Source = btImage;
                    await System.Threading.Tasks.Task.Delay(1100);
                    btImage.UriSource = new Uri("/Assets/ImageFace/DoomMussedS.png", UriKind.Relative);
                    image_Face.Source = btImage;
                    await System.Threading.Tasks.Task.Delay(1100);
                    //btImage.UriSource = new Uri("/Assets/ImageFace/DoomMussedS.png", UriKind.Relative);
                    //image_Face.Source = btImage;
                    //await System.Threading.Tasks.Task.Delay(1100);
                }


            }
            else if (percentPoint <= 59 && percentPoint >= 40)
            {
                newTileData.BackgroundImage = new Uri("/Assets/ImageFace/DoomSwollen.png", UriKind.Relative);
                newTileData.BackBackgroundImage = new Uri("/Assets/ImageFace/DoomSwollenS.png", UriKind.Relative);

                tileToFind.Update(newTileData);

                for (int i = 0; i < 5; i++)
                {
                    btImage.UriSource = new Uri("/Assets/ImageFace/DoomSwollenL.png", UriKind.Relative);
                    image_Face.Source = btImage;
                    await System.Threading.Tasks.Task.Delay(1100);
                    btImage.UriSource = new Uri("/Assets/ImageFace/DoomSwollen.png", UriKind.Relative);
                    image_Face.Source = btImage;
                    await System.Threading.Tasks.Task.Delay(1100);
                    btImage.UriSource = new Uri("/Assets/ImageFace/DoomSwollenS.png", UriKind.Relative);
                    image_Face.Source = btImage;
                    await System.Threading.Tasks.Task.Delay(1100);
                }


            }
            else if (percentPoint <= 39 && percentPoint >= 20)
            {
                newTileData.BackgroundImage = new Uri("/Assets/ImageFace/DoomDirty.png", UriKind.Relative);
                newTileData.BackBackgroundImage = new Uri("/Assets/ImageFace/DoomDirty - Kopi.png", UriKind.Relative);

                tileToFind.Update(newTileData);

                for (int i = 0; i < 5; i++)
                {
                    btImage.UriSource = new Uri("/Assets/ImageFace/DoomDirtyL.png", UriKind.Relative);
                    image_Face.Source = btImage;
                    await System.Threading.Tasks.Task.Delay(1100);
                    btImage.UriSource = new Uri("/Assets/ImageFace/DoomDirty.png", UriKind.Relative);
                    image_Face.Source = btImage;
                    await System.Threading.Tasks.Task.Delay(1100);
                    btImage.UriSource = new Uri("/Assets/ImageFace/DoomDirtyS.png", UriKind.Relative);
                    image_Face.Source = btImage;
                    await System.Threading.Tasks.Task.Delay(1100);
                }

            }
            else if (percentPoint <= 19 && percentPoint >= 1)
            {
                newTileData.BackgroundImage = new Uri("/Assets/ImageFace/DoomBloody - Kopi.png", UriKind.Relative);
                tileToFind.Update(newTileData);

                for (int i = 0; i < 5; i++)
                {
                    btImage.UriSource = new Uri("/Assets/ImageFace/DoomBloodyL.png", UriKind.Relative);
                    image_Face.Source = btImage;
                    await System.Threading.Tasks.Task.Delay(1100);
                    btImage.UriSource = new Uri("/Assets/ImageFace/DoomBloody.png", UriKind.Relative);
                    image_Face.Source = btImage;
                    await System.Threading.Tasks.Task.Delay(1100);
                    btImage.UriSource = new Uri("/Assets/ImageFace/DoomBloodyS.png", UriKind.Relative);
                    image_Face.Source = btImage;
                    await System.Threading.Tasks.Task.Delay(1100);
                }
            }

            tileToFind.Update(newTileData);
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}