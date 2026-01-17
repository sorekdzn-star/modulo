using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	public partial class FrmAlertaDePanico : Form
	{
		// Token: 0x0600018E RID: 398 RVA: 0x00013BF8 File Offset: 0x00011DF8
		public FrmAlertaDePanico()
		{
			base.Load += this.FrmAlertaDePanico_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000191 RID: 401 RVA: 0x000143D8 File Offset: 0x000125D8
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000143E2 File Offset: 0x000125E2
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000193 RID: 403 RVA: 0x000143EB File Offset: 0x000125EB
		// (set) Token: 0x06000194 RID: 404 RVA: 0x000143F5 File Offset: 0x000125F5
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000195 RID: 405 RVA: 0x000143FE File Offset: 0x000125FE
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00014408 File Offset: 0x00012608
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00014411 File Offset: 0x00012611
		// (set) Token: 0x06000198 RID: 408 RVA: 0x0001441B File Offset: 0x0001261B
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00014424 File Offset: 0x00012624
		// (set) Token: 0x0600019A RID: 410 RVA: 0x0001442E File Offset: 0x0001262E
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00014437 File Offset: 0x00012637
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00014441 File Offset: 0x00012641
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0001444A File Offset: 0x0001264A
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00014454 File Offset: 0x00012654
		internal virtual Button BtnParametros
		{
			[CompilerGenerated]
			get
			{
				return this._BtnParametros;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnParametros_Click);
				Button btnParametros = this._BtnParametros;
				if (btnParametros != null)
				{
					btnParametros.Click -= value2;
				}
				this._BtnParametros = value;
				btnParametros = this._BtnParametros;
				if (btnParametros != null)
				{
					btnParametros.Click += value2;
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00014497 File Offset: 0x00012697
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x000144A4 File Offset: 0x000126A4
		internal virtual Button btnVenta
		{
			[CompilerGenerated]
			get
			{
				return this._btnVenta;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnVenta_Click);
				Button btnVenta = this._btnVenta;
				if (btnVenta != null)
				{
					btnVenta.Click -= value2;
				}
				this._btnVenta = value;
				btnVenta = this._btnVenta;
				if (btnVenta != null)
				{
					btnVenta.Click += value2;
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000144E7 File Offset: 0x000126E7
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x000144F4 File Offset: 0x000126F4
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
				EventHandler value2 = new EventHandler(this.PictureBox1_Click_2);
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

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00014537 File Offset: 0x00012737
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00014544 File Offset: 0x00012744
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000036D5 File Offset: 0x000018D5
		private void FrmAlertaDePanico_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00014588 File Offset: 0x00012788
		private void PictureBox1_Click_2(object sender, EventArgs e)
		{
			base.Close();
			MyProject.Forms.main.PanelContenedorForms.Visible = true;
			MyProject.Forms.main.btnEliminarProductos.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnEliminacionMasiva.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnModificar1Ticket.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnModificarTurnos.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnReportes.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnPanico.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnBitacora.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnConfiguracion.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnRespaldar.BackColor = SystemColors.ActiveCaption;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000146A0 File Offset: 0x000128A0
		private void BtnParametros_Click(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			object obj = "SE ELIMINARAN LOS PARAMETROS DEL MODULO ADICIONAL, Deseas continuar?";
			object value = 276;
			object obj2 = "ATENCIÓN!!!";
			object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
			bool flag = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
			if (flag)
			{
				string query_conn = "delete from Parametro";
				sqlQuery_Conn.execQuery_conn(query_conn);
				query_conn = "delete from FP";
				sqlQuery_Conn.execQuery_conn(query_conn);
				query_conn = "delete from usuario2";
				sqlQuery_Conn.execQuery_conn(query_conn);
				query_conn = "delete from ModuloProducto";
				sqlQuery_Conn.execQuery_conn(query_conn);
				query_conn = "delete from VentasModulo";
				sqlQuery_Conn.execQuery_conn(query_conn);
				query_conn = "delete from Usuarioperfil2";
				sqlQuery_Conn.execQuery_conn(query_conn);
				query_conn = "delete from Usuarioperfil";
				sqlQuery_Conn.execQuery_conn(query_conn);
				query_conn = "delete from ProductosEliminar";
				sqlQuery_Conn.execQuery_conn(query_conn);
				Interaction.MsgBox("Proceso Finalizado!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.No, false);
				if (flag2)
				{
				}
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000147AC File Offset: 0x000129AC
		private void btnVenta_Click(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			object obj = "SE ELIMINARAN TODOS LOS REGISTROS DE VENTAS, Deseas continuar?";
			object value = 276;
			object obj2 = "ATENCIÓN!!!";
			object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
			bool flag = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
			if (flag)
			{
				string query = "delete from chequespagos";
				sqlQuery.execQuery(query);
				query = "Delete from cheques";
				sqlQuery.execQuery(query);
				query = "Delete movtoscaja";
				sqlQuery.execQuery(query);
				query = "Delete from cheqdet";
				sqlQuery.execQuery(query);
				query = "Delete from cancela";
				sqlQuery.execQuery(query);
				query = "Delete from turnos";
				sqlQuery.execQuery(query);
				Interaction.MsgBox("Proceso Finalizado!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.No, false);
				if (flag2)
				{
				}
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00014894 File Offset: 0x00012A94
		private void Button1_Click(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			object obj = "SE ELIMINARAN TODOS LOS REGISTROS DE VENTAS REALES ALMACENADOS EN EL MODULO , Deseas continuar?";
			object value = 276;
			object obj2 = "ATENCIÓN!!!";
			object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
			bool flag = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
			if (flag)
			{
				string query = "Delete Table ModuloProductos";
				sqlQuery.execQuery(query);
				query = "Delete Table VentasModulo";
				sqlQuery.execQuery(query);
				Interaction.MsgBox("Proceso Finalizado!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.No, false);
				if (flag2)
				{
				}
			}
		}
	}
}
