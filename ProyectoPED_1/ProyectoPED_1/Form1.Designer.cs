namespace ProyectoPED_1
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnCliente = new MetroFramework.Controls.MetroButton();
			this.label5 = new System.Windows.Forms.Label();
			this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.txtNombre = new MetroFramework.Controls.MetroTextBox();
			this.txtCarnet = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
			this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtclave = new MetroFramework.Controls.MetroTextBox();
			this.btnGestor = new MetroFramework.Controls.MetroButton();
			this.metroLink2 = new MetroFramework.Controls.MetroLink();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroTabControl1.SuspendLayout();
			this.metroTabPage1.SuspendLayout();
			this.metroTabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(661, 28);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(58, 37);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnCliente
			// 
			this.btnCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnCliente.FontSize = MetroFramework.MetroButtonSize.Tall;
			this.btnCliente.ForeColor = System.Drawing.Color.White;
			this.btnCliente.Location = new System.Drawing.Point(95, 288);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(150, 39);
			this.btnCliente.Style = MetroFramework.MetroColorStyle.Blue;
			this.btnCliente.TabIndex = 9;
			this.btnCliente.Text = "INGRESAR";
			this.btnCliente.UseCustomBackColor = true;
			this.btnCliente.UseCustomForeColor = true;
			this.btnCliente.UseSelectable = true;
			this.btnCliente.UseWaitCursor = true;
			this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(2, 341);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "La clave es: 1234";
			// 
			// metroTabControl1
			// 
			this.metroTabControl1.Controls.Add(this.metroTabPage1);
			this.metroTabControl1.Controls.Add(this.metroTabPage2);
			this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
			this.metroTabControl1.Location = new System.Drawing.Point(49, 81);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.SelectedIndex = 0;
			this.metroTabControl1.Size = new System.Drawing.Size(645, 396);
			this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroTabControl1.TabIndex = 10;
			this.metroTabControl1.UseSelectable = true;
			this.metroTabControl1.UseStyleColors = true;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.Controls.Add(this.pictureBox3);
			this.metroTabPage1.Controls.Add(this.metroLabel4);
			this.metroTabPage1.Controls.Add(this.metroLabel3);
			this.metroTabPage1.Controls.Add(this.btnCliente);
			this.metroTabPage1.Controls.Add(this.metroLabel2);
			this.metroTabPage1.Controls.Add(this.txtNombre);
			this.metroTabPage1.Controls.Add(this.txtCarnet);
			this.metroTabPage1.Controls.Add(this.metroLabel1);
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.HorizontalScrollbarSize = 10;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(637, 354);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "Registro de usuario";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.VerticalScrollbarSize = 10;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
			this.metroLabel4.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.metroLabel4.Enabled = false;
			this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.metroLabel4.Location = new System.Drawing.Point(21, 20);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(123, 25);
			this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
			this.metroLabel4.TabIndex = 15;
			this.metroLabel4.Text = "BIENVENIDO";
			this.metroLabel4.UseCustomBackColor = true;
			this.metroLabel4.UseCustomForeColor = true;
			this.metroLabel4.UseMnemonic = false;
			this.metroLabel4.UseStyleColors = true;
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel3.Location = new System.Drawing.Point(95, 188);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(69, 19);
			this.metroLabel3.TabIndex = 14;
			this.metroLabel3.Text = "NOMBRE";
			this.metroLabel3.UseStyleColors = true;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel2.ForeColor = System.Drawing.Color.Coral;
			this.metroLabel2.Location = new System.Drawing.Point(95, 102);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(63, 19);
			this.metroLabel2.TabIndex = 13;
			this.metroLabel2.Text = "CARNET";
			this.metroLabel2.UseStyleColors = true;
			// 
			// txtNombre
			// 
			// 
			// 
			// 
			this.txtNombre.CustomButton.Image = null;
			this.txtNombre.CustomButton.Location = new System.Drawing.Point(116, 1);
			this.txtNombre.CustomButton.Name = "";
			this.txtNombre.CustomButton.Size = new System.Drawing.Size(33, 33);
			this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtNombre.CustomButton.TabIndex = 1;
			this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtNombre.CustomButton.UseSelectable = true;
			this.txtNombre.CustomButton.Visible = false;
			this.txtNombre.Lines = new string[0];
			this.txtNombre.Location = new System.Drawing.Point(95, 210);
			this.txtNombre.MaxLength = 32767;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.PasswordChar = '\0';
			this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNombre.SelectedText = "";
			this.txtNombre.SelectionLength = 0;
			this.txtNombre.SelectionStart = 0;
			this.txtNombre.ShortcutsEnabled = true;
			this.txtNombre.Size = new System.Drawing.Size(150, 35);
			this.txtNombre.TabIndex = 12;
			this.txtNombre.UseCustomBackColor = true;
			this.txtNombre.UseSelectable = true;
			this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtCarnet
			// 
			// 
			// 
			// 
			this.txtCarnet.CustomButton.Image = null;
			this.txtCarnet.CustomButton.Location = new System.Drawing.Point(116, 1);
			this.txtCarnet.CustomButton.Name = "";
			this.txtCarnet.CustomButton.Size = new System.Drawing.Size(33, 33);
			this.txtCarnet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtCarnet.CustomButton.TabIndex = 1;
			this.txtCarnet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtCarnet.CustomButton.UseSelectable = true;
			this.txtCarnet.CustomButton.Visible = false;
			this.txtCarnet.ForeColor = System.Drawing.Color.CadetBlue;
			this.txtCarnet.Lines = new string[0];
			this.txtCarnet.Location = new System.Drawing.Point(95, 124);
			this.txtCarnet.MaxLength = 32767;
			this.txtCarnet.Name = "txtCarnet";
			this.txtCarnet.PasswordChar = '\0';
			this.txtCarnet.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtCarnet.SelectedText = "";
			this.txtCarnet.SelectionLength = 0;
			this.txtCarnet.SelectionStart = 0;
			this.txtCarnet.ShortcutsEnabled = true;
			this.txtCarnet.Size = new System.Drawing.Size(150, 35);
			this.txtCarnet.Style = MetroFramework.MetroColorStyle.Black;
			this.txtCarnet.TabIndex = 11;
			this.txtCarnet.UseCustomBackColor = true;
			this.txtCarnet.UseSelectable = true;
			this.txtCarnet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtCarnet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.metroLabel1.Location = new System.Drawing.Point(95, 56);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(137, 25);
			this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroLabel1.TabIndex = 10;
			this.metroLabel1.Text = "INICIA SESION";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroLabel1.UseStyleColors = true;
			// 
			// metroTabPage2
			// 
			this.metroTabPage2.Controls.Add(this.metroLabel5);
			this.metroTabPage2.Controls.Add(this.pictureBox4);
			this.metroTabPage2.Controls.Add(this.metroLink2);
			this.metroTabPage2.Controls.Add(this.btnGestor);
			this.metroTabPage2.Controls.Add(this.txtclave);
			this.metroTabPage2.Controls.Add(this.label5);
			this.metroTabPage2.HorizontalScrollbarBarColor = true;
			this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.HorizontalScrollbarSize = 10;
			this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage2.Name = "metroTabPage2";
			this.metroTabPage2.Size = new System.Drawing.Size(637, 354);
			this.metroTabPage2.TabIndex = 1;
			this.metroTabPage2.Text = "Registro Administrador";
			this.metroTabPage2.VerticalScrollbarBarColor = true;
			this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.VerticalScrollbarSize = 10;
			// 
			// metroStyleManager1
			// 
			this.metroStyleManager1.Owner = null;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(333, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(91, 74);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// txtclave
			// 
			// 
			// 
			// 
			this.txtclave.CustomButton.Image = null;
			this.txtclave.CustomButton.Location = new System.Drawing.Point(118, 2);
			this.txtclave.CustomButton.Name = "";
			this.txtclave.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.txtclave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtclave.CustomButton.TabIndex = 1;
			this.txtclave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtclave.CustomButton.UseSelectable = true;
			this.txtclave.CustomButton.Visible = false;
			this.txtclave.Lines = new string[0];
			this.txtclave.Location = new System.Drawing.Point(421, 158);
			this.txtclave.MaxLength = 32767;
			this.txtclave.Name = "txtclave";
			this.txtclave.PasswordChar = '\0';
			this.txtclave.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtclave.SelectedText = "";
			this.txtclave.SelectionLength = 0;
			this.txtclave.SelectionStart = 0;
			this.txtclave.ShortcutsEnabled = true;
			this.txtclave.Size = new System.Drawing.Size(148, 32);
			this.txtclave.TabIndex = 9;
			this.txtclave.UseCustomBackColor = true;
			this.txtclave.UseSelectable = true;
			this.txtclave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtclave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// btnGestor
			// 
			this.btnGestor.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnGestor.FontSize = MetroFramework.MetroButtonSize.Tall;
			this.btnGestor.ForeColor = System.Drawing.SystemColors.Window;
			this.btnGestor.Location = new System.Drawing.Point(421, 235);
			this.btnGestor.Name = "btnGestor";
			this.btnGestor.Size = new System.Drawing.Size(148, 39);
			this.btnGestor.TabIndex = 10;
			this.btnGestor.Text = "INGRESAR";
			this.btnGestor.UseCustomBackColor = true;
			this.btnGestor.UseCustomForeColor = true;
			this.btnGestor.UseSelectable = true;
			this.btnGestor.Click += new System.EventHandler(this.btnGestor_Click);
			// 
			// metroLink2
			// 
			this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Tall;
			this.metroLink2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.metroLink2.Location = new System.Drawing.Point(5, 22);
			this.metroLink2.Name = "metroLink2";
			this.metroLink2.Size = new System.Drawing.Size(299, 45);
			this.metroLink2.TabIndex = 12;
			this.metroLink2.Text = "INICIA COMO ADMINISTRADOR";
			this.metroLink2.UseCustomForeColor = true;
			this.metroLink2.UseSelectable = true;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(390, 76);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(223, 234);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 11;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(33, 91);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(271, 201);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 13;
			this.pictureBox4.TabStop = false;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.metroLabel5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.metroLabel5.Location = new System.Drawing.Point(421, 136);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(147, 19);
			this.metroLabel5.TabIndex = 14;
			this.metroLabel5.Text = "Clave Administrador";
			this.metroLabel5.UseStyleColors = true;
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(757, 525);
			this.Controls.Add(this.metroTabControl1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnSalir);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmMenu";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Menu de Biblioteca";
			this.Theme = MetroFramework.MetroThemeStyle.Default;
			this.Load += new System.EventHandler(this.FrmMenu_Load);
			this.metroTabControl1.ResumeLayout(false);
			this.metroTabPage1.ResumeLayout(false);
			this.metroTabPage1.PerformLayout();
			this.metroTabPage2.ResumeLayout(false);
			this.metroTabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
		private MetroFramework.Controls.MetroButton btnCliente;
		private System.Windows.Forms.Label label5;
		private MetroFramework.Controls.MetroTabControl metroTabControl1;
		private MetroFramework.Controls.MetroTabPage metroTabPage1;
		private MetroFramework.Controls.MetroTabPage metroTabPage2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox txtNombre;
		private MetroFramework.Controls.MetroTextBox txtCarnet;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Components.MetroStyleManager metroStyleManager1;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private MetroFramework.Controls.MetroButton btnGestor;
		private MetroFramework.Controls.MetroTextBox txtclave;
		private MetroFramework.Controls.MetroLink metroLink2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
	}
}

