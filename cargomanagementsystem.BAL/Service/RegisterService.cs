using cargomanagementsystem.DAL.Repository;
using cargomanagementsystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace cargomanagementsystem.BAL.Service
{
   public class RegisterService
    {
        private IRegisterRepo _registerRepo;
        public RegisterService(IRegisterRepo registerRepo)
        {
            _registerRepo = registerRepo;
        }
        public void Register(cargomanagementRegister cargomanagementRegister)
        {
            _registerRepo.Register(cargomanagementRegister);
        }
        public cargomanagementRegister Login(cargomanagementRegister cargologin)
        {
            return _registerRepo.Login(cargologin);
        }
    }
}
