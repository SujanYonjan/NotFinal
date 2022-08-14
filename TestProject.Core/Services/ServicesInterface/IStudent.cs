using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Core.Models;
using TestProject.Models;

namespace TestProject.Core.Services.ServicesInterface
{
    public interface IStudent
    {
        List<Student> GetAll();
        Student GetById(int studentId);
        void Insert(Student student);
        void Update(Student student);
        void Delete(Student student);
        void Save();
    }
}
