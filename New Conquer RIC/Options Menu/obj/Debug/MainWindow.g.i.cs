﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D2AD88B9A8D60B1227C67144CE35483F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace OptionsMenu {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OptionsMenu.MainWindow Window;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Menu_Window;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Title_Bar;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Title;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit_Button;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Return_Main_Menu;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Sound_Text;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel Toggle_Panel;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sound_On_Button;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sound_Off_Button;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save_Button;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement Bgm;
        
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
            System.Uri resourceLocater = new System.Uri("/Options Menu;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.Window = ((OptionsMenu.MainWindow)(target));
            return;
            case 2:
            this.Menu_Window = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.Title_Bar = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 136 "..\..\MainWindow.xaml"
            this.Title_Bar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Title_Bar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Title = ((System.Windows.Controls.Label)(target));
            
            #line 137 "..\..\MainWindow.xaml"
            this.Title.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Title_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Exit_Button = ((System.Windows.Controls.Button)(target));
            
            #line 138 "..\..\MainWindow.xaml"
            this.Exit_Button.Click += new System.Windows.RoutedEventHandler(this.Exit_Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Return_Main_Menu = ((System.Windows.Controls.Button)(target));
            
            #line 139 "..\..\MainWindow.xaml"
            this.Return_Main_Menu.Click += new System.Windows.RoutedEventHandler(this.Return_Main_Menu_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Sound_Text = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.Toggle_Panel = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 9:
            this.Sound_On_Button = ((System.Windows.Controls.Button)(target));
            
            #line 142 "..\..\MainWindow.xaml"
            this.Sound_On_Button.Click += new System.Windows.RoutedEventHandler(this.Sound_On_Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Sound_Off_Button = ((System.Windows.Controls.Button)(target));
            
            #line 143 "..\..\MainWindow.xaml"
            this.Sound_Off_Button.Click += new System.Windows.RoutedEventHandler(this.Sound_Off_Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Save_Button = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.Bgm = ((System.Windows.Controls.MediaElement)(target));
            
            #line 146 "..\..\MainWindow.xaml"
            this.Bgm.MediaEnded += new System.Windows.RoutedEventHandler(this.Bgm_MediaEnded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

