
using task.Models.BaseModels;

namespace task.Models
{
    public class SmsSender : MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("smsSender ");
        }
    }
}
