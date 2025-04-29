namespace ProyectoPED_1
{
    partial class FrmGestionLibros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVLibros = new MetroFramework.Controls.MetroGrid();
            this.btnAgregarLibro = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtAutor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chkDisponible = new MetroFramework.Controls.MetroCheckBox();
            this.txtTitulo = new MetroFramework.Controls.MetroTextBox();
            this.dtpFecha = new MetroFramework.Controls.MetroDateTime();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtID2 = new MetroFramework.Controls.MetroTextBox();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnRegresar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLibros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVLibros
            // 
            this.DGVLibros.AllowUserToResizeRows = false;
            this.DGVLibros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVLibros.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGVLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVLibros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVLibros.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGVLibros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVLibros.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVLibros.EnableHeadersVisualStyles = false;
            this.DGVLibros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGVLibros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGVLibros.Location = new System.Drawing.Point(397, 36);
            this.DGVLibros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVLibros.Name = "DGVLibros";
            this.DGVLibros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVLibros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVLibros.RowHeadersWidth = 51;
            this.DGVLibros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVLibros.Size = new System.Drawing.Size(928, 507);
            this.DGVLibros.TabIndex = 5;
            this.DGVLibros.UseCustomBackColor = true;
            this.DGVLibros.UseCustomForeColor = true;
            this.DGVLibros.UseStyleColors = true;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregarLibro.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAgregarLibro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarLibro.Location = new System.Drawing.Point(101, 251);
            this.btnAgregarLibro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(161, 47);
            this.btnAgregarLibro.TabIndex = 16;
            this.btnAgregarLibro.Text = "AGREGAR";
            this.btnAgregarLibro.UseCustomBackColor = true;
            this.btnAgregarLibro.UseCustomForeColor = true;
            this.btnAgregarLibro.UseMnemonic = false;
            this.btnAgregarLibro.UseSelectable = true;
            this.btnAgregarLibro.UseStyleColors = true;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.chkDisponible);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.btnAgregarLibro);
            this.groupBox1.HorizontalScrollbarBarColor = true;
            this.groupBox1.HorizontalScrollbarHighlightOnWheel = false;
            this.groupBox1.HorizontalScrollbarSize = 12;
            this.groupBox1.Location = new System.Drawing.Point(24, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 315);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.VerticalScrollbarBarColor = true;
            this.groupBox1.VerticalScrollbarHighlightOnWheel = false;
            this.groupBox1.VerticalScrollbarSize = 13;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(27, 204);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(131, 20);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "DISPONIBILIDAD";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(27, 63);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 25);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "AUTOR";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(27, 118);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(183, 20);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "FECHA DE PUBLICACION";
            this.metroLabel3.UseStyleColors = true;
            // 
            // txtAutor
            // 
            // 
            // 
            // 
            this.txtAutor.CustomButton.Image = null;
            this.txtAutor.CustomButton.Location = new System.Drawing.Point(209, 2);
            this.txtAutor.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAutor.CustomButton.Name = "";
            this.txtAutor.CustomButton.Size = new System.Drawing.Size(33, 31);
            this.txtAutor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAutor.CustomButton.TabIndex = 1;
            this.txtAutor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAutor.CustomButton.UseSelectable = true;
            this.txtAutor.CustomButton.Visible = false;
            this.txtAutor.Lines = new string[0];
            this.txtAutor.Location = new System.Drawing.Point(149, 63);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAutor.MaxLength = 32767;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.PasswordChar = '\0';
            this.txtAutor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAutor.SelectedText = "";
            this.txtAutor.SelectionLength = 0;
            this.txtAutor.SelectionStart = 0;
            this.txtAutor.ShortcutsEnabled = true;
            this.txtAutor.Size = new System.Drawing.Size(185, 30);
            this.txtAutor.TabIndex = 17;
            this.txtAutor.UseSelectable = true;
            this.txtAutor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAutor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(27, 11);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 25);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "TITULO";
            this.metroLabel1.UseStyleColors = true;
            // 
            // chkDisponible
            // 
            this.chkDisponible.AutoSize = true;
            this.chkDisponible.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkDisponible.Location = new System.Drawing.Point(232, 209);
            this.chkDisponible.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDisponible.Name = "chkDisponible";
            this.chkDisponible.Size = new System.Drawing.Size(58, 17);
            this.chkDisponible.TabIndex = 13;
            this.chkDisponible.Text = "LIBRE";
            this.chkDisponible.UseSelectable = true;
            this.chkDisponible.UseStyleColors = true;
            // 
            // txtTitulo
            // 
            // 
            // 
            // 
            this.txtTitulo.CustomButton.Image = null;
            this.txtTitulo.CustomButton.Location = new System.Drawing.Point(207, 2);
            this.txtTitulo.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.CustomButton.Name = "";
            this.txtTitulo.CustomButton.Size = new System.Drawing.Size(36, 33);
            this.txtTitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitulo.CustomButton.TabIndex = 1;
            this.txtTitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitulo.CustomButton.UseSelectable = true;
            this.txtTitulo.CustomButton.Visible = false;
            this.txtTitulo.Lines = new string[0];
            this.txtTitulo.Location = new System.Drawing.Point(149, 10);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.MaxLength = 32767;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.SelectionLength = 0;
            this.txtTitulo.SelectionStart = 0;
            this.txtTitulo.ShortcutsEnabled = true;
            this.txtTitulo.Size = new System.Drawing.Size(185, 32);
            this.txtTitulo.TabIndex = 16;
            this.txtTitulo.UseSelectable = true;
            this.txtTitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(27, 145);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(284, 30);
            this.dtpFecha.TabIndex = 12;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 436);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(352, 199);
            this.metroTabControl1.TabIndex = 16;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.metroLabel5);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(344, 157);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BUSCAR LIBRO";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(20, 37);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(77, 20);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "ID LIBRO ";
            this.metroLabel5.UseStyleColors = true;
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(201, 2);
            this.txtID.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(139, 30);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(177, 28);
            this.txtID.TabIndex = 1;
            this.txtID.UseCustomBackColor = true;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBuscar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(0, 111);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(344, 46);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseCustomBackColor = true;
            this.btnBuscar.UseCustomForeColor = true;
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.metroLabel6);
            this.tabPage2.Controls.Add(this.txtID2);
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(344, 157);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ELIMINAR LIBRO";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(33, 36);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(73, 20);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "ID LIBRO";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // txtID2
            // 
            // 
            // 
            // 
            this.txtID2.CustomButton.Image = null;
            this.txtID2.CustomButton.Location = new System.Drawing.Point(175, 2);
            this.txtID2.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtID2.CustomButton.Name = "";
            this.txtID2.CustomButton.Size = new System.Drawing.Size(28, 26);
            this.txtID2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID2.CustomButton.TabIndex = 1;
            this.txtID2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID2.CustomButton.UseSelectable = true;
            this.txtID2.CustomButton.Visible = false;
            this.txtID2.Lines = new string[0];
            this.txtID2.Location = new System.Drawing.Point(145, 33);
            this.txtID2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID2.MaxLength = 32767;
            this.txtID2.Name = "txtID2";
            this.txtID2.PasswordChar = '\0';
            this.txtID2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID2.SelectedText = "";
            this.txtID2.SelectionLength = 0;
            this.txtID2.SelectionStart = 0;
            this.txtID2.ShortcutsEnabled = true;
            this.txtID2.Size = new System.Drawing.Size(155, 26);
            this.txtID2.TabIndex = 2;
            this.txtID2.UseSelectable = true;
            this.txtID2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEliminar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(0, 111);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(344, 46);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseCustomBackColor = true;
            this.btnEliminar.UseCustomForeColor = true;
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.UseStyleColors = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegresar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegresar.Location = new System.Drawing.Point(397, 585);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(167, 46);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "SALIR";
            this.btnRegresar.UseCustomBackColor = true;
            this.btnRegresar.UseCustomForeColor = true;
            this.btnRegresar.UseSelectable = true;
            this.btnRegresar.UseStyleColors = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmGestionLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 644);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVLibros);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGestionLibros";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Gestion De Libros";
            this.Load += new System.EventHandler(this.FrmGestionLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLibros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
		private MetroFramework.Controls.MetroGrid DGVLibros;
		private MetroFramework.Controls.MetroButton btnAgregarLibro;
		private MetroFramework.Controls.MetroPanel groupBox1;
		private MetroFramework.Controls.MetroCheckBox chkDisponible;
		private MetroFramework.Controls.MetroDateTime dtpFecha;
		private MetroFramework.Controls.MetroTextBox txtAutor;
		private MetroFramework.Controls.MetroTextBox txtTitulo;
		private MetroFramework.Controls.MetroTabControl metroTabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private System.Windows.Forms.TabPage tabPage1;
		private MetroFramework.Controls.MetroTextBox txtID;
		private MetroFramework.Controls.MetroButton btnBuscar;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroButton btnEliminar;
		private MetroFramework.Controls.MetroTextBox txtID2;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroButton btnRegresar;
	}
}