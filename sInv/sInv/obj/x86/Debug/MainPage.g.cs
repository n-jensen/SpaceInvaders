﻿#pragma checksum "C:\Users\Noel\source\repos\SInv\sInv\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F0FC6910BEF6FBEE1F69C07E6816F37C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sInv
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 13
                {
                    global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl element2 = (global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl)(target);
                    ((global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl)element2).Draw += this.canvasControl_Draw;
                    ((global::Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl)element2).Loaded += this.CanvasControl_Loaded;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

