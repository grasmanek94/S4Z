namespace MyCalculatorClient
{
    partial class CalculatorForm
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
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.label_eq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_a
            // 
            this.tb_a.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_a.Location = new System.Drawing.Point(13, 12);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(111, 20);
            this.tb_a.TabIndex = 0;
            // 
            // tb_b
            // 
            this.tb_b.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_b.Location = new System.Drawing.Point(13, 67);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(111, 20);
            this.tb_b.TabIndex = 1;
            // 
            // tb_result
            // 
            this.tb_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_result.Location = new System.Drawing.Point(13, 106);
            this.tb_result.Name = "tb_result";
            this.tb_result.ReadOnly = true;
            this.tb_result.Size = new System.Drawing.Size(111, 20);
            this.tb_result.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_add.Location = new System.Drawing.Point(17, 38);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(21, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_sub.Location = new System.Drawing.Point(44, 38);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(21, 23);
            this.btn_sub.TabIndex = 4;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_mul.Location = new System.Drawing.Point(71, 38);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(21, 23);
            this.btn_mul.TabIndex = 5;
            this.btn_mul.Text = "x";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_div
            // 
            this.btn_div.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_div.Location = new System.Drawing.Point(98, 38);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(21, 23);
            this.btn_div.TabIndex = 6;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // label_eq
            // 
            this.label_eq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_eq.AutoSize = true;
            this.label_eq.Location = new System.Drawing.Point(62, 90);
            this.label_eq.Name = "label_eq";
            this.label_eq.Size = new System.Drawing.Size(13, 13);
            this.label_eq.TabIndex = 7;
            this.label_eq.Text = "=";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(129, 134);
            this.Controls.Add(this.label_eq);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.MaximumSize = new System.Drawing.Size(32000, 173);
            this.MinimumSize = new System.Drawing.Size(145, 173);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Label label_eq;
    }
}

