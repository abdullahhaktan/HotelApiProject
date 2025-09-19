using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.AdminContactDto;
using HotelProject.WebUI.Dtos.AppUserDto;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.SubscribeDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<CreateAboutDto,About>().ReverseMap();
            CreateMap<UpdateAboutDto,About>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();
            CreateMap<CreateStaffDto, Staff>().ReverseMap();
            CreateMap<UpdateStaffDto, Staff>().ReverseMap();

            CreateMap<ResultSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();


            CreateMap<ApprovedBookingDto, Booking>().ReverseMap();

            CreateMap<CreateGuestDto , Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();
            CreateMap<ResultGuestDto, Guest>().ReverseMap();

            CreateMap<ResultSendMessageDto, SendMessage>();

            CreateMap<ResultAppUserDto,AppUser>().ReverseMap();
        }
    }
}
