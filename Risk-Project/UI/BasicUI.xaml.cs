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
        
        private StackPanel e_3;
        
        private TextBlock txtblkOrders;
        
        private ListBox lbxOrders;
        
        private GroupBox e_4;
        
        private StackPanel e_5;
        
        private TextBlock txtblkPlayers;
        
        private ListBox lbxPlayers;
        
        private StackPanel e_6;
        
        private Button btnZoomIn;
        
        private Button btnZoomOut;
        
        private Button btnGame;
        
        private StackPanel e_7;
        
        private TextBlock e_8;
        
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
            this.e_1.Width = 250F;
            this.e_1.HorizontalAlignment = HorizontalAlignment.Left;
            this.e_1.Orientation = Orientation.Vertical;
            Grid.SetRowSpan(this.e_1, 3);
            // e_2 element
            this.e_2 = new GroupBox();
            this.e_1.Children.Add(this.e_2);
            this.e_2.Name = "e_2";
            this.e_2.Background = new SolidColorBrush(new ColorW(23, 23, 23, 191));
            this.e_2.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_2.Foreground = new SolidColorBrush(new ColorW(201, 201, 201, 255));
            // e_3 element
            this.e_3 = new StackPanel();
            this.e_2.Content = this.e_3;
            this.e_3.Name = "e_3";
            this.e_3.Orientation = Orientation.Vertical;
            // txtblkOrders element
            this.txtblkOrders = new TextBlock();
            this.e_3.Children.Add(this.txtblkOrders);
            this.txtblkOrders.Name = "txtblkOrders";
            this.txtblkOrders.Margin = new Thickness(0F, 15F, 0F, 0F);
            this.txtblkOrders.Text = "Orders";
            // lbxOrders element
            this.lbxOrders = new ListBox();
            this.e_3.Children.Add(this.lbxOrders);
            this.lbxOrders.Name = "lbxOrders";
            this.lbxOrders.MinHeight = 250F;
            LinearGradientBrush lbxOrders_Background = new LinearGradientBrush();
            lbxOrders_Background.StartPoint = new PointF(0.5F, 0F);
            lbxOrders_Background.EndPoint = new PointF(0.5F, 1F);
            lbxOrders_Background.SpreadMethod = GradientSpreadMethod.Pad;
            lbxOrders_Background.GradientStops.Add(new GradientStop(new ColorW(126, 126, 126, 255), 0F));
            lbxOrders_Background.GradientStops.Add(new GradientStop(new ColorW(70, 70, 70, 255), 1F));
            this.lbxOrders.Background = lbxOrders_Background;
            Binding binding_lbxOrders_ItemsSource = new Binding("orders");
            this.lbxOrders.SetBinding(ListBox.ItemsSourceProperty, binding_lbxOrders_ItemsSource);
            // e_4 element
            this.e_4 = new GroupBox();
            this.e_1.Children.Add(this.e_4);
            this.e_4.Name = "e_4";
            this.e_4.Margin = new Thickness(0F, 20F, 0F, 0F);
            this.e_4.Background = new SolidColorBrush(new ColorW(23, 23, 23, 191));
            this.e_4.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_4.Foreground = new SolidColorBrush(new ColorW(201, 201, 201, 255));
            // e_5 element
            this.e_5 = new StackPanel();
            this.e_4.Content = this.e_5;
            this.e_5.Name = "e_5";
            this.e_5.Orientation = Orientation.Vertical;
            // txtblkPlayers element
            this.txtblkPlayers = new TextBlock();
            this.e_5.Children.Add(this.txtblkPlayers);
            this.txtblkPlayers.Name = "txtblkPlayers";
            this.txtblkPlayers.Margin = new Thickness(0F, 15F, 0F, 0F);
            this.txtblkPlayers.Text = "Players";
            // lbxPlayers element
            this.lbxPlayers = new ListBox();
            this.e_5.Children.Add(this.lbxPlayers);
            this.lbxPlayers.Name = "lbxPlayers";
            this.lbxPlayers.MinHeight = 250F;
            LinearGradientBrush lbxPlayers_Background = new LinearGradientBrush();
            lbxPlayers_Background.StartPoint = new PointF(0.5F, 0F);
            lbxPlayers_Background.EndPoint = new PointF(0.5F, 1F);
            lbxPlayers_Background.SpreadMethod = GradientSpreadMethod.Pad;
            lbxPlayers_Background.GradientStops.Add(new GradientStop(new ColorW(126, 126, 126, 255), 0F));
            lbxPlayers_Background.GradientStops.Add(new GradientStop(new ColorW(70, 70, 70, 255), 1F));
            this.lbxPlayers.Background = lbxPlayers_Background;
            Binding binding_lbxPlayers_ItemsSource = new Binding("players");
            this.lbxPlayers.SetBinding(ListBox.ItemsSourceProperty, binding_lbxPlayers_ItemsSource);
            // e_6 element
            this.e_6 = new StackPanel();
            this.e_0.Children.Add(this.e_6);
            this.e_6.Name = "e_6";
            this.e_6.Height = 35F;
            this.e_6.Width = 200F;
            this.e_6.Margin = new Thickness(250F, 0F, 0F, 0F);
            this.e_6.HorizontalAlignment = HorizontalAlignment.Left;
            this.e_6.VerticalAlignment = VerticalAlignment.Bottom;
            this.e_6.Orientation = Orientation.Horizontal;
            // btnZoomIn element
            this.btnZoomIn = new Button();
            this.e_6.Children.Add(this.btnZoomIn);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Width = 50F;
            this.btnZoomIn.Content = "+";
            // btnZoomOut element
            this.btnZoomOut = new Button();
            this.e_6.Children.Add(this.btnZoomOut);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Width = 50F;
            this.btnZoomOut.Content = "-";
            // btnGame element
            this.btnGame = new Button();
            this.e_0.Children.Add(this.btnGame);
            this.btnGame.Name = "btnGame";
            this.btnGame.Height = 50F;
            this.btnGame.Width = 200F;
            this.btnGame.HorizontalAlignment = HorizontalAlignment.Right;
            this.btnGame.VerticalAlignment = VerticalAlignment.Bottom;
            // e_7 element
            this.e_7 = new StackPanel();
            this.btnGame.Content = this.e_7;
            this.e_7.Name = "e_7";
            this.e_7.Orientation = Orientation.Horizontal;
            // e_8 element
            this.e_8 = new TextBlock();
            this.e_7.Children.Add(this.e_8);
            this.e_8.Name = "e_8";
            this.e_8.Text = "Game";
        }
    }
}
