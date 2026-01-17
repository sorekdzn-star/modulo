using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x0200001C RID: 28
	[DesignerGenerated]
	public partial class FrmModificarTicket : Form
	{
		// Token: 0x06000B0D RID: 2829 RVA: 0x000BAAEA File Offset: 0x000B8CEA
		public FrmModificarTicket()
		{
			base.Load += this.FrmModificarTicket_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x000C12AE File Offset: 0x000BF4AE
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x000C12B8 File Offset: 0x000BF4B8
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x000C12C1 File Offset: 0x000BF4C1
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x000C12CC File Offset: 0x000BF4CC
		internal virtual Panel Panel1
		{
			[CompilerGenerated]
			get
			{
				return this._Panel1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.Panel1_Paint);
				Panel panel = this._Panel1;
				if (panel != null)
				{
					panel.Paint -= value2;
				}
				this._Panel1 = value;
				panel = this._Panel1;
				if (panel != null)
				{
					panel.Paint += value2;
				}
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x000C130F File Offset: 0x000BF50F
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x000C131C File Offset: 0x000BF51C
		internal virtual Panel Panel2
		{
			[CompilerGenerated]
			get
			{
				return this._Panel2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.Panel2_Paint);
				Panel panel = this._Panel2;
				if (panel != null)
				{
					panel.Paint -= value2;
				}
				this._Panel2 = value;
				panel = this._Panel2;
				if (panel != null)
				{
					panel.Paint += value2;
				}
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x000C135F File Offset: 0x000BF55F
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x000C1369 File Offset: 0x000BF569
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x000C1372 File Offset: 0x000BF572
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x000C137C File Offset: 0x000BF57C
		internal virtual TextBox txtPropina { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x000C1385 File Offset: 0x000BF585
		// (set) Token: 0x06000B1B RID: 2843 RVA: 0x000C138F File Offset: 0x000BF58F
		internal virtual Label lblPropina { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x000C1398 File Offset: 0x000BF598
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x000C13A2 File Offset: 0x000BF5A2
		internal virtual TextBox txtotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x000C13AB File Offset: 0x000BF5AB
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x000C13B5 File Offset: 0x000BF5B5
		internal virtual Label lblOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x000C13BE File Offset: 0x000BF5BE
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x000C13C8 File Offset: 0x000BF5C8
		internal virtual TextBox txtvales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x000C13D1 File Offset: 0x000BF5D1
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x000C13DB File Offset: 0x000BF5DB
		internal virtual Label lblVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x000C13E4 File Offset: 0x000BF5E4
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x000C13EE File Offset: 0x000BF5EE
		internal virtual TextBox txtTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x000C13F7 File Offset: 0x000BF5F7
		// (set) Token: 0x06000B27 RID: 2855 RVA: 0x000C1401 File Offset: 0x000BF601
		internal virtual Label lbltarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x000C140A File Offset: 0x000BF60A
		// (set) Token: 0x06000B29 RID: 2857 RVA: 0x000C1414 File Offset: 0x000BF614
		internal virtual TextBox txtEfectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x000C141D File Offset: 0x000BF61D
		// (set) Token: 0x06000B2B RID: 2859 RVA: 0x000C1427 File Offset: 0x000BF627
		internal virtual Label lblefectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x000C1430 File Offset: 0x000BF630
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x000C143A File Offset: 0x000BF63A
		internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x000C1443 File Offset: 0x000BF643
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x000C144D File Offset: 0x000BF64D
		internal virtual Label lblEmpresa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x000C1456 File Offset: 0x000BF656
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x000C1460 File Offset: 0x000BF660
		internal virtual ComboBox ComboBoxIdEmpresa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x000C1469 File Offset: 0x000BF669
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x000C1474 File Offset: 0x000BF674
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

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x000C14B7 File Offset: 0x000BF6B7
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x000C14C1 File Offset: 0x000BF6C1
		internal virtual TextBox txtSerie { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x000C14CA File Offset: 0x000BF6CA
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x000C14D4 File Offset: 0x000BF6D4
		public virtual TextBox txtBuscarFolio
		{
			[CompilerGenerated]
			get
			{
				return this._txtBuscarFolio;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtBuscarFolio_TextChanged);
				EventHandler value3 = new EventHandler(this.txtBuscarFolio_Click);
				TextBox txtBuscarFolio = this._txtBuscarFolio;
				if (txtBuscarFolio != null)
				{
					txtBuscarFolio.TextChanged -= value2;
					txtBuscarFolio.Click -= value3;
				}
				this._txtBuscarFolio = value;
				txtBuscarFolio = this._txtBuscarFolio;
				if (txtBuscarFolio != null)
				{
					txtBuscarFolio.TextChanged += value2;
					txtBuscarFolio.Click += value3;
				}
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x000C1532 File Offset: 0x000BF732
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x000C153C File Offset: 0x000BF73C
		internal virtual Label lblSerie { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x000C1545 File Offset: 0x000BF745
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x000C154F File Offset: 0x000BF74F
		internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x000C1558 File Offset: 0x000BF758
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x000C1562 File Offset: 0x000BF762
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x000C156B File Offset: 0x000BF76B
		// (set) Token: 0x06000B3F RID: 2879 RVA: 0x000C1575 File Offset: 0x000BF775
		internal virtual TextBox txtTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x000C157E File Offset: 0x000BF77E
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x000C1588 File Offset: 0x000BF788
		internal virtual TextBox txtSubtotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x000C1591 File Offset: 0x000BF791
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x000C159B File Offset: 0x000BF79B
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x000C15A4 File Offset: 0x000BF7A4
		// (set) Token: 0x06000B45 RID: 2885 RVA: 0x000C15AE File Offset: 0x000BF7AE
		internal virtual TextBox txtDescuento { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x000C15B7 File Offset: 0x000BF7B7
		// (set) Token: 0x06000B47 RID: 2887 RVA: 0x000C15C1 File Offset: 0x000BF7C1
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x000C15CA File Offset: 0x000BF7CA
		// (set) Token: 0x06000B49 RID: 2889 RVA: 0x000C15D4 File Offset: 0x000BF7D4
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x000C15DD File Offset: 0x000BF7DD
		// (set) Token: 0x06000B4B RID: 2891 RVA: 0x000C15E7 File Offset: 0x000BF7E7
		internal virtual Panel PanelVariables { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x000C15F0 File Offset: 0x000BF7F0
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x000C15FA File Offset: 0x000BF7FA
		internal virtual Label lblEfectivoTurno1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x000C1603 File Offset: 0x000BF803
		// (set) Token: 0x06000B4F RID: 2895 RVA: 0x000C160D File Offset: 0x000BF80D
		internal virtual DateTimePicker dateHoraFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x000C1616 File Offset: 0x000BF816
		// (set) Token: 0x06000B51 RID: 2897 RVA: 0x000C1620 File Offset: 0x000BF820
		internal virtual DateTimePicker dateHoraIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x000C1629 File Offset: 0x000BF829
		// (set) Token: 0x06000B53 RID: 2899 RVA: 0x000C1633 File Offset: 0x000BF833
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x000C163C File Offset: 0x000BF83C
		// (set) Token: 0x06000B55 RID: 2901 RVA: 0x000C1646 File Offset: 0x000BF846
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x000C164F File Offset: 0x000BF84F
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x000C1659 File Offset: 0x000BF859
		internal virtual Label lblTotalOtrosSinDescuento { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x000C1662 File Offset: 0x000BF862
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x000C166C File Offset: 0x000BF86C
		internal virtual Label lblTotalOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x000C1675 File Offset: 0x000BF875
		// (set) Token: 0x06000B5B RID: 2907 RVA: 0x000C167F File Offset: 0x000BF87F
		internal virtual Label lblTotalBebidasDesc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x000C1688 File Offset: 0x000BF888
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x000C1692 File Offset: 0x000BF892
		internal virtual Label lblTotalAlimentos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x000C169B File Offset: 0x000BF89B
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x000C16A5 File Offset: 0x000BF8A5
		internal virtual Label lblTotalAlimentosDescuento { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x000C16AE File Offset: 0x000BF8AE
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x000C16B8 File Offset: 0x000BF8B8
		internal virtual Label lblTotalBebidas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x000C16C1 File Offset: 0x000BF8C1
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x000C16CB File Offset: 0x000BF8CB
		internal virtual Label lblFechadelProducto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x000C16D4 File Offset: 0x000BF8D4
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x000C16DE File Offset: 0x000BF8DE
		internal virtual Label lblidFoliodet { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x000C16E7 File Offset: 0x000BF8E7
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x000C16F1 File Offset: 0x000BF8F1
		internal virtual Label lblContarFilas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x000C16FA File Offset: 0x000BF8FA
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x000C1704 File Offset: 0x000BF904
		internal virtual CheckBox chkRenumerar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x000C170D File Offset: 0x000BF90D
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x000C1717 File Offset: 0x000BF917
		internal virtual Label lblIdEstacion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x000C1720 File Offset: 0x000BF920
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x000C172A File Offset: 0x000BF92A
		internal virtual Label lblRefolear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x000C1733 File Offset: 0x000BF933
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x000C173D File Offset: 0x000BF93D
		internal virtual Label lblMesero { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x000C1746 File Offset: 0x000BF946
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x000C1750 File Offset: 0x000BF950
		internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x000C1759 File Offset: 0x000BF959
		// (set) Token: 0x06000B73 RID: 2931 RVA: 0x000C1764 File Offset: 0x000BF964
		internal virtual PictureBox btnEliminarProducto
		{
			[CompilerGenerated]
			get
			{
				return this._btnEliminarProducto;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnEliminarProducto_Click);
				PictureBox btnEliminarProducto = this._btnEliminarProducto;
				if (btnEliminarProducto != null)
				{
					btnEliminarProducto.Click -= value2;
				}
				this._btnEliminarProducto = value;
				btnEliminarProducto = this._btnEliminarProducto;
				if (btnEliminarProducto != null)
				{
					btnEliminarProducto.Click += value2;
				}
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x000C17A7 File Offset: 0x000BF9A7
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x000C17B4 File Offset: 0x000BF9B4
		internal virtual PictureBox BtnAgregarProducto
		{
			[CompilerGenerated]
			get
			{
				return this._BtnAgregarProducto;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnAgregarProducto_Click);
				PictureBox btnAgregarProducto = this._BtnAgregarProducto;
				if (btnAgregarProducto != null)
				{
					btnAgregarProducto.Click -= value2;
				}
				this._BtnAgregarProducto = value;
				btnAgregarProducto = this._BtnAgregarProducto;
				if (btnAgregarProducto != null)
				{
					btnAgregarProducto.Click += value2;
				}
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x000C17F7 File Offset: 0x000BF9F7
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x000C1804 File Offset: 0x000BFA04
		internal virtual PictureBox BtnVolver
		{
			[CompilerGenerated]
			get
			{
				return this._BtnVolver;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnVolver_Click);
				PictureBox btnVolver = this._BtnVolver;
				if (btnVolver != null)
				{
					btnVolver.Click -= value2;
				}
				this._BtnVolver = value;
				btnVolver = this._BtnVolver;
				if (btnVolver != null)
				{
					btnVolver.Click += value2;
				}
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x000C1847 File Offset: 0x000BFA47
		// (set) Token: 0x06000B79 RID: 2937 RVA: 0x000C1851 File Offset: 0x000BFA51
		internal virtual Panel Panel16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x000C185A File Offset: 0x000BFA5A
		// (set) Token: 0x06000B7B RID: 2939 RVA: 0x000C1864 File Offset: 0x000BFA64
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x000C186D File Offset: 0x000BFA6D
		// (set) Token: 0x06000B7D RID: 2941 RVA: 0x000C1878 File Offset: 0x000BFA78
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

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x000C18BB File Offset: 0x000BFABB
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x000C18C5 File Offset: 0x000BFAC5
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x000C18CE File Offset: 0x000BFACE
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x000C18D8 File Offset: 0x000BFAD8
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

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x000C191B File Offset: 0x000BFB1B
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x000C1925 File Offset: 0x000BFB25
		internal virtual DateTimePicker dateFechaFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x000C192E File Offset: 0x000BFB2E
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x000C1938 File Offset: 0x000BFB38
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x000C1941 File Offset: 0x000BFB41
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x000C194B File Offset: 0x000BFB4B
		internal virtual DateTimePicker dateFechaIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x000C1954 File Offset: 0x000BFB54
		// (set) Token: 0x06000B89 RID: 2953 RVA: 0x000C195E File Offset: 0x000BFB5E
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x000C1967 File Offset: 0x000BFB67
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x000C1971 File Offset: 0x000BFB71
		internal virtual Label lblFolioIdentity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x000C197A File Offset: 0x000BFB7A
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x000C1984 File Offset: 0x000BFB84
		internal virtual Label lblFolioPagoPropina { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x000C198D File Offset: 0x000BFB8D
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x000C1997 File Offset: 0x000BFB97
		internal virtual Label lblditurnoformadepago { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x000C19A0 File Offset: 0x000BFBA0
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x000C19AA File Offset: 0x000BFBAA
		internal virtual Label lblfoliopropinasincuenta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x000C19B3 File Offset: 0x000BFBB3
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x000C19BD File Offset: 0x000BFBBD
		internal virtual Label lblNuevoFOlioPropina { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x000C19C6 File Offset: 0x000BFBC6
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x000C19D0 File Offset: 0x000BFBD0
		internal virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x000C19D9 File Offset: 0x000BFBD9
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x000C19E3 File Offset: 0x000BFBE3
		internal virtual Label Label50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x000C19EC File Offset: 0x000BFBEC
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x000C19F6 File Offset: 0x000BFBF6
		internal virtual Panel Panel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x000C19FF File Offset: 0x000BFBFF
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x000C1A09 File Offset: 0x000BFC09
		internal virtual Label lblContarFilasEliminar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x000C1A12 File Offset: 0x000BFC12
		// (set) Token: 0x06000B9D RID: 2973 RVA: 0x000C1A1C File Offset: 0x000BFC1C
		internal virtual Label lblTotalDeFilasDGV { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x000C1A25 File Offset: 0x000BFC25
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x000C1A2F File Offset: 0x000BFC2F
		internal virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x000C1A38 File Offset: 0x000BFC38
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x000C1A42 File Offset: 0x000BFC42
		internal virtual Panel Panel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x000C1A4B File Offset: 0x000BFC4B
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x000C1A58 File Offset: 0x000BFC58
		internal virtual Button BtnVerTickets
		{
			[CompilerGenerated]
			get
			{
				return this._BtnVerTickets;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnVerTickets_Click);
				Button btnVerTickets = this._BtnVerTickets;
				if (btnVerTickets != null)
				{
					btnVerTickets.Click -= value2;
				}
				this._BtnVerTickets = value;
				btnVerTickets = this._BtnVerTickets;
				if (btnVerTickets != null)
				{
					btnVerTickets.Click += value2;
				}
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x000C1A9B File Offset: 0x000BFC9B
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x000C1AA8 File Offset: 0x000BFCA8
		internal virtual DataGridView DgvTicketsPeriodo
		{
			[CompilerGenerated]
			get
			{
				return this._DgvTicketsPeriodo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DgvTicketsPeriodo_CellContentClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.DgvTicketsPeriodo_CellDoubleClick);
				DataGridView dgvTicketsPeriodo = this._DgvTicketsPeriodo;
				if (dgvTicketsPeriodo != null)
				{
					dgvTicketsPeriodo.CellContentClick -= value2;
					dgvTicketsPeriodo.CellDoubleClick -= value3;
				}
				this._DgvTicketsPeriodo = value;
				dgvTicketsPeriodo = this._DgvTicketsPeriodo;
				if (dgvTicketsPeriodo != null)
				{
					dgvTicketsPeriodo.CellContentClick += value2;
					dgvTicketsPeriodo.CellDoubleClick += value3;
				}
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x000C1B06 File Offset: 0x000BFD06
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x000C1B10 File Offset: 0x000BFD10
		internal virtual Panel Panel14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x000C1B19 File Offset: 0x000BFD19
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x000C1B23 File Offset: 0x000BFD23
		internal virtual Panel PanelDGW { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x000C1B2C File Offset: 0x000BFD2C
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x000C1B36 File Offset: 0x000BFD36
		internal virtual Panel PanelBuscarProducto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x000C1B3F File Offset: 0x000BFD3F
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x000C1B49 File Offset: 0x000BFD49
		internal virtual Panel Panel17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x000C1B52 File Offset: 0x000BFD52
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x000C1B5C File Offset: 0x000BFD5C
		internal virtual DataGridView dgwProductos
		{
			[CompilerGenerated]
			get
			{
				return this._dgwProductos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgwProductos_CellValueChanged);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.dgwProductos_CellContentClick);
				DataGridViewCellEventHandler value4 = new DataGridViewCellEventHandler(this.dgwProductos_CellClick);
				DataGridViewCellMouseEventHandler value5 = new DataGridViewCellMouseEventHandler(this.dgwProductos_CellMouseClick);
				DataGridView dgwProductos = this._dgwProductos;
				if (dgwProductos != null)
				{
					dgwProductos.CellValueChanged -= value2;
					dgwProductos.CellContentClick -= value3;
					dgwProductos.CellClick -= value4;
					dgwProductos.CellMouseClick -= value5;
				}
				this._dgwProductos = value;
				dgwProductos = this._dgwProductos;
				if (dgwProductos != null)
				{
					dgwProductos.CellValueChanged += value2;
					dgwProductos.CellContentClick += value3;
					dgwProductos.CellClick += value4;
					dgwProductos.CellMouseClick += value5;
				}
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x000C1BFC File Offset: 0x000BFDFC
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x000C1C06 File Offset: 0x000BFE06
		internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x000C1C0F File Offset: 0x000BFE0F
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x000C1C1C File Offset: 0x000BFE1C
		internal virtual PictureBox PictureBox2
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox2_Click_1);
				PictureBox pictureBox = this._PictureBox2;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox2 = value;
				pictureBox = this._PictureBox2;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x000C1C5F File Offset: 0x000BFE5F
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x000C1C69 File Offset: 0x000BFE69
		internal virtual Panel Panel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x000C1C72 File Offset: 0x000BFE72
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x000C1C7C File Offset: 0x000BFE7C
		internal virtual Label lblContadorJC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x000C1C85 File Offset: 0x000BFE85
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x000C1C8F File Offset: 0x000BFE8F
		internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x000C1C98 File Offset: 0x000BFE98
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x000C1CA4 File Offset: 0x000BFEA4
		internal virtual TextBox txtBuscarProducto
		{
			[CompilerGenerated]
			get
			{
				return this._txtBuscarProducto;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtBuscarProducto_TextChanged);
				EventHandler value3 = new EventHandler(this.txtBuscarProducto_Click);
				TextBox txtBuscarProducto = this._txtBuscarProducto;
				if (txtBuscarProducto != null)
				{
					txtBuscarProducto.TextChanged -= value2;
					txtBuscarProducto.Click -= value3;
				}
				this._txtBuscarProducto = value;
				txtBuscarProducto = this._txtBuscarProducto;
				if (txtBuscarProducto != null)
				{
					txtBuscarProducto.TextChanged += value2;
					txtBuscarProducto.Click += value3;
				}
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x000C1D02 File Offset: 0x000BFF02
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x000C1D0C File Offset: 0x000BFF0C
		internal virtual PictureBox PictureBox4
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox4_Click);
				PictureBox pictureBox = this._PictureBox4;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox4 = value;
				pictureBox = this._PictureBox4;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x000C1D4F File Offset: 0x000BFF4F
		// (set) Token: 0x06000BBF RID: 3007 RVA: 0x000C1D59 File Offset: 0x000BFF59
		internal virtual Panel PanelFormasdePago { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x000C1D62 File Offset: 0x000BFF62
		// (set) Token: 0x06000BC1 RID: 3009 RVA: 0x000C1D6C File Offset: 0x000BFF6C
		internal virtual Panel Panel10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x000C1D75 File Offset: 0x000BFF75
		// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x000C1D7F File Offset: 0x000BFF7F
		internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x000C1D88 File Offset: 0x000BFF88
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x000C1D92 File Offset: 0x000BFF92
		internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x000C1D9B File Offset: 0x000BFF9B
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x000C1DA5 File Offset: 0x000BFFA5
		internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x000C1DAE File Offset: 0x000BFFAE
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x000C1DB8 File Offset: 0x000BFFB8
		internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x000C1DC1 File Offset: 0x000BFFC1
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x000C1DCB File Offset: 0x000BFFCB
		internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x000C1DD4 File Offset: 0x000BFFD4
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x000C1DE0 File Offset: 0x000BFFE0
		internal virtual TextBox TxtPropinaEnOtros
		{
			[CompilerGenerated]
			get
			{
				return this._TxtPropinaEnOtros;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TxtPropinaEnOtros_TextChanged);
				EventHandler value3 = new EventHandler(this.TxtPropinaEnOtros_Click);
				TextBox txtPropinaEnOtros = this._TxtPropinaEnOtros;
				if (txtPropinaEnOtros != null)
				{
					txtPropinaEnOtros.TextChanged -= value2;
					txtPropinaEnOtros.Click -= value3;
				}
				this._TxtPropinaEnOtros = value;
				txtPropinaEnOtros = this._TxtPropinaEnOtros;
				if (txtPropinaEnOtros != null)
				{
					txtPropinaEnOtros.TextChanged += value2;
					txtPropinaEnOtros.Click += value3;
				}
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x000C1E3E File Offset: 0x000C003E
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x000C1E48 File Offset: 0x000C0048
		internal virtual TextBox txtPropinaEnVales
		{
			[CompilerGenerated]
			get
			{
				return this._txtPropinaEnVales;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtPropinaEnVales_TextChanged);
				EventHandler value3 = new EventHandler(this.txtPropinaEnVales_Click);
				TextBox txtPropinaEnVales = this._txtPropinaEnVales;
				if (txtPropinaEnVales != null)
				{
					txtPropinaEnVales.TextChanged -= value2;
					txtPropinaEnVales.Click -= value3;
				}
				this._txtPropinaEnVales = value;
				txtPropinaEnVales = this._txtPropinaEnVales;
				if (txtPropinaEnVales != null)
				{
					txtPropinaEnVales.TextChanged += value2;
					txtPropinaEnVales.Click += value3;
				}
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x000C1EA6 File Offset: 0x000C00A6
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x000C1EB0 File Offset: 0x000C00B0
		internal virtual TextBox txtPropinaEnTarjeta
		{
			[CompilerGenerated]
			get
			{
				return this._txtPropinaEnTarjeta;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtPropinaEnTarjeta_TextChanged);
				EventHandler value3 = new EventHandler(this.txtPropinaEnTarjeta_Click);
				TextBox txtPropinaEnTarjeta = this._txtPropinaEnTarjeta;
				if (txtPropinaEnTarjeta != null)
				{
					txtPropinaEnTarjeta.TextChanged -= value2;
					txtPropinaEnTarjeta.Click -= value3;
				}
				this._txtPropinaEnTarjeta = value;
				txtPropinaEnTarjeta = this._txtPropinaEnTarjeta;
				if (txtPropinaEnTarjeta != null)
				{
					txtPropinaEnTarjeta.TextChanged += value2;
					txtPropinaEnTarjeta.Click += value3;
				}
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x000C1F0E File Offset: 0x000C010E
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x000C1F18 File Offset: 0x000C0118
		internal virtual TextBox TxtPropinaEnEfectivo
		{
			[CompilerGenerated]
			get
			{
				return this._TxtPropinaEnEfectivo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TxtPropinaEnEfectivo_TextChanged);
				EventHandler value3 = new EventHandler(this.TxtPropinaEnEfectivo_Click);
				TextBox txtPropinaEnEfectivo = this._TxtPropinaEnEfectivo;
				if (txtPropinaEnEfectivo != null)
				{
					txtPropinaEnEfectivo.TextChanged -= value2;
					txtPropinaEnEfectivo.Click -= value3;
				}
				this._TxtPropinaEnEfectivo = value;
				txtPropinaEnEfectivo = this._TxtPropinaEnEfectivo;
				if (txtPropinaEnEfectivo != null)
				{
					txtPropinaEnEfectivo.TextChanged += value2;
					txtPropinaEnEfectivo.Click += value3;
				}
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x000C1F76 File Offset: 0x000C0176
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x000C1F80 File Offset: 0x000C0180
		internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x000C1F89 File Offset: 0x000C0189
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x000C1F93 File Offset: 0x000C0193
		internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x000C1F9C File Offset: 0x000C019C
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x000C1FA6 File Offset: 0x000C01A6
		internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x000C1FAF File Offset: 0x000C01AF
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x000C1FB9 File Offset: 0x000C01B9
		internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x000C1FC2 File Offset: 0x000C01C2
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x000C1FCC File Offset: 0x000C01CC
		internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x000C1FD5 File Offset: 0x000C01D5
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x000C1FDF File Offset: 0x000C01DF
		internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x000C1FE8 File Offset: 0x000C01E8
		// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x000C1FF2 File Offset: 0x000C01F2
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x000C1FFB File Offset: 0x000C01FB
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x000C2008 File Offset: 0x000C0208
		internal virtual TextBox txtPagoPropina
		{
			[CompilerGenerated]
			get
			{
				return this._txtPagoPropina;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtPagoPropina_TextChanged);
				EventHandler value3 = new EventHandler(this.txtPagoPropina_Click);
				TextBox txtPagoPropina = this._txtPagoPropina;
				if (txtPagoPropina != null)
				{
					txtPagoPropina.TextChanged -= value2;
					txtPagoPropina.Click -= value3;
				}
				this._txtPagoPropina = value;
				txtPagoPropina = this._txtPagoPropina;
				if (txtPagoPropina != null)
				{
					txtPagoPropina.TextChanged += value2;
					txtPagoPropina.Click += value3;
				}
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x000C2066 File Offset: 0x000C0266
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x000C2070 File Offset: 0x000C0270
		internal virtual TextBox txtPagoOtros
		{
			[CompilerGenerated]
			get
			{
				return this._txtPagoOtros;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtPagoOtros_TextChanged);
				EventHandler value3 = new EventHandler(this.txtPagoOtros_Click);
				TextBox txtPagoOtros = this._txtPagoOtros;
				if (txtPagoOtros != null)
				{
					txtPagoOtros.TextChanged -= value2;
					txtPagoOtros.Click -= value3;
				}
				this._txtPagoOtros = value;
				txtPagoOtros = this._txtPagoOtros;
				if (txtPagoOtros != null)
				{
					txtPagoOtros.TextChanged += value2;
					txtPagoOtros.Click += value3;
				}
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x000C20CE File Offset: 0x000C02CE
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x000C20D8 File Offset: 0x000C02D8
		internal virtual TextBox txtPagoVales
		{
			[CompilerGenerated]
			get
			{
				return this._txtPagoVales;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtPagoVales_TextChanged);
				EventHandler value3 = new EventHandler(this.txtPagoVales_Click);
				TextBox txtPagoVales = this._txtPagoVales;
				if (txtPagoVales != null)
				{
					txtPagoVales.TextChanged -= value2;
					txtPagoVales.Click -= value3;
				}
				this._txtPagoVales = value;
				txtPagoVales = this._txtPagoVales;
				if (txtPagoVales != null)
				{
					txtPagoVales.TextChanged += value2;
					txtPagoVales.Click += value3;
				}
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x000C2136 File Offset: 0x000C0336
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x000C2140 File Offset: 0x000C0340
		internal virtual TextBox txtPagoTarjeta
		{
			[CompilerGenerated]
			get
			{
				return this._txtPagoTarjeta;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtPagoTarjeta_TextChanged);
				EventHandler value3 = new EventHandler(this.txtPagoTarjeta_Click);
				TextBox txtPagoTarjeta = this._txtPagoTarjeta;
				if (txtPagoTarjeta != null)
				{
					txtPagoTarjeta.TextChanged -= value2;
					txtPagoTarjeta.Click -= value3;
				}
				this._txtPagoTarjeta = value;
				txtPagoTarjeta = this._txtPagoTarjeta;
				if (txtPagoTarjeta != null)
				{
					txtPagoTarjeta.TextChanged += value2;
					txtPagoTarjeta.Click += value3;
				}
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x000C219E File Offset: 0x000C039E
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x000C21A8 File Offset: 0x000C03A8
		internal virtual TextBox txtPagoEfectivo
		{
			[CompilerGenerated]
			get
			{
				return this._txtPagoEfectivo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtPagoEfectivo_TextChanged);
				EventHandler value3 = new EventHandler(this.txtPagoEfectivo_Click);
				TextBox txtPagoEfectivo = this._txtPagoEfectivo;
				if (txtPagoEfectivo != null)
				{
					txtPagoEfectivo.TextChanged -= value2;
					txtPagoEfectivo.Click -= value3;
				}
				this._txtPagoEfectivo = value;
				txtPagoEfectivo = this._txtPagoEfectivo;
				if (txtPagoEfectivo != null)
				{
					txtPagoEfectivo.TextChanged += value2;
					txtPagoEfectivo.Click += value3;
				}
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x000C2206 File Offset: 0x000C0406
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x000C2210 File Offset: 0x000C0410
		internal virtual Panel Panel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x000C2219 File Offset: 0x000C0419
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x000C2223 File Offset: 0x000C0423
		internal virtual Label labeltotalformasdepago { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x000C222C File Offset: 0x000C042C
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x000C2236 File Offset: 0x000C0436
		internal virtual Label lbltotalpropinasvalidacion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x000C223F File Offset: 0x000C043F
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x000C2249 File Offset: 0x000C0449
		internal virtual Label lbltotalvalidacion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x000C2252 File Offset: 0x000C0452
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x000C225C File Offset: 0x000C045C
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

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x000C229F File Offset: 0x000C049F
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x000C22A9 File Offset: 0x000C04A9
		internal virtual Panel Panel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x000C22B2 File Offset: 0x000C04B2
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x000C22BC File Offset: 0x000C04BC
		internal virtual Label lblTotalFormapagoconpropina { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x000C22C5 File Offset: 0x000C04C5
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x000C22CF File Offset: 0x000C04CF
		internal virtual Label lbldiefectivotarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x000C22D8 File Offset: 0x000C04D8
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x000C22E2 File Offset: 0x000C04E2
		internal virtual Label lblidefectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x000C22EB File Offset: 0x000C04EB
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x000C22F5 File Offset: 0x000C04F5
		internal virtual Label lblPropinasSumar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x000C22FE File Offset: 0x000C04FE
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x000C2308 File Offset: 0x000C0508
		internal virtual Label lblOtrosSUmar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x000C2311 File Offset: 0x000C0511
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x000C231B File Offset: 0x000C051B
		internal virtual Label lblValesSumar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x000C2324 File Offset: 0x000C0524
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x000C232E File Offset: 0x000C052E
		internal virtual Label lblTarjetasumar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x000C2337 File Offset: 0x000C0537
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x000C2341 File Offset: 0x000C0541
		internal virtual Label lblEfectivoSumar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x000C234A File Offset: 0x000C054A
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x000C2354 File Offset: 0x000C0554
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

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x000C2397 File Offset: 0x000C0597
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x000C23A1 File Offset: 0x000C05A1
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x000C23AA File Offset: 0x000C05AA
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x000C23B4 File Offset: 0x000C05B4
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
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.dgvNotas_CellContentClick);
				DataGridView dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellClick -= value2;
					dgvNotas.CellContentClick -= value3;
				}
				this._dgvNotas = value;
				dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellClick += value2;
					dgvNotas.CellContentClick += value3;
				}
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x000C2412 File Offset: 0x000C0612
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x000C241C File Offset: 0x000C061C
		internal virtual Panel Panel12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x000C2425 File Offset: 0x000C0625
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x000C242F File Offset: 0x000C062F
		internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x000C2438 File Offset: 0x000C0638
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x000C2442 File Offset: 0x000C0642
		internal virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x000C244B File Offset: 0x000C064B
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x000C2455 File Offset: 0x000C0655
		internal virtual Label lblFolio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x000C245E File Offset: 0x000C065E
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x000C2468 File Offset: 0x000C0668
		internal virtual TextBox txtFechadelTicket { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x000C2471 File Offset: 0x000C0671
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x000C247B File Offset: 0x000C067B
		internal virtual TextBox TxtFacturado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x000C2484 File Offset: 0x000C0684
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x000C248E File Offset: 0x000C068E
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x000C2497 File Offset: 0x000C0697
		// (set) Token: 0x06000C1D RID: 3101 RVA: 0x000C24A1 File Offset: 0x000C06A1
		internal virtual TextBox txtPersonas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x000C24AA File Offset: 0x000C06AA
		// (set) Token: 0x06000C1F RID: 3103 RVA: 0x000C24B4 File Offset: 0x000C06B4
		internal virtual Label lblPersonas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x000C24BD File Offset: 0x000C06BD
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x000C24C8 File Offset: 0x000C06C8
		internal virtual Button btnCambiarFormadePago
		{
			[CompilerGenerated]
			get
			{
				return this._btnCambiarFormadePago;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				Button btnCambiarFormadePago = this._btnCambiarFormadePago;
				if (btnCambiarFormadePago != null)
				{
					btnCambiarFormadePago.Click -= value2;
				}
				this._btnCambiarFormadePago = value;
				btnCambiarFormadePago = this._btnCambiarFormadePago;
				if (btnCambiarFormadePago != null)
				{
					btnCambiarFormadePago.Click += value2;
				}
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x000C250B File Offset: 0x000C070B
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x000C2515 File Offset: 0x000C0715
		internal virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x000C251E File Offset: 0x000C071E
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x000C2528 File Offset: 0x000C0728
		internal virtual Panel Panel13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x000C2531 File Offset: 0x000C0731
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x000C253B File Offset: 0x000C073B
		internal virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x000C2544 File Offset: 0x000C0744
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x000C254E File Offset: 0x000C074E
		internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x000C2557 File Offset: 0x000C0757
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x000C2561 File Offset: 0x000C0761
		internal virtual TextBox txtFormasPago { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x000C256A File Offset: 0x000C076A
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x000C2574 File Offset: 0x000C0774
		internal virtual TextBox txtTotaldelTicket { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x000C257D File Offset: 0x000C077D
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x000C2587 File Offset: 0x000C0787
		internal virtual Label lblidturno_jc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000C30 RID: 3120 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x000036D5 File Offset: 0x000018D5
		private void GroupBox3_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x000C2590 File Offset: 0x000C0790
		private void FrmModificarTicket_Load(object sender, EventArgs e)
		{
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
			this.MostrarReporteProductos1();
			this.iniciaGridVerTickets();
			string text = "select o from H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string left = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					bool flag = Operators.CompareString(left, "0", false) != 0;
					if (flag)
					{
						this.llenaCombos();
						this.ComboBoxIdEmpresa.Enabled = false;
						this.txtSerie.Enabled = false;
						this.txtBuscarFolio.Text = "000000000";
						this.iniciaGridFolio();
						this.BtnVerTickets.Enabled = false;
						this.PanelFormasdePago.Visible = false;
						this.txtPersonas.Text = "0";
						this.TxtFacturado.Text = "N/A";
						this.txtFechadelTicket.Text = "N/A";
						this.txtEfectivo.Text = "$ 0.00";
						this.txtTarjeta.Text = "$ 0.00";
						this.txtvales.Text = "$ 0.00";
						this.txtotros.Text = "$ 0.00";
						this.txtDescuento.Text = "$ 0.00";
						this.txtPropina.Text = "$ 0.00";
						this.txtSubtotal.Text = "$ 0.00";
						this.txtTotal.Text = "$ 0.00";
						this.txtSerie.Text = "";
						this.PanelBuscarProducto.Visible = false;
						this.btnCambiarFormadePago.Visible = false;
						this.BtnAgregarProducto.Visible = false;
						this.btnEliminarProducto.Visible = false;
						this.PanelVariables.Visible = false;
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
						this.dateHoraFin.Enabled = false;
						this.dateHoraIni.Enabled = false;
						this.dateFechaIni.Enabled = false;
						this.dateFechaFin.Enabled = false;
						this.PictureBox1.Visible = false;
						this.txtBuscarFolio.Enabled = false;
						this.txtPersonas.Enabled = false;
						this.txtFechadelTicket.Enabled = false;
						this.TxtFacturado.Enabled = false;
						this.ComboBox1.Enabled = false;
						this.cmbAnio.Enabled = true;
						this.DoubleBufferedASD(this.dgvNotas, true);
						try
						{
							text = "UPDATE Cheqdet set idMeseroProducto='' where idmeseroproducto  is null";
							sqlQuery.execQuery(text);
						}
						catch (Exception ex)
						{
						}
					}
					bool flag2 = Operators.CompareString(left, "0", false) == 0;
					if (flag2)
					{
						this.llenaCombos();
						this.ComboBoxIdEmpresa.Enabled = false;
						this.txtSerie.Enabled = false;
						this.txtBuscarFolio.Text = "000000000";
						this.iniciaGridFolio();
						this.PanelFormasdePago.Visible = false;
						this.txtPersonas.Text = "0";
						this.TxtFacturado.Text = "N/A";
						this.txtFechadelTicket.Text = "N/A";
						this.txtEfectivo.Text = "$ 0.00";
						this.txtTarjeta.Text = "$ 0.00";
						this.txtvales.Text = "$ 0.00";
						this.txtotros.Text = "$ 0.00";
						this.txtDescuento.Text = "$ 0.00";
						this.txtPropina.Text = "$ 0.00";
						this.txtSubtotal.Text = "$ 0.00";
						this.txtTotal.Text = "$ 0.00";
						this.txtSerie.Text = "";
						this.PanelBuscarProducto.Visible = false;
						this.btnCambiarFormadePago.Visible = false;
						this.BtnAgregarProducto.Visible = false;
						this.btnEliminarProducto.Visible = false;
						this.PanelVariables.Visible = false;
						this.dateHoraFin.Format = DateTimePickerFormat.Custom;
						this.dateHoraFin.CustomFormat = "hh:mm:ss tt";
						this.dateHoraIni.Format = DateTimePickerFormat.Custom;
						this.dateHoraIni.CustomFormat = "hh:mm:ss tt";
						this.dateFechaIni.Text = Conversions.ToString(this.dateFechaIni.MinDate);
						this.dateFechaFin.Text = Conversions.ToString(this.dateFechaFin.MinDate);
						this.dateHoraFin.Enabled = false;
						this.dateHoraIni.Enabled = false;
						this.dateFechaIni.Enabled = false;
						this.dateFechaFin.Enabled = false;
						this.PictureBox1.Visible = false;
						this.txtBuscarFolio.Enabled = false;
						this.txtPersonas.Enabled = false;
						this.txtFechadelTicket.Enabled = false;
						this.TxtFacturado.Enabled = false;
						this.ComboBox1.Enabled = false;
						this.cmbAnio.Enabled = false;
						this.DoubleBufferedASD(this.dgvNotas, true);
						Interaction.MsgBox("Necesitas asignar las formas de pago dentro de Parametros,para poder utilizar esta funcion!", MsgBoxStyle.OkOnly, null);
					}
				}
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x000C2C00 File Offset: 0x000C0E00
		private void iniciaGridFolio()
		{
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			this.dgvNotas.Rows.Clear();
			this.dgvNotas.ColumnCount = 30;
			this.dgvNotas.Columns[0].Name = "id_nota";
			this.dgvNotas.Columns[0].Visible = false;
			this.dgvNotas.Columns[1].Name = "Mov.";
			this.dgvNotas.Columns[1].Width = 60;
			this.dgvNotas.Columns[2].Name = "Cantidad";
			this.dgvNotas.Columns[2].Width = 100;
			this.dgvNotas.Columns[3].Name = "Clave";
			this.dgvNotas.Columns[3].Width = 60;
			this.dgvNotas.Columns[3].Visible = false;
			this.dgvNotas.Columns[4].Name = "Descripcion del Producto";
			this.dgvNotas.Columns[4].Width = 200;
			this.dgvNotas.Columns[5].Name = "Descuento Producto %";
			this.dgvNotas.Columns[5].Width = 70;
			this.dgvNotas.Columns[6].Name = "Precio C/Descuento S/IVA";
			this.dgvNotas.Columns[6].Width = 80;
			this.dgvNotas.Columns[7].Name = "Precio C/Descuento C/IVA";
			this.dgvNotas.Columns[7].Width = 80;
			this.dgvNotas.Columns[8].Name = "Fecha";
			this.dgvNotas.Columns[8].Visible = false;
			this.dgvNotas.Columns[8].Width = 80;
			this.dgvNotas.Columns[9].Name = "Personas";
			this.dgvNotas.Columns[9].Visible = false;
			this.dgvNotas.Columns[9].Width = 80;
			this.dgvNotas.Columns[10].Name = "Descuento";
			this.dgvNotas.Columns[10].Visible = false;
			this.dgvNotas.Columns[10].Width = 80;
			this.dgvNotas.Columns[11].Name = "Subtotal";
			this.dgvNotas.Columns[11].Visible = false;
			this.dgvNotas.Columns[11].Width = 80;
			this.dgvNotas.Columns[12].Name = "Total";
			this.dgvNotas.Columns[12].Visible = false;
			this.dgvNotas.Columns[12].Width = 80;
			this.dgvNotas.Columns[13].Name = "PROPINA";
			this.dgvNotas.Columns[13].Visible = false;
			this.dgvNotas.Columns[13].Width = 80;
			this.dgvNotas.Columns[14].Name = "TARJETA";
			this.dgvNotas.Columns[14].Visible = false;
			this.dgvNotas.Columns[14].Width = 80;
			this.dgvNotas.Columns[15].Name = "EFECTIVO";
			this.dgvNotas.Columns[15].Visible = false;
			this.dgvNotas.Columns[15].Width = 80;
			this.dgvNotas.Columns[16].Name = "VALES";
			this.dgvNotas.Columns[16].Visible = false;
			this.dgvNotas.Columns[16].Width = 80;
			this.dgvNotas.Columns[17].Name = "OTROS";
			this.dgvNotas.Columns[17].Visible = false;
			this.dgvNotas.Columns[17].Width = 80;
			this.dgvNotas.Columns[18].Name = "IMPUESTOS";
			this.dgvNotas.Columns[18].Visible = false;
			this.dgvNotas.Columns[18].Width = 80;
			this.dgvNotas.Columns[19].Name = "FACTURADO";
			this.dgvNotas.Columns[19].Visible = false;
			this.dgvNotas.Columns[19].Width = 80;
			this.dgvNotas.Columns[20].Name = "Precio de Venta Unitario";
			this.dgvNotas.Columns[20].Visible = true;
			this.dgvNotas.Columns[20].Width = 80;
			this.dgvNotas.Columns[21].Name = "ig_grupo";
			this.dgvNotas.Columns[21].Visible = false;
			this.dgvNotas.Columns[21].Width = 80;
			this.dgvNotas.Columns[22].Name = "idgrupo_clasificacion";
			this.dgvNotas.Columns[22].Visible = false;
			this.dgvNotas.Columns[22].Width = 80;
			this.dgvNotas.Columns[23].Name = "TotalAlimentos";
			this.dgvNotas.Columns[23].Visible = false;
			this.dgvNotas.Columns[23].Width = 80;
			this.dgvNotas.Columns[24].Name = "TotalBebidas";
			this.dgvNotas.Columns[24].Visible = false;
			this.dgvNotas.Columns[24].Width = 80;
			this.dgvNotas.Columns[25].Name = "TotalOtros";
			this.dgvNotas.Columns[25].Visible = false;
			this.dgvNotas.Columns[25].Width = 80;
			this.dgvNotas.Columns[26].Name = "TotalAlimentosSinDecs";
			this.dgvNotas.Columns[26].Visible = false;
			this.dgvNotas.Columns[26].Width = 80;
			this.dgvNotas.Columns[27].Name = "TotalBebidasSinDec";
			this.dgvNotas.Columns[27].Visible = false;
			this.dgvNotas.Columns[27].Width = 80;
			this.dgvNotas.Columns[28].Name = "TotalOtrosSinDec";
			this.dgvNotas.Columns[28].Visible = false;
			this.dgvNotas.Columns[28].Width = 80;
			this.dgvNotas.Columns[29].Name = "PrecioSinImpuestos";
			this.dgvNotas.Columns[29].Visible = false;
			this.dgvNotas.Columns[29].Width = 80;
			this.dgvNotas.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.85f, FontStyle.Regular);
			this.dgvNotas.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.85f, FontStyle.Regular);
			dataGridViewCheckBoxColumn.Width = 60;
			dataGridViewCheckBoxColumn.Name = "Eliminar";
			this.dgvNotas.Columns.Add(dataGridViewCheckBoxColumn);
			this.DoubleBufferedASD(this.dgvNotas, true);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x000C354C File Offset: 0x000C174C
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x000C3580 File Offset: 0x000C1780
		private void llenaCombos()
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			this.ComboBoxIdEmpresa.Items.Clear();
			this.txtSerie.Clear();
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader("Select distinct(idempresa) from empresas");
			while (sqlDataReader.Read())
			{
				this.ComboBoxIdEmpresa.Items.Add(sqlDataReader[0].ToString());
			}
			sqlDataReader = (SqlDataReader)sqlQuery.execReader("Select distinct(serie) from folios");
			while (sqlDataReader.Read())
			{
			}
			sqlDataReader.Close();
			this.ComboBoxIdEmpresa.SelectedIndex = 0;
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn("Select distinct (b) from G");
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

		// Token: 0x06000C36 RID: 3126 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtBuscarFolio_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x000C3684 File Offset: 0x000C1884
		private void BtnVolver_Click(object sender, EventArgs e)
		{
			base.Close();
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

		// Token: 0x06000C38 RID: 3128 RVA: 0x000C3784 File Offset: 0x000C1984
		public void MostarReporte()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string text = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
			string text2 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
			string text3 = this.txtSerie.Text;
			string text4 = this.txtBuscarFolio.Text;
			string query = string.Concat(new string[]
			{
				"select idturno from cheques where numcheque='",
				text4.ToString(),
				"' and fecha between '",
				text,
				"' and  '",
				text2,
				"' and seriefolio = '",
				text3,
				"'"
			});
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool flag = sqlDataReader.Read();
			if (flag)
			{
				string text5 = sqlDataReader[0].ToString();
				this.lblidturno_jc.Text = text5;
			}
			query = string.Concat(new string[]
			{
				"Select a.foliodet, a.movimiento , a.cantidad ,a.idproducto, e.descripcion , CONVERT(numeric(10,0),a.descuento) as descuento , convert(numeric(10,2), a.preciosinimpuestos * a.descuento / -100) + (a.preciosinimpuestos) as 'preciosinimpuestos', convert(numeric(10,2), a.precio * a.descuento / -100) + (a.precio) as 'precio' , \r\n                    c.fecha , c.nopersonas , c.descuentoimporte , c.subtotal , c.total , c.propina , c.tarjeta , c.efectivo , c.vales , c.otros ,a.impuesto1 , c.facturado , a.precio as 'Precio Catalogo',\r\n\t\t\t\t\tg.idgrupo , z.clasificacionventa , c.totalalimentos , c.totalbebidas , c.totalotros , c.totalalimentossindescuentos , c.totalbebidassindescuentos , c.totalotrossindescuentos , a.preciosinimpuestos as 'PrecioSinImpuestos' , a.idestacion  , a.idmeseroproducto  , convert(datetime,a.hora) as hora\r\n                    from cheqdet A\r\n                    LEFT JOIN productos E on e.idproducto = a.idproducto\r\n                    LEFT JOIN CHEQUES C on c.folio= a.foliodet\r\n\t\t\t\t\tLEFT JOIN grupos G on g.idgrupo = e.idgrupo\r\n\t\t\t\t\tLEFT JOIN gruposiclasificacion Z on z.clasificacionventa = g.clasificacion\r\n                    where a.foliodet in ( select folio from cheques where numcheque='",
				text4.ToString(),
				"' and fecha between '",
				text,
				"' and  '",
				text2,
				"' and seriefolio = '",
				text3,
				"' ) order by a.movimiento"
			});
			try
			{
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				this.iniciaGridFolio();
				bool flag2 = !sqlDataReader.HasRows;
				if (flag2)
				{
					this.txtPersonas.Text = "0";
					this.TxtFacturado.Text = "N/A";
					this.txtFechadelTicket.Text = "N/A";
					this.txtEfectivo.Text = "$ 0.00";
					this.txtTarjeta.Text = "$ 0.00";
					this.txtvales.Text = "$ 0.00";
					this.txtotros.Text = "$ 0.00";
					this.txtDescuento.Text = "$ 0.00";
					this.txtPropina.Text = "$ 0.00";
					this.txtSubtotal.Text = "$ 0.00";
					this.txtTotal.Text = "$ 0.00";
					this.BtnAgregarProducto.Visible = false;
					this.btnEliminarProducto.Visible = false;
					this.btnCambiarFormadePago.Visible = false;
					Interaction.MsgBox("No existe el ticket en la base de datos o esta fuera del rango de tu licencia , verifica el folio que estas ingresando! ", MsgBoxStyle.Information, this.Text);
					this.BtnAgregarProducto.Visible = false;
				}
				bool hasRows = sqlDataReader.HasRows;
				if (hasRows)
				{
					while (sqlDataReader.Read())
					{
						string text6 = Conversions.ToString(sqlDataReader[0]);
						this.movimiento = Conversions.ToString(sqlDataReader[1]);
						double num = Conversions.ToDouble(sqlDataReader[2]);
						string text7 = Conversions.ToString(sqlDataReader[3]);
						string text8 = Conversions.ToString(sqlDataReader[4]);
						bool flag3 = Operators.ConditionalCompareObjectEqual(sqlDataReader[5], "0", false);
						string str;
						if (flag3)
						{
							str = "0";
						}
						else
						{
							str = Conversions.ToString(sqlDataReader[5]);
						}
						double num2 = Conversions.ToDouble(sqlDataReader[6]);
						double num3 = Conversions.ToDouble(sqlDataReader[7]);
						string text9 = Conversions.ToString(sqlDataReader[8]);
						string text10 = Conversions.ToString(sqlDataReader[9]);
						double num4 = Conversions.ToDouble(sqlDataReader[10]);
						double num5 = Conversions.ToDouble(sqlDataReader[11]);
						double value = Conversions.ToDouble(sqlDataReader[12]);
						double value2 = Conversions.ToDouble(sqlDataReader[13]);
						double value3 = Conversions.ToDouble(sqlDataReader[14]);
						double value4 = Conversions.ToDouble(sqlDataReader[15]);
						double num6 = Conversions.ToDouble(sqlDataReader[15]);
						double value5 = Conversions.ToDouble(sqlDataReader[16]);
						double value6 = Conversions.ToDouble(sqlDataReader[17]);
						string text11 = Conversions.ToString(sqlDataReader[18]);
						double num7 = Conversions.ToDouble((num * num2).ToString());
						double num8 = Conversions.ToDouble((num * num3).ToString());
						bool flag4 = Operators.ConditionalCompareObjectEqual(sqlDataReader[19], 0, false);
						string text12;
						if (flag4)
						{
							text12 = "NO FACTURADO";
						}
						else
						{
							text12 = "FACTURADO";
						}
						double num9 = Conversions.ToDouble(sqlDataReader[20]);
						string text13 = Conversions.ToString(sqlDataReader[21]);
						string text14 = Conversions.ToString(sqlDataReader[22]);
						double num10 = Conversions.ToDouble(sqlDataReader[23]);
						double num11 = Conversions.ToDouble(sqlDataReader[24]);
						double num12 = Conversions.ToDouble(sqlDataReader[25]);
						double num13 = Conversions.ToDouble(sqlDataReader[26]);
						double num14 = Conversions.ToDouble(sqlDataReader[27]);
						double num15 = Conversions.ToDouble(sqlDataReader[28]);
						double num16 = Conversions.ToDouble(sqlDataReader[29]);
						string text15 = Conversions.ToString(sqlDataReader[30]);
						string text16 = Conversions.ToString(sqlDataReader[31]);
						this.lblEfectivoTurno1.Text = num6.ToString("N2");
						this.lblFolioIdentity.Text = text6;
						this.lblEfectivoSumar.Text = Conversions.ToString(value4);
						this.lblTarjetasumar.Text = Conversions.ToString(value3);
						this.lblValesSumar.Text = Conversions.ToString(value5);
						this.lblOtrosSUmar.Text = Conversions.ToString(value6);
						this.lblPropinasSumar.Text = Conversions.ToString(value2);
						this.lbltotalvalidacion.Text = Conversions.ToString(value);
						string text17 = Conversions.ToString(sqlDataReader[32]);
						this.lblIdEstacion.Text = text15;
						this.lblMesero.Text = text16;
						this.lblFechadelProducto.Text = text17;
						this.lblFechadelProducto.Text = Conversions.ToDate(this.lblFechadelProducto.Text).ToString(Tools.strFormatoFechaLargo);
						this.lblidFoliodet.Text = text6;
						this.lblTotalAlimentos.Text = num10.ToString("N2");
						this.lblTotalBebidas.Text = num11.ToString("N2");
						this.lblTotalOtros.Text = num12.ToString("N2");
						this.lblTotalAlimentosDescuento.Text = num13.ToString("N2");
						this.lblTotalBebidasDesc.Text = num14.ToString("N2");
						this.lblTotalOtrosSinDescuento.Text = num15.ToString("N2");
						this.dgvNotas.Rows.Add(new object[]
						{
							text6,
							this.movimiento,
							num,
							text7,
							text8,
							str + "% ",
							"$ " + num7.ToString("N2"),
							"$ " + num8.ToString("N2"),
							text9,
							text10,
							"$ " + num4.ToString("N2"),
							"$ " + num5.ToString("N2"),
							"$ " + value.ToString("N2"),
							"$ " + value2.ToString("N2"),
							"$ " + value3.ToString("N2"),
							"$ " + value4.ToString("N2"),
							"$ " + value5.ToString("N2"),
							"$ " + value6.ToString("N2"),
							text11,
							text12,
							"$ " + num9.ToString("N2"),
							text13,
							text14,
							"$ " + num10.ToString("N2"),
							"$ " + num11.ToString("N2"),
							"$ " + num12.ToString("N2"),
							"$ " + num13.ToString("N2"),
							"$ " + num14.ToString("N2"),
							"$ " + num15.ToString("N2"),
							"$ " + num16.ToString("N2")
						});
						this.txtFechadelTicket.Text = text9;
						this.txtPersonas.Text = text10;
						this.txtDescuento.Text = "$ " + num4.ToString("N2");
						this.txtPropina.Text = "$ " + value2.ToString("N2");
						this.txtSubtotal.Text = "$ " + num5.ToString("N2");
						this.txtTotal.Text = "$ " + value.ToString("N2");
						this.TxtFacturado.Text = text12;
						this.txtEfectivo.Text = "$ " + value4.ToString("N2");
						this.txtTarjeta.Text = "$ " + value3.ToString("N2");
						this.txtvales.Text = "$ " + value5.ToString("N2");
						this.txtotros.Text = "$ " + value6.ToString("N2");
					}
					bool flag5 = Operators.CompareString(this.TxtFacturado.Text, "FACTURADO", false) == 0;
					if (flag5)
					{
						Interaction.MsgBox("Esta ingresando un folio facturado no puedes editarlo , intenta con otro!", MsgBoxStyle.OkOnly, null);
						this.dgvNotas.Enabled = false;
						this.BtnAgregarProducto.Visible = false;
						this.btnEliminarProducto.Visible = false;
						this.btnCambiarFormadePago.Visible = false;
					}
					this.lblContarFilas.Text = Conversions.ToString(this.dgvNotas.RowCount);
					bool flag6 = this.dgvNotas.RowCount > 0;
					if (flag6)
					{
						this.btnCambiarFormadePago.Visible = true;
					}
				}
				sqlDataReader.Close();
			}
			catch (Exception ex)
			{
			}
			query = string.Concat(new string[]
			{
				"select propinafoliomovtocaja from cheques where numcheque = '",
				this.txtBuscarFolio.Text,
				"' and seriefolio = '",
				text3,
				"'"
			});
			sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool hasRows2 = sqlDataReader.HasRows;
			if (hasRows2)
			{
				while (sqlDataReader.Read())
				{
					string text18 = Conversions.ToString(sqlDataReader[0]);
					this.lblFolioPagoPropina.Text = text18.ToString();
				}
				sqlDataReader.Close();
			}
			bool flag7 = Conversions.ToDouble(this.txtDescuento.Text) > 0.0 & Conversions.ToDouble(this.txtSubtotal.Text) > 0.0;
			if (flag7)
			{
				this.BtnAgregarProducto.Visible = true;
			}
			bool flag8 = Conversions.ToDouble(this.txtSubtotal.Text) < 0.0;
			if (flag8)
			{
				this.txtSubtotal.Text = "$ 0.00";
			}
			this.lblContarFilasEliminar.Text = Conversions.ToString(0);
			this.lblTotalDeFilasDGV.Text = Conversions.ToString(this.dgvNotas.RowCount);
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag9 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Precio C/Descuento S/IVA"].Value, 0, false);
					if (flag9)
					{
						dataGridViewRow.DefaultCellStyle.BackColor = Color.LightBlue;
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
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x000C4458 File Offset: 0x000C2658
		private void txtBuscarFolio_Click(object sender, EventArgs e)
		{
			this.txtBuscarFolio.SelectAll();
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x000C4468 File Offset: 0x000C2668
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			this.MostarReporte();
			bool flag = Operators.CompareString(this.TxtFacturado.Text, "FACTURADO", false) == 0;
			if (flag)
			{
				this.dgvNotas.Enabled = false;
				this.btnCambiarFormadePago.Visible = false;
			}
			else
			{
				bool flag2 = Conversions.ToDouble(this.txtTarjeta.Text) != 0.0 & Conversions.ToDouble(this.txtEfectivo.Text) != 0.0;
				if (flag2)
				{
					this.dgvNotas.Enabled = true;
					this.btnEliminarProducto.Visible = false;
				}
				else
				{
					bool flag3 = Conversions.ToDouble(this.txtTarjeta.Text) != 0.0;
					if (flag3)
					{
						this.dgvNotas.Enabled = false;
					}
					else
					{
						bool flag4 = Conversions.ToDouble(this.txtEfectivo.Text) != 0.0;
						if (flag4)
						{
							this.dgvNotas.Enabled = true;
							this.btnEliminarProducto.Visible = false;
						}
						else
						{
							bool flag5 = Conversions.ToDouble(this.txtotros.Text) != 0.0;
							if (flag5)
							{
								this.dgvNotas.Enabled = true;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x000C45C0 File Offset: 0x000C27C0
		private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 30;
			if (flag)
			{
				bool flag2 = this.dgvNotas.RowCount > 0;
				if (flag2)
				{
					bool flag3 = Conversions.ToDouble(this.txtEfectivo.Text) == 0.0 & Conversions.ToDouble(this.txtDescuento.Text) >= 0.0;
					if (flag3)
					{
						bool flag4 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false);
						if (flag4)
						{
							this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value = true;
							this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
							this.btnEliminarProducto.Visible = true;
							TextBox textBox;
							(textBox = this.txtSubtotal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.NegateObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
							(textBox = this.txtDescuento).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.NegateObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
						}
						else
						{
							this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value = false;
							this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
							TextBox textBox;
							(textBox = this.txtSubtotal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
							(textBox = this.txtDescuento).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
						}
						double num = Conversions.ToDouble(this.txtSubtotal.Text);
						double num2 = Conversions.ToDouble(this.txtDescuento.Text);
						this.txtSubtotal.Text = "$ " + num.ToString("N2");
						this.txtDescuento.Text = "$ " + num2.ToString("N2");
					}
					this.lblTotalDeFilasDGV.Text = Conversions.ToString(this.dgvNotas.RowCount);
					this.lblContarFilasEliminar.Text = Conversions.ToString(0);
					bool flag6;
					checked
					{
						int num3;
						try
						{
							foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								bool flag5 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false);
								if (flag5)
								{
									num3++;
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
						this.lblContarFilasEliminar.Text = num3.ToString();
						double num4 = Conversions.ToDouble(num3.ToString());
						double num5 = (double)this.dgvNotas.RowCount;
						flag6 = (num4 == num5);
					}
					if (flag6)
					{
						Interaction.MsgBox("La Cantidad de Productos en el Ticket no puede ser MENOR a 1!", MsgBoxStyle.OkOnly, null);
						Label label;
						(label = this.lblContarFilasEliminar).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - 1.0);
						this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value = false;
						this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
						TextBox textBox;
						(textBox = this.txtSubtotal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
						(textBox = this.txtDescuento).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
						double num6 = Conversions.ToDouble(this.txtSubtotal.Text);
						double num7 = Conversions.ToDouble(this.txtDescuento.Text);
						this.txtSubtotal.Text = "$ " + num6.ToString("N2");
						this.txtDescuento.Text = "$ " + num7.ToString("N2");
					}
					bool flag7 = Conversions.ToDouble(this.txtEfectivo.Text) < 0.0;
					if (flag7)
					{
						Interaction.MsgBox("El Efectivo no puede ser menor a $ 0.00!", MsgBoxStyle.OkOnly, null);
						TextBox textBox;
						(textBox = this.txtSubtotal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
						(textBox = this.txtEfectivo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento C/IVA"].Value)));
						this.txtTotal.Text = Conversions.ToString(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento C/IVA"].Value);
						this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value = false;
						this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
						double num8 = Conversions.ToDouble(this.txtSubtotal.Text);
						double num9 = Conversions.ToDouble(this.txtEfectivo.Text);
						double num10 = Conversions.ToDouble(this.txtTotal.Text);
						this.txtSubtotal.Text = "$ " + num8.ToString("N2");
						this.txtEfectivo.Text = "$ " + num9.ToString("N2");
						this.txtTotal.Text = "$ " + num10.ToString("N2");
					}
				}
				bool flag8 = Conversions.ToDouble(this.txtEfectivo.Text) > 0.0 & Conversions.ToDouble(this.txtTotal.Text) > 0.0;
				if (flag8)
				{
					bool flag9 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false);
					if (flag9)
					{
						this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value = true;
						this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
						this.btnEliminarProducto.Visible = true;
						double num11 = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento C/IVA"].Value);
						double num12 = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value);
						double num13 = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells["PrecioSinImpuestos"].Value);
						TextBox textBox;
						(textBox = this.txtSubtotal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - Conversions.ToDouble(num12.ToString("N2")));
						(textBox = this.txtTotal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - Conversions.ToDouble(num11.ToString("N2")));
						(textBox = this.txtEfectivo).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - Conversions.ToDouble(num11.ToString("N2")));
						double num14 = Conversions.ToDouble(this.txtSubtotal.Text);
						double num15 = Conversions.ToDouble(this.txtTotal.Text);
						double num16 = Conversions.ToDouble(this.txtEfectivo.Text);
						this.txtSubtotal.Text = "$ " + num14.ToString("N2");
						this.txtTotal.Text = "$ " + num15.ToString("N2");
						this.txtEfectivo.Text = "$ " + num16.ToString("N2");
						bool flag10 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["idgrupo_clasificacion"].Value, "2", false);
						if (flag10)
						{
							Label label;
							(label = this.lblTotalAlimentos).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num12.ToString("N2")));
							(label = this.lblTotalAlimentosDescuento).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num13.ToString("N2")));
						}
						else
						{
							bool flag11 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["idgrupo_clasificacion"].Value, "1", false);
							if (flag11)
							{
								Label label;
								(label = this.lblTotalBebidas).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num12.ToString("N2")));
								(label = this.lblTotalBebidasDesc).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num13.ToString("N2")));
							}
							else
							{
								bool flag12 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["idgrupo_clasificacion"].Value, "3", false);
								if (flag12)
								{
									Label label;
									(label = this.lblTotalOtros).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num12.ToString("N2")));
									(label = this.lblTotalOtrosSinDescuento).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num13.ToString("N2")));
								}
							}
						}
					}
					else
					{
						this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value = false;
						this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
						TextBox textBox;
						(textBox = this.txtTotal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento C/IVA"].Value)));
						(textBox = this.txtSubtotal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
						(textBox = this.txtEfectivo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento C/IVA"].Value)));
						bool flag13 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["idgrupo_clasificacion"].Value, "2", false);
						if (flag13)
						{
							Label label;
							(label = this.lblTotalAlimentos).Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
							(label = this.lblTotalAlimentosDescuento).Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["PrecioSinImpuestos"].Value)));
						}
						else
						{
							bool flag14 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["idgrupo_clasificacion"].Value, "1", false);
							if (flag14)
							{
								Label label;
								(label = this.lblTotalBebidas).Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
								(label = this.lblTotalBebidasDesc).Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["PrecioSinImpuestos"].Value)));
							}
							else
							{
								bool flag15 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["idgrupo_clasificacion"].Value, "3", false);
								if (flag15)
								{
									Label label;
									(label = this.lblTotalOtros).Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
									(label = this.lblTotalOtrosSinDescuento).Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["PrecioSinImpuestos"].Value)));
								}
							}
						}
						double num17 = Conversions.ToDouble(this.txtTotal.Text);
						double num18 = Conversions.ToDouble(this.txtSubtotal.Text);
						double num19 = Conversions.ToDouble(this.txtEfectivo.Text);
						this.txtTotal.Text = "$ " + num17.ToString("N2");
						this.txtSubtotal.Text = "$ " + num18.ToString("N2");
						this.txtEfectivo.Text = "$ " + num19.ToString("N2");
					}
					this.lblTotalDeFilasDGV.Text = Conversions.ToString(this.dgvNotas.RowCount);
					bool flag17;
					checked
					{
						int num20;
						try
						{
							foreach (object obj2 in ((IEnumerable)this.dgvNotas.Rows))
							{
								DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
								bool flag16 = Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false);
								if (flag16)
								{
									num20++;
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
						this.lblContarFilasEliminar.Text = num20.ToString();
						double num21 = Conversions.ToDouble(num20.ToString());
						double num22 = (double)this.dgvNotas.RowCount;
						flag17 = (num21 == num22);
					}
					if (flag17)
					{
						Interaction.MsgBox("La Cantidad de Productos en el Ticket no puede ser MENOR a 1!", MsgBoxStyle.OkOnly, null);
						Label label;
						(label = this.lblContarFilasEliminar).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - 1.0);
						this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value = false;
						this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
						TextBox textBox;
						(textBox = this.txtSubtotal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
						(textBox = this.txtEfectivo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento C/IVA"].Value)));
						this.txtTotal.Text = Conversions.ToString(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento C/IVA"].Value);
						double num23 = Conversions.ToDouble(this.txtSubtotal.Text);
						double num24 = Conversions.ToDouble(this.txtEfectivo.Text);
						double num25 = Conversions.ToDouble(this.txtTotal.Text);
						this.txtSubtotal.Text = "$ " + num23.ToString("N2");
						this.txtEfectivo.Text = "$ " + num24.ToString("N2");
						this.txtTotal.Text = "$ " + num25.ToString("N2");
					}
					bool flag18 = Conversions.ToDouble(this.txtEfectivo.Text) < 0.0;
					if (flag18)
					{
						Interaction.MsgBox("El Efectivo no puede ser menor a $ 0.00!", MsgBoxStyle.OkOnly, null);
						TextBox textBox;
						(textBox = this.txtSubtotal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
						(textBox = this.txtEfectivo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento C/IVA"].Value)));
						this.txtTotal.Text = Conversions.ToString(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento C/IVA"].Value);
						this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value = false;
						this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
						double num26 = Conversions.ToDouble(this.txtSubtotal.Text);
						double num27 = Conversions.ToDouble(this.txtEfectivo.Text);
						double num28 = Conversions.ToDouble(this.txtTotal.Text);
						this.txtSubtotal.Text = "$ " + num26.ToString("N2");
						this.txtEfectivo.Text = "$ " + num27.ToString("N2");
						this.txtTotal.Text = "$ " + num28.ToString("N2");
					}
				}
			}
			try
			{
				foreach (object obj3 in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj3;
					bool flag19 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow3.Cells["Precio C/Descuento S/IVA"].Value, 0, false), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Eliminar"].Value, false, false)));
					if (flag19)
					{
						dataGridViewRow3.DefaultCellStyle.BackColor = Color.LightBlue;
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
			this.lblContarFilas.Text = Conversions.ToString(this.dgvNotas.RowCount);
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x000C5B6C File Offset: 0x000C3D6C
		private void btnEliminarProducto_Click(object sender, EventArgs e)
		{
			string text = this.txtSerie.Text;
			object obj = "SE ELIMINARÁN LOS PRODUCTOS SELECCIONADOS, Deseas continuar?";
			object value = 276;
			object obj2 = "ATENCIÓN!!!";
			object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
			bool flag = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
			if (flag)
			{
				this.btnCambiarFormadePago.Visible = false;
				this.btnEliminarProducto.Visible = false;
				SqlQuery sqlQuery = new SqlQuery();
				string query2;
				try
				{
					foreach (object obj3 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj3;
						double num = Conversions.ToDouble(this.txtSubtotal.Text);
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false);
						if (flag2)
						{
							string text2 = Conversions.ToString(dataGridViewRow.Cells["id_nota"].Value);
							string text3 = Conversions.ToString(dataGridViewRow.Cells["Mov."].Value);
							double num2 = Conversions.ToDouble(this.txtSubtotal.Text);
							double num3 = Conversions.ToDouble(this.txtTotal.Text);
							double num4 = Conversions.ToDouble(this.txtTarjeta.Text);
							double num5 = Conversions.ToDouble(this.txtEfectivo.Text);
							double num6 = Conversions.ToDouble(this.txtvales.Text);
							double num7 = Conversions.ToDouble(this.txtotros.Text);
							double num8 = Conversions.ToDouble(this.lblTotalAlimentos.Text);
							double num9 = Conversions.ToDouble(this.lblTotalBebidas.Text);
							double num10 = Conversions.ToDouble(this.lblTotalOtros.Text);
							double num11 = num * 0.16;
							string text4 = this.lblTotalAlimentosDescuento.Text;
							double num12 = Conversions.ToDouble(this.lblTotalBebidasDesc.Text);
							double num13 = Conversions.ToDouble(this.lblTotalOtrosSinDescuento.Text);
							string text5 = this.lblidturno_jc.Text;
							double num14 = Conversions.ToDouble(this.lblEfectivoTurno1.Text);
							SqlQuery sqlQuery2 = new SqlQuery();
							string query = "Select idformadepago from formasdepago where descripcion = 'Efectivo'";
							SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
							bool hasRows = sqlDataReader.HasRows;
							if (hasRows)
							{
								sqlDataReader.Read();
								string text6 = Conversions.ToString(sqlDataReader[0]);
								try
								{
									query2 = string.Concat(new string[]
									{
										"delete from chequespagos where idformadepago ='",
										text6,
										"' and folio in  ( ",
										text2,
										")"
									});
									sqlQuery.execQuery(query2);
								}
								catch (Exception ex)
								{
								}
							}
							sqlDataReader.Close();
							try
							{
								query2 = string.Concat(new string[]
								{
									"Update Turnos set Efectivo = Efectivo - ",
									num14.ToString(),
									"  where idturno = '",
									text5.ToString(),
									"' "
								});
								sqlQuery.execQuery(query2);
							}
							catch (Exception ex2)
							{
							}
							try
							{
								query2 = string.Concat(new string[]
								{
									"delete from cheqdet where foliodet In ( ",
									text2,
									")  And movimiento In ( ",
									text3,
									") "
								});
								sqlQuery.execQuery(query2);
							}
							catch (Exception ex3)
							{
							}
							try
							{
								query2 = string.Concat(new string[]
								{
									"Update cheques Set total = '",
									num3.ToString(),
									"' , subtotal='",
									num2.ToString(),
									"' ,  Tarjeta='",
									num4.ToString(),
									"' ,  Efectivo='",
									num5.ToString(),
									"',  Vales='",
									num6.ToString(),
									"' ,  Otros='",
									num7.ToString(),
									"'   where folio in  ( ",
									text2,
									") and seriefolio = '",
									text,
									"' "
								});
								sqlQuery.execQuery(query2);
							}
							catch (Exception ex4)
							{
							}
							string text7 = this.lblidturno_jc.Text;
							try
							{
								query2 = string.Concat(new string[]
								{
									"Update cheques set totalconpropina = '",
									num3.ToString(),
									"' , TotalConCargo='",
									num3.ToString(),
									"' ,  TotalConPropinaCargo='",
									num3.ToString(),
									"' ,  TotalSinDescuento='",
									num2.ToString(),
									"',  SubtotalConDescuento='",
									num2.ToString(),
									"' ,  totalalimentos='",
									num8.ToString(),
									"' ,  totalbebidas='",
									num9.ToString(),
									"' ,  totalotros='",
									num10.ToString(),
									"' ,  totalimpuesto1='",
									num11.ToString(),
									"' ,  totalimpuestod1='",
									num11.ToString(),
									"'    where folio in  ( ",
									text2,
									") and seriefolio = '",
									text,
									"'"
								});
								sqlQuery.execQuery(query2);
							}
							catch (Exception ex5)
							{
							}
							SqlQuery sqlQuery3 = new SqlQuery();
							string query3 = "Select idformadepago from formasdepago where descripcion = 'Efectivo'";
							SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(query3);
							bool hasRows2 = sqlDataReader2.HasRows;
							if (hasRows2)
							{
								while (sqlDataReader2.Read())
								{
									string text8 = Conversions.ToString(sqlDataReader2[0]);
									try
									{
										query2 = string.Concat(new string[]
										{
											" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
											text2.ToString(),
											"','",
											text8.ToString(),
											"','",
											num5.ToString(),
											"','0','1','','",
											text7.ToString(),
											"','1','1')"
										});
										sqlQuery.execQuery(query2);
									}
									catch (Exception ex6)
									{
									}
								}
							}
							sqlDataReader2.Close();
							try
							{
								query2 = string.Concat(new string[]
								{
									"Update cheques set totalalimentossindescuentos = '",
									text4.ToString(),
									"' , totalbebidassindescuentos = '",
									num12.ToString(),
									"' , totalotrossindescuentos = '",
									num13.ToString(),
									"' where folio in  ( ",
									text2,
									") and seriefolio = '",
									text,
									"'"
								});
								sqlQuery.execQuery(query2);
							}
							catch (Exception ex7)
							{
							}
							try
							{
								query2 = string.Concat(new string[]
								{
									"Update Turnos set Efectivo = Efectivo + ",
									num5.ToString(),
									"  where idturno = '",
									text5.ToString(),
									"' "
								});
								sqlQuery.execQuery(query2);
							}
							catch (Exception ex8)
							{
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
				SqlQuery sqlQuery4 = new SqlQuery();
				SqlQuery sqlQuery5 = new SqlQuery();
				string text9 = this.txtPersonas.Text;
				string text10 = this.lblidFoliodet.Text;
				string text11 = this.lblContarFilas.Text;
				try
				{
					string query4 = string.Concat(new string[]
					{
						"Update cheques Set nopersonas = '",
						text9.ToString(),
						"' , descuentoimporte='",
						this.txtDescuento.Text,
						"'  where folio in  ( ",
						text10.ToString(),
						") and seriefolio = '",
						text,
						"' "
					});
					sqlQuery5.execQuery(query4);
				}
				catch (Exception ex9)
				{
				}
				try
				{
					string query4 = string.Concat(new string[]
					{
						"Update cheques set cambio=0  where folio in  ( ",
						text10.ToString(),
						") and seriefolio = '",
						text,
						"' "
					});
					sqlQuery5.execQuery(query4);
				}
				catch (Exception ex10)
				{
				}
				try
				{
					string query4 = string.Concat(new string[]
					{
						"Update cheques set totalarticulos = '",
						text11.ToString(),
						"' where folio in  ( ",
						text10.ToString(),
						") and seriefolio = '",
						text,
						"' "
					});
					sqlQuery5.execQuery(query4);
				}
				catch (Exception ex11)
				{
				}
				int num15 = 0;
				query2 = "SELECT movimiento,hora,idproducto from cheqdet where foliodet ='" + text10.ToString() + "' order by hora,movimiento asc";
				SqlDataReader sqlDataReader3 = (SqlDataReader)sqlQuery.execReader(query2);
				bool hasRows3 = sqlDataReader3.HasRows;
				checked
				{
					if (hasRows3)
					{
						while (sqlDataReader3.Read())
						{
							int num16 = Conversions.ToInteger(sqlDataReader3[0]);
							DateTime dateTime = Conversions.ToDate(sqlDataReader3[1]);
							string text12 = Conversions.ToString(sqlDataReader3[2]);
							num15++;
							query2 = string.Concat(new string[]
							{
								"  Update cheqdet set movimiento = ",
								num15.ToString(),
								" where foliodet ='",
								text10.ToString(),
								"' and movimiento=",
								num16.ToString(),
								" and hora='",
								dateTime.ToString(Tools.strFormatoFechaLargo),
								"' and idproducto='",
								text12.ToString(),
								"'"
							});
							sqlQuery.execQuery(query2);
						}
					}
					this.MostarReporte();
					this.BtnVolver.Visible = false;
					this.BtnAgregarProducto.Visible = true;
					this.btnEliminarProducto.Visible = false;
				}
			}
			bool flag3 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.No, false);
			if (flag3)
			{
				this.btnEliminarProducto.Visible = false;
				this.MostarReporte();
				this.btnEliminarProducto.Visible = false;
			}
			this.DgvTicketsPeriodo.Rows.Clear();
			this.iniciaGridVerTickets();
			this.MostrarTickets();
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x000036D5 File Offset: 0x000018D5
		private void btnAplicar_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x000C669C File Offset: 0x000C489C
		private void BtnAgregarProducto_Click(object sender, EventArgs e)
		{
			this.PanelBuscarProducto.Visible = true;
			this.BtnVolver.Visible = true;
			this.iniciaGridProductos();
			this.MostrarReporteProductos1();
			this.lblContadorJC.Text = Conversions.ToString(0);
			this.txtBuscarProducto.Text = "";
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x000C66F5 File Offset: 0x000C48F5
		private void PictureBox4_Click(object sender, EventArgs e)
		{
			this.PanelBuscarProducto.Visible = false;
			this.btnEliminarProducto.Visible = false;
			this.MostarReporte();
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x000C671C File Offset: 0x000C491C
		private void iniciaGridProductos()
		{
			this.DoubleBufferedASD(this.dgwProductos, true);
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			this.dgwProductos.Rows.Clear();
			this.dgwProductos.ColumnCount = 30;
			this.dgwProductos.Columns[0].Name = "id_Producto";
			this.dgwProductos.Columns[0].Visible = false;
			this.dgwProductos.Columns[0].ReadOnly = true;
			this.dgwProductos.Columns[1].Name = "Cant.";
			this.dgwProductos.Columns[1].Width = 60;
			this.dgwProductos.Columns[1].ReadOnly = false;
			this.dgwProductos.Columns[2].Name = "Descripcion";
			this.dgwProductos.Columns[2].Width = 250;
			this.dgwProductos.Columns[2].ReadOnly = true;
			this.dgwProductos.Columns[3].Name = "Descuento %";
			this.dgwProductos.Columns[3].Width = 80;
			this.dgwProductos.Columns[3].Visible = true;
			this.dgwProductos.Columns[3].ReadOnly = false;
			this.dgwProductos.Columns[4].Name = "Precio C/Descuento S/IVA";
			this.dgwProductos.Columns[4].Width = 90;
			this.dgwProductos.Columns[4].Visible = false;
			this.dgwProductos.Columns[4].ReadOnly = true;
			this.dgwProductos.Columns[5].Name = "Precio C/Descuento C/IVA";
			this.dgwProductos.Columns[5].Width = 90;
			this.dgwProductos.Columns[5].Visible = false;
			this.dgwProductos.Columns[5].ReadOnly = true;
			this.dgwProductos.Columns[6].Name = "Precio Venta C/IVA";
			this.dgwProductos.Columns[6].Width = 90;
			this.dgwProductos.Columns[6].Visible = true;
			this.dgwProductos.Columns[6].ReadOnly = true;
			this.dgwProductos.Columns[7].Name = "Precio sin mpuestos C/Descuento";
			this.dgwProductos.Columns[7].Width = 90;
			this.dgwProductos.Columns[7].Visible = true;
			this.dgwProductos.Columns[7].ReadOnly = true;
			this.dgwProductos.Columns[8].Name = "Precio con impuestos C/Descuento";
			this.dgwProductos.Columns[8].Visible = true;
			this.dgwProductos.Columns[8].Width = 90;
			this.dgwProductos.Columns[8].ReadOnly = true;
			this.dgwProductos.Columns[9].Name = "ID_Grupo";
			this.dgwProductos.Columns[9].Visible = false;
			this.dgwProductos.Columns[9].Width = 80;
			this.dgwProductos.Columns[10].Name = "Id_grupo_clasificacion";
			this.dgwProductos.Columns[10].Visible = false;
			this.dgwProductos.Columns[10].Width = 80;
			this.dgwProductos.Columns[11].Name = "Preciosinimpuestos";
			this.dgwProductos.Columns[11].Visible = false;
			this.dgwProductos.Columns[11].Width = 80;
			this.dgwProductos.Columns[12].Name = "Total";
			this.dgwProductos.Columns[12].Visible = false;
			this.dgwProductos.Columns[12].Width = 80;
			this.dgwProductos.Columns[13].Name = "Propina";
			this.dgwProductos.Columns[13].Visible = false;
			this.dgwProductos.Columns[13].Width = 80;
			this.dgwProductos.Columns[14].Name = "Tarjeta";
			this.dgwProductos.Columns[14].Visible = false;
			this.dgwProductos.Columns[14].Width = 80;
			this.dgwProductos.Columns[15].Name = "Efectivo";
			this.dgwProductos.Columns[15].Visible = false;
			this.dgwProductos.Columns[15].Width = 80;
			this.dgwProductos.Columns[16].Name = "Vales";
			this.dgwProductos.Columns[16].Visible = false;
			this.dgwProductos.Columns[16].Width = 80;
			this.dgwProductos.Columns[17].Name = "Otros";
			this.dgwProductos.Columns[17].Visible = false;
			this.dgwProductos.Columns[17].Width = 80;
			this.dgwProductos.Columns[18].Name = "Impuesto";
			this.dgwProductos.Columns[18].Visible = false;
			this.dgwProductos.Columns[18].Width = 80;
			this.dgwProductos.Columns[19].Name = "Facturado";
			this.dgwProductos.Columns[19].Visible = false;
			this.dgwProductos.Columns[19].Width = 80;
			this.dgwProductos.Columns[20].Name = "Precio de Venta";
			this.dgwProductos.Columns[20].Visible = false;
			this.dgwProductos.Columns[20].Width = 80;
			this.dgwProductos.Columns[21].Name = "ig_grupo";
			this.dgwProductos.Columns[21].Visible = false;
			this.dgwProductos.Columns[21].Width = 80;
			this.dgwProductos.Columns[22].Name = "idgrupo_clasificacion";
			this.dgwProductos.Columns[22].Visible = false;
			this.dgwProductos.Columns[22].Width = 80;
			this.dgwProductos.Columns[23].Name = "TotalAlimentos";
			this.dgwProductos.Columns[23].Visible = false;
			this.dgwProductos.Columns[23].Width = 80;
			this.dgwProductos.Columns[24].Name = "TotalBebidas";
			this.dgwProductos.Columns[24].Visible = false;
			this.dgwProductos.Columns[24].Width = 80;
			this.dgwProductos.Columns[25].Name = "TotalOtros";
			this.dgwProductos.Columns[25].Visible = false;
			this.dgwProductos.Columns[25].Width = 80;
			this.dgwProductos.Columns[26].Name = "TotalAlimentosSinDecs";
			this.dgwProductos.Columns[26].Visible = false;
			this.dgwProductos.Columns[26].Width = 80;
			this.dgwProductos.Columns[27].Name = "TotalBebidasSinDec";
			this.dgwProductos.Columns[27].Visible = false;
			this.dgwProductos.Columns[27].Width = 80;
			this.dgwProductos.Columns[28].Name = "TotalOtrosSinDec";
			this.dgwProductos.Columns[28].Visible = false;
			this.dgwProductos.Columns[28].Width = 80;
			this.dgwProductos.Columns[29].Name = "PrecioSinImpuestos";
			this.dgwProductos.Columns[29].Visible = false;
			this.dgwProductos.Columns[29].Width = 80;
			dataGridViewCheckBoxColumn.Width = 60;
			dataGridViewCheckBoxColumn.Name = "Agregar";
			this.dgwProductos.Columns.Add(dataGridViewCheckBoxColumn);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x000C715C File Offset: 0x000C535C
		public void MostrarReporteProductos()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string text = this.txtBuscarProducto.Text;
			string text2 = this.txtSerie.Text;
			string query = "SELECT a.idproducto ,a.Descripcion , b.preciosinimpuestos , b.precio , b.precio as 'Precio de Venta' , c.idgrupo , d.clasificacionventa , b.preciosinimpuestos  FROM productos A \r\n\t                Inner Join Productosdetalle B on b.idproducto = a.idproducto\r\n\t\t\t\t\tInner Join grupos c on c.idgrupo = a.idgrupo\r\n\t\t\t\t\tINNER JOIN gruposiclasificacion d on d.clasificacionventa = c.clasificacion\r\n        WHERE a.Descripcion Like '%" + this.txtBuscarProducto.Text + "%'";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			this.iniciaGridProductos();
			this.DoubleBufferedASD(this.dgwProductos, true);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text3 = Conversions.ToString(sqlDataReader[0]);
					string text4 = Conversions.ToString(sqlDataReader[1]);
					double num = Conversions.ToDouble(sqlDataReader[2]);
					double num2 = Conversions.ToDouble(sqlDataReader[3]);
					double num3 = Conversions.ToDouble(sqlDataReader[4]);
					string text5 = Conversions.ToString(sqlDataReader[5]);
					string text6 = Conversions.ToString(sqlDataReader[6]);
					double num4 = Conversions.ToDouble(sqlDataReader[7]);
					this.dgwProductos.Rows.Add(new object[]
					{
						text3,
						"1",
						text4,
						"0",
						"$ " + num.ToString("N2"),
						"$ " + num2.ToString("N2"),
						"$ " + num3.ToString("N2"),
						"0.00",
						"0.00",
						text5,
						text6,
						num4
					});
				}
				sqlDataReader.Close();
			}
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x000C7308 File Offset: 0x000C5508
		public void MostrarReporteProductos1()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string text = this.txtBuscarProducto.Text;
			string text2 = this.txtSerie.Text;
			string query = "SELECT a.idproducto ,a.Descripcion , b.preciosinimpuestos , b.precio , b.precio as 'Precio de Venta' , c.idgrupo , d.clasificacionventa , b.preciosinimpuestos  FROM productos A \r\n\t                Inner Join Productosdetalle B on b.idproducto = a.idproducto\r\n\t\t\t\t\tInner Join grupos c on c.idgrupo = a.idgrupo\r\n\t\t\t\t\tINNER JOIN gruposiclasificacion d on d.clasificacionventa = c.clasificacion";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			this.iniciaGridProductos();
			this.DoubleBufferedASD(this.dgwProductos, true);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text3 = Conversions.ToString(sqlDataReader[0]);
					string text4 = Conversions.ToString(sqlDataReader[1]);
					double num = Conversions.ToDouble(sqlDataReader[2]);
					double num2 = Conversions.ToDouble(sqlDataReader[3]);
					double num3 = Conversions.ToDouble(sqlDataReader[4]);
					string text5 = Conversions.ToString(sqlDataReader[5]);
					string text6 = Conversions.ToString(sqlDataReader[6]);
					double num4 = Conversions.ToDouble(sqlDataReader[7]);
					this.dgwProductos.Rows.Add(new object[]
					{
						text3,
						"1",
						text4,
						"0",
						"$ " + num.ToString("N2"),
						"$ " + num2.ToString("N2"),
						"$ " + num3.ToString("N2"),
						"0.00",
						"0.00",
						text5,
						text6,
						num4
					});
				}
				sqlDataReader.Close();
			}
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x000C749D File Offset: 0x000C569D
		private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
		{
			this.MostrarReporteProductos();
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x000C74A7 File Offset: 0x000C56A7
		private void txtBuscarProducto_Click(object sender, EventArgs e)
		{
			this.txtBuscarProducto.SelectAll();
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x000C74B8 File Offset: 0x000C56B8
		private void dgwProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			bool flag = this.dgwProductos[1, e.RowIndex].Value != null;
			if (flag)
			{
				num = Conversions.ToDouble(this.dgwProductos[1, e.RowIndex].Value);
			}
			bool flag2 = this.dgwProductos[4, e.RowIndex].Value != null;
			if (flag2)
			{
				num2 = Conversions.ToDouble(this.dgwProductos[4, e.RowIndex].Value);
			}
			bool flag3 = this.dgwProductos[3, e.RowIndex].Value != null;
			if (flag3)
			{
				num3 = Conversions.ToDouble(this.dgwProductos[3, e.RowIndex].Value);
			}
			bool flag4 = this.dgwProductos[7, e.RowIndex].Value != null;
			if (flag4)
			{
				double num4 = Conversions.ToDouble(this.dgwProductos[7, e.RowIndex].Value);
			}
			double a = (num * num2 + num * num2 * (-num3 / 100.0)) * Conversions.ToDouble(1.16.ToString("N2"));
			double num5 = Conversions.ToDouble((num * num2 + num * num2 * (-num3 / 100.0)).ToString("N2"));
			this.dgwProductos[7, e.RowIndex].Value = "$ " + num5.ToString("N2");
			double num6 = Conversions.ToDouble(Math.Round(a).ToString("N2"));
			this.dgwProductos[8, e.RowIndex].Value = "$ " + num6.ToString("N2");
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgwProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x000C76CC File Offset: 0x000C58CC
		private void dgwProductos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 30;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["Agregar"].Value, false, false);
				if (flag2)
				{
					this.dgwProductos.Rows[rowIndex].Cells["Agregar"].Value = true;
					this.dgwProductos.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
					Label label;
					(label = this.lblContadorJC).Text = Conversions.ToString(Conversions.ToDouble(label.Text) + 1.0);
					double num = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["Precio sin mpuestos C/Descuento"].Value);
					double num2 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["Precio con impuestos C/Descuento"].Value);
					double num3 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["Preciosinimpuestos"].Value);
					TextBox textBox;
					(textBox = this.txtSubtotal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString("N2")));
					(textBox = this.txtTotal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num2.ToString("N2")));
					(textBox = this.txtEfectivo).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num2.ToString("N2")));
					bool flag3 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["Id_grupo_clasificacion"].Value, "2", false);
					if (flag3)
					{
						(label = this.lblTotalAlimentos).Text = Conversions.ToString(Conversions.ToDouble(label.Text) + Conversions.ToDouble(num.ToString("N2")));
						(label = this.lblTotalAlimentosDescuento).Text = Conversions.ToString(Conversions.ToDouble(label.Text) + Conversions.ToDouble(num3.ToString("N2")));
					}
					else
					{
						bool flag4 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["Id_grupo_clasificacion"].Value, "1", false);
						if (flag4)
						{
							(label = this.lblTotalBebidas).Text = Conversions.ToString(Conversions.ToDouble(label.Text) + Conversions.ToDouble(num.ToString("N2")));
							(label = this.lblTotalBebidasDesc).Text = Conversions.ToString(Conversions.ToDouble(label.Text) + Conversions.ToDouble(num3.ToString("N2")));
						}
						else
						{
							bool flag5 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["id_grupo_clasificacion"].Value, "3", false);
							if (flag5)
							{
								(label = this.lblTotalOtros).Text = Conversions.ToString(Conversions.ToDouble(label.Text) + Conversions.ToDouble(num.ToString("N2")));
								(label = this.lblTotalOtrosSinDescuento).Text = Conversions.ToString(Conversions.ToDouble(label.Text) + Conversions.ToDouble(num3.ToString("N2")));
							}
						}
					}
				}
				else
				{
					this.dgwProductos.Rows[rowIndex].Cells["Agregar"].Value = false;
					this.dgwProductos.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
					Label label;
					(label = this.lblContadorJC).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - 1.0);
					TextBox textBox;
					(textBox = this.txtSubtotal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgwProductos.Rows[rowIndex].Cells["Precio sin mpuestos C/Descuento"].Value));
					(textBox = this.txtTotal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgwProductos.Rows[rowIndex].Cells["Precio con impuestos C/Descuento"].Value));
					(textBox = this.txtEfectivo).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgwProductos.Rows[rowIndex].Cells["Precio con impuestos C/Descuento"].Value));
					double num4 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["Precio sin mpuestos C/Descuento"].Value);
					double num5 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["Preciosinimpuestos"].Value);
					bool flag6 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["Id_grupo_clasificacion"].Value, "1", false);
					if (flag6)
					{
						(label = this.lblTotalBebidas).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num4.ToString("N2")));
						(label = this.lblTotalBebidasDesc).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num5.ToString("N2")));
					}
					else
					{
						bool flag7 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["Id_grupo_clasificacion"].Value, "2", false);
						if (flag7)
						{
							(label = this.lblTotalAlimentos).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num4.ToString("N2")));
							(label = this.lblTotalAlimentosDescuento).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num5.ToString("N2")));
						}
						else
						{
							bool flag8 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["id_grupo_clasificacion"].Value, "3", false);
							if (flag8)
							{
								(label = this.lblTotalOtros).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num4.ToString("N2")));
								(label = this.lblTotalOtrosSinDescuento).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num5.ToString("N2")));
							}
						}
					}
				}
			}
			double num6 = Conversions.ToDouble(this.txtEfectivo.Text);
			double num7 = Conversions.ToDouble(this.txtTotal.Text);
			double num8 = Conversions.ToDouble(this.txtSubtotal.Text);
			this.txtEfectivo.Text = "$ " + num6.ToString("N2");
			this.txtTotal.Text = "$ " + num7.ToString("N2");
			this.txtSubtotal.Text = "$ " + num8.ToString("N2");
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgwProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x000C7EC4 File Offset: 0x000C60C4
		public void MostarReporteConCambios()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string text = this.txtSerie.Text;
			string text2 = this.txtBuscarFolio.Text;
			string query = string.Concat(new string[]
			{
				"Select a.foliodet, a.movimiento , a.cantidad ,a.idproducto, e.descripcion , CONVERT(numeric(10,0),a.descuento) as descuento , convert(numeric(10,2), a.preciosinimpuestos * a.descuento / -100) + (a.preciosinimpuestos) as 'preciosinimpuestos', convert(numeric(10,2), a.precio * a.descuento / -100) + (a.precio) as 'precio' , \r\n                    c.fecha , c.nopersonas , c.descuentoimporte , c.subtotal , c.total , c.propina , c.tarjeta , c.efectivo , c.vales , c.otros ,a.impuesto1 , c.facturado , a.precio as 'Precio Catalogo',\r\n\t\t\t\t\tg.idgrupo , z.idgruposiclasificacion , c.totalalimentos , c.totalbebidas , c.totalotros , c.totalalimentossindescuentos , c.totalbebidassindescuentos , c.totalotrossindescuentos , a.preciosinimpuestos as 'PrecioSinImpuestos' , a.idestacion  , a.idmeseroproducto , convert(datetime,a.hora) as hora\r\n                    from cheqdet A\r\n                    LEFT JOIN productos E on e.idproducto = a.idproducto\r\n                    LEFT JOIN CHEQUES C on c.folio= a.foliodet\r\n\t\t\t\t\tLEFT JOIN grupos G on g.idgrupo = e.idgrupo\r\n\t\t\t\t\tLEFT JOIN gruposiclasificacion Z on z.clasificacionventa = g.clasificacion\r\n                    where a.foliodet in ( select folio from cheques where numcheque='",
				text2,
				"' and seriefolio = '",
				text,
				"' ) order by a.movimiento"
			});
			try
			{
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				this.iniciaGridFolio();
				bool flag = !sqlDataReader.HasRows;
				if (flag)
				{
					Interaction.MsgBox("No existe el ticket en la base de datos , verifica el folio que estas ingresando! ", MsgBoxStyle.Information, this.Text);
					this.txtPersonas.Text = "0";
					this.TxtFacturado.Text = "N/A";
					this.txtFechadelTicket.Text = "N/A";
					this.txtEfectivo.Text = "$ 0.00";
					this.txtTarjeta.Text = "$ 0.00";
					this.txtvales.Text = "$ 0.00";
					this.txtotros.Text = "$ 0.00";
					this.txtDescuento.Text = "$ 0.00";
					this.txtPropina.Text = "$ 0.00";
					this.txtSubtotal.Text = "$ 0.00";
					this.txtTotal.Text = "$ 0.00";
					this.txtSerie.Text = "N/A";
				}
				bool hasRows = sqlDataReader.HasRows;
				if (hasRows)
				{
				}
				while (sqlDataReader.Read())
				{
					string text3 = Conversions.ToString(sqlDataReader[0]);
					this.movimiento = Conversions.ToString(sqlDataReader[1]);
					string text4 = Conversions.ToString(sqlDataReader[2]);
					string text5 = Conversions.ToString(sqlDataReader[3]);
					string text6 = Conversions.ToString(sqlDataReader[4]);
					bool flag2 = Operators.ConditionalCompareObjectEqual(sqlDataReader[5], "0", false);
					string str;
					if (flag2)
					{
						str = "0";
					}
					else
					{
						str = Conversions.ToString(sqlDataReader[5]);
					}
					double num = Conversions.ToDouble(sqlDataReader[6]);
					double num2 = Conversions.ToDouble(sqlDataReader[7]);
					string text7 = Conversions.ToString(sqlDataReader[8]);
					string text8 = Conversions.ToString(sqlDataReader[9]);
					double num3 = Conversions.ToDouble(sqlDataReader[10]);
					double num4 = Conversions.ToDouble(sqlDataReader[11]);
					double num5 = Conversions.ToDouble(sqlDataReader[12]);
					double num6 = Conversions.ToDouble(sqlDataReader[13]);
					double num7 = Conversions.ToDouble(sqlDataReader[14]);
					double num8 = Conversions.ToDouble(sqlDataReader[15]);
					double num9 = Conversions.ToDouble(sqlDataReader[16]);
					double num10 = Conversions.ToDouble(sqlDataReader[17]);
					string text9 = Conversions.ToString(sqlDataReader[18]);
					bool flag3 = Operators.ConditionalCompareObjectEqual(sqlDataReader[19], 0, false);
					string text10;
					if (flag3)
					{
						text10 = "NO FACTURADO";
					}
					else
					{
						text10 = "FACTURADO";
					}
					double num11 = Conversions.ToDouble(sqlDataReader[20]);
					string text11 = Conversions.ToString(sqlDataReader[21]);
					string text12 = Conversions.ToString(sqlDataReader[22]);
					double num12 = Conversions.ToDouble(sqlDataReader[23]);
					double num13 = Conversions.ToDouble(sqlDataReader[24]);
					double num14 = Conversions.ToDouble(sqlDataReader[25]);
					double num15 = Conversions.ToDouble(sqlDataReader[26]);
					double num16 = Conversions.ToDouble(sqlDataReader[27]);
					double num17 = Conversions.ToDouble(sqlDataReader[28]);
					double num18 = Conversions.ToDouble(sqlDataReader[29]);
					string text13 = Conversions.ToString(sqlDataReader[30]);
					string text14 = Conversions.ToString(sqlDataReader[31]);
					string text15 = Conversions.ToString(sqlDataReader[32]);
					this.lblIdEstacion.Text = text13;
					this.lblMesero.Text = text14;
					this.lblFechadelProducto.Text = text15;
					this.lblFechadelProducto.Text = Conversions.ToDate(this.lblFechadelProducto.Text).ToString(Tools.strFormatoFechaLargo);
					this.lblidFoliodet.Text = text3;
					this.lblTotalAlimentos.Text = num12.ToString("N2");
					this.lblTotalBebidas.Text = num13.ToString("N2");
					this.lblTotalOtros.Text = num14.ToString("N2");
					this.lblTotalAlimentosDescuento.Text = num15.ToString("N2");
					this.lblTotalBebidasDesc.Text = num16.ToString("N2");
					this.lblTotalOtrosSinDescuento.Text = num17.ToString("N2");
					this.dgvNotas.Rows.Add(new object[]
					{
						text3,
						this.movimiento,
						text4,
						text5,
						text6,
						str + "% ",
						"$ " + num.ToString("N2"),
						"$ " + num2.ToString("N2"),
						text7,
						text8,
						"$ " + num3.ToString("N2"),
						"$ " + num4.ToString("N2"),
						"$ " + num5.ToString("N2"),
						"$ " + num6.ToString("N2"),
						"$ " + num7.ToString("N2"),
						"$ " + num8.ToString("N2"),
						"$ " + num9.ToString("N2"),
						"$ " + num10.ToString("N2"),
						text9,
						text10,
						"$ " + num11.ToString("N2"),
						text11,
						text12,
						"$ " + num12.ToString("N2"),
						"$ " + num13.ToString("N2"),
						"$ " + num14.ToString("N2"),
						"$ " + num15.ToString("N2"),
						"$ " + num16.ToString("N2"),
						"$ " + num17.ToString("N2"),
						"$ " + num18.ToString("N2")
					});
					this.txtFechadelTicket.Text = text7;
					this.txtPersonas.Text = text8;
					this.txtDescuento.Text = "$ " + num3.ToString("N2");
					this.txtPropina.Text = "$ " + num6.ToString("N2");
					this.txtSubtotal.Text = "$ " + num4.ToString("N2");
					this.txtTotal.Text = "$ " + num5.ToString("N2");
					this.TxtFacturado.Text = text10;
					this.txtEfectivo.Text = "$ " + num8.ToString("N2");
					this.txtTarjeta.Text = "$ " + num7.ToString("N2");
					this.txtvales.Text = "$ " + num9.ToString("N2");
					this.txtotros.Text = "$ " + num10.ToString("N2");
				}
				sqlDataReader.Close();
			}
			catch (Exception ex)
			{
			}
			this.lblContarFilas.Text = Conversions.ToString(this.dgvNotas.RowCount);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x000C8728 File Offset: 0x000C6928
		public void MostarReporte1()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string text = this.txtSerie.Text;
			string text2 = this.txtBuscarFolio.Text;
			string query = string.Concat(new string[]
			{
				"Select a.foliodet, a.movimiento , a.cantidad ,a.idproducto, e.descripcion , CONVERT(numeric(10,0),a.descuento) as descuento , convert(numeric(10,2), a.preciosinimpuestos * a.descuento / -100) + (a.preciosinimpuestos) as 'preciosinimpuestos', convert(numeric(10,2), a.precio * a.descuento / -100) + (a.precio) as 'precio' , \r\n                    c.fecha , c.nopersonas , c.descuentoimporte , c.subtotal , c.total , c.propina , c.tarjeta , c.efectivo , c.vales , c.otros ,a.impuesto1 , c.facturado , a.precio as 'Precio Catalogo',\r\n\t\t\t\t\tg.idgrupo , z.idgruposiclasificacion , c.totalalimentos , c.totalbebidas , c.totalotros , c.totalalimentossindescuentos , c.totalbebidassindescuentos , c.totalotrossindescuentos , a.preciosinimpuestos as 'PrecioSinImpuestos' , a.idestacion  , a.idmeseroproducto  , convert(datetime,a.hora) as hora\r\n                    from cheqdet A\r\n                    LEFT JOIN productos E on e.idproducto = a.idproducto\r\n                    LEFT JOIN CHEQUES C on c.folio= a.foliodet\r\n\t\t\t\t\tLEFT JOIN grupos G on g.idgrupo = e.idgrupo\r\n\t\t\t\t\tLEFT JOIN gruposiclasificacion Z on z.clasificacionventa = g.clasificacion\r\n                    where a.foliodet in ( select folio from cheques where numcheque='",
				text2,
				"' and seriefolio = '",
				text,
				"' ) order by a.movimiento"
			});
			try
			{
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				this.iniciaGridFolio();
				bool flag = !sqlDataReader.HasRows;
				if (flag)
				{
					Interaction.MsgBox("No existe el ticket en la base de datos , verifica el folio que estas ingresando! ", MsgBoxStyle.Information, this.Text);
					this.txtPersonas.Text = "0";
					this.TxtFacturado.Text = "N/A";
					this.txtFechadelTicket.Text = "N/A";
					this.txtEfectivo.Text = "$ 0.00";
					this.txtTarjeta.Text = "$ 0.00";
					this.txtvales.Text = "$ 0.00";
					this.txtotros.Text = "$ 0.00";
					this.txtDescuento.Text = "$ 0.00";
					this.txtPropina.Text = "$ 0.00";
					this.txtSubtotal.Text = "$ 0.00";
					this.txtTotal.Text = "$ 0.00";
					this.txtSerie.Text = "N/A";
				}
				bool hasRows = sqlDataReader.HasRows;
				if (hasRows)
				{
				}
				while (sqlDataReader.Read())
				{
					string text3 = Conversions.ToString(sqlDataReader[0]);
					this.movimiento = Conversions.ToString(sqlDataReader[1]);
					string text4 = Conversions.ToString(sqlDataReader[2]);
					string text5 = Conversions.ToString(sqlDataReader[3]);
					string text6 = Conversions.ToString(sqlDataReader[4]);
					bool flag2 = Operators.ConditionalCompareObjectEqual(sqlDataReader[5], "0", false);
					string str;
					if (flag2)
					{
						str = "0";
					}
					else
					{
						str = Conversions.ToString(sqlDataReader[5]);
					}
					double num = Conversions.ToDouble(sqlDataReader[6]);
					double num2 = Conversions.ToDouble(sqlDataReader[7]);
					string text7 = Conversions.ToString(sqlDataReader[8]);
					string text8 = Conversions.ToString(sqlDataReader[9]);
					double num3 = Conversions.ToDouble(sqlDataReader[10]);
					double num4 = Conversions.ToDouble(sqlDataReader[11]);
					double num5 = Conversions.ToDouble(sqlDataReader[12]);
					double num6 = Conversions.ToDouble(sqlDataReader[13]);
					double num7 = Conversions.ToDouble(sqlDataReader[14]);
					double num8 = Conversions.ToDouble(sqlDataReader[15]);
					double num9 = Conversions.ToDouble(sqlDataReader[16]);
					double num10 = Conversions.ToDouble(sqlDataReader[17]);
					string text9 = Conversions.ToString(sqlDataReader[18]);
					bool flag3 = Operators.ConditionalCompareObjectEqual(sqlDataReader[19], 0, false);
					string text10;
					if (flag3)
					{
						text10 = "NO FACTURADO";
					}
					else
					{
						text10 = "FACTURADO";
					}
					double num11 = Conversions.ToDouble(sqlDataReader[20]);
					string text11 = Conversions.ToString(sqlDataReader[21]);
					string text12 = Conversions.ToString(sqlDataReader[22]);
					double num12 = Conversions.ToDouble(sqlDataReader[23]);
					double num13 = Conversions.ToDouble(sqlDataReader[24]);
					double num14 = Conversions.ToDouble(sqlDataReader[25]);
					double num15 = Conversions.ToDouble(sqlDataReader[26]);
					double num16 = Conversions.ToDouble(sqlDataReader[27]);
					double num17 = Conversions.ToDouble(sqlDataReader[28]);
					double num18 = Conversions.ToDouble(sqlDataReader[29]);
					string text13 = Conversions.ToString(sqlDataReader[30]);
					string text14 = Conversions.ToString(sqlDataReader[31]);
					string text15 = Conversions.ToString(sqlDataReader[32]);
					this.lblIdEstacion.Text = text13;
					this.lblMesero.Text = text14;
					this.lblFechadelProducto.Text = text15;
					this.lblFechadelProducto.Text = Conversions.ToDate(this.lblFechadelProducto.Text).ToString(Tools.strFormatoFechaLargo);
					this.lblidFoliodet.Text = text3;
					this.lblTotalAlimentos.Text = num12.ToString("N2");
					this.lblTotalBebidas.Text = num13.ToString("N2");
					this.lblTotalOtros.Text = num14.ToString("N2");
					this.lblTotalAlimentosDescuento.Text = num15.ToString("N2");
					this.lblTotalBebidasDesc.Text = num16.ToString("N2");
					this.lblTotalOtrosSinDescuento.Text = num17.ToString("N2");
					this.dgvNotas.Rows.Add(new object[]
					{
						text3,
						this.movimiento,
						text4,
						text5,
						text6,
						str + "% ",
						"$ " + num.ToString("N2"),
						"$ " + num2.ToString("N2"),
						text7,
						text8,
						"$ " + num3.ToString("N2"),
						"$ " + num4.ToString("N2"),
						"$ " + num5.ToString("N2"),
						"$ " + num6.ToString("N2"),
						"$ " + num7.ToString("N2"),
						"$ " + num8.ToString("N2"),
						"$ " + num9.ToString("N2"),
						"$ " + num10.ToString("N2"),
						text9,
						text10,
						"$ " + num11.ToString("N2"),
						text11,
						text12,
						"$ " + num12.ToString("N2"),
						"$ " + num13.ToString("N2"),
						"$ " + num14.ToString("N2"),
						"$ " + num15.ToString("N2"),
						"$ " + num16.ToString("N2"),
						"$ " + num17.ToString("N2"),
						"$ " + num18.ToString("N2")
					});
					this.txtFechadelTicket.Text = text7;
					this.txtPersonas.Text = text8;
					this.txtDescuento.Text = "$ " + num3.ToString("N2");
					this.txtPropina.Text = "$ " + num6.ToString("N2");
					this.txtSubtotal.Text = "$ " + num4.ToString("N2");
					this.txtTotal.Text = "$ " + num5.ToString("N2");
					this.TxtFacturado.Text = text10;
					this.txtEfectivo.Text = "$ " + num8.ToString("N2");
					this.txtTarjeta.Text = "$ " + num7.ToString("N2");
					this.txtvales.Text = "$ " + num9.ToString("N2");
					this.txtotros.Text = "$ " + num10.ToString("N2");
				}
				sqlDataReader.Close();
			}
			catch (Exception ex)
			{
			}
			this.lblContarFilas.Text = Conversions.ToString(this.dgvNotas.RowCount);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x000C8F8C File Offset: 0x000C718C
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
				this.cmbAnio.Enabled = true;
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x000C9278 File Offset: 0x000C7478
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
						this.dateHoraFin.Enabled = false;
						this.dateHoraIni.Enabled = false;
						this.dateFechaIni.Enabled = false;
						this.dateFechaFin.Enabled = false;
						this.PictureBox1.Visible = false;
						this.txtBuscarFolio.Enabled = false;
						this.txtPersonas.Enabled = false;
						this.txtFechadelTicket.Enabled = false;
						this.TxtFacturado.Enabled = false;
						this.ComboBox1.Enabled = false;
						this.txtSerie.Enabled = false;
						this.BtnVerTickets.Enabled = false;
						sqlDataReader.Close();
					}
					else
					{
						sqlDataReader.Close();
						this.dateHoraFin.Enabled = false;
						this.dateHoraIni.Enabled = false;
						this.dateFechaIni.Enabled = true;
						this.dateFechaFin.Enabled = true;
						this.PictureBox1.Visible = true;
						this.txtBuscarFolio.Enabled = true;
						this.txtPersonas.Enabled = true;
						this.txtFechadelTicket.Enabled = false;
						this.TxtFacturado.Enabled = false;
						this.ComboBox1.Enabled = true;
						this.txtSerie.Enabled = true;
						this.BtnVerTickets.Enabled = true;
						this.dateFechaIni.MaxDate = new DateTime(2100, 1, 1);
						this.dateFechaFin.MaxDate = new DateTime(2100, 1, 1);
						this.dateFechaIni.MinDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), Conversions.ToInteger(Tools.Gm(this.ComboBox1.Text)), 1);
						this.dateFechaFin.MinDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), Conversions.ToInteger(Tools.Gm(this.ComboBox1.Text)), 1);
						bool flag2 = Operators.CompareString(Tools.Gm(this.ComboBox1.Text), "12", false) == 0;
						if (flag2)
						{
							this.dateFechaIni.MaxDate = new DateTime((int)Math.Round(unchecked(Conversions.ToDouble(this.cmbAnio.Text) + 1.0)), 1, 1);
							this.dateFechaFin.MaxDate = new DateTime((int)Math.Round(unchecked(Conversions.ToDouble(this.cmbAnio.Text) + 1.0)), 1, 1);
						}
						else
						{
							this.dateFechaIni.MaxDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), (int)Math.Round(unchecked(Conversions.ToDouble(Tools.Gm(this.ComboBox1.Text)) + 1.0)), 1);
							this.dateFechaFin.MaxDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), (int)Math.Round(unchecked(Conversions.ToDouble(Tools.Gm(this.ComboBox1.Text)) + 1.0)), 1);
						}
					}
				}
				else
				{
					sqlDataReader.Close();
				}
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000C963C File Offset: 0x000C783C
		private void PictureBox2_Click_1(object sender, EventArgs e)
		{
			int num = 0;
			bool flag = Conversions.ToDouble(this.lblContadorJC.Text) == 0.0;
			if (flag)
			{
				Interaction.MsgBox("Elige al MENOS 1 PRODUCTO para Agregar!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				object obj = "SE CARGARAN LOS PRODUCTOS SELECCIONADOS, Deseas continuar?";
				object value = 276;
				object obj2 = "ATENCIÓN!!!";
				object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
				bool flag2 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
				if (flag2)
				{
					this.btnCambiarFormadePago.Visible = false;
					SqlQuery sqlQuery = new SqlQuery();
					try
					{
						foreach (object obj3 in ((IEnumerable)this.dgwProductos.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj3;
							bool flag3 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Agregar"].Value, true, false);
							if (flag3)
							{
								string text = this.lblidFoliodet.Text;
								string text2 = Conversions.ToString(dataGridViewRow.Cells["Cant."].Value);
								string text3 = Conversions.ToString(dataGridViewRow.Cells["id_Producto"].Value);
								string text4 = Conversions.ToString(dataGridViewRow.Cells["Descuento %"].Value);
								double num2 = Conversions.ToDouble(dataGridViewRow.Cells["Precio C/Descuento C/IVA"].Value);
								double num3 = Conversions.ToDouble(dataGridViewRow.Cells["Precio C/Descuento S/IVA"].Value);
								string text5 = this.lblIdEstacion.Text;
								string text6 = this.lblMesero.Text;
								double num4 = Conversions.ToDouble(dataGridViewRow.Cells["Precio Venta C/IVA"].Value);
								string text7 = this.lblidturno_jc.Text;
								string query = "select Top 1 Movimiento from cheqdet where foliodet='" + text + "' order by movimiento desc";
								SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
								bool flag4 = sqlDataReader.Read();
								if (flag4)
								{
									num = Conversions.ToInteger(Operators.AddObject(sqlDataReader[0], 1));
								}
								query = string.Concat(new string[]
								{
									"insert into cheqdet (\r\nFoliodet,\r\nmovimiento,\r\ncomanda,\r\ncantidad,\r\nidproducto,\r\ndescuento,\r\nprecio,\r\nimpuesto1,\r\nimpuesto2,\r\nimpuesto3,\r\npreciosinimpuestos,\r\ntiempo,\r\nhora,\r\nmodificador,\r\nmitad,\r\ncomentario,\r\nidestacion,\r\nusuariodescuento,\r\ncomentariodescuento,\r\nidtipodescuento,\r\nhoraproduccion,\r\nidproductocompuesto,\r\nproductocompuestoprincipal,\r\npreciocatalogo,\r\nmarcar,\r\nidmeseroproducto,\r\nprioridadproduccion,\r\nestatuspatin,\r\nidcortesia,\r\nnumerotarjeta,\r\nestadomonitor,\r\nllavemovto,\r\nhorameserofinalizado,\r\nmeserofinalizado,\r\nsistema_envio,\r\nidturno_cierre,\r\nprocesado,\r\npromovolumen,\r\niddispositivo,\r\nproductsyncidsr,\r\nsubtotalsrx,\r\ntotalsrx,\r\nidlistaprecio,\r\ntipocambio,\r\nidmovtobillar,\r\nimpuestoimporte3,\r\nestrateca_DiscountCode,\r\nestrateca_DiscountID,\r\nestrateca_DiscountAmount)\r\n\r\n\r\nValues(\r\n'",
									text.ToString(),
									"',\r\n",
									num.ToString(),
									",\r\n'',\r\n'",
									text2.ToString(),
									"',\r\n'",
									text3.ToString(),
									"',\r\n'",
									text4.ToString(),
									"',\r\n'",
									num2.ToString(),
									"',\r\n'16.0',\r\n'0.00',\r\n'0.00',\r\n'",
									num3.ToString(),
									"',\r\n'',\r\n'",
									this.lblFechadelProducto.Text,
									"',\r\n'0',\r\n'0',\r\n'',\r\n'",
									text5.ToString(),
									"',\r\n'',\r\n'',\r\n'',\r\nNULL,\r\n'',\r\n'0',\r\n'",
									num4.ToString(),
									"',\r\n        '0',\r\n'",
									text6.ToString(),
									"',\r\n        NULL,\r\n'0',\r\n        '',\r\n        '',\r\n        '0',\r\n        NULL,\r\nNULL,\r\nNULL,\r\n'1',\r\n'",
									text7.ToString(),
									"',\r\n        '1',\r\n        '0',\r\n        '-1',\r\n        '-1',\r\n        '-1.00000',\r\n        '-1.00000',\r\n        NULL,\r\nNULL,\r\n'0',\r\n        '0.00',\r\n        '',\r\n        '',\r\n        '0.00')"
								});
								sqlQuery.execQuery(query);
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
					SqlQuery sqlQuery2 = new SqlQuery();
					string text8 = this.txtSerie.Text;
					try
					{
						foreach (object obj4 in ((IEnumerable)this.dgwProductos.Rows))
						{
							DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj4;
							bool flag5 = Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells["Agregar"].Value, true, false);
							if (flag5)
							{
								string text = this.lblidFoliodet.Text;
								double num5 = Conversions.ToDouble(this.txtSubtotal.Text);
								double num6 = Conversions.ToDouble(this.txtTotal.Text);
								double num7 = Conversions.ToDouble(this.txtTarjeta.Text);
								double num8 = Conversions.ToDouble(this.txtEfectivo.Text);
								double num9 = Conversions.ToDouble(this.txtvales.Text);
								double num10 = Conversions.ToDouble(this.txtotros.Text);
								double num11 = Conversions.ToDouble(this.lblTotalAlimentos.Text);
								double num12 = Conversions.ToDouble(this.lblTotalBebidas.Text);
								double num13 = Conversions.ToDouble(this.lblTotalOtros.Text);
								double num14 = Conversions.ToDouble(this.txtTotal.Text) - Conversions.ToDouble(this.txtSubtotal.Text);
								string text9 = this.lblTotalAlimentosDescuento.Text;
								double num15 = Conversions.ToDouble(this.lblTotalBebidasDesc.Text);
								double num16 = Conversions.ToDouble(this.lblTotalOtrosSinDescuento.Text);
								string text10 = this.lblidturno_jc.Text;
								double num17 = Conversions.ToDouble(this.lblEfectivoTurno1.Text);
								SqlQuery sqlQuery3 = new SqlQuery();
								string query2 = "Select idformadepago from formasdepago where descripcion = 'Efectivo'";
								SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery2.execReader(query2);
								bool hasRows = sqlDataReader2.HasRows;
								if (hasRows)
								{
									while (sqlDataReader2.Read())
									{
										string text11 = Conversions.ToString(sqlDataReader2[0]);
										try
										{
											string query = string.Concat(new string[]
											{
												"delete from chequespagos where idformadepago ='",
												text11.ToString(),
												"' and folio in  ( ",
												text,
												")"
											});
											sqlQuery2.execQuery(query);
										}
										catch (Exception ex)
										{
										}
									}
								}
								sqlDataReader2.Close();
								try
								{
									string query = string.Concat(new string[]
									{
										"Update Turnos set Efectivo = Efectivo - ",
										num17.ToString(),
										"  where idturno = '",
										text10.ToString(),
										"' "
									});
									sqlQuery2.execQuery(query);
								}
								catch (Exception ex2)
								{
								}
								try
								{
									string query = string.Concat(new string[]
									{
										"Update cheques Set total = '",
										num6.ToString(),
										"' , subtotal='",
										num5.ToString(),
										"' ,  Tarjeta='",
										num7.ToString(),
										"' ,  Efectivo='",
										num8.ToString(),
										"',  Vales='",
										num9.ToString(),
										"' ,  Otros='",
										num10.ToString(),
										"'   where folio in  ( ",
										text,
										") and seriefolio = '",
										text8,
										"' "
									});
									sqlQuery2.execQuery(query);
								}
								catch (Exception ex3)
								{
								}
								try
								{
									string query = string.Concat(new string[]
									{
										"Update cheques set totalconpropina = '",
										num6.ToString(),
										"' , TotalConCargo='",
										num6.ToString(),
										"' ,  TotalConPropinaCargo='",
										num6.ToString(),
										"' ,  TotalSinDescuento='",
										num5.ToString(),
										"',  SubtotalConDescuento='",
										num5.ToString(),
										"' ,  totalalimentos='",
										num11.ToString(),
										"' ,  totalbebidas='",
										num12.ToString(),
										"' ,  totalotros='",
										num13.ToString(),
										"' ,  totalimpuesto1='",
										num14.ToString(),
										"' ,  totalimpuestod1='",
										num14.ToString(),
										"'    where folio in  ( ",
										text,
										") and seriefolio = '",
										text8,
										"' "
									});
									sqlQuery2.execQuery(query);
								}
								catch (Exception ex4)
								{
								}
								SqlQuery sqlQuery4 = new SqlQuery();
								SqlDataReader sqlDataReader3 = (SqlDataReader)sqlQuery4.execReader(query2);
								bool hasRows2 = sqlDataReader3.HasRows;
								if (hasRows2)
								{
									while (sqlDataReader3.Read())
									{
										string text12 = Conversions.ToString(sqlDataReader3[0]);
										try
										{
											string query = string.Concat(new string[]
											{
												" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
												text.ToString(),
												"','",
												text12.ToString(),
												"','",
												num8.ToString(),
												"','0','1','','",
												text10.ToString(),
												"','1','1')"
											});
											sqlQuery2.execQuery(query);
										}
										catch (Exception ex5)
										{
										}
									}
								}
								sqlDataReader3.Close();
								try
								{
									string query = string.Concat(new string[]
									{
										"Update cheques set totalalimentossindescuentos = '",
										text9.ToString(),
										"' , totalbebidassindescuentos = '",
										num15.ToString(),
										"' , totalotrossindescuentos = '",
										num16.ToString(),
										"' where folio in  ( ",
										text,
										") and seriefolio = '",
										text8,
										"' "
									});
									sqlQuery2.execQuery(query);
								}
								catch (Exception ex6)
								{
								}
								try
								{
									string query = string.Concat(new string[]
									{
										"Update Turnos set Efectivo = Efectivo + ",
										num8.ToString(),
										"  where idturno = '",
										text10.ToString(),
										"' "
									});
									sqlQuery2.execQuery(query);
								}
								catch (Exception ex7)
								{
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
					try
					{
						foreach (object obj5 in ((IEnumerable)this.dgwProductos.Rows))
						{
							DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj5;
							bool flag6 = Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells["Agregar"].Value, true, false);
							if (flag6)
							{
							}
							SqlQuery sqlQuery5 = new SqlQuery();
							string text13 = this.txtPersonas.Text;
							string text14 = this.lblidFoliodet.Text;
							string text15 = this.lblContarFilas.Text;
							try
							{
								string query3 = string.Concat(new string[]
								{
									"Update cheques Set nopersonas = '",
									text13.ToString(),
									"' , descuentoimporte='",
									this.txtDescuento.Text,
									"'  where folio in  ( ",
									text14.ToString(),
									") and seriefolio = '",
									text8,
									"' "
								});
								sqlQuery5.execQuery(query3);
							}
							catch (Exception ex8)
							{
							}
							try
							{
								string query3 = string.Concat(new string[]
								{
									"Update cheques set cambio=0  where folio in  ( ",
									text14.ToString(),
									") and seriefolio = '",
									text8,
									"' "
								});
								sqlQuery5.execQuery(query3);
							}
							catch (Exception ex9)
							{
							}
							try
							{
								string query3 = string.Concat(new string[]
								{
									"Update cheques set totalarticulos = '",
									text15.ToString(),
									"' where folio in  ( ",
									text14.ToString(),
									") and seriefolio = '",
									text8,
									"' "
								});
								sqlQuery5.execQuery(query3);
							}
							catch (Exception ex10)
							{
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
					this.MostarReporte();
					this.PanelBuscarProducto.Visible = false;
					this.btnEliminarProducto.Visible = false;
					this.BtnAgregarProducto.Visible = true;
				}
				bool flag7 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.No, false);
				if (flag7)
				{
					this.PanelBuscarProducto.Visible = true;
				}
			}
			this.DgvTicketsPeriodo.Rows.Clear();
			this.iniciaGridVerTickets();
			this.MostrarTickets();
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x000036D5 File Offset: 0x000018D5
		private void btnCambiarFormadePago_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x000CA34C File Offset: 0x000C854C
		private void PictureBox3_Click(object sender, EventArgs e)
		{
			this.PanelFormasdePago.Visible = false;
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x000CA35C File Offset: 0x000C855C
		private void PictureBox5_Click(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = this.lbltotalvalidacion.Text;
			string text2 = this.lbltotalpropinasvalidacion.Text;
			string text3 = this.txtSerie.Text;
			bool flag = Conversion.Val(this.labeltotalformasdepago.Text) < Conversion.Val(text) + Conversion.Val(text2);
			if (flag)
			{
				Interaction.MsgBox("El total de formas de pago no puede ser distinto al total del ticket", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				bool flag2 = Conversion.Val(this.labeltotalformasdepago.Text) > Conversion.Val(text) + Conversion.Val(text2);
				if (flag2)
				{
					Interaction.MsgBox("El total de formas de pago no puede ser distinto al total del ticket", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					string text4;
					try
					{
						text4 = (("delete from chequespagos where folio=" + this.lblFolioIdentity.Text) ?? "");
						sqlQuery.execQuery(text4);
						text4 = string.Concat(new string[]
						{
							"update cheques set efectivo= '0.00' , tarjeta='0.00' , vales='0.00' , otros ='0.00' where folio=",
							this.lblFolioIdentity.Text,
							" and seriefolio = '",
							text3,
							"' "
						});
						sqlQuery.execQuery(text4);
					}
					catch (Exception ex)
					{
					}
					bool flag3 = Conversions.ToDouble(this.txtPagoPropina.Text) == 0.0;
					if (flag3)
					{
						text4 = string.Concat(new string[]
						{
							"Update movtoscaja Set importe = importe - (Select propina from cheques where numcheque ='",
							this.txtBuscarFolio.Text,
							"') where folio=  '",
							this.lblFolioPagoPropina.Text,
							"'"
						});
						sqlQuery.execQuery(text4);
						text4 = string.Concat(new string[]
						{
							"update cheques set propina=0 , propinafoliomovtocaja =0 where numcheque='",
							this.txtBuscarFolio.Text,
							"' and seriefolio = '",
							text3,
							"' "
						});
						sqlQuery.execQuery(text4);
					}
					bool flag4 = Operators.CompareString(this.txtPagoPropina.Text, this.txtPropina.Text, false) != 0;
					if (flag4)
					{
						text4 = string.Concat(new string[]
						{
							"select idturno from cheques where numcheque='",
							this.txtBuscarFolio.Text,
							"' and seriefolio = '",
							text3,
							"' "
						});
						SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
						bool hasRows = sqlDataReader.HasRows;
						if (hasRows)
						{
							while (sqlDataReader.Read())
							{
								string text5 = Conversions.ToString(sqlDataReader[0]);
								this.lblditurnoformadepago.Text = text5;
							}
							sqlDataReader.Close();
						}
						text4 = "select Top (1) propinafoliomovtocaja from cheques where idturno=" + this.lblditurnoformadepago.Text + " and propinafoliomovtocaja > 0";
						sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
						bool hasRows2 = sqlDataReader.HasRows;
						if (hasRows2)
						{
							while (sqlDataReader.Read())
							{
								string text6 = Conversions.ToString(sqlDataReader[0]);
								this.lblfoliopropinasincuenta.Text = text6;
							}
							sqlDataReader.Close();
						}
						bool flag5 = Operators.CompareString(this.lblFolioPagoPropina.Text, "0", false) == 0;
						if (flag5)
						{
							this.lblNuevoFOlioPropina.Text = this.lblfoliopropinasincuenta.Text;
						}
						else
						{
							this.lblNuevoFOlioPropina.Text = this.lblFolioPagoPropina.Text;
						}
						text4 = string.Concat(new string[]
						{
							"Update movtoscaja Set importe = importe - (Select propina from cheques where numcheque ='",
							this.txtBuscarFolio.Text,
							"' and seriefolio = '",
							text3,
							"' ) where folio=  '",
							this.lblNuevoFOlioPropina.Text,
							"'"
						});
						sqlQuery.execQuery(text4);
						text4 = string.Concat(new string[]
						{
							"update cheques set propina=",
							this.txtPagoPropina.Text,
							" , propinafoliomovtocaja='",
							this.lblNuevoFOlioPropina.Text,
							"'  where numcheque='",
							this.txtBuscarFolio.Text,
							"' and seriefolio = '",
							text3,
							"' "
						});
						sqlQuery.execQuery(text4);
						text4 = string.Concat(new string[]
						{
							"Update movtoscaja Set importe = importe + (Select propina from cheques where numcheque ='",
							this.txtBuscarFolio.Text,
							"' and seriefolio = '",
							text3,
							"' ) where folio=  '",
							this.lblNuevoFOlioPropina.Text,
							"'"
						});
						sqlQuery.execQuery(text4);
					}
					SqlQuery sqlQuery2 = new SqlQuery();
					bool flag6 = Conversions.ToDouble(this.txtPagoEfectivo.Text) >= 0.0;
					if (flag6)
					{
						text4 = "SELECT i from H";
						SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag7 = sqlDataReader.Read();
						if (flag7)
						{
							string text7 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							string query = "Select idformadepago , tipo from formasdepago where idformadepago = '" + text7.ToString() + "'";
							SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(query);
							bool hasRows3 = sqlDataReader2.HasRows;
							if (hasRows3)
							{
								while (sqlDataReader2.Read())
								{
									string text8 = Conversions.ToString(sqlDataReader2[0]);
									string text9 = Conversions.ToString(sqlDataReader2[1]);
									this.lblidefectivo.Text = text8;
									string text10 = Conversions.ToString(Conversion.Val(this.txtPagoEfectivo.Text) + Conversion.Val(this.TxtPropinaEnEfectivo.Text));
									this.lblTotalFormapagoconpropina.Text = text10;
									try
									{
										text4 = string.Concat(new string[]
										{
											"Update cheques set efectivo=",
											text10,
											" where folio='",
											this.lblidFoliodet.Text,
											"' and seriefolio = '",
											text3,
											"' "
										});
										sqlQuery.execQuery(text4);
										text4 = string.Concat(new string[]
										{
											" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
											this.lblidFoliodet.Text,
											"','",
											text8.ToString(),
											"','",
											this.txtPagoEfectivo.Text,
											"','",
											this.TxtPropinaEnEfectivo.Text,
											"','1','','",
											this.lblidturno_jc.Text,
											"','1','1')"
										});
										sqlQuery.execQuery(text4);
									}
									catch (Exception ex2)
									{
									}
								}
							}
							sqlDataReader2.Close();
						}
						sqlDataReader.Close();
					}
					bool flag8 = Conversions.ToDouble(this.txtPagoTarjeta.Text) >= 0.0;
					if (flag8)
					{
						text4 = "SELECT j from H";
						SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag9 = sqlDataReader.Read();
						if (flag9)
						{
							string text11 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							string query2 = "Select idformadepago , tipo from formasdepago where idformadepago = '" + text11.ToString() + "'";
							SqlDataReader sqlDataReader3 = (SqlDataReader)sqlQuery.execReader(query2);
							bool hasRows4 = sqlDataReader3.HasRows;
							if (hasRows4)
							{
								while (sqlDataReader3.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader3[0]);
									string text13 = Conversions.ToString(sqlDataReader3[1]);
									string text14 = Conversions.ToString(Conversion.Val(this.txtPagoTarjeta.Text) + Conversion.Val(this.txtPropinaEnTarjeta.Text));
									try
									{
										text4 = string.Concat(new string[]
										{
											"Update cheques set Tarjeta=",
											text14,
											" where folio='",
											this.lblidFoliodet.Text,
											"' and seriefolio = '",
											text3,
											"' "
										});
										sqlQuery.execQuery(text4);
										text4 = string.Concat(new string[]
										{
											" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
											this.lblidFoliodet.Text,
											"','",
											text12.ToString(),
											"','",
											this.txtPagoTarjeta.Text,
											"','",
											this.txtPropinaEnTarjeta.Text,
											"','1','','",
											this.lblidturno_jc.Text,
											"','1','1')"
										});
										sqlQuery.execQuery(text4);
									}
									catch (Exception ex3)
									{
									}
								}
							}
							sqlDataReader3.Close();
						}
						sqlDataReader.Close();
					}
					bool flag10 = Conversions.ToDouble(this.txtPagoVales.Text) >= 0.0;
					if (flag10)
					{
						text4 = "SELECT k from H";
						SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag11 = sqlDataReader.Read();
						if (flag11)
						{
							string text15 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							string query3 = "Select idformadepago , tipo from formasdepago where idformadepago = '" + text15.ToString() + "'";
							SqlDataReader sqlDataReader4 = (SqlDataReader)sqlQuery.execReader(query3);
							bool hasRows5 = sqlDataReader4.HasRows;
							if (hasRows5)
							{
								while (sqlDataReader4.Read())
								{
									string text16 = Conversions.ToString(sqlDataReader4[0]);
									string text17 = Conversions.ToString(sqlDataReader4[1]);
									string text18 = Conversions.ToString(Conversion.Val(this.txtPagoVales.Text) + Conversion.Val(this.txtPropinaEnVales.Text));
									try
									{
										text4 = string.Concat(new string[]
										{
											"Update cheques set Vales=",
											text18,
											" where folio='",
											this.lblidFoliodet.Text,
											"' and seriefolio = '",
											text3,
											"' "
										});
										sqlQuery.execQuery(text4);
										text4 = string.Concat(new string[]
										{
											" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
											this.lblidFoliodet.Text,
											"','",
											text16.ToString(),
											"','",
											this.txtPagoVales.Text,
											"','",
											this.txtPropinaEnVales.Text,
											"','1','','",
											this.lblidturno_jc.Text,
											"','1','1')"
										});
										sqlQuery.execQuery(text4);
									}
									catch (Exception ex4)
									{
									}
								}
							}
							sqlDataReader4.Close();
						}
						sqlDataReader.Close();
					}
					bool flag12 = Conversions.ToDouble(this.txtPagoOtros.Text) >= 0.0;
					if (flag12)
					{
						text4 = "SELECT l from H";
						SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag13 = sqlDataReader.Read();
						if (flag13)
						{
							string text19 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							string query4 = "Select idformadepago , tipo from formasdepago where idformadepago = '" + text19.ToString() + "'";
							SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(query4);
							bool hasRows6 = sqlDataReader5.HasRows;
							if (hasRows6)
							{
								while (sqlDataReader5.Read())
								{
									string text20 = Conversions.ToString(sqlDataReader5[0]);
									string text21 = Conversions.ToString(sqlDataReader5[1]);
									string text22 = Conversions.ToString(Conversion.Val(this.txtPagoOtros.Text) + Conversion.Val(this.TxtPropinaEnOtros.Text));
									try
									{
										text4 = string.Concat(new string[]
										{
											"Update cheques set Otros=",
											text22,
											" where folio='",
											this.lblidFoliodet.Text,
											"' and seriefolio = '",
											text3,
											"' "
										});
										sqlQuery.execQuery(text4);
										text4 = string.Concat(new string[]
										{
											" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
											this.lblidFoliodet.Text,
											"','",
											text20.ToString(),
											"','",
											this.txtPagoOtros.Text,
											"','",
											this.TxtPropinaEnOtros.Text,
											"','1','','",
											this.lblidturno_jc.Text,
											"','1','1')"
										});
										sqlQuery.execQuery(text4);
									}
									catch (Exception ex5)
									{
									}
								}
							}
							sqlDataReader5.Close();
						}
						sqlDataReader.Close();
					}
					text4 = string.Concat(new string[]
					{
						"Update cheques set propinafoliomovtocaja=0 where propina=0 and folio = '",
						this.lblidFoliodet.Text,
						"' and seriefolio = '",
						text3,
						"'  "
					});
					sqlQuery.execQuery(text4);
					this.MostarReporte();
					this.PanelFormasdePago.Visible = false;
					text4 = "delete from chequespagos where importe=0 and folio='" + this.lblidFoliodet.Text + "'";
					sqlQuery.execQuery(text4);
				}
			}
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x000CB070 File Offset: 0x000C9270
		public void Sumartextbox()
		{
			string text = this.txtPagoEfectivo.Text;
			string text2 = this.txtPagoTarjeta.Text;
			string text3 = this.txtPagoVales.Text;
			string text4 = this.txtPagoOtros.Text;
			string text5 = this.txtPagoPropina.Text;
			this.lbltotalpropinasvalidacion.Text = text5;
			double value = Conversion.Val(text) + Conversion.Val(text2) + Conversion.Val(text3) + Conversions.ToDouble(Conversion.Val(text4).ToString()) + Conversions.ToDouble(Conversion.Val(text5).ToString());
			this.labeltotalformasdepago.Text = Conversions.ToString(value);
			this.txtFormasPago.Text = "$ " + value.ToString("N2");
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x000CB140 File Offset: 0x000C9340
		private void txtPagoEfectivo_TextChanged(object sender, EventArgs e)
		{
			this.Sumartextbox();
			bool flag = Operators.CompareString(this.txtPagoEfectivo.Text, "", false) == 0;
			if (flag)
			{
				this.txtPagoEfectivo.Text = Conversions.ToString(0);
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x000CB188 File Offset: 0x000C9388
		private void txtPagoTarjeta_TextChanged(object sender, EventArgs e)
		{
			this.Sumartextbox();
			bool flag = Operators.CompareString(this.txtPagoTarjeta.Text, "", false) == 0;
			if (flag)
			{
				this.txtPagoTarjeta.Text = Conversions.ToString(0);
			}
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x000CB1D0 File Offset: 0x000C93D0
		private void txtPagoVales_TextChanged(object sender, EventArgs e)
		{
			this.Sumartextbox();
			bool flag = Operators.CompareString(this.txtPagoVales.Text, "", false) == 0;
			if (flag)
			{
				this.txtPagoVales.Text = Conversions.ToString(0);
			}
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x000CB218 File Offset: 0x000C9418
		private void txtPagoOtros_TextChanged(object sender, EventArgs e)
		{
			this.Sumartextbox();
			bool flag = Operators.CompareString(this.txtPagoOtros.Text, "", false) == 0;
			if (flag)
			{
				this.txtPagoOtros.Text = Conversions.ToString(0);
			}
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x000CB25E File Offset: 0x000C945E
		private void txtPagoEfectivo_Click(object sender, EventArgs e)
		{
			this.txtPagoEfectivo.SelectAll();
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x000CB26D File Offset: 0x000C946D
		private void txtPagoTarjeta_Click(object sender, EventArgs e)
		{
			this.txtPagoTarjeta.SelectAll();
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x000CB27C File Offset: 0x000C947C
		private void txtPagoVales_Click(object sender, EventArgs e)
		{
			this.txtPagoVales.SelectAll();
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000CB28B File Offset: 0x000C948B
		private void txtPagoOtros_Click(object sender, EventArgs e)
		{
			this.txtPagoOtros.SelectAll();
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x000CB29A File Offset: 0x000C949A
		private void txtPagoPropina_TextChanged(object sender, EventArgs e)
		{
			this.Sumartextbox();
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x000CB2A4 File Offset: 0x000C94A4
		private void txtPagoPropina_Click(object sender, EventArgs e)
		{
			this.txtPagoPropina.SelectAll();
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x000CB2B4 File Offset: 0x000C94B4
		public void MostrarPropinasTxt()
		{
			this.TxtPropinaEnEfectivo.Text = Conversions.ToString(0);
			this.TxtPropinaEnOtros.Text = Conversions.ToString(0);
			this.txtPropinaEnVales.Text = Conversions.ToString(0);
			this.txtPropinaEnTarjeta.Text = Conversions.ToString(0);
			SqlQuery sqlQuery = new SqlQuery();
			string query = " select a.idformadepago , a.propina , b.tipo from chequespagos A\r\n                    Inner join formasdepago b on b.idformadepago = a.idformadepago where a.folio = '" + this.lblFolioIdentity.Text + "'";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text = Conversions.ToString(sqlDataReader[0]);
					double value = Conversions.ToDouble(sqlDataReader[1]);
					string value2 = Conversions.ToString(sqlDataReader[2]);
					bool flag = Conversions.ToDouble(value2) == 1.0;
					if (flag)
					{
						this.TxtPropinaEnEfectivo.Text = Conversions.ToString(value);
					}
					else
					{
						bool flag2 = Conversions.ToDouble(value2) == 2.0;
						if (flag2)
						{
							this.txtPropinaEnTarjeta.Text = Conversions.ToString(value);
						}
						else
						{
							bool flag3 = Conversions.ToDouble(value2) == 3.0;
							if (flag3)
							{
								this.txtPropinaEnVales.Text = Conversions.ToString(value);
							}
							else
							{
								bool flag4 = Conversions.ToDouble(value2) == 4.0;
								if (flag4)
								{
									this.TxtPropinaEnOtros.Text = Conversions.ToString(value);
								}
							}
						}
					}
				}
				sqlDataReader.Close();
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x000CB444 File Offset: 0x000C9644
		public void Sumartextboxpropinas()
		{
			string text = this.TxtPropinaEnEfectivo.Text;
			string text2 = this.txtPropinaEnTarjeta.Text;
			string text3 = this.txtPropinaEnVales.Text;
			string text4 = this.TxtPropinaEnOtros.Text;
			double value = Conversion.Val(text) + Conversion.Val(text2) + Conversion.Val(text4) + Conversions.ToDouble(Conversion.Val(text3).ToString());
			this.txtPagoPropina.Text = Conversions.ToString(value);
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x000CB4C0 File Offset: 0x000C96C0
		private void TxtPropinaEnEfectivo_TextChanged(object sender, EventArgs e)
		{
			this.Sumartextboxpropinas();
			bool flag = Operators.CompareString(this.TxtPropinaEnEfectivo.Text, "", false) == 0;
			if (flag)
			{
				this.TxtPropinaEnEfectivo.Text = Conversions.ToString(0);
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x000CB508 File Offset: 0x000C9708
		private void txtPropinaEnTarjeta_TextChanged(object sender, EventArgs e)
		{
			this.Sumartextboxpropinas();
			bool flag = Operators.CompareString(this.txtPropinaEnTarjeta.Text, "", false) == 0;
			if (flag)
			{
				this.txtPropinaEnTarjeta.Text = Conversions.ToString(0);
			}
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x000CB550 File Offset: 0x000C9750
		private void txtPropinaEnVales_TextChanged(object sender, EventArgs e)
		{
			this.Sumartextboxpropinas();
			bool flag = Operators.CompareString(this.txtPropinaEnVales.Text, "", false) == 0;
			if (flag)
			{
				this.txtPropinaEnVales.Text = Conversions.ToString(0);
			}
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x000CB598 File Offset: 0x000C9798
		private void TxtPropinaEnOtros_TextChanged(object sender, EventArgs e)
		{
			this.Sumartextboxpropinas();
			bool flag = Operators.CompareString(this.TxtPropinaEnOtros.Text, "", false) == 0;
			if (flag)
			{
				this.TxtPropinaEnOtros.Text = Conversions.ToString(0);
			}
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x000CB5DE File Offset: 0x000C97DE
		private void TxtPropinaEnEfectivo_Click(object sender, EventArgs e)
		{
			this.TxtPropinaEnEfectivo.SelectAll();
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000CB5ED File Offset: 0x000C97ED
		private void txtPropinaEnTarjeta_Click(object sender, EventArgs e)
		{
			this.txtPropinaEnTarjeta.SelectAll();
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x000CB5FC File Offset: 0x000C97FC
		private void txtPropinaEnVales_Click(object sender, EventArgs e)
		{
			this.txtPropinaEnVales.SelectAll();
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x000CB60B File Offset: 0x000C980B
		private void TxtPropinaEnOtros_Click(object sender, EventArgs e)
		{
			this.TxtPropinaEnOtros.SelectAll();
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x000CB61A File Offset: 0x000C981A
		private void PictureBox6_Click(object sender, EventArgs e)
		{
			this.DgvTicketsPeriodo.Rows.Clear();
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x000CB62E File Offset: 0x000C982E
		private void BtnVerTickets_Click(object sender, EventArgs e)
		{
			this.DgvTicketsPeriodo.Rows.Clear();
			this.iniciaGridVerTickets();
			this.MostrarTickets();
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x000CB650 File Offset: 0x000C9850
		private void iniciaGridVerTickets()
		{
			this.DoubleBufferedASD(this.DgvTicketsPeriodo, true);
			this.dgwProductos.Rows.Clear();
			this.DgvTicketsPeriodo.ColumnCount = 11;
			this.DgvTicketsPeriodo.Columns[0].Name = "id_Folio";
			this.DgvTicketsPeriodo.Columns[0].Visible = false;
			this.DgvTicketsPeriodo.Columns[0].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[1].Name = "Serie";
			this.DgvTicketsPeriodo.Columns[1].Width = 37;
			this.DgvTicketsPeriodo.Columns[1].ReadOnly = false;
			this.DgvTicketsPeriodo.Columns[2].Name = "Folio";
			this.DgvTicketsPeriodo.Columns[2].Width = 50;
			this.DgvTicketsPeriodo.Columns[2].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[3].Name = "Descuento %";
			this.DgvTicketsPeriodo.Columns[3].Width = 40;
			this.DgvTicketsPeriodo.Columns[3].Visible = false;
			this.DgvTicketsPeriodo.Columns[3].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[4].Name = "Facturado";
			this.DgvTicketsPeriodo.Columns[4].Width = 60;
			this.DgvTicketsPeriodo.Columns[4].Visible = true;
			this.DgvTicketsPeriodo.Columns[4].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[5].Name = "Total";
			this.DgvTicketsPeriodo.Columns[5].Width = 60;
			this.DgvTicketsPeriodo.Columns[5].Visible = true;
			this.DgvTicketsPeriodo.Columns[5].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[6].Name = "Efectivo";
			this.DgvTicketsPeriodo.Columns[6].Width = 60;
			this.DgvTicketsPeriodo.Columns[6].Visible = true;
			this.DgvTicketsPeriodo.Columns[6].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[7].Name = "Tarjeta";
			this.DgvTicketsPeriodo.Columns[7].Width = 60;
			this.DgvTicketsPeriodo.Columns[7].Visible = true;
			this.DgvTicketsPeriodo.Columns[7].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[8].Name = "Vales";
			this.DgvTicketsPeriodo.Columns[8].Width = 60;
			this.DgvTicketsPeriodo.Columns[8].Visible = true;
			this.DgvTicketsPeriodo.Columns[8].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[9].Name = "Otros";
			this.DgvTicketsPeriodo.Columns[9].Visible = true;
			this.DgvTicketsPeriodo.Columns[9].Width = 60;
			this.DgvTicketsPeriodo.Columns[9].ReadOnly = true;
			this.DgvTicketsPeriodo.Columns[10].Name = "Propina";
			this.DgvTicketsPeriodo.Columns[10].Visible = true;
			this.DgvTicketsPeriodo.Columns[10].Width = 60;
			this.DgvTicketsPeriodo.Columns[10].Visible = false;
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x000CBAA4 File Offset: 0x000C9CA4
		public void MostrarTickets()
		{
			string text = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
			string text2 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
			SqlQuery sqlQuery = new SqlQuery();
			string query = string.Concat(new string[]
			{
				" SELECT folio,Seriefolio,Numcheque,Facturado,descuento,Total,Efectivo,Tarjeta,Vales,Otros,propina from cheques\r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
				text,
				"' AND '",
				text2,
				"' AND \r\n                    cierre is not null and idempresa='",
				Tools.id_Empresa,
				"')\r\n                    and idempresa='",
				Tools.id_Empresa,
				"' order by folio"
			});
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			this.iniciaGridVerTickets();
			this.DoubleBufferedASD(this.DgvTicketsPeriodo, true);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				this.ComboBox1.Enabled = false;
				while (sqlDataReader.Read())
				{
					string text3 = Conversions.ToString(sqlDataReader[0]);
					string text4 = Conversions.ToString(sqlDataReader[1]);
					string text5 = Conversions.ToString(sqlDataReader[2]);
					bool flag = Operators.ConditionalCompareObjectEqual(sqlDataReader[3], true, false);
					string text6;
					if (flag)
					{
						text6 = "Si";
					}
					else
					{
						text6 = "No";
					}
					double num = Conversions.ToDouble(sqlDataReader[4]);
					double num2 = Conversions.ToDouble(sqlDataReader[5]);
					double num3 = Conversions.ToDouble(sqlDataReader[6]);
					double num4 = Conversions.ToDouble(sqlDataReader[7]);
					double num5 = Conversions.ToDouble(sqlDataReader[8]);
					double num6 = Conversions.ToDouble(sqlDataReader[9]);
					double num7 = Conversions.ToDouble(sqlDataReader[10]);
					this.DgvTicketsPeriodo.Rows.Add(new object[]
					{
						text3,
						text4,
						text5,
						num,
						text6,
						num2.ToString("N2"),
						num3.ToString("N2"),
						num4.ToString("N2"),
						num5.ToString("N2"),
						num6.ToString("N2"),
						num7.ToString("N2")
					});
				}
				sqlDataReader.Close();
			}
			try
			{
				foreach (object obj in ((IEnumerable)this.DgvTicketsPeriodo.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag2 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectGreater(dataGridViewRow.Cells["Efectivo"].Value, 0, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Facturado"].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)));
					if (flag2)
					{
						dataGridViewRow.DefaultCellStyle.BackColor = Color.Green;
						dataGridViewRow.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold);
						dataGridViewRow.DefaultCellStyle.ForeColor = Color.White;
					}
					bool flag3 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectGreater(dataGridViewRow.Cells["Efectivo"].Value, 0, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Facturado"].Value, "No", false)), Operators.CompareObjectGreater(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)));
					if (flag3)
					{
						dataGridViewRow.DefaultCellStyle.BackColor = Color.Black;
						dataGridViewRow.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold);
						dataGridViewRow.DefaultCellStyle.ForeColor = Color.White;
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
			this.DgvTicketsPeriodo.ClearSelection();
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x000036D5 File Offset: 0x000018D5
		private void DgvTicketsPeriodo_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x000CBFA4 File Offset: 0x000CA1A4
		private void DgvTicketsPeriodo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			try
			{
				this.txtSerie.Text = Conversions.ToString(this.DgvTicketsPeriodo.Rows[rowIndex].Cells["Serie"].Value);
				this.txtBuscarFolio.Text = Conversions.ToString(this.DgvTicketsPeriodo.Rows[rowIndex].Cells["Folio"].Value);
			}
			catch (Exception ex)
			{
			}
			this.MostarReporte();
			bool flag = Operators.CompareString(this.TxtFacturado.Text, "FACTURADO", false) == 0;
			if (flag)
			{
				this.dgvNotas.Enabled = false;
				this.btnCambiarFormadePago.Visible = false;
			}
			else
			{
				bool flag2 = Conversions.ToDouble(this.txtTarjeta.Text) != 0.0 & Conversions.ToDouble(this.txtEfectivo.Text) != 0.0;
				if (flag2)
				{
					this.dgvNotas.Enabled = true;
					this.btnEliminarProducto.Visible = false;
				}
				else
				{
					bool flag3 = Conversions.ToDouble(this.txtTarjeta.Text) != 0.0;
					if (flag3)
					{
						this.dgvNotas.Enabled = false;
					}
					else
					{
						bool flag4 = Conversions.ToDouble(this.txtEfectivo.Text) != 0.0;
						if (flag4)
						{
							this.dgvNotas.Enabled = true;
							this.btnEliminarProducto.Visible = false;
						}
						else
						{
							bool flag5 = Conversions.ToDouble(this.txtotros.Text) != 0.0;
							if (flag5)
							{
								this.dgvNotas.Enabled = false;
							}
						}
					}
				}
			}
			this.DgvTicketsPeriodo.ClearSelection();
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x000CC1A0 File Offset: 0x000CA3A0
		private void Button1_Click(object sender, EventArgs e)
		{
			this.PanelFormasdePago.Visible = true;
			this.txtPagoEfectivo.Text = this.lblEfectivoSumar.Text;
			this.txtPagoOtros.Text = this.lblOtrosSUmar.Text;
			this.txtPagoVales.Text = this.lblValesSumar.Text;
			this.txtPagoTarjeta.Text = this.lblTarjetasumar.Text;
			this.txtPagoPropina.Text = this.lblPropinasSumar.Text;
			double num = Conversions.ToDouble(this.txtPagoEfectivo.Text);
			double num2 = Conversions.ToDouble(this.txtPagoTarjeta.Text);
			double num3 = Conversions.ToDouble(this.txtPagoVales.Text);
			double num4 = Conversions.ToDouble(this.txtPagoOtros.Text);
			double num5 = Conversions.ToDouble(this.txtPagoPropina.Text);
			this.lbltotalpropinasvalidacion.Text = Conversions.ToString(num5);
			this.txtTotaldelTicket.Text = this.txtTotal.Text;
			this.txtFormasPago.Text = "$ " + (num + num2 + num3 + num4 + num5).ToString("N2");
			this.MostrarPropinasTxt();
			this.txtPagoEfectivo.Text = Conversions.ToString(Conversion.Val(this.txtPagoEfectivo.Text) - Conversion.Val(this.TxtPropinaEnEfectivo.Text));
			this.txtPagoTarjeta.Text = Conversions.ToString(Conversion.Val(this.txtPagoTarjeta.Text) - Conversion.Val(this.txtPropinaEnTarjeta.Text));
			this.txtPagoVales.Text = Conversions.ToString(Conversion.Val(this.txtPagoVales.Text) - Conversion.Val(this.txtPropinaEnVales.Text));
			this.txtPagoOtros.Text = Conversions.ToString(Conversion.Val(this.txtPagoOtros.Text) - Conversion.Val(this.TxtPropinaEnOtros.Text));
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x040005AA RID: 1450
		private object iFolioInicial;

		// Token: 0x040005AB RID: 1451
		private object iNumChequeInicial;

		// Token: 0x040005AC RID: 1452
		private string movimiento;
	}
}
