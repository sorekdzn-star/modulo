using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel
{
	// Token: 0x02000041 RID: 65
	[CompilerGenerated]
	[Guid("000208DB-0000-0000-C000-000000000046")]
	[TypeIdentifier]
	[ComImport]
	public interface Workbooks : IEnumerable
	{
		// Token: 0x0600128B RID: 4747
		void _VtblGap1_3();

		// Token: 0x0600128C RID: 4748
		[DispId(181)]
		[LCIDConversion(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Workbook Add([MarshalAs(UnmanagedType.Struct)] [In] [Optional] object Template);

		// Token: 0x0600128D RID: 4749
		void _VtblGap2_6();

		// Token: 0x17000775 RID: 1909
		[DispId(0)]
		[IndexerName("_Default")]
		Workbook this[[MarshalAs(UnmanagedType.Struct)] [In] object Index]
		{
			[DispId(0)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}
	}
}
