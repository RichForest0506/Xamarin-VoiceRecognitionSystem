// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace VoiceRecognitionSystem {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class Home : global::Xamarin.Forms.ContentPage {
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.StackLayout iOSLayout;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Button nameButtonStart;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label textLabeliOS;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Button nameButtonStop;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.StackLayout androidLayout;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::VoiceRecognitionSystem.VoiceButton voiceButton;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label textLabelDroid;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(Home));
            iOSLayout = this.FindByName <global::Xamarin.Forms.StackLayout>("iOSLayout");
            nameButtonStart = this.FindByName <global::Xamarin.Forms.Button>("nameButtonStart");
            textLabeliOS = this.FindByName <global::Xamarin.Forms.Label>("textLabeliOS");
            nameButtonStop = this.FindByName <global::Xamarin.Forms.Button>("nameButtonStop");
            androidLayout = this.FindByName <global::Xamarin.Forms.StackLayout>("androidLayout");
            voiceButton = this.FindByName <global::VoiceRecognitionSystem.VoiceButton>("voiceButton");
            textLabelDroid = this.FindByName <global::Xamarin.Forms.Label>("textLabelDroid");
        }
    }
}
