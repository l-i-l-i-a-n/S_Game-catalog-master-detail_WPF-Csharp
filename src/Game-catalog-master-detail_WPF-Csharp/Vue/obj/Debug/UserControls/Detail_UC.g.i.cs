﻿#pragma checksum "..\..\..\UserControls\Detail_UC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "15D44D969AF14B3E5E3E5CACB9C57985BEAD845C245C18A192C4E21E86445282"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Vue.UserControls;


namespace Vue.UserControls {
    
    
    /// <summary>
    /// Detail_UC
    /// </summary>
    public partial class Detail_UC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\UserControls\Detail_UC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement Video;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\UserControls\Detail_UC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Video_Placeholder_Textblock;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\UserControls\Detail_UC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MuteVolume_Button;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\UserControls\Detail_UC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider volumeSlider;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\UserControls\Detail_UC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pause_Button;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\UserControls\Detail_UC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Play_Button;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\UserControls\Detail_UC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Fullscreen_Button;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\UserControls\Detail_UC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AjoutImage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Vue;component/usercontrols/detail_uc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\Detail_UC.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Video = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 2:
            this.Video_Placeholder_Textblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.MuteVolume_Button = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\UserControls\Detail_UC.xaml"
            this.MuteVolume_Button.Click += new System.Windows.RoutedEventHandler(this.MuteVolume_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.volumeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 36 "..\..\..\UserControls\Detail_UC.xaml"
            this.volumeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.VolumeSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Pause_Button = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\UserControls\Detail_UC.xaml"
            this.Pause_Button.Click += new System.Windows.RoutedEventHandler(this.Pause_Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Play_Button = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\UserControls\Detail_UC.xaml"
            this.Play_Button.Click += new System.Windows.RoutedEventHandler(this.Play_Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Fullscreen_Button = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\UserControls\Detail_UC.xaml"
            this.Fullscreen_Button.Click += new System.Windows.RoutedEventHandler(this.Fullscreen_Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AjoutImage = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\UserControls\Detail_UC.xaml"
            this.AjoutImage.Click += new System.Windows.RoutedEventHandler(this.AjoutImage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

