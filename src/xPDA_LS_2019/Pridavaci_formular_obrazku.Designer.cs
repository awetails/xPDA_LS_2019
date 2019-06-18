namespace xPDA_LS_2019
{
    partial class Pridavaci_formular_obrazku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pridavaci_formular_obrazku));
            this.filepicker = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Upload = new System.Windows.Forms.Button();
            this.preview = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ponyselect = new System.Windows.Forms.ListBox();
            this.ponyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.poniesDataSet = new xPDA_LS_2019.poniesDataSet();
            this.ponyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.poniesDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ponyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poniesNames = new xPDA_LS_2019.poniesNames();
            this.poniesNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ponyTableAdapter = new xPDA_LS_2019.poniesNamesTableAdapters.PonyTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.poniesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ponyTableAdapter1 = new xPDA_LS_2019.poniesDataSetTableAdapters.PonyTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ponyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ponyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ponyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // filepicker
            // 
            this.filepicker.Location = new System.Drawing.Point(6, 19);
            this.filepicker.Name = "filepicker";
            this.filepicker.Size = new System.Drawing.Size(144, 55);
            this.filepicker.TabIndex = 0;
            this.filepicker.Text = "Select Image";
            this.filepicker.UseVisualStyleBackColor = true;
            this.filepicker.Click += new System.EventHandler(this.Button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Upload);
            this.groupBox1.Controls.Add(this.preview);
            this.groupBox1.Controls.Add(this.filepicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New image";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // Upload
            // 
            this.Upload.Enabled = false;
            this.Upload.Location = new System.Drawing.Point(6, 118);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(144, 55);
            this.Upload.TabIndex = 2;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Button2_Click);
            // 
            // preview
            // 
            this.preview.Location = new System.Drawing.Point(170, 19);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(451, 160);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.preview.TabIndex = 1;
            this.preview.TabStop = false;
            this.preview.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.Preview_LoadCompleted);
            this.preview.Click += new System.EventHandler(this.Preview_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ponyselect);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 272);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ponies in image";
            // 
            // ponyselect
            // 
            this.ponyselect.ColumnWidth = 200;
            this.ponyselect.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ponyBindingSource1, "Id", true));
            this.ponyselect.DataSource = this.ponyBindingSource2;
            this.ponyselect.DisplayMember = "name";
            this.ponyselect.FormattingEnabled = true;
            this.ponyselect.HorizontalScrollbar = true;
            this.ponyselect.Location = new System.Drawing.Point(0, 19);
            this.ponyselect.MultiColumn = true;
            this.ponyselect.Name = "ponyselect";
            this.ponyselect.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ponyselect.Size = new System.Drawing.Size(621, 251);
            this.ponyselect.TabIndex = 0;
            this.ponyselect.ValueMember = "Id";
            this.ponyselect.SelectedIndexChanged += new System.EventHandler(this.Ponyselect_SelectedIndexChanged);
            // 
            // ponyBindingSource1
            // 
            this.ponyBindingSource1.DataMember = "Pony";
            this.ponyBindingSource1.DataSource = this.poniesDataSet;
            // 
            // poniesDataSet
            // 
            this.poniesDataSet.DataSetName = "poniesDataSet";
            this.poniesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ponyBindingSource2
            // 
            this.ponyBindingSource2.DataMember = "Pony";
            this.ponyBindingSource2.DataSource = this.poniesDataSetBindingSource1;
            // 
            // poniesDataSetBindingSource1
            // 
            this.poniesDataSetBindingSource1.DataSource = this.poniesDataSet;
            this.poniesDataSetBindingSource1.Position = 0;
            // 
            // ponyBindingSource
            // 
            this.ponyBindingSource.DataMember = "Pony";
            this.ponyBindingSource.DataSource = this.poniesNames;
            // 
            // poniesNames
            // 
            this.poniesNames.DataSetName = "poniesNames";
            this.poniesNames.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poniesNamesBindingSource
            // 
            this.poniesNamesBindingSource.DataSource = this.poniesNames;
            this.poniesNamesBindingSource.Position = 0;
            // 
            // ponyTableAdapter
            // 
            this.ponyTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.poniesDataSet;
            this.bindingSource1.Position = 0;
            // 
            // poniesDataSetBindingSource
            // 
            this.poniesDataSetBindingSource.DataSource = this.poniesDataSet;
            this.poniesDataSetBindingSource.Position = 0;
            // 
            // ponyTableAdapter1
            // 
            this.ponyTableAdapter1.ClearBeforeFill = true;
            // 
            // Pridavaci_formular_obrazku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pridavaci_formular_obrazku";
            this.Text = "Pridavaci_formular";
            this.Load += new System.EventHandler(this.Pridavaci_formular_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ponyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ponyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ponyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button filepicker;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ponyselect;
        private System.Windows.Forms.BindingSource poniesNamesBindingSource;
        private poniesNames poniesNames;
        private System.Windows.Forms.BindingSource ponyBindingSource;
        private poniesNamesTableAdapters.PonyTableAdapter ponyTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private poniesDataSet poniesDataSet;
        private System.Windows.Forms.BindingSource poniesDataSetBindingSource;
        private System.Windows.Forms.BindingSource ponyBindingSource1;
        private poniesDataSetTableAdapters.PonyTableAdapter ponyTableAdapter1;
        private System.Windows.Forms.BindingSource poniesDataSetBindingSource1;
        private System.Windows.Forms.BindingSource ponyBindingSource2;
        private System.Windows.Forms.Button Upload;
    }
}