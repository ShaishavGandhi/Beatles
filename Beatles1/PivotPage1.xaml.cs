using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using GoogleAds;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.BackgroundAudio;
namespace Beatles1
{
    public partial class PivotPage1 : PhoneApplicationPage
    {
        public PivotPage1()
        {
            //BackgroundAudioPlayer.Instance.PlayStateChanged += new EventHandler(Instance_PlayStateChanged);
            InitializeComponent();
            //AdControl.ErrorOccurred += AdControl_ErrorOccurred;
         
        }

       
        //void Instance_PlayStateChanged(object sender, EventArgs e)
        //{
        //    switch (BackgroundAudioPlayer.Instance.PlayerState)
        //    {
        //        case PlayState.Playing:
        //            BitmapImage bm1 = new BitmapImage(new Uri("Images/appbar.control.pause.png", UriKind.RelativeOrAbsolute));
        //            AudioImage.Source = bm1;
        //            break;

        //        case PlayState.Paused:
        //        case PlayState.Stopped:
        //            BitmapImage bm = new BitmapImage(new Uri("Images/appbar.control.play.png", UriKind.RelativeOrAbsolute));
        //            AudioImage.Source = bm;

        //            break;
        //    }

        //    if (null != BackgroundAudioPlayer.Instance.Track)
        //    {
        //      //  txtCurrentTrack.Text = BackgroundAudioPlayer.Instance.Track.Title +
        //        //                       " by " +
        //          //                     BackgroundAudioPlayer.Instance.Track.Artist;
        //    }
        //}

        private int Count = 0;
        private int index;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           
            if (DataContext == null)
            {
                string selectedIndex = "";
                if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
                {
                     index = int.Parse(selectedIndex);
                    DataContext = App.ViewModel.Items[index];
                    
                }
            }
            //if (PlayState.Playing == BackgroundAudioPlayer.Instance.PlayerState)
            //{
            //    BitmapImage bm1 = new BitmapImage(new Uri("Images/appbar.control.pause.png", UriKind.RelativeOrAbsolute));
            //    AudioImage.Source = bm1;


            //}
            //else
            //{
            //    BitmapImage bm = new BitmapImage(new Uri("Images/appbar.control.play.png", UriKind.RelativeOrAbsolute));
            //    AudioImage.Source = bm;
            //}
        }

        private void UIElement_OnTap(object sender, GestureEventArgs e)
        {
            if (Count % 2 != 0) { 
           AudioElement.Play();
                BitmapImage bm1 = new BitmapImage(new Uri("Images/appbar.control.pause.png", UriKind.RelativeOrAbsolute));
                AudioImage.Source = bm1;
            }
            else
            {
                BitmapImage bm = new BitmapImage(new Uri("Images/appbar.control.play.png", UriKind.RelativeOrAbsolute));
                AudioImage.Source = bm;
                AudioElement.Pause();
            }
            Count++;
        }

        private void AudioElement_OnMediaEnded(object sender, RoutedEventArgs e)
        {
            index++;
            string blah = App.ViewModel.Items[index].AudioSrc.ToString();
            string name = App.ViewModel.Items[index].LineOne.ToString();
            TrackNameBlock.Text = name;
            AudioElement.Source = new Uri(blah);
            AudioElement.Play();

        }

        private void prevTrack(object sender, RoutedEventArgs e)
        {
            index--;
            string blah = App.ViewModel.Items[index].AudioSrc.ToString();
            string name = App.ViewModel.Items[index].LineOne.ToString();
            TrackNameBlock.Text = name;
            AudioElement.Source = new Uri(blah);
            AudioElement.Play();
        }
    }
}