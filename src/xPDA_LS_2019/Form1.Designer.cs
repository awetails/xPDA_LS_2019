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
            this.addImage = new System.Windows.Forms.Button();
            this.add_pony = new System.Windows.Forms.Button();
            this.pony_list = new System.Windows.Forms.ListBox();
            this.ponyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.poniesDataSet1 = new xPDA_LS_2019.poniesDataSet1();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.poniesNames = new xPDA_LS_2019.poniesNames();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ponyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ponyTableAdapter = new xPDA_LS_2019.poniesNamesTableAdapters.PonyTableAdapter();
            this.ponyTableAdapter1 = new xPDA_LS_2019.poniesDataSet1TableAdapters.PonyTableAdapter();
            this.BS_images = new System.Windows.Forms.BindingSource(this.components);
            this.images = new xPDA_LS_2019.images();
            this.imagesviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imagesviewTableAdapter = new xPDA_LS_2019.imagesTableAdapters.imagesviewTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.info_name = new System.Windows.Forms.Label();
            this.info_race = new System.Windows.Forms.Label();
            this.info_gender = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ponyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ponyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_images)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesviewBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.addImage);
            this.splitContainer1.Panel1.Controls.Add(this.add_pony);
            this.splitContainer1.Panel1.Controls.Add(this.pony_list);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(1211, 779);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 0;
            // 
            // addImage
            // 
            this.addImage.Location = new System.Drawing.Point(108, 737);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(97, 39);
            this.addImage.TabIndex = 0;
            this.addImage.Text = "add Image";
            this.addImage.UseVisualStyleBackColor = true;
            this.addImage.Click += new System.EventHandler(this.Button1_Click);
            // 
            // add_pony
            // 
            this.add_pony.Location = new System.Drawing.Point(3, 737);
            this.add_pony.Name = "add_pony";
            this.add_pony.Size = new System.Drawing.Size(99, 39);
            this.add_pony.TabIndex = 1;
            this.add_pony.Text = "add Pony";
            this.add_pony.UseVisualStyleBackColor = true;
            this.add_pony.Click += new System.EventHandler(this.Add_pony_Click);
            // 
            // pony_list
            // 
            this.pony_list.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ponyBindingSource1, "Id", true));
            this.pony_list.DataSource = this.ponyBindingSource1;
            this.pony_list.DisplayMember = "name";
            this.pony_list.FormattingEnabled = true;
            this.pony_list.Location = new System.Drawing.Point(3, -1);
            this.pony_list.Name = "pony_list";
            this.pony_list.Size = new System.Drawing.Size(203, 641);
            this.pony_list.TabIndex = 0;
            this.pony_list.ValueMember = "Id";
            this.pony_list.SelectedIndexChanged += new System.EventHandler(this.Pony_list_SelectedIndexChanged);
            // 
            // ponyBindingSource1
            // 
            this.ponyBindingSource1.DataMember = "Pony";
            this.ponyBindingSource1.DataSource = this.poniesDataSet1;
            // 
            // poniesDataSet1
            // 
            this.poniesDataSet1.DataSetName = "poniesDataSet1";
            this.poniesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1000, 779);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.StateImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.TileSize = new System.Drawing.Size(350, 150);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(100, 100);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            // ponyBindingSource
            // 
            this.ponyBindingSource.DataMember = "Pony";
            this.ponyBindingSource.DataSource = this.bindingSource1;
            // 
            // ponyTableAdapter
            // 
            this.ponyTableAdapter.ClearBeforeFill = true;
            // 
            // ponyTableAdapter1
            // 
            this.ponyTableAdapter1.ClearBeforeFill = true;
            // 
            // BS_images
            // 
            this.BS_images.DataSource = this.images;
            this.BS_images.Position = 0;
            // 
            // images
            // 
            this.images.DataSetName = "images";
            this.images.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imagesviewBindingSource
            // 
            this.imagesviewBindingSource.DataMember = "imagesview";
            this.imagesviewBindingSource.DataSource = this.BS_images;
            // 
            // imagesviewTableAdapter
            // 
            this.imagesviewTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.info_gender, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.info_race, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.info_name, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 646);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.41177F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.58823F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 85);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Race";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_name
            // 
            this.info_name.Location = new System.Drawing.Point(53, 0);
            this.info_name.Name = "info_name";
            this.info_name.Size = new System.Drawing.Size(144, 23);
            this.info_name.TabIndex = 3;
            this.info_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_race
            // 
            this.info_race.Location = new System.Drawing.Point(53, 28);
            this.info_race.Name = "info_race";
            this.info_race.Size = new System.Drawing.Size(144, 23);
            this.info_race.TabIndex = 4;
            this.info_race.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_gender
            // 
            this.info_gender.Location = new System.Drawing.Point(53, 56);
            this.info_gender.Name = "info_gender";
            this.info_gender.Size = new System.Drawing.Size(144, 23);
            this.info_gender.TabIndex = 5;
            this.info_gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 779);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "My little pony";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ponyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poniesNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ponyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_images)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesviewBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button add_pony;
        private System.Windows.Forms.ListBox pony_list;
        private System.Windows.Forms.BindingSource bindingSource1;
        private poniesNames poniesNames;
        private System.Windows.Forms.Button addImage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource ponyBindingSource;
        private poniesNamesTableAdapters.PonyTableAdapter ponyTableAdapter;
        private poniesDataSet1 poniesDataSet1;
        private System.Windows.Forms.BindingSource ponyBindingSource1;
        private poniesDataSet1TableAdapters.PonyTableAdapter ponyTableAdapter1;
        private System.Windows.Forms.BindingSource BS_images;
        private images images;
        private System.Windows.Forms.BindingSource imagesviewBindingSource;
        private imagesTableAdapters.imagesviewTableAdapter imagesviewTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label info_gender;
        private System.Windows.Forms.Label info_race;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info_name;
    }
}

