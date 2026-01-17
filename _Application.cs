using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
	// Token: 0x02000043 RID: 67
	[CompilerGenerated]
	[DefaultMember("_Default")]
	[Guid("000208D5-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	[ComImport]
	public interface _Application
	{
		// Token: 0x0600128F RID: 4751
		void _VtblGap1_45();

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001290 RID: 4752
		[DispId(572)]
		Workbooks Workbooks { [DispId(572)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x06001291 RID: 4753
		void _VtblGap2_60();

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001292 RID: 4754
		[DispId(0)]
		[IndexerName("_Default")]
		string _Default { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06001293 RID: 4755
		void _VtblGap3_116();

		// Token: 0x06001294 RID: 4756
		[DispId(302)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Quit();
	}
}
