    using System.Collections.Generic;
    using System.Threading.Tasks;

namespace Real_Time_Chat_Application_SignalIR.Data
{
    public class ChatService
    {
        public List<(string User, string Message)> Messages { get; } = new();

        public event Action? OnMessagesUpdated;

        public void AddMessage(string user, string message)
        {
            Messages.Add((user, message));
            OnMessagesUpdated?.Invoke();
        }
    }

}
