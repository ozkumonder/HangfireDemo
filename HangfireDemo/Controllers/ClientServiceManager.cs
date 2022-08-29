namespace HangfireDemo.Controllers
{
    public class ClientServiceManager
    {
        public static void Loglama()
        {
            LogHelper.Log(LogLevel.Info, "Job tetiklendi...");
            try
            {
                string ayrac = new string('-', 6);
                int a = 100, b = 0;
                a = (a / b);
            }
            catch (Exception e)
            {
                LogHelper.Log(LogLevel.Error, e.Message);
            }
        }
    }
}
