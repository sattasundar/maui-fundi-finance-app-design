using Android.Content.Res;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace MauiFundi;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		//For Borderless Entry
#if ANDROID
		EntryHandler.Mapper.ModifyMapping("NoUnderline", (h, v, a) =>
		{
			h.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
		});
#endif
		MainPage = new NavigationPage(new MainPage());
	}
}
