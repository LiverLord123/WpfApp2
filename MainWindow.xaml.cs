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
using System.IO;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
<<<<<<<<< Temporary merge branch 1
            bool rInputs = true;
            var up = Key.W;
            var down = Key.S;
            var left = Key.A;
            var right = Key.D;
            var st0p = Key.Enter;
            
            o2();
            

        }

            public async void o2()
            {
                    bool rInputs = true;
                    var up = Key.W;
                    var down = Key.S;
                    var left = Key.A;
                    var right = Key.D;
                    var st0p = Key.Enter;
                    var lp = Key.H;
                    var mp = Key.J;
                    var hp = Key.K;
                    var lk = Key.B;
                    var mk = Key.N;
                    var hk = Key.M;
                    string userinputs = "Start";
                    string motioninputs = "Start";
                    while (rInputs == true)
                    
                    {
                        if (Keyboard.IsKeyDown(up))
                        {
                            userinputs = userinputs + "-up";
                            while (Keyboard.IsKeyUp(up) == false)
                            {

                            }
                        }
                        if (Keyboard.IsKeyDown(down))
                        {
                            userinputs = userinputs + "-down";
                            while (Keyboard.IsKeyUp(down) == false)
                            {

                            }
                        }
                        if (Keyboard.IsKeyDown(left))
                        {
                            userinputs = userinputs + "-left";
                            while (Keyboard.IsKeyUp(left) == false)
                            {

                            }
                        }
                        if (Keyboard.IsKeyDown(right))
                        {
                            userinputs = userinputs + "-right";
                            while (Keyboard.IsKeyUp(right) == false)
                            {

                            }
                        }
                        if (Keyboard.IsKeyDown(lp))
                        {
                            userinputs = userinputs + "-lp";
                            motioninputs = motioninputs + "-lp";
                            while (Keyboard.IsKeyUp(lp) == false)
                            {
                                
                            }
                        }
                        if (Keyboard.IsKeyDown(mp))
                        {
                            userinputs = userinputs + "-mp";
                            motioninputs = motioninputs + "-mp";
                            while (Keyboard.IsKeyUp(mp) == false)
                            {
                                
                            }

                        }
                        if (Keyboard.IsKeyDown(hp))
                        {
                            userinputs = userinputs + "-hp";
                            motioninputs = motioninputs + "-hp";
                            while (Keyboard.IsKeyUp(hp) == false)
                            {

                            }
                        }
                        if (Keyboard.IsKeyDown(lk))
                        {
                            userinputs = userinputs + "-lk";
                            while (Keyboard.IsKeyUp(lk) == false)
                            {

                            }
                        }
                        if (Keyboard.IsKeyDown(mk))
                        {
                            userinputs = userinputs + "-mk";
                            while (Keyboard.IsKeyUp(mk) == false)
                            {

                            }
                        }
                        if (Keyboard.IsKeyDown(hk))
                        {
                            userinputs = userinputs + "-hk";
                            while (Keyboard.IsKeyUp(hk) == false)
                            {

                            }
                        }

                        if (Keyboard.IsKeyDown(st0p))
                        {
                            userinputs = userinputs + "-stop";
                            /// MessageBox.Show("You clicked the ellipse!");
                            mssg("Stopping");
                            ///mssg(userinputs);wwwwwwwwwwwwwwwwwwsssssssssssssssssssssssssssaaaaaaaaaaaaaaaaaaaddddddddddddd
                            ///
                            ///
                            ///
                            await File.WriteAllTextAsync("userinputs-log.txt", userinputs);
                            await File.WriteAllTextAsync("motioninputs-log.txt", motioninputs);
                            break;
                        }
                        void qcf()
                        {
                            if (Keyboard.IsKeyDown(down))
                            {
                                ///userinputs = userinputs + "down";
                            for (int i = 0; i < 10; i++)
                            {
                                if (Keyboard.IsKeyDown(down) && Keyboard.IsKeyDown(right))
                                {
                                    ///userinputs = userinputs + "down" + "right";
                                    for (int b = 0; b < 10; b++)
                                    {
                                    if (Keyboard.IsKeyDown(right))
                                    {
                                        ///userinputs = userinputs + "right";
                                        motioninputs = motioninputs + "-qcf";
                                        b = 10;
                                    }

                                }
                                }
                            }
                            }
                        }
                    }
            }
        public void mssg(string a)
                {
                MessageBox.Show(a);
           }
        private void on(object sender, RoutedEventArgs e)
        {
            o2();
        }
        
    }
}
