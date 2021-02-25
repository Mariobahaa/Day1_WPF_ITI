using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace P1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void SetText_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "Replace default text with initial text value";
        }

        private void SelectAll_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Focus();
            TextBox1.SelectAll();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
        }

        private void Prepend_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "***Prepended Text****" + TextBox1.Text;
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Focus();

            var cur = TextBox1.SelectionStart;
            TextBox1.Text = TextBox1.Text.Insert(cur, "***Inserted Text***");
        }

        private void Append_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "***Appended Text***";
        }

        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Cut();
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Paste();
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Undo();
        }

        private void RadioButton_Checked1(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)(sender)).Content.ToString())
            {
                case "Editable":
                    TextBox1.IsReadOnly = false;
                break;
                case "Read Only":
                    TextBox1.IsReadOnly = true;
                break;

            }
        }

        private void RadioButton_Checked2(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)(sender)).Content.ToString())
            {
                case "Left":
                    TextBox1.TextAlignment = TextAlignment.Left;
                    break;
                case "Center":
                    TextBox1.TextAlignment = TextAlignment.Center;
                    break;
                case "Right":
                    TextBox1.TextAlignment = TextAlignment.Right;
                    break;

            }
        }
    }
}
