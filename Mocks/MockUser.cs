using System.Text;
using System.Text.Json;
using collections.Models;
using collections.Enums;
using collections.Interfaces;

namespace collections.Mocks {
    public class MockUsers : IUsers
    {
        private string _path;
        private string _file;
        
        public MockUsers(IWebHostEnvironment env)
        {
            _path = env.ContentRootPath + "/db_files/";
            _file = "users.txt";
        }

        private string FullFilePath()
        {
            return _path + _file;
        }

        private void save(string data)
        {
            bool pathExists = System.IO.Directory.Exists(_path);
            if(! pathExists) {
                System.IO.Directory.CreateDirectory(_path);
            }

            string file = this.FullFilePath();
            using (FileStream fs = File.Create(file))
            {
                byte[] bytes = new UTF8Encoding(true).GetBytes(data);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
        }

        public User Get(User user)
        {
            LinkedList<User> users = new LinkedList<User>(this.All);
            return users.Find(user).Value;
        }

        public User GetById(int id)
        {
            foreach(User user in this.All) {
                if(id == user.id) return user;
            }

            return null;
        }

        public bool Remove(User user)
        {
            List<User> users = new List<User>(this.All);
            users.RemoveAll(u => u.id == user.id);

            this.All = users;
            return true;
        }

        public bool RemoveById(int id)
        {
            User user = this.GetById(id);
            if(user != null) this.Remove(user);

            return true;
        }

        public IEnumerable<User> All
        {
            get {
                HashSet<User> users = new HashSet<User>();
                if(! File.Exists(this.FullFilePath())) {
                    this.save(JsonSerializer.Serialize(users));
                }

                StreamReader reader = File.OpenText(this.FullFilePath());
                string read = reader.ReadLine();

                if(read != null) {
                    users = JsonSerializer.Deserialize<HashSet<User>>(read);
                }

                reader.Close();
                return users == null ? new HashSet<User>() : users;
            }

            set {
                SortedList<int, User> sorted = new SortedList<int, User>();
                foreach(User u in value) sorted.Add(u.id, u);

                if(sorted.GetValueAtIndex(0).id == 0) {
                    int lastId = sorted.GetValueAtIndex(sorted.Count - 1).id;

                    sorted.GetValueAtIndex(0).id =  lastId + 1;
                }
                
                LinkedList<User> users = new LinkedList<User>();
                foreach(int key in sorted.Keys) {
                    users.AddLast((User) sorted[key]);
                }

                this.save(JsonSerializer.Serialize(users));
            }
        }

        public IEnumerable<User> OrderById(string method = "asc")
        {
            List<User> users = new List<User>(this.All);
            
            users.Sort(delegate(User first, User second) {
                if(String.Equals(method, SortingEnum.ASC)) return first.id >= second.id ? 1 : -1;
                return first.id < second.id ? 1 : -1;
            });

            return users;
        }

        public IEnumerable<User> OrderByName(string method = "asc")
        {
            List<User> users = new List<User>(this.All);
            
            users.Sort(delegate(User first, User second) {
                if(String.Equals(method, SortingEnum.ASC)) return first.name.CompareTo(second.name);
                return second.name.CompareTo(first.name);
            });

            return users;
        }

        public IEnumerable<User> OrderBySurname(string method = "asc")
        {
            List<User> users = new List<User>(this.All);
            
            users.Sort(delegate(User first, User second) {
                if(String.Equals(method, SortingEnum.ASC)) return first.surname.CompareTo(second.surname);
                return second.surname.CompareTo(first.surname);
            });

            return users;
        }

        public IEnumerable<User> OrderByAge(string method = "asc")
        {
            List<User> users = new List<User>(this.All);
            
            users.Sort(delegate(User first, User second) {
                if(String.Equals(method, SortingEnum.ASC)) return first.age >= second.age ? 1 : -1;
                return first.age < second.age ? 1 : -1;
            });

            return users;
        }

        public IEnumerable<User> AllOrdered(string by, string method = SortingEnum.ASC)
        {
            
            if(String.Equals(by, "age")) return this.OrderByAge(method);
            else if(String.Equals(by, "name")) return this.OrderByName(method);
            else if(String.Equals(by, "surname")) return this.OrderBySurname(method);
            else return this.OrderById(method);
        }
    }
}