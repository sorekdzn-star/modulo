using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ModuloAdicional
{
	// Token: 0x02000006 RID: 6
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00004288 File Offset: 0x00002488
		public Form1()
		{
			base.Load += this.Form1_Load;
			this.sc = new SplitContainer();
			this.b1 = new Button();
			this.b2 = new Button();
			this.DGV = new DataGridView();
			this.tb1 = new TextBox();
			this.matchColour = Color.Red;
			this.unmatchColour = Color.White;
			this.table = new DataTable();
			this.view = new DataView(this.table);
			this.InitializeComponent();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000043DC File Offset: 0x000025DC
		private void Form1_Load(object sender, EventArgs e)
		{
			this.sc.Dock = DockStyle.Fill;
			this.sc.Orientation = Orientation.Horizontal;
			this.sc.SplitterDistance = 210;
			this.sc.FixedPanel = FixedPanel.Panel2;
			this.sc.IsSplitterFixed = true;
			base.Controls.Add(this.sc);
			this.tb1.Location = new Point(20, 0);
			checked
			{
				this.b1.Location = new Point(this.tb1.Right + 10, this.tb1.Top);
				this.tb1.Font = new Font("Ariel", 12f);
				this.tb1.BackColor = Color.LightGray;
				this.b1.Text = "Match";
				this.b2.Text = "Sort";
				this.b2.Location = new Point(this.b1.Right + 8, this.b1.Top);
				this.sc.Panel2.Controls.AddRange(new Control[]
				{
					this.tb1,
					this.b1,
					this.b2
				});
				this.b1.Click += this.b1_Click;
				this.b2.Click += this.sortDGV;
				this.table.Columns.Add("One");
				this.table.Columns.Add("Two");
				this.table.Columns.Add("Three");
				this.table.Rows.Add(new object[]
				{
					"A1",
					"1",
					"ccc"
				});
				this.table.Rows.Add(new object[]
				{
					"B1",
					"1",
					"fff"
				});
				this.table.Rows.Add(new object[]
				{
					"A2",
					"2",
					"ccc"
				});
				this.table.Rows.Add(new object[]
				{
					"B2",
					"2",
					"fff"
				});
				this.table.Rows.Add(new object[]
				{
					"A11",
					"2",
					"ccc"
				});
				this.table.Rows.Add(new object[]
				{
					"B11",
					"2",
					"fff"
				});
				this.table.Rows.Add(new object[]
				{
					"A20",
					"2",
					"ccc"
				});
				this.table.Rows.Add(new object[]
				{
					"B20",
					"2",
					"fff"
				});
				this.table.Rows.Add(new object[]
				{
					"A101",
					"2",
					"ccc"
				});
				this.table.Rows.Add(new object[]
				{
					"B101",
					"2",
					"fff"
				});
				this.view = this.table.DefaultView;
				this.DGV.DataSource = this.view;
				this.DGV.Font = new Font("Ariel", 12f);
				this.DGV.Dock = DockStyle.Fill;
				this.sc.Panel1.Controls.Add(this.DGV);
				this.DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000047F5 File Offset: 0x000029F5
		private void sortDGV(object sender, EventArgs e)
		{
			this.view.Sort = "One asc, two asc";
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000480C File Offset: 0x00002A0C
		private void b1_Click(object sender, EventArgs e)
		{
			checked
			{
				int num = this.DGV.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					DataGridViewRow dataGridViewRow = this.DGV.Rows[i];
					try
					{
						foreach (object obj in dataGridViewRow.Cells)
						{
							DataGridViewCell dataGridViewCell = (DataGridViewCell)obj;
							bool flag = !dataGridViewRow.IsNewRow;
							if (flag)
							{
								bool flag2 = Operators.CompareString(dataGridViewCell.Value.ToString().ToLower(), this.tb1.Text.ToLower(), false) == 0;
								if (flag2)
								{
									dataGridViewCell.Style.BackColor = this.matchColour;
								}
								else
								{
									dataGridViewCell.Style.BackColor = this.unmatchColour;
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
			}
		}

		// Token: 0x04000013 RID: 19
		private SplitContainer sc;

		// Token: 0x04000014 RID: 20
		private Button b1;

		// Token: 0x04000015 RID: 21
		private Button b2;

		// Token: 0x04000016 RID: 22
		private DataGridView DGV;

		// Token: 0x04000017 RID: 23
		private TextBox tb1;

		// Token: 0x04000018 RID: 24
		private Color matchColour;

		// Token: 0x04000019 RID: 25
		private Color unmatchColour;

		// Token: 0x0400001A RID: 26
		private DataTable table;

		// Token: 0x0400001B RID: 27
		private DataView view;
	}
}
