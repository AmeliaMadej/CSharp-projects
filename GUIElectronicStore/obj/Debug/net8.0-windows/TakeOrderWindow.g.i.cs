﻿#pragma checksum "..\..\..\TakeOrderWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2521C98E6CC6F3E142F4E86409B6323C1BBDF831"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using GUIProjekt;
using System;
using System.Diagnostics;
using System.Media;
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


namespace GUIProjekt {
    
    
    /// <summary>
    /// TakeOrderWindow
    /// </summary>
    public partial class TakeOrderWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\TakeOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox producerCB;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\TakeOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox categoryCB;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\TakeOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox productCB;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\TakeOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quantityTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\TakeOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addToReceiptBtn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\TakeOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeFromReceiptBtn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\TakeOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sortReceiptUpBtn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\TakeOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sortReceiptDownBtn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\TakeOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox receiptTxtBl;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\TakeOrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button orderBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GUIElectronicStore;V1.0.0.0;component/takeorderwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TakeOrderWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.producerCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\TakeOrderWindow.xaml"
            this.producerCB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.categoryCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 16 "..\..\..\TakeOrderWindow.xaml"
            this.categoryCB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.productCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\..\TakeOrderWindow.xaml"
            this.productCB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.quantityTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\TakeOrderWindow.xaml"
            this.quantityTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.addToReceiptBtn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\TakeOrderWindow.xaml"
            this.addToReceiptBtn.Click += new System.Windows.RoutedEventHandler(this.AddToReceipt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.removeFromReceiptBtn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\TakeOrderWindow.xaml"
            this.removeFromReceiptBtn.Click += new System.Windows.RoutedEventHandler(this.RemoveFromReceipt_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.sortReceiptUpBtn = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\TakeOrderWindow.xaml"
            this.sortReceiptUpBtn.Click += new System.Windows.RoutedEventHandler(this.SortReceipt_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.sortReceiptDownBtn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\TakeOrderWindow.xaml"
            this.sortReceiptDownBtn.Click += new System.Windows.RoutedEventHandler(this.SortReceipt_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.receiptTxtBl = ((System.Windows.Controls.ListBox)(target));
            return;
            case 10:
            this.orderBtn = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\TakeOrderWindow.xaml"
            this.orderBtn.Click += new System.Windows.RoutedEventHandler(this.Order_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 38 "..\..\..\TakeOrderWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Return_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
