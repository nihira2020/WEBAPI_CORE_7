namespace LearnAPI.Modal
{
    public class UserRegister
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }

    public class Confirmpassword
    {
        public int userid { get; set; }
        public string username { get; set; }
        public string otptext { get; set; }
    }

    public class Resetpassword
    {
        public string username { get; set; }
        public string oldpassword { get; set; }
        public string newpassword { get; set; }
    }

    public class Updatepassword
    {
        public string username { get; set; }
        public string password { get; set; }
        public string otptext { get; set; }
    }

    public class Updatestatus
    {
        public string username { get; set; }
        public bool status { get; set; }
    }

    public class UpdateRole
    {
        public string username { get; set; }
        public string role { get; set; }
    }
}
