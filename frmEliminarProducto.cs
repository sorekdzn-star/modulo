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
	// Token: 0x02000015 RID: 21
	[DesignerGenerated]
	public partial class frmEliminarProducto : Form
	{
		// Token: 0x060005FB RID: 1531 RVA: 0x00054B40 File Offset: 0x00052D40
		public frmEliminarProducto()
		{
			base.Load += this.frmEliminarProducto_Load;
			this.table = new DataTable();
			this.view = new DataView(this.table);
			this.counter = 0;
			this.InitializeComponent();
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x000603D0 File Offset: 0x0005E5D0
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x000603DA File Offset: 0x0005E5DA
		internal virtual TextBox txtCuentasModificar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x000603E3 File Offset: 0x0005E5E3
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x000603ED File Offset: 0x0005E5ED
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x000603F6 File Offset: 0x0005E5F6
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x00060400 File Offset: 0x0005E600
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

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x00060443 File Offset: 0x0005E643
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x0006044D File Offset: 0x0005E64D
		internal virtual TextBox txtCuentasTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00060456 File Offset: 0x0005E656
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x00060460 File Offset: 0x0005E660
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

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x000604A3 File Offset: 0x0005E6A3
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x000604AD File Offset: 0x0005E6AD
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x000604B6 File Offset: 0x0005E6B6
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x000604C0 File Offset: 0x0005E6C0
		internal virtual TextBox txtDifPorcen { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x000604C9 File Offset: 0x0005E6C9
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x000604D3 File Offset: 0x0005E6D3
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x000604DC File Offset: 0x0005E6DC
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x000604E6 File Offset: 0x0005E6E6
		internal virtual TextBox txtEfectivoAnt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x000604EF File Offset: 0x0005E6EF
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x000604F9 File Offset: 0x0005E6F9
		internal virtual TextBox txtEfectivoCaja { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x00060502 File Offset: 0x0005E702
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x0006050C File Offset: 0x0005E70C
		internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00060515 File Offset: 0x0005E715
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x0006051F File Offset: 0x0005E71F
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x00060528 File Offset: 0x0005E728
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x00060532 File Offset: 0x0005E732
		internal virtual TextBox txtDifImporte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x0006053B File Offset: 0x0005E73B
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x00060545 File Offset: 0x0005E745
		internal virtual TextBox txtEfectivoFiscal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0006054E File Offset: 0x0005E74E
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x00060558 File Offset: 0x0005E758
		internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00060561 File Offset: 0x0005E761
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x0006056B File Offset: 0x0005E76B
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00060574 File Offset: 0x0005E774
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x0006057E File Offset: 0x0005E77E
		internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00060587 File Offset: 0x0005E787
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00060591 File Offset: 0x0005E791
		internal virtual TextBox txtImpNuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x0006059A File Offset: 0x0005E79A
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x000605A4 File Offset: 0x0005E7A4
		internal virtual TextBox txtImpAnterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x000605AD File Offset: 0x0005E7AD
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x000605B7 File Offset: 0x0005E7B7
		internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x000605C0 File Offset: 0x0005E7C0
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x000605CA File Offset: 0x0005E7CA
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x000605D3 File Offset: 0x0005E7D3
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x000605E0 File Offset: 0x0005E7E0
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

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x00060623 File Offset: 0x0005E823
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x0006062D File Offset: 0x0005E82D
		internal virtual DateTimePicker dateHoraFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00060636 File Offset: 0x0005E836
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00060640 File Offset: 0x0005E840
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

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00060683 File Offset: 0x0005E883
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00060690 File Offset: 0x0005E890
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

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x000606D3 File Offset: 0x0005E8D3
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x000606DD File Offset: 0x0005E8DD
		internal virtual ProgressBar progBar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x000606E6 File Offset: 0x0005E8E6
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x000606F0 File Offset: 0x0005E8F0
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x000606F9 File Offset: 0x0005E8F9
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x00060704 File Offset: 0x0005E904
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

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x00060747 File Offset: 0x0005E947
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x00060751 File Offset: 0x0005E951
		internal virtual GroupBox groupPeriodo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x0006075A File Offset: 0x0005E95A
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x00060764 File Offset: 0x0005E964
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x0006076D File Offset: 0x0005E96D
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00060777 File Offset: 0x0005E977
		internal virtual DateTimePicker dateHoraIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00060780 File Offset: 0x0005E980
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x0006078A File Offset: 0x0005E98A
		internal virtual ComboBox cmbxSerie { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x00060793 File Offset: 0x0005E993
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x0006079D File Offset: 0x0005E99D
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x000607A6 File Offset: 0x0005E9A6
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x000607B0 File Offset: 0x0005E9B0
		internal virtual DateTimePicker dateFechaFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x000607B9 File Offset: 0x0005E9B9
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x000607C3 File Offset: 0x0005E9C3
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x000607CC File Offset: 0x0005E9CC
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x000607D6 File Offset: 0x0005E9D6
		internal virtual DateTimePicker dateFechaIni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x000607DF File Offset: 0x0005E9DF
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x000607E9 File Offset: 0x0005E9E9
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x000607F2 File Offset: 0x0005E9F2
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x000607FC File Offset: 0x0005E9FC
		internal virtual GroupBox groupParametros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x00060805 File Offset: 0x0005EA05
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x0006080F File Offset: 0x0005EA0F
		internal virtual TextBox txtObjetivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00060818 File Offset: 0x0005EA18
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00060822 File Offset: 0x0005EA22
		internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x0006082B File Offset: 0x0005EA2B
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00060835 File Offset: 0x0005EA35
		internal virtual CheckBox chkEliminaRet { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0006083E File Offset: 0x0005EA3E
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x00060848 File Offset: 0x0005EA48
		internal virtual CheckBox chkEliminaProp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00060851 File Offset: 0x0005EA51
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x0006085B File Offset: 0x0005EA5B
		internal virtual CheckBox chkRenumerar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x00060864 File Offset: 0x0005EA64
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x0006086E File Offset: 0x0005EA6E
		internal virtual CheckBox chkCtasCortesia { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00060877 File Offset: 0x0005EA77
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00060881 File Offset: 0x0005EA81
		internal virtual CheckBox chkTarjCred { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0006088A File Offset: 0x0005EA8A
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x00060894 File Offset: 0x0005EA94
		internal virtual CheckBox chkVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0006089D File Offset: 0x0005EA9D
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x000608A7 File Offset: 0x0005EAA7
		internal virtual CheckBox chkReimpresas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x000608B0 File Offset: 0x0005EAB0
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x000608BC File Offset: 0x0005EABC
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

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x000608FF File Offset: 0x0005EAFF
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x00060909 File Offset: 0x0005EB09
		internal virtual CheckBox chkOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00060912 File Offset: 0x0005EB12
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x0006091C File Offset: 0x0005EB1C
		internal virtual CheckBox chkFacturada { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00060925 File Offset: 0x0005EB25
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x0006092F File Offset: 0x0005EB2F
		internal virtual CheckBox chkNotaConsumo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00060938 File Offset: 0x0005EB38
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00060942 File Offset: 0x0005EB42
		internal virtual CheckBox chkEfectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x0006094B File Offset: 0x0005EB4B
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00060955 File Offset: 0x0005EB55
		internal virtual ComboBox cmbxEmpresa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x0006095E File Offset: 0x0005EB5E
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00060968 File Offset: 0x0005EB68
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00060971 File Offset: 0x0005EB71
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x0006097B File Offset: 0x0005EB7B
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00060984 File Offset: 0x0005EB84
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00060990 File Offset: 0x0005EB90
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

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x000609EE File Offset: 0x0005EBEE
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x000609F8 File Offset: 0x0005EBF8
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00060A01 File Offset: 0x0005EC01
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00060A0C File Offset: 0x0005EC0C
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

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00060A6A File Offset: 0x0005EC6A
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00060A74 File Offset: 0x0005EC74
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00060A7D File Offset: 0x0005EC7D
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x00060A87 File Offset: 0x0005EC87
		internal virtual ComboBox cmbxTipo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00060A90 File Offset: 0x0005EC90
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x00060A9A File Offset: 0x0005EC9A
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00060AA3 File Offset: 0x0005ECA3
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x00060AAD File Offset: 0x0005ECAD
		internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00060AB6 File Offset: 0x0005ECB6
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x00060AC0 File Offset: 0x0005ECC0
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

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00060B39 File Offset: 0x0005ED39
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00060B43 File Offset: 0x0005ED43
		internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x00060B4C File Offset: 0x0005ED4C
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00060B56 File Offset: 0x0005ED56
		internal virtual Label lblFechaInicio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x00060B5F File Offset: 0x0005ED5F
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x00060B69 File Offset: 0x0005ED69
		internal virtual Label lblFechaFin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x00060B72 File Offset: 0x0005ED72
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x00060B7C File Offset: 0x0005ED7C
		internal virtual Label lblfechahoy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x00060B85 File Offset: 0x0005ED85
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x00060B8F File Offset: 0x0005ED8F
		internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00060B98 File Offset: 0x0005ED98
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x00060BA2 File Offset: 0x0005EDA2
		internal virtual TextBox txtDepositos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00060BAB File Offset: 0x0005EDAB
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x00060BB5 File Offset: 0x0005EDB5
		internal virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x00060BBE File Offset: 0x0005EDBE
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x00060BC8 File Offset: 0x0005EDC8
		internal virtual TextBox txtretirostotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00060BD1 File Offset: 0x0005EDD1
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x00060BDB File Offset: 0x0005EDDB
		internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00060BE4 File Offset: 0x0005EDE4
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00060BEE File Offset: 0x0005EDEE
		internal virtual TextBox txtTotalPropinas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x00060BF7 File Offset: 0x0005EDF7
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x00060C01 File Offset: 0x0005EE01
		internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00060C0A File Offset: 0x0005EE0A
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x00060C14 File Offset: 0x0005EE14
		internal virtual TextBox txtFacturaPUB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00060C1D File Offset: 0x0005EE1D
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x00060C27 File Offset: 0x0005EE27
		internal virtual Label lblVentaSinFacturar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00060C30 File Offset: 0x0005EE30
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x00060C3A File Offset: 0x0005EE3A
		internal virtual TextBox txtventasinfacturar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x00060C43 File Offset: 0x0005EE43
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x00060C4D File Offset: 0x0005EE4D
		internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00060C56 File Offset: 0x0005EE56
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x00060C60 File Offset: 0x0005EE60
		internal virtual TextBox txtVentaFacturada { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00060C69 File Offset: 0x0005EE69
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x00060C73 File Offset: 0x0005EE73
		internal virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00060C7C File Offset: 0x0005EE7C
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x00060C88 File Offset: 0x0005EE88
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

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00060CCB File Offset: 0x0005EECB
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x00060CD5 File Offset: 0x0005EED5
		internal virtual Label lblVentaentarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00060CDE File Offset: 0x0005EEDE
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x00060CE8 File Offset: 0x0005EEE8
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

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00060D2B File Offset: 0x0005EF2B
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00060D35 File Offset: 0x0005EF35
		internal virtual Label lblventaenotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00060D3E File Offset: 0x0005EF3E
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x00060D48 File Offset: 0x0005EF48
		internal virtual TextBox txtVentasOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00060D51 File Offset: 0x0005EF51
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x00060D5B File Offset: 0x0005EF5B
		internal virtual Label lblventaenVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00060D64 File Offset: 0x0005EF64
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x00060D6E File Offset: 0x0005EF6E
		internal virtual TextBox txtVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00060D77 File Offset: 0x0005EF77
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x00060D81 File Offset: 0x0005EF81
		internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00060D8A File Offset: 0x0005EF8A
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x00060D94 File Offset: 0x0005EF94
		internal virtual TextBox txttotalnuevopropinas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00060D9D File Offset: 0x0005EF9D
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x00060DA7 File Offset: 0x0005EFA7
		internal virtual Panel Panelvercortes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x00060DB0 File Offset: 0x0005EFB0
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00060DBA File Offset: 0x0005EFBA
		internal virtual Label Label51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00060DC3 File Offset: 0x0005EFC3
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x00060DCD File Offset: 0x0005EFCD
		internal virtual Label Label52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00060DD6 File Offset: 0x0005EFD6
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x00060DE0 File Offset: 0x0005EFE0
		internal virtual Label lblEfectivonuevocorte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00060DE9 File Offset: 0x0005EFE9
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x00060DF3 File Offset: 0x0005EFF3
		internal virtual Label lblsaldofinarlcortenuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00060DFC File Offset: 0x0005EFFC
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x00060E06 File Offset: 0x0005F006
		internal virtual Label lblpropinascortenuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00060E0F File Offset: 0x0005F00F
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x00060E19 File Offset: 0x0005F019
		internal virtual Label lblcortenuevoretiros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00060E22 File Offset: 0x0005F022
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x00060E2C File Offset: 0x0005F02C
		internal virtual Label lblcortenuevodepositos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00060E35 File Offset: 0x0005F035
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00060E3F File Offset: 0x0005F03F
		internal virtual Label lblcortenuevotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00060E48 File Offset: 0x0005F048
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x00060E52 File Offset: 0x0005F052
		internal virtual Label lblcortenuevovales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00060E5B File Offset: 0x0005F05B
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x00060E65 File Offset: 0x0005F065
		internal virtual Label lblcortetarjetanuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00060E6E File Offset: 0x0005F06E
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x00060E78 File Offset: 0x0005F078
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

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00060EBB File Offset: 0x0005F0BB
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x00060EC5 File Offset: 0x0005F0C5
		internal virtual Label lblcorteefectivonuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x00060ECE File Offset: 0x0005F0CE
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x00060ED8 File Offset: 0x0005F0D8
		internal virtual Label lblfondoinicialnuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x00060EE1 File Offset: 0x0005F0E1
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x00060EEB File Offset: 0x0005F0EB
		internal virtual Label lblcortefondoinicialanterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x00060EF4 File Offset: 0x0005F0F4
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x00060EFE File Offset: 0x0005F0FE
		internal virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x00060F07 File Offset: 0x0005F107
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x00060F11 File Offset: 0x0005F111
		internal virtual Label Label41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00060F1A File Offset: 0x0005F11A
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x00060F24 File Offset: 0x0005F124
		internal virtual Label Label42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00060F2D File Offset: 0x0005F12D
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x00060F37 File Offset: 0x0005F137
		internal virtual Label Label43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00060F40 File Offset: 0x0005F140
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00060F4A File Offset: 0x0005F14A
		internal virtual Label Label44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00060F53 File Offset: 0x0005F153
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00060F5D File Offset: 0x0005F15D
		internal virtual Label Label45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x00060F66 File Offset: 0x0005F166
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x00060F70 File Offset: 0x0005F170
		internal virtual Label Label46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00060F79 File Offset: 0x0005F179
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x00060F83 File Offset: 0x0005F183
		internal virtual Label Label47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00060F8C File Offset: 0x0005F18C
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x00060F96 File Offset: 0x0005F196
		internal virtual Label Label48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00060F9F File Offset: 0x0005F19F
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00060FA9 File Offset: 0x0005F1A9
		internal virtual Label Label49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00060FB2 File Offset: 0x0005F1B2
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x00060FBC File Offset: 0x0005F1BC
		internal virtual Label lblcorteanteriorefectivofinal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00060FC5 File Offset: 0x0005F1C5
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x00060FCF File Offset: 0x0005F1CF
		internal virtual Label lblcorteanteriorsaldo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00060FD8 File Offset: 0x0005F1D8
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x00060FE2 File Offset: 0x0005F1E2
		internal virtual Label lblcorteanteriorpropinas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00060FEB File Offset: 0x0005F1EB
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00060FF5 File Offset: 0x0005F1F5
		internal virtual Label lblcorteanteriorretirosefectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00060FFE File Offset: 0x0005F1FE
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x00061008 File Offset: 0x0005F208
		internal virtual Label lblcorteanteriordepositosenefectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00061011 File Offset: 0x0005F211
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x0006101B File Offset: 0x0005F21B
		internal virtual Label lblcorteanteriorotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00061024 File Offset: 0x0005F224
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x0006102E File Offset: 0x0005F22E
		internal virtual Label lblcorteanteriorvales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00061037 File Offset: 0x0005F237
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00061041 File Offset: 0x0005F241
		internal virtual Label lblcorteefectivoanterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0006104A File Offset: 0x0005F24A
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x00061054 File Offset: 0x0005F254
		internal virtual Label lblcortetarjetaanterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0006105D File Offset: 0x0005F25D
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x00061067 File Offset: 0x0005F267
		internal virtual Label Label38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00061070 File Offset: 0x0005F270
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x0006107A File Offset: 0x0005F27A
		internal virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00061083 File Offset: 0x0005F283
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x0006108D File Offset: 0x0005F28D
		internal virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x00061096 File Offset: 0x0005F296
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x000610A0 File Offset: 0x0005F2A0
		internal virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x000610A9 File Offset: 0x0005F2A9
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x000610B3 File Offset: 0x0005F2B3
		internal virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x000610BC File Offset: 0x0005F2BC
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x000610C6 File Offset: 0x0005F2C6
		internal virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x000610CF File Offset: 0x0005F2CF
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x000610D9 File Offset: 0x0005F2D9
		internal virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x000610E2 File Offset: 0x0005F2E2
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x000610EC File Offset: 0x0005F2EC
		internal virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x000610F5 File Offset: 0x0005F2F5
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x000610FF File Offset: 0x0005F2FF
		internal virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00061108 File Offset: 0x0005F308
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00061112 File Offset: 0x0005F312
		internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x0006111B File Offset: 0x0005F31B
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x00061125 File Offset: 0x0005F325
		internal virtual CheckBox CheckBoxfondocaja { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x0006112E File Offset: 0x0005F32E
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00061138 File Offset: 0x0005F338
		internal virtual Label lbldifvales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00061141 File Offset: 0x0005F341
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x0006114B File Offset: 0x0005F34B
		internal virtual TextBox txtdifvales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00061154 File Offset: 0x0005F354
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x0006115E File Offset: 0x0005F35E
		internal virtual Label lbldifotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00061167 File Offset: 0x0005F367
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00061171 File Offset: 0x0005F371
		internal virtual TextBox txtdifotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0006117A File Offset: 0x0005F37A
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x00061184 File Offset: 0x0005F384
		internal virtual Label lbldifTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0006118D File Offset: 0x0005F38D
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00061197 File Offset: 0x0005F397
		internal virtual TextBox txtDifTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x000611A0 File Offset: 0x0005F3A0
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x000611AA File Offset: 0x0005F3AA
		internal virtual Panel PanelCheqdet { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x000611B3 File Offset: 0x0005F3B3
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x000611BD File Offset: 0x0005F3BD
		internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x000611C6 File Offset: 0x0005F3C6
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x000611D0 File Offset: 0x0005F3D0
		internal virtual DataGridView DataGridCheqdet
		{
			[CompilerGenerated]
			get
			{
				return this._DataGridCheqdet;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DataGridCheqdet_CellContentClick);
				DataGridView dataGridCheqdet = this._DataGridCheqdet;
				if (dataGridCheqdet != null)
				{
					dataGridCheqdet.CellContentClick -= value2;
				}
				this._DataGridCheqdet = value;
				dataGridCheqdet = this._DataGridCheqdet;
				if (dataGridCheqdet != null)
				{
					dataGridCheqdet.CellContentClick += value2;
				}
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00061213 File Offset: 0x0005F413
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x0006121D File Offset: 0x0005F41D
		internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00061226 File Offset: 0x0005F426
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00061230 File Offset: 0x0005F430
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

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00061273 File Offset: 0x0005F473
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x0006127D File Offset: 0x0005F47D
		internal virtual Label lblcontarfilas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00061286 File Offset: 0x0005F486
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x00061290 File Offset: 0x0005F490
		internal virtual Label lblsumartotaldescontar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00061299 File Offset: 0x0005F499
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x000612A3 File Offset: 0x0005F4A3
		internal virtual Label Label50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x000612AC File Offset: 0x0005F4AC
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x000612B6 File Offset: 0x0005F4B6
		internal virtual ComboBox CmbMovtos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x000612BF File Offset: 0x0005F4BF
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x000612C9 File Offset: 0x0005F4C9
		internal virtual Label lblcontadordefila { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x000612D2 File Offset: 0x0005F4D2
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x000612DC File Offset: 0x0005F4DC
		internal virtual Label Label54 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x000612E5 File Offset: 0x0005F4E5
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x000612EF File Offset: 0x0005F4EF
		internal virtual Panel Panel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x000612F8 File Offset: 0x0005F4F8
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00061302 File Offset: 0x0005F502
		internal virtual Panel Panel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x0006130B File Offset: 0x0005F50B
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x00061315 File Offset: 0x0005F515
		internal virtual Label Label55 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0006131E File Offset: 0x0005F51E
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00061328 File Offset: 0x0005F528
		internal virtual Label lblfechayhora { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00061331 File Offset: 0x0005F531
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x0006133B File Offset: 0x0005F53B
		internal virtual Panel Panel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00061344 File Offset: 0x0005F544
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x00061350 File Offset: 0x0005F550
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

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00061393 File Offset: 0x0005F593
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x000613A0 File Offset: 0x0005F5A0
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

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x000613E3 File Offset: 0x0005F5E3
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x000613F0 File Offset: 0x0005F5F0
		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00061433 File Offset: 0x0005F633
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00061440 File Offset: 0x0005F640
		internal virtual Button btnReloj
		{
			[CompilerGenerated]
			get
			{
				return this._btnReloj;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				Button btnReloj = this._btnReloj;
				if (btnReloj != null)
				{
					btnReloj.Click -= value2;
				}
				this._btnReloj = value;
				btnReloj = this._btnReloj;
				if (btnReloj != null)
				{
					btnReloj.Click += value2;
				}
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00061483 File Offset: 0x0005F683
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x0006148D File Offset: 0x0005F68D
		internal virtual Label lblOrdenDeCuentas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00061496 File Offset: 0x0005F696
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x000614A0 File Offset: 0x0005F6A0
		internal virtual CheckBox CheckBoxCuentasCanceladas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x000614A9 File Offset: 0x0005F6A9
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x000614B3 File Offset: 0x0005F6B3
		internal virtual Panel PanelDetalleTicket { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x000614BC File Offset: 0x0005F6BC
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x000614C6 File Offset: 0x0005F6C6
		internal virtual Panel Panel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x000614CF File Offset: 0x0005F6CF
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x000614DC File Offset: 0x0005F6DC
		internal virtual DataGridView DataGridDetalleTickets
		{
			[CompilerGenerated]
			get
			{
				return this._DataGridDetalleTickets;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DataGridDetalleTickets_CellClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.DataGridDetalleTickets_CellContentClick);
				DataGridView dataGridDetalleTickets = this._DataGridDetalleTickets;
				if (dataGridDetalleTickets != null)
				{
					dataGridDetalleTickets.CellClick -= value2;
					dataGridDetalleTickets.CellContentClick -= value3;
				}
				this._DataGridDetalleTickets = value;
				dataGridDetalleTickets = this._DataGridDetalleTickets;
				if (dataGridDetalleTickets != null)
				{
					dataGridDetalleTickets.CellClick += value2;
					dataGridDetalleTickets.CellContentClick += value3;
				}
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0006153A File Offset: 0x0005F73A
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00061544 File Offset: 0x0005F744
		internal virtual Panel Panel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x0006154D File Offset: 0x0005F74D
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00061558 File Offset: 0x0005F758
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

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x0006159B File Offset: 0x0005F79B
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x000615A5 File Offset: 0x0005F7A5
		internal virtual Label lblpruebapanel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x000615AE File Offset: 0x0005F7AE
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x000615B8 File Offset: 0x0005F7B8
		internal virtual Label Label56 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x000615C1 File Offset: 0x0005F7C1
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x000615CB File Offset: 0x0005F7CB
		internal virtual Label lblfoliodelticket { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x000615D4 File Offset: 0x0005F7D4
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x000615DE File Offset: 0x0005F7DE
		internal virtual Label lbltotaloriginal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x000615E7 File Offset: 0x0005F7E7
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x000615F1 File Offset: 0x0005F7F1
		internal virtual Label Label57 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x000615FA File Offset: 0x0005F7FA
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x00061604 File Offset: 0x0005F804
		internal virtual Label lblnuevototal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x0006160D File Offset: 0x0005F80D
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x00061617 File Offset: 0x0005F817
		internal virtual Label Label59 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00061620 File Offset: 0x0005F820
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x0006162A File Offset: 0x0005F82A
		internal virtual Label lblcontador { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00061633 File Offset: 0x0005F833
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x0006163D File Offset: 0x0005F83D
		internal virtual Label lblfolioini { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00061646 File Offset: 0x0005F846
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x00061650 File Offset: 0x0005F850
		internal virtual Label lblFilasELiminar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00061659 File Offset: 0x0005F859
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x00061663 File Offset: 0x0005F863
		internal virtual Label lblnumerodefila { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x0006166C File Offset: 0x0005F86C
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x00061676 File Offset: 0x0005F876
		internal virtual Panel Panel10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x0006167F File Offset: 0x0005F87F
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x00061689 File Offset: 0x0005F889
		internal virtual Label lblAfectadboreal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00061692 File Offset: 0x0005F892
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x0006169C File Offset: 0x0005F89C
		internal virtual Label lbltipobarrido { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x000616A5 File Offset: 0x0005F8A5
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x000616AF File Offset: 0x0005F8AF
		internal virtual Label lblfecha_btm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x000616B8 File Offset: 0x0005F8B8
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x000616C4 File Offset: 0x0005F8C4
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

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00061707 File Offset: 0x0005F907
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x00061714 File Offset: 0x0005F914
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

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00061772 File Offset: 0x0005F972
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x0006177C File Offset: 0x0005F97C
		internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00061785 File Offset: 0x0005F985
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x0006178F File Offset: 0x0005F98F
		internal virtual Label lblcontafilastotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00061798 File Offset: 0x0005F998
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x000617A2 File Offset: 0x0005F9A2
		internal virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x000617AB File Offset: 0x0005F9AB
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x000617B5 File Offset: 0x0005F9B5
		internal virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x000617BE File Offset: 0x0005F9BE
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x000617C8 File Offset: 0x0005F9C8
		internal virtual Label Label53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x000617D1 File Offset: 0x0005F9D1
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x000617DB File Offset: 0x0005F9DB
		internal virtual Label Label58 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x000617E4 File Offset: 0x0005F9E4
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x000617EE File Offset: 0x0005F9EE
		internal virtual Label lblfacturapubnew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x000617F7 File Offset: 0x0005F9F7
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x00061801 File Offset: 0x0005FA01
		internal virtual Label lblventasinfacturarnew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0006180A File Offset: 0x0005FA0A
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x00061814 File Offset: 0x0005FA14
		internal virtual Label lblventafacturanew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0006181D File Offset: 0x0005FA1D
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00061827 File Offset: 0x0005FA27
		internal virtual Label lblfacturapub { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00061830 File Offset: 0x0005FA30
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x0006183A File Offset: 0x0005FA3A
		internal virtual Label lblventasinfacturarcorte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00061843 File Offset: 0x0005FA43
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x0006184D File Offset: 0x0005FA4D
		internal virtual Label lblventaFacturada { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00061856 File Offset: 0x0005FA56
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00061860 File Offset: 0x0005FA60
		internal virtual Label Label60 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00061869 File Offset: 0x0005FA69
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00061873 File Offset: 0x0005FA73
		internal virtual Label Label61 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x0006187C File Offset: 0x0005FA7C
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x00061886 File Offset: 0x0005FA86
		internal virtual Label Label62 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x0006188F File Offset: 0x0005FA8F
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x00061899 File Offset: 0x0005FA99
		internal virtual Label Label63 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x000618A2 File Offset: 0x0005FAA2
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x000618AC File Offset: 0x0005FAAC
		internal virtual Label Label64 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x000618B5 File Offset: 0x0005FAB5
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x000618BF File Offset: 0x0005FABF
		internal virtual Label Label65 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x000618C8 File Offset: 0x0005FAC8
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x000618D2 File Offset: 0x0005FAD2
		internal virtual Label lblCOdigoUnicoCorte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x000618DB File Offset: 0x0005FADB
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x000618E8 File Offset: 0x0005FAE8
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

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x0006192B File Offset: 0x0005FB2B
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x00061935 File Offset: 0x0005FB35
		internal virtual DataGridView DataGridView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x0006193E File Offset: 0x0005FB3E
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x00061948 File Offset: 0x0005FB48
		internal virtual Panel Panel12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00061951 File Offset: 0x0005FB51
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x0006195C File Offset: 0x0005FB5C
		internal virtual Button btnAgregarProductos
		{
			[CompilerGenerated]
			get
			{
				return this._btnAgregarProductos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnAgregarProductos_Click);
				Button btnAgregarProductos = this._btnAgregarProductos;
				if (btnAgregarProductos != null)
				{
					btnAgregarProductos.Click -= value2;
				}
				this._btnAgregarProductos = value;
				btnAgregarProductos = this._btnAgregarProductos;
				if (btnAgregarProductos != null)
				{
					btnAgregarProductos.Click += value2;
				}
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x0006199F File Offset: 0x0005FB9F
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x000619A9 File Offset: 0x0005FBA9
		internal virtual Panel PanelBuscarProducto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x000619B2 File Offset: 0x0005FBB2
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x000619BC File Offset: 0x0005FBBC
		internal virtual Panel Panel17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x000619C5 File Offset: 0x0005FBC5
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x000619D0 File Offset: 0x0005FBD0
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
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.dgwProductos_CellContentClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.dgwProductos_CellClick);
				DataGridViewCellEventHandler value4 = new DataGridViewCellEventHandler(this.dgwProductos_CellValueChanged);
				DataGridViewCellEventHandler value5 = new DataGridViewCellEventHandler(this.dgwProductos_CellEndEdit);
				DataGridViewCellEventHandler value6 = new DataGridViewCellEventHandler(this.dgwProductos_CellDoubleClick);
				DataGridView dgwProductos = this._dgwProductos;
				if (dgwProductos != null)
				{
					dgwProductos.CellContentClick -= value2;
					dgwProductos.CellClick -= value3;
					dgwProductos.CellValueChanged -= value4;
					dgwProductos.CellEndEdit -= value5;
					dgwProductos.CellDoubleClick -= value6;
				}
				this._dgwProductos = value;
				dgwProductos = this._dgwProductos;
				if (dgwProductos != null)
				{
					dgwProductos.CellContentClick += value2;
					dgwProductos.CellClick += value3;
					dgwProductos.CellValueChanged += value4;
					dgwProductos.CellEndEdit += value5;
					dgwProductos.CellDoubleClick += value6;
				}
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x00061A90 File Offset: 0x0005FC90
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x00061A9A File Offset: 0x0005FC9A
		internal virtual Panel Panel13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x00061AA3 File Offset: 0x0005FCA3
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x00061AB0 File Offset: 0x0005FCB0
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

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00061AF3 File Offset: 0x0005FCF3
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x00061AFD File Offset: 0x0005FCFD
		internal virtual Panel Panel14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x00061B06 File Offset: 0x0005FD06
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x00061B10 File Offset: 0x0005FD10
		internal virtual Label lblContadorJC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x00061B19 File Offset: 0x0005FD19
		// (set) Token: 0x060007AB RID: 1963 RVA: 0x00061B23 File Offset: 0x0005FD23
		internal virtual Label Label66 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x00061B2C File Offset: 0x0005FD2C
		// (set) Token: 0x060007AD RID: 1965 RVA: 0x00061B38 File Offset: 0x0005FD38
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
				TextBox txtBuscarProducto = this._txtBuscarProducto;
				if (txtBuscarProducto != null)
				{
					txtBuscarProducto.TextChanged -= value2;
				}
				this._txtBuscarProducto = value;
				txtBuscarProducto = this._txtBuscarProducto;
				if (txtBuscarProducto != null)
				{
					txtBuscarProducto.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x00061B7B File Offset: 0x0005FD7B
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x00061B88 File Offset: 0x0005FD88
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
				EventHandler value2 = new EventHandler(this.PictureBox4_Click_1);
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

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x00061BCB File Offset: 0x0005FDCB
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x00061BD5 File Offset: 0x0005FDD5
		internal virtual Label lblidFoliodet { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x00061BDE File Offset: 0x0005FDDE
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x00061BE8 File Offset: 0x0005FDE8
		internal virtual Label lblFechadelProducto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x00061BF1 File Offset: 0x0005FDF1
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x00061BFB File Offset: 0x0005FDFB
		internal virtual Label lblidturno_jc { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00061C04 File Offset: 0x0005FE04
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x00061C0E File Offset: 0x0005FE0E
		internal virtual Label lblTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00061C17 File Offset: 0x0005FE17
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x00061C21 File Offset: 0x0005FE21
		internal virtual Label txtSubtotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x00061C2A File Offset: 0x0005FE2A
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x00061C34 File Offset: 0x0005FE34
		internal virtual Label lblTotalBebidas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00061C3D File Offset: 0x0005FE3D
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x00061C47 File Offset: 0x0005FE47
		internal virtual Label lblTotalAlimentos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00061C50 File Offset: 0x0005FE50
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x00061C5A File Offset: 0x0005FE5A
		internal virtual Label lblTotalOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00061C63 File Offset: 0x0005FE63
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00061C6D File Offset: 0x0005FE6D
		internal virtual Label lblimpuesto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00061C76 File Offset: 0x0005FE76
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x00061C80 File Offset: 0x0005FE80
		internal virtual Panel PanelFormasPago { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00061C89 File Offset: 0x0005FE89
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00061C93 File Offset: 0x0005FE93
		internal virtual Panel Panel16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00061C9C File Offset: 0x0005FE9C
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00061CA6 File Offset: 0x0005FEA6
		internal virtual Label Label67 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00061CAF File Offset: 0x0005FEAF
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x00061CB9 File Offset: 0x0005FEB9
		internal virtual PictureBox PictureBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00061CC2 File Offset: 0x0005FEC2
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x00061CCC File Offset: 0x0005FECC
		internal virtual Panel Panel15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00061CD5 File Offset: 0x0005FED5
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x00061CE0 File Offset: 0x0005FEE0
		internal virtual Button btnVales
		{
			[CompilerGenerated]
			get
			{
				return this._btnVales;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnVales_Click);
				Button btnVales = this._btnVales;
				if (btnVales != null)
				{
					btnVales.Click -= value2;
				}
				this._btnVales = value;
				btnVales = this._btnVales;
				if (btnVales != null)
				{
					btnVales.Click += value2;
				}
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x00061D23 File Offset: 0x0005FF23
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x00061D30 File Offset: 0x0005FF30
		internal virtual Button btnOtros
		{
			[CompilerGenerated]
			get
			{
				return this._btnOtros;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnOtros_Click);
				Button btnOtros = this._btnOtros;
				if (btnOtros != null)
				{
					btnOtros.Click -= value2;
				}
				this._btnOtros = value;
				btnOtros = this._btnOtros;
				if (btnOtros != null)
				{
					btnOtros.Click += value2;
				}
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00061D73 File Offset: 0x0005FF73
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00061D80 File Offset: 0x0005FF80
		internal virtual Button btnTarjeta
		{
			[CompilerGenerated]
			get
			{
				return this._btnTarjeta;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnTarjeta_Click);
				Button btnTarjeta = this._btnTarjeta;
				if (btnTarjeta != null)
				{
					btnTarjeta.Click -= value2;
				}
				this._btnTarjeta = value;
				btnTarjeta = this._btnTarjeta;
				if (btnTarjeta != null)
				{
					btnTarjeta.Click += value2;
				}
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00061DC3 File Offset: 0x0005FFC3
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x00061DD0 File Offset: 0x0005FFD0
		internal virtual Button btnEfectivo
		{
			[CompilerGenerated]
			get
			{
				return this._btnEfectivo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btnEfectivo_Click);
				Button btnEfectivo = this._btnEfectivo;
				if (btnEfectivo != null)
				{
					btnEfectivo.Click -= value2;
				}
				this._btnEfectivo = value;
				btnEfectivo = this._btnEfectivo;
				if (btnEfectivo != null)
				{
					btnEfectivo.Click += value2;
				}
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00061E13 File Offset: 0x00060013
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x00061E1D File Offset: 0x0006001D
		internal virtual Label Label68 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060007D6 RID: 2006 RVA: 0x00061E28 File Offset: 0x00060028
		private void frmEliminarProducto_Load(object sender, EventArgs e)
		{
			this.Panelvercortes.Visible = false;
			this.btnCorteZ.Enabled = false;
			this.PanelCheqdet.Visible = false;
			this.DoubleBufferedASD(this.dgvNotas, true);
			this.DoubleBufferedASD(this.DataGridCheqdet, true);
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
						this.PanelDetalleTicket.Visible = false;
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
						this.PanelDetalleTicket.Visible = false;
						Interaction.MsgBox("Necesitas asignar las formas de pago dentro de Parametros,para poder utilizar esta funcion!", MsgBoxStyle.OkOnly, null);
					}
				}
			}
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
			this.PanelBuscarProducto.Visible = false;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0006232C File Offset: 0x0006052C
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

		// Token: 0x060007D8 RID: 2008 RVA: 0x000623C8 File Offset: 0x000605C8
		private void iniciaGridFolio()
		{
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
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
			dataGridViewButtonColumn.Width = 60;
			dataGridViewButtonColumn.Name = "Ver";
			this.dgvNotas.Columns.Add(dataGridViewButtonColumn);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000629D8 File Offset: 0x00060BD8
		private void iniciaGridCheqdet()
		{
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			this.DataGridCheqdet.Rows.Clear();
			this.DataGridCheqdet.ColumnCount = 9;
			this.DataGridCheqdet.Columns[0].Name = "Foliodet";
			this.DataGridCheqdet.Columns[0].Visible = true;
			this.DataGridCheqdet.Columns[0].ReadOnly = true;
			this.DataGridCheqdet.Columns[0].Width = 60;
			this.DataGridCheqdet.Columns[1].Name = "Mov.";
			this.DataGridCheqdet.Columns[1].Width = 60;
			this.DataGridCheqdet.Columns[1].ReadOnly = true;
			this.DataGridCheqdet.Columns[2].Name = "Cantidad";
			this.DataGridCheqdet.Columns[2].Width = 60;
			this.DataGridCheqdet.Columns[2].ReadOnly = true;
			this.DataGridCheqdet.Columns[3].Name = "idProducto";
			this.DataGridCheqdet.Columns[3].Width = 60;
			this.DataGridCheqdet.Columns[3].ReadOnly = true;
			this.DataGridCheqdet.Columns[4].Name = "Precio";
			this.DataGridCheqdet.Columns[4].Width = 60;
			this.DataGridCheqdet.Columns[4].ReadOnly = true;
			this.DataGridCheqdet.Columns[5].Name = "Impuesto";
			this.DataGridCheqdet.Columns[5].Width = 60;
			this.DataGridCheqdet.Columns[5].ReadOnly = true;
			this.DataGridCheqdet.Columns[6].Name = "Precio sin iva ";
			this.DataGridCheqdet.Columns[6].Width = 60;
			this.DataGridCheqdet.Columns[6].ReadOnly = true;
			this.DataGridCheqdet.Columns[7].Name = "Descuento";
			this.DataGridCheqdet.Columns[7].Width = 60;
			this.DataGridCheqdet.Columns[7].ReadOnly = true;
			this.DataGridCheqdet.Columns[8].Name = "ImporteDescuento";
			this.DataGridCheqdet.Columns[8].Width = 60;
			this.DataGridCheqdet.Columns[8].ReadOnly = true;
			dataGridViewCheckBoxColumn.Width = 60;
			dataGridViewCheckBoxColumn.Name = "Eliminar";
			this.DataGridCheqdet.Columns.Add(dataGridViewCheckBoxColumn);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00062D00 File Offset: 0x00060F00
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
			this.cmbxSerie.Items.Add("Todas");
			sqlDataReader = (SqlDataReader)sqlQuery.execReader("select distinct(serie) from folios");
			while (sqlDataReader.Read())
			{
				this.cmbxSerie.Items.Add(sqlDataReader[0].ToString());
			}
			this.CmbMovtos.Text = "2";
			this.cmbxTipo.Items.Add("Eliminar Productos");
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

		// Token: 0x060007DB RID: 2011 RVA: 0x00062E8C File Offset: 0x0006108C
		private void btnVistaPrevia_Click(object sender, EventArgs e)
		{
			this.progBar.Value = 0;
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery = new SqlQuery();
			string query_conn = "DELETE FROM FF";
			sqlQuery_Conn.execQuery_conn(query_conn);
			query_conn = "DELETE FROM F";
			sqlQuery_Conn.execQuery_conn(query_conn);
			bool flag = Operators.ConditionalCompareObjectEqual(this.validar(), false, false);
			if (!flag)
			{
				this.btnCorteZ.Enabled = true;
				string text = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
				string text2 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
				query_conn = string.Concat(new string[]
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
					this.progBar.Value = 20;
					frmWaitMsg frmWaitMsg = new frmWaitMsg();
					frmWaitMsg.Show();
					Application.DoEvents();
					this.habilitaControles(false);
					this.refrescaDatos();
					this.habilitaControles(true);
					this.dgvNotas.Enabled = true;
					this.Button1.PerformClick();
					frmWaitMsg.Hide();
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
							frmWaitMsg frmWaitMsg2 = new frmWaitMsg();
							frmWaitMsg2.Show();
							Application.DoEvents();
							this.progBar.Value = 20;
							this.habilitaControles(false);
							this.refrescaDatos();
							this.habilitaControles(true);
							this.dgvNotas.Enabled = true;
							this.Button1.PerformClick();
							frmWaitMsg2.Hide();
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

		// Token: 0x060007DC RID: 2012 RVA: 0x00063470 File Offset: 0x00061670
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x000634A4 File Offset: 0x000616A4
		public void MostrarCheqdetdelticket()
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = "Delete from F";
			sqlQuery_Conn.execQuery_conn(text);
			text = "Delete from FF";
			sqlQuery_Conn.execQuery_conn(text);
			int num = 400;
			int num2 = 0;
			this.progBar.Value = 30;
			text = "SELECT an from H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool flag = sqlDataReader.Read();
			if (flag)
			{
				this.Descomponercuentas = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
			}
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					string text2 = Conversions.ToString(dataGridViewRow.Cells["id_nota"].Value);
					bool flag2 = Operators.CompareString(this.Descomponercuentas, "1", false) == 0;
					double num21;
					if (flag2)
					{
						bool flag3 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(dataGridViewRow.Cells["Prod. Eliminados"].Value, 1, false)));
						bool flag4;
						checked
						{
							if (flag3)
							{
								text = "Select Foliodet from Cheqdet where foliodet ='" + text2 + "' and cantidad > '1'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
								bool hasRows = sqlDataReader.HasRows;
								if (hasRows)
								{
									text = string.Concat(new string[]
									{
										"Insert Into ",
										Tools.BaseDatos_Modulo,
										".dbo.FF ( a,\r\n                                b,\r\n                                c,\r\n                                d,\r\n                                e,\r\n                                f,\r\n                                g,\r\n                                h,\r\n                                i,\r\n                                j,\r\n                                k,\r\n                                l,\r\n                                m,\r\n                                n,\r\n                                o,\r\n                                p,\r\n                                q,\r\n                                r,\r\n                                s,\r\n                                t,\r\n                                u,\r\n                                w,\r\n                                x,\r\n                                y,\r\n                                z,\r\n                                aa,\r\n                                bb,\r\n                                cc,\r\n                                dd,\r\n                                ee,\r\n                                ff,\r\n                                gg,\r\n                                hh,\r\n                                ii,\r\n                                jj,\r\n                                kk,\r\n                                ll,\r\n                                mm,\r\n                                nn,\r\n                                oo,\r\n                                pp,\r\n                                qq,\r\n                                rr,\r\n                                ss,\r\n                                tt,\r\n                                uu,\r\n                                ww,\r\n                                xx,\r\n                                yy,\r\n                                zz)\r\n\r\n\r\n\r\n                select foliodet , movimiento , ISNULL(comanda,'') ,cantidad, idproducto , descuento, precio  ,  impuesto1 , impuesto2 , impuesto3 , preciosinimpuestos , ISNULL(tiempo,'') , hora ,\r\n                modificador , ISNULL(mitad,0) ,ISNULL(comentario,0) , idestacion , ISNULL(usuariodescuento,'') , ISNULL(comentariodescuento,'') , ISNULL(idtipodescuento,'') , Isnull(horaproduccion,'') as horaproduccion , ISNULL(idproductocompuesto,'') , \r\n                productocompuestoprincipal , ISNULL(preciocatalogo,0) , marcar , idmeseroproducto , ISNULL(prioridadproduccion,'') as prioridadproduccion , estatuspatin , ISNULL(idcortesia,'') , ISNULL(numerotarjeta,'') ,\r\n                estadomonitor , ISNULL(llavemovto,'') as llavemovto , ISNULL(horameserofinalizado,'')  as horameserofinalizado , ISNULL(meserofinalizado,'') as meserofinalizado , sistema_envio ,\r\n                ISNULL(idturno_cierre,'') , ISNULL(procesado,'0') , promovolumen , iddispositivo , productsyncidsr , subtotalsrx , totalsrx , idmovtobillar, ISNULL(idlistaprecio,'') as idlistaprecio , \r\n                ISNULL(tipocambio,'') as tipocambio , impuestoimporte3 , estrateca_DiscountCode , estrateca_DiscountID , estrateca_DiscountAmount , ISNULL(saledetailid,0) as saledetailid\r\n                from cheqdet where foliodet = '",
										text2,
										"'"
									});
									sqlQuery.execQuery(text);
								}
								sqlDataReader.Close();
								text = "select foliodet , movimiento , ISNULL(comanda,'') ,cantidad, idproducto , precio, descuento,  impuesto1 , impuesto2 , impuesto3 , preciosinimpuestos , ISNULL(tiempo,'') , hora ,\r\n                modificador , ISNULL(mitad,0) ,ISNULL(comentario,0) , idestacion , ISNULL(usuariodescuento,'') , ISNULL(comentariodescuento,'') , ISNULL(idtipodescuento,'') , Isnull(horaproduccion,'') as horaproduccion , ISNULL(idproductocompuesto,'') , \r\n                productocompuestoprincipal , ISNULL(preciocatalogo,0) , marcar , idmeseroproducto , ISNULL(prioridadproduccion,'') as prioridadproduccion , estatuspatin , ISNULL(idcortesia,'') , ISNULL(numerotarjeta,'') ,\r\n                estadomonitor , ISNULL(llavemovto,'') as llavemovto , ISNULL(horameserofinalizado,'')  as horameserofinalizado , ISNULL(meserofinalizado,'') as meserofinalizado , sistema_envio ,\r\n                ISNULL(idturno_cierre,'') , ISNULL(procesado,'0') , promovolumen , iddispositivo , productsyncidsr , subtotalsrx , totalsrx , idmovtobillar, ISNULL(idlistaprecio,'') as idlistaprecio , \r\n                ISNULL(tipocambio,'') as tipocambio , impuestoimporte3 , estrateca_DiscountCode , estrateca_DiscountID , estrateca_DiscountAmount , ISNULL(saledetailid,0) as saledetailid\r\n                from cheqdet where foliodet = '" + text2 + "' and cantidad > 1 ";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
								bool hasRows2 = sqlDataReader.HasRows;
								if (hasRows2)
								{
									while (sqlDataReader.Read())
									{
										int num3 = Conversions.ToInteger(sqlDataReader[3]);
										string text3 = Conversions.ToString(sqlDataReader[2]);
										string text4 = Conversions.ToString(sqlDataReader[4]);
										double num4 = Conversions.ToDouble(sqlDataReader[5]);
										double num5 = Conversions.ToDouble(sqlDataReader[6]);
										double num6 = Conversions.ToDouble(sqlDataReader[7]);
										double num7 = Conversions.ToDouble(sqlDataReader[8]);
										double num8 = Conversions.ToDouble(sqlDataReader[9]);
										double num9 = Conversions.ToDouble(sqlDataReader[10]);
										string text5 = Conversions.ToString(sqlDataReader[11]);
										DateTime dateTime = Conversions.ToDate(sqlDataReader[12]);
										string text6 = Conversions.ToString(sqlDataReader[13]);
										string text7 = Conversions.ToString(sqlDataReader[14]);
										string text8 = Conversions.ToString(sqlDataReader[15]);
										string text9 = Conversions.ToString(sqlDataReader[16]);
										string text10 = Conversions.ToString(sqlDataReader[17]);
										string text11 = Conversions.ToString(sqlDataReader[18]);
										string text12 = Conversions.ToString(sqlDataReader[19]);
										DateTime dateTime2 = Conversions.ToDate(sqlDataReader[20]);
										string text13 = Conversions.ToString(sqlDataReader[21]);
										string text14 = Conversions.ToString(sqlDataReader[22]);
										double num10 = Conversions.ToDouble(sqlDataReader[23]);
										string text15 = Conversions.ToString(sqlDataReader[24]);
										string text16 = Conversions.ToString(sqlDataReader[25]);
										string text17 = Conversions.ToString(sqlDataReader[26]);
										string text18 = Conversions.ToString(sqlDataReader[27]);
										string text19 = Conversions.ToString(sqlDataReader[28]);
										string text20 = Conversions.ToString(sqlDataReader[29]);
										string text21 = Conversions.ToString(sqlDataReader[30]);
										string text22 = Conversions.ToString(sqlDataReader[31]);
										DateTime dateTime3 = Conversions.ToDate(sqlDataReader[32]);
										string text23 = Conversions.ToString(sqlDataReader[33]);
										string text24 = Conversions.ToString(sqlDataReader[34]);
										string text25 = Conversions.ToString(sqlDataReader[35]);
										string text26 = Conversions.ToString(sqlDataReader[36]);
										string text27 = Conversions.ToString(sqlDataReader[37]);
										string text28 = Conversions.ToString(sqlDataReader[38]);
										string text29 = Conversions.ToString(sqlDataReader[39]);
										string text30 = Conversions.ToString(sqlDataReader[40]);
										string text31 = Conversions.ToString(sqlDataReader[41]);
										string text32 = Conversions.ToString(sqlDataReader[42]);
										string text33 = Conversions.ToString(sqlDataReader[43]);
										string text34 = Conversions.ToString(sqlDataReader[44]);
										double num11 = Conversions.ToDouble(sqlDataReader[45]);
										string text35 = Conversions.ToString(sqlDataReader[46]);
										string text36 = Conversions.ToString(sqlDataReader[47]);
										string text37 = Conversions.ToString(sqlDataReader[48]);
										string text38 = Conversions.ToString(sqlDataReader[49]);
										int num12 = num3;
										for (int i = 1; i <= num12; i++)
										{
											text = string.Concat(new string[]
											{
												"insert into cheqdet (\r\n                                Foliodet,\r\n                                movimiento,\r\n                                comanda,\r\n                                cantidad,\r\n                                idproducto,\r\n                                descuento,\r\n                                precio,\r\n                                impuesto1,\r\n                                impuesto2,\r\n                                impuesto3,\r\n                                preciosinimpuestos,\r\n                                tiempo,\r\n                                hora,\r\n                                modificador,\r\n                                mitad,\r\n                                comentario,\r\n                                idestacion,\r\n                                usuariodescuento,\r\n                                comentariodescuento,\r\n                                idtipodescuento,\r\n                                horaproduccion,\r\n                                idproductocompuesto,\r\n                                productocompuestoprincipal,\r\n                                preciocatalogo,\r\n                                marcar,\r\n                                idmeseroproducto,\r\n                                prioridadproduccion,\r\n                                estatuspatin,\r\n                                idcortesia,\r\n                                numerotarjeta,\r\n                                estadomonitor,\r\n                                llavemovto,\r\n                                horameserofinalizado,\r\n                                meserofinalizado,\r\n                                sistema_envio,\r\n                                idturno_cierre,\r\n                                procesado,\r\n                                promovolumen,\r\n                                iddispositivo,\r\n                                productsyncidsr,\r\n                                subtotalsrx,\r\n                                totalsrx,\r\n                                idmovtobillar,\r\n                                idlistaprecio,\r\n                                tipocambio,\r\n                                impuestoimporte3,\r\n                                estrateca_DiscountCode,\r\n                                estrateca_DiscountID,\r\n                                estrateca_DiscountAmount,\r\n                                saledetailid\r\n\r\n                               )\r\n\r\n\r\n                                Values(\r\n                                '",
												text2.ToString(),
												"',\r\n                                '",
												num.ToString(),
												"',\r\n                                '',\r\n                                '1',\r\n                                '",
												text4.ToString(),
												"',\r\n                                '",
												num5.ToString(),
												"',\r\n                                '",
												num4.ToString("N2"),
												"',\r\n                                '",
												num6.ToString("N2"),
												"',\r\n                                '",
												num7.ToString("N2"),
												"',\r\n                                '",
												num8.ToString("N2"),
												"',\r\n                                '",
												num9.ToString("N2"),
												"',\r\n                                '",
												text5,
												"',\r\n                                '",
												dateTime.ToString(Tools.strFormatoFechaLargo),
												"',\r\n                                '",
												text6.ToString(),
												"',\r\n                                '",
												text7.ToString(),
												"',\r\n                                '",
												text8.ToString(),
												"',\r\n                                '",
												text9.ToString(),
												"',\r\n                                '",
												text10,
												"',\r\n                                '",
												text11.ToString(),
												"',\r\n                                '",
												text12.ToString(),
												"',\r\n                                '",
												dateTime2.ToString(Tools.strFormatoFechaLargo),
												"',\r\n                                '",
												text13.ToString(),
												"',\r\n                                '",
												text14.ToString(),
												"',\r\n                                '",
												num10.ToString("N2"),
												"',\r\n                                '",
												text15.ToString(),
												"',\r\n                                '",
												text16.ToString(),
												"',\r\n                                '",
												text17.ToString(),
												"',\r\n                                ",
												text18.ToString(),
												",\r\n                                '",
												text19.ToString(),
												"',\r\n                                '",
												text20.ToString(),
												"',\r\n                                '",
												text21.ToString(),
												"',\r\n                                '",
												text22.ToString(),
												"',\r\n                                '",
												dateTime3.ToString(Tools.strFormatoFechaLargo),
												"',\r\n                                '",
												text23.ToString(),
												"',\r\n                                '",
												text24.ToString(),
												"',\r\n                                '",
												text25.ToString(),
												"',\r\n                                '",
												text26.ToString(),
												"',\r\n                                '",
												text27.ToString(),
												"',\r\n                                '",
												text28.ToString(),
												"',\r\n                                '",
												text29.ToString(),
												"',\r\n                                '",
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
												num11.ToString("N2"),
												"',                            \r\n                                '",
												text35.ToString(),
												"',\r\n                                '",
												text36.ToString(),
												"',\r\n                                '",
												text37,
												"',\r\n                                '",
												text38.ToString(),
												"')"
											});
											sqlQuery.execQuery(text);
											num++;
										}
										text = string.Concat(new string[]
										{
											"DELETE FROM CHEQDET WHERE Cantidad = '",
											num3.ToString(),
											"' and Foliodet = '",
											text2,
											"'"
										});
										sqlQuery.execQuery(text);
										num = 400;
									}
									text = "SELECT foliodet , movimiento , hora , idproducto , precio from cheqdet WITH (NOLOCK) where foliodet ='" + text2 + "' order by movimiento asc";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
									bool hasRows3 = sqlDataReader.HasRows;
									if (hasRows3)
									{
										while (sqlDataReader.Read())
										{
											string text39 = Conversions.ToString(sqlDataReader[1]);
											DateTime dateTime4 = Conversions.ToDate(sqlDataReader[2]);
											num2++;
											double num13 = Conversions.ToDouble(sqlDataReader[4]);
											string text40 = Conversions.ToString(sqlDataReader[3]);
											text = string.Concat(new string[]
											{
												"Set transaction isolation level read uncommitted\r\n\r\n                                                Update cheqdet set movimiento ='",
												num2.ToString(),
												"' where foliodet = '",
												text2,
												"' and movimiento= '",
												text39.ToString(),
												"' and idproducto='",
												text40.ToString(),
												"' and hora = '",
												dateTime4.ToString(Tools.strFormatoFechaLargo),
												"' and Precio='",
												num13.ToString("N2"),
												"'"
											});
											sqlQuery.execQuery(text);
										}
										num2 = 0;
									}
								}
								sqlDataReader.Close();
							}
							flag4 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false);
						}
						if (flag4)
						{
							text = string.Concat(new string[]
							{
								"SELECT Top ",
								this.CmbMovtos.Text,
								"\r\n                            foliodet,\r\n                            movimiento,\r\n                            cantidad,\r\n                            idproducto,\r\n                            precio,\r\n\t                        impuesto1,\r\n\t                        preciosinimpuestos,\r\n                            Descuento                  \r\n                            FROM cheqdet\r\n                            WHERE foliodet=",
								text2,
								" and precio  > 0 and cantidad = 1\r\n                ORDER BY precio asc "
							});
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
							this.iniciaGridCheqdet();
							bool hasRows4 = sqlDataReader.HasRows;
							if (hasRows4)
							{
								while (sqlDataReader.Read())
								{
									string text41 = Conversions.ToString(sqlDataReader[0]);
									string text42 = Conversions.ToString(sqlDataReader[1]);
									string text43 = Conversions.ToString(sqlDataReader[2]);
									string text44 = Conversions.ToString(sqlDataReader[3]);
									double num14 = Conversions.ToDouble(sqlDataReader[4]);
									double num15 = Conversions.ToDouble(sqlDataReader[5]);
									double num16 = Conversions.ToDouble(sqlDataReader[6]);
									double num17 = Conversions.ToDouble(sqlDataReader[7]);
									double num18 = Conversions.ToDouble(text43) * num16 - Conversions.ToDouble(text43) * num16 / 100.0 * num17;
									double num19 = (Conversions.ToDouble(text43) * num16 - Conversions.ToDouble(text43) * num16 / 100.0 * num17) / 100.0 * num15;
									double num20 = num18 + num19;
									num21 += num20;
									this.lblsumartotaldescontar.Text = Conversions.ToString(num20);
									text = string.Concat(new string[]
									{
										"Insert into F (a,b,c,d,e,f,g,h,i,j) \r\n                            values ('",
										text41.ToString(),
										"','",
										text42.ToString(),
										"','",
										text43.ToString(),
										"','",
										text44.ToString(),
										"' , '",
										num14.ToString(),
										"','",
										num15.ToString("N2"),
										"','",
										num16.ToString(),
										"','",
										num17.ToString("N2"),
										"','",
										num20.ToString("N2"),
										"','0')"
									});
									sqlQuery_Conn.execQuery_conn(text);
									this.lblcontarfilas.Text = Conversions.ToString(this.DataGridCheqdet.Rows.Count);
								}
							}
							sqlDataReader.Close();
						}
					}
					bool flag5 = Operators.CompareString(this.Descomponercuentas, "0", false) == 0;
					if (flag5)
					{
						text = string.Concat(new string[]
						{
							"SELECT Top ",
							this.CmbMovtos.Text,
							"\r\n                            foliodet,\r\n                            movimiento,\r\n                            cantidad,\r\n                            idproducto,\r\n                            precio,\r\n\t                        impuesto1,\r\n\t                        preciosinimpuestos,\r\n                            Descuento                  \r\n                            FROM cheqdet\r\n                            WHERE foliodet=",
							text2,
							" and precio  > 0 \r\n                ORDER BY precio asc "
						});
						sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
						bool hasRows5 = sqlDataReader.HasRows;
						if (hasRows5)
						{
							while (sqlDataReader.Read())
							{
								string text41 = Conversions.ToString(sqlDataReader[0]);
								string text42 = Conversions.ToString(sqlDataReader[1]);
								string text43 = Conversions.ToString(sqlDataReader[2]);
								string text44 = Conversions.ToString(sqlDataReader[3]);
								double num14 = Conversions.ToDouble(sqlDataReader[4]);
								double num15 = Conversions.ToDouble(sqlDataReader[5]);
								double num16 = Conversions.ToDouble(sqlDataReader[6]);
								double num17 = Conversions.ToDouble(sqlDataReader[7]);
								bool flag6 = Conversions.ToDouble(text43) > 1.0;
								bool flag8;
								checked
								{
									if (flag6)
									{
										text = string.Concat(new string[]
										{
											"Select Foliodet from Cheqdet where foliodet ='",
											text2,
											"' and movimiento = '",
											text42,
											"'"
										});
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
										bool hasRows6 = sqlDataReader.HasRows;
										if (hasRows6)
										{
											text = string.Concat(new string[]
											{
												"Insert Into ",
												Tools.BaseDatos_Modulo,
												".dbo.FF ( a,\r\n                                b,\r\n                                c,\r\n                                d,\r\n                                e,\r\n                                f,\r\n                                g,\r\n                                h,\r\n                                i,\r\n                                j,\r\n                                k,\r\n                                l,\r\n                                m,\r\n                                n,\r\n                                o,\r\n                                p,\r\n                                q,\r\n                                r,\r\n                                s,\r\n                                t,\r\n                                u,\r\n                                w,\r\n                                x,\r\n                                y,\r\n                                z,\r\n                                aa,\r\n                                bb,\r\n                                cc,\r\n                                dd,\r\n                                ee,\r\n                                ff,\r\n                                gg,\r\n                                hh,\r\n                                ii,\r\n                                jj,\r\n                                kk,\r\n                                ll,\r\n                                mm,\r\n                                nn,\r\n                                oo,\r\n                                pp,\r\n                                qq,\r\n                                rr,\r\n                                ss,\r\n                                tt,\r\n                                uu,\r\n                                ww,\r\n                                xx,\r\n                                yy,\r\n                                zz)\r\n\r\n\r\n\r\n                select foliodet , movimiento , ISNULL(comanda,'') ,cantidad, idproducto , descuento, precio  ,  impuesto1 , impuesto2 , impuesto3 , preciosinimpuestos , ISNULL(tiempo,'') , hora ,\r\n                modificador , ISNULL(mitad,0) ,ISNULL(comentario,0) , idestacion , ISNULL(usuariodescuento,'') , ISNULL(comentariodescuento,'') , ISNULL(idtipodescuento,'') , Isnull(horaproduccion,'') as horaproduccion , ISNULL(idproductocompuesto,'') , \r\n                productocompuestoprincipal , ISNULL(preciocatalogo,0) , marcar , idmeseroproducto , ISNULL(prioridadproduccion,'') as prioridadproduccion , estatuspatin , ISNULL(idcortesia,'') , ISNULL(numerotarjeta,'') ,\r\n                estadomonitor , ISNULL(llavemovto,'') as llavemovto , ISNULL(horameserofinalizado,'')  as horameserofinalizado , ISNULL(meserofinalizado,'') as meserofinalizado , sistema_envio ,\r\n                ISNULL(idturno_cierre,'') , ISNULL(procesado,'0') , promovolumen , iddispositivo , productsyncidsr , subtotalsrx , totalsrx , idmovtobillar, ISNULL(idlistaprecio,'') as idlistaprecio , \r\n                ISNULL(tipocambio,'') as tipocambio , impuestoimporte3 , estrateca_DiscountCode , estrateca_DiscountID , estrateca_DiscountAmount , ISNULL(saledetailid,0) as saledetailid\r\n                from cheqdet where foliodet = '",
												text2,
												"'"
											});
											sqlQuery.execQuery(text);
										}
										sqlDataReader.Close();
										text = string.Concat(new string[]
										{
											"select foliodet , movimiento , ISNULL(comanda,'') ,cantidad, idproducto , precio, descuento,  impuesto1 , impuesto2 , impuesto3 , preciosinimpuestos , ISNULL(tiempo,'') , hora ,\r\n                modificador , ISNULL(mitad,0) ,ISNULL(comentario,0) , idestacion , ISNULL(usuariodescuento,'') , ISNULL(comentariodescuento,'') , ISNULL(idtipodescuento,'') , Isnull(horaproduccion,'') as horaproduccion , ISNULL(idproductocompuesto,'') , \r\n                productocompuestoprincipal , ISNULL(preciocatalogo,0) , marcar , idmeseroproducto , ISNULL(prioridadproduccion,'') as prioridadproduccion , estatuspatin , ISNULL(idcortesia,'') , ISNULL(numerotarjeta,'') ,\r\n                estadomonitor , ISNULL(llavemovto,'') as llavemovto , ISNULL(horameserofinalizado,'')  as horameserofinalizado , ISNULL(meserofinalizado,'') as meserofinalizado , sistema_envio ,\r\n                ISNULL(idturno_cierre,'') , ISNULL(procesado,'0') , promovolumen , iddispositivo , productsyncidsr , subtotalsrx , totalsrx , idmovtobillar, ISNULL(idlistaprecio,'') as idlistaprecio , \r\n                ISNULL(tipocambio,'') as tipocambio , impuestoimporte3 , estrateca_DiscountCode , estrateca_DiscountID , estrateca_DiscountAmount , ISNULL(saledetailid,0) as saledetailid\r\n                from cheqdet where foliodet = '",
											text2,
											"' and movimiento ='",
											text42,
											"'"
										});
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
										bool hasRows7 = sqlDataReader.HasRows;
										if (hasRows7)
										{
											while (sqlDataReader.Read())
											{
												int num3 = Conversions.ToInteger(sqlDataReader[3]);
												string text3 = Conversions.ToString(sqlDataReader[2]);
												string text4 = Conversions.ToString(sqlDataReader[4]);
												double num4 = Conversions.ToDouble(sqlDataReader[5]);
												double num5 = Conversions.ToDouble(sqlDataReader[6]);
												double num6 = Conversions.ToDouble(sqlDataReader[7]);
												double num7 = Conversions.ToDouble(sqlDataReader[8]);
												double num8 = Conversions.ToDouble(sqlDataReader[9]);
												double num9 = Conversions.ToDouble(sqlDataReader[10]);
												string text5 = Conversions.ToString(sqlDataReader[11]);
												DateTime dateTime = Conversions.ToDate(sqlDataReader[12]);
												string text6 = Conversions.ToString(sqlDataReader[13]);
												string text7 = Conversions.ToString(sqlDataReader[14]);
												string text8 = Conversions.ToString(sqlDataReader[15]);
												string text9 = Conversions.ToString(sqlDataReader[16]);
												string text10 = Conversions.ToString(sqlDataReader[17]);
												string text11 = Conversions.ToString(sqlDataReader[18]);
												string text12 = Conversions.ToString(sqlDataReader[19]);
												DateTime dateTime2 = Conversions.ToDate(sqlDataReader[20]);
												string text13 = Conversions.ToString(sqlDataReader[21]);
												string text14 = Conversions.ToString(sqlDataReader[22]);
												double num10 = Conversions.ToDouble(sqlDataReader[23]);
												string text15 = Conversions.ToString(sqlDataReader[24]);
												bool flag7 = sqlDataReader[25] == DBNull.Value;
												string text16;
												if (flag7)
												{
													text16 = "";
												}
												else
												{
													text16 = Conversions.ToString(sqlDataReader[25]);
												}
												string text17 = Conversions.ToString(sqlDataReader[26]);
												string text18 = Conversions.ToString(sqlDataReader[27]);
												string text19 = Conversions.ToString(sqlDataReader[28]);
												string text20 = Conversions.ToString(sqlDataReader[29]);
												string text21 = Conversions.ToString(sqlDataReader[30]);
												string text22 = Conversions.ToString(sqlDataReader[31]);
												DateTime dateTime3 = Conversions.ToDate(sqlDataReader[32]);
												string text23 = Conversions.ToString(sqlDataReader[33]);
												string text24 = Conversions.ToString(sqlDataReader[34]);
												string text25 = Conversions.ToString(sqlDataReader[35]);
												string text26 = Conversions.ToString(sqlDataReader[36]);
												string text27 = Conversions.ToString(sqlDataReader[37]);
												string text28 = Conversions.ToString(sqlDataReader[38]);
												string text29 = Conversions.ToString(sqlDataReader[39]);
												string text30 = Conversions.ToString(sqlDataReader[40]);
												string text31 = Conversions.ToString(sqlDataReader[41]);
												string text32 = Conversions.ToString(sqlDataReader[42]);
												string text33 = Conversions.ToString(sqlDataReader[43]);
												string text34 = Conversions.ToString(sqlDataReader[44]);
												double num11 = Conversions.ToDouble(sqlDataReader[45]);
												string text35 = Conversions.ToString(sqlDataReader[46]);
												string text36 = Conversions.ToString(sqlDataReader[47]);
												string text37 = Conversions.ToString(sqlDataReader[48]);
												string text38 = Conversions.ToString(sqlDataReader[49]);
												int num22 = num3;
												for (int i = 1; i <= num22; i++)
												{
													text = string.Concat(new string[]
													{
														"insert into cheqdet (\r\n                                Foliodet,\r\n                                movimiento,\r\n                                comanda,\r\n                                cantidad,\r\n                                idproducto,\r\n                                descuento,\r\n                                precio,\r\n                                impuesto1,\r\n                                impuesto2,\r\n                                impuesto3,\r\n                                preciosinimpuestos,\r\n                                tiempo,\r\n                                hora,\r\n                                modificador,\r\n                                mitad,\r\n                                comentario,\r\n                                idestacion,\r\n                                usuariodescuento,\r\n                                comentariodescuento,\r\n                                idtipodescuento,\r\n                                horaproduccion,\r\n                                idproductocompuesto,\r\n                                productocompuestoprincipal,\r\n                                preciocatalogo,\r\n                                marcar,\r\n                                idmeseroproducto,\r\n                                prioridadproduccion,\r\n                                estatuspatin,\r\n                                idcortesia,\r\n                                numerotarjeta,\r\n                                estadomonitor,\r\n                                llavemovto,\r\n                                horameserofinalizado,\r\n                                meserofinalizado,\r\n                                sistema_envio,\r\n                                idturno_cierre,\r\n                                procesado,\r\n                                promovolumen,\r\n                                iddispositivo,\r\n                                productsyncidsr,\r\n                                subtotalsrx,\r\n                                totalsrx,\r\n                                idmovtobillar,\r\n                                idlistaprecio,\r\n                                tipocambio,\r\n                                impuestoimporte3,\r\n                                estrateca_DiscountCode,\r\n                                estrateca_DiscountID,\r\n                                estrateca_DiscountAmount,\r\n                                saledetailid\r\n\r\n                               )\r\n\r\n\r\n                                Values(\r\n                                '",
														text2.ToString(),
														"',\r\n                                '",
														num.ToString(),
														"',\r\n                                '',\r\n                                '1',\r\n                                '",
														text4.ToString(),
														"',\r\n                                '",
														num5.ToString(),
														"',\r\n                                '",
														num4.ToString("N2"),
														"',\r\n                                '",
														num6.ToString("N2"),
														"',\r\n                                '",
														num7.ToString("N2"),
														"',\r\n                                '",
														num8.ToString("N2"),
														"',\r\n                                '",
														num9.ToString("N2"),
														"',\r\n                                '",
														text5,
														"',\r\n                                '",
														dateTime.ToString(Tools.strFormatoFechaLargo),
														"',\r\n                                '",
														text6.ToString(),
														"',\r\n                                '",
														text7.ToString(),
														"',\r\n                                '",
														text8.ToString(),
														"',\r\n                                '",
														text9.ToString(),
														"',\r\n                                '",
														text10,
														"',\r\n                                '",
														text11.ToString(),
														"',\r\n                                '",
														text12.ToString(),
														"',\r\n                                '",
														dateTime2.ToString(Tools.strFormatoFechaLargo),
														"',\r\n                                '",
														text13.ToString(),
														"',\r\n                                '",
														text14.ToString(),
														"',\r\n                                '",
														num10.ToString("N2"),
														"',\r\n                                '",
														text15.ToString(),
														"',\r\n                                '",
														text16.ToString(),
														"',\r\n                                '",
														text17.ToString(),
														"',\r\n                                ",
														text18.ToString(),
														",\r\n                                '",
														text19.ToString(),
														"',\r\n                                '",
														text20.ToString(),
														"',\r\n                                '",
														text21.ToString(),
														"',\r\n                                '",
														text22.ToString(),
														"',\r\n                                '",
														dateTime3.ToString(Tools.strFormatoFechaLargo),
														"',\r\n                                '",
														text23.ToString(),
														"',\r\n                                '",
														text24.ToString(),
														"',\r\n                                '",
														text25.ToString(),
														"',\r\n                                '",
														text26.ToString(),
														"',\r\n                                '",
														text27.ToString(),
														"',\r\n                                '",
														text28.ToString(),
														"',\r\n                                '",
														text29.ToString(),
														"',\r\n                                '",
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
														num11.ToString("N2"),
														"',                            \r\n                                '",
														text35.ToString(),
														"',\r\n                                '",
														text36.ToString(),
														"',\r\n                                '",
														text37,
														"',\r\n                                '",
														text38.ToString(),
														"')"
													});
													sqlQuery.execQuery(text);
													num++;
												}
												text = string.Concat(new string[]
												{
													"DELETE FROM CHEQDET WHERE Cantidad = '",
													num3.ToString(),
													"' and Foliodet = '",
													text2,
													"' and movimiento ='",
													text42,
													"'"
												});
												sqlQuery.execQuery(text);
												num = 400;
											}
											text = "SELECT foliodet , movimiento , hora , idproducto , precio from cheqdet WITH (NOLOCK) where foliodet ='" + text2 + "' order by movimiento asc";
											sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
											bool hasRows8 = sqlDataReader.HasRows;
											if (hasRows8)
											{
												while (sqlDataReader.Read())
												{
													string text39 = Conversions.ToString(sqlDataReader[1]);
													DateTime dateTime4 = Conversions.ToDate(sqlDataReader[2]);
													num2++;
													double num13 = Conversions.ToDouble(sqlDataReader[4]);
													string text40 = Conversions.ToString(sqlDataReader[3]);
													text = string.Concat(new string[]
													{
														"Set transaction isolation level read uncommitted\r\n\r\n                                                Update cheqdet set movimiento ='",
														num2.ToString(),
														"' where foliodet = '",
														text2,
														"' and movimiento= '",
														text39.ToString(),
														"' and idproducto='",
														text40.ToString(),
														"' and hora = '",
														dateTime4.ToString(Tools.strFormatoFechaLargo),
														"' and Precio='",
														num13.ToString("N2"),
														"'"
													});
													sqlQuery.execQuery(text);
												}
												num2 = 0;
											}
										}
									}
									flag8 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false);
								}
								if (flag8)
								{
									text = string.Concat(new string[]
									{
										"SELECT Top ",
										this.CmbMovtos.Text,
										"\r\n                            foliodet,\r\n                            movimiento,\r\n                            cantidad,\r\n                            idproducto,\r\n                            precio,\r\n\t                        impuesto1,\r\n\t                        preciosinimpuestos,\r\n                            Descuento                  \r\n                            FROM cheqdet\r\n                            WHERE foliodet=",
										text2,
										" and precio  > 0 and cantidad = 1\r\n                ORDER BY precio asc "
									});
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
									this.iniciaGridCheqdet();
									bool hasRows9 = sqlDataReader.HasRows;
									if (hasRows9)
									{
										while (sqlDataReader.Read())
										{
											text41 = Conversions.ToString(sqlDataReader[0]);
											text42 = Conversions.ToString(sqlDataReader[1]);
											text43 = Conversions.ToString(sqlDataReader[2]);
											text44 = Conversions.ToString(sqlDataReader[3]);
											num14 = Conversions.ToDouble(sqlDataReader[4]);
											num15 = Conversions.ToDouble(sqlDataReader[5]);
											num16 = Conversions.ToDouble(sqlDataReader[6]);
											num17 = Conversions.ToDouble(sqlDataReader[7]);
											double num23 = Conversions.ToDouble(text43) * num16 - Conversions.ToDouble(text43) * num16 / 100.0 * num17;
											double num24 = (Conversions.ToDouble(text43) * num16 - Conversions.ToDouble(text43) * num16 / 100.0 * num17) / 100.0 * num15;
											double num20 = num23 + num24;
											num21 += num20;
											this.lblsumartotaldescontar.Text = Conversions.ToString(num20);
											text = string.Concat(new string[]
											{
												"Insert into F (a,b,c,d,e,f,g,h,i,j) \r\n                            values ('",
												text41.ToString(),
												"','",
												text42.ToString(),
												"','",
												text43.ToString(),
												"','",
												text44.ToString(),
												"' , '",
												num14.ToString(),
												"','",
												num15.ToString("N2"),
												"','",
												num16.ToString(),
												"','",
												num17.ToString("N2"),
												"','",
												num20.ToString("N2"),
												"','0')"
											});
											sqlQuery_Conn.execQuery_conn(text);
											this.lblcontarfilas.Text = Conversions.ToString(this.DataGridCheqdet.Rows.Count);
										}
									}
								}
							}
						}
					}
					sqlDataReader.Close();
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
			text = "select  a ,b , c,  d , e , f , g , h , i  from F order by a";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool hasRows10 = sqlDataReader.HasRows;
			if (hasRows10)
			{
				this.iniciaGridCheqdet();
				while (sqlDataReader.Read())
				{
					string text45 = Conversions.ToString(sqlDataReader[0]);
					string text46 = Conversions.ToString(sqlDataReader[1]);
					string text47 = Conversions.ToString(sqlDataReader[2]);
					string text48 = Conversions.ToString(sqlDataReader[3]);
					double num25 = Conversions.ToDouble(sqlDataReader[4]);
					double num26 = Conversions.ToDouble(sqlDataReader[5]);
					double num27 = Conversions.ToDouble(sqlDataReader[6]);
					double num28 = Conversions.ToDouble(sqlDataReader[7]);
					double num29 = Conversions.ToDouble(sqlDataReader[8]);
					this.DataGridCheqdet.Rows.Add(new object[]
					{
						text45,
						text46,
						text47,
						text48,
						num25.ToString(),
						num26,
						num27,
						num28,
						num29
					});
					this.lblcontarfilas.Text = Conversions.ToString(this.DataGridCheqdet.Rows.Count);
				}
				sqlDataReader.Close();
			}
			try
			{
				foreach (object obj2 in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
					string text2 = Conversions.ToString(dataGridViewRow2.Cells["id_nota"].Value);
					bool flag9 = Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false);
					if (flag9)
					{
						dataGridViewRow2.Cells["Total con Prod. Eliminados"].Selected = true;
						double num30 = Conversions.ToDouble(dataGridViewRow2.Cells["Descto %"].Value);
						int i = this.dgvNotas.CurrentRow.Index;
						text = (("select case when sum(i) IS NULL then 0 else sum(i) end from F where a=" + text2) ?? "");
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
						bool hasRows11 = sqlDataReader.HasRows;
						if (hasRows11)
						{
							while (sqlDataReader.Read())
							{
								double num31 = Conversions.ToDouble(sqlDataReader[0]);
								double num32 = num31 - num31 / 100.0 * num30;
								this.dgvNotas[11, i].Value = num32.ToString("N2");
							}
						}
						else
						{
							bool flag10 = !sqlDataReader.HasRows;
							if (flag10)
							{
								this.dgvNotas[11, i].Value = 0;
							}
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
			this.progBar.Value = 40;
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000651C0 File Offset: 0x000633C0
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
			this.progBar.Value = 0;
			this.lblfechahoy.Text = now.ToString("yyyy-dd-MM hh:mm:ss");
			int num = 0;
			int num2 = 0;
			bool flag = true;
			string text3 = this.cmbxSerie.Text;
			string text4 = "SELECT ac FROM H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
			bool flag2 = sqlDataReader.Read();
			double num13;
			double num15;
			if (flag2)
			{
				string left = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				bool flag3 = Operators.CompareString(left, "0", false) == 0;
				bool flag9;
				double num12;
				double num14;
				if (flag3)
				{
					bool flag4 = Operators.CompareString(text3, "Todas", false) != 0;
					if (flag4)
					{
						text4 = string.Concat(new string[]
						{
							"SELECT folio,numcheque,fecha,cancelado,facturado, \r\n                    folionotadeconsumo,impresiones,descuento,total,efectivo,\r\n                    tarjeta,vales,otros,notadeconsumo,totalarticulos , (select c from  ",
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
									double num9 = Conversions.ToDouble(sqlDataReader[14]);
									this.idmesero = Conversions.ToString(sqlDataReader[16]);
									this.estacion = Conversions.ToString(sqlDataReader[17]);
									this.FechaTicket = Conversions.ToDate(sqlDataReader[2]);
									this.idTurnoTicket = Conversions.ToString(sqlDataReader[18]);
									double num10 = Conversions.ToDouble(sqlDataReader[19]);
									double num11 = Conversions.ToDouble(sqlDataReader[20]);
									string text12 = Conversions.ToString(sqlDataReader[21]);
									string text13 = Conversions.ToString(sqlDataReader[22]);
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
									bool flag24 = this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0;
									if (flag24)
									{
										flag9 = true;
									}
									bool flag25 = !this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0;
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
										text12,
										num3,
										text9,
										text13,
										text6,
										text7,
										text8,
										text10,
										num4,
										num9,
										"0",
										num5,
										num6,
										num7,
										num8,
										num10,
										num11,
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
								bool flag27 = sqlDataReader.Read();
								if (flag27)
								{
									num12 = Conversions.ToDouble(sqlDataReader[0]);
								}
							}
							num13 += num12;
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
							bool flag28 = sqlDataReader.Read();
							if (flag28)
							{
								num14 = Conversions.ToDouble(sqlDataReader[0]);
							}
							num15 += num14;
						}
						sqlDataReader.Close();
					}
					bool flag29 = Operators.CompareString(text3, "Todas", false) == 0;
					if (flag29)
					{
						text4 = string.Concat(new string[]
						{
							"SELECT folio,numcheque,fecha,cancelado,facturado, \r\n                    folionotadeconsumo,impresiones,descuento,total,efectivo,\r\n                    tarjeta,vales,otros,notadeconsumo,totalarticulos , (select c from  ",
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
						bool hasRows2 = sqlDataReader.HasRows;
						if (hasRows2)
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
									double num9 = Conversions.ToDouble(sqlDataReader[14]);
									this.idmesero = Conversions.ToString(sqlDataReader[16]);
									this.estacion = Conversions.ToString(sqlDataReader[17]);
									this.FechaTicket = Conversions.ToDate(sqlDataReader[2]);
									this.idTurnoTicket = Conversions.ToString(sqlDataReader[18]);
									double num10 = Conversions.ToDouble(sqlDataReader[19]);
									double num11 = Conversions.ToDouble(sqlDataReader[20]);
									string text14 = Conversions.ToString(sqlDataReader[21]);
									string text13 = Conversions.ToString(sqlDataReader[22]);
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
									bool flag48 = this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0;
									if (flag48)
									{
										flag9 = true;
									}
									bool flag49 = !this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0;
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
										text14,
										num3,
										text9,
										text13,
										text6,
										text7,
										text8,
										text10,
										num4,
										num9,
										"0",
										num5,
										num6,
										num7,
										num8,
										num10,
										num11,
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
								bool flag51 = sqlDataReader.Read();
								if (flag51)
								{
									num12 = Conversions.ToDouble(sqlDataReader[0]);
								}
							}
							num13 += num12;
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
							bool flag52 = sqlDataReader.Read();
							if (flag52)
							{
								num14 = Conversions.ToDouble(sqlDataReader[0]);
							}
							num15 += num14;
						}
						sqlDataReader.Close();
					}
				}
				bool flag53 = Operators.CompareString(left, "1", false) == 0;
				if (flag53)
				{
					bool flag54 = Operators.CompareString(text3, "Todas", false) != 0;
					if (flag54)
					{
						text4 = string.Concat(new string[]
						{
							"SELECT folio,numcheque,fecha,cancelado,facturado, \r\n                    folionotadeconsumo,impresiones,descuento,total,efectivo,\r\n                    tarjeta,vales,otros,notadeconsumo,totalarticulos , (select c from  ",
							Tools.BaseDatos_Modulo,
							".dbo.h) as PrecioNuevo, idmesero , estacion , idturno ,propinafoliomovtocaja,propina,seriefolio,Mesa  from cheques \r\n\t\t\t\t\t\r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
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
						bool hasRows3 = sqlDataReader.HasRows;
						if (hasRows3)
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
									double num9 = Conversions.ToDouble(sqlDataReader[14]);
									this.idmesero = Conversions.ToString(sqlDataReader[16]);
									this.estacion = Conversions.ToString(sqlDataReader[17]);
									this.FechaTicket = Conversions.ToDate(sqlDataReader[2]);
									this.idTurnoTicket = Conversions.ToString(sqlDataReader[18]);
									double num10 = Conversions.ToDouble(sqlDataReader[19]);
									double num11 = Conversions.ToDouble(sqlDataReader[20]);
									string text15 = Conversions.ToString(sqlDataReader[21]);
									string text13 = Conversions.ToString(sqlDataReader[22]);
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
									bool flag65 = !this.chkTarjCred.Checked & num6 > 0.0;
									if (flag65)
									{
										flag9 = false;
									}
									bool flag66 = !this.chkVales.Checked & num7 > 0.0;
									if (flag66)
									{
										flag9 = false;
									}
									bool flag67 = !this.chkFacturada.Checked & Operators.CompareString(text8, "Si", false) == 0;
									if (flag67)
									{
										flag9 = false;
									}
									bool flag68 = !this.chkOtros.Checked & num8 > 0.0;
									if (flag68)
									{
										flag9 = false;
									}
									bool flag69 = !this.chkEfectivo.Checked & num5 > 0.0;
									if (flag69)
									{
										flag9 = false;
									}
									bool flag70 = !this.chkCtasCortesia.Checked & Operators.CompareString(text10, "100", false) == 0;
									if (flag70)
									{
										flag9 = false;
									}
									bool flag71 = !this.chkNotaConsumo.Checked & Operators.CompareString(text9, "0", false) != 0;
									if (flag71)
									{
										flag9 = false;
									}
									bool flag72 = this.chkReimpresas.Checked & Conversions.ToDouble(value) > 1.0;
									if (flag72)
									{
										flag9 = false;
									}
									bool flag73 = this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0;
									if (flag73)
									{
										flag9 = true;
									}
									bool flag74 = !this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0;
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
										text15,
										num3,
										text9,
										text13,
										text6,
										text7,
										text8,
										text10,
										num4,
										num9,
										"0",
										num5,
										num6,
										num7,
										num8,
										num10,
										num11,
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
								bool flag76 = sqlDataReader.Read();
								if (flag76)
								{
									num12 = Conversions.ToDouble(sqlDataReader[0]);
								}
							}
							num13 += num12;
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
							bool flag77 = sqlDataReader.Read();
							if (flag77)
							{
								num14 = Conversions.ToDouble(sqlDataReader[0]);
							}
							num15 += num14;
						}
						sqlDataReader.Close();
					}
					bool flag78 = Operators.CompareString(text3, "Todas", false) == 0;
					if (flag78)
					{
						text4 = string.Concat(new string[]
						{
							"SELECT folio,numcheque,fecha,cancelado,facturado, \r\n                    folionotadeconsumo,impresiones,descuento,total,efectivo,\r\n                    tarjeta,vales,otros,notadeconsumo,totalarticulos , (select c from  ",
							Tools.BaseDatos_Modulo,
							".dbo.h) as PrecioNuevo, idmesero , estacion , idturno ,propinafoliomovtocaja,propina,seriefolio,Mesa  from cheques \r\n\t\t\t\t\t\r\n                    where idturno in (\r\n                    SELECT idturno FROM turnos \r\n                    WHERE turnos.apertura BETWEEN '",
							text,
							"' AND '",
							text2,
							"' AND \r\n                    cierre is not null and idempresa='",
							Tools.id_Empresa,
							"')\r\n                    and idempresa='",
							Tools.id_Empresa,
							"'order by newid()"
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
									double num9 = Conversions.ToDouble(sqlDataReader[14]);
									this.idmesero = Conversions.ToString(sqlDataReader[16]);
									this.estacion = Conversions.ToString(sqlDataReader[17]);
									this.FechaTicket = Conversions.ToDate(sqlDataReader[2]);
									this.idTurnoTicket = Conversions.ToString(sqlDataReader[18]);
									double num10 = Conversions.ToDouble(sqlDataReader[19]);
									double num11 = Conversions.ToDouble(sqlDataReader[20]);
									string text16 = Conversions.ToString(sqlDataReader[21]);
									string text13 = Conversions.ToString(sqlDataReader[22]);
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
									bool flag97 = this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0;
									if (flag97)
									{
										flag9 = true;
									}
									bool flag98 = !this.CheckBoxCuentasCanceladas.Checked & Operators.CompareString(text7, "Si", false) == 0;
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
										text16,
										num3,
										text9,
										text13,
										text6,
										text7,
										text8,
										text10,
										num4,
										num9,
										"0",
										num5,
										num6,
										num7,
										num8,
										num10,
										num11,
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
								bool flag100 = sqlDataReader.Read();
								if (flag100)
								{
									num12 = Conversions.ToDouble(sqlDataReader[0]);
								}
							}
							num13 += num12;
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
							bool flag101 = sqlDataReader.Read();
							if (flag101)
							{
								num14 = Conversions.ToDouble(sqlDataReader[0]);
							}
							num15 += num14;
						}
						sqlDataReader.Close();
					}
				}
			}
			this.progBar.Value = 20;
			this.MostrarCheqdetdelticket();
			double num16 = Conversions.ToDouble(this.txtMinimo.Text);
			bool flag102 = Conversions.ToDouble(this.txtMinimo.Text) != 0.0;
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
			if (flag102)
			{
				num17 = num13 - (num13 - num16);
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag103 = num17 > num13 - num18 && flag;
						if (flag103)
						{
							flag = false;
						}
						bool flag104 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectGreater(dataGridViewRow.Cells["Prod. Eliminados"].Value, 1, false)), flag));
						if (flag104)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
							dataGridViewRow.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
							this.PrecioNuevo = Conversions.ToDouble(Operators.NegateObject(dataGridViewRow.Cells[11].Value));
							num18 += Conversions.ToDouble(dataGridViewRow.Cells["Total Original"].Value);
							num19 += Conversions.ToDouble(dataGridViewRow.Cells[11].Value);
							bool flag105 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag105)
							{
								num20 += Conversions.ToDouble(dataGridViewRow.Cells["Efectivo"].Value);
								text4 = "SELECT i from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag106 = sqlDataReader.Read();
								if (flag106)
								{
									string text17 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text17.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows5 = sqlDataReader.HasRows;
									if (hasRows5)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag107 = Conversions.ToDouble(value2) == 4.0;
											if (flag107)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag108 = Conversions.ToDouble(value2) == 3.0;
											if (flag108)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag109 = Conversions.ToDouble(value2) == 1.0;
											if (flag109)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag110 = Conversions.ToDouble(value2) == 2.0;
											if (flag110)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num20 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag111 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag111)
							{
								num25 += Conversions.ToDouble(dataGridViewRow.Cells["Tarjeta"].Value);
								text4 = "SELECT j from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag112 = sqlDataReader.Read();
								if (flag112)
								{
									string text19 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text19.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows6 = sqlDataReader.HasRows;
									if (hasRows6)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag113 = Conversions.ToDouble(value2) == 4.0;
											if (flag113)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag114 = Conversions.ToDouble(value2) == 3.0;
											if (flag114)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag115 = Conversions.ToDouble(value2) == 1.0;
											if (flag115)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag116 = Conversions.ToDouble(value2) == 2.0;
											if (flag116)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
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
							bool flag117 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag117)
							{
								num26 += Conversions.ToDouble(dataGridViewRow.Cells["Otros"].Value);
								text4 = "SELECT l from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag118 = sqlDataReader.Read();
								if (flag118)
								{
									string text20 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text20.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows7 = sqlDataReader.HasRows;
									if (hasRows7)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag119 = Conversions.ToDouble(value2) == 4.0;
											if (flag119)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag120 = Conversions.ToDouble(value2) == 3.0;
											if (flag120)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag121 = Conversions.ToDouble(value2) == 1.0;
											if (flag121)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag122 = Conversions.ToDouble(value2) == 2.0;
											if (flag122)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
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
							bool flag123 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag123)
							{
								num27 += Conversions.ToDouble(dataGridViewRow.Cells["Vales"].Value);
								text4 = "SELECT k from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag124 = sqlDataReader.Read();
								if (flag124)
								{
									string text21 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text21.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows8 = sqlDataReader.HasRows;
									if (hasRows8)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag125 = Conversions.ToDouble(value2) == 4.0;
											if (flag125)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag126 = Conversions.ToDouble(value2) == 3.0;
											if (flag126)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag127 = Conversions.ToDouble(value2) == 1.0;
											if (flag127)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag128 = Conversions.ToDouble(value2) == 2.0;
											if (flag128)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num27 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag129 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag129)
							{
								num20 += Conversions.ToDouble(dataGridViewRow.Cells["Efectivo"].Value);
								num25 += Conversions.ToDouble(dataGridViewRow.Cells["Tarjeta"].Value);
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag130 = sqlDataReader.Read();
								if (flag130)
								{
									string text22 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text22.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows9 = sqlDataReader.HasRows;
									if (hasRows9)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag131 = Conversions.ToDouble(value2) == 4.0;
											if (flag131)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag132 = Conversions.ToDouble(value2) == 3.0;
											if (flag132)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag133 = Conversions.ToDouble(value2) == 1.0;
											if (flag133)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag134 = Conversions.ToDouble(value2) == 2.0;
											if (flag134)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num25 += 0.0;
										num20 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag135 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag135)
							{
								num20 += Conversions.ToDouble(dataGridViewRow.Cells["Efectivo"].Value);
								num27 += Conversions.ToDouble(dataGridViewRow.Cells["Vales"].Value);
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag136 = sqlDataReader.Read();
								if (flag136)
								{
									string text22 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text22.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows10 = sqlDataReader.HasRows;
									if (hasRows10)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag137 = Conversions.ToDouble(value2) == 4.0;
											if (flag137)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag138 = Conversions.ToDouble(value2) == 3.0;
											if (flag138)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag139 = Conversions.ToDouble(value2) == 1.0;
											if (flag139)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag140 = Conversions.ToDouble(value2) == 2.0;
											if (flag140)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num27 += 0.0;
										num20 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag141 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag141)
							{
								num20 += Conversions.ToDouble(dataGridViewRow.Cells["Efectivo"].Value);
								num26 += Conversions.ToDouble(dataGridViewRow.Cells["Otros"].Value);
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag142 = sqlDataReader.Read();
								if (flag142)
								{
									string text22 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text22.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows11 = sqlDataReader.HasRows;
									if (hasRows11)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag143 = Conversions.ToDouble(value2) == 4.0;
											if (flag143)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag144 = Conversions.ToDouble(value2) == 3.0;
											if (flag144)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag145 = Conversions.ToDouble(value2) == 1.0;
											if (flag145)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag146 = Conversions.ToDouble(value2) == 2.0;
											if (flag146)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num26 += 0.0;
										num20 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag147 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag147)
							{
								num25 += Conversions.ToDouble(dataGridViewRow.Cells["Tarjeta"].Value);
								num27 += Conversions.ToDouble(dataGridViewRow.Cells["Vales"].Value);
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag148 = sqlDataReader.Read();
								if (flag148)
								{
									string text22 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text22.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows12 = sqlDataReader.HasRows;
									if (hasRows12)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag149 = Conversions.ToDouble(value2) == 4.0;
											if (flag149)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag150 = Conversions.ToDouble(value2) == 3.0;
											if (flag150)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag151 = Conversions.ToDouble(value2) == 1.0;
											if (flag151)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag152 = Conversions.ToDouble(value2) == 2.0;
											if (flag152)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num25 += 0.0;
										num27 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag153 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag153)
							{
								num25 += Conversions.ToDouble(dataGridViewRow.Cells["Tarjeta"].Value);
								num26 += Conversions.ToDouble(dataGridViewRow.Cells["Otros"].Value);
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag154 = sqlDataReader.Read();
								if (flag154)
								{
									string text22 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text22.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows13 = sqlDataReader.HasRows;
									if (hasRows13)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag155 = Conversions.ToDouble(value2) == 4.0;
											if (flag155)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag156 = Conversions.ToDouble(value2) == 3.0;
											if (flag156)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag157 = Conversions.ToDouble(value2) == 1.0;
											if (flag157)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag158 = Conversions.ToDouble(value2) == 2.0;
											if (flag158)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num26 += 0.0;
										num25 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag159 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow.Cells["Tarjeta"].Value, 0, false)));
							if (flag159)
							{
								num27 += Conversions.ToDouble(dataGridViewRow.Cells["Vales"].Value);
								num26 += Conversions.ToDouble(dataGridViewRow.Cells["Otros"].Value);
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag160 = sqlDataReader.Read();
								if (flag160)
								{
									string text22 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text22.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows14 = sqlDataReader.HasRows;
									if (hasRows14)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag161 = Conversions.ToDouble(value2) == 4.0;
											if (flag161)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag162 = Conversions.ToDouble(value2) == 3.0;
											if (flag162)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag163 = Conversions.ToDouble(value2) == 1.0;
											if (flag163)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag164 = Conversions.ToDouble(value2) == 2.0;
											if (flag164)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num26 += 0.0;
										num27 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							num28 += Conversions.ToDouble(dataGridViewRow.Cells["Propina"].Value);
							bool flag165 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow.Cells["Facturado"].Value, "Si", false), Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "No", false)));
							if (flag165)
							{
								num29 += Conversions.ToDouble(dataGridViewRow.Cells["Total Original"].Value) + this.PrecioNuevo;
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
						bool flag166 = Conversions.ToBoolean(Operators.AndObject(this.CheckBoxCuentasCanceladas.Checked, Operators.CompareObjectEqual(dataGridViewRow.Cells["Cancel."].Value, "Si", false)));
						checked
						{
							if (flag166)
							{
								dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
								dataGridViewRow.Cells["Eliminar"].Value = true;
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
			this.progBar.Value = 50;
			bool flag167 = Conversions.ToDouble(this.txtDescto.Text) > 0.0;
			if (flag167)
			{
				num17 = num13 - num13 * (Conversions.ToDouble(this.txtDescto.Text) / 100.0);
				try
				{
					foreach (object obj2 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
						bool flag168 = num17 > num13 - num18 && flag;
						if (flag168)
						{
							flag = false;
						}
						bool flag169 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectGreater(dataGridViewRow2.Cells["Prod. Eliminados"].Value, 1, false)), flag));
						if (flag169)
						{
							dataGridViewRow2.DefaultCellStyle.BackColor = Color.Red;
							dataGridViewRow2.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
							this.PrecioNuevo = Conversions.ToDouble(Operators.NegateObject(dataGridViewRow2.Cells[11].Value));
							num18 += Conversions.ToDouble(dataGridViewRow2.Cells["Total Original"].Value);
							num19 += Conversions.ToDouble(dataGridViewRow2.Cells[11].Value);
							bool flag170 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag170)
							{
								num20 += Conversions.ToDouble(dataGridViewRow2.Cells["Efectivo"].Value);
								text4 = "SELECT i from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag171 = sqlDataReader.Read();
								if (flag171)
								{
									string text17 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text17.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows15 = sqlDataReader.HasRows;
									if (hasRows15)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag172 = Conversions.ToDouble(value2) == 4.0;
											if (flag172)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag173 = Conversions.ToDouble(value2) == 3.0;
											if (flag173)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag174 = Conversions.ToDouble(value2) == 1.0;
											if (flag174)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag175 = Conversions.ToDouble(value2) == 2.0;
											if (flag175)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num20 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag176 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag176)
							{
								num25 += Conversions.ToDouble(dataGridViewRow2.Cells["Tarjeta"].Value);
								text4 = "SELECT j from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag177 = sqlDataReader.Read();
								if (flag177)
								{
									string text19 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text19.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows16 = sqlDataReader.HasRows;
									if (hasRows16)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag178 = Conversions.ToDouble(value2) == 4.0;
											if (flag178)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag179 = Conversions.ToDouble(value2) == 3.0;
											if (flag179)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag180 = Conversions.ToDouble(value2) == 1.0;
											if (flag180)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag181 = Conversions.ToDouble(value2) == 2.0;
											if (flag181)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
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
							bool flag182 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag182)
							{
								num26 += Conversions.ToDouble(dataGridViewRow2.Cells["Otros"].Value);
								text4 = "SELECT l from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag183 = sqlDataReader.Read();
								if (flag183)
								{
									string text20 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text20.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows17 = sqlDataReader.HasRows;
									if (hasRows17)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag184 = Conversions.ToDouble(value2) == 4.0;
											if (flag184)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag185 = Conversions.ToDouble(value2) == 3.0;
											if (flag185)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag186 = Conversions.ToDouble(value2) == 1.0;
											if (flag186)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag187 = Conversions.ToDouble(value2) == 2.0;
											if (flag187)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
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
							bool flag188 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag188)
							{
								num27 += Conversions.ToDouble(dataGridViewRow2.Cells["Vales"].Value);
								text4 = "SELECT k from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag189 = sqlDataReader.Read();
								if (flag189)
								{
									string text21 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text21.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows18 = sqlDataReader.HasRows;
									if (hasRows18)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag190 = Conversions.ToDouble(value2) == 4.0;
											if (flag190)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag191 = Conversions.ToDouble(value2) == 3.0;
											if (flag191)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag192 = Conversions.ToDouble(value2) == 1.0;
											if (flag192)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag193 = Conversions.ToDouble(value2) == 2.0;
											if (flag193)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num27 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag194 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag194)
							{
								num20 += Conversions.ToDouble(dataGridViewRow2.Cells["Efectivo"].Value);
								num25 += Conversions.ToDouble(dataGridViewRow2.Cells["Tarjeta"].Value);
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag195 = sqlDataReader.Read();
								if (flag195)
								{
									string text22 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text22.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows19 = sqlDataReader.HasRows;
									if (hasRows19)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag196 = Conversions.ToDouble(value2) == 4.0;
											if (flag196)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag197 = Conversions.ToDouble(value2) == 3.0;
											if (flag197)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag198 = Conversions.ToDouble(value2) == 1.0;
											if (flag198)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag199 = Conversions.ToDouble(value2) == 2.0;
											if (flag199)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num25 += 0.0;
										num20 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag200 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag200)
							{
								num20 += Conversions.ToDouble(dataGridViewRow2.Cells["Efectivo"].Value);
								num27 += Conversions.ToDouble(dataGridViewRow2.Cells["Vales"].Value);
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag201 = sqlDataReader.Read();
								if (flag201)
								{
									string text22 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text22.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows20 = sqlDataReader.HasRows;
									if (hasRows20)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag202 = Conversions.ToDouble(value2) == 4.0;
											if (flag202)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag203 = Conversions.ToDouble(value2) == 3.0;
											if (flag203)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag204 = Conversions.ToDouble(value2) == 1.0;
											if (flag204)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag205 = Conversions.ToDouble(value2) == 2.0;
											if (flag205)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num27 += 0.0;
										num20 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag206 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag206)
							{
								num20 += Conversions.ToDouble(dataGridViewRow2.Cells["Efectivo"].Value);
								num26 += Conversions.ToDouble(dataGridViewRow2.Cells["Otros"].Value);
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag207 = sqlDataReader.Read();
								if (flag207)
								{
									string text22 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text22.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows21 = sqlDataReader.HasRows;
									if (hasRows21)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag208 = Conversions.ToDouble(value2) == 4.0;
											if (flag208)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag209 = Conversions.ToDouble(value2) == 3.0;
											if (flag209)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag210 = Conversions.ToDouble(value2) == 1.0;
											if (flag210)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag211 = Conversions.ToDouble(value2) == 2.0;
											if (flag211)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num26 += 0.0;
										num20 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag212 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag212)
							{
								num25 += Conversions.ToDouble(dataGridViewRow2.Cells["Tarjeta"].Value);
								num27 += Conversions.ToDouble(dataGridViewRow2.Cells["Vales"].Value);
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag213 = sqlDataReader.Read();
								if (flag213)
								{
									string text22 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text22.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows22 = sqlDataReader.HasRows;
									if (hasRows22)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag214 = Conversions.ToDouble(value2) == 4.0;
											if (flag214)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag215 = Conversions.ToDouble(value2) == 3.0;
											if (flag215)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag216 = Conversions.ToDouble(value2) == 1.0;
											if (flag216)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag217 = Conversions.ToDouble(value2) == 2.0;
											if (flag217)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num25 += 0.0;
										num27 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag218 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag218)
							{
								num25 += Conversions.ToDouble(dataGridViewRow2.Cells["Tarjeta"].Value);
								num26 += Conversions.ToDouble(dataGridViewRow2.Cells["Otros"].Value);
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag219 = sqlDataReader.Read();
								if (flag219)
								{
									string text22 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text22.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows23 = sqlDataReader.HasRows;
									if (hasRows23)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag220 = Conversions.ToDouble(value2) == 4.0;
											if (flag220)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag221 = Conversions.ToDouble(value2) == 3.0;
											if (flag221)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag222 = Conversions.ToDouble(value2) == 1.0;
											if (flag222)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag223 = Conversions.ToDouble(value2) == 2.0;
											if (flag223)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num26 += 0.0;
										num25 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							bool flag224 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow2.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Tarjeta"].Value, 0, false)));
							if (flag224)
							{
								num27 += Conversions.ToDouble(dataGridViewRow2.Cells["Vales"].Value);
								num26 += Conversions.ToDouble(dataGridViewRow2.Cells["Otros"].Value);
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag225 = sqlDataReader.Read();
								if (flag225)
								{
									string text22 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text22.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows24 = sqlDataReader.HasRows;
									if (hasRows24)
									{
										while (sqlDataReader.Read())
										{
											string text18 = Conversions.ToString(sqlDataReader[0]);
											string value2 = Conversions.ToString(sqlDataReader[1]);
											bool flag226 = Conversions.ToDouble(value2) == 4.0;
											if (flag226)
											{
												num21 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag227 = Conversions.ToDouble(value2) == 3.0;
											if (flag227)
											{
												num22 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag228 = Conversions.ToDouble(value2) == 1.0;
											if (flag228)
											{
												num23 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
											bool flag229 = Conversions.ToDouble(value2) == 2.0;
											if (flag229)
											{
												num24 += Conversions.ToDouble(this.PrecioNuevo.ToString());
											}
										}
									}
									else
									{
										num26 += 0.0;
										num27 += 0.0;
									}
								}
								sqlDataReader.Close();
							}
							num28 += Conversions.ToDouble(dataGridViewRow2.Cells["Propina"].Value);
							bool flag230 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow2.Cells["Facturado"].Value, "Si", false), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(dataGridViewRow2.Cells["Descto %"].Value, 0, false)));
							if (flag230)
							{
								num29 += Conversions.ToDouble(dataGridViewRow2.Cells["Total Original"].Value) + this.PrecioNuevo;
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
							string str = Conversions.ToString(dataGridViewRow2.Cells[0].Value);
							text4 = "delete from F where a='" + str + "'";
							sqlQuery_Conn.execQuery_conn(text4);
							text4 = "delete from FF where a='" + str + "'";
							sqlQuery_Conn.execQuery_conn(text4);
						}
						bool flag231 = Conversions.ToBoolean(Operators.AndObject(this.CheckBoxCuentasCanceladas.Checked, Operators.CompareObjectEqual(dataGridViewRow2.Cells["Cancel."].Value, "Si", false)));
						checked
						{
							if (flag231)
							{
								dataGridViewRow2.DefaultCellStyle.BackColor = Color.Red;
								dataGridViewRow2.Cells["Eliminar"].Value = true;
								num2++;
							}
							this.dgvNotas.ClearSelection();
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
			this.progBar.Value = 70;
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
					double num30 = Conversions.ToDouble(sqlDataReader[0]);
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
					double num31 = Conversions.ToDouble(sqlDataReader[0]);
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
				double num32 = Conversions.ToDouble(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			bool flag232 = Operators.CompareString(text3, "Todas", false) == 0;
			double num33;
			if (flag232)
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
					num33 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag233 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag233)
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
					num33 = Conversions.ToDouble(sqlDataReader[0]);
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
			double num34;
			if (hasRows30)
			{
				num34 = Conversions.ToDouble(sqlDataReader[0]);
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
			double num35;
			if (hasRows31)
			{
				num35 = Conversions.ToDouble(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			bool flag234 = Operators.CompareString(text3, "Todas", false) == 0;
			double num36;
			double num37;
			if (flag234)
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
					"' and facturado = 1 and cancelado='0' "
				});
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				sqlDataReader.Read();
				bool hasRows32 = sqlDataReader.HasRows;
				if (hasRows32)
				{
					num36 = Conversions.ToDouble(sqlDataReader[0]);
					num37 = Conversions.ToDouble(sqlDataReader[0]);
					this.lblventaFacturada.Text = "$ " + num37.ToString("N2");
				}
				sqlDataReader.Close();
			}
			bool flag235 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag235)
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
				bool hasRows33 = sqlDataReader.HasRows;
				if (hasRows33)
				{
					num36 = Conversions.ToDouble(sqlDataReader[0]);
					num37 = Conversions.ToDouble(sqlDataReader[0]);
					this.lblventaFacturada.Text = "$ " + num37.ToString("N2");
				}
				sqlDataReader.Close();
			}
			bool flag236 = Operators.CompareString(text3, "Todas", false) == 0;
			double num38;
			if (flag236)
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
				bool hasRows34 = sqlDataReader.HasRows;
				if (hasRows34)
				{
					num38 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag237 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag237)
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
				bool hasRows35 = sqlDataReader.HasRows;
				if (hasRows35)
				{
					num38 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag238 = Operators.CompareString(text3, "Todas", false) == 0;
			double num39;
			if (flag238)
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
				bool hasRows36 = sqlDataReader.HasRows;
				if (hasRows36)
				{
					num39 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag239 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag239)
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
				bool hasRows37 = sqlDataReader.HasRows;
				if (hasRows37)
				{
					num39 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag240 = Operators.CompareString(text3, "Todas", false) == 0;
			double num40;
			if (flag240)
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
				bool hasRows38 = sqlDataReader.HasRows;
				if (hasRows38)
				{
					num40 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			bool flag241 = Operators.CompareString(text3, "Todas", false) != 0;
			if (flag241)
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
					num40 = Conversions.ToDouble(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
			this.progBar.Value = 80;
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
			double num41;
			if (hasRows40)
			{
				num41 = Conversions.ToDouble(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			this.lblcortetarjetaanterior.Text = "$ " + num38.ToString("N2");
			this.lblcorteefectivoanterior.Text = "$ " + num15.ToString("N2");
			this.lblcorteanteriorvales.Text = "$ " + num40.ToString("N2");
			this.lblcorteanteriorotros.Text = "$ " + num39.ToString("N2");
			this.lblcorteanteriordepositosenefectivo.Text = "$ " + num35.ToString("N2");
			this.lblcorteanteriorretirosefectivo.Text = "$ " + num34.ToString("N2");
			this.lblcorteanteriorpropinas.Text = "$ " + num33.ToString("N2");
			this.lblcorteanteriorsaldo.Text = "$ " + (num15 + num38 + num39 + num40 + num35 - num34 - num33 + num41).ToString("N2");
			this.lblcorteanteriorefectivofinal.Text = "$ " + (num15 + num35 - num34 - num33 + num41).ToString("N2");
			this.lblcortefondoinicialanterior.Text = "$ " + num41.ToString("N2");
			bool checked3 = this.CheckBoxfondocaja.Checked;
			if (checked3)
			{
				this.lblfondoinicialnuevo.Text = "$ 0.00";
			}
			else
			{
				this.lblfondoinicialnuevo.Text = "$ " + num41.ToString("N2");
			}
			this.progBar.Value = 90;
			this.txtVales.Text = "$ " + num40.ToString("N2");
			this.txtdifvales.Text = "$ " + (num40 - num27 - num22).ToString("N2");
			this.txtVentasOtros.Text = "$ " + num39.ToString("N2");
			this.txtdifotros.Text = "$ " + (num39 - num26 - num21).ToString("N2");
			this.txtVentaTarjeta.Text = "$ " + num38.ToString("N2");
			this.txtDifTarjeta.Text = "$ " + (num38 - num25 - num24).ToString("N2");
			this.txtVentaFacturada.Text = "$ " + (num36 - num29).ToString("N2");
			this.txtDepositos.Text = "$ " + num35.ToString("N2");
			this.txtretirostotal.Text = "$ " + num34.ToString("N2");
			this.txtTotalPropinas.Text = "$ " + num33.ToString("N2");
			this.txttotalnuevopropinas.Text = "$ " + (num33 - num28).ToString("N2");
			this.txtCuentasModificar.Text = num2.ToString();
			this.txtCuentasTotal.Text = num.ToString();
			this.txtImpAnterior.Text = "$ " + num13.ToString("N2");
			this.txtEfectivoAnt.Text = "$ " + num15.ToString("N2");
			this.txtEfectivoFiscal.Text = "$ " + (num15 - num20 - num23).ToString("N2");
			this.txtDifImporte.Text = "$ " + (num18 - num19).ToString("N2");
			this.txtDifPorcen.Text = "% " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			this.txtObjetivo.Text = "$ " + num17.ToString("N2");
			bool flag242 = !this.chkEliminaRet.Checked;
			if (flag242)
			{
				this.lblcortenuevodepositos.Text = "$ " + num35.ToString("N2");
				this.lblcortenuevoretiros.Text = "$ " + num34.ToString("N2");
			}
			else
			{
				this.lblcortenuevodepositos.Text = "$ 0.00";
				this.lblcortenuevoretiros.Text = "$ 0.00";
			}
			bool flag243 = !this.chkEliminaProp.Checked;
			if (flag243)
			{
				this.lblpropinascortenuevo.Text = "$ " + (num33 - num28).ToString("N2");
			}
			else
			{
				this.lblpropinascortenuevo.Text = "$ 0.00";
			}
			double num42 = Conversions.ToDouble(this.txtdifvales.Text);
			this.lblcortenuevovales.Text = "$ " + num42.ToString("N2");
			double num43 = Conversions.ToDouble(this.txtdifotros.Text);
			this.lblcortenuevotros.Text = "$ " + num43.ToString("N2");
			double num44 = Conversions.ToDouble(this.txtDifTarjeta.Text);
			this.lblcortetarjetanuevo.Text = "$ " + num44.ToString("N2");
			double num45 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
			this.lblcorteefectivonuevo.Text = "$ " + num45.ToString("N2");
			double num46 = Conversions.ToDouble(this.lblpropinascortenuevo.Text);
			double num47 = Conversions.ToDouble(this.lblcortenuevoretiros.Text);
			double num48 = Conversions.ToDouble(this.lblcortenuevodepositos.Text);
			double num49 = Conversions.ToDouble(this.lblfondoinicialnuevo.Text);
			this.lblsaldofinarlcortenuevo.Text = "$ " + (num45 + num44 + num43 + num42 - num46 - num47 + num48 + num49).ToString("N2");
			this.txtImpNuevo.Text = "$ " + (num13 - num18 + num19).ToString("N2");
			this.lblEfectivonuevocorte.Text = "$ " + (num45 - num46 - num47 + num48 + num49).ToString("N2");
			this.txtEfectivoCaja.Text = "$ " + (num45 - num46 - num47 + num48 + num49).ToString("N2");
			double num50 = num13 - num37;
			this.lblventasinfacturarcorte.Text = "$ " + num50.ToString("N2");
			this.lblfacturapub.Text = "$ " + num50.ToString("N2");
			double num51 = Conversions.ToDouble(this.txtImpNuevo.Text);
			double num52 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			this.txtFacturaPUB.Text = "$ " + (num51 - num52).ToString("N2");
			this.txtventasinfacturar.Text = "$ " + (num51 - num52).ToString("N2");
			this.lblventafacturanew.Text = this.txtVentaFacturada.Text;
			this.lblventasinfacturarnew.Text = this.txtventasinfacturar.Text;
			this.lblfacturapubnew.Text = this.txtFacturaPUB.Text;
			this.DifPorcentajeSin = (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			bool flag244 = Conversions.ToDouble(this.txtMinimo.Text) == 0.0 & Conversions.ToDouble(this.txtDescto.Text) == 0.0;
			if (flag244)
			{
				this.dgvNotas.Columns[18].Visible = false;
				this.dgvNotas.Columns[19].Visible = false;
			}
			else
			{
				bool flag245 = Conversions.ToDouble(this.txtMinimo.Text) != 0.0 & Conversions.ToDouble(this.txtDescto.Text) == 0.0;
				if (flag245)
				{
					this.dgvNotas.Columns[18].Visible = true;
					this.dgvNotas.Columns[19].Visible = true;
				}
				else
				{
					bool flag246 = Conversions.ToDouble(this.txtMinimo.Text) == 0.0 & Conversions.ToDouble(this.txtDescto.Text) != 0.0;
					if (flag246)
					{
						this.dgvNotas.Columns[18].Visible = true;
						this.dgvNotas.Columns[19].Visible = true;
					}
				}
			}
			this.iniciaGridCheqdet();
			try
			{
				foreach (object obj3 in ((IEnumerable)this.dgvNotas.Rows))
				{
					DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj3;
					bool flag247 = Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells["Total Original"].Value, 0, false);
					if (flag247)
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
			bool flag248 = Conversions.ToDouble(this.txtCuentasModificar.Text) != 0.0;
			if (flag248)
			{
				this.btnAplicar.Enabled = true;
			}
			bool flag249 = Operators.CompareString(this.txtCuentasTotal.Text, "0", false) == 0;
			if (flag249)
			{
				Interaction.MsgBox("No hay cuentas para modificar en le periodo seleccionado, intenta nuevamente con otro periodo o contacta a tu administrador del sistema!", MsgBoxStyle.OkOnly, null);
			}
			text4 = "SELECT an from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
			bool flag250 = sqlDataReader.Read();
			if (flag250)
			{
				this.Descomponercuentas = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
			}
			bool flag251 = Operators.CompareString(this.Descomponercuentas, "1", false) == 0;
			if (flag251)
			{
				try
				{
					foreach (object obj4 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow4 = (DataGridViewRow)obj4;
						bool flag252 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLessEqual(dataGridViewRow4.Cells["Prod. Eliminados"].Value, 1, false), Operators.CompareObjectEqual(dataGridViewRow4.Cells["Eliminar"].Value, true, false)));
						if (flag252)
						{
							string text23 = Conversions.ToString(dataGridViewRow4.Cells["Folio Cuenta"].Value);
							string text24 = Conversions.ToString(dataGridViewRow4.Cells["id_nota"].Value);
							dataGridViewRow4.Cells["Eliminar"].Value = false;
							dataGridViewRow4.DefaultCellStyle.BackColor = Color.White;
							dataGridViewRow4.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.875f, FontStyle.Regular);
							text4 = "DELETE FROM F where a ='" + text24 + "'";
							sqlQuery_Conn.execQuery_conn(text4);
							text4 = "select a , b , c ,d, e , f , g ,  h , i , j , k , l , m ,\r\n                n , o ,p , q , r , s , t , u, w , \r\n                x , y , z , aa , bb , cc , dd , ee ,\r\n                ff ,gg ,hh, ii , kk ,\r\n                kk , ll , mm , nn , oo , pp , qq , rr, ss , \r\n               tt , uu, ww , xx , yy ,zz\r\n                from FF where a = '" + text24 + "' order by b asc";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool hasRows41 = sqlDataReader.HasRows;
							if (hasRows41)
							{
								text4 = "Delete from Cheqdet where Foliodet = '" + text24 + "'";
								sqlQuery.execQuery(text4);
								while (sqlDataReader.Read())
								{
									int num53 = Conversions.ToInteger(sqlDataReader[3]);
									string text25 = Conversions.ToString(sqlDataReader[1]);
									string text26 = Conversions.ToString(sqlDataReader[2]);
									string text27 = Conversions.ToString(sqlDataReader[4]);
									double num54 = Conversions.ToDouble(sqlDataReader[5]);
									double num55 = Conversions.ToDouble(sqlDataReader[6]);
									double num56 = Conversions.ToDouble(sqlDataReader[7]);
									double num57 = Conversions.ToDouble(sqlDataReader[8]);
									double num58 = Conversions.ToDouble(sqlDataReader[9]);
									double num59 = Conversions.ToDouble(sqlDataReader[10]);
									string text28 = Conversions.ToString(sqlDataReader[11]);
									DateTime dateTime3 = Conversions.ToDate(sqlDataReader[12]);
									string text29 = Conversions.ToString(sqlDataReader[13]);
									string text30 = Conversions.ToString(sqlDataReader[14]);
									string text31 = Conversions.ToString(sqlDataReader[15]);
									string text32 = Conversions.ToString(sqlDataReader[16]);
									string text33 = Conversions.ToString(sqlDataReader[17]);
									string text34 = Conversions.ToString(sqlDataReader[18]);
									string text35 = Conversions.ToString(sqlDataReader[19]);
									DateTime dateTime4 = Conversions.ToDate(sqlDataReader[20]);
									string text36 = Conversions.ToString(sqlDataReader[21]);
									string text37 = Conversions.ToString(sqlDataReader[22]);
									double num60 = Conversions.ToDouble(sqlDataReader[23]);
									string text38 = Conversions.ToString(sqlDataReader[24]);
									string text39 = Conversions.ToString(sqlDataReader[25]);
									string text40 = Conversions.ToString(sqlDataReader[26]);
									string text41 = Conversions.ToString(sqlDataReader[27]);
									string text42 = Conversions.ToString(sqlDataReader[28]);
									string text43 = Conversions.ToString(sqlDataReader[29]);
									string text44 = Conversions.ToString(sqlDataReader[30]);
									string text45 = Conversions.ToString(sqlDataReader[31]);
									DateTime dateTime5 = Conversions.ToDate(sqlDataReader[32]);
									string text46 = Conversions.ToString(sqlDataReader[33]);
									string text47 = Conversions.ToString(sqlDataReader[34]);
									string text48 = Conversions.ToString(sqlDataReader[35]);
									string text49 = Conversions.ToString(sqlDataReader[36]);
									string text50 = Conversions.ToString(sqlDataReader[37]);
									string text51 = Conversions.ToString(sqlDataReader[38]);
									string text52 = Conversions.ToString(sqlDataReader[39]);
									string text53 = Conversions.ToString(sqlDataReader[40]);
									string text54 = Conversions.ToString(sqlDataReader[41]);
									string text55 = Conversions.ToString(sqlDataReader[42]);
									string text56 = Conversions.ToString(sqlDataReader[43]);
									string text57 = Conversions.ToString(sqlDataReader[44]);
									double num61 = Conversions.ToDouble(sqlDataReader[45]);
									string text58 = Conversions.ToString(sqlDataReader[46]);
									string text59 = Conversions.ToString(sqlDataReader[47]);
									string text60 = Conversions.ToString(sqlDataReader[48]);
									string text61 = Conversions.ToString(sqlDataReader[49]);
									text4 = string.Concat(new string[]
									{
										"insert into cheqdet (\r\n                                Foliodet,\r\n                                movimiento,\r\n                                comanda,\r\n                                cantidad,\r\n                                idproducto,\r\n                                descuento,\r\n                                precio,\r\n                                impuesto1,\r\n                                impuesto2,\r\n                                impuesto3,\r\n                                preciosinimpuestos,\r\n                                tiempo,\r\n                                hora,\r\n                                modificador,\r\n                                mitad,\r\n                                comentario,\r\n                                idestacion,\r\n                                usuariodescuento,\r\n                                comentariodescuento,\r\n                                idtipodescuento,\r\n                                horaproduccion,\r\n                                idproductocompuesto,\r\n                                productocompuestoprincipal,\r\n                                preciocatalogo,\r\n                                marcar,\r\n                                idmeseroproducto,\r\n                                prioridadproduccion,\r\n                                estatuspatin,\r\n                                idcortesia,\r\n                                numerotarjeta,\r\n                                estadomonitor,\r\n                                llavemovto,\r\n                                horameserofinalizado,\r\n                                meserofinalizado,\r\n                                sistema_envio,\r\n                                idturno_cierre,\r\n                                procesado,\r\n                                promovolumen,\r\n                                iddispositivo,\r\n                                productsyncidsr,\r\n                                subtotalsrx,\r\n                                totalsrx,\r\n                                idmovtobillar,\r\n                                idlistaprecio,\r\n                                tipocambio,\r\n                                impuestoimporte3,\r\n                                estrateca_DiscountCode,\r\n                                estrateca_DiscountID,\r\n                                estrateca_DiscountAmount,\r\n                                saledetailid\r\n\r\n                               )\r\n\r\n\r\n                               Values(\r\n                                '",
										text24.ToString(),
										"',\r\n                                '",
										text25.ToString(),
										"',\r\n                                '",
										text26.ToString(),
										"',\r\n                                '",
										num53.ToString(),
										"',\r\n                                '",
										text27.ToString(),
										"',\r\n                                '",
										num54.ToString(),
										"',\r\n                                '",
										num55.ToString("N2"),
										"',\r\n                                '",
										num56.ToString("N2"),
										"',\r\n                                '",
										num57.ToString("N2"),
										"',\r\n                                '",
										num58.ToString("N2"),
										"',\r\n                                '",
										num59.ToString("N2"),
										"',\r\n                                '",
										text28,
										"',\r\n                                '",
										dateTime3.ToString(Tools.strFormatoFechaLargo),
										"',\r\n                                '",
										text29.ToString(),
										"',\r\n                                '",
										text30.ToString(),
										"',\r\n                                '",
										text31.ToString(),
										"',\r\n                                '",
										text32.ToString(),
										"',\r\n                                '",
										text33,
										"',\r\n                                '",
										text34.ToString(),
										"',\r\n                                '",
										text35.ToString(),
										"',\r\n                                '",
										dateTime4.ToString(Tools.strFormatoFechaLargo),
										"',\r\n                                '",
										text36.ToString(),
										"',\r\n                                '",
										text37.ToString(),
										"',\r\n                                '",
										num60.ToString("N2"),
										"',\r\n                                '",
										text38.ToString(),
										"',\r\n                                '",
										text39.ToString(),
										"',\r\n                                '",
										text40.ToString(),
										"',\r\n                                ",
										text41.ToString(),
										",\r\n                                '",
										text42.ToString(),
										"',\r\n                                '",
										text43.ToString(),
										"',\r\n                                '",
										text44.ToString(),
										"',\r\n                                '",
										text45.ToString(),
										"',\r\n                                '",
										dateTime5.ToString(Tools.strFormatoFechaLargo),
										"',\r\n                                '",
										text46.ToString(),
										"',\r\n                                '",
										text47.ToString(),
										"',\r\n                                '",
										text48.ToString(),
										"',\r\n                                '",
										text49.ToString(),
										"',\r\n                                '",
										text50.ToString(),
										"',\r\n                                '",
										text51.ToString(),
										"',\r\n                                '",
										text52.ToString(),
										"',\r\n                                '",
										text53.ToString(),
										"',\r\n                                '",
										text54.ToString(),
										"',\r\n                                '",
										text55.ToString(),
										"',\r\n                                '",
										text56.ToString(),
										"',\r\n                                '",
										text57.ToString(),
										"',\r\n                                '",
										num61.ToString("N2"),
										"',                            \r\n                                '",
										text58.ToString(),
										"',\r\n                                '",
										text59.ToString(),
										"',\r\n                                '",
										text60,
										"',\r\n                                '",
										text61.ToString(),
										"')"
									});
									sqlQuery.execQuery(text4);
									this.progBar.Value = 90;
								}
								text4 = "DELETE FROM FF where a = '" + text24 + "'";
								sqlQuery_Conn.execQuery_conn(text4);
							}
							sqlDataReader.Close();
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
			bool flag253 = Operators.CompareString(this.Descomponercuentas, "0", false) == 0;
			if (flag253)
			{
				try
				{
					foreach (object obj5 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow5 = (DataGridViewRow)obj5;
						bool flag254 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectLessEqual(dataGridViewRow5.Cells["Prod. Eliminados"].Value, 1, false), Operators.CompareObjectEqual(dataGridViewRow5.Cells["Eliminar"].Value, true, false)));
						if (flag254)
						{
							string text23 = Conversions.ToString(dataGridViewRow5.Cells["Folio Cuenta"].Value);
							string text24 = Conversions.ToString(dataGridViewRow5.Cells["id_nota"].Value);
							dataGridViewRow5.Cells["Eliminar"].Value = false;
							dataGridViewRow5.DefaultCellStyle.BackColor = Color.White;
							dataGridViewRow5.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.875f, FontStyle.Regular);
							text4 = "DELETE FROM F where a ='" + text24 + "'";
							sqlQuery_Conn.execQuery_conn(text4);
							text4 = "select a , b , c ,d, e , f , g ,  h , i , j , k , l , m ,\r\n                n , o ,p , q , r , s , t , u, w , \r\n                x , y , z , aa , bb , cc , dd , ee ,\r\n                ff ,gg ,hh, ii , kk ,\r\n                kk , ll , mm , nn , oo , pp , qq , rr, ss , \r\n               tt , uu, ww , xx , yy ,zz\r\n                from FF where a = '" + text24 + "' order by b asc";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool hasRows42 = sqlDataReader.HasRows;
							if (hasRows42)
							{
								text4 = "Delete from Cheqdet where Foliodet = '" + text24 + "'";
								sqlQuery.execQuery(text4);
								while (sqlDataReader.Read())
								{
									int num53 = Conversions.ToInteger(sqlDataReader[3]);
									string text25 = Conversions.ToString(sqlDataReader[1]);
									string text26 = Conversions.ToString(sqlDataReader[2]);
									string text27 = Conversions.ToString(sqlDataReader[4]);
									double num54 = Conversions.ToDouble(sqlDataReader[5]);
									double num55 = Conversions.ToDouble(sqlDataReader[6]);
									double num56 = Conversions.ToDouble(sqlDataReader[7]);
									double num57 = Conversions.ToDouble(sqlDataReader[8]);
									double num58 = Conversions.ToDouble(sqlDataReader[9]);
									double num59 = Conversions.ToDouble(sqlDataReader[10]);
									string text28 = Conversions.ToString(sqlDataReader[11]);
									DateTime dateTime3 = Conversions.ToDate(sqlDataReader[12]);
									string text29 = Conversions.ToString(sqlDataReader[13]);
									string text30 = Conversions.ToString(sqlDataReader[14]);
									string text31 = Conversions.ToString(sqlDataReader[15]);
									string text32 = Conversions.ToString(sqlDataReader[16]);
									string text33 = Conversions.ToString(sqlDataReader[17]);
									string text34 = Conversions.ToString(sqlDataReader[18]);
									string text35 = Conversions.ToString(sqlDataReader[19]);
									DateTime dateTime4 = Conversions.ToDate(sqlDataReader[20]);
									string text36 = Conversions.ToString(sqlDataReader[21]);
									string text37 = Conversions.ToString(sqlDataReader[22]);
									double num60 = Conversions.ToDouble(sqlDataReader[23]);
									string text38 = Conversions.ToString(sqlDataReader[24]);
									string text39 = Conversions.ToString(sqlDataReader[25]);
									string text40 = Conversions.ToString(sqlDataReader[26]);
									string text41 = Conversions.ToString(sqlDataReader[27]);
									string text42 = Conversions.ToString(sqlDataReader[28]);
									string text43 = Conversions.ToString(sqlDataReader[29]);
									string text44 = Conversions.ToString(sqlDataReader[30]);
									string text45 = Conversions.ToString(sqlDataReader[31]);
									DateTime dateTime5 = Conversions.ToDate(sqlDataReader[32]);
									string text46 = Conversions.ToString(sqlDataReader[33]);
									string text47 = Conversions.ToString(sqlDataReader[34]);
									string text48 = Conversions.ToString(sqlDataReader[35]);
									string text49 = Conversions.ToString(sqlDataReader[36]);
									string text50 = Conversions.ToString(sqlDataReader[37]);
									string text51 = Conversions.ToString(sqlDataReader[38]);
									string text52 = Conversions.ToString(sqlDataReader[39]);
									string text53 = Conversions.ToString(sqlDataReader[40]);
									string text54 = Conversions.ToString(sqlDataReader[41]);
									string text55 = Conversions.ToString(sqlDataReader[42]);
									string text56 = Conversions.ToString(sqlDataReader[43]);
									string text57 = Conversions.ToString(sqlDataReader[44]);
									double num61 = Conversions.ToDouble(sqlDataReader[45]);
									string text58 = Conversions.ToString(sqlDataReader[46]);
									string text59 = Conversions.ToString(sqlDataReader[47]);
									string text60 = Conversions.ToString(sqlDataReader[48]);
									string text61 = Conversions.ToString(sqlDataReader[49]);
									text4 = string.Concat(new string[]
									{
										"insert into cheqdet (\r\n                                Foliodet,\r\n                                movimiento,\r\n                                comanda,\r\n                                cantidad,\r\n                                idproducto,\r\n                                descuento,\r\n                                precio,\r\n                                impuesto1,\r\n                                impuesto2,\r\n                                impuesto3,\r\n                                preciosinimpuestos,\r\n                                tiempo,\r\n                                hora,\r\n                                modificador,\r\n                                mitad,\r\n                                comentario,\r\n                                idestacion,\r\n                                usuariodescuento,\r\n                                comentariodescuento,\r\n                                idtipodescuento,\r\n                                horaproduccion,\r\n                                idproductocompuesto,\r\n                                productocompuestoprincipal,\r\n                                preciocatalogo,\r\n                                marcar,\r\n                                idmeseroproducto,\r\n                                prioridadproduccion,\r\n                                estatuspatin,\r\n                                idcortesia,\r\n                                numerotarjeta,\r\n                                estadomonitor,\r\n                                llavemovto,\r\n                                horameserofinalizado,\r\n                                meserofinalizado,\r\n                                sistema_envio,\r\n                                idturno_cierre,\r\n                                procesado,\r\n                                promovolumen,\r\n                                iddispositivo,\r\n                                productsyncidsr,\r\n                                subtotalsrx,\r\n                                totalsrx,\r\n                                idmovtobillar,\r\n                                idlistaprecio,\r\n                                tipocambio,\r\n                                impuestoimporte3,\r\n                                estrateca_DiscountCode,\r\n                                estrateca_DiscountID,\r\n                                estrateca_DiscountAmount,\r\n                                saledetailid\r\n\r\n                               )\r\n\r\n\r\n                               Values(\r\n                                '",
										text24.ToString(),
										"',\r\n                                '",
										text25.ToString(),
										"',\r\n                                '",
										text26.ToString(),
										"',\r\n                                '",
										num53.ToString(),
										"',\r\n                                '",
										text27.ToString(),
										"',\r\n                                '",
										num54.ToString(),
										"',\r\n                                '",
										num55.ToString("N2"),
										"',\r\n                                '",
										num56.ToString("N2"),
										"',\r\n                                '",
										num57.ToString("N2"),
										"',\r\n                                '",
										num58.ToString("N2"),
										"',\r\n                                '",
										num59.ToString("N2"),
										"',\r\n                                '",
										text28,
										"',\r\n                                '",
										dateTime3.ToString(Tools.strFormatoFechaLargo),
										"',\r\n                                '",
										text29.ToString(),
										"',\r\n                                '",
										text30.ToString(),
										"',\r\n                                '",
										text31.ToString(),
										"',\r\n                                '",
										text32.ToString(),
										"',\r\n                                '",
										text33,
										"',\r\n                                '",
										text34.ToString(),
										"',\r\n                                '",
										text35.ToString(),
										"',\r\n                                '",
										dateTime4.ToString(Tools.strFormatoFechaLargo),
										"',\r\n                                '",
										text36.ToString(),
										"',\r\n                                '",
										text37.ToString(),
										"',\r\n                                '",
										num60.ToString("N2"),
										"',\r\n                                '",
										text38.ToString(),
										"',\r\n                                '",
										text39.ToString(),
										"',\r\n                                '",
										text40.ToString(),
										"',\r\n                                ",
										text41.ToString(),
										",\r\n                                '",
										text42.ToString(),
										"',\r\n                                '",
										text43.ToString(),
										"',\r\n                                '",
										text44.ToString(),
										"',\r\n                                '",
										text45.ToString(),
										"',\r\n                                '",
										dateTime5.ToString(Tools.strFormatoFechaLargo),
										"',\r\n                                '",
										text46.ToString(),
										"',\r\n                                '",
										text47.ToString(),
										"',\r\n                                '",
										text48.ToString(),
										"',\r\n                                '",
										text49.ToString(),
										"',\r\n                                '",
										text50.ToString(),
										"',\r\n                                '",
										text51.ToString(),
										"',\r\n                                '",
										text52.ToString(),
										"',\r\n                                '",
										text53.ToString(),
										"',\r\n                                '",
										text54.ToString(),
										"',\r\n                                '",
										text55.ToString(),
										"',\r\n                                '",
										text56.ToString(),
										"',\r\n                                '",
										text57.ToString(),
										"',\r\n                                '",
										num61.ToString("N2"),
										"',                            \r\n                                '",
										text58.ToString(),
										"',\r\n                                '",
										text59.ToString(),
										"',\r\n                                '",
										text60,
										"',\r\n                                '",
										text61.ToString(),
										"')"
									});
									sqlQuery.execQuery(text4);
									this.progBar.Value = 90;
								}
								text4 = "DELETE FROM FF where a = '" + text24 + "'";
								sqlQuery_Conn.execQuery_conn(text4);
							}
							sqlDataReader.Close();
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
			}
			this.progBar.Value = 100;
			this.dgvNotas.ClearSelection();
			this.progBar.Value = 0;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0006DD00 File Offset: 0x0006BF00
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
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "DELETE FROM F";
			sqlQuery_Conn.execQuery_conn(query_conn);
			base.Hide();
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0006DE14 File Offset: 0x0006C014
		private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			double num = 0.0;
			int rowIndex = e.RowIndex;
			int num2 = 400;
			int num3 = 0;
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 18;
			double num19;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false);
				if (flag2)
				{
					this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value = true;
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
					string text = Conversions.ToString(this.dgvNotas.Rows[rowIndex].Cells["id_nota"].Value);
					double num4 = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value);
					string text2 = "SELECT an from H";
					SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
					bool flag3 = sqlDataReader.Read();
					if (flag3)
					{
						this.Descomponercuentas = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					}
					bool flag4 = Operators.CompareString(this.Descomponercuentas, "1", false) == 0;
					if (flag4)
					{
						text2 = "Select Foliodet from Cheqdet where foliodet ='" + text + "' and cantidad > '1'";
						sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
						bool hasRows = sqlDataReader.HasRows;
						if (hasRows)
						{
							text2 = "Select Foliodet , movimiento , ISNULL(comanda,'') ,cantidad, idproducto , precio, descuento  ,  impuesto1 , impuesto2 , impuesto3 , preciosinimpuestos , ISNULL(tiempo,'') , hora ,\r\n                    modificador , ISNULL(mitad, 0), ISNULL(comentario, 0), idEstacion, ISNULL(usuariodescuento,'') , ISNULL(comentariodescuento,'') , ISNULL(idtipodescuento,'') , Isnull(horaproduccion,'') as horaproduccion , ISNULL(idproductocompuesto,'') , \r\n                    productocompuestoprincipal, ISNULL(preciocatalogo, 0), marcar, idmeseroproducto, ISNULL(prioridadproduccion,'') as prioridadproduccion , estatuspatin , ISNULL(idcortesia,'') , ISNULL(numerotarjeta,'') ,\r\n                    estadomonitor, ISNULL(llavemovto,'') as llavemovto , ISNULL(horameserofinalizado,'')  as horameserofinalizado , ISNULL(meserofinalizado,'') as meserofinalizado , sistema_envio ,\r\n                    ISNULL(idturno_cierre,'') , ISNULL(procesado,'0') , promovolumen , iddispositivo , productsyncidsr , subtotalsrx , totalsrx , idmovtobillar, ISNULL(idlistaprecio,'') as idlistaprecio , \r\n                    ISNULL(tipocambio,'') as tipocambio , impuestoimporte3 , estrateca_DiscountCode , estrateca_DiscountID , estrateca_DiscountAmount , ISNULL(saledetailid,0) as saledetailid\r\n                    From cheqdet Where Foliodet = '" + text + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows2 = sqlDataReader.HasRows;
							if (hasRows2)
							{
								while (sqlDataReader.Read())
								{
									int num5 = Conversions.ToInteger(sqlDataReader[3]);
									string text3 = Conversions.ToString(sqlDataReader[1]);
									string text4 = Conversions.ToString(sqlDataReader[2]);
									string text5 = Conversions.ToString(sqlDataReader[4]);
									double num6 = Conversions.ToDouble(sqlDataReader[5]);
									double num7 = Conversions.ToDouble(sqlDataReader[6]);
									double num8 = Conversions.ToDouble(sqlDataReader[7]);
									double num9 = Conversions.ToDouble(sqlDataReader[8]);
									double num10 = Conversions.ToDouble(sqlDataReader[9]);
									double num11 = Conversions.ToDouble(sqlDataReader[10]);
									string text6 = Conversions.ToString(sqlDataReader[11]);
									DateTime dateTime = Conversions.ToDate(sqlDataReader[12]);
									string text7 = Conversions.ToString(sqlDataReader[13]);
									string text8 = Conversions.ToString(sqlDataReader[14]);
									string text9 = Conversions.ToString(sqlDataReader[15]);
									string text10 = Conversions.ToString(sqlDataReader[16]);
									string text11 = Conversions.ToString(sqlDataReader[17]);
									string text12 = Conversions.ToString(sqlDataReader[18]);
									string text13 = Conversions.ToString(sqlDataReader[19]);
									DateTime dateTime2 = Conversions.ToDate(sqlDataReader[20]);
									string text14 = Conversions.ToString(sqlDataReader[21]);
									string text15 = Conversions.ToString(sqlDataReader[22]);
									double num12 = Conversions.ToDouble(sqlDataReader[23]);
									string text16 = Conversions.ToString(sqlDataReader[24]);
									string text17 = Conversions.ToString(sqlDataReader[25]);
									string text18 = Conversions.ToString(sqlDataReader[26]);
									string text19 = Conversions.ToString(sqlDataReader[27]);
									string text20 = Conversions.ToString(sqlDataReader[28]);
									string text21 = Conversions.ToString(sqlDataReader[29]);
									string text22 = Conversions.ToString(sqlDataReader[30]);
									string text23 = Conversions.ToString(sqlDataReader[31]);
									DateTime dateTime3 = Conversions.ToDate(sqlDataReader[32]);
									string text24 = Conversions.ToString(sqlDataReader[33]);
									string text25 = Conversions.ToString(sqlDataReader[34]);
									string text26 = Conversions.ToString(sqlDataReader[35]);
									string text27 = Conversions.ToString(sqlDataReader[36]);
									string text28 = Conversions.ToString(sqlDataReader[37]);
									string text29 = Conversions.ToString(sqlDataReader[38]);
									string text30 = Conversions.ToString(sqlDataReader[39]);
									string text31 = Conversions.ToString(sqlDataReader[40]);
									string text32 = Conversions.ToString(sqlDataReader[41]);
									string text33 = Conversions.ToString(sqlDataReader[42]);
									string text34 = Conversions.ToString(sqlDataReader[43]);
									string text35 = Conversions.ToString(sqlDataReader[44]);
									double num13 = Conversions.ToDouble(sqlDataReader[45]);
									string text36 = Conversions.ToString(sqlDataReader[46]);
									string text37 = Conversions.ToString(sqlDataReader[47]);
									string text38 = Conversions.ToString(sqlDataReader[48]);
									string text39 = Conversions.ToString(sqlDataReader[49]);
									text2 = string.Concat(new string[]
									{
										"insert into FF (\r\n                                a,\r\n                                b,\r\n                                c,\r\n                                d,\r\n                                e,\r\n                                f,\r\n                                g,\r\n                                h,\r\n                                i,\r\n                                j,\r\n                                k,\r\n                                l,\r\n                                m,\r\n                                n,\r\n                                o,\r\n                                p,\r\n                                q,\r\n                                r,\r\n                                s,\r\n                                t,\r\n                                u,\r\n                                w,\r\n                                x,\r\n                                y,\r\n                                z,\r\n                                aa,\r\n                                bb,\r\n                                cc,\r\n                                dd,\r\n                                ee,\r\n                                ff,\r\n                                gg,\r\n                                hh,\r\n                                ii,\r\n                                jj,\r\n                                kk,\r\n                                ll,\r\n                                mm,\r\n                                nn,\r\n                                oo,\r\n                                pp,\r\n                                qq,\r\n                                rr,\r\n                                ss,\r\n                                tt,\r\n                                uu,\r\n                                ww,\r\n                                xx,\r\n                                yy,\r\n                                zz\r\n\r\n                               )\r\n\r\n\r\n                                Values(\r\n                                '",
										text.ToString(),
										"',\r\n                                '",
										text3.ToString(),
										"',\r\n                                '",
										text4.ToString(),
										"',\r\n                                '",
										num5.ToString(),
										"',\r\n                                '",
										text5.ToString(),
										"',\r\n                                '",
										num7.ToString(),
										"',\r\n                                '",
										num6.ToString("N2"),
										"',\r\n                                '",
										num8.ToString("N2"),
										"',\r\n                                '",
										num9.ToString("N2"),
										"',\r\n                                '",
										num10.ToString("N2"),
										"',\r\n                                '",
										num11.ToString("N2"),
										"',\r\n                                '",
										text6,
										"',\r\n                                '",
										dateTime.ToString(Tools.strFormatoFechaLargo),
										"',\r\n                                '",
										text7.ToString(),
										"',\r\n                                '",
										text8.ToString(),
										"',\r\n                                '",
										text9.ToString(),
										"',\r\n                                '",
										text10.ToString(),
										"',\r\n                                '",
										text11,
										"',\r\n                                '",
										text12.ToString(),
										"',\r\n                                '",
										text13.ToString(),
										"',\r\n                                '",
										dateTime2.ToString(Tools.strFormatoFechaLargo),
										"',\r\n                                '",
										text14.ToString(),
										"',\r\n                                '",
										text15.ToString(),
										"',\r\n                                '",
										num12.ToString("N2"),
										"',\r\n                                '",
										text16.ToString(),
										"',\r\n                                '",
										text17.ToString(),
										"',\r\n                                '",
										text18.ToString(),
										"',\r\n                                ",
										text19.ToString(),
										",\r\n                                '",
										text20.ToString(),
										"',\r\n                                '",
										text21.ToString(),
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
										text26.ToString(),
										"',\r\n                                '",
										text27.ToString(),
										"',\r\n                                '",
										text28.ToString(),
										"',\r\n                                '",
										text29.ToString(),
										"',\r\n                                '",
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
										num13.ToString("N2"),
										"',                            \r\n                                '",
										text36.ToString(),
										"',\r\n                                '",
										text37.ToString(),
										"',\r\n                                '",
										text38,
										"',\r\n                                '",
										text39.ToString(),
										"')"
									});
									sqlQuery_Conn.execQuery_conn(text2);
								}
							}
						}
						sqlDataReader.Close();
						text2 = "Select Foliodet , movimiento , ISNULL(comanda,'') ,cantidad, idproducto , precio, descuento  ,  impuesto1 , impuesto2 , impuesto3 , preciosinimpuestos , ISNULL(tiempo,'') , hora ,\r\n                    modificador , ISNULL(mitad, 0), ISNULL(comentario, 0), idEstacion, ISNULL(usuariodescuento,'') , ISNULL(comentariodescuento,'') , ISNULL(idtipodescuento,'') , Isnull(horaproduccion,'') as horaproduccion , ISNULL(idproductocompuesto,'') , \r\n                    productocompuestoprincipal, ISNULL(preciocatalogo, 0), marcar, idmeseroproducto, ISNULL(prioridadproduccion,'') as prioridadproduccion , estatuspatin , ISNULL(idcortesia,'') , ISNULL(numerotarjeta,'') ,\r\n                    estadomonitor, ISNULL(llavemovto,'') as llavemovto , ISNULL(horameserofinalizado,'')  as horameserofinalizado , ISNULL(meserofinalizado,'') as meserofinalizado , sistema_envio ,\r\n                    ISNULL(idturno_cierre,'') , ISNULL(procesado,'0') , promovolumen , iddispositivo , productsyncidsr , subtotalsrx , totalsrx , idmovtobillar, ISNULL(idlistaprecio,'') as idlistaprecio , \r\n                    ISNULL(tipocambio,'') as tipocambio , impuestoimporte3 , estrateca_DiscountCode , estrateca_DiscountID , estrateca_DiscountAmount , ISNULL(saledetailid,0) as saledetailid\r\n                    From cheqdet Where Foliodet = '" + text + "' and cantidad > '1' ";
						sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
						bool hasRows3 = sqlDataReader.HasRows;
						bool hasRows5;
						checked
						{
							if (hasRows3)
							{
								while (sqlDataReader.Read())
								{
									int num5 = Conversions.ToInteger(sqlDataReader[3]);
									string text4 = Conversions.ToString(sqlDataReader[2]);
									string text5 = Conversions.ToString(sqlDataReader[4]);
									double num6 = Conversions.ToDouble(sqlDataReader[5]);
									double num7 = Conversions.ToDouble(sqlDataReader[6]);
									double num8 = Conversions.ToDouble(sqlDataReader[7]);
									double num9 = Conversions.ToDouble(sqlDataReader[8]);
									double num10 = Conversions.ToDouble(sqlDataReader[9]);
									double num11 = Conversions.ToDouble(sqlDataReader[10]);
									string text6 = Conversions.ToString(sqlDataReader[11]);
									DateTime dateTime = Conversions.ToDate(sqlDataReader[12]);
									string text7 = Conversions.ToString(sqlDataReader[13]);
									string text8 = Conversions.ToString(sqlDataReader[14]);
									string text9 = Conversions.ToString(sqlDataReader[15]);
									string text10 = Conversions.ToString(sqlDataReader[16]);
									string text11 = Conversions.ToString(sqlDataReader[17]);
									string text12 = Conversions.ToString(sqlDataReader[18]);
									string text13 = Conversions.ToString(sqlDataReader[19]);
									DateTime dateTime2 = Conversions.ToDate(sqlDataReader[20]);
									string text14 = Conversions.ToString(sqlDataReader[21]);
									string text15 = Conversions.ToString(sqlDataReader[22]);
									double num12 = Conversions.ToDouble(sqlDataReader[23]);
									string text16 = Conversions.ToString(sqlDataReader[24]);
									string text17 = Conversions.ToString(sqlDataReader[25]);
									string text18 = Conversions.ToString(sqlDataReader[26]);
									string text19 = Conversions.ToString(sqlDataReader[27]);
									string text20 = Conversions.ToString(sqlDataReader[28]);
									string text21 = Conversions.ToString(sqlDataReader[29]);
									string text22 = Conversions.ToString(sqlDataReader[30]);
									string text23 = Conversions.ToString(sqlDataReader[31]);
									DateTime dateTime3 = Conversions.ToDate(sqlDataReader[32]);
									string text24 = Conversions.ToString(sqlDataReader[33]);
									string text25 = Conversions.ToString(sqlDataReader[34]);
									string text26 = Conversions.ToString(sqlDataReader[35]);
									string text27 = Conversions.ToString(sqlDataReader[36]);
									string text28 = Conversions.ToString(sqlDataReader[37]);
									string text29 = Conversions.ToString(sqlDataReader[38]);
									string text30 = Conversions.ToString(sqlDataReader[39]);
									string text31 = Conversions.ToString(sqlDataReader[40]);
									string text32 = Conversions.ToString(sqlDataReader[41]);
									string text33 = Conversions.ToString(sqlDataReader[42]);
									string text34 = Conversions.ToString(sqlDataReader[43]);
									string text35 = Conversions.ToString(sqlDataReader[44]);
									double num13 = Conversions.ToDouble(sqlDataReader[45]);
									string text36 = Conversions.ToString(sqlDataReader[46]);
									string text37 = Conversions.ToString(sqlDataReader[47]);
									string text38 = Conversions.ToString(sqlDataReader[48]);
									string text39 = Conversions.ToString(sqlDataReader[49]);
									int num14 = num5;
									for (int i = 1; i <= num14; i++)
									{
										text2 = string.Concat(new string[]
										{
											"insert into cheqdet (\r\n                                Foliodet,\r\n                                movimiento,\r\n                                comanda,\r\n                                cantidad,\r\n                                idproducto,\r\n                                descuento,\r\n                                precio,\r\n                                impuesto1,\r\n                                impuesto2,\r\n                                impuesto3,\r\n                                preciosinimpuestos,\r\n                                tiempo,\r\n                                hora,\r\n                                modificador,\r\n                                mitad,\r\n                                comentario,\r\n                                idestacion,\r\n                                usuariodescuento,\r\n                                comentariodescuento,\r\n                                idtipodescuento,\r\n                                horaproduccion,\r\n                                idproductocompuesto,\r\n                                productocompuestoprincipal,\r\n                                preciocatalogo,\r\n                                marcar,\r\n                                idmeseroproducto,\r\n                                prioridadproduccion,\r\n                                estatuspatin,\r\n                                idcortesia,\r\n                                numerotarjeta,\r\n                                estadomonitor,\r\n                                llavemovto,\r\n                                horameserofinalizado,\r\n                                meserofinalizado,\r\n                                sistema_envio,\r\n                                idturno_cierre,\r\n                                procesado,\r\n                                promovolumen,\r\n                                iddispositivo,\r\n                                productsyncidsr,\r\n                                subtotalsrx,\r\n                                totalsrx,\r\n                                idmovtobillar,\r\n                                idlistaprecio,\r\n                                tipocambio,\r\n                                impuestoimporte3,\r\n                                estrateca_DiscountCode,\r\n                                estrateca_DiscountID,\r\n                                estrateca_DiscountAmount,\r\n                                saledetailid\r\n\r\n                               )\r\n\r\n\r\n                                Values(\r\n                                '",
											text.ToString(),
											"',\r\n                                '",
											num2.ToString(),
											"',\r\n                                '',\r\n                                '1',\r\n                                '",
											text5.ToString(),
											"',\r\n                                '",
											num7.ToString(),
											"',\r\n                                '",
											num6.ToString("N2"),
											"',\r\n                                '",
											num8.ToString("N2"),
											"',\r\n                                '",
											num9.ToString("N2"),
											"',\r\n                                '",
											num10.ToString("N2"),
											"',\r\n                                '",
											num11.ToString("N2"),
											"',\r\n                                '",
											text6,
											"',\r\n                                '",
											dateTime.ToString(Tools.strFormatoFechaLargo),
											"',\r\n                                '",
											text7.ToString(),
											"',\r\n                                '",
											text8.ToString(),
											"',\r\n                                '",
											text9.ToString(),
											"',\r\n                                '",
											text10.ToString(),
											"',\r\n                                '",
											text11,
											"',\r\n                                '",
											text12.ToString(),
											"',\r\n                                '",
											text13.ToString(),
											"',\r\n                                '",
											dateTime2.ToString(Tools.strFormatoFechaLargo),
											"',\r\n                                '",
											text14.ToString(),
											"',\r\n                                '",
											text15.ToString(),
											"',\r\n                                '",
											num12.ToString("N2"),
											"',\r\n                                '",
											text16.ToString(),
											"',\r\n                                '",
											text17.ToString(),
											"',\r\n                                '",
											text18.ToString(),
											"',\r\n                                ",
											text19.ToString(),
											",\r\n                                '",
											text20.ToString(),
											"',\r\n                                '",
											text21.ToString(),
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
											text26.ToString(),
											"',\r\n                                '",
											text27.ToString(),
											"',\r\n                                '",
											text28.ToString(),
											"',\r\n                                '",
											text29.ToString(),
											"',\r\n                                '",
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
											num13.ToString("N2"),
											"',                            \r\n                                '",
											text36.ToString(),
											"',\r\n                                '",
											text37.ToString(),
											"',\r\n                                '",
											text38,
											"',\r\n                                '",
											text39.ToString(),
											"')"
										});
										sqlQuery.execQuery(text2);
										num2++;
									}
									text2 = string.Concat(new string[]
									{
										"DELETE FROM CHEQDET WHERE Cantidad = '",
										num5.ToString(),
										"' and Foliodet = '",
										text,
										"'"
									});
									sqlQuery.execQuery(text2);
									num2 = 300;
								}
								text2 = "SELECT foliodet , movimiento , hora , idproducto , precio from cheqdet WITH (NOLOCK) where foliodet ='" + text + "' order by movimiento asc";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
								bool hasRows4 = sqlDataReader.HasRows;
								if (hasRows4)
								{
									while (sqlDataReader.Read())
									{
										string text40 = Conversions.ToString(sqlDataReader[1]);
										DateTime dateTime4 = Conversions.ToDate(sqlDataReader[2]);
										num3++;
										double num15 = Conversions.ToDouble(sqlDataReader[4]);
										string text41 = Conversions.ToString(sqlDataReader[3]);
										text2 = string.Concat(new string[]
										{
											"Set transaction isolation level read uncommitted\r\n\r\n                                                Update cheqdet set movimiento ='",
											num3.ToString(),
											"' where foliodet = '",
											text,
											"' and movimiento= '",
											text40.ToString(),
											"' and idproducto='",
											text41.ToString(),
											"' and hora = '",
											dateTime4.ToString(Tools.strFormatoFechaLargo),
											"' and Precio='",
											num15.ToString("N2"),
											"'"
										});
										sqlQuery.execQuery(text2);
									}
									num3 = 0;
								}
							}
							sqlDataReader.Close();
							text2 = string.Concat(new string[]
							{
								"SELECT Top ",
								this.CmbMovtos.Text,
								"\r\n                                foliodet,\r\n                                movimiento,\r\n                                cantidad,\r\n                                idproducto,\r\n                                precio,\r\n                             impuesto1,\r\n                             preciosinimpuestos,\r\n                                Descuento                  \r\n                                FROM cheqdet\r\n                                WHERE foliodet=  '",
								text,
								"' and precio > '0' and cantidad = 1 \r\n                                ORDER BY precio asc "
							});
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							hasRows5 = sqlDataReader.HasRows;
						}
						if (hasRows5)
						{
							while (sqlDataReader.Read())
							{
								string text42 = Conversions.ToString(sqlDataReader[0]);
								string text43 = Conversions.ToString(sqlDataReader[1]);
								string text44 = Conversions.ToString(sqlDataReader[2]);
								string text45 = Conversions.ToString(sqlDataReader[3]);
								double num16 = Conversions.ToDouble(sqlDataReader[4]);
								double num17 = Conversions.ToDouble(sqlDataReader[5]);
								double num18 = Conversions.ToDouble(sqlDataReader[6]);
								num19 = Conversions.ToDouble(sqlDataReader[7]);
								double num20 = Conversions.ToDouble(text44) * num16 - Conversions.ToDouble(text44) * num16 / 100.0 * num19;
								text2 = string.Concat(new string[]
								{
									"Insert into F (a,b,c,d,e,f,g,h,i) \r\n                                        values ('",
									text42.ToString(),
									"','",
									text43.ToString(),
									"','",
									text44.ToString(),
									"','",
									text45.ToString(),
									"','",
									num16.ToString("N2"),
									"','",
									num17.ToString("N2"),
									"','",
									num18.ToString("N2"),
									"','",
									num19.ToString("N2"),
									"','",
									num20.ToString("N2"),
									"')"
								});
								sqlQuery_Conn.execQuery_conn(text2);
							}
						}
						sqlDataReader.Close();
					}
					bool flag5 = Operators.CompareString(this.Descomponercuentas, "0", false) == 0;
					if (flag5)
					{
						text2 = string.Concat(new string[]
						{
							"SELECT Top ",
							this.CmbMovtos.Text,
							"\r\n                            foliodet,\r\n                            movimiento,\r\n                            cantidad,\r\n                            idproducto,\r\n                            precio,\r\n\t                        impuesto1,\r\n\t                        preciosinimpuestos,\r\n                            Descuento                  \r\n                            FROM cheqdet\r\n                            WHERE foliodet=",
							text,
							" and precio  > 0 \r\n                ORDER BY precio asc "
						});
						sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
						bool hasRows6 = sqlDataReader.HasRows;
						if (hasRows6)
						{
							while (sqlDataReader.Read())
							{
								string text42 = Conversions.ToString(sqlDataReader[0]);
								string text43 = Conversions.ToString(sqlDataReader[1]);
								string text44 = Conversions.ToString(sqlDataReader[2]);
								string text45 = Conversions.ToString(sqlDataReader[3]);
								double num16 = Conversions.ToDouble(sqlDataReader[4]);
								double num17 = Conversions.ToDouble(sqlDataReader[5]);
								double num18 = Conversions.ToDouble(sqlDataReader[6]);
								num19 = Conversions.ToDouble(sqlDataReader[7]);
								bool flag6 = Conversions.ToDouble(text44) > 1.0;
								bool hasRows10;
								checked
								{
									if (flag6)
									{
										text2 = "Select Foliodet from Cheqdet where foliodet ='" + text + "'";
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
										bool hasRows7 = sqlDataReader.HasRows;
										if (hasRows7)
										{
											text2 = string.Concat(new string[]
											{
												"Insert Into ",
												Tools.BaseDatos_Modulo,
												".dbo.FF ( a,\r\n                                b,\r\n                                c,\r\n                                d,\r\n                                e,\r\n                                f,\r\n                                g,\r\n                                h,\r\n                                i,\r\n                                j,\r\n                                k,\r\n                                l,\r\n                                m,\r\n                                n,\r\n                                o,\r\n                                p,\r\n                                q,\r\n                                r,\r\n                                s,\r\n                                t,\r\n                                u,\r\n                                w,\r\n                                x,\r\n                                y,\r\n                                z,\r\n                                aa,\r\n                                bb,\r\n                                cc,\r\n                                dd,\r\n                                ee,\r\n                                ff,\r\n                                gg,\r\n                                hh,\r\n                                ii,\r\n                                jj,\r\n                                kk,\r\n                                ll,\r\n                                mm,\r\n                                nn,\r\n                                oo,\r\n                                pp,\r\n                                qq,\r\n                                rr,\r\n                                ss,\r\n                                tt,\r\n                                uu,\r\n                                ww,\r\n                                xx,\r\n                                yy,\r\n                                zz)\r\n\r\n\r\n\r\n                select foliodet , movimiento , ISNULL(comanda,'') ,cantidad, idproducto , descuento, precio  ,  impuesto1 , impuesto2 , impuesto3 , preciosinimpuestos , ISNULL(tiempo,'') , hora ,\r\n                modificador , ISNULL(mitad,0) ,ISNULL(comentario,0) , idestacion , ISNULL(usuariodescuento,'') , ISNULL(comentariodescuento,'') , ISNULL(idtipodescuento,'') , Isnull(horaproduccion,'') as horaproduccion , ISNULL(idproductocompuesto,'') , \r\n                productocompuestoprincipal , ISNULL(preciocatalogo,0) , marcar , idmeseroproducto , ISNULL(prioridadproduccion,'') as prioridadproduccion , estatuspatin , ISNULL(idcortesia,'') , ISNULL(numerotarjeta,'') ,\r\n                estadomonitor , ISNULL(llavemovto,'') as llavemovto , ISNULL(horameserofinalizado,'')  as horameserofinalizado , ISNULL(meserofinalizado,'') as meserofinalizado , sistema_envio ,\r\n                ISNULL(idturno_cierre,'') , ISNULL(procesado,'0') , promovolumen , iddispositivo , productsyncidsr , subtotalsrx , totalsrx , idmovtobillar, ISNULL(idlistaprecio,'') as idlistaprecio , \r\n                ISNULL(tipocambio,'') as tipocambio , impuestoimporte3 , estrateca_DiscountCode , estrateca_DiscountID , estrateca_DiscountAmount , ISNULL(saledetailid,0) as saledetailid\r\n                from cheqdet where foliodet = '",
												text,
												"'"
											});
											sqlQuery.execQuery(text2);
										}
										sqlDataReader.Close();
										text2 = string.Concat(new string[]
										{
											"select foliodet , movimiento , ISNULL(comanda,'') ,cantidad, idproducto , precio, descuento,  impuesto1 , impuesto2 , impuesto3 , preciosinimpuestos , ISNULL(tiempo,'') , hora ,\r\n                modificador , ISNULL(mitad,0) ,ISNULL(comentario,0) , idestacion , ISNULL(usuariodescuento,'') , ISNULL(comentariodescuento,'') , ISNULL(idtipodescuento,'') , Isnull(horaproduccion,'') as horaproduccion , ISNULL(idproductocompuesto,'') , \r\n                productocompuestoprincipal , ISNULL(preciocatalogo,0) , marcar , idmeseroproducto , ISNULL(prioridadproduccion,'') as prioridadproduccion , estatuspatin , ISNULL(idcortesia,'') , ISNULL(numerotarjeta,'') ,\r\n                estadomonitor , ISNULL(llavemovto,'') as llavemovto , ISNULL(horameserofinalizado,'')  as horameserofinalizado , ISNULL(meserofinalizado,'') as meserofinalizado , sistema_envio ,\r\n                ISNULL(idturno_cierre,'') , ISNULL(procesado,'0') , promovolumen , iddispositivo , productsyncidsr , subtotalsrx , totalsrx , idmovtobillar, ISNULL(idlistaprecio,'') as idlistaprecio , \r\n                ISNULL(tipocambio,'') as tipocambio , impuestoimporte3 , estrateca_DiscountCode , estrateca_DiscountID , estrateca_DiscountAmount , ISNULL(saledetailid,0) as saledetailid\r\n                from cheqdet where foliodet = '",
											text,
											"' and movimiento ='",
											text43,
											"'"
										});
										sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
										bool hasRows8 = sqlDataReader.HasRows;
										if (hasRows8)
										{
											while (sqlDataReader.Read())
											{
												int num5 = Conversions.ToInteger(sqlDataReader[3]);
												string text4 = Conversions.ToString(sqlDataReader[2]);
												string text5 = Conversions.ToString(sqlDataReader[4]);
												double num6 = Conversions.ToDouble(sqlDataReader[5]);
												double num7 = Conversions.ToDouble(sqlDataReader[6]);
												double num8 = Conversions.ToDouble(sqlDataReader[7]);
												double num9 = Conversions.ToDouble(sqlDataReader[8]);
												double num10 = Conversions.ToDouble(sqlDataReader[9]);
												double num11 = Conversions.ToDouble(sqlDataReader[10]);
												string text6 = Conversions.ToString(sqlDataReader[11]);
												DateTime dateTime = Conversions.ToDate(sqlDataReader[12]);
												string text7 = Conversions.ToString(sqlDataReader[13]);
												string text8 = Conversions.ToString(sqlDataReader[14]);
												string text9 = Conversions.ToString(sqlDataReader[15]);
												string text10 = Conversions.ToString(sqlDataReader[16]);
												string text11 = Conversions.ToString(sqlDataReader[17]);
												string text12 = Conversions.ToString(sqlDataReader[18]);
												string text13 = Conversions.ToString(sqlDataReader[19]);
												DateTime dateTime2 = Conversions.ToDate(sqlDataReader[20]);
												string text14 = Conversions.ToString(sqlDataReader[21]);
												string text15 = Conversions.ToString(sqlDataReader[22]);
												double num12 = Conversions.ToDouble(sqlDataReader[23]);
												string text16 = Conversions.ToString(sqlDataReader[24]);
												string text17 = Conversions.ToString(sqlDataReader[25]);
												string text18 = Conversions.ToString(sqlDataReader[26]);
												string text19 = Conversions.ToString(sqlDataReader[27]);
												string text20 = Conversions.ToString(sqlDataReader[28]);
												string text21 = Conversions.ToString(sqlDataReader[29]);
												string text22 = Conversions.ToString(sqlDataReader[30]);
												string text23 = Conversions.ToString(sqlDataReader[31]);
												DateTime dateTime3 = Conversions.ToDate(sqlDataReader[32]);
												string text24 = Conversions.ToString(sqlDataReader[33]);
												string text25 = Conversions.ToString(sqlDataReader[34]);
												string text26 = Conversions.ToString(sqlDataReader[35]);
												string text27 = Conversions.ToString(sqlDataReader[36]);
												string text28 = Conversions.ToString(sqlDataReader[37]);
												string text29 = Conversions.ToString(sqlDataReader[38]);
												string text30 = Conversions.ToString(sqlDataReader[39]);
												string text31 = Conversions.ToString(sqlDataReader[40]);
												string text32 = Conversions.ToString(sqlDataReader[41]);
												string text33 = Conversions.ToString(sqlDataReader[42]);
												string text34 = Conversions.ToString(sqlDataReader[43]);
												string text35 = Conversions.ToString(sqlDataReader[44]);
												double num13 = Conversions.ToDouble(sqlDataReader[45]);
												string text36 = Conversions.ToString(sqlDataReader[46]);
												string text37 = Conversions.ToString(sqlDataReader[47]);
												string text38 = Conversions.ToString(sqlDataReader[48]);
												string text39 = Conversions.ToString(sqlDataReader[49]);
												int num21 = num5;
												for (int i = 1; i <= num21; i++)
												{
													text2 = string.Concat(new string[]
													{
														"insert into cheqdet (\r\n                                Foliodet,\r\n                                movimiento,\r\n                                comanda,\r\n                                cantidad,\r\n                                idproducto,\r\n                                descuento,\r\n                                precio,\r\n                                impuesto1,\r\n                                impuesto2,\r\n                                impuesto3,\r\n                                preciosinimpuestos,\r\n                                tiempo,\r\n                                hora,\r\n                                modificador,\r\n                                mitad,\r\n                                comentario,\r\n                                idestacion,\r\n                                usuariodescuento,\r\n                                comentariodescuento,\r\n                                idtipodescuento,\r\n                                horaproduccion,\r\n                                idproductocompuesto,\r\n                                productocompuestoprincipal,\r\n                                preciocatalogo,\r\n                                marcar,\r\n                                idmeseroproducto,\r\n                                prioridadproduccion,\r\n                                estatuspatin,\r\n                                idcortesia,\r\n                                numerotarjeta,\r\n                                estadomonitor,\r\n                                llavemovto,\r\n                                horameserofinalizado,\r\n                                meserofinalizado,\r\n                                sistema_envio,\r\n                                idturno_cierre,\r\n                                procesado,\r\n                                promovolumen,\r\n                                iddispositivo,\r\n                                productsyncidsr,\r\n                                subtotalsrx,\r\n                                totalsrx,\r\n                                idmovtobillar,\r\n                                idlistaprecio,\r\n                                tipocambio,\r\n                                impuestoimporte3,\r\n                                estrateca_DiscountCode,\r\n                                estrateca_DiscountID,\r\n                                estrateca_DiscountAmount,\r\n                                saledetailid\r\n\r\n                               )\r\n\r\n\r\n                                Values(\r\n                                '",
														text.ToString(),
														"',\r\n                                '",
														num2.ToString(),
														"',\r\n                                '',\r\n                                '1',\r\n                                '",
														text5.ToString(),
														"',\r\n                                '",
														num7.ToString(),
														"',\r\n                                '",
														num6.ToString("N2"),
														"',\r\n                                '",
														num8.ToString("N2"),
														"',\r\n                                '",
														num9.ToString("N2"),
														"',\r\n                                '",
														num10.ToString("N2"),
														"',\r\n                                '",
														num11.ToString("N2"),
														"',\r\n                                '",
														text6,
														"',\r\n                                '",
														dateTime.ToString(Tools.strFormatoFechaLargo),
														"',\r\n                                '",
														text7.ToString(),
														"',\r\n                                '",
														text8.ToString(),
														"',\r\n                                '",
														text9.ToString(),
														"',\r\n                                '",
														text10.ToString(),
														"',\r\n                                '",
														text11,
														"',\r\n                                '",
														text12.ToString(),
														"',\r\n                                '",
														text13.ToString(),
														"',\r\n                                '",
														dateTime2.ToString(Tools.strFormatoFechaLargo),
														"',\r\n                                '",
														text14.ToString(),
														"',\r\n                                '",
														text15.ToString(),
														"',\r\n                                '",
														num12.ToString("N2"),
														"',\r\n                                '",
														text16.ToString(),
														"',\r\n                                '",
														text17.ToString(),
														"',\r\n                                '",
														text18.ToString(),
														"',\r\n                                ",
														text19.ToString(),
														",\r\n                                '",
														text20.ToString(),
														"',\r\n                                '",
														text21.ToString(),
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
														text26.ToString(),
														"',\r\n                                '",
														text27.ToString(),
														"',\r\n                                '",
														text28.ToString(),
														"',\r\n                                '",
														text29.ToString(),
														"',\r\n                                '",
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
														num13.ToString("N2"),
														"',                            \r\n                                '",
														text36.ToString(),
														"',\r\n                                '",
														text37.ToString(),
														"',\r\n                                '",
														text38,
														"',\r\n                                '",
														text39.ToString(),
														"')"
													});
													sqlQuery.execQuery(text2);
													num2++;
												}
												text2 = string.Concat(new string[]
												{
													"DELETE FROM CHEQDET WHERE Cantidad = '",
													num5.ToString(),
													"' and Foliodet = '",
													text,
													"' and movimiento ='",
													text43,
													"'"
												});
												sqlQuery.execQuery(text2);
												num2 = 400;
											}
											text2 = "SELECT foliodet , movimiento , hora , idproducto , precio from cheqdet WITH (NOLOCK) where foliodet ='" + text + "' order by movimiento asc";
											sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
											bool hasRows9 = sqlDataReader.HasRows;
											if (hasRows9)
											{
												while (sqlDataReader.Read())
												{
													string text40 = Conversions.ToString(sqlDataReader[1]);
													DateTime dateTime4 = Conversions.ToDate(sqlDataReader[2]);
													num3++;
													double num15 = Conversions.ToDouble(sqlDataReader[4]);
													string text41 = Conversions.ToString(sqlDataReader[3]);
													text2 = string.Concat(new string[]
													{
														"Set transaction isolation level read uncommitted\r\n\r\n                                                Update cheqdet set movimiento ='",
														num3.ToString(),
														"' where foliodet = '",
														text,
														"' and movimiento= '",
														text40.ToString(),
														"' and idproducto='",
														text41.ToString(),
														"' and hora = '",
														dateTime4.ToString(Tools.strFormatoFechaLargo),
														"' and Precio='",
														num15.ToString("N2"),
														"'"
													});
													sqlQuery.execQuery(text2);
												}
												num3 = 0;
											}
										}
									}
									text2 = string.Concat(new string[]
									{
										"SELECT Top ",
										this.CmbMovtos.Text,
										"\r\n                            foliodet,\r\n                            movimiento,\r\n                            cantidad,\r\n                            idproducto,\r\n                            precio,\r\n\t                        impuesto1,\r\n\t                        preciosinimpuestos,\r\n                            Descuento                  \r\n                            FROM cheqdet\r\n                            WHERE foliodet=",
										text,
										" and precio  > 0 and cantidad = 1\r\n                ORDER BY precio asc "
									});
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
									this.iniciaGridCheqdet();
									hasRows10 = sqlDataReader.HasRows;
								}
								if (hasRows10)
								{
									while (sqlDataReader.Read())
									{
										text42 = Conversions.ToString(sqlDataReader[0]);
										text43 = Conversions.ToString(sqlDataReader[1]);
										text44 = Conversions.ToString(sqlDataReader[2]);
										text45 = Conversions.ToString(sqlDataReader[3]);
										num16 = Conversions.ToDouble(sqlDataReader[4]);
										num17 = Conversions.ToDouble(sqlDataReader[5]);
										num18 = Conversions.ToDouble(sqlDataReader[6]);
										num19 = Conversions.ToDouble(sqlDataReader[7]);
										double num20 = Conversions.ToDouble(text44) * num16 - Conversions.ToDouble(text44) * num16 / 100.0 * num19;
										double num22;
										num22 += num20;
										this.lblsumartotaldescontar.Text = Conversions.ToString(num20);
										text2 = string.Concat(new string[]
										{
											"Insert into F (a,b,c,d,e,f,g,h,i) \r\n                            values ('",
											text42.ToString(),
											"','",
											text43.ToString(),
											"','",
											text44.ToString(),
											"','",
											text45.ToString(),
											"' , '",
											num16.ToString(),
											"','",
											num17.ToString("N2"),
											"','",
											num18.ToString(),
											"','",
											num19.ToString("N2"),
											"','",
											num20.ToString("N2"),
											"')"
										});
										sqlQuery_Conn.execQuery_conn(text2);
										this.lblcontarfilas.Text = Conversions.ToString(this.DataGridCheqdet.Rows.Count);
									}
								}
							}
						}
					}
					sqlDataReader.Close();
					bool flag7 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)));
					if (flag7)
					{
						text2 = (("select case when sum(i) IS NULL then 0 else sum(i) end from F where a=" + text) ?? "");
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool hasRows11 = sqlDataReader.HasRows;
						if (hasRows11)
						{
							while (sqlDataReader.Read())
							{
								num = Conversions.ToDouble(sqlDataReader[0]);
								int i = this.dgvNotas.CurrentRow.Index;
								this.dgvNotas[11, i].Value = num.ToString("N2");
							}
						}
					}
					bool flag8 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false)), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)));
					double num23;
					if (flag8)
					{
						text2 = (("select case when sum(i) IS NULL then 0 else sum(i) end from F where a=" + text) ?? "");
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool hasRows12 = sqlDataReader.HasRows;
						if (hasRows12)
						{
							while (sqlDataReader.Read())
							{
								num = Conversions.ToDouble(sqlDataReader[0]);
								num23 = num - num / 100.0 * num4;
								int i = this.dgvNotas.CurrentRow.Index;
								this.dgvNotas[11, i].Value = num23.ToString("N2");
							}
						}
					}
					bool flag9 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false)));
					if (flag9)
					{
						TextBox textBox;
						(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, num.ToString())));
						(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, num.ToString())));
						(textBox = this.txttotalnuevopropinas).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
					}
					bool flag10 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)));
					if (flag10)
					{
						TextBox textBox;
						(textBox = this.txtCuentasModificar).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
						(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, num.ToString())));
						(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, num.ToString())));
					}
					bool flag11 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)));
					if (flag11)
					{
						TextBox textBox;
						(textBox = this.txtCuentasModificar).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 1.0);
						(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, num23.ToString())));
						(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, num23.ToString())));
					}
					bool flag12 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag12)
					{
						TextBox textBox;
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT i from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag13 = sqlDataReader.Read();
						if (flag13)
						{
							string text46 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text46.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows13 = sqlDataReader.HasRows;
							if (hasRows13)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag14 = Conversions.ToDouble(value) == 4.0;
									if (flag14)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag15 = Conversions.ToDouble(value) == 3.0;
									if (flag15)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag16 = Conversions.ToDouble(value) == 1.0;
									if (flag16)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag17 = Conversions.ToDouble(value) == 2.0;
									if (flag17)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
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
					bool flag18 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag18)
					{
					}
					bool flag19 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag19)
					{
						TextBox textBox;
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT i from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag20 = sqlDataReader.Read();
						if (flag20)
						{
							string text46 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text46.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows14 = sqlDataReader.HasRows;
							if (hasRows14)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag21 = Conversions.ToDouble(value) == 4.0;
									if (flag21)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag22 = Conversions.ToDouble(value) == 3.0;
									if (flag22)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag23 = Conversions.ToDouble(value) == 1.0;
									if (flag23)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag24 = Conversions.ToDouble(value) == 2.0;
									if (flag24)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
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
					bool flag25 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag25)
					{
					}
					bool flag26 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag26)
					{
						TextBox textBox;
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						text2 = "SELECT j from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag27 = sqlDataReader.Read();
						if (flag27)
						{
							string text48 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text48.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows15 = sqlDataReader.HasRows;
							if (hasRows15)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag28 = Conversions.ToDouble(value) == 4.0;
									if (flag28)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag29 = Conversions.ToDouble(value) == 3.0;
									if (flag29)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag30 = Conversions.ToDouble(value) == 1.0;
									if (flag30)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag31 = Conversions.ToDouble(value) == 2.0;
									if (flag31)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
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
					bool flag32 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag32)
					{
					}
					bool flag33 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag33)
					{
						TextBox textBox;
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						text2 = "SELECT j from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag34 = sqlDataReader.Read();
						if (flag34)
						{
							string text48 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text48.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows16 = sqlDataReader.HasRows;
							if (hasRows16)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag35 = Conversions.ToDouble(value) == 4.0;
									if (flag35)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag36 = Conversions.ToDouble(value) == 3.0;
									if (flag36)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag37 = Conversions.ToDouble(value) == 1.0;
									if (flag37)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag38 = Conversions.ToDouble(value) == 2.0;
									if (flag38)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
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
					bool flag39 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag39)
					{
					}
					bool flag40 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag40)
					{
						TextBox textBox;
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						text2 = "SELECT k from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag41 = sqlDataReader.Read();
						if (flag41)
						{
							string text49 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text49.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows17 = sqlDataReader.HasRows;
							if (hasRows17)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag42 = Conversions.ToDouble(value) == 4.0;
									if (flag42)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag43 = Conversions.ToDouble(value) == 3.0;
									if (flag43)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag44 = Conversions.ToDouble(value) == 1.0;
									if (flag44)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag45 = Conversions.ToDouble(value) == 2.0;
									if (flag45)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
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
					bool flag46 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag46)
					{
					}
					bool flag47 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag47)
					{
						TextBox textBox;
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						text2 = "SELECT k from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag48 = sqlDataReader.Read();
						if (flag48)
						{
							string text49 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text49.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows18 = sqlDataReader.HasRows;
							if (hasRows18)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag49 = Conversions.ToDouble(value) == 4.0;
									if (flag49)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag50 = Conversions.ToDouble(value) == 3.0;
									if (flag50)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag51 = Conversions.ToDouble(value) == 1.0;
									if (flag51)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag52 = Conversions.ToDouble(value) == 2.0;
									if (flag52)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
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
					bool flag53 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag53)
					{
					}
					bool flag54 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag54)
					{
						TextBox textBox;
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						text2 = "SELECT l from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag55 = sqlDataReader.Read();
						if (flag55)
						{
							string text50 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text50.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows19 = sqlDataReader.HasRows;
							if (hasRows19)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag56 = Conversions.ToDouble(value) == 4.0;
									if (flag56)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag57 = Conversions.ToDouble(value) == 3.0;
									if (flag57)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag58 = Conversions.ToDouble(value) == 1.0;
									if (flag58)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag59 = Conversions.ToDouble(value) == 2.0;
									if (flag59)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
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
					bool flag60 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag60)
					{
					}
					bool flag61 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag61)
					{
						TextBox textBox;
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						text2 = "SELECT l from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag62 = sqlDataReader.Read();
						if (flag62)
						{
							string text50 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text50.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows20 = sqlDataReader.HasRows;
							if (hasRows20)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag63 = Conversions.ToDouble(value) == 4.0;
									if (flag63)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag64 = Conversions.ToDouble(value) == 3.0;
									if (flag64)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag65 = Conversions.ToDouble(value) == 1.0;
									if (flag65)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag66 = Conversions.ToDouble(value) == 2.0;
									if (flag66)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
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
					bool flag67 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag67)
					{
					}
					bool flag68 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag68)
					{
						TextBox textBox;
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag69 = sqlDataReader.Read();
						if (flag69)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows21 = sqlDataReader.HasRows;
							if (hasRows21)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag70 = Conversions.ToDouble(value) == 4.0;
									if (flag70)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag71 = Conversions.ToDouble(value) == 3.0;
									if (flag71)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag72 = Conversions.ToDouble(value) == 1.0;
									if (flag72)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag73 = Conversions.ToDouble(value) == 2.0;
									if (flag73)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
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
					bool flag74 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag74)
					{
					}
					bool flag75 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag75)
					{
						TextBox textBox;
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag76 = sqlDataReader.Read();
						if (flag76)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows22 = sqlDataReader.HasRows;
							if (hasRows22)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag77 = Conversions.ToDouble(value) == 4.0;
									if (flag77)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag78 = Conversions.ToDouble(value) == 3.0;
									if (flag78)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag79 = Conversions.ToDouble(value) == 1.0;
									if (flag79)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag80 = Conversions.ToDouble(value) == 2.0;
									if (flag80)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
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
					bool flag81 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag81)
					{
					}
					bool flag82 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag82)
					{
						TextBox textBox;
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag83 = sqlDataReader.Read();
						if (flag83)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows23 = sqlDataReader.HasRows;
							if (hasRows23)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag84 = Conversions.ToDouble(value) == 4.0;
									if (flag84)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag85 = Conversions.ToDouble(value) == 3.0;
									if (flag85)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag86 = Conversions.ToDouble(value) == 1.0;
									if (flag86)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag87 = Conversions.ToDouble(value) == 2.0;
									if (flag87)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
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
					bool flag88 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag88)
					{
					}
					bool flag89 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag89)
					{
						TextBox textBox;
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag90 = sqlDataReader.Read();
						if (flag90)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows24 = sqlDataReader.HasRows;
							if (hasRows24)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag91 = Conversions.ToDouble(value) == 4.0;
									if (flag91)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag92 = Conversions.ToDouble(value) == 3.0;
									if (flag92)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag93 = Conversions.ToDouble(value) == 1.0;
									if (flag93)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag94 = Conversions.ToDouble(value) == 2.0;
									if (flag94)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
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
					bool flag95 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag95)
					{
					}
					bool flag96 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag96)
					{
						TextBox textBox;
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag97 = sqlDataReader.Read();
						if (flag97)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows25 = sqlDataReader.HasRows;
							if (hasRows25)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag98 = Conversions.ToDouble(value) == 4.0;
									if (flag98)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag99 = Conversions.ToDouble(value) == 3.0;
									if (flag99)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag100 = Conversions.ToDouble(value) == 1.0;
									if (flag100)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag101 = Conversions.ToDouble(value) == 2.0;
									if (flag101)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
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
					bool flag102 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag102)
					{
					}
					bool flag103 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag103)
					{
						TextBox textBox;
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag104 = sqlDataReader.Read();
						if (flag104)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows26 = sqlDataReader.HasRows;
							if (hasRows26)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag105 = Conversions.ToDouble(value) == 4.0;
									if (flag105)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag106 = Conversions.ToDouble(value) == 3.0;
									if (flag106)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag107 = Conversions.ToDouble(value) == 1.0;
									if (flag107)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag108 = Conversions.ToDouble(value) == 2.0;
									if (flag108)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
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
					bool flag109 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag109)
					{
					}
					bool flag110 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag110)
					{
						TextBox textBox;
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag111 = sqlDataReader.Read();
						if (flag111)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows27 = sqlDataReader.HasRows;
							if (hasRows27)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag112 = Conversions.ToDouble(value) == 4.0;
									if (flag112)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag113 = Conversions.ToDouble(value) == 3.0;
									if (flag113)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag114 = Conversions.ToDouble(value) == 1.0;
									if (flag114)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag115 = Conversions.ToDouble(value) == 2.0;
									if (flag115)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
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
					bool flag116 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag116)
					{
					}
					bool flag117 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag117)
					{
						TextBox textBox;
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag118 = sqlDataReader.Read();
						if (flag118)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows28 = sqlDataReader.HasRows;
							if (hasRows28)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag119 = Conversions.ToDouble(value) == 4.0;
									if (flag119)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag120 = Conversions.ToDouble(value) == 3.0;
									if (flag120)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag121 = Conversions.ToDouble(value) == 1.0;
									if (flag121)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag122 = Conversions.ToDouble(value) == 2.0;
									if (flag122)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
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
					bool flag123 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag123)
					{
					}
					bool flag124 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag124)
					{
						TextBox textBox;
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag125 = sqlDataReader.Read();
						if (flag125)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows29 = sqlDataReader.HasRows;
							if (hasRows29)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag126 = Conversions.ToDouble(value) == 4.0;
									if (flag126)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag127 = Conversions.ToDouble(value) == 3.0;
									if (flag127)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag128 = Conversions.ToDouble(value) == 1.0;
									if (flag128)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag129 = Conversions.ToDouble(value) == 2.0;
									if (flag129)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
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
					bool flag130 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag130)
					{
					}
					bool flag131 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag131)
					{
						TextBox textBox;
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag132 = sqlDataReader.Read();
						if (flag132)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows30 = sqlDataReader.HasRows;
							if (hasRows30)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag133 = Conversions.ToDouble(value) == 4.0;
									if (flag133)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag134 = Conversions.ToDouble(value) == 3.0;
									if (flag134)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag135 = Conversions.ToDouble(value) == 1.0;
									if (flag135)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag136 = Conversions.ToDouble(value) == 2.0;
									if (flag136)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
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
					bool flag137 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag137)
					{
					}
					bool flag138 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag138)
					{
						TextBox textBox;
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag139 = sqlDataReader.Read();
						if (flag139)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows31 = sqlDataReader.HasRows;
							if (hasRows31)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag140 = Conversions.ToDouble(value) == 4.0;
									if (flag140)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag141 = Conversions.ToDouble(value) == 3.0;
									if (flag141)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag142 = Conversions.ToDouble(value) == 1.0;
									if (flag142)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
									}
									bool flag143 = Conversions.ToDouble(value) == 2.0;
									if (flag143)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num.ToString()));
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
					bool flag144 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag144)
					{
					}
					bool flag145 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag145)
					{
						TextBox textBox;
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag146 = sqlDataReader.Read();
						if (flag146)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows32 = sqlDataReader.HasRows;
							if (hasRows32)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag147 = Conversions.ToDouble(value) == 4.0;
									if (flag147)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag148 = Conversions.ToDouble(value) == 3.0;
									if (flag148)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag149 = Conversions.ToDouble(value) == 1.0;
									if (flag149)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
									}
									bool flag150 = Conversions.ToDouble(value) == 2.0;
									if (flag150)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num23.ToString()));
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
					bool flag151 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, true, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag151)
					{
					}
					bool flag152 = !this.chkEliminaProp.Checked;
					if (flag152)
					{
						Label lblpropinascortenuevo;
						(lblpropinascortenuevo = this.lblpropinascortenuevo).Text = Conversions.ToString(Operators.SubtractObject(lblpropinascortenuevo.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
						TextBox textBox;
						(textBox = this.txttotalnuevopropinas).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
					}
					else
					{
						this.lblpropinascortenuevo.Text = "$ 0.00";
						this.txttotalnuevopropinas.Text = "$ 0.00";
					}
					bool flag153 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Facturado"].Value, "Si", false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)));
					if (flag153)
					{
						TextBox textBox;
						(textBox = this.txtVentaFacturada).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, num)));
					}
				}
				else
				{
					this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value = false;
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
					this.dgvNotas.Rows[rowIndex].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.875f, FontStyle.Regular);
					TextBox textBox;
					(textBox = this.txtCuentasModificar).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) - 1.0);
					double num24 = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells[11].Value);
					string text52 = Conversions.ToString(this.dgvNotas.Rows[rowIndex].Cells["id_nota"].Value);
					string text2 = "SELECT an from H";
					SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
					bool flag154 = sqlDataReader.Read();
					if (flag154)
					{
						this.Descomponercuentas = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					}
					text2 = "Delete from F where a='" + text52 + "' and j='0'";
					sqlQuery_Conn.execQuery_conn(text2);
					bool flag155 = Operators.CompareString(this.Descomponercuentas, "1", false) == 0;
					if (flag155)
					{
						text2 = "select a , b , c ,d, e , f , g ,  h , i , j , k , l , m ,\r\n                n , o ,p , q , r , s , t , u, w , \r\n                x , y , z , aa , bb , cc , dd , ee ,\r\n                ff ,gg ,hh, ii , kk ,\r\n                kk , ll , mm , nn , oo , pp , qq , rr, ss , \r\n               tt , uu, ww , xx , yy ,zz\r\n                from FF where a = '" + text52 + "' order by b asc";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool hasRows33 = sqlDataReader.HasRows;
						if (hasRows33)
						{
							text2 = "Delete from Cheqdet where Foliodet = '" + text52 + "'";
							sqlQuery.execQuery(text2);
							while (sqlDataReader.Read())
							{
								int num5 = Conversions.ToInteger(sqlDataReader[3]);
								string text3 = Conversions.ToString(sqlDataReader[1]);
								string text4 = Conversions.ToString(sqlDataReader[2]);
								string text5 = Conversions.ToString(sqlDataReader[4]);
								double num7 = Conversions.ToDouble(sqlDataReader[5]);
								double num6 = Conversions.ToDouble(sqlDataReader[6]);
								double num8 = Conversions.ToDouble(sqlDataReader[7]);
								double num9 = Conversions.ToDouble(sqlDataReader[8]);
								double num10 = Conversions.ToDouble(sqlDataReader[9]);
								double num11 = Conversions.ToDouble(sqlDataReader[10]);
								string text6 = Conversions.ToString(sqlDataReader[11]);
								DateTime dateTime = Conversions.ToDate(sqlDataReader[12]);
								string text7 = Conversions.ToString(sqlDataReader[13]);
								string text8 = Conversions.ToString(sqlDataReader[14]);
								string text9 = Conversions.ToString(sqlDataReader[15]);
								string text10 = Conversions.ToString(sqlDataReader[16]);
								string text11 = Conversions.ToString(sqlDataReader[17]);
								string text12 = Conversions.ToString(sqlDataReader[18]);
								string text13 = Conversions.ToString(sqlDataReader[19]);
								DateTime dateTime2 = Conversions.ToDate(sqlDataReader[20]);
								string text14 = Conversions.ToString(sqlDataReader[21]);
								string text15 = Conversions.ToString(sqlDataReader[22]);
								double num12 = Conversions.ToDouble(sqlDataReader[23]);
								string text16 = Conversions.ToString(sqlDataReader[24]);
								string text17 = Conversions.ToString(sqlDataReader[25]);
								string text18 = Conversions.ToString(sqlDataReader[26]);
								string text19 = Conversions.ToString(sqlDataReader[27]);
								string text20 = Conversions.ToString(sqlDataReader[28]);
								string text21 = Conversions.ToString(sqlDataReader[29]);
								string text22 = Conversions.ToString(sqlDataReader[30]);
								string text23 = Conversions.ToString(sqlDataReader[31]);
								DateTime dateTime3 = Conversions.ToDate(sqlDataReader[32]);
								string text24 = Conversions.ToString(sqlDataReader[33]);
								string text25 = Conversions.ToString(sqlDataReader[34]);
								string text26 = Conversions.ToString(sqlDataReader[35]);
								string text27 = Conversions.ToString(sqlDataReader[36]);
								string text28 = Conversions.ToString(sqlDataReader[37]);
								string text29 = Conversions.ToString(sqlDataReader[38]);
								string text30 = Conversions.ToString(sqlDataReader[39]);
								string text31 = Conversions.ToString(sqlDataReader[40]);
								string text32 = Conversions.ToString(sqlDataReader[41]);
								string text33 = Conversions.ToString(sqlDataReader[42]);
								string text34 = Conversions.ToString(sqlDataReader[43]);
								string text35 = Conversions.ToString(sqlDataReader[44]);
								double num13 = Conversions.ToDouble(sqlDataReader[45]);
								string text36 = Conversions.ToString(sqlDataReader[46]);
								string text37 = Conversions.ToString(sqlDataReader[47]);
								string text38 = Conversions.ToString(sqlDataReader[48]);
								string text39 = Conversions.ToString(sqlDataReader[49]);
								text2 = string.Concat(new string[]
								{
									"insert into cheqdet (\r\n                                Foliodet,\r\n                                movimiento,\r\n                                comanda,\r\n                                cantidad,\r\n                                idproducto,\r\n                                descuento,\r\n                                precio,\r\n                                impuesto1,\r\n                                impuesto2,\r\n                                impuesto3,\r\n                                preciosinimpuestos,\r\n                                tiempo,\r\n                                hora,\r\n                                modificador,\r\n                                mitad,\r\n                                comentario,\r\n                                idestacion,\r\n                                usuariodescuento,\r\n                                comentariodescuento,\r\n                                idtipodescuento,\r\n                                horaproduccion,\r\n                                idproductocompuesto,\r\n                                productocompuestoprincipal,\r\n                                preciocatalogo,\r\n                                marcar,\r\n                                idmeseroproducto,\r\n                                prioridadproduccion,\r\n                                estatuspatin,\r\n                                idcortesia,\r\n                                numerotarjeta,\r\n                                estadomonitor,\r\n                                llavemovto,\r\n                                horameserofinalizado,\r\n                                meserofinalizado,\r\n                                sistema_envio,\r\n                                idturno_cierre,\r\n                                procesado,\r\n                                promovolumen,\r\n                                iddispositivo,\r\n                                productsyncidsr,\r\n                                subtotalsrx,\r\n                                totalsrx,\r\n                                idmovtobillar,\r\n                                idlistaprecio,\r\n                                tipocambio,\r\n                                impuestoimporte3,\r\n                                estrateca_DiscountCode,\r\n                                estrateca_DiscountID,\r\n                                estrateca_DiscountAmount,\r\n                                saledetailid\r\n\r\n                               )\r\n\r\n\r\n                               Values(\r\n                                '",
									text52.ToString(),
									"',\r\n                                '",
									text3.ToString(),
									"',\r\n                                '",
									text4.ToString(),
									"',\r\n                                '",
									num5.ToString(),
									"',\r\n                                '",
									text5.ToString(),
									"',\r\n                                '",
									num7.ToString(),
									"',\r\n                                '",
									num6.ToString("N2"),
									"',\r\n                                '",
									num8.ToString("N2"),
									"',\r\n                                '",
									num9.ToString("N2"),
									"',\r\n                                '",
									num10.ToString("N2"),
									"',\r\n                                '",
									num11.ToString("N2"),
									"',\r\n                                '",
									text6,
									"',\r\n                                '",
									dateTime.ToString(Tools.strFormatoFechaLargo),
									"',\r\n                                '",
									text7.ToString(),
									"',\r\n                                '",
									text8.ToString(),
									"',\r\n                                '",
									text9.ToString(),
									"',\r\n                                '",
									text10.ToString(),
									"',\r\n                                '",
									text11,
									"',\r\n                                '",
									text12.ToString(),
									"',\r\n                                '",
									text13.ToString(),
									"',\r\n                                '",
									dateTime2.ToString(Tools.strFormatoFechaLargo),
									"',\r\n                                '",
									text14.ToString(),
									"',\r\n                                '",
									text15.ToString(),
									"',\r\n                                '",
									num12.ToString("N2"),
									"',\r\n                                '",
									text16.ToString(),
									"',\r\n                                '",
									text17.ToString(),
									"',\r\n                                '",
									text18.ToString(),
									"',\r\n                                ",
									text19.ToString(),
									",\r\n                                '",
									text20.ToString(),
									"',\r\n                                '",
									text21.ToString(),
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
									text26.ToString(),
									"',\r\n                                '",
									text27.ToString(),
									"',\r\n                                '",
									text28.ToString(),
									"',\r\n                                '",
									text29.ToString(),
									"',\r\n                                '",
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
									num13.ToString("N2"),
									"',                            \r\n                                '",
									text36.ToString(),
									"',\r\n                                '",
									text37.ToString(),
									"',\r\n                                '",
									text38,
									"',\r\n                                '",
									text39.ToString(),
									"')"
								});
								sqlQuery.execQuery(text2);
							}
							text2 = "DELETE FROM FF where a = '" + text52 + "'";
							sqlQuery_Conn.execQuery_conn(text2);
						}
						sqlDataReader.Close();
					}
					bool flag156 = Operators.CompareString(this.Descomponercuentas, "0", false) == 0;
					if (flag156)
					{
						text2 = "select a , b , c ,d, e , f , g ,  h , i , j , k , l , m ,\r\n                n , o ,p , q , r , s , t , u, w , \r\n                x , y , z , aa , bb , cc , dd , ee ,\r\n                ff ,gg ,hh, ii , kk ,\r\n                kk , ll , mm , nn , oo , pp , qq , rr, ss , \r\n               tt , uu, ww , xx , yy ,zz\r\n                from FF where a = '" + text52 + "' order by b asc";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool hasRows34 = sqlDataReader.HasRows;
						if (hasRows34)
						{
							text2 = "Delete from Cheqdet where Foliodet = '" + text52 + "'";
							sqlQuery.execQuery(text2);
							while (sqlDataReader.Read())
							{
								int num5 = Conversions.ToInteger(sqlDataReader[3]);
								string text3 = Conversions.ToString(sqlDataReader[1]);
								string text4 = Conversions.ToString(sqlDataReader[2]);
								string text5 = Conversions.ToString(sqlDataReader[4]);
								double num7 = Conversions.ToDouble(sqlDataReader[5]);
								double num6 = Conversions.ToDouble(sqlDataReader[6]);
								double num8 = Conversions.ToDouble(sqlDataReader[7]);
								double num9 = Conversions.ToDouble(sqlDataReader[8]);
								double num10 = Conversions.ToDouble(sqlDataReader[9]);
								double num11 = Conversions.ToDouble(sqlDataReader[10]);
								string text6 = Conversions.ToString(sqlDataReader[11]);
								DateTime dateTime = Conversions.ToDate(sqlDataReader[12]);
								string text7 = Conversions.ToString(sqlDataReader[13]);
								string text8 = Conversions.ToString(sqlDataReader[14]);
								string text9 = Conversions.ToString(sqlDataReader[15]);
								string text10 = Conversions.ToString(sqlDataReader[16]);
								string text11 = Conversions.ToString(sqlDataReader[17]);
								string text12 = Conversions.ToString(sqlDataReader[18]);
								string text13 = Conversions.ToString(sqlDataReader[19]);
								DateTime dateTime2 = Conversions.ToDate(sqlDataReader[20]);
								string text14 = Conversions.ToString(sqlDataReader[21]);
								string text15 = Conversions.ToString(sqlDataReader[22]);
								double num12 = Conversions.ToDouble(sqlDataReader[23]);
								string text16 = Conversions.ToString(sqlDataReader[24]);
								string text17 = Conversions.ToString(sqlDataReader[25]);
								string text18 = Conversions.ToString(sqlDataReader[26]);
								string text19 = Conversions.ToString(sqlDataReader[27]);
								string text20 = Conversions.ToString(sqlDataReader[28]);
								string text21 = Conversions.ToString(sqlDataReader[29]);
								string text22 = Conversions.ToString(sqlDataReader[30]);
								string text23 = Conversions.ToString(sqlDataReader[31]);
								DateTime dateTime3 = Conversions.ToDate(sqlDataReader[32]);
								string text24 = Conversions.ToString(sqlDataReader[33]);
								string text25 = Conversions.ToString(sqlDataReader[34]);
								string text26 = Conversions.ToString(sqlDataReader[35]);
								string text27 = Conversions.ToString(sqlDataReader[36]);
								string text28 = Conversions.ToString(sqlDataReader[37]);
								string text29 = Conversions.ToString(sqlDataReader[38]);
								string text30 = Conversions.ToString(sqlDataReader[39]);
								string text31 = Conversions.ToString(sqlDataReader[40]);
								string text32 = Conversions.ToString(sqlDataReader[41]);
								string text33 = Conversions.ToString(sqlDataReader[42]);
								string text34 = Conversions.ToString(sqlDataReader[43]);
								string text35 = Conversions.ToString(sqlDataReader[44]);
								double num13 = Conversions.ToDouble(sqlDataReader[45]);
								string text36 = Conversions.ToString(sqlDataReader[46]);
								string text37 = Conversions.ToString(sqlDataReader[47]);
								string text38 = Conversions.ToString(sqlDataReader[48]);
								string text39 = Conversions.ToString(sqlDataReader[49]);
								text2 = string.Concat(new string[]
								{
									"insert into cheqdet (\r\n                                Foliodet,\r\n                                movimiento,\r\n                                comanda,\r\n                                cantidad,\r\n                                idproducto,\r\n                                descuento,\r\n                                precio,\r\n                                impuesto1,\r\n                                impuesto2,\r\n                                impuesto3,\r\n                                preciosinimpuestos,\r\n                                tiempo,\r\n                                hora,\r\n                                modificador,\r\n                                mitad,\r\n                                comentario,\r\n                                idestacion,\r\n                                usuariodescuento,\r\n                                comentariodescuento,\r\n                                idtipodescuento,\r\n                                horaproduccion,\r\n                                idproductocompuesto,\r\n                                productocompuestoprincipal,\r\n                                preciocatalogo,\r\n                                marcar,\r\n                                idmeseroproducto,\r\n                                prioridadproduccion,\r\n                                estatuspatin,\r\n                                idcortesia,\r\n                                numerotarjeta,\r\n                                estadomonitor,\r\n                                llavemovto,\r\n                                horameserofinalizado,\r\n                                meserofinalizado,\r\n                                sistema_envio,\r\n                                idturno_cierre,\r\n                                procesado,\r\n                                promovolumen,\r\n                                iddispositivo,\r\n                                productsyncidsr,\r\n                                subtotalsrx,\r\n                                totalsrx,\r\n                                idmovtobillar,\r\n                                idlistaprecio,\r\n                                tipocambio,\r\n                                impuestoimporte3,\r\n                                estrateca_DiscountCode,\r\n                                estrateca_DiscountID,\r\n                                estrateca_DiscountAmount,\r\n                                saledetailid\r\n\r\n                               )\r\n\r\n\r\n                               Values(\r\n                                '",
									text52.ToString(),
									"',\r\n                                '",
									text3.ToString(),
									"',\r\n                                '",
									text4.ToString(),
									"',\r\n                                '",
									num5.ToString(),
									"',\r\n                                '",
									text5.ToString(),
									"',\r\n                                '",
									num7.ToString(),
									"',\r\n                                '",
									num6.ToString("N2"),
									"',\r\n                                '",
									num8.ToString("N2"),
									"',\r\n                                '",
									num9.ToString("N2"),
									"',\r\n                                '",
									num10.ToString("N2"),
									"',\r\n                                '",
									num11.ToString("N2"),
									"',\r\n                                '",
									text6,
									"',\r\n                                '",
									dateTime.ToString(Tools.strFormatoFechaLargo),
									"',\r\n                                '",
									text7.ToString(),
									"',\r\n                                '",
									text8.ToString(),
									"',\r\n                                '",
									text9.ToString(),
									"',\r\n                                '",
									text10.ToString(),
									"',\r\n                                '",
									text11,
									"',\r\n                                '",
									text12.ToString(),
									"',\r\n                                '",
									text13.ToString(),
									"',\r\n                                '",
									dateTime2.ToString(Tools.strFormatoFechaLargo),
									"',\r\n                                '",
									text14.ToString(),
									"',\r\n                                '",
									text15.ToString(),
									"',\r\n                                '",
									num12.ToString("N2"),
									"',\r\n                                '",
									text16.ToString(),
									"',\r\n                                '",
									text17.ToString(),
									"',\r\n                                '",
									text18.ToString(),
									"',\r\n                                ",
									text19.ToString(),
									",\r\n                                '",
									text20.ToString(),
									"',\r\n                                '",
									text21.ToString(),
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
									text26.ToString(),
									"',\r\n                                '",
									text27.ToString(),
									"',\r\n                                '",
									text28.ToString(),
									"',\r\n                                '",
									text29.ToString(),
									"',\r\n                                '",
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
									num13.ToString("N2"),
									"',                            \r\n                                '",
									text36.ToString(),
									"',\r\n                                '",
									text37.ToString(),
									"',\r\n                                '",
									text38,
									"',\r\n                                '",
									text39.ToString(),
									"')"
								});
								sqlQuery.execQuery(text2);
							}
							text2 = "DELETE FROM FF where a = '" + text52 + "'";
							sqlQuery_Conn.execQuery_conn(text2);
						}
						sqlDataReader.Close();
					}
					bool flag157 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)));
					if (flag157)
					{
						(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, num24.ToString())));
						(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, num24.ToString())));
						(textBox = this.txttotalnuevopropinas).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
					}
					bool flag158 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)));
					if (flag158)
					{
						(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, num24.ToString())));
						(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, num24.ToString())));
						(textBox = this.txttotalnuevopropinas).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
					}
					bool flag159 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "Si", false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false)));
					if (flag159)
					{
						(textBox = this.txtImpNuevo).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, num24.ToString())));
						(textBox = this.txtDifImporte).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, num24.ToString())));
						(textBox = this.txttotalnuevopropinas).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
					}
					bool flag160 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag160)
					{
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT i from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag161 = sqlDataReader.Read();
						if (flag161)
						{
							string text46 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text46.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows35 = sqlDataReader.HasRows;
							if (hasRows35)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag162 = Conversions.ToDouble(value) == 4.0;
									if (flag162)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag163 = Conversions.ToDouble(value) == 3.0;
									if (flag163)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag164 = Conversions.ToDouble(value) == 1.0;
									if (flag164)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag165 = Conversions.ToDouble(value) == 2.0;
									if (flag165)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag166 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag166)
					{
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT i from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag167 = sqlDataReader.Read();
						if (flag167)
						{
							string text46 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text46.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows36 = sqlDataReader.HasRows;
							if (hasRows36)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag168 = Conversions.ToDouble(value) == 4.0;
									if (flag168)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag169 = Conversions.ToDouble(value) == 3.0;
									if (flag169)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag170 = Conversions.ToDouble(value) == 1.0;
									if (flag170)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag171 = Conversions.ToDouble(value) == 2.0;
									if (flag171)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag172 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag172)
					{
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						text2 = "SELECT j from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag173 = sqlDataReader.Read();
						if (flag173)
						{
							string text48 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text48.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows37 = sqlDataReader.HasRows;
							if (hasRows37)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag174 = Conversions.ToDouble(value) == 4.0;
									if (flag174)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag175 = Conversions.ToDouble(value) == 3.0;
									if (flag175)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag176 = Conversions.ToDouble(value) == 1.0;
									if (flag176)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag177 = Conversions.ToDouble(value) == 2.0;
									if (flag177)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag178 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag178)
					{
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						text2 = "SELECT j from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag179 = sqlDataReader.Read();
						if (flag179)
						{
							string text48 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text48.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows38 = sqlDataReader.HasRows;
							if (hasRows38)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag180 = Conversions.ToDouble(value) == 4.0;
									if (flag180)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag181 = Conversions.ToDouble(value) == 3.0;
									if (flag181)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag182 = Conversions.ToDouble(value) == 1.0;
									if (flag182)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag183 = Conversions.ToDouble(value) == 2.0;
									if (flag183)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag184 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag184)
					{
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						text2 = "SELECT l from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag185 = sqlDataReader.Read();
						if (flag185)
						{
							string text50 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text50.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows39 = sqlDataReader.HasRows;
							if (hasRows39)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag186 = Conversions.ToDouble(value) == 4.0;
									if (flag186)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag187 = Conversions.ToDouble(value) == 3.0;
									if (flag187)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag188 = Conversions.ToDouble(value) == 1.0;
									if (flag188)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag189 = Conversions.ToDouble(value) == 2.0;
									if (flag189)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag190 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag190)
					{
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						text2 = "SELECT l from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag191 = sqlDataReader.Read();
						if (flag191)
						{
							string text50 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text50.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows40 = sqlDataReader.HasRows;
							if (hasRows40)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag192 = Conversions.ToDouble(value) == 4.0;
									if (flag192)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag193 = Conversions.ToDouble(value) == 3.0;
									if (flag193)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag194 = Conversions.ToDouble(value) == 1.0;
									if (flag194)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag195 = Conversions.ToDouble(value) == 2.0;
									if (flag195)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag196 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag196)
					{
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						text2 = "SELECT k from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag197 = sqlDataReader.Read();
						if (flag197)
						{
							string text49 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text49.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows41 = sqlDataReader.HasRows;
							if (hasRows41)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag198 = Conversions.ToDouble(value) == 4.0;
									if (flag198)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag199 = Conversions.ToDouble(value) == 3.0;
									if (flag199)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag200 = Conversions.ToDouble(value) == 1.0;
									if (flag200)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag201 = Conversions.ToDouble(value) == 2.0;
									if (flag201)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag202 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag202)
					{
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						text2 = "SELECT k from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag203 = sqlDataReader.Read();
						if (flag203)
						{
							string text49 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text49.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows42 = sqlDataReader.HasRows;
							if (hasRows42)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag204 = Conversions.ToDouble(value) == 4.0;
									if (flag204)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag205 = Conversions.ToDouble(value) == 3.0;
									if (flag205)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag206 = Conversions.ToDouble(value) == 1.0;
									if (flag206)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag207 = Conversions.ToDouble(value) == 2.0;
									if (flag207)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag208 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag208)
					{
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag209 = sqlDataReader.Read();
						if (flag209)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows43 = sqlDataReader.HasRows;
							if (hasRows43)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag210 = Conversions.ToDouble(value) == 4.0;
									if (flag210)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag211 = Conversions.ToDouble(value) == 3.0;
									if (flag211)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag212 = Conversions.ToDouble(value) == 1.0;
									if (flag212)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag213 = Conversions.ToDouble(value) == 2.0;
									if (flag213)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag214 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag214)
					{
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag215 = sqlDataReader.Read();
						if (flag215)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows44 = sqlDataReader.HasRows;
							if (hasRows44)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag216 = Conversions.ToDouble(value) == 4.0;
									if (flag216)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag217 = Conversions.ToDouble(value) == 3.0;
									if (flag217)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag218 = Conversions.ToDouble(value) == 1.0;
									if (flag218)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag219 = Conversions.ToDouble(value) == 2.0;
									if (flag219)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag220 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag220)
					{
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag221 = sqlDataReader.Read();
						if (flag221)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows45 = sqlDataReader.HasRows;
							if (hasRows45)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag222 = Conversions.ToDouble(value) == 4.0;
									if (flag222)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag223 = Conversions.ToDouble(value) == 3.0;
									if (flag223)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag224 = Conversions.ToDouble(value) == 1.0;
									if (flag224)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag225 = Conversions.ToDouble(value) == 2.0;
									if (flag225)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag226 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag226)
					{
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag227 = sqlDataReader.Read();
						if (flag227)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows46 = sqlDataReader.HasRows;
							if (hasRows46)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag228 = Conversions.ToDouble(value) == 4.0;
									if (flag228)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag229 = Conversions.ToDouble(value) == 3.0;
									if (flag229)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag230 = Conversions.ToDouble(value) == 1.0;
									if (flag230)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag231 = Conversions.ToDouble(value) == 2.0;
									if (flag231)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag232 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag232)
					{
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag233 = sqlDataReader.Read();
						if (flag233)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows47 = sqlDataReader.HasRows;
							if (hasRows47)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag234 = Conversions.ToDouble(value) == 4.0;
									if (flag234)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag235 = Conversions.ToDouble(value) == 3.0;
									if (flag235)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag236 = Conversions.ToDouble(value) == 1.0;
									if (flag236)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag237 = Conversions.ToDouble(value) == 2.0;
									if (flag237)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag238 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag238)
					{
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag239 = sqlDataReader.Read();
						if (flag239)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows48 = sqlDataReader.HasRows;
							if (hasRows48)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag240 = Conversions.ToDouble(value) == 4.0;
									if (flag240)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag241 = Conversions.ToDouble(value) == 3.0;
									if (flag241)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag242 = Conversions.ToDouble(value) == 1.0;
									if (flag242)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag243 = Conversions.ToDouble(value) == 2.0;
									if (flag243)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag244 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag244)
					{
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["vales"].Value));
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag245 = sqlDataReader.Read();
						if (flag245)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows49 = sqlDataReader.HasRows;
							if (hasRows49)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag246 = Conversions.ToDouble(value) == 4.0;
									if (flag246)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag247 = Conversions.ToDouble(value) == 3.0;
									if (flag247)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag248 = Conversions.ToDouble(value) == 1.0;
									if (flag248)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag249 = Conversions.ToDouble(value) == 2.0;
									if (flag249)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag250 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag250)
					{
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["vales"].Value));
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag251 = sqlDataReader.Read();
						if (flag251)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows50 = sqlDataReader.HasRows;
							if (hasRows50)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag252 = Conversions.ToDouble(value) == 4.0;
									if (flag252)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag253 = Conversions.ToDouble(value) == 3.0;
									if (flag253)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag254 = Conversions.ToDouble(value) == 1.0;
									if (flag254)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag255 = Conversions.ToDouble(value) == 2.0;
									if (flag255)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag256 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag256)
					{
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag257 = sqlDataReader.Read();
						if (flag257)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows51 = sqlDataReader.HasRows;
							if (hasRows51)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag258 = Conversions.ToDouble(value) == 4.0;
									if (flag258)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag259 = Conversions.ToDouble(value) == 3.0;
									if (flag259)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag260 = Conversions.ToDouble(value) == 1.0;
									if (flag260)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag261 = Conversions.ToDouble(value) == 2.0;
									if (flag261)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag262 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag262)
					{
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag263 = sqlDataReader.Read();
						if (flag263)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows52 = sqlDataReader.HasRows;
							if (hasRows52)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag264 = Conversions.ToDouble(value) == 4.0;
									if (flag264)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag265 = Conversions.ToDouble(value) == 3.0;
									if (flag265)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag266 = Conversions.ToDouble(value) == 1.0;
									if (flag266)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag267 = Conversions.ToDouble(value) == 2.0;
									if (flag267)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag268 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag268)
					{
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["vales"].Value));
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag269 = sqlDataReader.Read();
						if (flag269)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows53 = sqlDataReader.HasRows;
							if (hasRows53)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag270 = Conversions.ToDouble(value) == 4.0;
									if (flag270)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag271 = Conversions.ToDouble(value) == 3.0;
									if (flag271)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag272 = Conversions.ToDouble(value) == 1.0;
									if (flag272)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag273 = Conversions.ToDouble(value) == 2.0;
									if (flag273)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					bool flag274 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false), Operators.CompareObjectGreater(this.dgvNotas.Rows[rowIndex].Cells["Descto %"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Tarjeta"].Value, 0, false)));
					if (flag274)
					{
						(textBox = this.txtdifvales).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["vales"].Value));
						(textBox = this.txtdifotros).Text = Conversions.ToString(Operators.AddObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Otros"].Value));
						text2 = "SELECT m from H";
						sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
						bool flag275 = sqlDataReader.Read();
						if (flag275)
						{
							string text51 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
							text2 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text51.ToString() + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows54 = sqlDataReader.HasRows;
							if (hasRows54)
							{
								while (sqlDataReader.Read())
								{
									string text47 = Conversions.ToString(sqlDataReader[0]);
									string value = Conversions.ToString(sqlDataReader[1]);
									bool flag276 = Conversions.ToDouble(value) == 4.0;
									if (flag276)
									{
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag277 = Conversions.ToDouble(value) == 3.0;
									if (flag277)
									{
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag278 = Conversions.ToDouble(value) == 1.0;
									if (flag278)
									{
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
									}
									bool flag279 = Conversions.ToDouble(value) == 2.0;
									if (flag279)
									{
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num24.ToString()));
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
					this.dgvNotas.Rows[e.RowIndex].Cells[11].Value = "0";
					bool flag280 = !this.chkEliminaProp.Checked;
					if (flag280)
					{
						Label lblpropinascortenuevo;
						(lblpropinascortenuevo = this.lblpropinascortenuevo).Text = Conversions.ToString(Operators.AddObject(lblpropinascortenuevo.Text, Operators.NegateObject(this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value)));
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Operators.SubtractObject(textBox.Text, this.dgvNotas.Rows[rowIndex].Cells["Propina"].Value));
					}
					else
					{
						this.lblpropinascortenuevo.Text = "$ 0.00";
					}
					bool flag281 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Facturado"].Value, "Si", false), Operators.CompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Cancel."].Value, "No", false)));
					if (flag281)
					{
						(textBox = this.txtVentaFacturada).Text = Conversions.ToString(Operators.AddObject(textBox.Text, Operators.SubtractObject(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value, num24)));
					}
				}
				double num25 = Conversions.ToDouble(this.txtdifvales.Text);
				this.txtdifvales.Text = "$ " + num25.ToString("N2");
				double num26 = Conversions.ToDouble(this.txtdifotros.Text);
				this.txtdifotros.Text = "$ " + num26.ToString("N2");
				double num27 = Conversions.ToDouble(this.txtDifTarjeta.Text);
				this.txtDifTarjeta.Text = "$ " + num27.ToString("N2");
				this.lblcortetarjetanuevo.Text = num27.ToString("N2");
				double num28 = Conversions.ToDouble(this.txttotalnuevopropinas.Text);
				this.txttotalnuevopropinas.Text = "$ " + num28.ToString("N2");
				double num29 = Conversions.ToDouble(this.txtVentaFacturada.Text);
				this.txtVentaFacturada.Text = "$ " + num29.ToString("N2");
				double num30 = Conversions.ToDouble(this.txtVentasOtros.Text);
				double num31 = Conversions.ToDouble(this.txtVentaTarjeta.Text);
				double num32 = Conversions.ToDouble(this.txtVales.Text);
				double num33 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
				double num34 = Conversions.ToDouble(this.txtImpNuevo.Text);
				this.txtEfectivoFiscal.Text = "$ " + num33.ToString("N2");
				this.lblcorteefectivonuevo.Text = "$ " + num33.ToString("N2");
				double num35 = Conversions.ToDouble(this.txtDifImporte.Text);
				this.txtVales.Text = "$ " + num32.ToString("N2");
				this.txtVentasOtros.Text = "$ " + num30.ToString("N2");
				this.txtVentaTarjeta.Text = "$ " + num31.ToString("N2");
				this.txtImpNuevo.Text = "$ " + num34.ToString("N2");
				this.txtDifImporte.Text = "$ " + num35.ToString("N2");
				this.txtDifPorcen.Text = "% " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
				double num36 = Conversions.ToDouble(this.txttotalnuevopropinas.Text);
				this.lblpropinascortenuevo.Text = "$ " + num36.ToString("N2");
				num28 = Conversions.ToDouble(this.txttotalnuevopropinas.Text);
				this.txttotalnuevopropinas.Text = "$ " + num28.ToString("N2");
				double num37 = Conversions.ToDouble(this.lblcorteefectivonuevo.Text);
				this.lblcorteefectivonuevo.Text = "$ " + num37.ToString("N2");
				double num38 = Conversions.ToDouble(this.lblcortetarjetanuevo.Text);
				this.lblcortetarjetanuevo.Text = "$ " + num38.ToString("N2");
				double num39 = Conversions.ToDouble(this.lblcortenuevotros.Text);
				this.lblcortenuevotros.Text = "$ " + num39.ToString("N2");
				double num40 = Conversions.ToDouble(this.lblcortenuevovales.Text);
				this.lblcortenuevovales.Text = "$ " + num40.ToString("N2");
				double num41 = Conversions.ToDouble(this.lblcortenuevodepositos.Text);
				double num42 = Conversions.ToDouble(this.lblcortenuevoretiros.Text);
				double num43 = num37 + num38 + num39 + num40 - num28 + num41 - num42;
				double num44 = num37 - num28 - num42 + num41;
				this.lblsaldofinarlcortenuevo.Text = "$ " + num43.ToString("N2");
				this.lblEfectivonuevocorte.Text = "$ " + num44.ToString("N2");
				double num45 = Conversions.ToDouble(this.txtEfectivoCaja.Text);
				this.txtEfectivoCaja.Text = "$ " + num45.ToString("N2");
				this.lblEfectivonuevocorte.Text = "$ " + num45.ToString("N2");
				double num46 = Conversions.ToDouble(this.txtImpNuevo.Text);
				double num47 = Conversions.ToDouble(this.txtVentaFacturada.Text);
				double num48 = Conversion.Val(num46) - Conversion.Val(num47);
				this.txtventasinfacturar.Text = "$ " + num48.ToString("N2");
				this.txtFacturaPUB.Text = "$ " + num48.ToString("N2");
				this.lblventafacturanew.Text = this.txtVentaFacturada.Text;
				this.lblventasinfacturarnew.Text = this.txtventasinfacturar.Text;
				this.lblfacturapubnew.Text = this.txtFacturaPUB.Text;
			}
			bool flag282 = e.RowIndex >= 0 && e.ColumnIndex == 19;
			if (flag282)
			{
				bool flag283 = Operators.ConditionalCompareObjectEqual(this.dgvNotas.Rows[rowIndex].Cells["Eliminar"].Value, false, false);
				if (flag283)
				{
					Interaction.MsgBox("Tienes que marcar el ticket como Eliminar para ver el detalle!", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					this.dgvNotas.Enabled = false;
					int index = this.dgvNotas.CurrentRow.Index;
					this.lblnumerodefila.Text = Conversions.ToString(index);
					this.PanelDetalleTicket.Visible = true;
					this.lblpruebapanel.Visible = false;
					this.iniciaGridCheqDetalleSeleccion();
					string text = Conversions.ToString(this.dgvNotas.Rows[rowIndex].Cells["id_nota"].Value);
					Tools.FolioParaAgregar_ProductosEliminarProductos = Conversions.ToString(this.dgvNotas.Rows[rowIndex].Cells["id_nota"].Value);
					this.lblidFoliodet.Text = text;
					this.lblfoliodelticket.Text = Conversions.ToString(this.dgvNotas.Rows[rowIndex].Cells["Folio Cuenta"].Value);
					double num49 = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells["Total Original"].Value);
					double num50 = Conversions.ToDouble(this.dgvNotas.Rows[rowIndex].Cells["Total con Prod. Eliminados"].Value);
					this.lbltotaloriginal.Text = "$" + num49.ToString("N2");
					this.lblnuevototal.Text = "$ " + num50.ToString("N2");
					this.PanelDetalleTicket.Visible = true;
					string text2 = "select a.foliodet , a.movimiento , a.cantidad , a.idproducto ,b.descripcion, a.precio , a.impuesto1 , a.preciosinimpuestos , a.Descuento  from cheqdet A\r\n                        Inner join productos B on b.idproducto = a.idproducto where foliodet= '" + text + "' order by a.movimiento asc";
					SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
					bool hasRows55 = sqlDataReader.HasRows;
					if (hasRows55)
					{
						while (sqlDataReader.Read())
						{
							string text53 = Conversions.ToString(sqlDataReader[0]);
							this.lblfolioini.Text = text53.ToString();
							string text54 = Conversions.ToString(sqlDataReader[1]);
							string text55 = Conversions.ToString(sqlDataReader[2]);
							string text56 = Conversions.ToString(sqlDataReader[3]);
							string text57 = Conversions.ToString(sqlDataReader[4]);
							double num51 = Conversions.ToDouble(sqlDataReader[5]);
							double num52 = Conversions.ToDouble(sqlDataReader[6]);
							double num53 = Conversions.ToDouble(sqlDataReader[7]);
							double num54 = Conversions.ToDouble(sqlDataReader[8]);
							double num55 = Conversions.ToDouble(text55) * num51 - Conversions.ToDouble(text55) * num51 / 100.0 * num19;
							this.DataGridDetalleTickets.Rows.Add(new object[]
							{
								text53,
								text54,
								text55,
								text56,
								text57,
								num51.ToString("N2"),
								num52.ToString("N2"),
								num53.ToString("N2"),
								num54.ToString("N2"),
								num55.ToString("N2"),
								"0"
							});
						}
					}
					text2 = string.Concat(new string[]
					{
						"select a.a , a.b , a.c , a.d ,b.descripcion, a.e , a.f , a.g , a.h   from ",
						Tools.BaseDatos_Modulo,
						".dbo.F A\r\n                        Inner join productos B on b.idproducto = a.d where a.a= '",
						text,
						"' and j='1' order by a.b asc"
					});
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
					bool hasRows56 = sqlDataReader.HasRows;
					if (hasRows56)
					{
						while (sqlDataReader.Read())
						{
							string text53 = Conversions.ToString(sqlDataReader[0]);
							this.lblfolioini.Text = text53.ToString();
							string text54 = Conversions.ToString(sqlDataReader[1]);
							string text55 = Conversions.ToString(sqlDataReader[2]);
							string text56 = Conversions.ToString(sqlDataReader[3]);
							string text57 = Conversions.ToString(sqlDataReader[4]);
							double num51 = Conversions.ToDouble(sqlDataReader[5]);
							double num52 = Conversions.ToDouble(sqlDataReader[6]);
							double num53 = Conversions.ToDouble(sqlDataReader[7]);
							double num54 = Conversions.ToDouble(sqlDataReader[8]);
							double num55 = Conversions.ToDouble(text55) * num51 - Conversions.ToDouble(text55) * num51 / 100.0 * num19;
							this.DataGridDetalleTickets.Rows.Add(new object[]
							{
								text53,
								text54,
								text55,
								text56,
								text57,
								num51.ToString("N2"),
								num52.ToString("N2"),
								num53.ToString("N2"),
								num54.ToString("N2"),
								num55.ToString("N2"),
								"1"
							});
						}
					}
					text2 = "SELECT ISNULL(count(a),0) as 'ContarFilas' FROM F where a = '" + this.lblfolioini.Text + "'";
					sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text2);
					bool flag284 = sqlDataReader.Read();
					if (flag284)
					{
						int value2 = Conversions.ToInteger(sqlDataReader[0]);
						this.lblcontador.Text = Conversions.ToString(value2);
					}
					try
					{
						foreach (object obj in ((IEnumerable)this.DataGridDetalleTickets.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							string text58 = Conversions.ToString(dataGridViewRow.Cells["Foliodet"].Value);
							string text3 = Conversions.ToString(dataGridViewRow.Cells["Mov."].Value);
							string text59 = Conversions.ToString(dataGridViewRow.Cells["idproducto"].Value);
							text2 = string.Concat(new string[]
							{
								"select a.a , a.b , a.c , a.d ,b.descripcion, a.e , a.f , a.g , a.j , a.k  from ",
								Tools.BaseDatos_Modulo,
								".dbo.F A\r\n                        Inner join productos B on b.idproducto = a.d where a.a ='",
								text58,
								"' and a.b='",
								text3,
								"' and a.d='",
								text59,
								"'"
							});
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text2);
							bool hasRows57 = sqlDataReader.HasRows;
							if (hasRows57)
							{
								while (sqlDataReader.Read())
								{
									string left = Conversions.ToString(sqlDataReader[8]);
									string left2 = Conversions.ToString(sqlDataReader[9]);
									bool flag285 = Operators.CompareString(left, "1", false) == 0;
									if (flag285)
									{
										dataGridViewRow.DefaultCellStyle.BackColor = Color.Yellow;
									}
									bool flag286 = Operators.CompareString(left2, "1", false) == 0;
									if (flag286)
									{
										bool flag287 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, false, false);
										if (flag287)
										{
											dataGridViewRow.Cells["Eliminar"].Value = true;
											dataGridViewRow.DefaultCellStyle.BackColor = Color.Yellow;
											dataGridViewRow.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
										}
									}
								}
							}
							else
							{
								bool flag288 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, false, false);
								if (flag288)
								{
									dataGridViewRow.Cells["Eliminar"].Value = true;
									dataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
									dataGridViewRow.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
								}
							}
							this.DataGridDetalleTickets.ClearSelection();
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
			}
			this.lblcontafilastotal.Text = Conversions.ToString(this.DataGridDetalleTickets.Rows.Count);
			bool flag289 = Conversions.ToDouble(this.txtCuentasModificar.Text) != 0.0;
			if (flag289)
			{
				this.btnAplicar.Enabled = true;
			}
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00080900 File Offset: 0x0007EB00
		private void dgvNotas_MouseUp(object sender, MouseEventArgs e)
		{
			this.dgvNotas.ClearSelection();
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00080910 File Offset: 0x0007EB10
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

		// Token: 0x060007E3 RID: 2019 RVA: 0x00080A10 File Offset: 0x0007EC10
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

		// Token: 0x060007E4 RID: 2020 RVA: 0x00080BBC File Offset: 0x0007EDBC
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

		// Token: 0x060007E5 RID: 2021 RVA: 0x00081058 File Offset: 0x0007F258
		private void btnAplicar_Click(object sender, EventArgs e)
		{
			this.progBar.Value = 0;
			this.COdigoUnicoCOrteGenerar();
			this.lblfechayhora.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
			int num = 0;
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery2 = new SqlQuery();
			SqlQuery sqlQuery3 = new SqlQuery();
			object obj = "SE MODIFICARAN LOS FOLIOS SELECCIONADOS, Deseas continuar?";
			object value = 276;
			object obj2 = "ATENCIÓN!!!";
			object left = Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), (MsgBoxStyle)Conversions.ToInteger(value), RuntimeHelpers.GetObjectValue(obj2));
			bool flag = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.Yes, false);
			if (flag)
			{
				this.progBar.Value = 10;
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
				this.progBar.Value = 20;
				this.habilitaControles(false);
				string text = "";
				double num2 = 0.0;
				SqlQuery sqlQuery4 = new SqlQuery();
				SqlQuery sqlQuery5 = new SqlQuery();
				string text2 = this.cmbxSerie.Text;
				SqlQuery sqlQuery6 = new SqlQuery();
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
				SqlDataReader sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
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
				sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
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
				try
				{
					foreach (string text6 in list)
					{
						this.progBar.Value = 25;
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
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
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
										sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
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
												sqlQuery.execQuery(text5);
												this.progBar.Value = 28;
											}
											text5 = "   Select a.idproducto ,b.descripcion, a.precio,a.cantidad,a.hora  from cheqdet A\r\n                                                         Inner JOIN productos B on b.idproducto = a.idproducto where a.foliodet in  (select folio from cheques where idturno = '" + text6 + "' AND cierre is not null  and cancelado=0)";
											sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
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
													sqlQuery.execQuery(text5);
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
							bool flag5 = Operators.CompareString(text2, "Todas", false) == 0;
							if (flag5)
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
								sqlQuery5.execQuery(text5);
								text5 = "update cheques set propina=0 , propinafoliomovtocaja =0 where numcheque='" + text23.ToString() + "'";
								sqlQuery5.execQuery(text5);
							}
							bool flag6 = Operators.CompareString(text2, "Todas", false) != 0;
							if (flag6)
							{
								text5 = string.Concat(new string[]
								{
									"Update movtoscaja Set importe = importe - (Select propina from cheques where numcheque ='",
									text23.ToString(),
									"' and  seriefolio = '",
									text2,
									"') where folio=  '",
									text24,
									"'"
								});
								sqlQuery5.execQuery(text5);
								text5 = string.Concat(new string[]
								{
									"update cheques set propina=0 , propinafoliomovtocaja =0 where numcheque='",
									text23.ToString(),
									"' and  seriefolio = '",
									text2,
									"'"
								});
								sqlQuery5.execQuery(text5);
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
				this.progBar.Value = 30;
				try
				{
					foreach (object obj4 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj4;
						bool flag7 = Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false);
						if (flag7)
						{
							text = Conversions.ToString(Operators.AddObject(text, dataGridViewRow2.Cells["id_nota"].Value));
							text += ",";
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
				text = text.Remove(checked(text.Length - 1), 1);
				this.progBar.Value = 40;
				try
				{
					foreach (object obj5 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow3 = (DataGridViewRow)obj5;
						bool flag8 = Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells["Eliminar"].Value, true, false);
						if (flag8)
						{
							double num3 = Conversions.ToDouble(dataGridViewRow3.Cells["Descto %"].Value);
							string text26 = Conversions.ToString(dataGridViewRow3.Cells["id_nota"].Value);
							DateTime dateTime3 = Conversions.ToDate(dataGridViewRow3.Cells["Fecha"].Value);
							text5 = " delete from chequespagos where folio = '" + text26 + "'";
							sqlQuery.execQuery(text5);
							text5 = string.Concat(new string[]
							{
								"delete from Cheqdet where movimiento not in (select b from ",
								Tools.BaseDatos_Modulo,
								".dbo.F where a='",
								text26,
								"') and foliodet= '",
								text26,
								"'"
							});
							sqlQuery.execQuery(text5);
							text5 = "select ISNULL(sum(((cantidad*preciosinimpuestos)-(cantidad*preciosinimpuestos/100*descuento))),0) from cheqdet where foliodet = '" + text26 + "'";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
							bool flag9 = sqlDataReader2.Read();
							double num4;
							if (flag9)
							{
								num4 = Conversions.ToDouble(sqlDataReader2[0]);
								num4 -= num4 / 100.0 * num3;
							}
							text5 = " select ISNULL(sum(((cantidad*preciosinimpuestos)-(cantidad*preciosinimpuestos/100*descuento))/100 *impuesto1),0) from cheqdet where foliodet  = '" + text26 + "'";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
							bool flag10 = sqlDataReader2.Read();
							double num5;
							if (flag10)
							{
								num5 = Conversions.ToDouble(sqlDataReader2[0]);
								num5 -= num5 / 100.0 * num3;
							}
							double num6 = num4 + num5;
							double num7 = num6;
							bool flag11 = Operators.CompareString(text2, "Todas", false) == 0;
							if (flag11)
							{
								text5 = string.Concat(new string[]
								{
									"update cheques Set nopersonas ='",
									this.CmbMovtos.Text,
									"' , cambio=0 , totalarticulos='",
									this.CmbMovtos.Text,
									"' where folio = '",
									text26,
									"'"
								});
								sqlQuery.execQuery(text5);
							}
							bool flag12 = Operators.CompareString(text2, "Todas", false) != 0;
							if (flag12)
							{
								text5 = string.Concat(new string[]
								{
									"update cheques Set nopersonas ='",
									this.CmbMovtos.Text,
									"' , cambio=0 , totalarticulos='",
									this.CmbMovtos.Text,
									"' where folio = '",
									text26,
									"' and  seriefolio = '",
									text2,
									"'"
								});
								sqlQuery.execQuery(text5);
							}
							SqlQuery sqlQuery7 = new SqlQuery();
							bool flag13 = Operators.CompareString(text2, "Todas", false) == 0;
							if (flag13)
							{
								bool flag14 = num3 == 100.0;
								if (flag14)
								{
									text5 = "UPDATE Cheques set descuentoimporte='0.00' ,totalalimentos='0.00', totalalimentossindescuentos='0.00', totalsindescuento='0.00',subtotalcondescuento='0.00' , subtotal='0.00', totalbebidas='0.00' ,  totalbebidassindescuentos='0.00' , totalotrossindescuentos='0.00' , totaldescuentoalimentos= '0.00' , totaldescuentobebidas='0.00' , totaldescuentootros='0.00' , totaldescuentos='0.00' , totaldescuentoycortesia='0.00'  Where folio='" + text26 + "'";
									sqlQuery.execQuery(text5);
									text5 = "SELECT Cantidad , Descuento , PreciosinImpuestos FROM Cheqdet Where foliodet='" + text26 + "' ";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows9 = sqlDataReader2.HasRows;
									if (hasRows9)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											double num11 = num8 * num10 / 100.0 * num3;
											text5 = string.Concat(new string[]
											{
												"UPDATE Cheques set DescuentoImporte = DescuentoImporte + '",
												num11.ToString("N2"),
												"'  , totaldescuentoycortesia = totaldescuentoycortesia + '",
												num11.ToString("N2"),
												"' Where folio='",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows10 = sqlDataReader2.HasRows;
									if (hasRows10)
									{
										while (sqlDataReader2.Read())
										{
											double num12 = Conversions.ToDouble(sqlDataReader2[0]);
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totalbebidassindescuentos='",
												num12.ToString("N2"),
												"' , totalsindescuento = totalsindescuento + '",
												num12.ToString("N2"),
												"' , subtotal= subtotal + '",
												num12.ToString("N2"),
												"' where folio='",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=2";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows11 = sqlDataReader2.HasRows;
									if (hasRows11)
									{
										while (sqlDataReader2.Read())
										{
											double num13 = Conversions.ToDouble(sqlDataReader2[0]);
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totalalimentossindescuentos='",
												num13.ToString("N2"),
												"' , totalsindescuento= totalsindescuento + '",
												num13.ToString("N2"),
												"' , subtotal= subtotal + '",
												num13.ToString("N2"),
												"' where folio='",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=3";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows12 = sqlDataReader2.HasRows;
									if (hasRows12)
									{
										while (sqlDataReader2.Read())
										{
											double num14 = Conversions.ToDouble(sqlDataReader2[0]);
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totalotrossindescuentos='",
												num14.ToString("N2"),
												"' ,totalsindescuento= totalsindescuento +'",
												num14.ToString("N2"),
												"' , subtotal= subtotal + '",
												num14.ToString("N2"),
												"'  where folio='",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
									}
									sqlDataReader2.Close();
								}
								bool flag15 = num3 >= 0.0 & num3 < 100.0;
								if (flag15)
								{
									text5 = "UPDATE Cheques set descuentoimporte='0.00' ,totalalimentos='0.00', totalalimentossindescuentos='0.00', totalsindescuento='0.00',subtotalcondescuento='0.00' , subtotal='0.00', totalbebidas='0.00' ,  totalbebidassindescuentos='0.00' , totalotrossindescuentos='0.00' , totaldescuentoalimentos= '0.00' , totaldescuentobebidas='0.00' , totaldescuentootros='0.00' , totaldescuentos='0.00' , totaldescuentoycortesia='0.00' Where folio='" + text26 + "'";
									sqlQuery.execQuery(text5);
									text5 = "SELECT Cantidad , Descuento , PreciosinImpuestos FROM Cheqdet Where foliodet='" + text26 + "' and descuento > 0 ";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows13 = sqlDataReader2.HasRows;
									if (hasRows13)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totaldescuentoycortesia= totaldescuentoycortesia +'",
												(num8 * num10 / 100.0 * num9).ToString("N2"),
												"'  where folio='",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows14 = sqlDataReader2.HasRows;
									if (hasRows14)
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
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows15 = sqlDataReader2.HasRows;
									if (hasRows15)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											double num15 = Conversions.ToDouble((num8 * num10 - num8 * num10 / 100.0 * num9).ToString("n2"));
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totalbebidas= totalbebidas +'",
												num15.ToString("N2"),
												"' ,subtotal= subtotal + '",
												num15.ToString("N2"),
												"' , subtotalcondescuento = subtotalcondescuento +  '",
												num15.ToString("N2"),
												"' , TotalSinDescuento=TotalSinDescuento + '",
												num15.ToString("N2"),
												"'    where folio='",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=2";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows16 = sqlDataReader2.HasRows;
									if (hasRows16)
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
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=2";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows17 = sqlDataReader2.HasRows;
									if (hasRows17)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											double num16 = Conversions.ToDouble((num8 * num10 - num8 * num10 / 100.0 * num9).ToString("n2"));
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totalalimentos= totalalimentos + '",
												num16.ToString("N2"),
												"' , subtotal= subtotal + '",
												num16.ToString("N2"),
												"' , subtotalcondescuento = subtotalcondescuento +  '",
												num16.ToString("N2"),
												"' ,  TotalSinDescuento=TotalSinDescuento + '",
												num16.ToString("N2"),
												"'  where folio='",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=3";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows18 = sqlDataReader2.HasRows;
									if (hasRows18)
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
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=3";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows19 = sqlDataReader2.HasRows;
									if (hasRows19)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											double num17 = Conversions.ToDouble((num8 * num10 - num8 * num10 / 100.0 * num9).ToString("n2"));
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totalotros= totalotros +'",
												num17.ToString("N2"),
												"' ,  subtotal= subtotal + '",
												num17.ToString("N2"),
												"' , subtotalcondescuento = subtotalcondescuento +  '",
												num17.ToString("N2"),
												"' , TotalSinDescuento=TotalSinDescuento + '",
												num17.ToString("N2"),
												"'   where folio='",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
									}
								}
								bool flag16 = num3 > 0.0 & num3 < 100.0;
								if (flag16)
								{
									text5 = "Select Subtotal from Cheques where folio='" + text26 + "'";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool flag17 = sqlDataReader2.Read();
									if (flag17)
									{
										double num18 = Conversions.ToDouble(sqlDataReader2[0]);
										num18 = num18 / 100.0 * num3;
										double num19 = Conversions.ToDouble(sqlDataReader2[0]);
										text5 = string.Concat(new string[]
										{
											"Update Cheques set  subtotalcondescuento ='",
											(num19 - num19 / 100.0 * num3).ToString("N2"),
											"' , DescuentoImporte = DescuentoImporte + '",
											num18.ToString("N2"),
											"' ,totaldescuentos = totaldescuentos + '",
											num18.ToString("N2"),
											"' , totaldescuentoycortesia = totaldescuentoycortesia + '",
											num18.ToString("N2"),
											"'  where Folio = '",
											text26,
											"'  "
										});
										sqlQuery.execQuery(text5);
									}
									sqlDataReader2.Close();
									text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows20 = sqlDataReader2.HasRows;
									if (hasRows20)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											double num20 = num8 * num10 / 100.0 * num9;
											double num15 = num8 * num10 - num8 * num10 / 100.0 * num9;
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totaldescuentobebidas= totaldescuentobebidas +'",
												Conversions.ToDouble((num15 - num15 / 100.0 * num3).ToString("n2")).ToString("N2"),
												"' where folio='",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
									}
									text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=2";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows21 = sqlDataReader2.HasRows;
									if (hasRows21)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											double num20 = num8 * num10 / 100.0 * num9;
											double num16 = num8 * num10 - num8 * num10 / 100.0 * num9;
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totaldescuentoalimentos= totaldescuentoalimentos +'",
												Conversions.ToDouble((num16 - num16 / 100.0 * num3).ToString("n2")).ToString("N2"),
												"'  where folio='",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
									}
									text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=3";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows22 = sqlDataReader2.HasRows;
									if (hasRows22)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											double num20 = num8 * num10 / 100.0 * num9;
											double num17 = num8 * num10 - num8 * num10 / 100.0 * num9;
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totaldescuentootros= totaldescuentootros +'",
												Conversions.ToDouble((num17 - num17 / 100.0 * num3).ToString("n2")).ToString("N2"),
												"' where folio='",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
									}
								}
								sqlDataReader2.Close();
							}
							bool flag18 = Operators.CompareString(text2, "Todas", false) != 0;
							if (flag18)
							{
								bool flag19 = num3 == 100.0;
								if (flag19)
								{
									text5 = "UPDATE Cheques set descuentoimporte='0.00' , totalalimentossindescuentos='0.00', totalsindescuento='0.00', totalbebidassindescuentos='0.00' , totalotrossindescuentos='0.00' ,subtotalcondescuento='0.00' , subtotal='0.00' , totaldescuentoalimentos= '0.00' , totaldescuentobebidas='0.00' , totaldescuentootros='0.00' , totaldescuentos='0.00' , totaldescuentoycortesia='0.00' Where folio='" + text26 + "'";
									sqlQuery.execQuery(text5);
									text5 = "SELECT Cantidad , Descuento , PreciosinImpuestos FROM Cheqdet Where foliodet='" + text26 + "' ";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows23 = sqlDataReader2.HasRows;
									if (hasRows23)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											double num11 = num8 * num10 / 100.0 * num3;
											text5 = string.Concat(new string[]
											{
												"UPDATE Cheques set DescuentoImporte = DescuentoImporte + '",
												num11.ToString("N2"),
												"'  , totaldescuentoycortesia = totaldescuentoycortesia + '",
												num11.ToString("N2"),
												"' Where folio='",
												text26,
												"' and seriefolio='",
												text2,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows24 = sqlDataReader2.HasRows;
									if (hasRows24)
									{
										while (sqlDataReader2.Read())
										{
											double num12 = Conversions.ToDouble(sqlDataReader2[0]);
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totalbebidassindescuentos='",
												num12.ToString("N2"),
												"' , totalsindescuento = totalsindescuento + '",
												num12.ToString("N2"),
												"' , subtotal= subtotal + '",
												num12.ToString("N2"),
												"' where folio='",
												text26,
												"' and seriefolio='",
												text2,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=2";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows25 = sqlDataReader2.HasRows;
									if (hasRows25)
									{
										while (sqlDataReader2.Read())
										{
											double num13 = Conversions.ToDouble(sqlDataReader2[0]);
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totalalimentossindescuentos='",
												num13.ToString("N2"),
												"' , totalsindescuento= totalsindescuento + '",
												num13.ToString("N2"),
												"' , subtotal= subtotal + '",
												num13.ToString("N2"),
												"' where folio='",
												text26,
												"' and seriefolio='",
												text2,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=3";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows26 = sqlDataReader2.HasRows;
									if (hasRows26)
									{
										while (sqlDataReader2.Read())
										{
											double num14 = Conversions.ToDouble(sqlDataReader2[0]);
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totalotrossindescuentos='",
												num14.ToString("N2"),
												"' ,totalsindescuento= totalsindescuento +'",
												num14.ToString("N2"),
												"' , subtotal= subtotal + '",
												num14.ToString("N2"),
												"'  where folio='",
												text26,
												"' and seriefolio='",
												text2,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
									}
									sqlDataReader2.Close();
								}
								bool flag20 = num3 >= 0.0 & num3 < 100.0;
								if (flag20)
								{
									text5 = string.Concat(new string[]
									{
										"UPDATE Cheques set descuentoimporte='0.00' ,totalalimentos='0.00', totalalimentossindescuentos='0.00', totalsindescuento='0.00',subtotalcondescuento='0.00' , subtotal='0.00', totalbebidas='0.00' ,  totalbebidassindescuentos='0.00' , totalotrossindescuentos='0.00' , totaldescuentoalimentos= '0.00' , totaldescuentobebidas='0.00' , totaldescuentootros='0.00' , totaldescuentos='0.00' , totaldescuentoycortesia='0.00' Where folio='",
										text26,
										"' and seriefolio='",
										text2,
										"'"
									});
									sqlQuery.execQuery(text5);
									text5 = "SELECT Cantidad , Descuento , PreciosinImpuestos FROM Cheqdet Where foliodet='" + text26 + "' and descuento > 0 ";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows27 = sqlDataReader2.HasRows;
									if (hasRows27)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totaldescuentoycortesia= totaldescuentoycortesia +'",
												(num8 * num10 / 100.0 * num9).ToString("N2"),
												"'  where folio='",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows28 = sqlDataReader2.HasRows;
									if (hasRows28)
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
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows29 = sqlDataReader2.HasRows;
									if (hasRows29)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											double num15 = Conversions.ToDouble((num8 * num10 - num8 * num10 / 100.0 * num9).ToString("n2"));
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totalbebidas= totalbebidas +'",
												num15.ToString("N2"),
												"' ,subtotal= subtotal + '",
												num15.ToString("N2"),
												"' , subtotalcondescuento = subtotalcondescuento +  '",
												num15.ToString("N2"),
												"' , TotalSinDescuento=TotalSinDescuento + '",
												num15.ToString("N2"),
												"'    where folio='",
												text26,
												"' and seriefolio='",
												text2,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=2";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows30 = sqlDataReader2.HasRows;
									if (hasRows30)
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
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=2";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows31 = sqlDataReader2.HasRows;
									if (hasRows31)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											double num16 = Conversions.ToDouble((num8 * num10 - num8 * num10 / 100.0 * num9).ToString("n2"));
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totalalimentos= totalalimentos + '",
												num16.ToString("N2"),
												"' , subtotal= subtotal + '",
												num16.ToString("N2"),
												"' , subtotalcondescuento = subtotalcondescuento +  '",
												num16.ToString("N2"),
												"' ,  TotalSinDescuento=TotalSinDescuento + '",
												num16.ToString("N2"),
												"'  where folio='",
												text26,
												"' and seriefolio='",
												text2,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=3";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows32 = sqlDataReader2.HasRows;
									if (hasRows32)
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
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=3";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows33 = sqlDataReader2.HasRows;
									if (hasRows33)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											double num17 = Conversions.ToDouble((num8 * num10 - num8 * num10 / 100.0 * num9).ToString("n2"));
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totalotros= totalotros +'",
												num17.ToString("N2"),
												"' ,  subtotal= subtotal + '",
												num17.ToString("N2"),
												"' , subtotalcondescuento = subtotalcondescuento +  '",
												num17.ToString("N2"),
												"' , TotalSinDescuento=TotalSinDescuento + '",
												num17.ToString("N2"),
												"'   where folio='",
												text26,
												"' and seriefolio='",
												text2,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
									}
								}
								bool flag21 = num3 > 0.0 & num3 < 100.0;
								if (flag21)
								{
									text5 = "Select Subtotal from Cheques where folio='" + text26 + "'";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool flag22 = sqlDataReader2.Read();
									if (flag22)
									{
										double num21 = Conversions.ToDouble(sqlDataReader2[0]);
										num21 = num21 / 100.0 * num3;
										double num22 = Conversions.ToDouble(sqlDataReader2[0]);
										text5 = string.Concat(new string[]
										{
											"Update Cheques set  subtotalcondescuento ='",
											(num22 - num22 / 100.0 * num3).ToString("N2"),
											"' , DescuentoImporte = DescuentoImporte + '",
											num21.ToString("N2"),
											"' ,totaldescuentos = totaldescuentos + '",
											num21.ToString("N2"),
											"' , totaldescuentoycortesia = totaldescuentoycortesia + '",
											num21.ToString("N2"),
											"'  where Folio = '",
											text26,
											"' and seriefolio='",
											text2,
											"' "
										});
										sqlQuery.execQuery(text5);
									}
									sqlDataReader2.Close();
									text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows34 = sqlDataReader2.HasRows;
									if (hasRows34)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											double num23 = num8 * num10 / 100.0 * num9;
											double num15 = num8 * num10 - num8 * num10 / 100.0 * num9;
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totaldescuentobebidas= totaldescuentobebidas +'",
												Conversions.ToDouble((num15 - num15 / 100.0 * num3).ToString("n2")).ToString("N2"),
												"' where folio='",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
									}
									text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=2";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows35 = sqlDataReader2.HasRows;
									if (hasRows35)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											double num23 = num8 * num10 / 100.0 * num9;
											double num16 = num8 * num10 - num8 * num10 / 100.0 * num9;
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totaldescuentoalimentos= totaldescuentoalimentos +'",
												Conversions.ToDouble((num16 - num16 / 100.0 * num3).ToString("n2")).ToString("N2"),
												"'  where folio='",
												text26,
												"' and seriefolio='",
												text2,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
									}
									text5 = "select a.Cantidad , a.Descuento , a.PreciosinImpuestos from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=3";
									sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
									bool hasRows36 = sqlDataReader2.HasRows;
									if (hasRows36)
									{
										while (sqlDataReader2.Read())
										{
											double num8 = Conversions.ToDouble(sqlDataReader2[0]);
											double num9 = Conversions.ToDouble(sqlDataReader2[1]);
											double num10 = Conversions.ToDouble(sqlDataReader2[2]);
											double num23 = num8 * num10 / 100.0 * num9;
											double num17 = num8 * num10 - num8 * num10 / 100.0 * num9;
											text5 = string.Concat(new string[]
											{
												"Update Cheques set  totaldescuentootros= totaldescuentootros +'",
												Conversions.ToDouble((num17 - num17 / 100.0 * num3).ToString("n2")).ToString("N2"),
												"' where folio='",
												text26,
												"' and seriefolio='",
												text2,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
									}
								}
								sqlDataReader2.Close();
							}
							bool flag23 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow3.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Tarjeta"].Value, 0, false)));
							if (flag23)
							{
								string text27 = "SELECT i from H";
								SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text27);
								bool flag24 = sqlDataReader5.Read();
								if (flag24)
								{
									string text28 = Tools.Desencriptar(sqlDataReader5[0].ToString().Trim());
									text27 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text28.ToString() + "'";
									sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(text27);
									bool hasRows37 = sqlDataReader5.HasRows;
									if (hasRows37)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num7.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery.execQuery(text5);
												bool flag25 = Operators.CompareString(text2, "Todas", false) == 0;
												if (flag25)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text5);
												}
												bool flag26 = Operators.CompareString(text2, "Todas", false) != 0;
												if (flag26)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text2,
														"'"
													});
													sqlQuery.execQuery(text5);
												}
												bool flag27 = Conversions.ToDouble(value2) == 4.0;
												if (flag27)
												{
													bool flag28 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag28)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag29 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag29)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag30 = Conversions.ToDouble(value2) == 3.0;
												if (flag30)
												{
													bool flag31 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag31)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag32 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag32)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag33 = Conversions.ToDouble(value2) == 1.0;
												if (flag33)
												{
													bool flag34 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag34)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag35 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag35)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag36 = Conversions.ToDouble(value2) == 2.0;
												if (flag36)
												{
													bool flag37 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag37)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag38 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag38)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
											}
											catch (Exception ex2)
											{
											}
										}
									}
								}
								sqlDataReader5.Close();
							}
							bool flag39 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow3.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Tarjeta"].Value, 0, false)));
							if (flag39)
							{
								string text27 = "SELECT j from H";
								SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text27);
								bool flag40 = sqlDataReader5.Read();
								if (flag40)
								{
									string text30 = Tools.Desencriptar(sqlDataReader5[0].ToString().Trim());
									text27 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text30.ToString() + "'";
									sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(text27);
									bool hasRows38 = sqlDataReader5.HasRows;
									if (hasRows38)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num7.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery.execQuery(text5);
												bool flag41 = Operators.CompareString(text2, "Todas", false) == 0;
												if (flag41)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text5);
												}
												bool flag42 = Operators.CompareString(text2, "Todas", false) != 0;
												if (flag42)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text2,
														"'"
													});
													sqlQuery.execQuery(text5);
												}
												bool flag43 = Conversions.ToDouble(value2) == 4.0;
												if (flag43)
												{
													bool flag44 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag44)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag45 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag45)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag46 = Conversions.ToDouble(value2) == 3.0;
												if (flag46)
												{
													bool flag47 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag47)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag48 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag48)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag49 = Conversions.ToDouble(value2) == 1.0;
												if (flag49)
												{
													bool flag50 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag50)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag51 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag51)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag52 = Conversions.ToDouble(value2) == 2.0;
												if (flag52)
												{
													bool flag53 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag53)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag54 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag54)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
											}
											catch (Exception ex3)
											{
											}
										}
									}
								}
								sqlDataReader5.Close();
							}
							bool flag55 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow3.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Tarjeta"].Value, 0, false)));
							if (flag55)
							{
								string text27 = "SELECT k from H";
								SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text27);
								bool flag56 = sqlDataReader5.Read();
								if (flag56)
								{
									string text31 = Tools.Desencriptar(sqlDataReader5[0].ToString().Trim());
									text27 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text31.ToString() + "'";
									sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(text27);
									bool hasRows39 = sqlDataReader5.HasRows;
									if (hasRows39)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num7.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery.execQuery(text5);
												bool flag57 = Operators.CompareString(text2, "Todas", false) == 0;
												if (flag57)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text5);
												}
												bool flag58 = Operators.CompareString(text2, "Todas", false) != 0;
												if (flag58)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text2,
														"'"
													});
													sqlQuery.execQuery(text5);
												}
												bool flag59 = Conversions.ToDouble(value2) == 4.0;
												if (flag59)
												{
													bool flag60 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag60)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag61 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag61)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag62 = Conversions.ToDouble(value2) == 3.0;
												if (flag62)
												{
													bool flag63 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag63)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag64 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag64)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag65 = Conversions.ToDouble(value2) == 1.0;
												if (flag65)
												{
													bool flag66 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag66)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag67 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag67)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag68 = Conversions.ToDouble(value2) == 2.0;
												if (flag68)
												{
													bool flag69 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag69)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag70 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag70)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
											}
											catch (Exception ex4)
											{
											}
										}
									}
								}
								sqlDataReader5.Close();
							}
							bool flag71 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow3.Cells["Eliminar"].Value, true, false), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Tarjeta"].Value, 0, false)));
							if (flag71)
							{
								string text27 = "SELECT l from H";
								SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text27);
								bool flag72 = sqlDataReader5.Read();
								if (flag72)
								{
									string text32 = Tools.Desencriptar(sqlDataReader5[0].ToString().Trim());
									text27 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text32.ToString() + "'";
									sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(text27);
									bool hasRows40 = sqlDataReader5.HasRows;
									if (hasRows40)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num7.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery.execQuery(text5);
												bool flag73 = Operators.CompareString(text2, "Todas", false) == 0;
												if (flag73)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text5);
												}
												bool flag74 = Operators.CompareString(text2, "Todas", false) != 0;
												if (flag74)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"'  and seriefolio = '",
														text2,
														"'"
													});
													sqlQuery.execQuery(text5);
												}
												bool flag75 = Conversions.ToDouble(value2) == 4.0;
												if (flag75)
												{
													bool flag76 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag76)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag77 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag77)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'  and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag78 = Conversions.ToDouble(value2) == 3.0;
												if (flag78)
												{
													bool flag79 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag79)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag80 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag80)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'  and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag81 = Conversions.ToDouble(value2) == 1.0;
												if (flag81)
												{
													bool flag82 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag82)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag83 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag83)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag84 = Conversions.ToDouble(value2) == 2.0;
												if (flag84)
												{
													bool flag85 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag85)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag86 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag86)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
											}
											catch (Exception ex5)
											{
											}
										}
									}
								}
								sqlDataReader5.Close();
							}
							bool flag87 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow3.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Tarjeta"].Value, 0, false)));
							if (flag87)
							{
								string text27 = "SELECT m from H";
								SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text27);
								bool flag88 = sqlDataReader5.Read();
								if (flag88)
								{
									string text33 = Tools.Desencriptar(sqlDataReader5[0].ToString().Trim());
									text27 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text33.ToString() + "'";
									sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(text27);
									bool hasRows41 = sqlDataReader5.HasRows;
									if (hasRows41)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num7.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery.execQuery(text5);
												bool flag89 = Operators.CompareString(text2, "Todas", false) == 0;
												if (flag89)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text5);
												}
												bool flag90 = Operators.CompareString(text2, "Todas", false) != 0;
												if (flag90)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text2,
														"'"
													});
													sqlQuery.execQuery(text5);
												}
												bool flag91 = Conversions.ToDouble(value2) == 4.0;
												if (flag91)
												{
													bool flag92 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag92)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag93 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag93)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag94 = Conversions.ToDouble(value2) == 3.0;
												if (flag94)
												{
													bool flag95 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag95)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag96 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag96)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag97 = Conversions.ToDouble(value2) == 1.0;
												if (flag97)
												{
													bool flag98 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag98)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag99 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag99)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag100 = Conversions.ToDouble(value2) == 2.0;
												if (flag100)
												{
													bool flag101 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag101)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag102 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag102)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
											}
											catch (Exception ex6)
											{
											}
										}
									}
								}
								sqlDataReader5.Close();
							}
							bool flag103 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow3.Cells["Eliminar"].Value, true, false), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Tarjeta"].Value, 0, false)));
							if (flag103)
							{
								string text27 = "SELECT m from H";
								SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text27);
								bool flag104 = sqlDataReader5.Read();
								if (flag104)
								{
									string text33 = Tools.Desencriptar(sqlDataReader5[0].ToString().Trim());
									text27 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text33.ToString() + "'";
									sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(text27);
									bool hasRows42 = sqlDataReader5.HasRows;
									if (hasRows42)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num7.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery.execQuery(text5);
												bool flag105 = Operators.CompareString(text2, "Todas", false) == 0;
												if (flag105)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text5);
												}
												bool flag106 = Operators.CompareString(text2, "Todas", false) != 0;
												if (flag106)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text2,
														"'"
													});
													sqlQuery.execQuery(text5);
												}
												bool flag107 = Conversions.ToDouble(value2) == 4.0;
												if (flag107)
												{
													bool flag108 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag108)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag109 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag109)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												this.progBar.Value = 60;
												bool flag110 = Conversions.ToDouble(value2) == 3.0;
												if (flag110)
												{
													bool flag111 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag111)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag112 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag112)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag113 = Conversions.ToDouble(value2) == 1.0;
												if (flag113)
												{
													bool flag114 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag114)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag115 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag115)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag116 = Conversions.ToDouble(value2) == 2.0;
												if (flag116)
												{
													bool flag117 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag117)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag118 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag118)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
											}
											catch (Exception ex7)
											{
											}
										}
									}
								}
								sqlDataReader5.Close();
							}
							bool flag119 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow3.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Tarjeta"].Value, 0, false)));
							if (flag119)
							{
								string text27 = "SELECT m from H";
								SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text27);
								bool flag120 = sqlDataReader5.Read();
								if (flag120)
								{
									string text33 = Tools.Desencriptar(sqlDataReader5[0].ToString().Trim());
									text27 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text33.ToString() + "'";
									sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(text27);
									bool hasRows43 = sqlDataReader5.HasRows;
									if (hasRows43)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num7.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery.execQuery(text5);
												bool flag121 = Operators.CompareString(text2, "Todas", false) == 0;
												if (flag121)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text5);
												}
												bool flag122 = Operators.CompareString(text2, "Todas", false) != 0;
												if (flag122)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text2,
														"'"
													});
													sqlQuery.execQuery(text5);
												}
												bool flag123 = Conversions.ToDouble(value2) == 4.0;
												if (flag123)
												{
													bool flag124 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag124)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag125 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag125)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag126 = Conversions.ToDouble(value2) == 3.0;
												if (flag126)
												{
													bool flag127 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag127)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag128 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag128)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag129 = Conversions.ToDouble(value2) == 1.0;
												if (flag129)
												{
													bool flag130 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag130)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag131 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag131)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag132 = Conversions.ToDouble(value2) == 2.0;
												if (flag132)
												{
													bool flag133 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag133)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag134 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag134)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
											}
											catch (Exception ex8)
											{
											}
										}
									}
								}
								sqlDataReader5.Close();
							}
							bool flag135 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow3.Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Tarjeta"].Value, 0, false)));
							if (flag135)
							{
								string text27 = "SELECT m from H";
								SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text27);
								bool flag136 = sqlDataReader5.Read();
								if (flag136)
								{
									string text33 = Tools.Desencriptar(sqlDataReader5[0].ToString().Trim());
									text27 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text33.ToString() + "'";
									sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(text27);
									bool hasRows44 = sqlDataReader5.HasRows;
									if (hasRows44)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num7.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery.execQuery(text5);
												bool flag137 = Operators.CompareString(text2, "Todas", false) == 0;
												if (flag137)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text5);
												}
												bool flag138 = Operators.CompareString(text2, "Todas", false) != 0;
												if (flag138)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text2,
														"'"
													});
													sqlQuery.execQuery(text5);
												}
												bool flag139 = Conversions.ToDouble(value2) == 4.0;
												if (flag139)
												{
													bool flag140 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag140)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag141 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag141)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag142 = Conversions.ToDouble(value2) == 3.0;
												if (flag142)
												{
													bool flag143 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag143)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag144 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag144)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag145 = Conversions.ToDouble(value2) == 1.0;
												if (flag145)
												{
													bool flag146 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag146)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag147 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag147)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag148 = Conversions.ToDouble(value2) == 2.0;
												if (flag148)
												{
													bool flag149 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag149)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag150 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag150)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
											}
											catch (Exception ex9)
											{
											}
										}
									}
								}
								sqlDataReader5.Close();
							}
							bool flag151 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow3.Cells["Eliminar"].Value, true, false), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Tarjeta"].Value, 0, false)));
							if (flag151)
							{
								string text27 = "SELECT m from H";
								SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text27);
								bool flag152 = sqlDataReader5.Read();
								if (flag152)
								{
									string text33 = Tools.Desencriptar(sqlDataReader5[0].ToString().Trim());
									text27 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text33.ToString() + "'";
									sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(text27);
									bool hasRows45 = sqlDataReader5.HasRows;
									if (hasRows45)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num7.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery.execQuery(text5);
												bool flag153 = Operators.CompareString(text2, "Todas", false) == 0;
												if (flag153)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text5);
												}
												bool flag154 = Operators.CompareString(text2, "Todas", false) != 0;
												if (flag154)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text2,
														"'"
													});
													sqlQuery.execQuery(text5);
												}
												bool flag155 = Conversions.ToDouble(value2) == 4.0;
												if (flag155)
												{
													bool flag156 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag156)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag157 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag157)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag158 = Conversions.ToDouble(value2) == 3.0;
												if (flag158)
												{
													bool flag159 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag159)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag160 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag160)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag161 = Conversions.ToDouble(value2) == 1.0;
												if (flag161)
												{
													bool flag162 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag162)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag163 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag163)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag164 = Conversions.ToDouble(value2) == 2.0;
												if (flag164)
												{
													bool flag165 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag165)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag166 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag166)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
											}
											catch (Exception ex10)
											{
											}
										}
									}
								}
								sqlDataReader5.Close();
							}
							bool flag167 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridViewRow3.Cells["Eliminar"].Value, true, false), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(dataGridViewRow3.Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(dataGridViewRow3.Cells["Tarjeta"].Value, 0, false)));
							if (flag167)
							{
								string text27 = "SELECT m from H";
								SqlDataReader sqlDataReader5 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text27);
								bool flag168 = sqlDataReader5.Read();
								if (flag168)
								{
									string text33 = Tools.Desencriptar(sqlDataReader5[0].ToString().Trim());
									text27 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text33.ToString() + "'";
									sqlDataReader5 = (SqlDataReader)sqlQuery.execReader(text27);
									bool hasRows46 = sqlDataReader5.HasRows;
									if (hasRows46)
									{
										while (sqlDataReader5.Read())
										{
											string text29 = Conversions.ToString(sqlDataReader5[0]);
											string value2 = Conversions.ToString(sqlDataReader5[1]);
											try
											{
												text5 = string.Concat(new string[]
												{
													" insert into chequespagos (folio,idformadepago,importe,propina,tipodecambio,referencia,idturno_cierre,procesado,sistema_envio)\r\n                values ('",
													text26.ToString(),
													"','",
													text29.ToString(),
													"','",
													num7.ToString("N2"),
													"','0','1','','",
													this.idTurnoTicket.ToString(),
													"','1','1')"
												});
												sqlQuery.execQuery(text5);
												bool flag169 = Operators.CompareString(text2, "Todas", false) == 0;
												if (flag169)
												{
													text5 = "Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '" + text26 + "'";
													sqlQuery.execQuery(text5);
												}
												bool flag170 = Operators.CompareString(text2, "Todas", false) != 0;
												if (flag170)
												{
													text5 = string.Concat(new string[]
													{
														"Update cheques set efectivo='0.00' , tarjeta='0.00' , vales = '0.00' , otros='0.00' where folio= '",
														text26,
														"' and seriefolio = '",
														text2,
														"'"
													});
													sqlQuery.execQuery(text5);
												}
												bool flag171 = Conversions.ToDouble(value2) == 4.0;
												if (flag171)
												{
													bool flag172 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag172)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag173 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag173)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Otros = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag174 = Conversions.ToDouble(value2) == 3.0;
												if (flag174)
												{
													bool flag175 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag175)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag176 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag176)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Vales = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag177 = Conversions.ToDouble(value2) == 1.0;
												if (flag177)
												{
													bool flag178 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag178)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag179 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag179)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Efectivo = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
												bool flag180 = Conversions.ToDouble(value2) == 2.0;
												if (flag180)
												{
													bool flag181 = Operators.CompareString(text2, "Todas", false) == 0;
													if (flag181)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
													bool flag182 = Operators.CompareString(text2, "Todas", false) != 0;
													if (flag182)
													{
														text5 = string.Concat(new string[]
														{
															"Update cheques set Tarjeta = '",
															num7.ToString("N2"),
															"' where folio='",
															text26,
															"' and seriefolio = '",
															text2,
															"'"
														});
														sqlQuery.execQuery(text5);
													}
												}
											}
											catch (Exception ex11)
											{
											}
										}
									}
								}
								sqlDataReader5.Close();
							}
							text5 = "Select fecha , estacion from cheques where folio = " + text26 + " ";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
							bool hasRows47 = sqlDataReader2.HasRows;
							if (hasRows47)
							{
								sqlDataReader2.Read();
								this.fechaProducto = Conversions.ToDate(sqlDataReader2[0]);
								this.Estacion1 = Conversions.ToString(sqlDataReader2[1]);
							}
							try
							{
								bool flag183 = Operators.CompareString(text2, "Todas", false) == 0;
								if (flag183)
								{
									text5 = string.Concat(new string[]
									{
										"Update cheques Set total = '",
										num7.ToString("N2"),
										"'  , totalconpropina = '",
										num7.ToString("N2"),
										"' , TotalConCargo='",
										num7.ToString("N2"),
										"' ,  TotalConPropinaCargo='",
										num7.ToString("N2"),
										"'    where folio = '",
										text26,
										"'"
									});
									sqlQuery.execQuery(text5);
								}
								bool flag184 = Operators.CompareString(text2, "Todas", false) != 0;
								if (flag184)
								{
									text5 = string.Concat(new string[]
									{
										"Update cheques set total = '",
										num7.ToString("N2"),
										"'  ,totalconpropina = '",
										num7.ToString("N2"),
										"' , TotalConCargo='",
										num7.ToString("N2"),
										"' ,  TotalConPropinaCargo='",
										num7.ToString("N2"),
										"'   where folio = '",
										text26,
										"' and seriefolio = '",
										text2,
										"'"
									});
									sqlQuery.execQuery(text5);
								}
							}
							catch (Exception ex12)
							{
							}
							bool flag185 = Operators.CompareString(text2, "Todas", false) == 0;
							if (flag185)
							{
								try
								{
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows48 = sqlDataReader2.HasRows;
									if (hasRows48)
									{
										while (sqlDataReader2.Read())
										{
											double num12 = Conversions.ToDouble(sqlDataReader2[0]);
											text5 = string.Concat(new string[]
											{
												"Update cheques Set  totalimpuesto1='",
												num5.ToString("N2"),
												"' ,  totalimpuestod1='",
												num5.ToString("N2"),
												"' where folio = '",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=2";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows49 = sqlDataReader2.HasRows;
									if (hasRows49)
									{
										while (sqlDataReader2.Read())
										{
											double num13 = Conversions.ToDouble(sqlDataReader2[0]);
											text5 = string.Concat(new string[]
											{
												"Update cheques Set totalimpuesto1='",
												num5.ToString("N2"),
												"' ,  totalimpuestod1='",
												num5.ToString("N2"),
												"' where folio = '",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=3";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows50 = sqlDataReader2.HasRows;
									if (hasRows50)
									{
										while (sqlDataReader2.Read())
										{
											double num14 = Conversions.ToDouble(sqlDataReader2[0]);
											text5 = string.Concat(new string[]
											{
												"Update cheques Set  totalimpuesto1='",
												num5.ToString("N2"),
												"' ,  totalimpuestod1='",
												num5.ToString("N2"),
												"' where folio = '",
												text26,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
									}
								}
								catch (Exception ex13)
								{
								}
							}
							bool flag186 = Operators.CompareString(text2, "Todas", false) != 0;
							if (flag186)
							{
								try
								{
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                            Inner Join Productos B on B.idproducto = a.idproducto\r\n                                            Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                            Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                            WHERE\r\n                                            a.foliodet='" + text26 + "' and d.clasificacionventa=1";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows51 = sqlDataReader2.HasRows;
									if (hasRows51)
									{
										while (sqlDataReader2.Read())
										{
											double num12 = Conversions.ToDouble(sqlDataReader2[0]);
											text5 = string.Concat(new string[]
											{
												"Update cheques Set  totalimpuesto1='",
												num5.ToString("N2"),
												"' ,  totalimpuestod1='",
												num5.ToString("N2"),
												"' where folio = '",
												text26,
												"' and seriefolio = '",
												text2,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
										sqlDataReader2.Close();
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)   from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=2";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows52 = sqlDataReader2.HasRows;
									if (hasRows52)
									{
										while (sqlDataReader2.Read())
										{
											double num13 = Conversions.ToDouble(sqlDataReader2[0]);
											text5 = string.Concat(new string[]
											{
												"Update cheques Set  totalimpuesto1='",
												num5.ToString("N2"),
												"' ,  totalimpuestod1='",
												num5.ToString("N2"),
												"' where folio = '",
												text26,
												"' and seriefolio = '",
												text2,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
									}
									text5 = "select ISNULL(sum(preciosinimpuestos*cantidad),0)  from cheqdet A \r\n                                                        Inner Join Productos B on B.idproducto = a.idproducto\r\n                                                        Inner join grupos C on C.idgrupo = b.idgrupo\r\n                                                        Inner Join gruposiclasificacion D on D.clasificacionventa = c.clasificacion \r\n                                                        WHERE\r\n                                                        a.foliodet='" + text26 + "' and d.clasificacionventa=3";
									sqlDataReader2 = (SqlDataReader)sqlQuery3.execReader(text5);
									bool hasRows53 = sqlDataReader2.HasRows;
									if (hasRows53)
									{
										while (sqlDataReader2.Read())
										{
											double num14 = Conversions.ToDouble(sqlDataReader2[0]);
											sqlQuery.execQuery(text5);
											text5 = string.Concat(new string[]
											{
												"Update cheques Set  totalimpuesto1='",
												num5.ToString("N2"),
												"' ,  totalimpuestod1='",
												num5.ToString("N2"),
												"' where folio = '",
												text26,
												"' and seriefolio = '",
												text2,
												"'"
											});
											sqlQuery.execQuery(text5);
										}
									}
								}
								catch (Exception ex14)
								{
								}
							}
							sqlDataReader2.Close();
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
				string text34 = Conversions.ToDate(this.dateFechaIni.Text + " " + this.dateHoraIni.Text).ToString(Tools.strFormatoFechaLargo);
				string text35 = Conversions.ToDate(this.dateFechaFin.Text + " " + this.dateHoraFin.Text).ToString(Tools.strFormatoFechaLargo);
				this.progBar.Value = 70;
				List<string> list2 = new List<string>();
				text5 = string.Concat(new string[]
				{
					"select distinct (idturno) from turnos where apertura between '",
					text34,
					"' and '",
					text35,
					"' and cierre is not  null"
				});
				sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
				bool hasRows54 = sqlDataReader2.HasRows;
				if (hasRows54)
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
					text34,
					"' and '",
					text35,
					"' and cierre is not  null"
				});
				sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
				bool hasRows55 = sqlDataReader2.HasRows;
				if (hasRows55)
				{
					sqlDataReader2.Read();
				}
				sqlDataReader2.Close();
				try
				{
					foreach (string text36 in list2)
					{
						string text37 = "select n from H";
						SqlDataReader sqlDataReader6 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text37);
						bool hasRows56 = sqlDataReader6.HasRows;
						if (hasRows56)
						{
							while (sqlDataReader6.Read())
							{
								bool flag187 = Operators.CompareString(Tools.Desencriptar(sqlDataReader6[0].ToString().Trim()), "1", false) == 0;
								if (flag187)
								{
									text37 = "delete from movsinv where idconcepto='SPV' and idturno ='" + text36 + "'";
									sqlQuery3.execQuery(text37);
								}
							}
						}
						this.progBar.Value = 80;
						bool @checked = this.chkEliminaProp.Checked;
						if (@checked)
						{
							text5 = "delete from movtoscaja where idturno  = '" + text36 + "' And  pagodepropina = 1";
							sqlQuery.execQuery(text5);
							bool flag188 = Operators.CompareString(text2, "Todas", false) == 0;
							if (flag188)
							{
								text5 = "update cheques set propina=0 , propinafoliomovtocaja =0 where idturno='" + text36 + "'";
								sqlQuery.execQuery(text5);
							}
							bool flag189 = Operators.CompareString(text2, "Todas", false) != 0;
							if (flag189)
							{
								text5 = string.Concat(new string[]
								{
									"update cheques set propina=0 , propinafoliomovtocaja =0 where idturno='",
									text36,
									"' and seriefolio = '",
									text2,
									"'"
								});
								sqlQuery.execQuery(text5);
							}
						}
						else
						{
							text5 = "Select ISNULL(sum(importe),0) from movtoscaja Where idturno = '" + text36 + "' And  pagodepropina = 1";
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
							sqlDataReader2.Read();
							num2 = Conversions.ToDouble(sqlDataReader2[0]);
							sqlDataReader2.Close();
						}
						bool checked2 = this.chkEliminaRet.Checked;
						if (checked2)
						{
							text5 = "delete from movtoscaja Where idturno = '" + text36 + "' And pagodepropina <1";
							sqlQuery.execQuery(text5);
						}
						bool flag190 = Operators.CompareString(text2, "Todas", false) == 0;
						if (flag190)
						{
							text5 = string.Concat(new string[]
							{
								"Select \r\n                            ISNULL(sum(efectivo),0),\r\n                            ISNULL(sum(tarjeta),0),\r\n                            ISNULL(sum(vales),0),\r\n                            ISNULL(sum(otros),0)\r\n                            from cheques WHERE idempresa='",
								Tools.id_Empresa,
								"' and  idturno = '",
								text36,
								"'"
							});
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
							sqlDataReader2.Read();
							double num24 = Conversions.ToDouble(Operators.SubtractObject(sqlDataReader2[0], num2));
							double num25 = Conversions.ToDouble(sqlDataReader2[1]);
							double num26 = Conversions.ToDouble(sqlDataReader2[2]);
							double num27 = Conversions.ToDouble(sqlDataReader2[3]);
							double num28 = num24;
							text5 = string.Concat(new string[]
							{
								"Update turnos Set efectivo='",
								num28.ToString("N2"),
								"',tarjeta='",
								num25.ToString("N2"),
								"',vales='",
								num26.ToString("N2"),
								"', credito='",
								num27.ToString("N2"),
								"' Where idturno = '",
								text36,
								"'"
							});
							sqlQuery.execQuery(text5);
						}
						bool flag191 = Operators.CompareString(text2, "Todas", false) != 0;
						if (flag191)
						{
							text5 = string.Concat(new string[]
							{
								"Select \r\n                            ISNULL(sum(efectivo),0),\r\n                            ISNULL(sum(tarjeta),0),\r\n                            ISNULL(sum(vales),0),\r\n                            ISNULL(sum(otros),0)\r\n                            from cheques WHERE idempresa='",
								Tools.id_Empresa,
								"' and  idturno = '",
								text36,
								"' and seriefolio = '",
								text2,
								"'"
							});
							sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
							sqlDataReader2.Read();
							double num24 = Conversions.ToDouble(Operators.SubtractObject(sqlDataReader2[0], num2));
							double num25 = Conversions.ToDouble(sqlDataReader2[1]);
							double num26 = Conversions.ToDouble(sqlDataReader2[2]);
							double num27 = Conversions.ToDouble(sqlDataReader2[3]);
							double num28 = num24;
							text5 = string.Concat(new string[]
							{
								"Update turnos Set efectivo='",
								num28.ToString("N2"),
								"',tarjeta='",
								num25.ToString("N2"),
								"',vales='",
								num26.ToString("N2"),
								"', credito='",
								num27.ToString("N2"),
								"' Where idturno = '",
								text36,
								"'"
							});
							sqlQuery.execQuery(text5);
						}
						bool checked3 = this.CheckBoxfondocaja.Checked;
						if (checked3)
						{
							text5 = "update turnos set fondo=0 Where idturno = '" + text36 + "'";
							sqlQuery.execQuery(text5);
						}
						try
						{
						}
						catch (Exception ex15)
						{
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator5;
					((IDisposable)enumerator5).Dispose();
				}
				this.progBar.Value = 90;
				this.txtMinimo.Text = Conversions.ToString(0);
				this.txtDescto.Text = Conversions.ToString(0);
				string text38 = DateAndTime.Now.ToString(Tools.strFormatoFechaLargo);
				string text39 = this.txtCuentasModificar.Text;
				string text40 = this.txtCuentasTotal.Text;
				double num29 = Conversions.ToDouble(this.txtImpAnterior.Text);
				double num30 = Conversions.ToDouble(this.txtImpNuevo.Text);
				double num31 = Conversions.ToDouble(this.txtEfectivoAnt.Text);
				double num32 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
				double num33 = Conversions.ToDouble(this.txtVentaTarjeta.Text);
				double num34 = Conversions.ToDouble(this.txtDifTarjeta.Text);
				double num35 = Conversions.ToDouble(this.txtVentasOtros.Text);
				double num36 = Conversions.ToDouble(this.txtdifotros.Text);
				double num37 = Conversions.ToDouble(this.txtVales.Text);
				double num38 = Conversions.ToDouble(this.txtdifvales.Text);
				double num39 = Conversions.ToDouble(this.txtTotalPropinas.Text);
				double num40 = Conversions.ToDouble(this.txttotalnuevopropinas.Text);
				string text41 = MyProject.Forms.main.lblNombreUsuario.Text;
				string text42 = this.cmbxEmpresa.Text;
				text5 = "Select h from H";
				sqlDataReader2 = (SqlDataReader)sqlQuery_Conn.execReader_conn(text5);
				bool hasRows57 = sqlDataReader2.HasRows;
				if (hasRows57)
				{
					while (sqlDataReader2.Read())
					{
						bool flag192 = Operators.CompareString(Tools.Desencriptar(sqlDataReader2[0].ToString().Trim()), "1", false) == 0;
						if (flag192)
						{
							try
							{
								text5 = string.Concat(new string[]
								{
									"Insert into I ( a ,b ,c ,d ,e ,f ,g ,h ,i ,j , k , l , m, n , o , p , q , r , s , t , u , w , x  )Values ( '",
									text38,
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
									"' , '",
									Tools.Encriptar(this.lblCOdigoUnicoCorte.Text.Trim()),
									"')"
								});
								sqlQuery_Conn.execQuery_conn(text5);
								this.InsertarCorteBitacora();
							}
							catch (Exception ex16)
							{
							}
						}
					}
					sqlDataReader2.Close();
				}
				checked
				{
					try
					{
						foreach (object obj6 in ((IEnumerable)this.dgvNotas.Rows))
						{
							DataGridViewRow dataGridViewRow4 = (DataGridViewRow)obj6;
							bool flag193 = Operators.ConditionalCompareObjectEqual(dataGridViewRow4.Cells["Eliminar"].Value, true, false);
							if (flag193)
							{
								string text43 = Conversions.ToString(dataGridViewRow4.Cells["id_nota"].Value);
								text5 = "SELECT movimiento,hora,idproducto from cheqdet where foliodet ='" + text43.ToString() + "' order by hora,movimiento asc";
								sqlDataReader2 = (SqlDataReader)sqlQuery.execReader(text5);
								bool hasRows58 = sqlDataReader2.HasRows;
								if (hasRows58)
								{
									while (sqlDataReader2.Read())
									{
										int num41 = Conversions.ToInteger(sqlDataReader2[0]);
										DateTime dateTime4 = Conversions.ToDate(sqlDataReader2[1]);
										string text44 = Conversions.ToString(sqlDataReader2[2]);
										num++;
										text5 = string.Concat(new string[]
										{
											"  Update cheqdet set movimiento = ",
											num.ToString(),
											" where foliodet ='",
											text43.ToString(),
											"' and movimiento=",
											num41.ToString(),
											" and hora='",
											dateTime4.ToString(Tools.strFormatoFechaLargo),
											"' and idproducto='",
											text44.ToString(),
											"'"
										});
										sqlQuery.execQuery(text5);
									}
									num = 0;
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
					text5 = "Delete from F";
					sqlQuery_Conn.execQuery_conn(text5);
					text5 = "Delete from FF";
					sqlQuery_Conn.execQuery_conn(text5);
					sqlDataReader2.Close();
					this.iniciaGridFolio();
					this.progBar.Value = 100;
					Interaction.MsgBox("Proceso Finalizado, los totales se actualizaron en el software para restaurante", MsgBoxStyle.OkOnly, null);
					this.habilitaControles(true);
					frmWaitMsg frmWaitMsg = new frmWaitMsg();
					frmWaitMsg.Show();
					Application.DoEvents();
					this.refrescaDatos();
					this.btnAplicar.Enabled = false;
					frmWaitMsg.Hide();
					this.Button2.PerformClick();
					try
					{
						foreach (object obj7 in ((IEnumerable)this.dgvNotas.Rows))
						{
							object objectValue = RuntimeHelpers.GetObjectValue(obj7);
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "cells", new object[]
							{
								18
							}, null, null, null), null, "value", new object[]
							{
								false
							}, null, null, false, true);
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "DefaultCellStyle", new object[0], null, null, null), null, "BackColor", new object[]
							{
								Color.White
							}, null, null, false, true);
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
					this.dgvNotas.Enabled = false;
					this.txtCuentasModificar.Text = Conversions.ToString(0);
				}
			}
			this.progBar.Value = 0;
			bool flag194 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.No, false);
			if (flag194)
			{
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00089770 File Offset: 0x00087970
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

		// Token: 0x060007E7 RID: 2023 RVA: 0x00089A5C File Offset: 0x00087C5C
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

		// Token: 0x060007E8 RID: 2024 RVA: 0x000036D5 File Offset: 0x000018D5
		private void chkReemplazar_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00089D25 File Offset: 0x00087F25
		private void txtDescto_TextChanged(object sender, EventArgs e)
		{
			this.txtMinimo.Text = Conversions.ToString(0);
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x000036D5 File Offset: 0x000018D5
		private void obtener_datos_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00089D3C File Offset: 0x00087F3C
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery = new SqlQuery();
			string text = "SELECT an from H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool flag = sqlDataReader.Read();
			if (flag)
			{
				this.Descomponercuentas = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
			}
			bool flag2 = Operators.CompareString(this.Descomponercuentas, "1", false) == 0;
			if (flag2)
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						string text2 = Conversions.ToString(dataGridViewRow.Cells["id_nota"].Value);
						bool flag3 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["Eliminar"].Value, true, false);
						if (flag3)
						{
							text = "DELETE FROM F where a ='" + text2 + "'";
							sqlQuery_Conn.execQuery_conn(text);
							text = "select a , b , c ,d, e , f , g ,  h , i , j , k , l , m ,\r\n                n , o ,p , q , r , s , t , u, w , \r\n                x , y , z , aa , bb , cc , dd , ee ,\r\n                ff ,gg ,hh, ii , kk ,\r\n                kk , ll , mm , nn , oo , pp , qq , rr, ss , \r\n               tt , uu, ww , xx , yy ,zz\r\n                from FF where a = '" + text2 + "' order by b asc";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
							bool hasRows = sqlDataReader.HasRows;
							if (hasRows)
							{
								text = "Delete from Cheqdet where Foliodet = '" + text2 + "'";
								sqlQuery.execQuery(text);
								while (sqlDataReader.Read())
								{
									int num = Conversions.ToInteger(sqlDataReader[3]);
									string text3 = Conversions.ToString(sqlDataReader[1]);
									string text4 = Conversions.ToString(sqlDataReader[2]);
									string text5 = Conversions.ToString(sqlDataReader[4]);
									double num2 = Conversions.ToDouble(sqlDataReader[5]);
									double num3 = Conversions.ToDouble(sqlDataReader[6]);
									double num4 = Conversions.ToDouble(sqlDataReader[7]);
									double num5 = Conversions.ToDouble(sqlDataReader[8]);
									double num6 = Conversions.ToDouble(sqlDataReader[9]);
									double num7 = Conversions.ToDouble(sqlDataReader[10]);
									string text6 = Conversions.ToString(sqlDataReader[11]);
									DateTime dateTime = Conversions.ToDate(sqlDataReader[12]);
									string text7 = Conversions.ToString(sqlDataReader[13]);
									string text8 = Conversions.ToString(sqlDataReader[14]);
									string text9 = Conversions.ToString(sqlDataReader[15]);
									string text10 = Conversions.ToString(sqlDataReader[16]);
									string text11 = Conversions.ToString(sqlDataReader[17]);
									string text12 = Conversions.ToString(sqlDataReader[18]);
									string text13 = Conversions.ToString(sqlDataReader[19]);
									DateTime dateTime2 = Conversions.ToDate(sqlDataReader[20]);
									string text14 = Conversions.ToString(sqlDataReader[21]);
									string text15 = Conversions.ToString(sqlDataReader[22]);
									double num8 = Conversions.ToDouble(sqlDataReader[23]);
									string text16 = Conversions.ToString(sqlDataReader[24]);
									string text17 = Conversions.ToString(sqlDataReader[25]);
									string text18 = Conversions.ToString(sqlDataReader[26]);
									string text19 = Conversions.ToString(sqlDataReader[27]);
									string text20 = Conversions.ToString(sqlDataReader[28]);
									string text21 = Conversions.ToString(sqlDataReader[29]);
									string text22 = Conversions.ToString(sqlDataReader[30]);
									string text23 = Conversions.ToString(sqlDataReader[31]);
									DateTime dateTime3 = Conversions.ToDate(sqlDataReader[32]);
									string text24 = Conversions.ToString(sqlDataReader[33]);
									string text25 = Conversions.ToString(sqlDataReader[34]);
									string text26 = Conversions.ToString(sqlDataReader[35]);
									string text27 = Conversions.ToString(sqlDataReader[36]);
									string text28 = Conversions.ToString(sqlDataReader[37]);
									string text29 = Conversions.ToString(sqlDataReader[38]);
									string text30 = Conversions.ToString(sqlDataReader[39]);
									string text31 = Conversions.ToString(sqlDataReader[40]);
									string text32 = Conversions.ToString(sqlDataReader[41]);
									string text33 = Conversions.ToString(sqlDataReader[42]);
									string text34 = Conversions.ToString(sqlDataReader[43]);
									string text35 = Conversions.ToString(sqlDataReader[44]);
									double num9 = Conversions.ToDouble(sqlDataReader[45]);
									string text36 = Conversions.ToString(sqlDataReader[46]);
									string text37 = Conversions.ToString(sqlDataReader[47]);
									string text38 = Conversions.ToString(sqlDataReader[48]);
									string text39 = Conversions.ToString(sqlDataReader[49]);
									text = string.Concat(new string[]
									{
										"insert into cheqdet (\r\n                                Foliodet,\r\n                                movimiento,\r\n                                comanda,\r\n                                cantidad,\r\n                                idproducto,\r\n                                descuento,\r\n                                precio,\r\n                                impuesto1,\r\n                                impuesto2,\r\n                                impuesto3,\r\n                                preciosinimpuestos,\r\n                                tiempo,\r\n                                hora,\r\n                                modificador,\r\n                                mitad,\r\n                                comentario,\r\n                                idestacion,\r\n                                usuariodescuento,\r\n                                comentariodescuento,\r\n                                idtipodescuento,\r\n                                horaproduccion,\r\n                                idproductocompuesto,\r\n                                productocompuestoprincipal,\r\n                                preciocatalogo,\r\n                                marcar,\r\n                                idmeseroproducto,\r\n                                prioridadproduccion,\r\n                                estatuspatin,\r\n                                idcortesia,\r\n                                numerotarjeta,\r\n                                estadomonitor,\r\n                                llavemovto,\r\n                                horameserofinalizado,\r\n                                meserofinalizado,\r\n                                sistema_envio,\r\n                                idturno_cierre,\r\n                                procesado,\r\n                                promovolumen,\r\n                                iddispositivo,\r\n                                productsyncidsr,\r\n                                subtotalsrx,\r\n                                totalsrx,\r\n                                idmovtobillar,\r\n                                idlistaprecio,\r\n                                tipocambio,\r\n                                impuestoimporte3,\r\n                                estrateca_DiscountCode,\r\n                                estrateca_DiscountID,\r\n                                estrateca_DiscountAmount,\r\n                                saledetailid\r\n\r\n                               )\r\n\r\n\r\n                               Values(\r\n                                '",
										text2.ToString(),
										"',\r\n                                '",
										text3.ToString(),
										"',\r\n                                '",
										text4.ToString(),
										"',\r\n                                '",
										num.ToString(),
										"',\r\n                                '",
										text5.ToString(),
										"',\r\n                                '",
										num2.ToString(),
										"',\r\n                                '",
										num3.ToString("N2"),
										"',\r\n                                '",
										num4.ToString("N2"),
										"',\r\n                                '",
										num5.ToString("N2"),
										"',\r\n                                '",
										num6.ToString("N2"),
										"',\r\n                                '",
										num7.ToString("N2"),
										"',\r\n                                '",
										text6,
										"',\r\n                                '",
										dateTime.ToString(Tools.strFormatoFechaLargo),
										"',\r\n                                '",
										text7.ToString(),
										"',\r\n                                '",
										text8.ToString(),
										"',\r\n                                '",
										text9.ToString(),
										"',\r\n                                '",
										text10.ToString(),
										"',\r\n                                '",
										text11,
										"',\r\n                                '",
										text12.ToString(),
										"',\r\n                                '",
										text13.ToString(),
										"',\r\n                                '",
										dateTime2.ToString(Tools.strFormatoFechaLargo),
										"',\r\n                                '",
										text14.ToString(),
										"',\r\n                                '",
										text15.ToString(),
										"',\r\n                                '",
										num8.ToString("N2"),
										"',\r\n                                '",
										text16.ToString(),
										"',\r\n                                '",
										text17.ToString(),
										"',\r\n                                '",
										text18.ToString(),
										"',\r\n                                ",
										text19.ToString(),
										",\r\n                                '",
										text20.ToString(),
										"',\r\n                                '",
										text21.ToString(),
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
										text26.ToString(),
										"',\r\n                                '",
										text27.ToString(),
										"',\r\n                                '",
										text28.ToString(),
										"',\r\n                                '",
										text29.ToString(),
										"',\r\n                                '",
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
										num9.ToString("N2"),
										"',                            \r\n                                '",
										text36.ToString(),
										"',\r\n                                '",
										text37.ToString(),
										"',\r\n                                '",
										text38,
										"',\r\n                                '",
										text39.ToString(),
										"')"
									});
									sqlQuery.execQuery(text);
								}
								text = "DELETE FROM FF where a = '" + text2 + "'";
								sqlQuery_Conn.execQuery_conn(text);
							}
							sqlDataReader.Close();
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
			bool flag4 = Operators.CompareString(this.Descomponercuentas, "0", false) == 0;
			if (flag4)
			{
				try
				{
					foreach (object obj2 in ((IEnumerable)this.dgvNotas.Rows))
					{
						DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
						string text2 = Conversions.ToString(dataGridViewRow2.Cells["id_nota"].Value);
						bool flag5 = Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells["Eliminar"].Value, true, false);
						if (flag5)
						{
							text = "DELETE FROM F where a ='" + text2 + "'";
							sqlQuery_Conn.execQuery_conn(text);
							text = "select a , b , c ,d, e , f , g ,  h , i , j , k , l , m ,\r\n                n , o ,p , q , r , s , t , u, w , \r\n                x , y , z , aa , bb , cc , dd , ee ,\r\n                ff ,gg ,hh, ii , kk ,\r\n                kk , ll , mm , nn , oo , pp , qq , rr, ss , \r\n               tt , uu, ww , xx , yy ,zz\r\n                from FF where a = '" + text2 + "' order by b asc";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
							bool hasRows2 = sqlDataReader.HasRows;
							if (hasRows2)
							{
								text = "Delete from Cheqdet where Foliodet = '" + text2 + "'";
								sqlQuery.execQuery(text);
								while (sqlDataReader.Read())
								{
									int num = Conversions.ToInteger(sqlDataReader[3]);
									string text3 = Conversions.ToString(sqlDataReader[1]);
									string text4 = Conversions.ToString(sqlDataReader[2]);
									string text5 = Conversions.ToString(sqlDataReader[4]);
									double num2 = Conversions.ToDouble(sqlDataReader[5]);
									double num3 = Conversions.ToDouble(sqlDataReader[6]);
									double num4 = Conversions.ToDouble(sqlDataReader[7]);
									double num5 = Conversions.ToDouble(sqlDataReader[8]);
									double num6 = Conversions.ToDouble(sqlDataReader[9]);
									double num7 = Conversions.ToDouble(sqlDataReader[10]);
									string text6 = Conversions.ToString(sqlDataReader[11]);
									DateTime dateTime = Conversions.ToDate(sqlDataReader[12]);
									string text7 = Conversions.ToString(sqlDataReader[13]);
									string text8 = Conversions.ToString(sqlDataReader[14]);
									string text9 = Conversions.ToString(sqlDataReader[15]);
									string text10 = Conversions.ToString(sqlDataReader[16]);
									string text11 = Conversions.ToString(sqlDataReader[17]);
									string text12 = Conversions.ToString(sqlDataReader[18]);
									string text13 = Conversions.ToString(sqlDataReader[19]);
									DateTime dateTime2 = Conversions.ToDate(sqlDataReader[20]);
									string text14 = Conversions.ToString(sqlDataReader[21]);
									string text15 = Conversions.ToString(sqlDataReader[22]);
									double num8 = Conversions.ToDouble(sqlDataReader[23]);
									string text16 = Conversions.ToString(sqlDataReader[24]);
									string text17 = Conversions.ToString(sqlDataReader[25]);
									string text18 = Conversions.ToString(sqlDataReader[26]);
									string text19 = Conversions.ToString(sqlDataReader[27]);
									string text20 = Conversions.ToString(sqlDataReader[28]);
									string text21 = Conversions.ToString(sqlDataReader[29]);
									string text22 = Conversions.ToString(sqlDataReader[30]);
									string text23 = Conversions.ToString(sqlDataReader[31]);
									DateTime dateTime3 = Conversions.ToDate(sqlDataReader[32]);
									string text24 = Conversions.ToString(sqlDataReader[33]);
									string text25 = Conversions.ToString(sqlDataReader[34]);
									string text26 = Conversions.ToString(sqlDataReader[35]);
									string text27 = Conversions.ToString(sqlDataReader[36]);
									string text28 = Conversions.ToString(sqlDataReader[37]);
									string text29 = Conversions.ToString(sqlDataReader[38]);
									string text30 = Conversions.ToString(sqlDataReader[39]);
									string text31 = Conversions.ToString(sqlDataReader[40]);
									string text32 = Conversions.ToString(sqlDataReader[41]);
									string text33 = Conversions.ToString(sqlDataReader[42]);
									string text34 = Conversions.ToString(sqlDataReader[43]);
									string text35 = Conversions.ToString(sqlDataReader[44]);
									double num9 = Conversions.ToDouble(sqlDataReader[45]);
									string text36 = Conversions.ToString(sqlDataReader[46]);
									string text37 = Conversions.ToString(sqlDataReader[47]);
									string text38 = Conversions.ToString(sqlDataReader[48]);
									string text39 = Conversions.ToString(sqlDataReader[49]);
									text = string.Concat(new string[]
									{
										"insert into cheqdet (\r\n                                Foliodet,\r\n                                movimiento,\r\n                                comanda,\r\n                                cantidad,\r\n                                idproducto,\r\n                                descuento,\r\n                                precio,\r\n                                impuesto1,\r\n                                impuesto2,\r\n                                impuesto3,\r\n                                preciosinimpuestos,\r\n                                tiempo,\r\n                                hora,\r\n                                modificador,\r\n                                mitad,\r\n                                comentario,\r\n                                idestacion,\r\n                                usuariodescuento,\r\n                                comentariodescuento,\r\n                                idtipodescuento,\r\n                                horaproduccion,\r\n                                idproductocompuesto,\r\n                                productocompuestoprincipal,\r\n                                preciocatalogo,\r\n                                marcar,\r\n                                idmeseroproducto,\r\n                                prioridadproduccion,\r\n                                estatuspatin,\r\n                                idcortesia,\r\n                                numerotarjeta,\r\n                                estadomonitor,\r\n                                llavemovto,\r\n                                horameserofinalizado,\r\n                                meserofinalizado,\r\n                                sistema_envio,\r\n                                idturno_cierre,\r\n                                procesado,\r\n                                promovolumen,\r\n                                iddispositivo,\r\n                                productsyncidsr,\r\n                                subtotalsrx,\r\n                                totalsrx,\r\n                                idmovtobillar,\r\n                                idlistaprecio,\r\n                                tipocambio,\r\n                                impuestoimporte3,\r\n                                estrateca_DiscountCode,\r\n                                estrateca_DiscountID,\r\n                                estrateca_DiscountAmount,\r\n                                saledetailid\r\n\r\n                               )\r\n\r\n\r\n                               Values(\r\n                                '",
										text2.ToString(),
										"',\r\n                                '",
										text3.ToString(),
										"',\r\n                                '",
										text4.ToString(),
										"',\r\n                                '",
										num.ToString(),
										"',\r\n                                '",
										text5.ToString(),
										"',\r\n                                '",
										num2.ToString(),
										"',\r\n                                '",
										num3.ToString("N2"),
										"',\r\n                                '",
										num4.ToString("N2"),
										"',\r\n                                '",
										num5.ToString("N2"),
										"',\r\n                                '",
										num6.ToString("N2"),
										"',\r\n                                '",
										num7.ToString("N2"),
										"',\r\n                                '",
										text6,
										"',\r\n                                '",
										dateTime.ToString(Tools.strFormatoFechaLargo),
										"',\r\n                                '",
										text7.ToString(),
										"',\r\n                                '",
										text8.ToString(),
										"',\r\n                                '",
										text9.ToString(),
										"',\r\n                                '",
										text10.ToString(),
										"',\r\n                                '",
										text11,
										"',\r\n                                '",
										text12.ToString(),
										"',\r\n                                '",
										text13.ToString(),
										"',\r\n                                '",
										dateTime2.ToString(Tools.strFormatoFechaLargo),
										"',\r\n                                '",
										text14.ToString(),
										"',\r\n                                '",
										text15.ToString(),
										"',\r\n                                '",
										num8.ToString("N2"),
										"',\r\n                                '",
										text16.ToString(),
										"',\r\n                                '",
										text17.ToString(),
										"',\r\n                                '",
										text18.ToString(),
										"',\r\n                                ",
										text19.ToString(),
										",\r\n                                '",
										text20.ToString(),
										"',\r\n                                '",
										text21.ToString(),
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
										text26.ToString(),
										"',\r\n                                '",
										text27.ToString(),
										"',\r\n                                '",
										text28.ToString(),
										"',\r\n                                '",
										text29.ToString(),
										"',\r\n                                '",
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
										num9.ToString("N2"),
										"',                            \r\n                                '",
										text36.ToString(),
										"',\r\n                                '",
										text37.ToString(),
										"',\r\n                                '",
										text38,
										"',\r\n                                '",
										text39.ToString(),
										"')"
									});
									sqlQuery.execQuery(text);
								}
								text = "DELETE FROM FF where a = '" + text2 + "'";
								sqlQuery_Conn.execQuery_conn(text);
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
			base.Hide();
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0008AEDC File Offset: 0x000890DC
		private void txtDescto_Click(object sender, EventArgs e)
		{
			this.txtMinimo.Text = Conversions.ToString(0);
			this.txtDescto.SelectAll();
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0008AEFD File Offset: 0x000890FD
		private void txtMinimo_TextChanged(object sender, EventArgs e)
		{
			this.txtDescto.Text = Conversions.ToString(0);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0008AF12 File Offset: 0x00089112
		private void txtMinimo_Click(object sender, EventArgs e)
		{
			this.txtDescto.Text = Conversions.ToString(0);
			this.txtMinimo.SelectAll();
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0008AF33 File Offset: 0x00089133
		private void BtnHorario_Click(object sender, EventArgs e)
		{
			this.BtnHorario.Enabled = false;
			this.dateHoraIni.Enabled = true;
			this.dateHoraFin.Enabled = true;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtVentaTarjeta_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox2_DoubleClick(object sender, EventArgs e)
		{
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0008AF5D File Offset: 0x0008915D
		private void PictureBox3_Click(object sender, EventArgs e)
		{
			this.Panelvercortes.Visible = false;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBox5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0008AF6D File Offset: 0x0008916D
		private void PictureBox5_Click_1(object sender, EventArgs e)
		{
			this.PanelCheqdet.Visible = false;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0008AF7D File Offset: 0x0008917D
		private void PictureBox7_Click(object sender, EventArgs e)
		{
			this.Panel1.Visible = false;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0008AF8D File Offset: 0x0008918D
		private void PictureBox6_Click(object sender, EventArgs e)
		{
			this.Panel1.Visible = true;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0008AFA0 File Offset: 0x000891A0
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.progBar.Value = DateAndTime.Now.Second;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0008AFC7 File Offset: 0x000891C7
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Timer1.Enabled = true;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0008AFD7 File Offset: 0x000891D7
		private void PictureBox8_Click(object sender, EventArgs e)
		{
			this.PanelDetalleTicket.Visible = false;
			this.dgvNotas.Enabled = true;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0008AFF4 File Offset: 0x000891F4
		private void iniciaGridCheqDetalleSeleccion()
		{
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			this.DataGridDetalleTickets.Rows.Clear();
			this.DataGridDetalleTickets.ColumnCount = 11;
			this.DataGridDetalleTickets.Columns[0].Name = "Foliodet";
			this.DataGridDetalleTickets.Columns[0].Visible = false;
			this.DataGridDetalleTickets.Columns[0].ReadOnly = true;
			this.DataGridDetalleTickets.Columns[0].Width = 57;
			this.DataGridDetalleTickets.Columns[1].Name = "Mov.";
			this.DataGridDetalleTickets.Columns[1].Width = 57;
			this.DataGridDetalleTickets.Columns[1].ReadOnly = true;
			this.DataGridDetalleTickets.Columns[2].Name = "Cantidad";
			this.DataGridDetalleTickets.Columns[2].Width = 70;
			this.DataGridDetalleTickets.Columns[2].ReadOnly = true;
			this.DataGridDetalleTickets.Columns[3].Name = "idProducto";
			this.DataGridDetalleTickets.Columns[3].Width = 60;
			this.DataGridDetalleTickets.Columns[3].ReadOnly = true;
			this.DataGridDetalleTickets.Columns[3].Visible = false;
			this.DataGridDetalleTickets.Columns[4].Name = "Descripcion";
			this.DataGridDetalleTickets.Columns[4].Width = 240;
			this.DataGridDetalleTickets.Columns[4].ReadOnly = true;
			this.DataGridDetalleTickets.Columns[5].Name = "Precio";
			this.DataGridDetalleTickets.Columns[5].Width = 60;
			this.DataGridDetalleTickets.Columns[5].ReadOnly = true;
			this.DataGridDetalleTickets.Columns[6].Name = "Impuesto";
			this.DataGridDetalleTickets.Columns[6].Width = 60;
			this.DataGridDetalleTickets.Columns[6].ReadOnly = true;
			this.DataGridDetalleTickets.Columns[7].Name = "Precio sin iva ";
			this.DataGridDetalleTickets.Columns[7].Width = 60;
			this.DataGridDetalleTickets.Columns[7].ReadOnly = true;
			this.DataGridDetalleTickets.Columns[8].Name = "Descuento";
			this.DataGridDetalleTickets.Columns[8].Width = 65;
			this.DataGridDetalleTickets.Columns[8].ReadOnly = true;
			this.DataGridDetalleTickets.Columns[9].Name = "ImporteDescuento";
			this.DataGridDetalleTickets.Columns[9].Width = 60;
			this.DataGridDetalleTickets.Columns[9].Visible = false;
			this.DataGridDetalleTickets.Columns[10].Name = "TipoMovto";
			this.DataGridDetalleTickets.Columns[10].Width = 60;
			this.DataGridDetalleTickets.Columns[10].Visible = false;
			dataGridViewCheckBoxColumn.Width = 60;
			dataGridViewCheckBoxColumn.Name = "Eliminar";
			this.DataGridDetalleTickets.Columns.Add(dataGridViewCheckBoxColumn);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0008B3D8 File Offset: 0x000895D8
		private void DataGridDetalleTickets_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			int rowIndex = e.RowIndex;
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 11;
			string text4;
			SqlDataReader sqlDataReader;
			if (flag)
			{
				string text = Conversions.ToString(this.DataGridDetalleTickets.Rows[rowIndex].Cells["Foliodet"].Value);
				string text2 = Conversions.ToString(this.DataGridDetalleTickets.Rows[rowIndex].Cells["Mov."].Value);
				string text3 = Conversions.ToString(this.DataGridDetalleTickets.Rows[rowIndex].Cells["idproducto"].Value);
				text4 = "SELECT Descuento from Cheques where folio='" + text + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				bool flag2 = sqlDataReader.Read();
				double num;
				if (flag2)
				{
					num = Conversions.ToDouble(sqlDataReader[0]);
				}
				bool flag3 = Operators.CompareString(this.lblcontador.Text, "0", false) >= 0;
				if (flag3)
				{
					bool flag4 = Operators.ConditionalCompareObjectEqual(this.DataGridDetalleTickets.Rows[rowIndex].Cells["Eliminar"].Value, false, false);
					if (flag4)
					{
						this.DataGridDetalleTickets.Rows[rowIndex].Cells["Eliminar"].Value = true;
						this.DataGridDetalleTickets.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
						this.DataGridDetalleTickets.Rows[rowIndex].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold);
						double num2 = Conversions.ToDouble(this.DataGridDetalleTickets.Rows[rowIndex].Cells["Descuento"].Value);
						string value = Conversions.ToString(this.DataGridDetalleTickets.Rows[rowIndex].Cells["Cantidad"].Value);
						string value2 = Conversions.ToString(this.DataGridDetalleTickets.Rows[rowIndex].Cells["Precio"].Value);
						string text5 = Conversions.ToString(this.DataGridDetalleTickets.Rows[rowIndex].Cells["TipoMovto"].Value);
						double num3 = Conversions.ToDouble(value) * Conversions.ToDouble(value2) - Conversions.ToDouble(value) * Conversions.ToDouble(value2) / 100.0 * num2;
						double num4 = Conversions.ToDouble((num3 - num3 / 100.0 * num).ToString("N2"));
						this.lblnuevototal.Text = Conversions.ToString(1);
						int index = Conversions.ToInteger(this.lblnumerodefila.Text);
						this.lblcontador.Text = Conversions.ToString(Conversions.ToDouble(this.lblcontador.Text) - 1.0);
						bool flag5 = Operators.CompareString(text5, "0", false) == 0;
						if (flag5)
						{
							text4 = string.Concat(new string[]
							{
								"Delete from F where a = '",
								text.ToString(),
								"'  and b = '",
								text2.ToString(),
								"' and d = '",
								text3.ToString(),
								"' and j='0'"
							});
							sqlQuery_Conn.execQuery_conn(text4);
						}
						bool flag6 = Operators.CompareString(text5, "1", false) == 0;
						if (flag6)
						{
							text4 = string.Concat(new string[]
							{
								"Update F set k ='1' Where a = '",
								text.ToString(),
								"'  and b = '",
								text2.ToString(),
								"' and d = '",
								text3.ToString(),
								"'"
							});
							sqlQuery_Conn.execQuery_conn(text4);
						}
						bool flag7 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)));
						if (flag7)
						{
							this.txtImpNuevo.Text = Conversions.ToString(Conversions.ToDouble(this.txtImpNuevo.Text) - num4);
							this.txtDifImporte.Text = Conversions.ToString(Conversions.ToDouble(this.txtDifImporte.Text) + num4);
						}
						bool flag8 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Facturado"].Value, "Si", false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)));
						if (flag8)
						{
							this.txtVentaFacturada.Text = Conversions.ToString(Conversions.ToDouble(this.txtVentaFacturada.Text) - num4);
						}
						bool flag9 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
						if (flag9)
						{
							text4 = "SELECT i from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag10 = sqlDataReader.Read();
							if (flag10)
							{
								string text6 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text6.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows = sqlDataReader.HasRows;
								if (hasRows)
								{
									while (sqlDataReader.Read())
									{
										string text7 = Conversions.ToString(sqlDataReader[0]);
										string value3 = Conversions.ToString(sqlDataReader[1]);
										bool flag11 = Conversions.ToDouble(value3) == 4.0;
										if (flag11)
										{
											TextBox textBox;
											(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag12 = Conversions.ToDouble(value3) == 3.0;
										if (flag12)
										{
											TextBox textBox;
											(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag13 = Conversions.ToDouble(value3) == 1.0;
										if (flag13)
										{
											TextBox textBox;
											(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
											(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag14 = Conversions.ToDouble(value3) == 2.0;
										if (flag14)
										{
											TextBox textBox;
											(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
									}
								}
								else
								{
									TextBox textBox;
									(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								}
							}
							sqlDataReader.Close();
						}
						bool flag15 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
						if (flag15)
						{
							text4 = "SELECT j from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag16 = sqlDataReader.Read();
							if (flag16)
							{
								string text8 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text8.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows2 = sqlDataReader.HasRows;
								if (hasRows2)
								{
									while (sqlDataReader.Read())
									{
										string text7 = Conversions.ToString(sqlDataReader[0]);
										string value3 = Conversions.ToString(sqlDataReader[1]);
										bool flag17 = Conversions.ToDouble(value3) == 4.0;
										if (flag17)
										{
											TextBox textBox;
											(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag18 = Conversions.ToDouble(value3) == 3.0;
										if (flag18)
										{
											TextBox textBox;
											(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag19 = Conversions.ToDouble(value3) == 1.0;
										if (flag19)
										{
											TextBox textBox;
											(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
											(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag20 = Conversions.ToDouble(value3) == 2.0;
										if (flag20)
										{
											TextBox textBox;
											(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
									}
								}
								else
								{
									TextBox textBox;
									(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								}
							}
							sqlDataReader.Close();
						}
						bool flag21 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
						if (flag21)
						{
							text4 = "SELECT k from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag22 = sqlDataReader.Read();
							if (flag22)
							{
								string text9 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text9.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows3 = sqlDataReader.HasRows;
								if (hasRows3)
								{
									while (sqlDataReader.Read())
									{
										string text7 = Conversions.ToString(sqlDataReader[0]);
										string value3 = Conversions.ToString(sqlDataReader[1]);
										bool flag23 = Conversions.ToDouble(value3) == 4.0;
										if (flag23)
										{
											TextBox textBox;
											(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag24 = Conversions.ToDouble(value3) == 3.0;
										if (flag24)
										{
											TextBox textBox;
											(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag25 = Conversions.ToDouble(value3) == 1.0;
										if (flag25)
										{
											TextBox textBox;
											(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
											(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag26 = Conversions.ToDouble(value3) == 2.0;
										if (flag26)
										{
											TextBox textBox;
											(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
									}
								}
								else
								{
									TextBox textBox;
									(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								}
							}
							sqlDataReader.Close();
						}
						bool flag27 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
						if (flag27)
						{
							text4 = "SELECT l from H";
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
										string text7 = Conversions.ToString(sqlDataReader[0]);
										string value3 = Conversions.ToString(sqlDataReader[1]);
										bool flag29 = Conversions.ToDouble(value3) == 4.0;
										if (flag29)
										{
											TextBox textBox;
											(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag30 = Conversions.ToDouble(value3) == 3.0;
										if (flag30)
										{
											TextBox textBox;
											(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag31 = Conversions.ToDouble(value3) == 1.0;
										if (flag31)
										{
											TextBox textBox;
											(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
											(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag32 = Conversions.ToDouble(value3) == 2.0;
										if (flag32)
										{
											TextBox textBox;
											(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
									}
								}
								else
								{
									TextBox textBox;
									(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								}
							}
							sqlDataReader.Close();
						}
						bool flag33 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
						if (flag33)
						{
							text4 = "SELECT m from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag34 = sqlDataReader.Read();
							if (flag34)
							{
								string text11 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text11.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows5 = sqlDataReader.HasRows;
								if (hasRows5)
								{
									while (sqlDataReader.Read())
									{
										string text7 = Conversions.ToString(sqlDataReader[0]);
										string value3 = Conversions.ToString(sqlDataReader[1]);
										bool flag35 = Conversions.ToDouble(value3) == 4.0;
										if (flag35)
										{
											TextBox textBox;
											(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag36 = Conversions.ToDouble(value3) == 3.0;
										if (flag36)
										{
											TextBox textBox;
											(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag37 = Conversions.ToDouble(value3) == 1.0;
										if (flag37)
										{
											TextBox textBox;
											(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
											(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag38 = Conversions.ToDouble(value3) == 2.0;
										if (flag38)
										{
											TextBox textBox;
											(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
									}
								}
								else
								{
									TextBox textBox;
									(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								}
							}
							sqlDataReader.Close();
						}
						bool flag39 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
						if (flag39)
						{
							text4 = "SELECT m from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag40 = sqlDataReader.Read();
							if (flag40)
							{
								string text11 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text11.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows6 = sqlDataReader.HasRows;
								if (hasRows6)
								{
									while (sqlDataReader.Read())
									{
										string text7 = Conversions.ToString(sqlDataReader[0]);
										string value3 = Conversions.ToString(sqlDataReader[1]);
										bool flag41 = Conversions.ToDouble(value3) == 4.0;
										if (flag41)
										{
											TextBox textBox;
											(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag42 = Conversions.ToDouble(value3) == 3.0;
										if (flag42)
										{
											TextBox textBox;
											(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag43 = Conversions.ToDouble(value3) == 1.0;
										if (flag43)
										{
											TextBox textBox;
											(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
											(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag44 = Conversions.ToDouble(value3) == 2.0;
										if (flag44)
										{
											TextBox textBox;
											(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
									}
								}
								else
								{
									TextBox textBox;
									(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								}
							}
							sqlDataReader.Close();
						}
						bool flag45 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
						if (flag45)
						{
							text4 = "SELECT m from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag46 = sqlDataReader.Read();
							if (flag46)
							{
								string text11 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text11.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows7 = sqlDataReader.HasRows;
								if (hasRows7)
								{
									while (sqlDataReader.Read())
									{
										string text7 = Conversions.ToString(sqlDataReader[0]);
										string value3 = Conversions.ToString(sqlDataReader[1]);
										bool flag47 = Conversions.ToDouble(value3) == 4.0;
										if (flag47)
										{
											TextBox textBox;
											(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag48 = Conversions.ToDouble(value3) == 3.0;
										if (flag48)
										{
											TextBox textBox;
											(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag49 = Conversions.ToDouble(value3) == 1.0;
										if (flag49)
										{
											TextBox textBox;
											(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
											(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag50 = Conversions.ToDouble(value3) == 2.0;
										if (flag50)
										{
											TextBox textBox;
											(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
									}
								}
								else
								{
									TextBox textBox;
									(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								}
							}
							sqlDataReader.Close();
						}
						bool flag51 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), this.dgvNotas.Rows[index].Cells["Efectivo"].Value), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
						if (flag51)
						{
							text4 = "SELECT m from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag52 = sqlDataReader.Read();
							if (flag52)
							{
								string text11 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text11.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows8 = sqlDataReader.HasRows;
								if (hasRows8)
								{
									while (sqlDataReader.Read())
									{
										string text7 = Conversions.ToString(sqlDataReader[0]);
										string value3 = Conversions.ToString(sqlDataReader[1]);
										bool flag53 = Conversions.ToDouble(value3) == 4.0;
										if (flag53)
										{
											TextBox textBox;
											(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag54 = Conversions.ToDouble(value3) == 3.0;
										if (flag54)
										{
											TextBox textBox;
											(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag55 = Conversions.ToDouble(value3) == 1.0;
										if (flag55)
										{
											TextBox textBox;
											(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
											(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag56 = Conversions.ToDouble(value3) == 2.0;
										if (flag56)
										{
											TextBox textBox;
											(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
									}
								}
								else
								{
									TextBox textBox;
									(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								}
							}
							sqlDataReader.Close();
						}
						bool flag57 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
						if (flag57)
						{
							text4 = "SELECT m from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag58 = sqlDataReader.Read();
							if (flag58)
							{
								string text11 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text11.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows9 = sqlDataReader.HasRows;
								if (hasRows9)
								{
									while (sqlDataReader.Read())
									{
										string text7 = Conversions.ToString(sqlDataReader[0]);
										string value3 = Conversions.ToString(sqlDataReader[1]);
										bool flag59 = Conversions.ToDouble(value3) == 4.0;
										if (flag59)
										{
											TextBox textBox;
											(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag60 = Conversions.ToDouble(value3) == 3.0;
										if (flag60)
										{
											TextBox textBox;
											(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag61 = Conversions.ToDouble(value3) == 1.0;
										if (flag61)
										{
											TextBox textBox;
											(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
											(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag62 = Conversions.ToDouble(value3) == 2.0;
										if (flag62)
										{
											TextBox textBox;
											(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
									}
								}
								else
								{
									TextBox textBox;
									(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								}
							}
							sqlDataReader.Close();
						}
						bool flag63 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
						if (flag63)
						{
							text4 = "SELECT m from H";
							sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
							bool flag64 = sqlDataReader.Read();
							if (flag64)
							{
								string text11 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
								text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text11.ToString() + "'";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
								bool hasRows10 = sqlDataReader.HasRows;
								if (hasRows10)
								{
									while (sqlDataReader.Read())
									{
										string text7 = Conversions.ToString(sqlDataReader[0]);
										string value3 = Conversions.ToString(sqlDataReader[1]);
										bool flag65 = Conversions.ToDouble(value3) == 4.0;
										if (flag65)
										{
											TextBox textBox;
											(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag66 = Conversions.ToDouble(value3) == 3.0;
										if (flag66)
										{
											TextBox textBox;
											(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag67 = Conversions.ToDouble(value3) == 1.0;
										if (flag67)
										{
											TextBox textBox;
											(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
											(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
										bool flag68 = Conversions.ToDouble(value3) == 2.0;
										if (flag68)
										{
											TextBox textBox;
											(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + -Conversions.ToDouble(num4.ToString()));
										}
									}
								}
								else
								{
									TextBox textBox;
									(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
								}
							}
							sqlDataReader.Close();
						}
					}
					else
					{
						bool flag69 = Operators.CompareString(this.lblcontador.Text, "0", false) >= 0;
						if (flag69)
						{
							this.lblcontador.Text = Conversions.ToString(Conversions.ToDouble(this.lblcontador.Text) + 1.0);
							text = Conversions.ToString(this.DataGridDetalleTickets.Rows[rowIndex].Cells["Foliodet"].Value);
							text2 = Conversions.ToString(this.DataGridDetalleTickets.Rows[rowIndex].Cells["Mov."].Value);
							text3 = Conversions.ToString(this.DataGridDetalleTickets.Rows[rowIndex].Cells["idproducto"].Value);
							string text12 = Conversions.ToString(this.DataGridDetalleTickets.Rows[rowIndex].Cells["Cantidad"].Value);
							double num5 = Conversions.ToDouble(this.DataGridDetalleTickets.Rows[rowIndex].Cells["ImporteDescuento"].Value);
							double num6 = Conversions.ToDouble(this.DataGridDetalleTickets.Rows[rowIndex].Cells["Impuesto"].Value);
							double num7 = Conversions.ToDouble(this.DataGridDetalleTickets.Rows[rowIndex].Cells["Precio sin iva "].Value);
							double num8 = Conversions.ToDouble(this.DataGridDetalleTickets.Rows[rowIndex].Cells["Descuento"].Value);
							double num9 = Conversions.ToDouble(this.DataGridDetalleTickets.Rows[rowIndex].Cells["Precio"].Value);
							string text5 = Conversions.ToString(this.DataGridDetalleTickets.Rows[rowIndex].Cells["TipoMovto"].Value);
							text4 = "SELECT Descuento from Cheques where folio='" + text + "'";
							sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
							bool flag70 = sqlDataReader.Read();
							if (flag70)
							{
								num = Conversions.ToDouble(sqlDataReader[0]);
							}
							double num10 = Conversions.ToDouble(text12) * num9 - Conversions.ToDouble(text12) * num9 / 100.0 * num8;
							double num4 = num10 - num10 / 100.0 * num;
							this.DataGridDetalleTickets.Rows[rowIndex].Cells["Eliminar"].Value = false;
							this.DataGridDetalleTickets.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
							this.DataGridDetalleTickets.Rows[rowIndex].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 7.875f, FontStyle.Regular);
							try
							{
								foreach (object obj in ((IEnumerable)this.DataGridDetalleTickets.Rows))
								{
									DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
									string left = Conversions.ToString(dataGridViewRow.Cells["TipoMovto"].Value);
									bool flag71 = Operators.CompareString(left, "1", false) == 0;
									if (flag71)
									{
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
							bool flag72 = Operators.CompareString(text5, "0", false) == 0;
							if (flag72)
							{
								text4 = string.Concat(new string[]
								{
									"Insert into F values ('",
									text.ToString(),
									"' , '",
									text2.ToString(),
									"' , '",
									text12.ToString(),
									"' , '",
									text3.ToString(),
									"' , '",
									num9.ToString("N2"),
									"' , '",
									num6.ToString("N2"),
									"' , '",
									num7.ToString("N2"),
									"' , '",
									num8.ToString("N2"),
									"','",
									num10.ToString("N2"),
									"','",
									text5,
									"','0')"
								});
								sqlQuery_Conn.execQuery_conn(text4);
							}
							bool flag73 = Operators.CompareString(text5, "1", false) == 0;
							if (flag73)
							{
								text4 = string.Concat(new string[]
								{
									"Update F set k ='0' Where a = '",
									text.ToString(),
									"'  and b = '",
									text2.ToString(),
									"' and d = '",
									text3.ToString(),
									"'"
								});
								sqlQuery_Conn.execQuery_conn(text4);
							}
							int index2 = Conversions.ToInteger(this.lblnumerodefila.Text);
							bool flag74 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Cancel."].Value, "No", false)));
							if (flag74)
							{
								this.txtImpNuevo.Text = Conversions.ToString(Conversions.ToDouble(this.txtImpNuevo.Text) + num4);
								this.txtDifImporte.Text = Conversions.ToString(Conversions.ToDouble(this.txtDifImporte.Text) - num4);
							}
							bool flag75 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Facturado"].Value, "Si", false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Cancel."].Value, "No", false)));
							if (flag75)
							{
								this.txtVentaFacturada.Text = Conversions.ToString(Conversions.ToDouble(this.txtVentaFacturada.Text) + num4);
							}
							bool flag76 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Tarjeta"].Value, 0, false)));
							if (flag76)
							{
								text4 = "SELECT i from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag77 = sqlDataReader.Read();
								if (flag77)
								{
									string text6 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text6.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows11 = sqlDataReader.HasRows;
									if (hasRows11)
									{
										while (sqlDataReader.Read())
										{
											string text7 = Conversions.ToString(sqlDataReader[0]);
											string value3 = Conversions.ToString(sqlDataReader[1]);
											bool flag78 = Conversions.ToDouble(value3) == 4.0;
											if (flag78)
											{
												TextBox textBox;
												(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag79 = Conversions.ToDouble(value3) == 3.0;
											if (flag79)
											{
												TextBox textBox;
												(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag80 = Conversions.ToDouble(value3) == 1.0;
											if (flag80)
											{
												TextBox textBox;
												(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
												(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag81 = Conversions.ToDouble(value3) == 2.0;
											if (flag81)
											{
												TextBox textBox;
												(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
										}
									}
									else
									{
										TextBox textBox;
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									}
								}
								sqlDataReader.Close();
							}
							bool flag82 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Tarjeta"].Value, 0, false)));
							if (flag82)
							{
								text4 = "SELECT j from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag83 = sqlDataReader.Read();
								if (flag83)
								{
									string text8 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text8.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows12 = sqlDataReader.HasRows;
									if (hasRows12)
									{
										while (sqlDataReader.Read())
										{
											string text7 = Conversions.ToString(sqlDataReader[0]);
											string value3 = Conversions.ToString(sqlDataReader[1]);
											bool flag84 = Conversions.ToDouble(value3) == 4.0;
											if (flag84)
											{
												TextBox textBox;
												(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag85 = Conversions.ToDouble(value3) == 3.0;
											if (flag85)
											{
												TextBox textBox;
												(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag86 = Conversions.ToDouble(value3) == 1.0;
											if (flag86)
											{
												TextBox textBox;
												(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
												(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag87 = Conversions.ToDouble(value3) == 2.0;
											if (flag87)
											{
												TextBox textBox;
												(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
										}
									}
									else
									{
										TextBox textBox;
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									}
								}
								sqlDataReader.Close();
							}
							bool flag88 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Tarjeta"].Value, 0, false)));
							if (flag88)
							{
								text4 = "SELECT k from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag89 = sqlDataReader.Read();
								if (flag89)
								{
									string text9 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text9.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows13 = sqlDataReader.HasRows;
									if (hasRows13)
									{
										while (sqlDataReader.Read())
										{
											string text7 = Conversions.ToString(sqlDataReader[0]);
											string value3 = Conversions.ToString(sqlDataReader[1]);
											bool flag90 = Conversions.ToDouble(value3) == 4.0;
											if (flag90)
											{
												TextBox textBox;
												(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag91 = Conversions.ToDouble(value3) == 3.0;
											if (flag91)
											{
												TextBox textBox;
												(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag92 = Conversions.ToDouble(value3) == 1.0;
											if (flag92)
											{
												TextBox textBox;
												(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
												(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag93 = Conversions.ToDouble(value3) == 2.0;
											if (flag93)
											{
												TextBox textBox;
												(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
										}
									}
									else
									{
										TextBox textBox;
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									}
								}
								sqlDataReader.Close();
							}
							bool flag94 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Tarjeta"].Value, 0, false)));
							if (flag94)
							{
								text4 = "SELECT l from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag95 = sqlDataReader.Read();
								if (flag95)
								{
									string text10 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text10.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows14 = sqlDataReader.HasRows;
									if (hasRows14)
									{
										while (sqlDataReader.Read())
										{
											string text7 = Conversions.ToString(sqlDataReader[0]);
											string value3 = Conversions.ToString(sqlDataReader[1]);
											bool flag96 = Conversions.ToDouble(value3) == 4.0;
											if (flag96)
											{
												TextBox textBox;
												(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag97 = Conversions.ToDouble(value3) == 3.0;
											if (flag97)
											{
												TextBox textBox;
												(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag98 = Conversions.ToDouble(value3) == 1.0;
											if (flag98)
											{
												TextBox textBox;
												(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
												(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag99 = Conversions.ToDouble(value3) == 2.0;
											if (flag99)
											{
												TextBox textBox;
												(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
										}
									}
									else
									{
										TextBox textBox;
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									}
								}
								sqlDataReader.Close();
							}
							bool flag100 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Tarjeta"].Value, 0, false)));
							if (flag100)
							{
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag101 = sqlDataReader.Read();
								if (flag101)
								{
									string text11 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text11.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows15 = sqlDataReader.HasRows;
									if (hasRows15)
									{
										while (sqlDataReader.Read())
										{
											string text7 = Conversions.ToString(sqlDataReader[0]);
											string value3 = Conversions.ToString(sqlDataReader[1]);
											bool flag102 = Conversions.ToDouble(value3) == 4.0;
											if (flag102)
											{
												TextBox textBox;
												(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag103 = Conversions.ToDouble(value3) == 3.0;
											if (flag103)
											{
												TextBox textBox;
												(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag104 = Conversions.ToDouble(value3) == 1.0;
											if (flag104)
											{
												TextBox textBox;
												(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
												(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag105 = Conversions.ToDouble(value3) == 2.0;
											if (flag105)
											{
												TextBox textBox;
												(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
										}
									}
									else
									{
										TextBox textBox;
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									}
								}
								sqlDataReader.Close();
							}
							bool flag106 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Tarjeta"].Value, 0, false)));
							if (flag106)
							{
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag107 = sqlDataReader.Read();
								if (flag107)
								{
									string text11 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text11.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows16 = sqlDataReader.HasRows;
									if (hasRows16)
									{
										while (sqlDataReader.Read())
										{
											string text7 = Conversions.ToString(sqlDataReader[0]);
											string value3 = Conversions.ToString(sqlDataReader[1]);
											bool flag108 = Conversions.ToDouble(value3) == 4.0;
											if (flag108)
											{
												TextBox textBox;
												(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag109 = Conversions.ToDouble(value3) == 3.0;
											if (flag109)
											{
												TextBox textBox;
												(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag110 = Conversions.ToDouble(value3) == 1.0;
											if (flag110)
											{
												TextBox textBox;
												(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
												(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag111 = Conversions.ToDouble(value3) == 2.0;
											if (flag111)
											{
												TextBox textBox;
												(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
										}
									}
									else
									{
										TextBox textBox;
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									}
								}
								sqlDataReader.Close();
							}
							bool flag112 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Tarjeta"].Value, 0, false)));
							if (flag112)
							{
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag113 = sqlDataReader.Read();
								if (flag113)
								{
									string text11 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text11.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows17 = sqlDataReader.HasRows;
									if (hasRows17)
									{
										while (sqlDataReader.Read())
										{
											string text7 = Conversions.ToString(sqlDataReader[0]);
											string value3 = Conversions.ToString(sqlDataReader[1]);
											bool flag114 = Conversions.ToDouble(value3) == 4.0;
											if (flag114)
											{
												TextBox textBox;
												(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag115 = Conversions.ToDouble(value3) == 3.0;
											if (flag115)
											{
												TextBox textBox;
												(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag116 = Conversions.ToDouble(value3) == 1.0;
											if (flag116)
											{
												TextBox textBox;
												(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
												(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag117 = Conversions.ToDouble(value3) == 2.0;
											if (flag117)
											{
												TextBox textBox;
												(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
										}
									}
									else
									{
										TextBox textBox;
										(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
										(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									}
								}
								sqlDataReader.Close();
							}
							bool flag118 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Tarjeta"].Value, 0, false)));
							if (flag118)
							{
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag119 = sqlDataReader.Read();
								if (flag119)
								{
									string text11 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text11.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows18 = sqlDataReader.HasRows;
									if (hasRows18)
									{
										while (sqlDataReader.Read())
										{
											string text7 = Conversions.ToString(sqlDataReader[0]);
											string value3 = Conversions.ToString(sqlDataReader[1]);
											bool flag120 = Conversions.ToDouble(value3) == 4.0;
											if (flag120)
											{
												TextBox textBox;
												(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag121 = Conversions.ToDouble(value3) == 3.0;
											if (flag121)
											{
												TextBox textBox;
												(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag122 = Conversions.ToDouble(value3) == 1.0;
											if (flag122)
											{
												TextBox textBox;
												(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
												(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag123 = Conversions.ToDouble(value3) == 2.0;
											if (flag123)
											{
												TextBox textBox;
												(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
										}
									}
									else
									{
										TextBox textBox;
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									}
								}
								sqlDataReader.Close();
							}
							bool flag124 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Tarjeta"].Value, 0, false)));
							if (flag124)
							{
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag125 = sqlDataReader.Read();
								if (flag125)
								{
									string text11 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text11.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows19 = sqlDataReader.HasRows;
									if (hasRows19)
									{
										while (sqlDataReader.Read())
										{
											string text7 = Conversions.ToString(sqlDataReader[0]);
											string value3 = Conversions.ToString(sqlDataReader[1]);
											bool flag126 = Conversions.ToDouble(value3) == 4.0;
											if (flag126)
											{
												TextBox textBox;
												(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag127 = Conversions.ToDouble(value3) == 3.0;
											if (flag127)
											{
												TextBox textBox;
												(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag128 = Conversions.ToDouble(value3) == 1.0;
											if (flag128)
											{
												TextBox textBox;
												(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
												(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag129 = Conversions.ToDouble(value3) == 2.0;
											if (flag129)
											{
												TextBox textBox;
												(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
										}
									}
									else
									{
										TextBox textBox;
										(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									}
								}
								sqlDataReader.Close();
							}
							bool flag130 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index2].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index2].Cells["Tarjeta"].Value, 0, false)));
							if (flag130)
							{
								text4 = "SELECT m from H";
								sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
								bool flag131 = sqlDataReader.Read();
								if (flag131)
								{
									string text11 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
									text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text11.ToString() + "'";
									sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
									bool hasRows20 = sqlDataReader.HasRows;
									if (hasRows20)
									{
										while (sqlDataReader.Read())
										{
											string text7 = Conversions.ToString(sqlDataReader[0]);
											string value3 = Conversions.ToString(sqlDataReader[1]);
											bool flag132 = Conversions.ToDouble(value3) == 4.0;
											if (flag132)
											{
												TextBox textBox;
												(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag133 = Conversions.ToDouble(value3) == 3.0;
											if (flag133)
											{
												TextBox textBox;
												(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag134 = Conversions.ToDouble(value3) == 1.0;
											if (flag134)
											{
												TextBox textBox;
												(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
												(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
											bool flag135 = Conversions.ToDouble(value3) == 2.0;
											if (flag135)
											{
												TextBox textBox;
												(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num4.ToString()));
											}
										}
									}
									else
									{
										TextBox textBox;
										(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
										(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
									}
								}
								sqlDataReader.Close();
							}
						}
					}
				}
			}
			text4 = "SELECT Descuento from Cheques where folio='" + this.lblfolioini.Text + "'";
			sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
			bool flag136 = sqlDataReader.Read();
			double num11;
			if (flag136)
			{
				num11 = Conversions.ToDouble(sqlDataReader[0]);
			}
			text4 = "Select ISNULL(Sum(i),0) from F where a = '" + this.lblfolioini.Text + "' and k=0";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
			bool flag137 = sqlDataReader.Read();
			double num12;
			if (flag137)
			{
				num12 = Conversions.ToDouble(sqlDataReader[0]);
				num12 -= num12 / 100.0 * num11;
				this.lblnuevototal.Text = "$ " + num12.ToString("N2");
			}
			int rowIndex2 = Conversions.ToInteger(this.lblnumerodefila.Text);
			this.dgvNotas[11, rowIndex2].Value = num12.ToString("N2");
			double num13 = Conversions.ToDouble(this.txtImpNuevo.Text);
			this.txtImpNuevo.Text = "$ " + num13.ToString("N2");
			double num14 = Conversions.ToDouble(this.txtDifImporte.Text);
			this.txtDifImporte.Text = "$ " + num14.ToString("N2");
			double num15 = Conversions.ToDouble(this.txtdifotros.Text);
			this.txtdifotros.Text = "$ " + num15.ToString("N2");
			this.lblcortenuevotros.Text = "$ " + num15.ToString("N2");
			double num16 = Conversions.ToDouble(this.txtdifvales.Text);
			this.txtdifvales.Text = "$ " + num16.ToString("N2");
			this.lblcortenuevovales.Text = "$ " + num16.ToString("N2");
			double num17 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
			this.txtEfectivoFiscal.Text = "$ " + num17.ToString("N2");
			this.lblcorteefectivonuevo.Text = "$ " + num17.ToString("N2");
			double num18 = Conversions.ToDouble(this.txtEfectivoCaja.Text);
			this.txtEfectivoCaja.Text = "$ " + num18.ToString("N2");
			this.lblEfectivonuevocorte.Text = "$ " + num18.ToString("N2");
			double num19 = Conversions.ToDouble(this.txtDifTarjeta.Text);
			this.txtDifTarjeta.Text = "$ " + num19.ToString("N2");
			this.lblcortetarjetanuevo.Text = "$ " + num19.ToString("N2");
			double num20 = Conversions.ToDouble(this.lblpropinascortenuevo.Text);
			double num21 = Conversions.ToDouble(this.lblcortenuevodepositos.Text);
			double num22 = Conversions.ToDouble(this.lblcortenuevoretiros.Text);
			this.txtDifPorcen.Text = "% " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			double num23 = num17 + num19 + num15 + num16 - num20 + num21 - num22;
			this.lblsaldofinarlcortenuevo.Text = "$ " + num23.ToString("N2");
			double num24 = Conversions.ToDouble(this.txtImpNuevo.Text);
			double num25 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			double num26 = Conversion.Val(num24) - Conversion.Val(num25);
			this.txtventasinfacturar.Text = "$ " + num26.ToString("N2");
			this.txtFacturaPUB.Text = "$ " + num26.ToString("N2");
			double num27 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			this.txtVentaFacturada.Text = "$ " + num27.ToString("N2");
			this.lblventafacturanew.Text = this.txtVentaFacturada.Text;
			this.lblventasinfacturarnew.Text = this.txtventasinfacturar.Text;
			this.lblfacturapubnew.Text = this.txtFacturaPUB.Text;
			this.DataGridDetalleTickets.ClearSelection();
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00090D0C File Offset: 0x0008EF0C
		private void btnCorteZ_Click(object sender, EventArgs e)
		{
			this.Panelvercortes.Visible = true;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00090D1C File Offset: 0x0008EF1C
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

		// Token: 0x06000801 RID: 2049 RVA: 0x00090DC8 File Offset: 0x0008EFC8
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

		// Token: 0x06000802 RID: 2050 RVA: 0x000036D5 File Offset: 0x000018D5
		private void DataGridDetalleTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00090E74 File Offset: 0x0008F074
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

		// Token: 0x06000804 RID: 2052 RVA: 0x00091234 File Offset: 0x0008F434
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

		// Token: 0x06000805 RID: 2053 RVA: 0x0009128C File Offset: 0x0008F48C
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

		// Token: 0x06000806 RID: 2054 RVA: 0x00091BE0 File Offset: 0x0008FDE0
		private void btnAgregarProductos_Click(object sender, EventArgs e)
		{
			this.PanelBuscarProducto.Visible = true;
			this.iniciaGridProductos();
			this.MostrarReporteProductos1();
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00091BFE File Offset: 0x0008FDFE
		private void PictureBox4_Click_1(object sender, EventArgs e)
		{
			this.PanelBuscarProducto.Visible = false;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00091C10 File Offset: 0x0008FE10
		private void iniciaGridProductos()
		{
			this.dgwProductos.Rows.Clear();
			this.dgwProductos.ColumnCount = 6;
			this.dgwProductos.Columns[0].Name = "id_Producto";
			this.dgwProductos.Columns[0].Visible = false;
			this.dgwProductos.Columns[1].Name = "Cantidad.";
			this.dgwProductos.Columns[1].Width = 60;
			this.dgwProductos.Columns[1].ReadOnly = true;
			this.dgwProductos.Columns[2].Name = "Descripcion";
			this.dgwProductos.Columns[2].Width = 210;
			this.dgwProductos.Columns[2].ReadOnly = false;
			this.dgwProductos.Columns[3].Name = "Precio";
			this.dgwProductos.Columns[3].Width = 80;
			this.dgwProductos.Columns[3].Visible = true;
			this.dgwProductos.Columns[4].Name = "Impuesto";
			this.dgwProductos.Columns[4].Width = 80;
			this.dgwProductos.Columns[4].ReadOnly = true;
			this.dgwProductos.Columns[5].Name = "Precio sin iva";
			this.dgwProductos.Columns[5].Width = 80;
			this.dgwProductos.Columns[5].ReadOnly = false;
			this.DoubleBufferedASD(this.dgwProductos, true);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00091E04 File Offset: 0x00090004
		public void MostrarReporteProductos1()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "SELECT a.idproducto ,a.Descripcion , b.preciosinimpuestos , b.precio , b.impuesto1  FROM productos A \r\n\t                Inner Join Productosdetalle B on b.idproducto = a.idproducto";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				this.iniciaGridProductos();
				while (sqlDataReader.Read())
				{
					string text = Conversions.ToString(sqlDataReader[0]);
					string text2 = Conversions.ToString(sqlDataReader[1]);
					double num = Conversions.ToDouble(sqlDataReader[2]);
					double num2 = Conversions.ToDouble(sqlDataReader[3]);
					double num3 = Conversions.ToDouble(sqlDataReader[4]);
					this.dgwProductos.Rows.Add(new object[]
					{
						text,
						"1",
						text2,
						num2.ToString("N2"),
						num3.ToString("N2"),
						num.ToString("N2")
					});
				}
			}
			sqlDataReader.Close();
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00091EFC File Offset: 0x000900FC
		public void MostrarReporteProductos()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string text = this.txtBuscarProducto.Text;
			string query = "SELECT a.idproducto ,a.Descripcion , b.preciosinimpuestos , b.precio , b.impuesto1  FROM productos A \r\n\t                Inner Join Productosdetalle B on b.idproducto = a.idproducto\r\n\t\t\t\t    WHERE a.Descripcion Like '%" + this.txtBuscarProducto.Text + "%'";
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
					this.dgwProductos.Rows.Add(new object[]
					{
						text2,
						"1",
						text3,
						num2.ToString("N2"),
						num3.ToString("N2"),
						num.ToString("N2")
					});
				}
				sqlDataReader.Close();
			}
			this.dgwProductos.ClearSelection();
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0009202D File Offset: 0x0009022D
		private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
		{
			this.MostrarReporteProductos();
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgwProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgwProductos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x000036D5 File Offset: 0x000018D5
		private void dgwProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00092038 File Offset: 0x00090238
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
								double num4 = Conversions.ToDouble(dataGridViewRow.Cells["Precio Venta C/IVA"].Value);
								string query = "select idturno,estacion,idmesero from cheques where folio='" + text + "'";
								SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
								bool flag4 = sqlDataReader.Read();
								if (flag4)
								{
									this.idEstacion = Conversions.ToString(sqlDataReader[1]);
									this.idMeseros = Conversions.ToString(sqlDataReader[2]);
									this.idturno_cierre = Conversions.ToString(sqlDataReader[0]);
								}
								query = "select Top 1 Movimiento,hora from cheqdet where foliodet='" + text + "' order by movimiento desc";
								sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
								bool flag5 = sqlDataReader.Read();
								if (flag5)
								{
									num = Conversions.ToInteger(Operators.AddObject(sqlDataReader[0], 1));
									this.Hora = Conversions.ToDate(sqlDataReader[1]);
									this.lblFechadelProducto.Text = this.Hora.ToString(Tools.strFormatoFechaLargo);
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
									this.idEstacion.ToString(),
									"',\r\n'',\r\n'',\r\n'',\r\nNULL,\r\n'',\r\n'0',\r\n'",
									num4.ToString(),
									"',\r\n        '0',\r\n'",
									this.idMeseros.ToString(),
									"',\r\n        NULL,\r\n'0',\r\n        '',\r\n        '',\r\n        '0',\r\n        NULL,\r\nNULL,\r\nNULL,\r\n'1',\r\n'",
									this.idturno_cierre.ToString(),
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
				bool flag6 = Operators.ConditionalCompareObjectEqual(left, MsgBoxResult.No, false);
				if (flag6)
				{
					this.PanelBuscarProducto.Visible = true;
				}
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x000036D5 File Offset: 0x000018D5
		private void DataGridCheqdet_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x000036D5 File Offset: 0x000018D5
		private void PictureBoxPendienteTickets_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0009244C File Offset: 0x0009064C
		private void dgwProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			double num5 = 0.0;
			try
			{
				bool flag = this.dgvNotas[2, e.RowIndex].Value != null;
				if (flag)
				{
					num = Conversions.ToDouble(this.dgvNotas[2, e.RowIndex].Value);
				}
			}
			catch (Exception ex)
			{
				return;
			}
			try
			{
				bool flag2 = this.dgvNotas[7, e.RowIndex].Value != null;
				if (flag2)
				{
					num2 = Conversions.ToDouble(this.dgvNotas[7, e.RowIndex].Value);
				}
			}
			catch (Exception ex2)
			{
				return;
			}
			try
			{
				bool flag3 = this.dgvNotas[5, e.RowIndex].Value != null;
				if (flag3)
				{
					num3 = Conversions.ToDouble(this.dgvNotas[5, e.RowIndex].Value);
				}
			}
			catch (Exception ex3)
			{
				return;
			}
			try
			{
				bool flag4 = this.dgvNotas[6, e.RowIndex].Value != null;
				if (flag4)
				{
					num4 = Conversions.ToDouble(this.dgvNotas[6, e.RowIndex].Value);
				}
			}
			catch (Exception ex4)
			{
				return;
			}
			try
			{
				bool flag5 = this.dgvNotas[9, e.RowIndex].Value != null;
				if (flag5)
				{
					num5 = Conversions.ToDouble(this.dgvNotas[9, e.RowIndex].Value);
				}
			}
			catch (Exception ex5)
			{
				return;
			}
			double num6 = Conversions.ToDouble(("1." + num4.ToString()) ?? "");
			double num7 = num2 / num6;
			this.dgvNotas[9, e.RowIndex].Value = num7.ToString("N2");
			try
			{
				bool flag6 = this.dgvNotas[9, e.RowIndex].Value != null;
				if (flag6)
				{
					num5 = Conversions.ToDouble(this.dgvNotas[9, e.RowIndex].Value);
				}
			}
			catch (Exception ex6)
			{
				return;
			}
			double a = num * num2 - num * num2 / 100.0 * num3;
			double num8 = num * num5 - num * num5 / 100.0 * num3;
			double num9 = Conversions.ToDouble(Math.Round(a).ToString("N2"));
			double num10 = Conversions.ToDouble(num8.ToString("N2"));
			this.dgvNotas[8, e.RowIndex].Value = num9.ToString("N2");
			this.dgvNotas[10, e.RowIndex].Value = num10.ToString("N2");
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x000927F4 File Offset: 0x000909F4
		private void dgwProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			int num = 1;
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery = new SqlQuery();
			string text = Conversions.ToString(0);
			string text2 = Conversions.ToString(this.dgwProductos.Rows[rowIndex].Cells["id_Producto"].Value);
			string text3 = Conversions.ToString(this.dgwProductos.Rows[rowIndex].Cells["Descripcion"].Value);
			double num2 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["Impuesto"].Value);
			double num3 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["Precio"].Value);
			double num4 = Conversions.ToDouble(this.dgwProductos.Rows[rowIndex].Cells["Precio sin iva"].Value);
			double num5 = (double)num * num3;
			double num6 = (double)num * num4;
			string text4 = "SELECT TOP 1 Movimiento FROM Cheqdet WHERE Foliodet='" + Tools.FolioParaAgregar_ProductosEliminarProductos + "' order by movimiento desc";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					text = Conversions.ToString(sqlDataReader[0]);
					text = Conversions.ToString(Conversions.ToDouble(text) + 1.0);
				}
			}
			else
			{
				text = Conversions.ToString(1);
			}
			sqlDataReader.Close();
			text4 = "SELECT TOP 1 b FROM F WHERE a='" + Tools.FolioParaAgregar_ProductosEliminarProductos + "' and j='1' order by b desc";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
			bool hasRows2 = sqlDataReader.HasRows;
			if (hasRows2)
			{
				while (sqlDataReader.Read())
				{
					text = Conversions.ToString(sqlDataReader[0]);
					text = Conversions.ToString(Conversions.ToDouble(text) + 1.0);
				}
			}
			sqlDataReader.Close();
			this.DataGridDetalleTickets.Rows.Add(new object[]
			{
				Tools.FolioParaAgregar_ProductosEliminarProductos,
				text,
				"1.000000",
				text2,
				text3,
				num3.ToString("N2"),
				num2.ToString("N2"),
				num4.ToString("N2"),
				"0.00",
				num5.ToString("N2"),
				"1"
			});
			text4 = string.Concat(new string[]
			{
				"INSERT INTO F values ('",
				Tools.FolioParaAgregar_ProductosEliminarProductos,
				"' , '",
				text,
				"','1.000000' , '",
				text2,
				"' , '",
				num3.ToString("N2"),
				"','",
				num2.ToString("N2"),
				"','",
				num4.ToString("N2"),
				"','0.00','",
				num5.ToString("N2"),
				"','1','0')"
			});
			sqlQuery_Conn.execReader_conn(text4);
			this.lblcontador.Text = Conversions.ToString(Conversions.ToDouble(this.lblcontador.Text) + 1.0);
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridDetalleTickets.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					string left = Conversions.ToString(dataGridViewRow.Cells["TipoMovto"].Value);
					bool flag = Operators.CompareString(left, "1", false) == 0;
					if (flag)
					{
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
			this.lblcontador.Text = Conversions.ToString(Conversions.ToDouble(this.lblcontador.Text) + 1.0);
			string folioParaAgregar_ProductosEliminarProductos = Tools.FolioParaAgregar_ProductosEliminarProductos;
			text4 = "SELECT Descuento from Cheques where folio='" + folioParaAgregar_ProductosEliminarProductos + "'";
			sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
			bool flag2 = sqlDataReader.Read();
			double num7;
			if (flag2)
			{
				num7 = Conversions.ToDouble(sqlDataReader[0]);
			}
			double num8 = num3 - num3 / 100.0 * num7;
			Tools.PrecioCargaProdAlien = num8;
			double num9 = Conversions.ToDouble(this.lblnuevototal.Text);
			num9 += num8;
			this.lblnuevototal.Text = num9.ToString("N2");
			double num10 = Conversions.ToDouble(this.txtImpAnterior.Text);
			num10 += num8;
			this.txtImpAnterior.Text = "$ " + num10.ToString("N2");
			this.txtDifImporte.Text = Conversions.ToString(Conversions.ToDouble(this.txtDifImporte.Text) + num8);
			int index = Conversions.ToInteger(this.lblnumerodefila.Text);
			bool flag3 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)));
			if (flag3)
			{
				this.txtImpNuevo.Text = Conversions.ToString(Conversions.ToDouble(this.txtImpNuevo.Text) + num8);
				this.txtDifImporte.Text = Conversions.ToString(Conversions.ToDouble(this.txtDifImporte.Text) - num8);
			}
			bool flag4 = Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Facturado"].Value, "Si", false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)));
			if (flag4)
			{
				this.txtVentaFacturada.Text = Conversions.ToString(Conversions.ToDouble(this.txtVentaFacturada.Text) + num8);
			}
			bool flag5 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
			if (flag5)
			{
				text4 = "SELECT i from H";
				sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
				bool flag6 = sqlDataReader.Read();
				if (flag6)
				{
					string text5 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text5.ToString() + "'";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
					bool hasRows3 = sqlDataReader.HasRows;
					if (hasRows3)
					{
						while (sqlDataReader.Read())
						{
							string text6 = Conversions.ToString(sqlDataReader[0]);
							string value = Conversions.ToString(sqlDataReader[1]);
							bool flag7 = Conversions.ToDouble(value) == 4.0;
							if (flag7)
							{
								TextBox textBox;
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtVentasOtros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num11 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[15].Value);
								num11 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[15].Value = num11;
							}
							bool flag8 = Conversions.ToDouble(value) == 3.0;
							if (flag8)
							{
								TextBox textBox;
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtVales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num12 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[14].Value);
								num12 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[14].Value = num12;
							}
							bool flag9 = Conversions.ToDouble(value) == 1.0;
							if (flag9)
							{
								TextBox textBox;
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtEfectivoAnt).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num13 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[12].Value);
								num13 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[12].Value = num13;
							}
							bool flag10 = Conversions.ToDouble(value) == 2.0;
							if (flag10)
							{
								TextBox textBox;
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtVentaTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num14 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[13].Value);
								num14 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[13].Value = num14;
							}
						}
					}
					else
					{
						TextBox textBox;
						(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
						(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
						(textBox = this.txtEfectivoAnt).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
					}
				}
				sqlDataReader.Close();
			}
			bool flag11 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
			if (flag11)
			{
				text4 = "SELECT j from H";
				sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
				bool flag12 = sqlDataReader.Read();
				if (flag12)
				{
					string text7 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text7.ToString() + "'";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
					bool hasRows4 = sqlDataReader.HasRows;
					if (hasRows4)
					{
						while (sqlDataReader.Read())
						{
							string text6 = Conversions.ToString(sqlDataReader[0]);
							string value = Conversions.ToString(sqlDataReader[1]);
							bool flag13 = Conversions.ToDouble(value) == 4.0;
							if (flag13)
							{
								TextBox textBox;
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtVentasOtros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num15 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[15].Value);
								num15 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[15].Value = num15;
							}
							bool flag14 = Conversions.ToDouble(value) == 3.0;
							if (flag14)
							{
								TextBox textBox;
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtVales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num16 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[14].Value);
								num16 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[14].Value = num16;
							}
							bool flag15 = Conversions.ToDouble(value) == 1.0;
							if (flag15)
							{
								TextBox textBox;
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtEfectivoAnt).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num17 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[12].Value);
								num17 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[12].Value = num17;
							}
							bool flag16 = Conversions.ToDouble(value) == 2.0;
							if (flag16)
							{
								TextBox textBox;
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtVentaTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num18 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[13].Value);
								num18 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[13].Value = num18;
							}
						}
					}
					else
					{
						TextBox textBox;
						(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
						(textBox = this.txtVentaTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
					}
				}
				sqlDataReader.Close();
			}
			bool flag17 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
			if (flag17)
			{
				text4 = "SELECT k from H";
				sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
				bool flag18 = sqlDataReader.Read();
				if (flag18)
				{
					string text8 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text8.ToString() + "'";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
					bool hasRows5 = sqlDataReader.HasRows;
					if (hasRows5)
					{
						while (sqlDataReader.Read())
						{
							string text6 = Conversions.ToString(sqlDataReader[0]);
							string value = Conversions.ToString(sqlDataReader[1]);
							bool flag19 = Conversions.ToDouble(value) == 4.0;
							if (flag19)
							{
								TextBox textBox;
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtVentasOtros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num19 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[15].Value);
								num19 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[15].Value = num19;
							}
							bool flag20 = Conversions.ToDouble(value) == 3.0;
							if (flag20)
							{
								TextBox textBox;
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtVales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num20 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[14].Value);
								num20 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[14].Value = num20;
							}
							bool flag21 = Conversions.ToDouble(value) == 1.0;
							if (flag21)
							{
								TextBox textBox;
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtEfectivoAnt).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num21 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[12].Value);
								num21 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[12].Value = num21;
							}
							bool flag22 = Conversions.ToDouble(value) == 2.0;
							if (flag22)
							{
								TextBox textBox;
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtVentaTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num22 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[13].Value);
								num22 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[13].Value = num22;
							}
						}
					}
					else
					{
						TextBox textBox;
						(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
						(textBox = this.txtVales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
					}
				}
				sqlDataReader.Close();
			}
			bool flag23 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
			if (flag23)
			{
				text4 = "SELECT l from H";
				sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
				bool flag24 = sqlDataReader.Read();
				if (flag24)
				{
					string text9 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					text4 = "select idformadepago , tipo from formasdepago where idformadepago = '" + text9.ToString() + "'";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
					bool hasRows6 = sqlDataReader.HasRows;
					if (hasRows6)
					{
						while (sqlDataReader.Read())
						{
							string text6 = Conversions.ToString(sqlDataReader[0]);
							string value = Conversions.ToString(sqlDataReader[1]);
							bool flag25 = Conversions.ToDouble(value) == 4.0;
							if (flag25)
							{
								TextBox textBox;
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtVentasOtros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num23 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[15].Value);
								num23 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[15].Value = num23;
							}
							bool flag26 = Conversions.ToDouble(value) == 3.0;
							if (flag26)
							{
								TextBox textBox;
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtVales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num24 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[14].Value);
								num24 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[14].Value = num24;
							}
							bool flag27 = Conversions.ToDouble(value) == 1.0;
							if (flag27)
							{
								TextBox textBox;
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtEfectivoAnt).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num25 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[12].Value);
								num25 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[12].Value = num25;
							}
							bool flag28 = Conversions.ToDouble(value) == 2.0;
							if (flag28)
							{
								TextBox textBox;
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								(textBox = this.txtVentaTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(num8.ToString()));
								double num26 = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[13].Value);
								num26 += Conversions.ToDouble(num8.ToString());
								this.dgvNotas.Rows[index].Cells[13].Value = num26;
							}
						}
					}
					else
					{
						TextBox textBox;
						(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
						(textBox = this.txtVentasOtros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + 0.0);
					}
				}
				sqlDataReader.Close();
			}
			bool flag29 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
			if (flag29)
			{
				text4 = "Select folio , a.idformadepago , b.descripcion , b.tipo from chequespagos A \r\n                        Inner Join FormasdePago b on b.idformadepago = a.idformadepago \r\n                        WHERE a.folio = '" + Tools.FolioParaAgregar_ProductosEliminarProductos + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				bool hasRows7 = sqlDataReader.HasRows;
				if (hasRows7)
				{
					while (sqlDataReader.Read())
					{
						string left2 = Conversions.ToString(sqlDataReader[3]);
						bool flag30 = Operators.CompareString(left2, "1", false) == 0;
						if (flag30)
						{
							this.btnEfectivo.Visible = true;
						}
						bool flag31 = Operators.CompareString(left2, "2", false) == 0;
						if (flag31)
						{
							this.btnTarjeta.Visible = true;
						}
						bool flag32 = Operators.CompareString(left2, "3", false) == 0;
						if (flag32)
						{
							this.btnVales.Visible = true;
						}
						bool flag33 = Operators.CompareString(left2, "4", false) == 0;
						if (flag33)
						{
							this.btnOtros.Visible = true;
						}
					}
				}
				sqlDataReader.Close();
				this.PanelFormasPago.Visible = true;
			}
			bool flag34 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
			if (flag34)
			{
				text4 = "Select folio , a.idformadepago , b.descripcion , b.tipo from chequespagos A \r\n                        Inner Join FormasdePago b on b.idformadepago = a.idformadepago \r\n                        WHERE a.folio = '" + Tools.FolioParaAgregar_ProductosEliminarProductos + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				bool hasRows8 = sqlDataReader.HasRows;
				if (hasRows8)
				{
					while (sqlDataReader.Read())
					{
						string left2 = Conversions.ToString(sqlDataReader[3]);
						bool flag35 = Operators.CompareString(left2, "1", false) == 0;
						if (flag35)
						{
							this.btnEfectivo.Visible = true;
						}
						bool flag36 = Operators.CompareString(left2, "2", false) == 0;
						if (flag36)
						{
							this.btnTarjeta.Visible = true;
						}
						bool flag37 = Operators.CompareString(left2, "3", false) == 0;
						if (flag37)
						{
							this.btnVales.Visible = true;
						}
						bool flag38 = Operators.CompareString(left2, "4", false) == 0;
						if (flag38)
						{
							this.btnOtros.Visible = true;
						}
					}
				}
				sqlDataReader.Close();
				this.PanelFormasPago.Visible = true;
			}
			bool flag39 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
			if (flag39)
			{
				text4 = "Select folio , a.idformadepago , b.descripcion , b.tipo from chequespagos A \r\n                        Inner Join FormasdePago b on b.idformadepago = a.idformadepago \r\n                        WHERE a.folio = '" + Tools.FolioParaAgregar_ProductosEliminarProductos + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				bool hasRows9 = sqlDataReader.HasRows;
				if (hasRows9)
				{
					while (sqlDataReader.Read())
					{
						string left2 = Conversions.ToString(sqlDataReader[3]);
						bool flag40 = Operators.CompareString(left2, "1", false) == 0;
						if (flag40)
						{
							this.btnEfectivo.Visible = true;
						}
						bool flag41 = Operators.CompareString(left2, "2", false) == 0;
						if (flag41)
						{
							this.btnTarjeta.Visible = true;
						}
						bool flag42 = Operators.CompareString(left2, "3", false) == 0;
						if (flag42)
						{
							this.btnVales.Visible = true;
						}
						bool flag43 = Operators.CompareString(left2, "4", false) == 0;
						if (flag43)
						{
							this.btnOtros.Visible = true;
						}
					}
				}
				sqlDataReader.Close();
				this.PanelFormasPago.Visible = true;
			}
			bool flag44 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
			if (flag44)
			{
				text4 = "Select folio , a.idformadepago , b.descripcion , b.tipo from chequespagos A \r\n                        Inner Join FormasdePago b on b.idformadepago = a.idformadepago \r\n                        WHERE a.folio = '" + Tools.FolioParaAgregar_ProductosEliminarProductos + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				bool hasRows10 = sqlDataReader.HasRows;
				if (hasRows10)
				{
					while (sqlDataReader.Read())
					{
						string left2 = Conversions.ToString(sqlDataReader[3]);
						bool flag45 = Operators.CompareString(left2, "1", false) == 0;
						if (flag45)
						{
							this.btnEfectivo.Visible = true;
						}
						bool flag46 = Operators.CompareString(left2, "2", false) == 0;
						if (flag46)
						{
							this.btnTarjeta.Visible = true;
						}
						bool flag47 = Operators.CompareString(left2, "3", false) == 0;
						if (flag47)
						{
							this.btnVales.Visible = true;
						}
						bool flag48 = Operators.CompareString(left2, "4", false) == 0;
						if (flag48)
						{
							this.btnOtros.Visible = true;
						}
					}
				}
				sqlDataReader.Close();
				this.PanelFormasPago.Visible = true;
			}
			bool flag49 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
			if (flag49)
			{
				text4 = "Select folio , a.idformadepago , b.descripcion , b.tipo from chequespagos A \r\n                        Inner Join FormasdePago b on b.idformadepago = a.idformadepago \r\n                        WHERE a.folio = '" + Tools.FolioParaAgregar_ProductosEliminarProductos + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				bool hasRows11 = sqlDataReader.HasRows;
				if (hasRows11)
				{
					while (sqlDataReader.Read())
					{
						string left2 = Conversions.ToString(sqlDataReader[3]);
						bool flag50 = Operators.CompareString(left2, "1", false) == 0;
						if (flag50)
						{
							this.btnEfectivo.Visible = true;
						}
						bool flag51 = Operators.CompareString(left2, "2", false) == 0;
						if (flag51)
						{
							this.btnTarjeta.Visible = true;
						}
						bool flag52 = Operators.CompareString(left2, "3", false) == 0;
						if (flag52)
						{
							this.btnVales.Visible = true;
						}
						bool flag53 = Operators.CompareString(left2, "4", false) == 0;
						if (flag53)
						{
							this.btnOtros.Visible = true;
						}
					}
				}
				sqlDataReader.Close();
				this.PanelFormasPago.Visible = true;
			}
			bool flag54 = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Eliminar"].Value, true, false), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Cancel."].Value, "No", false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Otros"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Efectivo"].Value, 0, false)), Operators.CompareObjectNotEqual(this.dgvNotas.Rows[index].Cells["Vales"].Value, 0, false)), Operators.CompareObjectEqual(this.dgvNotas.Rows[index].Cells["Tarjeta"].Value, 0, false)));
			if (flag54)
			{
				text4 = "Select folio , a.idformadepago , b.descripcion , b.tipo from chequespagos A \r\n                        Inner Join FormasdePago b on b.idformadepago = a.idformadepago \r\n                        WHERE a.folio = '" + Tools.FolioParaAgregar_ProductosEliminarProductos + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
				bool hasRows12 = sqlDataReader.HasRows;
				if (hasRows12)
				{
					while (sqlDataReader.Read())
					{
						string left2 = Conversions.ToString(sqlDataReader[3]);
						bool flag55 = Operators.CompareString(left2, "1", false) == 0;
						if (flag55)
						{
							this.btnEfectivo.Visible = true;
						}
						bool flag56 = Operators.CompareString(left2, "2", false) == 0;
						if (flag56)
						{
							this.btnTarjeta.Visible = true;
						}
						bool flag57 = Operators.CompareString(left2, "3", false) == 0;
						if (flag57)
						{
							this.btnVales.Visible = true;
						}
						bool flag58 = Operators.CompareString(left2, "4", false) == 0;
						if (flag58)
						{
							this.btnOtros.Visible = true;
						}
					}
				}
				sqlDataReader.Close();
				this.PanelFormasPago.Visible = true;
			}
			text4 = "SELECT Descuento from Cheques where folio='" + this.lblfolioini.Text + "'";
			sqlDataReader = (SqlDataReader)sqlQuery.execReader(text4);
			bool flag59 = sqlDataReader.Read();
			double num27;
			if (flag59)
			{
				num27 = Conversions.ToDouble(sqlDataReader[0]);
			}
			text4 = "Select ISNULL(Sum(i),0) from F where a = '" + this.lblfolioini.Text + "' and k='0'";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text4);
			bool flag60 = sqlDataReader.Read();
			double num28;
			if (flag60)
			{
				num28 = Conversions.ToDouble(sqlDataReader[0]);
				num28 -= num28 / 100.0 * num27;
				this.lblnuevototal.Text = "$ " + num28.ToString("N2");
			}
			int rowIndex2 = Conversions.ToInteger(this.lblnumerodefila.Text);
			this.dgvNotas[11, rowIndex2].Value = num28.ToString("N2");
			double num29 = Conversions.ToDouble(Operators.AddObject(this.dgvNotas[9, rowIndex2].Value, num8));
			this.dgvNotas[9, rowIndex2].Value = num29.ToString("N2");
			double num30 = Conversions.ToDouble(this.txtImpNuevo.Text);
			this.txtImpNuevo.Text = "$ " + num30.ToString("N2");
			double num31 = Conversions.ToDouble(this.txtDifImporte.Text);
			this.txtDifImporte.Text = "$ " + num31.ToString("N2");
			double num32 = Conversions.ToDouble(this.txtEfectivoAnt.Text);
			this.txtEfectivoAnt.Text = "$ " + num32.ToString("N2");
			double num33 = Conversions.ToDouble(this.txtdifotros.Text);
			this.txtdifotros.Text = "$ " + num33.ToString("N2");
			this.lblcortenuevotros.Text = "$ " + num33.ToString("N2");
			double num34 = Conversions.ToDouble(this.txtdifvales.Text);
			this.txtdifvales.Text = "$ " + num34.ToString("N2");
			this.lblcortenuevovales.Text = "$ " + num34.ToString("N2");
			double num35 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
			this.txtEfectivoFiscal.Text = "$ " + num35.ToString("N2");
			this.lblcorteefectivonuevo.Text = "$ " + num35.ToString("N2");
			double num36 = Conversions.ToDouble(this.txtEfectivoCaja.Text);
			this.txtEfectivoCaja.Text = "$ " + num36.ToString("N2");
			this.lblEfectivonuevocorte.Text = "$ " + num36.ToString("N2");
			double num37 = Conversions.ToDouble(this.txtDifTarjeta.Text);
			this.txtDifTarjeta.Text = "$ " + num37.ToString("N2");
			this.lblcortetarjetanuevo.Text = "$ " + num37.ToString("N2");
			double num38 = Conversions.ToDouble(this.lblpropinascortenuevo.Text);
			double num39 = Conversions.ToDouble(this.lblcortenuevodepositos.Text);
			double num40 = Conversions.ToDouble(this.lblcortenuevoretiros.Text);
			this.txtDifPorcen.Text = "% " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			double num41 = num35 + num37 + num33 + num34 - num38 + num39 - num40;
			this.lblsaldofinarlcortenuevo.Text = "$ " + num41.ToString("N2");
			double num42 = Conversions.ToDouble(this.txtImpNuevo.Text);
			double num43 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			double num44 = Conversion.Val(num42) - Conversion.Val(num43);
			this.txtventasinfacturar.Text = "$ " + num44.ToString("N2");
			this.txtFacturaPUB.Text = "$ " + num44.ToString("N2");
			double num45 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			this.txtVentaFacturada.Text = "$ " + num45.ToString("N2");
			this.lblventafacturanew.Text = this.txtVentaFacturada.Text;
			this.lblventasinfacturarnew.Text = this.txtventasinfacturar.Text;
			this.lblfacturapubnew.Text = this.txtFacturaPUB.Text;
			this.DataGridDetalleTickets.ClearSelection();
			this.PanelBuscarProducto.Visible = false;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00095A48 File Offset: 0x00093C48
		private void btnEfectivo_Click(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string left = "1";
			int index = Conversions.ToInteger(this.lblnumerodefila.Text);
			bool flag = Operators.CompareString(left, "1", false) == 0;
			string text;
			SqlDataReader sqlDataReader;
			if (flag)
			{
				TextBox textBox;
				(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
				(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
				(textBox = this.txtEfectivoAnt).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
				double num = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[12].Value);
				num += Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString());
				this.dgvNotas.Rows[index].Cells[12].Value = num;
				text = "SELECT m from H";
				sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
				bool flag2 = sqlDataReader.Read();
				if (flag2)
				{
					string text2 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text2.ToString() + "'";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
					bool hasRows = sqlDataReader.HasRows;
					if (hasRows)
					{
						while (sqlDataReader.Read())
						{
							string left2 = Conversions.ToString(sqlDataReader[1]);
							bool flag3 = Operators.CompareString(left2, "4", false) == 0;
							if (flag3)
							{
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
							bool flag4 = Operators.CompareString(left2, "3", false) == 0;
							if (flag4)
							{
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
							bool flag5 = Operators.CompareString(left2, "1", false) == 0;
							if (flag5)
							{
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
							bool flag6 = Operators.CompareString(left2, "2", false) == 0;
							if (flag6)
							{
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
						}
					}
				}
				sqlDataReader.Close();
			}
			text = "SELECT Descuento from Cheques where folio='" + this.lblfolioini.Text + "'";
			sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
			bool flag7 = sqlDataReader.Read();
			double num2;
			if (flag7)
			{
				num2 = Conversions.ToDouble(sqlDataReader[0]);
			}
			text = "Select ISNULL(Sum(i),0) from F where a = '" + this.lblfolioini.Text + "' and k='0'";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool flag8 = sqlDataReader.Read();
			double num3;
			if (flag8)
			{
				num3 = Conversions.ToDouble(sqlDataReader[0]);
				num3 -= num3 / 100.0 * num2;
				this.lblnuevototal.Text = "$ " + num3.ToString("N2");
			}
			int rowIndex = Conversions.ToInteger(this.lblnumerodefila.Text);
			this.dgvNotas[11, rowIndex].Value = num3.ToString("N2");
			double num4 = Conversions.ToDouble(Operators.AddObject(this.dgvNotas[9, rowIndex].Value, Tools.PrecioCargaProdAlien));
			this.dgvNotas[9, rowIndex].Value = num4.ToString("N2");
			double num5 = Conversions.ToDouble(this.txtImpNuevo.Text);
			this.txtImpNuevo.Text = "$ " + num5.ToString("N2");
			double num6 = Conversions.ToDouble(this.txtDifImporte.Text);
			this.txtDifImporte.Text = "$ " + num6.ToString("N2");
			double num7 = Conversions.ToDouble(this.txtEfectivoAnt.Text);
			this.txtEfectivoAnt.Text = "$ " + num7.ToString("N2");
			double num8 = Conversions.ToDouble(this.txtdifotros.Text);
			this.txtdifotros.Text = "$ " + num8.ToString("N2");
			this.lblcortenuevotros.Text = "$ " + num8.ToString("N2");
			double num9 = Conversions.ToDouble(this.txtdifvales.Text);
			this.txtdifvales.Text = "$ " + num9.ToString("N2");
			this.lblcortenuevovales.Text = "$ " + num9.ToString("N2");
			double num10 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
			this.txtEfectivoFiscal.Text = "$ " + num10.ToString("N2");
			this.lblcorteefectivonuevo.Text = "$ " + num10.ToString("N2");
			double num11 = Conversions.ToDouble(this.txtEfectivoCaja.Text);
			this.txtEfectivoCaja.Text = "$ " + num11.ToString("N2");
			this.lblEfectivonuevocorte.Text = "$ " + num11.ToString("N2");
			double num12 = Conversions.ToDouble(this.txtDifTarjeta.Text);
			this.txtDifTarjeta.Text = "$ " + num12.ToString("N2");
			this.lblcortetarjetanuevo.Text = "$ " + num12.ToString("N2");
			double num13 = Conversions.ToDouble(this.lblpropinascortenuevo.Text);
			double num14 = Conversions.ToDouble(this.lblcortenuevodepositos.Text);
			double num15 = Conversions.ToDouble(this.lblcortenuevoretiros.Text);
			this.txtDifPorcen.Text = "% " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			double num16 = num10 + num12 + num8 + num9 - num13 + num14 - num15;
			this.lblsaldofinarlcortenuevo.Text = "$ " + num16.ToString("N2");
			double num17 = Conversions.ToDouble(this.txtImpNuevo.Text);
			double num18 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			double num19 = Conversion.Val(num17) - Conversion.Val(num18);
			this.txtventasinfacturar.Text = "$ " + num19.ToString("N2");
			this.txtFacturaPUB.Text = "$ " + num19.ToString("N2");
			double num20 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			this.txtVentaFacturada.Text = "$ " + num20.ToString("N2");
			this.lblventafacturanew.Text = this.txtVentaFacturada.Text;
			this.lblventasinfacturarnew.Text = this.txtventasinfacturar.Text;
			this.lblfacturapubnew.Text = this.txtFacturaPUB.Text;
			this.DataGridDetalleTickets.ClearSelection();
			this.PanelFormasPago.Visible = false;
			this.btnEfectivo.Visible = false;
			this.btnTarjeta.Visible = false;
			this.btnOtros.Visible = false;
			this.btnVales.Visible = false;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00096308 File Offset: 0x00094508
		private void btnTarjeta_Click(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string left = "2";
			int index = Conversions.ToInteger(this.lblnumerodefila.Text);
			bool flag = Operators.CompareString(left, "2", false) == 0;
			string text;
			SqlDataReader sqlDataReader;
			if (flag)
			{
				TextBox textBox;
				(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
				(textBox = this.txtVentaTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
				double num = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[13].Value);
				num += Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString());
				this.dgvNotas.Rows[index].Cells[13].Value = num;
				text = "SELECT m from H";
				sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
				bool flag2 = sqlDataReader.Read();
				if (flag2)
				{
					string text2 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text2.ToString() + "'";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
					bool hasRows = sqlDataReader.HasRows;
					if (hasRows)
					{
						while (sqlDataReader.Read())
						{
							string left2 = Conversions.ToString(sqlDataReader[1]);
							bool flag3 = Operators.CompareString(left2, "4", false) == 0;
							if (flag3)
							{
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
							bool flag4 = Operators.CompareString(left2, "3", false) == 0;
							if (flag4)
							{
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
							bool flag5 = Operators.CompareString(left2, "1", false) == 0;
							if (flag5)
							{
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
							bool flag6 = Operators.CompareString(left2, "2", false) == 0;
							if (flag6)
							{
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
						}
					}
				}
				sqlDataReader.Close();
			}
			text = "SELECT Descuento from Cheques where folio='" + this.lblfolioini.Text + "'";
			sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
			bool flag7 = sqlDataReader.Read();
			double num2;
			if (flag7)
			{
				num2 = Conversions.ToDouble(sqlDataReader[0]);
			}
			text = "Select ISNULL(Sum(i),0) from F where a = '" + this.lblfolioini.Text + "' and k='0'";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool flag8 = sqlDataReader.Read();
			double num3;
			if (flag8)
			{
				num3 = Conversions.ToDouble(sqlDataReader[0]);
				num3 -= num3 / 100.0 * num2;
				this.lblnuevototal.Text = "$ " + num3.ToString("N2");
			}
			int rowIndex = Conversions.ToInteger(this.lblnumerodefila.Text);
			this.dgvNotas[11, rowIndex].Value = num3.ToString("N2");
			double num4 = Conversions.ToDouble(Operators.AddObject(this.dgvNotas[9, rowIndex].Value, Tools.PrecioCargaProdAlien));
			this.dgvNotas[9, rowIndex].Value = num4.ToString("N2");
			double num5 = Conversions.ToDouble(this.txtImpNuevo.Text);
			this.txtImpNuevo.Text = "$ " + num5.ToString("N2");
			double num6 = Conversions.ToDouble(this.txtDifImporte.Text);
			this.txtDifImporte.Text = "$ " + num6.ToString("N2");
			double num7 = Conversions.ToDouble(this.txtEfectivoAnt.Text);
			this.txtEfectivoAnt.Text = "$ " + num7.ToString("N2");
			double num8 = Conversions.ToDouble(this.txtdifotros.Text);
			this.txtdifotros.Text = "$ " + num8.ToString("N2");
			this.lblcortenuevotros.Text = "$ " + num8.ToString("N2");
			double num9 = Conversions.ToDouble(this.txtdifvales.Text);
			this.txtdifvales.Text = "$ " + num9.ToString("N2");
			this.lblcortenuevovales.Text = "$ " + num9.ToString("N2");
			double num10 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
			this.txtEfectivoFiscal.Text = "$ " + num10.ToString("N2");
			this.lblcorteefectivonuevo.Text = "$ " + num10.ToString("N2");
			double num11 = Conversions.ToDouble(this.txtEfectivoCaja.Text);
			this.txtEfectivoCaja.Text = "$ " + num11.ToString("N2");
			this.lblEfectivonuevocorte.Text = "$ " + num11.ToString("N2");
			double num12 = Conversions.ToDouble(this.txtDifTarjeta.Text);
			this.txtDifTarjeta.Text = "$ " + num12.ToString("N2");
			this.lblcortetarjetanuevo.Text = "$ " + num12.ToString("N2");
			double num13 = Conversions.ToDouble(this.lblpropinascortenuevo.Text);
			double num14 = Conversions.ToDouble(this.lblcortenuevodepositos.Text);
			double num15 = Conversions.ToDouble(this.lblcortenuevoretiros.Text);
			this.txtDifPorcen.Text = "% " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			double num16 = num10 + num12 + num8 + num9 - num13 + num14 - num15;
			this.lblsaldofinarlcortenuevo.Text = "$ " + num16.ToString("N2");
			double num17 = Conversions.ToDouble(this.txtImpNuevo.Text);
			double num18 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			double num19 = Conversion.Val(num17) - Conversion.Val(num18);
			this.txtventasinfacturar.Text = "$ " + num19.ToString("N2");
			this.txtFacturaPUB.Text = "$ " + num19.ToString("N2");
			double num20 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			this.txtVentaFacturada.Text = "$ " + num20.ToString("N2");
			this.lblventafacturanew.Text = this.txtVentaFacturada.Text;
			this.lblventasinfacturarnew.Text = this.txtventasinfacturar.Text;
			this.lblfacturapubnew.Text = this.txtFacturaPUB.Text;
			this.DataGridDetalleTickets.ClearSelection();
			this.PanelFormasPago.Visible = false;
			this.btnEfectivo.Visible = false;
			this.btnTarjeta.Visible = false;
			this.btnOtros.Visible = false;
			this.btnVales.Visible = false;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00096B98 File Offset: 0x00094D98
		private void btnOtros_Click(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string left = "4";
			int index = Conversions.ToInteger(this.lblnumerodefila.Text);
			bool flag = Operators.CompareString(left, "4", false) == 0;
			string text;
			SqlDataReader sqlDataReader;
			if (flag)
			{
				TextBox textBox;
				(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
				(textBox = this.txtVentasOtros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
				double num = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[15].Value);
				num += Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString());
				this.dgvNotas.Rows[index].Cells[15].Value = num;
				text = "SELECT m from H";
				sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
				bool flag2 = sqlDataReader.Read();
				if (flag2)
				{
					string text2 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text2.ToString() + "'";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
					bool hasRows = sqlDataReader.HasRows;
					if (hasRows)
					{
						while (sqlDataReader.Read())
						{
							string left2 = Conversions.ToString(sqlDataReader[1]);
							bool flag3 = Operators.CompareString(left2, "4", false) == 0;
							if (flag3)
							{
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
							bool flag4 = Operators.CompareString(left2, "3", false) == 0;
							if (flag4)
							{
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
							bool flag5 = Operators.CompareString(left2, "1", false) == 0;
							if (flag5)
							{
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
							bool flag6 = Operators.CompareString(left2, "2", false) == 0;
							if (flag6)
							{
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
						}
					}
				}
				sqlDataReader.Close();
			}
			text = "SELECT Descuento from Cheques where folio='" + this.lblfolioini.Text + "'";
			sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
			bool flag7 = sqlDataReader.Read();
			double num2;
			if (flag7)
			{
				num2 = Conversions.ToDouble(sqlDataReader[0]);
			}
			text = "Select ISNULL(Sum(i),0) from F where a = '" + this.lblfolioini.Text + "' and k='0'";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool flag8 = sqlDataReader.Read();
			double num3;
			if (flag8)
			{
				num3 = Conversions.ToDouble(sqlDataReader[0]);
				num3 -= num3 / 100.0 * num2;
				this.lblnuevototal.Text = "$ " + num3.ToString("N2");
			}
			int rowIndex = Conversions.ToInteger(this.lblnumerodefila.Text);
			this.dgvNotas[11, rowIndex].Value = num3.ToString("N2");
			double num4 = Conversions.ToDouble(Operators.AddObject(this.dgvNotas[9, rowIndex].Value, Tools.PrecioCargaProdAlien));
			this.dgvNotas[9, rowIndex].Value = num4.ToString("N2");
			double num5 = Conversions.ToDouble(this.txtImpNuevo.Text);
			this.txtImpNuevo.Text = "$ " + num5.ToString("N2");
			double num6 = Conversions.ToDouble(this.txtDifImporte.Text);
			this.txtDifImporte.Text = "$ " + num6.ToString("N2");
			double num7 = Conversions.ToDouble(this.txtEfectivoAnt.Text);
			this.txtEfectivoAnt.Text = "$ " + num7.ToString("N2");
			double num8 = Conversions.ToDouble(this.txtdifotros.Text);
			this.txtdifotros.Text = "$ " + num8.ToString("N2");
			this.lblcortenuevotros.Text = "$ " + num8.ToString("N2");
			double num9 = Conversions.ToDouble(this.txtdifvales.Text);
			this.txtdifvales.Text = "$ " + num9.ToString("N2");
			this.lblcortenuevovales.Text = "$ " + num9.ToString("N2");
			double num10 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
			this.txtEfectivoFiscal.Text = "$ " + num10.ToString("N2");
			this.lblcorteefectivonuevo.Text = "$ " + num10.ToString("N2");
			double num11 = Conversions.ToDouble(this.txtEfectivoCaja.Text);
			this.txtEfectivoCaja.Text = "$ " + num11.ToString("N2");
			this.lblEfectivonuevocorte.Text = "$ " + num11.ToString("N2");
			double num12 = Conversions.ToDouble(this.txtDifTarjeta.Text);
			this.txtDifTarjeta.Text = "$ " + num12.ToString("N2");
			this.lblcortetarjetanuevo.Text = "$ " + num12.ToString("N2");
			double num13 = Conversions.ToDouble(this.lblpropinascortenuevo.Text);
			double num14 = Conversions.ToDouble(this.lblcortenuevodepositos.Text);
			double num15 = Conversions.ToDouble(this.lblcortenuevoretiros.Text);
			this.txtDifPorcen.Text = "% " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			double num16 = num10 + num12 + num8 + num9 - num13 + num14 - num15;
			this.lblsaldofinarlcortenuevo.Text = "$ " + num16.ToString("N2");
			double num17 = Conversions.ToDouble(this.txtImpNuevo.Text);
			double num18 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			double num19 = Conversion.Val(num17) - Conversion.Val(num18);
			this.txtventasinfacturar.Text = "$ " + num19.ToString("N2");
			this.txtFacturaPUB.Text = "$ " + num19.ToString("N2");
			double num20 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			this.txtVentaFacturada.Text = "$ " + num20.ToString("N2");
			this.lblventafacturanew.Text = this.txtVentaFacturada.Text;
			this.lblventasinfacturarnew.Text = this.txtventasinfacturar.Text;
			this.lblfacturapubnew.Text = this.txtFacturaPUB.Text;
			this.DataGridDetalleTickets.ClearSelection();
			this.PanelFormasPago.Visible = false;
			this.btnEfectivo.Visible = false;
			this.btnTarjeta.Visible = false;
			this.btnOtros.Visible = false;
			this.btnVales.Visible = false;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00097428 File Offset: 0x00095628
		private void btnVales_Click(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string left = "3";
			int index = Conversions.ToInteger(this.lblnumerodefila.Text);
			bool flag = Operators.CompareString(left, "3", false) == 0;
			string text;
			SqlDataReader sqlDataReader;
			if (flag)
			{
				TextBox textBox;
				(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
				(textBox = this.txtVales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
				double num = Conversions.ToDouble(this.dgvNotas.Rows[index].Cells[14].Value);
				num += Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString());
				this.dgvNotas.Rows[index].Cells[14].Value = num;
				text = "SELECT m from H";
				sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
				bool flag2 = sqlDataReader.Read();
				if (flag2)
				{
					string text2 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					text = "select idformadepago , tipo from formasdepago where idformadepago = '" + text2.ToString() + "'";
					sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
					bool hasRows = sqlDataReader.HasRows;
					if (hasRows)
					{
						while (sqlDataReader.Read())
						{
							string left2 = Conversions.ToString(sqlDataReader[1]);
							bool flag3 = Operators.CompareString(left2, "4", false) == 0;
							if (flag3)
							{
								(textBox = this.txtdifotros).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
							bool flag4 = Operators.CompareString(left2, "3", false) == 0;
							if (flag4)
							{
								(textBox = this.txtdifvales).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
							bool flag5 = Operators.CompareString(left2, "1", false) == 0;
							if (flag5)
							{
								(textBox = this.txtEfectivoFiscal).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
								(textBox = this.txtEfectivoCaja).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
							bool flag6 = Operators.CompareString(left2, "2", false) == 0;
							if (flag6)
							{
								(textBox = this.txtDifTarjeta).Text = Conversions.ToString(Conversions.ToDouble(textBox.Text) + Conversions.ToDouble(Tools.PrecioCargaProdAlien.ToString()));
							}
						}
					}
				}
				sqlDataReader.Close();
			}
			text = "SELECT Descuento from Cheques where folio='" + this.lblfolioini.Text + "'";
			sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
			bool flag7 = sqlDataReader.Read();
			double num2;
			if (flag7)
			{
				num2 = Conversions.ToDouble(sqlDataReader[0]);
			}
			text = "Select ISNULL(Sum(i),0) from F where a = '" + this.lblfolioini.Text + "' and k='0'";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool flag8 = sqlDataReader.Read();
			double num3;
			if (flag8)
			{
				num3 = Conversions.ToDouble(sqlDataReader[0]);
				num3 -= num3 / 100.0 * num2;
				this.lblnuevototal.Text = "$ " + num3.ToString("N2");
			}
			int rowIndex = Conversions.ToInteger(this.lblnumerodefila.Text);
			this.dgvNotas[11, rowIndex].Value = num3.ToString("N2");
			double num4 = Conversions.ToDouble(Operators.AddObject(this.dgvNotas[9, rowIndex].Value, Tools.PrecioCargaProdAlien));
			this.dgvNotas[9, rowIndex].Value = num4.ToString("N2");
			double num5 = Conversions.ToDouble(this.txtImpNuevo.Text);
			this.txtImpNuevo.Text = "$ " + num5.ToString("N2");
			double num6 = Conversions.ToDouble(this.txtDifImporte.Text);
			this.txtDifImporte.Text = "$ " + num6.ToString("N2");
			double num7 = Conversions.ToDouble(this.txtEfectivoAnt.Text);
			this.txtEfectivoAnt.Text = "$ " + num7.ToString("N2");
			double num8 = Conversions.ToDouble(this.txtdifotros.Text);
			this.txtdifotros.Text = "$ " + num8.ToString("N2");
			this.lblcortenuevotros.Text = "$ " + num8.ToString("N2");
			double num9 = Conversions.ToDouble(this.txtdifvales.Text);
			this.txtdifvales.Text = "$ " + num9.ToString("N2");
			this.lblcortenuevovales.Text = "$ " + num9.ToString("N2");
			double num10 = Conversions.ToDouble(this.txtEfectivoFiscal.Text);
			this.txtEfectivoFiscal.Text = "$ " + num10.ToString("N2");
			this.lblcorteefectivonuevo.Text = "$ " + num10.ToString("N2");
			double num11 = Conversions.ToDouble(this.txtEfectivoCaja.Text);
			this.txtEfectivoCaja.Text = "$ " + num11.ToString("N2");
			this.lblEfectivonuevocorte.Text = "$ " + num11.ToString("N2");
			double num12 = Conversions.ToDouble(this.txtDifTarjeta.Text);
			this.txtDifTarjeta.Text = "$ " + num12.ToString("N2");
			this.lblcortetarjetanuevo.Text = "$ " + num12.ToString("N2");
			double num13 = Conversions.ToDouble(this.lblpropinascortenuevo.Text);
			double num14 = Conversions.ToDouble(this.lblcortenuevodepositos.Text);
			double num15 = Conversions.ToDouble(this.lblcortenuevoretiros.Text);
			this.txtDifPorcen.Text = "% " + (100.0 / Conversions.ToDouble(this.txtImpAnterior.Text) * Conversions.ToDouble(this.txtDifImporte.Text)).ToString("N2");
			double num16 = num10 + num12 + num8 + num9 - num13 + num14 - num15;
			this.lblsaldofinarlcortenuevo.Text = "$ " + num16.ToString("N2");
			double num17 = Conversions.ToDouble(this.txtImpNuevo.Text);
			double num18 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			double num19 = Conversion.Val(num17) - Conversion.Val(num18);
			this.txtventasinfacturar.Text = "$ " + num19.ToString("N2");
			this.txtFacturaPUB.Text = "$ " + num19.ToString("N2");
			double num20 = Conversions.ToDouble(this.txtVentaFacturada.Text);
			this.txtVentaFacturada.Text = "$ " + num20.ToString("N2");
			this.lblventafacturanew.Text = this.txtVentaFacturada.Text;
			this.lblventasinfacturarnew.Text = this.txtventasinfacturar.Text;
			this.lblfacturapubnew.Text = this.txtFacturaPUB.Text;
			this.DataGridDetalleTickets.ClearSelection();
			this.PanelFormasPago.Visible = false;
			this.btnEfectivo.Visible = false;
			this.btnTarjeta.Visible = false;
			this.btnOtros.Visible = false;
			this.btnVales.Visible = false;
		}

		// Token: 0x040003A6 RID: 934
		private object iFolioInicial;

		// Token: 0x040003A7 RID: 935
		private object iNumChequeInicial;

		// Token: 0x040003A8 RID: 936
		private string strFolio;

		// Token: 0x040003A9 RID: 937
		private DataTable table;

		// Token: 0x040003AA RID: 938
		private DataView view;

		// Token: 0x040003AB RID: 939
		private double PrecioNuevo;

		// Token: 0x040003AC RID: 940
		private string idmesero;

		// Token: 0x040003AD RID: 941
		private string estacion;

		// Token: 0x040003AE RID: 942
		private DateTime FechaTicket;

		// Token: 0x040003AF RID: 943
		private string idTurnoTicket;

		// Token: 0x040003B0 RID: 944
		private string Descomponercuentas;

		// Token: 0x040003B1 RID: 945
		private string DifPorcentajeSin;

		// Token: 0x040003B2 RID: 946
		private DateTime fechaProducto;

		// Token: 0x040003B3 RID: 947
		private string Estacion1;

		// Token: 0x040003B4 RID: 948
		private int counter;

		// Token: 0x040003B5 RID: 949
		private string idEstacion;

		// Token: 0x040003B6 RID: 950
		private string idMeseros;

		// Token: 0x040003B7 RID: 951
		private string idturno_cierre;

		// Token: 0x040003B8 RID: 952
		private DateTime Hora;
	}
}
