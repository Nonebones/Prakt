﻿#pragma checksum "..\..\..\..\View\Windows\AdminWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "75CBA5BE73483A70048A3F87CF5C7C934BBE1689414E94081294BE38DB32580F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Basic.View.Windows;
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


namespace Basic.View.Windows {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\View\Windows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoadSomePage;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\Windows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoadUsers;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\View\Windows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbID;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\View\Windows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbFirstName;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\Windows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMiddleName;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\Windows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbLastName;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\Windows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDateOfBirth;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\View\Windows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSalary;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\View\Windows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddUser;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\View\Windows\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame mainFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/Basic;component/view/windows/adminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Windows\AdminWindow.xaml"
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
            this.btnLoadSomePage = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\View\Windows\AdminWindow.xaml"
            this.btnLoadSomePage.Click += new System.Windows.RoutedEventHandler(this.btnLoadSomePage_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnLoadUsers = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\View\Windows\AdminWindow.xaml"
            this.btnLoadUsers.Click += new System.Windows.RoutedEventHandler(this.btnLoadUsers_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbMiddleName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tbDateOfBirth = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbSalary = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnAddUser = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\View\Windows\AdminWindow.xaml"
            this.btnAddUser.Click += new System.Windows.RoutedEventHandler(this.btnAddUser_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.mainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

