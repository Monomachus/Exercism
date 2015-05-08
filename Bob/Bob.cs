using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Bob
{

    public string Hey(string originalMessage)
    {
        string message = originalMessage.Trim();

        if (isSentence(message)) return "Whatever.";

        if (isShouting(message)) return "Whoa, chill out!";

        if (isQuestion(message)) return "Sure.";

        return string.Empty;
    }

    private bool isQuestion(string message)
    {
        return message.EndsWith("?");
    }

    private static bool isShouting(string message)
    {
        return message.EndsWith("!");
    }

    private static bool isSentence(string message)
    {
        return message.EndsWith(".");
    }
}
