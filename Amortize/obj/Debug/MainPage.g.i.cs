﻿#pragma checksum "C:\Users\Don\Documents\GitHub\Amortize\Amortize\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "50FF82EC6D11C707423233F3FC0AE75C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Amortize {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock PaymentAmount;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox Amount;
        
        internal System.Windows.Controls.TextBox DownPayment;
        
        internal System.Windows.Controls.TextBox InterestRate;
        
        internal System.Windows.Controls.TextBox Term;
        
        internal System.Windows.Controls.Button Calculate;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Amortize;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.PaymentAmount = ((System.Windows.Controls.TextBlock)(this.FindName("PaymentAmount")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Amount = ((System.Windows.Controls.TextBox)(this.FindName("Amount")));
            this.DownPayment = ((System.Windows.Controls.TextBox)(this.FindName("DownPayment")));
            this.InterestRate = ((System.Windows.Controls.TextBox)(this.FindName("InterestRate")));
            this.Term = ((System.Windows.Controls.TextBox)(this.FindName("Term")));
            this.Calculate = ((System.Windows.Controls.Button)(this.FindName("Calculate")));
        }
    }
}

