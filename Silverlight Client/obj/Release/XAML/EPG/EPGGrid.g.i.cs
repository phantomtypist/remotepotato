﻿#pragma checksum "D:\Users\Carl\Visual Studio\Projects\RemotePotatoServer\SilverPotato\XAML\EPG\EPGGrid.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "09A8AC9A182FF9CC1C5BAEEB557D3623"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace SilverPotato {
    
    
    public partial class EPGGrid : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ColumnDefinition cdChannels;
        
        internal System.Windows.Controls.ScrollViewer svTimeHeaders;
        
        internal System.Windows.Controls.StackPanel spTimeHeaders;
        
        internal System.Windows.Controls.ScrollViewer svChannels;
        
        internal System.Windows.Controls.StackPanel spChannels;
        
        internal System.Windows.Controls.Grid gdEPGProgrammes;
        
        internal System.Windows.Controls.ScrollViewer svProgrammes;
        
        internal System.Windows.Controls.Canvas cvChannelStrips;
        
        internal System.Windows.Controls.Canvas cvCurrentTime;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverPotato;component/XAML/EPG/EPGGrid.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.cdChannels = ((System.Windows.Controls.ColumnDefinition)(this.FindName("cdChannels")));
            this.svTimeHeaders = ((System.Windows.Controls.ScrollViewer)(this.FindName("svTimeHeaders")));
            this.spTimeHeaders = ((System.Windows.Controls.StackPanel)(this.FindName("spTimeHeaders")));
            this.svChannels = ((System.Windows.Controls.ScrollViewer)(this.FindName("svChannels")));
            this.spChannels = ((System.Windows.Controls.StackPanel)(this.FindName("spChannels")));
            this.gdEPGProgrammes = ((System.Windows.Controls.Grid)(this.FindName("gdEPGProgrammes")));
            this.svProgrammes = ((System.Windows.Controls.ScrollViewer)(this.FindName("svProgrammes")));
            this.cvChannelStrips = ((System.Windows.Controls.Canvas)(this.FindName("cvChannelStrips")));
            this.cvCurrentTime = ((System.Windows.Controls.Canvas)(this.FindName("cvCurrentTime")));
        }
    }
}
