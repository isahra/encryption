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

namespace encryption
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

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            string plaintext = (plaintextTXT.Text).ToLower();
            string syphertext="";
            int charcode=0;
            string CHARCODE="";


            for (int i = 0; i < plaintext.Length; i++)
            {
                switch (plaintext[i]){
                    case 'a':
                        charcode = 3;
                        break;
                    case 'b':
                        charcode = 8;
                        break;
                    case 'c':
                        charcode = 16;
                        break;
                    case 'd':
                        charcode = 13;
                        break;
                    case 'e':
                        charcode = 15;
                        break;
                    case 'f':
                        charcode = 7;
                        break;
                    case 'g':
                        charcode = 17;
                        break;
                    case 'h':
                        charcode = 23;
                        break;
                    case 'i':
                        charcode = 2;
                        break;
                    case 'j':
                        charcode = 11;
                        break;
                    case 'k':
                        charcode = 26;
                        break;
                    case 'l':
                        charcode = 6;
                        break;
                    case 'm':
                        charcode = 12;
                        break;
                    case 'n':
                        charcode = 18;
                        break;
                    case 'o':
                        charcode = 19;
                        break;
                    case 'p':
                        charcode = 1;
                        break;
                    case 'q':
                        charcode = 4;
                        break;
                    case 'r':
                        charcode = 20;
                        break;
                    case 's':
                        charcode = 24;
                        break;
                    case 't':
                        charcode = 21;
                        break;
                    case 'u':
                        charcode = 9;
                        break;
                    case 'v':
                        charcode = 14;
                        break;
                    case 'w':
                        charcode = 25;
                        break;
                    case 'x':
                        charcode = 5;
                        break;
                    case 'y':
                        charcode = 22;
                        break;
                    case 'z':
                        charcode = 10;
                        break;
                    case ' ':
                        charcode = 00;
                        break;
                                          
                }
               if (charcode % 2 == 0)
                {
                    
                    CHARCODE = charcode.ToString("00") + "b";
                }
                else
                {
                    
                    CHARCODE = charcode.ToString("00") + "q";

                }


                syphertext += CHARCODE;

            }

            cyphertext.Text += syphertext;
        }

        private void CypherToPlain_Click(object sender, RoutedEventArgs e)
        {
            string syphertext = cyphertext.Text;
            string plaintext = "";
            char CHARCODE =' ';
            string charcode = " ";


           for (int i = 0; i < syphertext.Length; i += 3)
            {

               charcode= syphertext.Substring(i, 3);
                switch (charcode)
                {
                    case "01q":
                        CHARCODE = 'p';
                        break;
                    case "02b":
                        CHARCODE = 'i';
                        break;
                    case "03q":
                        CHARCODE = 'a';
                        break;
                    case "04b":
                        CHARCODE = 'q';
                        break;
                    case "05q":
                        CHARCODE = 'x';
                        break;
                    case "06b":
                        CHARCODE = 'l';
                        break;
                    case "07q":
                        CHARCODE = 'f';
                        break;
                    case "08b":
                        CHARCODE = 'b';
                        break;
                    case "09q":
                        CHARCODE = 'u';
                        break;
                    case "10b":
                        CHARCODE = 'z';
                        break;
                    case "11q":
                        CHARCODE = 'j';
                        break;
                    case "12b":
                        CHARCODE = 'm';
                        break;
                    case "13q":
                        CHARCODE = 'd';
                        break;
                    case "14b":
                        CHARCODE = 'v';
                        break;
                    case "15q":
                        CHARCODE = 'e';
                        break;
                    case "16b":
                        CHARCODE = 'c';
                        break;
                    case "17q":
                        CHARCODE = 'g';
                        break;
                    case "18b":
                        CHARCODE = 'n';
                        break;
                    case "19q":
                        CHARCODE = 'o';
                        break;
                    case "20b":
                        CHARCODE = 'r';
                        break;
                    case "21q":
                        CHARCODE = 't';
                        break;
                    case "22b":
                        CHARCODE = 'y';
                        break;
                    case "23q":
                        CHARCODE = 'h';
                        break;
                    case "24b":
                        CHARCODE = 's';
                        break;
                    case "25q":
                        CHARCODE = 'w';
                        break;
                    case "26b":
                        CHARCODE = 'k';
                        break;
                    case "00":
                        CHARCODE = ' ';
                        break;
                    
                }
                plaintext += CHARCODE;
            }
            plaintextTXT.Text = plaintext;
        }
    }
}
