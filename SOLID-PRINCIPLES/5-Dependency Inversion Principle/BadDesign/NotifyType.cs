

using SOLID_PRINCIPLES._5_Dependency_Inversion_Principle.CommonType;

namespace SOLID_PRINCIPLES._5_Dependency_Inversion_Principle.BadDesign
{
    public class NotifyType
    {
        public void NotifyMessage(string message, EnumMessage type)
        {
            switch (type)
            {
                case EnumMessage.Email:
                    new Notification().EmailNotify(message);
                    break;
                case EnumMessage.Sms:
                    new Notification().SmsNotify(message);
                    break;
                default:
                    break;
            }
        }
    }
}
