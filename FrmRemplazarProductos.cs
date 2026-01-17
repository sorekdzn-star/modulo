using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x0200001F RID: 31
	[DesignerGenerated]
	public partial class FrmRemplazarProductos : Form
	{
		// Token: 0x06000D20 RID: 3360 RVA: 0x000D1EE8 File Offset: 0x000D00E8
		public FrmRemplazarProductos()
		{
			base.Load += this.FrmRemplazarProductos_Load;
			this.dblPrecioProdSustituir = 0.0;
			this.dblPrecioPodAnterior = 0.0;
			this.InitializeComponent();
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x000DC29E File Offset: 0x000DA49E
		// (set) Token: 0x06000D24 RID: 3364 RVA: 0x000DC2A8 File Offset: 0x000DA4A8
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

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x000DC2EB File Offset: 0x000DA4EB
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x000DC2F5 File Offset: 0x000DA4F5
		internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x000DC2FE File Offset: 0x000DA4FE
		// (set) Token: 0x06000D28 RID: 3368 RVA: 0x000DC308 File Offset: 0x000DA508
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

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x000DC34B File Offset: 0x000DA54B
		// (set) Token: 0x06000D2A RID: 3370 RVA: 0x000DC355 File Offset: 0x000DA555
		internal virtual GroupBox groupPeriodo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x000DC35E File Offset: 0x000DA55E
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x000DC368 File Offset: 0x000DA568
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x000DC371 File Offset: 0x000DA571
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x000DC37C File Offset: 0x000DA57C
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

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x000DC3BF File Offset: 0x000DA5BF
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x000DC3C9 File Offset: 0x000DA5C9
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x000DC3D2 File Offset: 0x000DA5D2
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x000DC3DC File Offset: 0x000DA5DC
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

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x000DC41F File Offset: 0x000DA61F
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x000DC429 File Offset: 0x000DA629
		internal virtual DateTimePicker dateHoraFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x000DC432 File Offset: 0x000DA632
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x000DC43C File Offset: 0x000DA63C
		internal virtual DateTimePicker dateHoraIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x000DC445 File Offset: 0x000DA645
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x000DC44F File Offset: 0x000DA64F
		internal virtual DateTimePicker dateFechaFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x000DC458 File Offset: 0x000DA658
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x000DC462 File Offset: 0x000DA662
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x000DC46B File Offset: 0x000DA66B
		// (set) Token: 0x06000D3C RID: 3388 RVA: 0x000DC475 File Offset: 0x000DA675
		internal virtual DateTimePicker dateFechaIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x000DC47E File Offset: 0x000DA67E
		// (set) Token: 0x06000D3E RID: 3390 RVA: 0x000DC488 File Offset: 0x000DA688
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x000DC491 File Offset: 0x000DA691
		// (set) Token: 0x06000D40 RID: 3392 RVA: 0x000DC49B File Offset: 0x000DA69B
		internal virtual ProgressBar progBar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x000DC4A4 File Offset: 0x000DA6A4
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x000DC4AE File Offset: 0x000DA6AE
		internal virtual GroupBox groupParametros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x000DC4B7 File Offset: 0x000DA6B7
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x000DC4C1 File Offset: 0x000DA6C1
		internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x000DC4CA File Offset: 0x000DA6CA
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x000DC4D4 File Offset: 0x000DA6D4
		internal virtual CheckBox chkTarjCred { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x000DC4DD File Offset: 0x000DA6DD
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x000DC4E7 File Offset: 0x000DA6E7
		internal virtual CheckBox chkVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x000DC4F0 File Offset: 0x000DA6F0
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x000DC4FA File Offset: 0x000DA6FA
		internal virtual CheckBox chkOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x000DC503 File Offset: 0x000DA703
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x000DC50D File Offset: 0x000DA70D
		internal virtual CheckBox chkEfectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x000DC516 File Offset: 0x000DA716
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x000DC520 File Offset: 0x000DA720
		internal virtual ComboBox cmbxEmpresa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x000DC529 File Offset: 0x000DA729
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x000DC533 File Offset: 0x000DA733
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x000DC53C File Offset: 0x000DA73C
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x000DC546 File Offset: 0x000DA746
		internal virtual ComboBox cmbxTipo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x000DC54F File Offset: 0x000DA74F
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x000DC559 File Offset: 0x000DA759
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x000DC562 File Offset: 0x000DA762
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x000DC56C File Offset: 0x000DA76C
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x000DC575 File Offset: 0x000DA775
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x000DC580 File Offset: 0x000DA780
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
				DataGridViewCellEventHandler value4 = new DataGridViewCellEventHandler(this.dgvNotas_CellDoubleClick);
				DataGridView dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellContentClick -= value2;
					dgvNotas.CellClick -= value3;
					dgvNotas.CellDoubleClick -= value4;
				}
				this._dgvNotas = value;
				dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellContentClick += value2;
					dgvNotas.CellClick += value3;
					dgvNotas.CellDoubleClick += value4;
				}
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x000DC5F9 File Offset: 0x000DA7F9
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x000DC603 File Offset: 0x000DA803
		internal virtual Panel PanelChequesproductos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x000DC60C File Offset: 0x000DA80C
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x000DC616 File Offset: 0x000DA816
		internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x000DC61F File Offset: 0x000DA81F
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x000DC62C File Offset: 0x000DA82C
		internal virtual DataGridView DataGridCheques
		{
			[CompilerGenerated]
			get
			{
				return this._DataGridCheques;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DataGridCheques_CellContentClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.DataGridCheques_CellClick);
				DataGridView dataGridCheques = this._DataGridCheques;
				if (dataGridCheques != null)
				{
					dataGridCheques.CellContentClick -= value2;
					dataGridCheques.CellClick -= value3;
				}
				this._DataGridCheques = value;
				dataGridCheques = this._DataGridCheques;
				if (dataGridCheques != null)
				{
					dataGridCheques.CellContentClick += value2;
					dataGridCheques.CellClick += value3;
				}
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x000DC68A File Offset: 0x000DA88A
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x000DC694 File Offset: 0x000DA894
		internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x000DC69D File Offset: 0x000DA89D
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x000DC6A7 File Offset: 0x000DA8A7
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x000DC6B0 File Offset: 0x000DA8B0
		// (set) Token: 0x06000D64 RID: 3428 RVA: 0x000DC6BC File Offset: 0x000DA8BC
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

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x000DC6FF File Offset: 0x000DA8FF
		// (set) Token: 0x06000D66 RID: 3430 RVA: 0x000DC709 File Offset: 0x000DA909
		internal virtual Label lblidproducto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x000DC712 File Offset: 0x000DA912
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x000DC71C File Offset: 0x000DA91C
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

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x000DC77A File Offset: 0x000DA97A
		// (set) Token: 0x06000D6A RID: 3434 RVA: 0x000DC784 File Offset: 0x000DA984
		internal virtual Label label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x000DC78D File Offset: 0x000DA98D
		// (set) Token: 0x06000D6C RID: 3436 RVA: 0x000DC797 File Offset: 0x000DA997
		internal virtual CheckBox chkFacturada { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x000DC7A0 File Offset: 0x000DA9A0
		// (set) Token: 0x06000D6E RID: 3438 RVA: 0x000DC7AA File Offset: 0x000DA9AA
		internal virtual Label lblidProdNew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x000DC7B3 File Offset: 0x000DA9B3
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x000DC7BD File Offset: 0x000DA9BD
		internal virtual Label lnlnumerodefila { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x000DC7C6 File Offset: 0x000DA9C6
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x000DC7D0 File Offset: 0x000DA9D0
		internal virtual Panel PanelAplicar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x000DC7D9 File Offset: 0x000DA9D9
		// (set) Token: 0x06000D74 RID: 3444 RVA: 0x000DC7E3 File Offset: 0x000DA9E3
		internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x000DC7EC File Offset: 0x000DA9EC
		// (set) Token: 0x06000D76 RID: 3446 RVA: 0x000DC7F6 File Offset: 0x000DA9F6
		internal virtual TextBox txtPropinasNuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x000DC7FF File Offset: 0x000DA9FF
		// (set) Token: 0x06000D78 RID: 3448 RVA: 0x000DC809 File Offset: 0x000DAA09
		internal virtual Label lbldifvales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x000DC812 File Offset: 0x000DAA12
		// (set) Token: 0x06000D7A RID: 3450 RVA: 0x000DC81C File Offset: 0x000DAA1C
		internal virtual TextBox txtdifvales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x000DC825 File Offset: 0x000DAA25
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x000DC82F File Offset: 0x000DAA2F
		internal virtual Label lbldifotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x000DC838 File Offset: 0x000DAA38
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x000DC842 File Offset: 0x000DAA42
		internal virtual TextBox txtdifotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x000DC84B File Offset: 0x000DAA4B
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x000DC855 File Offset: 0x000DAA55
		internal virtual Label lbldifTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x000DC85E File Offset: 0x000DAA5E
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x000DC868 File Offset: 0x000DAA68
		internal virtual TextBox txtDifTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x000DC871 File Offset: 0x000DAA71
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x000DC87B File Offset: 0x000DAA7B
		internal virtual Label lblventaenVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x000DC884 File Offset: 0x000DAA84
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x000DC88E File Offset: 0x000DAA8E
		internal virtual TextBox txtVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x000DC897 File Offset: 0x000DAA97
		// (set) Token: 0x06000D88 RID: 3464 RVA: 0x000DC8A1 File Offset: 0x000DAAA1
		internal virtual Label lblventaenotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000D89 RID: 3465 RVA: 0x000DC8AA File Offset: 0x000DAAAA
		// (set) Token: 0x06000D8A RID: 3466 RVA: 0x000DC8B4 File Offset: 0x000DAAB4
		internal virtual TextBox txtVentasOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x000DC8BD File Offset: 0x000DAABD
		// (set) Token: 0x06000D8C RID: 3468 RVA: 0x000DC8C7 File Offset: 0x000DAAC7
		internal virtual Label lblVentaentarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x000DC8D0 File Offset: 0x000DAAD0
		// (set) Token: 0x06000D8E RID: 3470 RVA: 0x000DC8DA File Offset: 0x000DAADA
		internal virtual TextBox txtVentaTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x000DC8E3 File Offset: 0x000DAAE3
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x000DC8ED File Offset: 0x000DAAED
		internal virtual Label lblventasinfacturar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x000DC8F6 File Offset: 0x000DAAF6
		// (set) Token: 0x06000D92 RID: 3474 RVA: 0x000DC900 File Offset: 0x000DAB00
		internal virtual TextBox txtventasinfacturar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x000DC909 File Offset: 0x000DAB09
		// (set) Token: 0x06000D94 RID: 3476 RVA: 0x000DC913 File Offset: 0x000DAB13
		internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x000DC91C File Offset: 0x000DAB1C
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x000DC926 File Offset: 0x000DAB26
		internal virtual TextBox txtVentaFacturada { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x000DC92F File Offset: 0x000DAB2F
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x000DC939 File Offset: 0x000DAB39
		internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x000DC942 File Offset: 0x000DAB42
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x000DC94C File Offset: 0x000DAB4C
		internal virtual TextBox txtDepositos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x000DC955 File Offset: 0x000DAB55
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x000DC95F File Offset: 0x000DAB5F
		internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x000DC968 File Offset: 0x000DAB68
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x000DC972 File Offset: 0x000DAB72
		internal virtual TextBox txtretirostotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x000DC97B File Offset: 0x000DAB7B
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x000DC985 File Offset: 0x000DAB85
		internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x000DC98E File Offset: 0x000DAB8E
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x000DC998 File Offset: 0x000DAB98
		internal virtual TextBox txtTotalPropinas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x000DC9A1 File Offset: 0x000DABA1
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x000DC9AB File Offset: 0x000DABAB
		internal virtual TextBox txtCuentasModificar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x000DC9B4 File Offset: 0x000DABB4
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x000DC9BE File Offset: 0x000DABBE
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x000DC9C7 File Offset: 0x000DABC7
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x000DC9D1 File Offset: 0x000DABD1
		internal virtual TextBox txtCuentasTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x000DC9DA File Offset: 0x000DABDA
		// (set) Token: 0x06000DAA RID: 3498 RVA: 0x000DC9E4 File Offset: 0x000DABE4
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x000DC9ED File Offset: 0x000DABED
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x000DC9F7 File Offset: 0x000DABF7
		internal virtual TextBox txtDifPorcen { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x000DCA00 File Offset: 0x000DAC00
		// (set) Token: 0x06000DAE RID: 3502 RVA: 0x000DCA0A File Offset: 0x000DAC0A
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x000DCA13 File Offset: 0x000DAC13
		// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x000DCA1D File Offset: 0x000DAC1D
		internal virtual TextBox txtEfectivoAnt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x000DCA26 File Offset: 0x000DAC26
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x000DCA30 File Offset: 0x000DAC30
		internal virtual TextBox txtEfectivoCaja { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x000DCA39 File Offset: 0x000DAC39
		// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x000DCA43 File Offset: 0x000DAC43
		internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x000DCA4C File Offset: 0x000DAC4C
		// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x000DCA56 File Offset: 0x000DAC56
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x000DCA5F File Offset: 0x000DAC5F
		// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x000DCA69 File Offset: 0x000DAC69
		internal virtual TextBox txtDifImporte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x000DCA72 File Offset: 0x000DAC72
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x000DCA7C File Offset: 0x000DAC7C
		internal virtual TextBox txtEfectivoFiscal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x000DCA85 File Offset: 0x000DAC85
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x000DCA8F File Offset: 0x000DAC8F
		internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x000DCA98 File Offset: 0x000DAC98
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x000DCAA2 File Offset: 0x000DACA2
		internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x000DCAAB File Offset: 0x000DACAB
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x000DCAB5 File Offset: 0x000DACB5
		internal virtual TextBox txtImpNuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x000DCABE File Offset: 0x000DACBE
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x000DCAC8 File Offset: 0x000DACC8
		internal virtual TextBox txtImpAnterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x000DCAD1 File Offset: 0x000DACD1
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x000DCADB File Offset: 0x000DACDB
		internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x000DCAE4 File Offset: 0x000DACE4
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x000DCAF0 File Offset: 0x000DACF0
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

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x000DCB33 File Offset: 0x000DAD33
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x000DCB40 File Offset: 0x000DAD40
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

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x000DCB83 File Offset: 0x000DAD83
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x000DCB8D File Offset: 0x000DAD8D
		internal virtual Panel PanelAsignarProducto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x000DCB96 File Offset: 0x000DAD96
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x000DCBA0 File Offset: 0x000DADA0
		internal virtual Panel Panel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x000DCBA9 File Offset: 0x000DADA9
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x000DCBB4 File Offset: 0x000DADB4
		internal virtual DataGridView dgvProdNuevos
		{
			[CompilerGenerated]
			get
			{
				return this._dgvProdNuevos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgvProdNuevos_CellClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.dgvProdNuevos_CellContentClick_1);
				DataGridViewCellEventHandler value4 = new DataGridViewCellEventHandler(this.dgvProdNuevos_CellDoubleClick);
				DataGridView dgvProdNuevos = this._dgvProdNuevos;
				if (dgvProdNuevos != null)
				{
					dgvProdNuevos.CellClick -= value2;
					dgvProdNuevos.CellContentClick -= value3;
					dgvProdNuevos.CellDoubleClick -= value4;
				}
				this._dgvProdNuevos = value;
				dgvProdNuevos = this._dgvProdNuevos;
				if (dgvProdNuevos != null)
				{
					dgvProdNuevos.CellClick += value2;
					dgvProdNuevos.CellContentClick += value3;
					dgvProdNuevos.CellDoubleClick += value4;
				}
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x000DCC2D File Offset: 0x000DAE2D
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x000DCC37 File Offset: 0x000DAE37
		internal virtual Panel Panel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x000DCC40 File Offset: 0x000DAE40
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x000DCC4C File Offset: 0x000DAE4C
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

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x000DCC8F File Offset: 0x000DAE8F
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x000DCC99 File Offset: 0x000DAE99
		internal virtual Panel Panel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x000DCCA2 File Offset: 0x000DAEA2
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x000DCCAC File Offset: 0x000DAEAC
		internal virtual Label lblContarfilas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x000DCCB5 File Offset: 0x000DAEB5
		// (set) Token: 0x06000DD8 RID: 3544 RVA: 0x000DCCC0 File Offset: 0x000DAEC0
		internal virtual TextBox txtBuscarProdNuevo
		{
			[CompilerGenerated]
			get
			{
				return this._txtBuscarProdNuevo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtBuscarProdNuevo_TextChanged);
				TextBox txtBuscarProdNuevo = this._txtBuscarProdNuevo;
				if (txtBuscarProdNuevo != null)
				{
					txtBuscarProdNuevo.TextChanged -= value2;
				}
				this._txtBuscarProdNuevo = value;
				txtBuscarProdNuevo = this._txtBuscarProdNuevo;
				if (txtBuscarProdNuevo != null)
				{
					txtBuscarProdNuevo.TextChanged += value2;
				}
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x000DCD03 File Offset: 0x000DAF03
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x000DCD0D File Offset: 0x000DAF0D
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x000DCD16 File Offset: 0x000DAF16
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x000DCD20 File Offset: 0x000DAF20
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
				EventHandler value2 = new EventHandler(this.PictureBox5_Click_1);
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

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x000DCD63 File Offset: 0x000DAF63
		// (set) Token: 0x06000DDE RID: 3550 RVA: 0x000DCD6D File Offset: 0x000DAF6D
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x000DCD76 File Offset: 0x000DAF76
		// (set) Token: 0x06000DE0 RID: 3552 RVA: 0x000DCD80 File Offset: 0x000DAF80
		internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x000DCD89 File Offset: 0x000DAF89
		// (set) Token: 0x06000DE2 RID: 3554 RVA: 0x000DCD93 File Offset: 0x000DAF93
		internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x000DCD9C File Offset: 0x000DAF9C
		// (set) Token: 0x06000DE4 RID: 3556 RVA: 0x000DCDA6 File Offset: 0x000DAFA6
		internal virtual Panel Panel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x000DCDAF File Offset: 0x000DAFAF
		// (set) Token: 0x06000DE6 RID: 3558 RVA: 0x000DCDB9 File Offset: 0x000DAFB9
		internal virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x000DCDC2 File Offset: 0x000DAFC2
		// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x000DCDCC File Offset: 0x000DAFCC
		internal virtual Panel Panel10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x000DCDD5 File Offset: 0x000DAFD5
		// (set) Token: 0x06000DEA RID: 3562 RVA: 0x000DCDDF File Offset: 0x000DAFDF
		internal virtual Label lblidprod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x000DCDE8 File Offset: 0x000DAFE8
		// (set) Token: 0x06000DEC RID: 3564 RVA: 0x000DCDF2 File Offset: 0x000DAFF2
		internal virtual Panel PanelCheqdetalle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000DED RID: 3565 RVA: 0x000DCDFB File Offset: 0x000DAFFB
		// (set) Token: 0x06000DEE RID: 3566 RVA: 0x000DCE05 File Offset: 0x000DB005
		internal virtual Panel Panel12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x000DCE0E File Offset: 0x000DB00E
		// (set) Token: 0x06000DF0 RID: 3568 RVA: 0x000DCE18 File Offset: 0x000DB018
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

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x000DCE5B File Offset: 0x000DB05B
		// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x000DCE65 File Offset: 0x000DB065
		internal virtual Panel Panel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x000DCE6E File Offset: 0x000DB06E
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x000DCE78 File Offset: 0x000DB078
		internal virtual DataGridView DataGridVerTicket { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x000DCE81 File Offset: 0x000DB081
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x000DCE8B File Offset: 0x000DB08B
		internal virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x000DCE94 File Offset: 0x000DB094
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x000DCE9E File Offset: 0x000DB09E
		internal virtual Label lblnumchequevista { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x000DCEA7 File Offset: 0x000DB0A7
		// (set) Token: 0x06000DFA RID: 3578 RVA: 0x000DCEB1 File Offset: 0x000DB0B1
		internal virtual CheckBox chkEliminaProp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x000DCEBA File Offset: 0x000DB0BA
		// (set) Token: 0x06000DFC RID: 3580 RVA: 0x000DCEC4 File Offset: 0x000DB0C4
		internal virtual CheckBox chkEliminaRet { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x000DCECD File Offset: 0x000DB0CD
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x000DCED7 File Offset: 0x000DB0D7
		internal virtual CheckBox CheckBoxfondocaja { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x000DCEE0 File Offset: 0x000DB0E0
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x000DCEEA File Offset: 0x000DB0EA
		internal virtual Label lblfondoincial { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x000DCEF3 File Offset: 0x000DB0F3
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x000DCEFD File Offset: 0x000DB0FD
		internal virtual Panel Panelvercortes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x000DCF06 File Offset: 0x000DB106
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x000DCF10 File Offset: 0x000DB110
		internal virtual Label Label51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x000DCF19 File Offset: 0x000DB119
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x000DCF23 File Offset: 0x000DB123
		internal virtual Label Label52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x000DCF2C File Offset: 0x000DB12C
		// (set) Token: 0x06000E08 RID: 3592 RVA: 0x000DCF36 File Offset: 0x000DB136
		internal virtual Label lblEfectivonuevocorte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x000DCF3F File Offset: 0x000DB13F
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x000DCF49 File Offset: 0x000DB149
		internal virtual Label lblsaldofinarlcortenuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x000DCF52 File Offset: 0x000DB152
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x000DCF5C File Offset: 0x000DB15C
		internal virtual Label lblpropinascortenuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x000DCF65 File Offset: 0x000DB165
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x000DCF6F File Offset: 0x000DB16F
		internal virtual Label lblcortenuevoretiros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x000DCF78 File Offset: 0x000DB178
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x000DCF82 File Offset: 0x000DB182
		internal virtual Label lblcortenuevodepositos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x000DCF8B File Offset: 0x000DB18B
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x000DCF95 File Offset: 0x000DB195
		internal virtual Label lblcortenuevotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x000DCF9E File Offset: 0x000DB19E
		// (set) Token: 0x06000E14 RID: 3604 RVA: 0x000DCFA8 File Offset: 0x000DB1A8
		internal virtual Label lblcortenuevovales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x000DCFB1 File Offset: 0x000DB1B1
		// (set) Token: 0x06000E16 RID: 3606 RVA: 0x000DCFBB File Offset: 0x000DB1BB
		internal virtual Label lblcortetarjetanuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x000DCFC4 File Offset: 0x000DB1C4
		// (set) Token: 0x06000E18 RID: 3608 RVA: 0x000DCFD0 File Offset: 0x000DB1D0
		internal virtual PictureBox PictureBox8
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox8_Click);
				PictureBox pictureBox = this._PictureBox8;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox8 = value;
				pictureBox = this._PictureBox8;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x000DD013 File Offset: 0x000DB213
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x000DD01D File Offset: 0x000DB21D
		internal virtual Label lblcorteefectivonuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x000DD026 File Offset: 0x000DB226
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x000DD030 File Offset: 0x000DB230
		internal virtual Label lblfondoinicialnuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x000DD039 File Offset: 0x000DB239
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x000DD043 File Offset: 0x000DB243
		internal virtual Label lblcortefondoinicialanterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x000DD04C File Offset: 0x000DB24C
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x000DD056 File Offset: 0x000DB256
		internal virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x000DD05F File Offset: 0x000DB25F
		// (set) Token: 0x06000E22 RID: 3618 RVA: 0x000DD069 File Offset: 0x000DB269
		internal virtual Label Label41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x000DD072 File Offset: 0x000DB272
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x000DD07C File Offset: 0x000DB27C
		internal virtual Label Label42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x000DD085 File Offset: 0x000DB285
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x000DD08F File Offset: 0x000DB28F
		internal virtual Label Label43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x000DD098 File Offset: 0x000DB298
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x000DD0A2 File Offset: 0x000DB2A2
		internal virtual Label Label44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x000DD0AB File Offset: 0x000DB2AB
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x000DD0B5 File Offset: 0x000DB2B5
		internal virtual Label Label45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x000DD0BE File Offset: 0x000DB2BE
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x000DD0C8 File Offset: 0x000DB2C8
		internal virtual Label Label46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x000DD0D1 File Offset: 0x000DB2D1
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x000DD0DB File Offset: 0x000DB2DB
		internal virtual Label Label47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x000DD0E4 File Offset: 0x000DB2E4
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x000DD0EE File Offset: 0x000DB2EE
		internal virtual Label Label48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x000DD0F7 File Offset: 0x000DB2F7
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x000DD101 File Offset: 0x000DB301
		internal virtual Label Label49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x000DD10A File Offset: 0x000DB30A
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x000DD114 File Offset: 0x000DB314
		internal virtual Label lblcorteanteriorefectivofinal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x000DD11D File Offset: 0x000DB31D
		// (set) Token: 0x06000E36 RID: 3638 RVA: 0x000DD127 File Offset: 0x000DB327
		internal virtual Label lblcorteanteriorsaldo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x000DD130 File Offset: 0x000DB330
		// (set) Token: 0x06000E38 RID: 3640 RVA: 0x000DD13A File Offset: 0x000DB33A
		internal virtual Label lblcorteanteriorpropinas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x000DD143 File Offset: 0x000DB343
		// (set) Token: 0x06000E3A RID: 3642 RVA: 0x000DD14D File Offset: 0x000DB34D
		internal virtual Label lblcorteanteriorretirosefectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x000DD156 File Offset: 0x000DB356
		// (set) Token: 0x06000E3C RID: 3644 RVA: 0x000DD160 File Offset: 0x000DB360
		internal virtual Label lblcorteanteriordepositosenefectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x000DD169 File Offset: 0x000DB369
		// (set) Token: 0x06000E3E RID: 3646 RVA: 0x000DD173 File Offset: 0x000DB373
		internal virtual Label lblcorteanteriorotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x000DD17C File Offset: 0x000DB37C
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x000DD186 File Offset: 0x000DB386
		internal virtual Label lblcorteanteriorvales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x000DD18F File Offset: 0x000DB38F
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x000DD199 File Offset: 0x000DB399
		internal virtual Label lblcorteefectivoanterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x000DD1A2 File Offset: 0x000DB3A2
		// (set) Token: 0x06000E44 RID: 3652 RVA: 0x000DD1AC File Offset: 0x000DB3AC
		internal virtual Label lblcortetarjetaanterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x000DD1B5 File Offset: 0x000DB3B5
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x000DD1BF File Offset: 0x000DB3BF
		internal virtual Label Label38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x000DD1C8 File Offset: 0x000DB3C8
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x000DD1D2 File Offset: 0x000DB3D2
		internal virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x000DD1DB File Offset: 0x000DB3DB
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x000DD1E5 File Offset: 0x000DB3E5
		internal virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x000DD1EE File Offset: 0x000DB3EE
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x000DD1F8 File Offset: 0x000DB3F8
		internal virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x000DD201 File Offset: 0x000DB401
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x000DD20B File Offset: 0x000DB40B
		internal virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x000DD214 File Offset: 0x000DB414
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x000DD21E File Offset: 0x000DB41E
		internal virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x000DD227 File Offset: 0x000DB427
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x000DD231 File Offset: 0x000DB431
		internal virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x000DD23A File Offset: 0x000DB43A
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x000DD244 File Offset: 0x000DB444
		internal virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x000DD24D File Offset: 0x000DB44D
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x000DD257 File Offset: 0x000DB457
		internal virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x000DD260 File Offset: 0x000DB460
		// (set) Token: 0x06000E58 RID: 3672 RVA: 0x000DD26A File Offset: 0x000DB46A
		internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x000DD273 File Offset: 0x000DB473
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x000DD280 File Offset: 0x000DB480
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

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x000DD2C3 File Offset: 0x000DB4C3
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x000DD2CD File Offset: 0x000DB4CD
		internal virtual DataGridView DataGridProductosElimiminar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x000DD2D6 File Offset: 0x000DB4D6
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x000DD2E0 File Offset: 0x000DB4E0
		internal virtual ComboBox cmbxSerie { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x000DD2E9 File Offset: 0x000DB4E9
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x000DD2F3 File Offset: 0x000DB4F3
		internal virtual Label Label54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x000DD2FC File Offset: 0x000DB4FC
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x000DD306 File Offset: 0x000DB506
		internal virtual Label lblfechayhora { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x000DD30F File Offset: 0x000DB50F
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x000DD31C File Offset: 0x000DB51C
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

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x000DD35F File Offset: 0x000DB55F
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x000DD369 File Offset: 0x000DB569
		internal virtual Label lblidturnodelticket { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x000DD372 File Offset: 0x000DB572
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x000DD37C File Offset: 0x000DB57C
		internal virtual Label lblidproductonew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x000DD385 File Offset: 0x000DB585
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x000DD390 File Offset: 0x000DB590
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x000DD3D3 File Offset: 0x000DB5D3
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x000DD3DD File Offset: 0x000DB5DD
		internal virtual Panel Panel13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x000DD3E6 File Offset: 0x000DB5E6
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x000DD3F0 File Offset: 0x000DB5F0
		internal virtual PictureBox PictureBox9
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox9;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox9_Click);
				PictureBox pictureBox = this._PictureBox9;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox9 = value;
				pictureBox = this._PictureBox9;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x000DD433 File Offset: 0x000DB633
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x000DD440 File Offset: 0x000DB640
		internal virtual PictureBox PictureBox10
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox10;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox10_Click);
				PictureBox pictureBox = this._PictureBox10;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox10 = value;
				pictureBox = this._PictureBox10;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x000DD483 File Offset: 0x000DB683
		// (set) Token: 0x06000E72 RID: 3698 RVA: 0x000DD48D File Offset: 0x000DB68D
		internal virtual Label lbleditarturnos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x000DD496 File Offset: 0x000DB696
		// (set) Token: 0x06000E74 RID: 3700 RVA: 0x000DD4A0 File Offset: 0x000DB6A0
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

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x000DD4E3 File Offset: 0x000DB6E3
		// (set) Token: 0x06000E76 RID: 3702 RVA: 0x000DD4F0 File Offset: 0x000DB6F0
		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return this._Button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button4_Click);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x000DD533 File Offset: 0x000DB733
		// (set) Token: 0x06000E78 RID: 3704 RVA: 0x000DD540 File Offset: 0x000DB740
		internal virtual Button Button5
		{
			[CompilerGenerated]
			get
			{
				return this._Button5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button5_Click);
				Button button = this._Button5;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button5 = value;
				button = this._Button5;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x000DD583 File Offset: 0x000DB783
		// (set) Token: 0x06000E7A RID: 3706 RVA: 0x000DD58D File Offset: 0x000DB78D
		internal virtual CheckBox CheckBoxCuentasCanceladas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x000DD596 File Offset: 0x000DB796
		// (set) Token: 0x06000E7C RID: 3708 RVA: 0x000DD5A0 File Offset: 0x000DB7A0
		internal virtual Panel Panel14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x000DD5A9 File Offset: 0x000DB7A9
		// (set) Token: 0x06000E7E RID: 3710 RVA: 0x000DD5B3 File Offset: 0x000DB7B3
		internal virtual Label lblAfectadboreal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x000DD5BC File Offset: 0x000DB7BC
		// (set) Token: 0x06000E80 RID: 3712 RVA: 0x000DD5C6 File Offset: 0x000DB7C6
		internal virtual Label lbltipobarrido { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x000DD5CF File Offset: 0x000DB7CF
		// (set) Token: 0x06000E82 RID: 3714 RVA: 0x000DD5D9 File Offset: 0x000DB7D9
		internal virtual Label lblfecha_btm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x000DD5E2 File Offset: 0x000DB7E2
		// (set) Token: 0x06000E84 RID: 3716 RVA: 0x000DD5EC File Offset: 0x000DB7EC
		internal virtual Button Button6
		{
			[CompilerGenerated]
			get
			{
				return this._Button6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button6_Click);
				EventHandler value3 = new EventHandler(this.Button6_DoubleClick);
				Button button = this._Button6;
				if (button != null)
				{
					button.Click -= value2;
					button.DoubleClick -= value3;
				}
				this._Button6 = value;
				button = this._Button6;
				if (button != null)
				{
					button.Click += value2;
					button.DoubleClick += value3;
				}
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x000DD64A File Offset: 0x000DB84A
		// (set) Token: 0x06000E86 RID: 3718 RVA: 0x000DD654 File Offset: 0x000DB854
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

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x000DD697 File Offset: 0x000DB897
		// (set) Token: 0x06000E88 RID: 3720 RVA: 0x000DD6A1 File Offset: 0x000DB8A1
		internal virtual TextBox txtFacturaPUB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x000DD6AA File Offset: 0x000DB8AA
		// (set) Token: 0x06000E8A RID: 3722 RVA: 0x000DD6B4 File Offset: 0x000DB8B4
		internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x000DD6BD File Offset: 0x000DB8BD
		// (set) Token: 0x06000E8C RID: 3724 RVA: 0x000DD6C7 File Offset: 0x000DB8C7
		internal virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x000DD6D0 File Offset: 0x000DB8D0
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x000DD6DA File Offset: 0x000DB8DA
		internal virtual Label Label50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x000DD6E3 File Offset: 0x000DB8E3
		// (set) Token: 0x06000E90 RID: 3728 RVA: 0x000DD6ED File Offset: 0x000DB8ED
		internal virtual Label Label53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x000DD6F6 File Offset: 0x000DB8F6
		// (set) Token: 0x06000E92 RID: 3730 RVA: 0x000DD700 File Offset: 0x000DB900
		internal virtual Label Label55 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x000DD709 File Offset: 0x000DB909
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x000DD713 File Offset: 0x000DB913
		internal virtual Label lblfacturapubnew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x000DD71C File Offset: 0x000DB91C
		// (set) Token: 0x06000E96 RID: 3734 RVA: 0x000DD726 File Offset: 0x000DB926
		internal virtual Label lblventasinfacturarnew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x000DD72F File Offset: 0x000DB92F
		// (set) Token: 0x06000E98 RID: 3736 RVA: 0x000DD739 File Offset: 0x000DB939
		internal virtual Label lblventafacturanew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x000DD742 File Offset: 0x000DB942
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x000DD74C File Offset: 0x000DB94C
		internal virtual Label lblfacturapub { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x000DD755 File Offset: 0x000DB955
		// (set) Token: 0x06000E9C RID: 3740 RVA: 0x000DD75F File Offset: 0x000DB95F
		internal virtual Label lblventasinfacturarcorte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x000DD768 File Offset: 0x000DB968
		// (set) Token: 0x06000E9E RID: 3742 RVA: 0x000DD772 File Offset: 0x000DB972
		internal virtual Label lblventaFacturada { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x000DD77B File Offset: 0x000DB97B
		// (set) Token: 0x06000EA0 RID: 3744 RVA: 0x000DD785 File Offset: 0x000DB985
		internal virtual Label Label60 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x000DD78E File Offset: 0x000DB98E
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x000DD798 File Offset: 0x000DB998
		internal virtual Label Label61 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x000DD7A1 File Offset: 0x000DB9A1
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x000DD7AB File Offset: 0x000DB9AB
		internal virtual Label Label62 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x000DD7B4 File Offset: 0x000DB9B4
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x000DD7BE File Offset: 0x000DB9BE
		internal virtual Label Label59 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x000DD7C7 File Offset: 0x000DB9C7
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x000DD7D1 File Offset: 0x000DB9D1
		internal virtual Label Label58 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x000DD7DA File Offset: 0x000DB9DA
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x000DD7E4 File Offset: 0x000DB9E4
		internal virtual Label Label57 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x000DD7ED File Offset: 0x000DB9ED
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x000DD7F7 File Offset: 0x000DB9F7
		internal virtual CheckBox chkNotaConsumo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x000DD800 File Offset: 0x000DBA00
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x000DD80A File Offset: 0x000DBA0A
		internal virtual Label lblCOdigoUnicoCorte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x000DD813 File Offset: 0x000DBA13
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x000DD81D File Offset: 0x000DBA1D
		internal virtual Panel PanelVerProductos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x000DD826 File Offset: 0x000DBA26
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x000DD830 File Offset: 0x000DBA30
		internal virtual Panel Panel16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x000DD839 File Offset: 0x000DBA39
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x000DD844 File Offset: 0x000DBA44
		internal virtual DataGridView dgvVerProductos
		{
			[CompilerGenerated]
			get
			{
				return this._dgvVerProductos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgvVerProductos_CellContentClick_1);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.dgvVerProductos_CellDoubleClick);
				DataGridView dgvVerProductos = this._dgvVerProductos;
				if (dgvVerProductos != null)
				{
					dgvVerProductos.CellContentClick -= value2;
					dgvVerProductos.CellDoubleClick -= value3;
				}
				this._dgvVerProductos = value;
				dgvVerProductos = this._dgvVerProductos;
				if (dgvVerProductos != null)
				{
					dgvVerProductos.CellContentClick += value2;
					dgvVerProductos.CellDoubleClick += value3;
				}
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x000DD8A2 File Offset: 0x000DBAA2
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x000DD8AC File Offset: 0x000DBAAC
		internal virtual Panel Panel17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x000DD8B5 File Offset: 0x000DBAB5
		// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x000DD8BF File Offset: 0x000DBABF
		internal virtual Label lblnumerodefila { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x000DD8C8 File Offset: 0x000DBAC8
		// (set) Token: 0x06000EBA RID: 3770 RVA: 0x000DD8D4 File Offset: 0x000DBAD4
		internal virtual TextBox TextBox1
		{
			[CompilerGenerated]
			get
			{
				return this._TextBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBox1_TextChanged_1);
				TextBox textBox = this._TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				this._TextBox1 = value;
				textBox = this._TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x000DD917 File Offset: 0x000DBB17
		// (set) Token: 0x06000EBC RID: 3772 RVA: 0x000DD921 File Offset: 0x000DBB21
		internal virtual Label Label56 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x000DD92A File Offset: 0x000DBB2A
		// (set) Token: 0x06000EBE RID: 3774 RVA: 0x000DD934 File Offset: 0x000DBB34
		internal virtual PictureBox PictureBox12
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox12;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox12_Click_1);
				PictureBox pictureBox = this._PictureBox12;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox12 = value;
				pictureBox = this._PictureBox12;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x000DD977 File Offset: 0x000DBB77
		// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x000DD981 File Offset: 0x000DBB81
		internal virtual Panel Panel15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x000DD98A File Offset: 0x000DBB8A
		// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x000DD994 File Offset: 0x000DBB94
		internal virtual PictureBox PictureBox11
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox11;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox11_Click_1);
				PictureBox pictureBox = this._PictureBox11;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox11 = value;
				pictureBox = this._PictureBox11;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x000DD9D7 File Offset: 0x000DBBD7
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			base.Hide();
			this.PanelAplicar.Visible = false;
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x000DD9F0 File Offset: 0x000DBBF0
		private void llenaCombos()
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			this.cmbxEmpresa.Items.Clear();
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
			this.cmbxTipo.Items.Add("Sustituir Productos");
			sqlDataReader.Close();
			this.cmbxTipo.SelectedIndex = 0;
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

		// Token: 0x06000EC5 RID: 3781 RVA: 0x000DDB50 File Offset: 0x000DBD50
		private void FrmRemplazarProductos_Load(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "select i from H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string left = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					bool flag = Operators.CompareString(left, "0", false) != 0;
					if (flag)
					{
						this.btnVistaPrevia.Enabled = false;
						this.llenaCombos();
						this.iniciaGridFolio();
						this.MostrarPRoductos();
						this.DoubleBufferedASD(this.dgvNotas, true);
						this.DoubleBufferedASD(this.DataGridCheques, true);
						this.DoubleBufferedASD(this.dgvProdNuevos, true);
						this.PanelAplicar.Visible = false;
						this.PanelCheqdetalle.Visible = false;
						this.Panelvercortes.Visible = false;
						this.cmbxSerie.Enabled = false;
						this.PanelVerProductos.Visible = false;
						this.habilitaControles(false);
						this.dgvNotas.Enabled = false;
						this.PanelChequesproductos.Visible = false;
						this.txtBuscarProducto.Enabled = false;
						this.PanelAsignarProducto.Visible = false;
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
						this.cmbxSerie.Text = "Todas";
						this.cmbAnio.Enabled = true;
						this.DataGridCheques.ClearSelection();
						this.dgvNotas.ClearSelection();
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
						this.BtnHorario.Visible = false;
						this.lbleditarturnos.Visible = false;
					}
					bool flag2 = Operators.CompareString(left, "0", false) == 0;
					if (flag2)
					{
						this.habilitaControles(false);
						this.iniciaGridFolio();
						this.llenaCombos();
						this.dateHoraFin.Format = DateTimePickerFormat.Custom;
						this.dateHoraFin.CustomFormat = "hh:mm:ss tt";
						this.dateHoraIni.Format = DateTimePickerFormat.Custom;
						this.dateHoraIni.CustomFormat = "hh:mm:ss tt";
						this.dateFechaIni.Text = Conversions.ToString(this.dateFechaIni.MinDate);
						this.dateFechaFin.Text = Conversions.ToString(this.dateFechaFin.MinDate);
						this.btnVistaPrevia.Text = "Vista Previa";
						this.cmbAnio.Enabled = false;
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
						this.BtnHorario.Visible = false;
						this.lbleditarturnos.Visible = false;
						this.PanelAplicar.Visible = false;
						this.PanelCheqdetalle.Visible = false;
						this.Panelvercortes.Visible = false;
						this.btnVistaPrevia.Enabled = false;
						this.cmbxSerie.Enabled = false;
						this.PanelVerProductos.Visible = false;
						this.habilitaControles(false);
						this.dgvNotas.Enabled = false;
						this.PanelChequesproductos.Visible = false;
						this.txtBuscarProducto.Enabled = false;
						this.PanelAsignarProducto.Visible = false;
						Interaction.MsgBox("Necesitas asignar las formas de pago dentro de Parametros,para poder utilizar esta funcion!", MsgBoxStyle.OkOnly, null);
					}
				}
			}
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000DE044 File Offset: 0x000DC244
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x000DE078 File Offset: 0x000DC278
		private void habilitaControles(bool boolDeasbilita)
		{
			if (boolDeasbilita)
			{
				this.groupParametros.Enabled = true;
				this.groupPeriodo.Enabled = true;
				this.dateHoraFin.Enabled = false;
				this.dateHoraIni.Enabled = false;
				this.dateFechaIni.Enabled = true;
				this.dateFechaFin.Enabled = true;
			}
			else
			{
				this.groupParametros.Enabled = false;
				this.ComboBox1.Enabled = false;
				this.dateFechaFin.Enabled = false;
				this.dateFechaIni.Enabled = false;
				this.dateHoraFin.Enabled = false;
				this.dateHoraIni.Enabled = false;
			}
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x000DE12C File Offset: 0x000DC32C
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
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x000DE408 File Offset: 0x000DC608
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
						this.dgvNotas.Enabled = true;
						this.txtBuscarProducto.Enabled = true;
						this.btnVistaPrevia.Enabled = false;
						this.cmbxSerie.Enabled = true;
						this.BtnHorario.Visible = true;
						this.lbleditarturnos.Visible = true;
						try
						{
							foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								bool flag2 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells["ID Producto."].Value, "", false);
								if (flag2)
								{
									this.btnVistaPrevia.Enabled = true;
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
						this.dateFechaIni.MaxDate = new DateTime(2100, 1, 1);
						this.dateFechaFin.MaxDate = new DateTime(2100, 1, 1);
						this.dateFechaIni.MinDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), Conversions.ToInteger(Tools.Gm(this.ComboBox1.Text)), 1);
						this.dateFechaFin.MinDate = new DateTime(Conversions.ToInteger(this.cmbAnio.Text), Conversions.ToInteger(Tools.Gm(this.ComboBox1.Text)), 1);
						bool flag3 = Operators.CompareString(Tools.Gm(this.ComboBox1.Text), "12", false) == 0;
						if (flag3)
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

		// Token: 0x06000ECA RID: 3786 RVA: 0x000DE7B0 File Offset: 0x000DC9B0
		private void iniciaGridFolio()
		{
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			DataGridViewButtonColumn dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
			this.dgvNotas.Rows.Clear();
			this.dgvNotas.ColumnCount = 10;
			this.dgvNotas.Columns[0].Name = "ID Producto";
			this.dgvNotas.Columns[0].Visible = true;
			this.dgvNotas.Columns[0].Width = 60;
			this.dgvNotas.Columns[1].Name = "Descripcion";
			this.dgvNotas.Columns[1].Width = 230;
			this.dgvNotas.Columns[2].Name = "Precio";
			this.dgvNotas.Columns[2].Width = 80;
			this.dgvNotas.Columns[3].Name = "Precio sin impuestos";
			this.dgvNotas.Columns[3].Width = 80;
			this.dgvNotas.Columns[4].Name = "Impuesto.";
			this.dgvNotas.Columns[4].Width = 80;
			this.dgvNotas.Columns[5].Name = "ID Producto.";
			this.dgvNotas.Columns[5].Width = 60;
			this.dgvNotas.Columns[6].Name = "Producto a sustituir";
			this.dgvNotas.Columns[6].Width = 230;
			this.dgvNotas.Columns[7].Name = "Precio a sustituir";
			this.dgvNotas.Columns[7].Width = 80;
			this.dgvNotas.Columns[8].Name = "Precio sin impuestos a sustitur";
			this.dgvNotas.Columns[8].Width = 80;
			this.dgvNotas.Columns[9].Name = "Estado";
			this.dgvNotas.Columns[9].Width = 80;
			this.dgvNotas.Columns[9].Visible = false;
			dataGridViewButtonColumn2.Width = 60;
			dataGridViewButtonColumn2.Name = "Elegir Prod.";
			this.dgvNotas.Columns.Add(dataGridViewButtonColumn2);
			dataGridViewButtonColumn.Width = 60;
			dataGridViewButtonColumn.Name = "Borrar";
			this.dgvNotas.Columns.Add(dataGridViewButtonColumn);
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x000DEA84 File Offset: 0x000DCC84
		public void MostrarPRoductos()
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = "select a.idproducto ,b.descripcion, a.precio , a.preciosinimpuestos , a.impuesto1 ,a.bloqueado from productosdetalle A \r\n                    Inner join productos B on b.idproducto = a.idproducto order by a.idproducto asc";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text2 = Conversions.ToString(sqlDataReader[0]);
					string text3 = Conversions.ToString(sqlDataReader[1]);
					double num = Conversions.ToDouble(sqlDataReader[2]);
					double num2 = Conversions.ToDouble(sqlDataReader[3]);
					string text4 = Conversions.ToString(sqlDataReader[4]);
					string text5 = Conversions.ToString(sqlDataReader[5]);
					bool flag = Operators.ConditionalCompareObjectEqual(sqlDataReader[5], false, false);
					if (flag)
					{
						text5 = "0";
					}
					else
					{
						text5 = "1";
					}
					this.dgvNotas.Rows.Add(new object[]
					{
						text2,
						text3,
						num.ToString("N2"),
						num2.ToString("N2"),
						text4,
						"",
						"",
						"",
						"",
						text5
					});
				}
			}
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Estado"].Value, "0", false);
					if (flag2)
					{
						dataGridViewRow.DefaultCellStyle.BackColor = Color.White;
						bool flag3 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Precio"].Value, "0.00", false);
						if (flag3)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.Coral;
						}
					}
					else
					{
						dataGridViewRow.Cells["Estado"].Value = "1";
						dataGridViewRow.DefaultCellStyle.BackColor = Color.Yellow;
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
			text = "SELECT TOP 1 A from N";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool hasRows2 = sqlDataReader.HasRows;
			if (hasRows2)
			{
				try
				{
					foreach (object obj2 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
						string text6 = Conversions.ToString(dataGridViewRow2.Cells["ID Producto"].Value);
						bool flag4 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow2.Cells["ID Producto"].Value, "", false);
						if (flag4)
						{
							text = "SELECT a , b from N where a = '" + Tools.Encriptar(text6.ToString().Trim()) + "'";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
							bool hasRows3 = sqlDataReader.HasRows;
							if (hasRows3)
							{
								while (sqlDataReader.Read())
								{
									string text7 = Conversions.ToString(sqlDataReader[1]);
									text = "select a.idproducto ,b.descripcion, a.precio , a.preciosinimpuestos , a.impuesto1 ,a.bloqueado from productosdetalle A \r\n                                    Inner join productos B on b.idproducto = a.idproducto where a.idproducto = '" + Tools.Desencriptar(text7.ToString().Trim()) + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
									bool hasRows4 = sqlDataReader.HasRows;
									if (hasRows4)
									{
										while (sqlDataReader.Read())
										{
											string value = Conversions.ToString(sqlDataReader[1]);
											double num3 = Conversions.ToDouble(sqlDataReader[2]);
											double num4 = Conversions.ToDouble(sqlDataReader[3]);
											dataGridViewRow2.Cells["ID Producto."].Value = Tools.Desencriptar(text7.ToString().Trim());
											dataGridViewRow2.Cells["Producto a sustituir"].Value = value;
											dataGridViewRow2.Cells["Precio a sustituir"].Value = num3.ToString("N2");
											dataGridViewRow2.Cells["Precio sin impuestos a sustitur"].Value = num4.ToString("N2");
											dataGridViewRow2.DefaultCellStyle.BackColor = Color.Red;
											dataGridViewRow2.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
										}
									}
								}
							}
							sqlDataReader.Close();
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
			this.dgvNotas.RowsDefaultCellStyle.ForeColor = Color.Black;
			this.dgvNotas.DefaultCellStyle.BackColor = Color.White;
			sqlDataReader.Close();
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x000DEF88 File Offset: 0x000DD188
		private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 11;
			if (flag)
			{
				string text = Conversions.ToString(this.dgvNotas.Rows[rowIndex].Cells["ID Producto"].Value);
				string query_conn = "DELETE FROM N where a = '" + Tools.Encriptar(text.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.dgvNotas.Rows[rowIndex].Cells["ID Producto."].Value = "";
				this.dgvNotas.Rows[rowIndex].Cells["Producto a sustituir"].Value = "";
				this.dgvNotas.Rows[rowIndex].Cells["Precio a sustituir"].Value = "";
				this.dgvNotas.Rows[rowIndex].Cells["Precio sin impuestos a sustitur"].Value = "";
				this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
				this.dgvNotas.Rows[rowIndex].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.875f, FontStyle.Regular);
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag2 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Estado"].Value, "0", false), Operators.CompareObjectEqual(dataGridViewRow.Cells["ID Producto."].Value, "", false)));
						if (flag2)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.White;
							bool flag3 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Precio"].Value, "0.00", false);
							if (flag3)
							{
								dataGridViewRow.DefaultCellStyle.BackColor = Color.Coral;
							}
						}
						bool flag4 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Estado"].Value, "1", false), Operators.CompareObjectEqual(dataGridViewRow.Cells["ID Producto."].Value, "", false)));
						if (flag4)
						{
							dataGridViewRow.Cells["Estado"].Value = "1";
							dataGridViewRow.DefaultCellStyle.BackColor = Color.Yellow;
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
			bool flag5 = e.RowIndex >= 0 && e.ColumnIndex == 10;
			if (flag5)
			{
				string text2 = Conversions.ToString(this.dgvNotas.Rows[rowIndex].Cells["ID Producto"].Value);
				this.lblidproducto.Text = text2;
				this.dgvNotas.Enabled = false;
				this.PanelChequesproductos.Visible = false;
				this.Panel1.Visible = true;
				this.PanelAsignarProducto.Visible = true;
				this.iniciaGridNuevoProducto();
				this.MostrarPRoductos1();
				bool flag6 = this.dgvNotas.SelectedRows.Count > 0;
				if (flag6)
				{
					int index = this.dgvNotas.CurrentRow.Index;
					this.lnlnumerodefila.Text = Conversions.ToString(index);
				}
			}
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x000DF38C File Offset: 0x000DD58C
		private void iniciaGridChequesProducto()
		{
			this.DoubleBufferedASD(this.DataGridCheques, true);
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			this.DataGridCheques.Rows.Clear();
			this.DataGridCheques.ColumnCount = 16;
			this.DataGridCheques.Columns[0].Name = "id_folio";
			this.DataGridCheques.Columns[0].Visible = false;
			this.DataGridCheques.Columns[1].Name = "Serie";
			this.DataGridCheques.Columns[1].Visible = true;
			this.DataGridCheques.Columns[1].Width = 70;
			this.DataGridCheques.Columns[2].Name = "Folio Cuenta";
			this.DataGridCheques.Columns[2].Width = 70;
			this.DataGridCheques.Columns[3].Name = "Folio Nota Consumo";
			this.DataGridCheques.Columns[3].Width = 70;
			this.DataGridCheques.Columns[4].Name = "Mesa";
			this.DataGridCheques.Columns[4].Width = 70;
			this.DataGridCheques.Columns[5].Name = "Fecha";
			this.DataGridCheques.Columns[5].Width = 170;
			this.DataGridCheques.Columns[6].Name = "Descuento %";
			this.DataGridCheques.Columns[6].Width = 90;
			this.DataGridCheques.Columns[7].Name = "Facturado";
			this.DataGridCheques.Columns[7].Width = 70;
			this.DataGridCheques.Columns[8].Name = "Total Original";
			this.DataGridCheques.Columns[8].Width = 90;
			this.DataGridCheques.Columns[9].Name = "Total Prod. Encontrados";
			this.DataGridCheques.Columns[9].Width = 90;
			this.DataGridCheques.Columns[10].Name = "Total con Descuento";
			this.DataGridCheques.Columns[10].Width = 70;
			this.DataGridCheques.Columns[11].Name = "Efectivo";
			this.DataGridCheques.Columns[11].Width = 70;
			this.DataGridCheques.Columns[12].Name = "Tarjeta";
			this.DataGridCheques.Columns[12].Width = 70;
			this.DataGridCheques.Columns[13].Name = "Vales";
			this.DataGridCheques.Columns[13].Width = 70;
			this.DataGridCheques.Columns[14].Name = "Otros";
			this.DataGridCheques.Columns[14].Width = 70;
			this.DataGridCheques.Columns[15].Name = "Propina";
			this.DataGridCheques.Columns[15].Width = 70;
			dataGridViewButtonColumn.Width = 70;
			dataGridViewButtonColumn.Name = "Ver Ticket";
			this.DataGridCheques.Columns.Add(dataGridViewButtonColumn);
			dataGridViewCheckBoxColumn.Width = 70;
			dataGridViewCheckBoxColumn.Name = "Modificar";
			this.DataGridCheques.Columns.Add(dataGridViewCheckBoxColumn);
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000DF79C File Offset: 0x000DD99C
		public void MostrarCuentasAEditar()
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			int num = 0;
			int num2 = 0;
			string text = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
			string text2 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
			string text3 = this.cmbxSerie.Text;
			bool flag = Operators.CompareString(text3, "Todas", false) == 0;
			double num11;
			double num12;
			double num14;
			double num15;
			double num16;
			double num17;
			double num18;
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
			double num29;
			double num30;
			double num31;
			double num32;
			double num33;
			double num34;
			bool flag89;
			checked
			{
				string text4;
				SqlDataReader sqlDataReader;
				bool flag4;
				if (flag)
				{
					text4 = string.Concat(new string[]
					{
						"Select folio,numcheque ,fecha, Descuento , total , efectivo,tarjeta,vales,otros,propina,totalarticulos,facturado,mesa from cheques where folio In ( Select foliodet from cheqdet where idproducto='",
						this.lblidproducto.Text,
						"') and \r\n                    idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
						text,
						"' AND '",
						text2,
						"' AND \r\n                    cierre is not null and idempresa='",
						Tools.id_Empresa,
						"')\r\n                    and idempresa='",
						Tools.id_Empresa,
						"' order by seriefolio,numcheque"
					});
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
					bool hasRows = sqlDataReader.HasRows;
					if (hasRows)
					{
						while (sqlDataReader.Read())
						{
							string text5 = Conversions.ToString(sqlDataReader[0]);
							int num3 = Conversions.ToInteger(sqlDataReader[1]);
							DateTime dateTime = Conversions.ToDate(sqlDataReader[2]);
							string text6 = Conversions.ToString(sqlDataReader[3]);
							double num4 = Conversions.ToDouble(sqlDataReader[4]);
							double num5 = Conversions.ToDouble(sqlDataReader[5]);
							double num6 = Conversions.ToDouble(sqlDataReader[6]);
							double num7 = Conversions.ToDouble(sqlDataReader[7]);
							double num8 = Conversions.ToDouble(sqlDataReader[8]);
							double num9 = Conversions.ToDouble(sqlDataReader[9]);
							string text7 = Conversions.ToString(sqlDataReader[10]);
							bool flag2 = Operators.ConditionalCompareObjectEqual(sqlDataReader[11], true, false);
							string text8;
							if (flag2)
							{
								text8 = "Si";
							}
							else
							{
								text8 = "No";
							}
							string text9 = Conversions.ToString(sqlDataReader[12]);
							bool flag3 = this.chkTarjCred.Checked & num6 > 0.0;
							if (flag3)
							{
								flag4 = true;
							}
							bool flag5 = this.chkVales.Checked & num7 > 0.0;
							if (flag5)
							{
								flag4 = true;
							}
							bool flag6 = this.chkOtros.Checked & num8 > 0.0;
							if (flag6)
							{
								flag4 = true;
							}
							bool flag7 = this.chkEfectivo.Checked & num5 > 0.0;
							if (flag7)
							{
								flag4 = true;
							}
							bool flag8 = this.chkFacturada.Checked & Operators.CompareString(text8, "Si", false) == 0;
							if (flag8)
							{
								flag4 = true;
							}
							bool flag9 = !this.chkTarjCred.Checked & num6 > 0.0;
							if (flag9)
							{
								flag4 = false;
							}
							bool flag10 = !this.chkVales.Checked & num7 > 0.0;
							if (flag10)
							{
								flag4 = false;
							}
							bool flag11 = !this.chkOtros.Checked & num8 > 0.0;
							if (flag11)
							{
								flag4 = false;
							}
							bool flag12 = !this.chkEfectivo.Checked & num5 > 0.0;
							if (flag12)
							{
								flag4 = false;
							}
							bool flag13 = !this.chkFacturada.Checked & Operators.CompareString(text8, "Si", false) == 0;
							if (flag13)
							{
								flag4 = false;
							}
							this.DataGridCheques.Rows.Add(new object[]
							{
								text5,
								num3,
								text9,
								dateTime.ToString(Tools.strFormatoFechaLargo),
								text6,
								text8,
								num4.ToString("N2"),
								"0",
								"0",
								num5.ToString("N2"),
								num6.ToString("N2"),
								num7.ToString("N2"),
								num8.ToString("N2"),
								num9.ToString("N2"),
								"",
								flag4
							});
							num++;
						}
						this.DataGridCheques.RowsDefaultCellStyle.ForeColor = Color.Black;
					}
					sqlDataReader.Close();
				}
				bool flag14 = Operators.CompareString(text3, "Todas", false) != 0;
				if (flag14)
				{
					text4 = string.Concat(new string[]
					{
						"Select folio,numcheque ,fecha, Descuento , total , efectivo,tarjeta,vales,otros,propina,totalarticulos,facturado,mesa from cheques where folio In ( Select foliodet from cheqdet where idproducto='",
						this.lblidproducto.Text,
						"') and \r\n                    idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
						text,
						"' AND '",
						text2,
						"' AND \r\n                    cierre is not null and idempresa='",
						Tools.id_Empresa,
						"')\r\n                    and idempresa='",
						Tools.id_Empresa,
						"' and seriefolio = '",
						text3,
						"' order by numcheque order by seriefolio,numcheque"
					});
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
					bool hasRows2 = sqlDataReader.HasRows;
					if (hasRows2)
					{
						while (sqlDataReader.Read())
						{
							string text5 = Conversions.ToString(sqlDataReader[0]);
							int num3 = Conversions.ToInteger(sqlDataReader[1]);
							DateTime dateTime = Conversions.ToDate(sqlDataReader[2]);
							string text6 = Conversions.ToString(sqlDataReader[3]);
							double num4 = Conversions.ToDouble(sqlDataReader[4]);
							double num5 = Conversions.ToDouble(sqlDataReader[5]);
							double num6 = Conversions.ToDouble(sqlDataReader[6]);
							double num7 = Conversions.ToDouble(sqlDataReader[7]);
							double num8 = Conversions.ToDouble(sqlDataReader[8]);
							double num9 = Conversions.ToDouble(sqlDataReader[9]);
							string text7 = Conversions.ToString(sqlDataReader[10]);
							bool flag15 = Operators.ConditionalCompareObjectEqual(sqlDataReader[11], true, false);
							string text8;
							if (flag15)
							{
								text8 = "Si";
							}
							else
							{
								text8 = "No";
							}
							string text9 = Conversions.ToString(sqlDataReader[12]);
							bool flag16 = this.chkTarjCred.Checked & num6 > 0.0;
							if (flag16)
							{
								flag4 = true;
							}
							bool flag17 = this.chkVales.Checked & num7 > 0.0;
							if (flag17)
							{
								flag4 = true;
							}
							bool flag18 = this.chkOtros.Checked & num8 > 0.0;
							if (flag18)
							{
								flag4 = true;
							}
							bool flag19 = this.chkEfectivo.Checked & num5 > 0.0;
							if (flag19)
							{
								flag4 = true;
							}
							bool flag20 = this.chkFacturada.Checked & Operators.CompareString(text8, "Si", false) == 0;
							if (flag20)
							{
								flag4 = true;
							}
							bool flag21 = !this.chkTarjCred.Checked & num6 > 0.0;
							if (flag21)
							{
								flag4 = false;
							}
							bool flag22 = !this.chkVales.Checked & num7 > 0.0;
							if (flag22)
							{
								flag4 = false;
							}
							bool flag23 = !this.chkOtros.Checked & num8 > 0.0;
							if (flag23)
							{
								flag4 = false;
							}
							bool flag24 = !this.chkEfectivo.Checked & num5 > 0.0;
							if (flag24)
							{
								flag4 = false;
							}
							bool flag25 = !this.chkFacturada.Checked & Operators.CompareString(text8, "Si", false) == 0;
							if (flag25)
							{
								flag4 = false;
							}
							this.DataGridCheques.Rows.Add(new object[]
							{
								text5,
								num3,
								text9,
								dateTime.ToString(Tools.strFormatoFechaLargo),
								text6,
								text8,
								num4.ToString("N2"),
								"0",
								"0",
								num5.ToString("N2"),
								num6.ToString("N2"),
								num7.ToString("N2"),
								num8.ToString("N2"),
								num9.ToString("N2"),
								"",
								flag4
							});
							num++;
						}
						this.DataGridCheques.RowsDefaultCellStyle.ForeColor = Color.Black;
					}
					sqlDataReader.Close();
				}
				try
				{
					foreach (object obj in ((IEnumerable)this.DataGridCheques.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag26 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Modificar"].Value, true, false);
						if (flag26)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
							string str = Conversions.ToString(dataGridViewRow.Cells["id_folio"].Value);
							num2++;
							double num10 = Conversions.ToDouble(dataGridViewRow.Cells["Total Original"].Value);
							unchecked
							{
								num11 += Conversions.ToDouble(dataGridViewRow.Cells["Total Original"].Value);
								num12 += Conversions.ToDouble(dataGridViewRow.Cells["Propina"].Value);
								text4 = (("select count(*) from cheqdet where idproducto='" + this.lblidproducto.Text + "' and foliodet = " + str) ?? "");
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows3 = sqlDataReader.HasRows;
								if (hasRows3)
								{
									sqlDataReader.Read();
									this.Contadrprodrepetidos = Conversions.ToString(sqlDataReader[0]);
									dataGridViewRow.Cells[8].Value = this.Contadrprodrepetidos;
									dataGridViewRow.Cells[9].Value = (num10 + (-Conversions.ToDouble(this.Contadrprodrepetidos) * this.dblPrecioPodAnterior + this.dblPrecioProdSustituir * Conversions.ToDouble(this.Contadrprodrepetidos))).ToString("N2");
									dataGridViewRow.Cells[15].Value = "";
									double num13;
									num13 += Conversions.ToDouble((num10 + (-Conversions.ToDouble(this.Contadrprodrepetidos) * this.dblPrecioPodAnterior + this.dblPrecioProdSustituir * Conversions.ToDouble(this.Contadrprodrepetidos))).ToString("N2"));
								}
								bool flag27 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Modificar"].Value, true, false), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)));
								if (flag27)
								{
									num14 += Conversions.ToDouble(dataGridViewRow.Cells["Efectivo"].Value);
									num15 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
									text4 = "SELECT i from H";
									sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
									bool flag28 = sqlDataReader.Read();
									if (flag28)
									{
										string text10 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
										text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text10.ToString() + "'";
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
										bool hasRows4 = sqlDataReader.HasRows;
										if (hasRows4)
										{
											while (sqlDataReader.Read())
											{
												string text11 = Conversions.ToString(sqlDataReader[0]);
												string value = Conversions.ToString(sqlDataReader[1]);
												bool flag29 = Conversions.ToDouble(value) == 4.0;
												if (flag29)
												{
													num16 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag30 = Conversions.ToDouble(value) == 3.0;
												if (flag30)
												{
													num17 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag31 = Conversions.ToDouble(value) == 1.0;
												if (flag31)
												{
													num18 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag32 = Conversions.ToDouble(value) == 2.0;
												if (flag32)
												{
													num19 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
											}
										}
										else
										{
											num14 += 0.0;
											num15 += 0.0;
										}
									}
								}
								bool flag33 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)));
								if (flag33)
								{
									num15 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
									num20 += Conversions.ToDouble(dataGridViewRow.Cells["Tarjeta"].Value);
									text4 = "SELECT j from H";
									sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
									bool flag34 = sqlDataReader.Read();
									if (flag34)
									{
										string text12 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
										text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text12.ToString() + "'";
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
										bool hasRows5 = sqlDataReader.HasRows;
										if (hasRows5)
										{
											while (sqlDataReader.Read())
											{
												string text11 = Conversions.ToString(sqlDataReader[0]);
												string value = Conversions.ToString(sqlDataReader[1]);
												bool flag35 = Conversions.ToDouble(value) == 4.0;
												if (flag35)
												{
													num16 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag36 = Conversions.ToDouble(value) == 3.0;
												if (flag36)
												{
													num17 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag37 = Conversions.ToDouble(value) == 1.0;
												if (flag37)
												{
													num18 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag38 = Conversions.ToDouble(value) == 2.0;
												if (flag38)
												{
													num19 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
											}
										}
										else
										{
											num15 += 0.0;
											num20 += 0.0;
										}
									}
								}
								bool flag39 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)));
								if (flag39)
								{
									num15 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
									num21 += Conversions.ToDouble(dataGridViewRow.Cells["Otros"].Value);
									text4 = "SELECT l from H";
									sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
									bool flag40 = sqlDataReader.Read();
									if (flag40)
									{
										string text13 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
										text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text13.ToString() + "'";
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
										bool hasRows6 = sqlDataReader.HasRows;
										if (hasRows6)
										{
											while (sqlDataReader.Read())
											{
												string text11 = Conversions.ToString(sqlDataReader[0]);
												string value = Conversions.ToString(sqlDataReader[1]);
												bool flag41 = Conversions.ToDouble(value) == 4.0;
												if (flag41)
												{
													num16 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag42 = Conversions.ToDouble(value) == 3.0;
												if (flag42)
												{
													num17 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag43 = Conversions.ToDouble(value) == 1.0;
												if (flag43)
												{
													num18 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag44 = Conversions.ToDouble(value) == 2.0;
												if (flag44)
												{
													num19 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
											}
										}
										else
										{
											num15 += 0.0;
											num21 += 0.0;
										}
									}
								}
								bool flag45 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)));
								if (flag45)
								{
									num15 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
									num22 += Conversions.ToDouble(dataGridViewRow.Cells["Vales"].Value);
									text4 = "SELECT k from H";
									sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
									bool flag46 = sqlDataReader.Read();
									if (flag46)
									{
										string text14 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
										text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text14.ToString() + "'";
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
										bool hasRows7 = sqlDataReader.HasRows;
										if (hasRows7)
										{
											while (sqlDataReader.Read())
											{
												string text11 = Conversions.ToString(sqlDataReader[0]);
												string value = Conversions.ToString(sqlDataReader[1]);
												bool flag47 = Conversions.ToDouble(value) == 4.0;
												if (flag47)
												{
													num16 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag48 = Conversions.ToDouble(value) == 3.0;
												if (flag48)
												{
													num17 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag49 = Conversions.ToDouble(value) == 1.0;
												if (flag49)
												{
													num18 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag50 = Conversions.ToDouble(value) == 2.0;
												if (flag50)
												{
													num19 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
											}
										}
										else
										{
											num15 += 0.0;
											num22 += 0.0;
										}
									}
								}
								bool flag51 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Modificar"].Value, true, false), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)));
								if (flag51)
								{
									num15 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
									num20 += Conversions.ToDouble(dataGridViewRow.Cells["Tarjeta"].Value);
									num14 += Conversions.ToDouble(dataGridViewRow.Cells["Efectivo"].Value);
									text4 = "SELECT m from H";
									sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
									bool flag52 = sqlDataReader.Read();
									if (flag52)
									{
										string text15 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
										text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text15.ToString() + "'";
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
										bool hasRows8 = sqlDataReader.HasRows;
										if (hasRows8)
										{
											while (sqlDataReader.Read())
											{
												string text11 = Conversions.ToString(sqlDataReader[0]);
												string value = Conversions.ToString(sqlDataReader[1]);
												bool flag53 = Conversions.ToDouble(value) == 4.0;
												if (flag53)
												{
													num16 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag54 = Conversions.ToDouble(value) == 3.0;
												if (flag54)
												{
													num17 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag55 = Conversions.ToDouble(value) == 1.0;
												if (flag55)
												{
													num18 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag56 = Conversions.ToDouble(value) == 2.0;
												if (flag56)
												{
													num19 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
											}
										}
										else
										{
											num15 += 0.0;
											num20 += 0.0;
											num14 += 0.0;
										}
									}
								}
								bool flag57 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Modificar"].Value, true, false), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)));
								if (flag57)
								{
									num15 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
									num22 += Conversions.ToDouble(dataGridViewRow.Cells["Vales"].Value);
									num14 += Conversions.ToDouble(dataGridViewRow.Cells["Efectivo"].Value);
									text4 = "SELECT m from H";
									sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
									bool flag58 = sqlDataReader.Read();
									if (flag58)
									{
										string text15 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
										text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text15.ToString() + "'";
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
										bool hasRows9 = sqlDataReader.HasRows;
										if (hasRows9)
										{
											while (sqlDataReader.Read())
											{
												string text11 = Conversions.ToString(sqlDataReader[0]);
												string value = Conversions.ToString(sqlDataReader[1]);
												bool flag59 = Conversions.ToDouble(value) == 4.0;
												if (flag59)
												{
													num16 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag60 = Conversions.ToDouble(value) == 3.0;
												if (flag60)
												{
													num17 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag61 = Conversions.ToDouble(value) == 1.0;
												if (flag61)
												{
													num18 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag62 = Conversions.ToDouble(value) == 2.0;
												if (flag62)
												{
													num19 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
											}
										}
										else
										{
											num15 += 0.0;
											num22 += 0.0;
											num14 += 0.0;
										}
									}
								}
								bool flag63 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Modificar"].Value, true, false), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)));
								if (flag63)
								{
									num15 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
									num21 += Conversions.ToDouble(dataGridViewRow.Cells["Otros"].Value);
									num14 += Conversions.ToDouble(dataGridViewRow.Cells["Efectivo"].Value);
									text4 = "SELECT m from H";
									sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
									bool flag64 = sqlDataReader.Read();
									if (flag64)
									{
										string text15 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
										text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text15.ToString() + "'";
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
										bool hasRows10 = sqlDataReader.HasRows;
										if (hasRows10)
										{
											while (sqlDataReader.Read())
											{
												string text11 = Conversions.ToString(sqlDataReader[0]);
												string value = Conversions.ToString(sqlDataReader[1]);
												bool flag65 = Conversions.ToDouble(value) == 4.0;
												if (flag65)
												{
													num16 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag66 = Conversions.ToDouble(value) == 3.0;
												if (flag66)
												{
													num17 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag67 = Conversions.ToDouble(value) == 1.0;
												if (flag67)
												{
													num18 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag68 = Conversions.ToDouble(value) == 2.0;
												if (flag68)
												{
													num19 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
											}
										}
										else
										{
											num15 += 0.0;
											num21 += 0.0;
											num14 += 0.0;
										}
									}
								}
								bool flag69 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)));
								if (flag69)
								{
									num15 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
									num20 += Conversions.ToDouble(dataGridViewRow.Cells["Tarjeta"].Value);
									num22 += Conversions.ToDouble(dataGridViewRow.Cells["Vales"].Value);
									text4 = "SELECT m from H";
									sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
									bool flag70 = sqlDataReader.Read();
									if (flag70)
									{
										string text15 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
										text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text15.ToString() + "'";
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
										bool hasRows11 = sqlDataReader.HasRows;
										if (hasRows11)
										{
											while (sqlDataReader.Read())
											{
												string text11 = Conversions.ToString(sqlDataReader[0]);
												string value = Conversions.ToString(sqlDataReader[1]);
												bool flag71 = Conversions.ToDouble(value) == 4.0;
												if (flag71)
												{
													num16 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag72 = Conversions.ToDouble(value) == 3.0;
												if (flag72)
												{
													num17 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag73 = Conversions.ToDouble(value) == 1.0;
												if (flag73)
												{
													num18 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag74 = Conversions.ToDouble(value) == 2.0;
												if (flag74)
												{
													num19 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
											}
										}
										else
										{
											num15 += 0.0;
											num20 += 0.0;
											num21 += 0.0;
										}
									}
								}
								bool flag75 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)));
								if (flag75)
								{
									num15 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
									num20 += Conversions.ToDouble(dataGridViewRow.Cells["Tarjeta"].Value);
									num21 += Conversions.ToDouble(dataGridViewRow.Cells["Otros"].Value);
									text4 = "SELECT m from H";
									sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
									bool flag76 = sqlDataReader.Read();
									if (flag76)
									{
										string text15 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
										text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text15.ToString() + "'";
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
										bool hasRows12 = sqlDataReader.HasRows;
										if (hasRows12)
										{
											while (sqlDataReader.Read())
											{
												string text11 = Conversions.ToString(sqlDataReader[0]);
												string value = Conversions.ToString(sqlDataReader[1]);
												bool flag77 = Conversions.ToDouble(value) == 4.0;
												if (flag77)
												{
													num16 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag78 = Conversions.ToDouble(value) == 3.0;
												if (flag78)
												{
													num17 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag79 = Conversions.ToDouble(value) == 1.0;
												if (flag79)
												{
													num18 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag80 = Conversions.ToDouble(value) == 2.0;
												if (flag80)
												{
													num19 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
											}
										}
										else
										{
											num15 += 0.0;
											num20 += 0.0;
											num21 += 0.0;
										}
									}
								}
								bool flag81 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)));
								if (flag81)
								{
									num15 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
									num22 += Conversions.ToDouble(dataGridViewRow.Cells["Vales"].Value);
									num21 += Conversions.ToDouble(dataGridViewRow.Cells["Otros"].Value);
									text4 = "SELECT m from H";
									sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
									bool flag82 = sqlDataReader.Read();
									if (flag82)
									{
										string text15 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
										text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text15.ToString() + "'";
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
										bool hasRows13 = sqlDataReader.HasRows;
										if (hasRows13)
										{
											while (sqlDataReader.Read())
											{
												string text11 = Conversions.ToString(sqlDataReader[0]);
												string value = Conversions.ToString(sqlDataReader[1]);
												bool flag83 = Conversions.ToDouble(value) == 4.0;
												if (flag83)
												{
													num16 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag84 = Conversions.ToDouble(value) == 3.0;
												if (flag84)
												{
													num17 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag85 = Conversions.ToDouble(value) == 1.0;
												if (flag85)
												{
													num18 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
												bool flag86 = Conversions.ToDouble(value) == 2.0;
												if (flag86)
												{
													num19 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
												}
											}
										}
										else
										{
											num15 += 0.0;
											num22 += 0.0;
											num21 += 0.0;
										}
									}
								}
								bool flag87 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Facturado"].Value, "Si", false);
								if (flag87)
								{
									num23 += Conversions.ToDouble(dataGridViewRow.Cells["Total Original"].Value);
									num24 += Conversions.ToDouble(dataGridViewRow.Cells["Total con Descuento"].Value);
								}
							}
						}
						else
						{
							bool flag88 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Modificar"].Value, false, false);
							if (flag88)
							{
								this.idnoteprueba = Conversions.ToString(dataGridViewRow.Cells["id_folio"].Value);
								text4 = (("select count(*) from cheqdet where idproducto='" + this.lblidproducto.Text + "' and foliodet = " + this.idnoteprueba) ?? "");
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows14 = sqlDataReader.HasRows;
								if (hasRows14)
								{
									sqlDataReader.Read();
									this.cantidadprodpelon = Conversions.ToString(sqlDataReader[0]);
								}
								dataGridViewRow.DefaultCellStyle.BackColor = Color.White;
								dataGridViewRow.Cells[7].Value = this.cantidadprodpelon;
								dataGridViewRow.Cells[14].Value = "";
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
				text4 = string.Concat(new string[]
				{
					"select case when sum(Total) IS NULL then 0 else sum(Total) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
				bool hasRows15 = sqlDataReader.HasRows;
				if (hasRows15)
				{
					while (sqlDataReader.Read())
					{
						num25 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
				text4 = string.Concat(new string[]
				{
					"select case when sum(Efectivo) IS NULL then 0 else sum(Efectivo) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
				bool hasRows16 = sqlDataReader.HasRows;
				if (hasRows16)
				{
					while (sqlDataReader.Read())
					{
						num26 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
				text4 = string.Concat(new string[]
				{
					"select case when sum(Tarjeta) IS NULL then 0 else sum(Tarjeta) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
				bool hasRows17 = sqlDataReader.HasRows;
				if (hasRows17)
				{
					while (sqlDataReader.Read())
					{
						num27 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
				text4 = string.Concat(new string[]
				{
					"select case when sum(Vales) IS NULL then 0 else sum(Vales) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
				bool hasRows18 = sqlDataReader.HasRows;
				if (hasRows18)
				{
					while (sqlDataReader.Read())
					{
						num28 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
				text4 = string.Concat(new string[]
				{
					"select case when sum(Otros) IS NULL then 0 else sum(Otros) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
				bool hasRows19 = sqlDataReader.HasRows;
				if (hasRows19)
				{
					while (sqlDataReader.Read())
					{
						num29 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
				text4 = string.Concat(new string[]
				{
					"select case when sum(Propina) IS NULL then 0 else sum(Propina) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
				bool hasRows20 = sqlDataReader.HasRows;
				if (hasRows20)
				{
					while (sqlDataReader.Read())
					{
						num30 = Conversions.ToDouble(sqlDataReader[0]);
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
				bool hasRows21 = sqlDataReader.HasRows;
				if (hasRows21)
				{
					num31 = Conversions.ToDouble(sqlDataReader[0]);
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
				bool hasRows22 = sqlDataReader.HasRows;
				if (hasRows22)
				{
					num32 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
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
					"' and facturado = 1 "
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows23 = sqlDataReader.HasRows;
				if (hasRows23)
				{
					num33 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
				this.DataGridCheques.ClearSelection();
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
				bool hasRows24 = sqlDataReader.HasRows;
				if (hasRows24)
				{
					num34 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
				flag89 = !this.chkEliminaProp.Checked;
			}
			if (flag89)
			{
				this.lblpropinascortenuevo.Text = "$ " + (num30 - num12).ToString("N2");
			}
			else
			{
				this.lblpropinascortenuevo.Text = "$ 0.00";
			}
			bool flag90 = !this.chkEliminaRet.Checked;
			if (flag90)
			{
				this.lblcortenuevodepositos.Text = "$ " + num32.ToString("N2");
				this.lblcortenuevoretiros.Text = "$ " + num31.ToString("N2");
			}
			else
			{
				this.lblcortenuevodepositos.Text = "$ 0.00";
				this.lblcortenuevoretiros.Text = "$ 0.00";
			}
			bool @checked = this.CheckBoxfondocaja.Checked;
			if (@checked)
			{
				this.lblfondoincial.Text = "$ 0.00";
			}
			else
			{
				this.lblfondoincial.Text = "$ " + num34.ToString("N2");
			}
			this.txtCuentasModificar.Text = num2.ToString();
			this.txtCuentasTotal.Text = num.ToString();
			this.txtImpAnterior.Text = "$ " + num25.ToString("N2");
			this.txtEfectivoAnt.Text = "$ " + num26.ToString("N2");
			this.txtTotalPropinas.Text = "$ " + num30.ToString("N2");
			this.txtVentaTarjeta.Text = "$ " + num27.ToString("N2");
			this.txtVentasOtros.Text = "$ " + num29.ToString("N2");
			this.txtVales.Text = "$ " + num28.ToString("N2");
			this.txtretirostotal.Text = "$ " + num31.ToString("N2");
			this.txtDepositos.Text = "$ " + num32.ToString("N2");
			this.txtVentaFacturada.Text = "$ " + num33.ToString("N2");
			this.txtImpNuevo.Text = "$ " + (num25 - num11 + num15).ToString("N2");
			double num35 = Conversions.ToDouble(this.txtImpNuevo.Text);
			this.txtDifImporte.Text = "$ " + (num25 - num35).ToString("N2");
			this.txtEfectivoFiscal.Text = "$ " + (num26 - num14 + num18).ToString("N2");
			double num36 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
			this.txtDifTarjeta.Text = "$ " + (num27 - num20 + num19).ToString("N2");
			this.txtdifotros.Text = "$ " + (num29 - num21 + num16).ToString("N2");
			this.txtdifvales.Text = "$ " + (num28 - num22 + num17).ToString("N2");
			this.txtDifPorcen.Text = "$ " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			double num37 = Conversions.ToDouble((num30 - num12).ToString("N2"));
			this.txtPropinasNuevo.Text = "$ " + num37.ToString("N2");
			this.txtEfectivoCaja.Text = "$ " + (num36 - num37 - num31 + num32 + num34).ToString("N2");
			double num38 = Conversions.ToDouble(this.txtEfectivoCaja.Text);
			this.txtVentaFacturada.Text = "$ " + (num33 - num23 + num24).ToString("N2");
			this.txtventasinfacturar.Text = "$ " + (num35 - num33).ToString("N2");
			this.lblcortefondoinicialanterior.Text = "$ " + num34.ToString("N2");
			this.lblcorteefectivoanterior.Text = "$ " + num26.ToString("N2");
			this.lblcortetarjetaanterior.Text = "$ " + num27.ToString("N2");
			this.lblcorteanteriorvales.Text = "$ " + num28.ToString("N2");
			this.lblcorteanteriorotros.Text = "$ " + num29.ToString("N2");
			this.lblcorteanteriordepositosenefectivo.Text = "$ " + num32.ToString("N2");
			this.lblcorteanteriorretirosefectivo.Text = "$ " + num31.ToString("N2");
			this.lblcorteanteriorpropinas.Text = "$ " + num30.ToString("N2");
			double num39 = num34 + num26 + num27 + num28 + num29 + num32 - num31 - num30;
			double num40 = num34 + num26 + num32 - num31 - num30;
			this.lblcorteanteriorefectivofinal.Text = "$ " + num40.ToString("N2");
			this.lblcorteanteriorsaldo.Text = "$ " + num39.ToString("N2");
			double num41 = Conversions.ToDouble(this.lblcortenuevodepositos.Text);
			double num42 = Conversions.ToDouble(this.lblcortenuevoretiros.Text);
			double num43 = Conversions.ToDouble(this.lblpropinascortenuevo.Text);
			double num44 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
			double num45 = Conversions.ToDouble(this.txtDifTarjeta.Text);
			double num46 = Conversions.ToDouble(this.txtdifvales.Text);
			double num47 = Conversions.ToDouble(this.txtdifotros.Text);
			double num48 = Conversions.ToDouble(this.lblfondoincial.Text);
			double num49 = Conversions.ToDouble(this.txtEfectivoCaja.Text);
			double num50 = num48 + num44 + num41 - num42 - num43;
			double num51 = num48 + num44 + num45 + num46 + num47 + num41 - num42 - num43;
			this.lblEfectivonuevocorte.Text = "$ " + num49.ToString("N2");
			this.lblcorteefectivonuevo.Text = "$ " + num44.ToString("N2");
			this.lblcortetarjetanuevo.Text = "$ " + num45.ToString("N2");
			this.lblcortenuevovales.Text = "$ " + num46.ToString("N2");
			this.lblcortenuevotros.Text = "$ " + num47.ToString("N2");
			this.lblfondoinicialnuevo.Text = "$ " + num48.ToString("N2");
			this.lblEfectivonuevocorte.Text = "$ " + num50.ToString("N2");
			this.lblsaldofinarlcortenuevo.Text = "$ " + num51.ToString("N2");
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x000E2D64 File Offset: 0x000E0F64
		private void PictureBox2_Click_1(object sender, EventArgs e)
		{
			this.PanelChequesproductos.Visible = false;
			this.dgvNotas.Enabled = true;
			this.Panel1.Visible = true;
			this.PanelAplicar.Visible = false;
			this.btnVistaPrevia.Enabled = true;
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x000036D5 File Offset: 0x000018D5
		private void DataGridCheques_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x000E2DB4 File Offset: 0x000E0FB4
		private void DataGridCheques_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			double num = 0.0;
			double num2 = Conversions.ToDouble(this.txtDifTarjeta.Text);
			double num3 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
			double num4 = Conversions.ToDouble(this.txtEfectivoCaja.Text);
			double num5 = Conversions.ToDouble(this.txtdifotros.Text);
			double num6 = Conversions.ToDouble(this.txtdifvales.Text);
			double num7 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 17;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, false, false);
				if (flag2)
				{
					this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value = true;
					this.DataGridCheques.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
					this.DataGridCheques.Rows[rowIndex].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
					TextBox textBox;
					(textBox = this.txtCuentasModificar).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
					string text = Conversions.ToString(this.DataGridCheques.Rows[rowIndex].Cells["id_folio"].Value);
					double num8 = Conversions.ToDouble(this.dblPrecioPodAnterior.ToString());
					double num9 = Conversions.ToDouble(this.dblPrecioProdSustituir.ToString());
					string text2 = Conversions.ToString(this.DataGridCheques.Rows[rowIndex].Cells["Total Prod. Encontrados"].Value);
					double num10 = Conversions.ToDouble(this.DataGridCheques.Rows[rowIndex].Cells["Total Original"].Value);
					string text3 = "";
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool flag3 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells["ID Producto."].Value, "", false);
							if (flag3)
							{
								text3 += "'";
								text3 = Conversions.ToString(Operators.AddObject(text3, dataGridViewRow.Cells["ID Producto"].Value));
								text3 += "'";
								text3 += ",";
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
					text3 = text3.Remove(checked(text3.Length - 1), 1);
					string text4 = ("Select foliodet , movimiento , cantidad , idproducto , precio , impuesto1 , preciosinimpuestos from cheqdet where idproducto in  (" + text3 + ") and foliodet = " + text) ?? "";
					SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
					bool hasRows = sqlDataReader.HasRows;
					if (hasRows)
					{
						while (sqlDataReader.Read())
						{
							string text5 = Conversions.ToString(sqlDataReader[0]);
							string text6 = Conversions.ToString(sqlDataReader[1]);
							string text7 = Conversions.ToString(sqlDataReader[2]);
							string text8 = Conversions.ToString(sqlDataReader[3]);
							double num11 = Conversions.ToDouble(sqlDataReader[4]);
							double num12 = Conversions.ToDouble(sqlDataReader[5]);
							double num13 = Conversions.ToDouble(sqlDataReader[6]);
							text4 = string.Concat(new string[]
							{
								"Insert into F (a,b,c,d,e,f,g) \r\n                                values ('",
								text5,
								"','",
								text6,
								"','",
								text7,
								"','",
								text8.ToString(),
								"','",
								num11.ToString("N2"),
								"','",
								num12.ToString("N2"),
								"','",
								num13.ToString("N2"),
								"')"
							});
							sqlQuery_Conn.execQuery_conn(text4);
						}
					}
					sqlDataReader.Close();
					try
					{
						foreach (object obj2 in ((IEnumerable)this.dgvNotas.Rows))
						{
							DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
							bool flag4 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow2.Cells["ID Producto."].Value, "", false);
							if (flag4)
							{
								string text9 = Conversions.ToString(dataGridViewRow2.Cells["ID Producto"].Value);
								string text10 = Conversions.ToString(dataGridViewRow2.Cells["ID Producto."].Value);
								double num14 = Conversions.ToDouble(dataGridViewRow2.Cells["Precio a sustituir"].Value);
								double num15 = Conversions.ToDouble(dataGridViewRow2.Cells["Precio sin impuestos a sustitur"].Value);
								text4 = string.Concat(new string[]
								{
									"Update F set d = '",
									text10.ToString(),
									"' , e = '",
									num14.ToString("N2"),
									"' , g = '",
									num15.ToString("N2"),
									"' WHERE \r\n                            d ='",
									text9.ToString(),
									"'"
								});
								sqlQuery_Conn.execQuery_conn(text4);
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
					text4 = string.Concat(new string[]
					{
						"Select sum(precio) FROM cheqdet where idproducto in (",
						text3,
						")  and foliodet='",
						text.ToString(),
						"'"
					});
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
					bool hasRows2 = sqlDataReader.HasRows;
					double num16;
					if (hasRows2)
					{
						while (sqlDataReader.Read())
						{
							num16 = Conversions.ToDouble(sqlDataReader[0]);
						}
					}
					text4 = "Select sum(e) FROM F where a='" + text.ToString() + "'";
					sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
					bool hasRows3 = sqlDataReader.HasRows;
					if (hasRows3)
					{
						while (sqlDataReader.Read())
						{
							double num17 = Conversions.ToDouble(sqlDataReader[0]);
							double num18 = num10;
							this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value = (num18 - num16 + num17).ToString("N2");
							num = Conversions.ToDouble(this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value);
						}
						sqlDataReader.Close();
					}
					bool flag5 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag5)
					{
						num3 = Conversions.ToDouble(Operators.SubtractObject(num3, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						num4 = Conversions.ToDouble(Operators.SubtractObject(num4, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						text4 = "SELECT i from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag6 = sqlDataReader.Read();
						if (flag6)
						{
							string text11 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text11.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows4 = sqlDataReader.HasRows;
							if (hasRows4)
							{
								while (sqlDataReader.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag7 = Conversions.ToDouble(value) == 4.0;
									if (flag7)
									{
										num5 += Conversions.ToDouble(num.ToString());
									}
									bool flag8 = Conversions.ToDouble(value) == 3.0;
									if (flag8)
									{
										num6 += Conversions.ToDouble(num.ToString());
									}
									bool flag9 = Conversions.ToDouble(value) == 1.0;
									if (flag9)
									{
										num4 += Conversions.ToDouble(num.ToString());
										num3 += Conversions.ToDouble(num.ToString());
									}
									bool flag10 = Conversions.ToDouble(value) == 2.0;
									if (flag10)
									{
										num2 += Conversions.ToDouble(num.ToString());
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
					bool flag11 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag11)
					{
						num2 = Conversions.ToDouble(Operators.SubtractObject(num2, this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value));
						text4 = "SELECT j from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag12 = sqlDataReader.Read();
						if (flag12)
						{
							string text13 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text13.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows5 = sqlDataReader.HasRows;
							if (hasRows5)
							{
								while (sqlDataReader.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag13 = Conversions.ToDouble(value) == 4.0;
									if (flag13)
									{
										num5 += Conversions.ToDouble(num.ToString());
									}
									bool flag14 = Conversions.ToDouble(value) == 3.0;
									if (flag14)
									{
										num6 += Conversions.ToDouble(num.ToString());
									}
									bool flag15 = Conversions.ToDouble(value) == 1.0;
									if (flag15)
									{
										num3 += Conversions.ToDouble(num.ToString());
										num4 += Conversions.ToDouble(num.ToString());
									}
									bool flag16 = Conversions.ToDouble(value) == 2.0;
									if (flag16)
									{
										num2 += Conversions.ToDouble(num.ToString());
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
					bool flag17 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag17)
					{
						num6 = Conversions.ToDouble(Operators.SubtractObject(num6, this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value));
						text4 = "SELECT k from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag18 = sqlDataReader.Read();
						if (flag18)
						{
							string text14 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text14.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows6 = sqlDataReader.HasRows;
							if (hasRows6)
							{
								while (sqlDataReader.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag19 = Conversions.ToDouble(value) == 4.0;
									if (flag19)
									{
										num5 += Conversions.ToDouble(num.ToString());
									}
									bool flag20 = Conversions.ToDouble(value) == 3.0;
									if (flag20)
									{
										num6 += Conversions.ToDouble(num.ToString());
									}
									bool flag21 = Conversions.ToDouble(value) == 1.0;
									if (flag21)
									{
										num4 += Conversions.ToDouble(num.ToString());
										num3 += Conversions.ToDouble(num.ToString());
									}
									bool flag22 = Conversions.ToDouble(value) == 2.0;
									if (flag22)
									{
										num2 += Conversions.ToDouble(num.ToString());
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
					bool flag23 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, true, false), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag23)
					{
						num5 = Conversions.ToDouble(Operators.SubtractObject(num5, this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value));
						text4 = "SELECT l from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag24 = sqlDataReader.Read();
						if (flag24)
						{
							string text15 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text15.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows7 = sqlDataReader.HasRows;
							if (hasRows7)
							{
								while (sqlDataReader.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag25 = Conversions.ToDouble(value) == 4.0;
									if (flag25)
									{
										num5 += Conversions.ToDouble(num.ToString());
									}
									bool flag26 = Conversions.ToDouble(value) == 3.0;
									if (flag26)
									{
										num6 += Conversions.ToDouble(num.ToString());
									}
									bool flag27 = Conversions.ToDouble(value) == 1.0;
									if (flag27)
									{
										num4 += Conversions.ToDouble(num.ToString());
										num3 += Conversions.ToDouble(num.ToString());
									}
									bool flag28 = Conversions.ToDouble(value) == 2.0;
									if (flag28)
									{
										num2 += Conversions.ToDouble(num.ToString());
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
					bool flag29 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag29)
					{
						num2 = Conversions.ToDouble(Operators.SubtractObject(num2, this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value));
						num4 = Conversions.ToDouble(Operators.SubtractObject(num4, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						num3 = Conversions.ToDouble(Operators.SubtractObject(num3, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						text4 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag30 = sqlDataReader.Read();
						if (flag30)
						{
							string text16 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text16.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows8 = sqlDataReader.HasRows;
							if (hasRows8)
							{
								while (sqlDataReader.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag31 = Conversions.ToDouble(value) == 4.0;
									if (flag31)
									{
										num5 += Conversions.ToDouble(num.ToString());
									}
									bool flag32 = Conversions.ToDouble(value) == 3.0;
									if (flag32)
									{
										num6 += Conversions.ToDouble(num.ToString());
									}
									bool flag33 = Conversions.ToDouble(value) == 1.0;
									if (flag33)
									{
										num4 += Conversions.ToDouble(num.ToString());
										num3 += Conversions.ToDouble(num.ToString());
									}
									bool flag34 = Conversions.ToDouble(value) == 2.0;
									if (flag34)
									{
										num2 += Conversions.ToDouble(num.ToString());
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
					bool flag35 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag35)
					{
						num6 = Conversions.ToDouble(Operators.SubtractObject(num6, this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value));
						num4 = Conversions.ToDouble(Operators.SubtractObject(num4, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						num3 = Conversions.ToDouble(Operators.SubtractObject(num3, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						text4 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag36 = sqlDataReader.Read();
						if (flag36)
						{
							string text16 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text16.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows9 = sqlDataReader.HasRows;
							if (hasRows9)
							{
								while (sqlDataReader.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag37 = Conversions.ToDouble(value) == 4.0;
									if (flag37)
									{
										num5 += Conversions.ToDouble(num.ToString());
									}
									bool flag38 = Conversions.ToDouble(value) == 3.0;
									if (flag38)
									{
										num6 += Conversions.ToDouble(num.ToString());
									}
									bool flag39 = Conversions.ToDouble(value) == 1.0;
									if (flag39)
									{
										num3 += Conversions.ToDouble(num.ToString());
										num4 += Conversions.ToDouble(num.ToString());
									}
									bool flag40 = Conversions.ToDouble(value) == 2.0;
									if (flag40)
									{
										num2 += Conversions.ToDouble(num.ToString());
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
					bool flag41 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, true, false), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag41)
					{
						num5 = Conversions.ToDouble(Operators.SubtractObject(num5, this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value));
						num4 = Conversions.ToDouble(Operators.SubtractObject(num4, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						num3 = Conversions.ToDouble(Operators.SubtractObject(num3, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						text4 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag42 = sqlDataReader.Read();
						if (flag42)
						{
							string text16 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text16.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows10 = sqlDataReader.HasRows;
							if (hasRows10)
							{
								while (sqlDataReader.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag43 = Conversions.ToDouble(value) == 4.0;
									if (flag43)
									{
										num5 += Conversions.ToDouble(num.ToString());
									}
									bool flag44 = Conversions.ToDouble(value) == 3.0;
									if (flag44)
									{
										num6 += Conversions.ToDouble(num.ToString());
									}
									bool flag45 = Conversions.ToDouble(value) == 1.0;
									if (flag45)
									{
										num4 += Conversions.ToDouble(num.ToString());
										num3 += Conversions.ToDouble(num.ToString());
									}
									bool flag46 = Conversions.ToDouble(value) == 2.0;
									if (flag46)
									{
										num2 += Conversions.ToDouble(num.ToString());
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
					bool flag47 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag47)
					{
						num2 = Conversions.ToDouble(Operators.SubtractObject(num2, this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value));
						num6 = Conversions.ToDouble(Operators.SubtractObject(num6, this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value));
						text4 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag48 = sqlDataReader.Read();
						if (flag48)
						{
							string text16 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text16.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows11 = sqlDataReader.HasRows;
							if (hasRows11)
							{
								while (sqlDataReader.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag49 = Conversions.ToDouble(value) == 4.0;
									if (flag49)
									{
										num5 += Conversions.ToDouble(num.ToString());
									}
									bool flag50 = Conversions.ToDouble(value) == 3.0;
									if (flag50)
									{
										num6 += Conversions.ToDouble(num.ToString());
									}
									bool flag51 = Conversions.ToDouble(value) == 1.0;
									if (flag51)
									{
										num4 += Conversions.ToDouble(num.ToString());
										num3 += Conversions.ToDouble(num.ToString());
									}
									bool flag52 = Conversions.ToDouble(value) == 2.0;
									if (flag52)
									{
										num2 += Conversions.ToDouble(num.ToString());
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
					bool flag53 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, true, false), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag53)
					{
						num2 = Conversions.ToDouble(Operators.SubtractObject(num2, this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value));
						num5 = Conversions.ToDouble(Operators.SubtractObject(num5, this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value));
						text4 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag54 = sqlDataReader.Read();
						if (flag54)
						{
							string text16 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text16.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows12 = sqlDataReader.HasRows;
							if (hasRows12)
							{
								while (sqlDataReader.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag55 = Conversions.ToDouble(value) == 4.0;
									if (flag55)
									{
										num5 += Conversions.ToDouble(num.ToString());
									}
									bool flag56 = Conversions.ToDouble(value) == 3.0;
									if (flag56)
									{
										num6 += Conversions.ToDouble(num.ToString());
									}
									bool flag57 = Conversions.ToDouble(value) == 1.0;
									if (flag57)
									{
										num4 += Conversions.ToDouble(num.ToString());
										num3 += Conversions.ToDouble(num.ToString());
									}
									bool flag58 = Conversions.ToDouble(value) == 2.0;
									if (flag58)
									{
										num2 += Conversions.ToDouble(num.ToString());
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
					bool flag59 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, true, false), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag59)
					{
						num6 = Conversions.ToDouble(Operators.SubtractObject(num6, this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value));
						num5 = Conversions.ToDouble(Operators.SubtractObject(num5, this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value));
						text4 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag60 = sqlDataReader.Read();
						if (flag60)
						{
							string text16 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text16.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows13 = sqlDataReader.HasRows;
							if (hasRows13)
							{
								while (sqlDataReader.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag61 = Conversions.ToDouble(value) == 4.0;
									if (flag61)
									{
										num5 += Conversions.ToDouble(num.ToString());
									}
									bool flag62 = Conversions.ToDouble(value) == 3.0;
									if (flag62)
									{
										num6 += Conversions.ToDouble(num.ToString());
									}
									bool flag63 = Conversions.ToDouble(value) == 1.0;
									if (flag63)
									{
										num4 += Conversions.ToDouble(num.ToString());
										num3 += Conversions.ToDouble(num.ToString());
									}
									bool flag64 = Conversions.ToDouble(value) == 2.0;
									if (flag64)
									{
										num2 += Conversions.ToDouble(num.ToString());
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
					bool flag65 = !this.chkEliminaProp.Checked;
					if (flag65)
					{
						(textBox = this.txtPropinasNuevo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.NegateObject(this.DataGridCheques.Rows[rowIndex].Cells["Propina"].Value)));
						num4 = Conversions.ToDouble(Operators.AddObject(num4, Operators.PlusObject(this.DataGridCheques.Rows[rowIndex].Cells["Propina"].Value)));
					}
					else
					{
						this.lblpropinascortenuevo.Text = "$ 0.00";
						this.txtPropinasNuevo.Text = "$ 0.00";
					}
					bool flag66 = Operators.ConditionalCompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Facturado"].Value, "Si", false);
					if (flag66)
					{
						num7 = Conversions.ToDouble(Operators.AddObject(num7, Operators.SubtractObject(Operators.PlusObject(this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value), this.DataGridCheques.Rows[rowIndex].Cells["Total Original"].Value)));
					}
					(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, Operators.SubtractObject(this.DataGridCheques.Rows[rowIndex].Cells["Total Original"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value)));
					(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.SubtractObject(this.DataGridCheques.Rows[rowIndex].Cells["Total Original"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value)));
					this.txtVentaFacturada.Text = num7.ToString();
				}
				else
				{
					this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value = false;
					this.DataGridCheques.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
					this.DataGridCheques.Rows[rowIndex].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.875f, FontStyle.Regular);
					TextBox textBox;
					(textBox = this.txtCuentasModificar).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - 1.0);
					double num19 = Conversions.ToDouble(this.DataGridCheques.Rows[rowIndex].Cells["Total Original"].Value);
					double num20 = Conversions.ToDouble(this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value);
					(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, Operators.SubtractObject(this.DataGridCheques.Rows[rowIndex].Cells["Total Original"].Value, num20.ToString())));
					(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.SubtractObject(this.DataGridCheques.Rows[rowIndex].Cells["Total Original"].Value, num20.ToString())));
					bool flag67 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, false, false), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					string text4;
					if (flag67)
					{
						num3 = Conversions.ToDouble(Operators.AddObject(num3, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						num4 = Conversions.ToDouble(Operators.AddObject(num4, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						text4 = "SELECT i from H";
						SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag68 = sqlDataReader2.Read();
						if (flag68)
						{
							string text11 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text11.ToString() + "'";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows14 = sqlDataReader2.HasRows;
							if (hasRows14)
							{
								while (sqlDataReader2.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader2[0]);
									string value = Conversions.ToString(sqlDataReader2[1]);
									bool flag69 = Conversions.ToDouble(value) == 4.0;
									if (flag69)
									{
										num5 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag70 = Conversions.ToDouble(value) == 3.0;
									if (flag70)
									{
										num6 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag71 = Conversions.ToDouble(value) == 1.0;
									if (flag71)
									{
										num3 += -Conversions.ToDouble(num20.ToString());
										num4 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag72 = Conversions.ToDouble(value) == 2.0;
									if (flag72)
									{
										num2 += -Conversions.ToDouble(num20.ToString());
									}
								}
							}
							else
							{
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader2.Close();
					}
					bool flag73 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, false, false), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag73)
					{
						num2 = Conversions.ToDouble(Operators.AddObject(num2, this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value));
						text4 = "SELECT j from H";
						SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag74 = sqlDataReader2.Read();
						if (flag74)
						{
							string text13 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text13.ToString() + "'";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows15 = sqlDataReader2.HasRows;
							if (hasRows15)
							{
								while (sqlDataReader2.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader2[0]);
									string value = Conversions.ToString(sqlDataReader2[1]);
									bool flag75 = Conversions.ToDouble(value) == 4.0;
									if (flag75)
									{
										num5 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag76 = Conversions.ToDouble(value) == 3.0;
									if (flag76)
									{
										num6 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag77 = Conversions.ToDouble(value) == 1.0;
									if (flag77)
									{
										num3 += -Conversions.ToDouble(num20.ToString());
										num4 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag78 = Conversions.ToDouble(value) == 2.0;
									if (flag78)
									{
										num2 += -Conversions.ToDouble(num20.ToString());
									}
								}
							}
							else
							{
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader2.Close();
					}
					bool flag79 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, false, false), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag79)
					{
						num5 = Conversions.ToDouble(Operators.AddObject(num5, this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value));
						text4 = "SELECT l from H";
						SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag80 = sqlDataReader2.Read();
						if (flag80)
						{
							string text15 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text15.ToString() + "'";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows16 = sqlDataReader2.HasRows;
							if (hasRows16)
							{
								while (sqlDataReader2.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader2[0]);
									string value = Conversions.ToString(sqlDataReader2[1]);
									bool flag81 = Conversions.ToDouble(value) == 4.0;
									if (flag81)
									{
										num5 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag82 = Conversions.ToDouble(value) == 3.0;
									if (flag82)
									{
										num6 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag83 = Conversions.ToDouble(value) == 1.0;
									if (flag83)
									{
										num3 += -Conversions.ToDouble(num20.ToString());
										num4 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag84 = Conversions.ToDouble(value) == 2.0;
									if (flag84)
									{
										num2 += -Conversions.ToDouble(num20.ToString());
									}
								}
							}
							else
							{
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader2.Close();
					}
					bool flag85 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, false, false), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag85)
					{
						num6 = Conversions.ToDouble(Operators.AddObject(num6, this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value));
						text4 = "SELECT k from H";
						SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag86 = sqlDataReader2.Read();
						if (flag86)
						{
							string text14 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text14.ToString() + "'";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows17 = sqlDataReader2.HasRows;
							if (hasRows17)
							{
								while (sqlDataReader2.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader2[0]);
									string value = Conversions.ToString(sqlDataReader2[1]);
									bool flag87 = Conversions.ToDouble(value) == 4.0;
									if (flag87)
									{
										num5 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag88 = Conversions.ToDouble(value) == 3.0;
									if (flag88)
									{
										num6 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag89 = Conversions.ToDouble(value) == 1.0;
									if (flag89)
									{
										num3 += -Conversions.ToDouble(num20.ToString());
										num4 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag90 = Conversions.ToDouble(value) == 2.0;
									if (flag90)
									{
										num2 += -Conversions.ToDouble(num20.ToString());
									}
								}
							}
							else
							{
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader2.Close();
					}
					bool flag91 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, false, false), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag91)
					{
						num2 = Conversions.ToDouble(Operators.AddObject(num2, this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value));
						num4 = Conversions.ToDouble(Operators.AddObject(num4, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						num3 = Conversions.ToDouble(Operators.AddObject(num3, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						text4 = "SELECT m from H";
						SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag92 = sqlDataReader2.Read();
						if (flag92)
						{
							string text16 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text16.ToString() + "'";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows18 = sqlDataReader2.HasRows;
							if (hasRows18)
							{
								while (sqlDataReader2.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader2[0]);
									string value = Conversions.ToString(sqlDataReader2[1]);
									bool flag93 = Conversions.ToDouble(value) == 4.0;
									if (flag93)
									{
										num5 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag94 = Conversions.ToDouble(value) == 3.0;
									if (flag94)
									{
										num6 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag95 = Conversions.ToDouble(value) == 1.0;
									if (flag95)
									{
										num3 += -Conversions.ToDouble(num20.ToString());
										num4 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag96 = Conversions.ToDouble(value) == 2.0;
									if (flag96)
									{
										num2 += -Conversions.ToDouble(num20.ToString());
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
						sqlDataReader2.Close();
					}
					bool flag97 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, false, false), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag97)
					{
						num5 = Conversions.ToDouble(Operators.AddObject(num5, this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value));
						num4 = Conversions.ToDouble(Operators.AddObject(num4, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						num3 = Conversions.ToDouble(Operators.AddObject(num3, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						text4 = "SELECT m from H";
						SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag98 = sqlDataReader2.Read();
						if (flag98)
						{
							string text16 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text16.ToString() + "'";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows19 = sqlDataReader2.HasRows;
							if (hasRows19)
							{
								while (sqlDataReader2.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader2[0]);
									string value = Conversions.ToString(sqlDataReader2[1]);
									bool flag99 = Conversions.ToDouble(value) == 4.0;
									if (flag99)
									{
										num5 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag100 = Conversions.ToDouble(value) == 3.0;
									if (flag100)
									{
										num6 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag101 = Conversions.ToDouble(value) == 1.0;
									if (flag101)
									{
										num4 += -Conversions.ToDouble(num20.ToString());
										num3 = -Conversions.ToDouble(num20.ToString());
									}
									bool flag102 = Conversions.ToDouble(value) == 2.0;
									if (flag102)
									{
										num2 += -Conversions.ToDouble(num20.ToString());
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
						sqlDataReader2.Close();
					}
					bool flag103 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, false, false), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag103)
					{
						num6 = Conversions.ToDouble(Operators.AddObject(num6, this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value));
						num4 = Conversions.ToDouble(Operators.AddObject(num4, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						num3 = Conversions.ToDouble(Operators.AddObject(num3, this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value));
						text4 = "SELECT m from H";
						SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag104 = sqlDataReader2.Read();
						if (flag104)
						{
							string text16 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text16.ToString() + "'";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows20 = sqlDataReader2.HasRows;
							if (hasRows20)
							{
								while (sqlDataReader2.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader2[0]);
									string value = Conversions.ToString(sqlDataReader2[1]);
									bool flag105 = Conversions.ToDouble(value) == 4.0;
									if (flag105)
									{
										num5 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag106 = Conversions.ToDouble(value) == 3.0;
									if (flag106)
									{
										num6 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag107 = Conversions.ToDouble(value) == 1.0;
									if (flag107)
									{
										num4 += -Conversions.ToDouble(num20.ToString());
										num3 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag108 = Conversions.ToDouble(value) == 2.0;
									if (flag108)
									{
										num2 += -Conversions.ToDouble(num20.ToString());
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
						sqlDataReader2.Close();
					}
					bool flag109 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, false, false), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag109)
					{
						num6 = Conversions.ToDouble(Operators.AddObject(num6, this.DataGridCheques.Rows[rowIndex].Cells["vales"].Value));
						num2 = Conversions.ToDouble(Operators.AddObject(num2, this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value));
						text4 = "SELECT m from H";
						SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag110 = sqlDataReader2.Read();
						if (flag110)
						{
							string text16 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text16.ToString() + "'";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows21 = sqlDataReader2.HasRows;
							if (hasRows21)
							{
								while (sqlDataReader2.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader2[0]);
									string value = Conversions.ToString(sqlDataReader2[1]);
									bool flag111 = Conversions.ToDouble(value) == 4.0;
									if (flag111)
									{
										num5 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag112 = Conversions.ToDouble(value) == 3.0;
									if (flag112)
									{
										num6 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag113 = Conversions.ToDouble(value) == 1.0;
									if (flag113)
									{
										num4 += -Conversions.ToDouble(num20.ToString());
										num3 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag114 = Conversions.ToDouble(value) == 2.0;
									if (flag114)
									{
										num2 += -Conversions.ToDouble(num20.ToString());
									}
								}
							}
							else
							{
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader2.Close();
					}
					bool flag115 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, false, false), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag115)
					{
						num5 = Conversions.ToDouble(Operators.AddObject(num5, this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value));
						num2 = Conversions.ToDouble(Operators.AddObject(num2, this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value));
						text4 = "SELECT m from H";
						SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag116 = sqlDataReader2.Read();
						if (flag116)
						{
							string text16 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text16.ToString() + "'";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows22 = sqlDataReader2.HasRows;
							if (hasRows22)
							{
								while (sqlDataReader2.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader2[0]);
									string value = Conversions.ToString(sqlDataReader2[1]);
									bool flag117 = Conversions.ToDouble(value) == 4.0;
									if (flag117)
									{
										num5 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag118 = Conversions.ToDouble(value) == 3.0;
									if (flag118)
									{
										num6 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag119 = Conversions.ToDouble(value) == 1.0;
									if (flag119)
									{
										num4 += -Conversions.ToDouble(num20.ToString());
										num3 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag120 = Conversions.ToDouble(value) == 2.0;
									if (flag120)
									{
										num2 += -Conversions.ToDouble(num20.ToString());
									}
								}
							}
							else
							{
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader2.Close();
					}
					bool flag121 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Modificar"].Value, false, false), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectNotEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag121)
					{
						num6 = Conversions.ToDouble(Operators.AddObject(num6, this.DataGridCheques.Rows[rowIndex].Cells["vales"].Value));
						num5 = Conversions.ToDouble(Operators.AddObject(num5, this.DataGridCheques.Rows[rowIndex].Cells["Otros"].Value));
						text4 = "SELECT m from H";
						SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool flag122 = sqlDataReader2.Read();
						if (flag122)
						{
							string text16 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
							text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text16.ToString() + "'";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows23 = sqlDataReader2.HasRows;
							if (hasRows23)
							{
								while (sqlDataReader2.Read())
								{
									string text12 = Conversions.ToString(sqlDataReader2[0]);
									string value = Conversions.ToString(sqlDataReader2[1]);
									bool flag123 = Conversions.ToDouble(value) == 4.0;
									if (flag123)
									{
										num5 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag124 = Conversions.ToDouble(value) == 3.0;
									if (flag124)
									{
										num6 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag125 = Conversions.ToDouble(value) == 1.0;
									if (flag125)
									{
										num4 += -Conversions.ToDouble(num20.ToString());
										num3 += -Conversions.ToDouble(num20.ToString());
									}
									bool flag126 = Conversions.ToDouble(value) == 2.0;
									if (flag126)
									{
										num2 += -Conversions.ToDouble(num20.ToString());
									}
								}
							}
							else
							{
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
							}
						}
						sqlDataReader2.Close();
					}
					bool flag127 = !this.chkEliminaProp.Checked;
					if (flag127)
					{
						(textBox = this.txtPropinasNuevo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.PlusObject(this.DataGridCheques.Rows[rowIndex].Cells["Propina"].Value)));
						num4 = Conversions.ToDouble(Operators.AddObject(num4, Operators.NegateObject(this.DataGridCheques.Rows[rowIndex].Cells["Propina"].Value)));
					}
					else
					{
						this.lblpropinascortenuevo.Text = "$ 0.00";
						this.txtPropinasNuevo.Text = "$ 0.00";
					}
					bool flag128 = Operators.ConditionalCompareObjectEqual(this.DataGridCheques.Rows[rowIndex].Cells["Facturado"].Value, "Si", false);
					if (flag128)
					{
						num7 = Conversions.ToDouble(Operators.AddObject(num7, Operators.SubtractObject(Operators.PlusObject(this.DataGridCheques.Rows[rowIndex].Cells["Total Original"].Value), this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value)));
					}
					this.txtVentaFacturada.Text = num7.ToString("N2");
					string text = Conversions.ToString(this.DataGridCheques.Rows[rowIndex].Cells["id_folio"].Value);
					text4 = "Delete from F where a='" + text + "'";
					sqlQuery_Conn.execQuery_conn(text4);
					this.DataGridCheques.Rows[rowIndex].Cells["Total con Descuento"].Value = "0";
				}
			}
			this.txtDifTarjeta.Text = Conversions.ToString(num2);
			this.txtEfectivoFiscal.Text = Conversions.ToString(num3);
			this.txtEfectivoCaja.Text = Conversions.ToString(num4);
			this.txtdifotros.Text = Conversions.ToString(num5);
			this.txtdifvales.Text = Conversions.ToString(num6);
			double num21 = Conversions.ToDouble(this.txtventasinfacturar.Text);
			this.txtventasinfacturar.Text = "$ " + num21.ToString("N2");
			double num22 = Conversions.ToDouble(this.txtImpNuevo.Text);
			this.txtImpNuevo.Text = "$ " + num22.ToString("N2");
			double num23 = Conversions.ToDouble(this.txtPropinasNuevo.Text);
			this.txtPropinasNuevo.Text = "$ " + num23.ToString("N2");
			this.lblpropinascortenuevo.Text = this.txtPropinasNuevo.Text;
			double num24 = Conversions.ToDouble(this.txtDifImporte.Text);
			this.txtDifImporte.Text = "$ " + num24.ToString("N2");
			double num25 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			double num26 = Conversions.ToDouble(this.txtImpNuevo.Text);
			this.txtVentaFacturada.Text = "$ " + num25.ToString("N2");
			double num27 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			this.txtFacturaPUB.Text = "$ " + (num26 - num27).ToString("N2");
			this.txtventasinfacturar.Text = "$ " + (num26 - num27).ToString("N2");
			double num28 = Conversions.ToDouble(this.txtdifvales.Text);
			this.txtdifvales.Text = "$ " + num28.ToString("N2");
			this.lblcortenuevovales.Text = this.txtdifvales.Text;
			double num29 = Conversions.ToDouble(this.txtdifotros.Text);
			this.txtdifotros.Text = "$ " + num29.ToString("N2");
			this.lblcortenuevotros.Text = this.txtdifotros.Text;
			double num30 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
			this.txtEfectivoFiscal.Text = "$ " + num30.ToString("N2");
			this.lblcorteefectivonuevo.Text = this.txtEfectivoFiscal.Text;
			double num31 = Conversions.ToDouble(this.txtEfectivoCaja.Text);
			this.txtEfectivoCaja.Text = "$ " + num31.ToString("N2");
			this.lblEfectivonuevocorte.Text = this.txtEfectivoCaja.Text;
			double num32 = Conversions.ToDouble(this.txtDifTarjeta.Text);
			this.txtDifTarjeta.Text = "$ " + num32.ToString("N2");
			this.lblcortetarjetanuevo.Text = this.txtDifTarjeta.Text;
			double num33 = Conversions.ToDouble(this.lblfondoinicialnuevo.Text);
			double num34 = Conversions.ToDouble(this.lblcorteefectivonuevo.Text);
			double num35 = Conversions.ToDouble(this.lblcortetarjetanuevo.Text);
			double num36 = Conversions.ToDouble(this.lblcortenuevovales.Text);
			double num37 = Conversions.ToDouble(this.lblcortenuevotros.Text);
			double num38 = Conversions.ToDouble(this.lblcortenuevodepositos.Text);
			double num39 = Conversions.ToDouble(this.lblcortenuevoretiros.Text);
			double num40 = Conversions.ToDouble(this.lblpropinascortenuevo.Text);
			double num41 = num33 + num34 + num35 + num36 + num37 + num38 - num39 - num40;
			this.lblsaldofinarlcortenuevo.Text = "$ " + num41.ToString("N2");
			this.txtDifPorcen.Text = "% " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			this.lblventafacturanew.Text = this.txtVentaFacturada.Text;
			this.lblventasinfacturarnew.Text = this.txtventasinfacturar.Text;
			this.lblfacturapubnew.Text = this.txtFacturaPUB.Text;
			bool flag129 = e.RowIndex >= 0 && e.ColumnIndex == 16;
			if (flag129)
			{
				this.DataGridCheques.Enabled = false;
				this.iniciaGridCheqdet();
				string text17 = Conversions.ToString(this.DataGridCheques.Rows[rowIndex].Cells["id_folio"].Value);
				this.lblnumchequevista.Text = Conversions.ToString(this.DataGridCheques.Rows[rowIndex].Cells["Folio Cuenta"].Value);
				this.PanelCheqdetalle.Visible = true;
				string text4 = "Select a.foliodet, a.Movimiento, a.cantidad, a.idproducto, b.descripcion, a.descuento, a.precio from cheqdet A             \r\n                        Inner join productos B on b.idproducto = a.idproducto  where foliodet = '" + text17.ToString() + "' order by a.movimiento ";
				SqlDataReader sqlDataReader3 = (SqlDataReader)sqlQuery.execReader(text4);
				bool hasRows24 = sqlDataReader3.HasRows;
				if (hasRows24)
				{
					while (sqlDataReader3.Read())
					{
						string text18 = Conversions.ToString(sqlDataReader3[0]);
						string text19 = Conversions.ToString(sqlDataReader3[1]);
						string text20 = Conversions.ToString(sqlDataReader3[2]);
						string text21 = Conversions.ToString(sqlDataReader3[3]);
						string text22 = Conversions.ToString(sqlDataReader3[4]);
						string text23 = Conversions.ToString(sqlDataReader3[5]);
						double num42 = Conversions.ToDouble(sqlDataReader3[6]);
						this.DataGridVerTicket.Rows.Add(new object[]
						{
							text18,
							text19,
							text20,
							text21,
							text22,
							text23,
							num42.ToString("N2")
						});
					}
				}
				try
				{
					foreach (object obj3 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj3;
						bool flag130 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow3.Cells["ID Producto."].Value, "", false);
						if (flag130)
						{
							string right = Conversions.ToString(dataGridViewRow3.Cells["ID Producto"].Value);
							try
							{
								foreach (object obj4 in ((IEnumerable)this.DataGridVerTicket.Rows))
								{
									DataGridViewRow dataGridViewRow4 = (DataGridViewRow)obj4;
									bool flag131 = Operators.ConditionalCompareObjectEqual(dataGridViewRow4.Cells["ID Producto"].Value, right, false);
									if (flag131)
									{
										bool flag132 = Operators.ConditionalCompareObjectEqual(dataGridViewRow4.Cells["Modificar"].Value, false, false);
										if (flag132)
										{
											dataGridViewRow4.Cells["Modificar"].Value = true;
											dataGridViewRow4.DefaultCellStyle.BackColor = Color.Red;
											dataGridViewRow4.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
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
			this.DataGridVerTicket.ClearSelection();
			this.DataGridCheques.ClearSelection();
			this.MostrarProductosReemplaza();
			bool flag133 = Conversions.ToDouble(this.txtCuentasModificar.Text) != 0.0;
			if (flag133)
			{
				this.Button1.Enabled = true;
			}
			else
			{
				this.Button1.Enabled = false;
			}
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x000E91B0 File Offset: 0x000E73B0
		private void iniciaGridCheqdet()
		{
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			this.DataGridVerTicket.Rows.Clear();
			this.DataGridVerTicket.ColumnCount = 7;
			this.DataGridVerTicket.Columns[0].Name = "id_Ticket";
			this.DataGridVerTicket.Columns[0].Visible = false;
			this.DataGridVerTicket.Columns[0].Width = 60;
			this.DataGridVerTicket.Columns[1].Name = "Mov.";
			this.DataGridVerTicket.Columns[1].Width = 60;
			this.DataGridVerTicket.Columns[2].Name = "Cantidad";
			this.DataGridVerTicket.Columns[2].Width = 60;
			this.DataGridVerTicket.Columns[3].Name = "ID Producto";
			this.DataGridVerTicket.Columns[3].Width = 60;
			this.DataGridVerTicket.Columns[4].Name = "Descripcion";
			this.DataGridVerTicket.Columns[4].Width = 230;
			this.DataGridVerTicket.Columns[5].Name = "Descuento";
			this.DataGridVerTicket.Columns[5].Width = 80;
			this.DataGridVerTicket.Columns[6].Name = "Precio";
			this.DataGridVerTicket.Columns[6].Width = 60;
			dataGridViewCheckBoxColumn.Width = 70;
			dataGridViewCheckBoxColumn.Name = "Modificar";
			this.DataGridVerTicket.Columns.Add(dataGridViewCheckBoxColumn);
			this.DataGridVerTicket.RowsDefaultCellStyle.ForeColor = Color.Black;
			this.DataGridVerTicket.DefaultCellStyle.BackColor = Color.White;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x000E93C4 File Offset: 0x000E75C4
		public void MostrarPRoductosBuscar()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select a.idproducto ,b.descripcion, a.precio , a.preciosinimpuestos , a.impuesto1 from productosdetalle A \r\n                    Inner join productos B on b.idproducto = a.idproducto where b.Descripcion Like '%" + this.txtBuscarProducto.Text + "%' order by a.idproducto asc";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text = Conversions.ToString(sqlDataReader[0]);
					string text2 = Conversions.ToString(sqlDataReader[1]);
					double num = Conversions.ToDouble(sqlDataReader[2]);
					double num2 = Conversions.ToDouble(sqlDataReader[3]);
					string text3 = Conversions.ToString(sqlDataReader[4]);
					this.dgvNotas.Rows.Add(new object[]
					{
						text,
						text2,
						num.ToString("N2"),
						num2.ToString("N2"),
						text3
					});
				}
			}
			sqlDataReader.Close();
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x000E94C4 File Offset: 0x000E76C4
		private void iniciaGridNuevoProducto()
		{
			this.dgvProdNuevos.Rows.Clear();
			this.dgvProdNuevos.ColumnCount = 5;
			this.dgvProdNuevos.Columns[0].Name = "ID Producto";
			this.dgvProdNuevos.Columns[0].Visible = true;
			this.dgvProdNuevos.Columns[0].Width = 60;
			this.dgvProdNuevos.Columns[1].Name = "Descripcion";
			this.dgvProdNuevos.Columns[1].Width = 230;
			this.dgvProdNuevos.Columns[2].Name = "Precio";
			this.dgvProdNuevos.Columns[2].Width = 80;
			this.dgvProdNuevos.Columns[3].Name = "Precio sin impuestos";
			this.dgvProdNuevos.Columns[3].Width = 80;
			this.dgvProdNuevos.Columns[4].Name = "Impuesto.";
			this.dgvProdNuevos.Columns[4].Width = 80;
			this.dgvProdNuevos.RowsDefaultCellStyle.ForeColor = Color.Black;
			this.dgvProdNuevos.DefaultCellStyle.BackColor = Color.White;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x000E9640 File Offset: 0x000E7840
		public void MostrarPRoductos1()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select a.idproducto ,b.descripcion, a.precio , a.preciosinimpuestos , a.impuesto1 from productosdetalle A \r\n                    Inner join productos B on b.idproducto = a.idproducto order by a.idproducto asc";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text = Conversions.ToString(sqlDataReader[0]);
					string text2 = Conversions.ToString(sqlDataReader[1]);
					double num = Conversions.ToDouble(sqlDataReader[2]);
					double num2 = Conversions.ToDouble(sqlDataReader[3]);
					string text3 = Conversions.ToString(sqlDataReader[4]);
					this.dgvProdNuevos.Rows.Add(new object[]
					{
						text,
						text2,
						num.ToString("N2"),
						num2.ToString("N2"),
						text3
					});
				}
			}
			sqlDataReader.Close();
			this.dgvProdNuevos.ClearSelection();
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x000E9728 File Offset: 0x000E7928
		public void MostrarPRoductosBuscar1()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select a.idproducto ,b.descripcion, a.precio , a.preciosinimpuestos , a.impuesto1 from productosdetalle A \r\n                    Inner join productos B on b.idproducto = a.idproducto where b.Descripcion Like '%" + this.txtBuscarProdNuevo.Text + "%' order by a.idproducto asc";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			this.iniciaGridNuevoProducto();
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text = Conversions.ToString(sqlDataReader[0]);
					string text2 = Conversions.ToString(sqlDataReader[1]);
					double num = Conversions.ToDouble(sqlDataReader[2]);
					double num2 = Conversions.ToDouble(sqlDataReader[3]);
					string text3 = Conversions.ToString(sqlDataReader[4]);
					this.dgvProdNuevos.Rows.Add(new object[]
					{
						text,
						text2,
						num.ToString("N2"),
						num2.ToString("N2"),
						text3
					});
				}
			}
			sqlDataReader.Close();
			this.dgvProdNuevos.ClearSelection();
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x000E982C File Offset: 0x000E7A2C
		private void txtBuscarProdNuevo_TextChanged(object sender, EventArgs e)
		{
			this.MostrarPRoductosBuscar1();
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvProdNuevos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvProdNuevos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x000E9836 File Offset: 0x000E7A36
		private void PictureBox5_Click_1(object sender, EventArgs e)
		{
			this.PanelAsignarProducto.Visible = false;
			this.dgvNotas.Enabled = true;
			this.PanelAplicar.Visible = false;
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x000036D5 File Offset: 0x000018D5
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x000E9860 File Offset: 0x000E7A60
		private void PictureBox7_Click(object sender, EventArgs e)
		{
			this.PanelCheqdetalle.Visible = false;
			this.DataGridCheques.Enabled = true;
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000E987D File Offset: 0x000E7A7D
		private void PictureBox8_Click(object sender, EventArgs e)
		{
			this.Panelvercortes.Visible = false;
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x000E9890 File Offset: 0x000E7A90
		private void btnVistaPrevia_Click(object sender, EventArgs e)
		{
			string text = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
			string text2 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text3 = "";
			frmWaitMsg frmWaitMsg = new frmWaitMsg();
			string text4 = "Delete from F";
			sqlQuery_Conn.execQuery_conn(text4);
			text4 = "Delete from FF";
			sqlQuery_Conn.execQuery_conn(text4);
			int num;
			int num2;
			string text5;
			SqlDataReader sqlDataReader;
			checked
			{
				try
				{
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool flag = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow.Cells["ID Producto."].Value, "", false);
							if (flag)
							{
								text3 += "'";
								text3 = Conversions.ToString(Operators.AddObject(text3, dataGridViewRow.Cells["ID Producto"].Value));
								text3 += "'";
								text3 += ",";
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
					text3 = text3.Remove(text3.Length - 1, 1);
				}
				catch (Exception ex)
				{
					Interaction.MsgBox("Asigna almenos 1 Producto para sustituir,intenta nuevamente!", MsgBoxStyle.OkOnly, null);
					return;
				}
				this.PanelChequesproductos.Visible = true;
				num = 0;
				num2 = 0;
				text5 = this.cmbxSerie.Text;
				bool flag2 = Operators.CompareString(text5, "Todas", false) == 0;
				bool flag6;
				if (flag2)
				{
					text4 = string.Concat(new string[]
					{
						"Select folio,numcheque ,fecha, Descuento , total , efectivo,tarjeta,vales,otros,propina,totalarticulos,facturado,seriefolio,mesa,cancelado, folionotadeconsumo from cheques where folio In ( Select foliodet from cheqdet where idproducto in  (",
						text3,
						")) and \r\n                    idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
						text,
						"' AND '",
						text2,
						"' AND \r\n                    cierre is not null and idempresa='",
						Tools.id_Empresa,
						"')\r\n                    and idempresa='",
						Tools.id_Empresa,
						"' and cancelado='0' and total > '0' order by seriefolio,numcheque "
					});
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
					this.iniciaGridChequesProducto();
					bool hasRows = sqlDataReader.HasRows;
					if (hasRows)
					{
						frmWaitMsg.Show();
						Application.DoEvents();
						while (sqlDataReader.Read())
						{
							string text6 = Conversions.ToString(sqlDataReader[0]);
							int num3 = Conversions.ToInteger(sqlDataReader[1]);
							DateTime dateTime = Conversions.ToDate(sqlDataReader[2]);
							string text7 = Conversions.ToString(sqlDataReader[3]);
							double num4 = Conversions.ToDouble(sqlDataReader[4]);
							double num5 = Conversions.ToDouble(sqlDataReader[5]);
							double num6 = Conversions.ToDouble(sqlDataReader[6]);
							double num7 = Conversions.ToDouble(sqlDataReader[7]);
							double num8 = Conversions.ToDouble(sqlDataReader[8]);
							double num9 = Conversions.ToDouble(sqlDataReader[9]);
							string text8 = Conversions.ToString(sqlDataReader[10]);
							string text9 = Conversions.ToString(sqlDataReader[12]);
							bool flag3 = Operators.ConditionalCompareObjectEqual(sqlDataReader[14], true, false);
							string left;
							if (flag3)
							{
								left = "Si";
							}
							else
							{
								left = "No";
							}
							bool flag4 = Operators.ConditionalCompareObjectEqual(sqlDataReader[11], true, false);
							string text10;
							if (flag4)
							{
								text10 = "Si";
							}
							else
							{
								text10 = "No";
							}
							string text11 = Conversions.ToString(sqlDataReader[13]);
							string text12 = Conversions.ToString(sqlDataReader[15]);
							bool flag5 = this.chkTarjCred.Checked & num6 > 0.0;
							if (flag5)
							{
								flag6 = true;
							}
							bool flag7 = this.chkVales.Checked & num7 > 0.0;
							if (flag7)
							{
								flag6 = true;
							}
							bool flag8 = this.chkOtros.Checked & num8 > 0.0;
							if (flag8)
							{
								flag6 = true;
							}
							bool flag9 = this.chkEfectivo.Checked & num5 > 0.0;
							if (flag9)
							{
								flag6 = true;
							}
							bool flag10 = this.chkFacturada.Checked & Operators.CompareString(text10, "Si", false) == 0;
							if (flag10)
							{
								flag6 = true;
							}
							bool flag11 = this.chkNotaConsumo.Checked & Operators.CompareString(text12, "0", false) != 0;
							if (flag11)
							{
								flag6 = true;
							}
							bool flag12 = !this.chkTarjCred.Checked & num6 > 0.0;
							if (flag12)
							{
								flag6 = false;
							}
							bool flag13 = !this.chkVales.Checked & num7 > 0.0;
							if (flag13)
							{
								flag6 = false;
							}
							bool flag14 = !this.chkOtros.Checked & num8 > 0.0;
							if (flag14)
							{
								flag6 = false;
							}
							bool flag15 = !this.chkEfectivo.Checked & num5 > 0.0;
							if (flag15)
							{
								flag6 = false;
							}
							bool flag16 = !this.chkFacturada.Checked & Operators.CompareString(text10, "Si", false) == 0;
							if (flag16)
							{
								flag6 = false;
							}
							bool flag17 = !this.chkNotaConsumo.Checked & Operators.CompareString(text12, "0", false) != 0;
							if (flag17)
							{
								flag6 = false;
							}
							bool flag18 = this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(left, "Si", false) == 0;
							if (flag18)
							{
								flag6 = true;
							}
							bool flag19 = !this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(left, "Si", false) == 0;
							if (flag19)
							{
								flag6 = false;
							}
							this.DataGridCheques.Rows.Add(new object[]
							{
								text6,
								text9.ToString(),
								num3,
								text12,
								text11,
								dateTime.ToString(),
								text7,
								text10,
								num4.ToString("N2"),
								"0",
								"0",
								num5.ToString("N2"),
								num6.ToString("N2"),
								num7.ToString("N2"),
								num8.ToString("N2"),
								num9.ToString("N2"),
								"",
								flag6
							});
							num++;
						}
						this.DataGridCheques.RowsDefaultCellStyle.ForeColor = Color.Black;
						this.DataGridCheques.DefaultCellStyle.BackColor = Color.White;
					}
				}
				bool flag20 = Operators.CompareString(text5, "Todas", false) != 0;
				if (flag20)
				{
					text4 = string.Concat(new string[]
					{
						"Select folio,numcheque ,fecha, Descuento , total , efectivo,tarjeta,vales,otros,propina,totalarticulos,facturado,seriefolio,mesa,cancelado,folionotadeconsumo from cheques where folio In ( Select foliodet from cheqdet where idproducto in  (",
						text3,
						")) and \r\n                    idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
						text,
						"' AND '",
						text2,
						"' AND \r\n                    cierre is not null and idempresa='",
						Tools.id_Empresa,
						"')\r\n                     And idempresa ='",
						Tools.id_Empresa,
						"' and seriefolio = '",
						text5,
						"' and cancelado='0' and total > '0'  order by seriefolio,numcheque"
					});
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
					this.iniciaGridChequesProducto();
					bool hasRows2 = sqlDataReader.HasRows;
					if (hasRows2)
					{
						frmWaitMsg.Show();
						Application.DoEvents();
						while (sqlDataReader.Read())
						{
							string text6 = Conversions.ToString(sqlDataReader[0]);
							int num3 = Conversions.ToInteger(sqlDataReader[1]);
							DateTime dateTime = Conversions.ToDate(sqlDataReader[2]);
							string text7 = Conversions.ToString(sqlDataReader[3]);
							double num4 = Conversions.ToDouble(sqlDataReader[4]);
							double num5 = Conversions.ToDouble(sqlDataReader[5]);
							double num6 = Conversions.ToDouble(sqlDataReader[6]);
							double num7 = Conversions.ToDouble(sqlDataReader[7]);
							double num8 = Conversions.ToDouble(sqlDataReader[8]);
							double num9 = Conversions.ToDouble(sqlDataReader[9]);
							string text8 = Conversions.ToString(sqlDataReader[10]);
							string text9 = Conversions.ToString(sqlDataReader[12]);
							bool flag21 = Operators.ConditionalCompareObjectEqual(sqlDataReader[14], true, false);
							string left;
							if (flag21)
							{
								left = "Si";
							}
							else
							{
								left = "No";
							}
							bool flag22 = Operators.ConditionalCompareObjectEqual(sqlDataReader[11], true, false);
							string text10;
							if (flag22)
							{
								text10 = "Si";
							}
							else
							{
								text10 = "No";
							}
							string text11 = Conversions.ToString(sqlDataReader[13]);
							string text12 = Conversions.ToString(sqlDataReader[15]);
							bool flag23 = this.chkTarjCred.Checked & num6 > 0.0;
							if (flag23)
							{
								flag6 = true;
							}
							bool flag24 = this.chkVales.Checked & num7 > 0.0;
							if (flag24)
							{
								flag6 = true;
							}
							bool flag25 = this.chkOtros.Checked & num8 > 0.0;
							if (flag25)
							{
								flag6 = true;
							}
							bool flag26 = this.chkEfectivo.Checked & num5 > 0.0;
							if (flag26)
							{
								flag6 = true;
							}
							bool flag27 = this.chkFacturada.Checked & Operators.CompareString(text10, "Si", false) == 0;
							if (flag27)
							{
								flag6 = true;
							}
							bool flag28 = this.chkNotaConsumo.Checked & Operators.CompareString(text12, "0", false) != 0;
							if (flag28)
							{
								flag6 = true;
							}
							bool flag29 = !this.chkTarjCred.Checked & num6 > 0.0;
							if (flag29)
							{
								flag6 = false;
							}
							bool flag30 = !this.chkVales.Checked & num7 > 0.0;
							if (flag30)
							{
								flag6 = false;
							}
							bool flag31 = !this.chkOtros.Checked & num8 > 0.0;
							if (flag31)
							{
								flag6 = false;
							}
							bool flag32 = !this.chkEfectivo.Checked & num5 > 0.0;
							if (flag32)
							{
								flag6 = false;
							}
							bool flag33 = !this.chkFacturada.Checked & Operators.CompareString(text10, "Si", false) == 0;
							if (flag33)
							{
								flag6 = false;
							}
							bool flag34 = !this.chkNotaConsumo.Checked & Operators.CompareString(text12, "0", false) != 0;
							if (flag34)
							{
								flag6 = false;
							}
							bool flag35 = this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(left, "Si", false) == 0;
							if (flag35)
							{
								flag6 = true;
							}
							bool flag36 = !this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(left, "Si", false) == 0;
							if (flag36)
							{
								flag6 = false;
							}
							this.DataGridCheques.Rows.Add(new object[]
							{
								text6,
								text9.ToString(),
								num3,
								text12,
								text11,
								dateTime.ToString(),
								text7,
								text10,
								num4.ToString("N2"),
								"0",
								"0",
								num5.ToString("N2"),
								num6.ToString("N2"),
								num7.ToString("N2"),
								num8.ToString("N2"),
								num9.ToString("N2"),
								"",
								flag6
							});
							num++;
						}
						this.DataGridCheques.RowsDefaultCellStyle.ForeColor = Color.Black;
						this.DataGridCheques.DefaultCellStyle.BackColor = Color.White;
					}
				}
				int num10 = 900;
				int num11 = 0;
				try
				{
					foreach (object obj2 in ((IEnumerable)this.DataGridCheques.Rows))
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
						bool flag37 = Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells["Modificar"].Value, true, false);
						if (flag37)
						{
							dataGridViewRow2.DefaultCellStyle.BackColor = Color.Red;
							dataGridViewRow2.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
							string text13 = Conversions.ToString(dataGridViewRow2.Cells["id_folio"].Value);
							num2++;
							text4 = "Select Foliodet from Cheqdet where foliodet ='" + text13 + "' and cantidad > '1'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows3 = sqlDataReader.HasRows;
							if (hasRows3)
							{
								text4 = string.Concat(new string[]
								{
									"Insert Into ",
									Tools.BaseDatos_Modulo,
									".dbo.FF ( a,\r\n                                b,\r\n                                c,\r\n                                d,\r\n                                e,\r\n                                f,\r\n                                g,\r\n                                h,\r\n                                i,\r\n                                j,\r\n                                k,\r\n                                l,\r\n                                m,\r\n                                n,\r\n                                o,\r\n                                p,\r\n                                q,\r\n                                r,\r\n                                s,\r\n                                t,\r\n                                u,\r\n                                w,\r\n                                x,\r\n                                y,\r\n                                z,\r\n                                aa,\r\n                                bb,\r\n                                cc,\r\n                                dd,\r\n                                ee,\r\n                                ff,\r\n                                gg,\r\n                                hh,\r\n                                ii,\r\n                                jj,\r\n                                kk,\r\n                                ll,\r\n                                mm,\r\n                                nn,\r\n                                oo,\r\n                                pp,\r\n                                qq,\r\n                                rr,\r\n                                ss,\r\n                                tt,\r\n                                uu,\r\n                                ww,\r\n                                xx,\r\n                                yy,\r\n                                zz)\r\n\r\n\r\n\r\n                select foliodet , movimiento , comanda ,cantidad, idproducto , precio , descuento ,  impuesto1 , impuesto2 , impuesto3 , preciosinimpuestos , tiempo , hora ,\r\n                modificador , mitad ,comentario , idestacion , usuariodescuento , comentariodescuento , idtipodescuento , Isnull(horaproduccion,'') as horaproduccion , idproductocompuesto , \r\n                productocompuestoprincipal , preciocatalogo , marcar , idmeseroproducto , ISNULL(prioridadproduccion,'') as prioridadproduccion , estatuspatin , idcortesia , numerotarjeta ,\r\n                estadomonitor , ISNULL(llavemovto,'') as llavemovto , ISNULL(horameserofinalizado,'')  as horameserofinalizado , ISNULL(meserofinalizado,'') as meserofinalizado , sistema_envio ,\r\n                ISNULL(idturno_cierre,'') , ISNULL(procesado,'0') , promovolumen , iddispositivo , productsyncidsr , subtotalsrx , totalsrx , idmovtobillar, ISNULL(idlistaprecio,'') as idlistaprecio , \r\n                ISNULL(tipocambio,'') as tipocambio , impuestoimporte3 , estrateca_DiscountCode , estrateca_DiscountID , estrateca_DiscountAmount , ISNULL(saledetailid,0) as saledetailid\r\n                from cheqdet where foliodet = '",
									text13,
									"'"
								});
								sqlQuery.execQuery(text4);
							}
							sqlDataReader.Close();
							text4 = "select foliodet , movimiento , comanda ,cantidad, idproducto , precio , descuento ,  impuesto1 , impuesto2 , impuesto3 , preciosinimpuestos , tiempo , hora ,\r\n                modificador , mitad ,comentario , idestacion , usuariodescuento , comentariodescuento , idtipodescuento , Isnull(horaproduccion,'') as horaproduccion , idproductocompuesto , \r\n                productocompuestoprincipal , preciocatalogo , marcar , idmeseroproducto , ISNULL(prioridadproduccion,'') as prioridadproduccion , estatuspatin , idcortesia , numerotarjeta ,\r\n                estadomonitor , ISNULL(llavemovto,'') as llavemovto , ISNULL(horameserofinalizado,'')  as horameserofinalizado , ISNULL(meserofinalizado,'') as meserofinalizado , sistema_envio ,\r\n                ISNULL(idturno_cierre,'') , ISNULL(procesado,'0') , promovolumen , iddispositivo , productsyncidsr , subtotalsrx , totalsrx , idmovtobillar, ISNULL(idlistaprecio,'') as idlistaprecio , \r\n                ISNULL(tipocambio,'') as tipocambio , impuestoimporte3 , estrateca_DiscountCode , estrateca_DiscountID , estrateca_DiscountAmount , ISNULL(saledetailid,0) as saledetailid\r\n                from cheqdet where foliodet = '" + text13 + "' and cantidad > 1 ";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows4 = sqlDataReader.HasRows;
							if (hasRows4)
							{
								while (sqlDataReader.Read())
								{
									int num12 = Conversions.ToInteger(sqlDataReader[3]);
									string text14 = Conversions.ToString(sqlDataReader[2]);
									string text15 = Conversions.ToString(sqlDataReader[4]);
									double num13 = Conversions.ToDouble(sqlDataReader[5]);
									double num14 = Conversions.ToDouble(sqlDataReader[6]);
									double num15 = Conversions.ToDouble(sqlDataReader[7]);
									double num16 = Conversions.ToDouble(sqlDataReader[8]);
									double num17 = Conversions.ToDouble(sqlDataReader[9]);
									double num18 = Conversions.ToDouble(sqlDataReader[10]);
									string text16 = Conversions.ToString(sqlDataReader[11]);
									DateTime dateTime2 = Conversions.ToDate(sqlDataReader[12]);
									string text17 = Conversions.ToString(sqlDataReader[13]);
									string text18 = Conversions.ToString(sqlDataReader[14]);
									string text19 = Conversions.ToString(sqlDataReader[15]);
									string text20 = Conversions.ToString(sqlDataReader[16]);
									string text21 = Conversions.ToString(sqlDataReader[17]);
									string text22 = Conversions.ToString(sqlDataReader[18]);
									string text23 = Conversions.ToString(sqlDataReader[19]);
									DateTime dateTime3 = Conversions.ToDate(sqlDataReader[20]);
									string text24 = Conversions.ToString(sqlDataReader[21]);
									string text25 = Conversions.ToString(sqlDataReader[22]);
									double num19 = Conversions.ToDouble(sqlDataReader[23]);
									string text26 = Conversions.ToString(sqlDataReader[24]);
									string text27 = Conversions.ToString(sqlDataReader[25]);
									string text28 = Conversions.ToString(sqlDataReader[26]);
									string text29 = Conversions.ToString(sqlDataReader[27]);
									string text30 = Conversions.ToString(sqlDataReader[28]);
									string text31 = Conversions.ToString(sqlDataReader[29]);
									string text32 = Conversions.ToString(sqlDataReader[30]);
									string text33 = Conversions.ToString(sqlDataReader[31]);
									string text34 = Conversions.ToString(sqlDataReader[32]);
									string text35 = Conversions.ToString(sqlDataReader[33]);
									string text36 = Conversions.ToString(sqlDataReader[34]);
									string text37 = Conversions.ToString(sqlDataReader[35]);
									string text38 = Conversions.ToString(sqlDataReader[36]);
									string text39 = Conversions.ToString(sqlDataReader[37]);
									string text40 = Conversions.ToString(sqlDataReader[38]);
									string text41 = Conversions.ToString(sqlDataReader[39]);
									string text42 = Conversions.ToString(sqlDataReader[40]);
									string text43 = Conversions.ToString(sqlDataReader[41]);
									string text44 = Conversions.ToString(sqlDataReader[42]);
									string text45 = Conversions.ToString(sqlDataReader[43]);
									string text46 = Conversions.ToString(sqlDataReader[44]);
									double num20 = Conversions.ToDouble(sqlDataReader[45]);
									string text47 = Conversions.ToString(sqlDataReader[46]);
									string text48 = Conversions.ToString(sqlDataReader[47]);
									string text49 = Conversions.ToString(sqlDataReader[48]);
									string text50 = Conversions.ToString(sqlDataReader[49]);
									int num21 = num12;
									for (int i = 1; i <= num21; i++)
									{
										text4 = string.Concat(new string[]
										{
											"insert into cheqdet (\r\n                                Foliodet,\r\n                                movimiento,\r\n                                comanda,\r\n                                cantidad,\r\n                                idproducto,\r\n                                descuento,\r\n                                precio,\r\n                                impuesto1,\r\n                                impuesto2,\r\n                                impuesto3,\r\n                                preciosinimpuestos,\r\n                                tiempo,\r\n                                hora,\r\n                                modificador,\r\n                                mitad,\r\n                                comentario,\r\n                                idestacion,\r\n                                usuariodescuento,\r\n                                comentariodescuento,\r\n                                idtipodescuento,\r\n                                horaproduccion,\r\n                                idproductocompuesto,\r\n                                productocompuestoprincipal,\r\n                                preciocatalogo,\r\n                                marcar,\r\n                                idmeseroproducto,\r\n                                prioridadproduccion,\r\n                                estatuspatin,\r\n                                idcortesia,\r\n                                numerotarjeta,\r\n                                estadomonitor,\r\n                                llavemovto,\r\n                                horameserofinalizado,\r\n                                meserofinalizado,\r\n                                sistema_envio,\r\n                                idturno_cierre,\r\n                                procesado,\r\n                                promovolumen,\r\n                                iddispositivo,\r\n                                productsyncidsr,\r\n                                subtotalsrx,\r\n                                totalsrx,\r\n                                idmovtobillar,\r\n                                idlistaprecio,\r\n                                tipocambio,\r\n                                impuestoimporte3,\r\n                                estrateca_DiscountCode,\r\n                                estrateca_DiscountID,\r\n                                estrateca_DiscountAmount,\r\n                                saledetailid\r\n\r\n                               )\r\n\r\n\r\n                                Values(\r\n                                '",
											text13.ToString(),
											"',\r\n                                '",
											num10.ToString(),
											"',\r\n                                '',\r\n                                '1',\r\n                                '",
											text15.ToString(),
											"',\r\n                                '",
											num14.ToString(),
											"',\r\n                                '",
											num13.ToString("N2"),
											"',\r\n                                '",
											num15.ToString("N2"),
											"',\r\n                                '",
											num16.ToString("N2"),
											"',\r\n                                '",
											num17.ToString("N2"),
											"',\r\n                                '",
											num18.ToString("N2"),
											"',\r\n                                '",
											text16,
											"',\r\n                                '",
											dateTime2.ToString(Tools.strFormatoFechaLargo),
											"',\r\n                                '",
											text17.ToString(),
											"',\r\n                                '",
											text18.ToString(),
											"',\r\n                                '",
											text19.ToString(),
											"',\r\n                                '",
											text20.ToString(),
											"',\r\n                                '",
											text21,
											"',\r\n                                '",
											text22.ToString(),
											"',\r\n                                '",
											text23.ToString(),
											"',\r\n                                '",
											dateTime3.ToString(Tools.strFormatoFechaLargo),
											"',\r\n                                '",
											text24.ToString(),
											"',\r\n                                '",
											text25.ToString(),
											"',\r\n                                '",
											num19.ToString("N2"),
											"',\r\n                                '",
											text26.ToString(),
											"',\r\n                                '",
											text27.ToString(),
											"',\r\n                                '",
											text28.ToString(),
											"',\r\n                                ",
											text29.ToString(),
											",\r\n                                '",
											text30.ToString(),
											"',\r\n                                '",
											text31.ToString(),
											"',\r\n                                '",
											text32.ToString(),
											"',\r\n                                '",
											text33.ToString(),
											"',\r\n                                '",
											text34.ToString(),
											"',\r\n                                '",
											text35.ToString(),
											"',\r\n                                '",
											text36.ToString(),
											"',\r\n                                '",
											text37.ToString(),
											"',\r\n                                '",
											text38.ToString(),
											"',\r\n                                '",
											text39.ToString(),
											"',\r\n                                '",
											text40.ToString(),
											"',\r\n                                '",
											text41.ToString(),
											"',\r\n                                '",
											text42.ToString(),
											"',\r\n                                '",
											text43.ToString(),
											"',\r\n                                '",
											text44.ToString(),
											"',\r\n                                '",
											text45.ToString(),
											"',\r\n                                '",
											text46.ToString(),
											"',\r\n                                '",
											num20.ToString("N2"),
											"',                            \r\n                                '",
											text47.ToString(),
											"',\r\n                                '",
											text48.ToString(),
											"',\r\n                                '",
											text49,
											"',\r\n                                '",
											text50.ToString(),
											"')"
										});
										sqlQuery.execQuery(text4);
										num10++;
									}
									text4 = string.Concat(new string[]
									{
										"DELETE FROM CHEQDET WHERE Cantidad = '",
										num12.ToString(),
										"' and Foliodet = '",
										text13,
										"'"
									});
									sqlQuery.execQuery(text4);
									num10 = 900;
								}
								text4 = "SELECT foliodet , movimiento , hora , idproducto , precio from cheqdet WITH (NOLOCK) where foliodet ='" + text13 + "' order by movimiento asc";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows5 = sqlDataReader.HasRows;
								if (hasRows5)
								{
									while (sqlDataReader.Read())
									{
										string text51 = Conversions.ToString(sqlDataReader[1]);
										DateTime dateTime4 = Conversions.ToDate(sqlDataReader[2]);
										num11++;
										double num22 = Conversions.ToDouble(sqlDataReader[4]);
										string text52 = Conversions.ToString(sqlDataReader[3]);
										text4 = string.Concat(new string[]
										{
											"Set transaction isolation level read uncommitted\r\n\r\n                                                Update cheqdet set movimiento ='",
											num11.ToString(),
											"' where foliodet = '",
											text13,
											"' and movimiento= '",
											text51.ToString(),
											"' and idproducto='",
											text52.ToString(),
											"' and hora = '",
											dateTime4.ToString(Tools.strFormatoFechaLargo),
											"' and Precio='",
											num22.ToString("N2"),
											"'"
										});
										sqlQuery.execQuery(text4);
									}
									num11 = 0;
								}
							}
							sqlDataReader.Close();
							text4 = (("Select foliodet , movimiento , cantidad , idproducto , precio , impuesto1 , preciosinimpuestos from cheqdet where idproducto in  (" + text3 + ") and foliodet = " + text13) ?? "");
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows6 = sqlDataReader.HasRows;
							if (hasRows6)
							{
								while (sqlDataReader.Read())
								{
									string text53 = Conversions.ToString(sqlDataReader[0]);
									string text54 = Conversions.ToString(sqlDataReader[1]);
									string text55 = Conversions.ToString(sqlDataReader[2]);
									string text56 = Conversions.ToString(sqlDataReader[3]);
									double num23 = Conversions.ToDouble(sqlDataReader[4]);
									double num24 = Conversions.ToDouble(sqlDataReader[5]);
									double num25 = Conversions.ToDouble(sqlDataReader[6]);
									text4 = string.Concat(new string[]
									{
										"Insert into F (a,b,c,d,e,f,g) \r\n                                values ('",
										text53,
										"','",
										text54,
										"','",
										text55,
										"','",
										text56.ToString(),
										"','",
										num23.ToString("N2"),
										"','",
										num24.ToString("N2"),
										"','",
										num25.ToString("N2"),
										"')"
									});
									sqlQuery_Conn.execQuery_conn(text4);
								}
							}
							sqlDataReader.Close();
							text4 = (("Select count(cantidad) from cheqdet where idproducto In  (" + text3 + ") And foliodet = " + text13) ?? "");
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows7 = sqlDataReader.HasRows;
							if (hasRows7)
							{
								sqlDataReader.Read();
								int num26 = Conversions.ToInteger(sqlDataReader[0]);
								dataGridViewRow2.Cells[9].Value = num26;
							}
							sqlDataReader.Close();
						}
						else
						{
							bool flag38 = Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells["Modificar"].Value, false, false);
							if (flag38)
							{
								string str = Conversions.ToString(dataGridViewRow2.Cells["id_folio"].Value);
								dataGridViewRow2.DefaultCellStyle.BackColor = Color.White;
								text4 = (("Select count(cantidad) from cheqdet where idproducto In  (" + text3 + ") And foliodet = " + str) ?? "");
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows8 = sqlDataReader.HasRows;
								if (hasRows8)
								{
									sqlDataReader.Read();
									string value = Conversions.ToString(sqlDataReader[0]);
									dataGridViewRow2.Cells[9].Value = value;
								}
								sqlDataReader.Close();
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
					foreach (object obj3 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj3;
						bool flag39 = Operators.ConditionalCompareObjectNotEqual(dataGridViewRow3.Cells["ID Producto."].Value, "", false);
						if (flag39)
						{
							string text57 = Conversions.ToString(dataGridViewRow3.Cells["ID Producto"].Value);
							string text58 = Conversions.ToString(dataGridViewRow3.Cells["ID Producto."].Value);
							double num27 = Conversions.ToDouble(dataGridViewRow3.Cells["Precio a sustituir"].Value);
							double num28 = Conversions.ToDouble(dataGridViewRow3.Cells["Precio sin impuestos a sustitur"].Value);
							text4 = string.Concat(new string[]
							{
								"Update F set d = '",
								text58.ToString(),
								"' , e = '",
								num27.ToString("N2"),
								"'  , g = '",
								num28.ToString("N2"),
								"' WHERE \r\n                            d ='",
								text57.ToString(),
								"'"
							});
							sqlQuery_Conn.execQuery_conn(text4);
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
			try
			{
				foreach (object obj4 in ((IEnumerable)this.DataGridCheques.Rows))
				{
					DataGridViewRow dataGridViewRow4 = (DataGridViewRow)obj4;
					bool flag40 = Operators.ConditionalCompareObjectEqual(dataGridViewRow4.Cells["Modificar"].Value, true, false);
					if (flag40)
					{
						string text59 = Conversions.ToString(dataGridViewRow4.Cells["id_folio"].Value);
						double num29 = Conversions.ToDouble(dataGridViewRow4.Cells["Total Original"].Value);
						text4 = (("Select sum(precio) from cheqdet where idproducto In  (" + text3 + ") And foliodet =  " + text59) ?? "");
						sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
						bool hasRows9 = sqlDataReader.HasRows;
						double num30;
						if (hasRows9)
						{
							while (sqlDataReader.Read())
							{
								num30 = Conversions.ToDouble(sqlDataReader[0]);
							}
							sqlDataReader.Close();
						}
						text4 = "Select sum(e) from F where a = '" + text59 + "'";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
						bool hasRows10 = sqlDataReader.HasRows;
						double num31;
						if (hasRows10)
						{
							while (sqlDataReader.Read())
							{
								num31 = Conversions.ToDouble(sqlDataReader[0]);
							}
						}
						dataGridViewRow4.Cells[10].Value = (num29 - num30 + num31).ToString("N2");
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
			double num32;
			double num33;
			double num34;
			double num35;
			double num36;
			double num37;
			double num38;
			double num39;
			double num40;
			double num41;
			double num42;
			double num43;
			try
			{
				foreach (object obj5 in ((IEnumerable)this.DataGridCheques.Rows))
				{
					DataGridViewRow dataGridViewRow5 = (DataGridViewRow)obj5;
					bool flag41 = Operators.ConditionalCompareObjectEqual(dataGridViewRow5.Cells["Modificar"].Value, true, false);
					if (flag41)
					{
						dataGridViewRow5.DefaultCellStyle.BackColor = Color.Red;
						string text13 = Conversions.ToString(dataGridViewRow5.Cells["id_folio"].Value);
						dataGridViewRow5.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
						num32 += Conversions.ToDouble(dataGridViewRow5.Cells["Total Original"].Value);
						num33 += Conversions.ToDouble(dataGridViewRow5.Cells["Propina"].Value);
						bool flag42 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow5.Cells["Modificar"].Value, true, false), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Vales"].Value, 0, false)));
						if (flag42)
						{
							num34 += Conversions.ToDouble(dataGridViewRow5.Cells["Efectivo"].Value);
							num35 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
							text4 = "SELECT i from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag43 = sqlDataReader.Read();
							if (flag43)
							{
								string text60 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text60.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows11 = sqlDataReader.HasRows;
								if (hasRows11)
								{
									while (sqlDataReader.Read())
									{
										string text61 = Conversions.ToString(sqlDataReader[0]);
										string value2 = Conversions.ToString(sqlDataReader[1]);
										bool flag44 = Conversions.ToDouble(value2) == 4.0;
										if (flag44)
										{
											num36 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag45 = Conversions.ToDouble(value2) == 3.0;
										if (flag45)
										{
											num37 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag46 = Conversions.ToDouble(value2) == 1.0;
										if (flag46)
										{
											num38 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag47 = Conversions.ToDouble(value2) == 2.0;
										if (flag47)
										{
											num39 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
									}
								}
								else
								{
									num34 += 0.0;
									num35 += 0.0;
								}
							}
						}
						bool flag48 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow5.Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Vales"].Value, 0, false)));
						if (flag48)
						{
							num35 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
							num40 += Conversions.ToDouble(dataGridViewRow5.Cells["Tarjeta"].Value);
							text4 = "SELECT j from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag49 = sqlDataReader.Read();
							if (flag49)
							{
								string text62 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text62.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows12 = sqlDataReader.HasRows;
								if (hasRows12)
								{
									while (sqlDataReader.Read())
									{
										string text61 = Conversions.ToString(sqlDataReader[0]);
										string value2 = Conversions.ToString(sqlDataReader[1]);
										bool flag50 = Conversions.ToDouble(value2) == 4.0;
										if (flag50)
										{
											num36 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag51 = Conversions.ToDouble(value2) == 3.0;
										if (flag51)
										{
											num37 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag52 = Conversions.ToDouble(value2) == 1.0;
										if (flag52)
										{
											num38 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag53 = Conversions.ToDouble(value2) == 2.0;
										if (flag53)
										{
											num39 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
									}
								}
								else
								{
									num35 += 0.0;
									num40 += 0.0;
								}
							}
						}
						bool flag54 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow5.Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Vales"].Value, 0, false)));
						if (flag54)
						{
							num35 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
							num41 += Conversions.ToDouble(dataGridViewRow5.Cells["Otros"].Value);
							text4 = "SELECT l from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag55 = sqlDataReader.Read();
							if (flag55)
							{
								string text63 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text63.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows13 = sqlDataReader.HasRows;
								if (hasRows13)
								{
									while (sqlDataReader.Read())
									{
										string text61 = Conversions.ToString(sqlDataReader[0]);
										string value2 = Conversions.ToString(sqlDataReader[1]);
										bool flag56 = Conversions.ToDouble(value2) == 4.0;
										if (flag56)
										{
											num36 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag57 = Conversions.ToDouble(value2) == 3.0;
										if (flag57)
										{
											num37 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag58 = Conversions.ToDouble(value2) == 1.0;
										if (flag58)
										{
											num38 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag59 = Conversions.ToDouble(value2) == 2.0;
										if (flag59)
										{
											num39 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
									}
								}
								else
								{
									num35 += 0.0;
									num41 += 0.0;
								}
							}
						}
						bool flag60 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow5.Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Vales"].Value, 0, false)));
						if (flag60)
						{
							num35 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
							num42 += Conversions.ToDouble(dataGridViewRow5.Cells["Vales"].Value);
							text4 = "SELECT k from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag61 = sqlDataReader.Read();
							if (flag61)
							{
								string text64 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text64.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows14 = sqlDataReader.HasRows;
								if (hasRows14)
								{
									while (sqlDataReader.Read())
									{
										string text61 = Conversions.ToString(sqlDataReader[0]);
										string value2 = Conversions.ToString(sqlDataReader[1]);
										bool flag62 = Conversions.ToDouble(value2) == 4.0;
										if (flag62)
										{
											num36 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag63 = Conversions.ToDouble(value2) == 3.0;
										if (flag63)
										{
											num37 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag64 = Conversions.ToDouble(value2) == 1.0;
										if (flag64)
										{
											num38 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag65 = Conversions.ToDouble(value2) == 2.0;
										if (flag65)
										{
											num39 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
									}
								}
								else
								{
									num35 += 0.0;
									num42 += 0.0;
								}
							}
						}
						bool flag66 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow5.Cells["Modificar"].Value, true, false), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Vales"].Value, 0, false)));
						if (flag66)
						{
							num35 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
							num40 += Conversions.ToDouble(dataGridViewRow5.Cells["Tarjeta"].Value);
							num34 += Conversions.ToDouble(dataGridViewRow5.Cells["Efectivo"].Value);
							text4 = "SELECT m from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag67 = sqlDataReader.Read();
							if (flag67)
							{
								string text65 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text65.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows15 = sqlDataReader.HasRows;
								if (hasRows15)
								{
									while (sqlDataReader.Read())
									{
										string text61 = Conversions.ToString(sqlDataReader[0]);
										string value2 = Conversions.ToString(sqlDataReader[1]);
										bool flag68 = Conversions.ToDouble(value2) == 4.0;
										if (flag68)
										{
											num36 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag69 = Conversions.ToDouble(value2) == 3.0;
										if (flag69)
										{
											num37 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag70 = Conversions.ToDouble(value2) == 1.0;
										if (flag70)
										{
											num38 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag71 = Conversions.ToDouble(value2) == 2.0;
										if (flag71)
										{
											num39 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
									}
								}
								else
								{
									num35 += 0.0;
									num40 += 0.0;
									num34 += 0.0;
								}
							}
						}
						bool flag72 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow5.Cells["Modificar"].Value, true, false), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Vales"].Value, 0, false)));
						if (flag72)
						{
							num35 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
							num42 += Conversions.ToDouble(dataGridViewRow5.Cells["Vales"].Value);
							num34 += Conversions.ToDouble(dataGridViewRow5.Cells["Efectivo"].Value);
							text4 = "SELECT m from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag73 = sqlDataReader.Read();
							if (flag73)
							{
								string text65 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text65.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows16 = sqlDataReader.HasRows;
								if (hasRows16)
								{
									while (sqlDataReader.Read())
									{
										string text61 = Conversions.ToString(sqlDataReader[0]);
										string value2 = Conversions.ToString(sqlDataReader[1]);
										bool flag74 = Conversions.ToDouble(value2) == 4.0;
										if (flag74)
										{
											num36 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag75 = Conversions.ToDouble(value2) == 3.0;
										if (flag75)
										{
											num37 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag76 = Conversions.ToDouble(value2) == 1.0;
										if (flag76)
										{
											num38 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag77 = Conversions.ToDouble(value2) == 2.0;
										if (flag77)
										{
											num39 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
									}
								}
								else
								{
									num35 += 0.0;
									num42 += 0.0;
									num34 += 0.0;
								}
							}
						}
						bool flag78 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow5.Cells["Modificar"].Value, true, false), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Vales"].Value, 0, false)));
						if (flag78)
						{
							num35 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
							num41 += Conversions.ToDouble(dataGridViewRow5.Cells["Otros"].Value);
							num34 += Conversions.ToDouble(dataGridViewRow5.Cells["Efectivo"].Value);
							text4 = "SELECT m from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag79 = sqlDataReader.Read();
							if (flag79)
							{
								string text65 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text65.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows17 = sqlDataReader.HasRows;
								if (hasRows17)
								{
									while (sqlDataReader.Read())
									{
										string text61 = Conversions.ToString(sqlDataReader[0]);
										string value2 = Conversions.ToString(sqlDataReader[1]);
										bool flag80 = Conversions.ToDouble(value2) == 4.0;
										if (flag80)
										{
											num36 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag81 = Conversions.ToDouble(value2) == 3.0;
										if (flag81)
										{
											num37 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag82 = Conversions.ToDouble(value2) == 1.0;
										if (flag82)
										{
											num38 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag83 = Conversions.ToDouble(value2) == 2.0;
										if (flag83)
										{
											num39 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
									}
								}
								else
								{
									num35 += 0.0;
									num41 += 0.0;
									num34 += 0.0;
								}
							}
						}
						bool flag84 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow5.Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Vales"].Value, 0, false)));
						if (flag84)
						{
							num35 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
							num40 += Conversions.ToDouble(dataGridViewRow5.Cells["Tarjeta"].Value);
							num42 += Conversions.ToDouble(dataGridViewRow5.Cells["Vales"].Value);
							text4 = "SELECT m from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag85 = sqlDataReader.Read();
							if (flag85)
							{
								string text65 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text65.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows18 = sqlDataReader.HasRows;
								if (hasRows18)
								{
									while (sqlDataReader.Read())
									{
										string text61 = Conversions.ToString(sqlDataReader[0]);
										string value2 = Conversions.ToString(sqlDataReader[1]);
										bool flag86 = Conversions.ToDouble(value2) == 4.0;
										if (flag86)
										{
											num36 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag87 = Conversions.ToDouble(value2) == 3.0;
										if (flag87)
										{
											num37 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag88 = Conversions.ToDouble(value2) == 1.0;
										if (flag88)
										{
											num38 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag89 = Conversions.ToDouble(value2) == 2.0;
										if (flag89)
										{
											num39 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
									}
								}
								else
								{
									num35 += 0.0;
									num40 += 0.0;
									num41 += 0.0;
								}
							}
						}
						bool flag90 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow5.Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Vales"].Value, 0, false)));
						if (flag90)
						{
							num35 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
							num40 += Conversions.ToDouble(dataGridViewRow5.Cells["Tarjeta"].Value);
							num41 += Conversions.ToDouble(dataGridViewRow5.Cells["Otros"].Value);
							text4 = "SELECT m from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag91 = sqlDataReader.Read();
							if (flag91)
							{
								string text65 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text65.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows19 = sqlDataReader.HasRows;
								if (hasRows19)
								{
									while (sqlDataReader.Read())
									{
										string text61 = Conversions.ToString(sqlDataReader[0]);
										string value2 = Conversions.ToString(sqlDataReader[1]);
										bool flag92 = Conversions.ToDouble(value2) == 4.0;
										if (flag92)
										{
											num36 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag93 = Conversions.ToDouble(value2) == 3.0;
										if (flag93)
										{
											num37 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag94 = Conversions.ToDouble(value2) == 1.0;
										if (flag94)
										{
											num38 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag95 = Conversions.ToDouble(value2) == 2.0;
										if (flag95)
										{
											num39 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
									}
								}
								else
								{
									num35 += 0.0;
									num40 += 0.0;
									num41 += 0.0;
								}
							}
						}
						bool flag96 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow5.Cells["Modificar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Tarjeta"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow5.Cells["Vales"].Value, 0, false)));
						if (flag96)
						{
							num35 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
							num42 += Conversions.ToDouble(dataGridViewRow5.Cells["Vales"].Value);
							num41 += Conversions.ToDouble(dataGridViewRow5.Cells["Otros"].Value);
							text4 = "SELECT m from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag97 = sqlDataReader.Read();
							if (flag97)
							{
								string text65 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text65.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows20 = sqlDataReader.HasRows;
								if (hasRows20)
								{
									while (sqlDataReader.Read())
									{
										string text61 = Conversions.ToString(sqlDataReader[0]);
										string value2 = Conversions.ToString(sqlDataReader[1]);
										bool flag98 = Conversions.ToDouble(value2) == 4.0;
										if (flag98)
										{
											num36 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag99 = Conversions.ToDouble(value2) == 3.0;
										if (flag99)
										{
											num37 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag100 = Conversions.ToDouble(value2) == 1.0;
										if (flag100)
										{
											num38 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
										bool flag101 = Conversions.ToDouble(value2) == 2.0;
										if (flag101)
										{
											num39 += Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
										}
									}
								}
								else
								{
									num35 += 0.0;
									num42 += 0.0;
									num41 += 0.0;
								}
							}
						}
						bool flag102 = Operators.ConditionalCompareObjectEqual(dataGridViewRow5.Cells["Facturado"].Value, "Si", false);
						if (flag102)
						{
							num43 += Conversions.ToDouble(dataGridViewRow5.Cells["Total Original"].Value) - Conversions.ToDouble(dataGridViewRow5.Cells["Total con Descuento"].Value);
						}
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
			bool flag103 = Operators.CompareString(text5, "Todas", false) == 0;
			double num44;
			if (flag103)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(Total) IS NULL then 0 else sum(Total) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
				bool hasRows21 = sqlDataReader.HasRows;
				if (hasRows21)
				{
					while (sqlDataReader.Read())
					{
						num44 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
			}
			bool flag104 = Operators.CompareString(text5, "Todas", false) != 0;
			if (flag104)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(Total) IS NULL then 0 else sum(Total) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"' and seriefolio='",
					text5,
					"' and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				bool hasRows22 = sqlDataReader.HasRows;
				if (hasRows22)
				{
					while (sqlDataReader.Read())
					{
						num44 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
			}
			bool flag105 = Operators.CompareString(text5, "Todas", false) == 0;
			double num45;
			if (flag105)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(Efectivo) IS NULL then 0 else sum(Efectivo) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
				bool hasRows23 = sqlDataReader.HasRows;
				if (hasRows23)
				{
					while (sqlDataReader.Read())
					{
						num45 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
			}
			bool flag106 = Operators.CompareString(text5, "Todas", false) != 0;
			if (flag106)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(Efectivo) IS NULL then 0 else sum(Efectivo) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"' and seriefolio='",
					text5,
					"' and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				bool hasRows24 = sqlDataReader.HasRows;
				if (hasRows24)
				{
					while (sqlDataReader.Read())
					{
						num45 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
			}
			bool flag107 = Operators.CompareString(text5, "Todas", false) == 0;
			double num46;
			if (flag107)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(Tarjeta) IS NULL then 0 else sum(Tarjeta) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
				bool hasRows25 = sqlDataReader.HasRows;
				if (hasRows25)
				{
					while (sqlDataReader.Read())
					{
						num46 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
			}
			bool flag108 = Operators.CompareString(text5, "Todas", false) != 0;
			if (flag108)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(Tarjeta) IS NULL then 0 else sum(Tarjeta) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"' and seriefolio='",
					text5,
					"' and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				bool hasRows26 = sqlDataReader.HasRows;
				if (hasRows26)
				{
					while (sqlDataReader.Read())
					{
						num46 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
			}
			bool flag109 = Operators.CompareString(text5, "Todas", false) == 0;
			double num47;
			if (flag109)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(Vales) IS NULL then 0 else sum(Vales) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
				bool hasRows27 = sqlDataReader.HasRows;
				if (hasRows27)
				{
					while (sqlDataReader.Read())
					{
						num47 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
			}
			bool flag110 = Operators.CompareString(text5, "Todas", false) != 0;
			if (flag110)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(Vales) IS NULL then 0 else sum(Vales) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"' and seriefolio='",
					text5,
					"' and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				bool hasRows28 = sqlDataReader.HasRows;
				if (hasRows28)
				{
					while (sqlDataReader.Read())
					{
						num47 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
			}
			bool flag111 = Operators.CompareString(text5, "Todas", false) == 0;
			double num48;
			if (flag111)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(Otros) IS NULL then 0 else sum(Otros) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
				bool hasRows29 = sqlDataReader.HasRows;
				if (hasRows29)
				{
					while (sqlDataReader.Read())
					{
						num48 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
			}
			bool flag112 = Operators.CompareString(text5, "Todas", false) != 0;
			if (flag112)
			{
				text4 = string.Concat(new string[]
				{
					"select case when sum(Otros) IS NULL then 0 else sum(Otros) end from cheques where  idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
					text,
					"' AND '",
					text2,
					"' AND \r\n                    cierre is not null and idempresa='",
					Tools.id_Empresa,
					"')\r\n                    and idempresa='",
					Tools.id_Empresa,
					"' and seriefolio='",
					text5,
					"' and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				bool hasRows30 = sqlDataReader.HasRows;
				if (hasRows30)
				{
					while (sqlDataReader.Read())
					{
						num48 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
			}
			bool flag113 = Operators.CompareString(text5, "Todas", false) == 0;
			double num49;
			if (flag113)
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
				bool hasRows31 = sqlDataReader.HasRows;
				if (hasRows31)
				{
					while (sqlDataReader.Read())
					{
						num49 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
			}
			bool flag114 = Operators.CompareString(text5, "Todas", false) != 0;
			if (flag114)
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
					text5,
					"'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				bool hasRows32 = sqlDataReader.HasRows;
				if (hasRows32)
				{
					while (sqlDataReader.Read())
					{
						num49 = Conversions.ToDouble(sqlDataReader[0]);
					}
					sqlDataReader.Close();
				}
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
				"' and tipo = '1' "
			});
			sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
			sqlDataReader.Read();
			bool hasRows33 = sqlDataReader.HasRows;
			double num50;
			if (hasRows33)
			{
				num50 = Conversions.ToDouble(sqlDataReader[0]);
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
				"' and tipo = '2' "
			});
			sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
			sqlDataReader.Read();
			bool hasRows34 = sqlDataReader.HasRows;
			double num51;
			if (hasRows34)
			{
				num51 = Conversions.ToDouble(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			bool flag115 = Operators.CompareString(text5, "Todas", false) == 0;
			double num52;
			double num53;
			if (flag115)
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
					"' and facturado = '1' and cancelado='0' "
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows35 = sqlDataReader.HasRows;
				if (hasRows35)
				{
					num52 = Conversions.ToDouble(sqlDataReader[0]);
					num53 = Conversions.ToDouble(sqlDataReader[0]);
					this.lblventaFacturada.Text = "$ " + num53.ToString("N2");
				}
				sqlDataReader.Close();
			}
			bool flag116 = Operators.CompareString(text5, "Todas", false) != 0;
			if (flag116)
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
					"' and facturado = '1' and seriefolio='",
					text5,
					"' and cancelado='0'"
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows36 = sqlDataReader.HasRows;
				if (hasRows36)
				{
					num52 = Conversions.ToDouble(sqlDataReader[0]);
					num53 = Conversions.ToDouble(sqlDataReader[0]);
					this.lblventaFacturada.Text = "$ " + num53.ToString("N2");
				}
				sqlDataReader.Close();
			}
			this.DataGridCheques.ClearSelection();
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
			bool hasRows37 = sqlDataReader.HasRows;
			double num54;
			if (hasRows37)
			{
				num54 = Conversions.ToDouble(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			bool flag117 = !this.chkEliminaProp.Checked;
			double num55;
			if (flag117)
			{
				this.lblpropinascortenuevo.Text = "$ " + (num49 - num33).ToString("N2");
				num55 = Conversions.ToDouble((num49 - num33).ToString("N2"));
			}
			else
			{
				this.lblpropinascortenuevo.Text = "$ 0.00";
				num55 = Conversions.ToDouble("$ 0.00");
			}
			bool flag118 = !this.chkEliminaRet.Checked;
			if (flag118)
			{
				this.lblcortenuevodepositos.Text = "$ " + num51.ToString("N2");
				this.lblcortenuevoretiros.Text = "$ " + num50.ToString("N2");
			}
			else
			{
				this.lblcortenuevodepositos.Text = "$ 0.00";
				this.lblcortenuevoretiros.Text = "$ 0.00";
				num50 = 0.0;
				num51 = 0.0;
			}
			bool @checked = this.CheckBoxfondocaja.Checked;
			if (@checked)
			{
				this.lblfondoincial.Text = "$ 0.00";
			}
			else
			{
				this.lblfondoincial.Text = "$ " + num54.ToString("N2");
			}
			this.txtCuentasModificar.Text = num2.ToString();
			this.txtCuentasTotal.Text = num.ToString();
			this.txtImpAnterior.Text = "$ " + num44.ToString("N2");
			this.txtEfectivoAnt.Text = "$ " + num45.ToString("N2");
			this.txtTotalPropinas.Text = "$ " + num49.ToString("N2");
			this.txtVentaTarjeta.Text = "$ " + num46.ToString("N2");
			this.txtVentasOtros.Text = "$ " + num48.ToString("N2");
			this.txtVales.Text = "$ " + num47.ToString("N2");
			this.txtretirostotal.Text = "$ " + num50.ToString("N2");
			this.txtDepositos.Text = "$ " + num51.ToString("N2");
			this.txtVentaFacturada.Text = "$ " + num52.ToString("N2");
			this.txtImpNuevo.Text = "$ " + (num44 - num32 + num35).ToString("N2");
			double num56 = Conversions.ToDouble(this.txtImpNuevo.Text);
			this.txtDifImporte.Text = "$ " + (num44 - num56).ToString("N2");
			this.txtEfectivoFiscal.Text = "$ " + (num45 - num34 + num38).ToString("N2");
			double num57 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
			this.txtDifTarjeta.Text = "$ " + (num46 - num40 + num39).ToString("N2");
			this.txtdifotros.Text = "$ " + (num48 - num41 + num36).ToString("N2");
			this.txtdifvales.Text = "$ " + (num47 - num42 + num37).ToString("N2");
			this.txtDifPorcen.Text = "$ " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			this.txtPropinasNuevo.Text = "$ " + num55.ToString("N2");
			this.txtEfectivoCaja.Text = "$ " + (num57 - num55 - num50 + num51 + num54).ToString("N2");
			double num58 = Conversions.ToDouble(this.txtEfectivoCaja.Text);
			this.txtVentaFacturada.Text = "$ " + (num52 - num43).ToString("N2");
			double num59 = Conversions.ToDouble(this.txtImpNuevo.Text);
			this.txtVentaFacturada.Text = "$ " + (num52 - num43).ToString("N2");
			double num60 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			this.txtFacturaPUB.Text = "$ " + (num59 - num60).ToString("N2");
			this.txtventasinfacturar.Text = "$ " + (num59 - num60).ToString("N2");
			double num61 = num44 - num53;
			this.lblventasinfacturarcorte.Text = "$ " + num61.ToString("N2");
			this.lblfacturapub.Text = "$ " + num61.ToString("N2");
			this.lblcortefondoinicialanterior.Text = "$ " + num54.ToString("N2");
			this.lblcorteefectivoanterior.Text = "$ " + num45.ToString("N2");
			this.lblcortetarjetaanterior.Text = "$ " + num46.ToString("N2");
			this.lblcorteanteriorvales.Text = "$ " + num47.ToString("N2");
			this.lblcorteanteriorotros.Text = "$ " + num48.ToString("N2");
			this.lblcorteanteriordepositosenefectivo.Text = "$ " + num51.ToString("N2");
			this.lblcorteanteriorretirosefectivo.Text = "$ " + num50.ToString("N2");
			this.lblcorteanteriorpropinas.Text = "$ " + num49.ToString("N2");
			double num62 = num54 + num45 + num46 + num47 + num48 + num51 - num50 - num49;
			double num63 = num54 + num45 + num51 - num50 - num49;
			this.lblcorteanteriorefectivofinal.Text = "$ " + num63.ToString("N2");
			this.lblcorteanteriorsaldo.Text = "$ " + num62.ToString("N2");
			double num64 = Conversions.ToDouble(this.lblcortenuevodepositos.Text);
			double num65 = Conversions.ToDouble(this.lblcortenuevoretiros.Text);
			double num66 = Conversions.ToDouble(this.lblpropinascortenuevo.Text);
			double num67 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
			double num68 = Conversions.ToDouble(this.txtDifTarjeta.Text);
			double num69 = Conversions.ToDouble(this.txtdifvales.Text);
			double num70 = Conversions.ToDouble(this.txtdifotros.Text);
			double num71 = Conversions.ToDouble(this.lblfondoincial.Text);
			double num72 = Conversions.ToDouble(this.txtEfectivoCaja.Text);
			double num73 = num71 + num67 + num64 - num65 - num66;
			double num74 = num71 + num67 + num68 + num69 + num70 + num64 - num65 - num66;
			this.lblEfectivonuevocorte.Text = "$ " + num72.ToString("N2");
			this.lblcorteefectivonuevo.Text = "$ " + num67.ToString("N2");
			this.lblcortetarjetanuevo.Text = "$ " + num68.ToString("N2");
			this.lblcortenuevovales.Text = "$ " + num69.ToString("N2");
			this.lblcortenuevotros.Text = "$ " + num70.ToString("N2");
			this.lblfondoinicialnuevo.Text = "$ " + num71.ToString("N2");
			this.lblEfectivonuevocorte.Text = "$ " + num73.ToString("N2");
			this.lblsaldofinarlcortenuevo.Text = "$ " + num74.ToString("N2");
			this.txtDifPorcen.Text = "% " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			this.DifPorcentajeSin = (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			this.lblventafacturanew.Text = this.txtVentaFacturada.Text;
			this.lblventasinfacturarnew.Text = this.txtventasinfacturar.Text;
			this.lblfacturapubnew.Text = this.txtFacturaPUB.Text;
			this.PanelAplicar.Visible = true;
			this.MostrarProductosReemplaza();
			bool flag119 = Conversions.ToDouble(this.txtCuentasModificar.Text) != 0.0;
			if (flag119)
			{
				this.Button1.Enabled = true;
			}
			else
			{
				this.Button1.Enabled = false;
			}
			bool flag120 = Operators.CompareString(this.txtImpAnterior.Text, "$ 0.00", false) == 0;
			if (flag120)
			{
				Interaction.MsgBox("No hay registros para mostrar en el periodo seleccionado, intenta nuevamente!", MsgBoxStyle.OkOnly, null);
			}
			this.ComboBox1.Enabled = false;
			this.Button6.PerformClick();
			frmWaitMsg.Hide();
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x000EEB24 File Offset: 0x000ECD24
		private void iniciaGridProductoReemplazar()
		{
			this.DataGridProductosElimiminar.Rows.Clear();
			this.DataGridProductosElimiminar.ColumnCount = 7;
			this.DataGridProductosElimiminar.Columns[0].Name = "Foliodet";
			this.DataGridProductosElimiminar.Columns[0].Visible = true;
			this.DataGridProductosElimiminar.Columns[1].Name = "Movimiento";
			this.DataGridProductosElimiminar.Columns[1].Width = 80;
			this.DataGridProductosElimiminar.Columns[2].Name = "Cantidad";
			this.DataGridProductosElimiminar.Columns[2].Width = 80;
			this.DataGridProductosElimiminar.Columns[3].Name = "Idproducto";
			this.DataGridProductosElimiminar.Columns[3].Width = 80;
			this.DataGridProductosElimiminar.Columns[4].Name = "Precio";
			this.DataGridProductosElimiminar.Columns[4].Width = 80;
			this.DataGridProductosElimiminar.Columns[5].Name = "Impuestos";
			this.DataGridProductosElimiminar.Columns[5].Width = 80;
			this.DataGridProductosElimiminar.Columns[6].Name = "Precio sin impuestos";
			this.DataGridProductosElimiminar.Columns[6].Width = 80;
			this.dgvProdNuevos.RowsDefaultCellStyle.ForeColor = Color.Black;
			this.dgvProdNuevos.DefaultCellStyle.BackColor = Color.White;
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x000EECF0 File Offset: 0x000ECEF0
		public void MostrarProductosReemplaza()
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			this.iniciaGridProductoReemplazar();
			string query_conn = " select a,b,c,d,e,f,g from F";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text = Conversions.ToString(sqlDataReader[0]);
					string text2 = Conversions.ToString(sqlDataReader[1]);
					string text3 = Conversions.ToString(sqlDataReader[2]);
					string text4 = Conversions.ToString(sqlDataReader[3]);
					double num = Conversions.ToDouble(sqlDataReader[4]);
					double num2 = Conversions.ToDouble(sqlDataReader[5]);
					double num3 = Conversions.ToDouble(sqlDataReader[6]);
					this.DataGridProductosElimiminar.Rows.Add(new object[]
					{
						text.ToString(),
						text2.ToString(),
						text3.ToString(),
						text4.ToString(),
						num.ToString("N2"),
						num2.ToString("N2"),
						num3.ToString("N2")
					});
				}
			}
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvNotas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvProdNuevos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x000EEE10 File Offset: 0x000ED010
		private void dgvProdNuevos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			int rowIndex2 = Conversions.ToInteger(this.lnlnumerodefila.Text);
			try
			{
				string text = Conversions.ToString(this.dgvNotas[0, rowIndex2].Value);
				this.dgvNotas[5, rowIndex2].Value = RuntimeHelpers.GetObjectValue(this.dgvProdNuevos.Rows[rowIndex].Cells["ID Producto"].Value);
				this.dgvNotas[6, rowIndex2].Value = RuntimeHelpers.GetObjectValue(this.dgvProdNuevos.Rows[rowIndex].Cells["Descripcion"].Value);
				this.dgvNotas[7, rowIndex2].Value = RuntimeHelpers.GetObjectValue(this.dgvProdNuevos.Rows[rowIndex].Cells["Precio"].Value);
				this.dgvNotas[8, rowIndex2].Value = RuntimeHelpers.GetObjectValue(this.dgvProdNuevos.Rows[rowIndex].Cells["Precio sin impuestos"].Value);
				string text2 = Conversions.ToString(this.dgvProdNuevos.Rows[rowIndex].Cells["ID Producto"].Value);
				string query_conn = string.Concat(new string[]
				{
					"INSERT INTO N (a,b) values ('",
					Tools.Encriptar(text.ToString().Trim()),
					"' , '",
					Tools.Encriptar(text2.ToString().Trim()),
					"')"
				});
				sqlQuery_Conn.execQuery_conn(query_conn);
			}
			catch (Exception ex)
			{
			}
			this.PanelAsignarProducto.Visible = false;
			this.dgvNotas.Enabled = true;
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = Operators.ConditionalCompareObjectGreater(dataGridViewRow.Cells["Precio a sustituir"].Value, "0", false);
					if (flag)
					{
						dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
						dataGridViewRow.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
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
			this.btnVistaPrevia.Enabled = true;
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x000EF0EC File Offset: 0x000ED2EC
		public void EnvioMail()
		{
			MailMessage mailMessage = new MailMessage();
			SmtpClient smtpClient = new SmtpClient();
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

		// Token: 0x06000EEA RID: 3818 RVA: 0x000EF580 File Offset: 0x000ED780
		private void Button1_Click(object sender, EventArgs e)
		{
			this.lblfechayhora.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
			this.progBar.Value = 0;
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery2 = new SqlQuery();
			object obj = "SE MODIFICARAN LOS FOLIOS SELECCIONADOS, Deseas continuar?";
			object value = 276;
			object obj2 = "ATENCIÓN!!!";
			object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
			bool flag = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
			if (flag)
			{
				this.COdigoUnicoCOrteGenerar();
				this.progBar.Value = 10;
				string query_conn = "Select ab from H";
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
				bool hasRows = sqlDataReader.HasRows;
				if (hasRows)
				{
					while (sqlDataReader.Read())
					{
						string value2 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
						bool flag2 = Conversions.ToDouble(value2) == 1.0;
						if (flag2)
						{
							this.EnvioMail();
						}
					}
					sqlDataReader.Close();
				}
				SqlQuery sqlQuery3 = new SqlQuery();
				string text = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
				string text2 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
				List<string> list = new List<string>();
				string query = string.Concat(new string[]
				{
					"select distinct (idturno) from turnos where apertura between '",
					text,
					"' and '",
					text2,
					"' and cierre is not null"
				});
				SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(query);
				bool hasRows2 = sqlDataReader2.HasRows;
				if (hasRows2)
				{
					while (sqlDataReader2.Read())
					{
						list.Add(Conversions.ToString(sqlDataReader2[0]));
					}
					sqlDataReader2.Close();
				}
				this.progBar.Value = 20;
				string text4;
				try
				{
					foreach (string text3 in list)
					{
						string query_conn2 = "Select g from h";
						SqlDataReader sqlDataReader3 = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn2);
						bool hasRows3 = sqlDataReader3.HasRows;
						if (hasRows3)
						{
							while (sqlDataReader3.Read())
							{
								bool flag3 = Operators.CompareString(Tools.Desencriptar(sqlDataReader3[0].ToString().Trim()), "1", false) == 0;
								if (flag3)
								{
									text4 = "select apertura from turnos where idturno = '" + text3 + "'";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows4 = sqlDataReader2.HasRows;
									DateTime dateTime;
									if (hasRows4)
									{
										while (sqlDataReader2.Read())
										{
											dateTime = Conversions.ToDate(sqlDataReader2[0]);
										}
									}
									sqlDataReader2.Close();
									text4 = "Select m from K where m = '" + dateTime.ToString(Tools.strFormatoFechaLargo) + "' ";
									SqlDataReader sqlDataReader4 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
									bool hasRows5 = sqlDataReader4.HasRows;
									if (!hasRows5)
									{
										text4 = string.Concat(new string[]
										{
											"Select ISNULL(SUM(totalalimentossindescuentos),0) as alimentos,ISNULL(SUM(totalbebidassindescuentos),0) as bebidas, ISNULL(SUM(totalotrossindescuentos),0) as otros, \r\n                                        ISNULL(SUM(totalcortesias),0) as cortesias,ISNULL(SUM(totaldescuentos),0) as descuentos, ISNULL(SUM(subtotal),0) as subtotal, ISNULL(SUM(totalimpuesto1),0) as iva, \r\n                                        ISNULL(SUM(total),0) as total, ISNULL(SUM(propina),0) as propina, ISNULL(SUM(total+propina),0) as totalconpropina,\r\n                                        ISNULL(SUM(nopersonas),0) as nopersonas,COUNT(folio) as cuentas ,  '",
											dateTime.ToString(Tools.strFormatoFechaLargo),
											"' from cheques where  idturno = '",
											text3,
											"' AND cierre is not null  and cancelado=0"
										});
										sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
										bool hasRows6 = sqlDataReader2.HasRows;
										if (hasRows6)
										{
											while (sqlDataReader2.Read())
											{
												string text5 = Conversions.ToString(sqlDataReader2[0]);
												string text6 = Conversions.ToString(sqlDataReader2[1]);
												string text7 = Conversions.ToString(sqlDataReader2[2]);
												string text8 = Conversions.ToString(sqlDataReader2[3]);
												string text9 = Conversions.ToString(sqlDataReader2[4]);
												string text10 = Conversions.ToString(sqlDataReader2[5]);
												string text11 = Conversions.ToString(sqlDataReader2[6]);
												string text12 = Conversions.ToString(sqlDataReader2[7]);
												string text13 = Conversions.ToString(sqlDataReader2[8]);
												string text14 = Conversions.ToString(sqlDataReader2[9]);
												string text15 = Conversions.ToString(sqlDataReader2[10]);
												string text16 = Conversions.ToString(sqlDataReader2[11]);
												text4 = string.Concat(new string[]
												{
													"Insert into ",
													Tools.BaseDatos_Modulo,
													".dbo.K (a,b,c,d,e,f,g,h,i,j,k,l,m)\r\n\r\n                                                    Values ('",
													Tools.Encriptar(text5.ToString().Trim()),
													"',\r\n                                                            '",
													Tools.Encriptar(text6.ToString().Trim()),
													"',\r\n                                                            '",
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
													"',                                        \r\n                                                            '",
													Tools.Encriptar(text14.ToString().Trim()),
													"',\r\n                                                            '",
													Tools.Encriptar(text15.ToString().Trim()),
													"',\r\n                                                            '",
													Tools.Encriptar(text16.ToString().Trim()),
													"',\r\n                                                            '",
													dateTime.ToString(Tools.strFormatoFechaLargo),
													"')"
												});
												sqlQuery.execQuery(text4);
												this.progBar.Value = 25;
											}
											text4 = "   Select a.idproducto ,b.descripcion, a.precio,a.cantidad,a.hora  from cheqdet A\r\n                                                         Inner JOIN productos B on b.idproducto = a.idproducto where a.foliodet in  (select folio from cheques where idturno = '" + text3 + "' AND cierre is not null  and cancelado=0)";
											sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
											bool hasRows7 = sqlDataReader2.HasRows;
											if (hasRows7)
											{
												while (sqlDataReader2.Read())
												{
													string text17 = Conversions.ToString(sqlDataReader2[0]);
													string text18 = Conversions.ToString(sqlDataReader2[1]);
													string text19 = Conversions.ToString(sqlDataReader2[2]);
													string text20 = Conversions.ToString(sqlDataReader2[3]);
													DateTime dateTime2 = Conversions.ToDate(sqlDataReader2[4]);
													text4 = string.Concat(new string[]
													{
														"Insert into ",
														Tools.BaseDatos_Modulo,
														".dbo.J (a,b,c,d,e)\r\n                                                        Values ('",
														Tools.Encriptar(text17.ToString().Trim()),
														"',\r\n                                                                '",
														Tools.Encriptar(text18.ToString().Trim()),
														"',\r\n                                                                '",
														Tools.Encriptar(text19.ToString().Trim()),
														"',\r\n                                                                '",
														Tools.Encriptar(text20.ToString().Trim()),
														"',\r\n                                                                '",
														dateTime2.ToString(Tools.strFormatoFechaLargo),
														"')"
													});
													sqlQuery.execQuery(text4);
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
				this.progBar.Value = 33;
				this.habilitaControles(false);
				string text21 = "";
				double num = 0.0;
				SqlQuery sqlQuery4 = new SqlQuery();
				SqlQuery sqlQuery5 = new SqlQuery();
				string text22 = this.cmbxSerie.Text;
				this.progBar.Value = 40;
				try
				{
					foreach (object obj3 in ((IEnumerable)this.DataGridProductosElimiminar.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj3;
						string text23 = Conversions.ToString(dataGridViewRow.Cells["foliodet"].Value);
						string text24 = Conversions.ToString(dataGridViewRow.Cells["Idproducto"].Value);
						this.lblidproductonew.Text = text24;
						string text25 = Conversions.ToString(dataGridViewRow.Cells["Movimiento"].Value);
						double num2 = Conversions.ToDouble(dataGridViewRow.Cells["Precio"].Value);
						double num3 = Conversions.ToDouble(dataGridViewRow.Cells["Impuestos"].Value);
						double num4 = Conversions.ToDouble(dataGridViewRow.Cells["Precio sin impuestos"].Value);
						text4 = string.Concat(new string[]
						{
							"UPDATE cheqdet set idproducto='",
							text24,
							"', precio='",
							num2.ToString("N2"),
							"' ,impuesto1='",
							num3.ToString("N2"),
							"' , preciosinimpuestos='",
							num4.ToString("N2"),
							"' where foliodet = '",
							text23.ToString(),
							"' and movimiento='",
							text25.ToString(),
							"'"
						});
						sqlQuery.execQuery(text4);
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
				this.progBar.Value = 40;
				try
				{
					foreach (object obj4 in ((IEnumerable)this.DataGridCheques.Rows))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj4);
						bool flag4 = Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
						{
							"Modificar"
						}, null, null, null), null, "Value", new object[0], null, null, null), true, false);
						if (flag4)
						{
							string text26 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"id_Folio"
							}, null, null, null), null, "Value", new object[0], null, null, null));
							double num5 = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Total con Descuento"
							}, null, null, null), null, "Value", new object[0], null, null, null));
							text4 = "select idturno from cheques where folio = '" + text26 + "'";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
							bool hasRows8 = sqlDataReader2.HasRows;
							if (hasRows8)
							{
								while (sqlDataReader2.Read())
								{
									string text27 = Conversions.ToString(sqlDataReader2[0]);
									this.lblidturnodelticket.Text = text27;
								}
								sqlDataReader2.Close();
							}
							text4 = " delete from chequespagos where folio = '" + text26 + "'";
							sqlQuery.execQuery(text4);
							bool flag5 = Operators.CompareString(text22, "Todas", false) == 0;
							if (flag5)
							{
								text4 = "update cheques Set  cambio=0  where folio = '" + text26 + "'";
								sqlQuery.execQuery(text4);
							}
							bool flag6 = Operators.CompareString(text22, "Todas", false) != 0;
							if (flag6)
							{
								text4 = string.Concat(new string[]
								{
									"update cheques Set  cambio=0  where folio = '",
									text26,
									"' and  seriefolio = '",
									text22,
									"'"
								});
								sqlQuery.execQuery(text4);
							}
							bool flag7 = Operators.CompareString(text22, "TODAS", false) == 0;
							if (flag7)
							{
								text4 = "SELECT Cantidad , Descuento , PreciosinImpuestos FROM Cheqdet Where foliodet='" + text26 + "' and descuento > 0";
								sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows9 = sqlDataReader2.HasRows;
								if (hasRows9)
								{
									text4 = "UPDATE Cheques set Totaldescuentos='0.00' , totaldescuentoycortesia='0.00' Where folio='" + text26 + "'";
									sqlQuery.execQuery(text4);
									while (sqlDataReader2.Read())
									{
										double num6 = Conversions.ToDouble(sqlDataReader2[0]);
										double num7 = Conversions.ToDouble(sqlDataReader2[1]);
										double num8 = Conversions.ToDouble(sqlDataReader2[2]);
										double num9 = num6 * num8 / 100.0 * num7;
										text4 = string.Concat(new string[]
										{
											"UPDATE Cheques set Totaldescuentos= Totaldescuentos +  '",
											num9.ToString("N2"),
											"' , totaldescuentoycortesia= totaldescuentoycortesia +'",
											num9.ToString("N2"),
											"' Where folio='",
											text26,
											"'"
										});
										sqlQuery.execQuery(text4);
									}
								}
								else
								{
									text4 = "UPDATE Cheques set Totaldescuentos='0.00' , totaldescuentoycortesia='0.00' Where folio='" + text26 + "'";
									sqlQuery.execQuery(text4);
								}
								sqlDataReader2.Close();
							}
							bool flag8 = Operators.CompareString(text22, "TODAS", false) != 0;
							if (flag8)
							{
								text4 = "SELECT Cantidad , Descuento , PreciosinImpuestos FROM Cheqdet Where foliodet='" + text26 + "' and descuento > 0";
								sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows10 = sqlDataReader2.HasRows;
								if (hasRows10)
								{
									text4 = "UPDATE Cheques set Totaldescuentos='0.00' , totaldescuentoycortesia='0.00' Where folio='" + text26 + "'";
									sqlQuery.execQuery(text4);
									while (sqlDataReader2.Read())
									{
										double num6 = Conversions.ToDouble(sqlDataReader2[0]);
										double num7 = Conversions.ToDouble(sqlDataReader2[1]);
										double num8 = Conversions.ToDouble(sqlDataReader2[2]);
										double num9 = num6 * num8 / 100.0 * num7;
										text4 = string.Concat(new string[]
										{
											"UPDATE Cheques set Totaldescuentos= Totaldescuentos +  '",
											num9.ToString("N2"),
											"' , totaldescuentoycortesia= totaldescuentoycortesia +'",
											num9.ToString("N2"),
											"' Where folio='",
											text26,
											"'"
										});
										sqlQuery.execQuery(text4);
									}
								}
								else
								{
									text4 = "UPDATE Cheques set Totaldescuentos='0.00' , totaldescuentoycortesia='0.00' Where folio='" + text26 + "'";
									sqlQuery.execQuery(text4);
								}
								sqlDataReader2.Close();
							}
							SqlQuery sqlQuery6 = new SqlQuery();
							bool flag9 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Modificar"
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
							if (flag9)
							{
								text4 = "SELECT i from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag10 = sqlDataReader2.Read();
								if (flag10)
								{
									string text28 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text28.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(query2);
									bool hasRows11 = sqlDataReader5.HasRows;
									if (hasRows11)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value3 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text4 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                                        values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num5.ToString("N2"),
													"','0','1','','",
													this.lblidturnodelticket.Text,
													"','1','1')"
												});
												sqlQuery.execQuery(text4);
												bool flag11 = Operators.CompareString(text22, "Todas", false) == 0;
												if (flag11)
												{
													text4 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text4);
												}
												bool flag12 = Operators.CompareString(text22, "Todas", false) != 0;
												if (flag12)
												{
													text4 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text22,
														"'"
													});
													sqlQuery.execQuery(text4);
												}
												bool flag13 = Conversions.ToDouble(value3) == 4.0;
												if (flag13)
												{
													bool flag14 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag14)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag15 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag15)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag16 = Conversions.ToDouble(value3) == 3.0;
												if (flag16)
												{
													bool flag17 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag17)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag18 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag18)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag19 = Conversions.ToDouble(value3) == 1.0;
												if (flag19)
												{
													bool flag20 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag20)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag21 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag21)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag22 = Conversions.ToDouble(value3) == 2.0;
												if (flag22)
												{
													bool flag23 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag23)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag24 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag24)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
											}
											catch (Exception ex)
											{
											}
										}
									}
									sqlDataReader5.Close();
								}
								sqlDataReader2.Close();
							}
							bool flag25 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Modificar"
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
							if (flag25)
							{
								text4 = "SELECT j from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag26 = sqlDataReader2.Read();
								if (flag26)
								{
									string text30 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text30.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(query2);
									bool hasRows12 = sqlDataReader5.HasRows;
									if (hasRows12)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value3 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text4 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                                        values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num5.ToString("N2"),
													"','0','1','','",
													this.lblidturnodelticket.Text,
													"','1','1')"
												});
												sqlQuery.execQuery(text4);
												bool flag27 = Operators.CompareString(text22, "Todas", false) == 0;
												if (flag27)
												{
													text4 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text4);
												}
												bool flag28 = Operators.CompareString(text22, "Todas", false) != 0;
												if (flag28)
												{
													text4 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text22,
														"'"
													});
													sqlQuery.execQuery(text4);
												}
												bool flag29 = Conversions.ToDouble(value3) == 4.0;
												if (flag29)
												{
													bool flag30 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag30)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag31 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag31)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag32 = Conversions.ToDouble(value3) == 3.0;
												if (flag32)
												{
													bool flag33 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag33)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag34 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag34)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag35 = Conversions.ToDouble(value3) == 1.0;
												if (flag35)
												{
													bool flag36 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag36)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag37 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag37)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag38 = Conversions.ToDouble(value3) == 2.0;
												if (flag38)
												{
													bool flag39 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag39)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag40 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag40)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
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
							bool flag41 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Modificar"
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
							if (flag41)
							{
								text4 = "SELECT k from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag42 = sqlDataReader2.Read();
								if (flag42)
								{
									string text31 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text31.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(query2);
									bool hasRows13 = sqlDataReader5.HasRows;
									if (hasRows13)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value3 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text4 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                                        values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num5.ToString("N2"),
													"','0','1','','",
													this.lblidturnodelticket.Text,
													"','1','1')"
												});
												sqlQuery.execQuery(text4);
												bool flag43 = Operators.CompareString(text22, "Todas", false) == 0;
												if (flag43)
												{
													text4 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text4);
												}
												bool flag44 = Operators.CompareString(text22, "Todas", false) != 0;
												if (flag44)
												{
													text4 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text22,
														"'"
													});
													sqlQuery.execQuery(text4);
												}
												bool flag45 = Conversions.ToDouble(value3) == 4.0;
												if (flag45)
												{
													bool flag46 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag46)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag47 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag47)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag48 = Conversions.ToDouble(value3) == 3.0;
												if (flag48)
												{
													bool flag49 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag49)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag50 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag50)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag51 = Conversions.ToDouble(value3) == 1.0;
												if (flag51)
												{
													bool flag52 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag52)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag53 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag53)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag54 = Conversions.ToDouble(value3) == 2.0;
												if (flag54)
												{
													bool flag55 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag55)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag56 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag56)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
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
							this.progBar.Value = 50;
							bool flag57 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Modificar"
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
							if (flag57)
							{
								text4 = "SELECT l from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag58 = sqlDataReader2.Read();
								if (flag58)
								{
									string text32 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text32.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(query2);
									bool hasRows14 = sqlDataReader5.HasRows;
									if (hasRows14)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value3 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text4 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num5.ToString("N2"),
													"','0','1','','",
													this.lblidturnodelticket.Text,
													"','1','1')"
												});
												sqlQuery.execQuery(text4);
												bool flag59 = Operators.CompareString(text22, "Todas", false) == 0;
												if (flag59)
												{
													text4 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text4);
												}
												bool flag60 = Operators.CompareString(text22, "Todas", false) != 0;
												if (flag60)
												{
													text4 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"'  and seriefolio = '",
														text22,
														"'"
													});
													sqlQuery.execQuery(text4);
												}
												bool flag61 = Conversions.ToDouble(value3) == 4.0;
												if (flag61)
												{
													bool flag62 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag62)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag63 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag63)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'  and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag64 = Conversions.ToDouble(value3) == 3.0;
												if (flag64)
												{
													bool flag65 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag65)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag66 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag66)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'  and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag67 = Conversions.ToDouble(value3) == 1.0;
												if (flag67)
												{
													bool flag68 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag68)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag69 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag69)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag70 = Conversions.ToDouble(value3) == 2.0;
												if (flag70)
												{
													bool flag71 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag71)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag72 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag72)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
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
							bool flag73 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Modificar"
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
							if (flag73)
							{
								text4 = "SELECT m from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag74 = sqlDataReader2.Read();
								if (flag74)
								{
									string text33 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text33.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(query2);
									bool hasRows15 = sqlDataReader5.HasRows;
									if (hasRows15)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value3 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text4 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num5.ToString("N2"),
													"','0','1','','",
													this.lblidturnodelticket.Text,
													"','1','1')"
												});
												sqlQuery.execQuery(text4);
												bool flag75 = Operators.CompareString(text22, "Todas", false) == 0;
												if (flag75)
												{
													text4 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text4);
												}
												bool flag76 = Operators.CompareString(text22, "Todas", false) != 0;
												if (flag76)
												{
													text4 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text22,
														"'"
													});
													sqlQuery.execQuery(text4);
												}
												bool flag77 = Conversions.ToDouble(value3) == 4.0;
												if (flag77)
												{
													bool flag78 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag78)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag79 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag79)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag80 = Conversions.ToDouble(value3) == 3.0;
												if (flag80)
												{
													bool flag81 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag81)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag82 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag82)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag83 = Conversions.ToDouble(value3) == 1.0;
												if (flag83)
												{
													bool flag84 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag84)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag85 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag85)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag86 = Conversions.ToDouble(value3) == 2.0;
												if (flag86)
												{
													bool flag87 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag87)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag88 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag88)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
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
							bool flag89 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Modificar"
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
							if (flag89)
							{
								text4 = "SELECT m from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag90 = sqlDataReader2.Read();
								if (flag90)
								{
									string text33 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text33.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(query2);
									bool hasRows16 = sqlDataReader5.HasRows;
									if (hasRows16)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value3 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text4 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num5.ToString("N2"),
													"','0','1','','",
													this.lblidturnodelticket.Text,
													"','1','1')"
												});
												sqlQuery.execQuery(text4);
												bool flag91 = Operators.CompareString(text22, "Todas", false) == 0;
												if (flag91)
												{
													text4 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text4);
												}
												bool flag92 = Operators.CompareString(text22, "Todas", false) != 0;
												if (flag92)
												{
													text4 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text22,
														"'"
													});
													sqlQuery.execQuery(text4);
												}
												bool flag93 = Conversions.ToDouble(value3) == 4.0;
												if (flag93)
												{
													bool flag94 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag94)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag95 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag95)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag96 = Conversions.ToDouble(value3) == 3.0;
												if (flag96)
												{
													bool flag97 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag97)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag98 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag98)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag99 = Conversions.ToDouble(value3) == 1.0;
												if (flag99)
												{
													bool flag100 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag100)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag101 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag101)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag102 = Conversions.ToDouble(value3) == 2.0;
												if (flag102)
												{
													bool flag103 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag103)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag104 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag104)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
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
							bool flag105 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Modificar"
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
							if (flag105)
							{
								text4 = "SELECT m from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag106 = sqlDataReader2.Read();
								if (flag106)
								{
									string text33 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text33.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(query2);
									bool hasRows17 = sqlDataReader5.HasRows;
									if (hasRows17)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value3 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text4 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num5.ToString("N2"),
													"','0','1','','",
													this.lblidturnodelticket.Text,
													"','1','1')"
												});
												sqlQuery.execQuery(text4);
												bool flag107 = Operators.CompareString(text22, "Todas", false) == 0;
												if (flag107)
												{
													text4 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text4);
												}
												bool flag108 = Operators.CompareString(text22, "Todas", false) != 0;
												if (flag108)
												{
													text4 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text22,
														"'"
													});
													sqlQuery.execQuery(text4);
												}
												bool flag109 = Conversions.ToDouble(value3) == 4.0;
												if (flag109)
												{
													bool flag110 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag110)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag111 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag111)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag112 = Conversions.ToDouble(value3) == 3.0;
												if (flag112)
												{
													bool flag113 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag113)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag114 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag114)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag115 = Conversions.ToDouble(value3) == 1.0;
												if (flag115)
												{
													bool flag116 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag116)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag117 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag117)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag118 = Conversions.ToDouble(value3) == 2.0;
												if (flag118)
												{
													bool flag119 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag119)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag120 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag120)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
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
							bool flag121 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Modificar"
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
							if (flag121)
							{
								text4 = "SELECT m from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag122 = sqlDataReader2.Read();
								if (flag122)
								{
									string text33 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text33.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(query2);
									bool hasRows18 = sqlDataReader5.HasRows;
									if (hasRows18)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value3 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text4 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num5.ToString("N2"),
													"','0','1','','",
													this.lblidturnodelticket.Text,
													"','1','1')"
												});
												sqlQuery.execQuery(text4);
												bool flag123 = Operators.CompareString(text22, "Todas", false) == 0;
												if (flag123)
												{
													text4 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text4);
												}
												bool flag124 = Operators.CompareString(text22, "Todas", false) != 0;
												if (flag124)
												{
													text4 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text22,
														"'"
													});
													sqlQuery.execQuery(text4);
												}
												bool flag125 = Conversions.ToDouble(value3) == 4.0;
												if (flag125)
												{
													bool flag126 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag126)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag127 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag127)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag128 = Conversions.ToDouble(value3) == 3.0;
												if (flag128)
												{
													bool flag129 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag129)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag130 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag130)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag131 = Conversions.ToDouble(value3) == 1.0;
												if (flag131)
												{
													bool flag132 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag132)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag133 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag133)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag134 = Conversions.ToDouble(value3) == 2.0;
												if (flag134)
												{
													bool flag135 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag135)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag136 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag136)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
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
							bool flag137 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Modificar"
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
							if (flag137)
							{
								text4 = "SELECT m from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag138 = sqlDataReader2.Read();
								if (flag138)
								{
									string text33 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text33.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(query2);
									bool hasRows19 = sqlDataReader5.HasRows;
									if (hasRows19)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value3 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text4 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num5.ToString("N2"),
													"','0','1','','",
													this.lblidturnodelticket.Text,
													"','1','1')"
												});
												sqlQuery.execQuery(text4);
												bool flag139 = Operators.CompareString(text22, "Todas", false) == 0;
												if (flag139)
												{
													text4 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text4);
												}
												bool flag140 = Operators.CompareString(text22, "Todas", false) != 0;
												if (flag140)
												{
													text4 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text22,
														"'"
													});
													sqlQuery.execQuery(text4);
												}
												bool flag141 = Conversions.ToDouble(value3) == 4.0;
												if (flag141)
												{
													bool flag142 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag142)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag143 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag143)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag144 = Conversions.ToDouble(value3) == 3.0;
												if (flag144)
												{
													bool flag145 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag145)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag146 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag146)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag147 = Conversions.ToDouble(value3) == 1.0;
												if (flag147)
												{
													bool flag148 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag148)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag149 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag149)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag150 = Conversions.ToDouble(value3) == 2.0;
												if (flag150)
												{
													bool flag151 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag151)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag152 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag152)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
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
							bool flag153 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								"Modificar"
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
							if (flag153)
							{
								text4 = "SELECT m from H";
								sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag154 = sqlDataReader2.Read();
								if (flag154)
								{
									string text33 = Tools.Desencriptar(sqlDataReader2[0].ToString().Trim());
									string query2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text33.ToString() + "'";
									SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(query2);
									bool hasRows20 = sqlDataReader5.HasRows;
									if (hasRows20)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value3 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text4 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num5.ToString("N2"),
													"','0','1','','",
													this.lblidturnodelticket.Text,
													"','1','1')"
												});
												sqlQuery.execQuery(text4);
												bool flag155 = Operators.CompareString(text22, "Todas", false) == 0;
												if (flag155)
												{
													text4 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text4);
												}
												bool flag156 = Operators.CompareString(text22, "Todas", false) != 0;
												if (flag156)
												{
													text4 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text22,
														"'"
													});
													sqlQuery.execQuery(text4);
												}
												bool flag157 = Conversions.ToDouble(value3) == 4.0;
												if (flag157)
												{
													bool flag158 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag158)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag159 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag159)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag160 = Conversions.ToDouble(value3) == 3.0;
												if (flag160)
												{
													bool flag161 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag161)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag162 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag162)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag163 = Conversions.ToDouble(value3) == 1.0;
												if (flag163)
												{
													bool flag164 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag164)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag165 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag165)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
												}
												bool flag166 = Conversions.ToDouble(value3) == 2.0;
												if (flag166)
												{
													bool flag167 = Operators.CompareString(text22, "Todas", false) == 0;
													if (flag167)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text4);
													}
													bool flag168 = Operators.CompareString(text22, "Todas", false) != 0;
													if (flag168)
													{
														text4 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num5.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text22,
															"'"
														});
														sqlQuery.execQuery(text4);
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
							double num10;
							try
							{
								text4 = "select ISNULL(sum(preciosinimpuestos*cantidad/100 *impuesto1),0) from cheqdet where foliodet = '" + text26 + "'";
								sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
								bool flag169 = sqlDataReader2.Read();
								if (flag169)
								{
									num10 = Conversions.ToDouble(sqlDataReader2[0]);
								}
								text4 = "select ISNULL(sum(precio*cantidad-(preciosinimpuestos*cantidad/100*impuesto1)),0) from cheqdet where foliodet = '" + text26 + "'";
								sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
								bool flag170 = sqlDataReader2.Read();
								double num11;
								if (flag170)
								{
									num11 = Conversions.ToDouble(sqlDataReader2[0]);
								}
								bool flag171 = Operators.CompareString(text22, "Todas", false) == 0;
								if (flag171)
								{
									text4 = string.Concat(new string[]
									{
										"Update cheques set total = '",
										num5.ToString("N2"),
										"' , subtotal='",
										num11.ToString("N2"),
										"' ,  descuento = 0 , usuariodescuento='' , idtipodescuento='' , descuentoimporte=0 ,totalconpropina = '",
										num5.ToString("N2"),
										"' , TotalConCargo='",
										num5.ToString("N2"),
										"' ,  TotalConPropinaCargo='",
										num5.ToString("N2"),
										"' ,  TotalSinDescuento='",
										num5.ToString("N2"),
										"',  SubtotalConDescuento='",
										num11.ToString("N2"),
										"'   where folio = '",
										text26,
										"'"
									});
									sqlQuery.execQuery(text4);
								}
								bool flag172 = Operators.CompareString(text22, "Todas", false) != 0;
								if (flag172)
								{
									text4 = string.Concat(new string[]
									{
										"Update cheques set total = '",
										num5.ToString("N2"),
										"' , subtotal='",
										num11.ToString("N2"),
										"' ,  descuento = 0 , usuariodescuento='' , idtipodescuento='' , descuentoimporte=0 ,totalconpropina = '",
										num5.ToString("N2"),
										"' , TotalConCargo='",
										num5.ToString("N2"),
										"' ,  TotalConPropinaCargo='",
										num5.ToString("N2"),
										"' ,  TotalSinDescuento='",
										num5.ToString("N2"),
										"',  SubtotalConDescuento='",
										num11.ToString("N2"),
										"'   where folio = '",
										text26,
										"' and seriefolio = '",
										text22,
										"'"
									});
									sqlQuery.execQuery(text4);
								}
							}
							catch (Exception ex11)
							{
							}
							this.progBar.Value = 60;
							SqlQuery sqlQuery7 = new SqlQuery();
							bool flag173 = Operators.CompareString(text22, "Todas", false) == 0;
							if (flag173)
							{
								try
								{
									text4 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
									sqlDataReader2 = (SqlDataReader)sqlQuery7.execReader(text4);
									bool hasRows21 = sqlDataReader2.HasRows;
									if (hasRows21)
									{
										while (sqlDataReader2.Read())
										{
											text4 = string.Concat(new string[]
											{
												"Update cheques Set   totalbebidas='",
												Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
												"' , totalimpuesto1='",
												num10.ToString("N2"),
												"' ,  totalimpuestod1='",
												num10.ToString("N2"),
												"' where folio = '",
												text26,
												"'"
											});
											sqlQuery.execQuery(text4);
										}
									}
									text4 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=2";
									sqlDataReader2 = (SqlDataReader)sqlQuery7.execReader(text4);
									bool hasRows22 = sqlDataReader2.HasRows;
									if (hasRows22)
									{
										while (sqlDataReader2.Read())
										{
											text4 = string.Concat(new string[]
											{
												"Update cheques Set totalalimentos = '",
												Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
												"' , totalimpuesto1='",
												num10.ToString("N2"),
												"' ,  totalimpuestod1='",
												num10.ToString("N2"),
												"' where folio = '",
												text26,
												"'"
											});
											sqlQuery.execQuery(text4);
										}
									}
									text4 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=3";
									sqlDataReader2 = (SqlDataReader)sqlQuery7.execReader(text4);
									bool hasRows23 = sqlDataReader2.HasRows;
									if (hasRows23)
									{
										while (sqlDataReader2.Read())
										{
											text4 = string.Concat(new string[]
											{
												"Update cheques Set  totalotros='",
												Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
												"' ,  totalimpuesto1='",
												num10.ToString("N2"),
												"' ,  totalimpuestod1='",
												num10.ToString("N2"),
												"' where folio = '",
												text26,
												"'"
											});
											sqlQuery.execQuery(text4);
										}
									}
								}
								catch (Exception ex12)
								{
								}
							}
							bool flag174 = Operators.CompareString(text22, "Todas", false) != 0;
							if (flag174)
							{
								try
								{
									text4 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
									sqlDataReader2 = (SqlDataReader)sqlQuery7.execReader(text4);
									bool hasRows24 = sqlDataReader2.HasRows;
									if (hasRows24)
									{
										while (sqlDataReader2.Read())
										{
											text4 = string.Concat(new string[]
											{
												"Update cheques Set  totalbebidas='",
												Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
												"' , totalimpuesto1='",
												num10.ToString("N2"),
												"' ,  totalimpuestod1='",
												num10.ToString("N2"),
												"' where folio = '",
												text26,
												"' and seriefolio = '",
												text22,
												"'"
											});
											sqlQuery.execQuery(text4);
										}
										sqlDataReader2.Close();
									}
									text4 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=2";
									sqlDataReader2 = (SqlDataReader)sqlQuery7.execReader(text4);
									bool hasRows25 = sqlDataReader2.HasRows;
									if (hasRows25)
									{
										while (sqlDataReader2.Read())
										{
											text4 = string.Concat(new string[]
											{
												"Update cheques Set totalalimentos = '",
												Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
												"' , totalimpuesto1='",
												num10.ToString("N2"),
												"' ,  totalimpuestod1='",
												num10.ToString("N2"),
												"' where folio = '",
												text26,
												"' and seriefolio = '",
												text22,
												"'"
											});
											sqlQuery.execQuery(text4);
										}
									}
									text4 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=3";
									sqlDataReader2 = (SqlDataReader)sqlQuery7.execReader(text4);
									bool hasRows26 = sqlDataReader2.HasRows;
									if (hasRows26)
									{
										while (sqlDataReader2.Read())
										{
											double num12 = Conversions.ToDouble(sqlDataReader2[0]);
											sqlQuery.execQuery(text4);
											text4 = string.Concat(new string[]
											{
												"Update cheques Set totalotros='",
												num12.ToString("N2"),
												"' ,  totalimpuesto1='",
												num10.ToString("N2"),
												"' ,  totalimpuestod1='",
												num10.ToString("N2"),
												"' where folio = '",
												text26,
												"' and seriefolio = '",
												text22,
												"'"
											});
											sqlQuery.execQuery(text4);
										}
									}
								}
								catch (Exception ex13)
								{
								}
							}
							this.progBar.Value = 70;
							bool flag175 = Operators.CompareString(text22, "Todas", false) == 0;
							if (flag175)
							{
								try
								{
									text4 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
									sqlDataReader2 = (SqlDataReader)sqlQuery7.execReader(text4);
									bool hasRows27 = sqlDataReader2.HasRows;
									if (hasRows27)
									{
										while (sqlDataReader2.Read())
										{
											text4 = string.Concat(new string[]
											{
												"Update cheques Set  totalbebidassindescuentos='",
												Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
												"'  where folio = '",
												text26,
												"'"
											});
											sqlQuery.execQuery(text4);
										}
									}
									text4 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=2";
									sqlDataReader2 = (SqlDataReader)sqlQuery7.execReader(text4);
									bool hasRows28 = sqlDataReader2.HasRows;
									if (hasRows28)
									{
										while (sqlDataReader2.Read())
										{
											text4 = string.Concat(new string[]
											{
												"Update cheques Set totalalimentossindescuentos = '",
												Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
												"'  where folio = '",
												text26,
												"'"
											});
											sqlQuery.execQuery(text4);
										}
									}
									text4 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=3";
									sqlDataReader2 = (SqlDataReader)sqlQuery7.execReader(text4);
									bool hasRows29 = sqlDataReader2.HasRows;
									if (hasRows29)
									{
										while (sqlDataReader2.Read())
										{
											text4 = string.Concat(new string[]
											{
												"Update cheques Set totalotrossindescuentos='",
												Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
												"'  where folio = '",
												text26,
												"'"
											});
											sqlQuery.execQuery(text4);
										}
									}
								}
								catch (Exception ex14)
								{
								}
								bool flag176 = Operators.CompareString(text22, "Todas", false) != 0;
								if (flag176)
								{
									try
									{
										text4 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
										sqlDataReader2 = (SqlDataReader)sqlQuery7.execReader(text4);
										bool hasRows30 = sqlDataReader2.HasRows;
										if (hasRows30)
										{
											while (sqlDataReader2.Read())
											{
												text4 = string.Concat(new string[]
												{
													"Update cheques Set  totalbebidassindescuentos='",
													Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
													"' ,   where folio = '",
													text26,
													"' and seriefolio = '",
													text22,
													"'"
												});
												sqlQuery.execQuery(text4);
											}
										}
										text4 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=2";
										sqlDataReader2 = (SqlDataReader)sqlQuery7.execReader(text4);
										bool hasRows31 = sqlDataReader2.HasRows;
										if (hasRows31)
										{
											while (sqlDataReader2.Read())
											{
												text4 = string.Concat(new string[]
												{
													"Update cheques Set totalalimentossindescuentos = '",
													Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
													"'  where folio = '",
													text26,
													"' and seriefolio = '",
													text22,
													"'"
												});
												sqlQuery.execQuery(text4);
											}
										}
										text4 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=3";
										sqlDataReader2 = (SqlDataReader)sqlQuery7.execReader(text4);
										bool hasRows32 = sqlDataReader2.HasRows;
										if (hasRows32)
										{
											while (sqlDataReader2.Read())
											{
												text4 = string.Concat(new string[]
												{
													"Update cheques Set  totalotrossindescuentos='",
													Conversions.ToDouble(sqlDataReader2[0]).ToString("N2"),
													"'  where folio = '",
													text26,
													"' and seriefolio = '",
													text22,
													"'"
												});
												sqlQuery.execQuery(text4);
											}
										}
									}
									catch (Exception ex15)
									{
									}
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
				this.progBar.Value = 80;
				try
				{
					foreach (object obj5 in ((IEnumerable)this.DataGridCheques.Rows))
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj5;
						bool flag177 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Modificar"].Value, true, false), Operators.CompareObjectGreater(dataGridViewRow2.Cells["Propina"].Value, 0, false)));
						if (flag177)
						{
							string text34 = Conversions.ToString(dataGridViewRow2.Cells["Folio Cuenta"].Value);
							string text35 = Conversions.ToString(dataGridViewRow2.Cells["Serie"].Value);
							bool flag178 = Operators.CompareString(text22, "Todas", false) == 0;
							if (flag178)
							{
								text4 = "Select propinafoliomovtocaja from cheques where numcheque='" + text34.ToString() + "'";
								sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows33 = sqlDataReader2.HasRows;
								if (hasRows33)
								{
									while (sqlDataReader2.Read())
									{
										string text36 = Conversions.ToString(sqlDataReader2[0]);
										text4 = string.Concat(new string[]
										{
											"Update movtoscaja Set importe = importe - (Select propina from cheques where numcheque ='",
											text34.ToString(),
											"' and seriefolio='",
											text35,
											"') where folio=  '",
											text36,
											"'"
										});
										sqlQuery5.execQuery(text4);
										text4 = "update cheques set propina=0 , propinafoliomovtocaja =0 where numcheque='" + text34.ToString() + "'";
										sqlQuery5.execQuery(text4);
									}
								}
								sqlDataReader2.Close();
							}
							bool flag179 = Operators.CompareString(text22, "Todas", false) != 0;
							if (flag179)
							{
								text4 = "Select propinafoliomovtocaja from cheques where numcheque='" + text34.ToString() + "'";
								sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows34 = sqlDataReader2.HasRows;
								if (hasRows34)
								{
									while (sqlDataReader2.Read())
									{
										string text36 = Conversions.ToString(sqlDataReader2[0]);
										text4 = string.Concat(new string[]
										{
											"Update movtoscaja Set importe = importe - (Select propina from cheques where numcheque ='",
											text34.ToString(),
											"' and  seriefolio = '",
											text22,
											"') where folio=  '",
											text36,
											"'"
										});
										sqlQuery5.execQuery(text4);
										text4 = string.Concat(new string[]
										{
											"update cheques set propina=0 , propinafoliomovtocaja =0 where numcheque='",
											text34.ToString(),
											"' and  seriefolio = '",
											text22,
											"'"
										});
										sqlQuery5.execQuery(text4);
									}
								}
								sqlDataReader2.Close();
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
				List<string> list2 = new List<string>();
				try
				{
					foreach (object obj6 in ((IEnumerable)this.DataGridCheques.Rows))
					{
						DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj6;
						bool flag180 = Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells["Modificar"].Value, true, false);
						if (flag180)
						{
							text21 = Conversions.ToString(Operators.AddObject(text21, dataGridViewRow3.Cells["id_folio"].Value));
							text21 += ",";
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
				text21 = text21.Remove(checked(text21.Length - 1), 1);
				text4 = string.Concat(new string[]
				{
					"select distinct (idturno) from turnos where apertura between '",
					text,
					"' and '",
					text2,
					"' and cierre is not  null"
				});
				sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
				bool hasRows35 = sqlDataReader2.HasRows;
				if (hasRows35)
				{
					while (sqlDataReader2.Read())
					{
						list2.Add(Conversions.ToString(sqlDataReader2[0]));
					}
					sqlDataReader2.Close();
				}
				text4 = string.Concat(new string[]
				{
					"Select count(*) from turnos where apertura between '",
					text,
					"' and '",
					text2,
					"' and cierre is not  null"
				});
				sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
				bool hasRows36 = sqlDataReader2.HasRows;
				if (hasRows36)
				{
					sqlDataReader2.Read();
					int num13 = Conversions.ToInteger(sqlDataReader2[0]);
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
					foreach (string text37 in list2)
					{
						SqlQuery sqlQuery8 = new SqlQuery();
						string text38 = "select n from h";
						SqlDataReader sqlDataReader6 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text38);
						bool hasRows37 = sqlDataReader6.HasRows;
						if (hasRows37)
						{
							while (sqlDataReader6.Read())
							{
								bool flag181 = Operators.CompareString(Tools.Desencriptar(sqlDataReader6[0].ToString().Trim()), "1", false) == 0;
								if (flag181)
								{
									text38 = "delete from movsinv where idconcepto='SPV' and idturno ='" + text37 + "'";
									sqlQuery8.execQuery(text38);
								}
							}
						}
						bool @checked = this.chkEliminaProp.Checked;
						if (@checked)
						{
							text4 = "delete from movtoscaja where idturno  = '" + text37 + "' And  pagodepropina = 1";
							sqlQuery.execQuery(text4);
							bool flag182 = Operators.CompareString(text22, "Todas", false) == 0;
							if (flag182)
							{
								text4 = "update cheques set propina=0 , propinafoliomovtocaja =0 where idturno='" + text37 + "'";
								sqlQuery.execQuery(text4);
							}
							bool flag183 = Operators.CompareString(text22, "Todas", false) != 0;
							if (flag183)
							{
								text4 = string.Concat(new string[]
								{
									"update cheques set propina=0 , propinafoliomovtocaja =0 where idturno='",
									text37,
									"' and seriefolio = '",
									text22,
									"'"
								});
								sqlQuery.execQuery(text4);
							}
						}
						else
						{
							text4 = "Select ISNULL(sum(importe),0) from movtoscaja Where idturno = '" + text37 + "' And  pagodepropina = 1";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
							sqlDataReader2.Read();
							num = Conversions.ToDouble(sqlDataReader2[0]);
							sqlDataReader2.Close();
						}
						bool checked2 = this.chkEliminaRet.Checked;
						if (checked2)
						{
							text4 = "delete from movtoscaja Where idturno = '" + text37 + "' And pagodepropina <1";
							sqlQuery.execQuery(text4);
						}
						bool flag184 = Operators.CompareString(text22, "Todas", false) == 0;
						if (flag184)
						{
							text4 = string.Concat(new string[]
							{
								"Select \r\n                            ISNULL(sum(efectivo),0),\r\n                            ISNULL(sum(tarjeta),0),\r\n                            ISNULL(sum(vales),0),\r\n                            ISNULL(sum(otros),0)\r\n                            from cheques WHERE idempresa='",
								Tools.id_Empresa,
								"' and  idturno = '",
								text37,
								"'"
							});
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
							sqlDataReader2.Read();
							double num14 = Conversions.ToDouble(Operators.SubtractObject(sqlDataReader2[0], num));
							double num15 = Conversions.ToDouble(sqlDataReader2[1]);
							double num16 = Conversions.ToDouble(sqlDataReader2[2]);
							double num17 = Conversions.ToDouble(sqlDataReader2[3]);
							double num18 = num14;
							text4 = string.Concat(new string[]
							{
								"Update turnos Set efectivo='",
								num18.ToString(),
								"',tarjeta='",
								num15.ToString(),
								"',vales='",
								num16.ToString(),
								"', credito='",
								num17.ToString(),
								"' Where idturno = '",
								text37,
								"'"
							});
							sqlQuery.execQuery(text4);
						}
						bool flag185 = Operators.CompareString(text22, "Todas", false) != 0;
						if (flag185)
						{
							text4 = string.Concat(new string[]
							{
								"Select \r\n                            ISNULL(sum(efectivo),0),\r\n                            ISNULL(sum(tarjeta),0),\r\n                            ISNULL(sum(vales),0),\r\n                            ISNULL(sum(otros),0)\r\n                            from cheques WHERE idempresa='",
								Tools.id_Empresa,
								"' and  idturno = '",
								text37,
								"' and seriefolio = '",
								text22,
								"'"
							});
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text4);
							sqlDataReader2.Read();
							double num14 = Conversions.ToDouble(Operators.SubtractObject(sqlDataReader2[0], num));
							double num15 = Conversions.ToDouble(sqlDataReader2[1]);
							double num16 = Conversions.ToDouble(sqlDataReader2[2]);
							double num17 = Conversions.ToDouble(sqlDataReader2[3]);
							double num18 = num14;
							text4 = string.Concat(new string[]
							{
								"Update turnos Set efectivo='",
								num18.ToString(),
								"',tarjeta='",
								num15.ToString(),
								"',vales='",
								num16.ToString(),
								"', credito='",
								num17.ToString(),
								"' Where idturno = '",
								text37,
								"'"
							});
							sqlQuery.execQuery(text4);
						}
						try
						{
						}
						catch (Exception ex17)
						{
						}
						bool checked3 = this.CheckBoxfondocaja.Checked;
						if (checked3)
						{
							text4 = "update turnos set fondo=0 Where idturno = '" + text37 + "'";
							sqlQuery.execQuery(text4);
						}
						this.progBar.Value = 90;
					}
				}
				finally
				{
					List<string>.Enumerator enumerator6;
					((IDisposable)enumerator6).Dispose();
				}
				string text39 = DateAndTime.Now.ToString(Tools.strFormatoFechaLargo);
				string text40 = this.txtCuentasModificar.Text;
				string text41 = this.txtCuentasTotal.Text;
				double num19 = Conversions.ToDouble(this.txtImpAnterior.Text);
				double num20 = Conversions.ToDouble(this.txtImpNuevo.Text);
				double num21 = Conversions.ToDouble(this.txtEfectivoAnt.Text);
				double num22 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
				double num23 = Conversions.ToDouble(this.txtVentaTarjeta.Text);
				double num24 = Conversions.ToDouble(this.txtDifTarjeta.Text);
				double num25 = Conversions.ToDouble(this.txtVentasOtros.Text);
				double num26 = Conversions.ToDouble(this.txtdifotros.Text);
				double num27 = Conversions.ToDouble(this.txtVales.Text);
				double num28 = Conversions.ToDouble(this.txtdifvales.Text);
				double num29 = Conversions.ToDouble(this.txtTotalPropinas.Text);
				double num30 = Conversions.ToDouble(this.txtPropinasNuevo.Text);
				string text42 = MyProject.Forms.main.lblNombreUsuario.Text;
				string text43 = this.cmbxEmpresa.Text;
				text4 = "Select h from H";
				sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
				bool hasRows38 = sqlDataReader2.HasRows;
				if (hasRows38)
				{
					while (sqlDataReader2.Read())
					{
						bool flag186 = Operators.CompareString(Tools.Desencriptar(sqlDataReader2[0].ToString().Trim()), "1", false) == 0;
						if (flag186)
						{
							try
							{
								text4 = string.Concat(new string[]
								{
									"Insert into I ( a ,b ,c ,d ,e ,f ,g ,h ,i ,j , k , l , m, n , o , p , q , r , s , t , u , w , x )Values ( '",
									text39,
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
									"','",
									Tools.Encriptar(this.lblCOdigoUnicoCorte.Text.Trim()),
									"')"
								});
								sqlQuery_Conn.execQuery_conn(text4);
								this.InsertarCorteBitacora();
							}
							catch (Exception ex18)
							{
							}
						}
					}
					sqlDataReader2.Close();
				}
				text4 = "Delete from F";
				sqlQuery_Conn.execQuery_conn(text4);
				this.progBar.Value = 100;
				Interaction.MsgBox("Proceso Finalizado, los totales se actualizaron en el software para restaurante!", MsgBoxStyle.OkOnly, null);
				this.progBar.Value = 0;
				this.btnVistaPrevia.PerformClick();
				this.habilitaControles(true);
				this.Button1.Enabled = false;
				bool flag187 = Conversions.ToDouble(this.txtCuentasModificar.Text) != 0.0;
				if (flag187)
				{
					this.Button1.Enabled = true;
				}
				else
				{
					this.Button1.Enabled = false;
				}
			}
			bool flag188 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.No, false);
			if (flag188)
			{
			}
			this.txtBuscarProducto.Text = "";
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x000F68C8 File Offset: 0x000F4AC8
		private void Button2_Click(object sender, EventArgs e)
		{
			this.MostrarProductosReemplaza();
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x000F68D4 File Offset: 0x000F4AD4
		private void Button3_Click(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "SELECT TOP 1 a from N";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				object obj = "SE ELIMINARAN LOS PRODUCTOS ALMACENADOS PARA SUSTITUIR, Deseas continuar?";
				object value = 276;
				object obj2 = "ATENCIÓN!!!";
				object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
				bool flag = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
				if (flag)
				{
					query_conn = "DELETE FROM N";
					sqlQuery_Conn.execQuery_conn(query_conn);
					this.dgvNotas.Rows.Clear();
					this.MostrarPRoductos();
					this.btnVistaPrevia.Enabled = false;
				}
			}
			else
			{
				Interaction.MsgBox("El listado se encuentra vacio!", MsgBoxStyle.OkOnly, null);
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x000F69A5 File Offset: 0x000F4BA5
		private void PictureBox10_Click(object sender, EventArgs e)
		{
			this.Panel1.Visible = false;
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x000F69B5 File Offset: 0x000F4BB5
		private void PictureBox9_Click(object sender, EventArgs e)
		{
			this.Panel1.Visible = true;
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox3_DoubleClick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x000F69C5 File Offset: 0x000F4BC5
		private void BtnHorario_Click(object sender, EventArgs e)
		{
			this.BtnHorario.Enabled = false;
			this.dateHoraIni.Enabled = true;
			this.dateHoraFin.Enabled = true;
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x000F69F0 File Offset: 0x000F4BF0
		private void Button4_Click(object sender, EventArgs e)
		{
			int index = 0;
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = Operators.CompareString(Conversions.ToString(dataGridViewRow.Cells["Descripcion"].Value).ToLower(), this.txtBuscarProducto.Text.ToLower(), false) == 0;
					if (flag)
					{
						dataGridViewRow.Selected = true;
						index = dataGridViewRow.Index;
						break;
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
			this.dgvNotas.Rows[index].Selected = true;
			this.dgvNotas.CurrentCell = this.dgvNotas.Rows[index].Cells[0];
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x000F6AE4 File Offset: 0x000F4CE4
		private void PictureBox12_Click(object sender, EventArgs e)
		{
			this.PanelVerProductos.Visible = false;
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x000F6AF4 File Offset: 0x000F4CF4
		private void Button5_Click(object sender, EventArgs e)
		{
			this.PanelVerProductos.Visible = true;
			this.VerProductos();
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x000F6B0C File Offset: 0x000F4D0C
		public void VerProductos()
		{
			SqlQuery sqlQuery = new SqlQuery();
			this.iniciaGridVerProductos();
			string query = "select a.idproducto ,b.descripcion, a.precio , a.preciosinimpuestos , a.impuesto1 ,a.bloqueado from productosdetalle A \r\n                    Inner join productos B on b.idproducto = a.idproducto order by a.idproducto asc";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text = Conversions.ToString(sqlDataReader[0]);
					string text2 = Conversions.ToString(sqlDataReader[1]);
					double num = Conversions.ToDouble(sqlDataReader[2]);
					double num2 = Conversions.ToDouble(sqlDataReader[3]);
					string text3 = Conversions.ToString(sqlDataReader[4]);
					string text4 = Conversions.ToString(sqlDataReader[5]);
					bool flag = Operators.ConditionalCompareObjectEqual(sqlDataReader[5], false, false);
					if (flag)
					{
					}
					this.dgvVerProductos.Rows.Add(new object[]
					{
						text,
						text2,
						num.ToString("N2"),
						num2.ToString("N2"),
						text3
					});
				}
			}
			this.dgvVerProductos.RowsDefaultCellStyle.ForeColor = Color.Black;
			this.dgvVerProductos.DefaultCellStyle.BackColor = Color.White;
			sqlDataReader.Close();
			this.dgvVerProductos.ClearSelection();
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x000F6C60 File Offset: 0x000F4E60
		private void iniciaGridVerProductos()
		{
			this.DoubleBufferedASD(this.dgvVerProductos, true);
			this.dgvVerProductos.Rows.Clear();
			this.dgvVerProductos.ColumnCount = 5;
			this.dgvVerProductos.Columns[0].Name = "id_Producto";
			this.dgvVerProductos.Columns[0].Visible = false;
			this.dgvVerProductos.Columns[0].Width = 60;
			this.dgvVerProductos.Columns[1].Name = "Descripcion";
			this.dgvVerProductos.Columns[1].Width = 270;
			this.dgvVerProductos.Columns[2].Name = "Precio";
			this.dgvVerProductos.Columns[2].Width = 80;
			this.dgvVerProductos.Columns[3].Name = "Precio S/IVA";
			this.dgvVerProductos.Columns[3].Width = 80;
			this.dgvVerProductos.Columns[4].Name = "Impuesto";
			this.dgvVerProductos.Columns[4].Width = 80;
			this.dgvVerProductos.RowsDefaultCellStyle.ForeColor = Color.Black;
			this.dgvVerProductos.DefaultCellStyle.BackColor = Color.White;
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x000F6DEC File Offset: 0x000F4FEC
		public void VerProductosBuscar()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select a.idproducto ,b.descripcion, a.precio , a.preciosinimpuestos , a.impuesto1 from productosdetalle A \r\n                    Inner join productos B on b.idproducto = a.idproducto where b.Descripcion Like '%" + this.TextBox1.Text + "%' order by a.idproducto asc";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string text = Conversions.ToString(sqlDataReader[0]);
					string text2 = Conversions.ToString(sqlDataReader[1]);
					double num = Conversions.ToDouble(sqlDataReader[2]);
					double num2 = Conversions.ToDouble(sqlDataReader[3]);
					string text3 = Conversions.ToString(sqlDataReader[4]);
					this.dgvVerProductos.Rows.Add(new object[]
					{
						text,
						text2,
						num.ToString("N2"),
						num2.ToString("N2"),
						text3
					});
				}
			}
			sqlDataReader.Close();
			this.dgvVerProductos.ClearSelection();
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x000F6EE9 File Offset: 0x000F50E9
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			this.iniciaGridVerProductos();
			this.VerProductosBuscar();
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvVerProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x000F6EFA File Offset: 0x000F50FA
		private void txtBuscarProducto_Click(object sender, EventArgs e)
		{
			this.txtBuscarProducto.SelectAll();
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x000F6F09 File Offset: 0x000F5109
		private void TextBox1_Click(object sender, EventArgs e)
		{
			this.TextBox1.SelectAll();
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0001D5AF File Offset: 0x0001B7AF
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x000F6F18 File Offset: 0x000F5118
		private void Button6_Click(object sender, EventArgs e)
		{
			this.txtVales.Visible = true;
			this.txtVentasOtros.Visible = true;
			this.txtVentaTarjeta.Visible = true;
			this.txtventasinfacturar.Visible = true;
			this.lblventaenotros.Visible = true;
			this.lblVentaentarjeta.Visible = true;
			this.lblventaenVales.Visible = true;
			this.lblventasinfacturar.Visible = true;
			this.txtdifotros.Visible = true;
			this.txtDifTarjeta.Visible = true;
			this.txtdifvales.Visible = true;
			this.lbldifotros.Visible = true;
			this.lbldifTarjeta.Visible = true;
			this.lbldifvales.Visible = true;
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x000F6FDC File Offset: 0x000F51DC
		private void Button6_DoubleClick(object sender, EventArgs e)
		{
			this.txtVales.Visible = false;
			this.txtVentasOtros.Visible = false;
			this.txtVentaTarjeta.Visible = false;
			this.txtventasinfacturar.Visible = false;
			this.lblventaenotros.Visible = false;
			this.lblVentaentarjeta.Visible = false;
			this.lblventaenVales.Visible = false;
			this.lblventasinfacturar.Visible = false;
			this.txtdifotros.Visible = false;
			this.txtDifTarjeta.Visible = false;
			this.txtdifvales.Visible = false;
			this.lbldifotros.Visible = false;
			this.lbldifTarjeta.Visible = false;
			this.lbldifvales.Visible = false;
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x000F70A0 File Offset: 0x000F52A0
		private void btnCorteZ_Click(object sender, EventArgs e)
		{
			this.Panelvercortes.Visible = true;
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x000F70B0 File Offset: 0x000F52B0
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

		// Token: 0x06000F02 RID: 3842 RVA: 0x000F7470 File Offset: 0x000F5670
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

		// Token: 0x06000F03 RID: 3843 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox11_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvVerProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x000F74C8 File Offset: 0x000F56C8
		private void dgvVerProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			this.txtBuscarProducto.Text = Conversions.ToString(this.dgvVerProductos.Rows[rowIndex].Cells["Descripcion"].Value);
			this.PanelVerProductos.Visible = false;
			this.dgvNotas.Enabled = true;
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = Operators.ConditionalCompareObjectGreater(dataGridViewRow.Cells["Precio a sustituir"].Value, "0", false);
					if (flag)
					{
						dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
						dataGridViewRow.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
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
			this.btnVistaPrevia.Enabled = false;
			this.Button4.PerformClick();
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x000F6EE9 File Offset: 0x000F50E9
		private void TextBox1_TextChanged_1(object sender, EventArgs e)
		{
			this.iniciaGridVerProductos();
			this.VerProductosBuscar();
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x000F75F8 File Offset: 0x000F57F8
		private void PictureBox12_Click_1(object sender, EventArgs e)
		{
			this.PanelVerProductos.Visible = false;
			this.TextBox1.Clear();
		}

		// Token: 0x040006BE RID: 1726
		private string idprodmodificar;

		// Token: 0x040006BF RID: 1727
		private string Preciomodificar;

		// Token: 0x040006C0 RID: 1728
		private double dblGrantotal;

		// Token: 0x040006C1 RID: 1729
		private double dblPrecioProdSustituir;

		// Token: 0x040006C2 RID: 1730
		private double dblPrecioPodAnterior;

		// Token: 0x040006C3 RID: 1731
		private string idnoteprueba;

		// Token: 0x040006C4 RID: 1732
		private string cantidadprodpelon;

		// Token: 0x040006C5 RID: 1733
		private string Contadrprodrepetidos;

		// Token: 0x040006C6 RID: 1734
		private string DifPorcentajeSin;
	}
}
