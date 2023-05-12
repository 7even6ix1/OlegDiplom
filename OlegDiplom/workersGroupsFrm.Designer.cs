namespace OlegDiplom
{
    partial class workersGroupsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workersGroupsFrm));
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.workerBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.workersInfoPredDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthdateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NicknameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GunModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GunTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersInfoPredDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(12, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(29, 42);
            this.button6.TabIndex = 70;
            this.button6.Text = "⬅";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.button5);
            this.groupBox.Controls.Add(this.button4);
            this.groupBox.Controls.Add(this.workerBox);
            this.groupBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(1235, 133);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(143, 158);
            this.groupBox.TabIndex = 69;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Поиск по позывному";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(6, 114);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 32);
            this.button5.TabIndex = 62;
            this.button5.Text = "Сброс";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(6, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 32);
            this.button4.TabIndex = 61;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // workerBox
            // 
            this.workerBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workerBox.ForeColor = System.Drawing.Color.Black;
            this.workerBox.Location = new System.Drawing.Point(6, 42);
            this.workerBox.Name = "workerBox";
            this.workerBox.Size = new System.Drawing.Size(131, 28);
            this.workerBox.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1235, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 32);
            this.button3.TabIndex = 68;
            this.button3.Text = "Удалить строку";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1235, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 32);
            this.button2.TabIndex = 67;
            this.button2.Text = "Добавить строку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // workersInfoPredDataGridView
            // 
            this.workersInfoPredDataGridView.AllowUserToAddRows = false;
            this.workersInfoPredDataGridView.AllowUserToDeleteRows = false;
            this.workersInfoPredDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.workersInfoPredDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersInfoPredDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SurnameColumn,
            this.NameColumn,
            this.PatronymicColumn,
            this.BirthdateColumn,
            this.AddressColumn,
            this.PhoneColumn,
            this.NicknameColumn,
            this.PostColumn,
            this.GunModelColumn,
            this.GunTypeColumn,
            this.Group});
            this.workersInfoPredDataGridView.Location = new System.Drawing.Point(12, 57);
            this.workersInfoPredDataGridView.MultiSelect = false;
            this.workersInfoPredDataGridView.Name = "workersInfoPredDataGridView";
            this.workersInfoPredDataGridView.ReadOnly = true;
            this.workersInfoPredDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workersInfoPredDataGridView.Size = new System.Drawing.Size(1217, 381);
            this.workersInfoPredDataGridView.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 64;
            this.label1.Text = "Сотрудники ГБР";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Фамилия";
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // PatronymicColumn
            // 
            this.PatronymicColumn.HeaderText = "Отчество";
            this.PatronymicColumn.Name = "PatronymicColumn";
            this.PatronymicColumn.ReadOnly = true;
            // 
            // BirthdateColumn
            // 
            this.BirthdateColumn.HeaderText = "Дата рождения";
            this.BirthdateColumn.Name = "BirthdateColumn";
            this.BirthdateColumn.ReadOnly = true;
            // 
            // AddressColumn
            // 
            this.AddressColumn.HeaderText = "Адрес";
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.HeaderText = "Телефон";
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.ReadOnly = true;
            // 
            // NicknameColumn
            // 
            this.NicknameColumn.HeaderText = "Позывной";
            this.NicknameColumn.Name = "NicknameColumn";
            this.NicknameColumn.ReadOnly = true;
            // 
            // PostColumn
            // 
            this.PostColumn.HeaderText = "Должность";
            this.PostColumn.Name = "PostColumn";
            this.PostColumn.ReadOnly = true;
            // 
            // GunModelColumn
            // 
            this.GunModelColumn.HeaderText = "Модель оружия";
            this.GunModelColumn.Name = "GunModelColumn";
            this.GunModelColumn.ReadOnly = true;
            // 
            // GunTypeColumn
            // 
            this.GunTypeColumn.HeaderText = "Тип оружия";
            this.GunTypeColumn.Name = "GunTypeColumn";
            this.GunTypeColumn.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.HeaderText = "Группа";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // workersGroupsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1390, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.workersInfoPredDataGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1406, 489);
            this.Name = "workersGroupsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЧОП \"Кайман\"";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersInfoPredDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox workerBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView workersInfoPredDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthdateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NicknameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GunModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GunTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
    }
}