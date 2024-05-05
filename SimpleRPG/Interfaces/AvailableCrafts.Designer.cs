namespace SimpleRPG.Interfaces
{
    partial class AvailableCrafts
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
            acrafts_pnl = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // acrafts_pnl
            // 
            acrafts_pnl.AutoScroll = true;
            acrafts_pnl.BorderStyle = BorderStyle.FixedSingle;
            acrafts_pnl.Location = new Point(12, 29);
            acrafts_pnl.Name = "acrafts_pnl";
            acrafts_pnl.Size = new Size(260, 370);
            acrafts_pnl.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 17);
            label1.TabIndex = 1;
            label1.Text = "Нажмите на элемент, чтобы создать.";
            // 
            // AvailableCrafts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(284, 411);
            Controls.Add(label1);
            Controls.Add(acrafts_pnl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AvailableCrafts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Доступные крафты";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel acrafts_pnl;
        private Label label1;
    }
}