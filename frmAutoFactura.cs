using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public partial class frmAutoFactura : Form
	{
		// Token: 0x060001AB RID: 427 RVA: 0x00014936 File Offset: 0x00012B36
		public frmAutoFactura()
		{
			base.Load += this.frmAutoFactura_Load;
			this.InitializeComponent();
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0001528A File Offset: 0x0001348A
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00015294 File Offset: 0x00013494
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0001529D File Offset: 0x0001349D
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x000152A7 File Offset: 0x000134A7
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000152B0 File Offset: 0x000134B0
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x000152BC File Offset: 0x000134BC
		internal virtual PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox1_Click);
				PictureBox pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox1 = value;
				pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000152FF File Offset: 0x000134FF
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00015309 File Offset: 0x00013509
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00015312 File Offset: 0x00013512
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x0001531C File Offset: 0x0001351C
		internal virtual Button btnDescativar
		{
			[CompilerGenerated]
			get
			{
				return this._btnDescativar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnDescativar_Click);
				Button btnDescativar = this._btnDescativar;
				if (btnDescativar != null)
				{
					btnDescativar.Click -= value2;
				}
				this._btnDescativar = value;
				btnDescativar = this._btnDescativar;
				if (btnDescativar != null)
				{
					btnDescativar.Click += value2;
				}
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0001535F File Offset: 0x0001355F
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x0001536C File Offset: 0x0001356C
		internal virtual Button btnActivar
		{
			[CompilerGenerated]
			get
			{
				return this._btnActivar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnActivar_Click);
				Button btnActivar = this._btnActivar;
				if (btnActivar != null)
				{
					btnActivar.Click -= value2;
				}
				this._btnActivar = value;
				btnActivar = this._btnActivar;
				if (btnActivar != null)
				{
					btnActivar.Click += value2;
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001BA RID: 442 RVA: 0x000153AF File Offset: 0x000135AF
		// (set) Token: 0x060001BB RID: 443 RVA: 0x000153B9 File Offset: 0x000135B9
		internal virtual Label lblAutoFacturaDesactivado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000153C2 File Offset: 0x000135C2
		// (set) Token: 0x060001BD RID: 445 RVA: 0x000153CC File Offset: 0x000135CC
		internal virtual Label lblAutoFacturaActivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001BE RID: 446 RVA: 0x000153D5 File Offset: 0x000135D5
		// (set) Token: 0x060001BF RID: 447 RVA: 0x000153DF File Offset: 0x000135DF
		internal virtual Label lblEstado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x000153E8 File Offset: 0x000135E8
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x000153F2 File Offset: 0x000135F2
		internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x000153FB File Offset: 0x000135FB
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00015405 File Offset: 0x00013605
		internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0001540E File Offset: 0x0001360E
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00015418 File Offset: 0x00013618
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060001C6 RID: 454 RVA: 0x00015424 File Offset: 0x00013624
		private void frmAutoFactura_Load(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "Select autofactura_enabled from configuracion_ws";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string left = sqlDataReader[0].ToString();
					bool flag = Operators.CompareString(left, " ", false) == 0 | Operators.CompareString(left, "False", false) == 0;
					if (flag)
					{
						this.lblAutoFacturaDesactivado.Visible = true;
						this.lblAutoFacturaActivo.Visible = false;
						this.btnActivar.Visible = true;
						this.btnDescativar.Visible = false;
					}
					bool flag2 = Operators.CompareString(this.lblEstado.Text, "True", false) == 0;
					if (flag2)
					{
						this.lblAutoFacturaActivo.Visible = true;
						this.lblAutoFacturaDesactivado.Visible = false;
						this.btnDescativar.Visible = true;
						this.btnActivar.Visible = false;
					}
				}
			}
			else
			{
				this.lblAutoFacturaDesactivado.Visible = true;
				this.lblAutoFacturaActivo.Visible = false;
				this.btnActivar.Visible = false;
				this.btnDescativar.Visible = false;
				Interaction.MsgBox("La Autofactura no esta configurada, para utilizar esta funcion es necesario activarla en el Software para Restaurantes!", MsgBoxStyle.OkOnly, null);
			}
			sqlDataReader.Close();
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00015579 File Offset: 0x00013779
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			base.Close();
			MyProject.Forms.main.BtnAutoFactura.BackColor = SystemColors.InactiveCaption;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000155A0 File Offset: 0x000137A0
		private void btnActivar_Click(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "Update configuracion_ws set autofactura_enabled=1";
			sqlQuery.execQuery(query);
			this.lblAutoFacturaActivo.Visible = true;
			this.lblAutoFacturaDesactivado.Visible = false;
			this.btnActivar.Visible = false;
			this.btnDescativar.Visible = true;
			Interaction.MsgBox("Activaste AutoFactura Opción>Ventas>Facturación se ha Desactivado", MsgBoxStyle.OkOnly, null);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00015604 File Offset: 0x00013804
		private void btnDescativar_Click(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "Update configuracion_ws set autofactura_enabled=0";
			sqlQuery.execQuery(query);
			this.lblAutoFacturaActivo.Visible = false;
			this.lblAutoFacturaDesactivado.Visible = true;
			this.btnActivar.Visible = true;
			this.btnDescativar.Visible = false;
			Interaction.MsgBox("Ya puedes facturar desde SoftRestaurant>Ventas>Facturacion", MsgBoxStyle.OkOnly, null);
		}
	}
}
