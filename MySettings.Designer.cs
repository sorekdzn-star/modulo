using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ModuloAdicional.My
{
	// Token: 0x0200002A RID: 42
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x060011F5 RID: 4597 RVA: 0x0011541C File Offset: 0x0011361C
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			bool saveMySettingsOnExit = MyProject.Application.SaveMySettingsOnExit;
			if (saveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x00115448 File Offset: 0x00113648
		public static MySettings Default
		{
			get
			{
				bool flag = !MySettings.addedHandler;
				if (flag)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						bool flag3 = !MySettings.addedHandler;
						if (flag3)
						{
							MyProject.Application.Shutdown += MySettings.AutoSaveSettings;
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x001154D4 File Offset: 0x001136D4
		// (set) Token: 0x060011F8 RID: 4600 RVA: 0x001154F6 File Offset: 0x001136F6
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AutoUpdate
		{
			get
			{
				return Conversions.ToBoolean(this["AutoUpdate"]);
			}
			set
			{
				this["AutoUpdate"] = value;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x0011550C File Offset: 0x0011370C
		// (set) Token: 0x060011FA RID: 4602 RVA: 0x0011552E File Offset: 0x0011372E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string UpdateLink
		{
			get
			{
				return Conversions.ToString(this["UpdateLink"]);
			}
			set
			{
				this["UpdateLink"] = value;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x00115540 File Offset: 0x00113740
		// (set) Token: 0x060011FC RID: 4604 RVA: 0x00115562 File Offset: 0x00113762
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string DownloadLink
		{
			get
			{
				return Conversions.ToString(this["DownloadLink"]);
			}
			set
			{
				this["DownloadLink"] = value;
			}
		}

		// Token: 0x040007F2 RID: 2034
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x040007F3 RID: 2035
		private static bool addedHandler;

		// Token: 0x040007F4 RID: 2036
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
