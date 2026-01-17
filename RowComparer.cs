using System;
using System.Collections;
using System.Windows.Forms;

namespace ModuloAdicional
{
	// Token: 0x02000031 RID: 49
	public class RowComparer : IComparer
	{
		// Token: 0x06001215 RID: 4629 RVA: 0x0011593C File Offset: 0x00113B3C
		public RowComparer(SortOrder sortOrder)
		{
			this.sortOrderModifier = 1;
			bool flag = sortOrder == SortOrder.Descending;
			if (flag)
			{
				this.sortOrderModifier = -1;
			}
			else
			{
				bool flag2 = sortOrder == SortOrder.Ascending;
				if (flag2)
				{
					this.sortOrderModifier = 1;
				}
			}
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0011597C File Offset: 0x00113B7C
		public int Compare(object x, object y)
		{
			DataGridViewRow dataGridViewRow = (DataGridViewRow)x;
			DataGridViewRow dataGridViewRow2 = (DataGridViewRow)y;
			int num = string.Compare(dataGridViewRow.Cells[1].Value.ToString(), dataGridViewRow2.Cells[2].Value.ToString());
			bool flag = num == 0;
			if (flag)
			{
				num = string.Compare(dataGridViewRow.Cells[2].Value.ToString(), dataGridViewRow2.Cells[2].Value.ToString());
			}
			return checked(num * this.sortOrderModifier);
		}

		// Token: 0x040007FC RID: 2044
		private int sortOrderModifier;
	}
}
