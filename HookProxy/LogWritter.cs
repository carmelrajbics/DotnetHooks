using Serilog;
using System.Text;

namespace HookProxy;

public class LogWritter : TextWriter
{
    public override Encoding Encoding => Encoding.Default;

    public override void Write(char value)
    {
        Write(value.ToString());
    }

    public override void Write(string? value)
    {
        Log.Logger.Information(value);
    }
}
