
namespace Demo_WinForm
{
    partial class Frmformchinh
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
            this.maytinh = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // maytinh
            // 
            this.maytinh.Location = new System.Drawing.Point(143, 79);
            this.maytinh.Name = "maytinh";
            this.maytinh.Size = new System.Drawing.Size(207, 109);
            this.maytinh.TabIndex = 0;
            this.maytinh.Text = "Máy tính";
            this.maytinh.UseVisualStyleBackColor = true;
            this.maytinh.Click += new System.EventHandler(this.maytinh_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(838, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(226, 619);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Frmformchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 619);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.maytinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frmformchinh";
            this.Text = "Chương trình minh họa winform";
            this.Load += new System.EventHandler(this.Frmformchinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button maytinh;
        private System.Windows.Forms.ListView listView1;
    }
}