using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetsController(IBookingService _bookingService
        , IStaffService _staffService,Context _context,IAppUserService _appUserService,IRoomService _roomService) : ControllerBase
    {
        //private readonly IStaffService _staffService;
        //private readonly Context _context;

        //public DashboardWidgetsController(IStaffService staffService, Context context)
        //{
        //    _staffService = staffService;
        //    _context = context;
        //}

        [HttpGet("StaffCount")]
        public IActionResult GetStaffCount()
        {
            int count = _staffService.TGetStaffCount();
            return Ok(count);
        }

        [HttpGet("BookingCount")]
        public IActionResult GetBookingCount()
        {
            int count = _bookingService.GetBookingCount();
            return Ok(count);
        }

        [HttpGet("AppUserCount")]
        public IActionResult GetUserCount()
        {
            int count = _appUserService.AppUserCount();
            return Ok(count);
        }

        [HttpGet("RoomCount")]
        public IActionResult GetRoomCount()
        {
            int count = _roomService.GetRoomCount();
            return Ok(count);
        }
    }
}
