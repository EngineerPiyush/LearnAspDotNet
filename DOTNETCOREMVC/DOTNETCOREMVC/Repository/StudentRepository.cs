using ModelInDotNetCore.Models;

namespace ModelInDotNetCore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();
        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel{ rollNo = 1, age = 23, name ="Rajat", city="gaziabad" },
                new StudentModel{ rollNo = 2, age = 24, name ="Rahul", city="bulandshar"},
                new StudentModel{ rollNo = 3, age = 21, name="Abhay", city="Noida"},
                new StudentModel{ rollNo = 4, age = 26, name="SriRam", city="mamura"},
                new StudentModel{ rollNo = 5, age = 22, name="Akansha", city="mamura"}
            };

        }
    }
}
