namespace CatchButton
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
            runningman = new Button();
            SuspendLayout();
            // 
            // runningman
            // 
            runningman.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            runningman.ForeColor = Color.FromArgb(192, 0, 192);
            runningman.Location = new Point(193, 107);
            runningman.Name = "runningman";
            runningman.Size = new Size(355, 183);
            runningman.TabIndex = 0;
            runningman.Text = "나를 잡아봐";
            runningman.UseVisualStyleBackColor = true;
            runningman.Click += runningman_Click;
            runningman.MouseEnter += runningman_MouseEnter;
            runningman.MouseLeave += runningman_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(runningman);
            Name = "Form1";
            Text = "버튼잡기게임";
            ResumeLayout(false);
        }

        #endregion

        private Button runningman;
    }
}
