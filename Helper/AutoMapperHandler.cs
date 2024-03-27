using AutoMapper;
using LearnAPI.Modal;
using LearnAPI.Repos.Models;

namespace LearnAPI.Helper
{
    public class AutoMapperHandler:Profile
    {
        public AutoMapperHandler() {
            CreateMap<TblCustomer, Customermodal>().ForMember(item => item.Statusname, opt => opt.MapFrom(
                item => (item.IsActive != null && item.IsActive.Value) ? "Active" : "In active")).ReverseMap() ;
            CreateMap<TblUser, UserModel>().ForMember(item => item.Statusname, opt => opt.MapFrom(
                item => (item.Isactive != null && item.Isactive.Value) ? "Active" : "In active")).ReverseMap();
        }
    }
}
