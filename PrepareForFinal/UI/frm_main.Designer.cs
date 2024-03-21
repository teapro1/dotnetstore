namespace PrepareForFinal.UI
{
    partial class frm_main
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
            this.pn_navigation = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.lblRoleName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRoleID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pn_groupButton = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_showAccountUI = new Guna.UI2.WinForms.Guna2Button();
            this.btn_showSupplyUI = new Guna.UI2.WinForms.Guna2Button();
            this.btn_showStatistic = new Guna.UI2.WinForms.Guna2Button();
            this.btn_showEmployeeUI = new Guna.UI2.WinForms.Guna2Button();
            this.btn_showCustomerUI = new Guna.UI2.WinForms.Guna2Button();
            this.btn_showPaymentUI = new Guna.UI2.WinForms.Guna2Button();
            this.btn_showProductUI = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lb_header = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_notify = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pn_notify = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.us_paymentUI = new PrepareForFinal.UI.us_paymentUI();
            this.us_supplyUI = new PrepareForFinal.UI.us_supplyUI();
            this.us_productUI = new PrepareForFinal.UI.us_productUI();
            this.us_customerUI = new PrepareForFinal.UI.us_customerUI();
            this.us_accountUI = new PrepareForFinal.UI.us_accountUI();
            this.us_employeeUI = new PrepareForFinal.UI.us_employeeUI();
            this.us_staticUI = new PrepareForFinal.UI.us_staticUI();
            this.pn_navigation.SuspendLayout();
            this.pn_groupButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_navigation
            // 
            this.pn_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.pn_navigation.Controls.Add(this.btn_logout);
            this.pn_navigation.Controls.Add(this.lblRoleName);
            this.pn_navigation.Controls.Add(this.lblRoleID);
            this.pn_navigation.Controls.Add(this.pn_groupButton);
            this.pn_navigation.Location = new System.Drawing.Point(-2, 44);
            this.pn_navigation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_navigation.Name = "pn_navigation";
            this.pn_navigation.ShadowDecoration.Parent = this.pn_navigation;
            this.pn_navigation.Size = new System.Drawing.Size(886, 68);
            this.pn_navigation.TabIndex = 19;
            // 
            // btn_logout
            // 
            this.btn_logout.BorderRadius = 5;
            this.btn_logout.CheckedState.Parent = this.btn_logout;
            this.btn_logout.CustomImages.Parent = this.btn_logout;
            this.btn_logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_logout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_logout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_logout.HoverState.Parent = this.btn_logout;
            this.btn_logout.Location = new System.Drawing.Point(814, 15);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.ShadowDecoration.Parent = this.btn_logout;
            this.btn_logout.Size = new System.Drawing.Size(62, 33);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "Thoát";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = false;
            this.lblRoleName.BackColor = System.Drawing.Color.Transparent;
            this.lblRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lblRoleName.Location = new System.Drawing.Point(751, 32);
            this.lblRoleName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(73, 24);
            this.lblRoleName.TabIndex = 8;
            this.lblRoleName.Text = "Nhân viên";
            // 
            // lblRoleID
            // 
            this.lblRoleID.AutoSize = false;
            this.lblRoleID.BackColor = System.Drawing.Color.Transparent;
            this.lblRoleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lblRoleID.Location = new System.Drawing.Point(754, 15);
            this.lblRoleID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblRoleID.Name = "lblRoleID";
            this.lblRoleID.Size = new System.Drawing.Size(73, 24);
            this.lblRoleID.TabIndex = 8;
            this.lblRoleID.Text = "Admin1";
            // 
            // pn_groupButton
            // 
            this.pn_groupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_groupButton.BackColor = System.Drawing.Color.Transparent;
            this.pn_groupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.pn_groupButton.BorderRadius = 5;
            this.pn_groupButton.BorderThickness = 2;
            this.pn_groupButton.Controls.Add(this.btn_showAccountUI);
            this.pn_groupButton.Controls.Add(this.btn_showSupplyUI);
            this.pn_groupButton.Controls.Add(this.btn_showStatistic);
            this.pn_groupButton.Controls.Add(this.btn_showEmployeeUI);
            this.pn_groupButton.Controls.Add(this.btn_showCustomerUI);
            this.pn_groupButton.Controls.Add(this.btn_showPaymentUI);
            this.pn_groupButton.Controls.Add(this.btn_showProductUI);
            this.pn_groupButton.Location = new System.Drawing.Point(10, 15);
            this.pn_groupButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_groupButton.Name = "pn_groupButton";
            this.pn_groupButton.ShadowDecoration.Parent = this.pn_groupButton;
            this.pn_groupButton.Size = new System.Drawing.Size(728, 41);
            this.pn_groupButton.TabIndex = 5;
            // 
            // btn_showAccountUI
            // 
            this.btn_showAccountUI.BorderRadius = 5;
            this.btn_showAccountUI.CheckedState.Parent = this.btn_showAccountUI;
            this.btn_showAccountUI.CustomImages.Parent = this.btn_showAccountUI;
            this.btn_showAccountUI.FillColor = System.Drawing.Color.Transparent;
            this.btn_showAccountUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAccountUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_showAccountUI.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_showAccountUI.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_showAccountUI.HoverState.Parent = this.btn_showAccountUI;
            this.btn_showAccountUI.Location = new System.Drawing.Point(607, 5);
            this.btn_showAccountUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_showAccountUI.Name = "btn_showAccountUI";
            this.btn_showAccountUI.ShadowDecoration.Parent = this.btn_showAccountUI;
            this.btn_showAccountUI.Size = new System.Drawing.Size(110, 31);
            this.btn_showAccountUI.TabIndex = 0;
            this.btn_showAccountUI.Text = "Tài khoản";
            this.btn_showAccountUI.Click += new System.EventHandler(this.btn_showAccountUI_Click);
            // 
            // btn_showSupplyUI
            // 
            this.btn_showSupplyUI.BorderRadius = 5;
            this.btn_showSupplyUI.CheckedState.Parent = this.btn_showSupplyUI;
            this.btn_showSupplyUI.CustomImages.Parent = this.btn_showSupplyUI;
            this.btn_showSupplyUI.FillColor = System.Drawing.Color.Transparent;
            this.btn_showSupplyUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showSupplyUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_showSupplyUI.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_showSupplyUI.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_showSupplyUI.HoverState.Parent = this.btn_showSupplyUI;
            this.btn_showSupplyUI.Location = new System.Drawing.Point(502, 5);
            this.btn_showSupplyUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_showSupplyUI.Name = "btn_showSupplyUI";
            this.btn_showSupplyUI.ShadowDecoration.Parent = this.btn_showSupplyUI;
            this.btn_showSupplyUI.Size = new System.Drawing.Size(107, 31);
            this.btn_showSupplyUI.TabIndex = 0;
            this.btn_showSupplyUI.Text = "Nhà cung cấp";
            this.btn_showSupplyUI.Click += new System.EventHandler(this.btn_showSupplyUI_Click);
            // 
            // btn_showStatistic
            // 
            this.btn_showStatistic.BorderRadius = 5;
            this.btn_showStatistic.CheckedState.Parent = this.btn_showStatistic;
            this.btn_showStatistic.CustomImages.Parent = this.btn_showStatistic;
            this.btn_showStatistic.FillColor = System.Drawing.Color.Transparent;
            this.btn_showStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showStatistic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_showStatistic.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_showStatistic.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_showStatistic.HoverState.Parent = this.btn_showStatistic;
            this.btn_showStatistic.Location = new System.Drawing.Point(400, 5);
            this.btn_showStatistic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_showStatistic.Name = "btn_showStatistic";
            this.btn_showStatistic.ShadowDecoration.Parent = this.btn_showStatistic;
            this.btn_showStatistic.Size = new System.Drawing.Size(104, 31);
            this.btn_showStatistic.TabIndex = 0;
            this.btn_showStatistic.Text = "Thống kê";
            this.btn_showStatistic.Click += new System.EventHandler(this.btn_showStatistic_Click);
            // 
            // btn_showEmployeeUI
            // 
            this.btn_showEmployeeUI.BorderRadius = 5;
            this.btn_showEmployeeUI.CheckedState.Parent = this.btn_showEmployeeUI;
            this.btn_showEmployeeUI.CustomImages.Parent = this.btn_showEmployeeUI;
            this.btn_showEmployeeUI.FillColor = System.Drawing.Color.Transparent;
            this.btn_showEmployeeUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showEmployeeUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_showEmployeeUI.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_showEmployeeUI.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_showEmployeeUI.HoverState.Parent = this.btn_showEmployeeUI;
            this.btn_showEmployeeUI.Location = new System.Drawing.Point(302, 5);
            this.btn_showEmployeeUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_showEmployeeUI.Name = "btn_showEmployeeUI";
            this.btn_showEmployeeUI.ShadowDecoration.Parent = this.btn_showEmployeeUI;
            this.btn_showEmployeeUI.Size = new System.Drawing.Size(99, 31);
            this.btn_showEmployeeUI.TabIndex = 0;
            this.btn_showEmployeeUI.Text = "Nhân viên";
            this.btn_showEmployeeUI.Click += new System.EventHandler(this.btn_showEmployeeUI_Click);
            // 
            // btn_showCustomerUI
            // 
            this.btn_showCustomerUI.BorderRadius = 5;
            this.btn_showCustomerUI.CheckedState.Parent = this.btn_showCustomerUI;
            this.btn_showCustomerUI.CustomImages.Parent = this.btn_showCustomerUI;
            this.btn_showCustomerUI.FillColor = System.Drawing.Color.Transparent;
            this.btn_showCustomerUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showCustomerUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_showCustomerUI.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_showCustomerUI.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_showCustomerUI.HoverState.Parent = this.btn_showCustomerUI;
            this.btn_showCustomerUI.Location = new System.Drawing.Point(201, 5);
            this.btn_showCustomerUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_showCustomerUI.Name = "btn_showCustomerUI";
            this.btn_showCustomerUI.ShadowDecoration.Parent = this.btn_showCustomerUI;
            this.btn_showCustomerUI.Size = new System.Drawing.Size(97, 31);
            this.btn_showCustomerUI.TabIndex = 0;
            this.btn_showCustomerUI.Text = "Khách hàng";
            this.btn_showCustomerUI.Click += new System.EventHandler(this.btn_showCustomerUI_Click);
            // 
            // btn_showPaymentUI
            // 
            this.btn_showPaymentUI.BackColor = System.Drawing.Color.Transparent;
            this.btn_showPaymentUI.BorderRadius = 5;
            this.btn_showPaymentUI.CheckedState.Parent = this.btn_showPaymentUI;
            this.btn_showPaymentUI.CustomImages.Parent = this.btn_showPaymentUI;
            this.btn_showPaymentUI.FillColor = System.Drawing.Color.Transparent;
            this.btn_showPaymentUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showPaymentUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_showPaymentUI.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_showPaymentUI.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_showPaymentUI.HoverState.Parent = this.btn_showPaymentUI;
            this.btn_showPaymentUI.Location = new System.Drawing.Point(4, 5);
            this.btn_showPaymentUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_showPaymentUI.Name = "btn_showPaymentUI";
            this.btn_showPaymentUI.ShadowDecoration.Parent = this.btn_showPaymentUI;
            this.btn_showPaymentUI.Size = new System.Drawing.Size(105, 31);
            this.btn_showPaymentUI.TabIndex = 0;
            this.btn_showPaymentUI.Text = "Thanh toán";
            this.btn_showPaymentUI.Click += new System.EventHandler(this.btn_showPaymentUI_Click);
            // 
            // btn_showProductUI
            // 
            this.btn_showProductUI.BorderRadius = 5;
            this.btn_showProductUI.CheckedState.Parent = this.btn_showProductUI;
            this.btn_showProductUI.CustomImages.Parent = this.btn_showProductUI;
            this.btn_showProductUI.FillColor = System.Drawing.Color.Transparent;
            this.btn_showProductUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showProductUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_showProductUI.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_showProductUI.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_showProductUI.HoverState.Parent = this.btn_showProductUI;
            this.btn_showProductUI.Location = new System.Drawing.Point(110, 5);
            this.btn_showProductUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_showProductUI.Name = "btn_showProductUI";
            this.btn_showProductUI.ShadowDecoration.Parent = this.btn_showProductUI;
            this.btn_showProductUI.Size = new System.Drawing.Size(87, 31);
            this.btn_showProductUI.TabIndex = 0;
            this.btn_showProductUI.Text = "Mặt hàng";
            this.btn_showProductUI.Click += new System.EventHandler(this.btn_showProductUI_Click);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(850, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox1.TabIndex = 18;
            // 
            // lb_header
            // 
            this.lb_header.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_header.AutoSize = false;
            this.lb_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_header.Font = new System.Drawing.Font("Times", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.lb_header.Location = new System.Drawing.Point(0, 0);
            this.lb_header.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(884, 44);
            this.lb_header.TabIndex = 17;
            this.lb_header.Text = "HỆ THỐNG QUẢN LÝ CỬA HÀNG MỸ PHẨM";
            this.lb_header.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_notify
            // 
            this.lb_notify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_notify.AutoSize = false;
            this.lb_notify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.lb_notify.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_notify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.lb_notify.Location = new System.Drawing.Point(152, 7);
            this.lb_notify.Name = "lb_notify";
            this.lb_notify.Size = new System.Drawing.Size(1191, 531);
            this.lb_notify.TabIndex = 0;
            this.lb_notify.Text = "WELCOME";
            this.lb_notify.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_notify
            // 
            this.pn_notify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_notify.AutoSize = false;
            this.pn_notify.BackColor = System.Drawing.Color.Transparent;
            this.pn_notify.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_notify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.pn_notify.Location = new System.Drawing.Point(0, 245);
            this.pn_notify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_notify.Name = "pn_notify";
            this.pn_notify.Size = new System.Drawing.Size(883, 54);
            this.pn_notify.TabIndex = 20;
            this.pn_notify.Text = "WELCOME";
            this.pn_notify.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // us_paymentUI
            // 
            this.us_paymentUI.BackColor = System.Drawing.Color.Transparent;
            this.us_paymentUI.Location = new System.Drawing.Point(0, 113);
            this.us_paymentUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.us_paymentUI.Name = "us_paymentUI";
            this.us_paymentUI.Size = new System.Drawing.Size(883, 431);
            this.us_paymentUI.TabIndex = 24;
            this.us_paymentUI.Load += new System.EventHandler(this.us_paymentUI_Load);
            // 
            // us_supplyUI
            // 
            this.us_supplyUI.BackColor = System.Drawing.Color.Transparent;
            this.us_supplyUI.Location = new System.Drawing.Point(1, 111);
            this.us_supplyUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.us_supplyUI.Name = "us_supplyUI";
            this.us_supplyUI.Size = new System.Drawing.Size(883, 431);
            this.us_supplyUI.TabIndex = 23;
            // 
            // us_productUI
            // 
            this.us_productUI.BackColor = System.Drawing.Color.Transparent;
            this.us_productUI.Location = new System.Drawing.Point(0, 114);
            this.us_productUI.Margin = new System.Windows.Forms.Padding(2);
            this.us_productUI.Name = "us_productUI";
            this.us_productUI.Size = new System.Drawing.Size(883, 431);
            this.us_productUI.TabIndex = 1;
            // 
            // us_customerUI
            // 
            this.us_customerUI.BackColor = System.Drawing.Color.Transparent;
            this.us_customerUI.Location = new System.Drawing.Point(2, 114);
            this.us_customerUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.us_customerUI.Name = "us_customerUI";
            this.us_customerUI.Size = new System.Drawing.Size(878, 427);
            this.us_customerUI.TabIndex = 22;
            // 
            // us_accountUI
            // 
            this.us_accountUI.BackColor = System.Drawing.Color.Transparent;
            this.us_accountUI.Location = new System.Drawing.Point(2, 114);
            this.us_accountUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.us_accountUI.Name = "us_accountUI";
            this.us_accountUI.Size = new System.Drawing.Size(878, 427);
            this.us_accountUI.TabIndex = 1;
            // 
            // us_employeeUI
            // 
            this.us_employeeUI.BackColor = System.Drawing.Color.Transparent;
            this.us_employeeUI.Location = new System.Drawing.Point(0, 113);
            this.us_employeeUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.us_employeeUI.Name = "us_employeeUI";
            this.us_employeeUI.Size = new System.Drawing.Size(883, 431);
            this.us_employeeUI.TabIndex = 21;
            // 
            // us_staticUI
            // 
            this.us_staticUI.Location = new System.Drawing.Point(1, 113);
            this.us_staticUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.us_staticUI.Name = "us_staticUI";
            this.us_staticUI.Size = new System.Drawing.Size(883, 431);
            this.us_staticUI.TabIndex = 25;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(883, 543);
            this.Controls.Add(this.pn_navigation);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lb_header);
            this.Controls.Add(this.us_paymentUI);
            this.Controls.Add(this.us_supplyUI);
            this.Controls.Add(this.us_productUI);
            this.Controls.Add(this.us_customerUI);
            this.Controls.Add(this.us_accountUI);
            this.Controls.Add(this.us_employeeUI);
            this.Controls.Add(this.pn_notify);
            this.Controls.Add(this.us_staticUI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý cửa hàng";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.pn_navigation.ResumeLayout(false);
            this.pn_groupButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pn_navigation;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2Panel pn_groupButton;
        private Guna.UI2.WinForms.Guna2Button btn_showSupplyUI;
        private Guna.UI2.WinForms.Guna2Button btn_showStatistic;
        private Guna.UI2.WinForms.Guna2Button btn_showEmployeeUI;
        private Guna.UI2.WinForms.Guna2Button btn_showCustomerUI;
        private Guna.UI2.WinForms.Guna2Button btn_showPaymentUI;
        private Guna.UI2.WinForms.Guna2Button btn_showProductUI;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_header;
        private us_productUI us_productUI;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_notify;
        private Guna.UI2.WinForms.Guna2HtmlLabel pn_notify;
        private Guna.UI2.WinForms.Guna2Button btn_showAccountUI;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRoleName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRoleID;
        private us_employeeUI us_employeeUI;
        private us_customerUI us_customerUI;
        private us_accountUI us_accountUI;
        private us_supplyUI us_supplyUI;
        private us_paymentUI us_paymentUI;
        private us_staticUI us_staticUI;
    }
}