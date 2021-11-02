using System;

public static class ClientUtils
{
    public static string StripInvalidFileNameChars(string input)
    {
        return input.Trim(System.IO.Path.GetInvalidFileNameChars());
    }
}
