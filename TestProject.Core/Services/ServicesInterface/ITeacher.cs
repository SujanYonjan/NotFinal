using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Core.Models;
using TestProject.Models;

namespace TestProject.Core.Services.ServicesInterface
{
    public interface ITeacher
    {
        List<Teacher> GetAll();
        Teacher GetById(int TeacherId);
        void Insert(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(Teacher teacher);
        void Save();
    }
}
