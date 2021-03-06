#pragma checksum "..\..\Timer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "71AD9860C68E98E339C564260561CA5E3DF9612E8FCDFB713D334911C549858C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CountdownTimer;
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


namespace CountdownTimer {
    
    
    /// <summary>
    /// Timer
    /// </summary>
    public partial class Timer : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel timerPanel;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Time;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stopButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pauseButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button resumeButton;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SetTimer;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hrSet;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mmSet;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ssSet;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\Timer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TimerStartBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/CountdownTimer;component/timer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Timer.xaml"
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
            this.timerPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.Time = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.stopButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\Timer.xaml"
            this.stopButton.Click += new System.Windows.RoutedEventHandler(this.StopButton);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pauseButton = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\Timer.xaml"
            this.pauseButton.Click += new System.Windows.RoutedEventHandler(this.pauseBtn);
            
            #line default
            #line hidden
            return;
            case 5:
            this.resumeButton = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\Timer.xaml"
            this.resumeButton.Click += new System.Windows.RoutedEventHandler(this.resumeBtn);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 71 "..\..\Timer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Brush);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 79 "..\..\Timer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Face);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 89 "..\..\Timer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Noon);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 97 "..\..\Timer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SteamEgg);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SetTimer = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 11:
            this.hrSet = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            
            #line 113 "..\..\Timer.xaml"
            ((System.Windows.Controls.Primitives.RepeatButton)(target)).Click += new System.Windows.RoutedEventHandler(this.NUDButtonUP_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 114 "..\..\Timer.xaml"
            ((System.Windows.Controls.Primitives.RepeatButton)(target)).Click += new System.Windows.RoutedEventHandler(this.NUDButtonLow_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.mmSet = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            
            #line 131 "..\..\Timer.xaml"
            ((System.Windows.Controls.Primitives.RepeatButton)(target)).Click += new System.Windows.RoutedEventHandler(this.MinUp_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 132 "..\..\Timer.xaml"
            ((System.Windows.Controls.Primitives.RepeatButton)(target)).Click += new System.Windows.RoutedEventHandler(this.MinLow_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.ssSet = ((System.Windows.Controls.TextBox)(target));
            return;
            case 18:
            
            #line 149 "..\..\Timer.xaml"
            ((System.Windows.Controls.Primitives.RepeatButton)(target)).Click += new System.Windows.RoutedEventHandler(this.MinUp_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 150 "..\..\Timer.xaml"
            ((System.Windows.Controls.Primitives.RepeatButton)(target)).Click += new System.Windows.RoutedEventHandler(this.MinLow_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.TimerStartBtn = ((System.Windows.Controls.Button)(target));
            
            #line 165 "..\..\Timer.xaml"
            this.TimerStartBtn.Click += new System.Windows.RoutedEventHandler(this.timeStartButton);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

