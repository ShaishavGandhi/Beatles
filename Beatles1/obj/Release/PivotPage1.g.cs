﻿#pragma checksum "C:\Users\Amit\Documents\Visual Studio 2013\Projects\Beatles1\Beatles1\PivotPage1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A6E3B342F30E80793EF3CF821F4A551D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Advertising.Mobile.UI;
using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Beatles1 {
    
    
    public partial class PivotPage1 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock TrackNameBlock;
        
        internal System.Windows.Controls.MediaElement AudioElement;
        
        internal System.Windows.Controls.Image AudioImagePrev;
        
        internal System.Windows.Controls.Image AudioImage;
        
        internal System.Windows.Controls.Image AudioImageNext;
        
        internal Microsoft.Advertising.Mobile.UI.AdControl AdControl;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Beatles1;component/PivotPage1.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TrackNameBlock = ((System.Windows.Controls.TextBlock)(this.FindName("TrackNameBlock")));
            this.AudioElement = ((System.Windows.Controls.MediaElement)(this.FindName("AudioElement")));
            this.AudioImagePrev = ((System.Windows.Controls.Image)(this.FindName("AudioImagePrev")));
            this.AudioImage = ((System.Windows.Controls.Image)(this.FindName("AudioImage")));
            this.AudioImageNext = ((System.Windows.Controls.Image)(this.FindName("AudioImageNext")));
            this.AdControl = ((Microsoft.Advertising.Mobile.UI.AdControl)(this.FindName("AdControl")));
        }
    }
}

