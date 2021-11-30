using Microsoft.Win32;
using System;
using System.Collections.Generic;
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


namespace NotepadApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string originalText;
        private void saveAsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //string originalText;
            sfd.Filter = "Text files|*.txt|Project Files|*.csproj|C# files|*.cs|All know|*.txt;*.cs;*.csproj";
            if (sfd.ShowDialog() == true)
            {
                File.WriteAllText(sfd.FileName, textBox.Text);
                MessageBox.Show(sfd.FileName);
                MessageBox.Show(File.ReadAllText(sfd.FileName));
                originalText = textBox.Text;
            }
        }
        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (originalText != textBox.Text)
            {
                MessageBoxResult res = MessageBox.Show("Документ не был сохранен. Вы желаете сохранить изменения в документе?", "NotePad", MessageBoxButton.OK | MessageBoxButton.YesNoCancel);
                if (res == MessageBoxResult.Yes)
                {
                    saveAsMenuItem_Click(sender, e);
                    this.Close();
                }
                if (res  == MessageBoxResult.No)
                {
                    this.Close();
                }
                if (res == MessageBoxResult.Cancel)
                {
                    return;
                }
            }

            if (originalText == textBox.Text)
            {
                this.Close();
            }
        }

        private void openMenuItem_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Text files|*.txt|Project Files|*.csproj|C# files|*.cs|All know|*.txt;*.cs;*.csproj";
            if (ofd.ShowDialog() == true)
            {
                MessageBox.Show(ofd.FileName);
                textBox.Text = File.ReadAllText(ofd.FileName);
            }
        }
        private void copyMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Проверка, что длина выделенного текста более нуля
            if (textBox.SelectionLength > 0)
                // Копирование выделенного текста в буфер обмена
                textBox.Copy();
        }

        private void cutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Текст выбран в текстовом поле
            if (textBox.SelectedText != "")
                // Вырезка выделенного текста и вставка его в буфер обмена
                textBox.Cut();
        }

        private void pasteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Есть ли в буфере обмена какой-либо текст для вставки в текстовое поле
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Выделен ли какой-либо текст в текстовом поле
                if (textBox.SelectionLength > 0)
                {
                    if (MessageBox.Show("Вы хотите вставить поверх текущего выделения?", "Пример", MessageBoxButton.YesNo) == MessageBoxResult.No)
                        textBox.SelectionStart = textBox.SelectionStart + textBox.SelectionLength;
                }
                // Вставка текущего текста из буфера обмена в текстовое поле
                textBox.Paste();
            }
        }

        private void undoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Можно ли отменить последнюю операцию в текстовом поле   
            if (textBox.CanUndo == true)
            {
                // Отменить последнюю операцию
                textBox.Undo();
                // Очистка буфера отмены, чтобы предотвратить повторение последнего действия.
                //textBox.ClearUndo();
            }
        }

        private void redoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            //textBox.Redo();
            // Определяет, можно ли выполнить операцию повтора.
            if (textBox.CanRedo == true)
            {
                    textBox.Redo();
            }
        }
        private void textWrappingMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = sender as MenuItem;
            if (item is null)
                return;
            if (textWrappingMI.IsChecked == true) { textBox.TextWrapping = TextWrapping.Wrap; }
            if (textWrappingMI.IsChecked == false) { textBox.TextWrapping = TextWrapping.NoWrap; }
        }

        private void spellcheckingMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = sender as MenuItem;
            if (item is null)
                return;
            if (textSpellCheckingMI.IsChecked == true) { textBox.SpellCheck.IsEnabled = true; }
            if (textSpellCheckingMI.IsChecked == false) { textBox.SpellCheck.IsEnabled = false; }
        }

        private void selectallMenuItem_Click(object sender, RoutedEventArgs e)
        {
            textBox.SelectAll();
        }

    }
    }


