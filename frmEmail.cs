using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ModuloAdicional.My;

namespace ModuloAdicional
{
	// Token: 0x02000016 RID: 22
	[DesignerGenerated]
	public partial class frmEmail : Form
	{
		// Token: 0x06000818 RID: 2072 RVA: 0x00097CB6 File Offset: 0x00095EB6
		public frmEmail()
		{
			base.Load += this.frmEmail_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x000990EE File Offset: 0x000972EE
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x000990F8 File Offset: 0x000972F8
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x00099101 File Offset: 0x00097301
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x0009910B File Offset: 0x0009730B
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00099114 File Offset: 0x00097314
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x0009911E File Offset: 0x0009731E
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00099127 File Offset: 0x00097327
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00099131 File Offset: 0x00097331
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x0009913A File Offset: 0x0009733A
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x00099144 File Offset: 0x00097344
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x0009914D File Offset: 0x0009734D
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x00099157 File Offset: 0x00097357
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00099160 File Offset: 0x00097360
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x0009916A File Offset: 0x0009736A
		internal virtual CheckBox CheckBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00099173 File Offset: 0x00097373
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x0009917D File Offset: 0x0009737D
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00099186 File Offset: 0x00097386
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00099190 File Offset: 0x00097390
		internal virtual TextBox txtWebmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00099199 File Offset: 0x00097399
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x000991A3 File Offset: 0x000973A3
		internal virtual TextBox txtPuerto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x000991AC File Offset: 0x000973AC
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x000991B6 File Offset: 0x000973B6
		internal virtual TextBox txtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x000991BF File Offset: 0x000973BF
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x000991CC File Offset: 0x000973CC
		internal virtual TextBox txtPassword
		{
			[CompilerGenerated]
			get
			{
				return this._txtPassword;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtPassword_TextChanged);
				EventHandler value3 = new EventHandler(this.txtPassword_Click);
				TextBox txtPassword = this._txtPassword;
				if (txtPassword != null)
				{
					txtPassword.TextChanged -= value2;
					txtPassword.Click -= value3;
				}
				this._txtPassword = value;
				txtPassword = this._txtPassword;
				if (txtPassword != null)
				{
					txtPassword.TextChanged += value2;
					txtPassword.Click += value3;
				}
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x0009922A File Offset: 0x0009742A
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x00099234 File Offset: 0x00097434
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

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x00099277 File Offset: 0x00097477
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x00099284 File Offset: 0x00097484
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

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x000992C7 File Offset: 0x000974C7
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x000992D1 File Offset: 0x000974D1
		internal virtual TextBox txtDestinatario { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x000992DA File Offset: 0x000974DA
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x000992E4 File Offset: 0x000974E4
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x000992ED File Offset: 0x000974ED
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x000992F8 File Offset: 0x000974F8
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

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0009933B File Offset: 0x0009753B
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00099345 File Offset: 0x00097545
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0009934E File Offset: 0x0009754E
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00099358 File Offset: 0x00097558
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

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0009939B File Offset: 0x0009759B
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x000993A8 File Offset: 0x000975A8
		internal virtual CheckBox CheckBox3
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox3_CheckedChanged);
				CheckBox checkBox = this._CheckBox3;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._CheckBox3 = value;
				checkBox = this._CheckBox3;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x000993EB File Offset: 0x000975EB
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x000993F5 File Offset: 0x000975F5
		internal virtual Label lblServidor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x000993FE File Offset: 0x000975FE
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x00099408 File Offset: 0x00097608
		internal virtual Label lblPuerto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x00099411 File Offset: 0x00097611
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x0009941B File Offset: 0x0009761B
		internal virtual Label lblemailenvio { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00099424 File Offset: 0x00097624
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x0009942E File Offset: 0x0009762E
		internal virtual Label lblpwd { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00099437 File Offset: 0x00097637
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x00099444 File Offset: 0x00097644
		internal virtual CheckBox CheckBox4
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox4_CheckedChanged);
				CheckBox checkBox = this._CheckBox4;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._CheckBox4 = value;
				checkBox = this._CheckBox4;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00099487 File Offset: 0x00097687
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x00099494 File Offset: 0x00097694
		internal virtual CheckBox CheckBoxActivar
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxActivar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxActivar_CheckedChanged);
				CheckBox checkBoxActivar = this._CheckBoxActivar;
				if (checkBoxActivar != null)
				{
					checkBoxActivar.CheckedChanged -= value2;
				}
				this._CheckBoxActivar = value;
				checkBoxActivar = this._CheckBoxActivar;
				if (checkBoxActivar != null)
				{
					checkBoxActivar.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x000994D7 File Offset: 0x000976D7
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x000994E1 File Offset: 0x000976E1
		internal virtual Label lblEncrpPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x000994EA File Offset: 0x000976EA
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x000994F4 File Offset: 0x000976F4
		internal virtual Label lblDesencriptarpwd { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000853 RID: 2131 RVA: 0x000994FD File Offset: 0x000976FD
		private void Button2_Click(object sender, EventArgs e)
		{
			this.lblEncrpPassword.Text = Tools.Encriptar(this.txtPassword.Text.Trim());
			this.EnvioMail();
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00099528 File Offset: 0x00097728
		public void EnvioMail()
		{
			MailMessage mailMessage = new MailMessage();
			SmtpClient smtpClient = new SmtpClient();
			bool flag = Operators.CompareString(this.txtWebmail.Text, "", false) == 0;
			if (flag)
			{
				Interaction.MsgBox("Ingresa el nombre del servidor!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				bool flag2 = Operators.CompareString(this.txtPuerto.Text, "", false) == 0;
				if (flag2)
				{
					Interaction.MsgBox("Ingresa el puerto del servidor!", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					bool flag3 = Operators.CompareString(this.txtEmail.Text, "", false) == 0;
					if (flag3)
					{
						Interaction.MsgBox("Ingresa el correo electronico!", MsgBoxStyle.OkOnly, null);
					}
					else
					{
						bool flag4 = Operators.CompareString(this.txtDestinatario.Text, "", false) == 0;
						if (flag4)
						{
							Interaction.MsgBox("Ingresa el destinatario!", MsgBoxStyle.OkOnly, null);
						}
						else
						{
							mailMessage.From = new MailAddress(this.txtEmail.Text, "Modulo de Proyeccion", Encoding.UTF8);
							mailMessage.To.Add(this.txtDestinatario.Text);
							mailMessage.SubjectEncoding = Encoding.UTF8;
							mailMessage.Subject = "Evento Realizado";
							mailMessage.Body = "Este es un correo de prueba enviado para recibir las Alertas Automaticas";
							mailMessage.BodyEncoding = Encoding.UTF8;
							mailMessage.IsBodyHtml = true;
							mailMessage.Priority = MailPriority.High;
							smtpClient.Credentials = new NetworkCredential(this.txtEmail.Text, this.txtPassword.Text);
							smtpClient.Port = Conversions.ToInteger(this.txtPuerto.Text);
							smtpClient.Host = this.txtWebmail.Text;
							smtpClient.EnableSsl = true;
							try
							{
								smtpClient.Send(mailMessage);
								this.Button1.Enabled = true;
								Interaction.MsgBox("Correo de prueba enviado correctamente, verifica tu Bandeja de Entrada!", MsgBoxStyle.OkOnly, null);
								this.txtDestinatario.Enabled = false;
								this.txtEmail.Enabled = false;
								this.txtPassword.Enabled = false;
								this.txtPuerto.Enabled = false;
								this.txtWebmail.Enabled = false;
								this.Button2.Enabled = false;
							}
							catch (Exception ex)
							{
								Interaction.MsgBox("No pudimos conectarnos con tu servidor,revisa la configuracion.", MsgBoxStyle.OkOnly, null);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00099774 File Offset: 0x00097974
		private void Button1_Click(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string query_conn = string.Concat(new string[]
			{
				"Update H set u='",
				Tools.Encriptar(this.txtWebmail.Text.Trim()),
				"' , v = '",
				Tools.Encriptar(this.txtPuerto.Text.Trim()),
				"', w = '",
				Tools.Encriptar(this.txtEmail.Text.Trim()),
				"', y =  '",
				this.lblEncrpPassword.Text,
				"', z='",
				Tools.Encriptar(this.txtDestinatario.Text.Trim()),
				"'"
			});
			sqlQuery_Conn.execQuery_conn(query_conn);
			Interaction.MsgBox("Correo Almacenado para recibir las Alertas Automaticas!", MsgBoxStyle.OkOnly, null);
			base.Close();
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00099854 File Offset: 0x00097A54
		private void frmEmail_Load(object sender, EventArgs e)
		{
			this.txtDestinatario.Enabled = true;
			this.txtEmail.Enabled = true;
			this.txtPassword.Enabled = true;
			this.txtPuerto.Enabled = true;
			this.txtWebmail.Enabled = true;
			this.Button1.Enabled = false;
			this.CheckBox4.Enabled = false;
			this.txtDestinatario.Clear();
			this.txtEmail.Clear();
			this.txtPassword.Clear();
			this.txtPuerto.Clear();
			this.txtWebmail.Clear();
			this.Button1.Enabled = false;
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			this.txtWebmail.Text = this.lblServidor.Text;
			this.txtPuerto.Text = this.lblPuerto.Text;
			this.txtEmail.Text = this.lblemailenvio.Text;
			this.txtPassword.Text = this.lblpwd.Text;
			string query_conn = "Select ab from H";
			SqlDataReader sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows = sqlDataReader.HasRows;
			if (hasRows)
			{
				while (sqlDataReader.Read())
				{
					string left = Tools.Desencriptar(sqlDataReader[0].ToString().Trim());
					bool flag = Operators.CompareString(left, "1", false) == 0;
					if (flag)
					{
						this.CheckBoxActivar.Checked = true;
						this.CheckBoxActivar.ForeColor = Color.Green;
					}
					bool flag2 = Operators.CompareString(left, "0", false) == 0;
					if (flag2)
					{
						this.CheckBoxActivar.Checked = false;
						this.CheckBoxActivar.ForeColor = Color.Red;
					}
				}
			}
			query_conn = "SELECT u,v,w,y,z from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows2 = sqlDataReader.HasRows;
			if (hasRows2)
			{
				while (sqlDataReader.Read())
				{
					bool flag3 = Operators.ConditionalCompareObjectEqual(sqlDataReader[0], "", false);
					string text;
					if (flag3)
					{
						text = Tools.Encriptar(this.lblServidor.Text.Trim());
					}
					else
					{
						text = Conversions.ToString(sqlDataReader[0]);
					}
					bool flag4 = Operators.ConditionalCompareObjectEqual(sqlDataReader[1], "", false);
					string text2;
					if (flag4)
					{
						text2 = Tools.Encriptar(this.lblPuerto.Text.Trim());
					}
					else
					{
						text2 = Conversions.ToString(sqlDataReader[1]);
					}
					bool flag5 = Operators.ConditionalCompareObjectEqual(sqlDataReader[2], "", false);
					string text3;
					if (flag5)
					{
						text3 = Tools.Encriptar(this.lblemailenvio.Text.Trim());
					}
					else
					{
						text3 = Conversions.ToString(sqlDataReader[2]);
					}
					bool flag6 = Operators.ConditionalCompareObjectEqual(sqlDataReader[3], "", false);
					string text4;
					if (flag6)
					{
						text4 = Tools.Encriptar(this.lblpwd.Text.Trim());
					}
					else
					{
						text4 = Conversions.ToString(sqlDataReader[3]);
					}
					bool flag7 = Operators.ConditionalCompareObjectEqual(sqlDataReader[4], "", false);
					string text5;
					if (flag7)
					{
						text5 = Tools.Encriptar(this.lblemailenvio.Text.Trim());
					}
					else
					{
						text5 = Conversions.ToString(sqlDataReader[4]);
					}
					this.txtWebmail.Text = Tools.Desencriptar(text.ToString().Trim());
					this.txtPuerto.Text = Tools.Desencriptar(text2.ToString().Trim());
					this.txtEmail.Text = Tools.Desencriptar(text3.ToString().Trim());
					this.txtPassword.Text = Tools.Desencriptar(text4.ToString().Trim());
					this.txtDestinatario.Text = Tools.Desencriptar(text5.ToString().Trim());
					this.lblDesencriptarpwd.Text = this.txtPassword.Text;
				}
			}
			sqlDataReader.Close();
			query_conn = "Select aa from H";
			sqlDataReader = (SqlDataReader)sqlQuery_Conn.execReader_conn(query_conn);
			bool hasRows3 = sqlDataReader.HasRows;
			if (hasRows3)
			{
				while (sqlDataReader.Read())
				{
					int num = Conversions.ToInteger(Tools.Desencriptar(sqlDataReader[0].ToString().Trim()));
					bool flag8 = (double)num == Conversions.ToDouble("0");
					if (flag8)
					{
						this.CheckBox3.Checked = false;
					}
					bool flag9 = (double)num == Conversions.ToDouble("1");
					if (flag9)
					{
						this.CheckBox3.Checked = true;
					}
				}
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00099CDF File Offset: 0x00097EDF
		private void PictureBox3_Click(object sender, EventArgs e)
		{
			base.Close();
			MyProject.Forms.main.btnEmail.BackColor = SystemColors.InactiveCaption;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000036D5 File Offset: 0x000018D5
		private void txtPassword_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00099D03 File Offset: 0x00097F03
		private void txtPassword_Click(object sender, EventArgs e)
		{
			this.txtPassword.SelectAll();
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00099D14 File Offset: 0x00097F14
		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox2.Checked;
			if (@checked)
			{
				this.txtPassword.Enabled = true;
			}
			bool flag = !this.CheckBox2.Checked;
			if (flag)
			{
				this.txtPassword.Enabled = false;
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00099D64 File Offset: 0x00097F64
		private void CheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = "0";
			string text2 = "1";
			bool flag = !this.CheckBox3.Checked;
			if (flag)
			{
				string query_conn = "Update H set aa='" + Tools.Encriptar(text.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.CheckBox4.Enabled = true;
				this.txtDestinatario.Clear();
				this.txtEmail.Clear();
				this.txtPassword.Clear();
				this.txtPuerto.Clear();
				this.txtWebmail.Clear();
				this.txtWebmail.Enabled = true;
				this.txtPuerto.Enabled = true;
				this.txtEmail.Enabled = true;
				this.txtPassword.Enabled = true;
			}
			bool @checked = this.CheckBox3.Checked;
			if (@checked)
			{
				string query_conn = "Update H set aa='" + Tools.Encriptar(text2.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.txtWebmail.Text = this.lblServidor.Text;
				this.txtPuerto.Text = this.lblPuerto.Text;
				this.txtEmail.Text = this.lblemailenvio.Text;
				this.txtPassword.Text = this.lblpwd.Text;
				this.txtDestinatario.Text = this.lblemailenvio.Text;
				this.CheckBox4.Enabled = false;
				this.txtWebmail.Enabled = false;
				this.txtPuerto.Enabled = false;
				this.txtEmail.Enabled = false;
				this.txtPassword.Enabled = false;
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00099F34 File Offset: 0x00098134
		private void CheckBox4_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox4.Checked;
			if (@checked)
			{
				this.txtPassword.UseSystemPasswordChar = false;
			}
			else
			{
				this.txtPassword.UseSystemPasswordChar = true;
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00099F70 File Offset: 0x00098170
		private void CheckBoxActivar_CheckedChanged(object sender, EventArgs e)
		{
			SqlQuery_Conn sqlQuery_Conn = new SqlQuery_Conn();
			string text = "0";
			string text2 = "1";
			bool @checked = this.CheckBoxActivar.Checked;
			if (@checked)
			{
				string query_conn = "Update H set ab='" + Tools.Encriptar(text2.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.CheckBoxActivar.ForeColor = Color.Green;
			}
			bool flag = !this.CheckBoxActivar.Checked;
			if (flag)
			{
				string query_conn = "Update H set ab='" + Tools.Encriptar(text.ToString().Trim()) + "'";
				sqlQuery_Conn.execQuery_conn(query_conn);
				this.CheckBoxActivar.ForeColor = Color.Red;
			}
		}
	}
}
