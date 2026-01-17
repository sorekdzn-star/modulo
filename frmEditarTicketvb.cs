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
	// Token: 0x02000010 RID: 16
	[DesignerGenerated]
	public partial class frmEditarTicketvb : Form
	{
		// Token: 0x0600031B RID: 795 RVA: 0x0001FF90 File Offset: 0x0001E190
		public frmEditarTicketvb()
		{
			base.Load += this.frmEditarTicketvb_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600031E RID: 798 RVA: 0x000240F1 File Offset: 0x000222F1
		// (set) Token: 0x0600031F RID: 799 RVA: 0x000240FC File Offset: 0x000222FC
		internal virtual Panel PanelInformacion
		{
			[CompilerGenerated]
			get
			{
				return this._PanelInformacion;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.PanelInformacion_Paint);
				Panel panelInformacion = this._PanelInformacion;
				if (panelInformacion != null)
				{
					panelInformacion.Paint -= value2;
				}
				this._PanelInformacion = value;
				panelInformacion = this._PanelInformacion;
				if (panelInformacion != null)
				{
					panelInformacion.Paint += value2;
				}
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0002413F File Offset: 0x0002233F
		// (set) Token: 0x06000321 RID: 801 RVA: 0x0002414C File Offset: 0x0002234C
		internal virtual Label lblFolio
		{
			[CompilerGenerated]
			get
			{
				return this._lblFolio;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lblFolio_Click);
				Label lblFolio = this._lblFolio;
				if (lblFolio != null)
				{
					lblFolio.Click -= value2;
				}
				this._lblFolio = value;
				lblFolio = this._lblFolio;
				if (lblFolio != null)
				{
					lblFolio.Click += value2;
				}
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0002418F File Offset: 0x0002238F
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00024199 File Offset: 0x00022399
		internal virtual TextBox txtFechadelTicket { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000324 RID: 804 RVA: 0x000241A2 File Offset: 0x000223A2
		// (set) Token: 0x06000325 RID: 805 RVA: 0x000241AC File Offset: 0x000223AC
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000326 RID: 806 RVA: 0x000241B5 File Offset: 0x000223B5
		// (set) Token: 0x06000327 RID: 807 RVA: 0x000241BF File Offset: 0x000223BF
		internal virtual Label lblSerie { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000328 RID: 808 RVA: 0x000241C8 File Offset: 0x000223C8
		// (set) Token: 0x06000329 RID: 809 RVA: 0x000241D2 File Offset: 0x000223D2
		internal virtual TextBox txtSerie { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600032A RID: 810 RVA: 0x000241DB File Offset: 0x000223DB
		// (set) Token: 0x0600032B RID: 811 RVA: 0x000241E5 File Offset: 0x000223E5
		internal virtual Label lblEmpresa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600032C RID: 812 RVA: 0x000241EE File Offset: 0x000223EE
		// (set) Token: 0x0600032D RID: 813 RVA: 0x000241F8 File Offset: 0x000223F8
		internal virtual ComboBox ComboBoxIdEmpresa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00024201 File Offset: 0x00022401
		// (set) Token: 0x0600032F RID: 815 RVA: 0x0002420B File Offset: 0x0002240B
		internal virtual Label lblPersonas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00024214 File Offset: 0x00022414
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0002421E File Offset: 0x0002241E
		internal virtual TextBox txtPersonas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00024227 File Offset: 0x00022427
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00024234 File Offset: 0x00022434
		internal virtual Panel PanelBot
		{
			[CompilerGenerated]
			get
			{
				return this._PanelBot;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.PanelBot_Paint);
				Panel panelBot = this._PanelBot;
				if (panelBot != null)
				{
					panelBot.Paint -= value2;
				}
				this._PanelBot = value;
				panelBot = this._PanelBot;
				if (panelBot != null)
				{
					panelBot.Paint += value2;
				}
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00024277 File Offset: 0x00022477
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00024281 File Offset: 0x00022481
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0002428A File Offset: 0x0002248A
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00024294 File Offset: 0x00022494
		internal virtual TextBox txtTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0002429D File Offset: 0x0002249D
		// (set) Token: 0x06000339 RID: 825 RVA: 0x000242A7 File Offset: 0x000224A7
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600033A RID: 826 RVA: 0x000242B0 File Offset: 0x000224B0
		// (set) Token: 0x0600033B RID: 827 RVA: 0x000242BA File Offset: 0x000224BA
		internal virtual TextBox txtSubtotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600033C RID: 828 RVA: 0x000242C3 File Offset: 0x000224C3
		// (set) Token: 0x0600033D RID: 829 RVA: 0x000242CD File Offset: 0x000224CD
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600033E RID: 830 RVA: 0x000242D6 File Offset: 0x000224D6
		// (set) Token: 0x0600033F RID: 831 RVA: 0x000242E0 File Offset: 0x000224E0
		internal virtual TextBox txtDescuento { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000340 RID: 832 RVA: 0x000242E9 File Offset: 0x000224E9
		// (set) Token: 0x06000341 RID: 833 RVA: 0x000242F3 File Offset: 0x000224F3
		internal virtual Panel PanelDGW { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000342 RID: 834 RVA: 0x000242FC File Offset: 0x000224FC
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00024308 File Offset: 0x00022508
		internal virtual PictureBox btnAplicar
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
				PictureBox btnAplicar = this._btnAplicar;
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

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0002434B File Offset: 0x0002254B
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00024358 File Offset: 0x00022558
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

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0002439B File Offset: 0x0002259B
		// (set) Token: 0x06000347 RID: 839 RVA: 0x000243A8 File Offset: 0x000225A8
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

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000348 RID: 840 RVA: 0x000243EB File Offset: 0x000225EB
		// (set) Token: 0x06000349 RID: 841 RVA: 0x000243F8 File Offset: 0x000225F8
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

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0002443B File Offset: 0x0002263B
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00024448 File Offset: 0x00022648
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
				EventHandler value3 = new EventHandler(this.txtBuscarFolio_Enter);
				EventHandler value4 = new EventHandler(this.txtBuscarFolio_Click);
				TextBox txtBuscarFolio = this._txtBuscarFolio;
				if (txtBuscarFolio != null)
				{
					txtBuscarFolio.TextChanged -= value2;
					txtBuscarFolio.Enter -= value3;
					txtBuscarFolio.Click -= value4;
				}
				this._txtBuscarFolio = value;
				txtBuscarFolio = this._txtBuscarFolio;
				if (txtBuscarFolio != null)
				{
					txtBuscarFolio.TextChanged += value2;
					txtBuscarFolio.Enter += value3;
					txtBuscarFolio.Click += value4;
				}
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600034C RID: 844 RVA: 0x000244C1 File Offset: 0x000226C1
		// (set) Token: 0x0600034D RID: 845 RVA: 0x000244CC File Offset: 0x000226CC
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

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0002450F File Offset: 0x0002270F
		// (set) Token: 0x0600034F RID: 847 RVA: 0x0002451C File Offset: 0x0002271C
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
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgvNotas_CellContentClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.dgvNotas_CellClick);
				DataGridView dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellContentClick -= value2;
					dgvNotas.CellClick -= value3;
				}
				this._dgvNotas = value;
				dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellContentClick += value2;
					dgvNotas.CellClick += value3;
				}
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0002457A File Offset: 0x0002277A
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00024584 File Offset: 0x00022784
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0002458D File Offset: 0x0002278D
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00024597 File Offset: 0x00022797
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000354 RID: 852 RVA: 0x000245A0 File Offset: 0x000227A0
		// (set) Token: 0x06000355 RID: 853 RVA: 0x000245AA File Offset: 0x000227AA
		internal virtual TextBox TxtFacturado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000356 RID: 854 RVA: 0x000245B3 File Offset: 0x000227B3
		// (set) Token: 0x06000357 RID: 855 RVA: 0x000245BD File Offset: 0x000227BD
		internal virtual Panel Panel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000358 RID: 856 RVA: 0x000245C6 File Offset: 0x000227C6
		// (set) Token: 0x06000359 RID: 857 RVA: 0x000245D0 File Offset: 0x000227D0
		internal virtual TextBox txtotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600035A RID: 858 RVA: 0x000245D9 File Offset: 0x000227D9
		// (set) Token: 0x0600035B RID: 859 RVA: 0x000245E3 File Offset: 0x000227E3
		internal virtual Label lblOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600035C RID: 860 RVA: 0x000245EC File Offset: 0x000227EC
		// (set) Token: 0x0600035D RID: 861 RVA: 0x000245F6 File Offset: 0x000227F6
		internal virtual TextBox txtvales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600035E RID: 862 RVA: 0x000245FF File Offset: 0x000227FF
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00024609 File Offset: 0x00022809
		internal virtual Label lblVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00024612 File Offset: 0x00022812
		// (set) Token: 0x06000361 RID: 865 RVA: 0x0002461C File Offset: 0x0002281C
		internal virtual TextBox txtTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00024625 File Offset: 0x00022825
		// (set) Token: 0x06000363 RID: 867 RVA: 0x0002462F File Offset: 0x0002282F
		internal virtual Label lbltarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00024638 File Offset: 0x00022838
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00024642 File Offset: 0x00022842
		internal virtual TextBox txtEfectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0002464B File Offset: 0x0002284B
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00024655 File Offset: 0x00022855
		internal virtual Label lblefectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0002465E File Offset: 0x0002285E
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00024668 File Offset: 0x00022868
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00024671 File Offset: 0x00022871
		// (set) Token: 0x0600036B RID: 875 RVA: 0x0002467B File Offset: 0x0002287B
		internal virtual TextBox txtPropina { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00024684 File Offset: 0x00022884
		// (set) Token: 0x0600036D RID: 877 RVA: 0x0002468E File Offset: 0x0002288E
		internal virtual Label lblPropina { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00024697 File Offset: 0x00022897
		// (set) Token: 0x0600036F RID: 879 RVA: 0x000246A1 File Offset: 0x000228A1
		internal virtual Panel PanelPropina { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000370 RID: 880 RVA: 0x000246AA File Offset: 0x000228AA
		// (set) Token: 0x06000371 RID: 881 RVA: 0x000246B4 File Offset: 0x000228B4
		internal virtual Panel PanelOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000372 RID: 882 RVA: 0x000246BD File Offset: 0x000228BD
		// (set) Token: 0x06000373 RID: 883 RVA: 0x000246C7 File Offset: 0x000228C7
		internal virtual Panel PanelVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000374 RID: 884 RVA: 0x000246D0 File Offset: 0x000228D0
		// (set) Token: 0x06000375 RID: 885 RVA: 0x000246DA File Offset: 0x000228DA
		internal virtual Panel PanelTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000376 RID: 886 RVA: 0x000246E3 File Offset: 0x000228E3
		// (set) Token: 0x06000377 RID: 887 RVA: 0x000246ED File Offset: 0x000228ED
		internal virtual Panel PanelEfectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000378 RID: 888 RVA: 0x000246F6 File Offset: 0x000228F6
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00024700 File Offset: 0x00022900
		internal virtual Panel Panel12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00024709 File Offset: 0x00022909
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00024713 File Offset: 0x00022913
		internal virtual Panel Panel15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0002471C File Offset: 0x0002291C
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00024726 File Offset: 0x00022926
		internal virtual Panel Panel14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0002472F File Offset: 0x0002292F
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00024739 File Offset: 0x00022939
		internal virtual Panel Panel13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00024742 File Offset: 0x00022942
		// (set) Token: 0x06000381 RID: 897 RVA: 0x0002474C File Offset: 0x0002294C
		internal virtual Label lblidFoliodet { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00024755 File Offset: 0x00022955
		// (set) Token: 0x06000383 RID: 899 RVA: 0x0002475F File Offset: 0x0002295F
		internal virtual Label lblContarFilas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00024768 File Offset: 0x00022968
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00024772 File Offset: 0x00022972
		internal virtual Label lblTotalAlimentos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0002477B File Offset: 0x0002297B
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00024785 File Offset: 0x00022985
		internal virtual Label lblTotalBebidas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0002478E File Offset: 0x0002298E
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00024798 File Offset: 0x00022998
		internal virtual Label lblTotalOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600038A RID: 906 RVA: 0x000247A1 File Offset: 0x000229A1
		// (set) Token: 0x0600038B RID: 907 RVA: 0x000247AB File Offset: 0x000229AB
		internal virtual Label lblTotalOtrosSinDescuento { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600038C RID: 908 RVA: 0x000247B4 File Offset: 0x000229B4
		// (set) Token: 0x0600038D RID: 909 RVA: 0x000247BE File Offset: 0x000229BE
		internal virtual Label lblTotalBebidasDesc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600038E RID: 910 RVA: 0x000247C7 File Offset: 0x000229C7
		// (set) Token: 0x0600038F RID: 911 RVA: 0x000247D1 File Offset: 0x000229D1
		internal virtual Label lblTotalAlimentosDescuento { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000390 RID: 912 RVA: 0x000247DA File Offset: 0x000229DA
		// (set) Token: 0x06000391 RID: 913 RVA: 0x000247E4 File Offset: 0x000229E4
		internal virtual Panel PanelBuscarProducto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000392 RID: 914 RVA: 0x000247ED File Offset: 0x000229ED
		// (set) Token: 0x06000393 RID: 915 RVA: 0x000247F7 File Offset: 0x000229F7
		internal virtual Panel Panel16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00024800 File Offset: 0x00022A00
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0002480C File Offset: 0x00022A0C
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
				EventHandler value2 = new EventHandler(this.PictureBox2_Click);
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

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0002484F File Offset: 0x00022A4F
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00024859 File Offset: 0x00022A59
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00024862 File Offset: 0x00022A62
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0002486C File Offset: 0x00022A6C
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
				EventHandler value4 = new EventHandler(this.txtBuscarProducto_Enter);
				TextBox txtBuscarProducto = this._txtBuscarProducto;
				if (txtBuscarProducto != null)
				{
					txtBuscarProducto.TextChanged -= value2;
					txtBuscarProducto.Click -= value3;
					txtBuscarProducto.Enter -= value4;
				}
				this._txtBuscarProducto = value;
				txtBuscarProducto = this._txtBuscarProducto;
				if (txtBuscarProducto != null)
				{
					txtBuscarProducto.TextChanged += value2;
					txtBuscarProducto.Click += value3;
					txtBuscarProducto.Enter += value4;
				}
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600039A RID: 922 RVA: 0x000248E5 File Offset: 0x00022AE5
		// (set) Token: 0x0600039B RID: 923 RVA: 0x000248F0 File Offset: 0x00022AF0
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

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00024933 File Offset: 0x00022B33
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0002493D File Offset: 0x00022B3D
		internal virtual Panel Panel17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00024946 File Offset: 0x00022B46
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00024950 File Offset: 0x00022B50
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
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.dgwProductos_CellClick);
				DataGridViewCellMouseEventHandler value4 = new DataGridViewCellMouseEventHandler(this.dgwProductos_CellMouseClick);
				DataGridView dgwProductos = this._dgwProductos;
				if (dgwProductos != null)
				{
					dgwProductos.CellValueChanged -= value2;
					dgwProductos.CellClick -= value3;
					dgwProductos.CellMouseClick -= value4;
				}
				this._dgwProductos = value;
				dgwProductos = this._dgwProductos;
				if (dgwProductos != null)
				{
					dgwProductos.CellValueChanged += value2;
					dgwProductos.CellClick += value3;
					dgwProductos.CellMouseClick += value4;
				}
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x000249C9 File Offset: 0x00022BC9
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x000249D3 File Offset: 0x00022BD3
		internal virtual CheckBox chkRenumerar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x000249DC File Offset: 0x00022BDC
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x000249E6 File Offset: 0x00022BE6
		internal virtual ProgressBar progBar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x000249EF File Offset: 0x00022BEF
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x000249F9 File Offset: 0x00022BF9
		internal virtual Label lblRefolear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00024A02 File Offset: 0x00022C02
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00024A0C File Offset: 0x00022C0C
		internal virtual Label lblIdEstacion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00024A15 File Offset: 0x00022C15
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00024A1F File Offset: 0x00022C1F
		internal virtual Label lblMesero { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00024A28 File Offset: 0x00022C28
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00024A32 File Offset: 0x00022C32
		internal virtual Label lblidturno_cierre { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00024A3B File Offset: 0x00022C3B
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00024A45 File Offset: 0x00022C45
		internal virtual Label lblFechadelProducto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00024A4E File Offset: 0x00022C4E
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00024A58 File Offset: 0x00022C58
		internal virtual Panel PanelVariables { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00024A61 File Offset: 0x00022C61
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00024A6B File Offset: 0x00022C6B
		internal virtual DateTimePicker dateHoraFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00024A74 File Offset: 0x00022C74
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00024A7E File Offset: 0x00022C7E
		internal virtual DateTimePicker dateHoraIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00024A87 File Offset: 0x00022C87
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00024A91 File Offset: 0x00022C91
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00024A9A File Offset: 0x00022C9A
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00024AA4 File Offset: 0x00022CA4
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00024AAD File Offset: 0x00022CAD
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00024AB7 File Offset: 0x00022CB7
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00024AC0 File Offset: 0x00022CC0
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00024ACA File Offset: 0x00022CCA
		internal virtual DateTimePicker dateFechaFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00024AD3 File Offset: 0x00022CD3
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00024ADD File Offset: 0x00022CDD
		internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00024AE6 File Offset: 0x00022CE6
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00024AF0 File Offset: 0x00022CF0
		internal virtual DateTimePicker dateFechaIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00024AF9 File Offset: 0x00022CF9
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00024B03 File Offset: 0x00022D03
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00024B0C File Offset: 0x00022D0C
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00024B18 File Offset: 0x00022D18
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

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00024B5B File Offset: 0x00022D5B
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00024B65 File Offset: 0x00022D65
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00024B6E File Offset: 0x00022D6E
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00024B78 File Offset: 0x00022D78
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

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00024BBB File Offset: 0x00022DBB
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00024BC5 File Offset: 0x00022DC5
		internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00024BCE File Offset: 0x00022DCE
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00024BD8 File Offset: 0x00022DD8
		internal virtual Label lblEfectivoTurno1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00024BE1 File Offset: 0x00022DE1
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00024BEB File Offset: 0x00022DEB
		internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060003CE RID: 974 RVA: 0x00024BF4 File Offset: 0x00022DF4
		private void frmEditarTicketvb_Load(object sender, EventArgs e)
		{
			this.llenaCombos();
			this.ComboBoxIdEmpresa.Enabled = false;
			this.txtSerie.Enabled = false;
			this.txtBuscarFolio.Text = "Buscar Folio...";
			this.iniciaGridFolio();
			this.txtDescuento.Enabled = false;
			this.txtPropina.Enabled = false;
			this.txtSubtotal.Enabled = false;
			this.txtTotal.Enabled = false;
			this.txtFechadelTicket.Enabled = false;
			this.txtEfectivo.Enabled = false;
			this.txtTarjeta.Enabled = false;
			this.txtotros.Enabled = false;
			this.txtvales.Enabled = false;
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
			this.PanelBuscarProducto.Visible = false;
			this.btnAplicar.Visible = false;
			this.BtnAgregarProducto.Visible = false;
			this.btnEliminarProducto.Visible = false;
			this.PanelVariables.Visible = false;
			this.dateHoraFin.Text = "05:59:59 a. m.";
			this.dateHoraIni.Text = "06:00:00 a. m.";
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
			this.DoubleBufferedASD(this.dgvNotas, true);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000036D5 File Offset: 0x000018D5
		private void lblFolio_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0001D5AF File Offset: 0x0001B7AF
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00024EA8 File Offset: 0x000230A8
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
			this.dgvNotas.Columns[2].Width = 60;
			this.dgvNotas.Columns[3].Name = "Clave";
			this.dgvNotas.Columns[3].Width = 70;
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
			this.dgvNotas.Columns[20].Name = "Precio de Venta";
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

		// Token: 0x060003D2 RID: 978 RVA: 0x000257F4 File Offset: 0x000239F4
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00025828 File Offset: 0x00023A28
		private void llenaCombos()
		{
			SqlQuery sqlQuery = new SqlQuery();
			this.ComboBoxIdEmpresa.Items.Clear();
			this.txtSerie.Clear();
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader("Select distinct(idempresa) from empresas");
			while (sqlDataReader.Read())
			{
				this.ComboBoxIdEmpresa.Items.Add(sqlDataReader[0].ToString());
			}
			sqlDataReader = (SqlDataReader)sqlQuery.execReader("Select distinct(serie) from folios");
			this.txtSerie.Text = "Todas";
			while (sqlDataReader.Read())
			{
				this.txtSerie.Text = sqlDataReader[0].ToString();
			}
			sqlDataReader.Close();
			this.ComboBoxIdEmpresa.SelectedIndex = 0;
			sqlDataReader = (SqlDataReader)sqlQuery.execReader("Select distinct (b) from usuarioperfil");
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					this.cmbAnio.Items.Add(sqlDataReader[0].ToString());
				}
			}
			sqlDataReader.Close();
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00025944 File Offset: 0x00023B44
		private void txtBuscarFolio_TextChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txtBuscarFolio.Text, "", false) == 0;
			if (flag)
			{
				this.txtBuscarFolio.Text = "Buscar Folio...";
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PanelBot_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PanelInformacion_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00025984 File Offset: 0x00023B84
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

		// Token: 0x060003D8 RID: 984 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtBuscarFolio_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00025A84 File Offset: 0x00023C84
		public void MostarReporte()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string text = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
			string text2 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
			string text3 = this.txtBuscarFolio.Text;
			string query = string.Concat(new string[]
			{
				"Select a.foliodet, a.movimiento , a.cantidad ,a.idproducto, e.descripcion , CONVERT(numeric(10,0),a.descuento) as descuento , convert(numeric(10,2), a.preciosinimpuestos * a.descuento / -100) + (a.preciosinimpuestos) as 'preciosinimpuestos', convert(numeric(10,2), a.precio * a.descuento / -100) + (a.precio) as 'precio' , \r\n                    c.fecha , c.nopersonas , c.descuentoimporte , c.subtotal , c.total , c.propina , c.tarjeta , c.efectivo , c.vales , c.otros ,a.impuesto1 , c.facturado , a.precio as 'Precio Catalogo',\r\n\t\t\t\t\tg.idgrupo , z.clasificacionventa , c.totalalimentos , c.totalbebidas , c.totalotros , c.totalalimentossindescuentos , c.totalbebidassindescuentos , c.totalotrossindescuentos , a.preciosinimpuestos as 'PrecioSinImpuestos' , a.idestacion  , a.idmeseroproducto , a.idturno_cierre , convert(datetime,a.hora) as hora\r\n                    from cheqdet A\r\n                    LEFT JOIN productos E on e.idproducto = a.idproducto\r\n                    LEFT JOIN CHEQUES C on c.folio= a.foliodet\r\n\t\t\t\t\tLEFT JOIN grupos G on g.idgrupo = e.idgrupo\r\n\t\t\t\t\tLEFT JOIN gruposiclasificacion Z on z.clasificacionventa = g.clasificacion\r\n                    where a.foliodet in ( select folio from cheques where numcheque='",
				text3,
				"' and fecha between '",
				text,
				"' and  '",
				text2,
				"') order by a.movimiento"
			});
			try
			{
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
				this.iniciaGridFolio();
				bool flag = !sqlDataReader.HasRows;
				if (flag)
				{
					Interaction.MsgBox("No existe el ticket en la base de datos o esta fuera del rango de tu licencia , verifica el folio que estas ingresando! ", MsgBoxStyle.Information, this.Text);
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
					string text4 = Conversions.ToString(sqlDataReader[0]);
					this.movimiento = Conversions.ToString(sqlDataReader[1]);
					string text5 = Conversions.ToString(sqlDataReader[2]);
					string text6 = Conversions.ToString(sqlDataReader[3]);
					string text7 = Conversions.ToString(sqlDataReader[4]);
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
					string text8 = Conversions.ToString(sqlDataReader[8]);
					string text9 = Conversions.ToString(sqlDataReader[9]);
					double num3 = Conversions.ToDouble(sqlDataReader[10]);
					double num4 = Conversions.ToDouble(sqlDataReader[11]);
					double num5 = Conversions.ToDouble(sqlDataReader[12]);
					double num6 = Conversions.ToDouble(sqlDataReader[13]);
					double num7 = Conversions.ToDouble(sqlDataReader[14]);
					double num8 = Conversions.ToDouble(sqlDataReader[15]);
					double num9 = Conversions.ToDouble(sqlDataReader[15]);
					double num10 = Conversions.ToDouble(sqlDataReader[16]);
					double num11 = Conversions.ToDouble(sqlDataReader[17]);
					string text10 = Conversions.ToString(sqlDataReader[18]);
					bool flag3 = Operators.ConditionalCompareObjectEqual(sqlDataReader[19], 0, false);
					string text11;
					if (flag3)
					{
						text11 = "NO FACTURADO";
					}
					else
					{
						text11 = "FACTURADO";
					}
					double num12 = Conversions.ToDouble(sqlDataReader[20]);
					string text12 = Conversions.ToString(sqlDataReader[21]);
					string text13 = Conversions.ToString(sqlDataReader[22]);
					double num13 = Conversions.ToDouble(sqlDataReader[23]);
					double num14 = Conversions.ToDouble(sqlDataReader[24]);
					double num15 = Conversions.ToDouble(sqlDataReader[25]);
					double num16 = Conversions.ToDouble(sqlDataReader[26]);
					double num17 = Conversions.ToDouble(sqlDataReader[27]);
					double num18 = Conversions.ToDouble(sqlDataReader[28]);
					double num19 = Conversions.ToDouble(sqlDataReader[29]);
					string text14 = Conversions.ToString(sqlDataReader[30]);
					string text15 = Conversions.ToString(sqlDataReader[31]);
					string text16 = Conversions.ToString(sqlDataReader[32]);
					this.lblEfectivoTurno1.Text = num9.ToString("N2");
					string text17 = Conversions.ToString(sqlDataReader[33]);
					this.lblIdEstacion.Text = text14;
					this.lblMesero.Text = text15;
					this.lblidturno_cierre.Text = text16;
					this.lblFechadelProducto.Text = text17;
					this.lblFechadelProducto.Text = Conversions.ToDate(this.lblFechadelProducto.Text).ToString(Tools.strFormatoFechaLargo);
					this.lblidFoliodet.Text = text4;
					this.lblTotalAlimentos.Text = num13.ToString("N2");
					this.lblTotalBebidas.Text = num14.ToString("N2");
					this.lblTotalOtros.Text = num15.ToString("N2");
					this.lblTotalAlimentosDescuento.Text = num16.ToString("N2");
					this.lblTotalBebidasDesc.Text = num17.ToString("N2");
					this.lblTotalOtrosSinDescuento.Text = num18.ToString("N2");
					this.dgvNotas.Rows.Add(new object[]
					{
						text4,
						this.movimiento,
						text5,
						text6,
						text7,
						str + "% ",
						"$ " + num.ToString("N2"),
						"$ " + num2.ToString("N2"),
						text8,
						text9,
						"$ " + num3.ToString("N2"),
						"$ " + num4.ToString("N2"),
						"$ " + num5.ToString("N2"),
						"$ " + num6.ToString("N2"),
						"$ " + num7.ToString("N2"),
						"$ " + num8.ToString("N2"),
						"$ " + num10.ToString("N2"),
						"$ " + num11.ToString("N2"),
						text10,
						text11,
						"$ " + num12.ToString("N2"),
						text12,
						text13,
						"$ " + num13.ToString("N2"),
						"$ " + num14.ToString("N2"),
						"$ " + num15.ToString("N2"),
						"$ " + num16.ToString("N2"),
						"$ " + num17.ToString("N2"),
						"$ " + num18.ToString("N2"),
						"$ " + num19.ToString("N2")
					});
					this.txtFechadelTicket.Text = text8;
					this.txtPersonas.Text = text9;
					this.txtDescuento.Text = "$ " + num3.ToString("N2");
					this.txtPropina.Text = "$ " + num6.ToString("N2");
					this.txtSubtotal.Text = "$ " + num4.ToString("N2");
					this.txtTotal.Text = "$ " + num5.ToString("N2");
					this.TxtFacturado.Text = text11;
					this.txtEfectivo.Text = "$ " + num8.ToString("N2");
					this.txtTarjeta.Text = "$ " + num7.ToString("N2");
					this.txtvales.Text = "$ " + num10.ToString("N2");
					this.txtotros.Text = "$ " + num11.ToString("N2");
				}
				sqlDataReader.Close();
			}
			catch (Exception ex)
			{
			}
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					dataGridViewRow.Cells[5].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[0].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[1].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[2].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[3].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[4].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[6].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[7].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[8].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[9].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[10].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[11].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[12].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[13].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[18].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[19].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[20].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
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
			bool flag4 = Operators.CompareString(this.TxtFacturado.Text, "FACTURADO", false) == 0;
			if (flag4)
			{
				Interaction.MsgBox("Esta ingresando un folio facturado no puedes editarlo , intenta con otro!", MsgBoxStyle.Information, this.Text);
				this.dgvNotas.Enabled = false;
				this.BtnAgregarProducto.Visible = false;
				this.btnEliminarProducto.Visible = false;
			}
			else
			{
				bool flag5 = Conversions.ToDouble(this.txtotros.Text) != 0.0;
				if (flag5)
				{
					Interaction.MsgBox("Esta ingresando un folio cobrado en OTROS no puedes editarlo ,Eliminado desde la eliminacion Masiva,  intenta con otro!", MsgBoxStyle.Information, this.Text);
					this.dgvNotas.Enabled = false;
					this.BtnAgregarProducto.Visible = false;
					this.btnEliminarProducto.Visible = false;
				}
				else
				{
					bool flag6 = Conversions.ToDouble(this.txtTarjeta.Text) != 0.0 & Conversions.ToDouble(this.txtEfectivo.Text) != 0.0;
					if (flag6)
					{
						Interaction.MsgBox("Esta ingresando un folio cobrado con Tarjeta y Efectivo puedes retirar productos para disminuir el efectivo!", MsgBoxStyle.Information, this.Text);
						this.dgvNotas.Enabled = true;
						this.BtnAgregarProducto.Visible = true;
						this.btnEliminarProducto.Visible = true;
					}
					else
					{
						bool flag7 = Conversions.ToDouble(this.txtTarjeta.Text) != 0.0;
						if (flag7)
						{
							Interaction.MsgBox("Esta ingresando un folio cobrado en Tarjeta no puedes editarlo , intenta con otro!", MsgBoxStyle.Information, this.Text);
							this.dgvNotas.Enabled = false;
							this.BtnAgregarProducto.Visible = false;
							this.btnEliminarProducto.Visible = false;
						}
						else
						{
							bool flag8 = Conversions.ToDouble(this.txtEfectivo.Text) != 0.0;
							if (flag8)
							{
								this.dgvNotas.Enabled = true;
								this.BtnAgregarProducto.Visible = true;
								this.btnEliminarProducto.Visible = true;
							}
						}
					}
				}
			}
			this.lblContarFilas.Text = Conversions.ToString(this.dgvNotas.RowCount);
			this.dgvNotas.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.85f, FontStyle.Regular);
			this.dgvNotas.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.85f, FontStyle.Regular);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000268F4 File Offset: 0x00024AF4
		private void txtBuscarFolio_Click(object sender, EventArgs e)
		{
			this.txtBuscarFolio.SelectAll();
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00026904 File Offset: 0x00024B04
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			this.MostarReporte();
			bool flag = Operators.CompareString(this.TxtFacturado.Text, "FACTURADO", false) == 0;
			if (flag)
			{
				this.dgvNotas.Enabled = false;
			}
			else
			{
				bool flag2 = Conversions.ToDouble(this.txtTarjeta.Text) != 0.0 & Conversions.ToDouble(this.txtEfectivo.Text) != 0.0;
				if (flag2)
				{
					this.dgvNotas.Enabled = true;
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

		// Token: 0x060003DC RID: 988 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00026A34 File Offset: 0x00024C34
		private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 30;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false);
				if (flag2)
				{
					this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value = true;
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
					double num = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value);
					double num2 = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento C/IVA"].Value);
					double num3 = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells["PrecioSinImpuestos"].Value);
					TextBox textBox;
					(textBox = this.txtSubtotal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - Conversions.ToDouble(num.ToString("N2")));
					(textBox = this.txtTotal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - Conversions.ToDouble(num2.ToString("N2")));
					(textBox = this.txtEfectivo).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - Conversions.ToDouble(num2.ToString("N2")));
					bool flag3 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["idgrupo_clasificacion"].Value, "2", false);
					if (flag3)
					{
						Label label;
						(label = this.lblTotalAlimentos).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num.ToString("N2")));
						(label = this.lblTotalAlimentosDescuento).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num3.ToString("N2")));
					}
					else
					{
						bool flag4 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["idgrupo_clasificacion"].Value, "1", false);
						if (flag4)
						{
							Label label;
							(label = this.lblTotalBebidas).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num.ToString("N2")));
							(label = this.lblTotalBebidasDesc).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num3.ToString("N2")));
						}
						else
						{
							bool flag5 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["idgrupo_clasificacion"].Value, "3", false);
							if (flag5)
							{
								Label label;
								(label = this.lblTotalOtros).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num.ToString("N2")));
								(label = this.lblTotalOtrosSinDescuento).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num3.ToString("N2")));
							}
						}
					}
				}
				else
				{
					this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value = false;
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
					TextBox textBox;
					(textBox = this.txtSubtotal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
					(textBox = this.txtTotal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento C/IVA"].Value)));
					(textBox = this.txtEfectivo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento C/IVA"].Value)));
					bool flag6 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["idgrupo_clasificacion"].Value, "2", false);
					if (flag6)
					{
						Label label;
						(label = this.lblTotalAlimentos).Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
						(label = this.lblTotalAlimentosDescuento).Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["PrecioSinImpuestos"].Value)));
					}
					else
					{
						bool flag7 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["idgrupo_clasificacion"].Value, "1", false);
						if (flag7)
						{
							Label label;
							(label = this.lblTotalBebidas).Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
							(label = this.lblTotalBebidasDesc).Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["PrecioSinImpuestos"].Value)));
						}
						else
						{
							bool flag8 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["idgrupo_clasificacion"].Value, "3", false);
							if (flag8)
							{
								Label label;
								(label = this.lblTotalOtros).Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["Precio C/Descuento S/IVA"].Value)));
								(label = this.lblTotalOtrosSinDescuento).Text = Conversions.ToString(Operators.AddObject(label.Text, Operators.PlusObject(this.dgvNotas.Rows[rowIndex].Cells["PrecioSinImpuestos"].Value)));
							}
						}
					}
				}
				this.txtSubtotal.Text = "$ " + this.txtSubtotal.Text;
				this.txtTotal.Text = "$ " + this.txtTotal.Text;
				this.txtEfectivo.Text = "$ " + this.txtEfectivo.Text;
				this.lblContarFilas.Text = Conversions.ToString(this.dgvNotas.RowCount);
			}
			bool flag9 = Conversions.ToDouble(this.txtSubtotal.Text) < 0.0;
			if (flag9)
			{
				this.txtSubtotal.Text = "$ 0.00";
			}
			bool flag10 = Conversions.ToDouble(this.txtEfectivo.Text) < 1.0;
			if (flag10)
			{
				Interaction.MsgBox("El Efectivo no puede ser menor a $ 0.00 , Valida la informacion!", MsgBoxStyle.Information, this.Text);
			}
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00027280 File Offset: 0x00025480
		private void btnEliminarProducto_Click(object sender, EventArgs e)
		{
			object obj = "SE ELIMINARÁN LOS PRODUCTOS SELECCIONADOS, Deseas continuar?";
			object value = 276;
			object obj2 = "ATENCIÓN!!!";
			object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
			bool flag = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
			if (flag)
			{
				SqlQuery sqlQuery = new SqlQuery();
				try
				{
					foreach (object obj3 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj3;
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false);
						if (flag2)
						{
							string text = Conversions.ToString(dataGridViewRow.Cells["id_nota"].Value);
							string text2 = Conversions.ToString(dataGridViewRow.Cells["Mov."].Value);
							double num = Conversions.ToDouble(this.txtSubtotal.Text);
							double num2 = Conversions.ToDouble(this.txtTotal.Text);
							double num3 = Conversions.ToDouble(this.txtTarjeta.Text);
							double num4 = Conversions.ToDouble(this.txtEfectivo.Text);
							double num5 = Conversions.ToDouble(this.txtvales.Text);
							double num6 = Conversions.ToDouble(this.txtotros.Text);
							double num7 = Conversions.ToDouble(this.lblTotalAlimentos.Text);
							double num8 = Conversions.ToDouble(this.lblTotalBebidas.Text);
							double num9 = Conversions.ToDouble(this.lblTotalOtros.Text);
							double num10 = Conversions.ToDouble(this.txtTotal.Text) - Conversions.ToDouble(this.txtSubtotal.Text);
							string text3 = this.lblTotalAlimentosDescuento.Text;
							double num11 = Conversions.ToDouble(this.lblTotalBebidasDesc.Text);
							double num12 = Conversions.ToDouble(this.lblTotalOtrosSinDescuento.Text);
							string text4 = this.lblidturno_cierre.Text;
							double num13 = Conversions.ToDouble(this.lblEfectivoTurno1.Text);
							try
							{
								string query = "ALTER SEQUENCE Numerar.CountBy1 RESTART";
								sqlQuery.execQuery(query);
							}
							catch (Exception ex)
							{
							}
							SqlQuery sqlQuery2 = new SqlQuery();
							string query2 = "Select idformadepago from formasdepago where descripcion = 'Efectivo'";
							SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query2);
							bool hasRows = sqlDataReader.HasRows;
							if (hasRows)
							{
								sqlDataReader.Read();
								string text5 = Conversions.ToString(sqlDataReader[0]);
								try
								{
									string query = string.Concat(new string[]
									{
										"delete from chequespagos where idformadepago ='",
										text5,
										"' and folio in  ( ",
										text,
										")"
									});
									sqlQuery.execQuery(query);
								}
								catch (Exception ex2)
								{
								}
							}
							sqlDataReader.Close();
							try
							{
								string query = string.Concat(new string[]
								{
									"Update Turnos set Efectivo = Efectivo - ",
									num13.ToString(),
									"  where idturno = '",
									text4.ToString(),
									"' "
								});
								sqlQuery.execQuery(query);
							}
							catch (Exception ex3)
							{
							}
							try
							{
								string query = string.Concat(new string[]
								{
									"delete from cheqdet where foliodet In ( ",
									text,
									")  And movimiento In ( ",
									text2,
									") "
								});
								sqlQuery.execQuery(query);
							}
							catch (Exception ex4)
							{
							}
							try
							{
								string query = string.Concat(new string[]
								{
									"Update cheques Set total = '",
									num2.ToString(),
									"' , subtotal='",
									num.ToString(),
									"' ,  Tarjeta='",
									num3.ToString(),
									"' ,  Efectivo='",
									num4.ToString(),
									"',  Vales='",
									num5.ToString(),
									"' ,  Otros='",
									num6.ToString(),
									"'   where folio in  ( ",
									text,
									")"
								});
								sqlQuery.execQuery(query);
							}
							catch (Exception ex5)
							{
							}
							string text6 = this.lblidturno_cierre.Text;
							try
							{
								string query = string.Concat(new string[]
								{
									"Update cheques set totalconpropina = '",
									num2.ToString(),
									"' , TotalConCargo='",
									num2.ToString(),
									"' ,  TotalConPropinaCargo='",
									num2.ToString(),
									"' ,  TotalSinDescuento='",
									num.ToString(),
									"',  SubtotalConDescuento='",
									num.ToString(),
									"' ,  totalalimentos='",
									num7.ToString(),
									"' ,  totalbebidas='",
									num8.ToString(),
									"' ,  totalotros='",
									num9.ToString(),
									"' ,  totalimpuesto1='",
									num10.ToString(),
									"' ,  totalimpuestod1='",
									num10.ToString(),
									"'    where folio in  ( ",
									text,
									")"
								});
								sqlQuery.execQuery(query);
							}
							catch (Exception ex6)
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
									string text7 = Conversions.ToString(sqlDataReader2[0]);
									try
									{
										string query = string.Concat(new string[]
										{
											" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
											text.ToString(),
											"','",
											text7.ToString(),
											"','",
											num4.ToString(),
											"','0','1','','",
											text6.ToString(),
											"','1','1')"
										});
										sqlQuery.execQuery(query);
									}
									catch (Exception ex7)
									{
									}
								}
							}
							sqlDataReader2.Close();
							try
							{
								string query = string.Concat(new string[]
								{
									"Update cheques set totalalimentossindescuentos = '",
									text3.ToString(),
									"' , totalbebidassindescuentos = '",
									num11.ToString(),
									"' , totalotrossindescuentos = '",
									num12.ToString(),
									"' where folio in  ( ",
									text,
									")"
								});
								sqlQuery.execQuery(query);
							}
							catch (Exception ex8)
							{
							}
							try
							{
								string query = string.Concat(new string[]
								{
									"Update Turnos set Efectivo = Efectivo + ",
									num4.ToString(),
									"  where idturno = '",
									text4.ToString(),
									"' "
								});
								sqlQuery.execQuery(query);
							}
							catch (Exception ex9)
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
			}
			SqlQuery sqlQuery4 = new SqlQuery();
			try
			{
				foreach (object obj4 in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj4;
					bool flag3 = Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false);
					if (flag3)
					{
						string query = "ALTER SEQUENCE Numerar.CountBy1 RESTART";
						sqlQuery4.execQuery(query);
						string text = Conversions.ToString(dataGridViewRow2.Cells["id_nota"].Value);
						query = "Update cheqdet set movimiento = NEXT VALUE FOR Numerar.CountBy1 where foliodet in ( " + text + ")";
						sqlQuery4.execQuery(query);
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
			Interaction.MsgBox("Productos eliminados!", MsgBoxStyle.Information, this.Text);
			this.MostarReporte1();
			this.btnAplicar.Visible = true;
			this.BtnVolver.Visible = false;
			this.BtnAgregarProducto.Visible = false;
			this.btnEliminarProducto.Visible = false;
			this.PictureBox1.Visible = false;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00027B94 File Offset: 0x00025D94
		private void btnAplicar_Click(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			string text = this.txtPersonas.Text;
			string text2 = this.lblidFoliodet.Text;
			string text3 = this.lblContarFilas.Text;
			try
			{
				string query = string.Concat(new string[]
				{
					"Update cheques Set nopersonas = '",
					text.ToString(),
					"' where folio in  ( ",
					text2.ToString(),
					")"
				});
				sqlQuery.execQuery(query);
			}
			catch (Exception ex)
			{
			}
			try
			{
				string query = "Update cheques set cambio=0  where folio in  ( " + text2.ToString() + ")";
				sqlQuery.execQuery(query);
			}
			catch (Exception ex2)
			{
			}
			try
			{
				string query = string.Concat(new string[]
				{
					"Update cheques set totalarticulos = '",
					text3.ToString(),
					"' where folio in  ( ",
					text2.ToString(),
					")"
				});
				sqlQuery.execQuery(query);
			}
			catch (Exception ex3)
			{
			}
			Interaction.MsgBox("Ticket guardado exitosamente! , Captura otro folio para seguir editando!", MsgBoxStyle.Information, this.Text);
			this.BtnVolver.Visible = true;
			this.btnAplicar.Visible = false;
			this.dgvNotas.Rows.Clear();
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
			this.txtBuscarFolio.Text = "BUSCAR FOLIO...";
			this.PictureBox1.Visible = true;
			this.btnEliminarProducto.Visible = false;
			this.BtnAgregarProducto.Visible = false;
			this.dgvNotas.Columns[30].Visible = true;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00027E28 File Offset: 0x00026028
		private void BtnAgregarProducto_Click(object sender, EventArgs e)
		{
			this.PanelBuscarProducto.Visible = true;
			this.btnAplicar.Visible = true;
			this.BtnVolver.Visible = false;
			this.iniciaGridProductos();
			this.txtBuscarProducto.Text = "BUSCAR PRODUCTO...";
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00027E75 File Offset: 0x00026075
		private void PictureBox3_Click(object sender, EventArgs e)
		{
			this.PanelBuscarProducto.Visible = false;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00027E88 File Offset: 0x00026088
		private void iniciaGridProductos()
		{
			this.DoubleBufferedASD(this.dgwProductos, true);
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			this.dgwProductos.Rows.Clear();
			this.dgwProductos.ColumnCount = 30;
			this.dgwProductos.Columns[0].Name = "id_Producto";
			this.dgwProductos.Columns[0].Visible = false;
			this.dgwProductos.Columns[0].ReadOnly = true;
			this.dgwProductos.Columns[1].Name = "CANTIDAD";
			this.dgwProductos.Columns[1].Width = 60;
			this.dgwProductos.Columns[1].ReadOnly = false;
			this.dgwProductos.Columns[2].Name = "DESCRIPCION";
			this.dgwProductos.Columns[2].Width = 200;
			this.dgwProductos.Columns[2].ReadOnly = true;
			this.dgwProductos.Columns[3].Name = "DESCUENTO %";
			this.dgwProductos.Columns[3].Width = 70;
			this.dgwProductos.Columns[3].Visible = true;
			this.dgwProductos.Columns[3].ReadOnly = false;
			this.dgwProductos.Columns[4].Name = "PRECIO C/Descuento S/IVA";
			this.dgwProductos.Columns[4].Width = 70;
			this.dgwProductos.Columns[4].Visible = false;
			this.dgwProductos.Columns[4].ReadOnly = true;
			this.dgwProductos.Columns[5].Name = "Precio C/Descuento C/IVA";
			this.dgwProductos.Columns[5].Width = 70;
			this.dgwProductos.Columns[5].Visible = false;
			this.dgwProductos.Columns[5].ReadOnly = true;
			this.dgwProductos.Columns[6].Name = "PRECIO VENTA C/IVA";
			this.dgwProductos.Columns[6].Width = 80;
			this.dgwProductos.Columns[6].Visible = true;
			this.dgwProductos.Columns[6].ReadOnly = true;
			this.dgwProductos.Columns[7].Name = "PRECIO SIN IMPUESTOS C/DESCUENTO";
			this.dgwProductos.Columns[7].Width = 80;
			this.dgwProductos.Columns[7].Visible = true;
			this.dgwProductos.Columns[7].ReadOnly = true;
			this.dgwProductos.Columns[8].Name = "PRECIO CON IMPUESTOS C/DESCUENTO";
			this.dgwProductos.Columns[8].Visible = true;
			this.dgwProductos.Columns[8].Width = 80;
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
			this.dgwProductos.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.85f, FontStyle.Regular);
			this.dgwProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.85f, FontStyle.Regular);
			dataGridViewCheckBoxColumn.Width = 60;
			dataGridViewCheckBoxColumn.Name = "Agregar";
			this.dgwProductos.Columns.Add(dataGridViewCheckBoxColumn);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0002890C File Offset: 0x00026B0C
		public void MostrarReporteProductos()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string text = this.txtBuscarProducto.Text;
			string query = "SELECT a.idproducto ,a.Descripcion , b.preciosinimpuestos , b.precio , b.precio as 'Precio de Venta' , c.idgrupo , d.clasificacionventa , b.preciosinimpuestos  FROM productos A \r\n\t                Inner Join Productosdetalle B on b.idproducto = a.idproducto\r\n\t\t\t\t\tInner Join grupos c on c.idgrupo = a.idgrupo\r\n\t\t\t\t\tINNER JOIN gruposiclasificacion d on d.clasificacionventa = c.clasificacion\r\n        WHERE a.Descripcion Like '%" + this.txtBuscarProducto.Text + "%'";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			this.iniciaGridProductos();
			this.DoubleBufferedASD(this.dgwProductos, true);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text2 = Conversions.ToString(sqlDataReader[0]);
					string text3 = Conversions.ToString(sqlDataReader[1]);
					double num = Conversions.ToDouble(sqlDataReader[2]);
					double num2 = Conversions.ToDouble(sqlDataReader[3]);
					double num3 = Conversions.ToDouble(sqlDataReader[4]);
					string text4 = Conversions.ToString(sqlDataReader[5]);
					string text5 = Conversions.ToString(sqlDataReader[6]);
					double num4 = Conversions.ToDouble(sqlDataReader[7]);
					this.dgwProductos.Rows.Add(new object[]
					{
						text2,
						"0",
						text3,
						"0",
						"$ " + num.ToString("N2"),
						"$ " + num2.ToString("N2"),
						"$ " + num3.ToString("N2"),
						"0.00",
						"0.00",
						text4,
						text5,
						num4
					});
				}
				sqlDataReader.Close();
				this.dgwProductos.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.85f, FontStyle.Regular);
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00028ACC File Offset: 0x00026CCC
		private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txtBuscarProducto.Text, "", false) == 0;
			if (flag)
			{
				this.txtBuscarProducto.Text = "Buscar Producto...";
			}
			this.MostrarReporteProductos();
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00028B11 File Offset: 0x00026D11
		private void txtBuscarProducto_Click(object sender, EventArgs e)
		{
			this.txtBuscarProducto.SelectAll();
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00028B20 File Offset: 0x00026D20
		private void dgwProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
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
				num4 = Conversions.ToDouble(this.dgwProductos[7, e.RowIndex].Value);
			}
			double num5 = num * Conversions.ToDouble(num2.ToString("N2")) + num * Conversions.ToDouble(num2.ToString("N2")) * (-Conversions.ToDouble(num3.ToString("N2")) / 100.0);
			this.dgwProductos[7, e.RowIndex].Value = "$ " + num5.ToString("N2");
			num5 = 1.16 * Conversions.ToDouble(num4.ToString("N2"));
			this.dgwProductos[8, e.RowIndex].Value = "$ " + num5.ToString("N2");
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00028D20 File Offset: 0x00026F20
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
					double num = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["PRECIO SIN IMPUESTOS C/DESCUENTO"].Value);
					double num2 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["PRECIO CON IMPUESTOS C/DESCUENTO"].Value);
					double num3 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["Preciosinimpuestos"].Value);
					TextBox textBox;
					(textBox = this.txtSubtotal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString("N2")));
					(textBox = this.txtTotal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num2.ToString("N2")));
					(textBox = this.txtEfectivo).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num2.ToString("N2")));
					bool flag3 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["Id_grupo_clasificacion"].Value, "2", false);
					if (flag3)
					{
						Label label;
						(label = this.lblTotalAlimentos).Text = Conversions.ToString(Conversions.ToDouble(label.Text) + Conversions.ToDouble(num.ToString("N2")));
						(label = this.lblTotalAlimentosDescuento).Text = Conversions.ToString(Conversions.ToDouble(label.Text) + Conversions.ToDouble(num3.ToString("N2")));
					}
					else
					{
						bool flag4 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["Id_grupo_clasificacion"].Value, "1", false);
						if (flag4)
						{
							Label label;
							(label = this.lblTotalBebidas).Text = Conversions.ToString(Conversions.ToDouble(label.Text) + Conversions.ToDouble(num.ToString("N2")));
							(label = this.lblTotalBebidasDesc).Text = Conversions.ToString(Conversions.ToDouble(label.Text) + Conversions.ToDouble(num3.ToString("N2")));
						}
						else
						{
							bool flag5 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["id_grupo_clasificacion"].Value, "3", false);
							if (flag5)
							{
								Label label;
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
					TextBox textBox;
					(textBox = this.txtSubtotal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgwProductos.Rows[rowIndex].Cells["PRECIO SIN IMPUESTOS C/DESCUENTO"].Value));
					(textBox = this.txtTotal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgwProductos.Rows[rowIndex].Cells["PRECIO CON IMPUESTOS C/DESCUENTO"].Value));
					(textBox = this.txtEfectivo).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgwProductos.Rows[rowIndex].Cells["PRECIO CON IMPUESTOS C/DESCUENTO"].Value));
					this.txtSubtotal.Text = "$ " + this.txtSubtotal.Text;
					this.txtTotal.Text = "$ " + this.txtTotal.Text;
					this.txtEfectivo.Text = "$ " + this.txtEfectivo.Text;
					double num4 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["PRECIO SIN IMPUESTOS C/DESCUENTO"].Value);
					double num5 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["Preciosinimpuestos"].Value);
					bool flag6 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["Id_grupo_clasificacion"].Value, "1", false);
					if (flag6)
					{
						Label label;
						(label = this.lblTotalBebidas).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num4.ToString("N2")));
						(label = this.lblTotalBebidasDesc).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num5.ToString("N2")));
					}
					else
					{
						bool flag7 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["Id_grupo_clasificacion"].Value, "2", false);
						if (flag7)
						{
							Label label;
							(label = this.lblTotalAlimentos).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num4.ToString("N2")));
							(label = this.lblTotalAlimentosDescuento).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num5.ToString("N2")));
						}
						else
						{
							bool flag8 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["id_grupo_clasificacion"].Value, "3", false);
							if (flag8)
							{
								Label label;
								(label = this.lblTotalOtros).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num4.ToString("N2")));
								(label = this.lblTotalOtrosSinDescuento).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num5.ToString("N2")));
							}
						}
					}
				}
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0002948C File Offset: 0x0002768C
		private void dgwProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int rowIndex = e.RowIndex;
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 1;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["Agregar"].Value, true, false);
				if (flag2)
				{
					this.dgwProductos.Rows[rowIndex].Cells["Agregar"].Value = false;
					this.dgwProductos.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
					double num = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["PRECIO SIN IMPUESTOS C/DESCUENTO"].Value);
					double num2 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["PRECIO CON IMPUESTOS C/DESCUENTO"].Value);
					double num3 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["PRECIO SIN IMPUESTOS C/DESCUENTO"].Value);
					double num4 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["PRECIO CON IMPUESTOS C/DESCUENTO"].Value);
					double num5 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["Preciosinimpuestos"].Value);
					bool flag3 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["Id_grupo_clasificacion"].Value, "2", false);
					if (flag3)
					{
						Label label;
						(label = this.lblTotalAlimentos).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num3.ToString("N2")));
						(label = this.lblTotalAlimentosDescuento).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num5.ToString("N2")));
					}
					else
					{
						bool flag4 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["Id_grupo_clasificacion"].Value, "1", false);
						if (flag4)
						{
							Label label;
							(label = this.lblTotalBebidas).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num3.ToString("N2")));
							(label = this.lblTotalBebidasDesc).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num5.ToString("N2")));
						}
						else
						{
							bool flag5 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["id_grupo_clasificacion"].Value, "3", false);
							if (flag5)
							{
								Label label;
								(label = this.lblTotalOtros).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num3.ToString("N2")));
								(label = this.lblTotalOtrosSinDescuento).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num5.ToString("N2")));
							}
						}
					}
					TextBox textBox;
					(textBox = this.txtSubtotal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - Conversions.ToDouble("$ " + num.ToString("N2")));
					(textBox = this.txtTotal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - Conversions.ToDouble("$ " + num2.ToString("N2")));
					(textBox = this.txtEfectivo).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - Conversions.ToDouble("$ " + num2.ToString("N2")));
					this.txtSubtotal.Text = "$ " + this.txtSubtotal.Text;
					this.txtTotal.Text = "$ " + this.txtTotal.Text;
					this.txtEfectivo.Text = "$ " + this.txtEfectivo.Text;
				}
			}
			bool flag6 = e.RowIndex >= 0 && e.ColumnIndex == 3;
			if (flag6)
			{
				bool flag7 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["Agregar"].Value, true, false);
				if (flag7)
				{
					this.dgwProductos.Rows[rowIndex].Cells["Agregar"].Value = false;
					this.dgwProductos.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
					double num = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["PRECIO SIN IMPUESTOS C/DESCUENTO"].Value);
					double num2 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["PRECIO CON IMPUESTOS C/DESCUENTO"].Value);
					double num6 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["PRECIO SIN IMPUESTOS C/DESCUENTO"].Value);
					double num7 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["Preciosinimpuestos"].Value);
					bool flag8 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["Id_grupo_clasificacion"].Value, "1", false);
					if (flag8)
					{
						Label label;
						(label = this.lblTotalBebidas).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num6.ToString("N2")));
						(label = this.lblTotalBebidasDesc).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num7.ToString("N2")));
					}
					else
					{
						bool flag9 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["Id_grupo_clasificacion"].Value, "2", false);
						if (flag9)
						{
							Label label;
							(label = this.lblTotalAlimentos).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num6.ToString("N2")));
							(label = this.lblTotalAlimentosDescuento).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num7.ToString("N2")));
						}
						else
						{
							bool flag10 = Operators.ConditionalCompareObjectEqual(this.dgwProductos.Rows[rowIndex].Cells["id_grupo_clasificacion"].Value, "3", false);
							if (flag10)
							{
								Label label;
								(label = this.lblTotalOtros).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num6.ToString("N2")));
								(label = this.lblTotalOtrosSinDescuento).Text = Conversions.ToString(Conversions.ToDouble(label.Text) - Conversions.ToDouble(num7.ToString("N2")));
							}
						}
					}
					TextBox textBox;
					(textBox = this.txtSubtotal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - Conversions.ToDouble("$ " + num.ToString("N2")));
					(textBox = this.txtTotal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - Conversions.ToDouble("$ " + num2.ToString("N2")));
					(textBox = this.txtEfectivo).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - Conversions.ToDouble("$ " + num2.ToString("N2")));
					this.txtSubtotal.Text = "$ " + this.txtSubtotal.Text;
					this.txtTotal.Text = "$ " + this.txtTotal.Text;
					this.txtEfectivo.Text = "$ " + this.txtEfectivo.Text;
				}
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00029D60 File Offset: 0x00027F60
		private void PictureBox2_Click(object sender, EventArgs e)
		{
			object obj = "SE CARGARAN LOS PRODUCTOS SELECCIONADOS, Deseas continuar?";
			object value = 276;
			object obj2 = "ATENCIÓN!!!";
			object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
			bool flag = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
			if (flag)
			{
				SqlQuery sqlQuery = new SqlQuery();
				try
				{
					foreach (object obj3 in ((IEnumerable)this.dgwProductos.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj3;
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Agregar"].Value, true, false);
						if (flag2)
						{
							string text = this.lblidFoliodet.Text;
							string text2 = Conversions.ToString(dataGridViewRow.Cells["CANTIDAD"].Value);
							string text3 = Conversions.ToString(dataGridViewRow.Cells["id_Producto"].Value);
							string text4 = Conversions.ToString(dataGridViewRow.Cells["DESCUENTO %"].Value);
							double num = Conversions.ToDouble(dataGridViewRow.Cells["Precio C/Descuento C/IVA"].Value);
							double num2 = Conversions.ToDouble(dataGridViewRow.Cells["PRECIO C/Descuento S/IVA"].Value);
							string text5 = this.lblIdEstacion.Text;
							string text6 = this.lblMesero.Text;
							double num3 = Conversions.ToDouble(dataGridViewRow.Cells["PRECIO VENTA C/IVA"].Value);
							string text7 = this.lblidturno_cierre.Text;
							string query = string.Concat(new string[]
							{
								"insert into cheqdet (\r\nFoliodet,\r\nmovimiento,\r\ncomanda,\r\ncantidad,\r\nidproducto,\r\ndescuento,\r\nprecio,\r\nimpuesto1,\r\nimpuesto2,\r\nimpuesto3,\r\npreciosinimpuestos,\r\ntiempo,\r\nhora,\r\nmodificador,\r\nmitad,\r\ncomentario,\r\nidestacion,\r\nusuariodescuento,\r\ncomentariodescuento,\r\nidtipodescuento,\r\nhoraproduccion,\r\nidproductocompuesto,\r\nproductocompuestoprincipal,\r\npreciocatalogo,\r\nmarcar,\r\nidmeseroproducto,\r\nprioridadproduccion,\r\nestatuspatin,\r\nidcortesia,\r\nnumerotarjeta,\r\nestadomonitor,\r\nllavemovto,\r\nhorameserofinalizado,\r\nmeserofinalizado,\r\nsistema_envio,\r\nidturno_cierre,\r\nprocesado,\r\npromovolumen,\r\niddispositivo,\r\nproductsyncidsr,\r\nsubtotalsrx,\r\ntotalsrx,\r\nidlistaprecio,\r\ntipocambio,\r\nidmovtobillar,\r\nimpuestoimporte3,\r\nestrateca_DiscountCode,\r\nestrateca_DiscountID,\r\nestrateca_DiscountAmount)\r\n\r\n\r\nValues(\r\n'",
								text.ToString(),
								"',\r\n0,\r\n'',\r\n'",
								text2.ToString(),
								"',\r\n'",
								text3.ToString(),
								"',\r\n'",
								text4.ToString(),
								"',\r\n'",
								num.ToString(),
								"',\r\n'16.0',\r\n'0.00',\r\n'0.00',\r\n'",
								num2.ToString(),
								"',\r\n'',\r\n'",
								this.lblFechadelProducto.Text,
								"',\r\n'0',\r\n'0',\r\n'',\r\n'",
								text5.ToString(),
								"',\r\n'',\r\n'',\r\n'',\r\nNULL,\r\n'',\r\n'0',\r\n'",
								num3.ToString(),
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
			}
			SqlQuery sqlQuery2 = new SqlQuery();
			try
			{
				foreach (object obj4 in ((IEnumerable)this.dgwProductos.Rows))
				{
					DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj4;
					bool flag3 = Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells["Agregar"].Value, true, false);
					if (flag3)
					{
						string text = this.lblidFoliodet.Text;
						double num4 = Conversions.ToDouble(this.txtSubtotal.Text);
						double num5 = Conversions.ToDouble(this.txtTotal.Text);
						double num6 = Conversions.ToDouble(this.txtTarjeta.Text);
						double num7 = Conversions.ToDouble(this.txtEfectivo.Text);
						double num8 = Conversions.ToDouble(this.txtvales.Text);
						double num9 = Conversions.ToDouble(this.txtotros.Text);
						double num10 = Conversions.ToDouble(this.lblTotalAlimentos.Text);
						double num11 = Conversions.ToDouble(this.lblTotalBebidas.Text);
						double num12 = Conversions.ToDouble(this.lblTotalOtros.Text);
						double num13 = Conversions.ToDouble(this.txtTotal.Text) - Conversions.ToDouble(this.txtSubtotal.Text);
						string text8 = this.lblTotalAlimentosDescuento.Text;
						double num14 = Conversions.ToDouble(this.lblTotalBebidasDesc.Text);
						double num15 = Conversions.ToDouble(this.lblTotalOtrosSinDescuento.Text);
						string text9 = this.lblidturno_cierre.Text;
						double num16 = Conversions.ToDouble(this.lblEfectivoTurno1.Text);
						SqlQuery sqlQuery3 = new SqlQuery();
						string query2 = "Select idformadepago from formasdepago where descripcion = 'Efectivo'";
						SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery2.execReader(query2);
						bool hasRows = sqlDataReader.HasRows;
						if (hasRows)
						{
							while (sqlDataReader.Read())
							{
								string text10 = Conversions.ToString(sqlDataReader[0]);
								try
								{
									string query = string.Concat(new string[]
									{
										"delete from chequespagos where idformadepago ='",
										text10.ToString(),
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
						sqlDataReader.Close();
						try
						{
							string query = string.Concat(new string[]
							{
								"Update Turnos set Efectivo = Efectivo - ",
								num16.ToString(),
								"  where idturno = '",
								text9.ToString(),
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
								num5.ToString(),
								"' , subtotal='",
								num4.ToString(),
								"' ,  Tarjeta='",
								num6.ToString(),
								"' ,  Efectivo='",
								num7.ToString(),
								"',  Vales='",
								num8.ToString(),
								"' ,  Otros='",
								num9.ToString(),
								"'   where folio in  ( ",
								text,
								")"
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
								num5.ToString(),
								"' , TotalConCargo='",
								num5.ToString(),
								"' ,  TotalConPropinaCargo='",
								num5.ToString(),
								"' ,  TotalSinDescuento='",
								num4.ToString(),
								"',  SubtotalConDescuento='",
								num4.ToString(),
								"' ,  totalalimentos='",
								num10.ToString(),
								"' ,  totalbebidas='",
								num11.ToString(),
								"' ,  totalotros='",
								num12.ToString(),
								"' ,  totalimpuesto1='",
								num13.ToString(),
								"' ,  totalimpuestod1='",
								num13.ToString(),
								"'    where folio in  ( ",
								text,
								")"
							});
							sqlQuery2.execQuery(query);
						}
						catch (Exception ex4)
						{
						}
						SqlQuery sqlQuery4 = new SqlQuery();
						SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery4.execReader(query2);
						bool hasRows2 = sqlDataReader2.HasRows;
						if (hasRows2)
						{
							while (sqlDataReader2.Read())
							{
								string text11 = Conversions.ToString(sqlDataReader2[0]);
								try
								{
									string query = string.Concat(new string[]
									{
										" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
										text.ToString(),
										"','",
										text11.ToString(),
										"','",
										num7.ToString(),
										"','0','1','','",
										text9.ToString(),
										"','1','1')"
									});
									sqlQuery2.execQuery(query);
								}
								catch (Exception ex5)
								{
								}
							}
						}
						sqlDataReader2.Close();
						try
						{
							string query = string.Concat(new string[]
							{
								"Update cheques set totalalimentossindescuentos = '",
								text8.ToString(),
								"' , totalbebidassindescuentos = '",
								num14.ToString(),
								"' , totalotrossindescuentos = '",
								num15.ToString(),
								"' where folio in  ( ",
								text,
								")"
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
								num7.ToString(),
								"  where idturno = '",
								text9.ToString(),
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
					bool flag4 = Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells["Agregar"].Value, true, false);
					if (flag4)
					{
						string query = "ALTER SEQUENCE Numerar.CountBy1 RESTART";
						sqlQuery2.execQuery(query);
						string text = this.lblidFoliodet.Text;
						try
						{
							query = "Update cheqdet set movimiento = NEXT VALUE FOR Numerar.CountBy1 where foliodet in ( " + text + ")";
							sqlQuery2.execQuery(query);
						}
						catch (Exception ex8)
						{
						}
						Interaction.MsgBox("Productos Cargados Exitosamente!", MsgBoxStyle.Information, this.Text);
					}
					this.PanelBuscarProducto.Visible = false;
					this.btnEliminarProducto.Visible = false;
					this.BtnAgregarProducto.Visible = false;
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
			this.PictureBox1.Visible = false;
			this.MostarReporteConCambios();
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0002A828 File Offset: 0x00028A28
		public void MostarReporteConCambios()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string text = this.txtBuscarFolio.Text;
			string query = "Select a.foliodet, a.movimiento , a.cantidad ,a.idproducto, e.descripcion , CONVERT(numeric(10,0),a.descuento) as descuento , convert(numeric(10,2), a.preciosinimpuestos * a.descuento / -100) + (a.preciosinimpuestos) as 'preciosinimpuestos', convert(numeric(10,2), a.precio * a.descuento / -100) + (a.precio) as 'precio' , \r\n                    c.fecha , c.nopersonas , c.descuentoimporte , c.subtotal , c.total , c.propina , c.tarjeta , c.efectivo , c.vales , c.otros ,a.impuesto1 , c.facturado , a.precio as 'Precio Catalogo',\r\n\t\t\t\t\tg.idgrupo , z.idgruposiclasificacion , c.totalalimentos , c.totalbebidas , c.totalotros , c.totalalimentossindescuentos , c.totalbebidassindescuentos , c.totalotrossindescuentos , a.preciosinimpuestos as 'PrecioSinImpuestos' , a.idestacion  , a.idmeseroproducto , a.idturno_cierre , convert(datetime,a.hora) as hora\r\n                    from cheqdet A\r\n                    LEFT JOIN productos E on e.idproducto = a.idproducto\r\n                    LEFT JOIN CHEQUES C on c.folio= a.foliodet\r\n\t\t\t\t\tLEFT JOIN grupos G on g.idgrupo = e.idgrupo\r\n\t\t\t\t\tLEFT JOIN gruposiclasificacion Z on z.clasificacionventa = g.clasificacion\r\n                    where a.foliodet in ( select folio from cheques where numcheque='" + text + "') order by a.movimiento";
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
					string text2 = Conversions.ToString(sqlDataReader[0]);
					this.movimiento = Conversions.ToString(sqlDataReader[1]);
					string text3 = Conversions.ToString(sqlDataReader[2]);
					string text4 = Conversions.ToString(sqlDataReader[3]);
					string text5 = Conversions.ToString(sqlDataReader[4]);
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
					string text6 = Conversions.ToString(sqlDataReader[8]);
					string text7 = Conversions.ToString(sqlDataReader[9]);
					double num3 = Conversions.ToDouble(sqlDataReader[10]);
					double num4 = Conversions.ToDouble(sqlDataReader[11]);
					double num5 = Conversions.ToDouble(sqlDataReader[12]);
					double num6 = Conversions.ToDouble(sqlDataReader[13]);
					double num7 = Conversions.ToDouble(sqlDataReader[14]);
					double num8 = Conversions.ToDouble(sqlDataReader[15]);
					double num9 = Conversions.ToDouble(sqlDataReader[16]);
					double num10 = Conversions.ToDouble(sqlDataReader[17]);
					string text8 = Conversions.ToString(sqlDataReader[18]);
					bool flag3 = Operators.ConditionalCompareObjectEqual(sqlDataReader[19], 0, false);
					string text9;
					if (flag3)
					{
						text9 = "NO FACTURADO";
					}
					else
					{
						text9 = "FACTURADO";
					}
					double num11 = Conversions.ToDouble(sqlDataReader[20]);
					string text10 = Conversions.ToString(sqlDataReader[21]);
					string text11 = Conversions.ToString(sqlDataReader[22]);
					double num12 = Conversions.ToDouble(sqlDataReader[23]);
					double num13 = Conversions.ToDouble(sqlDataReader[24]);
					double num14 = Conversions.ToDouble(sqlDataReader[25]);
					double num15 = Conversions.ToDouble(sqlDataReader[26]);
					double num16 = Conversions.ToDouble(sqlDataReader[27]);
					double num17 = Conversions.ToDouble(sqlDataReader[28]);
					double num18 = Conversions.ToDouble(sqlDataReader[29]);
					string text12 = Conversions.ToString(sqlDataReader[30]);
					string text13 = Conversions.ToString(sqlDataReader[31]);
					string text14 = Conversions.ToString(sqlDataReader[32]);
					string text15 = Conversions.ToString(sqlDataReader[33]);
					this.lblIdEstacion.Text = text12;
					this.lblMesero.Text = text13;
					this.lblidturno_cierre.Text = text14;
					this.lblFechadelProducto.Text = text15;
					this.lblFechadelProducto.Text = Conversions.ToDate(this.lblFechadelProducto.Text).ToString(Tools.strFormatoFechaLargo);
					this.lblidFoliodet.Text = text2;
					this.lblTotalAlimentos.Text = num12.ToString("N2");
					this.lblTotalBebidas.Text = num13.ToString("N2");
					this.lblTotalOtros.Text = num14.ToString("N2");
					this.lblTotalAlimentosDescuento.Text = num15.ToString("N2");
					this.lblTotalBebidasDesc.Text = num16.ToString("N2");
					this.lblTotalOtrosSinDescuento.Text = num17.ToString("N2");
					this.dgvNotas.Rows.Add(new object[]
					{
						text2,
						this.movimiento,
						text3,
						text4,
						text5,
						str + "% ",
						"$ " + num.ToString("N2"),
						"$ " + num2.ToString("N2"),
						text6,
						text7,
						"$ " + num3.ToString("N2"),
						"$ " + num4.ToString("N2"),
						"$ " + num5.ToString("N2"),
						"$ " + num6.ToString("N2"),
						"$ " + num7.ToString("N2"),
						"$ " + num8.ToString("N2"),
						"$ " + num9.ToString("N2"),
						"$ " + num10.ToString("N2"),
						text8,
						text9,
						"$ " + num11.ToString("N2"),
						text10,
						text11,
						"$ " + num12.ToString("N2"),
						"$ " + num13.ToString("N2"),
						"$ " + num14.ToString("N2"),
						"$ " + num15.ToString("N2"),
						"$ " + num16.ToString("N2"),
						"$ " + num17.ToString("N2"),
						"$ " + num18.ToString("N2")
					});
					this.txtFechadelTicket.Text = text6;
					this.txtPersonas.Text = text7;
					this.txtDescuento.Text = "$ " + num3.ToString("N2");
					this.txtPropina.Text = "$ " + num6.ToString("N2");
					this.txtSubtotal.Text = "$ " + num4.ToString("N2");
					this.txtTotal.Text = "$ " + num5.ToString("N2");
					this.TxtFacturado.Text = text9;
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
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					dataGridViewRow.Cells[5].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[0].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[1].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[2].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[3].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[4].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[6].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[7].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[8].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[9].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[10].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[11].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[12].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[13].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[18].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[19].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[20].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
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
			this.dgvNotas.Columns[30].Visible = false;
			this.lblContarFilas.Text = Conversions.ToString(this.dgvNotas.RowCount);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0002B3C4 File Offset: 0x000295C4
		public void MostarReporte1()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string text = this.txtBuscarFolio.Text;
			string query = "Select a.foliodet, a.movimiento , a.cantidad ,a.idproducto, e.descripcion , CONVERT(numeric(10,0),a.descuento) as descuento , convert(numeric(10,2), a.preciosinimpuestos * a.descuento / -100) + (a.preciosinimpuestos) as 'preciosinimpuestos', convert(numeric(10,2), a.precio * a.descuento / -100) + (a.precio) as 'precio' , \r\n                    c.fecha , c.nopersonas , c.descuentoimporte , c.subtotal , c.total , c.propina , c.tarjeta , c.efectivo , c.vales , c.otros ,a.impuesto1 , c.facturado , a.precio as 'Precio Catalogo',\r\n\t\t\t\t\tg.idgrupo , z.idgruposiclasificacion , c.totalalimentos , c.totalbebidas , c.totalotros , c.totalalimentossindescuentos , c.totalbebidassindescuentos , c.totalotrossindescuentos , a.preciosinimpuestos as 'PrecioSinImpuestos' , a.idestacion  , a.idmeseroproducto , a.idturno_cierre , convert(datetime,a.hora) as hora\r\n                    from cheqdet A\r\n                    LEFT JOIN productos E on e.idproducto = a.idproducto\r\n                    LEFT JOIN CHEQUES C on c.folio= a.foliodet\r\n\t\t\t\t\tLEFT JOIN grupos G on g.idgrupo = e.idgrupo\r\n\t\t\t\t\tLEFT JOIN gruposiclasificacion Z on z.clasificacionventa = g.clasificacion\r\n                    where a.foliodet in ( select folio from cheques where numcheque='" + text + "') order by a.movimiento";
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
					string text2 = Conversions.ToString(sqlDataReader[0]);
					this.movimiento = Conversions.ToString(sqlDataReader[1]);
					string text3 = Conversions.ToString(sqlDataReader[2]);
					string text4 = Conversions.ToString(sqlDataReader[3]);
					string text5 = Conversions.ToString(sqlDataReader[4]);
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
					string text6 = Conversions.ToString(sqlDataReader[8]);
					string text7 = Conversions.ToString(sqlDataReader[9]);
					double num3 = Conversions.ToDouble(sqlDataReader[10]);
					double num4 = Conversions.ToDouble(sqlDataReader[11]);
					double num5 = Conversions.ToDouble(sqlDataReader[12]);
					double num6 = Conversions.ToDouble(sqlDataReader[13]);
					double num7 = Conversions.ToDouble(sqlDataReader[14]);
					double num8 = Conversions.ToDouble(sqlDataReader[15]);
					double num9 = Conversions.ToDouble(sqlDataReader[16]);
					double num10 = Conversions.ToDouble(sqlDataReader[17]);
					string text8 = Conversions.ToString(sqlDataReader[18]);
					bool flag3 = Operators.ConditionalCompareObjectEqual(sqlDataReader[19], 0, false);
					string text9;
					if (flag3)
					{
						text9 = "NO FACTURADO";
					}
					else
					{
						text9 = "FACTURADO";
					}
					double num11 = Conversions.ToDouble(sqlDataReader[20]);
					string text10 = Conversions.ToString(sqlDataReader[21]);
					string text11 = Conversions.ToString(sqlDataReader[22]);
					double num12 = Conversions.ToDouble(sqlDataReader[23]);
					double num13 = Conversions.ToDouble(sqlDataReader[24]);
					double num14 = Conversions.ToDouble(sqlDataReader[25]);
					double num15 = Conversions.ToDouble(sqlDataReader[26]);
					double num16 = Conversions.ToDouble(sqlDataReader[27]);
					double num17 = Conversions.ToDouble(sqlDataReader[28]);
					double num18 = Conversions.ToDouble(sqlDataReader[29]);
					string text12 = Conversions.ToString(sqlDataReader[30]);
					string text13 = Conversions.ToString(sqlDataReader[31]);
					string text14 = Conversions.ToString(sqlDataReader[32]);
					string text15 = Conversions.ToString(sqlDataReader[33]);
					this.lblIdEstacion.Text = text12;
					this.lblMesero.Text = text13;
					this.lblidturno_cierre.Text = text14;
					this.lblFechadelProducto.Text = text15;
					this.lblFechadelProducto.Text = Conversions.ToDate(this.lblFechadelProducto.Text).ToString(Tools.strFormatoFechaLargo);
					this.lblidFoliodet.Text = text2;
					this.lblTotalAlimentos.Text = num12.ToString("N2");
					this.lblTotalBebidas.Text = num13.ToString("N2");
					this.lblTotalOtros.Text = num14.ToString("N2");
					this.lblTotalAlimentosDescuento.Text = num15.ToString("N2");
					this.lblTotalBebidasDesc.Text = num16.ToString("N2");
					this.lblTotalOtrosSinDescuento.Text = num17.ToString("N2");
					this.dgvNotas.Rows.Add(new object[]
					{
						text2,
						this.movimiento,
						text3,
						text4,
						text5,
						str + "% ",
						"$ " + num.ToString("N2"),
						"$ " + num2.ToString("N2"),
						text6,
						text7,
						"$ " + num3.ToString("N2"),
						"$ " + num4.ToString("N2"),
						"$ " + num5.ToString("N2"),
						"$ " + num6.ToString("N2"),
						"$ " + num7.ToString("N2"),
						"$ " + num8.ToString("N2"),
						"$ " + num9.ToString("N2"),
						"$ " + num10.ToString("N2"),
						text8,
						text9,
						"$ " + num11.ToString("N2"),
						text10,
						text11,
						"$ " + num12.ToString("N2"),
						"$ " + num13.ToString("N2"),
						"$ " + num14.ToString("N2"),
						"$ " + num15.ToString("N2"),
						"$ " + num16.ToString("N2"),
						"$ " + num17.ToString("N2"),
						"$ " + num18.ToString("N2")
					});
					this.txtFechadelTicket.Text = text6;
					this.txtPersonas.Text = text7;
					this.txtDescuento.Text = "$ " + num3.ToString("N2");
					this.txtPropina.Text = "$ " + num6.ToString("N2");
					this.txtSubtotal.Text = "$ " + num4.ToString("N2");
					this.txtTotal.Text = "$ " + num5.ToString("N2");
					this.TxtFacturado.Text = text9;
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
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					dataGridViewRow.Cells[5].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[0].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[1].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[2].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[3].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[4].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[6].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[7].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[8].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[9].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[10].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[11].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[12].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[13].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[18].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[19].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
					dataGridViewRow.Cells[20].Style.Font = new Font(this.dgvNotas.Font, FontStyle.Regular);
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
			this.dgvNotas.Columns[30].Visible = false;
			this.lblContarFilas.Text = Conversions.ToString(this.dgvNotas.RowCount);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0002BF60 File Offset: 0x0002A160
		private void cmbAnio_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			this.ComboBox1.Items.Clear();
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader("select distinct(c), CASE WHEN c = 'Enero' THEN 1 WHEN c = 'Febrero' THEN 2 WHEN c = 'Marzo' THEN 3\tWHEN c = 'Abril' THEN 4\tWHEN c = 'Mayo' THEN 5\tWHEN c = 'Junio' THEN 6\tWHEN c = 'Julio' THEN 7\tWHEN c = 'Agosto' THEN 8\tWHEN c = 'Septiembre' THEN 9\tWHEN c = 'Octubre' THEN 10\tWHEN c = 'Noviembre' THEN 11\tWHEN c = 'Diciembre' THEN 12 END AS monthNum from usuarioperfil where b = '" + this.cmbAnio.Text + "' order by monthNum");
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					this.ComboBox1.Items.Add(sqlDataReader[0].ToString());
				}
				this.ComboBox1.Enabled = true;
				this.cmbAnio.Enabled = true;
			}
			sqlDataReader.Close();
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0002C004 File Offset: 0x0002A204
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(string.Concat(new string[]
			{
				"select a,b,c from usuarioperfil where c='",
				this.ComboBox1.Text,
				"' and b ='",
				this.cmbAnio.Text,
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

		// Token: 0x060003EF RID: 1007 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtBuscarProducto_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x040001C4 RID: 452
		private object iFolioInicial;

		// Token: 0x040001C5 RID: 453
		private object iNumChequeInicial;

		// Token: 0x040001C6 RID: 454
		private string movimiento;
	}
}
