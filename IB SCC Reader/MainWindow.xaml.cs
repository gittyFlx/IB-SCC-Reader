using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace IB_SCC_Reader {
    public partial class MainWindow : Window {
        const string CardCodesFilename = @"codes.txt";
        const byte MaxCodes = 1 + 224;// the very last number on the card
        readonly string[] Codes = new string[MaxCodes];
        public MainWindow() {
            InitializeComponent();
            MainWindow1.Left = SystemParameters.PrimaryScreenWidth /2; 
            MainWindow1.Top  = SystemParameters.PrimaryScreenHeight/2;
            ReadCardCodes();
            TextBoxInput1.Focus();
        }
        private void ReadCardCodes() {
            try {
                using (StreamReader SR1 = File.OpenText(CardCodesFilename)) {
                    int i = 0;
                    string line = "???";
                    do {
                        Codes[i] = line.Trim().ToUpper();
                        i += 1;
                    } while (((line = SR1.ReadLine()) != null) & (i < MaxCodes));
                }//using
            } catch (Exception e) { // the most likely error will be file "codes.txt" not found"
                MessageBox.Show(e.Message, "Error Message");
                MainWindow1.Close();
            }//catch
        }
        private void TextBoxesInput_TextChanged(object sender, TextChangedEventArgs e) {
        byte b = 0;
        try {
            b = byte.Parse((sender as TextBox).Text);
        } catch {
        }
        if (b >= MaxCodes) { b = 0; }
        if (sender == TextBoxInput1) {
            LabelOutput1.Content = Codes[b];
        } else {
            LabelOutput2.Content = Codes[b];
        }
        LabelClipboard.Content = (LabelOutput1.Content as String) + (LabelOutput2.Content as String);
        Clipboard.SetData("Text", LabelClipboard.Content);
        }//TextBoxesInput_TextChanged
        private void TextBoxInput1_KeyUp(object sender, System.Windows.Input.KeyEventArgs e) {
          if (e.Key == System.Windows.Input.Key.Enter) { TextBoxInput2.Focus(); }
        }
        private void TextBoxInput2_KeyUp(object sender, System.Windows.Input.KeyEventArgs e) {
          //if (e.Key == System.Windows.Input.Key.Enter) { MainWindow1.WindowState = WindowState.Minimized; }
            if (e.Key == System.Windows.Input.Key.Enter) { MainWindow1.Close(); }
        }
    }//partial class MainWindows
}//namespace IB_SCC_Reader
