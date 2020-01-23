﻿#pragma checksum "..\..\..\InsertNewExam.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9DE1A20C5A5BD20A97BBBCA1B39C89F3874CB064"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using MedicalExams;
using Notifications.Wpf.Controls;
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


namespace MedicalExams {
    
    
    /// <summary>
    /// InsertNewExam
    /// </summary>
    public partial class InsertNewExam : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\InsertNewExam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserNumber;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\InsertNewExam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserName;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\InsertNewExam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker UserDateOfBirth;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\InsertNewExam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TotalSelectedExamsText;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\InsertNewExam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ExamsListBox;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\InsertNewExam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Notifications.Wpf.Controls.NotificationArea WindowArea;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\InsertNewExam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearButton;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\InsertNewExam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MedicalExams;component/insertnewexam.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\InsertNewExam.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UserNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\InsertNewExam.xaml"
            this.UserNumber.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.UserNumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UserName = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\InsertNewExam.xaml"
            this.UserName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.UserNameValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UserDateOfBirth = ((System.Windows.Controls.DatePicker)(target));
            
            #line 44 "..\..\..\InsertNewExam.xaml"
            this.UserDateOfBirth.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.UserDateOfBirthValidationDatePicker);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TotalSelectedExamsText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.ExamsListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 64 "..\..\..\InsertNewExam.xaml"
            this.ExamsListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ExamsListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.WindowArea = ((Notifications.Wpf.Controls.NotificationArea)(target));
            return;
            case 7:
            this.ClearButton = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\InsertNewExam.xaml"
            this.ClearButton.Click += new System.Windows.RoutedEventHandler(this.ClearButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\..\InsertNewExam.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
