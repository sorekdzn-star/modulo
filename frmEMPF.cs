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
	// Token: 0x02000017 RID: 23
	[DesignerGenerated]
	public partial class frmEMPF : Form
	{
		// Token: 0x0600085E RID: 2142 RVA: 0x0009A02B File Offset: 0x0009822B
		public frmEMPF()
		{
			base.Load += this.frmEMPF_Load;
			this.table = new DataTable();
			this.view = new DataView(this.table);
			this.InitializeComponent();
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x000A2B1C File Offset: 0x000A0D1C
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x000A2B26 File Offset: 0x000A0D26
		internal virtual GroupBox groupParametros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x000A2B2F File Offset: 0x000A0D2F
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x000A2B3C File Offset: 0x000A0D3C
		internal virtual GroupBox groupPeriodo
		{
			[CompilerGenerated]
			get
			{
				return this._groupPeriodo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.groupPeriodo_Enter);
				GroupBox groupPeriodo = this._groupPeriodo;
				if (groupPeriodo != null)
				{
					groupPeriodo.Enter -= value2;
				}
				this._groupPeriodo = value;
				groupPeriodo = this._groupPeriodo;
				if (groupPeriodo != null)
				{
					groupPeriodo.Enter += value2;
				}
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x000A2B7F File Offset: 0x000A0D7F
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x000A2B8C File Offset: 0x000A0D8C
		internal virtual DateTimePicker dateFechaFin
		{
			[CompilerGenerated]
			get
			{
				return this._dateFechaFin;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.dateFecha_ValueChanged);
				DateTimePicker dateFechaFin = this._dateFechaFin;
				if (dateFechaFin != null)
				{
					dateFechaFin.ValueChanged -= value2;
				}
				this._dateFechaFin = value;
				dateFechaFin = this._dateFechaFin;
				if (dateFechaFin != null)
				{
					dateFechaFin.ValueChanged += value2;
				}
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x000A2BCF File Offset: 0x000A0DCF
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x000A2BD9 File Offset: 0x000A0DD9
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x000A2BE2 File Offset: 0x000A0DE2
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x000A2BEC File Offset: 0x000A0DEC
		internal virtual DateTimePicker dateFechaIni
		{
			[CompilerGenerated]
			get
			{
				return this._dateFechaIni;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.dateFecha_ValueChanged);
				DateTimePicker dateFechaIni = this._dateFechaIni;
				if (dateFechaIni != null)
				{
					dateFechaIni.ValueChanged -= value2;
				}
				this._dateFechaIni = value;
				dateFechaIni = this._dateFechaIni;
				if (dateFechaIni != null)
				{
					dateFechaIni.ValueChanged += value2;
				}
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x000A2C2F File Offset: 0x000A0E2F
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x000A2C39 File Offset: 0x000A0E39
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x000A2C42 File Offset: 0x000A0E42
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x000A2C4C File Offset: 0x000A0E4C
		internal virtual ComboBox cmbxEmpresa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x000A2C55 File Offset: 0x000A0E55
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x000A2C5F File Offset: 0x000A0E5F
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x000A2C68 File Offset: 0x000A0E68
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x000A2C72 File Offset: 0x000A0E72
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x000A2C7B File Offset: 0x000A0E7B
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x000A2C88 File Offset: 0x000A0E88
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

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x000A2CE6 File Offset: 0x000A0EE6
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x000A2CF0 File Offset: 0x000A0EF0
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x000A2CF9 File Offset: 0x000A0EF9
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x000A2D04 File Offset: 0x000A0F04
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

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x000A2D62 File Offset: 0x000A0F62
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x000A2D6C File Offset: 0x000A0F6C
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x000A2D75 File Offset: 0x000A0F75
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x000A2D80 File Offset: 0x000A0F80
		internal virtual ComboBox cmbxTipo
		{
			[CompilerGenerated]
			get
			{
				return this._cmbxTipo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cmbxTipo_SelectedIndexChanged);
				ComboBox cmbxTipo = this._cmbxTipo;
				if (cmbxTipo != null)
				{
					cmbxTipo.SelectedIndexChanged -= value2;
				}
				this._cmbxTipo = value;
				cmbxTipo = this._cmbxTipo;
				if (cmbxTipo != null)
				{
					cmbxTipo.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x000A2DC3 File Offset: 0x000A0FC3
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x000A2DCD File Offset: 0x000A0FCD
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x000A2DD6 File Offset: 0x000A0FD6
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x000A2DE0 File Offset: 0x000A0FE0
		internal virtual CheckBox chkReimpresas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x000A2DE9 File Offset: 0x000A0FE9
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x000A2DF3 File Offset: 0x000A0FF3
		internal virtual CheckBox chkFacturada { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x000A2DFC File Offset: 0x000A0FFC
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x000A2E06 File Offset: 0x000A1006
		internal virtual CheckBox chkReemplazar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x000A2E0F File Offset: 0x000A100F
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x000A2E19 File Offset: 0x000A1019
		internal virtual CheckBox chkEfectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x000A2E22 File Offset: 0x000A1022
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x000A2E2C File Offset: 0x000A102C
		internal virtual CheckBox chkNotaConsumo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x000A2E35 File Offset: 0x000A1035
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x000A2E3F File Offset: 0x000A103F
		internal virtual CheckBox chkOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x000A2E48 File Offset: 0x000A1048
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x000A2E52 File Offset: 0x000A1052
		internal virtual CheckBox chkVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x000A2E5B File Offset: 0x000A105B
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x000A2E65 File Offset: 0x000A1065
		internal virtual CheckBox chkTarjCred { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x000A2E6E File Offset: 0x000A106E
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x000A2E78 File Offset: 0x000A1078
		internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x000A2E81 File Offset: 0x000A1081
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x000A2E8C File Offset: 0x000A108C
		internal virtual ComboBox cmbxSerie
		{
			[CompilerGenerated]
			get
			{
				return this._cmbxSerie;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cmbxSerie_SelectedIndexChanged);
				ComboBox cmbxSerie = this._cmbxSerie;
				if (cmbxSerie != null)
				{
					cmbxSerie.SelectedIndexChanged -= value2;
				}
				this._cmbxSerie = value;
				cmbxSerie = this._cmbxSerie;
				if (cmbxSerie != null)
				{
					cmbxSerie.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x000A2ECF File Offset: 0x000A10CF
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x000A2ED9 File Offset: 0x000A10D9
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x000A2EE2 File Offset: 0x000A10E2
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x000A2EEC File Offset: 0x000A10EC
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

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x000A2F2F File Offset: 0x000A112F
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x000A2F39 File Offset: 0x000A1139
		internal virtual DateTimePicker dateHoraFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x000A2F42 File Offset: 0x000A1142
		// (set) Token: 0x0600089A RID: 2202 RVA: 0x000A2F4C File Offset: 0x000A114C
		internal virtual DateTimePicker dateHoraIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x000A2F55 File Offset: 0x000A1155
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x000A2F5F File Offset: 0x000A115F
		internal virtual CheckBox chkCtasCortesia { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x000A2F68 File Offset: 0x000A1168
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x000A2F72 File Offset: 0x000A1172
		internal virtual CheckBox chkRenumerar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x000A2F7B File Offset: 0x000A117B
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x000A2F85 File Offset: 0x000A1185
		internal virtual TextBox txtObjetivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x000A2F8E File Offset: 0x000A118E
		// (set) Token: 0x060008A2 RID: 2210 RVA: 0x000A2F98 File Offset: 0x000A1198
		internal virtual ProgressBar progBar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x000A2FA1 File Offset: 0x000A11A1
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x000A2FAB File Offset: 0x000A11AB
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x000A2FB4 File Offset: 0x000A11B4
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x000A2FBE File Offset: 0x000A11BE
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x000A2FC7 File Offset: 0x000A11C7
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x000A2FD4 File Offset: 0x000A11D4
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

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x000A3017 File Offset: 0x000A1217
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x000A3021 File Offset: 0x000A1221
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x000A302A File Offset: 0x000A122A
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x000A3034 File Offset: 0x000A1234
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

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x000A3077 File Offset: 0x000A1277
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x000A3081 File Offset: 0x000A1281
		internal virtual CheckBox chkEliminaRet { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x000A308A File Offset: 0x000A128A
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x000A3094 File Offset: 0x000A1294
		internal virtual CheckBox chkEliminaProp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x000A309D File Offset: 0x000A129D
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x000A30A8 File Offset: 0x000A12A8
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

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x000A30EB File Offset: 0x000A12EB
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x000A30F5 File Offset: 0x000A12F5
		internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x000A30FE File Offset: 0x000A12FE
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x000A3108 File Offset: 0x000A1308
		internal virtual Label lblfechahoy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x000A3111 File Offset: 0x000A1311
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x000A311B File Offset: 0x000A131B
		internal virtual Label lblFechaFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x000A3124 File Offset: 0x000A1324
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x000A312E File Offset: 0x000A132E
		internal virtual Label lblFechaInicio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x000A3137 File Offset: 0x000A1337
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x000A3141 File Offset: 0x000A1341
		internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x000A314A File Offset: 0x000A134A
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x000A3154 File Offset: 0x000A1354
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
				DataGridViewCellEventHandler value5 = new DataGridViewCellEventHandler(this.dgvNotas_CellContextMenuStripChanged);
				DataGridView dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellClick -= value2;
					dgvNotas.MouseUp -= value3;
					dgvNotas.CellContentClick -= value4;
					dgvNotas.CellContextMenuStripChanged -= value5;
				}
				this._dgvNotas = value;
				dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellClick += value2;
					dgvNotas.MouseUp += value3;
					dgvNotas.CellContentClick += value4;
					dgvNotas.CellContextMenuStripChanged += value5;
				}
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x000A31F4 File Offset: 0x000A13F4
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x000A3200 File Offset: 0x000A1400
		internal virtual Panel lbl41
		{
			[CompilerGenerated]
			get
			{
				return this._lbl41;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.Panel2_Paint);
				Panel lbl = this._lbl41;
				if (lbl != null)
				{
					lbl.Paint -= value2;
				}
				this._lbl41 = value;
				lbl = this._lbl41;
				if (lbl != null)
				{
					lbl.Paint += value2;
				}
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x000A3243 File Offset: 0x000A1443
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x000A324D File Offset: 0x000A144D
		internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x000A3256 File Offset: 0x000A1456
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x000A3260 File Offset: 0x000A1460
		internal virtual TextBox txtretirostotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x000A3269 File Offset: 0x000A1469
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x000A3273 File Offset: 0x000A1473
		internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x000A327C File Offset: 0x000A147C
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x000A3286 File Offset: 0x000A1486
		internal virtual TextBox txtTotalPropinas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x000A328F File Offset: 0x000A148F
		// (set) Token: 0x060008CA RID: 2250 RVA: 0x000A3299 File Offset: 0x000A1499
		internal virtual TextBox txtCuentasModificar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x000A32A2 File Offset: 0x000A14A2
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x000A32AC File Offset: 0x000A14AC
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x000A32B5 File Offset: 0x000A14B5
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x000A32C0 File Offset: 0x000A14C0
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

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x000A3303 File Offset: 0x000A1503
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x000A330D File Offset: 0x000A150D
		internal virtual TextBox txtCuentasTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x000A3316 File Offset: 0x000A1516
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x000A3320 File Offset: 0x000A1520
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

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x000A3363 File Offset: 0x000A1563
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x000A336D File Offset: 0x000A156D
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x000A3376 File Offset: 0x000A1576
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x000A3380 File Offset: 0x000A1580
		internal virtual TextBox txtDifPorcen { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x000A3389 File Offset: 0x000A1589
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x000A3393 File Offset: 0x000A1593
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x000A339C File Offset: 0x000A159C
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x000A33A6 File Offset: 0x000A15A6
		internal virtual TextBox txtEfectivoAnt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x000A33AF File Offset: 0x000A15AF
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x000A33B9 File Offset: 0x000A15B9
		internal virtual TextBox txtEfectivoCaja { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x000A33C2 File Offset: 0x000A15C2
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x000A33CC File Offset: 0x000A15CC
		internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x000A33D5 File Offset: 0x000A15D5
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x000A33DF File Offset: 0x000A15DF
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x000A33E8 File Offset: 0x000A15E8
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x000A33F2 File Offset: 0x000A15F2
		internal virtual TextBox txtDifImporte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x000A33FB File Offset: 0x000A15FB
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x000A3405 File Offset: 0x000A1605
		internal virtual TextBox txtEfectivoFiscal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x000A340E File Offset: 0x000A160E
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x000A3418 File Offset: 0x000A1618
		internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x000A3421 File Offset: 0x000A1621
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x000A342B File Offset: 0x000A162B
		internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x000A3434 File Offset: 0x000A1634
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x000A343E File Offset: 0x000A163E
		internal virtual TextBox txtImpNuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x000A3447 File Offset: 0x000A1647
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x000A3451 File Offset: 0x000A1651
		internal virtual TextBox txtImpAnterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x000A345A File Offset: 0x000A165A
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x000A3464 File Offset: 0x000A1664
		internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x000A346D File Offset: 0x000A166D
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x000A3477 File Offset: 0x000A1677
		internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x000A3480 File Offset: 0x000A1680
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x000A348A File Offset: 0x000A168A
		internal virtual TextBox txtDepositos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x000A3493 File Offset: 0x000A1693
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x000A349D File Offset: 0x000A169D
		internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x000A34A6 File Offset: 0x000A16A6
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x000A34B0 File Offset: 0x000A16B0
		internal virtual TextBox txtVentaFacturada
		{
			[CompilerGenerated]
			get
			{
				return this._txtVentaFacturada;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtVentaFacturada_TextChanged);
				TextBox txtVentaFacturada = this._txtVentaFacturada;
				if (txtVentaFacturada != null)
				{
					txtVentaFacturada.TextChanged -= value2;
				}
				this._txtVentaFacturada = value;
				txtVentaFacturada = this._txtVentaFacturada;
				if (txtVentaFacturada != null)
				{
					txtVentaFacturada.TextChanged += value2;
				}
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x000A34F3 File Offset: 0x000A16F3
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x000A34FD File Offset: 0x000A16FD
		internal virtual Label lblventasinfacturar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x000A3506 File Offset: 0x000A1706
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x000A3510 File Offset: 0x000A1710
		internal virtual TextBox txtventasinfacturar
		{
			[CompilerGenerated]
			get
			{
				return this._txtventasinfacturar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtventasinfacturar_TextChanged);
				TextBox txtventasinfacturar = this._txtventasinfacturar;
				if (txtventasinfacturar != null)
				{
					txtventasinfacturar.TextChanged -= value2;
				}
				this._txtventasinfacturar = value;
				txtventasinfacturar = this._txtventasinfacturar;
				if (txtventasinfacturar != null)
				{
					txtventasinfacturar.TextChanged += value2;
				}
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x000A3553 File Offset: 0x000A1753
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x000A355D File Offset: 0x000A175D
		internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x000A3566 File Offset: 0x000A1766
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x000A3570 File Offset: 0x000A1770
		internal virtual TextBox txtFacturaPUB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x000A3579 File Offset: 0x000A1779
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x000A3583 File Offset: 0x000A1783
		internal virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x000A358C File Offset: 0x000A178C
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x000A3598 File Offset: 0x000A1798
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

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x000A35DB File Offset: 0x000A17DB
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x000A35E5 File Offset: 0x000A17E5
		internal virtual Label lblventaenVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x000A35EE File Offset: 0x000A17EE
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x000A35F8 File Offset: 0x000A17F8
		internal virtual TextBox txtVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x000A3601 File Offset: 0x000A1801
		// (set) Token: 0x06000908 RID: 2312 RVA: 0x000A360B File Offset: 0x000A180B
		internal virtual Label lblventaenotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x000A3614 File Offset: 0x000A1814
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x000A361E File Offset: 0x000A181E
		internal virtual TextBox txtVentasOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x000A3627 File Offset: 0x000A1827
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x000A3631 File Offset: 0x000A1831
		internal virtual Label lblVentaentarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x000A363A File Offset: 0x000A183A
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x000A3644 File Offset: 0x000A1844
		internal virtual TextBox txtVentaTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x000A364D File Offset: 0x000A184D
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x000A3657 File Offset: 0x000A1857
		internal virtual Label lbldifvales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x000A3660 File Offset: 0x000A1860
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x000A366A File Offset: 0x000A186A
		internal virtual TextBox txtdifvales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x000A3673 File Offset: 0x000A1873
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x000A367D File Offset: 0x000A187D
		internal virtual Label lbldifotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x000A3686 File Offset: 0x000A1886
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x000A3690 File Offset: 0x000A1890
		internal virtual TextBox txtdifotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x000A3699 File Offset: 0x000A1899
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x000A36A3 File Offset: 0x000A18A3
		internal virtual Label lbldifTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x000A36AC File Offset: 0x000A18AC
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x000A36B6 File Offset: 0x000A18B6
		internal virtual TextBox txtDifTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x000A36BF File Offset: 0x000A18BF
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x000A36C9 File Offset: 0x000A18C9
		internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x000A36D2 File Offset: 0x000A18D2
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x000A36DC File Offset: 0x000A18DC
		internal virtual TextBox txtPropinasNuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x000A36E5 File Offset: 0x000A18E5
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x000A36EF File Offset: 0x000A18EF
		internal virtual Panel Panelvercortes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x000A36F8 File Offset: 0x000A18F8
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x000A3702 File Offset: 0x000A1902
		internal virtual Label Label38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x000A370B File Offset: 0x000A190B
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x000A3715 File Offset: 0x000A1915
		internal virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x000A371E File Offset: 0x000A191E
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x000A3728 File Offset: 0x000A1928
		internal virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x000A3731 File Offset: 0x000A1931
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x000A373B File Offset: 0x000A193B
		internal virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x000A3744 File Offset: 0x000A1944
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x000A374E File Offset: 0x000A194E
		internal virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x000A3757 File Offset: 0x000A1957
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x000A3761 File Offset: 0x000A1961
		internal virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x000A376A File Offset: 0x000A196A
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x000A3774 File Offset: 0x000A1974
		internal virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x000A377D File Offset: 0x000A197D
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x000A3787 File Offset: 0x000A1987
		internal virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x000A3790 File Offset: 0x000A1990
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x000A379A File Offset: 0x000A199A
		internal virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x000A37A3 File Offset: 0x000A19A3
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x000A37AD File Offset: 0x000A19AD
		internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x000A37B6 File Offset: 0x000A19B6
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x000A37C0 File Offset: 0x000A19C0
		internal virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x000A37C9 File Offset: 0x000A19C9
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x000A37D3 File Offset: 0x000A19D3
		internal virtual Label lblcortetarjetaanterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x000A37DC File Offset: 0x000A19DC
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x000A37E6 File Offset: 0x000A19E6
		internal virtual Label lblcorteefectivoanterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x000A37EF File Offset: 0x000A19EF
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x000A37F9 File Offset: 0x000A19F9
		internal virtual Label lblcorteanteriorotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x000A3802 File Offset: 0x000A1A02
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x000A380C File Offset: 0x000A1A0C
		internal virtual Label lblcorteanteriorvales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x000A3815 File Offset: 0x000A1A15
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x000A381F File Offset: 0x000A1A1F
		internal virtual Label lblcorteanteriordepositosenefectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x000A3828 File Offset: 0x000A1A28
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x000A3832 File Offset: 0x000A1A32
		internal virtual Label lblcorteanteriorretirosefectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x000A383B File Offset: 0x000A1A3B
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x000A3845 File Offset: 0x000A1A45
		internal virtual Label lblcorteanteriorpropinas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x000A384E File Offset: 0x000A1A4E
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x000A3858 File Offset: 0x000A1A58
		internal virtual Label lblcorteanteriorsaldo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x000A3861 File Offset: 0x000A1A61
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x000A386B File Offset: 0x000A1A6B
		internal virtual Label lblcorteanteriorefectivofinal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x000A3874 File Offset: 0x000A1A74
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x000A387E File Offset: 0x000A1A7E
		internal virtual Label Label41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x000A3887 File Offset: 0x000A1A87
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x000A3891 File Offset: 0x000A1A91
		internal virtual Label Label42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x000A389A File Offset: 0x000A1A9A
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x000A38A4 File Offset: 0x000A1AA4
		internal virtual Label Label43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x000A38AD File Offset: 0x000A1AAD
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x000A38B7 File Offset: 0x000A1AB7
		internal virtual Label Label44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x000A38C0 File Offset: 0x000A1AC0
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x000A38CA File Offset: 0x000A1ACA
		internal virtual Label Label45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x000A38D3 File Offset: 0x000A1AD3
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x000A38DD File Offset: 0x000A1ADD
		internal virtual Label Label46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x000A38E6 File Offset: 0x000A1AE6
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x000A38F0 File Offset: 0x000A1AF0
		internal virtual Label Label47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x000A38F9 File Offset: 0x000A1AF9
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x000A3903 File Offset: 0x000A1B03
		internal virtual Label Label48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x000A390C File Offset: 0x000A1B0C
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x000A3916 File Offset: 0x000A1B16
		internal virtual Label Label49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x000A391F File Offset: 0x000A1B1F
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x000A3929 File Offset: 0x000A1B29
		internal virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x000A3932 File Offset: 0x000A1B32
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x000A393C File Offset: 0x000A1B3C
		internal virtual Label lblcortefondoinicialanterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x000A3945 File Offset: 0x000A1B45
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x000A394F File Offset: 0x000A1B4F
		internal virtual Label lblfondoinicialnuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x000A3958 File Offset: 0x000A1B58
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x000A3962 File Offset: 0x000A1B62
		internal virtual Label lblcorteefectivonuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x000A396B File Offset: 0x000A1B6B
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x000A3978 File Offset: 0x000A1B78
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

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x000A39BB File Offset: 0x000A1BBB
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x000A39C5 File Offset: 0x000A1BC5
		internal virtual Label lblcortetarjetanuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x000A39CE File Offset: 0x000A1BCE
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x000A39D8 File Offset: 0x000A1BD8
		internal virtual Label lblcortenuevovales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x000A39E1 File Offset: 0x000A1BE1
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x000A39EB File Offset: 0x000A1BEB
		internal virtual Label lblcortenuevotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x000A39F4 File Offset: 0x000A1BF4
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x000A39FE File Offset: 0x000A1BFE
		internal virtual Label lblcortenuevodepositos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x000A3A07 File Offset: 0x000A1C07
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x000A3A11 File Offset: 0x000A1C11
		internal virtual Label lblcortenuevoretiros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x000A3A1A File Offset: 0x000A1C1A
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x000A3A24 File Offset: 0x000A1C24
		internal virtual Label lblpropinascortenuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x000A3A2D File Offset: 0x000A1C2D
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x000A3A37 File Offset: 0x000A1C37
		internal virtual Label lblsaldofinarlcortenuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x000A3A40 File Offset: 0x000A1C40
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x000A3A4A File Offset: 0x000A1C4A
		internal virtual Label lblEfectivonuevocorte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x000A3A53 File Offset: 0x000A1C53
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x000A3A5D File Offset: 0x000A1C5D
		internal virtual Label Label51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x000A3A66 File Offset: 0x000A1C66
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x000A3A70 File Offset: 0x000A1C70
		internal virtual Label Label52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x000A3A79 File Offset: 0x000A1C79
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x000A3A83 File Offset: 0x000A1C83
		internal virtual CheckBox CheckBoxfondocaja { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x000A3A8C File Offset: 0x000A1C8C
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x000A3A96 File Offset: 0x000A1C96
		internal virtual Label Label50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x000A3A9F File Offset: 0x000A1C9F
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x000A3AA9 File Offset: 0x000A1CA9
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x000A3AB2 File Offset: 0x000A1CB2
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x000A3ABC File Offset: 0x000A1CBC
		internal virtual Label Label54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x000A3AC5 File Offset: 0x000A1CC5
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x000A3ACF File Offset: 0x000A1CCF
		internal virtual Panel Panel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x000A3AD8 File Offset: 0x000A1CD8
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x000A3AE2 File Offset: 0x000A1CE2
		internal virtual DataGridView DataGridFoliosRenumerar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x000A3AEB File Offset: 0x000A1CEB
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x000A3AF5 File Offset: 0x000A1CF5
		internal virtual Label lblpuerto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x000A3AFE File Offset: 0x000A1CFE
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x000A3B08 File Offset: 0x000A1D08
		internal virtual Label lblfechayhora { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x000A3B11 File Offset: 0x000A1D11
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x000A3B1B File Offset: 0x000A1D1B
		internal virtual Label lblemail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x000A3B24 File Offset: 0x000A1D24
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x000A3B2E File Offset: 0x000A1D2E
		internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x000A3B37 File Offset: 0x000A1D37
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x000A3B44 File Offset: 0x000A1D44
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

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x000A3B87 File Offset: 0x000A1D87
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x000A3B94 File Offset: 0x000A1D94
		internal virtual PictureBox PictureBox5
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox5_Click);
				PictureBox pictureBox = this._PictureBox5;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox5 = value;
				pictureBox = this._PictureBox5;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x000A3BD7 File Offset: 0x000A1DD7
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x000A3BE1 File Offset: 0x000A1DE1
		internal virtual Label lblOrdenDeCuentas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x000A3BEA File Offset: 0x000A1DEA
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x000A3BF4 File Offset: 0x000A1DF4
		internal virtual Label lblFolioIni
		{
			[CompilerGenerated]
			get
			{
				return this._lblFolioIni;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lblFolioIni_Click);
				Label lblFolioIni = this._lblFolioIni;
				if (lblFolioIni != null)
				{
					lblFolioIni.Click -= value2;
				}
				this._lblFolioIni = value;
				lblFolioIni = this._lblFolioIni;
				if (lblFolioIni != null)
				{
					lblFolioIni.Click += value2;
				}
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x000A3C37 File Offset: 0x000A1E37
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x000A3C41 File Offset: 0x000A1E41
		internal virtual Label Label55 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x000A3C4A File Offset: 0x000A1E4A
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x000A3C54 File Offset: 0x000A1E54
		internal virtual CheckBox CheckBoxCuentasCanceladas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x000A3C5D File Offset: 0x000A1E5D
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x000A3C67 File Offset: 0x000A1E67
		internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x000A3C70 File Offset: 0x000A1E70
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x000A3C7A File Offset: 0x000A1E7A
		internal virtual Label lblfecha_btm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x000A3C83 File Offset: 0x000A1E83
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x000A3C8D File Offset: 0x000A1E8D
		internal virtual Label lbltipobarrido { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x000A3C96 File Offset: 0x000A1E96
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x000A3CA0 File Offset: 0x000A1EA0
		internal virtual Label lblAfectadboreal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x000A3CA9 File Offset: 0x000A1EA9
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x000A3CB4 File Offset: 0x000A1EB4
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
				EventHandler value2 = new EventHandler(this.Button1_Click_1);
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

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x000A3D12 File Offset: 0x000A1F12
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x000A3D1C File Offset: 0x000A1F1C
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

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x000A3D5F File Offset: 0x000A1F5F
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x000A3D69 File Offset: 0x000A1F69
		internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x000A3D72 File Offset: 0x000A1F72
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x000A3D7C File Offset: 0x000A1F7C
		internal virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x000A3D85 File Offset: 0x000A1F85
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x000A3D8F File Offset: 0x000A1F8F
		internal virtual Label lblfacturapubnew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x000A3D98 File Offset: 0x000A1F98
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x000A3DA2 File Offset: 0x000A1FA2
		internal virtual Label lblventasinfacturarnew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x000A3DAB File Offset: 0x000A1FAB
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x000A3DB5 File Offset: 0x000A1FB5
		internal virtual Label lblventafacturanew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x000A3DBE File Offset: 0x000A1FBE
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x000A3DC8 File Offset: 0x000A1FC8
		internal virtual Label lblfacturapub { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x000A3DD1 File Offset: 0x000A1FD1
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x000A3DDB File Offset: 0x000A1FDB
		internal virtual Label lblventasinfacturarcorte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x000A3DE4 File Offset: 0x000A1FE4
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x000A3DEE File Offset: 0x000A1FEE
		internal virtual Label lblventaFacturada { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x000A3DF7 File Offset: 0x000A1FF7
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x000A3E01 File Offset: 0x000A2001
		internal virtual Label Label60 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x000A3E0A File Offset: 0x000A200A
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x000A3E14 File Offset: 0x000A2014
		internal virtual Label Label61 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x000A3E1D File Offset: 0x000A201D
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x000A3E27 File Offset: 0x000A2027
		internal virtual Label Label62 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x000A3E30 File Offset: 0x000A2030
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x000A3E3A File Offset: 0x000A203A
		internal virtual Label Label59 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x000A3E43 File Offset: 0x000A2043
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x000A3E4D File Offset: 0x000A204D
		internal virtual Label Label58 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x000A3E56 File Offset: 0x000A2056
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x000A3E60 File Offset: 0x000A2060
		internal virtual Label Label57 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x000A3E69 File Offset: 0x000A2069
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x000A3E73 File Offset: 0x000A2073
		internal virtual Label Label53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x000A3E7C File Offset: 0x000A207C
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x000A3E86 File Offset: 0x000A2086
		internal virtual Label Label56 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x000A3E8F File Offset: 0x000A208F
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x000A3E99 File Offset: 0x000A2099
		internal virtual Label lblCOdigoUnicoCorte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x000A3EA2 File Offset: 0x000A20A2
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x000A3EAC File Offset: 0x000A20AC
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

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x000A3EEF File Offset: 0x000A20EF
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x000A3EF9 File Offset: 0x000A20F9
		internal virtual DataGridView DataGridView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060009CB RID: 2507 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dateFecha_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000A3F04 File Offset: 0x000A2104
		private void iniciaGridFolio()
		{
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			this.dgvNotas.Rows.Clear();
			this.dgvNotas.ColumnCount = 18;
			this.dgvNotas.Columns[0].Name = "id_nota";
			this.dgvNotas.Columns[0].Visible = false;
			this.dgvNotas.Columns[1].Name = "Serie";
			this.dgvNotas.Columns[1].Width = 50;
			this.dgvNotas.Columns[2].Name = "Folio Cuenta";
			this.dgvNotas.Columns[2].Width = 70;
			this.dgvNotas.Columns[3].Name = "Folio Nota Consumo";
			this.dgvNotas.Columns[3].Width = 70;
			this.dgvNotas.Columns[4].Name = "Mesa";
			this.dgvNotas.Columns[4].Width = 70;
			this.dgvNotas.Columns[5].Name = "Fecha";
			this.dgvNotas.Columns[5].Width = 170;
			this.dgvNotas.Columns[6].Name = "Cancel.";
			this.dgvNotas.Columns[6].Width = 50;
			this.dgvNotas.Columns[7].Name = "Facturado";
			this.dgvNotas.Columns[7].Width = 70;
			this.dgvNotas.Columns[8].Name = "Descto %";
			this.dgvNotas.Columns[8].Width = 60;
			this.dgvNotas.Columns[9].Name = "Total Original";
			this.dgvNotas.Columns[9].Width = 80;
			this.dgvNotas.Columns[10].Name = "Prod. Eliminados";
			this.dgvNotas.Columns[10].Width = 80;
			this.dgvNotas.Columns[10].Visible = false;
			this.dgvNotas.Columns[11].Name = "Total con Descuento";
			this.dgvNotas.Columns[11].Width = 80;
			this.dgvNotas.Columns[11].Visible = false;
			this.dgvNotas.Columns[12].Name = "Efectivo";
			this.dgvNotas.Columns[12].Width = 80;
			this.dgvNotas.Columns[13].Name = "Tarjeta";
			this.dgvNotas.Columns[13].Width = 80;
			this.dgvNotas.Columns[14].Name = "Vales";
			this.dgvNotas.Columns[14].Width = 80;
			this.dgvNotas.Columns[15].Name = "Otros";
			this.dgvNotas.Columns[15].Width = 80;
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

		// Token: 0x060009CD RID: 2509 RVA: 0x000A4390 File Offset: 0x000A2590
		public void ObtenerFolioSerie()
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			try
			{
				string query_conn = "SELECT f from H";
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
				bool hasRows = sqlDataReader.HasRows;
				if (hasRows)
				{
					while (sqlDataReader.Read())
					{
						string text = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
						this.lblFolioIni.Text = text.ToString();
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000A4424 File Offset: 0x000A2624
		public void ActulizarORden()
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "Select ac from H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool flag = sqlDataReader.Read();
			if (flag)
			{
				string left = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				bool flag2 = Operators.CompareString(left, "0", false) == 0;
				if (flag2)
				{
					this.lblOrdenDeCuentas.Text = "Orden de Cuentas Continuo";
				}
				bool flag3 = Operators.CompareString(left, "1", false) == 0;
				if (flag3)
				{
					this.lblOrdenDeCuentas.Text = "Orden de Cuentas Aleatorio";
				}
			}
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000A44C0 File Offset: 0x000A26C0
		private void frmEMPF_Load(object sender, EventArgs e)
		{
			this.DoubleBufferedASD(this.dgvNotas, true);
			this.Panelvercortes.Visible = false;
			this.btnCorteZ.Enabled = false;
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
			this.cmbAnio.Enabled = true;
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
			this.ActulizarORden();
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
			this.Button2.Enabled = false;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000A483C File Offset: 0x000A2A3C
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
			this.cmbxTipo.Items.Add("Eliminar Folios");
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

		// Token: 0x060009D1 RID: 2513 RVA: 0x000036D5 File Offset: 0x000018D5
		private void cmbxTipo_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000036D5 File Offset: 0x000018D5
		private void cmbxSerie_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000A49B8 File Offset: 0x000A2BB8
		private void btnVistaPrevia_Click(object sender, EventArgs e)
		{
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
					}
				}
				sqlDataReader.Close();
				this.ObtenerFolioSerie();
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000A4F2C File Offset: 0x000A312C
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000A4F60 File Offset: 0x000A3160
		private void iniciaGriSeriesFolios()
		{
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			this.DataGridFoliosRenumerar.Rows.Clear();
			this.DataGridFoliosRenumerar.ColumnCount = 2;
			this.DataGridFoliosRenumerar.Columns[0].Name = "Serie";
			this.DataGridFoliosRenumerar.Columns[0].Visible = true;
			this.DataGridFoliosRenumerar.Columns[0].Width = 100;
			this.DataGridFoliosRenumerar.Columns[1].Name = "Folio";
			this.DataGridFoliosRenumerar.Columns[1].Width = 100;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000A5014 File Offset: 0x000A3214
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
			double num11;
			double num13;
			if (flag2)
			{
				string left = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				bool flag3 = Operators.CompareString(left, "0", false) == 0;
				bool flag9;
				double num10;
				double num12;
				if (flag3)
				{
					bool flag4 = Operators.CompareString(text3, "Todas", false) == 0;
					if (flag4)
					{
						text4 = string.Concat(new string[]
						{
							"SELECT folio,numcheque,fecha,cancelado,facturado, \r\n                    folionotadeconsumo,impresiones,descuento,total,efectivo,\r\n                    tarjeta,vales,otros,notadeconsumo,propinafoliomovtocaja,propina,seriefolio,mesa from cheques \r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
						bool hasRows = sqlDataReader.HasRows;
						if (hasRows)
						{
							checked
							{
								while (sqlDataReader.Read())
								{
									bool flag5 = Operators.ConditionalCompareObjectLessEqual(this.iFolioInicial, 0, false);
									if (flag5)
									{
										this.iFolioInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
										this.iNumChequeInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[1]);
									}
									string text5 = Conversions.ToString(sqlDataReader[0]);
									int num3 = Conversions.ToInteger(sqlDataReader[1]);
									string text6 = Conversions.ToString(sqlDataReader[2]);
									bool flag6 = Operators.ConditionalCompareObjectEqual(sqlDataReader[3], true, false);
									string text7;
									if (flag6)
									{
										text7 = "Si";
									}
									else
									{
										text7 = "No";
									}
									bool flag7 = Operators.ConditionalCompareObjectEqual(sqlDataReader[4], true, false);
									string text8;
									if (flag7)
									{
										text8 = "Si";
									}
									else
									{
										text8 = "No";
									}
									string text9 = Conversions.ToString(sqlDataReader[5]);
									string value = Conversions.ToString(sqlDataReader[6]);
									string text10 = Conversions.ToString(Conversions.ToInteger(sqlDataReader[7]));
									double num4 = Conversions.ToDouble(sqlDataReader[8]);
									double num5 = Conversions.ToDouble(sqlDataReader[9]);
									double num6 = Conversions.ToDouble(sqlDataReader[10]);
									double num7 = Conversions.ToDouble(sqlDataReader[11]);
									double num8 = Conversions.ToDouble(sqlDataReader[12]);
									string text11 = Conversions.ToString(sqlDataReader[13]);
									string text12 = Conversions.ToString(sqlDataReader[14]);
									double num9 = Conversions.ToDouble(sqlDataReader[15]);
									string text13 = Conversions.ToString(sqlDataReader[16]);
									string text14 = Conversions.ToString(sqlDataReader[17]);
									bool flag8 = this.chkTarjCred.Checked & num6 > 0.0;
									if (flag8)
									{
										flag9 = true;
									}
									bool flag10 = this.chkVales.Checked & num7 > 0.0;
									if (flag10)
									{
										flag9 = true;
									}
									bool flag11 = this.chkFacturada.Checked & Operators.CompareString(text8, "Si", false) == 0;
									if (flag11)
									{
										flag9 = true;
									}
									bool flag12 = this.chkOtros.Checked & num8 > 0.0;
									if (flag12)
									{
										flag9 = true;
									}
									bool flag13 = this.chkEfectivo.Checked & num5 > 0.0;
									if (flag13)
									{
										flag9 = true;
									}
									bool flag14 = this.chkCtasCortesia.Checked & Operators.CompareString(text10, "100", false) == 0;
									if (flag14)
									{
										flag9 = true;
									}
									bool flag15 = this.chkNotaConsumo.Checked & Operators.CompareString(text9, "0", false) != 0;
									if (flag15)
									{
										flag9 = true;
									}
									bool flag16 = !this.chkTarjCred.Checked & num6 > 0.0;
									if (flag16)
									{
										flag9 = false;
									}
									bool flag17 = !this.chkVales.Checked & num7 > 0.0;
									if (flag17)
									{
										flag9 = false;
									}
									bool flag18 = !this.chkFacturada.Checked & Operators.CompareString(text8, "Si", false) == 0;
									if (flag18)
									{
										flag9 = false;
									}
									bool flag19 = !this.chkOtros.Checked & num8 > 0.0;
									if (flag19)
									{
										flag9 = false;
									}
									bool flag20 = !this.chkEfectivo.Checked & num5 > 0.0;
									if (flag20)
									{
										flag9 = false;
									}
									bool flag21 = !this.chkCtasCortesia.Checked & Operators.CompareString(text10, "100", false) == 0;
									if (flag21)
									{
										flag9 = false;
									}
									bool flag22 = !this.chkNotaConsumo.Checked & Operators.CompareString(text9, "0", false) != 0;
									if (flag22)
									{
										flag9 = false;
									}
									bool flag23 = this.chkReimpresas.Checked & Conversions.ToDouble(value) > 1.0;
									if (flag23)
									{
										flag9 = false;
									}
									bool flag24 = (this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0) | num4 == 0.0;
									if (flag24)
									{
										flag9 = true;
									}
									bool flag25 = (!this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0) | num4 == 0.0;
									if (flag25)
									{
										flag9 = false;
									}
									bool flag26 = Operators.CompareString(this.txtMinimo.Text, "", false) != 0;
									if (flag26)
									{
									}
									this.dgvNotas.Rows.Add(new object[]
									{
										text5,
										text13,
										num3,
										text9,
										text14,
										text6,
										text7,
										text8,
										text10,
										num4,
										"X",
										"X",
										num5,
										num6,
										num7,
										num8,
										text12,
										num9,
										flag9
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
								bool flag27 = sqlDataReader.Read();
								if (flag27)
								{
									num10 = Conversions.ToDouble(sqlDataReader[0]);
								}
							}
							num11 += num10;
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
							bool flag28 = sqlDataReader.Read();
							if (flag28)
							{
								num12 = Conversions.ToDouble(sqlDataReader[0]);
							}
							num13 += num12;
						}
						sqlDataReader.Close();
						this.iniciaGriSeriesFolios();
						text4 = "select distinct serie from folios order by serie asc";
						sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
						bool hasRows2 = sqlDataReader.HasRows;
						if (hasRows2)
						{
							while (sqlDataReader.Read())
							{
								string text15 = Conversions.ToString(sqlDataReader[0]);
								this.DataGridFoliosRenumerar.Rows.Add(new object[]
								{
									text15
								});
							}
							sqlDataReader.Close();
						}
						try
						{
							foreach (object obj in ((IEnumerable)this.DataGridFoliosRenumerar.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								string text16 = Conversions.ToString(dataGridViewRow.Cells["Serie"].Value);
								text4 = string.Concat(new string[]
								{
									"SELECT Top 1 Numcheque from cheques \r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                    cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                    and idempresa='",
									Tools.id_Empresa,
									"' and seriefolio = '",
									text16,
									"' and fecha >= '",
									text,
									"' and Numcheque > 0  order by numcheque asc"
								});
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows3 = sqlDataReader.HasRows;
								if (hasRows3)
								{
									while (sqlDataReader.Read())
									{
										string value2 = Conversions.ToString(sqlDataReader[0]);
										dataGridViewRow.Cells["Folio"].Value = value2;
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
					bool flag29 = Operators.CompareString(text3, "Todas", false) != 0;
					if (flag29)
					{
						text4 = string.Concat(new string[]
						{
							"SELECT folio,numcheque,fecha,cancelado,facturado, \r\n                    folionotadeconsumo,impresiones,descuento,total,efectivo,\r\n                    tarjeta,vales,otros,notadeconsumo,propinafoliomovtocaja,propina,seriefolio,mesa from cheques \r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
									bool flag30 = Operators.ConditionalCompareObjectLessEqual(this.iFolioInicial, 0, false);
									if (flag30)
									{
										this.iFolioInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
										this.iNumChequeInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[1]);
									}
									string text5 = Conversions.ToString(sqlDataReader[0]);
									int num3 = Conversions.ToInteger(sqlDataReader[1]);
									string text6 = Conversions.ToString(sqlDataReader[2]);
									bool flag31 = Operators.ConditionalCompareObjectEqual(sqlDataReader[3], true, false);
									string text7;
									if (flag31)
									{
										text7 = "Si";
									}
									else
									{
										text7 = "No";
									}
									bool flag32 = Operators.ConditionalCompareObjectEqual(sqlDataReader[4], true, false);
									string text8;
									if (flag32)
									{
										text8 = "Si";
									}
									else
									{
										text8 = "No";
									}
									string text9 = Conversions.ToString(sqlDataReader[5]);
									string value = Conversions.ToString(sqlDataReader[6]);
									string text10 = Conversions.ToString(Conversions.ToInteger(sqlDataReader[7]));
									double num4 = Conversions.ToDouble(sqlDataReader[8]);
									double num5 = Conversions.ToDouble(sqlDataReader[9]);
									double num6 = Conversions.ToDouble(sqlDataReader[10]);
									double num7 = Conversions.ToDouble(sqlDataReader[11]);
									double num8 = Conversions.ToDouble(sqlDataReader[12]);
									string text11 = Conversions.ToString(sqlDataReader[13]);
									string text12 = Conversions.ToString(sqlDataReader[14]);
									double num9 = Conversions.ToDouble(sqlDataReader[15]);
									string text13 = Conversions.ToString(sqlDataReader[16]);
									string text14 = Conversions.ToString(sqlDataReader[17]);
									bool flag33 = this.chkTarjCred.Checked & num6 > 0.0;
									if (flag33)
									{
										flag9 = true;
									}
									bool flag34 = this.chkVales.Checked & num7 > 0.0;
									if (flag34)
									{
										flag9 = true;
									}
									bool flag35 = this.chkFacturada.Checked & Operators.CompareString(text8, "Si", false) == 0;
									if (flag35)
									{
										flag9 = true;
									}
									bool flag36 = this.chkOtros.Checked & num8 > 0.0;
									if (flag36)
									{
										flag9 = true;
									}
									bool flag37 = this.chkEfectivo.Checked & num5 > 0.0;
									if (flag37)
									{
										flag9 = true;
									}
									bool flag38 = this.chkCtasCortesia.Checked & Operators.CompareString(text10, "100", false) == 0;
									if (flag38)
									{
										flag9 = true;
									}
									bool flag39 = this.chkNotaConsumo.Checked & Operators.CompareString(text9, "0", false) != 0;
									if (flag39)
									{
										flag9 = true;
									}
									bool flag40 = !this.chkTarjCred.Checked & num6 > 0.0;
									if (flag40)
									{
										flag9 = false;
									}
									bool flag41 = !this.chkVales.Checked & num7 > 0.0;
									if (flag41)
									{
										flag9 = false;
									}
									bool flag42 = !this.chkFacturada.Checked & Operators.CompareString(text8, "Si", false) == 0;
									if (flag42)
									{
										flag9 = false;
									}
									bool flag43 = !this.chkOtros.Checked & num8 > 0.0;
									if (flag43)
									{
										flag9 = false;
									}
									bool flag44 = !this.chkEfectivo.Checked & num5 > 0.0;
									if (flag44)
									{
										flag9 = false;
									}
									bool flag45 = !this.chkCtasCortesia.Checked & Operators.CompareString(text10, "100", false) == 0;
									if (flag45)
									{
										flag9 = false;
									}
									bool flag46 = !this.chkNotaConsumo.Checked & Operators.CompareString(text9, "0", false) != 0;
									if (flag46)
									{
										flag9 = false;
									}
									bool flag47 = this.chkReimpresas.Checked & Conversions.ToDouble(value) > 1.0;
									if (flag47)
									{
										flag9 = false;
									}
									bool flag48 = (this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0) | num4 == 0.0;
									if (flag48)
									{
										flag9 = true;
									}
									bool flag49 = (!this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0) | num4 == 0.0;
									if (flag49)
									{
										flag9 = false;
									}
									bool flag50 = Operators.CompareString(this.txtMinimo.Text, "", false) != 0;
									if (flag50)
									{
									}
									this.dgvNotas.Rows.Add(new object[]
									{
										text5,
										text13,
										num3,
										text9,
										text14,
										text6,
										text7,
										text8,
										text10,
										num4,
										"X",
										"X",
										num5,
										num6,
										num7,
										num8,
										text12,
										num9,
										flag9
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
								bool flag51 = sqlDataReader.Read();
								if (flag51)
								{
									num10 = Conversions.ToDouble(sqlDataReader[0]);
								}
							}
							num11 += num10;
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
							bool flag52 = sqlDataReader.Read();
							if (flag52)
							{
								num12 = Conversions.ToDouble(sqlDataReader[0]);
							}
							num13 += num12;
						}
						sqlDataReader.Close();
					}
				}
				bool flag53 = Operators.CompareString(left, "1", false) == 0;
				if (flag53)
				{
					bool flag54 = Operators.CompareString(text3, "Todas", false) == 0;
					if (flag54)
					{
						text4 = string.Concat(new string[]
						{
							"SELECT folio,numcheque,fecha,cancelado,facturado, \r\n                    folionotadeconsumo,impresiones,descuento,total,efectivo,\r\n                    tarjeta,vales,otros,notadeconsumo,propinafoliomovtocaja,propina,seriefolio,mesa from cheques \r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
						bool hasRows5 = sqlDataReader.HasRows;
						if (hasRows5)
						{
							checked
							{
								while (sqlDataReader.Read())
								{
									bool flag55 = Operators.ConditionalCompareObjectLessEqual(this.iFolioInicial, 0, false);
									if (flag55)
									{
										this.iFolioInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
										this.iNumChequeInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[1]);
									}
									string text5 = Conversions.ToString(sqlDataReader[0]);
									int num3 = Conversions.ToInteger(sqlDataReader[1]);
									string text6 = Conversions.ToString(sqlDataReader[2]);
									bool flag56 = Operators.ConditionalCompareObjectEqual(sqlDataReader[3], true, false);
									string text7;
									if (flag56)
									{
										text7 = "Si";
									}
									else
									{
										text7 = "No";
									}
									bool flag57 = Operators.ConditionalCompareObjectEqual(sqlDataReader[4], true, false);
									string text8;
									if (flag57)
									{
										text8 = "Si";
									}
									else
									{
										text8 = "No";
									}
									string text9 = Conversions.ToString(sqlDataReader[5]);
									string value = Conversions.ToString(sqlDataReader[6]);
									string text10 = Conversions.ToString(Conversions.ToInteger(sqlDataReader[7]));
									double num4 = Conversions.ToDouble(sqlDataReader[8]);
									double num5 = Conversions.ToDouble(sqlDataReader[9]);
									double num6 = Conversions.ToDouble(sqlDataReader[10]);
									double num7 = Conversions.ToDouble(sqlDataReader[11]);
									double num8 = Conversions.ToDouble(sqlDataReader[12]);
									string text11 = Conversions.ToString(sqlDataReader[13]);
									string text12 = Conversions.ToString(sqlDataReader[14]);
									double num9 = Conversions.ToDouble(sqlDataReader[15]);
									string text13 = Conversions.ToString(sqlDataReader[16]);
									string text14 = Conversions.ToString(sqlDataReader[17]);
									bool flag58 = this.chkTarjCred.Checked & num6 > 0.0;
									if (flag58)
									{
										flag9 = true;
									}
									bool flag59 = this.chkVales.Checked & num7 > 0.0;
									if (flag59)
									{
										flag9 = true;
									}
									bool flag60 = this.chkFacturada.Checked & Operators.CompareString(text8, "Si", false) == 0;
									if (flag60)
									{
										flag9 = true;
									}
									bool flag61 = this.chkOtros.Checked & num8 > 0.0;
									if (flag61)
									{
										flag9 = true;
									}
									bool flag62 = this.chkEfectivo.Checked & num5 > 0.0;
									if (flag62)
									{
										flag9 = true;
									}
									bool flag63 = this.chkCtasCortesia.Checked & Operators.CompareString(text10, "100", false) == 0;
									if (flag63)
									{
										flag9 = true;
									}
									bool flag64 = this.chkNotaConsumo.Checked & Operators.CompareString(text9, "0", false) != 0;
									if (flag64)
									{
										flag9 = true;
									}
									bool flag65 = (this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0) | num4 == 0.0;
									if (flag65)
									{
										flag9 = true;
									}
									bool flag66 = !this.chkTarjCred.Checked & num6 > 0.0;
									if (flag66)
									{
										flag9 = false;
									}
									bool flag67 = !this.chkVales.Checked & num7 > 0.0;
									if (flag67)
									{
										flag9 = false;
									}
									bool flag68 = !this.chkFacturada.Checked & Operators.CompareString(text8, "Si", false) == 0;
									if (flag68)
									{
										flag9 = false;
									}
									bool flag69 = !this.chkOtros.Checked & num8 > 0.0;
									if (flag69)
									{
										flag9 = false;
									}
									bool flag70 = !this.chkEfectivo.Checked & num5 > 0.0;
									if (flag70)
									{
										flag9 = false;
									}
									bool flag71 = !this.chkCtasCortesia.Checked & Operators.CompareString(text10, "100", false) == 0;
									if (flag71)
									{
										flag9 = false;
									}
									bool flag72 = !this.chkNotaConsumo.Checked & Operators.CompareString(text9, "0", false) != 0;
									if (flag72)
									{
										flag9 = false;
									}
									bool flag73 = this.chkReimpresas.Checked & Conversions.ToDouble(value) > 1.0;
									if (flag73)
									{
										flag9 = false;
									}
									bool flag74 = (!this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0) | num4 == 0.0;
									if (flag74)
									{
										flag9 = false;
									}
									bool flag75 = Operators.CompareString(this.txtMinimo.Text, "", false) != 0;
									if (flag75)
									{
									}
									this.dgvNotas.Rows.Add(new object[]
									{
										text5,
										text13,
										num3,
										text9,
										text14,
										text6,
										text7,
										text8,
										text10,
										num4,
										"X",
										"X",
										num5,
										num6,
										num7,
										num8,
										text12,
										num9,
										flag9
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
								bool flag76 = sqlDataReader.Read();
								if (flag76)
								{
									num10 = Conversions.ToDouble(sqlDataReader[0]);
								}
							}
							num11 += num10;
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
							bool flag77 = sqlDataReader.Read();
							if (flag77)
							{
								num12 = Conversions.ToDouble(sqlDataReader[0]);
							}
							num13 += num12;
						}
						sqlDataReader.Close();
						this.iniciaGriSeriesFolios();
						text4 = "select distinct serie from folios order by serie asc";
						sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
						bool hasRows6 = sqlDataReader.HasRows;
						if (hasRows6)
						{
							while (sqlDataReader.Read())
							{
								string text17 = Conversions.ToString(sqlDataReader[0]);
								this.DataGridFoliosRenumerar.Rows.Add(new object[]
								{
									text17
								});
							}
							sqlDataReader.Close();
						}
						try
						{
							foreach (object obj2 in ((IEnumerable)this.DataGridFoliosRenumerar.Rows))
							{
								DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
								string text18 = Conversions.ToString(dataGridViewRow2.Cells["Serie"].Value);
								text4 = string.Concat(new string[]
								{
									"SELECT Top 1 Numcheque from cheques \r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                    cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                    and idempresa='",
									Tools.id_Empresa,
									"' and seriefolio = '",
									text18,
									"' and fecha >= '",
									text,
									"' AND NUMCHEQUE > 0  order by seriefolio,numcheque asc"
								});
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows7 = sqlDataReader.HasRows;
								if (hasRows7)
								{
									while (sqlDataReader.Read())
									{
										string value3 = Conversions.ToString(sqlDataReader[0]);
										dataGridViewRow2.Cells["Folio"].Value = value3;
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
					bool flag78 = Operators.CompareString(text3, "Todas", false) != 0;
					if (flag78)
					{
						text4 = string.Concat(new string[]
						{
							"SELECT folio,numcheque,fecha,cancelado,facturado, \r\n                    folionotadeconsumo,impresiones,descuento,total,efectivo,\r\n                    tarjeta,vales,otros,notadeconsumo,propinafoliomovtocaja,propina,seriefolio,mesa from cheques \r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
						bool hasRows8 = sqlDataReader.HasRows;
						if (hasRows8)
						{
							checked
							{
								while (sqlDataReader.Read())
								{
									bool flag79 = Operators.ConditionalCompareObjectLessEqual(this.iFolioInicial, 0, false);
									if (flag79)
									{
										this.iFolioInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[0]);
										this.iNumChequeInicial = RuntimeHelpers.GetObjectValue(sqlDataReader[1]);
									}
									string text5 = Conversions.ToString(sqlDataReader[0]);
									int num3 = Conversions.ToInteger(sqlDataReader[1]);
									string text6 = Conversions.ToString(sqlDataReader[2]);
									bool flag80 = Operators.ConditionalCompareObjectEqual(sqlDataReader[3], true, false);
									string text7;
									if (flag80)
									{
										text7 = "Si";
									}
									else
									{
										text7 = "No";
									}
									bool flag81 = Operators.ConditionalCompareObjectEqual(sqlDataReader[4], true, false);
									string text8;
									if (flag81)
									{
										text8 = "Si";
									}
									else
									{
										text8 = "No";
									}
									string text9 = Conversions.ToString(sqlDataReader[5]);
									string value = Conversions.ToString(sqlDataReader[6]);
									string text10 = Conversions.ToString(Conversions.ToInteger(sqlDataReader[7]));
									double num4 = Conversions.ToDouble(sqlDataReader[8]);
									double num5 = Conversions.ToDouble(sqlDataReader[9]);
									double num6 = Conversions.ToDouble(sqlDataReader[10]);
									double num7 = Conversions.ToDouble(sqlDataReader[11]);
									double num8 = Conversions.ToDouble(sqlDataReader[12]);
									string text11 = Conversions.ToString(sqlDataReader[13]);
									string text12 = Conversions.ToString(sqlDataReader[14]);
									double num9 = Conversions.ToDouble(sqlDataReader[15]);
									string text13 = Conversions.ToString(sqlDataReader[16]);
									string text14 = Conversions.ToString(sqlDataReader[17]);
									bool flag82 = this.chkTarjCred.Checked & num6 > 0.0;
									if (flag82)
									{
										flag9 = true;
									}
									bool flag83 = this.chkVales.Checked & num7 > 0.0;
									if (flag83)
									{
										flag9 = true;
									}
									bool flag84 = this.chkFacturada.Checked & Operators.CompareString(text8, "Si", false) == 0;
									if (flag84)
									{
										flag9 = true;
									}
									bool flag85 = this.chkOtros.Checked & num8 > 0.0;
									if (flag85)
									{
										flag9 = true;
									}
									bool flag86 = this.chkEfectivo.Checked & num5 > 0.0;
									if (flag86)
									{
										flag9 = true;
									}
									bool flag87 = this.chkCtasCortesia.Checked & Operators.CompareString(text10, "100", false) == 0;
									if (flag87)
									{
										flag9 = true;
									}
									bool flag88 = this.chkNotaConsumo.Checked & Operators.CompareString(text9, "0", false) != 0;
									if (flag88)
									{
										flag9 = true;
									}
									bool flag89 = !this.chkTarjCred.Checked & num6 > 0.0;
									if (flag89)
									{
										flag9 = false;
									}
									bool flag90 = !this.chkVales.Checked & num7 > 0.0;
									if (flag90)
									{
										flag9 = false;
									}
									bool flag91 = !this.chkFacturada.Checked & Operators.CompareString(text8, "Si", false) == 0;
									if (flag91)
									{
										flag9 = false;
									}
									bool flag92 = !this.chkOtros.Checked & num8 > 0.0;
									if (flag92)
									{
										flag9 = false;
									}
									bool flag93 = !this.chkEfectivo.Checked & num5 > 0.0;
									if (flag93)
									{
										flag9 = false;
									}
									bool flag94 = !this.chkCtasCortesia.Checked & Operators.CompareString(text10, "100", false) == 0;
									if (flag94)
									{
										flag9 = false;
									}
									bool flag95 = !this.chkNotaConsumo.Checked & Operators.CompareString(text9, "0", false) != 0;
									if (flag95)
									{
										flag9 = false;
									}
									bool flag96 = this.chkReimpresas.Checked & Conversions.ToDouble(value) > 1.0;
									if (flag96)
									{
										flag9 = false;
									}
									bool flag97 = (this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0) | num4 == 0.0;
									if (flag97)
									{
										flag9 = true;
									}
									bool flag98 = (!this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0) | num4 == 0.0;
									if (flag98)
									{
										flag9 = false;
									}
									bool flag99 = Operators.CompareString(this.txtMinimo.Text, "", false) != 0;
									if (flag99)
									{
									}
									this.dgvNotas.Rows.Add(new object[]
									{
										text5,
										text13,
										num3,
										text9,
										text14,
										text6,
										text7,
										text8,
										text10,
										num4,
										"X",
										"X",
										num5,
										num6,
										num7,
										num8,
										text12,
										num9,
										flag9
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
								bool flag100 = sqlDataReader.Read();
								if (flag100)
								{
									num10 = Conversions.ToDouble(sqlDataReader[0]);
								}
							}
							num11 += num10;
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
							bool flag101 = sqlDataReader.Read();
							if (flag101)
							{
								num12 = Conversions.ToDouble(sqlDataReader[0]);
							}
							num13 += num12;
						}
						sqlDataReader.Close();
					}
				}
			}
			SqlQuery sqlQuery2 = new SqlQuery();
			bool flag102 = Operators.CompareString(text3, "Todas", false) == 0;
			if (flag102)
			{
				string query = string.Concat(new string[]
				{
					"SELECT Top 1 Numcheque from cheques \r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"' and fecha >= '",
					text,
					"' AND Numcheque > 0 order by numcheque asc"
				});
				SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery2.execReader(query);
				bool hasRows9 = sqlDataReader2.HasRows;
				if (hasRows9)
				{
					while (sqlDataReader2.Read())
					{
						string text19 = Conversions.ToString(sqlDataReader2[0]);
						string text20 = text3;
						SqlQuery sqlQuery3 = new SqlQuery();
						string query_conn = string.Concat(new string[]
						{
							"Update H set f = '",
							Tools.Encriptar(text19.ToString().Trim()),
							"' , al='",
							Tools.Encriptar(text20.ToString().Trim()),
							"'"
						});
						sqlQuery_Conn.execQuery_conn(query_conn);
					}
				}
				sqlDataReader2.Close();
			}
			bool flag103 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag103)
			{
				string query = string.Concat(new string[]
				{
					"SELECT Top 1 Numcheque from cheques \r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"' and seriefolio = '",
					text3,
					"' and fecha >= '",
					text,
					"' and Numcheque > 0   order by seriefolio,numcheque asc"
				});
				SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery2.execReader(query);
				bool hasRows10 = sqlDataReader2.HasRows;
				if (hasRows10)
				{
					while (sqlDataReader2.Read())
					{
						string text19 = Conversions.ToString(sqlDataReader2[0]);
						string text20 = text3;
						string query_conn2 = string.Concat(new string[]
						{
							"Update H set f = '",
							Tools.Encriptar(text19.ToString().Trim()),
							"' , al='",
							Tools.Encriptar(text20.ToString().Trim()),
							"'"
						});
						sqlQuery_Conn.execQuery_conn(query_conn2);
					}
				}
				sqlDataReader2.Close();
			}
			double num14 = Conversions.ToDouble(this.txtMinimo.Text);
			bool flag104 = Conversions.ToDouble(this.txtMinimo.Text) != 0.0;
			double num15;
			double num16;
			double num17;
			double num18;
			double num19;
			double num20;
			double num21;
			double num22;
			if (flag104)
			{
				num15 = num11 - (num11 - num14);
				try
				{
					foreach (object obj3 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj3;
						bool flag105 = num15 > num11 - num16 && flag;
						if (flag105)
						{
							flag = false;
						}
						bool flag106 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow3.Cells["Eliminar"].Value, true, false), flag));
						if (flag106)
						{
							dataGridViewRow3.DefaultCellStyle.BackColor = Color.Red;
							dataGridViewRow3.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
							num16 += Conversions.ToDouble(dataGridViewRow3.Cells["Total Original"].Value);
							num17 += Conversions.ToDouble(dataGridViewRow3.Cells["Efectivo"].Value);
							num18 += Conversions.ToDouble(dataGridViewRow3.Cells["Tarjeta"].Value);
							num19 += Conversions.ToDouble(dataGridViewRow3.Cells["Otros"].Value);
							num20 += Conversions.ToDouble(dataGridViewRow3.Cells["Vales"].Value);
							num21 += Conversions.ToDouble(dataGridViewRow3.Cells["Propina"].Value);
							bool flag107 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow3.Cells["Facturado"].Value, "Si", false), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Cancel."].Value, "No", false)));
							if (flag107)
							{
								num22 += Conversions.ToDouble(dataGridViewRow3.Cells["Total Original"].Value);
							}
							bool flag108 = Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells["Cancel."].Value, "Si", false);
							if (flag108)
							{
								num16 -= Conversions.ToDouble(dataGridViewRow3.Cells["Total Original"].Value);
								num17 -= Conversions.ToDouble(dataGridViewRow3.Cells["Efectivo"].Value);
								num18 -= Conversions.ToDouble(dataGridViewRow3.Cells["Tarjeta"].Value);
								num19 -= Conversions.ToDouble(dataGridViewRow3.Cells["Otros"].Value);
								num20 -= Conversions.ToDouble(dataGridViewRow3.Cells["Vales"].Value);
								num21 -= Conversions.ToDouble(dataGridViewRow3.Cells["Propina"].Value);
							}
							checked
							{
								num2++;
							}
						}
						else
						{
							dataGridViewRow3.DefaultCellStyle.BackColor = Color.White;
							dataGridViewRow3.Cells["Eliminar"].Value = false;
						}
						bool @checked = this.CheckBoxCuentasCanceladas.Checked;
						checked
						{
							if (@checked)
							{
								bool flag109 = Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells["Cancel."].Value, "Si", false);
								if (flag109)
								{
									dataGridViewRow3.Cells["Eliminar"].Value = true;
									dataGridViewRow3.DefaultCellStyle.BackColor = Color.Red;
									dataGridViewRow3.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
									num2++;
								}
							}
							bool checked2 = this.chkCtasCortesia.Checked;
							if (checked2)
							{
								bool flag110 = Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells["Total Original"].Value, 0, false);
								if (flag110)
								{
									dataGridViewRow3.Cells["Eliminar"].Value = true;
									dataGridViewRow3.DefaultCellStyle.BackColor = Color.Red;
									dataGridViewRow3.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
									num2++;
								}
							}
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
			}
			bool flag111 = Conversions.ToDouble(this.txtDescto.Text) > 0.0;
			if (flag111)
			{
				num15 = num11 - num11 * (Conversions.ToDouble(this.txtDescto.Text) / 100.0);
				try
				{
					foreach (object obj4 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow4 = (DataGridViewRow)obj4;
						bool flag112 = num15 > num11 - num16 && flag;
						if (flag112)
						{
							flag = false;
						}
						bool flag113 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow4.Cells["Eliminar"].Value, true, false), flag));
						if (flag113)
						{
							dataGridViewRow4.DefaultCellStyle.BackColor = Color.Red;
							dataGridViewRow4.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
							num16 += Conversions.ToDouble(dataGridViewRow4.Cells["Total Original"].Value);
							num17 += Conversions.ToDouble(dataGridViewRow4.Cells["Efectivo"].Value);
							num18 += Conversions.ToDouble(dataGridViewRow4.Cells["Tarjeta"].Value);
							num19 += Conversions.ToDouble(dataGridViewRow4.Cells["Otros"].Value);
							num20 += Conversions.ToDouble(dataGridViewRow4.Cells["Vales"].Value);
							num21 += Conversions.ToDouble(dataGridViewRow4.Cells["Propina"].Value);
							bool flag114 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow4.Cells["Facturado"].Value, "Si", false), Operators.CompareObjectEqual(dataGridViewRow4.Cells["Cancel."].Value, "No", false)));
							if (flag114)
							{
								num22 += Conversions.ToDouble(dataGridViewRow4.Cells["Total Original"].Value);
							}
							bool flag115 = Operators.ConditionalCompareObjectEqual(dataGridViewRow4.Cells["Cancel."].Value, "Si", false);
							if (flag115)
							{
								num16 -= Conversions.ToDouble(dataGridViewRow4.Cells["Total Original"].Value);
								num17 -= Conversions.ToDouble(dataGridViewRow4.Cells["Efectivo"].Value);
								num18 -= Conversions.ToDouble(dataGridViewRow4.Cells["Tarjeta"].Value);
								num19 -= Conversions.ToDouble(dataGridViewRow4.Cells["Otros"].Value);
								num20 -= Conversions.ToDouble(dataGridViewRow4.Cells["Vales"].Value);
								num21 -= Conversions.ToDouble(dataGridViewRow4.Cells["Propina"].Value);
							}
							checked
							{
								num2++;
							}
						}
						else
						{
							dataGridViewRow4.DefaultCellStyle.BackColor = Color.White;
							dataGridViewRow4.Cells["Eliminar"].Value = false;
						}
						bool checked3 = this.CheckBoxCuentasCanceladas.Checked;
						checked
						{
							if (checked3)
							{
								bool flag116 = Operators.ConditionalCompareObjectEqual(dataGridViewRow4.Cells["Cancel."].Value, "Si", false);
								if (flag116)
								{
									dataGridViewRow4.Cells["Eliminar"].Value = true;
									dataGridViewRow4.DefaultCellStyle.BackColor = Color.Red;
									dataGridViewRow4.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
									num2++;
								}
							}
							bool checked4 = this.chkCtasCortesia.Checked;
							if (checked4)
							{
								bool flag117 = Operators.ConditionalCompareObjectEqual(dataGridViewRow4.Cells["Total Original"].Value, 0, false);
								if (flag117)
								{
									dataGridViewRow4.Cells["Eliminar"].Value = true;
									dataGridViewRow4.DefaultCellStyle.BackColor = Color.Red;
									dataGridViewRow4.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
									num2++;
								}
							}
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
			}
			bool checked5 = this.chkEliminaProp.Checked;
			if (checked5)
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
				bool hasRows11 = sqlDataReader.HasRows;
				if (hasRows11)
				{
					double num23 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool checked6 = this.chkEliminaRet.Checked;
			if (checked6)
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
				bool hasRows12 = sqlDataReader.HasRows;
				if (hasRows12)
				{
					double num24 = Conversions.ToDouble(sqlDataReader[0]);
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
			bool hasRows13 = sqlDataReader.HasRows;
			if (hasRows13)
			{
				double num25 = Conversions.ToDouble(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			bool flag118 = Operators.CompareString(text3, "Todas", false) == 0;
			double num26;
			if (flag118)
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
				bool hasRows14 = sqlDataReader.HasRows;
				if (hasRows14)
				{
					num26 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag119 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag119)
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
				bool hasRows15 = sqlDataReader.HasRows;
				if (hasRows15)
				{
					num26 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			text4 = string.Concat(new string[]
			{
				"Select Case When sum(importe) Is NULL Then 0 Else sum(importe) End from movtoscaja  where  pagodepropina=0 And idturno In (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
			bool hasRows16 = sqlDataReader.HasRows;
			double num27;
			if (hasRows16)
			{
				num27 = Conversions.ToDouble(sqlDataReader[0]);
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
			bool hasRows17 = sqlDataReader.HasRows;
			double num28;
			if (hasRows17)
			{
				num28 = Conversions.ToDouble(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			bool flag120 = Operators.CompareString(text3, "Todas", false) == 0;
			double num29;
			double num30;
			if (flag120)
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
					"' and facturado = 1 and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows18 = sqlDataReader.HasRows;
				if (hasRows18)
				{
					num29 = Conversions.ToDouble(sqlDataReader[0]);
					num30 = Conversions.ToDouble(sqlDataReader[0]);
					this.lblventaFacturada.Text = "$ " + num30.ToString("N2");
				}
				sqlDataReader.Close();
			}
			bool flag121 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag121)
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
					"' and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows19 = sqlDataReader.HasRows;
				if (hasRows19)
				{
					num29 = Conversions.ToDouble(sqlDataReader[0]);
					num30 = Conversions.ToDouble(sqlDataReader[0]);
					this.lblventaFacturada.Text = "$ " + num30.ToString("N2");
				}
				sqlDataReader.Close();
			}
			bool flag122 = Operators.CompareString(text3, "Todas", false) == 0;
			double num31;
			if (flag122)
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
					"' and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows20 = sqlDataReader.HasRows;
				if (hasRows20)
				{
					num31 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag123 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag123)
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
					"' and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows21 = sqlDataReader.HasRows;
				if (hasRows21)
				{
					num31 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag124 = Operators.CompareString(text3, "Todas", false) == 0;
			double num32;
			if (flag124)
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
					"' and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows22 = sqlDataReader.HasRows;
				if (hasRows22)
				{
					num32 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag125 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag125)
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
					"' and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows23 = sqlDataReader.HasRows;
				if (hasRows23)
				{
					num32 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag126 = Operators.CompareString(text3, "Todas", false) == 0;
			double num33;
			if (flag126)
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
					"' and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows24 = sqlDataReader.HasRows;
				if (hasRows24)
				{
					num33 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag127 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag127)
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
				bool hasRows25 = sqlDataReader.HasRows;
				if (hasRows25)
				{
					num33 = Conversions.ToDouble(sqlDataReader[0]);
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
			bool hasRows26 = sqlDataReader.HasRows;
			double num34;
			if (hasRows26)
			{
				num34 = Conversions.ToDouble(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			bool flag128 = !this.chkEliminaRet.Checked;
			if (flag128)
			{
				this.lblcortenuevodepositos.Text = "$ " + num28.ToString("N2");
				this.lblcortenuevoretiros.Text = "$ " + num27.ToString("N2");
			}
			else
			{
				this.lblcortenuevodepositos.Text = "$ 0.00";
				this.lblcortenuevoretiros.Text = "$ 0.00";
			}
			bool flag129 = !this.chkEliminaProp.Checked;
			if (flag129)
			{
				this.lblpropinascortenuevo.Text = "$ " + (num26 - num21).ToString("N2");
			}
			else
			{
				this.lblpropinascortenuevo.Text = "$ 0.00";
			}
			this.lblcortetarjetaanterior.Text = "$ " + num31.ToString("N2");
			this.lblcorteefectivoanterior.Text = "$ " + num13.ToString("N2");
			this.lblcorteanteriorvales.Text = "$ " + num33.ToString("N2");
			this.lblcorteanteriorotros.Text = "$ " + num32.ToString("N2");
			this.lblcorteanteriordepositosenefectivo.Text = "$ " + num28.ToString("N2");
			this.lblcorteanteriorretirosefectivo.Text = "$ " + num27.ToString("N2");
			this.lblcorteanteriorpropinas.Text = "$ " + num26.ToString("N2");
			this.lblcorteanteriorsaldo.Text = "$ " + (num13 + num31 + num32 + num33 + num28 - num27 - num26 + num34).ToString("N2");
			this.lblcorteanteriorefectivofinal.Text = "$ " + (num13 + num28 - num27 - num26 + num34).ToString("N2");
			this.lblcortefondoinicialanterior.Text = "$ " + num34.ToString("N2");
			bool checked7 = this.CheckBoxfondocaja.Checked;
			if (checked7)
			{
				this.lblfondoinicialnuevo.Text = "$ 0.00";
			}
			else
			{
				this.lblfondoinicialnuevo.Text = "$ " + num34.ToString("N2");
			}
			this.txtVales.Text = "$ " + num33.ToString("N2");
			this.txtdifvales.Text = "$ " + (num33 - num20).ToString("N2");
			double num35 = Conversions.ToDouble(this.txtdifvales.Text);
			this.lblcortenuevovales.Text = "$ " + num35.ToString("N2");
			this.txtVentasOtros.Text = "$ " + num32.ToString("N2");
			this.txtdifotros.Text = "$ " + (num32 - num19).ToString("N2");
			double num36 = Conversions.ToDouble(this.txtdifotros.Text);
			this.lblcortenuevotros.Text = "$ " + num36.ToString("N2");
			this.txtVentaTarjeta.Text = "$ " + num31.ToString("N2");
			this.txtDifTarjeta.Text = "$ " + (num31 - num18).ToString("N2");
			double num37 = Conversions.ToDouble(this.txtDifTarjeta.Text);
			this.lblcortetarjetanuevo.Text = "$ " + num37.ToString("N2");
			this.txtVentaFacturada.Text = "$ " + (num29 - num22).ToString("N2");
			this.txtventasinfacturar.Text = "$ " + (num16 - num29).ToString("N2");
			this.txtFacturaPUB.Text = "$ " + (num16 - num29).ToString("N2");
			this.txtDepositos.Text = "$ " + num28.ToString("N2");
			this.txtretirostotal.Text = "$ " + num27.ToString("N2");
			this.txtTotalPropinas.Text = "$ " + num26.ToString("N2");
			this.txtPropinasNuevo.Text = "$ " + (num26 - num21).ToString("N2");
			this.txtCuentasModificar.Text = num2.ToString();
			this.txtCuentasTotal.Text = num.ToString();
			this.txtImpAnterior.Text = "$ " + num11.ToString("N2");
			this.txtImpNuevo.Text = "$ " + (num11 - num16).ToString("N2");
			double num38 = num11 - num30;
			this.lblventasinfacturarcorte.Text = "$ " + num38.ToString("N2");
			this.lblfacturapub.Text = "$ " + num38.ToString("N2");
			double num39 = Conversions.ToDouble(this.txtImpNuevo.Text);
			this.txtVentaFacturada.Text = "$ " + (num29 - num22).ToString("N2");
			double num40 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			this.txtFacturaPUB.Text = "$ " + (num39 - num40).ToString("N2");
			this.txtventasinfacturar.Text = "$ " + (num39 - num40).ToString("N2");
			this.txtEfectivoAnt.Text = "$ " + num13.ToString("N2");
			this.txtEfectivoFiscal.Text = "$ " + (num13 - num17).ToString("N2");
			double num41 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
			this.lblcorteefectivonuevo.Text = "$ " + num41.ToString("N2");
			this.txtDifImporte.Text = "$ " + num16.ToString("N2");
			this.txtDifPorcen.Text = "% " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			this.txtObjetivo.Text = "$ " + num15.ToString("N2");
			double num42 = Conversions.ToDouble(this.lblpropinascortenuevo.Text);
			double num43 = Conversions.ToDouble(this.lblcortenuevoretiros.Text);
			double num44 = Conversions.ToDouble(this.lblcortenuevodepositos.Text);
			double num45 = Conversions.ToDouble(this.lblfondoinicialnuevo.Text);
			this.txtEfectivoCaja.Text = "$ " + (num41 - num42 - num43 + num44 + num45).ToString("N2");
			this.lblsaldofinarlcortenuevo.Text = "$ " + (num41 + num37 + num36 + num35 - num42 - num43 + num44 + num45).ToString("N2");
			this.lblEfectivonuevocorte.Text = "$ " + (num41 - num42 - num43 + num44 + num45).ToString("N2");
			this.DifPorcentajeSin = (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			this.lblventafacturanew.Text = this.txtVentaFacturada.Text;
			this.lblventasinfacturarnew.Text = this.txtventasinfacturar.Text;
			this.lblfacturapubnew.Text = this.txtFacturaPUB.Text;
			bool flag130 = Conversions.ToDouble(this.txtMinimo.Text) == 0.0 & Conversions.ToDouble(this.txtDescto.Text) == 0.0;
			if (flag130)
			{
				this.dgvNotas.Columns[18].Visible = false;
			}
			else
			{
				bool flag131 = Conversions.ToDouble(this.txtMinimo.Text) != 0.0 & Conversions.ToDouble(this.txtDescto.Text) == 0.0;
				if (flag131)
				{
					this.dgvNotas.Columns[18].Visible = true;
				}
				else
				{
					bool flag132 = Conversions.ToDouble(this.txtMinimo.Text) == 0.0 & Conversions.ToDouble(this.txtDescto.Text) != 0.0;
					if (flag132)
					{
						this.dgvNotas.Columns[18].Visible = true;
					}
				}
			}
			try
			{
				foreach (object obj5 in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow5 = (DataGridViewRow)obj5;
					bool flag133 = Operators.ConditionalCompareObjectEqual(dataGridViewRow5.Cells["Total Original"].Value, "0", false);
					if (flag133)
					{
						dataGridViewRow5.DefaultCellStyle.BackColor = Color.LightBlue;
					}
				}
			}
			finally
			{
				IEnumerator enumerator5;
				if (enumerator5 is IDisposable)
				{
					(enumerator5 as IDisposable).Dispose();
				}
			}
			bool flag134 = Conversions.ToDouble(this.txtCuentasModificar.Text) != 0.0;
			if (flag134)
			{
				this.btnAplicar.Enabled = true;
			}
			else
			{
				this.btnAplicar.Enabled = false;
			}
			bool flag135 = Operators.CompareString(this.txtCuentasTotal.Text, "0", false) == 0;
			if (flag135)
			{
				Interaction.MsgBox("No hay cuentas para modificar en le periodo seleccionado, intenta nuevamente con otro periodo o contacta a tu administrador del sistema!", MsgBoxStyle.OkOnly, null);
			}
			this.btnCorteZ.Enabled = true;
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Button3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000A923C File Offset: 0x000A743C
		private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
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
					TextBox textBox;
					(textBox = this.txtCuentasModificar).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
					(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value));
					(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
					(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value));
					(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
					(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
					(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
					(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
					(textBox = this.txtPropinasNuevo).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
					Label label;
					(label = this.lblcorteefectivonuevo).Text = Conversions.ToString(Operators.SubtractObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
					(label = this.lblcortetarjetanuevo).Text = Conversions.ToString(Operators.SubtractObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
					(label = this.lblcortenuevovales).Text = Conversions.ToString(Operators.SubtractObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
					(label = this.lblcortenuevotros).Text = Conversions.ToString(Operators.SubtractObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
					bool flag3 = !this.chkEliminaProp.Checked;
					if (flag3)
					{
						(label = this.lblpropinascortenuevo).Text = Conversions.ToString(Operators.SubtractObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
					}
					else
					{
						this.lblpropinascortenuevo.Text = "$ 0.00";
					}
					bool flag4 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Facturado"].Value, "Si", false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)));
					if (flag4)
					{
						(textBox = this.txtVentaFacturada).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value));
					}
					bool flag5 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false);
					if (flag5)
					{
						(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						(textBox = this.txtPropinasNuevo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
						(label = this.lblcorteefectivonuevo).Text = Conversions.ToString(Operators.AddObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(label = this.lblcortetarjetanuevo).Text = Conversions.ToString(Operators.AddObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(label = this.lblcortenuevovales).Text = Conversions.ToString(Operators.AddObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						(label = this.lblcortenuevotros).Text = Conversions.ToString(Operators.AddObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
					}
				}
				else
				{
					this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value = false;
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.875f, FontStyle.Regular);
					TextBox textBox;
					(textBox = this.txtCuentasModificar).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - 1.0);
					(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value));
					(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
					(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value));
					(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
					(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
					(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
					(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
					(textBox = this.txtPropinasNuevo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
					Label label;
					(label = this.lblcorteefectivonuevo).Text = Conversions.ToString(Operators.AddObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
					(label = this.lblcortetarjetanuevo).Text = Conversions.ToString(Operators.AddObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
					(label = this.lblcortenuevovales).Text = Conversions.ToString(Operators.AddObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
					(label = this.lblcortenuevotros).Text = Conversions.ToString(Operators.AddObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
					bool flag6 = !this.chkEliminaProp.Checked;
					if (flag6)
					{
						(label = this.lblpropinascortenuevo).Text = Conversions.ToString(Operators.AddObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
					}
					else
					{
						this.lblpropinascortenuevo.Text = "$ 0.00";
					}
					bool flag7 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Facturado"].Value, "Si", false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)));
					if (flag7)
					{
						(textBox = this.txtVentaFacturada).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value));
					}
					bool flag8 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false);
					if (flag8)
					{
						(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						(textBox = this.txtPropinasNuevo).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
						(label = this.lblcorteefectivonuevo).Text = Conversions.ToString(Operators.SubtractObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(label = this.lblcortetarjetanuevo).Text = Conversions.ToString(Operators.SubtractObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(label = this.lblcortenuevovales).Text = Conversions.ToString(Operators.SubtractObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						(label = this.lblcortenuevotros).Text = Conversions.ToString(Operators.SubtractObject(label.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
					}
				}
				double num = Conversions.ToDouble(this.lblpropinascortenuevo.Text);
				this.lblpropinascortenuevo.Text = "$ " + num.ToString("N2");
				double num2 = Conversions.ToDouble(this.txtPropinasNuevo.Text);
				this.txtPropinasNuevo.Text = "$ " + num2.ToString("N2");
				double num3 = Conversions.ToDouble(this.lblcorteefectivonuevo.Text);
				this.lblcorteefectivonuevo.Text = "$ " + num3.ToString("N2");
				double num4 = Conversions.ToDouble(this.lblcortetarjetanuevo.Text);
				this.lblcortetarjetanuevo.Text = "$ " + num4.ToString("N2");
				double num5 = Conversions.ToDouble(this.lblcortenuevotros.Text);
				this.lblcortenuevotros.Text = "$ " + num5.ToString("N2");
				double num6 = Conversions.ToDouble(this.lblcortenuevovales.Text);
				this.lblcortenuevovales.Text = "$ " + num6.ToString("N2");
				double num7 = Conversions.ToDouble(this.txtDifTarjeta.Text);
				double num8 = Conversions.ToDouble(this.txtdifotros.Text);
				double num9 = Conversions.ToDouble(this.txtdifvales.Text);
				this.txtDifTarjeta.Text = "$ " + num7.ToString("N2");
				this.txtdifvales.Text = "$ " + num9.ToString("N2");
				this.txtdifotros.Text = "$ " + num8.ToString("N2");
				double num10 = Conversions.ToDouble(this.txtVentaFacturada.Text);
				this.txtVentaFacturada.Text = "$ " + num10.ToString("N2");
				double num11 = Conversions.ToDouble(this.txtVentaTarjeta.Text);
				double num12 = Conversions.ToDouble(this.txtVales.Text);
				double num13 = Conversions.ToDouble(this.txtVentasOtros.Text);
				this.txtVales.Text = "$ " + num12.ToString("N2");
				this.txtVentasOtros.Text = "$ " + num13.ToString("N2");
				this.txtVentaTarjeta.Text = "$ " + num11.ToString("N2");
				double num14 = Conversions.ToDouble(this.txtFacturaPUB.Text);
				double num15 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
				double num16 = Conversions.ToDouble(this.txtImpNuevo.Text);
				double num17 = Conversions.ToDouble(this.txtDifImporte.Text);
				this.txtFacturaPUB.Text = "$ " + num14.ToString("N2");
				this.txtImpNuevo.Text = "$ " + num16.ToString("N2");
				this.txtEfectivoFiscal.Text = "$ " + num15.ToString("N2");
				this.txtDifImporte.Text = "$ " + num17.ToString("N2");
				this.txtDifPorcen.Text = "% " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
				double num18 = Conversions.ToDouble(this.lblcortenuevodepositos.Text);
				double num19 = Conversions.ToDouble(this.lblcortenuevoretiros.Text);
				double num20 = num3 + num4 + num5 + num6 - num2 + num18 - num19;
				double num21 = num3 - num2 - num19 + num18;
				this.lblsaldofinarlcortenuevo.Text = "$ " + num20.ToString("N2");
				this.lblEfectivonuevocorte.Text = "$ " + num21.ToString("N2");
				this.txtEfectivoCaja.Text = "$ " + num21.ToString("N2");
				double num22 = Conversions.ToDouble(this.txtImpNuevo.Text);
				double num23 = Conversions.ToDouble(this.txtVentaFacturada.Text);
				double num24 = Conversion.Val(num22) - Conversion.Val(num23);
				this.txtventasinfacturar.Text = "$ " + num24.ToString("N2");
				this.txtFacturaPUB.Text = "$ " + num24.ToString("N2");
				this.lblventafacturanew.Text = this.txtVentaFacturada.Text;
				this.lblventasinfacturarnew.Text = this.txtventasinfacturar.Text;
				this.lblfacturapubnew.Text = this.txtFacturaPUB.Text;
			}
			bool flag9 = Conversions.ToDouble(this.txtCuentasModificar.Text) != 0.0;
			if (flag9)
			{
				this.btnAplicar.Enabled = true;
			}
			else
			{
				this.btnAplicar.Enabled = false;
			}
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000AA974 File Offset: 0x000A8B74
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

		// Token: 0x060009DA RID: 2522 RVA: 0x000AAA74 File Offset: 0x000A8C74
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
			string query_conn = "SELECT u ,v,w,y,z  from H";
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
						"<br>\r\n              Vales Nuevo : ",
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
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x000AAF08 File Offset: 0x000A9108
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

		// Token: 0x060009DC RID: 2524 RVA: 0x000AB0B4 File Offset: 0x000A92B4
		private void btnAplicar_Click(object sender, EventArgs e)
		{
			this.COdigoUnicoCOrteGenerar();
			this.lblfechayhora.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
			string text = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
			string text2 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			object obj = "SE ELIMINARÁN LOS FOLIOS SELECCIONADOS, Deseas continuar?";
			object value = 276;
			object obj2 = "ATENCIÓN!!!";
			object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
			bool flag = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
			if (flag)
			{
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
				string text3 = "";
				double num = 0.0;
				SqlQuery sqlQuery = new SqlQuery();
				SqlQuery sqlQuery2 = new SqlQuery();
				string text4 = this.cmbxSerie.Text;
				this.progBar.Value = 20;
				SqlQuery sqlQuery3 = new SqlQuery();
				SqlQuery sqlQuery4 = new SqlQuery();
				List<string> list = new List<string>();
				string text5 = string.Concat(new string[]
				{
					"select distinct (idturno) from turnos where apertura between '",
					text,
					"' and '",
					text2,
					"' and cierre is not null"
				});
				SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
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
					text,
					"' and '",
					text2,
					"' and cierre is not null"
				});
				sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
				bool hasRows3 = sqlDataReader2.HasRows;
				if (hasRows3)
				{
					sqlDataReader2.Read();
				}
				sqlDataReader2.Close();
				try
				{
				}
				catch (Exception ex)
				{
				}
				this.progBar.Value = 24;
				try
				{
					foreach (string text6 in list)
					{
						string query_conn2 = "Select g from H";
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
									sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
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
										sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
										bool hasRows7 = sqlDataReader2.HasRows;
										if (hasRows7)
										{
											while (sqlDataReader2.Read())
											{
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
												sqlQuery4.execQuery(text5);
												this.progBar.Value = 26;
											}
											text5 = "   Select a.idproducto ,b.descripcion, a.precio,a.cantidad,a.hora  from cheqdet A\r\n                                                         Inner JOIN productos B on b.idproducto = a.idproducto where a.foliodet in  (select folio from cheques where idturno = '" + text6 + "' AND cierre is not null  and cancelado=0)";
											sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
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
													sqlQuery4.execQuery(text5);
													this.progBar.Value = 28;
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
				List<string> list2 = new List<string>();
				try
				{
					foreach (object obj3 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj3;
						bool flag4 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false);
						if (flag4)
						{
							text3 = Conversions.ToString(Operators.AddObject(text3, dataGridViewRow.Cells["id_nota"].Value));
							text3 += ",";
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
				text3 = text3.Remove(checked(text3.Length - 1), 1);
				text5 = string.Concat(new string[]
				{
					"select distinct (idturno) from turnos where apertura between '",
					text,
					"' and '",
					text2,
					"' and cierre is not null"
				});
				sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
				bool hasRows9 = sqlDataReader2.HasRows;
				if (hasRows9)
				{
					while (sqlDataReader2.Read())
					{
						list2.Add(Conversions.ToString(sqlDataReader2[0]));
					}
					sqlDataReader2.Close();
				}
				this.progBar.Value = 30;
				try
				{
					foreach (string text23 in list2)
					{
						SqlQuery sqlQuery5 = new SqlQuery();
						string text24 = "select n from H";
						SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text24);
						bool hasRows10 = sqlDataReader5.HasRows;
						if (hasRows10)
						{
							while (sqlDataReader5.Read())
							{
								bool flag5 = Operators.CompareString(Tools.Desencriptar(sqlDataReader5[0].ToString().Trim()), "1", false) == 0;
								if (flag5)
								{
									text24 = "delete from movsinv where idconcepto='SPV' and idturno ='" + text23 + "'";
									sqlQuery5.execQuery(text24);
								}
							}
						}
						try
						{
							foreach (object obj4 in ((IEnumerable)this.dgvNotas.Rows))
							{
								DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj4;
								bool flag6 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(dataGridViewRow2.Cells["Propina"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)));
								if (flag6)
								{
									string text25 = Conversions.ToString(dataGridViewRow2.Cells["Folio Cuenta"].Value);
									string text26 = Conversions.ToString(dataGridViewRow2.Cells["Folio Propina"].Value);
									string text27 = Conversions.ToString(dataGridViewRow2.Cells["Serie"].Value);
									bool flag7 = Operators.CompareString(text4, "Todas", false) == 0;
									if (flag7)
									{
										text5 = string.Concat(new string[]
										{
											"Update movtoscaja Set importe = importe - (Select propina from cheques where numcheque ='",
											text25.ToString(),
											"' and seriefolio='",
											text27,
											"') where folio=  '",
											text26,
											"'"
										});
										sqlQuery2.execQuery(text5);
									}
									bool flag8 = Operators.CompareString(text4, "Todas", false) != 0;
									if (flag8)
									{
										text5 = string.Concat(new string[]
										{
											"Update movtoscaja Set importe = importe - (Select propina from cheques where numcheque ='",
											text25.ToString(),
											"' and seriefolio = '",
											text4,
											"') where folio=  '",
											text26,
											"'"
										});
										sqlQuery2.execQuery(text5);
									}
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
						bool @checked = this.chkCtasCortesia.Checked;
						if (@checked)
						{
							bool flag9 = Operators.CompareString(text4, "Todas", false) == 0;
							if (flag9)
							{
								text5 = string.Concat(new string[]
								{
									"delete from  chequespagos where  folio in (SELECT folio from cheques where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and cancelado='1' and descuento='100')"
								});
								sqlQuery4.execQuery(text5);
								text5 = string.Concat(new string[]
								{
									"delete from  cheqdet where  foliodet in (SELECT folio from cheques where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and descuento='100')"
								});
								sqlQuery4.execQuery(text5);
								text5 = string.Concat(new string[]
								{
									"Delete from cheques where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and descuento='100'"
								});
								sqlQuery4.execQuery(text5);
							}
							bool flag10 = Operators.CompareString(text4, "Todas", false) != 0;
							if (flag10)
							{
								text5 = string.Concat(new string[]
								{
									"Delete from  chequespagos where  folio in (SELECT folio from cheques where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and descuento='100' and seriefolio = '",
									text4,
									"')"
								});
								sqlQuery4.execQuery(text5);
								text5 = string.Concat(new string[]
								{
									"Delete from  cheqdet where  foliodet in (SELECT folio from cheques where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and descuento='100' and seriefolio = '",
									text4,
									"')"
								});
								sqlQuery4.execQuery(text5);
								text5 = string.Concat(new string[]
								{
									"Delete from cheques where  idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and descuento='100' and seriefolio = '",
									text4,
									"'"
								});
								sqlQuery4.execQuery(text5);
							}
						}
						bool checked2 = this.CheckBoxCuentasCanceladas.Checked;
						if (checked2)
						{
							bool flag11 = Operators.CompareString(text4, "Todas", false) == 0;
							if (flag11)
							{
								text5 = string.Concat(new string[]
								{
									"delete from  chequespagos where  folio in (SELECT folio from cheques where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and cancelado='1')"
								});
								sqlQuery4.execQuery(text5);
								text5 = string.Concat(new string[]
								{
									"delete from  cheqdet where  foliodet in (SELECT folio from cheques where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and cancelado='1')"
								});
								sqlQuery4.execQuery(text5);
								text5 = string.Concat(new string[]
								{
									"Delete from cheques where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and cancelado='1'"
								});
								sqlQuery4.execQuery(text5);
							}
							bool flag12 = Operators.CompareString(text4, "Todas", false) != 0;
							if (flag12)
							{
								text5 = string.Concat(new string[]
								{
									"Delete from  chequespagos where  folio in (SELECT folio from cheques where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and cancelado='1' and seriefolio = '",
									text4,
									"')"
								});
								sqlQuery4.execQuery(text5);
								text5 = string.Concat(new string[]
								{
									"Delete from  cheqdet where  foliodet in (SELECT folio from cheques where idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and cancelado='1' and seriefolio = '",
									text4,
									"')"
								});
								sqlQuery4.execQuery(text5);
								text5 = string.Concat(new string[]
								{
									"Delete from cheques where  idturno in (\r\n                                        SELECT idturno FROM turnos \r\n                                        WHERE turnos.apertura BETWEEN '",
									text,
									"' AND '",
									text2,
									"' AND \r\n                                        cierre is not null and idempresa='",
									Tools.id_Empresa,
									"')\r\n                                        and idempresa='",
									Tools.id_Empresa,
									"' and cancelado='1' and seriefolio = '",
									text4,
									"'"
								});
								sqlQuery4.execQuery(text5);
							}
						}
						this.progBar.Value = 50;
						bool checked3 = this.chkEliminaProp.Checked;
						if (checked3)
						{
							text5 = "delete from movtoscaja where idturno = '" + text23 + "' And  pagodepropina = 1";
							sqlQuery4.execQuery(text5);
							bool flag13 = Operators.CompareString(text4, "Todas", false) == 0;
							if (flag13)
							{
								text5 = "update cheques set propina=0 , propinafoliomovtocaja =0 where idturno='" + text23 + "'";
								sqlQuery4.execQuery(text5);
							}
							bool flag14 = Operators.CompareString(text4, "Todas", false) != 0;
							if (flag14)
							{
								text5 = string.Concat(new string[]
								{
									"update cheques set propina=0 , propinafoliomovtocaja =0 where idturno='",
									text23,
									"' and seriefolio = '",
									text4,
									"'"
								});
								sqlQuery4.execQuery(text5);
							}
						}
						else
						{
							text5 = "Select ISNULL(sum(importe),0) from movtoscaja Where idturno = '" + text23 + "' And  pagodepropina = 1";
							sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
							sqlDataReader2.Read();
							num = Conversions.ToDouble(sqlDataReader2[0]);
							sqlDataReader2.Close();
						}
						bool checked4 = this.chkEliminaRet.Checked;
						if (checked4)
						{
							text5 = "delete from movtoscaja Where idturno = '" + text23 + "' And pagodepropina <1";
							sqlQuery4.execQuery(text5);
						}
						bool flag15 = Conversions.ToDouble(this.txtImpAnterior.Text) != 0.0;
						if (flag15)
						{
							text5 = " delete from chequespagos where folio In (" + text3 + ")";
							sqlQuery4.execQuery(text5);
							text5 = "delete from cheqdet where foliodet In (" + text3 + ")";
							sqlQuery4.execQuery(text5);
							bool flag16 = Operators.CompareString(text4, "Todas", false) == 0;
							if (flag16)
							{
								text5 = "delete from cheques where folio In (" + text3 + ")";
								sqlQuery4.execQuery(text5);
							}
							bool flag17 = Operators.CompareString(text4, "Todas", false) != 0;
							if (flag17)
							{
								text5 = string.Concat(new string[]
								{
									"delete from cheques where folio In (",
									text3,
									") and seriefolio = '",
									text4,
									"'"
								});
								sqlQuery4.execQuery(text5);
							}
						}
						this.progBar.Value = 60;
						bool flag18 = Operators.CompareString(text4, "Todas", false) != 0;
						if (flag18)
						{
							text5 = string.Concat(new string[]
							{
								"Select \r\n                            ISNULL(sum(efectivo),0),\r\n                            ISNULL(sum(tarjeta),0),\r\n                            ISNULL(sum(vales),0),\r\n                            ISNULL(sum(otros),0)\r\n                            from cheques WHERE idempresa='",
								Tools.id_Empresa,
								"' and  idturno = '",
								text23,
								"' and seriefolio = '",
								text4,
								"'"
							});
							sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
							sqlDataReader2.Read();
							double num2 = Conversions.ToDouble(Operators.SubtractObject(sqlDataReader2[0], num));
							double num3 = Conversions.ToDouble(sqlDataReader2[1]);
							double num4 = Conversions.ToDouble(sqlDataReader2[2]);
							double num5 = Conversions.ToDouble(sqlDataReader2[3]);
							double num6 = num2;
							text5 = string.Concat(new string[]
							{
								"Update turnos Set efectivo='",
								num6.ToString("N2"),
								"',tarjeta='",
								num3.ToString("N2"),
								"',vales='",
								num4.ToString("N2"),
								"', credito='",
								num5.ToString("N2"),
								"' Where idturno = '",
								text23,
								"'"
							});
							sqlQuery4.execQuery(text5);
						}
						bool flag19 = Operators.CompareString(text4, "Todas", false) == 0;
						if (flag19)
						{
							text5 = string.Concat(new string[]
							{
								"Select \r\n                            ISNULL(sum(efectivo),0),\r\n                            ISNULL(sum(tarjeta),0),\r\n                            ISNULL(sum(vales),0),\r\n                            ISNULL(sum(otros),0)\r\n                            from cheques WHERE idempresa='",
								Tools.id_Empresa,
								"' and  idturno = '",
								text23,
								"'"
							});
							sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
							sqlDataReader2.Read();
							double num2 = Conversions.ToDouble(Operators.SubtractObject(sqlDataReader2[0], num));
							double num3 = Conversions.ToDouble(sqlDataReader2[1]);
							double num4 = Conversions.ToDouble(sqlDataReader2[2]);
							double num5 = Conversions.ToDouble(sqlDataReader2[3]);
							double num6 = num2;
							text5 = string.Concat(new string[]
							{
								"Update turnos Set efectivo='",
								num6.ToString("N2"),
								"',tarjeta='",
								num3.ToString("N2"),
								"',vales='",
								num4.ToString("N2"),
								"', credito='",
								num5.ToString("N2"),
								"' Where idturno = '",
								text23,
								"'"
							});
							sqlQuery4.execQuery(text5);
						}
						bool checked5 = this.CheckBoxfondocaja.Checked;
						if (checked5)
						{
							text5 = "update turnos set fondo=0 Where idturno = '" + text23 + "'";
							sqlQuery4.execQuery(text5);
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				this.progBar.Value = 70;
				sqlDataReader2.Close();
				this.txtMinimo.Text = Conversions.ToString(0);
				this.txtDescto.Text = Conversions.ToString(0);
				string text28 = DateAndTime.Now.ToString(Tools.strFormatoFechaLargo);
				string text29 = this.txtCuentasModificar.Text;
				string text30 = this.txtCuentasTotal.Text;
				double num7 = Conversions.ToDouble(this.txtImpAnterior.Text);
				double num8 = Conversions.ToDouble(this.txtImpNuevo.Text);
				double num9 = Conversions.ToDouble(this.txtEfectivoAnt.Text);
				double num10 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
				double num11 = Conversions.ToDouble(this.txtVentaTarjeta.Text);
				double num12 = Conversions.ToDouble(this.txtDifTarjeta.Text);
				double num13 = Conversions.ToDouble(this.txtVentasOtros.Text);
				double num14 = Conversions.ToDouble(this.txtdifotros.Text);
				double num15 = Conversions.ToDouble(this.txtVales.Text);
				double num16 = Conversions.ToDouble(this.txtdifvales.Text);
				double num17 = Conversions.ToDouble(this.txtTotalPropinas.Text);
				double num18 = Conversions.ToDouble(this.txtPropinasNuevo.Text);
				string text31 = MyProject.Forms.main.lblNombreUsuario.Text;
				this.progBar.Value = 80;
				string text32 = this.cmbxEmpresa.Text;
				text5 = "Select h from H";
				sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
				bool hasRows11 = sqlDataReader2.HasRows;
				if (hasRows11)
				{
					while (sqlDataReader2.Read())
					{
						bool flag20 = Operators.CompareString(Tools.Desencriptar(sqlDataReader2[0].ToString().Trim()), "1", false) == 0;
						if (flag20)
						{
							try
							{
								text5 = string.Concat(new string[]
								{
									"Insert into I ( a ,b ,c ,d ,e ,f ,g ,h ,i ,j , k , l , m, n , o , p , q , r , s , t , u , w , x  )Values ( '",
									text28,
									"','",
									text,
									"','",
									text2,
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
									Tools.Encriptar(this.txtPropinasNuevo.Text.Trim()),
									"','",
									Tools.Encriptar(MyProject.Forms.main.lblNombreUsuario.Text.Trim()),
									"' , '",
									Tools.Encriptar(this.lblCOdigoUnicoCorte.Text).Trim(),
									"')"
								});
								sqlQuery_Conn.execQuery_conn(text5);
								this.InsertarCorteBitacora();
							}
							catch (Exception ex2)
							{
							}
						}
					}
					sqlDataReader2.Close();
				}
				try
				{
					text5 = "Delete from movtoscaja where importe <=0";
					sqlQuery2.execQuery(text5);
				}
				catch (Exception ex3)
				{
				}
				SqlQuery sqlQuery6 = new SqlQuery();
				string query_conn3 = "Select f from H";
				SqlDataReader sqlDataReader6 = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn3);
				bool hasRows12 = sqlDataReader6.HasRows;
				if (hasRows12)
				{
					sqlDataReader6.Read();
					this.IFolioInirenumerar = Tools.Desencriptar(sqlDataReader6[0].ToString().Trim());
				}
				sqlDataReader6.Close();
				bool flag21 = Operators.CompareString(text4, "Todas", false) != 0;
				if (flag21)
				{
					frmAvisoDistintoTodas frmAvisoDistintoTodas = new frmAvisoDistintoTodas();
					frmAvisoDistintoTodas.ShowDialog();
					bool checked6 = this.chkRenumerar.Checked;
					if (checked6)
					{
						text5 = string.Concat(new string[]
						{
							"select count(*) from cheques where fecha >='",
							text,
							"' and  seriefolio = '",
							text4,
							"'"
						});
						sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
						bool hasRows13 = sqlDataReader2.HasRows;
						if (hasRows13)
						{
							sqlDataReader2.Read();
							int num19 = Conversions.ToInteger(sqlDataReader2[0]);
						}
						sqlDataReader2.Close();
						text5 = string.Concat(new string[]
						{
							"Select folio, numcheque, folionotadeconsumo  from cheques where numcheque >= ",
							this.IFolioInirenumerar.ToString(),
							" and  seriefolio = '",
							text4,
							"' order by fecha asc, folio asc"
						});
						sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
						bool hasRows14 = sqlDataReader2.HasRows;
						if (hasRows14)
						{
							object obj5 = this.IFolioInirenumerar;
							try
							{
							}
							catch (Exception ex4)
							{
							}
							while (sqlDataReader2.Read())
							{
								bool flag22 = Operators.ConditionalCompareObjectEqual(sqlDataReader2[2], 0, false);
								if (flag22)
								{
									text5 = string.Concat(new string[]
									{
										"update cheques Set numcheque = ",
										obj5.ToString(),
										" where folio = ",
										sqlDataReader2[0].ToString(),
										" and  seriefolio = '",
										text4,
										"'"
									});
								}
								else
								{
									text5 = string.Concat(new string[]
									{
										"update cheques Set numcheque = ",
										obj5.ToString(),
										", folionotadeconsumo = ",
										obj5.ToString(),
										" where folio = ",
										sqlDataReader2[0].ToString(),
										" and  seriefolio = '",
										text4,
										"'"
									});
								}
								sqlQuery4.execQuery(text5);
								obj5 = Operators.AddObject(obj5, 1);
							}
							sqlDataReader2.Close();
							text5 = "Select Case When Max(numcheque) is Null then 0 Else Max(numcheque) end from cheques where (seriefolio)= '" + text4 + "' ";
							sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
							sqlDataReader2.Read();
							text5 = string.Concat(new string[]
							{
								"Update folios set ultimofolio='",
								sqlDataReader2[0].ToString(),
								"' , ultimofolionotadeconsumo='",
								sqlDataReader2[0].ToString(),
								"' where (serie)='",
								text4,
								"'"
							});
							sqlQuery4.execQuery(text5);
							sqlDataReader2.Close();
						}
					}
				}
				bool flag23 = Operators.CompareString(text4, "Todas", false) == 0;
				if (flag23)
				{
					text5 = "DELETE FROM L";
					sqlQuery_Conn.execQuery_conn(text5);
					bool checked7 = this.chkRenumerar.Checked;
					if (checked7)
					{
						try
						{
							foreach (object obj6 in ((IEnumerable)this.DataGridFoliosRenumerar.Rows))
							{
								DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj6;
								string text33 = Conversions.ToString(dataGridViewRow3.Cells["Serie"].Value);
								string text34 = Conversions.ToString(dataGridViewRow3.Cells["Folio"].Value);
								text5 = string.Concat(new string[]
								{
									"INSERT INTO L VALUES ('",
									Tools.Encriptar(text33),
									"','",
									Tools.Encriptar(text34),
									"')"
								});
								sqlQuery_Conn.execQuery_conn(text5);
							}
						}
						finally
						{
							IEnumerator enumerator5;
							if (enumerator5 is IDisposable)
							{
								(enumerator5 as IDisposable).Dispose();
							}
						}
						frmAvisoTodas frmAvisoTodas = new frmAvisoTodas();
						frmAvisoTodas.ShowDialog();
						this.DataGridFoliosRenumerar.Rows.Clear();
						text5 = "SELECT a , b FROM L";
						sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
						bool hasRows15 = sqlDataReader2.HasRows;
						if (hasRows15)
						{
							this.iniciaGriSeriesFolios();
							while (sqlDataReader2.Read())
							{
								string text35 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
								string text36 = Tools.Desencriptar(sqlDataReader2[1].ToString().Trim());
								this.DataGridFoliosRenumerar.Rows.Add(new object[]
								{
									text35,
									text36
								});
							}
						}
						text5 = "select count(*) from cheques where fecha >='" + text + "'";
						sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
						bool hasRows16 = sqlDataReader2.HasRows;
						if (hasRows16)
						{
							sqlDataReader2.Read();
							int num19 = Conversions.ToInteger(sqlDataReader2[0]);
						}
						sqlDataReader2.Close();
						try
						{
							foreach (object obj7 in ((IEnumerable)this.DataGridFoliosRenumerar.Rows))
							{
								DataGridViewRow dataGridViewRow4 = (DataGridViewRow)obj7;
								bool flag24 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow4.Cells["Folio"].Value, "", false);
								if (flag24)
								{
									string text33 = Conversions.ToString(dataGridViewRow4.Cells["Serie"].Value);
									string text34 = Conversions.ToString(dataGridViewRow4.Cells["Folio"].Value);
									text5 = string.Concat(new string[]
									{
										"Select  folio, numcheque, folionotadeconsumo  from cheques where numcheque >= ",
										text34.ToString(),
										" and seriefolio='",
										text33.ToString(),
										"'  order by fecha asc, folio asc"
									});
									sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
									bool hasRows17 = sqlDataReader2.HasRows;
									if (hasRows17)
									{
										object obj5 = text34;
										try
										{
										}
										catch (Exception ex5)
										{
										}
										while (sqlDataReader2.Read())
										{
											bool flag25 = Operators.ConditionalCompareObjectEqual(sqlDataReader2[2], 0, false);
											if (flag25)
											{
												text5 = (("update cheques Set numcheque = " + obj5.ToString() + " where folio = " + sqlDataReader2[0].ToString()) ?? "");
											}
											else
											{
												text5 = (string.Concat(new string[]
												{
													"update cheques Set numcheque = ",
													obj5.ToString(),
													", folionotadeconsumo = ",
													obj5.ToString(),
													" where folio = ",
													sqlDataReader2[0].ToString()
												}) ?? "");
											}
											sqlQuery4.execQuery(text5);
											obj5 = Operators.AddObject(obj5, 1);
										}
										sqlDataReader2.Close();
									}
								}
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
						this.progBar.Value = 90;
						this.iniciaGriSeriesFolios();
						text5 = "select distinct serie from folios order by serie asc";
						sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
						bool hasRows18 = sqlDataReader2.HasRows;
						if (hasRows18)
						{
							while (sqlDataReader2.Read())
							{
								string text37 = Conversions.ToString(sqlDataReader2[0]);
								this.DataGridFoliosRenumerar.Rows.Add(new object[]
								{
									text37
								});
							}
							sqlDataReader2.Close();
						}
						try
						{
							foreach (object obj8 in ((IEnumerable)this.DataGridFoliosRenumerar.Rows))
							{
								DataGridViewRow dataGridViewRow5 = (DataGridViewRow)obj8;
								string text38 = Conversions.ToString(dataGridViewRow5.Cells["Serie"].Value);
								text5 = "Select Case When Max(numcheque) is Null then 0 Else Max(numcheque) end from cheques where seriefolio = '" + text38 + "'";
								sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(text5);
								bool hasRows19 = sqlDataReader2.HasRows;
								if (hasRows19)
								{
									while (sqlDataReader2.Read())
									{
										string value2 = Conversions.ToString(sqlDataReader2[0]);
										dataGridViewRow5.Cells["Folio"].Value = value2;
										text5 = string.Concat(new string[]
										{
											"Update folios set ultimofolio='",
											sqlDataReader2[0].ToString(),
											"' , ultimofolionotadeconsumo='",
											sqlDataReader2[0].ToString(),
											"' where (serie) = '",
											text38,
											"'"
										});
										sqlQuery4.execQuery(text5);
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator7;
							if (enumerator7 is IDisposable)
							{
								(enumerator7 as IDisposable).Dispose();
							}
						}
					}
				}
				text5 = "Update Folios set UltimaOrden=0 , UltimofolioProduccion=0 where ultimofolio=0";
				sqlQuery4.execQuery(text5);
				this.progBar.Value = 100;
				Interaction.MsgBox("Proceso Finalizado, los totales se actualizaron en el software para restaurante!", MsgBoxStyle.OkOnly, null);
				this.iniciaGridFolio();
				this.progBar.Value = 0;
				this.habilitaControles(true);
				this.refrescaDatos();
			}
			bool flag26 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.No, false);
			if (flag26)
			{
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000AD6E8 File Offset: 0x000AB8E8
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

		// Token: 0x060009DE RID: 2526 RVA: 0x000AD9D4 File Offset: 0x000ABBD4
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
						this.habilitaControles(false);
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

		// Token: 0x060009DF RID: 2527 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtEfectivoAnt_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000ADCA0 File Offset: 0x000ABEA0
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

		// Token: 0x060009E1 RID: 2529 RVA: 0x000ADD9F File Offset: 0x000ABF9F
		private void dgvNotas_MouseUp(object sender, MouseEventArgs e)
		{
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00053212 File Offset: 0x00051412
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000ADDAE File Offset: 0x000ABFAE
		private void txtDescto_TextChanged(object sender, EventArgs e)
		{
			this.txtMinimo.Text = Conversions.ToString(0);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000ADDC3 File Offset: 0x000ABFC3
		private void txtDescto_Click(object sender, EventArgs e)
		{
			this.txtMinimo.Text = Conversions.ToString(0);
			this.txtDescto.SelectAll();
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x000ADDE4 File Offset: 0x000ABFE4
		private void txtMinimo_TextChanged(object sender, EventArgs e)
		{
			this.txtDescto.Text = Conversions.ToString(0);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x000ADDF9 File Offset: 0x000ABFF9
		private void txtMinimo_Click(object sender, EventArgs e)
		{
			this.txtDescto.Text = Conversions.ToString(0);
			this.txtMinimo.SelectAll();
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtventasinfacturar_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x000ADE1A File Offset: 0x000AC01A
		private void BtnHorario_Click(object sender, EventArgs e)
		{
			this.BtnHorario.Enabled = false;
			this.dateHoraIni.Enabled = true;
			this.dateHoraFin.Enabled = true;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox2_DoubleClick(object sender, EventArgs e)
		{
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x000ADE44 File Offset: 0x000AC044
		private void PictureBox3_Click(object sender, EventArgs e)
		{
			this.Panelvercortes.Visible = false;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000036D5 File Offset: 0x000018D5
		private void groupPeriodo_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x000ADE54 File Offset: 0x000AC054
		private void PictureBox6_Click(object sender, EventArgs e)
		{
			this.Panel1.Visible = true;
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x000ADE64 File Offset: 0x000AC064
		private void PictureBox5_Click(object sender, EventArgs e)
		{
			this.Panel1.Visible = false;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x000036D5 File Offset: 0x000018D5
		private void lblPorcentaje_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x000036D5 File Offset: 0x000018D5
		private void lblFolioIni_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x000ADE74 File Offset: 0x000AC074
		private void btnCorteZ_Click(object sender, EventArgs e)
		{
			this.Panelvercortes.Visible = true;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x000ADE84 File Offset: 0x000AC084
		private void Button1_Click_1(object sender, EventArgs e)
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

		// Token: 0x060009F7 RID: 2551 RVA: 0x000ADF30 File Offset: 0x000AC130
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

		// Token: 0x060009F8 RID: 2552 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtVentaFacturada_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x000ADFDC File Offset: 0x000AC1DC
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

		// Token: 0x060009FA RID: 2554 RVA: 0x000AE39C File Offset: 0x000AC59C
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

		// Token: 0x060009FB RID: 2555 RVA: 0x000AE3F4 File Offset: 0x000AC5F4
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
					dataRow["Total con Descuento"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total con Descuento"].Value);
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

		// Token: 0x060009FC RID: 2556 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvNotas_CellContextMenuStripChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0400048C RID: 1164
		private object iFolioInicial;

		// Token: 0x0400048D RID: 1165
		private object iNumChequeInicial;

		// Token: 0x0400048E RID: 1166
		private DataTable table;

		// Token: 0x0400048F RID: 1167
		private DataView view;

		// Token: 0x04000490 RID: 1168
		private string DifPorcentajeSin;

		// Token: 0x04000491 RID: 1169
		private string IFolioInirenumerar;
	}
}
