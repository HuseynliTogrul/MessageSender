using task.Models;
EmailSender EmailSender = new EmailSender();
SmsSender SmsSender = new SmsSender();
Console.WriteLine("1. Send message by email");
Console.WriteLine("2.Send message by sms");
Console.WriteLine("0. Quit");

string request = Console.ReadLine();

while (request!="0")
{
	switch (request)
	{
		case "1":
			EmailSender.SendMessage();
            break;
			case "2":
			SmsSender.SendMessage();
            break;
		default:
			Console.WriteLine("duzgun deyer daxil edin!");
			break;
	}
    Console.WriteLine("1. Send message by email");
    Console.WriteLine("2.Send message by sms");
    Console.WriteLine("0. Quit");
    request = Console.ReadLine();
}