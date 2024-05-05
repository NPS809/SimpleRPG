namespace SimpleRPG.Interfaces
{
    partial class PlayerInventory
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
            player_inventory = new FlowLayoutPanel();
            label1 = new Label();
            pnlCraft = new FlowLayoutPanel();
            label2 = new Label();
            right_hand = new FlowLayoutPanel();
            label3 = new Label();
            btn_craft = new Button();
            health = new Label();
            healthbar = new ProgressBar();
            lbl_player_name = new Label();
            SuspendLayout();
            // 
            // player_inventory
            // 
            player_inventory.AutoScroll = true;
            player_inventory.BackColor = Color.FromArgb(35, 35, 35);
            player_inventory.BorderStyle = BorderStyle.FixedSingle;
            player_inventory.Location = new Point(12, 35);
            player_inventory.Name = "player_inventory";
            player_inventory.Size = new Size(337, 314);
            player_inventory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 1;
            label1.Text = "Инвентарь";
            // 
            // pnlCraft
            // 
            pnlCraft.AutoScroll = true;
            pnlCraft.BackColor = Color.FromArgb(35, 35, 35);
            pnlCraft.BorderStyle = BorderStyle.FixedSingle;
            pnlCraft.Location = new Point(355, 35);
            pnlCraft.Name = "pnlCraft";
            pnlCraft.Size = new Size(241, 277);
            pnlCraft.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(515, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "Создание";
            // 
            // right_hand
            // 
            right_hand.AutoSize = true;
            right_hand.BackColor = Color.FromArgb(35, 35, 35);
            right_hand.BorderStyle = BorderStyle.FixedSingle;
            right_hand.Location = new Point(371, 393);
            right_hand.Name = "right_hand";
            right_hand.Size = new Size(223, 43);
            right_hand.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(497, 369);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 3;
            label3.Text = "Правая рука";
            // 
            // btn_craft
            // 
            btn_craft.FlatStyle = FlatStyle.Flat;
            btn_craft.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_craft.ForeColor = Color.FromArgb(255, 128, 0);
            btn_craft.Location = new Point(355, 318);
            btn_craft.Margin = new Padding(3, 3, 3, 20);
            btn_craft.Name = "btn_craft";
            btn_craft.Size = new Size(239, 31);
            btn_craft.TabIndex = 0;
            btn_craft.TabStop = false;
            btn_craft.Text = "Создать";
            btn_craft.UseVisualStyleBackColor = true;
            btn_craft.Click += btn_craft_Click;
            // 
            // health
            // 
            health.AutoSize = true;
            health.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            health.ForeColor = Color.FromArgb(255, 128, 0);
            health.Location = new Point(12, 401);
            health.Margin = new Padding(5);
            health.Name = "health";
            health.Size = new Size(74, 17);
            health.TabIndex = 6;
            health.Text = "Здоровье: ";
            // 
            // healthbar
            // 
            healthbar.Location = new Point(14, 426);
            healthbar.Name = "healthbar";
            healthbar.Size = new Size(351, 10);
            healthbar.TabIndex = 9;
            // 
            // lbl_player_name
            // 
            lbl_player_name.AutoSize = true;
            lbl_player_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbl_player_name.ForeColor = Color.FromArgb(255, 128, 0);
            lbl_player_name.Location = new Point(12, 352);
            lbl_player_name.Name = "lbl_player_name";
            lbl_player_name.Size = new Size(160, 21);
            lbl_player_name.TabIndex = 10;
            lbl_player_name.Text = "Игрок: {player_name}";
            // 
            // PlayerInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(608, 450);
            Controls.Add(lbl_player_name);
            Controls.Add(healthbar);
            Controls.Add(health);
            Controls.Add(btn_craft);
            Controls.Add(label3);
            Controls.Add(right_hand);
            Controls.Add(pnlCraft);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(player_inventory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "PlayerInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Инвентарь";
            FormClosing += PlayerInventory_FormClosing;
            KeyUp += KeyHandler;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel player_inventory;
        private Label label1;
        private FlowLayoutPanel pnlCraft;
        private Label label2;
        private FlowLayoutPanel right_hand;
        private Label label3;
        private Button btn_craft;
        private Label health;
        private ProgressBar healthbar;
        private Label lbl_player_name;
    }
}