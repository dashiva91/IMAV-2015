﻿#pragma checksum "..\..\..\..\UserControls\PIDControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8378F31B57D655BA6921C8F94690E517"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
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
using System.Windows.Forms;
using System.Windows.Forms.Integration;
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
using Xceed.Wpf.Toolkit;


namespace HighFlyers.UserControls {
    
    
    /// <summary>
    /// PIDControl
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class PIDControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\UserControls\PIDControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sendButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\UserControls\PIDControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle statusLight;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\UserControls\PIDControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label kpLabel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\UserControls\PIDControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label kiLabel;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\UserControls\PIDControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label kdLabel;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\UserControls\PIDControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.DecimalUpDown kpNumericUpDown;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\UserControls\PIDControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.DecimalUpDown kiNumericUpDown;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\UserControls\PIDControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.DecimalUpDown kdNumericUpDown;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_test;component/usercontrols/pidcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\PIDControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.sendButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\..\UserControls\PIDControl.xaml"
            this.sendButton.Click += new System.Windows.RoutedEventHandler(this.sendButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.statusLight = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.kpLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.kiLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.kdLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.kpNumericUpDown = ((Xceed.Wpf.Toolkit.DecimalUpDown)(target));
            
            #line 16 "..\..\..\..\UserControls\PIDControl.xaml"
            this.kpNumericUpDown.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.kpNumericUpDown_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.kiNumericUpDown = ((Xceed.Wpf.Toolkit.DecimalUpDown)(target));
            
            #line 17 "..\..\..\..\UserControls\PIDControl.xaml"
            this.kiNumericUpDown.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.kiNumericUpDown_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.kdNumericUpDown = ((Xceed.Wpf.Toolkit.DecimalUpDown)(target));
            
            #line 18 "..\..\..\..\UserControls\PIDControl.xaml"
            this.kdNumericUpDown.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.kdNumericUpDown_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
