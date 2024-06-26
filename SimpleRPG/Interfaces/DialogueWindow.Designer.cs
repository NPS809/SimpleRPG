﻿namespace SimpleRPG.Interfaces
{
    partial class DialogueWindow
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btn_exit = new Button();
            textbox = new TextBox();
            answers = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 27);
            label1.TabIndex = 0;
            label1.Text = "Торговец";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(35, 35, 35);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(472, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 296);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(472, 341);
            button1.Name = "button1";
            button1.Size = new Size(200, 37);
            button1.TabIndex = 4;
            button1.Text = "Торговать";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_exit.ForeColor = Color.FromArgb(255, 128, 0);
            btn_exit.Location = new Point(472, 384);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(200, 37);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Выход";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // textbox
            // 
            textbox.BackColor = Color.FromArgb(35, 35, 35);
            textbox.BorderStyle = BorderStyle.FixedSingle;
            textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textbox.ForeColor = Color.FromArgb(255, 128, 0);
            textbox.Location = new Point(12, 39);
            textbox.Multiline = true;
            textbox.Name = "textbox";
            textbox.ReadOnly = true;
            textbox.Size = new Size(454, 233);
            textbox.TabIndex = 6;
            // 
            // answers
            // 
            answers.BackColor = Color.FromArgb(35, 35, 35);
            answers.BorderStyle = BorderStyle.FixedSingle;
            answers.FlowDirection = FlowDirection.TopDown;
            answers.Location = new Point(12, 278);
            answers.Name = "answers";
            answers.Size = new Size(454, 143);
            answers.TabIndex = 7;
            // 
            // DialogueWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(684, 433);
            ControlBox = false;
            Controls.Add(answers);
            Controls.Add(textbox);
            Controls.Add(btn_exit);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DialogueWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Болтовнёжка";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button btn_exit;
        private TextBox textbox;
        private FlowLayoutPanel answers;
    }
}