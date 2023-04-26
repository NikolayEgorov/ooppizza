using collections.Enums;
using collections.Models;

namespace collections.ViewModels.Users {
    public class IndexViewModels {
        public IEnumerable<User> users;
        public string orderBy;
        public string order;

        public IndexViewModels(IEnumerable<User> users, string orderBy = "id", string order = SortingEnum.ASC)
        {
            this.users = users;

            this.orderBy = orderBy;
            this.order = order;
        }
    }
}