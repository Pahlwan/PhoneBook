
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dataGridViewPhoneDirectory = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhoneDirectory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Teal;
            this.panelHeader.Controls.Add(this.buttonSearch);
            this.panelHeader.Controls.Add(this.textBoxSearch);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(424, 54);
            this.panelHeader.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackgroundImage = global::UI.Resources.icons8_search_50;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(381, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(30, 30);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSearch_MouseDown);
            this.buttonSearch.MouseLeave += new System.EventHandler(this.buttonSearch_MouseLeave);
            this.buttonSearch.MouseHover += new System.EventHandler(this.buttonSearch_MouseHover);
            this.buttonSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonSearch_MouseUp);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSearch.Location = new System.Drawing.Point(207, 15);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(156, 23);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.Text = "Name, PhoneNum or Address";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dataGridViewPhoneDirectory);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 54);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(424, 305);
            this.panelMain.TabIndex = 1;
            // 
            // dataGridViewPhoneDirectory
            // 
            this.dataGridViewPhoneDirectory.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewPhoneDirectory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPhoneDirectory.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewPhoneDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhoneDirectory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.NameCol,
            this.PhoneCol,
            this.AddressCol});
            this.dataGridViewPhoneDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPhoneDirectory.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPhoneDirectory.Name = "dataGridViewPhoneDirectory";
            this.dataGridViewPhoneDirectory.RowHeadersVisible = false;
            this.dataGridViewPhoneDirectory.RowTemplate.Height = 25;
            this.dataGridViewPhoneDirectory.Size = new System.Drawing.Size(424, 305);
            this.dataGridViewPhoneDirectory.TabIndex = 0;
            this.dataGridViewPhoneDirectory.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhoneDirectory_CellEndEdit);
            this.dataGridViewPhoneDirectory.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhoneDirectory_CellLeave);
            this.dataGridViewPhoneDirectory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPhoneDirectory_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 59);
            this.panel1.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Teal;
            this.buttonAdd.BackgroundImage = global::UI.Resources.add_user;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(362, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 50);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonAdd_MouseDown);
            this.buttonAdd.MouseEnter += new System.EventHandler(this.buttonAdd_MouseEnter);
            this.buttonAdd.MouseLeave += new System.EventHandler(this.buttonAdd_MouseLeave);
            this.buttonAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonAdd_MouseUp);
            // 
            // IdCol
            // 
            this.IdCol.HeaderText = "Id";
            this.IdCol.Name = "IdCol";
            this.IdCol.Visible = false;
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
            this.ClientSize = new System.Drawing.Size(424, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "PhoneDirectory";
            this.Text = "PhoneDirectory";
            this.Load += new System.EventHandler(this.PhoneDirectory_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhoneDirectory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dataGridViewPhoneDirectory;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressCol;
    }
}

