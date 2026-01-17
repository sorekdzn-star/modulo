namespace ModuloAdicional
{
	// Token: 0x0200001E RID: 30
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmProductos : global::System.Windows.Forms.Form
	{
		// Token: 0x06000D05 RID: 3333 RVA: 0x000D0CE0 File Offset: 0x000CEEE0
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

		// Token: 0x06000D06 RID: 3334 RVA: 0x000D0D30 File Offset: 0x000CEF30
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ModuloAdicional.frmProductos));
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.txtBuscarProducto = new global::System.Windows.Forms.TextBox();
			this.PictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.dgvProductos = new global::System.Windows.Forms.DataGridView();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvProductos).BeginInit();
			base.SuspendLayout();
			this.Panel1.BackColor = global::System.Drawing.SystemColors.Info;
			this.Panel1.Controls.Add(this.txtBuscarProducto);
			this.Panel1.Controls.Add(this.PictureBox2);
			this.Panel1.Controls.Add(this.PictureBox1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(1014, 70);
			this.Panel1.TabIndex = 0;
			this.txtBuscarProducto.BackColor = global::System.Drawing.SystemColors.InactiveCaption;
			this.txtBuscarProducto.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtBuscarProducto.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtBuscarProducto.Location = new global::System.Drawing.Point(9, 24);
			this.txtBuscarProducto.Name = "txtBuscarProducto";
			this.txtBuscarProducto.Size = new global::System.Drawing.Size(502, 35);
			this.txtBuscarProducto.TabIndex = 130;
			this.PictureBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.PictureBox2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.PictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox2.Image");
			this.PictureBox2.Location = new global::System.Drawing.Point(954, 12);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new global::System.Drawing.Size(48, 44);
			this.PictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox2.TabIndex = 129;
			this.PictureBox2.TabStop = false;
			this.PictureBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.PictureBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new global::System.Drawing.Point(957, 12);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(45, 45);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 126;
			this.PictureBox1.TabStop = false;
			this.Panel2.Controls.Add(this.dgvProductos);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel2.Location = new global::System.Drawing.Point(0, 70);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(1014, 663);
			this.Panel2.TabIndex = 1;
			this.dgvProductos.AllowUserToAddRows = false;
			this.dgvProductos.AllowUserToDeleteRows = false;
			this.dgvProductos.AllowUserToResizeColumns = false;
			this.dgvProductos.AllowUserToResizeRows = false;
			this.dgvProductos.BackgroundColor = global::System.Drawing.SystemColors.InactiveCaption;
			this.dgvProductos.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dgvProductos.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.dgvProductos.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvProductos.GridColor = global::System.Drawing.SystemColors.AppWorkspace;
			this.dgvProductos.Location = new global::System.Drawing.Point(0, 0);
			this.dgvProductos.Margin = new global::System.Windows.Forms.Padding(4);
			this.dgvProductos.MultiSelect = false;
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.ReadOnly = true;
			this.dgvProductos.RowHeadersVisible = false;
			this.dgvProductos.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvProductos.RowTemplate.Height = 24;
			this.dgvProductos.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProductos.Size = new global::System.Drawing.Size(1014, 663);
			this.dgvProductos.TabIndex = 25;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 25f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1014, 733);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmProductos";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmProductos";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvProductos).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040005E6 RID: 1510
		private global::System.ComponentModel.IContainer components;
	}
}
