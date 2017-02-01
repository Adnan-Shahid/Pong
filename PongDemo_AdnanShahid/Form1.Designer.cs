namespace PongDemo_AdnanShahid
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
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblBall = new System.Windows.Forms.Label();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.pcbPlayer = new System.Windows.Forms.PictureBox();
            this.pcbComp = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCmpScore = new System.Windows.Forms.Label();
            this.lblPlyrScore = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDegree
            // 
            this.txtDegree.Location = new System.Drawing.Point(84, 472);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(100, 20);
            this.txtDegree.TabIndex = 0;
            this.txtDegree.Text = "45";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(174, 444);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(103, 74);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Pause";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(283, 444);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 74);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblBall
            // 
            this.lblBall.AutoSize = true;
            this.lblBall.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBall.Location = new System.Drawing.Point(394, 194);
            this.lblBall.Name = "lblBall";
            this.lblBall.Size = new System.Drawing.Size(24, 23);
            this.lblBall.TabIndex = 8;
            this.lblBall.Text = "O";
            // 
            // tmrMove
            // 
            this.tmrMove.Interval = 1;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.White;
            this.btnRestart.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(501, 444);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(103, 74);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pcbPlayer
            // 
            this.pcbPlayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbPlayer.Location = new System.Drawing.Point(358, 418);
            this.pcbPlayer.Name = "pcbPlayer";
            this.pcbPlayer.Size = new System.Drawing.Size(100, 15);
            this.pcbPlayer.TabIndex = 14;
            this.pcbPlayer.TabStop = false;
            // 
            // pcbComp
            // 
            this.pcbComp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pcbComp.Location = new System.Drawing.Point(358, 1);
            this.pcbComp.Name = "pcbComp";
            this.pcbComp.Size = new System.Drawing.Size(100, 15);
            this.pcbComp.TabIndex = 15;
            this.pcbComp.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-3, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 543);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCmpScore
            // 
            this.lblCmpScore.AutoSize = true;
            this.lblCmpScore.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmpScore.Location = new System.Drawing.Point(646, 444);
            this.lblCmpScore.Name = "lblCmpScore";
            this.lblCmpScore.Size = new System.Drawing.Size(120, 22);
            this.lblCmpScore.TabIndex = 17;
            this.lblCmpScore.Text = "Computer Score";
            // 
            // lblPlyrScore
            // 
            this.lblPlyrScore.AutoSize = true;
            this.lblPlyrScore.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlyrScore.Location = new System.Drawing.Point(27, 444);
            this.lblPlyrScore.Name = "lblPlyrScore";
            this.lblPlyrScore.Size = new System.Drawing.Size(94, 22);
            this.lblPlyrScore.TabIndex = 18;
            this.lblPlyrScore.Text = "Player Score";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerScore.Location = new System.Drawing.Point(701, 469);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(18, 22);
            this.lblComputerScore.TabIndex = 19;
            this.lblComputerScore.Text = "0";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(69, 466);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(18, 22);
            this.lblPlayerScore.TabIndex = 20;
            this.lblPlayerScore.Text = "0";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(392, 444);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 74);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(808, 534);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblPlyrScore);
            this.Controls.Add(this.lblCmpScore);
            this.Controls.Add(this.pcbComp);
            this.Controls.Add(this.pcbPlayer);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblBall);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDegree);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblBall;
        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox pcbPlayer;
        private System.Windows.Forms.PictureBox pcbComp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCmpScore;
        private System.Windows.Forms.Label lblPlyrScore;
        private System.Windows.Forms.Label lblComputerScore;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Button btnExit;
    }
}

