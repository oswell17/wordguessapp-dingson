namespace wordguessapp_dingson
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
            label_word = new Label();
            textBox_guess = new TextBox();
            button_next = new Button();
            button_start = new Button();
            label_result = new Label();
            label_score = new Label();
            label_totalresult = new Label();
            SuspendLayout();
            // 
            // label_word
            // 
            label_word.BackColor = SystemColors.ControlDark;
            label_word.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_word.ForeColor = Color.White;
            label_word.Location = new Point(59, 32);
            label_word.Name = "label_word";
            label_word.Size = new Size(273, 53);
            label_word.TabIndex = 0;
            label_word.Text = "Word";
            label_word.TextAlign = ContentAlignment.MiddleCenter;
            label_word.Click += label_word_Click;
            // 
            // textBox_guess
            // 
            textBox_guess.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_guess.Location = new Point(59, 101);
            textBox_guess.Name = "textBox_guess";
            textBox_guess.Size = new Size(273, 45);
            textBox_guess.TabIndex = 1;
            textBox_guess.TextAlign = HorizontalAlignment.Center;
            // 
            // button_next
            // 
            button_next.BackColor = Color.DeepSkyBlue;
            button_next.Enabled = false;
            button_next.FlatAppearance.BorderColor = Color.Black;
            button_next.FlatStyle = FlatStyle.Flat;
            button_next.Font = new Font("Microsoft Sans Serif", 18F);
            button_next.Location = new Point(59, 161);
            button_next.Name = "button_next";
            button_next.Size = new Size(273, 52);
            button_next.TabIndex = 2;
            button_next.Text = "Next";
            button_next.UseVisualStyleBackColor = false;
            button_next.Click += button1_Click;
            // 
            // button_start
            // 
            button_start.BackColor = Color.DeepSkyBlue;
            button_start.FlatAppearance.BorderColor = Color.Black;
            button_start.FlatStyle = FlatStyle.Flat;
            button_start.Font = new Font("Microsoft Sans Serif", 18F);
            button_start.Location = new Point(59, 219);
            button_start.Name = "button_start";
            button_start.Size = new Size(273, 52);
            button_start.TabIndex = 3;
            button_start.Text = "Start";
            button_start.UseVisualStyleBackColor = false;
            button_start.Click += button_start_Click;
            // 
            // label_result
            // 
            label_result.BackColor = Color.Peru;
            label_result.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_result.Location = new Point(59, 283);
            label_result.Name = "label_result";
            label_result.Size = new Size(273, 44);
            label_result.TabIndex = 4;
            label_result.Text = "Result";
            label_result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_score
            // 
            label_score.AutoSize = true;
            label_score.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_score.Location = new Point(178, 340);
            label_score.Name = "label_score";
            label_score.Size = new Size(34, 25);
            label_score.TabIndex = 5;
            label_score.Text = "00";
            // 
            // label_totalresult
            // 
            label_totalresult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_totalresult.BackColor = Color.Khaki;
            label_totalresult.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_totalresult.ForeColor = SystemColors.ActiveCaptionText;
            label_totalresult.Location = new Point(399, 32);
            label_totalresult.Name = "label_totalresult";
            label_totalresult.Size = new Size(299, 121);
            label_totalresult.TabIndex = 6;
            label_totalresult.Text = "Click This to see Result";
            label_totalresult.Click += label_totalresult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(737, 380);
            Controls.Add(label_totalresult);
            Controls.Add(label_score);
            Controls.Add(label_result);
            Controls.Add(button_start);
            Controls.Add(button_next);
            Controls.Add(textBox_guess);
            Controls.Add(label_word);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_word;
        private TextBox textBox_guess;
        private Button button_next;
        private Button button_start;
        private Label label_result;
        private Label label_score;
        private Label label_totalresult;
    }
}
