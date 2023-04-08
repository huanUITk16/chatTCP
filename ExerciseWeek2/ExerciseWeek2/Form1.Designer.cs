namespace ExerciseWeek2
{
    partial class Form1
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.capnhat = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.khoitao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_ns = new System.Windows.Forms.Label();
            this.lb_add = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNS = new System.Windows.Forms.DateTimePicker();
            this.tb_add = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(50, 20);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(492, 150);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // capnhat
            // 
            this.capnhat.Location = new System.Drawing.Point(635, 310);
            this.capnhat.Name = "capnhat";
            this.capnhat.Size = new System.Drawing.Size(75, 23);
            this.capnhat.TabIndex = 1;
            this.capnhat.Text = "CapNhat";
            this.capnhat.UseVisualStyleBackColor = true;
            this.capnhat.Click += new System.EventHandler(this.capnhat_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(635, 226);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 2;
            this.them.Text = "Them";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(635, 268);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 3;
            this.xoa.Text = "Xoa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // khoitao
            // 
            this.khoitao.Location = new System.Drawing.Point(635, 357);
            this.khoitao.Name = "khoitao";
            this.khoitao.Size = new System.Drawing.Size(75, 23);
            this.khoitao.TabIndex = 4;
            this.khoitao.Text = "KhoiTao";
            this.khoitao.UseVisualStyleBackColor = true;
            this.khoitao.Click += new System.EventHandler(this.khoitao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(20, 25);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(18, 16);
            this.lb_id.TabIndex = 9;
            this.lb_id.Text = "id";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(20, 60);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(41, 16);
            this.lb_name.TabIndex = 10;
            this.lb_name.Text = "name";
            // 
            // lb_ns
            // 
            this.lb_ns.AutoSize = true;
            this.lb_ns.Location = new System.Drawing.Point(20, 92);
            this.lb_ns.Name = "lb_ns";
            this.lb_ns.Size = new System.Drawing.Size(32, 16);
            this.lb_ns.TabIndex = 11;
            this.lb_ns.Text = "birth";
            // 
            // lb_add
            // 
            this.lb_add.AutoSize = true;
            this.lb_add.Location = new System.Drawing.Point(20, 128);
            this.lb_add.Name = "lb_add";
            this.lb_add.Size = new System.Drawing.Size(57, 16);
            this.lb_add.TabIndex = 12;
            this.lb_add.Text = "address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 13;
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.dgv);
            this.groupbox.Location = new System.Drawing.Point(8, 8);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(591, 183);
            this.groupbox.TabIndex = 14;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "ThongTin";
            this.groupbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbNS);
            this.groupBox2.Controls.Add(this.tb_add);
            this.groupBox2.Controls.Add(this.tb_name);
            this.groupBox2.Controls.Add(this.tb_id);
            this.groupBox2.Controls.Add(this.lb_id);
            this.groupBox2.Controls.Add(this.lb_name);
            this.groupBox2.Controls.Add(this.lb_ns);
            this.groupBox2.Controls.Add(this.lb_add);
            this.groupBox2.Location = new System.Drawing.Point(25, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 172);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tbNS
            // 
            this.tbNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbNS.Location = new System.Drawing.Point(95, 92);
            this.tbNS.Name = "tbNS";
            this.tbNS.Size = new System.Drawing.Size(141, 22);
            this.tbNS.TabIndex = 16;
            // 
            // tb_add
            // 
            this.tb_add.Location = new System.Drawing.Point(95, 122);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(100, 22);
            this.tb_add.TabIndex = 15;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(95, 60);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(171, 22);
            this.tb_name.TabIndex = 14;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(95, 22);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(171, 22);
            this.tb_id.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.khoitao);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Controls.Add(this.capnhat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupbox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button capnhat;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button khoitao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_ns;
        private System.Windows.Forms.Label lb_add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker tbNS;
        private System.Windows.Forms.TextBox tb_add;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
    }
}

