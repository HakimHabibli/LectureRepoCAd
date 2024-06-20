namespace Delegate_.Models
{
    public interface ILogger
    {
        void SendLog(string message);
    }

    public class Logger<T> : ILogger where T : ILogger, new()
    {
        public void SendLog(string message)
        {

            if (typeof(T) == typeof(SmsLog))
            {
                Console.WriteLine("Sms Log " + message);

            }
            else if (typeof(T) == typeof(XmlLog))
            {
                Console.WriteLine("Xml Log " + message);

            }
            else if (typeof(T) == typeof(SqlLog))
            {
                Console.WriteLine("Sql Log " + message);

            }
            else if (typeof(T) == typeof(MailLog))
            {
                Console.WriteLine("Mail Log " + message);

            }
            else if (typeof(T) == typeof(PushNotiLog))
            {
                Console.WriteLine("PushNotiLog Log " + message);
            }
        }
    }


    public class SmsLog : Logger<SmsLog>, ILogger { }
    public class XmlLog : Logger<XmlLog>, ILogger { }
    public class SqlLog : Logger<SqlLog>, ILogger { }
    public class MailLog : Logger<MailLog>, ILogger { }
    public class PushNotiLog : Logger<PushNotiLog>, ILogger { }
}
