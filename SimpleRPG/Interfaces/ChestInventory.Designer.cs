namespace SimpleRPG
{
    partial class ChestInventory
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
            lcb_entity_inventory = new CheckedListBox();
            lcb_chest_inventory = new CheckedListBox();
            takeAllToChest = new Button();
            takeAllToEntity = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lcb_entity_inventory
            // 
            lcb_entity_inventory.BackColor = Color.FromArgb(25, 25, 25);
            lcb_entity_inventory.BorderStyle = BorderStyle.FixedSingle;
            lcb_entity_inventory.Font = new Font("Candara", 12F);
            lcb_entity_inventory.ForeColor = Color.FromArgb(255, 128, 0);
            lcb_entity_inventory.FormattingEnabled = true;
            lcb_entity_inventory.Location = new Point(12, 35);
            lcb_entity_inventory.Name = "lcb_entity_inventory";
            lcb_entity_inventory.RightToLeft = RightToLeft.Yes;
            lcb_entity_inventory.Size = new Size(200, 354);
            lcb_entity_inventory.TabIndex = 0;
            lcb_entity_inventory.TabStop = false;
            lcb_entity_inventory.SelectedIndexChanged += entity_inventory_SelectedIndexChanged;
            // 
            // lcb_chest_inventory
            // 
            lcb_chest_inventory.BackColor = Color.FromArgb(25, 25, 25);
            lcb_chest_inventory.BorderStyle = BorderStyle.FixedSingle;
            lcb_chest_inventory.Font = new Font("Candara", 12F);
            lcb_chest_inventory.ForeColor = Color.FromArgb(255, 128, 0);
            lcb_chest_inventory.FormattingEnabled = true;
            lcb_chest_inventory.Location = new Point(222, 35);
            lcb_chest_inventory.Name = "lcb_chest_inventory";
            lcb_chest_inventory.Size = new Size(200, 354);
            lcb_chest_inventory.TabIndex = 1;
            lcb_chest_inventory.TabStop = false;
            lcb_chest_inventory.SelectedIndexChanged += chest_inventory_SelectedIndexChanged;
            // 
            // takeAllToChest
            // 
            takeAllToChest.FlatStyle = FlatStyle.Flat;
            takeAllToChest.ForeColor = Color.FromArgb(255, 128, 0);
            takeAllToChest.Location = new Point(12, 404);
            takeAllToChest.Name = "takeAllToChest";
            takeAllToChest.Size = new Size(167, 35);
            takeAllToChest.TabIndex = 2;
            takeAllToChest.TabStop = false;
            takeAllToChest.Text = "Перенести всё";
            takeAllToChest.UseVisualStyleBackColor = true;
            takeAllToChest.Click += takeAllToChest_Click;
            // 
            // takeAllToEntity
            // 
            takeAllToEntity.FlatStyle = FlatStyle.Flat;
            takeAllToEntity.ForeColor = Color.FromArgb(255, 128, 0);
            takeAllToEntity.Location = new Point(255, 404);
            takeAllToEntity.Name = "takeAllToEntity";
            takeAllToEntity.Size = new Size(167, 35);
            takeAllToEntity.TabIndex = 3;
            takeAllToEntity.TabStop = false;
            takeAllToEntity.Text = "Перенести всё";
            takeAllToEntity.UseVisualStyleBackColor = true;
            takeAllToEntity.Click += takeAllToEntity_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 4;
            label1.Text = "Инвентарь";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(358, 9);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 5;
            label2.Text = "Сундук";
            // 
            // ChestInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(434, 451);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(takeAllToEntity);
            Controls.Add(takeAllToChest);
            Controls.Add(lcb_chest_inventory);
            Controls.Add(lcb_entity_inventory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChestInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сундук";
            KeyUp += KeyHandler;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox lcb_entity_inventory;
        private CheckedListBox lcb_chest_inventory;
        private Button takeAllToChest;
        private Button takeAllToEntity;
        private Label label1;
        private Label label2;
    }
}