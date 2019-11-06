using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRIP_LAB7_ALBERTI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Shifr_Click(object sender, EventArgs e)
        {
            char[] text = Text.Text.ToCharArray();
            char[] shifr = Text.Text.ToCharArray();

            char[] ALPHA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] ALPHA_copy = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] alpha_copy = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            char[] alph_copy = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            char[] ALPH = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
            char[] ALPH_copy = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
            int n = 0, j1 = 0, j2 = 0;      
            int key = Convert.ToInt32(keyBox.Text);

            //  сдвиг кольца
            for (int i = 0, j = 0; i < ALPHA.Length; i++)
            {

                if(key >= 0)
                    j = (i + key) % ALPHA.Length;
                if (key < 0)
                {
                    j = (i + key + ALPHA.Length) % ALPHA.Length;
                    while (j < 0)
                    {
                        j = (j + ALPHA.Length) % ALPHA.Length;
                    }
                }

                ALPHA_copy[j] = ALPHA[i];
                alpha_copy[j] = alpha[i];
            }

            //  сдвиг кольца
            for (int i = 0, j = 0; i < ALPH.Length; i++)
            {
                if (key >= 0)
                    j = (i + key) % ALPH.Length;
                if (key < 0)
                {
                    j = (i + key + ALPH.Length) % ALPH.Length;
                    while (j < 0)
                    {
                        j = (j + ALPH.Length) % ALPH.Length;
                    }
                }
                ALPH_copy[j] = ALPH[i];
                alph_copy[j] = alph[i];
            }

            for (int i = 0; i < text.Length;i++)
            {
                for (int j = 0; j < ALPHA.Length; j++)
                {
                    j1 = n + j;
                    if (j1 >= ALPHA.Length)
                    {
                        j1 = j1 % 26;
                    }
                    if (text[i] == ALPHA[j])
                    {
                        shifr[i] = ALPHA_copy[j1];
                        n++;
                        break;
                    }
                    if (text[i] == alpha[j])
                    {
                        shifr[i] = alpha_copy[j1];
                        n++;
                        break;
                    }
                }

                for (int j = 0; j < ALPH.Length; j++)
                {
                    j2 = n + j;
                    if (j2 >= ALPH.Length)
                    {
                        j2 = j2 % 33;
                    }
                    if (text[i] == ALPH[j])
                    {
                        shifr[i] = ALPH_copy[j2];
                        n++;
                        break;
                    }
                    if (text[i] == alph[j])
                    {
                        shifr[i] = alph_copy[j2];
                        n++;
                        break;
                    }
                }


            }

            string text1 = new string(shifr);
            ShifrText.Text = text1;

        }

        private void button_unShifr_Click(object sender, EventArgs e)
        {
            char[] text = Text.Text.ToCharArray();
            char[] shifr = Text.Text.ToCharArray();
            char[] ALPHA = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] ALPHA_copy = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] alpha_copy = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            char[] alph_copy = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
            char[] ALPH = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
            char[] ALPH_copy = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
            int n = 0, j1 = 0, j2 = 0;
            int key = Convert.ToInt32(keyBox.Text);
            int length = 0;

            for (int i = 0, j = 0; i < ALPHA.Length; i++)
            {
                if (key >= 0)
                    j = (i + key) % ALPHA.Length;
                if (key < 0)
                {
                    j = (i + key + ALPHA.Length) % ALPHA.Length;
                    while (j < 0)
                    {
                        j = (j + ALPHA.Length) % ALPHA.Length;
                    }
                }
                ALPHA_copy[j] = ALPHA[i];
                alpha_copy[j] = alpha[i];
            }

            for (int i = 0, j = 0; i < ALPH.Length; i++)
            {
                if (key >= 0)
                    j = (i + key) % ALPH.Length;
                if (key < 0)
                {
                    j = (i + key + ALPH.Length) % ALPH.Length;
                    while (j < 0)
                    {
                        j = (j + ALPH.Length) % ALPH.Length;
                    }
                }
                ALPH_copy[j] = ALPH[i];
                alph_copy[j] = alph[i];
            }

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < ALPHA.Length; j++)
                {
                    if (text[i] == ALPHA[j] || text[i] == alpha[j])
                    {
                        length++;
                        break;
                    }
                }

                for (int j = 0; j < ALPH.Length; j++)
                {
                    if (text[i] == ALPH[j] || text[i] == alph[j])
                    {
                        length++;
                        break;
                    }
                }
            }


            length--;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < ALPHA.Length; j++)
                {
                    j1 = j - length;

                    while (j1 < 0)
                    {
                        j1 = j1 + 26;
                    }

                    if (text[i] == ALPHA_copy[j])
                    {
                        shifr[i] = ALPHA[j1];
                        length--;
                    }

                    if (text[i] == alpha_copy[j])
                    {
                        shifr[i] = alpha[j1];
                        length--;
                    }
                }
                for (int j = 0; j < ALPH.Length; j++)
                {
                    j2 = j - length;

                    while (j2 < 0)
                    {
                        j2 = j2 + 33;
                    }

                    if (text[i] == ALPH_copy[j])
                    {
                        shifr[i] = ALPH[j2];
                        length--;
                    }

                    if (text[i] == alph_copy[j])
                    {
                        shifr[i] = alph[j2];
                        length--;
                    }
                }
            }

            string text1 = new string(shifr);
            ShifrText.Text = text1;
        }
    }
}
