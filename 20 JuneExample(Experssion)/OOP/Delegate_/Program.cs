using Delegate_.Models;

namespace Delegate_
{
    internal class Program
    {


        public delegate void LogSenderDelegateLow(string message);
        public delegate void LogSenderDelegateMedium(string message);
        public delegate void LogSenderDelegateHigh(string message);
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            SmsLog smsLog = new SmsLog();
            XmlLog xmlLog = new XmlLog();
            SqlLog sqlLog = new SqlLog();
            MailLog mailLog = new MailLog();
            PushNotiLog pushNotiLog = new PushNotiLog();
            #region MyRegion

            LogSenderDelegateLow logSenderDelegateLow = new(smsLog.SendLog);
            logSenderDelegateLow += xmlLog.SendLog;
            logSenderDelegateLow.Invoke("Mahalle yanıyo");

            LogSenderDelegateMedium logSenderDelegateMedium = new(smsLog.SendLog);
            logSenderDelegateMedium += xmlLog.SendLog;
            logSenderDelegateMedium += sqlLog.SendLog;
            logSenderDelegateMedium.Invoke("Mahalle yanıyo");


            LogSenderDelegateHigh logSenderDelegateHigh = new(smsLog.SendLog);
            logSenderDelegateHigh += xmlLog.SendLog;
            logSenderDelegateHigh += sqlLog.SendLog;
            logSenderDelegateHigh += pushNotiLog.SendLog;
            logSenderDelegateHigh += mailLog.SendLog;
            logSenderDelegateHigh.Invoke("Mahalle yanıyo");



            Action<string> SmsAction  = message => new SmsLog().SendLog(message);
            Action<string> MailAction = message => new MailLog().SendLog(message);

            var logs = new Action<string>[]
            {
                SmsAction,
                MailAction
            };

            foreach (var log in logs)
            {
                log("Mahalle yanıyo");
            }
            #endregion

            Action<string> level5   = new Action<string>(smsLog.SendLog);
            level5 += new Action<string>(xmlLog.SendLog);
            level5 += new Action<string>(sqlLog.SendLog);
            level5 += new Action<string>(pushNotiLog.SendLog);
            level5 += new Action<string>(mailLog.SendLog);
            level5("Mahalle yanıyo");

        }
    }
}


/*
Delegate Nedir?
C# programlama dilinde, bir delegate, bir veya daha fazla metoda referans tutan ve bu metotları çağırmayı sağlayan bir türdür. Başka bir deyişle, delegate'ler metotları değişkenler gibi kullanmanızı sağlar. Böylece, programınızda esneklik ve yeniden kullanılabilirlik sağlayabilirsiniz.

Delegate'ler özellikle olay işleyicileri ve geri çağırma fonksiyonları yazarken kullanılır. Delegate'ler sayesinde, hangi metotun çalıştırılacağını çalışma zamanında belirleyebilir ve böylece kodunuzu daha modüler ve esnek hale getirebilirsiniz.
*/