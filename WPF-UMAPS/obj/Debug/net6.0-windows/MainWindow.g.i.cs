﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EAD46952EE2F669229A4E356D907F7853D1A75BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using System.Windows.Controls.Ribbon;
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
using WPF_UMAPS;


namespace WPF_UMAPS {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 268 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pactware;
        
        #line default
        #line hidden
        
        
        #line 305 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button meterview;
        
        #line default
        #line hidden
        
        
        #line 342 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button simatic;
        
        #line default
        #line hidden
        
        
        #line 379 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dim;
        
        #line default
        #line hidden
        
        
        #line 423 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MiniBtn;
        
        #line default
        #line hidden
        
        
        #line 429 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF-UMAPS;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 16 "..\..\..\MainWindow.xaml"
            ((WPF_UMAPS.MainWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.pactware = ((System.Windows.Controls.Button)(target));
            
            #line 270 "..\..\..\MainWindow.xaml"
            this.pactware.Click += new System.Windows.RoutedEventHandler(this.pactware_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.meterview = ((System.Windows.Controls.Button)(target));
            
            #line 307 "..\..\..\MainWindow.xaml"
            this.meterview.Click += new System.Windows.RoutedEventHandler(this.meterview_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.simatic = ((System.Windows.Controls.Button)(target));
            
            #line 344 "..\..\..\MainWindow.xaml"
            this.simatic.Click += new System.Windows.RoutedEventHandler(this.simatic_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dim = ((System.Windows.Controls.Button)(target));
            
            #line 381 "..\..\..\MainWindow.xaml"
            this.dim.Click += new System.Windows.RoutedEventHandler(this.dim_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MiniBtn = ((System.Windows.Controls.Button)(target));
            
            #line 425 "..\..\..\MainWindow.xaml"
            this.MiniBtn.Click += new System.Windows.RoutedEventHandler(this.MiniBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ExitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 431 "..\..\..\MainWindow.xaml"
            this.ExitBtn.Click += new System.Windows.RoutedEventHandler(this.ExitBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

