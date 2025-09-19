using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        private readonly Context _context;
        public EfBookingDal(Context context) : base(context)
        {
            _context = context;
        }

        public int BookingCount()
        {
            var values = _context.Bookings.Count();
            return values;
        }

        public List<Booking> Last6Bookings()
        {
            var values = _context.Bookings.OrderByDescending(b=>b.BookingID).Take(6).ToList(); 
            return values;
        }
    }
}
