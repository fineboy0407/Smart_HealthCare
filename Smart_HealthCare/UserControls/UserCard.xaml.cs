using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Smart_HealthCare.UserControls
{
    /// <summary>
    /// Interaction logic for UserCard.xaml
    /// </summary>
    public partial class UserCard : UserControl
    {
        public UserCard()
        {
            InitializeComponent();
        }

        public string FullName
        {
            get { return (string)GetValue(FullNameProperty); }
            set { SetValue(FullNameProperty, value); }
        }

        public static DependencyProperty FullNameProperty = DependencyProperty.Register("FullName", typeof(string), typeof(UserCard), new PropertyMetadata(null));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(UserCard), new PropertyMetadata(null));
        public string Time
        {
            get { return (string)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }

        public static DependencyProperty TimeProperty = DependencyProperty.Register("Time", typeof(string), typeof(UserCard), new PropertyMetadata(null));

        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static DependencyProperty ImageProperty = DependencyProperty.Register("Image", typeof(ImageSource), typeof(UserCard), new PropertyMetadata(null));
        public bool isActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        public static DependencyProperty IsActiveProperty = DependencyProperty.Register("IsActive", typeof(string), typeof(UserCard), new PropertyMetadata(null));
        
    }
}
