namespace xPDA_LS_2019
{
    partial class Pridavaci_formular_pony
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pridavaci_formular_pony));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rb_earth = new System.Windows.Forms.RadioButton();
            this.rb_uni = new System.Windows.Forms.RadioButton();
            this.rb_pega = new System.Windows.Forms.RadioButton();
            this.rb_M = new System.Windows.Forms.RadioButton();
            this.rb_F = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 20);
            this.textBox1.TabIndex = 0;
            // 
            // rb_earth
            // 
            this.rb_earth.AutoSize = true;
            this.rb_earth.Location = new System.Drawing.Point(144, 31);
            this.rb_earth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_earth.Name = "rb_earth";
            this.rb_earth.Size = new System.Drawing.Size(76, 17);
            this.rb_earth.TabIndex = 1;
            this.rb_earth.TabStop = true;
            this.rb_earth.Text = "Earth pony";
            this.rb_earth.UseVisualStyleBackColor = true;
            // 
            // rb_uni
            // 
            this.rb_uni.AutoSize = true;
            this.rb_uni.Location = new System.Drawing.Point(78, 31);
            this.rb_uni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_uni.Name = "rb_uni";
            this.rb_uni.Size = new System.Drawing.Size(62, 17);
            this.rb_uni.TabIndex = 2;
            this.rb_uni.TabStop = true;
            this.rb_uni.Text = "Unicorn";
            this.rb_uni.UseVisualStyleBackColor = true;
            // 
            // rb_pega
            // 
            this.rb_pega.AutoSize = true;
            this.rb_pega.Location = new System.Drawing.Point(5, 31);
            this.rb_pega.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_pega.Name = "rb_pega";
            this.rb_pega.Size = new System.Drawing.Size(69, 17);
            this.rb_pega.TabIndex = 3;
            this.rb_pega.TabStop = true;
            this.rb_pega.Text = "Pegasus ";
            this.rb_pega.UseVisualStyleBackColor = true;
            // 
            // rb_M
            // 
            this.rb_M.AutoSize = true;
            this.rb_M.Location = new System.Drawing.Point(5, 31);
            this.rb_M.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_M.Name = "rb_M";
            this.rb_M.Size = new System.Drawing.Size(48, 17);
            this.rb_M.TabIndex = 4;
            this.rb_M.TabStop = true;
            this.rb_M.Text = "Male";
            this.rb_M.UseVisualStyleBackColor = true;
            this.rb_M.CheckedChanged += new System.EventHandler(this.Rb_M_CheckedChanged);
            // 
            // rb_F
            // 
            this.rb_F.AutoSize = true;
            this.rb_F.Location = new System.Drawing.Point(57, 31);
            this.rb_F.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_F.Name = "rb_F";
            this.rb_F.Size = new System.Drawing.Size(59, 17);
            this.rb_F.TabIndex = 5;
            this.rb_F.TabStop = true;
            this.rb_F.Text = "Female";
            this.rb_F.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pony name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 239);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Potvrď";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_F);
            this.groupBox1.Controls.Add(this.rb_M);
            this.groupBox1.Location = new System.Drawing.Point(11, 160);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(370, 75);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Gender";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_pega);
            this.groupBox2.Controls.Add(this.rb_uni);
            this.groupBox2.Controls.Add(this.rb_earth);
            this.groupBox2.Location = new System.Drawing.Point(11, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 74);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Race";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // Pridavaci_formular_pony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 272);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pridavaci_formular_pony";
            this.Text = "Pridavaci_formular_pony";
            this.Load += new System.EventHandler(this.Pridavaci_formular_pony_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rb_earth;
        private System.Windows.Forms.RadioButton rb_uni;
        private System.Windows.Forms.RadioButton rb_pega;
        private System.Windows.Forms.RadioButton rb_M;
        private System.Windows.Forms.RadioButton rb_F;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}