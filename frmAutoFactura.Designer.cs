namespace ModuloAdicional
{
	// Token: 0x0200000B RID: 11
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmAutoFactura : global::System.Windows.Forms.Form
	{
		// Token: 0x060001AC RID: 428 RVA: 0x00014958 File Offset: 0x00012B58
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

		// Token: 0x060001AD RID: 429 RVA: 0x000149A8 File Offset: 0x00012BA8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ModuloAdicional.frmAutoFactura));
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.lblEstado = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.Panel4 = new global::System.Windows.Forms.Panel();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.btnActivar = new global::System.Windows.Forms.Button();
			this.btnDescativar = new global::System.Windows.Forms.Button();
			this.Panel3 = new global::System.Windows.Forms.Panel();
			this.lblAutoFacturaActivo = new global::System.Windows.Forms.Label();
			this.lblAutoFacturaDesactivado = new global::System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.Panel2.SuspendLayout();
			this.Panel4.SuspendLayout();
			this.Panel3.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.Panel1.Controls.Add(this.PictureBox1);
			this.Panel1.Controls.Add(this.lblEstado);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(878, 52);
			this.Panel1.TabIndex = 0;
			this.PictureBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.PictureBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new global::System.Drawing.Point(830, 3);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(45, 45);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 128;
			this.PictureBox1.TabStop = false;
			this.lblEstado.AutoSize = true;
			this.lblEstado.Location = new global::System.Drawing.Point(872, 0);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new global::System.Drawing.Size(77, 25);
			this.lblEstado.TabIndex = 4;
			this.lblEstado.Text = "Label2";
			this.lblEstado.Visible = false;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(12, 13);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(451, 31);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Activa o Desactiva - AutoFactura ";
			this.Panel2.Controls.Add(this.Panel4);
			this.Panel2.Controls.Add(this.Panel3);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel2.Location = new global::System.Drawing.Point(0, 52);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(878, 133);
			this.Panel2.TabIndex = 1;
			this.Panel4.Controls.Add(this.Label2);
			this.Panel4.Controls.Add(this.btnActivar);
			this.Panel4.Controls.Add(this.btnDescativar);
			this.Panel4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel4.Location = new global::System.Drawing.Point(0, 58);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new global::System.Drawing.Size(878, 75);
			this.Panel4.TabIndex = 6;
			this.Label2.AutoSize = true;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = global::System.Drawing.Color.Red;
			this.Label2.Location = new global::System.Drawing.Point(454, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(424, 20);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "*Aplica este proceso antes de abrir SoftRestaurant \r\n";
			this.btnActivar.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.btnActivar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnActivar.Location = new global::System.Drawing.Point(211, 0);
			this.btnActivar.Name = "btnActivar";
			this.btnActivar.Size = new global::System.Drawing.Size(211, 75);
			this.btnActivar.TabIndex = 2;
			this.btnActivar.Text = "Activar";
			this.btnActivar.UseVisualStyleBackColor = true;
			this.btnDescativar.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.btnDescativar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnDescativar.Location = new global::System.Drawing.Point(0, 0);
			this.btnDescativar.Name = "btnDescativar";
			this.btnDescativar.Size = new global::System.Drawing.Size(211, 75);
			this.btnDescativar.TabIndex = 3;
			this.btnDescativar.Text = "Desactivar";
			this.btnDescativar.UseVisualStyleBackColor = true;
			this.Panel3.Controls.Add(this.lblAutoFacturaActivo);
			this.Panel3.Controls.Add(this.lblAutoFacturaDesactivado);
			this.Panel3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel3.Location = new global::System.Drawing.Point(0, 0);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new global::System.Drawing.Size(878, 58);
			this.Panel3.TabIndex = 5;
			this.lblAutoFacturaActivo.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom);
			this.lblAutoFacturaActivo.AutoSize = true;
			this.lblAutoFacturaActivo.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblAutoFacturaActivo.ForeColor = global::System.Drawing.Color.Green;
			this.lblAutoFacturaActivo.Location = new global::System.Drawing.Point(204, 11);
			this.lblAutoFacturaActivo.Name = "lblAutoFacturaActivo";
			this.lblAutoFacturaActivo.Size = new global::System.Drawing.Size(465, 37);
			this.lblAutoFacturaActivo.TabIndex = 0;
			this.lblAutoFacturaActivo.Text = "AutoFactura - Estado : Activo";
			this.lblAutoFacturaDesactivado.AutoSize = true;
			this.lblAutoFacturaDesactivado.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblAutoFacturaDesactivado.ForeColor = global::System.Drawing.Color.Red;
			this.lblAutoFacturaDesactivado.Location = new global::System.Drawing.Point(174, 11);
			this.lblAutoFacturaDesactivado.Name = "lblAutoFacturaDesactivado";
			this.lblAutoFacturaDesactivado.Size = new global::System.Drawing.Size(558, 37);
			this.lblAutoFacturaDesactivado.TabIndex = 1;
			this.lblAutoFacturaDesactivado.Text = "AutoFactura - Estado : Desactivado\r\n";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 25f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(878, 185);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmAutoFactura";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAutoFactura";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel4.ResumeLayout(false);
			this.Panel4.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040000B1 RID: 177
		private global::System.ComponentModel.IContainer components;
	}
}
