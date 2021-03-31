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
            void o2()
            {
            bool rInputs = true;
            var up = Key.W;
            var down = Key.S;
            var left = Key.A;
            var right = Key.D;
            var st0p = Key.Enter;
            
            o2();
            void o2()
            {
                while (rInputs == true)
                {
                    string userinputs = "Start";

                        break;
                    }
                    if (Keyboard.IsKeyDown(up))
                    {
                        userinputs = userinputs + "up";
                        var z = 1;
                    }
                    if (Keyboard.IsKeyDown(down))
                    {
                        userinputs = userinputs + "down";
                        var x = 1;
                    }
                    if (Keyboard.IsKeyDown(left))
                    {
                        userinputs = userinputs + "left";
                        var x = 1;
                    }
                    if (Keyboard.IsKeyDown(right))
                    {
                        userinputs = userinputs + "right";
                        var x = 1;
                    }
                    if (Keyboard.IsKeyDown(st0p))
                    {
                        userinputs = userinputs + "stop";
                        /// MessageBox.Show("You clicked the ellipse!");
                        mssg("All");
                        mssg(userinputs);
                        break;
                }
            }
        }

    }
        public void mssg(string a)
                {
                MessageBox.Show(a);
           }
    }
}
