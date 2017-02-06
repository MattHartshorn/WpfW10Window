using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfW10Window
{
    public class TitleBar : Control
    {
        static TitleBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TitleBar), new FrameworkPropertyMetadata(typeof(TitleBar)));
        }

        #region Dependency Properties
        #region CaptionButtonMode
        public static readonly DependencyProperty CaptionButtonModeProperty =
            DependencyProperty.Register("CaptionButtonMode", typeof(CaptionButtonMode), typeof(TitleBar), new PropertyMetadata(CaptionButtonMode.Darken));

        public CaptionButtonMode CaptionButtonMode
        {
            get { return (CaptionButtonMode)this.GetValue(CaptionButtonModeProperty); }
            set { SetValue(CaptionButtonModeProperty, value); }
        }
        #endregion

        #region CaptionButtonHeight
        public static readonly DependencyProperty CaptionButtonHeightProperty =
            DependencyProperty.Register("CaptionButtonHeight", typeof(double), typeof(TitleBar), new PropertyMetadata(30.0));

        public double CaptionButtonHeight
        {
            get { return (double)this.GetValue(CaptionButtonHeightProperty); }
            set { SetValue(CaptionButtonHeightProperty, value); }
        }
        #endregion

        #region CaptionButtonSize
        public static readonly DependencyProperty CaptionButtonSizeProperty =
            DependencyProperty.Register("CaptionButtonSize", typeof(CaptionButtonSize), typeof(TitleBar), new PropertyMetadata(CaptionButtonSize.Normal));

        public CaptionButtonSize CaptionButtonSize
        {
            get { return (CaptionButtonSize)this.GetValue(CaptionButtonSizeProperty); }
            set { SetValue(CaptionButtonSizeProperty, value); }
        }
        #endregion

        #region HideMinimizeButton
        public static readonly DependencyProperty HideMinimizeButtonProperty =
            DependencyProperty.Register("HideMinimizeButton", typeof(bool), typeof(TitleBar), new PropertyMetadata(false));

        public bool HideMinimizeButton
        {
            get { return (bool)this.GetValue(HideMinimizeButtonProperty); }
            set { SetValue(HideMinimizeButtonProperty, value); }
        }
        #endregion

        #region HideMaximizeButton
        public static readonly DependencyProperty HideMaximizeButtonProperty =
            DependencyProperty.Register("HideMaximizeButton", typeof(bool), typeof(TitleBar), new PropertyMetadata(false));

        public bool HideMaximizeButton
        {
            get { return (bool)this.GetValue(HideMaximizeButtonProperty); }
            set { SetValue(HideMaximizeButtonProperty, value); }
        }
        #endregion

        #region ShowHelpButton
        public static readonly DependencyProperty ShowHelpButtonProperty =
            DependencyProperty.Register("ShowHelpButton", typeof(bool), typeof(TitleBar), new PropertyMetadata(false));

        public bool ShowHelpButton
        {
            get { return (bool)this.GetValue(ShowHelpButtonProperty); }
            set { SetValue(ShowHelpButtonProperty, value); }
        }
        #endregion

        #region Content
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(object), typeof(TitleBar));

        public object Content
        {
            get { return this.GetValue(ContentProperty); }
            set { this.SetValue(ContentProperty, value); }
        }
        #endregion
        #endregion

        #region Protected Fields
        protected CaptionButton CloseButton;

        protected CaptionButton MaximizeButton;

        protected CaptionButton MinimizeButton;

        protected CaptionButton HelpButton;
        #endregion

        #region Events
        public event RoutedEventHandler Close
        {
            add { this.CloseButton.Click += value; }
            remove { this.CloseButton.Click -= value; }
        }

        public event RoutedEventHandler Minimize
        {
            add { this.MinimizeButton.Click += value; }
            remove { this.MinimizeButton.Click -= value; }
        }

        public event RoutedEventHandler Maximize
        {
            add { this.MaximizeButton.Click += value; }
            remove { this.MaximizeButton.Click -= value; }
        }

        public event RoutedEventHandler Help
        {
            add { this.HelpButton.Click += value; }
            remove { this.HelpButton.Click -= value; }
        }
        #endregion

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.CloseButton = (CaptionButton)this.Template.FindName("CloseBtn", this);
            this.MaximizeButton = (CaptionButton)this.Template.FindName("MaximizeBtn", this);
            this.MinimizeButton = (CaptionButton)this.Template.FindName("MinimizeBtn", this);
            this.HelpButton = (CaptionButton)this.Template.FindName("HelpBtn", this);
        }
    }
}
