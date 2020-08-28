using System.Threading;
using static System.Console;

public class Program
{
  public static void Main(string[] args) => OpenBrowser("https://ragewars.ga/");

  public static void OpenBrowser(string url)
  {
    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
    {
      Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
    }
    else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
    {
      Process.Start("xdg-open", url);
    }
    else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
    {
      Process.Start("open", url);
    }
    else
    {
      WriteLine("tf... what os are you running");
    }
  }
}
