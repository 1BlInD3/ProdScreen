﻿#pragma checksum "..\..\UnitSelectView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B41A4DA110B1A1D9E29300AEFA0845D2C4D5BCAF35D47BBE2AED21AF53DA09D9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MonitorManager;
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


namespace MonitorManager {
    
    
    /// <summary>
    /// UnitSelectView
    /// </summary>
    public partial class UnitSelectView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\UnitSelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbGroup1;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\UnitSelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbGroup2;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\UnitSelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbGroup3;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\UnitSelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbGroup4;
        
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
            System.Uri resourceLocater = new System.Uri("/MonitorManager;component/unitselectview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UnitSelectView.xaml"
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
            this.cbGroup1 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 20 "..\..\UnitSelectView.xaml"
            this.cbGroup1.Checked += new System.Windows.RoutedEventHandler(this.cbGroup_Checked);
            
            #line default
            #line hidden
            
            #line 20 "..\..\UnitSelectView.xaml"
            this.cbGroup1.Unchecked += new System.Windows.RoutedEventHandler(this.cbGroup_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbGroup2 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 21 "..\..\UnitSelectView.xaml"
            this.cbGroup2.Checked += new System.Windows.RoutedEventHandler(this.cbGroup_Checked);
            
            #line default
            #line hidden
            
            #line 21 "..\..\UnitSelectView.xaml"
            this.cbGroup2.Unchecked += new System.Windows.RoutedEventHandler(this.cbGroup_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbGroup3 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 22 "..\..\UnitSelectView.xaml"
            this.cbGroup3.Checked += new System.Windows.RoutedEventHandler(this.cbGroup_Checked);
            
            #line default
            #line hidden
            
            #line 22 "..\..\UnitSelectView.xaml"
            this.cbGroup3.Unchecked += new System.Windows.RoutedEventHandler(this.cbGroup_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbGroup4 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 23 "..\..\UnitSelectView.xaml"
            this.cbGroup4.Checked += new System.Windows.RoutedEventHandler(this.cbGroup_Checked);
            
            #line default
            #line hidden
            
            #line 23 "..\..\UnitSelectView.xaml"
            this.cbGroup4.Unchecked += new System.Windows.RoutedEventHandler(this.cbGroup_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

