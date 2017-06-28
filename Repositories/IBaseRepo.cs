using System.Collections.Generic;
using DOTNETCORE.Models;
using System;

namespace DOTNETCORE.Repositories
{
    public interface IBaseRepo{
        List<Employee> findAll();
        Employee getById();
        void Add();
        void Update();
        void Delete();
    }
}