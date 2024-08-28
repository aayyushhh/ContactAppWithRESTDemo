namespace ContactAppWithRESTDemo.Services.ExceptionHandler
{
    public class UserNotAdminException:Exception
    {
        public UserNotAdminException(string msg):base(msg) 
        {
            
        }
    }
}
