﻿#pragma checksum "..\..\..\Views\TankView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "25D6AE480B9EEBB9B29303E61714AD88FD3AF888F6346E250E3216D32BAA9B25"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
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
using WPF_OOP_Testing.Views;


namespace WPF_OOP_Testing.Views {
    
    
    /// <summary>
    /// TankView
    /// </summary>
    public partial class TankView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Views\TankView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FuelCombobox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\TankView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FuelName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\TankView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LiterAnz;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\TankView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LiterAnzMax;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\TankView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ErrorMessage;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\TankView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Views\TankView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF OOP Testing;component/views/tankview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\TankView.xaml"
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
            this.FuelCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\Views\TankView.xaml"
            this.FuelCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FuelCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FuelName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.LiterAnz = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.LiterAnzMax = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ErrorMessage = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Views\TankView.xaml"
            this.AddButton.Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Views\TankView.xaml"
            this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

