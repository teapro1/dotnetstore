namespace PrepareForFinal.UI
{
    partial class frm_typeList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_header = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gb_typeInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtgv_typeList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txt_typeName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_typeName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_typeID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_typeID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_typeCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_typeDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_typeSave = new Guna.UI2.WinForms.Guna2Button();
            this.btn_typeUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btn_typeAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txt_findType = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_findType = new Guna.UI2.WinForms.Guna2Button();
            this.gb_typeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_typeList)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_header
            // 
            this.lb_header.AutoSize = false;
            this.lb_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.lb_header.Location = new System.Drawing.Point(0, 0);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(904, 54);
            this.lb_header.TabIndex = 20;
            this.lb_header.Text = "-   Danh sách loại sản phẩm";
            this.lb_header.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(859, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 21;
            // 
            // gb_typeInfo
            // 
            this.gb_typeInfo.BackColor = System.Drawing.Color.Transparent;
            this.gb_typeInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.gb_typeInfo.BorderRadius = 5;
            this.gb_typeInfo.BorderThickness = 2;
            this.gb_typeInfo.Controls.Add(this.dtgv_typeList);
            this.gb_typeInfo.Controls.Add(this.txt_typeName);
            this.gb_typeInfo.Controls.Add(this.lb_typeName);
            this.gb_typeInfo.Controls.Add(this.txt_typeID);
            this.gb_typeInfo.Controls.Add(this.lb_typeID);
            this.gb_typeInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.gb_typeInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gb_typeInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.gb_typeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_typeInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.gb_typeInfo.Location = new System.Drawing.Point(9, 60);
            this.gb_typeInfo.Name = "gb_typeInfo";
            this.gb_typeInfo.ShadowDecoration.Parent = this.gb_typeInfo;
            this.gb_typeInfo.Size = new System.Drawing.Size(572, 381);
            this.gb_typeInfo.TabIndex = 28;
            this.gb_typeInfo.Text = "Thông tin chung";
            // 
            // dtgv_typeList
            // 
            this.dtgv_typeList.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dtgv_typeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgv_typeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_typeList.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_typeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_typeList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_typeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_typeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgv_typeList.ColumnHeadersHeight = 28;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_typeList.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgv_typeList.EnableHeadersVisualStyles = false;
            this.dtgv_typeList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_typeList.Location = new System.Drawing.Point(15, 129);
            this.dtgv_typeList.Name = "dtgv_typeList";
            this.dtgv_typeList.ReadOnly = true;
            this.dtgv_typeList.RowHeadersVisible = false;
            this.dtgv_typeList.RowHeadersWidth = 51;
            this.dtgv_typeList.RowTemplate.Height = 24;
            this.dtgv_typeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_typeList.Size = new System.Drawing.Size(538, 216);
            this.dtgv_typeList.TabIndex = 27;
            this.dtgv_typeList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgv_typeList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_typeList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_typeList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_typeList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_typeList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_typeList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_typeList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_typeList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.dtgv_typeList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_typeList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_typeList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.dtgv_typeList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_typeList.ThemeStyle.HeaderStyle.Height = 28;
            this.dtgv_typeList.ThemeStyle.ReadOnly = true;
            this.dtgv_typeList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_typeList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_typeList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_typeList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.dtgv_typeList.ThemeStyle.RowsStyle.Height = 24;
            this.dtgv_typeList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_typeList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgv_typeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_typeList_CellClick);
            // 
            // txt_typeName
            // 
            this.txt_typeName.BackColor = System.Drawing.Color.Transparent;
            this.txt_typeName.BorderRadius = 5;
            this.txt_typeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_typeName.DefaultText = "";
            this.txt_typeName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_typeName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_typeName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_typeName.DisabledState.Parent = this.txt_typeName;
            this.txt_typeName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_typeName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_typeName.FocusedState.Parent = this.txt_typeName;
            this.txt_typeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_typeName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_typeName.HoverState.Parent = this.txt_typeName;
            this.txt_typeName.Location = new System.Drawing.Point(254, 66);
            this.txt_typeName.Margin = new System.Windows.Forms.Padding(11, 45, 11, 45);
            this.txt_typeName.Name = "txt_typeName";
            this.txt_typeName.PasswordChar = '\0';
            this.txt_typeName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_typeName.PlaceholderText = "";
            this.txt_typeName.SelectedText = "";
            this.txt_typeName.ShadowDecoration.Parent = this.txt_typeName;
            this.txt_typeName.Size = new System.Drawing.Size(299, 37);
            this.txt_typeName.TabIndex = 15;
            // 
            // lb_typeName
            // 
            this.lb_typeName.AutoSize = false;
            this.lb_typeName.BackColor = System.Drawing.Color.Transparent;
            this.lb_typeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_typeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_typeName.Location = new System.Drawing.Point(254, 38);
            this.lb_typeName.Name = "lb_typeName";
            this.lb_typeName.Size = new System.Drawing.Size(206, 34);
            this.lb_typeName.TabIndex = 14;
            this.lb_typeName.Text = "Tên loại";
            // 
            // txt_typeID
            // 
            this.txt_typeID.BackColor = System.Drawing.Color.Transparent;
            this.txt_typeID.BorderRadius = 5;
            this.txt_typeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_typeID.DefaultText = "";
            this.txt_typeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_typeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_typeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_typeID.DisabledState.Parent = this.txt_typeID;
            this.txt_typeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_typeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_typeID.FocusedState.Parent = this.txt_typeID;
            this.txt_typeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_typeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_typeID.HoverState.Parent = this.txt_typeID;
            this.txt_typeID.Location = new System.Drawing.Point(15, 66);
            this.txt_typeID.Margin = new System.Windows.Forms.Padding(8, 23, 8, 23);
            this.txt_typeID.Name = "txt_typeID";
            this.txt_typeID.PasswordChar = '\0';
            this.txt_typeID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_typeID.PlaceholderText = "";
            this.txt_typeID.SelectedText = "";
            this.txt_typeID.ShadowDecoration.Parent = this.txt_typeID;
            this.txt_typeID.Size = new System.Drawing.Size(192, 37);
            this.txt_typeID.TabIndex = 15;
            // 
            // lb_typeID
            // 
            this.lb_typeID.AutoSize = false;
            this.lb_typeID.BackColor = System.Drawing.Color.Transparent;
            this.lb_typeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_typeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_typeID.Location = new System.Drawing.Point(15, 38);
            this.lb_typeID.Name = "lb_typeID";
            this.lb_typeID.Size = new System.Drawing.Size(206, 34);
            this.lb_typeID.TabIndex = 14;
            this.lb_typeID.Text = "Mã loại";
            // 
            // btn_typeCancel
            // 
            this.btn_typeCancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_typeCancel.BorderRadius = 5;
            this.btn_typeCancel.CheckedState.Parent = this.btn_typeCancel;
            this.btn_typeCancel.CustomImages.Parent = this.btn_typeCancel;
            this.btn_typeCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_typeCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_typeCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_typeCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_typeCancel.HoverState.Parent = this.btn_typeCancel;
            this.btn_typeCancel.Location = new System.Drawing.Point(598, 333);
            this.btn_typeCancel.Name = "btn_typeCancel";
            this.btn_typeCancel.ShadowDecoration.Parent = this.btn_typeCancel;
            this.btn_typeCancel.Size = new System.Drawing.Size(147, 47);
            this.btn_typeCancel.TabIndex = 46;
            this.btn_typeCancel.Text = "Hủy";
            this.btn_typeCancel.Click += new System.EventHandler(this.btn_typeCancel_Click);
            // 
            // btn_typeDelete
            // 
            this.btn_typeDelete.BackColor = System.Drawing.Color.Transparent;
            this.btn_typeDelete.BorderRadius = 5;
            this.btn_typeDelete.CheckedState.Parent = this.btn_typeDelete;
            this.btn_typeDelete.CustomImages.Parent = this.btn_typeDelete;
            this.btn_typeDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.btn_typeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_typeDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_typeDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_typeDelete.HoverState.Parent = this.btn_typeDelete;
            this.btn_typeDelete.Location = new System.Drawing.Point(598, 388);
            this.btn_typeDelete.Name = "btn_typeDelete";
            this.btn_typeDelete.ShadowDecoration.Parent = this.btn_typeDelete;
            this.btn_typeDelete.Size = new System.Drawing.Size(277, 47);
            this.btn_typeDelete.TabIndex = 42;
            this.btn_typeDelete.Text = "Xóa";
            this.btn_typeDelete.Click += new System.EventHandler(this.btn_typeDelete_Click);
            // 
            // btn_typeSave
            // 
            this.btn_typeSave.BackColor = System.Drawing.Color.Transparent;
            this.btn_typeSave.BorderRadius = 5;
            this.btn_typeSave.CheckedState.Parent = this.btn_typeSave;
            this.btn_typeSave.CustomImages.Parent = this.btn_typeSave;
            this.btn_typeSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_typeSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_typeSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_typeSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_typeSave.HoverState.Parent = this.btn_typeSave;
            this.btn_typeSave.Location = new System.Drawing.Point(751, 333);
            this.btn_typeSave.Name = "btn_typeSave";
            this.btn_typeSave.ShadowDecoration.Parent = this.btn_typeSave;
            this.btn_typeSave.Size = new System.Drawing.Size(124, 47);
            this.btn_typeSave.TabIndex = 43;
            this.btn_typeSave.Text = "Lưu";
            this.btn_typeSave.Click += new System.EventHandler(this.btn_typeSave_Click);
            // 
            // btn_typeUpdate
            // 
            this.btn_typeUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btn_typeUpdate.BorderRadius = 5;
            this.btn_typeUpdate.CheckedState.Parent = this.btn_typeUpdate;
            this.btn_typeUpdate.CustomImages.Parent = this.btn_typeUpdate;
            this.btn_typeUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_typeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_typeUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_typeUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_typeUpdate.HoverState.Parent = this.btn_typeUpdate;
            this.btn_typeUpdate.Location = new System.Drawing.Point(751, 278);
            this.btn_typeUpdate.Name = "btn_typeUpdate";
            this.btn_typeUpdate.ShadowDecoration.Parent = this.btn_typeUpdate;
            this.btn_typeUpdate.Size = new System.Drawing.Size(124, 47);
            this.btn_typeUpdate.TabIndex = 44;
            this.btn_typeUpdate.Text = "Sửa";
            this.btn_typeUpdate.Click += new System.EventHandler(this.btn_typeUpdate_Click);
            // 
            // btn_typeAdd
            // 
            this.btn_typeAdd.BackColor = System.Drawing.Color.Transparent;
            this.btn_typeAdd.BorderRadius = 5;
            this.btn_typeAdd.CheckedState.Parent = this.btn_typeAdd;
            this.btn_typeAdd.CustomImages.Parent = this.btn_typeAdd;
            this.btn_typeAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_typeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_typeAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_typeAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_typeAdd.HoverState.Parent = this.btn_typeAdd;
            this.btn_typeAdd.Location = new System.Drawing.Point(598, 278);
            this.btn_typeAdd.Name = "btn_typeAdd";
            this.btn_typeAdd.ShadowDecoration.Parent = this.btn_typeAdd;
            this.btn_typeAdd.Size = new System.Drawing.Size(147, 47);
            this.btn_typeAdd.TabIndex = 45;
            this.btn_typeAdd.Text = "Thêm";
            this.btn_typeAdd.Click += new System.EventHandler(this.btn_typeAdd_Click);
            // 
            // txt_findType
            // 
            this.txt_findType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_findType.DefaultText = "";
            this.txt_findType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_findType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_findType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_findType.DisabledState.Parent = this.txt_findType;
            this.txt_findType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_findType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findType.FocusedState.Parent = this.txt_findType;
            this.txt_findType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findType.HoverState.Parent = this.txt_findType;
            this.txt_findType.Location = new System.Drawing.Point(598, 182);
            this.txt_findType.Margin = new System.Windows.Forms.Padding(14, 72, 14, 72);
            this.txt_findType.Name = "txt_findType";
            this.txt_findType.PasswordChar = '\0';
            this.txt_findType.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_findType.PlaceholderText = "";
            this.txt_findType.SelectedText = "";
            this.txt_findType.ShadowDecoration.Parent = this.txt_findType;
            this.txt_findType.Size = new System.Drawing.Size(211, 36);
            this.txt_findType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_findType.TabIndex = 41;
            // 
            // btn_findType
            // 
            this.btn_findType.BackColor = System.Drawing.Color.Transparent;
            this.btn_findType.BorderRadius = 5;
            this.btn_findType.CheckedState.Parent = this.btn_findType;
            this.btn_findType.CustomImages.Parent = this.btn_findType;
            this.btn_findType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_findType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_findType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_findType.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_findType.HoverState.Parent = this.btn_findType;
            this.btn_findType.Location = new System.Drawing.Point(814, 180);
            this.btn_findType.Name = "btn_findType";
            this.btn_findType.ShadowDecoration.Parent = this.btn_findType;
            this.btn_findType.Size = new System.Drawing.Size(61, 41);
            this.btn_findType.TabIndex = 40;
            this.btn_findType.Text = "Tìm";
            this.btn_findType.Click += new System.EventHandler(this.btn_findType_Click);
            // 
            // frm_typeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.btn_typeCancel);
            this.Controls.Add(this.btn_typeDelete);
            this.Controls.Add(this.btn_typeSave);
            this.Controls.Add(this.btn_typeUpdate);
            this.Controls.Add(this.btn_typeAdd);
            this.Controls.Add(this.txt_findType);
            this.Controls.Add(this.btn_findType);
            this.Controls.Add(this.gb_typeInfo);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lb_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_typeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách loại sản phẩm";
            this.Load += new System.EventHandler(this.frm_typeList_Load);
            this.gb_typeInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_typeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lb_header;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GroupBox gb_typeInfo;
        private Guna.UI2.WinForms.Guna2TextBox txt_typeID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_typeID;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_typeList;
        private Guna.UI2.WinForms.Guna2TextBox txt_typeName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_typeName;
        private Guna.UI2.WinForms.Guna2Button btn_typeCancel;
        private Guna.UI2.WinForms.Guna2Button btn_typeDelete;
        private Guna.UI2.WinForms.Guna2Button btn_typeSave;
        private Guna.UI2.WinForms.Guna2Button btn_typeUpdate;
        private Guna.UI2.WinForms.Guna2Button btn_typeAdd;
        private Guna.UI2.WinForms.Guna2TextBox txt_findType;
        private Guna.UI2.WinForms.Guna2Button btn_findType;
    }
}