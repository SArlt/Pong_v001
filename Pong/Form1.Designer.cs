namespace Pong
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_player1 = new System.Windows.Forms.Panel();
            this.pnl_player2 = new System.Windows.Forms.Panel();
            this.pnl_ball = new System.Windows.Forms.Panel();
            this.lbl_counter1 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.tmr_ball = new System.Windows.Forms.Timer(this.components);
            this.lbl_counter2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl_player1
            // 
            this.pnl_player1.BackColor = System.Drawing.Color.White;
            this.pnl_player1.Location = new System.Drawing.Point(39, 198);
            this.pnl_player1.Name = "pnl_player1";
            this.pnl_player1.Size = new System.Drawing.Size(20, 84);
            this.pnl_player1.TabIndex = 0;
            // 
            // pnl_player2
            // 
            this.pnl_player2.BackColor = System.Drawing.Color.White;
            this.pnl_player2.Location = new System.Drawing.Point(1053, 219);
            this.pnl_player2.Name = "pnl_player2";
            this.pnl_player2.Size = new System.Drawing.Size(20, 84);
            this.pnl_player2.TabIndex = 1;
            // 
            // pnl_ball
            // 
            this.pnl_ball.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_ball.Location = new System.Drawing.Point(430, 315);
            this.pnl_ball.Name = "pnl_ball";
            this.pnl_ball.Size = new System.Drawing.Size(15, 19);
            this.pnl_ball.TabIndex = 2;
            // 
            // lbl_counter1
            // 
            this.lbl_counter1.AutoSize = true;
            this.lbl_counter1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_counter1.ForeColor = System.Drawing.Color.Lime;
            this.lbl_counter1.Location = new System.Drawing.Point(206, 28);
            this.lbl_counter1.Name = "lbl_counter1";
            this.lbl_counter1.Size = new System.Drawing.Size(24, 17);
            this.lbl_counter1.TabIndex = 0;
            this.lbl_counter1.Text = "00";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(524, 28);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(99, 32);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // tmr_ball
            // 
            this.tmr_ball.Interval = 3;
            this.tmr_ball.Tick += new System.EventHandler(this.tmr_ball_Tick);
            // 
            // lbl_counter2
            // 
            this.lbl_counter2.AutoSize = true;
            this.lbl_counter2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_counter2.ForeColor = System.Drawing.Color.Red;
            this.lbl_counter2.Location = new System.Drawing.Point(889, 28);
            this.lbl_counter2.Name = "lbl_counter2";
            this.lbl_counter2.Size = new System.Drawing.Size(24, 17);
            this.lbl_counter2.TabIndex = 4;
            this.lbl_counter2.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1116, 597);
            this.Controls.Add(this.lbl_counter2);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_counter1);
            this.Controls.Add(this.pnl_ball);
            this.Controls.Add(this.pnl_player2);
            this.Controls.Add(this.pnl_player1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_player1;
        private System.Windows.Forms.Panel pnl_player2;
        private System.Windows.Forms.Panel pnl_ball;
        private System.Windows.Forms.Label lbl_counter1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer tmr_ball;
        private System.Windows.Forms.Label lbl_counter2;
    }
}

