namespace ModuloAdicional
{
	// Token: 0x0200000C RID: 12
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmAutoUpdate : global::System.Windows.Forms.Form
	{
		// Token: 0x060001CB RID: 459 RVA: 0x00015688 File Offset: 0x00013888
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

		// Token: 0x060001CC RID: 460 RVA: 0x000156D8 File Offset: 0x000138D8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ModuloAdicional.frmAutoUpdate));
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.rbYes = new global::System.Windows.Forms.RadioButton();
			this.rbNo = new global::System.Windows.Forms.RadioButton();
			this.PictureBox8 = new global::System.Windows.Forms.PictureBox();
			this.btnGuardar = new global::System.Windows.Forms.Button();
			this.Panel1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox8).BeginInit();
			base.SuspendLayout();
			this.Panel1.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.Panel1.Controls.Add(this.PictureBox8);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(884, 54);
			this.Panel1.TabIndex = 0;
			this.GroupBox1.Controls.Add(this.btnGuardar);
			this.GroupBox1.Controls.Add(this.rbNo);
			this.GroupBox1.Controls.Add(this.rbYes);
			this.GroupBox1.Location = new global::System.Drawing.Point(12, 60);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(390, 86);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Buscar Actualizaciones";
			this.rbYes.AutoSize = true;
			this.rbYes.Location = new global::System.Drawing.Point(16, 40);
			this.rbYes.Name = "rbYes";
			this.rbYes.Size = new global::System.Drawing.Size(62, 29);
			this.rbYes.TabIndex = 0;
			this.rbYes.TabStop = true;
			this.rbYes.Text = "Si";
			this.rbYes.UseVisualStyleBackColor = true;
			this.rbNo.AutoSize = true;
			this.rbNo.Location = new global::System.Drawing.Point(129, 40);
			this.rbNo.Name = "rbNo";
			this.rbNo.Size = new global::System.Drawing.Size(74, 29);
			this.rbNo.TabIndex = 1;
			this.rbNo.TabStop = true;
			this.rbNo.Text = "NO";
			this.rbNo.UseVisualStyleBackColor = true;
			this.PictureBox8.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.PictureBox8.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.PictureBox8.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox8.Image");
			this.PictureBox8.Location = new global::System.Drawing.Point(831, 2);
			this.PictureBox8.Name = "PictureBox8";
			this.PictureBox8.Size = new global::System.Drawing.Size(50, 50);
			this.PictureBox8.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox8.TabIndex = 128;
			this.PictureBox8.TabStop = false;
			this.btnGuardar.Location = new global::System.Drawing.Point(240, 27);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new global::System.Drawing.Size(144, 49);
			this.btnGuardar.TabIndex = 2;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 25f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(884, 737);
			base.Controls.Add(this.GroupBox1);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmAutoUpdate";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAutoUpdate";
			this.Panel1.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox8).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000BE RID: 190
		private global::System.ComponentModel.IContainer components;
	}
}
