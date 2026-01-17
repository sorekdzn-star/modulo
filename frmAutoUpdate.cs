using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x0200000C RID: 12
	[DesignerGenerated]
	public partial class frmAutoUpdate : Form
	{
		// Token: 0x060001CA RID: 458 RVA: 0x00015667 File Offset: 0x00013867
		public frmAutoUpdate()
		{
			base.Load += this.frmAutoUpdate_Load;
			this.InitializeComponent();
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00015B61 File Offset: 0x00013D61
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00015B6B File Offset: 0x00013D6B
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00015B74 File Offset: 0x00013D74
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00015B7E File Offset: 0x00013D7E
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00015B87 File Offset: 0x00013D87
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00015B91 File Offset: 0x00013D91
		internal virtual RadioButton rbNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00015B9A File Offset: 0x00013D9A
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00015BA4 File Offset: 0x00013DA4
		internal virtual RadioButton rbYes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00015BAD File Offset: 0x00013DAD
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00015BB7 File Offset: 0x00013DB7
		internal virtual PictureBox PictureBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00015BC0 File Offset: 0x00013DC0
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00015BCC File Offset: 0x00013DCC
		internal virtual Button btnGuardar
		{
			[CompilerGenerated]
			get
			{
				return this._btnGuardar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnGuardar_Click);
				Button btnGuardar = this._btnGuardar;
				if (btnGuardar != null)
				{
					btnGuardar.Click -= value2;
				}
				this._btnGuardar = value;
				btnGuardar = this._btnGuardar;
				if (btnGuardar != null)
				{
					btnGuardar.Click += value2;
				}
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00015C10 File Offset: 0x00013E10
		private void frmAutoUpdate_Load(object sender, EventArgs e)
		{
			bool autoUpdate = MySettingsProperty.Settings.AutoUpdate;
			if (autoUpdate)
			{
				this.rbYes.Checked = true;
			}
			else
			{
				this.rbNo.Checked = false;
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00015C4C File Offset: 0x00013E4C
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			bool @checked = this.rbYes.Checked;
			if (@checked)
			{
				MySettingsProperty.Settings.AutoUpdate = true;
			}
			else
			{
				bool checked2 = this.rbNo.Checked;
				if (checked2)
				{
					MySettingsProperty.Settings.AutoUpdate = false;
				}
			}
		}
	}
}
