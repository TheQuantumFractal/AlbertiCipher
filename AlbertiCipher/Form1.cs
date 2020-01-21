using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbertiCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand;
        string parag;
        string[,] value = { { }, { } };
        string hi;
        string[,] tevalue;

        DiskGenerator disk = new DiskGenerator();
        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();
            //string[,] disc = disk.NoGen(rand);
            //string var = "";
            //for(int i = 0; i < 26; i++)
            //{
            //    var += String.Format("{0} {1} ", disc[0, i], disc[1, i]);
            //}
            //MessageBox.Show(var);
            rot.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void en_Click(object sender, EventArgs e)
        {
            parag = string.Empty;
            fix();
            if(seed.Text == string.Empty)
            {
                if (rot.Text == "0" || rot.Text == "")
                {
                    value = disk.NoGen(rand, 0);
                }
                else
                {
                    value = disk.NoGen(rand, int.Parse(rot.Text));
                }
                seed.Text = disk.seedO.ToString();
            }
            else
            {
                if (rot.Text == "0" || rot.Text == "")
                {
                    value = disk.Gen(rand, int.Parse(seed.Text), 0);
                }
                else
                {
                    value = disk.Gen(rand, int.Parse(seed.Text), int.Parse(rot.Text));
                }
            }
            disk.reset();
            for (int i = 0; i < para.Text.Count(); i++)
            {
                if (!Char.IsLetter(para.Text[i]))
                {
                    parag += para.Text[i];
                    continue;
                }
                else
                {
                    for (int x = 0; x < 26; x++)
                    {
                        if (Char.ToUpper(para.Text[i]) == Convert.ToChar(value[0, x]))
                        {
                            parag += Char.ToLower(Convert.ToChar(value[0, int.Parse(value[1, x])]));
                            break;
                        }
                    }
                }
            }
            result.Text = parag;
        }
        public void fix()
        {
            //seeder = seed.Text;
            //if (seeder.Contains('A'))
            //{
            //    seeder.Replace('A', '3');
            //}
            //if (seeder.Contains('B'))
            //{
            //    seeder.Replace('B', '2');
            //}
            //if (seeder.Contains('C'))
            //{
            //    seeder.Replace('C', '4');
            //}
            //if (seeder.Contains('D'))
            //{
            //    seeder.Replace('D', '0');
            //}
            //if (seeder.Contains('E'))
            //{
            //    seeder.Replace('E', '5');
            //}
            //if (seeder.Contains('F'))
            //{
            //    seeder.Replace('F', '8');
            //}
            //if (seeder.Contains('G'))
            //{
            //    seeder.Replace('G', '6');
            //}
            //if (seeder.Contains('H'))
            //{
            //    seeder.Replace('H', '7');
            //}
            //if (seeder.Contains('I'))
            //{
            //    seeder.Replace('I', '9');
            //}
            //if (seeder.Contains('J'))
            //{
            //    seeder.Replace('J', '1');
            //}
            //if (seeder.Contains('K'))
            //{
            //    seeder.Replace('K', '5');
            //}
            //if (seeder.Contains('L'))
            //{
            //    seeder.Replace('L', '4');
            //}
            //if (seeder.Contains('M'))
            //{
            //    seeder.Replace('M', '8');
            //}
            //if (seeder.Contains('N'))
            //{
            //    seeder.Replace('N', '9');
            //}
            //if (seeder.Contains('O'))
            //{
            //    seeder.Replace('O', '0');
            //}
            //if (seeder.Contains('P'))
            //{
            //    seeder.Replace('P', '2');
            //}
            //if (seeder.Contains('Q'))
            //{
            //    seeder.Replace('Q', '7');
            //}
            //if (seeder.Contains('R'))
            //{
            //    seeder.Replace('R', '4');
            //}
            //if (seeder.Contains('S'))
            //{
            //    seeder.Replace('S', '6');
            //}
            //if (seeder.Contains('T'))
            //{
            //    seeder.Replace('T', '1');
            //}
            //if (seeder.Contains('U'))
            //{
            //    seeder.Replace('U', '2');
            //}
            //if (seeder.Contains('V'))
            //{
            //    seeder.Replace('V', '0');
            //}
            //if (seeder.Contains('W'))
            //{
            //    seeder.Replace('W', '8');
            //}
            //if (seeder.Contains('X'))
            //{
            //    seeder.Replace('X', '5');
            //}
            //if (seeder.Contains('Y'))
            //{
            //    seeder.Replace('Y', '9');
            //}
            //if (seeder.Contains('Z'))
            //{
            //    seeder.Replace('Z', '3');
            //}
            //if (seeder.Contains('e'))
            //{
            //    seeder.Replace('e', '2');
            //}
            //if (seeder.Contains('z'))
            //{
            //    seeder.Replace('z', '2');
            //}
            //if (seeder.Contains('y'))
            //{
            //    seeder.Replace('t', '4');
            //}
            //if (seeder.Contains('q'))
            //{
            //    seeder.Replace('q', '4');
            //}
            //if (seeder.Contains('a'))
            //{
            //    seeder.Replace('a', '3');
            //}
            //if (seeder.Contains('x'))
            //{
            //    seeder.Replace('x', '3');
            //}
            //if (seeder.Contains('o'))
            //{
            //    seeder.Replace('o', '1');
            //}
            //if (seeder.Contains('j'))
            //{
            //    seeder.Replace('j', '1');
            //}
            //if (seeder.Contains('i'))
            //{
            //    seeder.Replace('i', '8');
            //}
            //if (seeder.Contains('k'))
            //{
            //    seeder.Replace('k', '8');
            //}
            //if (seeder.Contains('n'))
            //{
            //    seeder.Replace('n', '7');
            //}
            //if (seeder.Contains('v'))
            //{
            //    seeder.Replace('v', '7');
            //}
            //if (seeder.Contains('s'))
            //{
            //    seeder.Replace('s', '5');
            //}
            //if (seeder.Contains('b'))
            //{
            //    seeder.Replace('b', '5');
            //}
            //if (seeder.Contains('h'))
            //{
            //    seeder.Replace('h', '6');
            //}
            //if (seeder.Contains('p'))
            //{
            //    seeder.Replace('p', '6');
            //}
            //if (seeder.Contains('r'))
            //{
            //    seeder.Replace('r', '9');
            //}
            //if (seeder.Contains('y'))
            //{
            //    seeder.Replace('y', '9');
            //}
            //if (seeder.Contains('d'))
            //{
            //    seeder.Replace('d', '0');
            //}
            //if (seeder.Contains('g'))
            //{
            //    seeder.Replace('g', '0');
            //}
            //if (seeder.Contains('l'))
            //{
            //    seeder.Replace('l', '8');
            //}
            //if (seeder.Contains('f'))
            //{
            //    seeder.Replace('f', '8');
            //}
            //if (seeder.Contains('c'))
            //{
            //    seeder.Replace('c', '6');
            //}
            //if (seeder.Contains('w'))
            //{
            //    seeder.Replace('w', '6');
            //}
            //if (seeder.Contains('u'))
            //{
            //    seeder.Replace('u', '7');
            //}
            //if (seeder.Contains('m'))
            //{
            //    seeder.Replace('m', '7');
            //}
        }

        private void de_Click(object sender, EventArgs e)
        {
            string parag2 = "";
            fix();
            string[,] devalue;
            if (seed.Text == string.Empty)
            {
                MessageBox.Show("There is no seed!", "NO SEED!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                int tempseed;
                if(int.TryParse(seed.Text, out tempseed))
                {
                    if (rot.Text == string.Empty || rot.Text == "0")
                    {
                        devalue = disk.Degen(rand, tempseed, 0);
                    }
                    else
                    {
                        devalue = disk.Degen(rand, tempseed, int.Parse(rot.Text));
                    }
                    disk.reset();
                    for (int i = 0; i < para.Text.Count(); i++)
                    {
                        if (!Char.IsLetter(para.Text[i]))
                        {
                            parag2 += para.Text[i];
                            continue;
                        }
                        else
                        {
                            for (int x = 0; x < 26; x++)
                            {
                                if (int.Parse(devalue[1, x]) < int.Parse(rot.Text))
                                {
                                    if (Char.ToUpper(para.Text[i]) == Convert.ToChar(devalue[0, int.Parse(devalue[1, x])]))
                                    {
                                        parag2 += Char.ToLower(Convert.ToChar(devalue[0, x]));
                                        break;
                                    }
                                }
                                else
                                {
                                    if (Char.ToUpper(para.Text[i]) == Convert.ToChar(devalue[0, int.Parse(devalue[1, x])]))
                                    {
                                        parag2 += Char.ToLower(Convert.ToChar(devalue[0, x]));
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    result.Text = parag2;
                }
                else
                {
                    MessageBox.Show("You may not use letters in your seed");
                }
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            seed.Text = string.Empty;
            tbox.Text = string.Empty;
            tevalue = disk.NoGen(rand, int.Parse(rot.Text));
            seed.Text = disk.seedO.ToString();
            hi = "";
            disk.reset();
            for (int f = 0; f < 26; f++)
            {
                hi += tevalue[0, f];
                hi += "=";
                hi += tevalue[0, int.Parse(tevalue[1, f])];
                if (f % 4 == 0 && f > 0)
                {
                    hi += "\r\n";
                }
                else
                {
                    hi += "   ";
                }
            }
            tbox.Text = hi;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                if(int.Parse(rot.Text) < 25)
                {
                    rot.Text = Convert.ToString(int.Parse(rot.Text) + 1);
                }
                else
                {
                    rot.Text = "1";
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (int.Parse(rot.Text) > 1)
                {
                    rot.Text = Convert.ToString(int.Parse(rot.Text) - 1);
                }
                else
                {
                    rot.Text = "25";
                }
            }
        }

        private void rot_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                if (int.Parse(rot.Text) < 25)
                {
                    rot.Text = Convert.ToString(int.Parse(rot.Text) + 1);
                }
                else
                {
                    rot.Text = "1";
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (int.Parse(rot.Text) > 1)
                {
                    rot.Text = Convert.ToString(int.Parse(rot.Text) - 1);
                }
                else
                {
                    rot.Text = "25";
                }
            }
        }

        private void para_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                if (int.Parse(rot.Text) < 25)
                {
                    rot.Text = Convert.ToString(int.Parse(rot.Text) + 1);
                }
                else
                {
                    rot.Text = "1";
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (int.Parse(rot.Text) > 1)
                {
                    rot.Text = Convert.ToString(int.Parse(rot.Text) - 1);
                }
                else
                {
                    rot.Text = "25";
                }
            }
        }

        private void test_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (int.Parse(rot.Text) < 25)
                {
                    rot.Text = Convert.ToString(int.Parse(rot.Text) + 1);
                }
                else
                {
                    rot.Text = "1";
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (int.Parse(rot.Text) > 1)
                {
                    rot.Text = Convert.ToString(int.Parse(rot.Text) - 1);
                }
                else
                {
                    rot.Text = "25";
                }
            }
        }

        private void tbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (int.Parse(rot.Text) < 25)
                {
                    rot.Text = Convert.ToString(int.Parse(rot.Text) + 1);
                }
                else
                {
                    rot.Text = "1";
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (int.Parse(rot.Text) > 1)
                {
                    rot.Text = Convert.ToString(int.Parse(rot.Text) - 1);
                }
                else
                {
                    rot.Text = "25";
                }
            }
        }

        private void result_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (int.Parse(rot.Text) < 25)
                {
                    rot.Text = Convert.ToString(int.Parse(rot.Text) + 1);
                }
                else
                {
                    rot.Text = "1";
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (int.Parse(rot.Text) > 1)
                {
                    rot.Text = Convert.ToString(int.Parse(rot.Text) - 1);
                }
                else
                {
                    rot.Text = "25";
                }
            }
        }

        private void test2_Click(object sender, EventArgs e)
        {
            tbox.Text = string.Empty;
            tevalue = disk.Gen(rand, int.Parse(seed.Text), int.Parse(rot.Text));
            hi = "";
            disk.reset();
            for (int f = 0; f < 26; f++)
            {
                hi += tevalue[0, f];
                hi += "=";
                hi += tevalue[0, int.Parse(tevalue[1, f])];
                if (f % 4 == 0 && f > 0)
                {
                    hi += "\r\n";
                }
                else
                {
                    hi += "   ";
                }
            }
            tbox.Text = hi;
        }

        private void para_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
