using Ardalis.Specification;
using Mslearn.Core.Entities;

namespace Mslearn.Core.Specifications
{
    public class IncompleteItemsSpecification : Specification<ToDoItem>
    {
        public IncompleteItemsSpecification()
        {
            Query.Where(item => !item.IsDone);
        }
    }
}
