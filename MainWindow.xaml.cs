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
                    var tp = Key.L;
                    var tk = Key.OemComma;
                    bool record1 = false;
                    bool record2 = false;
                    bool record3 = false;
                    bool record4 = false;
                    bool record5 = false;
                    bool record6 = false;
                    bool record7 = false;
                    bool record8 = false;
                    bool record9 = false;
                    bool record10 = false;
                    bool record11 = false;
                    bool record12 = false;
                    bool d_phase = false;
                    bool df_phase = false;
                    bool up_phase = false;
                    bool l_phase = false;
                    bool r_phase = false;
                    string userinputs = "Start";
                    string motioninputs = "Start";
                    string phases = "Start";
                    while (rInputs == true)
                    
                    {
                        if (Keyboard.IsKeyDown(up))
                        {
                            
                            if (record1 == false)
                            {
                                userinputs = userinputs + "-up";
                            }
                            record1 = true;
                            up_phase = true;
                        }
                        if (up_phase == true)
                        {
                            phases = phases + "-up_phase";
                            for (int ez = 0; ez < 8; ez++)
                            {
                                up_phase = true;
                            }
                            up_phase = false;
                        }

                        if (Keyboard.IsKeyDown(down))
                        {
                            if (record2 == false)
                            {
                                userinputs = userinputs + "-down";
                            }
                            record2 = true;
                            d_phase = true;
                        }
                        if (d_phase == true)
                        {
                            phases = phases + "-d_phase";
                            for (int z = 0; z < 9; z++)
                            {
                                d_phase = true;
                            }
                            d_phase = false;
                        }

                        if (Keyboard.IsKeyDown(left))
                        {
                            if (record3 == false)
                            {
                                userinputs = userinputs + "-left";
                            }
                            record3 = true;
                            l_phase = true;
                        }
                        if (l_phase == true)
                        {
                            phases = phases + "-l_phase";
                            for (int ez = 0; ez < 8; ez++)
                            {
                                l_phase = true;
                            }
                            l_phase = false;
                        }

                        if (Keyboard.IsKeyDown(right))
                        {
                            if (record4 == false)
                            {
                                userinputs = userinputs + "-right";
                            }
                            record4 = true;
                            r_phase = true;
                        }
                        if (r_phase == true)
                        {
                            phases = phases + "-r_phase";
                            for (int ez = 0; ez < 8; ez++)
                            {
                                r_phase = true;
                            }
                            r_phase = false;
                        }

                        ///Attack Buttons
                        ///Light Punch
                        if (Keyboard.IsKeyDown(lp))
                        {
                            if (record5 == false)
                            {
                            userinputs = userinputs + "-lp";
                            motioninputs = motioninputs + "-lp";
                            }
                            record5 = true;
                        }

                        ///Medium Punch
                        if (Keyboard.IsKeyDown(mp))
                        {
                            if (record6 == false)
                            {
                            userinputs = userinputs + "-mp";
                            motioninputs = motioninputs + "-mp";
                            }
                            record6 = true;
                        }

                        ///Heavy Punch
                        if (Keyboard.IsKeyDown(hp))
                        {
                            if (record7 == false)
                            {
                            userinputs = userinputs + "-hp";
                            motioninputs = motioninputs + "-hp";
                            }
                            record7 = true;
                        }

                        ///Light Kick
                        if (Keyboard.IsKeyDown(lk))
                        {
                            if (record8 == false)
                            {
                            userinputs = userinputs + "-lk";
                            motioninputs = motioninputs + "lk";
                            }
                            record8 = true;
                        }

                        ///Medium Kick
                        if (Keyboard.IsKeyDown(mk))
                        {
                            if (record9 == false)
                            {
                            userinputs = userinputs + "-mk";
                            motioninputs = motioninputs + "-mk";
                            }
                            record9 = true;
                        }

                        ///Heavy Kick
                        if (Keyboard.IsKeyDown(hk))
                        {
                            if (record10 == false)
                            {
                            userinputs = userinputs + "-hk";
                            motioninputs = motioninputs + "-hk";
                            }
                            record10 = true;
                        }

                        ///Triple Punches
                        if (Keyboard.IsKeyDown(tp))
                        {
                            if (record11 == false)
                            {
                            userinputs = userinputs + "-tp";
                            motioninputs = motioninputs + "-tp";
                            }
                            record11 = true;
                        }

                        ///Triple Kicks
                        if (Keyboard.IsKeyDown(tk))
                        {
                            if (record12 == false)
                            {
                            userinputs = userinputs + "-tk";
                            motioninputs = motioninputs + "-tk";
                            }
                            record12 = true;
                        }

                        if (Keyboard.IsKeyDown(st0p))
                        {
                            userinputs = userinputs + "-stop";
                            motioninputs = motioninputs + "-stop";
                            ///
                            await File.WriteAllTextAsync("userinputs-log.txt", userinputs);
                            await File.WriteAllTextAsync("motioninputs-log.txt", motioninputs);
                            
                            mssg("Stopping");
                            break;
                        }

                        ///Motion-Inputs Called
                        qcf();
                        
                        ///Motion-Input Methods Defined
                        void qcf()
                        {
                            if (d_phase)
                            {
                                ///userinputs = userinputs + "down";
                            for (int i = 0; i < 9; i++)
                            {
                                d_phase = true;
                                if (df_phase)
                                {
                                    for (int b = 0; b < 9; b++)
                                    {
                                    df_phase = true;
                                    if (r_phase)
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
                        
                        ///special direction detection and loop
                        if (Keyboard.IsKeyDown(down) && Keyboard.IsKeyDown(right))
                        {
                            df_phase = true;
                        }
                        if (df_phase == true)
                        {
                            for (int x = 0; x < 8; x++)
                            {
                                df_phase = true;
                            }
                            df_phase = false;
                        }

                        ///will allow recording if key is released
                        if (Keyboard.IsKeyUp(up))
                            {
                                record1 = false;
                            }
                        if (Keyboard.IsKeyUp(down))
                            {
                                record2 = false;
                            }
                        if (Keyboard.IsKeyUp(left))
                            {
                                record3 = false;
                            }
                        if (Keyboard.IsKeyUp(right))
                            {
                                record4 = false;
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
