
using task.Models.BaseModels;

namespace task.Models
{
    public class EmailSender : MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("emailSender");
        }
    }
}
