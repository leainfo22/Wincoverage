﻿#pragma checksum "..\..\..\..\..\..\Views\Configuration\Channel\channelEditAdd.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86B1756BBE10EDDB35B43BF0740D270E29D42B52"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using WpfWincoverage.Views.Configuration.Channel;


namespace WpfWincoverage.Views.Configuration.Channel {
    
    
    /// <summary>
    /// channelEditAdd
    /// </summary>
    public partial class channelEditAdd : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\..\Views\Configuration\Channel\channelEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelMnj;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\..\Views\Configuration\Channel\channelEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveNew;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\..\Views\Configuration\Channel\channelEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveClose;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\..\Views\Configuration\Channel\channelEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox texboxName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\..\Views\Configuration\Channel\channelEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox texboxArea;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\..\Views\Configuration\Channel\channelEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox texboxLongitud;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\..\Views\Configuration\Channel\channelEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox texboxLatitud;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\..\Views\Configuration\Channel\channelEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox texboxLatitud_Copy;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfWincoverage;component/views/configuration/channel/channeleditadd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Configuration\Channel\channelEditAdd.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\..\..\..\Views\Configuration\Channel\channelEditAdd.xaml"
            ((System.Windows.Controls.Canvas)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Canvas_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.labelMnj = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.saveNew = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\..\..\Views\Configuration\Channel\channelEditAdd.xaml"
            this.saveNew.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.saveClose = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\..\..\Views\Configuration\Channel\channelEditAdd.xaml"
            this.saveClose.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.texboxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.texboxArea = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.texboxLongitud = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.texboxLatitud = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.texboxLatitud_Copy = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

