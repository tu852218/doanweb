
namespace ĐỒAn.Net
{
    partial class Xuat_excel
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
            this.components = new System.ComponentModel.Container();
            this.HoaDondataGridView1 = new System.Windows.Forms.DataGridView();
            this.mahdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doan_net_TAAAADataSet1 = new ĐỒAn.Net.doan_net_TAAAADataSet1();
            this.hoadonTableAdapter = new ĐỒAn.Net.doan_net_TAAAADataSet1TableAdapters.hoadonTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xuatFileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doan_net_TAAAADataSet3 = new ĐỒAn.Net.doan_net_TAAAADataSet3();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new ĐỒAn.Net.doan_net_TAAAADataSet3TableAdapters.KhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDondataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doan_net_TAAAADataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doan_net_TAAAADataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HoaDondataGridView1
            // 
            this.HoaDondataGridView1.AutoGenerateColumns = false;
            this.HoaDondataGridView1.BackgroundColor = System.Drawing.Color.LightCoral;
            this.HoaDondataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HoaDondataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahdDataGridViewTextBoxColumn,
            this.ngaybanDataGridViewTextBoxColumn,
            this.manvDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.makhDataGridViewTextBoxColumn,
            this.tendtDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn});
            this.HoaDondataGridView1.DataSource = this.hoadonBindingSource;
            this.HoaDondataGridView1.GridColor = System.Drawing.Color.PeachPuff;
            this.HoaDondataGridView1.Location = new System.Drawing.Point(12, 66);
            this.HoaDondataGridView1.Name = "HoaDondataGridView1";
            this.HoaDondataGridView1.Size = new System.Drawing.Size(726, 229);
            this.HoaDondataGridView1.TabIndex = 0;
            this.HoaDondataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mahdDataGridViewTextBoxColumn
            // 
            this.mahdDataGridViewTextBoxColumn.DataPropertyName = "mahd";
            this.mahdDataGridViewTextBoxColumn.HeaderText = "mahd";
            this.mahdDataGridViewTextBoxColumn.Name = "mahdDataGridViewTextBoxColumn";
            // 
            // ngaybanDataGridViewTextBoxColumn
            // 
            this.ngaybanDataGridViewTextBoxColumn.DataPropertyName = "ngayban";
            this.ngaybanDataGridViewTextBoxColumn.HeaderText = "ngayban";
            this.ngaybanDataGridViewTextBoxColumn.Name = "ngaybanDataGridViewTextBoxColumn";
            // 
            // manvDataGridViewTextBoxColumn
            // 
            this.manvDataGridViewTextBoxColumn.DataPropertyName = "manv";
            this.manvDataGridViewTextBoxColumn.HeaderText = "manv";
            this.manvDataGridViewTextBoxColumn.Name = "manvDataGridViewTextBoxColumn";
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "soluong";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            // 
            // makhDataGridViewTextBoxColumn
            // 
            this.makhDataGridViewTextBoxColumn.DataPropertyName = "makh";
            this.makhDataGridViewTextBoxColumn.HeaderText = "makh";
            this.makhDataGridViewTextBoxColumn.Name = "makhDataGridViewTextBoxColumn";
            // 
            // tendtDataGridViewTextBoxColumn
            // 
            this.tendtDataGridViewTextBoxColumn.DataPropertyName = "tendt";
            this.tendtDataGridViewTextBoxColumn.HeaderText = "tendt";
            this.tendtDataGridViewTextBoxColumn.Name = "tendtDataGridViewTextBoxColumn";
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "diachi";
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "sdt";
            this.sdtDataGridViewTextBoxColumn.HeaderText = "sdt";
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "gia";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // hoadonBindingSource
            // 
            this.hoadonBindingSource.DataMember = "hoadon";
            this.hoadonBindingSource.DataSource = this.doan_net_TAAAADataSet1;
            // 
            // doan_net_TAAAADataSet1
            // 
            this.doan_net_TAAAADataSet1.DataSetName = "doan_net_TAAAADataSet1";
            this.doan_net_TAAAADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoadonTableAdapter
            // 
            this.hoadonTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuatFileExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xuatFileExcelToolStripMenuItem
            // 
            this.xuatFileExcelToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.xuatFileExcelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.xuatFileExcelToolStripMenuItem.Image = global::ĐỒAn.Net.Properties.Resources.Export_To_File_icon;
            this.xuatFileExcelToolStripMenuItem.Name = "xuatFileExcelToolStripMenuItem";
            this.xuatFileExcelToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.xuatFileExcelToolStripMenuItem.Text = "Xuat file excel";
            this.xuatFileExcelToolStripMenuItem.Click += new System.EventHandler(this.xuatFileExcelToolStripMenuItem_Click);
            // 
            // doan_net_TAAAADataSet3
            // 
            this.doan_net_TAAAADataSet3.DataSetName = "doan_net_TAAAADataSet3";
            this.doan_net_TAAAADataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.doan_net_TAAAADataSet3;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // Xuat_excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HoaDondataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Xuat_excel";
            this.Text = "Xuat_excel";
            this.Load += new System.EventHandler(this.Xuat_excel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDondataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doan_net_TAAAADataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doan_net_TAAAADataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HoaDondataGridView1;
        private doan_net_TAAAADataSet1 doan_net_TAAAADataSet1;
        private System.Windows.Forms.BindingSource hoadonBindingSource;
        private doan_net_TAAAADataSet1TableAdapters.hoadonTableAdapter hoadonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xuatFileExcelToolStripMenuItem;
        private doan_net_TAAAADataSet3 doan_net_TAAAADataSet3;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private doan_net_TAAAADataSet3TableAdapters.KhachHangTableAdapter khachHangTableAdapter;
    }
}