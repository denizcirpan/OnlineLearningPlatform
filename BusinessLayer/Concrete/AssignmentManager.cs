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
            if (assignment.isActive == true)
            {
                assignment.isActive = false;
            }
            else if (assignment.isActive == false)
            {
                assignment.isActive = true;
            }
        }

        public void AssignmentDelete(Assignment assignment)
        {
            _assignmentDAL.Delete(assignment);
        }

        public void AssignmentUpdate(Assignment assignment)
        {
            _assignmentDAL.Update(assignment);
        }

        public Assignment GetByID(int id)
        {
            return _assignmentDAL.Get(x => x.assignmentId == id);
        }

        public List<Assignment> GetList()
        {
            return _assignmentDAL.List();
        }
    }
}
