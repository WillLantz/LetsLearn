﻿#pragma checksum "..\..\FinalScore.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1082AABCFEB4FADFF14BDEAE1505239036BF5D2BC59CAC71655E3474CAAA44FA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LetsLearn;
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


namespace LetsLearn {
    
    
    /// <summary>
    /// FinalScore
    /// </summary>
    public partial class FinalScore : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\FinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LetsLearn.FinalScore finalPage;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\FinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fUserLbl;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\FinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fUserAgeLbl;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\FinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fCAnsLbl;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\FinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fIncAnsLbl;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\FinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fCompTimeLbl;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\FinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Home;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\FinalScore.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image fSImage;
        
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
            System.Uri resourceLocater = new System.Uri("/LetsLearn;component/finalscore.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FinalScore.xaml"
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
            this.finalPage = ((LetsLearn.FinalScore)(target));
            return;
            case 2:
            this.fUserLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.fUserAgeLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.fCAnsLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.fIncAnsLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.fCompTimeLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Home = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\FinalScore.xaml"
            this.Home.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.fSImage = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
