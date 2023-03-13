using Academy_2023.Data;
using Academy_2022.Data;
using SQLitePCL;

namespace Academy_2022.Repositories
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User? GetById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public User? Matured(int Age)
        {
            var ageQuery = _context.Users.Where(x => x.Age == 18);

            foreach (var user in ageQuery)
            {
                return user;
            }

            return null;
        }

        public void Create(User data)
        {
            _context.Users.Add(data);

            _context.SaveChanges();
        }

        public User? Update(int id, User data)
        {
            foreach (var user in _context.Users)
            {
                if (user.Id == id)
                {
                    user.FirstName = data.FirstName;
                    user.LastName = data.LastName;

                    return user;
                }
            }

            return null;
        }

        public bool Delete(int id)
        {
            foreach (var user in _context.Users)
            {
                if (user.Id == id)
                {
                    _context.Users.Remove(user);

                    return true;
                }
            }

            return false;
        }
    }
}
