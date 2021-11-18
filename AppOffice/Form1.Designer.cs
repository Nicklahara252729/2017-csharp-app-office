namespace AppOffice
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
            this.panelmenu = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnemploye = new DevComponents.DotNetBar.ButtonX();
            this.btnposition = new DevComponents.DotNetBar.ButtonX();
            this.btnclass = new DevComponents.DotNetBar.ButtonX();
            this.btnlogout = new DevComponents.DotNetBar.ButtonX();
            this.panelfooter = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.panelbottom = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.panelemploye = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.spdataemploye = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.gridemploye = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.btnnew = new DevComponents.DotNetBar.ButtonX();
            this.btnedit = new DevComponents.DotNetBar.ButtonX();
            this.btncancel = new DevComponents.DotNetBar.ButtonX();
            this.btnsave = new DevComponents.DotNetBar.ButtonX();
            this.pictview = new System.Windows.Forms.PictureBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.karyawanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.karyawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new AppOffice.AppData();
            this.karyawanTableAdapter = new AppOffice.AppDataTableAdapters.karyawanTableAdapter();
            this.karyawanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelmenu.SuspendLayout();
            this.panelfooter.SuspendLayout();
            this.panelemploye.SuspendLayout();
            this.spdataemploye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridemploye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.Controls.Add(this.btnlogout);
            this.panelmenu.Controls.Add(this.btnclass);
            this.panelmenu.Controls.Add(this.btnposition);
            this.panelmenu.Controls.Add(this.btnemploye);
            this.panelmenu.Controls.Add(this.buttonX1);
            this.panelmenu.Location = new System.Drawing.Point(-1, -1);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(87, 435);
            this.panelmenu.TabIndex = 0;
            this.panelmenu.Text = "slidePanel1";
            this.panelmenu.UsesBlockingAnimation = false;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.Crimson;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX1.Location = new System.Drawing.Point(0, 1);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(87, 81);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolSize = 30F;
            this.buttonX1.TabIndex = 1;
            // 
            // btnemploye
            // 
            this.btnemploye.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnemploye.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnemploye.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnemploye.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnemploye.Location = new System.Drawing.Point(1, 88);
            this.btnemploye.Name = "btnemploye";
            this.btnemploye.Size = new System.Drawing.Size(86, 77);
            this.btnemploye.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnemploye.Symbol = "";
            this.btnemploye.SymbolSize = 30F;
            this.btnemploye.TabIndex = 1;
            this.btnemploye.Text = "Employe";
            // 
            // btnposition
            // 
            this.btnposition.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnposition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnposition.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnposition.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnposition.Location = new System.Drawing.Point(0, 171);
            this.btnposition.Name = "btnposition";
            this.btnposition.Size = new System.Drawing.Size(86, 84);
            this.btnposition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnposition.Symbol = "";
            this.btnposition.TabIndex = 1;
            this.btnposition.Text = "Position";
            // 
            // btnclass
            // 
            this.btnclass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnclass.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnclass.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnclass.Location = new System.Drawing.Point(0, 266);
            this.btnclass.Name = "btnclass";
            this.btnclass.Size = new System.Drawing.Size(87, 74);
            this.btnclass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnclass.Symbol = "";
            this.btnclass.TabIndex = 1;
            this.btnclass.Text = "Class";
            // 
            // btnlogout
            // 
            this.btnlogout.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnlogout.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnlogout.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnlogout.Location = new System.Drawing.Point(0, 357);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(87, 74);
            this.btnlogout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnlogout.Symbol = "";
            this.btnlogout.SymbolSize = 30F;
            this.btnlogout.TabIndex = 1;
            this.btnlogout.Text = "Logout";
            // 
            // panelfooter
            // 
            this.panelfooter.BackColor = System.Drawing.Color.Crimson;
            this.panelfooter.Controls.Add(this.btnsave);
            this.panelfooter.Controls.Add(this.btncancel);
            this.panelfooter.Controls.Add(this.btnedit);
            this.panelfooter.Controls.Add(this.btnnew);
            this.panelfooter.Location = new System.Drawing.Point(-1, 433);
            this.panelfooter.Name = "panelfooter";
            this.panelfooter.Size = new System.Drawing.Size(818, 36);
            this.panelfooter.TabIndex = 1;
            this.panelfooter.Text = "slidePanel1";
            this.panelfooter.UsesBlockingAnimation = false;
            // 
            // panelbottom
            // 
            this.panelbottom.BackColor = System.Drawing.Color.LightGray;
            this.panelbottom.Location = new System.Drawing.Point(-1, 469);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(818, 13);
            this.panelbottom.TabIndex = 2;
            this.panelbottom.Text = "slidePanel1";
            this.panelbottom.UsesBlockingAnimation = false;
            // 
            // panelemploye
            // 
            this.panelemploye.BackColor = System.Drawing.Color.Gainsboro;
            this.panelemploye.Controls.Add(this.label5);
            this.panelemploye.Controls.Add(this.textBox1);
            this.panelemploye.Controls.Add(this.gridemploye);
            this.panelemploye.Controls.Add(this.spdataemploye);
            this.panelemploye.Location = new System.Drawing.Point(85, 0);
            this.panelemploye.Name = "panelemploye";
            this.panelemploye.Size = new System.Drawing.Size(731, 434);
            this.panelemploye.TabIndex = 3;
            this.panelemploye.Text = "\\";
            this.panelemploye.UsesBlockingAnimation = false;
            // 
            // spdataemploye
            // 
            this.spdataemploye.BackColor = System.Drawing.Color.White;
            this.spdataemploye.Controls.Add(this.buttonX2);
            this.spdataemploye.Controls.Add(this.pictview);
            this.spdataemploye.Controls.Add(this.txtaddress);
            this.spdataemploye.Controls.Add(this.txtemail);
            this.spdataemploye.Controls.Add(this.txtphonenumber);
            this.spdataemploye.Controls.Add(this.txtfullname);
            this.spdataemploye.Controls.Add(this.label4);
            this.spdataemploye.Controls.Add(this.label3);
            this.spdataemploye.Controls.Add(this.label2);
            this.spdataemploye.Controls.Add(this.label1);
            this.spdataemploye.Enabled = false;
            this.spdataemploye.Location = new System.Drawing.Point(6, 3);
            this.spdataemploye.Name = "spdataemploye";
            this.spdataemploye.Size = new System.Drawing.Size(715, 198);
            this.spdataemploye.TabIndex = 0;
            this.spdataemploye.Text = "0";
            this.spdataemploye.UsesBlockingAnimation = false;
            // 
            // gridemploye
            // 
            this.gridemploye.AutoGenerateColumns = false;
            this.gridemploye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridemploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridemploye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.karyawanIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.gridemploye.DataSource = this.karyawanBindingSource;
            this.gridemploye.Location = new System.Drawing.Point(6, 243);
            this.gridemploye.Name = "gridemploye";
            this.gridemploye.Size = new System.Drawing.Size(715, 184);
            this.gridemploye.TabIndex = 1;
            this.gridemploye.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridemploye_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // txtfullname
            // 
            this.txtfullname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "FullName", true));
            this.txtfullname.Location = new System.Drawing.Point(148, 7);
            this.txtfullname.Multiline = true;
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(251, 28);
            this.txtfullname.TabIndex = 0;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "PhoneNumber", true));
            this.txtphonenumber.Location = new System.Drawing.Point(148, 40);
            this.txtphonenumber.Multiline = true;
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(251, 28);
            this.txtphonenumber.TabIndex = 1;
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "Email", true));
            this.txtemail.Location = new System.Drawing.Point(148, 74);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(251, 28);
            this.txtemail.TabIndex = 2;
            // 
            // txtaddress
            // 
            this.txtaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "Address", true));
            this.txtaddress.Location = new System.Drawing.Point(148, 108);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(408, 80);
            this.txtaddress.TabIndex = 3;
            // 
            // btnnew
            // 
            this.btnnew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnnew.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnnew.Location = new System.Drawing.Point(495, 7);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnnew.Symbol = "";
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "New";
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnedit
            // 
            this.btnedit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnedit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnedit.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnedit.Location = new System.Drawing.Point(573, 7);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnedit.Symbol = "";
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "Edit";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btncancel
            // 
            this.btncancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btncancel.Location = new System.Drawing.Point(651, 7);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btncancel.Symbol = "";
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnsave.Location = new System.Drawing.Point(729, 6);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsave.Symbol = "";
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // pictview
            // 
            this.pictview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictview.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.karyawanBindingSource, "Image", true));
            this.pictview.Image = ((System.Drawing.Image)(resources.GetObject("pictview.Image")));
            this.pictview.InitialImage = null;
            this.pictview.Location = new System.Drawing.Point(582, 12);
            this.pictview.Name = "pictview";
            this.pictview.Size = new System.Drawing.Size(118, 118);
            this.pictview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictview.TabIndex = 8;
            this.pictview.TabStop = false;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.buttonX2.Location = new System.Drawing.Point(583, 144);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(117, 34);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.TabIndex = 4;
            this.buttonX2.Text = "Browse";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 207);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(567, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Search";
            // 
            // karyawanIDDataGridViewTextBoxColumn
            // 
            this.karyawanIDDataGridViewTextBoxColumn.DataPropertyName = "KaryawanID";
            this.karyawanIDDataGridViewTextBoxColumn.HeaderText = "KaryawanID";
            this.karyawanIDDataGridViewTextBoxColumn.Name = "karyawanIDDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // karyawanBindingSource
            // 
            this.karyawanBindingSource.DataMember = "karyawan";
            this.karyawanBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karyawanTableAdapter
            // 
            this.karyawanTableAdapter.ClearBeforeFill = true;
            // 
            // karyawanBindingSource1
            // 
            this.karyawanBindingSource1.DataMember = "karyawan";
            this.karyawanBindingSource1.DataSource = this.appData;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 481);
            this.Controls.Add(this.panelemploye);
            this.Controls.Add(this.panelbottom);
            this.Controls.Add(this.panelfooter);
            this.Controls.Add(this.panelmenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelmenu.ResumeLayout(false);
            this.panelfooter.ResumeLayout(false);
            this.panelemploye.ResumeLayout(false);
            this.panelemploye.PerformLayout();
            this.spdataemploye.ResumeLayout(false);
            this.spdataemploye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridemploye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SlidePanel panelmenu;
        private DevComponents.DotNetBar.ButtonX btnlogout;
        private DevComponents.DotNetBar.ButtonX btnclass;
        private DevComponents.DotNetBar.ButtonX btnposition;
        private DevComponents.DotNetBar.ButtonX btnemploye;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.SlidePanel panelfooter;
        private DevComponents.DotNetBar.Controls.SlidePanel panelbottom;
        private DevComponents.DotNetBar.Controls.SlidePanel panelemploye;
        private System.Windows.Forms.DataGridView gridemploye;
        private DevComponents.DotNetBar.Controls.SlidePanel spdataemploye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.ButtonX btnnew;
        private DevComponents.DotNetBar.ButtonX btnsave;
        private DevComponents.DotNetBar.ButtonX btncancel;
        private DevComponents.DotNetBar.ButtonX btnedit;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.PictureBox pictview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private AppData appData;
        private System.Windows.Forms.BindingSource karyawanBindingSource;
        private AppDataTableAdapters.karyawanTableAdapter karyawanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn karyawanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource karyawanBindingSource1;
    }
}

