using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Камень_Ножницы_Бумага
{
    public partial class Form1 : Form
    {
        string user_figure = "";
        string comp_figure = "";
        int score_wins = 0;
        int score_lose = 0;
        int score_draw = 0;
        string mode = "show";

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            show_score();
            set_comp_speed();
        }

        private void start_game()
        {
            if (mode != "game")
            {
                label_mesage.Text = "Выбери свою фигуру!";
                mode = "game";
            }
            
        }

        private void show_user_figure(string figure)
        {
            start_game();
            user_pictureBox_kam.Visible = figure=="kam";
            user_pictureBox_noz.Visible = figure == "noz";
            user_pictureBox_bum.Visible = figure == "bum";
            user_figure = figure;

        }

        private void show_comp_figure(string figure)
        {
            comp_pictureBox_kam.Visible = figure == "kam";
            comp_pictureBox_noz.Visible = figure == "noz";
            comp_pictureBox_bum.Visible = figure == "bum";
            comp_figure = figure;
        }

        private void user_panel_kam_MouseEnter(object sender, EventArgs e)
        {
            show_user_figure((((Panel)sender).Tag).ToString());
            
        }

        private void user_pictureBox_kam_MouseClick(object sender, MouseEventArgs e)
        {
            if (mode == "game")
                check_result();
            else
                start_game();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(mode=="game")
                use_comp_random_figure();
        }

        private void use_comp_random_figure()
        {
            int f = rand.Next(1, 4);
            if (f == 1) show_comp_figure("kam");
            if (f == 2) show_comp_figure("noz");
            if (f == 3) show_comp_figure("bum");

        }

        void show_score()
        {
            label_score.Text = 
                "Победы: " + score_wins.ToString() +
            "  Поражения: " + score_lose.ToString() + 
                "  Ничьи: " + score_draw.ToString();
        }

       private void check_result()
        {
            mode = "show";
            int wins = 0;
            int lose = 0;
            int draw = 0;
            if (user_figure == comp_figure)
                draw = 1;
            else
            {
                if (user_figure == "kam")
                    if (comp_figure == "noz")
                        wins = 1;
                    else
                        lose = 1;
                if (user_figure == "noz")
                    if (comp_figure == "bum")
                        wins = 1;
                    else
                        lose = 1;
                if (user_figure == "bum")
                    if (comp_figure == "kam")
                        wins = 1;
                    else
                        lose = 1;
            }
            score_wins += wins;
            score_lose += lose;
            score_draw += draw;
            if (wins > 0)
                label_mesage.Text = "Победа!:)";
            if (lose > 0)
                label_mesage.Text = "Проигрыш!:(";
            if (draw > 0)
                label_mesage.Text = "Ничья...";
            show_score();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            set_comp_speed();
        }

        private void set_comp_speed()
        {
            if (trackBar_speed.Value == 1) timer.Interval = 400;
            if (trackBar_speed.Value == 2) timer.Interval = 300;
            if (trackBar_speed.Value == 3) timer.Interval = 200;
            if (trackBar_speed.Value == 4) timer.Interval = 100;
            if (trackBar_speed.Value == 5) timer.Interval = 50;
        }
    }
}
