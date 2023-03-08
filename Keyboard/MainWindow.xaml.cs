using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Forms;
using System.Windows.Shapes;
using System.Drawing;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using System.Threading;

namespace Keyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TB1.Text = "";
            
        }
       
        
        int fails = 0;
        int Difficulty_value = 1;
        int Case = 0;

        bool CpsL = false;
        

        private const int TimeToSleep = 100;
        private const int N = 1;
        int pos = 0;

        
        

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        public void Refresh_Keys(bool CpsL)
        {
            if (CpsL == false)
            {
                b1.Content = "`";
                b2.Content = "1";
                b3.Content = "2";
                b4.Content = "3";
                b5.Content = "4";
                b6.Content = "5";
                b7.Content = "6";
                b8.Content = "7";
                b9.Content = "8";
                b10.Content = "9";
                b11.Content = "0";
                b12.Content = "-";
                b13.Content = "=";
                
                c2.Content = "q";
                c3.Content = "w";
                c4.Content = "e";
                c5.Content = "r";
                c6.Content = "t";
                c7.Content = "y";
                c8.Content = "u";
                c9.Content = "i";
                c10.Content = "o";
                c11.Content = "p";
                c12.Content = "[";
                c13.Content = "]";
                c14.Content = "\\";

                f1.Content = "a";
                f2.Content = "s";
                f3.Content = "d";
                f4.Content = "f";
                f5.Content = "g";
                f6.Content = "h";
                f7.Content = "j";
                f8.Content = "k";
                f9.Content = "l";
                f10.Content = ";";
                f11.Content = "'";

                y1.Content = "z";
                y2.Content = "x";
                y3.Content = "c";
                y4.Content = "v";
                y5.Content = "b";
                y6.Content = "n";
                y7.Content = "m";
                y8.Content = ",";
                y9.Content = ".";
                y10.Content = "/";




            }
            else
            {
                b1.Content = "~";
                b2.Content = "!";
                b3.Content = "@";
                b4.Content = "#";
                b5.Content = "$";
                b6.Content = "%";
                b7.Content = "^";
                b8.Content = "&";
                b9.Content = "*";
                b10.Content = "(";
                b11.Content = ")";
                b12.Content = "_";
                b13.Content = "+";

                c2.Content = "Q";
                c3.Content = "W";
                c4.Content = "E";
                c5.Content = "R";
                c6.Content = "T";
                c7.Content = "Y";
                c8.Content = "U";
                c9.Content = "I";
                c10.Content = "O";
                c11.Content = "P";
                c12.Content = "{";
                c13.Content = "}";
                c14.Content = "|";

                f1.Content = "A";
                f2.Content = "S";
                f3.Content = "D";
                f4.Content = "F";
                f5.Content = "G";
                f6.Content = "H";
                f7.Content = "J";
                f8.Content = "K";
                f9.Content = "L";
                f10.Content = ":";
                f11.Content = "\"";

                y1.Content = "Z";
                y2.Content = "X";
                y3.Content = "C";
                y4.Content = "V";
                y5.Content = "B";
                y6.Content = "N";
                y7.Content = "M";
                y8.Content = "<";
                y9.Content = ">";
                y10.Content = "?";
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {


            



        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if(TB1.Text != "")
            { 
            //TB1.Text = e.Key.ToString();
            if (e.Key == Key.Capital)
            {
                
                switch (CpsL)
                {
                    case true:
                        CpsL = false;
                        Refresh_Keys(CpsL);
                        Caps.Background = new SolidColorBrush(Colors.LightGray);
                        break;

                    case false:
                        CpsL = true;
                        Refresh_Keys(CpsL);
                        Caps.Background = new SolidColorBrush(Colors.DarkGray);
                        break;

                }
              
            }
           
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                CpsL = true;
                Refresh_Keys(CpsL);
                LShift.Background = new SolidColorBrush(Colors.DarkGray);
                RShift.Background = new SolidColorBrush(Colors.DarkGray);
            }
            if (e.Key == Key.D1)
            {
                //ColorAnimation animation;
                //animation = new ColorAnimation();
                //animation.From = Colors.Gray;
                //animation.To = Colors.HotPink;
                //animation.Duration = new Duration(TimeSpan.FromSeconds(1));
                //this.b2.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                b2.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.HotPink, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                b2.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == b2.Content.ToString())
                {
                    TB2.Text += b2.Content;
                    pos++;
                }
                else {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
               

            }
            if (e.Key == Key.D2)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                b3.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.HotPink, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                b3.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == b3.Content.ToString())
                {
                    TB2.Text += b3.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }

            }
            if (e.Key == Key.Oem3)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                b1.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.HotPink, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                b1.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == b3.Content.ToString())
                {
                    TB2.Text += b1.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }

            }
            if (e.Key == Key.D3)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                b4.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.PaleGoldenrod, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                b4.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == b4.Content.ToString())
                {
                    TB2.Text += b4.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }

            }
            if (e.Key == Key.D4)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                b5.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGreen, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                b5.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == b5.Content.ToString())
                {
                    TB2.Text += b5.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }

            }
            if (e.Key == Key.D5)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                b6.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.CornflowerBlue, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                b6.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == b6.Content.ToString())
                {
                    TB2.Text += b6.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }

            }
            if (e.Key == Key.D6)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                b7.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.CornflowerBlue, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                b7.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == b7.Content.ToString())
                {
                    TB2.Text += b7.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }

            }
            if (e.Key == Key.D7)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                b8.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.MediumPurple, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                b8.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == b8.Content.ToString())
                {
                    TB2.Text += b8.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }

            }
            if (e.Key == Key.D8)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                b9.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.MediumPurple, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                b9.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == b9.Content.ToString())
                {
                    TB2.Text += b9.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }

            }
            if (e.Key == Key.D9)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                b10.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.HotPink, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                b10.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == b10.Content.ToString())
                {
                    TB2.Text += b10.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }

            }
            if (e.Key == Key.D0)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                b11.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.PaleGoldenrod, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                b11.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == b11.Content.ToString())
                {
                    TB2.Text += b11.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }

            }
            if (e.Key == Key.OemMinus)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                b12.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGreen, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                b12.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == b12.Content.ToString())
                {
                    TB2.Text += b12.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }

            }
            if (e.Key == Key.OemPlus)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                b13.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGreen, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                b13.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == b13.Content.ToString())
                {
                    TB2.Text += b13.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }

            }
            if (e.Key == Key.Back)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                b14.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGray, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                b14.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);


            }
            if (e.Key == Key.Tab)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                c1.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGray, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                c1.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);


            }
            if (e.Key == Key.Q)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                c2.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.HotPink, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                c2.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == c2.Content.ToString())
                {
                    TB2.Text += c2.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }

            }
            if (e.Key == Key.W)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                c3.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.PaleGoldenrod, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                c3.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == c3.Content.ToString())
                {
                    TB2.Text += c3.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.E)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                c4.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGreen, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                c4.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == c4.Content.ToString())
                {
                    TB2.Text += c4.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.R)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                c5.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.CornflowerBlue, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                c5.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == c5.Content.ToString())
                {
                    TB2.Text += c5.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.T)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                c6.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.CornflowerBlue, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                c6.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == c6.Content.ToString())
                {
                    TB2.Text += c6.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.Y)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                c7.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.MediumPurple, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                c7.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == c7.Content.ToString())
                {
                    TB2.Text += c7.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.U)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                c8.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.MediumPurple, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                c8.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == c8.Content.ToString())
                {
                    TB2.Text += c8.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.I)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                c9.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.HotPink, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                c9.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == c9.Content.ToString())
                {
                    TB2.Text += c9.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.O)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                c10.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.PaleGoldenrod, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                c10.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == c10.Content.ToString())
                {
                    TB2.Text += c10.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.P)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                c11.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGreen, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                c11.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == c11.Content.ToString())
                {
                    TB2.Text += c11.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.OemOpenBrackets)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                c12.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGreen, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                c12.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == c12.Content.ToString())
                {
                    TB2.Text += c12.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.Oem6)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                c13.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGreen, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                c13.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == c13.Content.ToString())
                {
                    TB2.Text += c13.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.Oem5)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                c14.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGreen, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                c14.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == c14.Content.ToString())
                {
                    TB2.Text += c14.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.A)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                f1.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.HotPink, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                f1.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == f1.Content.ToString())
                {
                    TB2.Text += f1.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.S)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                f2.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.PaleGoldenrod, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                f2.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == f2.Content.ToString())
                {
                    TB2.Text += f2.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                   
                }
            }
            if (e.Key == Key.D)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                f3.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGreen, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                f3.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == f3.Content.ToString())
                {
                    TB2.Text += f3.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.F)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                f4.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.CornflowerBlue, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                f4.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == f4.Content.ToString())
                {
                    TB2.Text += f4.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.G)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                f5.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.CornflowerBlue, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                f5.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == f5.Content.ToString())
                {
                    TB2.Text += f5.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.H)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                f6.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.MediumPurple, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                f6.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == f6.Content.ToString())
                {
                    TB2.Text += f6.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.J)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                f7.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.MediumPurple, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                f7.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == f7.Content.ToString())
                {
                    TB2.Text += f7.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.K)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                f8.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.HotPink, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                f8.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == f8.Content.ToString())
                {
                    TB2.Text += f8.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.L)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                f9.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.PaleGoldenrod, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                f9.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == f9.Content.ToString())
                {
                    TB2.Text += f9.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.Oem1)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                f10.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGreen, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                f10.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == f10.Content.ToString())
                {
                    TB2.Text += f10.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.OemQuotes)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                f11.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGreen, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                f11.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == f11.Content.ToString())
                {
                    TB2.Text += f11.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.Return)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                Enter.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGray, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                Enter.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

               

            }
            if (e.Key == Key.Z)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                y1.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.HotPink, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                y1.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == y1.Content.ToString())
                {
                    TB2.Text += y1.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.X)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                y2.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.PaleGoldenrod, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                y2.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == y2.Content.ToString())
                {
                    TB2.Text += y2.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.C)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                y3.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGreen, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                y3.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == y3.Content.ToString())
                {
                    TB2.Text += y3.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.V)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                y4.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.CornflowerBlue, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                y4.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == y4.Content.ToString())
                {
                    TB2.Text += y4.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.B)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                y5.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.CornflowerBlue, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                y5.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == y5.Content.ToString())
                {
                    TB2.Text += y5.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.N)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                y6.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.MediumPurple, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                y6.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == y6.Content.ToString())
                {
                    TB2.Text += y6.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.M)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                y7.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.MediumPurple, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                y7.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == y7.Content.ToString())
                {
                    TB2.Text += y7.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.OemComma)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                y8.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.HotPink, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                y8.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == y8.Content.ToString())
                {
                    TB2.Text += y8.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.OemPeriod)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                y9.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.PaleGoldenrod, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                y9.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == y9.Content.ToString())
                {
                    TB2.Text += y9.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.OemQuestion)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                y10.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGreen, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                y10.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos].ToString() == y10.Content.ToString())
                {
                    TB2.Text += y10.Content;
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            if (e.Key == Key.LeftCtrl || e.Key == Key.RightCtrl)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                LCtrl.Background = new SolidColorBrush();
                RCtrl.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGray, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                LCtrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
                RCtrl.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);



            }
            if (e.Key == Key.LWin || e.Key == Key.RWin)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                LWin.Background = new SolidColorBrush();
                RWin.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGray, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                LWin.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
                RWin.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

            }
            if (e.Key == Key.System)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                LAlt.Background = new SolidColorBrush();
                RAlt.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.LightGray, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                LAlt.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
                RAlt.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

            }
            if (e.Key == Key.Space)
            {
                var color = Equals(Background, Brushes.Orange) ? Colors.Orange : Colors.Black;
                Space.Background = new SolidColorBrush();
                var animation = new ColorAnimation(color, Colors.SandyBrown, new Duration(TimeSpan.FromMilliseconds(TimeToSleep)))
                { AutoReverse = true, RepeatBehavior = new RepeatBehavior(N + 0.5) };
                Space.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);

                if (TB1.Text[pos] == ' ')
                {
                    TB2.Text += ' ';
                    pos++;
                }
                else
                {
                    fails++;
                    Fails.Content = "Fails: " + fails;
                }
            }
            }
        }

        private void Window_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                CpsL = false;
                Refresh_Keys(CpsL);
                LShift.Background = new SolidColorBrush(Colors.LightGray);
                RShift.Background = new SolidColorBrush(Colors.LightGray);
            }
            if (pos == TB1.Text.Length && TB2.Text != "")
            {
               
                System.Windows.MessageBox.Show("YOU WIN");
                pos = 0;

                TB2.Text = "";
                TB1.Text = "";
                Start.IsEnabled = true;
                CB.IsEnabled = true;
                Slider.IsEnabled = true;
                Stop.IsEnabled = false;
                timer1.Tick -= dtTicker;
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Slider.Value == 0)
            {
                Difficulty.Content = "Difficulty: 1";
                Difficulty_value = 1;
            }
            if (Slider.Value == 1)
            {
                Difficulty.Content = "Difficulty: 2";
                Difficulty_value = 2;
            }
            if (Slider.Value == 2)
            {
                Difficulty.Content = "Difficulty: 3";
                Difficulty_value = 3;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
           

        }
        double t = 0;
        double posd = 0;
        DispatcherTimer timer1 = new DispatcherTimer();

        private void dtTicker(object sender, EventArgs e)
        {
            t+=1;
            //Speed.Content = "Speed: " + t + " chars/min";
            double min = 60;
            posd = pos;
            double temp = (posd / t) * min;
            Speed.Content = "Speed: " + Math.Round(temp, 2)+ " chars/min";

        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {

            t = 0;
            timer1.Interval = TimeSpan.FromMilliseconds(1000);
            timer1.Tick += dtTicker;
            timer1.Start();
            TB2.Text = "";
            pos = 0;
            fails = 0;
            Fails.Content = "Fails: " + fails;
            Start.IsEnabled = false;
            CB.IsEnabled = false;
            Slider.IsEnabled = false;
            Stop.IsEnabled = true;
            Random rnd = new Random();
            int value = 0;
            if (Difficulty_value == 1)
            {
                 value = rnd.Next(1, 5);
            }
            if (Difficulty_value == 2)
            {
                 value = rnd.Next(6, 10);
            }
            if (Difficulty_value == 3)
            {
                 value = rnd.Next(11, 15);
            }

            if (Case == 0)
            {
                switch (value)
                {
                    case 1:
                        TB1.Text = "i don't know where we are";
                        break;
                    case 2:
                        TB1.Text = "all the wrong places";
                        break;
                    case 3:
                        TB1.Text = "what do you stand for";
                        break;
                    case 4:
                        TB1.Text = "all eyes glow";
                        break;
                    case 5:
                        TB1.Text = "get your head right";
                        break;
                    case 6:
                        TB1.Text = "i feel ready to say goodbye would make me stay";
                        break;
                    case 7:
                        TB1.Text = "the visual studio editor provides many features";
                        break;
                    case 8:
                        TB1.Text = "you can see the default color for each error";
                        break;
                    case 9:
                        TB1.Text = "apply the global undo and redo to the actions";
                        break;
                    case 10:
                        TB1.Text = "deletes spaces at the end of the current line";
                        break;
                    case 11:
                        TB1.Text = "you can set up the scroll bar to show code changes, errors! please.";
                        break;
                    case 12:
                        TB1.Text = "select show annotations over vertical scroll bar, the annotationser.";
                        break;
                    case 13:
                        TB1.Text = "by default the toolbox is collapsed along the left tre visual studio!";
                        break;
                    case 14:
                        TB1.Text = "you can rearrange the items in a toolbox tab or tabs and items i use.";
                        break;
                    case 15:
                        TB1.Text = "you can scope searches to the current document, the current solution!";
                        break;
                        ;
                    default:
                        TB1.Text = "ERROR!";
                        break;

                        /// //////////////////////////////////////////////////////////////////////
                }

                }
                if (Case == 1)
                {
                    switch (value)
                    {
                        case 1:
                            TB1.Text = "I Don't Know Where We Are.";
                            break;
                        case 2:
                            TB1.Text = "All The Wrong Places!";
                            break;
                        case 3:
                            TB1.Text = "What Do You Stand For?";
                            break;
                        case 4:
                            TB1.Text = "All Eyes The Glowes!";
                            break;
                        case 5:
                            TB1.Text = "Get Your ANd Head Right!";
                            break;
                        case 6:
                            TB1.Text = "I Feel Ready To Say Goodbye Would Make Me Stay!";
                            break;
                        case 7:
                            TB1.Text = "The Visual Studio Editor Provides Many Features.";
                            break;
                        case 8:
                            TB1.Text = "You Can See The Default Color For Each Error.";
                            break;
                        case 9:
                            TB1.Text = "Apply The Global Undo And Redo To The Actions!";
                            break;
                        case 10:
                            TB1.Text = "Deletes Spaces At The End Of The Current Line!";
                            break;
                        case 11:
                            TB1.Text = "You Can Set Up The Scroll Bar To Show Code Changes, Errors! Please.";
                            break;
                        case 12:
                            TB1.Text = "Select Show Annotations Over Vertical Scroll Bar, The Annotations.";
                            break;
                        case 13:
                            TB1.Text = "By Default The Toolbox Is Collapsed Along The Left Visual Studio!";
                            break;
                        case 14:
                            TB1.Text = "You Can Rearrange The Items In A Toolbox Tab Add Custom Items I Use.";
                            break;
                        case 15:
                            TB1.Text = "You Can Scope Searches To The Current Document, The Current Solution!";
                            break;
                        default:
                            TB1.Text = "ERROR!";
                            break;
                    }
                }
            
        }
                
        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            Start.IsEnabled = true;
            CB.IsEnabled = true;
            Slider.IsEnabled = true;
            Stop.IsEnabled = false;
            timer1.Stop();
            timer1.Tick -= dtTicker;
        }

        private void CB_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (CB.IsChecked == true)
            {
                Case = 1;
            }
            if (CB.IsChecked != true)
            {
                Case = 0;

            }
        }
    }
}
