using System.Windows;
using System.Windows.Controls;

namespace Smart_HealthCare.UserControls
{
    public partial class InfoCard : UserControl
    {
        public InfoCard()
        {
            InitializeComponent();
        }
 
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static DependencyProperty TitleProperty = DependencyProperty.Register("Title",typeof(string), typeof(InfoCard), new PropertyMetadata(null));
        public string Desc
        {
            get { return (string)GetValue(DescProperty); }
            set { SetValue(DescProperty, value); }
        }
        public static DependencyProperty DescProperty = DependencyProperty.Register("Desc", typeof(string), typeof(InfoCard), new PropertyMetadata(null));

        public string Percentage
        {
            get { return (string)GetValue(PercentageProperty); }
            set { SetValue(PercentageProperty, value); }
        }
        public static DependencyProperty PercentageProperty = DependencyProperty.Register("Percentage", typeof(string), typeof(InfoCard), new PropertyMetadata(null));

        public string BottomText
        {
            get { return (string)GetValue(BottomTextProperty); }
            set { SetValue(BottomTextProperty, value); }
        }
        public static DependencyProperty BottomTextProperty = DependencyProperty.Register("BottomText", typeof(string), typeof(InfoCard), new PropertyMetadata(null));

        public string Days
        {
            get { return (string)GetValue(DaysProperty); }
            set { SetValue(DaysProperty, value); }
        }
        public static DependencyProperty DaysProperty = DependencyProperty.Register("Days", typeof(string), typeof(InfoCard), new PropertyMetadata(null));

        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }
        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(InfoCard), new PropertyMetadata(null));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }
        public static DependencyProperty IsActiveProperty = DependencyProperty.Register("IsActive", typeof(bool), typeof(InfoCard), new PropertyMetadata(null));

        public MahApps.Metro.IconPacks.PackIconMaterialKind Icon
        {
            get { return (MahApps.Metro.IconPacks.PackIconMaterialKind)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(MahApps.Metro.IconPacks.PackIconMaterialKind), typeof(InfoCard), new PropertyMetadata(null));

    }
}
