using cargomanagementsystem.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace cargomanagementsystem.DAL.Repository
{
   public interface IRegisterRepo
    {
        void Register(cargomanagementRegister cargomanagementRegister);
        cargomanagementRegister Login(cargomanagementRegister cargologin);
        
    }
}
