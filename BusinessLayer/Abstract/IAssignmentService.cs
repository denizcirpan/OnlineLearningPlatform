using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAssignmentService
    {
        List<Assignment> GetList();
        void AssignmentAdd(Assignment assignment);
        Assignment GetByID(int id);
        void AssignmentChangeStatus(Assignment assignment);
        void AssignmentUpdate(Assignment assignment);
        void AssignmentDelete(Assignment assignment);
    }
}
