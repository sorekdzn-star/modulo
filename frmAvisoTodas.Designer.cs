namespace ModuloAdicional
{
	// Token: 0x02000004 RID: 4
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmAvisoTodas : global::System.Windows.Forms.Form
	{
		// Token: 0x06000018 RID: 24 RVA: 0x000036F8 File Offset: 0x000018F8
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

		// Token: 0x06000019 RID: 25 RVA: 0x00003748 File Offset: 0x00001948
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DataGridFoliosRenumerar = new global::System.Windows.Forms.DataGridView();
			this.btnAplicar = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridFoliosRenumerar).BeginInit();
			base.SuspendLayout();
			this.Panel1.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(746, 52);
			this.Panel1.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(12, 13);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(544, 31);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Renumerar los tickets a partir del folio....";
			this.Panel2.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.Panel2.Controls.Add(this.btnAplicar);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel2.Location = new global::System.Drawing.Point(0, 263);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(746, 78);
			this.Panel2.TabIndex = 2;
			this.DataGridFoliosRenumerar.AllowUserToAddRows = false;
			this.DataGridFoliosRenumerar.AllowUserToDeleteRows = false;
			this.DataGridFoliosRenumerar.AllowUserToResizeColumns = false;
			this.DataGridFoliosRenumerar.AllowUserToResizeRows = false;
			this.DataGridFoliosRenumerar.BackgroundColor = global::System.Drawing.Color.White;
			this.DataGridFoliosRenumerar.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10.125f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridFoliosRenumerar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.DataGridFoliosRenumerar.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridFoliosRenumerar.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.DataGridFoliosRenumerar.GridColor = global::System.Drawing.SystemColors.AppWorkspace;
			this.DataGridFoliosRenumerar.Location = new global::System.Drawing.Point(0, 52);
			this.DataGridFoliosRenumerar.Margin = new global::System.Windows.Forms.Padding(4);
			this.DataGridFoliosRenumerar.MultiSelect = false;
			this.DataGridFoliosRenumerar.Name = "DataGridFoliosRenumerar";
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10.875f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridFoliosRenumerar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DataGridFoliosRenumerar.RowHeadersVisible = false;
			this.DataGridFoliosRenumerar.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.DataGridFoliosRenumerar.RowTemplate.Height = 24;
			this.DataGridFoliosRenumerar.Size = new global::System.Drawing.Size(358, 211);
			this.DataGridFoliosRenumerar.TabIndex = 180;
			this.btnAplicar.BackColor = global::System.Drawing.Color.Green;
			this.btnAplicar.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAplicar.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.btnAplicar.FlatAppearance.BorderSize = 2;
			this.btnAplicar.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAplicar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13.125f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAplicar.ForeColor = global::System.Drawing.Color.White;
			this.btnAplicar.Location = new global::System.Drawing.Point(6, 6);
			this.btnAplicar.Margin = new global::System.Windows.Forms.Padding(6);
			this.btnAplicar.Name = "btnAplicar";
			this.btnAplicar.Size = new global::System.Drawing.Size(734, 66);
			this.btnAplicar.TabIndex = 141;
			this.btnAplicar.TabStop = false;
			this.btnAplicar.Text = "Continuar";
			this.btnAplicar.UseVisualStyleBackColor = false;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7.875f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = global::System.Drawing.Color.Red;
			this.Label2.Location = new global::System.Drawing.Point(367, 64);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(343, 25);
			this.Label2.TabIndex = 181;
			this.Label2.Text = "*Doble clic al folio para editarlo";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 25f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.InactiveCaption;
			base.ClientSize = new global::System.Drawing.Size(746, 341);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.DataGridFoliosRenumerar);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmAvisoTodas";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAvisoTodas";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DataGridFoliosRenumerar).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000009 RID: 9
		private global::System.ComponentModel.IContainer components;
	}
}
