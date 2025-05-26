namespace ERPGameCoder
{
    partial class Projects
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

        private void InitializeComponent()
        {
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtPlatform = new System.Windows.Forms.TextBox();
            this.txtGameEngine = new System.Windows.Forms.TextBox();
            this.cmbLeadDesigner = new System.Windows.Forms.ComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.lblGameEngine = new System.Windows.Forms.Label();
            this.lblLeadDesigner = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.ReadOnly = true;
            this.dataGridViewProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProjects.Size = new System.Drawing.Size(800, 200);
            this.dataGridViewProjects.TabIndex = 0;
            this.dataGridViewProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProjects_CellClick);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(12, 240);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(200, 20);
            this.txtProjectName.TabIndex = 1;
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(12, 280);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(200, 20);
            this.txtBudget.TabIndex = 2;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(240, 240);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(200, 20);
            this.txtGenre.TabIndex = 3;
            // 
            // txtPlatform
            // 
            this.txtPlatform.Location = new System.Drawing.Point(240, 280);
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.Size = new System.Drawing.Size(200, 20);
            this.txtPlatform.TabIndex = 4;
            // 
            // txtGameEngine
            // 
            this.txtGameEngine.Location = new System.Drawing.Point(480, 240);
            this.txtGameEngine.Name = "txtGameEngine";
            this.txtGameEngine.Size = new System.Drawing.Size(200, 20);
            this.txtGameEngine.TabIndex = 5;
            // 
            // cmbLeadDesigner
            // 
            this.cmbLeadDesigner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeadDesigner.FormattingEnabled = true;
            this.cmbLeadDesigner.Location = new System.Drawing.Point(480, 280);
            this.cmbLeadDesigner.Name = "cmbLeadDesigner";
            this.cmbLeadDesigner.Size = new System.Drawing.Size(200, 21);
            this.cmbLeadDesigner.TabIndex = 6;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(12, 320);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 7;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(240, 320);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 8;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Location = new System.Drawing.Point(480, 320);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReleaseDate.TabIndex = 9;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(12, 224);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(74, 13);
            this.lblProjectName.TabIndex = 10;
            this.lblProjectName.Text = "Project Name:";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(12, 264);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(44, 13);
            this.lblBudget.TabIndex = 11;
            this.lblBudget.Text = "Budget:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(240, 224);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(39, 13);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Genre:";
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(240, 264);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(48, 13);
            this.lblPlatform.TabIndex = 13;
            this.lblPlatform.Text = "Platform:";
            // 
            // lblGameEngine
            // 
            this.lblGameEngine.AutoSize = true;
            this.lblGameEngine.Location = new System.Drawing.Point(480, 224);
            this.lblGameEngine.Name = "lblGameEngine";
            this.lblGameEngine.Size = new System.Drawing.Size(74, 13);
            this.lblGameEngine.TabIndex = 14;
            this.lblGameEngine.Text = "Game Engine:";
            // 
            // lblLeadDesigner
            // 
            this.lblLeadDesigner.AutoSize = true;
            this.lblLeadDesigner.Location = new System.Drawing.Point(480, 264);
            this.lblLeadDesigner.Name = "lblLeadDesigner";
            this.lblLeadDesigner.Size = new System.Drawing.Size(79, 13);
            this.lblLeadDesigner.TabIndex = 15;
            this.lblLeadDesigner.Text = "Lead Designer:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 304);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 16;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(240, 304);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(58, 13);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(480, 304);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(75, 13);
            this.lblReleaseDate.TabIndex = 0;
            this.lblReleaseDate.Text = "Release Date:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(723, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(723, 277);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(723, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 364);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblLeadDesigner);
            this.Controls.Add(this.lblGameEngine);
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cmbLeadDesigner);
            this.Controls.Add(this.txtGameEngine);
            this.Controls.Add(this.txtPlatform);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.dataGridViewProjects);
            this.Name = "Projects";
            this.Text = "Projects Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtPlatform;
        private System.Windows.Forms.TextBox txtGameEngine;
        private System.Windows.Forms.ComboBox cmbLeadDesigner;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Label lblGameEngine;
        private System.Windows.Forms.Label lblLeadDesigner;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}