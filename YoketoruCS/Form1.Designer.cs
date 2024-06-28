namespace YoketoruCS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTitle = new Label();
            buttonStart = new Button();
            labelGameover = new Label();
            buttonToTitle = new Button();
            labelClear = new Label();
            labelScore = new Label();
            labelTime = new Label();
            tempPlayer = new Label();
            tempItem = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("源ノ角ゴシック Code JP H", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(89, 63);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(286, 70);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "よけとるVS";
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("源ノ角ゴシック Code JP H", 24F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.Location = new Point(123, 136);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(219, 66);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "スタート!!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelGameover
            // 
            labelGameover.AutoSize = true;
            labelGameover.Font = new Font("源ノ角ゴシック Code JP H", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelGameover.Location = new Point(128, 63);
            labelGameover.Name = "labelGameover";
            labelGameover.Size = new Size(209, 46);
            labelGameover.TabIndex = 2;
            labelGameover.Text = "GAME OVER";
            // 
            // buttonToTitle
            // 
            buttonToTitle.Font = new Font("源ノ角ゴシック Code JP H", 24F, FontStyle.Regular, GraphicsUnit.Point);
            buttonToTitle.Location = new Point(123, 136);
            buttonToTitle.Name = "buttonToTitle";
            buttonToTitle.Size = new Size(219, 66);
            buttonToTitle.TabIndex = 3;
            buttonToTitle.Text = "タイトルへ";
            buttonToTitle.UseVisualStyleBackColor = true;
            buttonToTitle.Click += buttonToTitle_Click;
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Font = new Font("源ノ角ゴシック Code JP H", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelClear.Location = new Point(149, 63);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(167, 46);
            labelClear.TabIndex = 4;
            labelClear.Text = "CLEAR!!";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("源ノ角ゴシック Code JP H", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.Location = new Point(218, 9);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(29, 32);
            labelScore.TabIndex = 5;
            labelScore.Text = "0";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("源ノ角ゴシック Code JP H", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.Location = new Point(369, 226);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(83, 46);
            labelTime.TabIndex = 6;
            labelTime.Text = "200";
            // 
            // tempPlayer
            // 
            tempPlayer.AutoSize = true;
            tempPlayer.Font = new Font("源ノ角ゴシック Code JP H", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tempPlayer.Location = new Point(35, 207);
            tempPlayer.Name = "tempPlayer";
            tempPlayer.Size = new Size(75, 23);
            tempPlayer.TabIndex = 7;
            tempPlayer.Text = "(・ω・)";
            // 
            // tempItem
            // 
            tempItem.AutoSize = true;
            tempItem.Font = new Font("源ノ角ゴシック Code JP H", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tempItem.ForeColor = Color.FromArgb(255, 128, 0);
            tempItem.Location = new Point(128, 226);
            tempItem.Name = "tempItem";
            tempItem.Size = new Size(36, 32);
            tempItem.TabIndex = 8;
            tempItem.Text = "★";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("源ノ角ゴシック Code JP H", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(218, 226);
            label3.Name = "label3";
            label3.Size = new Size(26, 23);
            label3.TabIndex = 9;
            label3.Text = "◆";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 281);
            Controls.Add(label3);
            Controls.Add(tempItem);
            Controls.Add(tempPlayer);
            Controls.Add(labelTime);
            Controls.Add(labelScore);
            Controls.Add(labelClear);
            Controls.Add(buttonToTitle);
            Controls.Add(buttonStart);
            Controls.Add(labelGameover);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label labelTitle;
        private Button buttonStart;
        private Label labelGameover;
        private Button buttonToTitle;
        private Label labelClear;
        private Label labelScore;
        private Label labelTime;
        private Label tempPlayer;
        private Label tempItem;
        private Label label3;
    }
}