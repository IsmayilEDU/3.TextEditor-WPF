using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddAllColorsToPropColors();
            AddAllFontSizesToPropFontSizes();
            AddAllFontsToPropFonts();
            IsBold = false; 
            IsItalic = false;
            IsUnderline = false;
        }


        #region Properties
        public List<string> colors { get; set; }
        public List<string> fontSizes { get; set; }
        public List<string> fonts { get; set; }
        public bool IsBold { get; set; }
        public bool IsItalic{ get; set; }
        public bool IsUnderline{ get; set; }
        #endregion

        #region Functions ( Add data to properties)
        //  Add all colors to property (colors)
        private void AddAllColorsToPropColors()
        {
            colors = new();
            foreach (var color in typeof(Colors).GetProperties())
            {
                colors.Add(color.Name.ToString());
            }
        }

        //  Add all font sizes to property (FontSizes)
        private void AddAllFontSizesToPropFontSizes()
        {
            fontSizes = new() { "8", "10", "12", "14", "16", "18", "20", "22", "24", "28", "32", "48", "72", };
        }

        //  Add all fonts to property (Fonts)
        private void AddAllFontsToPropFonts()
        {
            fonts = new();
            foreach (var font in Fonts.SystemFontFamilies)
            {
                fonts.Add(font.ToString());
            }

        }
        #endregion

        #region Assistent Functions
        private System.Windows.Media.Color GetColor(string name)
        {
            System.Windows.Media.Color color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(name);
            return color;
        }
        #endregion

        #region Loaded Functions
        private void comboboxTextColor_Loaded(object sender, RoutedEventArgs e)
        {
            //  Add all colors to combobox (Text color)
            comboboxTextColor.ItemsSource = colors;

            //  Default color
            comboboxTextColor.Text = colors[7];
        }

        private void comboboxBackgroundColor_Loaded(object sender, RoutedEventArgs e)
        {
            //  Add all colors to combobox (Background color)
            comboboxBackgroundColor.ItemsSource = colors;

            //  Default color
            comboboxBackgroundColor.Text = colors[0];
        }

        private void comboboxFontSize_Loaded(object sender, RoutedEventArgs e)
        {
            //  Add all colors to combobox (Font size)
            comboboxFontSize.ItemsSource = fontSizes;

            //  Default font size
            comboboxFontSize.Text = fontSizes[4];
        }

        private void comboboxFonts_Loaded(object sender, RoutedEventArgs e)
        {
            //  Add all fonts to combobox (Fonts)
            comboboxFonts.ItemsSource = fonts;

            //  Default font size
            comboboxFonts.Text = fonts[0];
        }
        #endregion

        #region Menu Functions
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                textbox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textbox.Text);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        #endregion

        #region Toolbar Functions
        private void Bold_Click(object sender, RoutedEventArgs e)
        {
            IsBold= !IsBold;
            if (IsBold)
            {
                textbox.FontWeight = FontWeights.Bold;
            }
            else
            {
                textbox.FontWeight = FontWeights.Regular;
            }
        }

        private void Italic_Click(object sender, RoutedEventArgs e)
        {
            IsItalic = !IsItalic;
            if (IsItalic)
            {
                textbox.FontStyle = FontStyles.Italic;
            }
            else
            {
                textbox.FontStyle = FontStyles.Normal;
            }
        }

        private void Underline_Click(object sender, RoutedEventArgs e)
        {
            IsUnderline = !IsUnderline;
            if (IsUnderline)
            {
                textbox.TextDecorations = TextDecorations.Underline;
            }
            else
            {
                textbox.TextDecorations = new TextDecorationCollection();
            }
        }

        private void comboboxTextColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textbox.Foreground = new SolidColorBrush(GetColor(comboboxTextColor.SelectedIndex.ToString()));
        }
        
        private void comboboxBackgroundColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textbox.Background = new SolidColorBrush(GetColor(comboboxBackgroundColor.SelectedIndex.ToString()));
        }

        private void comboboxFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textbox.FontSize = double.Parse(comboboxFontSize.SelectedIndex.ToString());
        }
        private void comboboxFonts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textbox.FontFamily = new FontFamily(comboboxFonts.SelectedIndex.ToString());
        }



        #endregion

    }
}
