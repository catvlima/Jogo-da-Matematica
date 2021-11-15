namespace Jogo_da_Matemática
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TimeLeft = new System.Windows.Forms.Label();
            this.lbl_AddLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_AddRight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Add = new System.Windows.Forms.TextBox();
            this.bt_Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_Sub = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_SubRight = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_SubLeft = new System.Windows.Forms.Label();
            this.txt_Mult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_MultRight = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_MultLeft = new System.Windows.Forms.Label();
            this.txt_Div = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_DivRight = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_DivLeft = new System.Windows.Forms.Label();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faltam:";
            // 
            // lbl_TimeLeft
            // 
            this.lbl_TimeLeft.AutoSize = true;
            this.lbl_TimeLeft.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeLeft.Location = new System.Drawing.Point(174, 30);
            this.lbl_TimeLeft.Name = "lbl_TimeLeft";
            this.lbl_TimeLeft.Size = new System.Drawing.Size(27, 27);
            this.lbl_TimeLeft.TabIndex = 1;
            this.lbl_TimeLeft.Text = "#";
            // 
            // lbl_AddLeft
            // 
            this.lbl_AddLeft.AutoSize = true;
            this.lbl_AddLeft.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddLeft.Location = new System.Drawing.Point(43, 93);
            this.lbl_AddLeft.Name = "lbl_AddLeft";
            this.lbl_AddLeft.Size = new System.Drawing.Size(38, 43);
            this.lbl_AddLeft.TabIndex = 2;
            this.lbl_AddLeft.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            // 
            // lbl_AddRight
            // 
            this.lbl_AddRight.AutoSize = true;
            this.lbl_AddRight.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddRight.Location = new System.Drawing.Point(206, 93);
            this.lbl_AddRight.Name = "lbl_AddRight";
            this.lbl_AddRight.Size = new System.Drawing.Size(38, 43);
            this.lbl_AddRight.TabIndex = 4;
            this.lbl_AddRight.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 43);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            // 
            // txt_Add
            // 
            this.txt_Add.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Add.Location = new System.Drawing.Point(365, 93);
            this.txt_Add.Name = "txt_Add";
            this.txt_Add.Size = new System.Drawing.Size(100, 48);
            this.txt_Add.TabIndex = 2;
            this.txt_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_Start
            // 
            this.bt_Start.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Start.Location = new System.Drawing.Point(51, 369);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(169, 51);
            this.bt_Start.TabIndex = 1;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_Sub
            // 
            this.txt_Sub.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sub.Location = new System.Drawing.Point(365, 159);
            this.txt_Sub.Name = "txt_Sub";
            this.txt_Sub.Size = new System.Drawing.Size(100, 48);
            this.txt_Sub.TabIndex = 3;
            this.txt_Sub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 43);
            this.label3.TabIndex = 12;
            this.label3.Text = "=";
            // 
            // lbl_SubRight
            // 
            this.lbl_SubRight.AutoSize = true;
            this.lbl_SubRight.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubRight.Location = new System.Drawing.Point(206, 159);
            this.lbl_SubRight.Name = "lbl_SubRight";
            this.lbl_SubRight.Size = new System.Drawing.Size(38, 43);
            this.lbl_SubRight.TabIndex = 11;
            this.lbl_SubRight.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 43);
            this.label6.TabIndex = 10;
            this.label6.Text = "-";
            // 
            // lbl_SubLeft
            // 
            this.lbl_SubLeft.AutoSize = true;
            this.lbl_SubLeft.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubLeft.Location = new System.Drawing.Point(43, 159);
            this.lbl_SubLeft.Name = "lbl_SubLeft";
            this.lbl_SubLeft.Size = new System.Drawing.Size(38, 43);
            this.lbl_SubLeft.TabIndex = 9;
            this.lbl_SubLeft.Text = "?";
            // 
            // txt_Mult
            // 
            this.txt_Mult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mult.Location = new System.Drawing.Point(365, 230);
            this.txt_Mult.Name = "txt_Mult";
            this.txt_Mult.Size = new System.Drawing.Size(100, 48);
            this.txt_Mult.TabIndex = 4;
            this.txt_Mult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(283, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 43);
            this.label8.TabIndex = 17;
            this.label8.Text = "=";
            // 
            // lbl_MultRight
            // 
            this.lbl_MultRight.AutoSize = true;
            this.lbl_MultRight.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MultRight.Location = new System.Drawing.Point(206, 230);
            this.lbl_MultRight.Name = "lbl_MultRight";
            this.lbl_MultRight.Size = new System.Drawing.Size(38, 43);
            this.lbl_MultRight.TabIndex = 16;
            this.lbl_MultRight.Text = "?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(122, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 43);
            this.label10.TabIndex = 15;
            this.label10.Text = "x";
            // 
            // lbl_MultLeft
            // 
            this.lbl_MultLeft.AutoSize = true;
            this.lbl_MultLeft.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MultLeft.Location = new System.Drawing.Point(43, 230);
            this.lbl_MultLeft.Name = "lbl_MultLeft";
            this.lbl_MultLeft.Size = new System.Drawing.Size(38, 43);
            this.lbl_MultLeft.TabIndex = 14;
            this.lbl_MultLeft.Text = "?";
            // 
            // txt_Div
            // 
            this.txt_Div.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Div.Location = new System.Drawing.Point(365, 299);
            this.txt_Div.Name = "txt_Div";
            this.txt_Div.Size = new System.Drawing.Size(100, 48);
            this.txt_Div.TabIndex = 5;
            this.txt_Div.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(283, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 43);
            this.label12.TabIndex = 22;
            this.label12.Text = "=";
            // 
            // lbl_DivRight
            // 
            this.lbl_DivRight.AutoSize = true;
            this.lbl_DivRight.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DivRight.Location = new System.Drawing.Point(206, 299);
            this.lbl_DivRight.Name = "lbl_DivRight";
            this.lbl_DivRight.Size = new System.Drawing.Size(38, 43);
            this.lbl_DivRight.TabIndex = 21;
            this.lbl_DivRight.Text = "?";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(122, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 43);
            this.label14.TabIndex = 20;
            this.label14.Text = "/";
            // 
            // lbl_DivLeft
            // 
            this.lbl_DivLeft.AutoSize = true;
            this.lbl_DivLeft.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DivLeft.Location = new System.Drawing.Point(43, 299);
            this.lbl_DivLeft.Name = "lbl_DivLeft";
            this.lbl_DivLeft.Size = new System.Drawing.Size(38, 43);
            this.lbl_DivLeft.TabIndex = 19;
            this.lbl_DivLeft.Text = "?";
            // 
            // bt_Stop
            // 
            this.bt_Stop.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Stop.Location = new System.Drawing.Point(296, 369);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(169, 51);
            this.bt_Stop.TabIndex = 23;
            this.bt_Stop.Text = "Stop";
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(528, 444);
            this.Controls.Add(this.bt_Stop);
            this.Controls.Add(this.txt_Div);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_DivRight);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_DivLeft);
            this.Controls.Add(this.txt_Mult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_MultRight);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_MultLeft);
            this.Controls.Add(this.txt_Sub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_SubRight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_SubLeft);
            this.Controls.Add(this.bt_Start);
            this.Controls.Add(this.txt_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_AddRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_AddLeft);
            this.Controls.Add(this.lbl_TimeLeft);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Matemática";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TimeLeft;
        private System.Windows.Forms.Label lbl_AddLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_AddRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Add;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_Sub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_SubRight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_SubLeft;
        private System.Windows.Forms.TextBox txt_Mult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_MultRight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_MultLeft;
        private System.Windows.Forms.TextBox txt_Div;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_DivRight;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_DivLeft;
        private System.Windows.Forms.Button bt_Stop;
    }
}

