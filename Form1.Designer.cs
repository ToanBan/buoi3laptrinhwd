namespace baitapbuoi3
{
    partial class frm
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
            this.lblln = new System.Windows.Forms.Label();
            this.lblfn = new System.Windows.Forms.Label();
            this.lblp = new System.Windows.Forms.Label();
            this.tbp = new System.Windows.Forms.TextBox();
            this.tbfn = new System.Windows.Forms.TextBox();
            this.tbln = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colln = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colfn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblln
            // 
            this.lblln.AutoSize = true;
            this.lblln.Location = new System.Drawing.Point(949, 43);
            this.lblln.Name = "lblln";
            this.lblln.Size = new System.Drawing.Size(72, 16);
            this.lblln.TabIndex = 0;
            this.lblln.Text = "Last Name";
            // 
            // lblfn
            // 
            this.lblfn.AutoSize = true;
            this.lblfn.Location = new System.Drawing.Point(949, 160);
            this.lblfn.Name = "lblfn";
            this.lblfn.Size = new System.Drawing.Size(72, 16);
            this.lblfn.TabIndex = 1;
            this.lblfn.Text = "First Name";
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Location = new System.Drawing.Point(949, 256);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(46, 16);
            this.lblp.TabIndex = 2;
            this.lblp.Text = "Phone";
            // 
            // tbp
            // 
            this.tbp.Location = new System.Drawing.Point(952, 313);
            this.tbp.Name = "tbp";
            this.tbp.Size = new System.Drawing.Size(231, 22);
            this.tbp.TabIndex = 4;
            // 
            // tbfn
            // 
            this.tbfn.Location = new System.Drawing.Point(952, 204);
            this.tbfn.Name = "tbfn";
            this.tbfn.Size = new System.Drawing.Size(231, 22);
            this.tbfn.TabIndex = 5;
            // 
            // tbln
            // 
            this.tbln.Location = new System.Drawing.Point(952, 91);
            this.tbln.Name = "tbln";
            this.tbln.Size = new System.Drawing.Size(231, 22);
            this.tbln.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(749, 375);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(884, 375);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(1023, 375);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(81, 40);
            this.btnDeleteAll.TabIndex = 9;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1159, 375);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 40);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colln,
            this.colfn,
            this.colp});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(176, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(387, 300);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colln
            // 
            this.colln.Text = "Last Name";
            this.colln.Width = 100;
            // 
            // colfn
            // 
            this.colfn.Text = "First Name";
            this.colfn.Width = 119;
            // 
            // colp
            // 
            this.colp.Text = "Phone";
            this.colp.Width = 133;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1269, 375);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 40);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 516);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbln);
            this.Controls.Add(this.tbfn);
            this.Controls.Add(this.tbp);
            this.Controls.Add(this.lblp);
            this.Controls.Add(this.lblfn);
            this.Controls.Add(this.lblln);
            this.Name = "frm";
            this.Text = "frm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblln;
        private System.Windows.Forms.Label lblfn;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.TextBox tbp;
        private System.Windows.Forms.TextBox tbfn;
        private System.Windows.Forms.TextBox tbln;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colln;
        private System.Windows.Forms.ColumnHeader colfn;
        private System.Windows.Forms.ColumnHeader colp;
        private System.Windows.Forms.Button btnUpdate;
    }
}

