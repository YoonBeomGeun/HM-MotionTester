﻿#pragma checksum "..\..\..\..\Views\MainView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23C617FA2B26C0A719D3F3FB1CCF7780513E14A6"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Core;
using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Mvvm.UI.ModuleInjection;
using DevExpress.Xpf.Accordion;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.ConditionalFormatting;
using DevExpress.Xpf.Core.DataSources;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Core.ServerMode;
using DevExpress.Xpf.DXBinding;
using DevExpress.Xpf.Data;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Docking.Base;
using DevExpress.Xpf.Navigation;
using DevExpress.Xpf.WindowsUI;
using DevExpress.Xpf.WindowsUI.Navigation;
using HMMotionTester.ViewModels;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace HMMotionTester.Views {
    
    
    /// <summary>
    /// MainView
    /// </summary>
    public partial class MainView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel BaseDockPanel;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Navigation.TileBar MenuBar;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ErrorText;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.WindowsUI.AppBar appBar;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SeqPanel;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Docking.DockLayoutManager dockLayoutManager;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Docking.DockingDocumentUIService WorkspaceDocumentManagerService;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Accordion.AccordionControl accordion;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel MotionPanel;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Moving_Axis;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CoordinatesGrid;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UsingAxisCount;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CoordinateAxis1;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TransferAixs1;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CoordinateAxis2;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TransferAxis2;
        
        #line default
        #line hidden
        
        
        #line 241 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CoordinateAxis3;
        
        #line default
        #line hidden
        
        
        #line 242 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ZMoveAxis;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SyncMaster1;
        
        #line default
        #line hidden
        
        
        #line 258 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SyncMaster2;
        
        #line default
        #line hidden
        
        
        #line 263 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SyncMaster3;
        
        #line default
        #line hidden
        
        
        #line 270 "..\..\..\..\Views\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl MotionContentControl;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HMMotionTester;component/views/mainview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\MainView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BaseDockPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.MenuBar = ((DevExpress.Xpf.Navigation.TileBar)(target));
            return;
            case 3:
            this.ErrorText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.appBar = ((DevExpress.Xpf.WindowsUI.AppBar)(target));
            return;
            case 5:
            
            #line 99 "..\..\..\..\Views\MainView.xaml"
            ((DevExpress.Xpf.WindowsUI.AppBarButton)(target)).Click += new System.Windows.RoutedEventHandler(this.StartButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 101 "..\..\..\..\Views\MainView.xaml"
            ((DevExpress.Xpf.WindowsUI.AppBarButton)(target)).Click += new System.Windows.RoutedEventHandler(this.StopButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 103 "..\..\..\..\Views\MainView.xaml"
            ((DevExpress.Xpf.WindowsUI.AppBarButton)(target)).Click += new System.Windows.RoutedEventHandler(this.ReStartButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SeqPanel = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.dockLayoutManager = ((DevExpress.Xpf.Docking.DockLayoutManager)(target));
            return;
            case 10:
            this.WorkspaceDocumentManagerService = ((DevExpress.Xpf.Docking.DockingDocumentUIService)(target));
            return;
            case 11:
            this.accordion = ((DevExpress.Xpf.Accordion.AccordionControl)(target));
            return;
            case 12:
            this.MotionPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 13:
            this.Moving_Axis = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 14:
            this.CoordinatesGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 15:
            this.UsingAxisCount = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 16:
            this.CoordinateAxis1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 17:
            this.TransferAixs1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 18:
            this.CoordinateAxis2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 19:
            this.TransferAxis2 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 20:
            this.CoordinateAxis3 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 21:
            this.ZMoveAxis = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 22:
            this.SyncMaster1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 23:
            this.SyncMaster2 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 24:
            this.SyncMaster3 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 25:
            this.MotionContentControl = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

