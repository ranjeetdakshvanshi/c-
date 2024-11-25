using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class NEXUS_Booking_Class31_Rail
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("NEXUS.Booking.Class31_Rail", typeof(NEXUS_Booking_Class31_Rail).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static string national => ResourceManager.GetString("national", resourceCulture);

	internal static string stn => ResourceManager.GetString("stn", resourceCulture);

	internal static string trnlist => ResourceManager.GetString("trnlist", resourceCulture);

	internal NEXUS_Booking_Class31_Rail()
	{
	}
}
