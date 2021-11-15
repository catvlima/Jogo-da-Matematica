using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Matemática
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Cria um objeto SoundPlayer para ser tocado quando o jogador ganhou
        System.Media.SoundPlayer win = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");

        System.Media.SoundPlayer endgame = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows error.wav");

        int add1, add2;     // operandos da soma
        int sub1, sub2, mult1, mult2, div1, div2; // Restantes operandos

        // Objeto randi da classe Random para gerar os nºs aleatórios
        Random randi = new Random();

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            Close();
        }

        int TimeLeft;       // conta o tempo do jogo

        public void ClearText()
        {
            txt_Add.Text = "";
            txt_Sub.Text = "";
            txt_Mult.Text = "";
            txt_Div.Text = "";
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            ClearText();
            lbl_TimeLeft.BackColor = Color.Khaki;
            lbl_TimeLeft.ForeColor = DefaultForeColor;
            StartGame();
            bt_Start.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(CheckAnswer())
            {
                timer1.Stop();
                win.Play();     // Toca o som já definido   
                MessageBox.Show("Parabéns! Ganhou!");
                bt_Start.Enabled = true;
                lbl_TimeLeft.Text = "";
            }
            else 
                if(TimeLeft > 0)
                {
                    TimeLeft--;     // Decrementa o timer
                    lbl_TimeLeft.Text = TimeLeft + " segundos";
                    if(TimeLeft <= 5)
                    {
                        lbl_TimeLeft.BackColor = Color.Yellow;
                        lbl_TimeLeft.ForeColor = Color.Red;
                        endgame.Play();
                    }
                }
                else
                {
                    timer1.Stop();   // Pára o timer 
                    lbl_TimeLeft.Text = " Já esgotou o tempo...";
                    MessageBox.Show("Que pena! Perdeu... Pode tentar novamente");
                // Mostra os resultados certos
                    txt_Add.Text = (add1 + add2).ToString();
                    txt_Sub.Text = (sub1 - sub2).ToString();
                    txt_Mult.Text = (mult1 * mult2).ToString();
                    txt_Div.Text = (div1 / div2).ToString();

                    bt_Start.Enabled = true;
                }
        }

        public void StartGame()
        {
            // Adição
            // Preenche os operandos com valores aleatórios
            add1 = randi.Next(21);
            add2 = randi.Next(21);
            // Converte os valores para string e armazena na label
            lbl_AddLeft.Text = add1.ToString();
            lbl_AddRight.Text = add2.ToString();

            // Subtração
            sub1 = randi.Next(21);
            sub2 = randi.Next(sub1);    // para não dar nºs negativos
            lbl_SubLeft.Text = sub1.ToString();
            lbl_SubRight.Text = sub2.ToString();

            // Multiplicação
            mult1 = randi.Next(11);
            mult2 = randi.Next(11);
            lbl_MultLeft.Text = mult1.ToString();
            lbl_MultRight.Text = mult2.ToString();

            // Divisão
            div1 = randi.Next(11);
            div2 = randi.Next(1, 11);   // Para evitar divisão por zero
            lbl_DivLeft.Text = div1.ToString();
            lbl_DivRight.Text = div2.ToString();
            // Iniciar o timer

            TimeLeft = 20;
            lbl_TimeLeft.Text = TimeLeft + " segundos";
            timer1.Start();
        }

        public bool CheckAnswer()
        {
            if ((add1 + add2).ToString() == txt_Add.Text &&
                (sub1 - sub2).ToString() == txt_Sub.Text &&
                (mult1 * mult2).ToString() == txt_Mult.Text &&
                (div1 / div2).ToString() == txt_Div.Text)
                return true;
            else
                return false;
        }
       
    }
}
