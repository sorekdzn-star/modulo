using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x02000013 RID: 19
	[DesignerGenerated]
	public partial class frmEliminar1Producto : Form
	{
		// Token: 0x06000462 RID: 1122 RVA: 0x00030CB4 File Offset: 0x0002EEB4
		public frmEliminar1Producto()
		{
			base.Load += this.frmEliminarProducto_Load;
			this.table = new DataTable();
			this.view = new DataView(this.table);
			this.InitializeComponent();
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00039278 File Offset: 0x00037478
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00039282 File Offset: 0x00037482
		internal virtual TextBox txtCuentasModificar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x0003928B File Offset: 0x0003748B
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00039295 File Offset: 0x00037495
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0003929E File Offset: 0x0003749E
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x000392A8 File Offset: 0x000374A8
		internal virtual Button btnCancelar
		{
			[CompilerGenerated]
			get
			{
				return this._btnCancelar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCancelar_Click);
				Button btnCancelar = this._btnCancelar;
				if (btnCancelar != null)
				{
					btnCancelar.Click -= value2;
				}
				this._btnCancelar = value;
				btnCancelar = this._btnCancelar;
				if (btnCancelar != null)
				{
					btnCancelar.Click += value2;
				}
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x000392EB File Offset: 0x000374EB
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x000392F5 File Offset: 0x000374F5
		internal virtual TextBox txtCuentasTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x000392FE File Offset: 0x000374FE
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00039308 File Offset: 0x00037508
		internal virtual Button btnAplicar
		{
			[CompilerGenerated]
			get
			{
				return this._btnAplicar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAplicar_Click);
				Button btnAplicar = this._btnAplicar;
				if (btnAplicar != null)
				{
					btnAplicar.Click -= value2;
				}
				this._btnAplicar = value;
				btnAplicar = this._btnAplicar;
				if (btnAplicar != null)
				{
					btnAplicar.Click += value2;
				}
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0003934B File Offset: 0x0003754B
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00039355 File Offset: 0x00037555
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0003935E File Offset: 0x0003755E
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00039368 File Offset: 0x00037568
		internal virtual TextBox txtDifPorcen { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00039371 File Offset: 0x00037571
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x0003937B File Offset: 0x0003757B
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00039384 File Offset: 0x00037584
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x0003938E File Offset: 0x0003758E
		internal virtual TextBox txtEfectivoAnt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00039397 File Offset: 0x00037597
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x000393A1 File Offset: 0x000375A1
		internal virtual TextBox txtEfectivoCaja { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x000393AA File Offset: 0x000375AA
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x000393B4 File Offset: 0x000375B4
		internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x000393BD File Offset: 0x000375BD
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x000393C7 File Offset: 0x000375C7
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x000393D0 File Offset: 0x000375D0
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x000393DA File Offset: 0x000375DA
		internal virtual TextBox txtDifImporte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x000393E3 File Offset: 0x000375E3
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x000393ED File Offset: 0x000375ED
		internal virtual TextBox txtEfectivoFiscal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x000393F6 File Offset: 0x000375F6
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00039400 File Offset: 0x00037600
		internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00039409 File Offset: 0x00037609
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x00039413 File Offset: 0x00037613
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0003941C File Offset: 0x0003761C
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00039426 File Offset: 0x00037626
		internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0003942F File Offset: 0x0003762F
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00039439 File Offset: 0x00037639
		internal virtual TextBox txtImpNuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00039442 File Offset: 0x00037642
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x0003944C File Offset: 0x0003764C
		internal virtual TextBox txtImpAnterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00039455 File Offset: 0x00037655
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x0003945F File Offset: 0x0003765F
		internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00039468 File Offset: 0x00037668
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00039472 File Offset: 0x00037672
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0003947B File Offset: 0x0003767B
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00039488 File Offset: 0x00037688
		internal virtual ComboBox ComboBox1
		{
			[CompilerGenerated]
			get
			{
				return this._ComboBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBox1_SelectedIndexChanged);
				ComboBox comboBox = this._ComboBox1;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				this._ComboBox1 = value;
				comboBox = this._ComboBox1;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x000394CB File Offset: 0x000376CB
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x000394D5 File Offset: 0x000376D5
		internal virtual DateTimePicker dateHoraFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x000394DE File Offset: 0x000376DE
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x000394E8 File Offset: 0x000376E8
		internal virtual Button btnVistaPrevia
		{
			[CompilerGenerated]
			get
			{
				return this._btnVistaPrevia;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnVistaPrevia_Click);
				Button btnVistaPrevia = this._btnVistaPrevia;
				if (btnVistaPrevia != null)
				{
					btnVistaPrevia.Click -= value2;
				}
				this._btnVistaPrevia = value;
				btnVistaPrevia = this._btnVistaPrevia;
				if (btnVistaPrevia != null)
				{
					btnVistaPrevia.Click += value2;
				}
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0003952B File Offset: 0x0003772B
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00039538 File Offset: 0x00037738
		internal virtual ComboBox cmbAnio
		{
			[CompilerGenerated]
			get
			{
				return this._cmbAnio;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cmbAnio_SelectedIndexChanged);
				ComboBox cmbAnio = this._cmbAnio;
				if (cmbAnio != null)
				{
					cmbAnio.SelectedIndexChanged -= value2;
				}
				this._cmbAnio = value;
				cmbAnio = this._cmbAnio;
				if (cmbAnio != null)
				{
					cmbAnio.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0003957B File Offset: 0x0003777B
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00039585 File Offset: 0x00037785
		internal virtual ProgressBar progBar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0003958E File Offset: 0x0003778E
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00039598 File Offset: 0x00037798
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x000395A1 File Offset: 0x000377A1
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x000395AC File Offset: 0x000377AC
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

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000395EF File Offset: 0x000377EF
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x000395F9 File Offset: 0x000377F9
		internal virtual GroupBox groupPeriodo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00039602 File Offset: 0x00037802
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x0003960C File Offset: 0x0003780C
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00039615 File Offset: 0x00037815
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x0003961F File Offset: 0x0003781F
		internal virtual DateTimePicker dateHoraIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00039628 File Offset: 0x00037828
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00039632 File Offset: 0x00037832
		internal virtual ComboBox cmbxSerie { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0003963B File Offset: 0x0003783B
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00039645 File Offset: 0x00037845
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0003964E File Offset: 0x0003784E
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00039658 File Offset: 0x00037858
		internal virtual DateTimePicker dateFechaFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00039661 File Offset: 0x00037861
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x0003966B File Offset: 0x0003786B
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00039674 File Offset: 0x00037874
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x0003967E File Offset: 0x0003787E
		internal virtual DateTimePicker dateFechaIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00039687 File Offset: 0x00037887
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00039691 File Offset: 0x00037891
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x0003969A File Offset: 0x0003789A
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x000396A4 File Offset: 0x000378A4
		internal virtual GroupBox groupParametros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x000396AD File Offset: 0x000378AD
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x000396B7 File Offset: 0x000378B7
		internal virtual TextBox txtObjetivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x000396C0 File Offset: 0x000378C0
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x000396CA File Offset: 0x000378CA
		internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x000396D3 File Offset: 0x000378D3
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x000396DD File Offset: 0x000378DD
		internal virtual CheckBox chkEliminaRet { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x000396E6 File Offset: 0x000378E6
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x000396F0 File Offset: 0x000378F0
		internal virtual CheckBox chkEliminaProp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x000396F9 File Offset: 0x000378F9
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00039703 File Offset: 0x00037903
		internal virtual CheckBox chkRenumerar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x0003970C File Offset: 0x0003790C
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00039716 File Offset: 0x00037916
		internal virtual CheckBox chkCtasCortesia { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0003971F File Offset: 0x0003791F
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x00039729 File Offset: 0x00037929
		internal virtual CheckBox chkTarjCred { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00039732 File Offset: 0x00037932
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x0003973C File Offset: 0x0003793C
		internal virtual CheckBox chkVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00039745 File Offset: 0x00037945
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x0003974F File Offset: 0x0003794F
		internal virtual CheckBox chkReimpresas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00039758 File Offset: 0x00037958
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00039764 File Offset: 0x00037964
		internal virtual CheckBox chkReemplazar
		{
			[CompilerGenerated]
			get
			{
				return this._chkReemplazar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.chkReemplazar_CheckedChanged);
				CheckBox chkReemplazar = this._chkReemplazar;
				if (chkReemplazar != null)
				{
					chkReemplazar.CheckedChanged -= value2;
				}
				this._chkReemplazar = value;
				chkReemplazar = this._chkReemplazar;
				if (chkReemplazar != null)
				{
					chkReemplazar.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x000397A7 File Offset: 0x000379A7
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x000397B1 File Offset: 0x000379B1
		internal virtual CheckBox chkOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x000397BA File Offset: 0x000379BA
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x000397C4 File Offset: 0x000379C4
		internal virtual CheckBox chkFacturada { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x000397CD File Offset: 0x000379CD
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x000397D7 File Offset: 0x000379D7
		internal virtual CheckBox chkNotaConsumo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x000397E0 File Offset: 0x000379E0
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x000397EA File Offset: 0x000379EA
		internal virtual CheckBox chkEfectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x000397F3 File Offset: 0x000379F3
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x000397FD File Offset: 0x000379FD
		internal virtual ComboBox cmbxEmpresa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00039806 File Offset: 0x00037A06
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00039810 File Offset: 0x00037A10
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00039819 File Offset: 0x00037A19
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00039823 File Offset: 0x00037A23
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x0003982C File Offset: 0x00037A2C
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00039838 File Offset: 0x00037A38
		internal virtual TextBox txtDescto
		{
			[CompilerGenerated]
			get
			{
				return this._txtDescto;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtDescto_TextChanged);
				EventHandler value3 = new EventHandler(this.txtDescto_Click);
				TextBox txtDescto = this._txtDescto;
				if (txtDescto != null)
				{
					txtDescto.TextChanged -= value2;
					txtDescto.Click -= value3;
				}
				this._txtDescto = value;
				txtDescto = this._txtDescto;
				if (txtDescto != null)
				{
					txtDescto.TextChanged += value2;
					txtDescto.Click += value3;
				}
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00039896 File Offset: 0x00037A96
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x000398A0 File Offset: 0x00037AA0
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x000398A9 File Offset: 0x00037AA9
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x000398B4 File Offset: 0x00037AB4
		internal virtual TextBox txtMinimo
		{
			[CompilerGenerated]
			get
			{
				return this._txtMinimo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtMinimo_TextChanged);
				EventHandler value3 = new EventHandler(this.txtMinimo_Click);
				TextBox txtMinimo = this._txtMinimo;
				if (txtMinimo != null)
				{
					txtMinimo.TextChanged -= value2;
					txtMinimo.Click -= value3;
				}
				this._txtMinimo = value;
				txtMinimo = this._txtMinimo;
				if (txtMinimo != null)
				{
					txtMinimo.TextChanged += value2;
					txtMinimo.Click += value3;
				}
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00039912 File Offset: 0x00037B12
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x0003991C File Offset: 0x00037B1C
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00039925 File Offset: 0x00037B25
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x0003992F File Offset: 0x00037B2F
		internal virtual ComboBox cmbxTipo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00039938 File Offset: 0x00037B38
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00039942 File Offset: 0x00037B42
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x0003994B File Offset: 0x00037B4B
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00039955 File Offset: 0x00037B55
		internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0003995E File Offset: 0x00037B5E
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00039968 File Offset: 0x00037B68
		internal virtual DataGridView dgvNotas
		{
			[CompilerGenerated]
			get
			{
				return this._dgvNotas;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgvNotas_CellClick);
				MouseEventHandler value3 = new MouseEventHandler(this.dgvNotas_MouseUp);
				DataGridViewCellEventHandler value4 = new DataGridViewCellEventHandler(this.dgvNotas_CellContentClick);
				DataGridView dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellClick -= value2;
					dgvNotas.MouseUp -= value3;
					dgvNotas.CellContentClick -= value4;
				}
				this._dgvNotas = value;
				dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellClick += value2;
					dgvNotas.MouseUp += value3;
					dgvNotas.CellContentClick += value4;
				}
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x000399E1 File Offset: 0x00037BE1
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x000399EB File Offset: 0x00037BEB
		internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x000399F4 File Offset: 0x00037BF4
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x000399FE File Offset: 0x00037BFE
		internal virtual Label lblFechaInicio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00039A07 File Offset: 0x00037C07
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00039A11 File Offset: 0x00037C11
		internal virtual Label lblFechaFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00039A1A File Offset: 0x00037C1A
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00039A24 File Offset: 0x00037C24
		internal virtual Label lblfechahoy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00039A2D File Offset: 0x00037C2D
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00039A37 File Offset: 0x00037C37
		internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00039A40 File Offset: 0x00037C40
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x00039A4A File Offset: 0x00037C4A
		internal virtual TextBox txtDepositos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00039A53 File Offset: 0x00037C53
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00039A5D File Offset: 0x00037C5D
		internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00039A66 File Offset: 0x00037C66
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00039A70 File Offset: 0x00037C70
		internal virtual TextBox txtretirostotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00039A79 File Offset: 0x00037C79
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00039A83 File Offset: 0x00037C83
		internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00039A8C File Offset: 0x00037C8C
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00039A96 File Offset: 0x00037C96
		internal virtual TextBox txtTotalPropinas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00039A9F File Offset: 0x00037C9F
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00039AA9 File Offset: 0x00037CA9
		internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00039AB2 File Offset: 0x00037CB2
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00039ABC File Offset: 0x00037CBC
		internal virtual TextBox txtFacturaPUB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00039AC5 File Offset: 0x00037CC5
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00039ACF File Offset: 0x00037CCF
		internal virtual Label lblVentaSinFacturar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00039AD8 File Offset: 0x00037CD8
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00039AE2 File Offset: 0x00037CE2
		internal virtual TextBox txtventasinfacturar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00039AEB File Offset: 0x00037CEB
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00039AF5 File Offset: 0x00037CF5
		internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x00039AFE File Offset: 0x00037CFE
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x00039B08 File Offset: 0x00037D08
		internal virtual TextBox txtVentaFacturada { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00039B11 File Offset: 0x00037D11
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x00039B1B File Offset: 0x00037D1B
		internal virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00039B24 File Offset: 0x00037D24
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x00039B30 File Offset: 0x00037D30
		internal virtual PictureBox BtnHorario
		{
			[CompilerGenerated]
			get
			{
				return this._BtnHorario;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnHorario_Click);
				PictureBox btnHorario = this._BtnHorario;
				if (btnHorario != null)
				{
					btnHorario.Click -= value2;
				}
				this._BtnHorario = value;
				btnHorario = this._BtnHorario;
				if (btnHorario != null)
				{
					btnHorario.Click += value2;
				}
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00039B73 File Offset: 0x00037D73
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00039B7D File Offset: 0x00037D7D
		internal virtual Label lblVentaentarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00039B86 File Offset: 0x00037D86
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00039B90 File Offset: 0x00037D90
		internal virtual TextBox txtVentaTarjeta
		{
			[CompilerGenerated]
			get
			{
				return this._txtVentaTarjeta;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtVentaTarjeta_TextChanged);
				TextBox txtVentaTarjeta = this._txtVentaTarjeta;
				if (txtVentaTarjeta != null)
				{
					txtVentaTarjeta.TextChanged -= value2;
				}
				this._txtVentaTarjeta = value;
				txtVentaTarjeta = this._txtVentaTarjeta;
				if (txtVentaTarjeta != null)
				{
					txtVentaTarjeta.TextChanged += value2;
				}
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00039BD3 File Offset: 0x00037DD3
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x00039BDD File Offset: 0x00037DDD
		internal virtual Label lblventaenotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00039BE6 File Offset: 0x00037DE6
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00039BF0 File Offset: 0x00037DF0
		internal virtual TextBox txtVentasOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00039BF9 File Offset: 0x00037DF9
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x00039C03 File Offset: 0x00037E03
		internal virtual Label lblventaenVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00039C0C File Offset: 0x00037E0C
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x00039C16 File Offset: 0x00037E16
		internal virtual TextBox txtVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00039C1F File Offset: 0x00037E1F
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x00039C29 File Offset: 0x00037E29
		internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00039C32 File Offset: 0x00037E32
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x00039C3C File Offset: 0x00037E3C
		internal virtual TextBox txttotalnuevopropinas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00039C45 File Offset: 0x00037E45
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00039C4F File Offset: 0x00037E4F
		internal virtual Panel Panelvercortes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00039C58 File Offset: 0x00037E58
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00039C62 File Offset: 0x00037E62
		internal virtual Label Label51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00039C6B File Offset: 0x00037E6B
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00039C75 File Offset: 0x00037E75
		internal virtual Label Label52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00039C7E File Offset: 0x00037E7E
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00039C88 File Offset: 0x00037E88
		internal virtual Label lblEfectivonuevocorte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00039C91 File Offset: 0x00037E91
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00039C9B File Offset: 0x00037E9B
		internal virtual Label lblsaldofinarlcortenuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00039CA4 File Offset: 0x00037EA4
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00039CAE File Offset: 0x00037EAE
		internal virtual Label lblpropinascortenuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00039CB7 File Offset: 0x00037EB7
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00039CC1 File Offset: 0x00037EC1
		internal virtual Label lblcortenuevoretiros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00039CCA File Offset: 0x00037ECA
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00039CD4 File Offset: 0x00037ED4
		internal virtual Label lblcortenuevodepositos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00039CDD File Offset: 0x00037EDD
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00039CE7 File Offset: 0x00037EE7
		internal virtual Label lblcortenuevotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00039CF0 File Offset: 0x00037EF0
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00039CFA File Offset: 0x00037EFA
		internal virtual Label lblcortenuevovales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00039D03 File Offset: 0x00037F03
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00039D0D File Offset: 0x00037F0D
		internal virtual Label lblcortetarjetanuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00039D16 File Offset: 0x00037F16
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x00039D20 File Offset: 0x00037F20
		internal virtual PictureBox PictureBox3
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox3_Click);
				PictureBox pictureBox = this._PictureBox3;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox3 = value;
				pictureBox = this._PictureBox3;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00039D63 File Offset: 0x00037F63
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x00039D6D File Offset: 0x00037F6D
		internal virtual Label lblcorteefectivonuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00039D76 File Offset: 0x00037F76
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x00039D80 File Offset: 0x00037F80
		internal virtual Label lblfondoinicialnuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00039D89 File Offset: 0x00037F89
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x00039D93 File Offset: 0x00037F93
		internal virtual Label lblcortefondoinicialanterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00039D9C File Offset: 0x00037F9C
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x00039DA6 File Offset: 0x00037FA6
		internal virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00039DAF File Offset: 0x00037FAF
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00039DB9 File Offset: 0x00037FB9
		internal virtual Label Label41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00039DC2 File Offset: 0x00037FC2
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00039DCC File Offset: 0x00037FCC
		internal virtual Label Label42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00039DD5 File Offset: 0x00037FD5
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00039DDF File Offset: 0x00037FDF
		internal virtual Label Label43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00039DE8 File Offset: 0x00037FE8
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00039DF2 File Offset: 0x00037FF2
		internal virtual Label Label44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00039DFB File Offset: 0x00037FFB
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00039E05 File Offset: 0x00038005
		internal virtual Label Label45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00039E0E File Offset: 0x0003800E
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00039E18 File Offset: 0x00038018
		internal virtual Label Label46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00039E21 File Offset: 0x00038021
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00039E2B File Offset: 0x0003802B
		internal virtual Label Label47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00039E34 File Offset: 0x00038034
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00039E3E File Offset: 0x0003803E
		internal virtual Label Label48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00039E47 File Offset: 0x00038047
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00039E51 File Offset: 0x00038051
		internal virtual Label Label49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00039E5A File Offset: 0x0003805A
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00039E64 File Offset: 0x00038064
		internal virtual Label lblcorteanteriorefectivofinal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00039E6D File Offset: 0x0003806D
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x00039E77 File Offset: 0x00038077
		internal virtual Label lblcorteanteriorsaldo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00039E80 File Offset: 0x00038080
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00039E8A File Offset: 0x0003808A
		internal virtual Label lblcorteanteriorpropinas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00039E93 File Offset: 0x00038093
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00039E9D File Offset: 0x0003809D
		internal virtual Label lblcorteanteriorretirosefectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00039EA6 File Offset: 0x000380A6
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00039EB0 File Offset: 0x000380B0
		internal virtual Label lblcorteanteriordepositosenefectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00039EB9 File Offset: 0x000380B9
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00039EC3 File Offset: 0x000380C3
		internal virtual Label lblcorteanteriorotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00039ECC File Offset: 0x000380CC
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00039ED6 File Offset: 0x000380D6
		internal virtual Label lblcorteanteriorvales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00039EDF File Offset: 0x000380DF
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00039EE9 File Offset: 0x000380E9
		internal virtual Label lblcorteefectivoanterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00039EF2 File Offset: 0x000380F2
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00039EFC File Offset: 0x000380FC
		internal virtual Label lblcortetarjetaanterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00039F05 File Offset: 0x00038105
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00039F0F File Offset: 0x0003810F
		internal virtual Label Label38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00039F18 File Offset: 0x00038118
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00039F22 File Offset: 0x00038122
		internal virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00039F2B File Offset: 0x0003812B
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00039F35 File Offset: 0x00038135
		internal virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00039F3E File Offset: 0x0003813E
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00039F48 File Offset: 0x00038148
		internal virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00039F51 File Offset: 0x00038151
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00039F5B File Offset: 0x0003815B
		internal virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00039F64 File Offset: 0x00038164
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x00039F6E File Offset: 0x0003816E
		internal virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00039F77 File Offset: 0x00038177
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x00039F81 File Offset: 0x00038181
		internal virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00039F8A File Offset: 0x0003818A
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x00039F94 File Offset: 0x00038194
		internal virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00039F9D File Offset: 0x0003819D
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x00039FA7 File Offset: 0x000381A7
		internal virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00039FB0 File Offset: 0x000381B0
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00039FBA File Offset: 0x000381BA
		internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00039FC3 File Offset: 0x000381C3
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00039FCD File Offset: 0x000381CD
		internal virtual CheckBox CheckBoxfondocaja { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00039FD6 File Offset: 0x000381D6
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00039FE0 File Offset: 0x000381E0
		internal virtual Label lbldifvales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00039FE9 File Offset: 0x000381E9
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00039FF3 File Offset: 0x000381F3
		internal virtual TextBox txtdifvales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00039FFC File Offset: 0x000381FC
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x0003A006 File Offset: 0x00038206
		internal virtual Label lbldifotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0003A00F File Offset: 0x0003820F
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x0003A019 File Offset: 0x00038219
		internal virtual TextBox txtdifotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0003A022 File Offset: 0x00038222
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x0003A02C File Offset: 0x0003822C
		internal virtual Label lbldifTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0003A035 File Offset: 0x00038235
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x0003A03F File Offset: 0x0003823F
		internal virtual TextBox txtDifTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0003A048 File Offset: 0x00038248
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x0003A052 File Offset: 0x00038252
		internal virtual Label Label50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0003A05B File Offset: 0x0003825B
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0003A065 File Offset: 0x00038265
		internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0003A06E File Offset: 0x0003826E
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x0003A078 File Offset: 0x00038278
		internal virtual Label Label54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0003A081 File Offset: 0x00038281
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x0003A08B File Offset: 0x0003828B
		internal virtual Panel Panel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0003A094 File Offset: 0x00038294
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x0003A09E File Offset: 0x0003829E
		internal virtual Label lblfechayhora { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0003A0A7 File Offset: 0x000382A7
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x0003A0B1 File Offset: 0x000382B1
		internal virtual Panel Panel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0003A0BA File Offset: 0x000382BA
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x0003A0C4 File Offset: 0x000382C4
		internal virtual PictureBox PictureBox6
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox6_Click);
				PictureBox pictureBox = this._PictureBox6;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox6 = value;
				pictureBox = this._PictureBox6;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0003A107 File Offset: 0x00038307
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x0003A114 File Offset: 0x00038314
		internal virtual PictureBox PictureBox7
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox7_Click);
				PictureBox pictureBox = this._PictureBox7;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox7 = value;
				pictureBox = this._PictureBox7;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0003A157 File Offset: 0x00038357
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x0003A161 File Offset: 0x00038361
		internal virtual Label lblOrdenDeCuentas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0003A16A File Offset: 0x0003836A
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0003A174 File Offset: 0x00038374
		internal virtual CheckBox CheckBoxCuentasCanceladas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0003A17D File Offset: 0x0003837D
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x0003A187 File Offset: 0x00038387
		internal virtual Panel Panel10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0003A190 File Offset: 0x00038390
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x0003A19A File Offset: 0x0003839A
		internal virtual Label lblAfectadboreal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0003A1A3 File Offset: 0x000383A3
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0003A1AD File Offset: 0x000383AD
		internal virtual Label lbltipobarrido { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0003A1B6 File Offset: 0x000383B6
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x0003A1C0 File Offset: 0x000383C0
		internal virtual Label lblfecha_btm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0003A1C9 File Offset: 0x000383C9
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x0003A1D4 File Offset: 0x000383D4
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
				EventHandler value3 = new EventHandler(this.Button1_DoubleClick);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= value2;
					button.DoubleClick -= value3;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += value2;
					button.DoubleClick += value3;
				}
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0003A232 File Offset: 0x00038432
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x0003A23C File Offset: 0x0003843C
		internal virtual Button btnCorteZ
		{
			[CompilerGenerated]
			get
			{
				return this._btnCorteZ;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnCorteZ_Click);
				Button btnCorteZ = this._btnCorteZ;
				if (btnCorteZ != null)
				{
					btnCorteZ.Click -= value2;
				}
				this._btnCorteZ = value;
				btnCorteZ = this._btnCorteZ;
				if (btnCorteZ != null)
				{
					btnCorteZ.Click += value2;
				}
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0003A27F File Offset: 0x0003847F
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x0003A289 File Offset: 0x00038489
		internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0003A292 File Offset: 0x00038492
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x0003A29C File Offset: 0x0003849C
		internal virtual Label Label53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0003A2A5 File Offset: 0x000384A5
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x0003A2AF File Offset: 0x000384AF
		internal virtual Label Label55 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0003A2B8 File Offset: 0x000384B8
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x0003A2C2 File Offset: 0x000384C2
		internal virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0003A2CB File Offset: 0x000384CB
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x0003A2D5 File Offset: 0x000384D5
		internal virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0003A2DE File Offset: 0x000384DE
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x0003A2E8 File Offset: 0x000384E8
		internal virtual Label lblfacturapubnew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0003A2F1 File Offset: 0x000384F1
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x0003A2FB File Offset: 0x000384FB
		internal virtual Label lblventasinfacturarnew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0003A304 File Offset: 0x00038504
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x0003A30E File Offset: 0x0003850E
		internal virtual Label lblventafacturanew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0003A317 File Offset: 0x00038517
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x0003A321 File Offset: 0x00038521
		internal virtual Label lblfacturapub { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0003A32A File Offset: 0x0003852A
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x0003A334 File Offset: 0x00038534
		internal virtual Label lblventasinfacturarcorte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0003A33D File Offset: 0x0003853D
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0003A347 File Offset: 0x00038547
		internal virtual Label lblventaFacturada { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0003A350 File Offset: 0x00038550
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x0003A35A File Offset: 0x0003855A
		internal virtual Label Label60 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0003A363 File Offset: 0x00038563
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x0003A36D File Offset: 0x0003856D
		internal virtual Label Label61 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0003A376 File Offset: 0x00038576
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x0003A380 File Offset: 0x00038580
		internal virtual Label Label62 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0003A389 File Offset: 0x00038589
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x0003A393 File Offset: 0x00038593
		internal virtual Label Label59 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0003A39C File Offset: 0x0003859C
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x0003A3A6 File Offset: 0x000385A6
		internal virtual Label Label58 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0003A3AF File Offset: 0x000385AF
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x0003A3B9 File Offset: 0x000385B9
		internal virtual Label Label57 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0003A3C2 File Offset: 0x000385C2
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x0003A3CC File Offset: 0x000385CC
		internal virtual Label lblCOdigoUnicoCorte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0003A3D5 File Offset: 0x000385D5
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x0003A3E0 File Offset: 0x000385E0
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0003A423 File Offset: 0x00038623
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x0003A42D File Offset: 0x0003862D
		internal virtual DataGridView DataGridView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060005C5 RID: 1477 RVA: 0x0003A438 File Offset: 0x00038638
		private void frmEliminarProducto_Load(object sender, EventArgs e)
		{
			this.Panelvercortes.Visible = false;
			this.btnCorteZ.Enabled = false;
			this.DoubleBufferedASD(this.dgvNotas, true);
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "Select a from H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string left = Conversions.ToString(sqlDataReader[0]);
					bool flag = Operators.CompareString(left, "0", false) != 0 & Operators.CompareString(left, "", false) != 0;
					if (flag)
					{
						this.habilitaControles(false);
						this.iniciaGridFolio();
						this.llenaCombos();
						this.dateHoraFin.Format = DateTimePickerFormat.Custom;
						this.dateHoraFin.CustomFormat = "hh:mm:ss tt";
						this.dateHoraIni.Format = DateTimePickerFormat.Custom;
						this.dateHoraIni.CustomFormat = "hh:mm:ss tt";
						this.dateFechaIni.Format = DateTimePickerFormat.Custom;
						this.dateFechaIni.CustomFormat = "dd/MM/yyyy";
						this.dateFechaFin.Format = DateTimePickerFormat.Custom;
						this.dateFechaFin.CustomFormat = "dd/MM/yyyy";
						this.dateFechaIni.Value = this.dateFechaIni.MinDate;
						this.dateFechaFin.Value = this.dateFechaFin.MinDate;
						this.btnVistaPrevia.Text = "Vista Previa";
						this.dgvNotas.Enabled = false;
						this.txtVales.Visible = false;
						this.txtVentasOtros.Visible = false;
						this.txtVentaTarjeta.Visible = false;
						this.lblventaenotros.Visible = false;
						this.lblVentaentarjeta.Visible = false;
						this.lblventaenVales.Visible = false;
						this.txtdifotros.Visible = false;
						this.txtDifTarjeta.Visible = false;
						this.txtdifvales.Visible = false;
						this.lbldifotros.Visible = false;
						this.lbldifTarjeta.Visible = false;
						this.lbldifvales.Visible = false;
						this.Button2.Enabled = false;
						this.ActulizarORden();
						this.cmbAnio.Enabled = true;
					}
					else
					{
						this.habilitaControles(false);
						this.llenaCombos();
						this.dateHoraFin.Format = DateTimePickerFormat.Custom;
						this.dateHoraFin.CustomFormat = "hh:mm:ss tt";
						this.dateHoraIni.Format = DateTimePickerFormat.Custom;
						this.dateHoraIni.CustomFormat = "hh:mm:ss tt";
						this.dateFechaIni.Format = DateTimePickerFormat.Custom;
						this.dateFechaIni.CustomFormat = "dd/MM/yyyy";
						this.dateFechaFin.Format = DateTimePickerFormat.Custom;
						this.dateFechaFin.CustomFormat = "dd/MM/yyyy";
						this.dateFechaIni.Value = this.dateFechaIni.MinDate;
						this.dateFechaFin.Value = this.dateFechaFin.MinDate;
						this.btnVistaPrevia.Text = "Vista Previa";
						this.cmbAnio.Enabled = false;
						this.dgvNotas.Enabled = false;
						this.txtVales.Visible = false;
						this.txtVentasOtros.Visible = false;
						this.txtVentaTarjeta.Visible = false;
						this.txtventasinfacturar.Visible = false;
						this.lblventaenotros.Visible = false;
						this.lblVentaentarjeta.Visible = false;
						this.lblventaenVales.Visible = false;
						this.lblVentaSinFacturar.Visible = false;
						this.txtdifotros.Visible = false;
						this.txtDifTarjeta.Visible = false;
						this.txtdifvales.Visible = false;
						this.lbldifotros.Visible = false;
						this.lbldifTarjeta.Visible = false;
						this.lbldifvales.Visible = false;
						this.Button2.Enabled = false;
						this.ActulizarORden();
						Interaction.MsgBox("No puedes utilizar esta funcion necesitas asignar un producto , Ve a Configuracion >> Asignar Producto!", MsgBoxStyle.OkOnly, null);
					}
				}
			}
			sqlDataReader.Close();
			this.table.Columns.Add("id_nota");
			this.table.Columns.Add("Serie");
			this.table.Columns.Add("FolioCuenta", typeof(int));
			this.table.Columns.Add("Folio Nota Consumo");
			this.table.Columns.Add("Mesa");
			this.table.Columns.Add("Fecha");
			this.table.Columns.Add("Cancel.");
			this.table.Columns.Add("Facturado");
			this.table.Columns.Add("Descto %");
			this.table.Columns.Add("Total Original");
			this.table.Columns.Add("Prod. Eliminados");
			this.table.Columns.Add("Total con Descuento");
			this.table.Columns.Add("Efectivo");
			this.table.Columns.Add("Tarjeta");
			this.table.Columns.Add("Vales");
			this.table.Columns.Add("Otros");
			this.table.Columns.Add("Folio Propina");
			this.table.Columns.Add("Propina");
			this.table.Columns.Add("Eliminar");
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0003A9EC File Offset: 0x00038BEC
		public void ActulizarORden()
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "Select ac from H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool flag = sqlDataReader.Read();
			if (flag)
			{
				string value = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				bool flag2 = Conversions.ToDouble(value) == 0.0;
				if (flag2)
				{
					this.lblOrdenDeCuentas.Text = "Orden de Cuentas Continuo";
				}
				bool flag3 = Conversions.ToDouble(value) == 1.0;
				if (flag3)
				{
					this.lblOrdenDeCuentas.Text = "Orden de Cuentas Aleatorio";
				}
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0003AA8C File Offset: 0x00038C8C
		private void iniciaGridFolio()
		{
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			this.dgvNotas.Rows.Clear();
			this.dgvNotas.ColumnCount = 18;
			this.dgvNotas.Columns[0].Name = "id_nota";
			this.dgvNotas.Columns[0].Visible = false;
			this.dgvNotas.Columns[0].ReadOnly = true;
			this.dgvNotas.Columns[1].Name = "Serie";
			this.dgvNotas.Columns[1].Width = 50;
			this.dgvNotas.Columns[1].ReadOnly = true;
			this.dgvNotas.Columns[2].Name = "Folio Cuenta";
			this.dgvNotas.Columns[2].Width = 70;
			this.dgvNotas.Columns[2].ReadOnly = true;
			this.dgvNotas.Columns[3].Name = "Folio Nota Consumo";
			this.dgvNotas.Columns[3].Width = 70;
			this.dgvNotas.Columns[3].ReadOnly = true;
			this.dgvNotas.Columns[4].Name = "Mesa";
			this.dgvNotas.Columns[4].Width = 70;
			this.dgvNotas.Columns[4].ReadOnly = true;
			this.dgvNotas.Columns[5].Name = "Fecha";
			this.dgvNotas.Columns[5].Width = 170;
			this.dgvNotas.Columns[5].ReadOnly = true;
			this.dgvNotas.Columns[6].Name = "Cancel.";
			this.dgvNotas.Columns[6].Width = 50;
			this.dgvNotas.Columns[6].ReadOnly = true;
			this.dgvNotas.Columns[7].Name = "Facturado";
			this.dgvNotas.Columns[7].Width = 70;
			this.dgvNotas.Columns[7].ReadOnly = true;
			this.dgvNotas.Columns[8].Name = "Descto %";
			this.dgvNotas.Columns[8].Width = 60;
			this.dgvNotas.Columns[8].ReadOnly = true;
			this.dgvNotas.Columns[9].Name = "Total Original";
			this.dgvNotas.Columns[9].Width = 80;
			this.dgvNotas.Columns[9].ReadOnly = true;
			this.dgvNotas.Columns[10].Name = "Prod. Eliminados";
			this.dgvNotas.Columns[10].Width = 80;
			this.dgvNotas.Columns[10].ReadOnly = true;
			this.dgvNotas.Columns[11].Name = "Total con Prod. Eliminados";
			this.dgvNotas.Columns[11].Width = 80;
			this.dgvNotas.Columns[11].ReadOnly = true;
			this.dgvNotas.Columns[12].Name = "Efectivo";
			this.dgvNotas.Columns[12].Width = 80;
			this.dgvNotas.Columns[12].ReadOnly = true;
			this.dgvNotas.Columns[13].Name = "Tarjeta";
			this.dgvNotas.Columns[13].Width = 80;
			this.dgvNotas.Columns[13].ReadOnly = true;
			this.dgvNotas.Columns[14].Name = "Vales";
			this.dgvNotas.Columns[14].Width = 80;
			this.dgvNotas.Columns[14].ReadOnly = true;
			this.dgvNotas.Columns[15].Name = "Otros";
			this.dgvNotas.Columns[15].Width = 80;
			this.dgvNotas.Columns[15].ReadOnly = true;
			this.dgvNotas.Columns[16].Name = "Folio Propina";
			this.dgvNotas.Columns[16].Width = 80;
			this.dgvNotas.Columns[16].Visible = false;
			this.dgvNotas.Columns[17].Name = "Propina";
			this.dgvNotas.Columns[17].Width = 80;
			this.dgvNotas.Columns[17].Visible = true;
			dataGridViewCheckBoxColumn.Width = 60;
			dataGridViewCheckBoxColumn.Name = "Eliminar";
			this.dgvNotas.Columns.Add(dataGridViewCheckBoxColumn);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0003B070 File Offset: 0x00039270
		private void llenaCombos()
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			this.cmbxEmpresa.Items.Clear();
			this.cmbxSerie.Items.Clear();
			this.cmbxTipo.Items.Clear();
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader("select distinct(idempresa) from empresas");
			while (sqlDataReader.Read())
			{
				this.cmbxEmpresa.Items.Add(sqlDataReader[0].ToString());
			}
			sqlDataReader = (SqlDataReader)sqlQuery.execReader("select distinct(serie) from folios");
			this.cmbxSerie.Items.Add("Todas");
			while (sqlDataReader.Read())
			{
				this.cmbxSerie.Items.Add(sqlDataReader[0].ToString());
			}
			this.cmbxTipo.Items.Add("Reemplazar 1 Producto");
			sqlDataReader.Close();
			this.cmbxTipo.SelectedIndex = 0;
			this.cmbxSerie.SelectedIndex = 0;
			this.cmbxEmpresa.SelectedIndex = 0;
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn("select distinct (b) from G");
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					this.cmbAnio.Items.Add(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
				}
			}
			sqlDataReader.Close();
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0003B1EC File Offset: 0x000393EC
		private void btnVistaPrevia_Click(object sender, EventArgs e)
		{
			this.progBar.Value = 0;
			this.btnCorteZ.Enabled = true;
			bool flag = Operators.ConditionalCompareObjectEqual(this.validar(), false, false);
			if (!flag)
			{
				SqlQuery sqlQuery = new SqlQuery();
				SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
				string text = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
				string text2 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
				string query_conn = string.Concat(new string[]
				{
					"select * from I where b >= '",
					text,
					"' and c <='",
					text2,
					"'"
				});
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
				bool flag2 = !sqlDataReader.HasRows;
				if (flag2)
				{
					this.habilitaControles(false);
					this.refrescaDatos();
					this.habilitaControles(true);
					this.dgvNotas.Enabled = true;
					this.progBar.Value = 0;
					this.Button1.PerformClick();
					bool flag3 = Conversions.ToDouble(this.txtMinimo.Text) == 0.0 & Conversions.ToDouble(this.txtDescto.Text) == 0.0;
					if (flag3)
					{
						this.dgvNotas.Columns[18].Visible = false;
					}
					else
					{
						bool flag4 = Conversions.ToDouble(this.txtMinimo.Text) != 0.0 & Conversions.ToDouble(this.txtDescto.Text) == 0.0;
						if (flag4)
						{
							this.dgvNotas.Columns[18].Visible = true;
						}
						else
						{
							bool flag5 = Conversions.ToDouble(this.txtMinimo.Text) == 0.0 & Conversions.ToDouble(this.txtDescto.Text) != 0.0;
							if (flag5)
							{
								this.dgvNotas.Columns[18].Visible = true;
							}
						}
					}
					bool flag6 = this.dgvNotas.Rows.Count > 1 & Operators.CompareString(this.txtCuentasModificar.Text, "0", false) != 0;
					if (flag6)
					{
						this.btnAplicar.Enabled = true;
					}
					else
					{
						this.btnAplicar.Enabled = false;
					}
					bool flag7 = Operators.CompareString(this.lblOrdenDeCuentas.Text, "Orden de Cuentas Aleatorio", false) == 0;
					if (flag7)
					{
						this.Button2.PerformClick();
					}
					bool flag8 = Operators.CompareString(this.lblOrdenDeCuentas.Text, "Orden de Cuentas Continuo", false) == 0;
					if (flag8)
					{
						this.Button2.PerformClick();
					}
				}
				else
				{
					bool hasRows = sqlDataReader.HasRows;
					if (hasRows)
					{
						object obj = "El rango de fechas ya ha sido modificado anteriormente, Deseas continuar?        \r\n*Nota se sobrescribiran los datos fiscales de esas fechas,con los nuevos datos.\r\n                  ";
						object value = 276;
						object obj2 = "ATENCIÓN!!!";
						object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
						bool flag9 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
						if (flag9)
						{
							this.habilitaControles(false);
							this.refrescaDatos();
							this.habilitaControles(true);
							this.dgvNotas.Enabled = true;
							this.progBar.Value = 0;
							this.Button1.PerformClick();
							bool flag10 = Conversions.ToDouble(this.txtMinimo.Text) == 0.0 & Conversions.ToDouble(this.txtDescto.Text) == 0.0;
							if (flag10)
							{
								this.dgvNotas.Columns[18].Visible = false;
							}
							else
							{
								bool flag11 = Conversions.ToDouble(this.txtMinimo.Text) != 0.0 & Conversions.ToDouble(this.txtDescto.Text) == 0.0;
								if (flag11)
								{
									this.dgvNotas.Columns[18].Visible = true;
								}
								else
								{
									bool flag12 = Conversions.ToDouble(this.txtMinimo.Text) == 0.0 & Conversions.ToDouble(this.txtDescto.Text) != 0.0;
									if (flag12)
									{
										this.dgvNotas.Columns[18].Visible = true;
									}
								}
							}
							bool flag13 = this.dgvNotas.Rows.Count > 1 & Operators.CompareString(this.txtCuentasModificar.Text, "0", false) != 0;
							if (flag13)
							{
								this.btnAplicar.Enabled = true;
							}
							else
							{
								this.btnAplicar.Enabled = false;
							}
							bool flag14 = Operators.CompareString(this.lblOrdenDeCuentas.Text, "Orden de Cuentas Aleatorio", false) == 0;
							if (flag14)
							{
								this.Button2.PerformClick();
							}
							bool flag15 = Operators.CompareString(this.lblOrdenDeCuentas.Text, "Orden de Cuentas Continuo", false) == 0;
							if (flag15)
							{
								this.Button2.PerformClick();
							}
						}
						else
						{
							bool flag16 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.No, false);
							if (flag16)
							{
							}
						}
						sqlDataReader.Close();
					}
				}
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0003B774 File Offset: 0x00039974
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0003B7A8 File Offset: 0x000399A8
		public void refrescaDatos()
		{
			frmWaitMsg frmWaitMsg = new frmWaitMsg();
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			this.iFolioInicial = (0 == 0);
			this.iNumChequeInicial = (0 == 0);
			DateTime dateTime = Convert.ToDateTime(this.dateFechaIni.Text);
			DateTime dateTime2 = Convert.ToDateTime(this.dateFechaFin.Text);
			string text = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
			string text2 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
			this.lblFechaInicio.Text = text.ToString();
			this.lblFechaFin.Text = text2.ToString();
			DateTime now = DateAndTime.Now;
			this.lblfechahoy.Text = now.ToString("yyyy-dd-MM hh:mm:ss");
			int num = 0;
			int num2 = 0;
			bool flag = true;
			string text3 = this.cmbxSerie.Text;
			string text4 = "SELECT ac FROM H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
			bool flag2 = sqlDataReader.Read();
			double num12;
			double num14;
			if (flag2)
			{
				string text5 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				bool flag3 = Operators.CompareString(text5, "1", false) == 0;
				bool flag10;
				double num11;
				double num13;
				if (flag3)
				{
					bool flag4 = Operators.CompareString(text3, "Todas", false) == 0;
					if (flag4)
					{
						text4 = "SELECT c from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag5 = sqlDataReader.Read();
						if (flag5)
						{
							this.PrecioNuevo = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
							text4 = string.Concat(new string[]
							{
								"SELECT folio,numcheque,fecha,cancelado,facturado, \r\n                    folionotadeconsumo,impresiones,descuento,total,efectivo,\r\n                    tarjeta,vales,otros,notadeconsumo,totalarticulos , (select c from ",
								Tools.BaseDatos_Modulo,
								".dbo.h) as PrecioNuevo, idmesero , estacion , idturno ,propinafoliomovtocaja,propina,seriefolio,mesa  from cheques \r\n\t\t\t\t\t\r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
								text,
								"' AND '",
								text2,
								"' AND \r\n                    cierre is not null and idempresa='",
								Tools.id_Empresa,
								"')\r\n                    and idempresa='",
								Tools.id_Empresa,
								"' order by newid()"
							});
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							this.iniciaGridFolio();
							bool hasRows = sqlDataReader.HasRows;
							if (hasRows)
							{
								checked
								{
									while (sqlDataReader.Read())
									{
										bool flag6 = Operators.ConditionalCompareObjectLessEqual(this.iFolioInicial, 0, false);
										if (flag6)
										{
											this.iFolioInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
											this.iNumChequeInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[1]);
										}
										string text6 = Conversions.ToString(sqlDataReader[0]);
										int num3 = Conversions.ToInteger(sqlDataReader[1]);
										string text7 = Conversions.ToString(sqlDataReader[2]);
										bool flag7 = Operators.ConditionalCompareObjectEqual(sqlDataReader[3], true, false);
										string text8;
										if (flag7)
										{
											text8 = "Si";
										}
										else
										{
											text8 = "No";
										}
										bool flag8 = Operators.ConditionalCompareObjectEqual(sqlDataReader[4], true, false);
										string text9;
										if (flag8)
										{
											text9 = "Si";
										}
										else
										{
											text9 = "No";
										}
										string text10 = Conversions.ToString(sqlDataReader[5]);
										string value = Conversions.ToString(sqlDataReader[6]);
										string text11 = Conversions.ToString(Conversions.ToInteger(sqlDataReader[7]));
										double num4 = Conversions.ToDouble(sqlDataReader[8]);
										double num5 = Conversions.ToDouble(sqlDataReader[9]);
										double num6 = Conversions.ToDouble(sqlDataReader[10]);
										double num7 = Conversions.ToDouble(sqlDataReader[11]);
										double num8 = Conversions.ToDouble(sqlDataReader[12]);
										string text12 = Conversions.ToString(sqlDataReader[13]);
										string text13 = Conversions.ToString(sqlDataReader[14]);
										this.idmesero = Conversions.ToString(sqlDataReader[16]);
										this.estacion = Conversions.ToString(sqlDataReader[17]);
										this.FechaTicket = Conversions.ToDate(sqlDataReader[2]);
										this.idTurnoTicket = Conversions.ToString(sqlDataReader[18]);
										double num9 = Conversions.ToDouble(sqlDataReader[19]);
										double num10 = Conversions.ToDouble(sqlDataReader[20]);
										string text14 = Conversions.ToString(sqlDataReader[21]);
										string text15 = Conversions.ToString(sqlDataReader[22]);
										bool flag9 = this.chkTarjCred.Checked & num6 > 0.0;
										if (flag9)
										{
											flag10 = true;
										}
										bool flag11 = this.chkVales.Checked & num7 > 0.0;
										if (flag11)
										{
											flag10 = true;
										}
										bool flag12 = this.chkFacturada.Checked & Operators.CompareString(text9, "Si", false) == 0;
										if (flag12)
										{
											flag10 = true;
										}
										bool flag13 = this.chkOtros.Checked & num8 > 0.0;
										if (flag13)
										{
											flag10 = true;
										}
										bool flag14 = this.chkEfectivo.Checked & num5 > 0.0;
										if (flag14)
										{
											flag10 = true;
										}
										bool flag15 = this.chkCtasCortesia.Checked & Operators.CompareString(text11, "100", false) == 0;
										if (flag15)
										{
											flag10 = true;
										}
										bool flag16 = this.chkNotaConsumo.Checked & Operators.CompareString(text10, "0", false) != 0;
										if (flag16)
										{
											flag10 = true;
										}
										bool flag17 = !this.chkTarjCred.Checked & num6 > 0.0;
										if (flag17)
										{
											flag10 = false;
										}
										bool flag18 = !this.chkVales.Checked & num7 > 0.0;
										if (flag18)
										{
											flag10 = false;
										}
										bool flag19 = !this.chkFacturada.Checked & Operators.CompareString(text9, "Si", false) == 0;
										if (flag19)
										{
											flag10 = false;
										}
										bool flag20 = !this.chkOtros.Checked & num8 > 0.0;
										if (flag20)
										{
											flag10 = false;
										}
										bool flag21 = !this.chkEfectivo.Checked & num5 > 0.0;
										if (flag21)
										{
											flag10 = false;
										}
										bool flag22 = !this.chkCtasCortesia.Checked & Operators.CompareString(text11, "100", false) == 0;
										if (flag22)
										{
											flag10 = false;
										}
										bool flag23 = !this.chkNotaConsumo.Checked & Operators.CompareString(text10, "0", false) != 0;
										if (flag23)
										{
											flag10 = false;
										}
										bool flag24 = this.chkReimpresas.Checked & Conversions.ToDouble(value) > 1.0;
										if (flag24)
										{
											flag10 = false;
										}
										bool flag25 = this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text8, "Si", false) == 0;
										if (flag25)
										{
											flag10 = true;
										}
										bool flag26 = !this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text8, "Si", false) == 0;
										if (flag26)
										{
											flag10 = false;
										}
										bool flag27 = Operators.CompareString(this.txtMinimo.Text, "", false) != 0;
										if (flag27)
										{
										}
										this.dgvNotas.Rows.Add(new object[]
										{
											text6,
											text14,
											num3,
											text10,
											text15,
											text7,
											text8,
											text9,
											text11,
											num4,
											text13,
											"0",
											num5,
											num6,
											num7,
											num8,
											num9,
											num10,
											flag10
										});
										num++;
									}
									text4 = string.Concat(new string[]
									{
										"select Case when sum(total) Is NULL then 0 else sum(total) end from cheques \r\n                                        where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
										text,
										"' AND '",
										text2,
										"' AND \r\n                                        cierre is not null and idempresa='",
										Tools.id_Empresa,
										"')\r\n                                        and idempresa='",
										Tools.id_Empresa,
										"' and cancelado='0'"
									});
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool flag28 = sqlDataReader.Read();
									if (flag28)
									{
										num11 = Conversions.ToDouble(sqlDataReader[0]);
									}
								}
								num12 += num11;
								text4 = string.Concat(new string[]
								{
									"select Case when sum(efectivo) Is NULL then 0 else sum(efectivo) end from cheques \r\n                                        where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and cancelado='0'"
								});
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool flag29 = sqlDataReader.Read();
								if (flag29)
								{
									num13 = Conversions.ToDouble(sqlDataReader[0]);
								}
								num14 += num13;
							}
						}
						sqlDataReader.Close();
					}
					bool flag30 = Operators.CompareString(text3, "Todas", false) != 0;
					if (flag30)
					{
						text4 = "SELECT c from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag31 = sqlDataReader.Read();
						if (flag31)
						{
							this.PrecioNuevo = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
							text4 = string.Concat(new string[]
							{
								"SELECT folio,numcheque,fecha,cancelado,facturado, \r\n                    folionotadeconsumo,impresiones,descuento,total,efectivo,\r\n                    tarjeta,vales,otros,notadeconsumo,totalarticulos , (select c from ",
								Tools.BaseDatos_Modulo,
								".dbo.h) as PrecioNuevo, idmesero , estacion , idturno ,propinafoliomovtocaja,propina,seriefolio,mesa  from cheques \r\n\t\t\t\t\t\r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
								text,
								"' AND '",
								text2,
								"' AND \r\n                    cierre is not null and idempresa='",
								Tools.id_Empresa,
								"')\r\n                    and idempresa='",
								Tools.id_Empresa,
								"' and seriefolio = '",
								text3,
								"'  order by newid()"
							});
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							this.iniciaGridFolio();
							bool hasRows2 = sqlDataReader.HasRows;
							if (hasRows2)
							{
								checked
								{
									while (sqlDataReader.Read())
									{
										bool flag32 = Operators.ConditionalCompareObjectLessEqual(this.iFolioInicial, 0, false);
										if (flag32)
										{
											this.iFolioInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
											this.iNumChequeInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[1]);
										}
										string text6 = Conversions.ToString(sqlDataReader[0]);
										int num3 = Conversions.ToInteger(sqlDataReader[1]);
										string text7 = Conversions.ToString(sqlDataReader[2]);
										bool flag33 = Operators.ConditionalCompareObjectEqual(sqlDataReader[3], true, false);
										string text8;
										if (flag33)
										{
											text8 = "Si";
										}
										else
										{
											text8 = "No";
										}
										bool flag34 = Operators.ConditionalCompareObjectEqual(sqlDataReader[4], true, false);
										string text9;
										if (flag34)
										{
											text9 = "Si";
										}
										else
										{
											text9 = "No";
										}
										string text10 = Conversions.ToString(sqlDataReader[5]);
										string value = Conversions.ToString(sqlDataReader[6]);
										string text11 = Conversions.ToString(Conversions.ToInteger(sqlDataReader[7]));
										double num4 = Conversions.ToDouble(sqlDataReader[8]);
										double num5 = Conversions.ToDouble(sqlDataReader[9]);
										double num6 = Conversions.ToDouble(sqlDataReader[10]);
										double num7 = Conversions.ToDouble(sqlDataReader[11]);
										double num8 = Conversions.ToDouble(sqlDataReader[12]);
										string text12 = Conversions.ToString(sqlDataReader[13]);
										string text13 = Conversions.ToString(sqlDataReader[14]);
										this.idmesero = Conversions.ToString(sqlDataReader[16]);
										this.estacion = Conversions.ToString(sqlDataReader[17]);
										this.FechaTicket = Conversions.ToDate(sqlDataReader[2]);
										this.idTurnoTicket = Conversions.ToString(sqlDataReader[18]);
										double num9 = Conversions.ToDouble(sqlDataReader[19]);
										double num10 = Conversions.ToDouble(sqlDataReader[20]);
										string text16 = Conversions.ToString(sqlDataReader[21]);
										string text15 = Conversions.ToString(sqlDataReader[22]);
										bool flag35 = this.chkTarjCred.Checked & num6 > 0.0;
										if (flag35)
										{
											flag10 = true;
										}
										bool flag36 = this.chkVales.Checked & num7 > 0.0;
										if (flag36)
										{
											flag10 = true;
										}
										bool flag37 = this.chkFacturada.Checked & Operators.CompareString(text9, "Si", false) == 0;
										if (flag37)
										{
											flag10 = true;
										}
										bool flag38 = this.chkOtros.Checked & num8 > 0.0;
										if (flag38)
										{
											flag10 = true;
										}
										bool flag39 = this.chkEfectivo.Checked & num5 > 0.0;
										if (flag39)
										{
											flag10 = true;
										}
										bool flag40 = this.chkCtasCortesia.Checked & Operators.CompareString(text11, "100", false) == 0;
										if (flag40)
										{
											flag10 = true;
										}
										bool flag41 = this.chkNotaConsumo.Checked & Operators.CompareString(text10, "0", false) != 0;
										if (flag41)
										{
											flag10 = true;
										}
										bool flag42 = !this.chkTarjCred.Checked & num6 > 0.0;
										if (flag42)
										{
											flag10 = false;
										}
										bool flag43 = !this.chkVales.Checked & num7 > 0.0;
										if (flag43)
										{
											flag10 = false;
										}
										bool flag44 = !this.chkFacturada.Checked & Operators.CompareString(text9, "Si", false) == 0;
										if (flag44)
										{
											flag10 = false;
										}
										bool flag45 = !this.chkOtros.Checked & num8 > 0.0;
										if (flag45)
										{
											flag10 = false;
										}
										bool flag46 = !this.chkEfectivo.Checked & num5 > 0.0;
										if (flag46)
										{
											flag10 = false;
										}
										bool flag47 = !this.chkCtasCortesia.Checked & Operators.CompareString(text11, "100", false) == 0;
										if (flag47)
										{
											flag10 = false;
										}
										bool flag48 = !this.chkNotaConsumo.Checked & Operators.CompareString(text10, "0", false) != 0;
										if (flag48)
										{
											flag10 = false;
										}
										bool flag49 = this.chkReimpresas.Checked & Conversions.ToDouble(value) > 1.0;
										if (flag49)
										{
											flag10 = false;
										}
										bool flag50 = this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text8, "Si", false) == 0;
										if (flag50)
										{
											flag10 = true;
										}
										bool flag51 = !this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text8, "Si", false) == 0;
										if (flag51)
										{
											flag10 = false;
										}
										bool flag52 = Operators.CompareString(this.txtMinimo.Text, "", false) != 0;
										if (flag52)
										{
										}
										this.dgvNotas.Rows.Add(new object[]
										{
											text6,
											text16,
											num3,
											text10,
											text15,
											text7,
											text8,
											text9,
											text11,
											num4,
											text13,
											"0",
											num5,
											num6,
											num7,
											num8,
											num9,
											num10,
											flag10
										});
										num++;
									}
									text4 = string.Concat(new string[]
									{
										"select Case when sum(total) Is NULL then 0 else sum(total) end from cheques \r\n                                        where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
										text,
										"' AND '",
										text2,
										"' AND \r\n                                        cierre is not null and idempresa='",
										Tools.id_Empresa,
										"')\r\n                                        and idempresa='",
										Tools.id_Empresa,
										"' and cancelado='0' and seriefolio = '",
										text3,
										"'"
									});
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool flag53 = sqlDataReader.Read();
									if (flag53)
									{
										num11 = Conversions.ToDouble(sqlDataReader[0]);
									}
								}
								num12 += num11;
								text4 = string.Concat(new string[]
								{
									"select Case when sum(efectivo) Is NULL then 0 else sum(efectivo) end from cheques \r\n                                        where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and cancelado='0' and seriefolio = '",
									text3,
									"'"
								});
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool flag54 = sqlDataReader.Read();
								if (flag54)
								{
									num13 = Conversions.ToDouble(sqlDataReader[0]);
								}
								num14 += num13;
							}
						}
						sqlDataReader.Close();
					}
				}
				bool flag55 = Conversions.ToDouble(text5) == 0.0;
				if (flag55)
				{
					bool flag56 = Operators.CompareString(text3, "Todas", false) == 0;
					if (flag56)
					{
						text4 = "SELECT c from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag57 = sqlDataReader.Read();
						if (flag57)
						{
							this.PrecioNuevo = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
							text4 = string.Concat(new string[]
							{
								"SELECT folio,numcheque,fecha,cancelado,facturado, \r\n                    folionotadeconsumo,impresiones,descuento,total,efectivo,\r\n                    tarjeta,vales,otros,notadeconsumo,totalarticulos , (select c from ",
								Tools.BaseDatos_Modulo,
								".dbo.h) as PrecioNuevo, idmesero , estacion , idturno ,propinafoliomovtocaja,propina,seriefolio,mesa  from cheques \r\n\t\t\t\t\t\r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
								text,
								"' AND '",
								text2,
								"' AND \r\n                    cierre is not null and idempresa='",
								Tools.id_Empresa,
								"')\r\n                    and idempresa='",
								Tools.id_Empresa,
								"' order by seriefolio,numcheque asc"
							});
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							this.iniciaGridFolio();
							bool hasRows3 = sqlDataReader.HasRows;
							if (hasRows3)
							{
								checked
								{
									while (sqlDataReader.Read())
									{
										bool flag58 = Operators.ConditionalCompareObjectLessEqual(this.iFolioInicial, 0, false);
										if (flag58)
										{
											this.iFolioInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
											this.iNumChequeInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[1]);
										}
										string text6 = Conversions.ToString(sqlDataReader[0]);
										int num3 = Conversions.ToInteger(sqlDataReader[1]);
										string text7 = Conversions.ToString(sqlDataReader[2]);
										bool flag59 = Operators.ConditionalCompareObjectEqual(sqlDataReader[3], true, false);
										string text8;
										if (flag59)
										{
											text8 = "Si";
										}
										else
										{
											text8 = "No";
										}
										bool flag60 = Operators.ConditionalCompareObjectEqual(sqlDataReader[4], true, false);
										string text9;
										if (flag60)
										{
											text9 = "Si";
										}
										else
										{
											text9 = "No";
										}
										string text10 = Conversions.ToString(sqlDataReader[5]);
										string value = Conversions.ToString(sqlDataReader[6]);
										string text11 = Conversions.ToString(Conversions.ToInteger(sqlDataReader[7]));
										double num4 = Conversions.ToDouble(sqlDataReader[8]);
										double num5 = Conversions.ToDouble(sqlDataReader[9]);
										double num6 = Conversions.ToDouble(sqlDataReader[10]);
										double num7 = Conversions.ToDouble(sqlDataReader[11]);
										double num8 = Conversions.ToDouble(sqlDataReader[12]);
										string text12 = Conversions.ToString(sqlDataReader[13]);
										string text13 = Conversions.ToString(sqlDataReader[14]);
										this.idmesero = Conversions.ToString(sqlDataReader[16]);
										this.estacion = Conversions.ToString(sqlDataReader[17]);
										this.FechaTicket = Conversions.ToDate(sqlDataReader[2]);
										this.idTurnoTicket = Conversions.ToString(sqlDataReader[18]);
										double num9 = Conversions.ToDouble(sqlDataReader[19]);
										double num10 = Conversions.ToDouble(sqlDataReader[20]);
										string text17 = Conversions.ToString(sqlDataReader[21]);
										string text15 = Conversions.ToString(sqlDataReader[22]);
										bool flag61 = this.chkTarjCred.Checked & num6 > 0.0;
										if (flag61)
										{
											flag10 = true;
										}
										bool flag62 = this.chkVales.Checked & num7 > 0.0;
										if (flag62)
										{
											flag10 = true;
										}
										bool flag63 = this.chkFacturada.Checked & Operators.CompareString(text9, "Si", false) == 0;
										if (flag63)
										{
											flag10 = true;
										}
										bool flag64 = this.chkOtros.Checked & num8 > 0.0;
										if (flag64)
										{
											flag10 = true;
										}
										bool flag65 = this.chkEfectivo.Checked & num5 > 0.0;
										if (flag65)
										{
											flag10 = true;
										}
										bool flag66 = this.chkCtasCortesia.Checked & Operators.CompareString(text11, "100", false) == 0;
										if (flag66)
										{
											flag10 = true;
										}
										bool flag67 = this.chkNotaConsumo.Checked & Operators.CompareString(text10, "0", false) != 0;
										if (flag67)
										{
											flag10 = true;
										}
										bool flag68 = !this.chkTarjCred.Checked & num6 > 0.0;
										if (flag68)
										{
											flag10 = false;
										}
										bool flag69 = !this.chkVales.Checked & num7 > 0.0;
										if (flag69)
										{
											flag10 = false;
										}
										bool flag70 = !this.chkFacturada.Checked & Operators.CompareString(text9, "Si", false) == 0;
										if (flag70)
										{
											flag10 = false;
										}
										bool flag71 = !this.chkOtros.Checked & num8 > 0.0;
										if (flag71)
										{
											flag10 = false;
										}
										bool flag72 = !this.chkEfectivo.Checked & num5 > 0.0;
										if (flag72)
										{
											flag10 = false;
										}
										bool flag73 = !this.chkCtasCortesia.Checked & Operators.CompareString(text11, "100", false) == 0;
										if (flag73)
										{
											flag10 = false;
										}
										bool flag74 = !this.chkNotaConsumo.Checked & Operators.CompareString(text10, "0", false) != 0;
										if (flag74)
										{
											flag10 = false;
										}
										bool flag75 = this.chkReimpresas.Checked & Conversions.ToDouble(value) > 1.0;
										if (flag75)
										{
											flag10 = false;
										}
										bool flag76 = this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text8, "Si", false) == 0;
										if (flag76)
										{
											flag10 = true;
										}
										bool flag77 = !this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text8, "Si", false) == 0;
										if (flag77)
										{
											flag10 = false;
										}
										bool flag78 = Operators.CompareString(this.txtMinimo.Text, "", false) != 0;
										if (flag78)
										{
										}
										this.dgvNotas.Rows.Add(new object[]
										{
											text6,
											text17,
											num3,
											text10,
											text15,
											text7,
											text8,
											text9,
											text11,
											num4,
											text13,
											"0",
											num5,
											num6,
											num7,
											num8,
											num9,
											num10,
											flag10
										});
										num++;
									}
									text4 = string.Concat(new string[]
									{
										"select Case when sum(total) Is NULL then 0 else sum(total) end from cheques \r\n                                        where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
										text,
										"' AND '",
										text2,
										"' AND \r\n                                        cierre is not null and idempresa='",
										Tools.id_Empresa,
										"')\r\n                                        and idempresa='",
										Tools.id_Empresa,
										"' and cancelado='0'"
									});
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool flag79 = sqlDataReader.Read();
									if (flag79)
									{
										num11 = Conversions.ToDouble(sqlDataReader[0]);
									}
								}
								num12 += num11;
								text4 = string.Concat(new string[]
								{
									"select Case when sum(efectivo) Is NULL then 0 else sum(efectivo) end from cheques \r\n                                        where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and cancelado='0'"
								});
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool flag80 = sqlDataReader.Read();
								if (flag80)
								{
									num13 = Conversions.ToDouble(sqlDataReader[0]);
								}
								num14 += num13;
							}
						}
						sqlDataReader.Close();
					}
					bool flag81 = Operators.CompareString(text3, "Todas", false) != 0;
					if (flag81)
					{
						text4 = "SELECT c from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag82 = sqlDataReader.Read();
						if (flag82)
						{
							this.PrecioNuevo = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
							text4 = string.Concat(new string[]
							{
								"SELECT folio,numcheque,fecha,cancelado,facturado, \r\n                    folionotadeconsumo,impresiones,descuento,total,efectivo,\r\n                    tarjeta,vales,otros,notadeconsumo,totalarticulos , (select c from ",
								Tools.BaseDatos_Modulo,
								".dbo.h) as PrecioNuevo, idmesero , estacion , idturno ,propinafoliomovtocaja,propina,seriefolio,mesa  from cheques \r\n\t\t\t\t\t\r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
								text,
								"' AND '",
								text2,
								"' AND \r\n                    cierre is not null and idempresa='",
								Tools.id_Empresa,
								"')\r\n                    and idempresa='",
								Tools.id_Empresa,
								"' and seriefolio = '",
								text3,
								"'  order by seriefolio,numcheque asc"
							});
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							this.iniciaGridFolio();
							bool hasRows4 = sqlDataReader.HasRows;
							if (hasRows4)
							{
								checked
								{
									while (sqlDataReader.Read())
									{
										bool flag83 = Operators.ConditionalCompareObjectLessEqual(this.iFolioInicial, 0, false);
										if (flag83)
										{
											this.iFolioInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
											this.iNumChequeInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[1]);
										}
										string text6 = Conversions.ToString(sqlDataReader[0]);
										int num3 = Conversions.ToInteger(sqlDataReader[1]);
										string text7 = Conversions.ToString(sqlDataReader[2]);
										bool flag84 = Operators.ConditionalCompareObjectEqual(sqlDataReader[3], true, false);
										string text8;
										if (flag84)
										{
											text8 = "Si";
										}
										else
										{
											text8 = "No";
										}
										bool flag85 = Operators.ConditionalCompareObjectEqual(sqlDataReader[4], true, false);
										string text9;
										if (flag85)
										{
											text9 = "Si";
										}
										else
										{
											text9 = "No";
										}
										string text10 = Conversions.ToString(sqlDataReader[5]);
										string value = Conversions.ToString(sqlDataReader[6]);
										string text11 = Conversions.ToString(Conversions.ToInteger(sqlDataReader[7]));
										double num4 = Conversions.ToDouble(sqlDataReader[8]);
										double num5 = Conversions.ToDouble(sqlDataReader[9]);
										double num6 = Conversions.ToDouble(sqlDataReader[10]);
										double num7 = Conversions.ToDouble(sqlDataReader[11]);
										double num8 = Conversions.ToDouble(sqlDataReader[12]);
										string text12 = Conversions.ToString(sqlDataReader[13]);
										string text13 = Conversions.ToString(sqlDataReader[14]);
										this.idmesero = Conversions.ToString(sqlDataReader[16]);
										this.estacion = Conversions.ToString(sqlDataReader[17]);
										this.FechaTicket = Conversions.ToDate(sqlDataReader[2]);
										this.idTurnoTicket = Conversions.ToString(sqlDataReader[18]);
										double num9 = Conversions.ToDouble(sqlDataReader[19]);
										double num10 = Conversions.ToDouble(sqlDataReader[20]);
										string text18 = Conversions.ToString(sqlDataReader[21]);
										string text15 = Conversions.ToString(sqlDataReader[22]);
										bool flag86 = this.chkTarjCred.Checked & num6 > 0.0;
										if (flag86)
										{
											flag10 = true;
										}
										bool flag87 = this.chkVales.Checked & num7 > 0.0;
										if (flag87)
										{
											flag10 = true;
										}
										bool flag88 = this.chkFacturada.Checked & Operators.CompareString(text9, "Si", false) == 0;
										if (flag88)
										{
											flag10 = true;
										}
										bool flag89 = this.chkOtros.Checked & num8 > 0.0;
										if (flag89)
										{
											flag10 = true;
										}
										bool flag90 = this.chkEfectivo.Checked & num5 > 0.0;
										if (flag90)
										{
											flag10 = true;
										}
										bool flag91 = this.chkCtasCortesia.Checked & Operators.CompareString(text11, "100", false) == 0;
										if (flag91)
										{
											flag10 = true;
										}
										bool flag92 = this.chkNotaConsumo.Checked & Operators.CompareString(text10, "0", false) != 0;
										if (flag92)
										{
											flag10 = true;
										}
										bool flag93 = !this.chkTarjCred.Checked & num6 > 0.0;
										if (flag93)
										{
											flag10 = false;
										}
										bool flag94 = !this.chkVales.Checked & num7 > 0.0;
										if (flag94)
										{
											flag10 = false;
										}
										bool flag95 = !this.chkFacturada.Checked & Operators.CompareString(text9, "Si", false) == 0;
										if (flag95)
										{
											flag10 = false;
										}
										bool flag96 = !this.chkOtros.Checked & num8 > 0.0;
										if (flag96)
										{
											flag10 = false;
										}
										bool flag97 = !this.chkEfectivo.Checked & num5 > 0.0;
										if (flag97)
										{
											flag10 = false;
										}
										bool flag98 = !this.chkCtasCortesia.Checked & Operators.CompareString(text11, "100", false) == 0;
										if (flag98)
										{
											flag10 = false;
										}
										bool flag99 = !this.chkNotaConsumo.Checked & Operators.CompareString(text10, "0", false) != 0;
										if (flag99)
										{
											flag10 = false;
										}
										bool flag100 = this.chkReimpresas.Checked & Conversions.ToDouble(value) > 1.0;
										if (flag100)
										{
											flag10 = false;
										}
										bool flag101 = this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text8, "Si", false) == 0;
										if (flag101)
										{
											flag10 = true;
										}
										bool flag102 = !this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text8, "Si", false) == 0;
										if (flag102)
										{
											flag10 = false;
										}
										bool flag103 = Operators.CompareString(this.txtMinimo.Text, "", false) != 0;
										if (flag103)
										{
										}
										this.dgvNotas.Rows.Add(new object[]
										{
											text6,
											text18,
											num3,
											text10,
											text15,
											text7,
											text8,
											text9,
											text11,
											num4,
											text13,
											"0",
											num5,
											num6,
											num7,
											num8,
											num9,
											num10,
											flag10
										});
										num++;
									}
									text4 = string.Concat(new string[]
									{
										"select Case when sum(total) Is NULL then 0 else sum(total) end from cheques \r\n                                        where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
										text,
										"' AND '",
										text2,
										"' AND \r\n                                        cierre is not null and idempresa='",
										Tools.id_Empresa,
										"')\r\n                                        and idempresa='",
										Tools.id_Empresa,
										"' and cancelado='0' and seriefolio = '",
										text3,
										"'"
									});
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool flag104 = sqlDataReader.Read();
									if (flag104)
									{
										num11 = Conversions.ToDouble(sqlDataReader[0]);
									}
								}
								num12 += num11;
								text4 = string.Concat(new string[]
								{
									"select Case when sum(efectivo) Is NULL then 0 else sum(efectivo) end from cheques \r\n                                        where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and cancelado='0' and seriefolio = '",
									text3,
									"'"
								});
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool flag105 = sqlDataReader.Read();
								if (flag105)
								{
									num13 = Conversions.ToDouble(sqlDataReader[0]);
								}
								num14 += num13;
							}
						}
						sqlDataReader.Close();
					}
				}
			}
			double num15 = Conversions.ToDouble(this.txtMinimo.Text);
			bool flag106 = Conversions.ToDouble(this.txtMinimo.Text) != 0.0;
			double num16;
			double num17;
			double num19;
			double num20;
			double num21;
			double num22;
			double num23;
			double num24;
			double num25;
			double num26;
			double num27;
			double num28;
			if (flag106)
			{
				num16 = num12 - (num12 - num15);
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag107 = num16 > num12 - num17 && flag;
						if (flag107)
						{
							flag = false;
						}
						bool flag108 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), flag));
						if (flag108)
						{
							text4 = "SELECT c from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag109 = sqlDataReader.Read();
							if (flag109)
							{
								this.PrecioNuevo = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
							}
							dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
							dataGridViewRow.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
							double num18 = Conversions.ToDouble(dataGridViewRow.Cells["Descto %"].Value);
							this.PrecioNuevo = Conversions.ToDouble((this.PrecioNuevo - this.PrecioNuevo / 100.0 * num18).ToString());
							dataGridViewRow.Cells[11].Value = this.PrecioNuevo.ToString();
							num17 += Conversions.ToDouble(dataGridViewRow.Cells["Total Original"].Value) - Conversions.ToDouble(this.PrecioNuevo.ToString());
							bool flag110 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag110)
							{
								num19 += Conversions.ToDouble(dataGridViewRow.Cells["Efectivo"].Value);
								text4 = "Select i from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag111 = sqlDataReader.Read();
								if (flag111)
								{
									string text19 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text19.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows5 = sqlDataReader.HasRows;
									if (hasRows5)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag112 = Conversions.ToDouble(value2) == 4.0;
											if (flag112)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag113 = Conversions.ToDouble(value2) == 3.0;
											if (flag113)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag114 = Conversions.ToDouble(value2) == 1.0;
											if (flag114)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag115 = Conversions.ToDouble(value2) == 2.0;
											if (flag115)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num19 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag116 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag116)
							{
								num24 += Conversions.ToDouble(dataGridViewRow.Cells["Tarjeta"].Value);
								text4 = "Select j from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag117 = sqlDataReader.Read();
								if (flag117)
								{
									string text21 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text21.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows6 = sqlDataReader.HasRows;
									if (hasRows6)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag118 = Conversions.ToDouble(value2) == 4.0;
											if (flag118)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag119 = Conversions.ToDouble(value2) == 3.0;
											if (flag119)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag120 = Conversions.ToDouble(value2) == 1.0;
											if (flag120)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag121 = Conversions.ToDouble(value2) == 2.0;
											if (flag121)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num24 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag122 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag122)
							{
								num25 += Conversions.ToDouble(dataGridViewRow.Cells["Otros"].Value);
								text4 = "Select l from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag123 = sqlDataReader.Read();
								if (flag123)
								{
									string text22 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text22.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows7 = sqlDataReader.HasRows;
									if (hasRows7)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag124 = Conversions.ToDouble(value2) == 4.0;
											if (flag124)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag125 = Conversions.ToDouble(value2) == 3.0;
											if (flag125)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag126 = Conversions.ToDouble(value2) == 1.0;
											if (flag126)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag127 = Conversions.ToDouble(value2) == 2.0;
											if (flag127)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num25 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag128 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag128)
							{
								num26 += Conversions.ToDouble(dataGridViewRow.Cells["Vales"].Value);
								text4 = "Select k from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag129 = sqlDataReader.Read();
								if (flag129)
								{
									string text23 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text23.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows8 = sqlDataReader.HasRows;
									if (hasRows8)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag130 = Conversions.ToDouble(value2) == 4.0;
											if (flag130)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag131 = Conversions.ToDouble(value2) == 3.0;
											if (flag131)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag132 = Conversions.ToDouble(value2) == 1.0;
											if (flag132)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag133 = Conversions.ToDouble(value2) == 2.0;
											if (flag133)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num26 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag134 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag134)
							{
								num19 += Conversions.ToDouble(dataGridViewRow.Cells["Efectivo"].Value);
								num24 += Conversions.ToDouble(dataGridViewRow.Cells["Tarjeta"].Value);
								text4 = "Select m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag135 = sqlDataReader.Read();
								if (flag135)
								{
									string text24 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text24.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows9 = sqlDataReader.HasRows;
									if (hasRows9)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag136 = Conversions.ToDouble(value2) == 4.0;
											if (flag136)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag137 = Conversions.ToDouble(value2) == 3.0;
											if (flag137)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag138 = Conversions.ToDouble(value2) == 1.0;
											if (flag138)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag139 = Conversions.ToDouble(value2) == 2.0;
											if (flag139)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num24 += 0.0;
										num19 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag140 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag140)
							{
								num19 += Conversions.ToDouble(dataGridViewRow.Cells["Efectivo"].Value);
								num26 += Conversions.ToDouble(dataGridViewRow.Cells["Vales"].Value);
								text4 = "Select m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag141 = sqlDataReader.Read();
								if (flag141)
								{
									string text24 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text24.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows10 = sqlDataReader.HasRows;
									if (hasRows10)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag142 = Conversions.ToDouble(value2) == 4.0;
											if (flag142)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag143 = Conversions.ToDouble(value2) == 3.0;
											if (flag143)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag144 = Conversions.ToDouble(value2) == 1.0;
											if (flag144)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag145 = Conversions.ToDouble(value2) == 2.0;
											if (flag145)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num26 += 0.0;
										num19 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag146 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag146)
							{
								num19 += Conversions.ToDouble(dataGridViewRow.Cells["Efectivo"].Value);
								num25 += Conversions.ToDouble(dataGridViewRow.Cells["Otros"].Value);
								text4 = "Select m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag147 = sqlDataReader.Read();
								if (flag147)
								{
									string text24 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text24.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows11 = sqlDataReader.HasRows;
									if (hasRows11)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag148 = Conversions.ToDouble(value2) == 4.0;
											if (flag148)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag149 = Conversions.ToDouble(value2) == 3.0;
											if (flag149)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag150 = Conversions.ToDouble(value2) == 1.0;
											if (flag150)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag151 = Conversions.ToDouble(value2) == 2.0;
											if (flag151)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num25 += 0.0;
										num19 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag152 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag152)
							{
								num24 += Conversions.ToDouble(dataGridViewRow.Cells["Tarjeta"].Value);
								num26 += Conversions.ToDouble(dataGridViewRow.Cells["Vales"].Value);
								text4 = "Select m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag153 = sqlDataReader.Read();
								if (flag153)
								{
									string text24 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text24.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows12 = sqlDataReader.HasRows;
									if (hasRows12)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag154 = Conversions.ToDouble(value2) == 4.0;
											if (flag154)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag155 = Conversions.ToDouble(value2) == 3.0;
											if (flag155)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag156 = Conversions.ToDouble(value2) == 1.0;
											if (flag156)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag157 = Conversions.ToDouble(value2) == 2.0;
											if (flag157)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num24 += 0.0;
										num26 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag158 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag158)
							{
								num24 += Conversions.ToDouble(dataGridViewRow.Cells["Tarjeta"].Value);
								num25 += Conversions.ToDouble(dataGridViewRow.Cells["Otros"].Value);
								text4 = "Select m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag159 = sqlDataReader.Read();
								if (flag159)
								{
									string text24 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text24.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows13 = sqlDataReader.HasRows;
									if (hasRows13)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag160 = Conversions.ToDouble(value2) == 4.0;
											if (flag160)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag161 = Conversions.ToDouble(value2) == 3.0;
											if (flag161)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag162 = Conversions.ToDouble(value2) == 1.0;
											if (flag162)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag163 = Conversions.ToDouble(value2) == 2.0;
											if (flag163)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num25 += 0.0;
										num24 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag164 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag164)
							{
								num26 += Conversions.ToDouble(dataGridViewRow.Cells["Vales"].Value);
								num25 += Conversions.ToDouble(dataGridViewRow.Cells["Otros"].Value);
								text4 = "Select m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag165 = sqlDataReader.Read();
								if (flag165)
								{
									string text24 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text24.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows14 = sqlDataReader.HasRows;
									if (hasRows14)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag166 = Conversions.ToDouble(value2) == 4.0;
											if (flag166)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag167 = Conversions.ToDouble(value2) == 3.0;
											if (flag167)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag168 = Conversions.ToDouble(value2) == 1.0;
											if (flag168)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag169 = Conversions.ToDouble(value2) == 2.0;
											if (flag169)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num25 += 0.0;
										num26 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							num27 += Conversions.ToDouble(dataGridViewRow.Cells["Propina"].Value);
							bool flag170 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Facturado"].Value, "Si", false);
							if (flag170)
							{
								num28 += Conversions.ToDouble(dataGridViewRow.Cells["Total Original"].Value) - this.PrecioNuevo;
							}
							checked
							{
								num2++;
							}
						}
						else
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.White;
							dataGridViewRow.Cells["Eliminar"].Value = false;
						}
						bool flag171 = Conversions.ToBoolean(Operators.AndObject(this.CheckBoxCuentasCanceladas.Checked, Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "Si", false)));
						checked
						{
							if (flag171)
							{
								dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
								dataGridViewRow.Cells["Eliminar"].Value = true;
								dataGridViewRow.Cells[11].Value = this.PrecioNuevo.ToString();
								num2++;
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			bool flag172 = Conversions.ToDouble(this.txtDescto.Text) > 0.0;
			if (flag172)
			{
				num16 = num12 - num12 * (Conversions.ToDouble(this.txtDescto.Text) / 100.0);
				try
				{
					foreach (object obj2 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
						bool flag173 = num16 > num12 - num17 && flag;
						if (flag173)
						{
							flag = false;
						}
						bool flag174 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), flag));
						if (flag174)
						{
							dataGridViewRow2.DefaultCellStyle.BackColor = Color.Red;
							dataGridViewRow2.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
							num17 += Conversions.ToDouble(dataGridViewRow2.Cells["Total Original"].Value) - Conversions.ToDouble(this.PrecioNuevo.ToString());
							text4 = "SELECT c from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag175 = sqlDataReader.Read();
							if (flag175)
							{
								this.PrecioNuevo = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
							}
							double num18 = Conversions.ToDouble(dataGridViewRow2.Cells["Descto %"].Value);
							this.PrecioNuevo = Conversions.ToDouble((this.PrecioNuevo - this.PrecioNuevo / 100.0 * num18).ToString());
							dataGridViewRow2.Cells[11].Value = this.PrecioNuevo.ToString();
							bool flag176 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag176)
							{
								num19 += Conversions.ToDouble(dataGridViewRow2.Cells["Efectivo"].Value);
								text4 = "Select i from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag177 = sqlDataReader.Read();
								if (flag177)
								{
									string text19 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text19.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows15 = sqlDataReader.HasRows;
									if (hasRows15)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag178 = Conversions.ToDouble(value2) == 4.0;
											if (flag178)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag179 = Conversions.ToDouble(value2) == 3.0;
											if (flag179)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag180 = Conversions.ToDouble(value2) == 1.0;
											if (flag180)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag181 = Conversions.ToDouble(value2) == 2.0;
											if (flag181)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num19 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag182 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag182)
							{
								num24 += Conversions.ToDouble(dataGridViewRow2.Cells["Tarjeta"].Value);
								text4 = "Select j from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag183 = sqlDataReader.Read();
								if (flag183)
								{
									string text21 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text21.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows16 = sqlDataReader.HasRows;
									if (hasRows16)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag184 = Conversions.ToDouble(value2) == 4.0;
											if (flag184)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag185 = Conversions.ToDouble(value2) == 3.0;
											if (flag185)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag186 = Conversions.ToDouble(value2) == 1.0;
											if (flag186)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag187 = Conversions.ToDouble(value2) == 2.0;
											if (flag187)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num24 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag188 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag188)
							{
								num25 += Conversions.ToDouble(dataGridViewRow2.Cells["Otros"].Value);
								text4 = "Select l from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag189 = sqlDataReader.Read();
								if (flag189)
								{
									string text22 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text22.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows17 = sqlDataReader.HasRows;
									if (hasRows17)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag190 = Conversions.ToDouble(value2) == 4.0;
											if (flag190)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag191 = Conversions.ToDouble(value2) == 3.0;
											if (flag191)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag192 = Conversions.ToDouble(value2) == 1.0;
											if (flag192)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag193 = Conversions.ToDouble(value2) == 2.0;
											if (flag193)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num25 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag194 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag194)
							{
								num26 += Conversions.ToDouble(dataGridViewRow2.Cells["Vales"].Value);
								text4 = "Select k from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag195 = sqlDataReader.Read();
								if (flag195)
								{
									string text23 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text23.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows18 = sqlDataReader.HasRows;
									if (hasRows18)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag196 = Conversions.ToDouble(value2) == 4.0;
											if (flag196)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag197 = Conversions.ToDouble(value2) == 3.0;
											if (flag197)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag198 = Conversions.ToDouble(value2) == 1.0;
											if (flag198)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag199 = Conversions.ToDouble(value2) == 2.0;
											if (flag199)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num26 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag200 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag200)
							{
								num19 += Conversions.ToDouble(dataGridViewRow2.Cells["Efectivo"].Value);
								num24 += Conversions.ToDouble(dataGridViewRow2.Cells["Tarjeta"].Value);
								text4 = "Select m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag201 = sqlDataReader.Read();
								if (flag201)
								{
									string text24 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text24.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows19 = sqlDataReader.HasRows;
									if (hasRows19)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag202 = Conversions.ToDouble(value2) == 4.0;
											if (flag202)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag203 = Conversions.ToDouble(value2) == 3.0;
											if (flag203)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag204 = Conversions.ToDouble(value2) == 1.0;
											if (flag204)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag205 = Conversions.ToDouble(value2) == 2.0;
											if (flag205)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num24 += 0.0;
										num19 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag206 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag206)
							{
								num19 += Conversions.ToDouble(dataGridViewRow2.Cells["Efectivo"].Value);
								num26 += Conversions.ToDouble(dataGridViewRow2.Cells["Vales"].Value);
								text4 = "Select m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag207 = sqlDataReader.Read();
								if (flag207)
								{
									string text24 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text24.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows20 = sqlDataReader.HasRows;
									if (hasRows20)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag208 = Conversions.ToDouble(value2) == 4.0;
											if (flag208)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag209 = Conversions.ToDouble(value2) == 3.0;
											if (flag209)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag210 = Conversions.ToDouble(value2) == 1.0;
											if (flag210)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag211 = Conversions.ToDouble(value2) == 2.0;
											if (flag211)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num26 += 0.0;
										num19 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag212 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag212)
							{
								num19 += Conversions.ToDouble(dataGridViewRow2.Cells["Efectivo"].Value);
								num25 += Conversions.ToDouble(dataGridViewRow2.Cells["Otros"].Value);
								text4 = "Select m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag213 = sqlDataReader.Read();
								if (flag213)
								{
									string text24 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text24.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows21 = sqlDataReader.HasRows;
									if (hasRows21)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag214 = Conversions.ToDouble(value2) == 4.0;
											if (flag214)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag215 = Conversions.ToDouble(value2) == 3.0;
											if (flag215)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag216 = Conversions.ToDouble(value2) == 1.0;
											if (flag216)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag217 = Conversions.ToDouble(value2) == 2.0;
											if (flag217)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num25 += 0.0;
										num19 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag218 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag218)
							{
								num24 += Conversions.ToDouble(dataGridViewRow2.Cells["Tarjeta"].Value);
								num26 += Conversions.ToDouble(dataGridViewRow2.Cells["Vales"].Value);
								text4 = "Select m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag219 = sqlDataReader.Read();
								if (flag219)
								{
									string text24 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text24.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows22 = sqlDataReader.HasRows;
									if (hasRows22)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag220 = Conversions.ToDouble(value2) == 4.0;
											if (flag220)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag221 = Conversions.ToDouble(value2) == 3.0;
											if (flag221)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag222 = Conversions.ToDouble(value2) == 1.0;
											if (flag222)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag223 = Conversions.ToDouble(value2) == 2.0;
											if (flag223)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num24 += 0.0;
										num26 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag224 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag224)
							{
								num24 += Conversions.ToDouble(dataGridViewRow2.Cells["Tarjeta"].Value);
								num25 += Conversions.ToDouble(dataGridViewRow2.Cells["Otros"].Value);
								text4 = "Select m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag225 = sqlDataReader.Read();
								if (flag225)
								{
									string text24 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text24.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows23 = sqlDataReader.HasRows;
									if (hasRows23)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag226 = Conversions.ToDouble(value2) == 4.0;
											if (flag226)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag227 = Conversions.ToDouble(value2) == 3.0;
											if (flag227)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag228 = Conversions.ToDouble(value2) == 1.0;
											if (flag228)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag229 = Conversions.ToDouble(value2) == 2.0;
											if (flag229)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num25 += 0.0;
										num24 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag230 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag230)
							{
								num26 += Conversions.ToDouble(dataGridViewRow2.Cells["Vales"].Value);
								num25 += Conversions.ToDouble(dataGridViewRow2.Cells["Otros"].Value);
								text4 = "Select m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag231 = sqlDataReader.Read();
								if (flag231)
								{
									string text24 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text24.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows24 = sqlDataReader.HasRows;
									if (hasRows24)
									{
										while (sqlDataReader.Read())
										{
											string text20 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag232 = Conversions.ToDouble(value2) == 4.0;
											if (flag232)
											{
												num20 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag233 = Conversions.ToDouble(value2) == 3.0;
											if (flag233)
											{
												num21 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag234 = Conversions.ToDouble(value2) == 1.0;
											if (flag234)
											{
												num22 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag235 = Conversions.ToDouble(value2) == 2.0;
											if (flag235)
											{
												num23 += -Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num25 += 0.0;
										num26 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							num27 += Conversions.ToDouble(dataGridViewRow2.Cells["Propina"].Value);
							bool flag236 = Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells["Facturado"].Value, "Si", false);
							if (flag236)
							{
								num28 += Conversions.ToDouble(dataGridViewRow2.Cells["Total Original"].Value) - this.PrecioNuevo;
							}
							checked
							{
								num2++;
							}
						}
						else
						{
							dataGridViewRow2.DefaultCellStyle.BackColor = Color.White;
							dataGridViewRow2.Cells["Eliminar"].Value = false;
						}
						bool flag237 = Conversions.ToBoolean(Operators.AndObject(this.CheckBoxCuentasCanceladas.Checked, Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "Si", false)));
						checked
						{
							if (flag237)
							{
								dataGridViewRow2.DefaultCellStyle.BackColor = Color.Red;
								dataGridViewRow2.Cells["Eliminar"].Value = true;
								dataGridViewRow2.Cells[11].Value = this.PrecioNuevo.ToString();
								num2++;
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
			bool @checked = this.chkEliminaProp.Checked;
			if (@checked)
			{
				text4 = string.Concat(new string[]
				{
					" select case when sum(importe) IS NULL then 0 else sum(importe) end from movtoscaja  where tipo = 1 and pagodepropina=1 and idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows25 = sqlDataReader.HasRows;
				if (hasRows25)
				{
					double num29 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool checked2 = this.chkEliminaRet.Checked;
			if (checked2)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(importe) IS NULL then 0 else sum(importe) end from movtoscaja  where  pagodepropina=0 and idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"' and tipo = 1 "
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows26 = sqlDataReader.HasRows;
				if (hasRows26)
				{
					double num30 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			text4 = string.Concat(new string[]
			{
				"select case when sum(importe) IS NULL then 0 else sum(importe) end from movtoscaja  where  pagodepropina=0 and idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
				text,
				"' AND '",
				text2,
				"' AND \r\n                    cierre is not null and idempresa='",
				Tools.id_Empresa,
				"')\r\n                    and idempresa='",
				Tools.id_Empresa,
				"' and tipo = 2 "
			});
			sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
			sqlDataReader.Read();
			bool hasRows27 = sqlDataReader.HasRows;
			if (hasRows27)
			{
				double num31 = Conversions.ToDouble(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			bool flag238 = Operators.CompareString(text3, "Todas", false) == 0;
			double num32;
			if (flag238)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(propina) is null Then 0 else sum(propina ) end from cheques where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN   '",
					text,
					"' and  '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"' )\r\n                    and idempresa='",
					Tools.id_Empresa,
					"'  and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows28 = sqlDataReader.HasRows;
				if (hasRows28)
				{
					num32 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag239 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag239)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(propina) is null Then 0 else sum(propina ) end from cheques where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN   '",
					text,
					"' and  '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"' )\r\n                    and idempresa='",
					Tools.id_Empresa,
					"'  and cancelado='0' and seriefolio='",
					text3,
					"'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows29 = sqlDataReader.HasRows;
				if (hasRows29)
				{
					num32 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			text4 = string.Concat(new string[]
			{
				"select case when sum(importe) IS NULL then 0 else sum(importe) end from movtoscaja  where  pagodepropina=0 and idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
				text,
				"' AND '",
				text2,
				"' AND \r\n                    cierre is not null and idempresa='",
				Tools.id_Empresa,
				"')\r\n                    and idempresa='",
				Tools.id_Empresa,
				"' and tipo = 1 "
			});
			sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
			sqlDataReader.Read();
			bool hasRows30 = sqlDataReader.HasRows;
			double num33;
			if (hasRows30)
			{
				num33 = Conversions.ToDouble(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			text4 = string.Concat(new string[]
			{
				"select case when sum(importe) IS NULL then 0 else sum(importe) end from movtoscaja  where  pagodepropina=0 and idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
				text,
				"' AND '",
				text2,
				"' AND \r\n                    cierre is not null and idempresa='",
				Tools.id_Empresa,
				"')\r\n                    and idempresa='",
				Tools.id_Empresa,
				"' and tipo = 2 "
			});
			sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
			sqlDataReader.Read();
			bool hasRows31 = sqlDataReader.HasRows;
			double num34;
			if (hasRows31)
			{
				num34 = Conversions.ToDouble(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			bool flag240 = Operators.CompareString(text3, "Todas", false) == 0;
			double num35;
			double num36;
			if (flag240)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(total) is null Then 0 else sum(total ) end from cheques where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"' and facturado = '1'  and cancelado='0' "
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows32 = sqlDataReader.HasRows;
				if (hasRows32)
				{
					num35 = Conversions.ToDouble(sqlDataReader[0]);
					num36 = Conversions.ToDouble(sqlDataReader[0]);
					this.lblventaFacturada.Text = "$ " + num36.ToString("N2");
				}
				sqlDataReader.Close();
			}
			bool flag241 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag241)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(total) is null Then 0 else sum(total ) end from cheques where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"' and facturado = 1 and seriefolio = '",
					text3,
					"'  and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows33 = sqlDataReader.HasRows;
				if (hasRows33)
				{
					num35 = Conversions.ToDouble(sqlDataReader[0]);
					num36 = Conversions.ToDouble(sqlDataReader[0]);
					this.lblventaFacturada.Text = "$ " + num36.ToString("N2");
				}
				sqlDataReader.Close();
			}
			bool flag242 = Operators.CompareString(text3, "Todas", false) == 0;
			double num37;
			if (flag242)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(tarjeta) is null Then 0 else sum(tarjeta ) end from cheques where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"'  and cancelado='0')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows34 = sqlDataReader.HasRows;
				if (hasRows34)
				{
					num37 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag243 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag243)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(tarjeta) is null Then 0 else sum(tarjeta ) end from cheques where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"' and seriefolio = '",
					text3,
					"'  and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows35 = sqlDataReader.HasRows;
				if (hasRows35)
				{
					num37 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag244 = Operators.CompareString(text3, "Todas", false) == 0;
			double num38;
			if (flag244)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(otros) is null Then 0 else sum(otros) end from cheques where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"'  and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows36 = sqlDataReader.HasRows;
				if (hasRows36)
				{
					num38 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag245 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag245)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(otros) is null Then 0 else sum(otros) end from cheques where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"' and seriefolio = '",
					text3,
					"'  and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows37 = sqlDataReader.HasRows;
				if (hasRows37)
				{
					num38 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag246 = Operators.CompareString(text3, "Todas", false) == 0;
			double num39;
			if (flag246)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(vales) is null Then 0 else sum(vales) end from cheques where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"'  and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows38 = sqlDataReader.HasRows;
				if (hasRows38)
				{
					num39 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag247 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag247)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(vales) is null Then 0 else sum(vales) end from cheques where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"' and seriefolio = '",
					text3,
					"' and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows39 = sqlDataReader.HasRows;
				if (hasRows39)
				{
					num39 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			text4 = string.Concat(new string[]
			{
				"select case when sum(fondo) IS NULL then 0 else sum(fondo) end from turnos  where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
				text,
				"' AND '",
				text2,
				"' AND \r\n                    cierre is not null and idempresa='",
				Tools.id_Empresa,
				"')\r\n                    and idempresa='",
				Tools.id_Empresa,
				"'"
			});
			sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
			sqlDataReader.Read();
			bool hasRows40 = sqlDataReader.HasRows;
			double num40;
			if (hasRows40)
			{
				num40 = Conversions.ToDouble(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			this.lblcortetarjetaanterior.Text = "$ " + num37.ToString("N2");
			this.lblcorteefectivoanterior.Text = "$ " + num14.ToString("N2");
			this.lblcorteanteriorvales.Text = "$ " + num39.ToString("N2");
			this.lblcorteanteriorotros.Text = "$ " + num38.ToString("N2");
			this.lblcorteanteriordepositosenefectivo.Text = "$ " + num34.ToString("N2");
			this.lblcorteanteriorretirosefectivo.Text = "$ " + num33.ToString("N2");
			this.lblcorteanteriorpropinas.Text = "$ " + num32.ToString("N2");
			this.lblcorteanteriorsaldo.Text = "$ " + (num14 + num37 + num38 + num39 + num34 - num33 - num32 + num40).ToString("N2");
			this.lblcorteanteriorefectivofinal.Text = "$ " + (num14 + num34 - num33 - num32 + num40).ToString("N2");
			this.lblcortefondoinicialanterior.Text = "$ " + num40.ToString("N2");
			bool checked3 = this.CheckBoxfondocaja.Checked;
			if (checked3)
			{
				this.lblfondoinicialnuevo.Text = "$ 0.00";
			}
			else
			{
				this.lblfondoinicialnuevo.Text = "$ " + num40.ToString("N2");
			}
			this.txtVales.Text = "$ " + num39.ToString("N2");
			this.txtdifvales.Text = "$ " + (num39 - num26 - num21).ToString("N2");
			this.txtVentasOtros.Text = "$ " + num38.ToString("N2");
			this.txtdifotros.Text = "$ " + (num38 - num25 - num20).ToString("N2");
			this.txtVentaTarjeta.Text = "$ " + num37.ToString("N2");
			this.txtDifTarjeta.Text = "$ " + (num37 - num24 - num23).ToString("N2");
			this.txtDepositos.Text = "$ " + num34.ToString("N2");
			this.txtretirostotal.Text = "$ " + num33.ToString("N2");
			this.txtTotalPropinas.Text = "$ " + num32.ToString("N2");
			this.txttotalnuevopropinas.Text = "$ " + (num32 - num27).ToString("N2");
			this.txtCuentasModificar.Text = num2.ToString();
			this.txtCuentasTotal.Text = num.ToString();
			this.txtImpAnterior.Text = "$ " + num12.ToString("N2");
			this.txtImpNuevo.Text = "$ " + (num12 - num17).ToString("N2");
			this.txtEfectivoAnt.Text = "$ " + num14.ToString("N2");
			this.txtEfectivoFiscal.Text = "$ " + (num14 - num19 - num22).ToString("N2");
			this.txtDifImporte.Text = "$ " + num17.ToString("N2");
			this.txtDifPorcen.Text = "% " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			this.txtObjetivo.Text = "$ " + num16.ToString("N2");
			bool flag248 = !this.chkEliminaRet.Checked;
			if (flag248)
			{
				this.lblcortenuevodepositos.Text = "$ " + num34.ToString("N2");
				this.lblcortenuevoretiros.Text = "$ " + num33.ToString("N2");
			}
			else
			{
				this.lblcortenuevodepositos.Text = "$ 0.00";
				this.lblcortenuevoretiros.Text = "$ 0.00";
			}
			bool flag249 = !this.chkEliminaProp.Checked;
			if (flag249)
			{
				this.lblpropinascortenuevo.Text = "$ " + (num32 - num27).ToString("N2");
			}
			else
			{
				this.lblpropinascortenuevo.Text = "$ 0.00";
			}
			double num41 = num12 - num36;
			this.lblventasinfacturarcorte.Text = "$ " + num41.ToString("N2");
			this.lblfacturapub.Text = "$ " + num41.ToString("N2");
			double num42 = Conversions.ToDouble(this.txtImpNuevo.Text);
			this.txtVentaFacturada.Text = "$ " + (num35 - num28).ToString("N2");
			double num43 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			this.txtFacturaPUB.Text = "$ " + (num42 - num43).ToString("N2");
			this.txtventasinfacturar.Text = "$ " + (num42 - num43).ToString("N2");
			double num44 = Conversions.ToDouble(this.txtdifvales.Text);
			this.lblcortenuevovales.Text = "$ " + num44.ToString("N2");
			double num45 = Conversions.ToDouble(this.txtdifotros.Text);
			this.lblcortenuevotros.Text = "$ " + num45.ToString("N2");
			double num46 = Conversions.ToDouble(this.txtDifTarjeta.Text);
			this.lblcortetarjetanuevo.Text = "$ " + num46.ToString("N2");
			double num47 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
			this.lblcorteefectivonuevo.Text = "$ " + num47.ToString("N2");
			double num48 = Conversions.ToDouble(this.lblpropinascortenuevo.Text);
			double num49 = Conversions.ToDouble(this.lblcortenuevoretiros.Text);
			double num50 = Conversions.ToDouble(this.lblcortenuevodepositos.Text);
			double num51 = Conversions.ToDouble(this.lblfondoinicialnuevo.Text);
			this.lblsaldofinarlcortenuevo.Text = "$ " + (num47 + num46 + num45 + num44 - num48 - num49 + num50 + num51).ToString("N2");
			this.lblEfectivonuevocorte.Text = "$ " + (num47 - num48 - num49 + num50 + num51).ToString("N2");
			this.txtEfectivoCaja.Text = "$ " + (num47 - num48 - num49 + num50 + num51).ToString("N2");
			this.DifPorcentajeSin = (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			this.lblventafacturanew.Text = this.txtVentaFacturada.Text;
			this.lblventasinfacturarnew.Text = this.txtventasinfacturar.Text;
			this.lblfacturapubnew.Text = this.txtFacturaPUB.Text;
			bool flag250 = Conversions.ToDouble(this.txtMinimo.Text) == 0.0 & Conversions.ToDouble(this.txtDescto.Text) == 0.0;
			if (flag250)
			{
				this.dgvNotas.Columns[18].Visible = false;
			}
			else
			{
				bool flag251 = Conversions.ToDouble(this.txtMinimo.Text) != 0.0 & Conversions.ToDouble(this.txtDescto.Text) == 0.0;
				if (flag251)
				{
					this.dgvNotas.Columns[18].Visible = true;
				}
				else
				{
					bool flag252 = Conversions.ToDouble(this.txtMinimo.Text) == 0.0 & Conversions.ToDouble(this.txtDescto.Text) != 0.0;
					if (flag252)
					{
						this.dgvNotas.Columns[18].Visible = true;
					}
				}
			}
			try
			{
				foreach (object obj3 in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj3;
					bool flag253 = Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells["Total Original"].Value, 0, false);
					if (flag253)
					{
						dataGridViewRow3.DefaultCellStyle.BackColor = Color.LightBlue;
						dataGridViewRow3.Cells["Eliminar"].Value = false;
						dataGridViewRow3.Cells["Total con Prod. Eliminados"].Value = 0;
					}
				}
			}
			finally
			{
				IEnumerator enumerator3;
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			bool flag254 = Conversions.ToDouble(this.txtCuentasModificar.Text) != 0.0;
			if (flag254)
			{
				this.btnAplicar.Enabled = true;
			}
			bool flag255 = Operators.CompareString(this.txtCuentasTotal.Text, "0", false) == 0;
			if (flag255)
			{
				Interaction.MsgBox("No hay cuentas para modificar en le periodo seleccionado, intenta nuevamente con otro periodo o contacta a tu administrador del sistema!", MsgBoxStyle.OkOnly, null);
			}
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00042F70 File Offset: 0x00041170
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.main.btnEliminarProductos.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnEliminacionMasiva.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnModificar1Ticket.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnModificarTurnos.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnReportes.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnPanico.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnBitacora.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.btnConfiguracion.BackColor = SystemColors.ActiveCaption;
			MyProject.Forms.main.BtnRespaldar.BackColor = SystemColors.ActiveCaption;
			base.Hide();
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00043070 File Offset: 0x00041270
		private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			int rowIndex = e.RowIndex;
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 18;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false);
				if (flag2)
				{
					this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value = true;
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
					string text = "SELECT c from H";
					SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
					bool flag3 = sqlDataReader.Read();
					if (flag3)
					{
						this.PrecioNuevo = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
					}
					double num = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value);
					this.PrecioNuevo -= this.PrecioNuevo / 100.0 * num;
					TextBox textBox;
					(textBox = this.txtCuentasModificar).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
					(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, this.PrecioNuevo.ToString())));
					(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, this.PrecioNuevo.ToString())));
					this.dgvNotas.Rows[e.RowIndex].Cells[11].Value = this.PrecioNuevo.ToString();
					bool flag4 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false)));
					if (flag4)
					{
						(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, this.PrecioNuevo.ToString())));
						(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, this.PrecioNuevo.ToString())));
					}
					bool flag5 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, this.dgvNotas.Rows[rowIndex].Cells["Total con Prod. Eliminados"].Value, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag5)
					{
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text = "Select i from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag6 = sqlDataReader.Read();
						if (flag6)
						{
							string text2 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text2.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows = sqlDataReader.HasRows;
							if (hasRows)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag7 = Conversions.ToDouble(value) == 4.0;
									if (flag7)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag8 = Conversions.ToDouble(value) == 3.0;
									if (flag8)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag9 = Conversions.ToDouble(value) == 1.0;
									if (flag9)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag10 = Conversions.ToDouble(value) == 2.0;
									if (flag10)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag11 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag11)
					{
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						text = "Select j from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag12 = sqlDataReader.Read();
						if (flag12)
						{
							string text4 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text4.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows2 = sqlDataReader.HasRows;
							if (hasRows2)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag13 = Conversions.ToDouble(value) == 4.0;
									if (flag13)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag14 = Conversions.ToDouble(value) == 3.0;
									if (flag14)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag15 = Conversions.ToDouble(value) == 1.0;
									if (flag15)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag16 = Conversions.ToDouble(value) == 2.0;
									if (flag16)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag17 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag17)
					{
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						text = "Select k from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag18 = sqlDataReader.Read();
						if (flag18)
						{
							string text5 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text5.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows3 = sqlDataReader.HasRows;
							if (hasRows3)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag19 = Conversions.ToDouble(value) == 4.0;
									if (flag19)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag20 = Conversions.ToDouble(value) == 3.0;
									if (flag20)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag21 = Conversions.ToDouble(value) == 1.0;
									if (flag21)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag22 = Conversions.ToDouble(value) == 2.0;
									if (flag22)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag23 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag23)
					{
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						text = "Select l from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag24 = sqlDataReader.Read();
						if (flag24)
						{
							string text6 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text6.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows4 = sqlDataReader.HasRows;
							if (hasRows4)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag25 = Conversions.ToDouble(value) == 4.0;
									if (flag25)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag26 = Conversions.ToDouble(value) == 3.0;
									if (flag26)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag27 = Conversions.ToDouble(value) == 1.0;
									if (flag27)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag28 = Conversions.ToDouble(value) == 2.0;
									if (flag28)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag29 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag29)
					{
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text = "Select m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag30 = sqlDataReader.Read();
						if (flag30)
						{
							string text7 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text7.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows5 = sqlDataReader.HasRows;
							if (hasRows5)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag31 = Conversions.ToDouble(value) == 4.0;
									if (flag31)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag32 = Conversions.ToDouble(value) == 3.0;
									if (flag32)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag33 = Conversions.ToDouble(value) == 1.0;
									if (flag33)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag34 = Conversions.ToDouble(value) == 2.0;
									if (flag34)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag35 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag35)
					{
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text = "Select m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag36 = sqlDataReader.Read();
						if (flag36)
						{
							string text7 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text7.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows6 = sqlDataReader.HasRows;
							if (hasRows6)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag37 = Conversions.ToDouble(value) == 4.0;
									if (flag37)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag38 = Conversions.ToDouble(value) == 3.0;
									if (flag38)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag39 = Conversions.ToDouble(value) == 1.0;
									if (flag39)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag40 = Conversions.ToDouble(value) == 2.0;
									if (flag40)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag41 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag41)
					{
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text = "Select m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag42 = sqlDataReader.Read();
						if (flag42)
						{
							string text7 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text7.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows7 = sqlDataReader.HasRows;
							if (hasRows7)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag43 = Conversions.ToDouble(value) == 4.0;
									if (flag43)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag44 = Conversions.ToDouble(value) == 3.0;
									if (flag44)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag45 = Conversions.ToDouble(value) == 1.0;
									if (flag45)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag46 = Conversions.ToDouble(value) == 2.0;
									if (flag46)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag47 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag47)
					{
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						text = "Select m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag48 = sqlDataReader.Read();
						if (flag48)
						{
							string text7 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text7.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows8 = sqlDataReader.HasRows;
							if (hasRows8)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag49 = Conversions.ToDouble(value) == 4.0;
									if (flag49)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag50 = Conversions.ToDouble(value) == 3.0;
									if (flag50)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag51 = Conversions.ToDouble(value) == 1.0;
									if (flag51)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag52 = Conversions.ToDouble(value) == 2.0;
									if (flag52)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag53 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag53)
					{
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						text = "Select m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag54 = sqlDataReader.Read();
						if (flag54)
						{
							string text7 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text7.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows9 = sqlDataReader.HasRows;
							if (hasRows9)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag55 = Conversions.ToDouble(value) == 4.0;
									if (flag55)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag56 = Conversions.ToDouble(value) == 3.0;
									if (flag56)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag57 = Conversions.ToDouble(value) == 1.0;
									if (flag57)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag58 = Conversions.ToDouble(value) == 2.0;
									if (flag58)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag59 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag59)
					{
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						text = "Select m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag60 = sqlDataReader.Read();
						if (flag60)
						{
							string text7 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text7.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows10 = sqlDataReader.HasRows;
							if (hasRows10)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag61 = Conversions.ToDouble(value) == 4.0;
									if (flag61)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag62 = Conversions.ToDouble(value) == 3.0;
									if (flag62)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag63 = Conversions.ToDouble(value) == 1.0;
									if (flag63)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag64 = Conversions.ToDouble(value) == 2.0;
									if (flag64)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag65 = Conversions.ToBoolean(Operators.AndObject(!this.chkEliminaProp.Checked, Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)));
					if (flag65)
					{
						Label lblpropinascortenuevo;
						(lblpropinascortenuevo = this.lblpropinascortenuevo).Text = Conversions.ToString(Operators.SubtractObject(lblpropinascortenuevo.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
						(textBox = this.txttotalnuevopropinas).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
					}
					else
					{
						this.lblpropinascortenuevo.Text = "$ 0.00";
					}
					bool flag66 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Facturado"].Value, "Si", false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)));
					if (flag66)
					{
						(textBox = this.txtVentaFacturada).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, this.PrecioNuevo.ToString())));
					}
				}
				else
				{
					this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value = false;
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.875f, FontStyle.Regular);
					this.dgvNotas.Rows[e.RowIndex].Cells[11].Value = "0";
					TextBox textBox;
					(textBox = this.txtCuentasModificar).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - 1.0);
					string text = "SELECT c from H";
					SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
					bool flag67 = sqlDataReader.Read();
					if (flag67)
					{
						this.PrecioNuevo = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
					}
					double num = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value);
					this.PrecioNuevo -= this.PrecioNuevo / 100.0 * num;
					(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, this.PrecioNuevo.ToString())));
					(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, this.PrecioNuevo.ToString())));
					bool flag68 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false)));
					if (flag68)
					{
						(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, this.PrecioNuevo.ToString())));
						(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, this.PrecioNuevo.ToString())));
					}
					bool flag69 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag69)
					{
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text = "Select i from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag70 = sqlDataReader.Read();
						if (flag70)
						{
							string text2 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text2.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows11 = sqlDataReader.HasRows;
							if (hasRows11)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag71 = Conversions.ToDouble(value) == 4.0;
									if (flag71)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag72 = Conversions.ToDouble(value) == 3.0;
									if (flag72)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag73 = Conversions.ToDouble(value) == 1.0;
									if (flag73)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag74 = Conversions.ToDouble(value) == 2.0;
									if (flag74)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag75 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag75)
					{
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						text = "Select j from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag76 = sqlDataReader.Read();
						if (flag76)
						{
							string text4 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text4.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows12 = sqlDataReader.HasRows;
							if (hasRows12)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag77 = Conversions.ToDouble(value) == 4.0;
									if (flag77)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag78 = Conversions.ToDouble(value) == 3.0;
									if (flag78)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag79 = Conversions.ToDouble(value) == 1.0;
									if (flag79)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag80 = Conversions.ToDouble(value) == 2.0;
									if (flag80)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag81 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag81)
					{
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						text = "Select l from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag82 = sqlDataReader.Read();
						if (flag82)
						{
							string text4 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text4.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows13 = sqlDataReader.HasRows;
							if (hasRows13)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag83 = Conversions.ToDouble(value) == 4.0;
									if (flag83)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag84 = Conversions.ToDouble(value) == 3.0;
									if (flag84)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag85 = Conversions.ToDouble(value) == 1.0;
									if (flag85)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag86 = Conversions.ToDouble(value) == 2.0;
									if (flag86)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag87 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag87)
					{
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						text = "Select k from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag88 = sqlDataReader.Read();
						if (flag88)
						{
							string text5 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text5.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows14 = sqlDataReader.HasRows;
							if (hasRows14)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag89 = Conversions.ToDouble(value) == 4.0;
									if (flag89)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag90 = Conversions.ToDouble(value) == 3.0;
									if (flag90)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag91 = Conversions.ToDouble(value) == 1.0;
									if (flag91)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag92 = Conversions.ToDouble(value) == 2.0;
									if (flag92)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag93 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag93)
					{
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text = "Select m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag94 = sqlDataReader.Read();
						if (flag94)
						{
							string text7 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text7.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows15 = sqlDataReader.HasRows;
							if (hasRows15)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag95 = Conversions.ToDouble(value) == 4.0;
									if (flag95)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag96 = Conversions.ToDouble(value) == 3.0;
									if (flag96)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag97 = Conversions.ToDouble(value) == 1.0;
									if (flag97)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag98 = Conversions.ToDouble(value) == 2.0;
									if (flag98)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag99 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag99)
					{
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text = "Select m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag100 = sqlDataReader.Read();
						if (flag100)
						{
							string text7 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text7.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows16 = sqlDataReader.HasRows;
							if (hasRows16)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag101 = Conversions.ToDouble(value) == 4.0;
									if (flag101)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag102 = Conversions.ToDouble(value) == 3.0;
									if (flag102)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag103 = Conversions.ToDouble(value) == 1.0;
									if (flag103)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag104 = Conversions.ToDouble(value) == 2.0;
									if (flag104)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag105 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag105)
					{
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text = "Select m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag106 = sqlDataReader.Read();
						if (flag106)
						{
							string text7 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text7.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows17 = sqlDataReader.HasRows;
							if (hasRows17)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag107 = Conversions.ToDouble(value) == 4.0;
									if (flag107)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag108 = Conversions.ToDouble(value) == 3.0;
									if (flag108)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag109 = Conversions.ToDouble(value) == 1.0;
									if (flag109)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag110 = Conversions.ToDouble(value) == 2.0;
									if (flag110)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag111 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag111)
					{
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["vales"].Value));
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						text = "Select m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag112 = sqlDataReader.Read();
						if (flag112)
						{
							string text7 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text7.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows18 = sqlDataReader.HasRows;
							if (hasRows18)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag113 = Conversions.ToDouble(value) == 4.0;
									if (flag113)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag114 = Conversions.ToDouble(value) == 3.0;
									if (flag114)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag115 = Conversions.ToDouble(value) == 1.0;
									if (flag115)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag116 = Conversions.ToDouble(value) == 2.0;
									if (flag116)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag117 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag117)
					{
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						text = "Select m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag118 = sqlDataReader.Read();
						if (flag118)
						{
							string text7 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text7.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows19 = sqlDataReader.HasRows;
							if (hasRows19)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag119 = Conversions.ToDouble(value) == 4.0;
									if (flag119)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag120 = Conversions.ToDouble(value) == 3.0;
									if (flag120)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag121 = Conversions.ToDouble(value) == 1.0;
									if (flag121)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag122 = Conversions.ToDouble(value) == 2.0;
									if (flag122)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag123 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag123)
					{
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["vales"].Value));
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						text = "Select m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool flag124 = sqlDataReader.Read();
						if (flag124)
						{
							string text7 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text7.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							bool hasRows20 = sqlDataReader.HasRows;
							if (hasRows20)
							{
								while (sqlDataReader.Read())
								{
									string text3 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag125 = Conversions.ToDouble(value) == 4.0;
									if (flag125)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag126 = Conversions.ToDouble(value) == 3.0;
									if (flag126)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag127 = Conversions.ToDouble(value) == 1.0;
									if (flag127)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
									bool flag128 = Conversions.ToDouble(value) == 2.0;
									if (flag128)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(this.PrecioNuevo.ToString()));
									}
								}
							}
							else
							{
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader.Close();
					}
					bool flag129 = Conversions.ToBoolean(Operators.AndObject(!this.chkEliminaProp.Checked, Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)));
					if (flag129)
					{
						Label lblpropinascortenuevo;
						(lblpropinascortenuevo = this.lblpropinascortenuevo).Text = Conversions.ToString(Operators.AddObject(lblpropinascortenuevo.Text, Operators.NegateObject(this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value)));
						(textBox = this.txttotalnuevopropinas).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
					}
					else
					{
						this.lblpropinascortenuevo.Text = "$ 0.00";
					}
					bool flag130 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Facturado"].Value, "Si", false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)));
					if (flag130)
					{
						(textBox = this.txtVentaFacturada).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, this.PrecioNuevo.ToString())));
					}
				}
				double num2 = Conversions.ToDouble(this.txtdifvales.Text);
				this.txtdifvales.Text = "$ " + num2.ToString("N2");
				double num3 = Conversions.ToDouble(this.txtdifotros.Text);
				this.txtdifotros.Text = "$ " + num3.ToString("N2");
				double num4 = Conversions.ToDouble(this.txtDifTarjeta.Text);
				this.txtDifTarjeta.Text = "$ " + num4.ToString("N2");
				this.lblcortetarjetanuevo.Text = num4.ToString("N2");
				double num5 = Conversions.ToDouble(this.txttotalnuevopropinas.Text);
				this.txttotalnuevopropinas.Text = "$ " + num5.ToString("N2");
				double num6 = Conversions.ToDouble(this.txtVentaFacturada.Text);
				this.txtVentaFacturada.Text = "$ " + num6.ToString("N2");
				double num7 = Conversions.ToDouble(this.txtVentasOtros.Text);
				double num8 = Conversions.ToDouble(this.txtVentaTarjeta.Text);
				double num9 = Conversions.ToDouble(this.txtVales.Text);
				double num10 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
				double num11 = Conversions.ToDouble(this.txtImpNuevo.Text);
				this.txtEfectivoFiscal.Text = "$ " + num10.ToString("N2");
				this.lblcorteefectivonuevo.Text = "$ " + num10.ToString("N2");
				double num12 = Conversions.ToDouble(this.txtDifImporte.Text);
				this.txtVales.Text = "$ " + num9.ToString("N2");
				this.txtVentasOtros.Text = "$ " + num7.ToString("N2");
				this.txtVentaTarjeta.Text = "$ " + num8.ToString("N2");
				this.txtImpNuevo.Text = "$ " + num11.ToString("N2");
				this.txtDifImporte.Text = "$ " + num12.ToString("N2");
				this.txtDifPorcen.Text = "% " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
				double num13 = Conversions.ToDouble(this.txttotalnuevopropinas.Text);
				this.lblpropinascortenuevo.Text = "$ " + num13.ToString("N2");
				num5 = Conversions.ToDouble(this.txttotalnuevopropinas.Text);
				this.txttotalnuevopropinas.Text = "$ " + num5.ToString("N2");
				double num14 = Conversions.ToDouble(this.lblcorteefectivonuevo.Text);
				this.lblcorteefectivonuevo.Text = "$ " + num14.ToString("N2");
				double num15 = Conversions.ToDouble(this.lblcortetarjetanuevo.Text);
				this.lblcortetarjetanuevo.Text = "$ " + num15.ToString("N2");
				double num16 = Conversions.ToDouble(this.lblcortenuevotros.Text);
				this.lblcortenuevotros.Text = "$ " + num16.ToString("N2");
				double num17 = Conversions.ToDouble(this.lblcortenuevovales.Text);
				this.lblcortenuevovales.Text = "$ " + num17.ToString("N2");
				double num18 = Conversions.ToDouble(this.lblcortenuevodepositos.Text);
				double num19 = Conversions.ToDouble(this.lblcortenuevoretiros.Text);
				double num20 = num14 + num15 + num16 + num17 - num5 + num18 - num19;
				double num21 = num14 - num5 - num19 + num18;
				this.lblsaldofinarlcortenuevo.Text = "$ " + num20.ToString("N2");
				double num22 = Conversions.ToDouble(this.txtEfectivoCaja.Text);
				this.txtEfectivoCaja.Text = "$ " + num22.ToString("N2");
				this.lblEfectivonuevocorte.Text = "$ " + num22.ToString("N2");
				double num23 = Conversions.ToDouble(this.txtImpNuevo.Text);
				double num24 = Conversions.ToDouble(this.txtVentaFacturada.Text);
				double num25 = Conversion.Val(num23) - Conversion.Val(num24);
				this.txtventasinfacturar.Text = "$ " + num25.ToString("N2");
				this.txtFacturaPUB.Text = "$ " + num25.ToString("N2");
				this.lblventafacturanew.Text = this.txtVentaFacturada.Text;
				this.lblventasinfacturarnew.Text = this.txtventasinfacturar.Text;
				this.lblfacturapubnew.Text = this.txtFacturaPUB.Text;
			}
			bool flag131 = Conversions.ToDouble(this.txtCuentasModificar.Text) != 0.0;
			if (flag131)
			{
				this.btnAplicar.Enabled = true;
			}
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x000497D1 File Offset: 0x000479D1
		private void dgvNotas_MouseUp(object sender, MouseEventArgs e)
		{
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x000497E0 File Offset: 0x000479E0
		private object validar()
		{
			Regex regex = new Regex("^(\\$)?([1-9]{1}[0-9]{0, 2})(\\,\\ d{3}) * (\\ .\\ d{2})?$|^(\\$)?([1-9]{1}[0-9]{0,2})(\\d{3})*(\\.\\d{2})?$|^(0)?(\\.\\d{2})?$|^(\\$0)?(\\.\\d{2})?$|^(\\$\\.)(\\d{2})?$");
			Regex regex2 = new Regex("^([0-9]+(\\.?[0-9]?[0-9]?)?)");
			bool flag = !regex.IsMatch(this.txtMinimo.Text);
			object result;
			if (flag)
			{
				Interaction.MsgBox("Revise el $ Minimo tiene que ser un valor numerico", MsgBoxStyle.Information, this.Text);
				this.txtMinimo.Focus();
				result = false;
			}
			else
			{
				bool flag2 = !regex.IsMatch(this.txtDescto.Text);
				if (flag2)
				{
					Interaction.MsgBox("Revise el  % Descuento, debe ser un valor numerico menor a 100 con hasta dos decimales", MsgBoxStyle.Information, this.Text);
					this.txtDescto.Focus();
					result = false;
				}
				else
				{
					bool flag3 = Conversions.ToDouble(this.txtDescto.Text) > 100.0;
					if (flag3)
					{
						Interaction.MsgBox("Revise el % Descuento, debe ser un valor menor a 100", MsgBoxStyle.Information, this.Text);
						this.txtDescto.Focus();
						result = false;
					}
					else
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000498E0 File Offset: 0x00047AE0
		private void habilitaControles(bool boolDeasbilita)
		{
			if (boolDeasbilita)
			{
				this.btnVistaPrevia.Text = "Vista Previa";
				this.groupParametros.Enabled = true;
				this.groupPeriodo.Enabled = true;
				this.btnAplicar.Enabled = false;
				this.btnCancelar.Enabled = true;
				this.dateHoraFin.Enabled = false;
				this.dateHoraIni.Enabled = false;
				this.dateFechaIni.Enabled = true;
				this.dateFechaFin.Enabled = true;
				this.cmbxSerie.Enabled = true;
				this.btnVistaPrevia.Enabled = true;
				this.BtnHorario.Visible = true;
				this.Label27.Visible = true;
				this.BtnHorario.Enabled = true;
				this.Button1.Enabled = true;
			}
			else
			{
				this.btnVistaPrevia.Text = "Espere...";
				this.groupParametros.Enabled = false;
				this.ComboBox1.Enabled = false;
				this.dateFechaFin.Enabled = false;
				this.dateFechaIni.Enabled = false;
				this.dateHoraFin.Enabled = false;
				this.dateHoraIni.Enabled = false;
				this.cmbxSerie.Enabled = false;
				this.btnAplicar.Enabled = false;
				this.btnCancelar.Enabled = false;
				this.btnVistaPrevia.Enabled = false;
				this.BtnHorario.Visible = false;
				this.Label27.Visible = false;
				this.BtnHorario.Enabled = false;
				this.Button1.Enabled = false;
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00049A8C File Offset: 0x00047C8C
		public void EnvioMail()
		{
			MailMessage mailMessage = new MailMessage();
			SmtpClient smtpClient = new SmtpClient();
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			this.dateHoraFin.Format = DateTimePickerFormat.Custom;
			this.dateHoraFin.CustomFormat = "hh:mm:ss tt";
			this.dateHoraIni.Format = DateTimePickerFormat.Custom;
			this.dateHoraIni.CustomFormat = "hh:mm:ss tt";
			this.dateFechaIni.Format = DateTimePickerFormat.Custom;
			this.dateFechaIni.CustomFormat = "dd/MM/yyyy";
			this.dateFechaFin.Format = DateTimePickerFormat.Custom;
			this.dateFechaFin.CustomFormat = "dd/MM/yyyy";
			DateTime dateTime = Conversions.ToDate(Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString());
			DateTime dateTime2 = Conversions.ToDate(Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString());
			string query_conn = "SELECT u , v,w,y,z  from H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					string text2 = Tools.Desencriptar(sqlDataReader[1].ToString().Trim());
					string text3 = Tools.Desencriptar(sqlDataReader[2].ToString().Trim());
					string text4 = Conversions.ToString(sqlDataReader[3]);
					string text5 = Tools.Desencriptar(sqlDataReader[4].ToString().Trim());
					mailMessage.From = new MailAddress(text3.ToString(), "Modulo de Proyeccion", Encoding.UTF8);
					mailMessage.To.Add(text5.ToString());
					mailMessage.SubjectEncoding = Encoding.UTF8;
					mailMessage.Subject = "Evento Realizado";
					mailMessage.Body = string.Concat(new string[]
					{
						" <!DOCTYPE html><html xmlns='http://www.w3.org/1999/xhtml'><head>    <title>Alerta de Proceso Realizado</title></head><body style='margin-left: 10px ;font-family: sans-serif;'>\r\n    <div style='border-width: 5px;border-image: initial;background-color: #BFCDDB ; margin-bottom: 5px; border: 1px solid;\r\n                border-color: black;display: grid;grid-template-columns:90% 10%'>\r\n            <div style='justify-content: flex-end;'><h3 style='font-weight: 700;margin-left:3px; margin-top:5px ;'>EVENTO REGISTRADO</h3></div> \r\n            <div style='justify-content: flex-start;'><img style='max-width: 40px; max-height: 40px;margin-top: -1px;' src='https://i.postimg.cc/qBwdQXT5/logolobo.png' alt='logo'></div>  \r\n    </div>\r\n\r\n               \r\n    <div style='font-size 10px'>\r\n        Fecha y hora: ",
						this.lblfechayhora.Text,
						" <br>\r\n        Proceso : ",
						this.cmbxTipo.Text,
						"<br>\r\n        Usuario : ",
						MyProject.Forms.main.lblNombreUsuario.Text,
						"<br>\r\n    </div>\r\n    <div  style='border-width: 5px;border-image: initial;background-color: #BFCDDB ; margin-bottom: 5px; border: 1px solid;\r\n                border-color: black;'>\r\n        <h5 style='font-weight: 700;margin: 5px 0 5px 0;'>VENTAS</h5>\r\n    </div>\r\n        <div style='font-size 10px;'>\r\n            Periodo Inicial : ",
						dateTime.ToString(),
						" <br>\r\n            Periodo Final : ",
						dateTime2.ToString(),
						"<br>\r\n            Cuentas Total: ",
						this.txtCuentasTotal.Text,
						"<br>\r\n            Cuentas Modificadas : ",
						this.txtCuentasModificar.Text,
						"<br>          \r\n            Venta Anterior : ",
						this.txtImpAnterior.Text,
						"<br>\r\n            Venta Nueva : ",
						this.txtImpNuevo.Text,
						"<br>\r\n            Diferencia : ",
						this.txtDifImporte.Text,
						"<br>  \r\n            Dif.: ",
						this.txtDifPorcen.Text,
						"<br>\r\n        </div>\r\n    <div  style='border-width: 5px;border-image: initial;background-color: #BFCDDB ; margin-bottom: 5px; border: 1px solid;\r\n                border-color: black'>\r\n        <h5 style='font-weight: 700;margin: 5px 0 5px 0'>FORMAS DE PAGO</h5>\r\n    </div>\r\n        <div style='font-size 10px;' >   \r\n            Efectivo Anterior : ",
						this.txtEfectivoAnt.Text,
						"<br>\r\n            Efectivo Nuevo : ",
						this.txtEfectivoFiscal.Text,
						"<br>\r\n            Efectivo en Caja : ",
						this.txtEfectivoCaja.Text,
						"<br>\r\n            Tarjeta Anterior : ",
						this.txtVentaTarjeta.Text,
						"<br>\r\n            Tarjeta Nuevo : ",
						this.txtDifTarjeta.Text,
						"<br>\r\n            Vales Anterior : ",
						this.txtVales.Text,
						"<br>\r\n            Vales Nuevo : ",
						this.txtdifvales.Text,
						"<br>\r\n            Otros Anterior : ",
						this.txtVentasOtros.Text,
						"<br>\r\n            Otros Nuevo : ",
						this.txtdifotros.Text,
						"<br>\r\n        </div>\r\n</body>\r\n<footer>\r\n    <div  style='display: flex; justify-content: center; align-items:center; margin-top: 40px;flex-direction: column;font-size: 10px;'>\r\n        <div> Alerta Generada por Módulo Adicional 2020 ® - GordoloboSoft</div>\r\n        <div>Favor de no responder a este correo</div>\r\n    </div>\r\n      \r\n</footer>\r\n</html>"
					});
					mailMessage.BodyEncoding = Encoding.UTF8;
					mailMessage.IsBodyHtml = true;
					mailMessage.Priority = MailPriority.High;
					smtpClient.Credentials = new NetworkCredential(text3.ToString(), Tools.Desencriptar(text4.ToString()));
					smtpClient.Port = Conversions.ToInteger(text2.ToString());
					smtpClient.Host = text.ToString();
					smtpClient.EnableSsl = true;
					try
					{
						smtpClient.Send(mailMessage);
					}
					catch (Exception ex)
					{
						Interaction.MsgBox("No pudimos conectarnos con el servidor emisor,revisa la configuracion.\r\nel proceso continuara!", MsgBoxStyle.OkOnly, null);
					}
				}
			}
			sqlDataReader.Close();
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00049F28 File Offset: 0x00048128
		private void btnAplicar_Click(object sender, EventArgs e)
		{
			string text = this.cmbxSerie.Text;
			SqlQuery sqlQuery = new SqlQuery();
			this.lblfechayhora.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
			SqlQuery sqlQuery2 = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			object obj = "SE MODIFICARAN LOS FOLIOS SELECCIONADOS, Deseas continuar?";
			object value = 276;
			object obj2 = "ATENCIÓN!!!";
			object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
			bool flag = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
			if (flag)
			{
				this.COdigoUnicoCOrteGenerar();
				string query_conn = "Select ab from H";
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
				bool hasRows = sqlDataReader.HasRows;
				if (hasRows)
				{
					while (sqlDataReader.Read())
					{
						string left2 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
						bool flag2 = Operators.CompareString(left2, "1", false) == 0;
						if (flag2)
						{
							this.EnvioMail();
						}
					}
					sqlDataReader.Close();
				}
				this.progBar.Value = 10;
				this.habilitaControles(false);
				string text2 = "";
				double num = 0.0;
				SqlQuery sqlQuery3 = new SqlQuery();
				SqlQuery sqlQuery4 = new SqlQuery();
				SqlQuery sqlQuery5 = new SqlQuery();
				List<string> list = new List<string>();
				string text3 = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
				string text4 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
				string text5 = string.Concat(new string[]
				{
					"select distinct (idturno) from turnos where apertura between '",
					text3,
					"' and '",
					text4,
					"' and cierre is not null"
				});
				SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
				bool hasRows2 = sqlDataReader2.HasRows;
				if (hasRows2)
				{
					while (sqlDataReader2.Read())
					{
						list.Add(Conversions.ToString(sqlDataReader2[0]));
					}
					sqlDataReader2.Close();
				}
				text5 = string.Concat(new string[]
				{
					"Select count(*) from turnos where apertura between '",
					text3,
					"' and '",
					text4,
					"' and cierre is not null"
				});
				sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
				bool hasRows3 = sqlDataReader2.HasRows;
				if (hasRows3)
				{
					sqlDataReader2.Read();
					this.progBar.Value = 15;
				}
				sqlDataReader2.Close();
				try
				{
				}
				catch (Exception ex)
				{
				}
				try
				{
					foreach (string text6 in list)
					{
						this.progBar.Value = 18;
						string query_conn2 = "Select g from h";
						SqlDataReader sqlDataReader3 = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn2);
						bool hasRows4 = sqlDataReader3.HasRows;
						if (hasRows4)
						{
							while (sqlDataReader3.Read())
							{
								bool flag3 = Operators.CompareString(Tools.Desencriptar(sqlDataReader3[0].ToString().Trim()), "1", false) == 0;
								if (flag3)
								{
									text5 = "select apertura from turnos where idturno = '" + text6 + "'";
									sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
									bool hasRows5 = sqlDataReader2.HasRows;
									DateTime dateTime;
									if (hasRows5)
									{
										while (sqlDataReader2.Read())
										{
											dateTime = Conversions.ToDate(sqlDataReader2[0]);
										}
									}
									sqlDataReader2.Close();
									text5 = "Select m from K where m = '" + dateTime.ToString(Tools.strFormatoFechaLargo) + "' ";
									SqlDataReader sqlDataReader4 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
									bool hasRows6 = sqlDataReader4.HasRows;
									if (!hasRows6)
									{
										text5 = string.Concat(new string[]
										{
											"Select ISNULL(SUM(totalalimentossindescuentos),0) as alimentos,ISNULL(SUM(totalbebidassindescuentos),0) as bebidas, ISNULL(SUM(totalotrossindescuentos),0) as otros, \r\n                                    ISNULL(SUM(totalcortesias),0) as cortesias,ISNULL(SUM(totaldescuentos),0) as descuentos, ISNULL(SUM(subtotal),0) as subtotal, ISNULL(SUM(totalimpuesto1),0) as iva, \r\n                                    ISNULL(SUM(total),0) as total, ISNULL(SUM(propina),0) as propina, ISNULL(SUM(total+propina),0) as totalconpropina,\r\n                                    ISNULL(SUM(nopersonas),0) as nopersonas,COUNT(folio) as cuentas , '",
											dateTime.ToString(Tools.strFormatoFechaLargo),
											"' from cheques where  idturno = '",
											text6,
											"' AND cierre is not null  and cancelado=0"
										});
										sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
										bool hasRows7 = sqlDataReader2.HasRows;
										if (hasRows7)
										{
											while (sqlDataReader2.Read())
											{
												this.progBar.Value = 19;
												string text7 = Conversions.ToString(sqlDataReader2[0]);
												string text8 = Conversions.ToString(sqlDataReader2[1]);
												string text9 = Conversions.ToString(sqlDataReader2[2]);
												string text10 = Conversions.ToString(sqlDataReader2[3]);
												string text11 = Conversions.ToString(sqlDataReader2[4]);
												string text12 = Conversions.ToString(sqlDataReader2[5]);
												string text13 = Conversions.ToString(sqlDataReader2[6]);
												string text14 = Conversions.ToString(sqlDataReader2[7]);
												string text15 = Conversions.ToString(sqlDataReader2[8]);
												string text16 = Conversions.ToString(sqlDataReader2[9]);
												string text17 = Conversions.ToString(sqlDataReader2[10]);
												string text18 = Conversions.ToString(sqlDataReader2[11]);
												text5 = string.Concat(new string[]
												{
													"Insert into ",
													Tools.BaseDatos_Modulo,
													".dbo.K (a,b,c,d,e,f,g,h,i,j,k,l,m)\r\n\r\n                                                    Values ('",
													Tools.Encriptar(text7.ToString().Trim()),
													"',\r\n                                                            '",
													Tools.Encriptar(text8.ToString().Trim()),
													"',\r\n                                                            '",
													Tools.Encriptar(text9.ToString().Trim()),
													"',\r\n                                                            '",
													Tools.Encriptar(text10.ToString().Trim()),
													"',\r\n                                                            '",
													Tools.Encriptar(text11.ToString().Trim()),
													"',\r\n                                                            '",
													Tools.Encriptar(text12.ToString().Trim()),
													"',\r\n                                                            '",
													Tools.Encriptar(text13.ToString().Trim()),
													"',\r\n                                                            '",
													Tools.Encriptar(text14.ToString().Trim()),
													"',\r\n                                                            '",
													Tools.Encriptar(text15.ToString().Trim()),
													"',                                        \r\n                                                            '",
													Tools.Encriptar(text16.ToString().Trim()),
													"',\r\n                                                            '",
													Tools.Encriptar(text17.ToString().Trim()),
													"',\r\n                                                            '",
													Tools.Encriptar(text18.ToString().Trim()),
													"',\r\n                                                            '",
													dateTime.ToString(Tools.strFormatoFechaLargo),
													"')"
												});
												sqlQuery5.execQuery(text5);
											}
											text5 = "   Select a.idproducto ,b.descripcion, a.precio,a.cantidad,a.hora  from cheqdet A\r\n                                                         Inner JOIN productos B on b.idproducto = a.idproducto where a.foliodet in  (select folio from cheques where idturno = '" + text6 + "' AND cierre is not null  and cancelado=0)";
											sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
											bool hasRows8 = sqlDataReader2.HasRows;
											if (hasRows8)
											{
												while (sqlDataReader2.Read())
												{
													string text19 = Conversions.ToString(sqlDataReader2[0]);
													string text20 = Conversions.ToString(sqlDataReader2[1]);
													string text21 = Conversions.ToString(sqlDataReader2[2]);
													string text22 = Conversions.ToString(sqlDataReader2[3]);
													DateTime dateTime2 = Conversions.ToDate(sqlDataReader2[4]);
													text5 = string.Concat(new string[]
													{
														"Insert into ",
														Tools.BaseDatos_Modulo,
														".dbo.J (a,b,c,d,e)\r\n                                                        Values ('",
														Tools.Encriptar(text19.ToString().Trim()),
														"',\r\n                                                                '",
														Tools.Encriptar(text20.ToString().Trim()),
														"',\r\n                                                                '",
														Tools.Encriptar(text21.ToString().Trim()),
														"',\r\n                                                                '",
														Tools.Encriptar(text22.ToString().Trim()),
														"',\r\n                                                                '",
														dateTime2.ToString(Tools.strFormatoFechaLargo),
														"')"
													});
													sqlQuery5.execQuery(text5);
													this.progBar.Value = 20;
												}
											}
										}
										sqlDataReader2.Close();
									}
									sqlDataReader4.Close();
								}
							}
							sqlDataReader3.Close();
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (object obj3 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj3;
						bool flag4 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(dataGridViewRow.Cells["Propina"].Value, 0, false)));
						if (flag4)
						{
							string text23 = Conversions.ToString(dataGridViewRow.Cells["Folio Cuenta"].Value);
							string text24 = Conversions.ToString(dataGridViewRow.Cells["Folio Propina"].Value);
							string text25 = Conversions.ToString(dataGridViewRow.Cells["Serie"].Value);
							bool flag5 = Operators.CompareString(text, "Todas", false) != 0;
							if (flag5)
							{
								text5 = string.Concat(new string[]
								{
									"Update movtoscaja Set importe = importe - (Select propina from cheques where numcheque ='",
									text23.ToString(),
									"' and seriefolio = '",
									text,
									"') where folio=  '",
									text24,
									"'"
								});
								sqlQuery4.execQuery(text5);
								text5 = string.Concat(new string[]
								{
									"update cheques set propina=0 , propinafoliomovtocaja =0 where numcheque='",
									text23.ToString(),
									"' and seriefolio = '",
									text,
									"'"
								});
								sqlQuery4.execQuery(text5);
							}
							bool flag6 = Operators.CompareString(text, "Todas", false) == 0;
							if (flag6)
							{
								text5 = string.Concat(new string[]
								{
									"Update movtoscaja Set importe = importe - (Select propina from cheques where numcheque ='",
									text23.ToString(),
									"' and seriefolio='",
									text25,
									"') where folio=  '",
									text24,
									"'"
								});
								sqlQuery4.execQuery(text5);
								text5 = "update cheques set propina=0 , propinafoliomovtocaja =0 where numcheque='" + text23.ToString() + "'";
								sqlQuery4.execQuery(text5);
							}
						}
						this.progBar.Value = 25;
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				List<string> list2 = new List<string>();
				try
				{
					foreach (object obj4 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj4;
						bool flag7 = Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false);
						if (flag7)
						{
							text2 = Conversions.ToString(Operators.AddObject(text2, dataGridViewRow2.Cells["id_nota"].Value));
							text2 += ",";
						}
					}
				}
				finally
				{
					IEnumerator enumerator3;
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				text2 = text2.Remove(checked(text2.Length - 1), 1);
				this.progBar.Value = 30;
				try
				{
					foreach (object obj5 in ((IEnumerable)this.dgvNotas.Rows))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj5);
						bool flag8 = Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
						{
							"Eliminar"
						}, null, null, null), null, "Value", new object[0], null, null, null), true, false);
						if (flag8)
						{
							string text26 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"id_nota"
							}, null, null, null), null, "Value", new object[0], null, null, null));
							DateTime dateTime3 = Conversions.ToDate(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Fecha"
							}, null, null, null), null, "Value", new object[0], null, null, null));
							double num2 = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Descto %"
							}, null, null, null), null, "Value", new object[0], null, null, null));
							double num3 = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Total con Prod. Eliminados"
							}, null, null, null), null, "Value", new object[0], null, null, null));
							text5 = " delete from chequespagos where folio = '" + text26 + "'";
							sqlQuery5.execQuery(text5);
							text5 = "delete from cheqdet where foliodet = '" + text26 + "'";
							sqlQuery5.execQuery(text5);
							bool flag9 = Operators.CompareString(text, "Todas", false) != 0;
							if (flag9)
							{
								text5 = string.Concat(new string[]
								{
									"update cheques Set nopersonas =1 , cambio=0 , totalarticulos=1 where folio = '",
									text26,
									"' and seriefolio = '",
									text,
									"'"
								});
								sqlQuery5.execQuery(text5);
							}
							bool flag10 = Operators.CompareString(text, "Todas", false) == 0;
							if (flag10)
							{
								text5 = "update cheques Set nopersonas =1 , cambio=0 , totalarticulos=1 where folio = '" + text26 + "'";
								sqlQuery5.execQuery(text5);
							}
							this.progBar.Value = 40;
							SqlQuery sqlQuery6 = new SqlQuery();
							bool flag11 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Eliminar"
							}, null, null, null), null, "Value", new object[0], null, null, null), true, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Otros"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Efectivo"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Vales"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Tarjeta"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)));
							if (flag11)
							{
								text5 = "Select i from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
								bool flag12 = sqlDataReader2.Read();
								if (flag12)
								{
									string text27 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query = "select idformadepago , tipo from formasdepago where idformadepago = '" + text27.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery5.execReader(query);
									bool hasRows9 = sqlDataReader5.HasRows;
									if (hasRows9)
									{
										while (sqlDataReader5.Read())
										{
											string text28 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text28.ToString(),
													"','",
													this.PrecioNuevo.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery5.execQuery(text5);
												bool flag13 = Operators.CompareString(text, "Todas", false) == 0;
												if (flag13)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery5.execQuery(text5);
												}
												bool flag14 = Operators.CompareString(text, "Todas", false) != 0;
												if (flag14)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text,
														"'"
													});
													sqlQuery5.execQuery(text5);
												}
												bool flag15 = Conversions.ToDouble(value2) == 4.0;
												if (flag15)
												{
													bool flag16 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag16)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag17 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag17)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag18 = Conversions.ToDouble(value2) == 3.0;
												if (flag18)
												{
													bool flag19 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag19)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag20 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag20)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag21 = Conversions.ToDouble(value2) == 1.0;
												if (flag21)
												{
													bool flag22 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag22)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag23 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag23)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag24 = Conversions.ToDouble(value2) == 2.0;
												if (flag24)
												{
													bool flag25 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag25)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag26 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag26)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
											}
											catch (Exception ex2)
											{
											}
										}
									}
									sqlDataReader5.Close();
								}
								sqlDataReader2.Close();
							}
							bool flag27 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Eliminar"
							}, null, null, null), null, "Value", new object[0], null, null, null), true, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Otros"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Efectivo"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Vales"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Tarjeta"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)));
							if (flag27)
							{
								text5 = "Select j from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
								bool flag28 = sqlDataReader2.Read();
								if (flag28)
								{
									string text29 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query = "select idformadepago , tipo from formasdepago where idformadepago = '" + text29.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery5.execReader(query);
									bool hasRows10 = sqlDataReader5.HasRows;
									if (hasRows10)
									{
										while (sqlDataReader5.Read())
										{
											string text28 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text28.ToString(),
													"','",
													this.PrecioNuevo.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery5.execQuery(text5);
												bool flag29 = Operators.CompareString(text, "Todas", false) == 0;
												if (flag29)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery5.execQuery(text5);
												}
												bool flag30 = Operators.CompareString(text, "Todas", false) != 0;
												if (flag30)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text,
														"'"
													});
													sqlQuery5.execQuery(text5);
												}
												bool flag31 = Conversions.ToDouble(value2) == 4.0;
												if (flag31)
												{
													bool flag32 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag32)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag33 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag33)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag34 = Conversions.ToDouble(value2) == 3.0;
												if (flag34)
												{
													bool flag35 = Operators.CompareString(text, "Todas ", false) == 0;
													if (flag35)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag36 = Operators.CompareString(text, "Todas ", false) != 0;
													if (flag36)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag37 = Conversions.ToDouble(value2) == 1.0;
												if (flag37)
												{
													bool flag38 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag38)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag39 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag39)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag40 = Conversions.ToDouble(value2) == 2.0;
												if (flag40)
												{
													bool flag41 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag41)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag42 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag42)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
											}
											catch (Exception ex3)
											{
											}
										}
									}
									sqlDataReader5.Close();
								}
								sqlDataReader2.Close();
							}
							bool flag43 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Eliminar"
							}, null, null, null), null, "Value", new object[0], null, null, null), true, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Otros"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Efectivo"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Vales"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Tarjeta"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)));
							if (flag43)
							{
								text5 = "Select k from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
								bool flag44 = sqlDataReader2.Read();
								if (flag44)
								{
									string text30 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query = "select idformadepago , tipo from formasdepago where idformadepago = '" + text30.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery5.execReader(query);
									bool hasRows11 = sqlDataReader5.HasRows;
									if (hasRows11)
									{
										while (sqlDataReader5.Read())
										{
											string text28 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text28.ToString(),
													"','",
													this.PrecioNuevo.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery5.execQuery(text5);
												bool flag45 = Operators.CompareString(text, "Todas", false) == 0;
												if (flag45)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery5.execQuery(text5);
												}
												bool flag46 = Operators.CompareString(text, "Todas", false) != 0;
												if (flag46)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text,
														"'"
													});
													sqlQuery5.execQuery(text5);
												}
												bool flag47 = Conversions.ToDouble(value2) == 4.0;
												if (flag47)
												{
													bool flag48 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag48)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag49 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag49)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag50 = Conversions.ToDouble(value2) == 3.0;
												if (flag50)
												{
													bool flag51 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag51)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag52 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag52)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag53 = Conversions.ToDouble(value2) == 1.0;
												if (flag53)
												{
													bool flag54 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag54)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag55 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag55)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag56 = Conversions.ToDouble(value2) == 2.0;
												if (flag56)
												{
													bool flag57 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag57)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag58 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag58)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
											}
											catch (Exception ex4)
											{
											}
										}
									}
									sqlDataReader5.Close();
								}
								sqlDataReader2.Close();
							}
							bool flag59 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Eliminar"
							}, null, null, null), null, "Value", new object[0], null, null, null), true, false), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Otros"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Efectivo"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Vales"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Tarjeta"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)));
							if (flag59)
							{
								text5 = "Select l from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
								bool flag60 = sqlDataReader2.Read();
								if (flag60)
								{
									string text31 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query = "select idformadepago , tipo from formasdepago where idformadepago = '" + text31.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery5.execReader(query);
									bool hasRows12 = sqlDataReader5.HasRows;
									if (hasRows12)
									{
										while (sqlDataReader5.Read())
										{
											string text28 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text28.ToString(),
													"','",
													this.PrecioNuevo.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery5.execQuery(text5);
												bool flag61 = Operators.CompareString(text, "Todas", false) == 0;
												if (flag61)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery5.execQuery(text5);
												}
												bool flag62 = Operators.CompareString(text, "Todas", false) != 0;
												if (flag62)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text,
														"'"
													});
													sqlQuery5.execQuery(text5);
												}
												bool flag63 = Conversions.ToDouble(value2) == 4.0;
												if (flag63)
												{
													bool flag64 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag64)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag65 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag65)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag66 = Conversions.ToDouble(value2) == 3.0;
												if (flag66)
												{
													bool flag67 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag67)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag68 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag68)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag69 = Conversions.ToDouble(value2) == 1.0;
												if (flag69)
												{
													bool flag70 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag70)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag71 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag71)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag72 = Conversions.ToDouble(value2) == 2.0;
												if (flag72)
												{
													bool flag73 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag73)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag74 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag74)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
											}
											catch (Exception ex5)
											{
											}
										}
									}
									sqlDataReader5.Close();
								}
								sqlDataReader2.Close();
							}
							bool flag75 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Eliminar"
							}, null, null, null), null, "Value", new object[0], null, null, null), true, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Otros"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Efectivo"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Vales"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Tarjeta"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)));
							if (flag75)
							{
								text5 = "Select m from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
								bool flag76 = sqlDataReader2.Read();
								if (flag76)
								{
									string text32 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query = "select idformadepago , tipo from formasdepago where idformadepago = '" + text32.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery5.execReader(query);
									bool hasRows13 = sqlDataReader5.HasRows;
									if (hasRows13)
									{
										while (sqlDataReader5.Read())
										{
											string text28 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text28.ToString(),
													"','",
													this.PrecioNuevo.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery5.execQuery(text5);
												bool flag77 = Operators.CompareString(text, "Todas", false) == 0;
												if (flag77)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery5.execQuery(text5);
												}
												bool flag78 = Operators.CompareString(text, "Todas", false) != 0;
												if (flag78)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text,
														"'"
													});
													sqlQuery5.execQuery(text5);
												}
												bool flag79 = Conversions.ToDouble(value2) == 4.0;
												if (flag79)
												{
													bool flag80 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag80)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag81 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag81)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag82 = Conversions.ToDouble(value2) == 3.0;
												if (flag82)
												{
													bool flag83 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag83)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag84 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag84)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag85 = Conversions.ToDouble(value2) == 1.0;
												if (flag85)
												{
													bool flag86 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag86)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag87 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag87)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag88 = Conversions.ToDouble(value2) == 2.0;
												if (flag88)
												{
													bool flag89 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag89)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag90 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag90)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
											}
											catch (Exception ex6)
											{
											}
										}
									}
									sqlDataReader5.Close();
								}
								sqlDataReader2.Close();
							}
							bool flag91 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Eliminar"
							}, null, null, null), null, "Value", new object[0], null, null, null), true, false), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Otros"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Efectivo"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Vales"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Tarjeta"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)));
							if (flag91)
							{
								text5 = "Select m from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
								bool flag92 = sqlDataReader2.Read();
								if (flag92)
								{
									string text32 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query = "select idformadepago , tipo from formasdepago where idformadepago = '" + text32.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery5.execReader(query);
									bool hasRows14 = sqlDataReader5.HasRows;
									if (hasRows14)
									{
										while (sqlDataReader5.Read())
										{
											string text28 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text28.ToString(),
													"','",
													this.PrecioNuevo.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery5.execQuery(text5);
												bool flag93 = Operators.CompareString(text, "Todas", false) == 0;
												if (flag93)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery5.execQuery(text5);
												}
												bool flag94 = Operators.CompareString(text, "Todas", false) != 0;
												if (flag94)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text,
														"'"
													});
													sqlQuery5.execQuery(text5);
												}
												bool flag95 = Conversions.ToDouble(value2) == 4.0;
												if (flag95)
												{
													bool flag96 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag96)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag97 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag97)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag98 = Conversions.ToDouble(value2) == 3.0;
												if (flag98)
												{
													bool flag99 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag99)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag100 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag100)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag101 = Conversions.ToDouble(value2) == 1.0;
												if (flag101)
												{
													bool flag102 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag102)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag103 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag103)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag104 = Conversions.ToDouble(value2) == 2.0;
												if (flag104)
												{
													bool flag105 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag105)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag106 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag106)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
											}
											catch (Exception ex7)
											{
											}
										}
									}
									sqlDataReader5.Close();
								}
								sqlDataReader2.Close();
							}
							bool flag107 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Eliminar"
							}, null, null, null), null, "Value", new object[0], null, null, null), true, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Otros"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Efectivo"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Vales"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Tarjeta"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)));
							if (flag107)
							{
								text5 = "Select m from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
								bool flag108 = sqlDataReader2.Read();
								if (flag108)
								{
									string text32 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query = "select idformadepago , tipo from formasdepago where idformadepago = '" + text32.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery5.execReader(query);
									bool hasRows15 = sqlDataReader5.HasRows;
									if (hasRows15)
									{
										while (sqlDataReader5.Read())
										{
											string text28 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text28.ToString(),
													"','",
													this.PrecioNuevo.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery5.execQuery(text5);
												bool flag109 = Operators.CompareString(text, "Todas", false) == 0;
												if (flag109)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery5.execQuery(text5);
												}
												bool flag110 = Operators.CompareString(text, "Todas", false) != 0;
												if (flag110)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text,
														"'"
													});
													sqlQuery5.execQuery(text5);
												}
												bool flag111 = Conversions.ToDouble(value2) == 4.0;
												if (flag111)
												{
													bool flag112 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag112)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag113 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag113)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag114 = Conversions.ToDouble(value2) == 3.0;
												if (flag114)
												{
													bool flag115 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag115)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag116 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag116)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag117 = Conversions.ToDouble(value2) == 1.0;
												if (flag117)
												{
													bool flag118 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag118)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag119 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag119)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag120 = Conversions.ToDouble(value2) == 2.0;
												if (flag120)
												{
													bool flag121 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag121)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag122 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag122)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
											}
											catch (Exception ex8)
											{
											}
										}
									}
									sqlDataReader5.Close();
								}
								sqlDataReader2.Close();
							}
							bool flag123 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Eliminar"
							}, null, null, null), null, "Value", new object[0], null, null, null), true, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Otros"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Efectivo"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Vales"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Tarjeta"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)));
							if (flag123)
							{
								text5 = "Select m from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
								bool flag124 = sqlDataReader2.Read();
								if (flag124)
								{
									string text32 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query = "select idformadepago , tipo from formasdepago where idformadepago = '" + text32.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery5.execReader(query);
									bool hasRows16 = sqlDataReader5.HasRows;
									if (hasRows16)
									{
										while (sqlDataReader5.Read())
										{
											string text28 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text28.ToString(),
													"','",
													this.PrecioNuevo.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery5.execQuery(text5);
												bool flag125 = Operators.CompareString(text, "Todas", false) == 0;
												if (flag125)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery5.execQuery(text5);
												}
												bool flag126 = Operators.CompareString(text, "Todas", false) != 0;
												if (flag126)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text,
														"'"
													});
													sqlQuery5.execQuery(text5);
												}
												bool flag127 = Conversions.ToDouble(value2) == 4.0;
												if (flag127)
												{
													bool flag128 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag128)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag129 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag129)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag130 = Conversions.ToDouble(value2) == 3.0;
												if (flag130)
												{
													bool flag131 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag131)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag132 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag132)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag133 = Conversions.ToDouble(value2) == 1.0;
												if (flag133)
												{
													bool flag134 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag134)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag135 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag135)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag136 = Conversions.ToDouble(value2) == 2.0;
												if (flag136)
												{
													bool flag137 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag137)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag138 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag138)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
											}
											catch (Exception ex9)
											{
											}
										}
									}
									sqlDataReader5.Close();
								}
								sqlDataReader2.Close();
							}
							bool flag139 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Eliminar"
							}, null, null, null), null, "Value", new object[0], null, null, null), true, false), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Otros"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Efectivo"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Vales"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Tarjeta"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)));
							if (flag139)
							{
								text5 = "Select m from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
								bool flag140 = sqlDataReader2.Read();
								if (flag140)
								{
									string text32 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query = "select idformadepago , tipo from formasdepago where idformadepago = '" + text32.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery5.execReader(query);
									bool hasRows17 = sqlDataReader5.HasRows;
									if (hasRows17)
									{
										while (sqlDataReader5.Read())
										{
											string text28 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text28.ToString(),
													"','",
													this.PrecioNuevo.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery5.execQuery(text5);
												bool flag141 = Operators.CompareString(text, "Todas", false) == 0;
												if (flag141)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery5.execQuery(text5);
												}
												bool flag142 = Operators.CompareString(text, "Todas", false) != 0;
												if (flag142)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text,
														"'"
													});
													sqlQuery5.execQuery(text5);
												}
												bool flag143 = Conversions.ToDouble(value2) == 4.0;
												if (flag143)
												{
													bool flag144 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag144)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag145 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag145)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag146 = Conversions.ToDouble(value2) == 3.0;
												if (flag146)
												{
													bool flag147 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag147)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag148 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag148)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag149 = Conversions.ToDouble(value2) == 1.0;
												if (flag149)
												{
													bool flag150 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag150)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag151 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag151)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag152 = Conversions.ToDouble(value2) == 2.0;
												if (flag152)
												{
													bool flag153 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag153)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag154 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag154)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
											}
											catch (Exception ex10)
											{
											}
										}
									}
									sqlDataReader5.Close();
								}
								sqlDataReader2.Close();
							}
							this.progBar.Value = 60;
							bool flag155 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Eliminar"
							}, null, null, null), null, "Value", new object[0], null, null, null), true, false), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Otros"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Efectivo"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Vales"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								"Tarjeta"
							}, null, null, null), null, "value", new object[0], null, null, null), 0, false)));
							if (flag155)
							{
								text5 = "Select m from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
								bool flag156 = sqlDataReader2.Read();
								if (flag156)
								{
									string text32 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query = "select idformadepago , tipo from formasdepago where idformadepago = '" + text32.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery5.execReader(query);
									bool hasRows18 = sqlDataReader5.HasRows;
									if (hasRows18)
									{
										while (sqlDataReader5.Read())
										{
											string text28 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text28.ToString(),
													"','",
													this.PrecioNuevo.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery5.execQuery(text5);
												bool flag157 = Operators.CompareString(text, "Todas", false) == 0;
												if (flag157)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery5.execQuery(text5);
												}
												bool flag158 = Operators.CompareString(text, "Todas", false) != 0;
												if (flag158)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text,
														"'"
													});
													sqlQuery5.execQuery(text5);
												}
												bool flag159 = Conversions.ToDouble(value2) == 4.0;
												if (flag159)
												{
													bool flag160 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag160)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag161 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag161)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag162 = Conversions.ToDouble(value2) == 3.0;
												if (flag162)
												{
													bool flag163 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag163)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag164 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag164)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag165 = Conversions.ToDouble(value2) == 1.0;
												if (flag165)
												{
													bool flag166 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag166)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag167 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag167)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
												bool flag168 = Conversions.ToDouble(value2) == 2.0;
												if (flag168)
												{
													bool flag169 = Operators.CompareString(text, "Todas", false) == 0;
													if (flag169)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													bool flag170 = Operators.CompareString(text, "Todas", false) != 0;
													if (flag170)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															this.PrecioNuevo.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
												}
											}
											catch (Exception ex11)
											{
											}
										}
									}
									sqlDataReader5.Close();
								}
								sqlDataReader2.Close();
							}
							try
							{
								text5 = "Select fecha , estacion from cheques where folio = " + text26 + " ";
								sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
								bool hasRows19 = sqlDataReader2.HasRows;
								if (hasRows19)
								{
									sqlDataReader2.Read();
									this.fechaProducto = Conversions.ToDate(sqlDataReader2[0]);
									this.Estacion1 = Conversions.ToString(sqlDataReader2[1]);
								}
								text5 = "Select a , c , d ,e  from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
								bool hasRows20 = sqlDataReader2.HasRows;
								if (hasRows20)
								{
									while (sqlDataReader2.Read())
									{
										string text33 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
										double num4 = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader2[1].ToString().Trim()));
										double num5 = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader2[2].ToString().Trim()));
										double num6 = Conversions.ToDouble(Tools.Desencriptar(sqlDataReader2[3].ToString().Trim()));
										double num7 = num4 - num5;
										text5 = "SELECT impuesto1 from productosdetalle where idproducto='" + text33.ToString() + "'";
										sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
										bool flag171 = sqlDataReader2.Read();
										if (flag171)
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = num4 - num5 / 100.0 * num8;
											text5 = string.Concat(new string[]
											{
												"insert into cheqdet (\r\n                                Foliodet,\r\n                                movimiento,\r\n                                comanda,\r\n                                cantidad,\r\n                                idproducto,\r\n                                descuento,\r\n                                precio,\r\n                                impuesto1,\r\n                                impuesto2,\r\n                                impuesto3,\r\n                                preciosinimpuestos,\r\n                                tiempo,\r\n                                hora,\r\n                                modificador,\r\n                                mitad,\r\n                                comentario,\r\n                                idestacion,\r\n                                usuariodescuento,\r\n                                comentariodescuento,\r\n                                idtipodescuento,\r\n                                horaproduccion,\r\n                                idproductocompuesto,\r\n                                productocompuestoprincipal,\r\n                                preciocatalogo,\r\n                                marcar,\r\n                                idmeseroproducto,\r\n                                prioridadproduccion,\r\n                                estatuspatin,\r\n                                idcortesia,\r\n                                numerotarjeta,\r\n                                estadomonitor,\r\n                                llavemovto,\r\n                                horameserofinalizado,\r\n                                meserofinalizado,\r\n                                sistema_envio,\r\n                                idturno_cierre,\r\n                                procesado,\r\n                                promovolumen,\r\n                                iddispositivo,\r\n                                productsyncidsr,\r\n                                subtotalsrx,\r\n                                totalsrx,\r\n                                idlistaprecio,\r\n                                tipocambio,\r\n                                idmovtobillar,\r\n                                impuestoimporte3,\r\n                                estrateca_DiscountCode,\r\n                                estrateca_DiscountID,\r\n                                estrateca_DiscountAmount)\r\n\r\n\r\n                                Values(\r\n                                '",
												text26.ToString(),
												"',\r\n                                '1',\r\n                                '',\r\n                                '1',\r\n                                '",
												text33.ToString(),
												"',\r\n                                '0',\r\n                                '",
												num4.ToString("N2"),
												"',\r\n                                '",
												num8.ToString("N2"),
												"',\r\n                                '0.00',\r\n                                '0.00',\r\n                                '",
												num5.ToString("N2"),
												"',\r\n                                '',\r\n                                '",
												dateTime3.ToString(Tools.strFormatoFechaLargo),
												"',\r\n                                '0',\r\n                                '0',\r\n                                '',\r\n                                '",
												this.estacion.ToString(),
												"',\r\n                                '',\r\n                                '',\r\n                                '',\r\n                                NULL,\r\n                                '',\r\n                                '0',\r\n                                '",
												num5.ToString("N2"),
												"',\r\n                                        '0',\r\n                                '",
												this.idmesero.ToString(),
												"',\r\n                                        NULL,\r\n                                '0',\r\n                                        '',\r\n                                        '',\r\n                                        '0',\r\n                                        NULL,\r\n                                NULL,\r\n                                NULL,\r\n                                '1',\r\n                                '",
												this.idTurnoTicket.ToString(),
												"',\r\n                                        '1',\r\n                                        '0',\r\n                                        '-1',\r\n                                        '-1',\r\n                                        '-1.00000',\r\n                                        '-1.00000',\r\n                                        NULL,\r\n                                NULL,\r\n                                '0',\r\n                                        '0.00',\r\n                                        '',\r\n                                        '',\r\n                                        '0.00')"
											});
											sqlQuery5.execQuery(text5);
											bool flag172 = Operators.CompareString(text, "Todas", false) == 0;
											if (flag172)
											{
												bool flag173 = num2 == 100.0;
												if (flag173)
												{
													text5 = "UPDATE Cheques set descuentoimporte='0.00' ,totalalimentos='0.00', totalalimentossindescuentos='0.00', totalsindescuento='0.00',subtotalcondescuento='0.00' , subtotal='0.00', totalbebidas='0.00' ,  totalbebidassindescuentos='0.00' , totalotrossindescuentos='0.00' , totaldescuentoalimentos= '0.00' , totaldescuentobebidas='0.00' , totaldescuentootros='0.00' , totaldescuentos='0.00' , totaldescuentoycortesia='0.00' Where folio='" + text26 + "'";
													sqlQuery5.execQuery(text5);
													text5 = "SELECT Cantidad , Descuento , PreciosinImpuestos FROM Cheqdet Where foliodet='" + text26 + "' ";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows21 = sqlDataReader2.HasRows;
													if (hasRows21)
													{
														while (sqlDataReader2.Read())
														{
															double num10 = Conversions.ToDouble(sqlDataReader2[0]);
															double num11 = Conversions.ToDouble(sqlDataReader2[1]);
															double num12 = Conversions.ToDouble(sqlDataReader2[2]);
															double num13 = num10 * num12 / 100.0 * num2;
															text5 = string.Concat(new string[]
															{
																"UPDATE Cheques set DescuentoImporte = DescuentoImporte + '",
																num13.ToString("N2"),
																"'  , totaldescuentoycortesia = totaldescuentoycortesia + '",
																num13.ToString("N2"),
																"' Where folio='",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows22 = sqlDataReader2.HasRows;
													if (hasRows22)
													{
														while (sqlDataReader2.Read())
														{
															double num14 = Conversions.ToDouble(sqlDataReader2[0]);
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalbebidassindescuentos='",
																num14.ToString("N2"),
																"' , totalsindescuento = totalsindescuento + '",
																num14.ToString("N2"),
																"' , subtotal= subtotal + '",
																num14.ToString("N2"),
																"' where folio='",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=2";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows23 = sqlDataReader2.HasRows;
													if (hasRows23)
													{
														while (sqlDataReader2.Read())
														{
															double num15 = Conversions.ToDouble(sqlDataReader2[0]);
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalalimentossindescuentos='",
																num15.ToString("N2"),
																"' , totalsindescuento= totalsindescuento + '",
																num15.ToString("N2"),
																"' , subtotal= subtotal + '",
																num15.ToString("N2"),
																"' where folio='",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=3";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows24 = sqlDataReader2.HasRows;
													if (hasRows24)
													{
														while (sqlDataReader2.Read())
														{
															double num16 = Conversions.ToDouble(sqlDataReader2[0]);
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalotrossindescuentos='",
																num16.ToString("N2"),
																"' ,totalsindescuento= totalsindescuento +'",
																num16.ToString("N2"),
																"' , subtotal= subtotal + '",
																num16.ToString("N2"),
																"'  where folio='",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
													}
													sqlDataReader2.Close();
												}
												bool flag174 = num2 >= 0.0 & num2 < 100.0;
												if (flag174)
												{
													text5 = "UPDATE Cheques set descuentoimporte='0.00' ,totalalimentos='0.00', totalalimentossindescuentos='0.00', totalsindescuento='0.00',subtotalcondescuento='0.00' , subtotal='0.00', totalbebidas='0.00' ,  totalbebidassindescuentos='0.00' , totalotrossindescuentos='0.00' , totaldescuentoalimentos= '0.00' , totaldescuentobebidas='0.00' , totaldescuentootros='0.00' , totaldescuentos='0.00' , totaldescuentoycortesia='0.00' Where folio='" + text26 + "'";
													sqlQuery5.execQuery(text5);
													text5 = "SELECT Cantidad , Descuento , PreciosinImpuestos FROM Cheqdet Where foliodet='" + text26 + "' and descuento > 0 ";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows25 = sqlDataReader2.HasRows;
													if (hasRows25)
													{
														while (sqlDataReader2.Read())
														{
															double num10 = Conversions.ToDouble(sqlDataReader2[0]);
															double num11 = Conversions.ToDouble(sqlDataReader2[1]);
															double num12 = Conversions.ToDouble(sqlDataReader2[2]);
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totaldescuentoycortesia= totaldescuentoycortesia +'",
																(num10 * num12 / 100.0 * num11).ToString("N2"),
																"'  where folio='",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows26 = sqlDataReader2.HasRows;
													if (hasRows26)
													{
														while (sqlDataReader2.Read())
														{
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalbebidassindescuentos= totalbebidassindescuentos +'",
																Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
																"' where folio='",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows27 = sqlDataReader2.HasRows;
													if (hasRows27)
													{
														while (sqlDataReader2.Read())
														{
															double num10 = Conversions.ToDouble(sqlDataReader2[0]);
															double num11 = Conversions.ToDouble(sqlDataReader2[1]);
															double num12 = Conversions.ToDouble(sqlDataReader2[2]);
															double num17 = Conversions.ToDouble((num10 * num12 - num10 * num12 / 100.0 * num11).ToString("n2"));
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalbebidas= totalbebidas +'",
																num17.ToString("N2"),
																"' ,subtotal= subtotal + '",
																num17.ToString("N2"),
																"' , subtotalcondescuento = subtotalcondescuento +  '",
																num17.ToString("N2"),
																"' , TotalSinDescuento=TotalSinDescuento + '",
																num17.ToString("N2"),
																"'    where folio='",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=2";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows28 = sqlDataReader2.HasRows;
													if (hasRows28)
													{
														while (sqlDataReader2.Read())
														{
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalalimentossindescuentos= totalalimentossindescuentos+ '",
																Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
																"' where folio='",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=2";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows29 = sqlDataReader2.HasRows;
													if (hasRows29)
													{
														while (sqlDataReader2.Read())
														{
															double num10 = Conversions.ToDouble(sqlDataReader2[0]);
															double num11 = Conversions.ToDouble(sqlDataReader2[1]);
															double num12 = Conversions.ToDouble(sqlDataReader2[2]);
															double num18 = Conversions.ToDouble((num10 * num12 - num10 * num12 / 100.0 * num11).ToString("n2"));
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalalimentos= totalalimentos + '",
																num18.ToString("N2"),
																"' , subtotal= subtotal + '",
																num18.ToString("N2"),
																"' , subtotalcondescuento = subtotalcondescuento +  '",
																num18.ToString("N2"),
																"' ,  TotalSinDescuento=TotalSinDescuento + '",
																num18.ToString("N2"),
																"'  where folio='",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=3";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows30 = sqlDataReader2.HasRows;
													if (hasRows30)
													{
														while (sqlDataReader2.Read())
														{
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalotrossindescuentos='",
																Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
																"' where folio='",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=3";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows31 = sqlDataReader2.HasRows;
													if (hasRows31)
													{
														while (sqlDataReader2.Read())
														{
															double num10 = Conversions.ToDouble(sqlDataReader2[0]);
															double num11 = Conversions.ToDouble(sqlDataReader2[1]);
															double num12 = Conversions.ToDouble(sqlDataReader2[2]);
															double num19 = Conversions.ToDouble((num10 * num12 - num10 * num12 / 100.0 * num11).ToString("n2"));
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalotros= totalotros +'",
																num19.ToString("N2"),
																"' ,  subtotal= subtotal + '",
																num19.ToString("N2"),
																"' , subtotalcondescuento = subtotalcondescuento +  '",
																num19.ToString("N2"),
																"' , TotalSinDescuento=TotalSinDescuento + '",
																num19.ToString("N2"),
																"'   where folio='",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
													}
													bool flag175 = num2 > 0.0 & num2 < 100.0;
													if (flag175)
													{
														text5 = "Select Subtotal from Cheques where folio='" + text26 + "'";
														sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
														bool flag176 = sqlDataReader2.Read();
														if (flag176)
														{
															double num20 = Conversions.ToDouble(sqlDataReader2[0]);
															num20 = num20 / 100.0 * num2;
															double num21 = Conversions.ToDouble(sqlDataReader2[0]);
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  subtotalcondescuento ='",
																(num21 - num21 / 100.0 * num2).ToString("N2"),
																"' , DescuentoImporte = DescuentoImporte + '",
																num20.ToString("N2"),
																"' ,totaldescuentos = totaldescuentos + '",
																num20.ToString("N2"),
																"' , totaldescuentoycortesia = totaldescuentoycortesia + '",
																num20.ToString("N2"),
																"'  where Folio = '",
																text26,
																"'  "
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
														text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
														sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
														bool hasRows32 = sqlDataReader2.HasRows;
														if (hasRows32)
														{
															while (sqlDataReader2.Read())
															{
																double num10 = Conversions.ToDouble(sqlDataReader2[0]);
																double num11 = Conversions.ToDouble(sqlDataReader2[1]);
																double num12 = Conversions.ToDouble(sqlDataReader2[2]);
																double num22 = num10 * num12 / 100.0 * num11;
																double num17 = num10 * num12 - num10 * num12 / 100.0 * num11;
																text5 = string.Concat(new string[]
																{
																	"Update Cheques set  totaldescuentobebidas= totaldescuentobebidas +'",
																	Conversions.ToDouble((num17 - num17 / 100.0 * num2).ToString("n2")).ToString("N2"),
																	"' where folio='",
																	text26,
																	"'"
																});
																sqlQuery5.execQuery(text5);
															}
														}
														text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=2";
														sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
														bool hasRows33 = sqlDataReader2.HasRows;
														if (hasRows33)
														{
															while (sqlDataReader2.Read())
															{
																double num10 = Conversions.ToDouble(sqlDataReader2[0]);
																double num11 = Conversions.ToDouble(sqlDataReader2[1]);
																double num12 = Conversions.ToDouble(sqlDataReader2[2]);
																double num22 = num10 * num12 / 100.0 * num11;
																double num18 = num10 * num12 - num10 * num12 / 100.0 * num11;
																text5 = string.Concat(new string[]
																{
																	"Update Cheques set  totaldescuentoalimentos= totaldescuentoalimentos +'",
																	Conversions.ToDouble((num18 - num18 / 100.0 * num2).ToString("n2")).ToString("N2"),
																	"'  where folio='",
																	text26,
																	"'"
																});
																sqlQuery5.execQuery(text5);
															}
														}
														text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=3";
														sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
														bool hasRows34 = sqlDataReader2.HasRows;
														if (hasRows34)
														{
															while (sqlDataReader2.Read())
															{
																double num10 = Conversions.ToDouble(sqlDataReader2[0]);
																double num11 = Conversions.ToDouble(sqlDataReader2[1]);
																double num12 = Conversions.ToDouble(sqlDataReader2[2]);
																double num22 = num10 * num12 / 100.0 * num11;
																double num19 = num10 * num12 - num10 * num12 / 100.0 * num11;
																text5 = string.Concat(new string[]
																{
																	"Update Cheques set  totaldescuentootros= totaldescuentootros +'",
																	Conversions.ToDouble((num19 - num19 / 100.0 * num2).ToString("n2")).ToString("N2"),
																	"' where folio='",
																	text26,
																	"'"
																});
																sqlQuery5.execQuery(text5);
															}
														}
													}
												}
												sqlDataReader2.Close();
											}
											bool flag177 = Operators.CompareString(text, "Todas", false) != 0;
											if (flag177)
											{
												bool flag178 = num2 == 100.0;
												if (flag178)
												{
													text5 = "UPDATE Cheques set descuentoimporte='0.00' ,totalalimentos='0.00', totalalimentossindescuentos='0.00', totalsindescuento='0.00',subtotalcondescuento='0.00' , subtotal='0.00', totalbebidas='0.00' ,  totalbebidassindescuentos='0.00' , totalotrossindescuentos='0.00' , totaldescuentoalimentos= '0.00' , totaldescuentobebidas='0.00' , totaldescuentootros='0.00' , totaldescuentos='0.00' , totaldescuentoycortesia='0.00' Where folio='" + text26 + "'";
													sqlQuery5.execQuery(text5);
													text5 = "SELECT Cantidad , Descuento , PreciosinImpuestos FROM Cheqdet Where foliodet='" + text26 + "' ";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows35 = sqlDataReader2.HasRows;
													if (hasRows35)
													{
														while (sqlDataReader2.Read())
														{
															double num10 = Conversions.ToDouble(sqlDataReader2[0]);
															double num11 = Conversions.ToDouble(sqlDataReader2[1]);
															double num12 = Conversions.ToDouble(sqlDataReader2[2]);
															double num13 = num10 * num12 / 100.0 * num2;
															text5 = string.Concat(new string[]
															{
																"UPDATE Cheques set DescuentoImporte = DescuentoImporte + '",
																num13.ToString("N2"),
																"'  , totaldescuentoycortesia = totaldescuentoycortesia + '",
																num13.ToString("N2"),
																"' Where folio='",
																text26,
																"' and seriefolio='",
																text,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows36 = sqlDataReader2.HasRows;
													if (hasRows36)
													{
														while (sqlDataReader2.Read())
														{
															double num14 = Conversions.ToDouble(sqlDataReader2[0]);
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalbebidassindescuentos='",
																num14.ToString("N2"),
																"' , totalsindescuento = totalsindescuento + '",
																num14.ToString("N2"),
																"' , subtotal= subtotal + '",
																num14.ToString("N2"),
																"' where folio='",
																text26,
																"' and seriefolio='",
																text,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=2";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows37 = sqlDataReader2.HasRows;
													if (hasRows37)
													{
														while (sqlDataReader2.Read())
														{
															double num15 = Conversions.ToDouble(sqlDataReader2[0]);
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalalimentossindescuentos='",
																num15.ToString("N2"),
																"' , totalsindescuento= totalsindescuento + '",
																num15.ToString("N2"),
																"' , subtotal= subtotal + '",
																num15.ToString("N2"),
																"' where folio='",
																text26,
																"' and seriefolio='",
																text,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=3";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows38 = sqlDataReader2.HasRows;
													if (hasRows38)
													{
														while (sqlDataReader2.Read())
														{
															double num16 = Conversions.ToDouble(sqlDataReader2[0]);
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalotrossindescuentos='",
																num16.ToString("N2"),
																"' ,totalsindescuento= totalsindescuento +'",
																num16.ToString("N2"),
																"' , subtotal= subtotal + '",
																num16.ToString("N2"),
																"'  where folio='",
																text26,
																"' and seriefolio='",
																text,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
													}
													sqlDataReader2.Close();
												}
												bool flag179 = num2 >= 0.0 & num2 < 100.0;
												if (flag179)
												{
													text5 = "UPDATE Cheques set descuentoimporte='0.00' ,totalalimentos='0.00', totalalimentossindescuentos='0.00', totalsindescuento='0.00',subtotalcondescuento='0.00' , subtotal='0.00', totalbebidas='0.00' ,  totalbebidassindescuentos='0.00' , totalotrossindescuentos='0.00' , totaldescuentoalimentos= '0.00' , totaldescuentobebidas='0.00' , totaldescuentootros='0.00' , totaldescuentos='0.00' , totaldescuentoycortesia='0.00' Where folio='" + text26 + "'";
													sqlQuery5.execQuery(text5);
													text5 = "SELECT Cantidad , Descuento , PreciosinImpuestos FROM Cheqdet Where foliodet='" + text26 + "' and descuento > 0 ";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows39 = sqlDataReader2.HasRows;
													if (hasRows39)
													{
														while (sqlDataReader2.Read())
														{
															double num10 = Conversions.ToDouble(sqlDataReader2[0]);
															double num11 = Conversions.ToDouble(sqlDataReader2[1]);
															double num12 = Conversions.ToDouble(sqlDataReader2[2]);
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totaldescuentoycortesia= totaldescuentoycortesia +'",
																(num10 * num12 / 100.0 * num11).ToString("N2"),
																"'  where folio='",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows40 = sqlDataReader2.HasRows;
													if (hasRows40)
													{
														while (sqlDataReader2.Read())
														{
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalbebidassindescuentos= totalbebidassindescuentos +'",
																Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
																"' where folio='",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows41 = sqlDataReader2.HasRows;
													if (hasRows41)
													{
														while (sqlDataReader2.Read())
														{
															double num10 = Conversions.ToDouble(sqlDataReader2[0]);
															double num11 = Conversions.ToDouble(sqlDataReader2[1]);
															double num12 = Conversions.ToDouble(sqlDataReader2[2]);
															double num17 = Conversions.ToDouble((num10 * num12 - num10 * num12 / 100.0 * num11).ToString("n2"));
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalbebidas= totalbebidas +'",
																num17.ToString("N2"),
																"' ,subtotal= subtotal + '",
																num17.ToString("N2"),
																"' , subtotalcondescuento = subtotalcondescuento +  '",
																num17.ToString("N2"),
																"' , TotalSinDescuento=TotalSinDescuento + '",
																num17.ToString("N2"),
																"'    where folio='",
																text26,
																"' and seriefolio='",
																text,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=2";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows42 = sqlDataReader2.HasRows;
													if (hasRows42)
													{
														while (sqlDataReader2.Read())
														{
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalalimentossindescuentos= totalalimentossindescuentos+ '",
																Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
																"' where folio='",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=2";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows43 = sqlDataReader2.HasRows;
													if (hasRows43)
													{
														while (sqlDataReader2.Read())
														{
															double num10 = Conversions.ToDouble(sqlDataReader2[0]);
															double num11 = Conversions.ToDouble(sqlDataReader2[1]);
															double num12 = Conversions.ToDouble(sqlDataReader2[2]);
															double num18 = Conversions.ToDouble((num10 * num12 - num10 * num12 / 100.0 * num11).ToString("n2"));
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalalimentos= totalalimentos + '",
																num18.ToString("N2"),
																"' , subtotal= subtotal + '",
																num18.ToString("N2"),
																"' , subtotalcondescuento = subtotalcondescuento +  '",
																num18.ToString("N2"),
																"' ,  TotalSinDescuento=TotalSinDescuento + '",
																num18.ToString("N2"),
																"'  where folio='",
																text26,
																"' and seriefolio='",
																text,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=3";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows44 = sqlDataReader2.HasRows;
													if (hasRows44)
													{
														while (sqlDataReader2.Read())
														{
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalotrossindescuentos='",
																Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
																"' where folio='",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
													}
													text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=3";
													sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
													bool hasRows45 = sqlDataReader2.HasRows;
													if (hasRows45)
													{
														while (sqlDataReader2.Read())
														{
															double num10 = Conversions.ToDouble(sqlDataReader2[0]);
															double num11 = Conversions.ToDouble(sqlDataReader2[1]);
															double num12 = Conversions.ToDouble(sqlDataReader2[2]);
															double num19 = Conversions.ToDouble((num10 * num12 - num10 * num12 / 100.0 * num11).ToString("n2"));
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  totalotros= totalotros +'",
																num19.ToString("N2"),
																"' ,  subtotal= subtotal + '",
																num19.ToString("N2"),
																"' , subtotalcondescuento = subtotalcondescuento +  '",
																num19.ToString("N2"),
																"' , TotalSinDescuento=TotalSinDescuento + '",
																num19.ToString("N2"),
																"'   where folio='",
																text26,
																"' and seriefolio='",
																text,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
													}
													bool flag180 = num2 > 0.0 & num2 < 100.0;
													if (flag180)
													{
														text5 = "Select Subtotal from Cheques where folio='" + text26 + "'";
														sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
														bool flag181 = sqlDataReader2.Read();
														if (flag181)
														{
															double num23 = Conversions.ToDouble(sqlDataReader2[0]);
															num23 = num23 / 100.0 * num2;
															double num24 = Conversions.ToDouble(sqlDataReader2[0]);
															text5 = string.Concat(new string[]
															{
																"Update Cheques set  subtotalcondescuento ='",
																(num24 - num24 / 100.0 * num2).ToString("N2"),
																"' , DescuentoImporte = DescuentoImporte + '",
																num23.ToString("N2"),
																"' ,totaldescuentos = totaldescuentos + '",
																num23.ToString("N2"),
																"' , totaldescuentoycortesia = totaldescuentoycortesia + '",
																num23.ToString("N2"),
																"'  where Folio = '",
																text26,
																"' and seriefolio='",
																text,
																"' "
															});
															sqlQuery5.execQuery(text5);
														}
														sqlDataReader2.Close();
														text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
														sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
														bool hasRows46 = sqlDataReader2.HasRows;
														if (hasRows46)
														{
															while (sqlDataReader2.Read())
															{
																double num10 = Conversions.ToDouble(sqlDataReader2[0]);
																double num11 = Conversions.ToDouble(sqlDataReader2[1]);
																double num12 = Conversions.ToDouble(sqlDataReader2[2]);
																double num25 = num10 * num12 / 100.0 * num11;
																double num17 = num10 * num12 - num10 * num12 / 100.0 * num11;
																text5 = string.Concat(new string[]
																{
																	"Update Cheques set  totaldescuentobebidas= totaldescuentobebidas +'",
																	Conversions.ToDouble((num17 - num17 / 100.0 * num2).ToString("n2")).ToString("N2"),
																	"' where folio='",
																	text26,
																	"'"
																});
																sqlQuery5.execQuery(text5);
															}
														}
														text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=2";
														sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
														bool hasRows47 = sqlDataReader2.HasRows;
														if (hasRows47)
														{
															while (sqlDataReader2.Read())
															{
																double num10 = Conversions.ToDouble(sqlDataReader2[0]);
																double num11 = Conversions.ToDouble(sqlDataReader2[1]);
																double num12 = Conversions.ToDouble(sqlDataReader2[2]);
																double num25 = num10 * num12 / 100.0 * num11;
																double num18 = num10 * num12 - num10 * num12 / 100.0 * num11;
																text5 = string.Concat(new string[]
																{
																	"Update Cheques set  totaldescuentoalimentos= totaldescuentoalimentos +'",
																	Conversions.ToDouble((num18 - num18 / 100.0 * num2).ToString("n2")).ToString("N2"),
																	"'  where folio='",
																	text26,
																	"' and seriefolio='",
																	text,
																	"'"
																});
																sqlQuery5.execQuery(text5);
															}
														}
														text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=3";
														sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
														bool hasRows48 = sqlDataReader2.HasRows;
														if (hasRows48)
														{
															while (sqlDataReader2.Read())
															{
																double num10 = Conversions.ToDouble(sqlDataReader2[0]);
																double num11 = Conversions.ToDouble(sqlDataReader2[1]);
																double num12 = Conversions.ToDouble(sqlDataReader2[2]);
																double num25 = num10 * num12 / 100.0 * num11;
																double num19 = num10 * num12 - num10 * num12 / 100.0 * num11;
																text5 = string.Concat(new string[]
																{
																	"Update Cheques set  totaldescuentootros= totaldescuentootros +'",
																	Conversions.ToDouble((num19 - num19 / 100.0 * num2).ToString("n2")).ToString("N2"),
																	"' where folio='",
																	text26,
																	"' and seriefolio='",
																	text,
																	"'"
																});
																sqlQuery5.execQuery(text5);
															}
														}
													}
												}
												sqlDataReader2.Close();
											}
											text5 = "select ISNULL(sum(preciosinimpuestos*cantidad/100 *impuesto1),0) from cheqdet where foliodet = '" + text26 + "'";
											sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
											bool flag182 = sqlDataReader2.Read();
											double num26;
											if (flag182)
											{
												num26 = Conversions.ToDouble(sqlDataReader2[0]);
												num26 -= num26 / 100.0 * num2;
											}
											text5 = "select ISNULL(sum(precio*cantidad-(preciosinimpuestos*cantidad/100*impuesto1)),0) from cheqdet where foliodet = '" + text26 + "'";
											sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
											bool flag183 = sqlDataReader2.Read();
											if (flag183)
											{
												double num12 = Conversions.ToDouble(sqlDataReader2[0]);
												num12 -= num12 / 100.0 * num2;
											}
											try
											{
												bool flag184 = Operators.CompareString(text, "Todas", false) == 0;
												if (flag184)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques Set total = '",
														num3.ToString("N2"),
														"'  , totalconpropina = '",
														num3.ToString("N2"),
														"' , TotalConCargo='",
														num3.ToString("N2"),
														"' ,  TotalConPropinaCargo='",
														num3.ToString("N2"),
														"'    where folio = '",
														text26,
														"'"
													});
													sqlQuery5.execQuery(text5);
												}
												bool flag185 = Operators.CompareString(text, "Todas", false) != 0;
												if (flag185)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set total = '",
														num3.ToString("N2"),
														"'  ,totalconpropina = '",
														num3.ToString("N2"),
														"' , TotalConCargo='",
														num3.ToString("N2"),
														"' ,  TotalConPropinaCargo='",
														num3.ToString("N2"),
														"'   where folio = '",
														text26,
														"' and seriefolio = '",
														text,
														"'"
													});
													sqlQuery5.execQuery(text5);
												}
											}
											catch (Exception ex12)
											{
											}
											bool flag186 = Operators.CompareString(text, "Todas", false) == 0;
											if (flag186)
											{
												try
												{
													bool flag187 = num6 == 1.0;
													if (flag187)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques Set   totalimpuesto1='",
															num26.ToString("N2"),
															"' ,  totalimpuestod1='",
															num26.ToString("N2"),
															"' where folio = '",
															text26,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													else
													{
														bool flag188 = num6 == 2.0;
														if (flag188)
														{
															text5 = string.Concat(new string[]
															{
																"Update cheques Set  totalimpuesto1='",
																num26.ToString("N2"),
																"' ,  totalimpuestod1='",
																num26.ToString("N2"),
																"' where folio = '",
																text26,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														else
														{
															bool flag189 = num6 == 3.0;
															if (flag189)
															{
																text5 = string.Concat(new string[]
																{
																	"Update cheques   totalimpuesto1='",
																	num26.ToString("N2"),
																	"' ,  totalimpuestod1='",
																	num26.ToString("N2"),
																	"' where folio = '",
																	text26,
																	"'"
																});
																sqlQuery5.execQuery(text5);
															}
														}
													}
												}
												catch (Exception ex13)
												{
												}
											}
											bool flag190 = Operators.CompareString(text, "Todas", false) != 0;
											if (flag190)
											{
												try
												{
													bool flag191 = num6 == 1.0;
													if (flag191)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques Set totalimpuesto1='",
															num26.ToString("N2"),
															"' ,  totalimpuestod1='",
															num26.ToString("N2"),
															"' where folio = '",
															text26,
															"' and seriefolio = '",
															text,
															"'"
														});
														sqlQuery5.execQuery(text5);
													}
													else
													{
														bool flag192 = num6 == 2.0;
														if (flag192)
														{
															text5 = string.Concat(new string[]
															{
																"Update cheques Set   totalimpuesto1='",
																num26.ToString("N2"),
																"' ,  totalimpuestod1='",
																num26.ToString("N2"),
																"' where folio = '",
																text26,
																"' and seriefolio = '",
																text,
																"'"
															});
															sqlQuery5.execQuery(text5);
														}
														else
														{
															bool flag193 = num6 == 3.0;
															if (flag193)
															{
																text5 = string.Concat(new string[]
																{
																	"Update cheques Set   totalimpuesto1='",
																	num26.ToString("N2"),
																	"' ,  totalimpuestod1='",
																	num26.ToString("N2"),
																	"' where folio = '",
																	text26,
																	"' and seriefolio = '",
																	text,
																	"'"
																});
																sqlQuery5.execQuery(text5);
															}
														}
													}
												}
												catch (Exception ex14)
												{
												}
											}
										}
									}
								}
							}
							catch (Exception ex15)
							{
							}
						}
						this.progBar.Value = 60;
					}
				}
				finally
				{
					IEnumerator enumerator4;
					if (enumerator4 is IDisposable)
					{
						(enumerator4 as IDisposable).Dispose();
					}
				}
				text5 = string.Concat(new string[]
				{
					"select distinct (idturno) from turnos where apertura between '",
					text3,
					"' and '",
					text4,
					"' and cierre is not  null"
				});
				sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
				bool hasRows49 = sqlDataReader2.HasRows;
				if (hasRows49)
				{
					while (sqlDataReader2.Read())
					{
						list2.Add(Conversions.ToString(sqlDataReader2[0]));
					}
					sqlDataReader2.Close();
				}
				text5 = string.Concat(new string[]
				{
					"Select count(*) from turnos where apertura between '",
					text3,
					"' and '",
					text4,
					"' and cierre is not  null"
				});
				sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
				bool hasRows50 = sqlDataReader2.HasRows;
				if (hasRows50)
				{
					sqlDataReader2.Read();
					int num27 = Conversions.ToInteger(sqlDataReader2[0]);
				}
				sqlDataReader2.Close();
				try
				{
				}
				catch (Exception ex16)
				{
				}
				try
				{
					foreach (string text34 in list2)
					{
						SqlQuery sqlQuery7 = new SqlQuery();
						string text35 = "select n from H";
						SqlDataReader sqlDataReader6 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text35);
						bool hasRows51 = sqlDataReader6.HasRows;
						if (hasRows51)
						{
							while (sqlDataReader6.Read())
							{
								bool flag194 = Operators.CompareString(Tools.Desencriptar(sqlDataReader6[0].ToString().Trim()), "1", false) == 0;
								if (flag194)
								{
									text35 = "delete from movsinv where idconcepto='SPV' and idturno ='" + text34 + "'";
									sqlQuery7.execQuery(text35);
								}
							}
						}
						bool @checked = this.chkEliminaProp.Checked;
						if (@checked)
						{
							text5 = "delete from movtoscaja where idturno  = '" + text34 + "' And  pagodepropina = 1";
							sqlQuery5.execQuery(text5);
							bool flag195 = Operators.CompareString(text, "Todas", false) == 0;
							if (flag195)
							{
								text5 = "update cheques set propina=0 , propinafoliomovtocaja =0 where idturno='" + text34 + "'";
								sqlQuery5.execQuery(text5);
							}
							bool flag196 = Operators.CompareString(text, "Todas", false) != 0;
							if (flag196)
							{
								text5 = string.Concat(new string[]
								{
									"update cheques set propina=0 , propinafoliomovtocaja =0 where idturno='",
									text34,
									"' and seriefolio = '",
									text,
									"'"
								});
								sqlQuery5.execQuery(text5);
							}
						}
						else
						{
							text5 = "Select ISNULL(sum(importe),0) from movtoscaja Where idturno = '" + text34 + "' And  pagodepropina = 1";
							sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
							sqlDataReader2.Read();
							num = Conversions.ToDouble(sqlDataReader2[0]);
							sqlDataReader2.Close();
						}
						bool checked2 = this.chkEliminaRet.Checked;
						if (checked2)
						{
							text5 = "delete from movtoscaja Where idturno = '" + text34 + "' And pagodepropina <1";
							sqlQuery5.execQuery(text5);
						}
						bool flag197 = Operators.CompareString(text, "Todas", false) == 0;
						if (flag197)
						{
							text5 = string.Concat(new string[]
							{
								"Select \r\n                            ISNULL(sum(efectivo),0),\r\n                            ISNULL(sum(tarjeta),0),\r\n                            ISNULL(sum(vales),0),\r\n                            ISNULL(sum(otros),0)\r\n                            from cheques WHERE idempresa='",
								Tools.id_Empresa,
								"' and  idturno = '",
								text34,
								"'"
							});
							sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
							sqlDataReader2.Read();
							double num28 = Conversions.ToDouble(Operators.SubtractObject(sqlDataReader2[0], num));
							double num29 = Conversions.ToDouble(sqlDataReader2[1]);
							double num30 = Conversions.ToDouble(sqlDataReader2[2]);
							double num31 = Conversions.ToDouble(sqlDataReader2[3]);
							double num32 = num28;
							text5 = string.Concat(new string[]
							{
								"Update turnos Set efectivo='",
								num32.ToString("N2"),
								"',tarjeta='",
								num29.ToString("N2"),
								"',vales='",
								num30.ToString("N2"),
								"', credito='",
								num31.ToString("N2"),
								"' Where idturno = '",
								text34,
								"'"
							});
							sqlQuery5.execQuery(text5);
						}
						bool flag198 = Operators.CompareString(text, "Todas", false) != 0;
						if (flag198)
						{
							text5 = string.Concat(new string[]
							{
								"Select \r\n                            ISNULL(sum(efectivo),0),\r\n                            ISNULL(sum(tarjeta),0),\r\n                            ISNULL(sum(vales),0),\r\n                            ISNULL(sum(otros),0)\r\n                            from cheques WHERE idempresa='",
								Tools.id_Empresa,
								"' and  idturno = '",
								text34,
								"' and seriefolio = '",
								text,
								"'"
							});
							sqlDataReader2 = (SqlDataReader)sqlQuery5.execReader(text5);
							sqlDataReader2.Read();
							double num28 = Conversions.ToDouble(Operators.SubtractObject(sqlDataReader2[0], num));
							double num29 = Conversions.ToDouble(sqlDataReader2[1]);
							double num30 = Conversions.ToDouble(sqlDataReader2[2]);
							double num31 = Conversions.ToDouble(sqlDataReader2[3]);
							double num32 = num28;
							text5 = string.Concat(new string[]
							{
								"Update turnos Set efectivo='",
								num32.ToString("N2"),
								"',tarjeta='",
								num29.ToString("N2"),
								"',vales='",
								num30.ToString("N2"),
								"', credito='",
								num31.ToString("N2"),
								"' Where idturno = '",
								text34,
								"'"
							});
							sqlQuery5.execQuery(text5);
						}
						bool checked3 = this.CheckBoxfondocaja.Checked;
						if (checked3)
						{
							text5 = "update turnos set fondo=0 Where idturno = '" + text34 + "'";
							sqlQuery5.execQuery(text5);
						}
						try
						{
						}
						catch (Exception ex17)
						{
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator5;
					((IDisposable)enumerator5).Dispose();
				}
				this.progBar.Value = 80;
				this.txtMinimo.Text = Conversions.ToString(0);
				this.txtDescto.Text = Conversions.ToString(0);
				string text36 = DateAndTime.Now.ToString(Tools.strFormatoFechaLargo);
				string text37 = this.txtCuentasModificar.Text;
				string text38 = this.txtCuentasTotal.Text;
				double num33 = Conversions.ToDouble(this.txtImpAnterior.Text);
				double num34 = Conversions.ToDouble(this.txtImpNuevo.Text);
				double num35 = Conversions.ToDouble(this.txtEfectivoAnt.Text);
				double num36 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
				double num37 = Conversions.ToDouble(this.txtVentaTarjeta.Text);
				double num38 = Conversions.ToDouble(this.txtDifTarjeta.Text);
				double num39 = Conversions.ToDouble(this.txtVentasOtros.Text);
				double num40 = Conversions.ToDouble(this.txtdifotros.Text);
				double num41 = Conversions.ToDouble(this.txtVales.Text);
				double num42 = Conversions.ToDouble(this.txtdifvales.Text);
				double num43 = Conversions.ToDouble(this.txtTotalPropinas.Text);
				double num44 = Conversions.ToDouble(this.txttotalnuevopropinas.Text);
				string text39 = MyProject.Forms.main.lblNombreUsuario.Text;
				string text40 = this.cmbxEmpresa.Text;
				text5 = "Select h from H";
				sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
				this.progBar.Value = 90;
				bool hasRows52 = sqlDataReader2.HasRows;
				if (hasRows52)
				{
					while (sqlDataReader2.Read())
					{
						bool flag199 = Operators.CompareString(Tools.Desencriptar(sqlDataReader2[0].ToString().Trim()), "1", false) == 0;
						if (flag199)
						{
							try
							{
								text5 = string.Concat(new string[]
								{
									"Insert into I ( a ,b ,c ,d ,e ,f ,g ,h ,i ,j , k , l , m, n , o , p , q , r , s , t , u , w , x )Values ( '",
									text36,
									"','",
									text3,
									"','",
									text4,
									"','",
									Tools.Encriptar(this.txtCuentasTotal.Text.Trim()),
									"','",
									Tools.Encriptar(this.txtCuentasModificar.Text.Trim()),
									"','",
									Tools.Encriptar(this.txtImpAnterior.Text.Trim()),
									"','",
									Tools.Encriptar(this.txtImpNuevo.Text.Trim()),
									"','",
									Tools.Encriptar(this.txtEfectivoAnt.Text.Trim()),
									"','",
									Tools.Encriptar(this.txtEfectivoFiscal.Text.Trim()),
									"','",
									Tools.Encriptar(this.txtDifPorcen.Text.Trim()),
									"','",
									Tools.Encriptar(this.lbltipobarrido.Text.Trim()),
									"','",
									Tools.Encriptar(this.lblAfectadboreal.Text.Trim()),
									"','",
									Tools.Encriptar(this.cmbxEmpresa.Text.Trim()),
									"','",
									Tools.Encriptar(this.txtVentaTarjeta.Text.Trim()),
									"','",
									Tools.Encriptar(this.txtDifTarjeta.Text.Trim()),
									"','",
									Tools.Encriptar(this.txtVales.Text.Trim()),
									"','",
									Tools.Encriptar(this.txtdifvales.Text.Trim()),
									"','",
									Tools.Encriptar(this.txtVentasOtros.Text.Trim()),
									"','",
									Tools.Encriptar(this.txtdifotros.Text.Trim()),
									"','",
									Tools.Encriptar(this.txtTotalPropinas.Text.Trim()),
									"','",
									Tools.Encriptar(this.txttotalnuevopropinas.Text.Trim()),
									"','",
									Tools.Encriptar(MyProject.Forms.main.lblNombreUsuario.Text.Trim()),
									"','",
									Tools.Encriptar(this.lblCOdigoUnicoCorte.Text.Trim()),
									"')"
								});
								sqlQuery_Conn.execQuery_conn(text5);
								this.InsertarCorteBitacora();
							}
							catch (Exception ex18)
							{
							}
						}
					}
					sqlDataReader2.Close();
				}
				sqlDataReader2.Close();
				this.progBar.Value = 100;
				Interaction.MsgBox("Proceso Finalizado, los totales se actualizaron en el software para restaurante!", MsgBoxStyle.OkOnly, null);
				this.progBar.Value = 0;
				this.iniciaGridFolio();
				this.habilitaControles(true);
				this.refrescaDatos();
				this.btnAplicar.Enabled = false;
				try
				{
					foreach (object obj6 in ((IEnumerable)this.dgvNotas.Rows))
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(obj6);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue2, null, "cells", new object[]
						{
							18
						}, null, null, null), null, "value", new object[]
						{
							false
						}, null, null, false, true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue2, null, "DefaultCellStyle", new object[0], null, null, null), null, "BackColor", new object[]
						{
							Color.White
						}, null, null, false, true);
					}
				}
				finally
				{
					IEnumerator enumerator6;
					if (enumerator6 is IDisposable)
					{
						(enumerator6 as IDisposable).Dispose();
					}
				}
				this.dgvNotas.Enabled = false;
				this.txtCuentasModificar.Text = Conversions.ToString(0);
			}
			bool flag200 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.No, false);
			if (flag200)
			{
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00052C48 File Offset: 0x00050E48
		private void cmbAnio_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			this.ComboBox1.Items.Clear();
			string text = "Enero";
			text = Tools.Encriptar(text.ToString().Trim());
			string text2 = "Febrero";
			text2 = Tools.Encriptar(text2.ToString().Trim());
			string text3 = "Marzo";
			text3 = Tools.Encriptar(text3.ToString().Trim());
			string text4 = "Abril";
			text4 = Tools.Encriptar(text4.ToString().Trim());
			string text5 = "Mayo";
			text5 = Tools.Encriptar(text5.ToString().Trim());
			string text6 = "Junio";
			text6 = Tools.Encriptar(text6.ToString().Trim());
			string text7 = "Julio";
			text7 = Tools.Encriptar(text7.ToString().Trim());
			string text8 = "Agosto";
			text8 = Tools.Encriptar(text8.ToString().Trim());
			string text9 = "Septiembre";
			text9 = Tools.Encriptar(text9.ToString().Trim());
			string text10 = "Octubre";
			text10 = Tools.Encriptar(text10.ToString().Trim());
			string text11 = "Noviembre";
			text11 = Tools.Encriptar(text11.ToString().Trim());
			string text12 = "Diciembre";
			text12 = Tools.Encriptar(text12.ToString().Trim());
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(string.Concat(new string[]
			{
				"select distinct(c), CASE WHEN c = '",
				text.ToString(),
				"' THEN 1 WHEN c = '",
				text2.ToString(),
				"' THEN 2 WHEN c = '",
				text3.ToString(),
				"' THEN 3\tWHEN c = '",
				text4.ToString(),
				"' THEN 4\tWHEN c = '",
				text5.ToString(),
				"' THEN 5\tWHEN c = '",
				text6.ToString(),
				"' THEN 6\tWHEN c = '",
				text7.ToString().Trim(),
				"' THEN 7\tWHEN c = '",
				text8.ToString(),
				"' THEN 8\tWHEN c = '",
				text9.ToString(),
				"' THEN 9\tWHEN c = '",
				text10.ToString(),
				"' THEN 10\tWHEN c = '",
				text11.ToString(),
				"' THEN 11\tWHEN c = '",
				text12.ToString(),
				"' THEN 12 END AS monthNum from G where b = '",
				Tools.Encriptar(this.cmbAnio.Text.Trim()),
				"' order by monthNum"
			}));
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					this.ComboBox1.Items.Add(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
				}
				this.ComboBox1.Enabled = true;
				this.Button2.Enabled = true;
			}
			sqlDataReader.Close();
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00052F34 File Offset: 0x00051134
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(string.Concat(new string[]
			{
				"select a,b,c from G where c='",
				Tools.Encriptar(this.ComboBox1.Text.Trim()),
				"' and b ='",
				Tools.Encriptar(this.cmbAnio.Text.Trim()),
				"'"
			}));
			bool hasRows = sqlDataReader.HasRows;
			checked
			{
				if (hasRows)
				{
					sqlDataReader.Read();
					Tools.licencia = Conversions.ToString(sqlDataReader[0]);
					bool flag = !Tools.ValidaLicencia();
					if (flag)
					{
						this.habilitaControles(true);
						sqlDataReader.Close();
					}
					else
					{
						sqlDataReader.Close();
						this.habilitaControles(true);
						this.dateFechaIni.MaxDate = new DateTime(2100, 1, 1);
						this.dateFechaFin.MaxDate = new DateTime(2100, 1, 1);
						this.dateFechaIni.MinDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), Conversions.ToInteger(Tools.Gm(this.ComboBox1.Text)), 1);
						this.dateFechaFin.MinDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), Conversions.ToInteger(Tools.Gm(this.ComboBox1.Text)), 1);
						bool flag2 = Operators.CompareString(Tools.Gm(this.ComboBox1.Text), "12", false) == 0;
						if (flag2)
						{
							this.dateFechaIni.MaxDate = new DateTime((int)Math.Round(unchecked(Conversions.ToDouble(this.cmbAnio.Text) + 1.0)), 1, 1);
							this.dateFechaFin.MaxDate = new DateTime((int)Math.Round(unchecked(Conversions.ToDouble(this.cmbAnio.Text) + 1.0)), 1, 6);
						}
						else
						{
							this.dateFechaIni.MaxDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), (int)Math.Round(unchecked(Conversions.ToDouble(Tools.Gm(this.ComboBox1.Text)) + 1.0)), 1);
							this.dateFechaFin.MaxDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), (int)Math.Round(unchecked(Conversions.ToDouble(Tools.Gm(this.ComboBox1.Text)) + 1.0)), 6);
						}
						this.dateFechaIni.Value = this.dateFechaIni.MinDate;
						this.dateFechaFin.Value = this.dateFechaFin.MinDate;
					}
				}
				else
				{
					this.habilitaControles(false);
					sqlDataReader.Close();
				}
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x000036D5 File Offset: 0x000018D5
		private void chkReemplazar_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x000531FD File Offset: 0x000513FD
		private void txtDescto_TextChanged(object sender, EventArgs e)
		{
			this.txtMinimo.Text = Conversions.ToString(0);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000036D5 File Offset: 0x000018D5
		private void obtener_datos_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00053212 File Offset: 0x00051412
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0005321C File Offset: 0x0005141C
		private void txtDescto_Click(object sender, EventArgs e)
		{
			this.txtMinimo.Text = Conversions.ToString(0);
			this.txtDescto.SelectAll();
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0005323D File Offset: 0x0005143D
		private void txtMinimo_TextChanged(object sender, EventArgs e)
		{
			this.txtDescto.Text = Conversions.ToString(0);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00053252 File Offset: 0x00051452
		private void txtMinimo_Click(object sender, EventArgs e)
		{
			this.txtDescto.Text = Conversions.ToString(0);
			this.txtMinimo.SelectAll();
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00053273 File Offset: 0x00051473
		private void BtnHorario_Click(object sender, EventArgs e)
		{
			this.BtnHorario.Enabled = false;
			this.dateHoraIni.Enabled = true;
			this.dateHoraFin.Enabled = true;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtVentaTarjeta_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox2_DoubleClick(object sender, EventArgs e)
		{
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0005329D File Offset: 0x0005149D
		private void PictureBox3_Click(object sender, EventArgs e)
		{
			this.Panelvercortes.Visible = false;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000532AD File Offset: 0x000514AD
		private void PictureBox7_Click(object sender, EventArgs e)
		{
			this.Panel1.Visible = false;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x000532BD File Offset: 0x000514BD
		private void PictureBox6_Click(object sender, EventArgs e)
		{
			this.Panel1.Visible = true;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000532D0 File Offset: 0x000514D0
		private void Button1_Click(object sender, EventArgs e)
		{
			this.txtVales.Visible = true;
			this.txtVentasOtros.Visible = true;
			this.txtVentaTarjeta.Visible = true;
			this.lblventaenotros.Visible = true;
			this.lblVentaentarjeta.Visible = true;
			this.lblventaenVales.Visible = true;
			this.txtdifotros.Visible = true;
			this.txtDifTarjeta.Visible = true;
			this.txtdifvales.Visible = true;
			this.lbldifotros.Visible = true;
			this.lbldifTarjeta.Visible = true;
			this.lbldifvales.Visible = true;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0005337C File Offset: 0x0005157C
		private void Button1_DoubleClick(object sender, EventArgs e)
		{
			this.txtVales.Visible = false;
			this.txtVentasOtros.Visible = false;
			this.txtVentaTarjeta.Visible = false;
			this.lblventaenotros.Visible = false;
			this.lblVentaentarjeta.Visible = false;
			this.lblventaenVales.Visible = false;
			this.txtdifotros.Visible = false;
			this.txtDifTarjeta.Visible = false;
			this.txtdifvales.Visible = false;
			this.lbldifotros.Visible = false;
			this.lbldifTarjeta.Visible = false;
			this.lbldifvales.Visible = false;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00053426 File Offset: 0x00051626
		private void btnCorteZ_Click(object sender, EventArgs e)
		{
			this.Panelvercortes.Visible = true;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00053438 File Offset: 0x00051638
		public void InsertarCorteBitacora()
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = string.Concat(new string[]
			{
				"INSERT INTO M (a , b , c , d , e , f , g , h , i , j , k , l , m , n , o , p , q , r , s , t , u , v , w , x , y , z , aa)\r\n\r\n                    Values (\r\n                    '",
				Tools.Encriptar(this.lblCOdigoUnicoCorte.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcortefondoinicialanterior.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcorteefectivoanterior.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcortetarjetaanterior.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcorteanteriorvales.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcorteanteriorotros.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcorteanteriordepositosenefectivo.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcorteanteriorretirosefectivo.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcorteanteriorpropinas.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcorteanteriorsaldo.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcorteanteriorefectivofinal.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblventaFacturada.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblventasinfacturarcorte.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblfacturapub.Text).Trim(),
				"',\r\n\r\n                    '",
				Tools.Encriptar(this.lblfondoinicialnuevo.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcorteefectivonuevo.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcortetarjetanuevo.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcortenuevovales.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcortenuevotros.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcortenuevodepositos.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblcortenuevoretiros.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblpropinascortenuevo.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblsaldofinarlcortenuevo.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblEfectivonuevocorte.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblventafacturanew.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblventasinfacturarnew.Text).Trim(),
				"',\r\n                    '",
				Tools.Encriptar(this.lblventasinfacturarnew.Text).Trim(),
				"')"
			});
			sqlQuery_Conn.execQuery_conn(query_conn);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x000537F8 File Offset: 0x000519F8
		public void COdigoUnicoCOrteGenerar()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "Select \r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(65 + ROUND( RAND()* 25, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) +\r\n\tCHAR(48 + ROUND( RAND()* 9, 0)) as 'Codigo Empresa'";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool flag = sqlDataReader.Read();
			if (flag)
			{
				string text = Conversions.ToString(sqlDataReader[0]);
				this.lblCOdigoUnicoCorte.Text = text;
			}
			sqlDataReader.Close();
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00053850 File Offset: 0x00051A50
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					DataRow dataRow = this.table.NewRow();
					dataRow["id_nota"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["id_nota"].Value);
					dataRow["Serie"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Serie"].Value);
					int num = Conversions.ToInteger(dataGridViewRow.Cells["Folio Cuenta"].Value);
					dataRow["FolioCuenta"] = num;
					dataRow["Folio Nota Consumo"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Folio Nota Consumo"].Value);
					dataRow["Mesa"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Mesa"].Value);
					dataRow["Fecha"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Fecha"].Value);
					dataRow["Cancel."] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Cancel."].Value);
					dataRow["Facturado"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Facturado"].Value);
					dataRow["Descto %"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Descto %"].Value);
					dataRow["Total Original"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total Original"].Value);
					dataRow["Prod. Eliminados"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Prod. Eliminados"].Value);
					dataRow["Total con Descuento"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total con Prod. Eliminados"].Value);
					dataRow["Efectivo"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Efectivo"].Value);
					dataRow["Tarjeta"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tarjeta"].Value);
					dataRow["Vales"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Vales"].Value);
					dataRow["Otros"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Otros"].Value);
					dataRow["Folio Propina"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Folio Propina"].Value);
					dataRow["Propina"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Propina"].Value);
					dataRow["Eliminar"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Eliminar"].Value);
					this.table.Rows.Add(dataRow);
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.view = this.table.DefaultView;
			this.view.Sort = this.table.Columns["Serie"].ColumnName + " Asc, " + this.table.Columns["FolioCuenta"].ColumnName + " Asc";
			this.DataGridView1.DataSource = this.table;
			this.dgvNotas.Rows.Clear();
			try
			{
				foreach (object obj2 in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
					string text = Conversions.ToString(dataGridViewRow2.Cells["id_nota"].Value);
					string text2 = Conversions.ToString(dataGridViewRow2.Cells["Serie"].Value);
					int num2 = Conversions.ToInteger(dataGridViewRow2.Cells["FolioCuenta"].Value);
					string text3 = Conversions.ToString(dataGridViewRow2.Cells["Folio Nota Consumo"].Value);
					string text4 = Conversions.ToString(dataGridViewRow2.Cells["Mesa"].Value);
					string text5 = Conversions.ToString(dataGridViewRow2.Cells["Fecha"].Value);
					string text6 = Conversions.ToString(dataGridViewRow2.Cells["Cancel."].Value);
					string text7 = Conversions.ToString(dataGridViewRow2.Cells["Facturado"].Value);
					string text8 = Conversions.ToString(dataGridViewRow2.Cells["Descto %"].Value);
					double num3 = Conversions.ToDouble(dataGridViewRow2.Cells["Total Original"].Value);
					string text9 = Conversions.ToString(dataGridViewRow2.Cells["Prod. Eliminados"].Value);
					string text10 = Conversions.ToString(dataGridViewRow2.Cells["Total con Descuento"].Value);
					double num4 = Conversions.ToDouble(dataGridViewRow2.Cells["Efectivo"].Value);
					double num5 = Conversions.ToDouble(dataGridViewRow2.Cells["Tarjeta"].Value);
					double num6 = Conversions.ToDouble(dataGridViewRow2.Cells["Vales"].Value);
					double num7 = Conversions.ToDouble(dataGridViewRow2.Cells["Otros"].Value);
					string text11 = Conversions.ToString(dataGridViewRow2.Cells["Folio Propina"].Value);
					double num8 = Conversions.ToDouble(dataGridViewRow2.Cells["Propina"].Value);
					string text12 = Conversions.ToString(dataGridViewRow2.Cells["Eliminar"].Value);
					this.dgvNotas.Rows.Add(new object[]
					{
						text,
						text2,
						num2,
						text3,
						text4,
						text5,
						text6,
						text7,
						text8,
						num3,
						text9,
						text10,
						num4,
						num5,
						num6,
						num7,
						text11,
						num8,
						text12
					});
				}
			}
			finally
			{
				IEnumerator enumerator2;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			bool flag = Operators.CompareString(this.txtDescto.Text, "0", false) > 0;
			if (flag)
			{
				try
				{
					foreach (object obj3 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj3;
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells["Eliminar"].Value, true, false);
						if (flag2)
						{
							dataGridViewRow3.DefaultCellStyle.BackColor = Color.Red;
							dataGridViewRow3.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
						}
					}
				}
				finally
				{
					IEnumerator enumerator3;
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				this.dgvNotas.ClearSelection();
			}
			bool flag3 = Operators.CompareString(this.txtMinimo.Text, "0", false) > 0;
			if (flag3)
			{
				try
				{
					foreach (object obj4 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow4 = (DataGridViewRow)obj4;
						bool flag4 = Operators.ConditionalCompareObjectEqual(dataGridViewRow4.Cells["Eliminar"].Value, true, false);
						if (flag4)
						{
							dataGridViewRow4.DefaultCellStyle.BackColor = Color.Red;
							dataGridViewRow4.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
						}
					}
				}
				finally
				{
					IEnumerator enumerator4;
					if (enumerator4 is IDisposable)
					{
						(enumerator4 as IDisposable).Dispose();
					}
				}
				this.dgvNotas.ClearSelection();
			}
			this.dgvNotas.ClearSelection();
			this.DataGridView1.DataSource = null;
			this.DataGridView1.Refresh();
			this.table.Clear();
		}

		// Token: 0x040002A6 RID: 678
		private object iFolioInicial;

		// Token: 0x040002A7 RID: 679
		private object iNumChequeInicial;

		// Token: 0x040002A8 RID: 680
		private string strFolio;

		// Token: 0x040002A9 RID: 681
		private DataTable table;

		// Token: 0x040002AA RID: 682
		private DataView view;

		// Token: 0x040002AB RID: 683
		private double PrecioNuevo;

		// Token: 0x040002AC RID: 684
		private string idmesero;

		// Token: 0x040002AD RID: 685
		private string estacion;

		// Token: 0x040002AE RID: 686
		private DateTime FechaTicket;

		// Token: 0x040002AF RID: 687
		private string idTurnoTicket;

		// Token: 0x040002B0 RID: 688
		private string DifPorcentajeSin;

		// Token: 0x040002B1 RID: 689
		private DateTime fechaProducto;

		// Token: 0x040002B2 RID: 690
		private string Estacion1;
	}
}
