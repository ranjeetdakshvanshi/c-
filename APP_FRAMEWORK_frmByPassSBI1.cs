using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class APP_FRAMEWORK_frmByPassSBI1
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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("APP_FRAMEWORK.frmByPassSBI1", typeof(APP_FRAMEWORK_frmByPassSBI1).Assembly));
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

	internal static Bitmap btnClose_BackgroundImage
	{
		get
		{
			object @object = ResourceManager.GetObject("btnClose.BackgroundImage", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap btnClose_ErrorImage
	{
		get
		{
			object @object = ResourceManager.GetObject("btnClose.ErrorImage", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap btnClose_Image
	{
		get
		{
			object @object = ResourceManager.GetObject("btnClose.Image", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap btnClose_InitialImage
	{
		get
		{
			object @object = ResourceManager.GetObject("btnClose.InitialImage", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal APP_FRAMEWORK_frmByPassSBI1()
	{
	}
}
