namespace ERPGameCoder
{
    partial class Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbTaskType = new System.Windows.Forms.ComboBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.numEstimatedHours = new System.Windows.Forms.NumericUpDown();
            this.numActualHours = new System.Windows.Forms.NumericUpDown();
            this.txtDependencies = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblEstimatedHours = new System.Windows.Forms.Label();
            this.lblActualHours = new System.Windows.Forms.Label();
            this.lblDependencies = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstimatedHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numActualHours)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTasks.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.ReadOnly = true;
            this.dataGridViewTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTasks.Size = new System.Drawing.Size(1000, 200);
            this.dataGridViewTasks.TabIndex = 0;
            this.dataGridViewTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTasks_CellClick);
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(12, 240);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(200, 20);
            this.txtTaskName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(240, 240);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 60);
            this.txtDescription.TabIndex = 2;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(480, 240);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(200, 21);
            this.cmbEmployee.TabIndex = 3;
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(700, 240);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(200, 21);
            this.cmbProject.TabIndex = 4;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(12, 280);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDueDate.TabIndex = 5;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Not Started",
            "In Progress",
            "Completed",
            "On Hold"});
            this.cmbStatus.Location = new System.Drawing.Point(240, 320);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 6;
            // 
            // cmbTaskType
            // 
            this.cmbTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskType.FormattingEnabled = true;
            this.cmbTaskType.Items.AddRange(new object[] {
            "Development",
            "Testing",
            "Design",
            "Documentation"});
            this.cmbTaskType.Location = new System.Drawing.Point(480, 320);
            this.cmbTaskType.Name = "cmbTaskType";
            this.cmbTaskType.Size = new System.Drawing.Size(200, 21);
            this.cmbTaskType.TabIndex = 7;
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Critical"});
            this.cmbPriority.Location = new System.Drawing.Point(700, 320);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(200, 21);
            this.cmbPriority.TabIndex = 8;
            // 
            // numEstimatedHours
            // 
            this.numEstimatedHours.DecimalPlaces = 2;
            this.numEstimatedHours.Location = new System.Drawing.Point(12, 360);
            this.numEstimatedHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numEstimatedHours.Name = "numEstimatedHours";
            this.numEstimatedHours.Size = new System.Drawing.Size(200, 20);
            this.numEstimatedHours.TabIndex = 9;
            // 
            // numActualHours
            // 
            this.numActualHours.DecimalPlaces = 2;
            this.numActualHours.Location = new System.Drawing.Point(240, 360);
            this.numActualHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numActualHours.Name = "numActualHours";
            this.numActualHours.Size = new System.Drawing.Size(200, 20);
            this.numActualHours.TabIndex = 10;
            // 
            // txtDependencies
            // 
            this.txtDependencies.Location = new System.Drawing.Point(480, 360);
            this.txtDependencies.Multiline = true;
            this.txtDependencies.Name = "txtDependencies";
            this.txtDependencies.Size = new System.Drawing.Size(420, 60);
            this.txtDependencies.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(12, 440);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(100, 440);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(190, 440);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.ForeColor = System.Drawing.Color.White;
            this.lblTaskName.Location = new System.Drawing.Point(12, 220);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(65, 13);
            this.lblTaskName.TabIndex = 15;
            this.lblTaskName.Text = "Task Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(240, 220);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.ForeColor = System.Drawing.Color.White;
            this.lblEmployee.Location = new System.Drawing.Point(480, 220);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(56, 13);
            this.lblEmployee.TabIndex = 17;
            this.lblEmployee.Text = "Employee:";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.ForeColor = System.Drawing.Color.White;
            this.lblProject.Location = new System.Drawing.Point(700, 220);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(43, 13);
            this.lblProject.TabIndex = 18;
            this.lblProject.Text = "Project:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.ForeColor = System.Drawing.Color.White;
            this.lblDueDate.Location = new System.Drawing.Point(12, 260);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblDueDate.TabIndex = 19;
            this.lblDueDate.Text = "Due Date:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(240, 300);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Status:";
            // 
            // lblTaskType
            // 
            this.lblTaskType.AutoSize = true;
            this.lblTaskType.ForeColor = System.Drawing.Color.White;
            this.lblTaskType.Location = new System.Drawing.Point(480, 300);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(61, 13);
            this.lblTaskType.TabIndex = 21;
            this.lblTaskType.Text = "Task Type:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.ForeColor = System.Drawing.Color.White;
            this.lblPriority.Location = new System.Drawing.Point(700, 300);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(41, 13);
            this.lblPriority.TabIndex = 22;
            this.lblPriority.Text = "Priority:";
            // 
            // lblEstimatedHours
            // 
            this.lblEstimatedHours.AutoSize = true;
            this.lblEstimatedHours.ForeColor = System.Drawing.Color.White;
            this.lblEstimatedHours.Location = new System.Drawing.Point(12, 340);
            this.lblEstimatedHours.Name = "lblEstimatedHours";
            this.lblEstimatedHours.Size = new System.Drawing.Size(87, 13);
            this.lblEstimatedHours.TabIndex = 23;
            this.lblEstimatedHours.Text = "Estimated Hours:";
            // 
            // lblActualHours
            // 
            this.lblActualHours.AutoSize = true;
            this.lblActualHours.ForeColor = System.Drawing.Color.White;
            this.lblActualHours.Location = new System.Drawing.Point(240, 340);
            this.lblActualHours.Name = "lblActualHours";
            this.lblActualHours.Size = new System.Drawing.Size(71, 13);
            this.lblActualHours.TabIndex = 24;
            this.lblActualHours.Text = "Actual Hours:";
            // 
            // lblDependencies
            // 
            this.lblDependencies.AutoSize = true;
            this.lblDependencies.ForeColor = System.Drawing.Color.White;
            this.lblDependencies.Location = new System.Drawing.Point(480, 340);
            this.lblDependencies.Name = "lblDependencies";
            this.lblDependencies.Size = new System.Drawing.Size(79, 13);
            this.lblDependencies.TabIndex = 25;
            this.lblDependencies.Text = "Dependencies:";
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 480);
            this.Controls.Add(this.dataGridViewTasks);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbTaskType);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.numEstimatedHours);
            this.Controls.Add(this.numActualHours);
            this.Controls.Add(this.txtDependencies);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTaskType);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblEstimatedHours);
            this.Controls.Add(this.lblActualHours);
            this.Controls.Add(this.lblDependencies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tasks";
            this.Text = "Production Module";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstimatedHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numActualHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbTaskType;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.NumericUpDown numEstimatedHours;
        private System.Windows.Forms.NumericUpDown numActualHours;
        private System.Windows.Forms.TextBox txtDependencies;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete; private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblEstimatedHours;
        private System.Windows.Forms.Label lblActualHours;
        private System.Windows.Forms.Label lblDependencies;

    }
}