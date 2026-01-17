namespace ModuloAdicional
{
	// Token: 0x02000003 RID: 3
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class frmAvisoDistintoTodas : global::System.Windows.Forms.Form
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002E98 File Offset: 0x00001098
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

		// Token: 0x06000004 RID: 4 RVA: 0x00002EE8 File Offset: 0x000010E8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.btnAplicar = new global::System.Windows.Forms.Button();
			this.txtSerie = new global::System.Windows.Forms.TextBox();
			this.txtFolio = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(746, 52);
			this.Panel1.TabIndex = 2;
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
			this.Panel2.Location = new global::System.Drawing.Point(0, 147);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(746, 78);
			this.Panel2.TabIndex = 3;
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
			this.txtSerie.Enabled = false;
			this.txtSerie.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10.125f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtSerie.Location = new global::System.Drawing.Point(18, 74);
			this.txtSerie.Name = "txtSerie";
			this.txtSerie.ReadOnly = true;
			this.txtSerie.Size = new global::System.Drawing.Size(100, 38);
			this.txtSerie.TabIndex = 4;
			this.txtFolio.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10.125f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtFolio.Location = new global::System.Drawing.Point(124, 74);
			this.txtFolio.Name = "txtFolio";
			this.txtFolio.Size = new global::System.Drawing.Size(232, 38);
			this.txtFolio.TabIndex = 5;
			this.Label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7.875f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = global::System.Drawing.Color.Red;
			this.Label2.Location = new global::System.Drawing.Point(372, 83);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(286, 25);
			this.Label2.TabIndex = 182;
			this.Label2.Text = "* Clic al folio para editarlo";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 25f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.InactiveCaption;
			base.ClientSize = new global::System.Drawing.Size(746, 225);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.txtFolio);
			base.Controls.Add(this.txtSerie);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmAvisoDistintoTodas";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAvisoDistintoTodas";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;
	}
}
