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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 281);
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
    }
}