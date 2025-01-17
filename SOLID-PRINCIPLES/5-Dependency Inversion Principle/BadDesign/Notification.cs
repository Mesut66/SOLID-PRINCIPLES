

namespace SOLID_PRINCIPLES._5_Dependency_Inversion_Principle.BadDesign
{
    public class Notification
    {
        private Email _email;
        private Sms _sms;

        public Notification()
        {
            Email email = new Email();
            Sms sms = new Sms();

        }
        public void EmailNotify(string message)
        {
            _email.Send(message);
        }

        public void SmsNotify(string message)
        {
            _sms.Send(message);
        }
    }
}
