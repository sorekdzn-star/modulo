namespace ModuloAdicional
{
	// Token: 0x0200001A RID: 26
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmLicencias : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A90 RID: 2704 RVA: 0x000B60AC File Offset: 0x000B42AC
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x000B60FC File Offset: 0x000B42FC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ModuloAdicional.frmLicencias));
			this.cmbAnio = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dgvLicencias = new global::System.Windows.Forms.DataGridView();
			this.btnAgregar = new global::System.Windows.Forms.Button();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.Panel3 = new global::System.Windows.Forms.Panel();
			this.Label2 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.dgvLicencias).BeginInit();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.Panel3.SuspendLayout();
			base.SuspendLayout();
			this.cmbAnio.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cmbAnio.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAnio.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cmbAnio.FormattingEnabled = true;
			this.cmbAnio.Location = new global::System.Drawing.Point(93, 18);
			this.cmbAnio.Margin = new global::System.Windows.Forms.Padding(6);
			this.cmbAnio.Name = "cmbAnio";
			this.cmbAnio.Size = new global::System.Drawing.Size(268, 37);
			this.cmbAnio.TabIndex = 0;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(12, 22);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(72, 29);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Año: ";
			this.dgvLicencias.AllowUserToAddRows = false;
			this.dgvLicencias.AllowUserToDeleteRows = false;
			this.dgvLicencias.AllowUserToResizeColumns = false;
			this.dgvLicencias.AllowUserToResizeRows = false;
			this.dgvLicencias.BackgroundColor = global::System.Drawing.SystemColors.ControlLight;
			this.dgvLicencias.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dgvLicencias.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLicencias.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvLicencias.Enabled = false;
			this.dgvLicencias.GridColor = global::System.Drawing.SystemColors.AppWorkspace;
			this.dgvLicencias.Location = new global::System.Drawing.Point(0, 70);
			this.dgvLicencias.Margin = new global::System.Windows.Forms.Padding(4);
			this.dgvLicencias.MultiSelect = false;
			this.dgvLicencias.Name = "dgvLicencias";
			this.dgvLicencias.ReadOnly = true;
			this.dgvLicencias.RowHeadersVisible = false;
			this.dgvLicencias.RowTemplate.Height = 24;
			this.dgvLicencias.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvLicencias.Size = new global::System.Drawing.Size(1436, 631);
			this.dgvLicencias.TabIndex = 25;
			this.dgvLicencias.TabStop = false;
			this.btnAgregar.BackColor = global::System.Drawing.Color.Green;
			this.btnAgregar.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.FlatAppearance.BorderSize = 0;
			this.btnAgregar.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAgregar.ForeColor = global::System.Drawing.Color.White;
			this.btnAgregar.Location = new global::System.Drawing.Point(376, 11);
			this.btnAgregar.Margin = new global::System.Windows.Forms.Padding(6);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new global::System.Drawing.Size(304, 50);
			this.btnAgregar.TabIndex = 26;
			this.btnAgregar.Text = "Agregar Licencias";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.Panel1.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.PictureBox1);
			this.Panel1.Controls.Add(this.btnAgregar);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.cmbAnio);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(1436, 70);
			this.Panel1.TabIndex = 27;
			this.Button1.Location = new global::System.Drawing.Point(718, 11);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(356, 50);
			this.Button1.TabIndex = 127;
			this.Button1.Text = "Descargar Licencias";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.Visible = false;
			this.PictureBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.PictureBox1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new global::System.Drawing.Point(1381, 0);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(55, 70);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 126;
			this.PictureBox1.TabStop = false;
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel2.Location = new global::System.Drawing.Point(0, 70);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(1436, 699);
			this.Panel2.TabIndex = 28;
			this.Panel3.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.Panel3.Controls.Add(this.Label2);
			this.Panel3.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel3.Location = new global::System.Drawing.Point(0, 701);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new global::System.Drawing.Size(1436, 68);
			this.Panel3.TabIndex = 29;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(11, 19);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(311, 31);
			this.Label2.TabIndex = 0;
			this.Label2.Text = "Licencias Registradas!";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 25f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1436, 769);
			base.Controls.Add(this.dgvLicencias);
			base.Controls.Add(this.Panel3);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(6);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmLicencias";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Licencias";
			((global::System.ComponentModel.ISupportInitialize)this.dgvLicencias).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040004E0 RID: 1248
		private global::System.ComponentModel.IContainer components;
	}
}
