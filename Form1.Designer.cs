namespace Pharmacy2Utest
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
            this.convert_btn = new System.Windows.Forms.Button();
            this.input_txtbox = new System.Windows.Forms.TextBox();
            this.output_lbl = new System.Windows.Forms.Label();
            this.eur_rdoBtn = new System.Windows.Forms.RadioButton();
            this.aud_rdoBtn = new System.Windows.Forms.RadioButton();
            this.usd_rdoBtn = new System.Windows.Forms.RadioButton();
            this.logs_btn = new System.Windows.Forms.Button();
            this.log_panel = new System.Windows.Forms.Panel();
            this.MaxDateQuery_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.log_dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.MinDateQuery_txtbox = new System.Windows.Forms.TextBox();
            this.query_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbp_rdoBtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.result_txtbox = new System.Windows.Forms.TextBox();
            this.log_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // convert_btn
            // 
            this.convert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_btn.Location = new System.Drawing.Point(12, 134);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Size = new System.Drawing.Size(174, 43);
            this.convert_btn.TabIndex = 0;
            this.convert_btn.Text = "Convert";
            this.convert_btn.UseVisualStyleBackColor = true;
            this.convert_btn.Click += new System.EventHandler(this.convert_btn_Click);
            // 
            // input_txtbox
            // 
            this.input_txtbox.Location = new System.Drawing.Point(100, 15);
            this.input_txtbox.Name = "input_txtbox";
            this.input_txtbox.Size = new System.Drawing.Size(67, 20);
            this.input_txtbox.TabIndex = 2;
            // 
            // output_lbl
            // 
            this.output_lbl.AutoSize = true;
            this.output_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_lbl.Location = new System.Drawing.Point(37, 187);
            this.output_lbl.Name = "output_lbl";
            this.output_lbl.Size = new System.Drawing.Size(56, 18);
            this.output_lbl.TabIndex = 3;
            this.output_lbl.Text = "Result";
            // 
            // eur_rdoBtn
            // 
            this.eur_rdoBtn.AutoSize = true;
            this.eur_rdoBtn.Checked = true;
            this.eur_rdoBtn.Location = new System.Drawing.Point(5, 3);
            this.eur_rdoBtn.Name = "eur_rdoBtn";
            this.eur_rdoBtn.Size = new System.Drawing.Size(57, 17);
            this.eur_rdoBtn.TabIndex = 4;
            this.eur_rdoBtn.TabStop = true;
            this.eur_rdoBtn.Text = "EUR €";
            this.eur_rdoBtn.UseVisualStyleBackColor = true;
            // 
            // aud_rdoBtn
            // 
            this.aud_rdoBtn.AutoSize = true;
            this.aud_rdoBtn.Location = new System.Drawing.Point(5, 26);
            this.aud_rdoBtn.Name = "aud_rdoBtn";
            this.aud_rdoBtn.Size = new System.Drawing.Size(64, 17);
            this.aud_rdoBtn.TabIndex = 5;
            this.aud_rdoBtn.Text = "AUD A$";
            this.aud_rdoBtn.UseVisualStyleBackColor = true;
            // 
            // usd_rdoBtn
            // 
            this.usd_rdoBtn.AutoSize = true;
            this.usd_rdoBtn.Location = new System.Drawing.Point(5, 46);
            this.usd_rdoBtn.Name = "usd_rdoBtn";
            this.usd_rdoBtn.Size = new System.Drawing.Size(57, 17);
            this.usd_rdoBtn.TabIndex = 6;
            this.usd_rdoBtn.Text = "USD $";
            this.usd_rdoBtn.UseVisualStyleBackColor = true;
            // 
            // logs_btn
            // 
            this.logs_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs_btn.Location = new System.Drawing.Point(45, 220);
            this.logs_btn.Name = "logs_btn";
            this.logs_btn.Size = new System.Drawing.Size(101, 38);
            this.logs_btn.TabIndex = 8;
            this.logs_btn.Text = "Previous Logs";
            this.logs_btn.UseVisualStyleBackColor = true;
            this.logs_btn.Click += new System.EventHandler(this.logs_btn_Click);
            // 
            // log_panel
            // 
            this.log_panel.Controls.Add(this.MaxDateQuery_txtbox);
            this.log_panel.Controls.Add(this.label1);
            this.log_panel.Controls.Add(this.log_dataGridView);
            this.log_panel.Controls.Add(this.label2);
            this.log_panel.Controls.Add(this.MinDateQuery_txtbox);
            this.log_panel.Controls.Add(this.query_btn);
            this.log_panel.Location = new System.Drawing.Point(202, 12);
            this.log_panel.Name = "log_panel";
            this.log_panel.Size = new System.Drawing.Size(445, 227);
            this.log_panel.TabIndex = 9;
            this.log_panel.Visible = false;
            // 
            // MaxDateQuery_txtbox
            // 
            this.MaxDateQuery_txtbox.Location = new System.Drawing.Point(291, 166);
            this.MaxDateQuery_txtbox.Name = "MaxDateQuery_txtbox";
            this.MaxDateQuery_txtbox.Size = new System.Drawing.Size(100, 20);
            this.MaxDateQuery_txtbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Max Date";
            // 
            // log_dataGridView
            // 
            this.log_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.log_dataGridView.Location = new System.Drawing.Point(4, 3);
            this.log_dataGridView.Name = "log_dataGridView";
            this.log_dataGridView.Size = new System.Drawing.Size(432, 157);
            this.log_dataGridView.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Min Date";
            // 
            // MinDateQuery_txtbox
            // 
            this.MinDateQuery_txtbox.Location = new System.Drawing.Point(115, 168);
            this.MinDateQuery_txtbox.Name = "MinDateQuery_txtbox";
            this.MinDateQuery_txtbox.Size = new System.Drawing.Size(94, 20);
            this.MinDateQuery_txtbox.TabIndex = 3;
            // 
            // query_btn
            // 
            this.query_btn.Location = new System.Drawing.Point(163, 192);
            this.query_btn.Name = "query_btn";
            this.query_btn.Size = new System.Drawing.Size(144, 32);
            this.query_btn.TabIndex = 1;
            this.query_btn.Text = "Query";
            this.query_btn.UseVisualStyleBackColor = true;
            this.query_btn.Click += new System.EventHandler(this.query_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "=>";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.aud_rdoBtn);
            this.panel1.Controls.Add(this.eur_rdoBtn);
            this.panel1.Controls.Add(this.usd_rdoBtn);
            this.panel1.Location = new System.Drawing.Point(108, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 66);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbp_rdoBtn);
            this.panel2.Location = new System.Drawing.Point(11, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 64);
            this.panel2.TabIndex = 12;
            // 
            // gbp_rdoBtn
            // 
            this.gbp_rdoBtn.AutoSize = true;
            this.gbp_rdoBtn.Checked = true;
            this.gbp_rdoBtn.Location = new System.Drawing.Point(3, 24);
            this.gbp_rdoBtn.Name = "gbp_rdoBtn";
            this.gbp_rdoBtn.Size = new System.Drawing.Size(56, 17);
            this.gbp_rdoBtn.TabIndex = 0;
            this.gbp_rdoBtn.TabStop = true;
            this.gbp_rdoBtn.Text = "GBP £";
            this.gbp_rdoBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Amount to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "convert";
            // 
            // result_txtbox
            // 
            this.result_txtbox.Location = new System.Drawing.Point(100, 185);
            this.result_txtbox.Name = "result_txtbox";
            this.result_txtbox.ReadOnly = true;
            this.result_txtbox.Size = new System.Drawing.Size(67, 20);
            this.result_txtbox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 279);
            this.Controls.Add(this.result_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.log_panel);
            this.Controls.Add(this.logs_btn);
            this.Controls.Add(this.output_lbl);
            this.Controls.Add(this.input_txtbox);
            this.Controls.Add(this.convert_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.log_panel.ResumeLayout(false);
            this.log_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convert_btn;
        private System.Windows.Forms.TextBox input_txtbox;
        private System.Windows.Forms.Label output_lbl;
        private System.Windows.Forms.RadioButton eur_rdoBtn;
        private System.Windows.Forms.RadioButton aud_rdoBtn;
        private System.Windows.Forms.RadioButton usd_rdoBtn;
        private System.Windows.Forms.Button logs_btn;
        private System.Windows.Forms.Panel log_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MinDateQuery_txtbox;
        private System.Windows.Forms.Button query_btn;
        private System.Windows.Forms.DataGridView log_dataGridView;
        private System.Windows.Forms.TextBox MaxDateQuery_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton gbp_rdoBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox result_txtbox;
    }
}

