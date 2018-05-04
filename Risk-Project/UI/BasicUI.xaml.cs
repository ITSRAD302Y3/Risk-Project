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
    public partial class BasicUI : UIRoot {
        
        private Grid e_0;
        
        private StackPanel e_1;
        
        private GroupBox e_2;
        
        private ListBox lbxOrders;
        
        private GroupBox e_3;
        
        private ListBox lbxPlayers;
        
        private Button btnGame;
        
        public BasicUI() : 
                base() {
            this.Initialize();
        }
        
        public BasicUI(int width, int height) : 
                base(width, height) {
            this.Initialize();
        }
        
        private void Initialize() {
            Style style = RootStyle.CreateRootStyle();
            style.TargetType = this.GetType();
            this.Style = style;
            this.InitializeComponent();
        }
        
        private void InitializeComponent() {
            this.Background = new SolidColorBrush(new ColorW(255, 255, 255, 0));
            // e_0 element
            this.e_0 = new Grid();
            this.Content = this.e_0;
            this.e_0.Name = "e_0";
            // e_1 element
            this.e_1 = new StackPanel();
            this.e_0.Children.Add(this.e_1);
            this.e_1.Name = "e_1";
            this.e_1.Width = 300F;
            this.e_1.HorizontalAlignment = HorizontalAlignment.Left;
            this.e_1.Orientation = Orientation.Vertical;
            Grid.SetRowSpan(this.e_1, 3);
            // e_2 element
            this.e_2 = new GroupBox();
            this.e_1.Children.Add(this.e_2);
            this.e_2.Name = "e_2";
            this.e_2.Width = 300F;
            this.e_2.Background = new SolidColorBrush(new ColorW(23, 23, 23, 191));
            this.e_2.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_2.Foreground = new SolidColorBrush(new ColorW(201, 201, 201, 255));
            this.e_2.Header = "Orders";
            // lbxOrders element
            this.lbxOrders = new ListBox();
            this.e_2.Content = this.lbxOrders;
            this.lbxOrders.Name = "lbxOrders";
            this.lbxOrders.MinHeight = 300F;
            LinearGradientBrush lbxOrders_Background = new LinearGradientBrush();
            lbxOrders_Background.StartPoint = new PointF(0.5F, 0F);
            lbxOrders_Background.EndPoint = new PointF(0.5F, 1F);
            lbxOrders_Background.SpreadMethod = GradientSpreadMethod.Pad;
            lbxOrders_Background.GradientStops.Add(new GradientStop(new ColorW(126, 126, 126, 255), 0F));
            lbxOrders_Background.GradientStops.Add(new GradientStop(new ColorW(70, 70, 70, 255), 1F));
            this.lbxOrders.Background = lbxOrders_Background;
            Binding binding_lbxOrders_ItemsSource = new Binding("orders");
            this.lbxOrders.SetBinding(ListBox.ItemsSourceProperty, binding_lbxOrders_ItemsSource);
            // e_3 element
            this.e_3 = new GroupBox();
            this.e_1.Children.Add(this.e_3);
            this.e_3.Name = "e_3";
            this.e_3.Width = 300F;
            this.e_3.Background = new SolidColorBrush(new ColorW(23, 23, 23, 191));
            this.e_3.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_3.Foreground = new SolidColorBrush(new ColorW(201, 201, 201, 255));
            this.e_3.Header = "Players";
            // lbxPlayers element
            this.lbxPlayers = new ListBox();
            this.e_3.Content = this.lbxPlayers;
            this.lbxPlayers.Name = "lbxPlayers";
            this.lbxPlayers.MinHeight = 300F;
            LinearGradientBrush lbxPlayers_Background = new LinearGradientBrush();
            lbxPlayers_Background.StartPoint = new PointF(0.5F, 0F);
            lbxPlayers_Background.EndPoint = new PointF(0.5F, 1F);
            lbxPlayers_Background.SpreadMethod = GradientSpreadMethod.Pad;
            lbxPlayers_Background.GradientStops.Add(new GradientStop(new ColorW(126, 126, 126, 255), 0F));
            lbxPlayers_Background.GradientStops.Add(new GradientStop(new ColorW(70, 70, 70, 255), 1F));
            this.lbxPlayers.Background = lbxPlayers_Background;
            Binding binding_lbxPlayers_ItemsSource = new Binding("players");
            this.lbxPlayers.SetBinding(ListBox.ItemsSourceProperty, binding_lbxPlayers_ItemsSource);
            // btnGame element
            this.btnGame = new Button();
            this.e_0.Children.Add(this.btnGame);
            this.btnGame.Name = "btnGame";
            this.btnGame.Height = 50F;
            this.btnGame.Width = 200F;
            this.btnGame.HorizontalAlignment = HorizontalAlignment.Right;
            this.btnGame.VerticalAlignment = VerticalAlignment.Bottom;
            this.btnGame.Background = new SolidColorBrush(new ColorW(95, 253, 95, 255));
            this.btnGame.BorderBrush = new SolidColorBrush(new ColorW(31, 31, 31, 255));
            this.btnGame.Content = "Game";
        }
    }
}
