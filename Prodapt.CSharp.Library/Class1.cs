namespace Prodapt.CSharp.Library
{
    public class Login
    {
        public bool Validation(string userId, string password)
        {
            if(userId=="admin" && password == "admin@123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
