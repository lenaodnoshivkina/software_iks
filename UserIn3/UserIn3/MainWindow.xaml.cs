﻿using System;
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

namespace UserIn3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (FontFamily F in Fonts.SystemFontFamilies)
            {
                listBox1.Items.Add(F.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            richTextBox1.Selection.ApplyPropertyValue(FontWeightProperty, FontWeights.Bold);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            richTextBox1.Selection.ApplyPropertyValue(FontStyleProperty, FontStyles.Italic);
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            richTextBox1.Selection.ApplyPropertyValue(FontFamilyProperty,((ListBoxItem)listBox1.SelectedItem).FontFamily);
        }

        private void Slider1_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
#pragma warning disable CS0164 // Отсутствует ссылка на эту метку.
        ValueChanged:
#pragma warning restore CS0164 // Отсутствует ссылка на эту метку.
            try
            {
                richTextBox1.Selection.ApplyPropertyValue(FontSizeProperty, Slider1.Value.ToString());
            }
            catch { }
        }
    }
}