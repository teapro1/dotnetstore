namespace PrepareForFinal.UI
{
    partial class us_supplyUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_productID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_supplyAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_supplyID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_findSupply = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_supplyAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_supplyID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_findSupply = new Guna.UI2.WinForms.Guna2Button();
            this.btn_supplyInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cb_nameProduct = new System.Windows.Forms.ComboBox();
            this.btn_supplyCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_supplyDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_supplySave = new Guna.UI2.WinForms.Guna2Button();
            this.btn_supplyUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btn_supplyAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dtgv_supplyList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.s_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_supplyPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_supplyName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_supplyPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_supplyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_supplyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_supplyList)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_productID
            // 
            this.lb_productID.AutoSize = false;
            this.lb_productID.BackColor = System.Drawing.Color.Transparent;
            this.lb_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_productID.Location = new System.Drawing.Point(959, 39);
            this.lb_productID.Name = "lb_productID";
            this.lb_productID.Size = new System.Drawing.Size(255, 25);
            this.lb_productID.TabIndex = 14;
            this.lb_productID.Text = "Tên sản phẩm";
            // 
            // lb_supplyAddress
            // 
            this.lb_supplyAddress.AutoSize = false;
            this.lb_supplyAddress.BackColor = System.Drawing.Color.Transparent;
            this.lb_supplyAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplyAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_supplyAddress.Location = new System.Drawing.Point(721, 111);
            this.lb_supplyAddress.Name = "lb_supplyAddress";
            this.lb_supplyAddress.Size = new System.Drawing.Size(139, 25);
            this.lb_supplyAddress.TabIndex = 14;
            this.lb_supplyAddress.Text = "Địa chỉ";
            // 
            // lb_supplyID
            // 
            this.lb_supplyID.AutoSize = false;
            this.lb_supplyID.BackColor = System.Drawing.Color.Transparent;
            this.lb_supplyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_supplyID.Location = new System.Drawing.Point(721, 39);
            this.lb_supplyID.Name = "lb_supplyID";
            this.lb_supplyID.Size = new System.Drawing.Size(191, 25);
            this.lb_supplyID.TabIndex = 14;
            this.lb_supplyID.Text = "Mã nhà cung cấp";
            // 
            // txt_findSupply
            // 
            this.txt_findSupply.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_findSupply.DefaultText = "";
            this.txt_findSupply.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_findSupply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_findSupply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_findSupply.DisabledState.Parent = this.txt_findSupply;
            this.txt_findSupply.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_findSupply.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findSupply.FocusedState.Parent = this.txt_findSupply;
            this.txt_findSupply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findSupply.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findSupply.HoverState.Parent = this.txt_findSupply;
            this.txt_findSupply.Location = new System.Drawing.Point(721, 370);
            this.txt_findSupply.Margin = new System.Windows.Forms.Padding(14, 72, 14, 72);
            this.txt_findSupply.Name = "txt_findSupply";
            this.txt_findSupply.PasswordChar = '\0';
            this.txt_findSupply.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_findSupply.PlaceholderText = "";
            this.txt_findSupply.SelectedText = "";
            this.txt_findSupply.ShadowDecoration.Parent = this.txt_findSupply;
            this.txt_findSupply.Size = new System.Drawing.Size(258, 36);
            this.txt_findSupply.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_findSupply.TabIndex = 12;
            this.txt_findSupply.TextChanged += new System.EventHandler(this.txt_findSupply_TextChanged);
            // 
            // txt_supplyAddress
            // 
            this.txt_supplyAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_supplyAddress.DefaultText = "";
            this.txt_supplyAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_supplyAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_supplyAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyAddress.DisabledState.Parent = this.txt_supplyAddress;
            this.txt_supplyAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyAddress.FocusedState.Parent = this.txt_supplyAddress;
            this.txt_supplyAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyAddress.HoverState.Parent = this.txt_supplyAddress;
            this.txt_supplyAddress.Location = new System.Drawing.Point(721, 139);
            this.txt_supplyAddress.Margin = new System.Windows.Forms.Padding(14, 45, 14, 45);
            this.txt_supplyAddress.Name = "txt_supplyAddress";
            this.txt_supplyAddress.PasswordChar = '\0';
            this.txt_supplyAddress.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_supplyAddress.PlaceholderText = "";
            this.txt_supplyAddress.SelectedText = "";
            this.txt_supplyAddress.ShadowDecoration.Parent = this.txt_supplyAddress;
            this.txt_supplyAddress.Size = new System.Drawing.Size(203, 37);
            this.txt_supplyAddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_supplyAddress.TabIndex = 13;
            // 
            // txt_supplyID
            // 
            this.txt_supplyID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_supplyID.DefaultText = "";
            this.txt_supplyID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_supplyID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_supplyID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyID.DisabledState.Parent = this.txt_supplyID;
            this.txt_supplyID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyID.FocusedState.Parent = this.txt_supplyID;
            this.txt_supplyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyID.HoverState.Parent = this.txt_supplyID;
            this.txt_supplyID.Location = new System.Drawing.Point(721, 66);
            this.txt_supplyID.Margin = new System.Windows.Forms.Padding(9, 23, 9, 23);
            this.txt_supplyID.Name = "txt_supplyID";
            this.txt_supplyID.PasswordChar = '\0';
            this.txt_supplyID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_supplyID.PlaceholderText = "";
            this.txt_supplyID.SelectedText = "";
            this.txt_supplyID.ShadowDecoration.Parent = this.txt_supplyID;
            this.txt_supplyID.Size = new System.Drawing.Size(203, 37);
            this.txt_supplyID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_supplyID.TabIndex = 13;
            // 
            // btn_findSupply
            // 
            this.btn_findSupply.BackColor = System.Drawing.Color.Transparent;
            this.btn_findSupply.BorderRadius = 5;
            this.btn_findSupply.CheckedState.Parent = this.btn_findSupply;
            this.btn_findSupply.CustomImages.Parent = this.btn_findSupply;
            this.btn_findSupply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_findSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_findSupply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_findSupply.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_findSupply.HoverState.Parent = this.btn_findSupply;
            this.btn_findSupply.Location = new System.Drawing.Point(996, 368);
            this.btn_findSupply.Name = "btn_findSupply";
            this.btn_findSupply.ShadowDecoration.Parent = this.btn_findSupply;
            this.btn_findSupply.Size = new System.Drawing.Size(138, 41);
            this.btn_findSupply.TabIndex = 5;
            this.btn_findSupply.Text = "Tìm kiếm";
            this.btn_findSupply.Click += new System.EventHandler(this.btn_findSupply_Click);
            // 
            // btn_supplyInfo
            // 
            this.btn_supplyInfo.BackColor = System.Drawing.Color.Transparent;
            this.btn_supplyInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_supplyInfo.BorderRadius = 5;
            this.btn_supplyInfo.BorderThickness = 2;
            this.btn_supplyInfo.Controls.Add(this.cb_nameProduct);
            this.btn_supplyInfo.Controls.Add(this.btn_supplyCancel);
            this.btn_supplyInfo.Controls.Add(this.btn_supplyDelete);
            this.btn_supplyInfo.Controls.Add(this.btn_supplySave);
            this.btn_supplyInfo.Controls.Add(this.btn_supplyUpdate);
            this.btn_supplyInfo.Controls.Add(this.btn_supplyAdd);
            this.btn_supplyInfo.Controls.Add(this.dtgv_supplyList);
            this.btn_supplyInfo.Controls.Add(this.lb_productID);
            this.btn_supplyInfo.Controls.Add(this.lb_supplyPhone);
            this.btn_supplyInfo.Controls.Add(this.lb_supplyAddress);
            this.btn_supplyInfo.Controls.Add(this.lb_supplyName);
            this.btn_supplyInfo.Controls.Add(this.lb_supplyID);
            this.btn_supplyInfo.Controls.Add(this.txt_findSupply);
            this.btn_supplyInfo.Controls.Add(this.txt_supplyPhone);
            this.btn_supplyInfo.Controls.Add(this.txt_supplyAddress);
            this.btn_supplyInfo.Controls.Add(this.txt_supplyName);
            this.btn_supplyInfo.Controls.Add(this.txt_supplyID);
            this.btn_supplyInfo.Controls.Add(this.btn_findSupply);
            this.btn_supplyInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_supplyInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.btn_supplyInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_supplyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplyInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_supplyInfo.Location = new System.Drawing.Point(3, 3);
            this.btn_supplyInfo.Name = "btn_supplyInfo";
            this.btn_supplyInfo.ShadowDecoration.Parent = this.btn_supplyInfo;
            this.btn_supplyInfo.Size = new System.Drawing.Size(1171, 525);
            this.btn_supplyInfo.TabIndex = 16;
            this.btn_supplyInfo.Text = "Thông tin nhà cung cấp";
            // 
            // cb_nameProduct
            // 
            this.cb_nameProduct.FormattingEnabled = true;
            this.cb_nameProduct.Location = new System.Drawing.Point(959, 66);
            this.cb_nameProduct.Name = "cb_nameProduct";
            this.cb_nameProduct.Size = new System.Drawing.Size(181, 30);
            this.cb_nameProduct.TabIndex = 40;
            // 
            // btn_supplyCancel
            // 
            this.btn_supplyCancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_supplyCancel.BorderRadius = 5;
            this.btn_supplyCancel.CheckedState.Parent = this.btn_supplyCancel;
            this.btn_supplyCancel.CustomImages.Parent = this.btn_supplyCancel;
            this.btn_supplyCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_supplyCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplyCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_supplyCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_supplyCancel.HoverState.Parent = this.btn_supplyCancel;
            this.btn_supplyCancel.Location = new System.Drawing.Point(976, 432);
            this.btn_supplyCancel.Name = "btn_supplyCancel";
            this.btn_supplyCancel.ShadowDecoration.Parent = this.btn_supplyCancel;
            this.btn_supplyCancel.Size = new System.Drawing.Size(75, 49);
            this.btn_supplyCancel.TabIndex = 39;
            this.btn_supplyCancel.Text = "Hủy";
            this.btn_supplyCancel.Click += new System.EventHandler(this.btn_supplyCancel_Click);
            // 
            // btn_supplyDelete
            // 
            this.btn_supplyDelete.BackColor = System.Drawing.Color.Transparent;
            this.btn_supplyDelete.BorderRadius = 5;
            this.btn_supplyDelete.CheckedState.Parent = this.btn_supplyDelete;
            this.btn_supplyDelete.CustomImages.Parent = this.btn_supplyDelete;
            this.btn_supplyDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.btn_supplyDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplyDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_supplyDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_supplyDelete.HoverState.Parent = this.btn_supplyDelete;
            this.btn_supplyDelete.Location = new System.Drawing.Point(1061, 432);
            this.btn_supplyDelete.Name = "btn_supplyDelete";
            this.btn_supplyDelete.ShadowDecoration.Parent = this.btn_supplyDelete;
            this.btn_supplyDelete.Size = new System.Drawing.Size(72, 49);
            this.btn_supplyDelete.TabIndex = 35;
            this.btn_supplyDelete.Text = "Xóa";
            this.btn_supplyDelete.Click += new System.EventHandler(this.btn_supplyDelete_Click);
            // 
            // btn_supplySave
            // 
            this.btn_supplySave.BackColor = System.Drawing.Color.Transparent;
            this.btn_supplySave.BorderRadius = 5;
            this.btn_supplySave.CheckedState.Parent = this.btn_supplySave;
            this.btn_supplySave.CustomImages.Parent = this.btn_supplySave;
            this.btn_supplySave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_supplySave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplySave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_supplySave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_supplySave.HoverState.Parent = this.btn_supplySave;
            this.btn_supplySave.Location = new System.Drawing.Point(891, 432);
            this.btn_supplySave.Name = "btn_supplySave";
            this.btn_supplySave.ShadowDecoration.Parent = this.btn_supplySave;
            this.btn_supplySave.Size = new System.Drawing.Size(75, 49);
            this.btn_supplySave.TabIndex = 36;
            this.btn_supplySave.Text = "Lưu";
            this.btn_supplySave.Click += new System.EventHandler(this.btn_supplySave_Click);
            // 
            // btn_supplyUpdate
            // 
            this.btn_supplyUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btn_supplyUpdate.BorderRadius = 5;
            this.btn_supplyUpdate.CheckedState.Parent = this.btn_supplyUpdate;
            this.btn_supplyUpdate.CustomImages.Parent = this.btn_supplyUpdate;
            this.btn_supplyUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_supplyUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplyUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_supplyUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_supplyUpdate.HoverState.Parent = this.btn_supplyUpdate;
            this.btn_supplyUpdate.Location = new System.Drawing.Point(806, 432);
            this.btn_supplyUpdate.Name = "btn_supplyUpdate";
            this.btn_supplyUpdate.ShadowDecoration.Parent = this.btn_supplyUpdate;
            this.btn_supplyUpdate.Size = new System.Drawing.Size(75, 49);
            this.btn_supplyUpdate.TabIndex = 37;
            this.btn_supplyUpdate.Text = "Sửa";
            this.btn_supplyUpdate.Click += new System.EventHandler(this.btn_supplyUpdate_Click);
            // 
            // btn_supplyAdd
            // 
            this.btn_supplyAdd.BackColor = System.Drawing.Color.Transparent;
            this.btn_supplyAdd.BorderRadius = 5;
            this.btn_supplyAdd.CheckedState.Parent = this.btn_supplyAdd;
            this.btn_supplyAdd.CustomImages.Parent = this.btn_supplyAdd;
            this.btn_supplyAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_supplyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplyAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_supplyAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_supplyAdd.HoverState.Parent = this.btn_supplyAdd;
            this.btn_supplyAdd.Location = new System.Drawing.Point(721, 432);
            this.btn_supplyAdd.Name = "btn_supplyAdd";
            this.btn_supplyAdd.ShadowDecoration.Parent = this.btn_supplyAdd;
            this.btn_supplyAdd.Size = new System.Drawing.Size(75, 49);
            this.btn_supplyAdd.TabIndex = 38;
            this.btn_supplyAdd.Text = "Thêm";
            this.btn_supplyAdd.Click += new System.EventHandler(this.btn_supplyAdd_Click);
            // 
            // dtgv_supplyList
            // 
            this.dtgv_supplyList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv_supplyList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_supplyList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_supplyList.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_supplyList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_supplyList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_supplyList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_supplyList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_supplyList.ColumnHeadersHeight = 28;
            this.dtgv_supplyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s_id,
            this.s_name,
            this.s_address,
            this.s_phone,
            this.p_id,
            this.s_status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_supplyList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_supplyList.EnableHeadersVisualStyles = false;
            this.dtgv_supplyList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_supplyList.Location = new System.Drawing.Point(15, 64);
            this.dtgv_supplyList.Name = "dtgv_supplyList";
            this.dtgv_supplyList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_supplyList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_supplyList.RowHeadersVisible = false;
            this.dtgv_supplyList.RowHeadersWidth = 51;
            this.dtgv_supplyList.RowTemplate.Height = 24;
            this.dtgv_supplyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_supplyList.Size = new System.Drawing.Size(689, 417);
            this.dtgv_supplyList.TabIndex = 23;
            this.dtgv_supplyList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgv_supplyList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_supplyList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_supplyList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_supplyList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_supplyList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_supplyList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_supplyList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_supplyList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.dtgv_supplyList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_supplyList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_supplyList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.dtgv_supplyList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_supplyList.ThemeStyle.HeaderStyle.Height = 28;
            this.dtgv_supplyList.ThemeStyle.ReadOnly = true;
            this.dtgv_supplyList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_supplyList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_supplyList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_supplyList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.dtgv_supplyList.ThemeStyle.RowsStyle.Height = 24;
            this.dtgv_supplyList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_supplyList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgv_supplyList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_supplyList_CellClick);
            // 
            // s_id
            // 
            this.s_id.DataPropertyName = "s_id";
            this.s_id.HeaderText = "Mã NSX";
            this.s_id.MinimumWidth = 6;
            this.s_id.Name = "s_id";
            this.s_id.ReadOnly = true;
            // 
            // s_name
            // 
            this.s_name.DataPropertyName = "s_name";
            this.s_name.HeaderText = "Tên NSX";
            this.s_name.MinimumWidth = 6;
            this.s_name.Name = "s_name";
            this.s_name.ReadOnly = true;
            // 
            // s_address
            // 
            this.s_address.DataPropertyName = "s_address";
            this.s_address.HeaderText = "Địa chỉ";
            this.s_address.MinimumWidth = 6;
            this.s_address.Name = "s_address";
            this.s_address.ReadOnly = true;
            // 
            // s_phone
            // 
            this.s_phone.DataPropertyName = "s_phone";
            this.s_phone.HeaderText = "SĐT";
            this.s_phone.MinimumWidth = 6;
            this.s_phone.Name = "s_phone";
            this.s_phone.ReadOnly = true;
            // 
            // p_id
            // 
            this.p_id.DataPropertyName = "p_id";
            this.p_id.HeaderText = "Mã SP";
            this.p_id.MinimumWidth = 6;
            this.p_id.Name = "p_id";
            this.p_id.ReadOnly = true;
            // 
            // s_status
            // 
            this.s_status.DataPropertyName = "s_status";
            this.s_status.HeaderText = "Tình trạng";
            this.s_status.MinimumWidth = 6;
            this.s_status.Name = "s_status";
            this.s_status.ReadOnly = true;
            // 
            // lb_supplyPhone
            // 
            this.lb_supplyPhone.AutoSize = false;
            this.lb_supplyPhone.BackColor = System.Drawing.Color.Transparent;
            this.lb_supplyPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplyPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_supplyPhone.Location = new System.Drawing.Point(959, 111);
            this.lb_supplyPhone.Name = "lb_supplyPhone";
            this.lb_supplyPhone.Size = new System.Drawing.Size(139, 25);
            this.lb_supplyPhone.TabIndex = 14;
            this.lb_supplyPhone.Text = "Điện thoại";
            // 
            // lb_supplyName
            // 
            this.lb_supplyName.AutoSize = false;
            this.lb_supplyName.BackColor = System.Drawing.Color.Transparent;
            this.lb_supplyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_supplyName.Location = new System.Drawing.Point(721, 183);
            this.lb_supplyName.Name = "lb_supplyName";
            this.lb_supplyName.Size = new System.Drawing.Size(225, 25);
            this.lb_supplyName.TabIndex = 14;
            this.lb_supplyName.Text = "Tên nhà cung cấp";
            // 
            // txt_supplyPhone
            // 
            this.txt_supplyPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_supplyPhone.DefaultText = "";
            this.txt_supplyPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_supplyPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_supplyPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyPhone.DisabledState.Parent = this.txt_supplyPhone;
            this.txt_supplyPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyPhone.FocusedState.Parent = this.txt_supplyPhone;
            this.txt_supplyPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyPhone.HoverState.Parent = this.txt_supplyPhone;
            this.txt_supplyPhone.Location = new System.Drawing.Point(959, 139);
            this.txt_supplyPhone.Margin = new System.Windows.Forms.Padding(21, 87, 21, 87);
            this.txt_supplyPhone.Name = "txt_supplyPhone";
            this.txt_supplyPhone.PasswordChar = '\0';
            this.txt_supplyPhone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_supplyPhone.PlaceholderText = "";
            this.txt_supplyPhone.SelectedText = "";
            this.txt_supplyPhone.ShadowDecoration.Parent = this.txt_supplyPhone;
            this.txt_supplyPhone.Size = new System.Drawing.Size(174, 37);
            this.txt_supplyPhone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_supplyPhone.TabIndex = 13;
            // 
            // txt_supplyName
            // 
            this.txt_supplyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_supplyName.DefaultText = "";
            this.txt_supplyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_supplyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_supplyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyName.DisabledState.Parent = this.txt_supplyName;
            this.txt_supplyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyName.FocusedState.Parent = this.txt_supplyName;
            this.txt_supplyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyName.HoverState.Parent = this.txt_supplyName;
            this.txt_supplyName.Location = new System.Drawing.Point(721, 212);
            this.txt_supplyName.Margin = new System.Windows.Forms.Padding(14, 45, 14, 45);
            this.txt_supplyName.Name = "txt_supplyName";
            this.txt_supplyName.PasswordChar = '\0';
            this.txt_supplyName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_supplyName.PlaceholderText = "";
            this.txt_supplyName.SelectedText = "";
            this.txt_supplyName.ShadowDecoration.Parent = this.txt_supplyName;
            this.txt_supplyName.Size = new System.Drawing.Size(412, 37);
            this.txt_supplyName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_supplyName.TabIndex = 13;
            // 
            // us_supplyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_supplyInfo);
            this.Name = "us_supplyUI";
            this.Size = new System.Drawing.Size(1177, 531);
            this.Load += new System.EventHandler(this.us_supplyUI_Load);
            this.btn_supplyInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_supplyList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lb_productID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_supplyAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_supplyID;
        private Guna.UI2.WinForms.Guna2TextBox txt_findSupply;
        private Guna.UI2.WinForms.Guna2TextBox txt_supplyAddress;
        private Guna.UI2.WinForms.Guna2TextBox txt_supplyID;
        private Guna.UI2.WinForms.Guna2Button btn_findSupply;
        private Guna.UI2.WinForms.Guna2GroupBox btn_supplyInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_supplyPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_supplyName;
        private Guna.UI2.WinForms.Guna2TextBox txt_supplyPhone;
        private Guna.UI2.WinForms.Guna2TextBox txt_supplyName;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_supplyList;
        private Guna.UI2.WinForms.Guna2Button btn_supplyCancel;
        private Guna.UI2.WinForms.Guna2Button btn_supplyDelete;
        private Guna.UI2.WinForms.Guna2Button btn_supplySave;
        private Guna.UI2.WinForms.Guna2Button btn_supplyUpdate;
        private Guna.UI2.WinForms.Guna2Button btn_supplyAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_status;
        private System.Windows.Forms.ComboBox cb_nameProduct;
    }
}
