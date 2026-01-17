namespace ModuloAdicional
{
	// Token: 0x0200000F RID: 15
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmDownLicencias : global::System.Windows.Forms.Form
	{
		// Token: 0x06000302 RID: 770 RVA: 0x0001EDA8 File Offset: 0x0001CFA8
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

		// Token: 0x06000303 RID: 771 RVA: 0x0001EDF8 File Offset: 0x0001CFF8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ModuloAdicional.frmDownLicencias));
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.dgvNotas = new global::System.Windows.Forms.DataGridView();
			this.Panel3 = new global::System.Windows.Forms.Panel();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.lblfechahoy = new global::System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvNotas).BeginInit();
			this.Panel3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			base.SuspendLayout();
			this.Panel1.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.Panel1.Controls.Add(this.lblfechahoy);
			this.Panel1.Controls.Add(this.PictureBox1);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(1216, 50);
			this.Panel1.TabIndex = 0;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7.875f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(12, 13);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(227, 25);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Descargar Licencias";
			this.Panel2.Controls.Add(this.dgvNotas);
			this.Panel2.Controls.Add(this.Panel3);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel2.Location = new global::System.Drawing.Point(0, 50);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(1216, 753);
			this.Panel2.TabIndex = 1;
			this.dgvNotas.AllowUserToAddRows = false;
			this.dgvNotas.AllowUserToDeleteRows = false;
			this.dgvNotas.AllowUserToResizeColumns = false;
			this.dgvNotas.AllowUserToResizeRows = false;
			this.dgvNotas.BackgroundColor = global::System.Drawing.SystemColors.Control;
			this.dgvNotas.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dgvNotas.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNotas.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvNotas.GridColor = global::System.Drawing.SystemColors.AppWorkspace;
			this.dgvNotas.Location = new global::System.Drawing.Point(0, 0);
			this.dgvNotas.Margin = new global::System.Windows.Forms.Padding(4);
			this.dgvNotas.MultiSelect = false;
			this.dgvNotas.Name = "dgvNotas";
			this.dgvNotas.ReadOnly = true;
			this.dgvNotas.RowHeadersVisible = false;
			this.dgvNotas.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvNotas.RowTemplate.Height = 24;
			this.dgvNotas.Size = new global::System.Drawing.Size(1216, 667);
			this.dgvNotas.TabIndex = 25;
			this.Panel3.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.Panel3.Controls.Add(this.Button1);
			this.Panel3.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel3.Location = new global::System.Drawing.Point(0, 667);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new global::System.Drawing.Size(1216, 86);
			this.Panel3.TabIndex = 26;
			this.Button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.Button1.BackColor = global::System.Drawing.Color.Green;
			this.Button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7.875f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = global::System.Drawing.Color.White;
			this.Button1.Location = new global::System.Drawing.Point(692, 7);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(512, 67);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Descargar";
			this.Button1.UseVisualStyleBackColor = false;
			this.PictureBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.PictureBox1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new global::System.Drawing.Point(1171, 0);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(45, 50);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 126;
			this.PictureBox1.TabStop = false;
			this.lblfechahoy.AutoSize = true;
			this.lblfechahoy.Location = new global::System.Drawing.Point(498, 13);
			this.lblfechahoy.Name = "lblfechahoy";
			this.lblfechahoy.Size = new global::System.Drawing.Size(77, 25);
			this.lblfechahoy.TabIndex = 127;
			this.lblfechahoy.Text = "Label2";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 25f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1216, 803);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmDownLicencias";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmDownLicencias";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvNotas).EndInit();
			this.Panel3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000155 RID: 341
		private global::System.ComponentModel.IContainer components;
	}
}
