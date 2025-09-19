using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public int AppUserCount()
        {
           return _appUserDal.AppUserCount();
        }

        public void Delete(AppUser t)
        {
            _appUserDal.Delete(t);
        }

        public AppUser GetById(int id)
        {
           return _appUserDal.GetById(id);
        }

        public List<AppUser> GetList()
        {
           return _appUserDal.GetList();
        }

        public void Insert(AppUser t)
        {
            _appUserDal.Insert(t);
        }

        public void TDelete(AppUser t)
        {
            _appUserDal.Delete(t);
        }

        public AppUser TGetById(int id)
        {
            return _appUserDal.GetById(id);
        }

        public List<AppUser> TGetList()
        {
           return _appUserDal.GetList();
        }

        public void TInsert(AppUser t)
        {
            _appUserDal.Insert(t);
        }

        public void TUpdate(AppUser t)
        {
            _appUserDal.Update(t);
        }

        public List<AppUser> TUserListWithWorkLocation()
        {
            return _appUserDal.UserListWithWorkLocation();
        }

        public List<AppUser> TUsersListWithWorkLocation()
        {
            return _appUserDal.UsersListWithWorkLocation();
        }

        public void Update(AppUser t)
        {
            _appUserDal.Update(t);
        }

    }
}
