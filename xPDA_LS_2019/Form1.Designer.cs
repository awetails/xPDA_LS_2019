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
            this.pony_list = new System.Windows.Forms.ListBox();
            this.add_pony = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.poniesNames = new xPDA_LS_2019.poniesNames();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesNames)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.add_pony);
            this.splitContainer1.Panel1.Controls.Add(this.pony_list);
            this.splitContainer1.Size = new System.Drawing.Size(1211, 779);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 0;
            // 
            // pony_list
            // 
            this.pony_list.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.poniesNames, "Pony.name", true));
            this.pony_list.DataSource = this.poniesNames;
            this.pony_list.DisplayMember = "Pony.name";
            this.pony_list.FormattingEnabled = true;
            this.pony_list.Location = new System.Drawing.Point(3, -1);
            this.pony_list.Name = "pony_list";
            this.pony_list.Size = new System.Drawing.Size(203, 732);
            this.pony_list.TabIndex = 0;
            this.pony_list.ValueMember = "Pony.name";
            // 
            // add_pony
            // 
            this.add_pony.Location = new System.Drawing.Point(3, 728);
            this.add_pony.Name = "add_pony";
            this.add_pony.Size = new System.Drawing.Size(203, 39);
            this.add_pony.TabIndex = 1;
            this.add_pony.Text = "button2";
            this.add_pony.UseVisualStyleBackColor = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.poniesNames;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // poniesNames
            // 
            this.poniesNames.DataSetName = "poniesNames";
            this.poniesNames.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 779);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "My little pony";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesNames)).EndInit();
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

