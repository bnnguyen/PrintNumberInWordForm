namespace PrintNumberInWordForm_2
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
            this.lb_inp = new System.Windows.Forms.Label();
            this.txt_inp = new System.Windows.Forms.TextBox();
            this.txt_out = new System.Windows.Forms.TextBox();
            this.lb_out = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_cheat = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_inp
            // 
            this.lb_inp.AutoSize = true;
            this.lb_inp.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_inp.Location = new System.Drawing.Point(28, 19);
            this.lb_inp.Name = "lb_inp";
            this.lb_inp.Size = new System.Drawing.Size(171, 43);
            this.lb_inp.TabIndex = 0;
            this.lb_inp.Text = "NHẬP SỐ:";
            // 
            // txt_inp
            // 
            this.txt_inp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inp.Location = new System.Drawing.Point(35, 72);
            this.txt_inp.Multiline = true;
            this.txt_inp.Name = "txt_inp";
            this.txt_inp.ReadOnly = true;
            this.txt_inp.Size = new System.Drawing.Size(730, 42);
            this.txt_inp.TabIndex = 1;
            this.txt_inp.TextChanged += new System.EventHandler(this.txt_inp_TextChanged);
            this.txt_inp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_inp_KeyPress);
            // 
            // txt_out
            // 
            this.txt_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_out.Location = new System.Drawing.Point(35, 207);
            this.txt_out.Multiline = true;
            this.txt_out.Name = "txt_out";
            this.txt_out.ReadOnly = true;
            this.txt_out.Size = new System.Drawing.Size(730, 199);
            this.txt_out.TabIndex = 3;
            // 
            // lb_out
            // 
            this.lb_out.AutoSize = true;
            this.lb_out.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_out.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_out.Location = new System.Drawing.Point(28, 151);
            this.lb_out.Name = "lb_out";
            this.lb_out.Size = new System.Drawing.Size(190, 43);
            this.lb_out.TabIndex = 2;
            this.lb_out.Text = "DẠNG CHỮ:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "English";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Tiếng Việt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_cheat
            // 
            this.txt_cheat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cheat.Location = new System.Drawing.Point(33, 67);
            this.txt_cheat.Multiline = true;
            this.txt_cheat.Name = "txt_cheat";
            this.txt_cheat.Size = new System.Drawing.Size(732, 76);
            this.txt_cheat.TabIndex = 6;
            this.txt_cheat.TextChanged += new System.EventHandler(this.txt_cheat_TextChanged);
            this.txt_cheat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cheat_KeyPress);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(540, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "ĐỌC SỐ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_cheat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_out);
            this.Controls.Add(this.lb_out);
            this.Controls.Add(this.txt_inp);
            this.Controls.Add(this.lb_inp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_inp;
        private System.Windows.Forms.TextBox txt_inp;
        private System.Windows.Forms.TextBox txt_out;
        private System.Windows.Forms.Label lb_out;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_cheat;
        private System.Windows.Forms.Button button3;
    }
}

