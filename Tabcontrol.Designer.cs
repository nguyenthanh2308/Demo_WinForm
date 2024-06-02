
namespace Demo_WinForm
{
    partial class Tabcontrol
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "4551190048",
            "Nguyễn Minh Thành",
            "23/08/2004",
            "Gia Lai"}, -1);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDSMH = new System.Windows.Forms.TabPage();
            this.tabDSGV = new System.Windows.Forms.TabPage();
            this.tabDSlop = new System.Windows.Forms.TabPage();
            this.tabTroGiup = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabDSMH.SuspendLayout();
            this.tabDSlop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDSMH);
            this.tabControl1.Controls.Add(this.tabDSGV);
            this.tabControl1.Controls.Add(this.tabDSlop);
            this.tabControl1.Controls.Add(this.tabTroGiup);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(130, 91);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 380);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabDSMH
            // 
            this.tabDSMH.Controls.Add(this.domainUpDown1);
            this.tabDSMH.Controls.Add(this.label2);
            this.tabDSMH.Controls.Add(this.numericUpDown1);
            this.tabDSMH.Controls.Add(this.label1);
            this.tabDSMH.Location = new System.Drawing.Point(4, 34);
            this.tabDSMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDSMH.Name = "tabDSMH";
            this.tabDSMH.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDSMH.Size = new System.Drawing.Size(791, 342);
            this.tabDSMH.TabIndex = 0;
            this.tabDSMH.Text = "Danh sách môn học";
            this.toolTip2.SetToolTip(this.tabDSMH, "Số răng trám");
            this.tabDSMH.UseVisualStyleBackColor = true;
            // 
            // tabDSGV
            // 
            this.tabDSGV.Location = new System.Drawing.Point(4, 34);
            this.tabDSGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDSGV.Name = "tabDSGV";
            this.tabDSGV.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDSGV.Size = new System.Drawing.Size(791, 342);
            this.tabDSGV.TabIndex = 1;
            this.tabDSGV.Text = "Danh sách giáo viên";
            this.tabDSGV.UseVisualStyleBackColor = true;
            // 
            // tabDSlop
            // 
            this.tabDSlop.Controls.Add(this.listView1);
            this.tabDSlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabDSlop.Location = new System.Drawing.Point(4, 34);
            this.tabDSlop.Name = "tabDSlop";
            this.tabDSlop.Size = new System.Drawing.Size(791, 342);
            this.tabDSlop.TabIndex = 2;
            this.tabDSlop.Text = "Danh sách lớp";
            this.tabDSlop.UseVisualStyleBackColor = true;
            // 
            // tabTroGiup
            // 
            this.tabTroGiup.Location = new System.Drawing.Point(4, 34);
            this.tabTroGiup.Name = "tabTroGiup";
            this.tabTroGiup.Size = new System.Drawing.Size(791, 342);
            this.tabTroGiup.TabIndex = 3;
            this.tabTroGiup.Text = "Trợ giúp";
            this.tabTroGiup.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(24, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(733, 261);
            this.listView1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listView1, "Danh sách sinh viên");
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã SV";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày sinh";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quê quán";
            this.columnHeader4.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng răng trám";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(264, 32);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(165, 30);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bàn số";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("0");
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Location = new System.Drawing.Point(264, 107);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(165, 30);
            this.domainUpDown1.TabIndex = 3;
            this.domainUpDown1.Text = "3";
            // 
            // Tabcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Tabcontrol";
            this.Text = "Tabcontrol";
            this.tabControl1.ResumeLayout(false);
            this.tabDSMH.ResumeLayout(false);
            this.tabDSMH.PerformLayout();
            this.tabDSlop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDSMH;
        private System.Windows.Forms.TabPage tabDSGV;
        private System.Windows.Forms.TabPage tabDSlop;
        private System.Windows.Forms.TabPage tabTroGiup;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}