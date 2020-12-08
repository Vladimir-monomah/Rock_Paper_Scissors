namespace Камень_Ножницы_Бумага
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.user_panel_kam = new System.Windows.Forms.Panel();
            this.user_panel_noz = new System.Windows.Forms.Panel();
            this.user_panel_bum = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.user_pictureBox_kam = new System.Windows.Forms.PictureBox();
            this.user_pictureBox_noz = new System.Windows.Forms.PictureBox();
            this.user_pictureBox_bum = new System.Windows.Forms.PictureBox();
            this.comp_pictureBox_kam = new System.Windows.Forms.PictureBox();
            this.comp_pictureBox_noz = new System.Windows.Forms.PictureBox();
            this.comp_pictureBox_bum = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_mesage = new System.Windows.Forms.Label();
            this.label_comp = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.trackBar_speed = new System.Windows.Forms.TrackBar();
            this.user_panel_kam.SuspendLayout();
            this.user_panel_noz.SuspendLayout();
            this.user_panel_bum.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox_kam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox_noz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox_bum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_pictureBox_kam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_pictureBox_noz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_pictureBox_bum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // user_panel_kam
            // 
            this.user_panel_kam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_panel_kam.Controls.Add(this.user_pictureBox_kam);
            this.user_panel_kam.Location = new System.Drawing.Point(12, 55);
            this.user_panel_kam.Name = "user_panel_kam";
            this.user_panel_kam.Size = new System.Drawing.Size(120, 120);
            this.user_panel_kam.TabIndex = 0;
            this.user_panel_kam.Tag = "kam";
            this.user_panel_kam.MouseEnter += new System.EventHandler(this.user_panel_kam_MouseEnter);
            // 
            // user_panel_noz
            // 
            this.user_panel_noz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_panel_noz.Controls.Add(this.user_pictureBox_noz);
            this.user_panel_noz.Location = new System.Drawing.Point(138, 55);
            this.user_panel_noz.Name = "user_panel_noz";
            this.user_panel_noz.Size = new System.Drawing.Size(120, 120);
            this.user_panel_noz.TabIndex = 0;
            this.user_panel_noz.Tag = "noz";
            this.user_panel_noz.MouseEnter += new System.EventHandler(this.user_panel_kam_MouseEnter);
            // 
            // user_panel_bum
            // 
            this.user_panel_bum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_panel_bum.Controls.Add(this.user_pictureBox_bum);
            this.user_panel_bum.Location = new System.Drawing.Point(264, 55);
            this.user_panel_bum.Name = "user_panel_bum";
            this.user_panel_bum.Size = new System.Drawing.Size(120, 120);
            this.user_panel_bum.TabIndex = 0;
            this.user_panel_bum.Tag = "bum";
            this.user_panel_bum.MouseEnter += new System.EventHandler(this.user_panel_kam_MouseEnter);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.comp_pictureBox_kam);
            this.panel5.Controls.Add(this.comp_pictureBox_noz);
            this.panel5.Controls.Add(this.comp_pictureBox_bum);
            this.panel5.Location = new System.Drawing.Point(471, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 120);
            this.panel5.TabIndex = 0;
            // 
            // user_pictureBox_kam
            // 
            this.user_pictureBox_kam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_pictureBox_kam.Image = ((System.Drawing.Image)(resources.GetObject("user_pictureBox_kam.Image")));
            this.user_pictureBox_kam.Location = new System.Drawing.Point(0, 0);
            this.user_pictureBox_kam.Name = "user_pictureBox_kam";
            this.user_pictureBox_kam.Size = new System.Drawing.Size(118, 118);
            this.user_pictureBox_kam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_pictureBox_kam.TabIndex = 1;
            this.user_pictureBox_kam.TabStop = false;
            this.user_pictureBox_kam.Visible = false;
            this.user_pictureBox_kam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.user_pictureBox_kam_MouseClick);
            // 
            // user_pictureBox_noz
            // 
            this.user_pictureBox_noz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_pictureBox_noz.Image = ((System.Drawing.Image)(resources.GetObject("user_pictureBox_noz.Image")));
            this.user_pictureBox_noz.Location = new System.Drawing.Point(0, 0);
            this.user_pictureBox_noz.Name = "user_pictureBox_noz";
            this.user_pictureBox_noz.Size = new System.Drawing.Size(118, 118);
            this.user_pictureBox_noz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_pictureBox_noz.TabIndex = 1;
            this.user_pictureBox_noz.TabStop = false;
            this.user_pictureBox_noz.Visible = false;
            this.user_pictureBox_noz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.user_pictureBox_kam_MouseClick);
            // 
            // user_pictureBox_bum
            // 
            this.user_pictureBox_bum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_pictureBox_bum.Image = ((System.Drawing.Image)(resources.GetObject("user_pictureBox_bum.Image")));
            this.user_pictureBox_bum.Location = new System.Drawing.Point(0, 0);
            this.user_pictureBox_bum.Name = "user_pictureBox_bum";
            this.user_pictureBox_bum.Size = new System.Drawing.Size(118, 118);
            this.user_pictureBox_bum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_pictureBox_bum.TabIndex = 1;
            this.user_pictureBox_bum.TabStop = false;
            this.user_pictureBox_bum.Visible = false;
            this.user_pictureBox_bum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.user_pictureBox_kam_MouseClick);
            // 
            // comp_pictureBox_kam
            // 
            this.comp_pictureBox_kam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comp_pictureBox_kam.Image = ((System.Drawing.Image)(resources.GetObject("comp_pictureBox_kam.Image")));
            this.comp_pictureBox_kam.Location = new System.Drawing.Point(0, 0);
            this.comp_pictureBox_kam.Name = "comp_pictureBox_kam";
            this.comp_pictureBox_kam.Size = new System.Drawing.Size(118, 118);
            this.comp_pictureBox_kam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comp_pictureBox_kam.TabIndex = 1;
            this.comp_pictureBox_kam.TabStop = false;
            this.comp_pictureBox_kam.Visible = false;
            // 
            // comp_pictureBox_noz
            // 
            this.comp_pictureBox_noz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comp_pictureBox_noz.Image = ((System.Drawing.Image)(resources.GetObject("comp_pictureBox_noz.Image")));
            this.comp_pictureBox_noz.Location = new System.Drawing.Point(0, 0);
            this.comp_pictureBox_noz.Name = "comp_pictureBox_noz";
            this.comp_pictureBox_noz.Size = new System.Drawing.Size(118, 118);
            this.comp_pictureBox_noz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comp_pictureBox_noz.TabIndex = 1;
            this.comp_pictureBox_noz.TabStop = false;
            this.comp_pictureBox_noz.Visible = false;
            // 
            // comp_pictureBox_bum
            // 
            this.comp_pictureBox_bum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comp_pictureBox_bum.Image = ((System.Drawing.Image)(resources.GetObject("comp_pictureBox_bum.Image")));
            this.comp_pictureBox_bum.Location = new System.Drawing.Point(0, 0);
            this.comp_pictureBox_bum.Name = "comp_pictureBox_bum";
            this.comp_pictureBox_bum.Size = new System.Drawing.Size(118, 118);
            this.comp_pictureBox_bum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.comp_pictureBox_bum.TabIndex = 1;
            this.comp_pictureBox_bum.TabStop = false;
            this.comp_pictureBox_bum.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_mesage
            // 
            this.label_mesage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_mesage.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mesage.Location = new System.Drawing.Point(12, 13);
            this.label_mesage.Name = "label_mesage";
            this.label_mesage.Size = new System.Drawing.Size(371, 39);
            this.label_mesage.TabIndex = 1;
            this.label_mesage.Text = "Выбери свою фигуру";
            this.label_mesage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_comp
            // 
            this.label_comp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_comp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_comp.Location = new System.Drawing.Point(471, 1);
            this.label_comp.Name = "label_comp";
            this.label_comp.Size = new System.Drawing.Size(120, 52);
            this.label_comp.TabIndex = 1;
            this.label_comp.Text = "Рука компьютера";
            this.label_comp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_score
            // 
            this.label_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_score.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_score.Location = new System.Drawing.Point(14, 178);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(577, 51);
            this.label_score.TabIndex = 2;
            this.label_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar_speed
            // 
            this.trackBar_speed.LargeChange = 1;
            this.trackBar_speed.Location = new System.Drawing.Point(594, 52);
            this.trackBar_speed.Maximum = 5;
            this.trackBar_speed.Minimum = 1;
            this.trackBar_speed.Name = "trackBar_speed";
            this.trackBar_speed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_speed.Size = new System.Drawing.Size(45, 119);
            this.trackBar_speed.TabIndex = 3;
            this.trackBar_speed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_speed.Value = 3;
            this.trackBar_speed.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 238);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_comp);
            this.Controls.Add(this.label_mesage);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.user_panel_bum);
            this.Controls.Add(this.user_panel_noz);
            this.Controls.Add(this.user_panel_kam);
            this.Controls.Add(this.trackBar_speed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Камень-Ножницы-Бумага";
            this.user_panel_kam.ResumeLayout(false);
            this.user_panel_noz.ResumeLayout(false);
            this.user_panel_bum.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox_kam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox_noz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox_bum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_pictureBox_kam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_pictureBox_noz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_pictureBox_bum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel user_panel_kam;
        private System.Windows.Forms.Panel user_panel_noz;
        private System.Windows.Forms.Panel user_panel_bum;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox user_pictureBox_kam;
        private System.Windows.Forms.PictureBox user_pictureBox_noz;
        private System.Windows.Forms.PictureBox user_pictureBox_bum;
        private System.Windows.Forms.PictureBox comp_pictureBox_kam;
        private System.Windows.Forms.PictureBox comp_pictureBox_noz;
        private System.Windows.Forms.PictureBox comp_pictureBox_bum;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_mesage;
        private System.Windows.Forms.Label label_comp;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.TrackBar trackBar_speed;
    }
}

