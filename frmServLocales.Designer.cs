namespace ModuloAdicional
{
	// Token: 0x02000027 RID: 39
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmServLocales : global::System.Windows.Forms.Form
	{
		// Token: 0x060011E1 RID: 4577 RVA: 0x00114E4C File Offset: 0x0011304C
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

		// Token: 0x060011E2 RID: 4578 RVA: 0x00114E9C File Offset: 0x0011309C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.dgvServidores = new global::System.Windows.Forms.DataGridView();
			this.Label1 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.dgvServidores).BeginInit();
			base.SuspendLayout();
			this.dgvServidores.AllowUserToAddRows = false;
			this.dgvServidores.AllowUserToDeleteRows = false;
			this.dgvServidores.AllowUserToOrderColumns = true;
			this.dgvServidores.AllowUserToResizeColumns = false;
			this.dgvServidores.AllowUserToResizeRows = false;
			this.dgvServidores.BackgroundColor = global::System.Drawing.SystemColors.Control;
			this.dgvServidores.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dgvServidores.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvServidores.GridColor = global::System.Drawing.SystemColors.AppWorkspace;
			this.dgvServidores.Location = new global::System.Drawing.Point(46, 63);
			this.dgvServidores.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvServidores.Name = "dgvServidores";
			this.dgvServidores.ReadOnly = true;
			this.dgvServidores.RowHeadersVisible = false;
			this.dgvServidores.RowTemplate.Height = 24;
			this.dgvServidores.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvServidores.Size = new global::System.Drawing.Size(388, 371);
			this.dgvServidores.TabIndex = 12;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(40, 12);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(237, 25);
			this.Label1.TabIndex = 11;
			this.Label1.Text = "Selecciona un servidor:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 25f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(488, 460);
			base.Controls.Add(this.dgvServidores);
			base.Controls.Add(this.Label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(6, 6, 6, 6);
			base.Name = "frmServLocales";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmServLocales";
			((global::System.ComponentModel.ISupportInitialize)this.dgvServidores).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040007EC RID: 2028
		private global::System.ComponentModel.IContainer components;
	}
}
