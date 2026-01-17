using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x0200001D RID: 29
	[DesignerGenerated]
	public partial class frmParametros : Form
	{
		// Token: 0x06000C70 RID: 3184 RVA: 0x000CC3AB File Offset: 0x000CA5AB
		public frmParametros()
		{
			base.Load += this.frmParametros_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x000CE8EB File Offset: 0x000CCAEB
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x000CE8F5 File Offset: 0x000CCAF5
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x000CE8FE File Offset: 0x000CCAFE
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x000CE908 File Offset: 0x000CCB08
		internal virtual CheckBox CheckBox1
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox1_CheckedChanged);
				CheckBox checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._CheckBox1 = value;
				checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x000CE94B File Offset: 0x000CCB4B
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x000CE955 File Offset: 0x000CCB55
		internal virtual BackgroundWorker BackgroundWorker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x000CE95E File Offset: 0x000CCB5E
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x000CE968 File Offset: 0x000CCB68
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x000CE971 File Offset: 0x000CCB71
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x000CE97C File Offset: 0x000CCB7C
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

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x000CE9BF File Offset: 0x000CCBBF
		// (set) Token: 0x06000C7E RID: 3198 RVA: 0x000CE9C9 File Offset: 0x000CCBC9
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x000CE9D2 File Offset: 0x000CCBD2
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x000CE9DC File Offset: 0x000CCBDC
		internal virtual Label lblventasnoalmacenadas { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x000CE9E5 File Offset: 0x000CCBE5
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x000CE9EF File Offset: 0x000CCBEF
		internal virtual Label lblAlmacenaVentasAcrivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x000CE9F8 File Offset: 0x000CCBF8
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x000CEA02 File Offset: 0x000CCC02
		internal virtual Label lblBitacoraActiva { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x000CEA0B File Offset: 0x000CCC0B
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x000CEA15 File Offset: 0x000CCC15
		internal virtual Label lblBitacoraDesactivada { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x000CEA1E File Offset: 0x000CCC1E
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x000CEA28 File Offset: 0x000CCC28
		internal virtual CheckBox CheckBox2
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox2_CheckedChanged);
				CheckBox checkBox = this._CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._CheckBox2 = value;
				checkBox = this._CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x000CEA6B File Offset: 0x000CCC6B
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x000CEA75 File Offset: 0x000CCC75
		internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x000CEA7E File Offset: 0x000CCC7E
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x000CEA88 File Offset: 0x000CCC88
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x000CEA91 File Offset: 0x000CCC91
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x000CEA9B File Offset: 0x000CCC9B
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x000CEAA4 File Offset: 0x000CCCA4
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x000CEAAE File Offset: 0x000CCCAE
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x000CEAB7 File Offset: 0x000CCCB7
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x000CEAC1 File Offset: 0x000CCCC1
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x000CEACA File Offset: 0x000CCCCA
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x000CEAD4 File Offset: 0x000CCCD4
		internal virtual ComboBox ComboBoxOtros
		{
			[CompilerGenerated]
			get
			{
				return this._ComboBoxOtros;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBoxOtros_SelectedIndexChanged);
				ComboBox comboBoxOtros = this._ComboBoxOtros;
				if (comboBoxOtros != null)
				{
					comboBoxOtros.SelectedIndexChanged -= value2;
				}
				this._ComboBoxOtros = value;
				comboBoxOtros = this._ComboBoxOtros;
				if (comboBoxOtros != null)
				{
					comboBoxOtros.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x000CEB17 File Offset: 0x000CCD17
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x000CEB24 File Offset: 0x000CCD24
		internal virtual ComboBox ComboBoxVales
		{
			[CompilerGenerated]
			get
			{
				return this._ComboBoxVales;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBoxVales_SelectedIndexChanged);
				ComboBox comboBoxVales = this._ComboBoxVales;
				if (comboBoxVales != null)
				{
					comboBoxVales.SelectedIndexChanged -= value2;
				}
				this._ComboBoxVales = value;
				comboBoxVales = this._ComboBoxVales;
				if (comboBoxVales != null)
				{
					comboBoxVales.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x000CEB67 File Offset: 0x000CCD67
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x000CEB74 File Offset: 0x000CCD74
		internal virtual ComboBox ComboBoxEfectivo
		{
			[CompilerGenerated]
			get
			{
				return this._ComboBoxEfectivo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBoxEfectivo_SelectedIndexChanged);
				EventHandler value3 = new EventHandler(this.ComboBoxEfectivo_Click);
				EventHandler value4 = new EventHandler(this.ComboBoxEfectivo_SelectedValueChanged);
				ComboBox comboBoxEfectivo = this._ComboBoxEfectivo;
				if (comboBoxEfectivo != null)
				{
					comboBoxEfectivo.SelectedIndexChanged -= value2;
					comboBoxEfectivo.Click -= value3;
					comboBoxEfectivo.SelectedValueChanged -= value4;
				}
				this._ComboBoxEfectivo = value;
				comboBoxEfectivo = this._ComboBoxEfectivo;
				if (comboBoxEfectivo != null)
				{
					comboBoxEfectivo.SelectedIndexChanged += value2;
					comboBoxEfectivo.Click += value3;
					comboBoxEfectivo.SelectedValueChanged += value4;
				}
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x000CEBED File Offset: 0x000CCDED
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x000CEBF8 File Offset: 0x000CCDF8
		internal virtual ComboBox ComboBoxTarjeta
		{
			[CompilerGenerated]
			get
			{
				return this._ComboBoxTarjeta;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBoxTarjeta_SelectedValueChanged);
				ComboBox comboBoxTarjeta = this._ComboBoxTarjeta;
				if (comboBoxTarjeta != null)
				{
					comboBoxTarjeta.SelectedValueChanged -= value2;
				}
				this._ComboBoxTarjeta = value;
				comboBoxTarjeta = this._ComboBoxTarjeta;
				if (comboBoxTarjeta != null)
				{
					comboBoxTarjeta.SelectedValueChanged += value2;
				}
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x000CEC3B File Offset: 0x000CCE3B
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x000CEC45 File Offset: 0x000CCE45
		internal virtual BackgroundWorker BackgroundWorker2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x000CEC4E File Offset: 0x000CCE4E
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x000CEC58 File Offset: 0x000CCE58
		internal virtual Label lblidformapago { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x000CEC61 File Offset: 0x000CCE61
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x000CEC6C File Offset: 0x000CCE6C
		internal virtual PictureBox PictureOtros
		{
			[CompilerGenerated]
			get
			{
				return this._PictureOtros;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureOtros_Click);
				PictureBox pictureOtros = this._PictureOtros;
				if (pictureOtros != null)
				{
					pictureOtros.Click -= value2;
				}
				this._PictureOtros = value;
				pictureOtros = this._PictureOtros;
				if (pictureOtros != null)
				{
					pictureOtros.Click += value2;
				}
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x000CECAF File Offset: 0x000CCEAF
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x000CECBC File Offset: 0x000CCEBC
		internal virtual PictureBox PictureBoxVales
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBoxVales;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBoxVales_Click);
				PictureBox pictureBoxVales = this._PictureBoxVales;
				if (pictureBoxVales != null)
				{
					pictureBoxVales.Click -= value2;
				}
				this._PictureBoxVales = value;
				pictureBoxVales = this._PictureBoxVales;
				if (pictureBoxVales != null)
				{
					pictureBoxVales.Click += value2;
				}
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x000CECFF File Offset: 0x000CCEFF
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x000CED0C File Offset: 0x000CCF0C
		internal virtual PictureBox PictureBoxTarjeta
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBoxTarjeta;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBoxTarjeta_Click);
				PictureBox pictureBoxTarjeta = this._PictureBoxTarjeta;
				if (pictureBoxTarjeta != null)
				{
					pictureBoxTarjeta.Click -= value2;
				}
				this._PictureBoxTarjeta = value;
				pictureBoxTarjeta = this._PictureBoxTarjeta;
				if (pictureBoxTarjeta != null)
				{
					pictureBoxTarjeta.Click += value2;
				}
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x000CED4F File Offset: 0x000CCF4F
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x000CED5C File Offset: 0x000CCF5C
		internal virtual PictureBox PictureBoxEfectivo
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBoxEfectivo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBoxEfectivo_Click);
				PictureBox pictureBoxEfectivo = this._PictureBoxEfectivo;
				if (pictureBoxEfectivo != null)
				{
					pictureBoxEfectivo.Click -= value2;
				}
				this._PictureBoxEfectivo = value;
				pictureBoxEfectivo = this._PictureBoxEfectivo;
				if (pictureBoxEfectivo != null)
				{
					pictureBoxEfectivo.Click += value2;
				}
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x000CED9F File Offset: 0x000CCF9F
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x000CEDAC File Offset: 0x000CCFAC
		internal virtual PictureBox PictureBox2formas
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox2formas;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox2formas_Click);
				PictureBox pictureBox2formas = this._PictureBox2formas;
				if (pictureBox2formas != null)
				{
					pictureBox2formas.Click -= value2;
				}
				this._PictureBox2formas = value;
				pictureBox2formas = this._PictureBox2formas;
				if (pictureBox2formas != null)
				{
					pictureBox2formas.Click += value2;
				}
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x000CEDEF File Offset: 0x000CCFEF
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x000CEDF9 File Offset: 0x000CCFF9
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x000CEE02 File Offset: 0x000CD002
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x000CEE0C File Offset: 0x000CD00C
		internal virtual ComboBox ComboBox2Formas
		{
			[CompilerGenerated]
			get
			{
				return this._ComboBox2Formas;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBox2Formas_SelectedIndexChanged);
				ComboBox comboBox2Formas = this._ComboBox2Formas;
				if (comboBox2Formas != null)
				{
					comboBox2Formas.SelectedIndexChanged -= value2;
				}
				this._ComboBox2Formas = value;
				comboBox2Formas = this._ComboBox2Formas;
				if (comboBox2Formas != null)
				{
					comboBox2Formas.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x000CEE4F File Offset: 0x000CD04F
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x000CEE59 File Offset: 0x000CD059
		internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x000CEE62 File Offset: 0x000CD062
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x000CEE6C File Offset: 0x000CD06C
		internal virtual Label lblNoalmacenaInv { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x000CEE75 File Offset: 0x000CD075
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x000CEE7F File Offset: 0x000CD07F
		internal virtual Label lblAlmacenaInv { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x000CEE88 File Offset: 0x000CD088
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x000CEE94 File Offset: 0x000CD094
		internal virtual CheckBox CheckBoxInventarios
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxInventarios;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxInventarios_CheckedChanged);
				CheckBox checkBoxInventarios = this._CheckBoxInventarios;
				if (checkBoxInventarios != null)
				{
					checkBoxInventarios.CheckedChanged -= value2;
				}
				this._CheckBoxInventarios = value;
				checkBoxInventarios = this._CheckBoxInventarios;
				if (checkBoxInventarios != null)
				{
					checkBoxInventarios.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x000CEED7 File Offset: 0x000CD0D7
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x000CEEE1 File Offset: 0x000CD0E1
		internal virtual GroupBox GroupBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x000CEEEA File Offset: 0x000CD0EA
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x000CEEF4 File Offset: 0x000CD0F4
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

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x000CEF37 File Offset: 0x000CD137
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x000CEF44 File Offset: 0x000CD144
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

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x000CEF87 File Offset: 0x000CD187
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x000CEF94 File Offset: 0x000CD194
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

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x000CEFD7 File Offset: 0x000CD1D7
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x000CEFE4 File Offset: 0x000CD1E4
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

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x000CF027 File Offset: 0x000CD227
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x000CF031 File Offset: 0x000CD231
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x000CF03A File Offset: 0x000CD23A
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x000CF044 File Offset: 0x000CD244
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x000CF04D File Offset: 0x000CD24D
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x000CF057 File Offset: 0x000CD257
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x000CF060 File Offset: 0x000CD260
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x000CF06A File Offset: 0x000CD26A
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x000CF073 File Offset: 0x000CD273
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x000CF080 File Offset: 0x000CD280
		internal virtual ComboBox ComboBoxOtrosTicket
		{
			[CompilerGenerated]
			get
			{
				return this._ComboBoxOtrosTicket;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBoxOtrosTicket_SelectedIndexChanged);
				ComboBox comboBoxOtrosTicket = this._ComboBoxOtrosTicket;
				if (comboBoxOtrosTicket != null)
				{
					comboBoxOtrosTicket.SelectedIndexChanged -= value2;
				}
				this._ComboBoxOtrosTicket = value;
				comboBoxOtrosTicket = this._ComboBoxOtrosTicket;
				if (comboBoxOtrosTicket != null)
				{
					comboBoxOtrosTicket.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x000CF0C3 File Offset: 0x000CD2C3
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x000CF0D0 File Offset: 0x000CD2D0
		internal virtual ComboBox ComboBoxValesTicket
		{
			[CompilerGenerated]
			get
			{
				return this._ComboBoxValesTicket;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBoxValesTicket_SelectedIndexChanged);
				ComboBox comboBoxValesTicket = this._ComboBoxValesTicket;
				if (comboBoxValesTicket != null)
				{
					comboBoxValesTicket.SelectedIndexChanged -= value2;
				}
				this._ComboBoxValesTicket = value;
				comboBoxValesTicket = this._ComboBoxValesTicket;
				if (comboBoxValesTicket != null)
				{
					comboBoxValesTicket.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x000CF113 File Offset: 0x000CD313
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x000CF120 File Offset: 0x000CD320
		internal virtual ComboBox ComboBoxEfectivoTicket
		{
			[CompilerGenerated]
			get
			{
				return this._ComboBoxEfectivoTicket;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBoxEfectivoTicket_SelectedIndexChanged);
				ComboBox comboBoxEfectivoTicket = this._ComboBoxEfectivoTicket;
				if (comboBoxEfectivoTicket != null)
				{
					comboBoxEfectivoTicket.SelectedIndexChanged -= value2;
				}
				this._ComboBoxEfectivoTicket = value;
				comboBoxEfectivoTicket = this._ComboBoxEfectivoTicket;
				if (comboBoxEfectivoTicket != null)
				{
					comboBoxEfectivoTicket.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x000CF163 File Offset: 0x000CD363
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x000CF170 File Offset: 0x000CD370
		internal virtual ComboBox ComboBoxTarjetaTicket
		{
			[CompilerGenerated]
			get
			{
				return this._ComboBoxTarjetaTicket;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBoxTarjetaTicket_SelectedIndexChanged);
				ComboBox comboBoxTarjetaTicket = this._ComboBoxTarjetaTicket;
				if (comboBoxTarjetaTicket != null)
				{
					comboBoxTarjetaTicket.SelectedIndexChanged -= value2;
				}
				this._ComboBoxTarjetaTicket = value;
				comboBoxTarjetaTicket = this._ComboBoxTarjetaTicket;
				if (comboBoxTarjetaTicket != null)
				{
					comboBoxTarjetaTicket.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x000CF1B3 File Offset: 0x000CD3B3
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x000CF1BD File Offset: 0x000CD3BD
		internal virtual Label lblidOtros { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x000CF1C6 File Offset: 0x000CD3C6
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x000CF1D0 File Offset: 0x000CD3D0
		internal virtual Label lblidVales { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x000CF1D9 File Offset: 0x000CD3D9
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x000CF1E3 File Offset: 0x000CD3E3
		internal virtual Label lblidTarjeta { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x000CF1EC File Offset: 0x000CD3EC
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x000CF1F6 File Offset: 0x000CD3F6
		internal virtual Label lbldiEfectivo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x000CF1FF File Offset: 0x000CD3FF
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x000CF209 File Offset: 0x000CD409
		internal virtual GroupBox GroupBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x000CF212 File Offset: 0x000CD412
		// (set) Token: 0x06000CDA RID: 3290 RVA: 0x000CF21C File Offset: 0x000CD41C
		internal virtual CheckBox CheckBoxAleatorio
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxAleatorio;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxAleatorio_CheckedChanged);
				CheckBox checkBoxAleatorio = this._CheckBoxAleatorio;
				if (checkBoxAleatorio != null)
				{
					checkBoxAleatorio.CheckedChanged -= value2;
				}
				this._CheckBoxAleatorio = value;
				checkBoxAleatorio = this._CheckBoxAleatorio;
				if (checkBoxAleatorio != null)
				{
					checkBoxAleatorio.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x000CF25F File Offset: 0x000CD45F
		// (set) Token: 0x06000CDC RID: 3292 RVA: 0x000CF26C File Offset: 0x000CD46C
		internal virtual CheckBox CheckBoxContinuo
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxContinuo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxContinuo_CheckedChanged);
				CheckBox checkBoxContinuo = this._CheckBoxContinuo;
				if (checkBoxContinuo != null)
				{
					checkBoxContinuo.CheckedChanged -= value2;
				}
				this._CheckBoxContinuo = value;
				checkBoxContinuo = this._CheckBoxContinuo;
				if (checkBoxContinuo != null)
				{
					checkBoxContinuo.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x000CF2AF File Offset: 0x000CD4AF
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x000CF2BC File Offset: 0x000CD4BC
		internal virtual CheckBox CheckBox_SepararProductos
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox_SepararProductos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox_SepararProductos_CheckedChanged);
				CheckBox checkBox_SepararProductos = this._CheckBox_SepararProductos;
				if (checkBox_SepararProductos != null)
				{
					checkBox_SepararProductos.CheckedChanged -= value2;
				}
				this._CheckBox_SepararProductos = value;
				checkBox_SepararProductos = this._CheckBox_SepararProductos;
				if (checkBox_SepararProductos != null)
				{
					checkBox_SepararProductos.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x000CF300 File Offset: 0x000CD500
		private void frmParametros_Load(object sender, EventArgs e)
		{
			this.lblventasnoalmacenadas.Visible = false;
			this.lblAlmacenaVentasAcrivo.Visible = false;
			this.lblBitacoraActiva.Visible = false;
			this.lblBitacoraDesactivada.Visible = false;
			this.lblAlmacenaInv.Visible = false;
			this.lblNoalmacenaInv.Visible = false;
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery = new SqlQuery();
			string text = "Select g from H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					bool flag = Operators.CompareString(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()), "1", false) == 0;
					if (flag)
					{
						this.CheckBox1.Checked = true;
						this.lblventasnoalmacenadas.Visible = false;
						this.lblAlmacenaVentasAcrivo.Visible = true;
					}
					bool flag2 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()), "0", false) == 0;
					if (flag2)
					{
						this.CheckBox1.Checked = false;
						this.lblventasnoalmacenadas.Visible = true;
						this.lblAlmacenaVentasAcrivo.Visible = false;
					}
				}
				sqlDataReader.Close();
			}
			text = "Select h from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool hasRows2 = sqlDataReader.HasRows;
			if (hasRows2)
			{
				while (sqlDataReader.Read())
				{
					bool flag3 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()), "1", false) == 0;
					if (flag3)
					{
						this.CheckBox2.Checked = true;
						this.lblBitacoraActiva.Visible = true;
						this.lblBitacoraDesactivada.Visible = false;
					}
					bool flag4 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()), "0", false) == 0;
					if (flag4)
					{
						this.CheckBox2.Checked = false;
						this.lblBitacoraActiva.Visible = false;
						this.lblBitacoraDesactivada.Visible = true;
					}
				}
				sqlDataReader.Close();
			}
			text = "Select n from h";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool hasRows3 = sqlDataReader.HasRows;
			if (hasRows3)
			{
				while (sqlDataReader.Read())
				{
					bool flag5 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()), "1", false) == 0;
					if (flag5)
					{
						this.CheckBoxInventarios.Checked = true;
						this.lblAlmacenaInv.Visible = true;
						this.lblNoalmacenaInv.Visible = false;
					}
					bool flag6 = Operators.CompareString(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()), "0", false) == 0;
					if (flag6)
					{
						this.CheckBoxInventarios.Checked = false;
						this.lblAlmacenaInv.Visible = false;
						this.lblNoalmacenaInv.Visible = true;
					}
				}
				sqlDataReader.Close();
			}
			text = "SELECT o from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool flag7 = sqlDataReader.Read();
			if (flag7)
			{
				string text2 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				text = "select descripcion From formasdepago where  idformadepago= '" + text2.ToString() + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
				while (sqlDataReader.Read())
				{
					string text3 = Conversions.ToString(sqlDataReader[0]);
					this.ComboBoxEfectivoTicket.Text = text3;
				}
				sqlDataReader.Close();
			}
			text = "SELECT i from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool flag8 = sqlDataReader.Read();
			if (flag8)
			{
				string text4 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				text = "select descripcion from formasdepago where idformadepago='" + text4.ToString() + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
				while (sqlDataReader.Read())
				{
					string text5 = Conversions.ToString(sqlDataReader[0]);
					this.ComboBoxEfectivo.Text = text5;
				}
				sqlDataReader.Close();
			}
			text = "SELECT j from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool flag9 = sqlDataReader.Read();
			if (flag9)
			{
				string text6 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				text = "select descripcion from formasdepago where idformadepago= '" + text6.ToString() + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
				while (sqlDataReader.Read())
				{
					string text7 = Conversions.ToString(sqlDataReader[0]);
					this.ComboBoxTarjeta.Text = text7;
				}
				sqlDataReader.Close();
			}
			text = "SELECT p from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool flag10 = sqlDataReader.Read();
			if (flag10)
			{
				string text8 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				text = "select descripcion from formasdepago where  idformadepago='" + text8.ToString() + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
				while (sqlDataReader.Read())
				{
					string text9 = Conversions.ToString(sqlDataReader[0]);
					this.ComboBoxTarjetaTicket.Text = text9;
				}
				sqlDataReader.Close();
			}
			text = "SELECT k from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool flag11 = sqlDataReader.Read();
			if (flag11)
			{
				string text10 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				text = "select descripcion from formasdepago where  idformadepago= '" + text10.ToString() + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
				while (sqlDataReader.Read())
				{
					string text11 = Conversions.ToString(sqlDataReader[0]);
					this.ComboBoxVales.Text = text11;
				}
				sqlDataReader.Close();
			}
			text = "SELECT q from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool flag12 = sqlDataReader.Read();
			if (flag12)
			{
				string str = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				text = "select descripcion from formasdepago where  idformadepago= '" + str + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
				while (sqlDataReader.Read())
				{
					string text12 = Conversions.ToString(sqlDataReader[0]);
					this.ComboBoxValesTicket.Text = text12;
				}
				sqlDataReader.Close();
			}
			text = "SELECT l from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool flag13 = sqlDataReader.Read();
			if (flag13)
			{
				string text13 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				text = "select descripcion from  formasdepago where  idformadepago= '" + text13.ToString() + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
				while (sqlDataReader.Read())
				{
					string text14 = Conversions.ToString(sqlDataReader[0]);
					this.ComboBoxOtros.Text = text14;
				}
				sqlDataReader.Close();
			}
			text = "SELECT r from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool flag14 = sqlDataReader.Read();
			if (flag14)
			{
				string text15 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				text = "select descripcion from formasdepago where  idformadepago= '" + text15.ToString() + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
				while (sqlDataReader.Read())
				{
					string text16 = Conversions.ToString(sqlDataReader[0]);
					this.ComboBoxOtrosTicket.Text = text16;
				}
				sqlDataReader.Close();
			}
			text = "SELECT m from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool flag15 = sqlDataReader.Read();
			if (flag15)
			{
				string text17 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
				text = "select descripcion from  formasdepago where  idformadepago  = '" + text17.ToString() + "'";
				sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
				while (sqlDataReader.Read())
				{
					string text18 = Conversions.ToString(sqlDataReader[0]);
					this.ComboBox2Formas.Text = text18;
				}
				sqlDataReader.Close();
			}
			text = "SELECT ac from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool hasRows4 = sqlDataReader.HasRows;
			if (hasRows4)
			{
				while (sqlDataReader.Read())
				{
					string left = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					bool flag16 = Operators.CompareString(left, "1", false) == 0;
					if (flag16)
					{
						this.CheckBoxAleatorio.Checked = true;
					}
					else
					{
						this.CheckBoxContinuo.Checked = true;
					}
				}
			}
			text = "SELECT an from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(text);
			bool hasRows5 = sqlDataReader.HasRows;
			if (hasRows5)
			{
				while (sqlDataReader.Read())
				{
					string left2 = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					bool flag17 = Operators.CompareString(left2, "1", false) == 0;
					if (flag17)
					{
						this.CheckBox_SepararProductos.Checked = true;
					}
					bool flag18 = Operators.CompareString(left2, "0", false) == 0;
					if (flag18)
					{
						this.CheckBox_SepararProductos.Checked = false;
					}
				}
			}
			this.ComboBoxEfectivo.Enabled = false;
			this.ComboBoxTarjeta.Enabled = false;
			this.ComboBoxVales.Enabled = false;
			this.ComboBoxOtros.Enabled = false;
			this.ComboBox2Formas.Enabled = false;
			this.ComboBoxEfectivoTicket.Enabled = false;
			this.ComboBoxTarjetaTicket.Enabled = false;
			this.ComboBoxOtrosTicket.Enabled = false;
			this.ComboBoxValesTicket.Enabled = false;
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x000CFCA0 File Offset: 0x000CDEA0
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			base.Close();
			MyProject.Forms.main.Parametros.BackColor = SystemColors.InactiveCaption;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x000CFCC4 File Offset: 0x000CDEC4
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = "1";
			string text2 = "0";
			bool @checked = this.CheckBox1.Checked;
			if (@checked)
			{
				string query_conn = "Update H set g='" + Tools.Encriptar(text.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.lblventasnoalmacenadas.Visible = false;
				this.lblAlmacenaVentasAcrivo.Visible = true;
			}
			bool flag = !this.CheckBox1.Checked;
			if (flag)
			{
				string query_conn = "Update H set g='" + Tools.Encriptar(text2.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.lblventasnoalmacenadas.Visible = true;
				this.lblAlmacenaVentasAcrivo.Visible = false;
			}
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x000CFD94 File Offset: 0x000CDF94
		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = "1";
			string text2 = "0";
			bool @checked = this.CheckBox2.Checked;
			if (@checked)
			{
				string query_conn = "Update H set h='" + Tools.Encriptar(text.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.lblBitacoraActiva.Visible = true;
				this.lblBitacoraDesactivada.Visible = false;
			}
			bool flag = !this.CheckBox2.Checked;
			if (flag)
			{
				string query_conn = "Update h set H='" + Tools.Encriptar(text2.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.lblBitacoraActiva.Visible = false;
				this.lblBitacoraDesactivada.Visible = true;
			}
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x000CFE64 File Offset: 0x000CE064
		public void llenarcomboboxefectivo()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select descripcion from formasdepago";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			while (sqlDataReader.Read())
			{
				this.idDescripcionformapagodescripcion = Conversions.ToString(sqlDataReader[0]);
				this.ComboBoxEfectivo.Items.Add(this.idDescripcionformapagodescripcion);
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000CFEC8 File Offset: 0x000CE0C8
		public void llenarcomboboxeTarjeta()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select descripcion from formasdepago";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			while (sqlDataReader.Read())
			{
				this.idDescripcionformapagodescripcion = Conversions.ToString(sqlDataReader[0]);
				this.ComboBoxTarjeta.Items.Add(this.idDescripcionformapagodescripcion);
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x000CFF2C File Offset: 0x000CE12C
		public void llenarcomboboxVales()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select descripcion from formasdepago";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			while (sqlDataReader.Read())
			{
				this.idDescripcionformapagodescripcion = Conversions.ToString(sqlDataReader[0]);
				this.ComboBoxVales.Items.Add(this.idDescripcionformapagodescripcion);
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x000CFF90 File Offset: 0x000CE190
		public void llenarcomboboxOtros()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select descripcion from formasdepago";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			while (sqlDataReader.Read())
			{
				this.idDescripcionformapagodescripcion = Conversions.ToString(sqlDataReader[0]);
				this.ComboBoxOtros.Items.Add(this.idDescripcionformapagodescripcion);
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x000CFFF4 File Offset: 0x000CE1F4
		public void llenarcombobo2FormasPago()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select descripcion from formasdepago";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			while (sqlDataReader.Read())
			{
				this.idDescripcionformapagodescripcion = Conversions.ToString(sqlDataReader[0]);
				this.ComboBox2Formas.Items.Add(this.idDescripcionformapagodescripcion);
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x000D0058 File Offset: 0x000CE258
		private void ComboBoxTarjeta_SelectedValueChanged(object sender, EventArgs e)
		{
			SqlQuery sqlQuery = new SqlQuery();
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = Conversions.ToString(Operators.AddObject(Operators.AddObject("select idformadepago from formasdepago where descripcion = '", this.ComboBoxTarjeta.SelectedItem), "'"));
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
			while (sqlDataReader.Read())
			{
				this.idformadepago = Conversions.ToString(sqlDataReader[0]);
				this.lblidformapago.Text = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			text = "Update H Set j = '" + Tools.Encriptar(this.idformadepago.ToString().Trim()) + "'";
			sqlQuery_Conn.execQuery_conn(text);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x000D0114 File Offset: 0x000CE314
		private void ComboBoxEfectivo_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery = new SqlQuery();
			string text = Conversions.ToString(Operators.AddObject(Operators.AddObject("select idformadepago from formasdepago where descripcion = '", this.ComboBoxEfectivo.SelectedItem), "'"));
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
			while (sqlDataReader.Read())
			{
				this.idformadepago = Conversions.ToString(sqlDataReader[0]);
				this.lblidformapago.Text = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			text = "Update H Set i = '" + Tools.Encriptar(this.idformadepago.ToString().Trim()) + "'";
			sqlQuery_Conn.execQuery_conn(text);
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x000D01D0 File Offset: 0x000CE3D0
		private void ComboBoxVales_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery = new SqlQuery();
			string text = Conversions.ToString(Operators.AddObject(Operators.AddObject("select idformadepago from formasdepago where descripcion = '", this.ComboBoxVales.SelectedItem), "'"));
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
			while (sqlDataReader.Read())
			{
				this.idformadepago = Conversions.ToString(sqlDataReader[0]);
				this.lblidformapago.Text = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			text = "Update H Set k = '" + Tools.Encriptar(this.idformadepago.ToString().Trim()) + "'";
			sqlQuery_Conn.execQuery_conn(text);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x000D028C File Offset: 0x000CE48C
		private void ComboBoxOtros_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery = new SqlQuery();
			string text = Conversions.ToString(Operators.AddObject(Operators.AddObject("select idformadepago from formasdepago where descripcion = '", this.ComboBoxOtros.SelectedItem), "'"));
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
			while (sqlDataReader.Read())
			{
				this.idformadepago = Conversions.ToString(sqlDataReader[0]);
				this.lblidformapago.Text = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			text = "Update H Set l = '" + Tools.Encriptar(this.idformadepago.ToString().Trim()) + "'";
			sqlQuery_Conn.execQuery_conn(text);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000036D5 File Offset: 0x000018D5
		private void ComboBoxEfectivo_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x000036D5 File Offset: 0x000018D5
		private void ComboBoxEfectivo_SelectedValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x000D0345 File Offset: 0x000CE545
		private void PictureBoxEfectivo_Click(object sender, EventArgs e)
		{
			this.llenarcomboboxefectivo();
			this.PictureBoxEfectivo.Enabled = false;
			this.ComboBoxEfectivo.Enabled = true;
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x000D0369 File Offset: 0x000CE569
		private void PictureBoxTarjeta_Click(object sender, EventArgs e)
		{
			this.llenarcomboboxeTarjeta();
			this.PictureBoxTarjeta.Enabled = false;
			this.ComboBoxTarjeta.Enabled = true;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x000D038D File Offset: 0x000CE58D
		private void PictureBoxVales_Click(object sender, EventArgs e)
		{
			this.llenarcomboboxVales();
			this.PictureBoxVales.Enabled = false;
			this.ComboBoxVales.Enabled = true;
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x000D03B1 File Offset: 0x000CE5B1
		private void PictureOtros_Click(object sender, EventArgs e)
		{
			this.llenarcomboboxOtros();
			this.PictureOtros.Enabled = false;
			this.ComboBoxOtros.Enabled = true;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x000D03D5 File Offset: 0x000CE5D5
		private void PictureBox2formas_Click(object sender, EventArgs e)
		{
			this.llenarcombobo2FormasPago();
			this.PictureBox2formas.Enabled = false;
			this.ComboBox2Formas.Enabled = true;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x000D03FC File Offset: 0x000CE5FC
		private void ComboBox2Formas_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery = new SqlQuery();
			string text = Conversions.ToString(Operators.AddObject(Operators.AddObject("select idformadepago from formasdepago where descripcion = '", this.ComboBox2Formas.SelectedItem), "'"));
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
			while (sqlDataReader.Read())
			{
				this.idformadepago = Conversions.ToString(sqlDataReader[0]);
				this.lblidformapago.Text = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			text = "Update h Set m = '" + Tools.Encriptar(this.idformadepago.ToString().Trim()) + "'";
			sqlQuery_Conn.execQuery_conn(text);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x000D04B8 File Offset: 0x000CE6B8
		private void CheckBoxInventarios_CheckedChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = "1";
			string text2 = "0";
			bool @checked = this.CheckBoxInventarios.Checked;
			if (@checked)
			{
				string query_conn = "Update H set n='" + Tools.Encriptar(text.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.lblAlmacenaInv.Visible = true;
				this.lblNoalmacenaInv.Visible = false;
			}
			bool flag = !this.CheckBoxInventarios.Checked;
			if (flag)
			{
				string query_conn = "Update h set n='" + Tools.Encriptar(text2.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.lblAlmacenaInv.Visible = false;
				this.lblNoalmacenaInv.Visible = true;
			}
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x000D0588 File Offset: 0x000CE788
		public void llenarcomboboxefectivo1()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select idformadepago , descripcion from formasdepago where tipo=1";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			while (sqlDataReader.Read())
			{
				string text = Conversions.ToString(sqlDataReader[0]);
				string item = Conversions.ToString(sqlDataReader[1]);
				this.ComboBoxEfectivoTicket.Items.Add(item);
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x000D05F4 File Offset: 0x000CE7F4
		public void llenarcomboboxTarjeta1()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select idformadepago , descripcion from formasdepago where tipo=2";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			while (sqlDataReader.Read())
			{
				string text = Conversions.ToString(sqlDataReader[0]);
				string item = Conversions.ToString(sqlDataReader[1]);
				this.ComboBoxTarjetaTicket.Items.Add(item);
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x000D0660 File Offset: 0x000CE860
		public void llenarcomboboxVales1()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select idformadepago , descripcion from formasdepago where tipo=3";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			while (sqlDataReader.Read())
			{
				string text = Conversions.ToString(sqlDataReader[0]);
				string item = Conversions.ToString(sqlDataReader[1]);
				this.ComboBoxValesTicket.Items.Add(item);
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x000D06CC File Offset: 0x000CE8CC
		public void llenarcomboboxOtros1()
		{
			SqlQuery sqlQuery = new SqlQuery();
			string query = "select idformadepago , descripcion from formasdepago where tipo=4";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(query);
			while (sqlDataReader.Read())
			{
				string text = Conversions.ToString(sqlDataReader[0]);
				string item = Conversions.ToString(sqlDataReader[1]);
				this.ComboBoxOtrosTicket.Items.Add(item);
			}
			sqlDataReader.Close();
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x000D0737 File Offset: 0x000CE937
		private void PictureBox6_Click(object sender, EventArgs e)
		{
			this.ComboBoxEfectivoTicket.Enabled = true;
			this.PictureBox6.Enabled = false;
			this.llenarcomboboxefectivo1();
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x000D075B File Offset: 0x000CE95B
		private void PictureBox5_Click(object sender, EventArgs e)
		{
			this.PictureBox5.Enabled = false;
			this.ComboBoxTarjetaTicket.Enabled = true;
			this.llenarcomboboxTarjeta1();
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x000D077F File Offset: 0x000CE97F
		private void PictureBox4_Click(object sender, EventArgs e)
		{
			this.PictureBox4.Enabled = false;
			this.ComboBoxValesTicket.Enabled = true;
			this.llenarcomboboxVales1();
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x000D07A3 File Offset: 0x000CE9A3
		private void PictureBox3_Click(object sender, EventArgs e)
		{
			this.PictureBox3.Enabled = false;
			this.ComboBoxOtrosTicket.Enabled = true;
			this.llenarcomboboxOtros1();
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x000D07C8 File Offset: 0x000CE9C8
		private void ComboBoxEfectivoTicket_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery = new SqlQuery();
			string text = Conversions.ToString(Operators.AddObject(Operators.AddObject("select idformadepago from formasdepago where descripcion = '", this.ComboBoxEfectivoTicket.SelectedItem), "'"));
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
			while (sqlDataReader.Read())
			{
				string text2 = Conversions.ToString(sqlDataReader[0]);
				this.lbldiEfectivo.Text = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			text = "Update H Set O = '" + Tools.Encriptar(this.lbldiEfectivo.Text.Trim()) + "'";
			sqlQuery_Conn.execQuery_conn(text);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x000D0880 File Offset: 0x000CEA80
		private void ComboBoxTarjetaTicket_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery = new SqlQuery();
			string text = Conversions.ToString(Operators.AddObject(Operators.AddObject("select idformadepago from formasdepago where descripcion = '", this.ComboBoxTarjetaTicket.SelectedItem), "'"));
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
			while (sqlDataReader.Read())
			{
				string text2 = Conversions.ToString(sqlDataReader[0]);
				this.lblidTarjeta.Text = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			text = "Update H Set p = '" + Tools.Encriptar(this.lblidTarjeta.Text.Trim()) + "'";
			sqlQuery_Conn.execQuery_conn(text);
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x000D0938 File Offset: 0x000CEB38
		private void ComboBoxValesTicket_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery = new SqlQuery();
			string text = Conversions.ToString(Operators.AddObject(Operators.AddObject("select idformadepago from formasdepago where descripcion = '", this.ComboBoxValesTicket.SelectedItem), "'"));
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
			while (sqlDataReader.Read())
			{
				string text2 = Conversions.ToString(sqlDataReader[0]);
				this.lblidVales.Text = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			text = "Update H Set q = '" + Tools.Encriptar(this.lblidVales.Text.Trim()) + "'";
			sqlQuery_Conn.execQuery_conn(text);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x000D09F0 File Offset: 0x000CEBF0
		private void ComboBoxOtrosTicket_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			SqlQuery sqlQuery = new SqlQuery();
			string text = Conversions.ToString(Operators.AddObject(Operators.AddObject("select idformadepago from formasdepago where descripcion = '", this.ComboBoxOtrosTicket.SelectedItem), "'"));
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery.execReader(text);
			while (sqlDataReader.Read())
			{
				string text2 = Conversions.ToString(sqlDataReader[0]);
				this.lblidOtros.Text = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			text = "Update H Set r = '" + Tools.Encriptar(this.lblidOtros.Text.Trim()) + "'";
			sqlQuery_Conn.execQuery_conn(text);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x000D0AA8 File Offset: 0x000CECA8
		private void CheckBoxContinuo_CheckedChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = "1";
			string text2 = "0";
			bool @checked = this.CheckBoxContinuo.Checked;
			if (@checked)
			{
				string query_conn = "Update H set ac='" + Tools.Encriptar(text2.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.CheckBoxAleatorio.Checked = false;
				this.CheckBoxContinuo.Checked = true;
			}
			else
			{
				string query_conn = "Update H set ac='" + Tools.Encriptar(text.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.CheckBoxContinuo.Checked = false;
				this.CheckBoxAleatorio.Checked = true;
			}
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x000D0B64 File Offset: 0x000CED64
		private void CheckBoxAleatorio_CheckedChanged(object sender, EventArgs e)
		{
			string text = "1";
			string text2 = "0";
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			bool @checked = this.CheckBoxAleatorio.Checked;
			if (@checked)
			{
				string query_conn = "Update h set ac='" + Tools.Encriptar(text.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.CheckBoxContinuo.Checked = false;
				this.CheckBoxAleatorio.Checked = true;
			}
			else
			{
				string query_conn = "Update h set ac='" + Tools.Encriptar(text2.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.CheckBoxAleatorio.Checked = false;
				this.CheckBoxContinuo.Checked = true;
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x000D0C20 File Offset: 0x000CEE20
		private void CheckBox_SepararProductos_CheckedChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = "1";
			string text2 = "0";
			bool @checked = this.CheckBox_SepararProductos.Checked;
			if (@checked)
			{
				string query_conn = "Update H set an='" + Tools.Encriptar(text.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.CheckBox_SepararProductos.Checked = true;
			}
			else
			{
				string query_conn = "Update H set an='" + Tools.Encriptar(text2.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.CheckBox_SepararProductos.Checked = false;
			}
		}

		// Token: 0x040005E4 RID: 1508
		private string idformadepago;

		// Token: 0x040005E5 RID: 1509
		private string idDescripcionformapagodescripcion;
	}
}
