using Avalonia;

namespace ArsVisualizer
{
    public class Program
    {
        public static AppBuilder BuildAvaloniaApp()
         => AppBuilder.Configure<App>().UsePlatformDetect();

        public static int Main(string[] args)
          => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
    }
}