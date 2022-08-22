
Console.WriteLine("Hello World!");


SendEmail mail = new();
ComposeEmail composeEmail = new();
ReadMails readMails = new();
mail.SendAsync();
composeEmail.ComposeAsync();
readMails.ReadAsync();

Console.ReadLine();


public class SendEmail
{
    public void SendAsync()
    {
        Console.WriteLine("Sending email...");
    }
}

public class ComposeEmail
{
    public void ComposeAsync()
    {
        Console.WriteLine("Composing email... ");
    }
}

public class ReadMails
{
    public void ReadAsync()
    {
        Console.WriteLine("Reading mails... ");
    }
}

