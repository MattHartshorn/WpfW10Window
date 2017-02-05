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
    


    public class W10Window : Window
    {
        static W10Window()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(W10Window), new FrameworkPropertyMetadata(typeof(W10Window)));
        }
    }
}
