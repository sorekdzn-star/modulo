using System;
using System.Collections;
using System.Windows.Forms;

namespace ModuloAdicional
{
	// Token: 0x0200002E RID: 46
	public class OrdenaComoYoQuiero : IComparer
	{
		// Token: 0x06001205 RID: 4613 RVA: 0x00115658 File Offset: 0x00113858
		public OrdenaComoYoQuiero()
		{
			this.Descendente = true;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00115668 File Offset: 0x00113868
		public int Compare(object x, object y)
		{
			DataGridViewRow dataGridViewRow = (DataGridViewRow)x;
			DataGridViewRow dataGridViewRow2 = (DataGridViewRow)y;
			int num = dataGridViewRow.Cells[1].Value.ToString().CompareTo(dataGridViewRow2.Cells[1].Value.ToString());
			bool flag = num == 0;
			if (flag)
			{
				num = dataGridViewRow2.Cells[1].Value.ToString().CompareTo(dataGridViewRow.Cells[1].Value.ToString());
			}
			return this.Descendente ? checked(-1 * num) : num;
		}

		// Token: 0x040007FA RID: 2042
		public bool Descendente;
	}
}
