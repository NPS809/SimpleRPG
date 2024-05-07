namespace SimpleRPG.Interfaces
{
    partial class SpeechWindow
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
            textbox = new TextBox();
            SuspendLayout();
            // 
            // textbox
            // 
            textbox.BackColor = Color.FromArgb(35, 35, 35);
            textbox.BorderStyle = BorderStyle.FixedSingle;
            textbox.Dock = DockStyle.Fill;
            textbox.ForeColor = Color.FromArgb(255, 128, 0);
            textbox.Location = new Point(10, 10);
            textbox.Margin = new Padding(4);
            textbox.Multiline = true;
            textbox.Name = "textbox";
            textbox.ReadOnly = true;
            textbox.Size = new Size(623, 189);
            textbox.TabIndex = 0;
            textbox.TabStop = false;
            // 
            // SpeechWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(643, 209);
            ControlBox = false;
            Controls.Add(textbox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SpeechWindow";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.Manual;
            Text = "SpeechWindow";
            KeyUp += SpeechWindow_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox;
    }
}