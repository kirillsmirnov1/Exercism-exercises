using System;
using System.Collections.Generic;

public static class SecretHandshake
{
    private static readonly Operations[] operations = new Operations[] 
    {
        new Operations(1, x => x.Add("wink")),
        new Operations(2, x => x.Add("double blink")),
        new Operations(4, x => x.Add("close your eyes")),
        new Operations(8, x => x.Add("jump")),
        new Operations(16, x => x.Reverse())
    };

    public static string[] Commands(int commandValue)
    {
        List<string> list = new List<string>();

        foreach(var operation in operations)
        {
            if ((commandValue & operation.code) == operation.code)
                operation.Apply(list);
        }

        return list.ToArray();
    }

    private class Operations
    {
        public int code;
        public Action<List<string>> Apply;

        public Operations(int code, Action<List<string>> action)
            => (this.code, Apply) = (code, action);
    }
}
