using EntityFrameworkDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo.Business
{
    public interface IPersonelService
    {
        List<Personel> GetAll();
    }
}
