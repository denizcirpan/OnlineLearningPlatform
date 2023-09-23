using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AssignmentManager : IAssignmentService
    {
        IAssignmentDAL _assignmentDAL;
        public AssignmentManager(IAssignmentDAL assignmentDAL)
        {
            _assignmentDAL = assignmentDAL;
        }

        public void AssignmentAdd(Assignment assignment)
        {
            _assignmentDAL.Insert(assignment);
        }

        public void AssignmentChangeStatus(Assignment assignment)
        {
            throw new NotImplementedException();
        }

        public void AssignmentDelete(Assignment assignment)
        {
            throw new NotImplementedException();
        }

        public void AssignmentUpdate(Assignment assignment)
        {
            throw new NotImplementedException();
        }

        public Assignment GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Assignment> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
