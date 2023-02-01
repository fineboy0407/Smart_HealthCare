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

namespace Smart_HealthCare.UserControls
{
    public partial class TextInfo : UserControl
    {
        public TextInfo()
        {
            InitializeComponent();
        }

        public string TextTop
        {
            get { return (string)GetValue(TextTopProperty); }
            set { SetValue(TextTopProperty, value); }
        }
        public static readonly DependencyProperty TextTopProperty = DependencyProperty.Register("TextTop", typeof(string), typeof(TextInfo), new PropertyMetadata());

        public string TextMiddle
        {
            get { return (string)GetValue(TextMiddleProperty); }
            set { SetValue(TextMiddleProperty, value); }
        }
        public static readonly DependencyProperty TextMiddleProperty = DependencyProperty.Register("TextMiddle", typeof(string), typeof(TextInfo), new PropertyMetadata());

        public string TextBottom
        {
            get { return (string)GetValue(TextBottomProperty); }
            set { SetValue(TextBottomProperty, value); }
        }
        public static readonly DependencyProperty TextBottomProperty = DependencyProperty.Register("TextBottom", typeof(string), typeof(TextInfo), new PropertyMetadata());

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }
        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register("IsActive", typeof(bool), typeof(TextInfo), new PropertyMetadata());

    }
}
