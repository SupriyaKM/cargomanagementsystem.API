using cargomanagementsystem.DAL.Data;
using cargomanagementsystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cargomanagementsystem.DAL.Repository
{
    public class RegisterRepo : IRegisterRepo
    {
        private cargomanagementDbContext _cargomanagementDbContext;
        public RegisterRepo(cargomanagementDbContext cargomanagementDbContext)
        {
            _cargomanagementDbContext = cargomanagementDbContext;
        }
        public cargomanagementRegister Login(cargomanagementRegister cargologin)
        {
            cargomanagementRegister cargomanagementRegister = null;
            var result = _cargomanagementDbContext.Register.Where(obj => obj.Emailid == cargologin.Emailid && obj.Password == cargologin.Password).ToList();
            if(result.Count>0)
            {
                cargomanagementRegister = result[0];
            }
            return cargomanagementRegister;
        }

        public void Register(cargomanagementRegister cargomanagementRegister)
        {
            _cargomanagementDbContext.Register.Add(cargomanagementRegister);
            _cargomanagementDbContext.SaveChanges();
        }
    }
} 
