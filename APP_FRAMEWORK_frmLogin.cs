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
internal class APP_FRAMEWORK_frmLogin
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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("APP_FRAMEWORK.frmLogin", typeof(APP_FRAMEWORK_frmLogin).Assembly));
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

	internal static PointF animation1_BlindCoeff
	{
		get
		{
			object @object = ResourceManager.GetObject("animation1.BlindCoeff", resourceCulture);
			return (PointF)@object;
		}
	}

	internal static PointF animation1_MosaicCoeff
	{
		get
		{
			object @object = ResourceManager.GetObject("animation1.MosaicCoeff", resourceCulture);
			return (PointF)@object;
		}
	}

	internal static PointF animation1_MosaicShift
	{
		get
		{
			object @object = ResourceManager.GetObject("animation1.MosaicShift", resourceCulture);
			return (PointF)@object;
		}
	}

	internal static PointF animation1_ScaleCoeff
	{
		get
		{
			object @object = ResourceManager.GetObject("animation1.ScaleCoeff", resourceCulture);
			return (PointF)@object;
		}
	}

	internal static PointF animation1_SlideCoeff
	{
		get
		{
			object @object = ResourceManager.GetObject("animation1.SlideCoeff", resourceCulture);
			return (PointF)@object;
		}
	}

	internal static Bitmap B2AAA_Image
	{
		get
		{
			object @object = ResourceManager.GetObject("B2AAA.Image", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap btnLogin_Iconimage
	{
		get
		{
			object @object = ResourceManager.GetObject("btnLogin.Iconimage", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap bunifuButton1_Iconimage
	{
		get
		{
			object @object = ResourceManager.GetObject("bunifuButton1.Iconimage", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap C1AA0_Image
	{
		get
		{
			object @object = ResourceManager.GetObject("C1AA0.Image", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap txtPassword_BackgroundImage
	{
		get
		{
			object @object = ResourceManager.GetObject("txtPassword.BackgroundImage", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap txtPassword_Icon
	{
		get
		{
			object @object = ResourceManager.GetObject("txtPassword.Icon", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap txtUserName_BackgroundImage
	{
		get
		{
			object @object = ResourceManager.GetObject("txtUserName.BackgroundImage", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap txtUserName_Icon
	{
		get
		{
			object @object = ResourceManager.GetObject("txtUserName.Icon", resourceCulture);
			return (Bitmap)@object;
		}
	}
}
