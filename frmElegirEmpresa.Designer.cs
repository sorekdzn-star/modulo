namespace ModuloAdicional
{
	// Token: 0x02000012 RID: 18
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmElegirEmpresa : global::System.Windows.Forms.Form
	{
		// Token: 0x06000436 RID: 1078 RVA: 0x0002F268 File Offset: 0x0002D468
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

		// Token: 0x06000437 RID: 1079 RVA: 0x0002F2B8 File Offset: 0x0002D4B8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ModuloAdicional.frmElegirEmpresa));
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.lblfilaseleccionada = new global::System.Windows.Forms.Label();
			this.ListBox1 = new global::System.Windows.Forms.ListBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.btnEliminarEmpresa = new global::System.Windows.Forms.Button();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.lbltotal = new global::System.Windows.Forms.Label();
			this.lblnombrearchivo = new global::System.Windows.Forms.Label();
			this.lblempresa1 = new global::System.Windows.Forms.Label();
			this.lblcadenamodulo = new global::System.Windows.Forms.Label();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.btnNuevaEmpresa = new global::System.Windows.Forms.Button();
			this.Panel3 = new global::System.Windows.Forms.Panel();
			this.dgvnotas = new global::System.Windows.Forms.DataGridView();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvnotas).BeginInit();
			base.SuspendLayout();
			this.Panel1.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.Panel1.Controls.Add(this.PictureBox1);
			this.Panel1.Controls.Add(this.lblfilaseleccionada);
			this.Panel1.Controls.Add(this.ListBox1);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.btnEliminarEmpresa);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(457, 39);
			this.Panel1.TabIndex = 0;
			this.PictureBox1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new global::System.Drawing.Point(411, 0);
			this.PictureBox1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(46, 39);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 29;
			this.PictureBox1.TabStop = false;
			this.lblfilaseleccionada.AutoSize = true;
			this.lblfilaseleccionada.Location = new global::System.Drawing.Point(205, 11);
			this.lblfilaseleccionada.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblfilaseleccionada.Name = "lblfilaseleccionada";
			this.lblfilaseleccionada.Size = new global::System.Drawing.Size(39, 13);
			this.lblfilaseleccionada.TabIndex = 28;
			this.lblfilaseleccionada.Text = "Label2";
			this.lblfilaseleccionada.Visible = false;
			this.ListBox1.FormattingEnabled = true;
			this.ListBox1.Location = new global::System.Drawing.Point(248, 5);
			this.ListBox1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ListBox1.Name = "ListBox1";
			this.ListBox1.Size = new global::System.Drawing.Size(68, 30);
			this.ListBox1.TabIndex = 27;
			this.ListBox1.Visible = false;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(4, 7);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(166, 24);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Acceso principal";
			this.btnEliminarEmpresa.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnEliminarEmpresa.Location = new global::System.Drawing.Point(380, 2);
			this.btnEliminarEmpresa.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnEliminarEmpresa.Name = "btnEliminarEmpresa";
			this.btnEliminarEmpresa.Size = new global::System.Drawing.Size(20, 14);
			this.btnEliminarEmpresa.TabIndex = 2;
			this.btnEliminarEmpresa.Text = "Eliminar empresa";
			this.btnEliminarEmpresa.UseVisualStyleBackColor = true;
			this.btnEliminarEmpresa.Visible = false;
			this.Panel2.BackColor = global::System.Drawing.SystemColors.InactiveCaption;
			this.Panel2.Controls.Add(this.Button4);
			this.Panel2.Controls.Add(this.lbltotal);
			this.Panel2.Controls.Add(this.lblnombrearchivo);
			this.Panel2.Controls.Add(this.lblempresa1);
			this.Panel2.Controls.Add(this.lblcadenamodulo);
			this.Panel2.Controls.Add(this.Button2);
			this.Panel2.Controls.Add(this.btnNuevaEmpresa);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Panel2.Location = new global::System.Drawing.Point(315, 39);
			this.Panel2.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(142, 190);
			this.Panel2.TabIndex = 1;
			this.Button4.BackColor = global::System.Drawing.SystemColors.Info;
			this.Button4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Button4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Button4.Image");
			this.Button4.Location = new global::System.Drawing.Point(7, 140);
			this.Button4.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(129, 43);
			this.Button4.TabIndex = 6;
			this.Button4.UseVisualStyleBackColor = false;
			this.lbltotal.AutoSize = true;
			this.lbltotal.Location = new global::System.Drawing.Point(102, 169);
			this.lbltotal.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbltotal.Name = "lbltotal";
			this.lbltotal.Size = new global::System.Drawing.Size(39, 13);
			this.lbltotal.TabIndex = 5;
			this.lbltotal.Text = "Label2";
			this.lbltotal.Visible = false;
			this.lblnombrearchivo.AutoSize = true;
			this.lblnombrearchivo.Location = new global::System.Drawing.Point(102, 169);
			this.lblnombrearchivo.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblnombrearchivo.Name = "lblnombrearchivo";
			this.lblnombrearchivo.Size = new global::System.Drawing.Size(39, 13);
			this.lblnombrearchivo.TabIndex = 5;
			this.lblnombrearchivo.Text = "Label2";
			this.lblnombrearchivo.Visible = false;
			this.lblempresa1.AutoSize = true;
			this.lblempresa1.Location = new global::System.Drawing.Point(102, 169);
			this.lblempresa1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblempresa1.Name = "lblempresa1";
			this.lblempresa1.Size = new global::System.Drawing.Size(39, 13);
			this.lblempresa1.TabIndex = 4;
			this.lblempresa1.Text = "Label2";
			this.lblempresa1.Visible = false;
			this.lblcadenamodulo.AutoSize = true;
			this.lblcadenamodulo.Location = new global::System.Drawing.Point(102, 169);
			this.lblcadenamodulo.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblcadenamodulo.Name = "lblcadenamodulo";
			this.lblcadenamodulo.Size = new global::System.Drawing.Size(39, 13);
			this.lblcadenamodulo.TabIndex = 3;
			this.lblcadenamodulo.Text = "Label2";
			this.lblcadenamodulo.Visible = false;
			this.Button2.BackColor = global::System.Drawing.Color.OrangeRed;
			this.Button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button2.ForeColor = global::System.Drawing.Color.White;
			this.Button2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Button2.Image");
			this.Button2.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.Button2.Location = new global::System.Drawing.Point(7, 5);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(129, 43);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "I n g r e s a r";
			this.Button2.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Button2.UseVisualStyleBackColor = false;
			this.btnNuevaEmpresa.BackColor = global::System.Drawing.Color.PowderBlue;
			this.btnNuevaEmpresa.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnNuevaEmpresa.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnNuevaEmpresa.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnNuevaEmpresa.Image");
			this.btnNuevaEmpresa.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevaEmpresa.Location = new global::System.Drawing.Point(7, 92);
			this.btnNuevaEmpresa.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnNuevaEmpresa.Name = "btnNuevaEmpresa";
			this.btnNuevaEmpresa.Size = new global::System.Drawing.Size(129, 43);
			this.btnNuevaEmpresa.TabIndex = 0;
			this.btnNuevaEmpresa.Text = "Nueva empresa";
			this.btnNuevaEmpresa.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNuevaEmpresa.UseVisualStyleBackColor = false;
			this.Panel3.Controls.Add(this.dgvnotas);
			this.Panel3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel3.Location = new global::System.Drawing.Point(0, 39);
			this.Panel3.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new global::System.Drawing.Size(315, 190);
			this.Panel3.TabIndex = 2;
			this.dgvnotas.AllowUserToAddRows = false;
			this.dgvnotas.AllowUserToDeleteRows = false;
			this.dgvnotas.AllowUserToResizeColumns = false;
			this.dgvnotas.AllowUserToResizeRows = false;
			this.dgvnotas.BackgroundColor = global::System.Drawing.SystemColors.InactiveCaption;
			this.dgvnotas.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dgvnotas.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvnotas.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.dgvnotas.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvnotas.GridColor = global::System.Drawing.SystemColors.AppWorkspace;
			this.dgvnotas.Location = new global::System.Drawing.Point(0, 0);
			this.dgvnotas.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvnotas.MultiSelect = false;
			this.dgvnotas.Name = "dgvnotas";
			this.dgvnotas.ReadOnly = true;
			this.dgvnotas.RowHeadersVisible = false;
			this.dgvnotas.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvnotas.RowTemplate.Height = 24;
			this.dgvnotas.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvnotas.Size = new global::System.Drawing.Size(315, 190);
			this.dgvnotas.TabIndex = 26;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(457, 229);
			base.Controls.Add(this.Panel3);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			base.Name = "frmElegirEmpresa";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmElegirEmpresa";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvnotas).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040001E1 RID: 481
		private global::System.ComponentModel.IContainer components;
	}
}
