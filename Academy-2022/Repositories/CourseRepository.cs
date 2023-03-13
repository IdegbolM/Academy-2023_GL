using Academy_2023.Data;
using Academy_2022.Data;
using SQLitePCL;

namespace Academy_2022.Repositories
{
    public class CourseRepository
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public IEnumerable<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public Course? GetById(int id)
        {
            return _context.Courses.FirstOrDefault(x => x.Id == id);
        }

        public void Create(Course data)
        {
            _context.Courses.Add(data);

            _context.SaveChanges();
        }

        public Course? Update(int id, Course data)
        {
            foreach (var Course in _context.Courses)
            {
                if (Course.Id == id)
                {
                    Course.Name = data.Name;
                    Course.Description = data.Description;

                    return Course;
                }
            }

            return null;
        }

        public bool Delete(int id)
        {
            foreach (var Course in _context.Courses)
            {
                if (Course.Id == id)
                {
                    _context.Courses.Remove(Course);

                    return true;
                }
            }

            return false;
        }
    }
}
