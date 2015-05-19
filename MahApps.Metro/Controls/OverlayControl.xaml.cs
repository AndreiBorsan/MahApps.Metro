using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MahApps.Metro.Controls
{
    /// <summary>
    /// Interaction logic for OverlayControl.xaml
    /// </summary>
    public partial class OverlayControl : UserControl
    {
        #region Constructors & Inits

        /// <summary>
        /// Creates and instance of the control
        /// </summary>
        public OverlayControl()
        {
            InitializeComponent();

            DataContext = this;
        }

        #endregion

        #region Dependency properties

        /// <summary>
        /// Sets or gets the opacity of the control
        /// </summary>
        public double OverlayOpacity
        {
            get { return (double) GetValue(OverlayOpacityProperty); }
            set { SetValue(OverlayOpacityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OpacityValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OverlayOpacityProperty =
            DependencyProperty.Register("OverlayOpacity", typeof (double), typeof (OverlayControl),
                new PropertyMetadata(default(double)));

        /// <summary>
        /// Sets or gets the background color of the control
        /// </summary>
        public Brush OverlayBackground
        {
            get { return (Brush) GetValue(OverlayBackgroundProperty); }
            set { SetValue(OverlayBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OverlayBackgroundProperty =
            DependencyProperty.Register("OverlayBackground", typeof (Brush), typeof (OverlayControl),
                new PropertyMetadata(default(Brush)));

        /// <summary>
        /// Sets or gets the foreground color of the text of the control
        /// </summary>
        public Brush OverlayForeground
        {
            get { return (Brush) GetValue(OverlayForegroundProperty); }
            set { SetValue(OverlayForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ForegroundColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OverlayForegroundProperty =
            DependencyProperty.Register("OverlayForeground", typeof (Brush), typeof (OverlayControl),
                new PropertyMetadata(default(Brush)));

        /// <summary>
        /// Sets or gets the text displayed on the control
        /// </summary>
        public string OverlayText
        {
            get { return (string) GetValue(OverlayTextProperty); }
            set { SetValue(OverlayTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OverlayText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OverlayTextProperty =
            DependencyProperty.Register("OverlayText", typeof (string), typeof (OverlayControl),
                new PropertyMetadata(default(string)));

        /// <summary>
        /// Sets or gets the font size of the text of the control
        /// </summary>
        public double OverlayFontSize
        {
            get { return (double) GetValue(OverlayFontSizeProperty); }
            set { SetValue(OverlayFontSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OverlayFontSize.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OverlayFontSizeProperty =
            DependencyProperty.Register("OverlayFontSize", typeof (double), typeof (OverlayControl),
                new PropertyMetadata(default(double)));

        /// <summary>
        /// Sets or gets the font weight of the text of the control
        /// </summary>
        public FontWeight OverlayFontWeight
        {
            get { return (FontWeight) GetValue(OverlayFontWeightProperty); }
            set { SetValue(OverlayFontWeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OverlayFontWeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OverlayFontWeightProperty =
            DependencyProperty.Register("OverlayFontWeight", typeof (FontWeight), typeof (OverlayControl),
                new PropertyMetadata(default(FontWeight)));

        /// <summary>
        /// Sets or gets the visibility of the progress ring
        /// </summary>
        public bool IsOverlayProgressRingVisible
        {
            get { return (bool)GetValue(IsOverlayProgressRingVisibleProperty); }
            set { SetValue(IsOverlayProgressRingVisibleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsOverlayProgressRingVisible.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsOverlayProgressRingVisibleProperty =
            DependencyProperty.Register("IsOverlayProgressRingVisible", typeof(bool), typeof(OverlayControl),
                new PropertyMetadata(default(bool)));

        #endregion
    }
}
