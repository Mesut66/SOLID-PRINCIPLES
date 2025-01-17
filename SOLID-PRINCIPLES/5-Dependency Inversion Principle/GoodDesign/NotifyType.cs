

using SOLID_PRINCIPLES._5_Dependency_Inversion_Principle.CommonType;

namespace SOLID_PRINCIPLES._5_Dependency_Inversion_Principle.GoodDesign
{
    internal class NotifyType
    {
        public void NotifyMessage(string message, EnumMessage type)
        {
            Notification notification = null;

            if (TryGetNotificationStrategy(type, ref notification))
            {
                notification.SendNotification(message);
            }

            notification.SendNotification(message);
        }

        private bool TryGetNotificationStrategy(EnumMessage type, ref Notification notification)
        {
            switch (type)
            {
                case EnumMessage.Email:
                    notification = new Notification(new Email());
                    break;
                case EnumMessage.Sms:
                    notification = new Notification(new Sms());
                    break;
                default:
                    notification = new Notification(new Email());
                    break;
            }

            return notification != null;
        }
    }
}
