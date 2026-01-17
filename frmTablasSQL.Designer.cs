namespace ModuloAdicional
{
	// Token: 0x02000022 RID: 34
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmTablasSQL : global::System.Windows.Forms.Form
	{
		// Token: 0x06001053 RID: 4179 RVA: 0x00103638 File Offset: 0x00101838
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

		// Token: 0x06001054 RID: 4180 RVA: 0x00103688 File Offset: 0x00101888
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Location = new global::System.Drawing.Point(12, 500);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(248, 124);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Tablas SQL";
			this.Button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.Location = new global::System.Drawing.Point(6, 40);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(142, 44);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Numerador";
			this.Button1.UseVisualStyleBackColor = true;
			this.GroupBox2.Controls.Add(this.Button3);
			this.GroupBox2.Controls.Add(this.Button2);
			this.GroupBox2.Location = new global::System.Drawing.Point(15, 12);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(578, 188);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Parametros Productos Masivo";
			this.Button2.Location = new global::System.Drawing.Point(11, 42);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(134, 48);
			this.Button2.TabIndex = 0;
			this.Button2.Text = "Producto";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button3.Location = new global::System.Drawing.Point(162, 42);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(134, 48);
			this.Button3.TabIndex = 1;
			this.Button3.Text = "Cuentas";
			this.Button3.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 25f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(774, 649);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmTablasSQL";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Herramientas Admimistror";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000747 RID: 1863
		private global::System.ComponentModel.IContainer components;
	}
}
