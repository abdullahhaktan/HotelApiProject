using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        private readonly Context _context;
        public EfAppUserDal(Context context) : base(context)
        {
            _context = context;
        }

        public int AppUserCount()
        {
            var values = _context.Users.Count();
            return values;
        }

        public List<AppUser> UserListWithWorkLocation()
        {
            var users = _context.Users.Include(u=>u.WorkLocation).ToList();
            return users;
        }

        public List<AppUser> UsersListWithWorkLocation()
        {
            var values = _context.Users.Include(u=>u.WorkLocation).ToList();
            return values;
        }
    }
}
