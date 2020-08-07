namespace TDD
{
    public class UserManager
    {

        // Should return TRUE if able to change the password
        public bool ChangePassword(string userName, string oldPassword, string newPassword)
        {
            if (thisUser == userName && currentPassword == oldPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string thisUser;
        private string currentPassword;

        public UserManager(string userName, string password)
        { thisUser = userName; currentPassword = password; }
    }

}

