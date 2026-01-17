namespace ModuloAdicional
{
	// Token: 0x02000014 RID: 20
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmEliminarProdFormasdePago : global::System.Windows.Forms.Form
	{
		// Token: 0x060005EC RID: 1516 RVA: 0x000541C4 File Offset: 0x000523C4
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

		// Token: 0x060005ED RID: 1517 RVA: 0x00054214 File Offset: 0x00052414
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ModuloAdicional.frmEliminarProdFormasdePago));
			this.Panel4 = new global::System.Windows.Forms.Panel();
			this.Label29 = new global::System.Windows.Forms.Label();
			this.btnEliminarProducto = new global::System.Windows.Forms.PictureBox();
			this.dgvNotas = new global::System.Windows.Forms.DataGridView();
			this.Panel4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.btnEliminarProducto).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvNotas).BeginInit();
			base.SuspendLayout();
			this.Panel4.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.Panel4.Controls.Add(this.Label29);
			this.Panel4.Controls.Add(this.btnEliminarProducto);
			this.Panel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel4.Location = new global::System.Drawing.Point(0, 0);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new global::System.Drawing.Size(1178, 60);
			this.Panel4.TabIndex = 96;
			this.Label29.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.Label29.AutoSize = true;
			this.Label29.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7.875f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label29.Location = new global::System.Drawing.Point(12, 18);
			this.Label29.Name = "Label29";
			this.Label29.Size = new global::System.Drawing.Size(294, 25);
			this.Label29.TabIndex = 42;
			this.Label29.Text = "Formas de Pago del Ticket";
			this.btnEliminarProducto.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.btnEliminarProducto.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnEliminarProducto.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.btnEliminarProducto.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnEliminarProducto.Image");
			this.btnEliminarProducto.Location = new global::System.Drawing.Point(1121, 0);
			this.btnEliminarProducto.Name = "btnEliminarProducto";
			this.btnEliminarProducto.Size = new global::System.Drawing.Size(57, 60);
			this.btnEliminarProducto.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnEliminarProducto.TabIndex = 5;
			this.btnEliminarProducto.TabStop = false;
			this.dgvNotas.AllowUserToAddRows = false;
			this.dgvNotas.AllowUserToDeleteRows = false;
			this.dgvNotas.AllowUserToResizeColumns = false;
			this.dgvNotas.AllowUserToResizeRows = false;
			this.dgvNotas.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvNotas.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dgvNotas.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNotas.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvNotas.GridColor = global::System.Drawing.SystemColors.AppWorkspace;
			this.dgvNotas.Location = new global::System.Drawing.Point(0, 60);
			this.dgvNotas.Margin = new global::System.Windows.Forms.Padding(4);
			this.dgvNotas.MultiSelect = false;
			this.dgvNotas.Name = "dgvNotas";
			this.dgvNotas.ReadOnly = true;
			this.dgvNotas.RowHeadersVisible = false;
			this.dgvNotas.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvNotas.RowTemplate.Height = 24;
			this.dgvNotas.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvNotas.Size = new global::System.Drawing.Size(1178, 371);
			this.dgvNotas.TabIndex = 152;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 25f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1178, 431);
			base.Controls.Add(this.dgvNotas);
			base.Controls.Add(this.Panel4);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmEliminarProdFormasdePago";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Formas de Pagos";
			this.Panel4.ResumeLayout(false);
			this.Panel4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.btnEliminarProducto).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvNotas).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040002B3 RID: 691
		private global::System.ComponentModel.IContainer components;
	}
}
