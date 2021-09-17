
namespace UI
{
    partial class PhoneDirectory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewPhoneDirectory = new System.Windows.Forms.DataGridView();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhoneDirectory)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(424, 84);
            this.panelHeader.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewPhoneDirectory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 366);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewPhoneDirectory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewPhoneDirectory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPhoneDirectory.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewPhoneDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhoneDirectory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.PhoneCol,
            this.AddressCol});
            this.dataGridViewPhoneDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPhoneDirectory.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPhoneDirectory.Name = "dataGridViewPhoneDirectory";
            this.dataGridViewPhoneDirectory.RowHeadersVisible = false;
            this.dataGridViewPhoneDirectory.RowTemplate.Height = 25;
            this.dataGridViewPhoneDirectory.Size = new System.Drawing.Size(424, 366);
            this.dataGridViewPhoneDirectory.TabIndex = 0;
            this.dataGridViewPhoneDirectory.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhoneDirectory_CellEndEdit);
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PhoneCol
            // 
            this.PhoneCol.HeaderText = "Phone Number";
            this.PhoneCol.Name = "PhoneCol";
            this.PhoneCol.Width = 120;
            // 
            // AddressCol
            // 
            this.AddressCol.HeaderText = "Address";
            this.AddressCol.Name = "AddressCol";
            this.AddressCol.Width = 200;
            // 
            // PhoneDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "PhoneDirectory";
            this.Text = "PhoneDirectory";
            this.Load += new System.EventHandler(this.PhoneDirectory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhoneDirectory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewPhoneDirectory;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressCol;
    }
}

