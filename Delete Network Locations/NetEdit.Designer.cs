namespace Delete_Network_Locations
{
    partial class NetEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetEdit));
            this.label_info = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.listView_networks = new System.Windows.Forms.ListView();
            this.columnHeader_location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_regname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_clearall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(12, 9);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(372, 13);
            this.label_info.TabIndex = 0;
            this.label_info.Text = "Select the network location or network locations that you would like to delete.";
            // 
            // button_delete
            // 
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.Enabled = false;
            this.button_delete.Location = new System.Drawing.Point(15, 317);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete...";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_close
            // 
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.Location = new System.Drawing.Point(412, 317);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // listView_networks
            // 
            this.listView_networks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_location,
            this.columnHeader_regname});
            this.listView_networks.HideSelection = false;
            this.listView_networks.Location = new System.Drawing.Point(15, 36);
            this.listView_networks.Name = "listView_networks";
            this.listView_networks.Size = new System.Drawing.Size(472, 272);
            this.listView_networks.TabIndex = 1;
            this.listView_networks.UseCompatibleStateImageBehavior = false;
            this.listView_networks.View = System.Windows.Forms.View.Details;
            this.listView_networks.SelectedIndexChanged += new System.EventHandler(this.listView_networks_SelectedIndexChanged);
            // 
            // columnHeader_location
            // 
            this.columnHeader_location.Text = "Network location";
            this.columnHeader_location.Width = 208;
            // 
            // columnHeader_regname
            // 
            this.columnHeader_regname.Text = "Registry key name";
            this.columnHeader_regname.Width = 260;
            // 
            // button_refresh
            // 
            this.button_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_refresh.Location = new System.Drawing.Point(96, 317);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 4;
            this.button_refresh.Text = "Refresh...";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_clearall
            // 
            this.button_clearall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clearall.Location = new System.Drawing.Point(177, 317);
            this.button_clearall.Name = "button_clearall";
            this.button_clearall.Size = new System.Drawing.Size(75, 23);
            this.button_clearall.TabIndex = 5;
            this.button_clearall.Text = "Clear all...";
            this.button_clearall.UseVisualStyleBackColor = true;
            this.button_clearall.Click += new System.EventHandler(this.button_clearall_Click);
            // 
            // NetEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 348);
            this.Controls.Add(this.button_clearall);
            this.Controls.Add(this.listView_networks);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Network Locations";
            this.Load += new System.EventHandler(this.NetEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ListView listView_networks;
        private System.Windows.Forms.ColumnHeader columnHeader_location;
        private System.Windows.Forms.ColumnHeader columnHeader_regname;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_clearall;
    }
}

