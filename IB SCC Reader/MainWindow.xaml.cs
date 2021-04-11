////////////////////////////////////////////////////////////////////////////
//
//  Interactive Brokers Security Code Card Reader
//
//  What does it do?
//    During login to IB, it speeds up the tedious task of looking up the
//    two numbers on the security code card and typing of the respective
//    code combination.
//  How does it work?
//    Before first use, create text file "codes.txt" and (only once) enter
//    all 224 codes. One per line, 224 lines. Only the codes, without the
//    line numbers. Like here:    ____________
//                               |T9G
//                               |NL7
//                               |3QS
//                               |...
//    Put "codes.txt" in the same directory as this program's .exe file.
//    When during the login process prompted for the codes of the two
//    numbers displayed, start this little program and type in the 1st
//    number <enter> and the 2nd number <enter>. The program closes but the
//    resulting code is now in the clipboard. Paste it into the login field
//    with the keyboard combination Ctrl-v (paste) and continue login to IB.
//
////////////////////////////////////////////////////////////////////////////
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace IB_SCC_Reader {
    public partial class MainWindow : Window {
        const string CardCodesFilename = @"codes.txt";
        const byte MaxCodes = 1 + 224;// the very last number on the card
        string[] Codes = new string[MaxCodes];
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
