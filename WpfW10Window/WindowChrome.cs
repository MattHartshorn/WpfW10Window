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
    public class WindowChrome : Control
    {
        public static readonly DependencyProperty WindowCaptionButtonThemeProperty =
            DependencyProperty.Register("WindowCaptionButtonTheme", typeof(WindowCaptionButtonTheme), typeof(W10Window), new PropertyMetadata(WindowCaptionButtonTheme.Darken));

        public static readonly DependencyProperty WindowChromeHeightProperty =
            DependencyProperty.Register("WindowChromeHeight", typeof(double), typeof(W10Window), new PropertyMetadata(30.0));

        static WindowChrome()
        {
            

            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowChrome), new FrameworkPropertyMetadata(typeof(WindowChrome)));
        }
    }
}
