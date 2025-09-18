namespace TicTacToe
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

        /*
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        */



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.singlePlayerBtn = new System.Windows.Forms.Button();
            this.multiPlayerBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.playerTurnLbl = new System.Windows.Forms.Label();
            this.square0_0 = new System.Windows.Forms.Button();
            this.square0_1 = new System.Windows.Forms.Button();
            this.square0_2 = new System.Windows.Forms.Button();
            this.square1_0 = new System.Windows.Forms.Button();
            this.square1_1 = new System.Windows.Forms.Button();
            this.square1_2 = new System.Windows.Forms.Button();
            this.square2_0 = new System.Windows.Forms.Button();
            this.square2_1 = new System.Windows.Forms.Button();
            this.square2_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // singlePlayerBtn
            // 
            this.singlePlayerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singlePlayerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.singlePlayerBtn.Location = new System.Drawing.Point(308, 515);
            this.singlePlayerBtn.Name = "singlePlayerBtn";
            this.singlePlayerBtn.Size = new System.Drawing.Size(164, 40);
            this.singlePlayerBtn.TabIndex = 1;
            this.singlePlayerBtn.Text = "Single Player";
            this.singlePlayerBtn.UseVisualStyleBackColor = true;
            this.singlePlayerBtn.Click += new System.EventHandler(this.singlePlayerBtn_Click);
            // 
            // multiPlayerBtn
            // 
            this.multiPlayerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiPlayerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.multiPlayerBtn.Location = new System.Drawing.Point(543, 515);
            this.multiPlayerBtn.Name = "multiPlayerBtn";
            this.multiPlayerBtn.Size = new System.Drawing.Size(160, 40);
            this.multiPlayerBtn.TabIndex = 2;
            this.multiPlayerBtn.Text = "Multiplayer";
            this.multiPlayerBtn.UseVisualStyleBackColor = true;
            this.multiPlayerBtn.Click += new System.EventHandler(this.multiPlayerBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.resetBtn.Location = new System.Drawing.Point(453, 578);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(106, 40);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // playerTurnLbl
            // 
            this.playerTurnLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.playerTurnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.playerTurnLbl.Location = new System.Drawing.Point(12, 127);
            this.playerTurnLbl.Name = "playerTurnLbl";
            this.playerTurnLbl.Size = new System.Drawing.Size(205, 37);
            this.playerTurnLbl.TabIndex = 13;
            // 
            // square0_0
            // 
            this.square0_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.square0_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.square0_0.Location = new System.Drawing.Point(261, 114);
            this.square0_0.Name = "square0_0";
            this.square0_0.Size = new System.Drawing.Size(154, 116);
            this.square0_0.TabIndex = 14;
            this.square0_0.UseVisualStyleBackColor = true;
            this.square0_0.Click += new System.EventHandler(this.square0_0_Click);
            // 
            // square0_1
            // 
            this.square0_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.square0_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.square0_1.Location = new System.Drawing.Point(421, 114);
            this.square0_1.Name = "square0_1";
            this.square0_1.Size = new System.Drawing.Size(154, 116);
            this.square0_1.TabIndex = 15;
            this.square0_1.UseVisualStyleBackColor = true;
            this.square0_1.Click += new System.EventHandler(this.square0_1_Click);
            // 
            // square0_2
            // 
            this.square0_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.square0_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.square0_2.Location = new System.Drawing.Point(581, 114);
            this.square0_2.Name = "square0_2";
            this.square0_2.Size = new System.Drawing.Size(154, 116);
            this.square0_2.TabIndex = 16;
            this.square0_2.UseVisualStyleBackColor = true;
            this.square0_2.Click += new System.EventHandler(this.square0_2_Click);
            // 
            // square1_0
            // 
            this.square1_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.square1_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.square1_0.Location = new System.Drawing.Point(261, 236);
            this.square1_0.Name = "square1_0";
            this.square1_0.Size = new System.Drawing.Size(154, 116);
            this.square1_0.TabIndex = 17;
            this.square1_0.UseVisualStyleBackColor = true;
            this.square1_0.Click += new System.EventHandler(this.square1_0_Click);
            // 
            // square1_1
            // 
            this.square1_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.square1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.square1_1.Location = new System.Drawing.Point(421, 236);
            this.square1_1.Name = "square1_1";
            this.square1_1.Size = new System.Drawing.Size(154, 116);
            this.square1_1.TabIndex = 18;
            this.square1_1.UseVisualStyleBackColor = true;
            this.square1_1.Click += new System.EventHandler(this.square1_1_Click);
            // 
            // square1_2
            // 
            this.square1_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.square1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.square1_2.Location = new System.Drawing.Point(581, 236);
            this.square1_2.Name = "square1_2";
            this.square1_2.Size = new System.Drawing.Size(154, 116);
            this.square1_2.TabIndex = 19;
            this.square1_2.UseVisualStyleBackColor = true;
            this.square1_2.Click += new System.EventHandler(this.square1_2_Click);
            // 
            // square2_0
            // 
            this.square2_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.square2_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.square2_0.Location = new System.Drawing.Point(261, 358);
            this.square2_0.Name = "square2_0";
            this.square2_0.Size = new System.Drawing.Size(154, 116);
            this.square2_0.TabIndex = 20;
            this.square2_0.UseVisualStyleBackColor = true;
            this.square2_0.Click += new System.EventHandler(this.square2_0_Click);
            // 
            // square2_1
            // 
            this.square2_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.square2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.square2_1.Location = new System.Drawing.Point(421, 358);
            this.square2_1.Name = "square2_1";
            this.square2_1.Size = new System.Drawing.Size(154, 116);
            this.square2_1.TabIndex = 21;
            this.square2_1.UseVisualStyleBackColor = true;
            this.square2_1.Click += new System.EventHandler(this.square2_1_Click);
            // 
            // square2_2
            // 
            this.square2_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.square2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.square2_2.Location = new System.Drawing.Point(581, 358);
            this.square2_2.Name = "square2_2";
            this.square2_2.Size = new System.Drawing.Size(154, 116);
            this.square2_2.TabIndex = 22;
            this.square2_2.UseVisualStyleBackColor = true;
            this.square2_2.Click += new System.EventHandler(this.square2_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.bearBackground;
            this.ClientSize = new System.Drawing.Size(997, 674);
            this.Controls.Add(this.square2_2);
            this.Controls.Add(this.square2_1);
            this.Controls.Add(this.square2_0);
            this.Controls.Add(this.square1_2);
            this.Controls.Add(this.square1_1);
            this.Controls.Add(this.square1_0);
            this.Controls.Add(this.square0_2);
            this.Controls.Add(this.square0_1);
            this.Controls.Add(this.square0_0);
            this.Controls.Add(this.playerTurnLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.multiPlayerBtn);
            this.Controls.Add(this.singlePlayerBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);

        }





        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button singlePlayerBtn;
        private System.Windows.Forms.Button multiPlayerBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label playerTurnLbl;
        private System.Windows.Forms.Button square0_0;
        private System.Windows.Forms.Button square0_1;
        private System.Windows.Forms.Button square0_2;
        private System.Windows.Forms.Button square1_0;
        private System.Windows.Forms.Button square1_1;
        private System.Windows.Forms.Button square1_2;
        private System.Windows.Forms.Button square2_0;
        private System.Windows.Forms.Button square2_1;
        private System.Windows.Forms.Button square2_2;
    }
}

