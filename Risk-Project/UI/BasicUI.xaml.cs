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
        
        private GroupBox e_9;
        
        private StackPanel e_10;
        
        private TextBlock txtblkTurns;
        
        private StackPanel e_11;
        
        private Button e_12;
        
        private Button e_15;
        
        private Button e_18;
        
        private Button btnEndTurn;
        
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
            // e_9 element
            this.e_9 = new GroupBox();
            this.e_0.Children.Add(this.e_9);
            this.e_9.Name = "e_9";
            this.e_9.Height = 180F;
            this.e_9.Width = 175F;
            this.e_9.Margin = new Thickness(20F, 20F, 20F, 20F);
            this.e_9.HorizontalAlignment = HorizontalAlignment.Right;
            this.e_9.VerticalAlignment = VerticalAlignment.Top;
            this.e_9.Background = new SolidColorBrush(new ColorW(23, 23, 23, 191));
            this.e_9.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_9.Foreground = new SolidColorBrush(new ColorW(201, 201, 201, 255));
            // e_10 element
            this.e_10 = new StackPanel();
            this.e_9.Content = this.e_10;
            this.e_10.Name = "e_10";
            this.e_10.Orientation = Orientation.Vertical;
            // txtblkTurns element
            this.txtblkTurns = new TextBlock();
            this.e_10.Children.Add(this.txtblkTurns);
            this.txtblkTurns.Name = "txtblkTurns";
            this.txtblkTurns.Margin = new Thickness(20F, 20F, 20F, 20F);
            this.txtblkTurns.HorizontalAlignment = HorizontalAlignment.Center;
            this.txtblkTurns.VerticalAlignment = VerticalAlignment.Top;
            this.txtblkTurns.Text = "Turn 1";
            // e_11 element
            this.e_11 = new StackPanel();
            this.e_10.Children.Add(this.e_11);
            this.e_11.Name = "e_11";
            this.e_11.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_11.Orientation = Orientation.Horizontal;
            // e_12 element
            this.e_12 = new Button();
            this.e_11.Children.Add(this.e_12);
            this.e_12.Name = "e_12";
            this.e_12.Height = 40F;
            this.e_12.Width = 40F;
            this.e_12.Margin = new Thickness(5F, 5F, 5F, 5F);
            Func<UIElement, UIElement> e_12_ctFunc = e_12_ctMethod;
            ControlTemplate e_12_ct = new ControlTemplate(typeof(Button), e_12_ctFunc);
            this.e_12.Template = e_12_ct;
            this.e_12.Content = "O";
            // e_15 element
            this.e_15 = new Button();
            this.e_11.Children.Add(this.e_15);
            this.e_15.Name = "e_15";
            this.e_15.Height = 40F;
            this.e_15.Width = 40F;
            this.e_15.Margin = new Thickness(5F, 5F, 5F, 5F);
            Func<UIElement, UIElement> e_15_ctFunc = e_15_ctMethod;
            ControlTemplate e_15_ct = new ControlTemplate(typeof(Button), e_15_ctFunc);
            this.e_15.Template = e_15_ct;
            this.e_15.Content = "+";
            // e_18 element
            this.e_18 = new Button();
            this.e_11.Children.Add(this.e_18);
            this.e_18.Name = "e_18";
            this.e_18.Height = 40F;
            this.e_18.Width = 40F;
            this.e_18.Margin = new Thickness(5F, 5F, 5F, 5F);
            Func<UIElement, UIElement> e_18_ctFunc = e_18_ctMethod;
            ControlTemplate e_18_ct = new ControlTemplate(typeof(Button), e_18_ctFunc);
            this.e_18.Template = e_18_ct;
            this.e_18.Content = "->";
            // btnEndTurn element
            this.btnEndTurn = new Button();
            this.e_10.Children.Add(this.btnEndTurn);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Height = 40F;
            this.btnEndTurn.Margin = new Thickness(15F, 15F, 15F, 15F);
            this.btnEndTurn.Content = "End Turn";
        }
        
        private static UIElement e_12_ctMethod(UIElement parent) {
            // e_13 element
            Grid e_13 = new Grid();
            e_13.Parent = parent;
            e_13.Name = "e_13";
            // e_14 element
            Ellipse e_14 = new Ellipse();
            e_13.Children.Add(e_14);
            e_14.Name = "e_14";
            e_14.Fill = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_14.Stroke = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            e_14.StrokeThickness = 0F;
            return e_13;
        }
        
        private static UIElement e_15_ctMethod(UIElement parent) {
            // e_16 element
            Grid e_16 = new Grid();
            e_16.Parent = parent;
            e_16.Name = "e_16";
            // e_17 element
            Ellipse e_17 = new Ellipse();
            e_16.Children.Add(e_17);
            e_17.Name = "e_17";
            e_17.Fill = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_17.Stroke = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            e_17.StrokeThickness = 0F;
            return e_16;
        }
        
        private static UIElement e_18_ctMethod(UIElement parent) {
            // e_19 element
            Grid e_19 = new Grid();
            e_19.Parent = parent;
            e_19.Name = "e_19";
            // e_20 element
            Ellipse e_20 = new Ellipse();
            e_19.Children.Add(e_20);
            e_20.Name = "e_20";
            e_20.Fill = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            e_20.Stroke = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            e_20.StrokeThickness = 0F;
            return e_19;
        }
    }
}
