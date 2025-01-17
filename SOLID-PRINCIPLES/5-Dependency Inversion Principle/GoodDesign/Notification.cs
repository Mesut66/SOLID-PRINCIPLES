

namespace SOLID_PRINCIPLES._5_Dependency_Inversion_Principle.GoodDesign
{
    public class Notification
    {
        private IMessageType _messageType;

        public Notification(IMessageType messageType)
        {
            _messageType = messageType;
        }

        public void SendNotification(string message)
        {
            _messageType.Send(message);
        }
    }
}
