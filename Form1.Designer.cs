namespace Osama_Tic_Tac_Toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_PlayerTurn = new System.Windows.Forms.Label();
            this.lb_GameWinner = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GameBtn2 = new System.Windows.Forms.Button();
            this.GameBtn3 = new System.Windows.Forms.Button();
            this.GameBtn4 = new System.Windows.Forms.Button();
            this.GameBtn5 = new System.Windows.Forms.Button();
            this.GameBtn6 = new System.Windows.Forms.Button();
            this.GameBtn7 = new System.Windows.Forms.Button();
            this.GameBtn8 = new System.Windows.Forms.Button();
            this.GameBtn9 = new System.Windows.Forms.Button();
            this.GameBtn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(483, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic - Tac - Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(126, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(96, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "Winner";
            // 
            // lb_PlayerTurn
            // 
            this.lb_PlayerTurn.AutoSize = true;
            this.lb_PlayerTurn.Font = new System.Drawing.Font("Tahoma", 27F, System.Drawing.FontStyle.Bold);
            this.lb_PlayerTurn.ForeColor = System.Drawing.Color.White;
            this.lb_PlayerTurn.Location = new System.Drawing.Point(59, 275);
            this.lb_PlayerTurn.Name = "lb_PlayerTurn";
            this.lb_PlayerTurn.Size = new System.Drawing.Size(286, 54);
            this.lb_PlayerTurn.TabIndex = 12;
            this.lb_PlayerTurn.Text = "Player Turn";
            // 
            // lb_GameWinner
            // 
            this.lb_GameWinner.AutoSize = true;
            this.lb_GameWinner.Font = new System.Drawing.Font("Tahoma", 27F, System.Drawing.FontStyle.Bold);
            this.lb_GameWinner.ForeColor = System.Drawing.Color.Lime;
            this.lb_GameWinner.Location = new System.Drawing.Point(48, 488);
            this.lb_GameWinner.Name = "lb_GameWinner";
            this.lb_GameWinner.Size = new System.Drawing.Size(332, 54);
            this.lb_GameWinner.TabIndex = 13;
            this.lb_GameWinner.Text = "Game Winner";
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("LCDMono2", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(71, 611);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(274, 85);
            this.button10.TabIndex = 3;
            this.button10.Text = "Restart Game";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Osama_Tic_Tac_Toe.Properties.Resources.my_logo;
            this.pictureBox1.Location = new System.Drawing.Point(32, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // GameBtn2
            // 
            this.GameBtn2.BackColor = System.Drawing.Color.Black;
            this.GameBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameBtn2.Image = global::Osama_Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.GameBtn2.Location = new System.Drawing.Point(652, 194);
            this.GameBtn2.Name = "GameBtn2";
            this.GameBtn2.Size = new System.Drawing.Size(147, 119);
            this.GameBtn2.TabIndex = 11;
            this.GameBtn2.Tag = "?";
            this.GameBtn2.UseVisualStyleBackColor = false;
            this.GameBtn2.Click += new System.EventHandler(this.GameBtn2_Click);
            // 
            // GameBtn3
            // 
            this.GameBtn3.BackColor = System.Drawing.Color.Black;
            this.GameBtn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameBtn3.Image = global::Osama_Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.GameBtn3.Location = new System.Drawing.Point(885, 194);
            this.GameBtn3.Name = "GameBtn3";
            this.GameBtn3.Size = new System.Drawing.Size(147, 119);
            this.GameBtn3.TabIndex = 10;
            this.GameBtn3.Tag = "?";
            this.GameBtn3.UseVisualStyleBackColor = false;
            this.GameBtn3.Click += new System.EventHandler(this.GameBtn3_Click);
            // 
            // GameBtn4
            // 
            this.GameBtn4.BackColor = System.Drawing.Color.Black;
            this.GameBtn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameBtn4.Image = global::Osama_Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.GameBtn4.Location = new System.Drawing.Point(419, 376);
            this.GameBtn4.Name = "GameBtn4";
            this.GameBtn4.Size = new System.Drawing.Size(147, 119);
            this.GameBtn4.TabIndex = 9;
            this.GameBtn4.Tag = "?";
            this.GameBtn4.UseVisualStyleBackColor = false;
            this.GameBtn4.Click += new System.EventHandler(this.GameBtn4_Click);
            // 
            // GameBtn5
            // 
            this.GameBtn5.BackColor = System.Drawing.Color.Black;
            this.GameBtn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameBtn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameBtn5.Image = global::Osama_Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.GameBtn5.Location = new System.Drawing.Point(652, 372);
            this.GameBtn5.Name = "GameBtn5";
            this.GameBtn5.Size = new System.Drawing.Size(147, 119);
            this.GameBtn5.TabIndex = 8;
            this.GameBtn5.Tag = "?";
            this.GameBtn5.UseVisualStyleBackColor = false;
            this.GameBtn5.Click += new System.EventHandler(this.GameBtn5_Click);
            // 
            // GameBtn6
            // 
            this.GameBtn6.BackColor = System.Drawing.Color.Black;
            this.GameBtn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameBtn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameBtn6.Image = global::Osama_Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.GameBtn6.Location = new System.Drawing.Point(885, 376);
            this.GameBtn6.Name = "GameBtn6";
            this.GameBtn6.Size = new System.Drawing.Size(147, 119);
            this.GameBtn6.TabIndex = 7;
            this.GameBtn6.Tag = "?";
            this.GameBtn6.UseVisualStyleBackColor = false;
            this.GameBtn6.Click += new System.EventHandler(this.GameBtn6_Click);
            // 
            // GameBtn7
            // 
            this.GameBtn7.BackColor = System.Drawing.Color.Black;
            this.GameBtn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameBtn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameBtn7.Image = global::Osama_Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.GameBtn7.Location = new System.Drawing.Point(419, 558);
            this.GameBtn7.Name = "GameBtn7";
            this.GameBtn7.Size = new System.Drawing.Size(147, 119);
            this.GameBtn7.TabIndex = 6;
            this.GameBtn7.Tag = "?";
            this.GameBtn7.UseVisualStyleBackColor = false;
            this.GameBtn7.Click += new System.EventHandler(this.GameBtn7_Click);
            // 
            // GameBtn8
            // 
            this.GameBtn8.BackColor = System.Drawing.Color.Black;
            this.GameBtn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameBtn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameBtn8.Image = global::Osama_Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.GameBtn8.Location = new System.Drawing.Point(652, 550);
            this.GameBtn8.Name = "GameBtn8";
            this.GameBtn8.Size = new System.Drawing.Size(147, 119);
            this.GameBtn8.TabIndex = 5;
            this.GameBtn8.Tag = "?";
            this.GameBtn8.UseVisualStyleBackColor = false;
            this.GameBtn8.Click += new System.EventHandler(this.GameBtn8_Click);
            // 
            // GameBtn9
            // 
            this.GameBtn9.BackColor = System.Drawing.Color.Black;
            this.GameBtn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameBtn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameBtn9.Image = global::Osama_Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.GameBtn9.Location = new System.Drawing.Point(885, 558);
            this.GameBtn9.Name = "GameBtn9";
            this.GameBtn9.Size = new System.Drawing.Size(147, 119);
            this.GameBtn9.TabIndex = 4;
            this.GameBtn9.Tag = "?";
            this.GameBtn9.UseVisualStyleBackColor = false;
            this.GameBtn9.Click += new System.EventHandler(this.GameBtn9_Click);
            // 
            // GameBtn1
            // 
            this.GameBtn1.BackColor = System.Drawing.Color.Black;
            this.GameBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameBtn1.Image = global::Osama_Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.GameBtn1.Location = new System.Drawing.Point(419, 194);
            this.GameBtn1.Name = "GameBtn1";
            this.GameBtn1.Size = new System.Drawing.Size(147, 119);
            this.GameBtn1.TabIndex = 14;
            this.GameBtn1.Tag = "?";
            this.GameBtn1.UseVisualStyleBackColor = false;
            this.GameBtn1.Click += new System.EventHandler(this.GameBtn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1136, 736);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.lb_GameWinner);
            this.Controls.Add(this.lb_PlayerTurn);
            this.Controls.Add(this.GameBtn2);
            this.Controls.Add(this.GameBtn3);
            this.Controls.Add(this.GameBtn4);
            this.Controls.Add(this.GameBtn5);
            this.Controls.Add(this.GameBtn6);
            this.Controls.Add(this.GameBtn7);
            this.Controls.Add(this.GameBtn8);
            this.Controls.Add(this.GameBtn9);
            this.Controls.Add(this.GameBtn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GameBtn1;
        private System.Windows.Forms.Button GameBtn9;
        private System.Windows.Forms.Button GameBtn8;
        private System.Windows.Forms.Button GameBtn7;
        private System.Windows.Forms.Button GameBtn6;
        private System.Windows.Forms.Button GameBtn5;
        private System.Windows.Forms.Button GameBtn4;
        private System.Windows.Forms.Button GameBtn3;
        private System.Windows.Forms.Button GameBtn2;
        private System.Windows.Forms.Label lb_PlayerTurn;
        private System.Windows.Forms.Label lb_GameWinner;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

