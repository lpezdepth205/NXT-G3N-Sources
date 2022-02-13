using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace COD2019TOOL.Properties
{
	// Token: 0x02000006 RID: 6
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00003751 File Offset: 0x00001951
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("COD2019TOOL.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000377D File Offset: 0x0000197D
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00003784 File Offset: 0x00001984
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000378C File Offset: 0x0000198C
		internal Resources()
		{
		}

		// Token: 0x04000018 RID: 24
		private static ResourceManager resourceMan;

		// Token: 0x04000019 RID: 25
		private static CultureInfo resourceCulture;
	}
}
