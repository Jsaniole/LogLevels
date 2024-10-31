using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Substring(logLine.IndexOf(':') + 2).Trim();
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        return logLine.Substring(logLine.IndexOf('[') + 1, logLine.IndexOf(']') - 1).ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        string logline = logLine.Trim();
        string message = logline.Substring(logline.IndexOf(':') + 2);
        string loglevel = logLine.Substring(logline.IndexOf('[') + 1, logline.IndexOf(']') - 1).ToLower();
        message = message.Trim();
        return $"{message} " + "(" + $"{loglevel}" + ")";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
