#pragma checksum "..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DBEE3A64B44288E901208215CEC5BEFFC6F8CEE094D2F693C224738AE1419B38"
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
using WpfWincoverage.NetFramework.Views.Configuration.Site;


namespace WpfWincoverage.NetFramework.Views.Configuration.Site {
    
    
    /// <summary>
    /// siteEditAdd
    /// </summary>
    public partial class siteEditAdd : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelMnj;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveNew;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveClose;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox texboxName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox texboxArea;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox texboxLongitud;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox texboxLatitud;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfWincoverage.NetFramework;component/views/configuration/site/siteeditadd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
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
            
            #line 11 "..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
            ((System.Windows.Controls.Canvas)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Canvas_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.labelMnj = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.saveNew = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
            this.saveNew.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.saveClose = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\..\Views\Configuration\Site\siteEditAdd.xaml"
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
            }
            this._contentLoaded = true;
        }
    }
}

