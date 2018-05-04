// -----------------------------------------------------------
//  
//  This file was generated, please do not modify.
//  
// -----------------------------------------------------------
namespace EmptyKeys.UserInterface.Generated {
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using EmptyKeys.UserInterface;
    using EmptyKeys.UserInterface.Charts;
    using EmptyKeys.UserInterface.Data;
    using EmptyKeys.UserInterface.Controls;
    using EmptyKeys.UserInterface.Controls.Primitives;
    using EmptyKeys.UserInterface.Input;
    using EmptyKeys.UserInterface.Interactions.Core;
    using EmptyKeys.UserInterface.Interactivity;
    using EmptyKeys.UserInterface.Media;
    using EmptyKeys.UserInterface.Media.Effects;
    using EmptyKeys.UserInterface.Media.Animation;
    using EmptyKeys.UserInterface.Media.Imaging;
    using EmptyKeys.UserInterface.Shapes;
    using EmptyKeys.UserInterface.Renderers;
    using EmptyKeys.UserInterface.Themes;
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "3.0.0.0")]
    public sealed class Dictionary : ResourceDictionary {
        
        private static Dictionary singleton = new Dictionary();
        
        public Dictionary() {
            this.InitializeResources();
        }
        
        public static Dictionary Instance {
            get {
                return singleton;
            }
        }
        
        private void InitializeResources() {
            // Resource - [Sounds] SoundSourceCollection
            var r_0_sounds = new SoundSourceCollection();
            SoundManager.Instance.AddSound("Click");
            r_0_sounds.Add(new SoundSource { SoundType = SoundType.ButtonsClick, SoundAsset = "Click", Volume = 1f });
            SoundManager.Instance.AddSound("KeyPress");
            r_0_sounds.Add(new SoundSource { SoundType = SoundType.TextBoxKeyPress, SoundAsset = "KeyPress", Volume = 1f });
            SoundManager.Instance.AddSound("Move");
            r_0_sounds.Add(new SoundSource { SoundType = SoundType.TabControlMove, SoundAsset = "Move", Volume = 1f });
            SoundManager.Instance.AddSound("Select");
            r_0_sounds.Add(new SoundSource { SoundType = SoundType.TabControlSelect, SoundAsset = "Select", Volume = 1f });
            this.Add("Sounds", r_0_sounds);
        }
    }
}
