﻿#pragma checksum "..\..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70DCF7126591F01E046F9A1F184A9C97B494179A"
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
using WpfWincoverage.Views.Configuration.Site;


namespace WpfWincoverage.Views.Configuration.Site {
    
    
    /// <summary>
    /// siteEditAdd
    /// </summary>
    public partial class siteEditAdd : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelMnj;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveNew;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox texboxName;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox texboxArea;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox texboxLongitud;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox texboxLatitud;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfWincoverage;V1.0.0.0;component/views/configuration/site/siteeditadd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
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
            
            #line 11 "..\..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
            ((System.Windows.Controls.Canvas)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Canvas_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.labelMnj = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.saveNew = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
            this.saveNew.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 19 "..\..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
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
            }
            this._contentLoaded = true;
        }
    }
}
