namespace xPDA_LS_2019
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.add_pony = new System.Windows.Forms.Button();
            this.pony_list = new System.Windows.Forms.ListBox();
            this.poniesNames = new xPDA_LS_2019.poniesNames();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poniesNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.add_pony);
            this.splitContainer1.Panel1.Controls.Add(this.pony_list);
            this.splitContainer1.Size = new System.Drawing.Size(1615, 959);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // add_pony
            // 
            this.add_pony.Location = new System.Drawing.Point(4, 896);
            this.add_pony.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_pony.Name = "add_pony";
            this.add_pony.Size = new System.Drawing.Size(271, 48);
            this.add_pony.TabIndex = 1;
            this.add_pony.Text = "button2";
            this.add_pony.UseVisualStyleBackColor = true;
            // 
            // pony_list
            // 
            this.pony_list.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.poniesNames, "Pony.name", true));
            this.pony_list.DataSource = this.poniesNames;
            this.pony_list.DisplayMember = "Pony.name";
            this.pony_list.FormattingEnabled = true;
            this.pony_list.ItemHeight = 16;
            this.pony_list.Location = new System.Drawing.Point(4, -1);
            this.pony_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pony_list.Name = "pony_list";
            this.pony_list.Size = new System.Drawing.Size(269, 900);
            this.pony_list.TabIndex = 0;
            this.pony_list.ValueMember = "Pony.name";
            // 
            // poniesNames
            // 
            this.poniesNames.DataSetName = "poniesNames";
            this.poniesNames.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.poniesNames;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 959);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "My little pony";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poniesNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button add_pony;
        private System.Windows.Forms.ListBox pony_list;
        private System.Windows.Forms.BindingSource bindingSource1;
        private poniesNames poniesNames;
    }
}

