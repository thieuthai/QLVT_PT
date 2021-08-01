namespace QLVT_PHANTAN
{
    partial class inDSVattu
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
            this.grb_in = new System.Windows.Forms.GroupBox();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grb_in.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_in
            // 
            this.grb_in.Controls.Add(this.btn_thoat);
            this.grb_in.Controls.Add(this.btn_in);
            this.grb_in.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_in.Location = new System.Drawing.Point(0, 0);
            this.grb_in.Name = "grb_in";
            this.grb_in.Size = new System.Drawing.Size(1174, 100);
            this.grb_in.TabIndex = 0;
            this.grb_in.TabStop = false;
            this.grb_in.Text = "in Dánh Sách Vật Tư";
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(305, 40);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(175, 33);
            this.btn_in.TabIndex = 0;
            this.btn_in.Text = "in Danh Sách Vật Tư";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(621, 40);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(207, 33);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 100);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1174, 372);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // inDSVattu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 472);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.grb_in);
            this.Name = "inDSVattu";
            this.Text = "inDSVattu";
            this.grb_in.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_in;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_in;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}