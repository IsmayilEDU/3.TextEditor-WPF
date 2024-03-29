﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1243B2307DB5B5B8572212B73D90678115C01F51"
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
using TextEditor;


namespace TextEditor {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 79 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboboxTextColor;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboboxBackgroundColor;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboboxFontSize;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboboxFonts;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TextEditor;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 28 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Open_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 29 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 30 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 46 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Bold_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 54 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Italic_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 62 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Underline_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.comboboxTextColor = ((System.Windows.Controls.ComboBox)(target));
            
            #line 81 "..\..\..\MainWindow.xaml"
            this.comboboxTextColor.Loaded += new System.Windows.RoutedEventHandler(this.comboboxTextColor_Loaded);
            
            #line default
            #line hidden
            
            #line 82 "..\..\..\MainWindow.xaml"
            this.comboboxTextColor.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboboxTextColor_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.comboboxBackgroundColor = ((System.Windows.Controls.ComboBox)(target));
            
            #line 98 "..\..\..\MainWindow.xaml"
            this.comboboxBackgroundColor.Loaded += new System.Windows.RoutedEventHandler(this.comboboxBackgroundColor_Loaded);
            
            #line default
            #line hidden
            
            #line 99 "..\..\..\MainWindow.xaml"
            this.comboboxBackgroundColor.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboboxBackgroundColor_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.comboboxFontSize = ((System.Windows.Controls.ComboBox)(target));
            
            #line 115 "..\..\..\MainWindow.xaml"
            this.comboboxFontSize.Loaded += new System.Windows.RoutedEventHandler(this.comboboxFontSize_Loaded);
            
            #line default
            #line hidden
            
            #line 116 "..\..\..\MainWindow.xaml"
            this.comboboxFontSize.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboboxFontSize_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.comboboxFonts = ((System.Windows.Controls.ComboBox)(target));
            
            #line 132 "..\..\..\MainWindow.xaml"
            this.comboboxFonts.Loaded += new System.Windows.RoutedEventHandler(this.comboboxFonts_Loaded);
            
            #line default
            #line hidden
            
            #line 133 "..\..\..\MainWindow.xaml"
            this.comboboxFonts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboboxFonts_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

