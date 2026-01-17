using System;
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
	// Token: 0x0200000D RID: 13
	[DesignerGenerated]
	public partial class FrmBitacora : Form
	{
		// Token: 0x060001DB RID: 475 RVA: 0x00015C94 File Offset: 0x00013E94
		public FrmBitacora()
		{
			base.Load += this.FrmBitacora_Load;
			this.InitializeComponent();
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00018E05 File Offset: 0x00017005
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00018E0F File Offset: 0x0001700F
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00018E18 File Offset: 0x00017018
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00018E22 File Offset: 0x00017022
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00018E2B File Offset: 0x0001702B
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00018E38 File Offset: 0x00017038
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
				DataGridView dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellClick -= value2;
				}
				this._dgvNotas = value;
				dgvNotas = this._dgvNotas;
				if (dgvNotas != null)
				{
					dgvNotas.CellClick += value2;
				}
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00018E7B File Offset: 0x0001707B
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00018E88 File Offset: 0x00017088
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00018ECB File Offset: 0x000170CB
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00018ED5 File Offset: 0x000170D5
		internal virtual Panel Panelvercortes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00018EDE File Offset: 0x000170DE
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00018EE8 File Offset: 0x000170E8
		internal virtual Label lblfacturapubnew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00018EF1 File Offset: 0x000170F1
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00018EFB File Offset: 0x000170FB
		internal virtual Label lblventasinfacturarnew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00018F04 File Offset: 0x00017104
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00018F0E File Offset: 0x0001710E
		internal virtual Label lblventafacturanew { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00018F17 File Offset: 0x00017117
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00018F21 File Offset: 0x00017121
		internal virtual Label lblfacturapub { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00018F2A File Offset: 0x0001712A
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00018F34 File Offset: 0x00017134
		internal virtual Label lblventasinfacturarcorte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00018F3D File Offset: 0x0001713D
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00018F47 File Offset: 0x00017147
		internal virtual Label lblventaFacturada { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00018F50 File Offset: 0x00017150
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00018F5A File Offset: 0x0001715A
		internal virtual Label Label60 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00018F63 File Offset: 0x00017163
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00018F6D File Offset: 0x0001716D
		internal virtual Label Label61 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00018F76 File Offset: 0x00017176
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00018F80 File Offset: 0x00017180
		internal virtual Label Label62 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00018F89 File Offset: 0x00017189
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00018F93 File Offset: 0x00017193
		internal virtual Label Label59 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00018F9C File Offset: 0x0001719C
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00018FA6 File Offset: 0x000171A6
		internal virtual Label Label58 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00018FAF File Offset: 0x000171AF
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00018FB9 File Offset: 0x000171B9
		internal virtual Label Label57 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00018FC2 File Offset: 0x000171C2
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00018FCC File Offset: 0x000171CC
		internal virtual Label Label53 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00018FD5 File Offset: 0x000171D5
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00018FDF File Offset: 0x000171DF
		internal virtual Label Label56 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00018FE8 File Offset: 0x000171E8
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00018FF2 File Offset: 0x000171F2
		internal virtual Label Label40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00018FFB File Offset: 0x000171FB
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00019005 File Offset: 0x00017205
		internal virtual Label Label51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0001900E File Offset: 0x0001720E
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00019018 File Offset: 0x00017218
		internal virtual Label Label52 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00019021 File Offset: 0x00017221
		// (set) Token: 0x0600020B RID: 523 RVA: 0x0001902B File Offset: 0x0001722B
		internal virtual Label lblEfectivonuevocorte { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00019034 File Offset: 0x00017234
		// (set) Token: 0x0600020D RID: 525 RVA: 0x0001903E File Offset: 0x0001723E
		internal virtual Label lblsaldofinarlcortenuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00019047 File Offset: 0x00017247
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00019051 File Offset: 0x00017251
		internal virtual Label lblpropinascortenuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0001905A File Offset: 0x0001725A
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00019064 File Offset: 0x00017264
		internal virtual Label lblcortenuevoretiros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0001906D File Offset: 0x0001726D
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00019077 File Offset: 0x00017277
		internal virtual Label lblcortenuevodepositos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00019080 File Offset: 0x00017280
		// (set) Token: 0x06000215 RID: 533 RVA: 0x0001908A File Offset: 0x0001728A
		internal virtual Label lblcortenuevotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00019093 File Offset: 0x00017293
		// (set) Token: 0x06000217 RID: 535 RVA: 0x0001909D File Offset: 0x0001729D
		internal virtual Label lblcortenuevovales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000218 RID: 536 RVA: 0x000190A6 File Offset: 0x000172A6
		// (set) Token: 0x06000219 RID: 537 RVA: 0x000190B0 File Offset: 0x000172B0
		internal virtual Label lblcortetarjetanuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600021A RID: 538 RVA: 0x000190B9 File Offset: 0x000172B9
		// (set) Token: 0x0600021B RID: 539 RVA: 0x000190C4 File Offset: 0x000172C4
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

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00019107 File Offset: 0x00017307
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00019111 File Offset: 0x00017311
		internal virtual Label lblcorteefectivonuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0001911A File Offset: 0x0001731A
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00019124 File Offset: 0x00017324
		internal virtual Label lblfondoinicialnuevo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0001912D File Offset: 0x0001732D
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00019137 File Offset: 0x00017337
		internal virtual Label lblcortefondoinicialanterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00019140 File Offset: 0x00017340
		// (set) Token: 0x06000223 RID: 547 RVA: 0x0001914A File Offset: 0x0001734A
		internal virtual Label Label41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00019153 File Offset: 0x00017353
		// (set) Token: 0x06000225 RID: 549 RVA: 0x0001915D File Offset: 0x0001735D
		internal virtual Label Label42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00019166 File Offset: 0x00017366
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00019170 File Offset: 0x00017370
		internal virtual Label Label43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00019179 File Offset: 0x00017379
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00019183 File Offset: 0x00017383
		internal virtual Label Label44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0001918C File Offset: 0x0001738C
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00019196 File Offset: 0x00017396
		internal virtual Label Label45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0001919F File Offset: 0x0001739F
		// (set) Token: 0x0600022D RID: 557 RVA: 0x000191A9 File Offset: 0x000173A9
		internal virtual Label Label46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600022E RID: 558 RVA: 0x000191B2 File Offset: 0x000173B2
		// (set) Token: 0x0600022F RID: 559 RVA: 0x000191BC File Offset: 0x000173BC
		internal virtual Label Label47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000230 RID: 560 RVA: 0x000191C5 File Offset: 0x000173C5
		// (set) Token: 0x06000231 RID: 561 RVA: 0x000191CF File Offset: 0x000173CF
		internal virtual Label Label48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000232 RID: 562 RVA: 0x000191D8 File Offset: 0x000173D8
		// (set) Token: 0x06000233 RID: 563 RVA: 0x000191E2 File Offset: 0x000173E2
		internal virtual Label Label49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000234 RID: 564 RVA: 0x000191EB File Offset: 0x000173EB
		// (set) Token: 0x06000235 RID: 565 RVA: 0x000191F5 File Offset: 0x000173F5
		internal virtual Label Label39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000236 RID: 566 RVA: 0x000191FE File Offset: 0x000173FE
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00019208 File Offset: 0x00017408
		internal virtual Label lblcorteanteriorefectivofinal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00019211 File Offset: 0x00017411
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0001921B File Offset: 0x0001741B
		internal virtual Label lblcorteanteriorsaldo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00019224 File Offset: 0x00017424
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0001922E File Offset: 0x0001742E
		internal virtual Label lblcorteanteriorpropinas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00019237 File Offset: 0x00017437
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00019241 File Offset: 0x00017441
		internal virtual Label lblcorteanteriorretirosefectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0001924A File Offset: 0x0001744A
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00019254 File Offset: 0x00017454
		internal virtual Label lblcorteanteriordepositosenefectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0001925D File Offset: 0x0001745D
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00019267 File Offset: 0x00017467
		internal virtual Label lblcorteanteriorotros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00019270 File Offset: 0x00017470
		// (set) Token: 0x06000243 RID: 579 RVA: 0x0001927A File Offset: 0x0001747A
		internal virtual Label lblcorteanteriorvales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00019283 File Offset: 0x00017483
		// (set) Token: 0x06000245 RID: 581 RVA: 0x0001928D File Offset: 0x0001748D
		internal virtual Label lblcorteefectivoanterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00019296 File Offset: 0x00017496
		// (set) Token: 0x06000247 RID: 583 RVA: 0x000192A0 File Offset: 0x000174A0
		internal virtual Label lblcortetarjetaanterior { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000192A9 File Offset: 0x000174A9
		// (set) Token: 0x06000249 RID: 585 RVA: 0x000192B3 File Offset: 0x000174B3
		internal virtual Label Label38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600024A RID: 586 RVA: 0x000192BC File Offset: 0x000174BC
		// (set) Token: 0x0600024B RID: 587 RVA: 0x000192C6 File Offset: 0x000174C6
		internal virtual Label Label37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600024C RID: 588 RVA: 0x000192CF File Offset: 0x000174CF
		// (set) Token: 0x0600024D RID: 589 RVA: 0x000192D9 File Offset: 0x000174D9
		internal virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000192E2 File Offset: 0x000174E2
		// (set) Token: 0x0600024F RID: 591 RVA: 0x000192EC File Offset: 0x000174EC
		internal virtual Label Label35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000250 RID: 592 RVA: 0x000192F5 File Offset: 0x000174F5
		// (set) Token: 0x06000251 RID: 593 RVA: 0x000192FF File Offset: 0x000174FF
		internal virtual Label Label34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00019308 File Offset: 0x00017508
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00019312 File Offset: 0x00017512
		internal virtual Label Label33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0001931B File Offset: 0x0001751B
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00019325 File Offset: 0x00017525
		internal virtual Label Label32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0001932E File Offset: 0x0001752E
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00019338 File Offset: 0x00017538
		internal virtual Label Label31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00019341 File Offset: 0x00017541
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0001934B File Offset: 0x0001754B
		internal virtual Label Label30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00019354 File Offset: 0x00017554
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0001935E File Offset: 0x0001755E
		internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00019367 File Offset: 0x00017567
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00019371 File Offset: 0x00017571
		internal virtual Label Label28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600025E RID: 606 RVA: 0x0001937A File Offset: 0x0001757A
		private void FrmBitacora_Load(object sender, EventArgs e)
		{
			this.Panelvercortes.Visible = false;
			this.iniciaGridFolio();
			this.MostarReporte();
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00019398 File Offset: 0x00017598
		private void iniciaGridFolio()
		{
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			this.dgvNotas.Rows.Clear();
			this.dgvNotas.ColumnCount = 23;
			this.dgvNotas.Columns[0].Name = "Fecha Aplicacion";
			this.dgvNotas.Columns[0].Visible = true;
			this.dgvNotas.Columns[0].Width = 140;
			this.dgvNotas.Columns[1].Name = "Periodo Inicial";
			this.dgvNotas.Columns[1].Width = 140;
			this.dgvNotas.Columns[2].Name = "Periodo Final ";
			this.dgvNotas.Columns[2].Width = 140;
			this.dgvNotas.Columns[3].Name = "Cuentas Total";
			this.dgvNotas.Columns[3].Width = 80;
			this.dgvNotas.Columns[4].Name = "Cuentas Modificadas";
			this.dgvNotas.Columns[4].Width = 80;
			this.dgvNotas.Columns[5].Name = "Venta Anterior";
			this.dgvNotas.Columns[5].Width = 80;
			this.dgvNotas.Columns[6].Name = "Venta Nueva";
			this.dgvNotas.Columns[6].Width = 80;
			this.dgvNotas.Columns[7].Name = "Efectivo Anterior";
			this.dgvNotas.Columns[7].Width = 80;
			this.dgvNotas.Columns[8].Name = "Efectivo Nuevo";
			this.dgvNotas.Columns[8].Width = 80;
			this.dgvNotas.Columns[9].Name = "Tarjeta Anterior";
			this.dgvNotas.Columns[9].Width = 80;
			this.dgvNotas.Columns[10].Name = "Tarjeta Nuevo";
			this.dgvNotas.Columns[10].Width = 80;
			this.dgvNotas.Columns[11].Name = "Vales Anterior";
			this.dgvNotas.Columns[11].Width = 80;
			this.dgvNotas.Columns[12].Name = "Vales Nuevo";
			this.dgvNotas.Columns[12].Width = 80;
			this.dgvNotas.Columns[13].Name = "Otros Anterior";
			this.dgvNotas.Columns[13].Width = 80;
			this.dgvNotas.Columns[14].Name = "Otros Nuevo";
			this.dgvNotas.Columns[14].Width = 80;
			this.dgvNotas.Columns[15].Name = "Propinas Anterior";
			this.dgvNotas.Columns[15].Width = 80;
			this.dgvNotas.Columns[16].Name = "Propinas Nuevo";
			this.dgvNotas.Columns[16].Width = 80;
			this.dgvNotas.Columns[17].Name = "Descuento %";
			this.dgvNotas.Columns[17].Width = 80;
			this.dgvNotas.Columns[18].Name = "Tipo";
			this.dgvNotas.Columns[18].Width = 150;
			this.dgvNotas.Columns[19].Name = "Base de Datos";
			this.dgvNotas.Columns[19].Width = 80;
			this.dgvNotas.Columns[20].Name = "Empresa";
			this.dgvNotas.Columns[20].Width = 80;
			this.dgvNotas.Columns[21].Name = "Usuario";
			this.dgvNotas.Columns[21].Width = 80;
			this.dgvNotas.Columns[22].Name = "CodigoUnico";
			this.dgvNotas.Columns[22].Width = 80;
			this.dgvNotas.Columns[22].Visible = false;
			dataGridViewButtonColumn.Width = 60;
			dataGridViewButtonColumn.Name = "Ver Corte";
			this.dgvNotas.Columns.Add(dataGridViewButtonColumn);
			this.DoubleBufferedASD(this.dgvNotas, true);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0001991C File Offset: 0x00017B1C
		public void DoubleBufferedASD(DataGridView dgv, bool setting)
		{
			Type type = dgv.GetType();
			PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
			property.SetValue(dgv, setting, null);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00019950 File Offset: 0x00017B50
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
			base.Close();
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00019A50 File Offset: 0x00017C50
		public void MostarReporte()
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = "select a , b , c ,d ,e ,f ,g ,h ,i ,j ,k ,l ,m ,n ,o ,p ,q , r , s , t , u , w , x   from I order by id desc";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			this.iniciaGridFolio();
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					DateTime dateTime = Conversions.ToDate(sqlDataReader[0]);
					DateTime dateTime2 = Conversions.ToDate(sqlDataReader[1]);
					DateTime dateTime3 = Conversions.ToDate(sqlDataReader[2]);
					string text = Conversions.ToString(sqlDataReader[3]);
					string text2 = Conversions.ToString(sqlDataReader[4]);
					string text3 = Conversions.ToString(sqlDataReader[5]);
					string text4 = Conversions.ToString(sqlDataReader[6]);
					string text5 = Conversions.ToString(sqlDataReader[7]);
					string text6 = Conversions.ToString(sqlDataReader[8]);
					string text7 = Conversions.ToString(sqlDataReader[9]);
					string text8 = Conversions.ToString(sqlDataReader[10]);
					bool flag = Operators.ConditionalCompareObjectEqual(sqlDataReader[11], "1", false);
					if (flag)
					{
					}
					string text9 = "AFECTADA";
					string text10 = Conversions.ToString(sqlDataReader[12]);
					string text11 = Conversions.ToString(sqlDataReader[13]);
					string text12 = Conversions.ToString(sqlDataReader[14]);
					string text13 = Conversions.ToString(sqlDataReader[15]);
					string text14 = Conversions.ToString(sqlDataReader[16]);
					string text15 = Conversions.ToString(sqlDataReader[17]);
					string text16 = Conversions.ToString(sqlDataReader[18]);
					string text17 = Conversions.ToString(sqlDataReader[19]);
					string text18 = Conversions.ToString(sqlDataReader[20]);
					string text19 = Conversions.ToString(sqlDataReader[21]);
					string text20 = Conversions.ToString(sqlDataReader[22]);
					this.dgvNotas.Rows.Add(new object[]
					{
						dateTime.ToString("dd-MM-yyyy hh:mm:ss tt"),
						dateTime2.ToString("dd-MM-yyyy hh:mm:ss tt"),
						dateTime3.ToString("dd-MM-yyyy hh:mm:ss tt"),
						Tools.Desencriptar(text.ToString().Trim()),
						Tools.Desencriptar(text2.ToString().Trim()),
						Tools.Desencriptar(text3.ToString().Trim()),
						Tools.Desencriptar(text4.ToString().Trim()),
						Tools.Desencriptar(text5.ToString().Trim()),
						Tools.Desencriptar(text6.ToString().Trim()),
						Tools.Desencriptar(text11.ToString().Trim()),
						Tools.Desencriptar(text12.ToString().Trim()),
						Tools.Desencriptar(text13.ToString().Trim()),
						Tools.Desencriptar(text14.ToString().Trim()),
						Tools.Desencriptar(text15.ToString().Trim()),
						Tools.Desencriptar(text16.ToString().Trim()),
						Tools.Desencriptar(text17.ToString().Trim()),
						Tools.Desencriptar(text18.ToString().Trim()),
						Tools.Desencriptar(text7.ToString().Trim()),
						Tools.Desencriptar(text8.ToString().Trim()),
						text9.ToString().Trim(),
						Tools.Desencriptar(text10.ToString().Trim()),
						Tools.Desencriptar(text19.ToString().Trim()),
						Tools.Desencriptar(text20.ToString().Trim())
					});
				}
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00019E0C File Offset: 0x0001800C
		private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			int rowIndex = e.RowIndex;
			bool flag = e.RowIndex >= 0 && e.ColumnIndex == 23;
			if (flag)
			{
				string text = Conversions.ToString(this.dgvNotas.Rows[rowIndex].Cells["CodigoUnico"].Value);
				string query_conn = "SELECT b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,aa from M where a='" + Tools.Encriptar(text.ToString().Trim()) + "'";
				SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
				bool hasRows = sqlDataReader.HasRows;
				if (hasRows)
				{
					this.Panelvercortes.Visible = true;
					while (sqlDataReader.Read())
					{
						string text2 = Conversions.ToString(sqlDataReader[0]);
						string text3 = Conversions.ToString(sqlDataReader[1]);
						string text4 = Conversions.ToString(sqlDataReader[2]);
						string text5 = Conversions.ToString(sqlDataReader[3]);
						string text6 = Conversions.ToString(sqlDataReader[4]);
						string text7 = Conversions.ToString(sqlDataReader[5]);
						string text8 = Conversions.ToString(sqlDataReader[6]);
						string text9 = Conversions.ToString(sqlDataReader[7]);
						string text10 = Conversions.ToString(sqlDataReader[8]);
						string text11 = Conversions.ToString(sqlDataReader[9]);
						string text12 = Conversions.ToString(sqlDataReader[10]);
						string text13 = Conversions.ToString(sqlDataReader[11]);
						string text14 = Conversions.ToString(sqlDataReader[12]);
						string text15 = Conversions.ToString(sqlDataReader[13]);
						string text16 = Conversions.ToString(sqlDataReader[14]);
						string text17 = Conversions.ToString(sqlDataReader[15]);
						string text18 = Conversions.ToString(sqlDataReader[16]);
						string text19 = Conversions.ToString(sqlDataReader[17]);
						string text20 = Conversions.ToString(sqlDataReader[18]);
						string text21 = Conversions.ToString(sqlDataReader[19]);
						string text22 = Conversions.ToString(sqlDataReader[20]);
						string text23 = Conversions.ToString(sqlDataReader[21]);
						string text24 = Conversions.ToString(sqlDataReader[22]);
						string text25 = Conversions.ToString(sqlDataReader[23]);
						string text26 = Conversions.ToString(sqlDataReader[24]);
						string text27 = Conversions.ToString(sqlDataReader[25]);
						this.lblcortefondoinicialanterior.Text = Tools.Desencriptar(text2.ToString()).Trim();
						this.lblcorteefectivoanterior.Text = Tools.Desencriptar(text3.ToString()).Trim();
						this.lblcortetarjetaanterior.Text = Tools.Desencriptar(text4.ToString()).Trim();
						this.lblcorteanteriorvales.Text = Tools.Desencriptar(text5.ToString()).Trim();
						this.lblcorteanteriorotros.Text = Tools.Desencriptar(text6.ToString()).Trim();
						this.lblcorteanteriordepositosenefectivo.Text = Tools.Desencriptar(text7.ToString()).Trim();
						this.lblcorteanteriorretirosefectivo.Text = Tools.Desencriptar(text8.ToString()).Trim();
						this.lblcorteanteriorpropinas.Text = Tools.Desencriptar(text9.ToString()).Trim();
						this.lblcorteanteriorsaldo.Text = Tools.Desencriptar(text10.ToString()).Trim();
						this.lblcorteanteriorefectivofinal.Text = Tools.Desencriptar(text11.ToString()).Trim();
						this.lblventaFacturada.Text = Tools.Desencriptar(text12.ToString()).Trim();
						this.lblventasinfacturarcorte.Text = Tools.Desencriptar(text13.ToString()).Trim();
						this.lblfacturapub.Text = Tools.Desencriptar(text14.ToString()).Trim();
						this.lblfondoinicialnuevo.Text = Tools.Desencriptar(text15.ToString()).Trim();
						this.lblcorteefectivonuevo.Text = Tools.Desencriptar(text16.ToString()).Trim();
						this.lblcortetarjetanuevo.Text = Tools.Desencriptar(text17.ToString()).Trim();
						this.lblcortenuevovales.Text = Tools.Desencriptar(text18.ToString()).Trim();
						this.lblcortenuevotros.Text = Tools.Desencriptar(text19.ToString()).Trim();
						this.lblcortenuevodepositos.Text = Tools.Desencriptar(text20.ToString()).Trim();
						this.lblcortenuevoretiros.Text = Tools.Desencriptar(text21.ToString()).Trim();
						this.lblpropinascortenuevo.Text = Tools.Desencriptar(text22.ToString()).Trim();
						this.lblsaldofinarlcortenuevo.Text = Tools.Desencriptar(text23.ToString()).Trim();
						this.lblEfectivonuevocorte.Text = Tools.Desencriptar(text24.ToString()).Trim();
						this.lblventafacturanew.Text = Tools.Desencriptar(text25.ToString()).Trim();
						this.lblventasinfacturarnew.Text = Tools.Desencriptar(text26.ToString()).Trim();
						this.lblfacturapubnew.Text = Tools.Desencriptar(text27.ToString()).Trim();
					}
				}
				else
				{
					this.Panelvercortes.Visible = false;
					Interaction.MsgBox("No hay registros para consultar, intenta con otro!", MsgBoxStyle.OkOnly, null);
				}
				sqlDataReader.Close();
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0001A368 File Offset: 0x00018568
		private void PictureBox3_Click(object sender, EventArgs e)
		{
			this.Panelvercortes.Visible = false;
		}
	}
}
