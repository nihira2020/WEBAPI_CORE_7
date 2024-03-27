using LearnAPI.Helper;
using LearnAPI.Modal;

namespace LearnAPI.Service
{
    public interface IUserService
    {
        Task<APIResponse> UserRegisteration(UserRegister userRegister);
        Task<APIResponse> ConfirmRegister(int userid, string username, string otptext);
        Task<APIResponse> ResetPassword(string username, string oldpassword,string newpassword);
        Task<APIResponse> ForgetPassword(string username);
        Task<APIResponse> UpdatePassword(string username,string Password,string Otptext);
        Task<APIResponse> UpdateStatus(string username, bool userstatus);
        Task<APIResponse> UpdateRole(string username, string userrole);
        Task<List<UserModel>> Getall();
        Task<UserModel> Getbycode(string code);
    }
}
