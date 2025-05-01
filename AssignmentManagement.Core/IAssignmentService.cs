using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManagement.Core
{
    public interface IAssignmentService
    {
        public bool AddAssignment(Assignment assignment);


        public List<Assignment> ListAll();


        public List<Assignment> ListIncomplete();
       

        // TODO: Implement method to find an assignment by title
        public Assignment FindAssignmentByTitle(string title)
        {
            throw new NotImplementedException();
        }

        // TODO: Implement method to mark an assignment complete
        public bool MarkAssignmentComplete(string title)
        {
            throw new NotImplementedException();
        }

        // TODO: Implement method to delete an assignment by title
        public bool DeleteAssignment(string title)
        {
            throw new NotImplementedException();
        }

        // TODO: Implement method to update an assignment (title and description)
        public bool UpdateAssignment(string oldTitle, string newTitle, string newDescription)
        {
            throw new NotImplementedException();
        }

    }
}
