using collections.Models;
using collections.Enums;

namespace collections.Interfaces
{
    public interface IUsers
    {
        IEnumerable<User> All { get; set; }
        IEnumerable<User> OrderById(string method = SortingEnum.ASC);
        IEnumerable<User> OrderByName(string method = SortingEnum.ASC);
        IEnumerable<User> OrderBySurname(string method = SortingEnum.ASC);
        IEnumerable<User> OrderByAge(string method = SortingEnum.ASC);
        IEnumerable<User> AllOrdered(string by, string method = SortingEnum.ASC);
        User Get(User user);
        User GetById(int id);
        bool Remove(User user);
        bool RemoveById(int id);
    }
}