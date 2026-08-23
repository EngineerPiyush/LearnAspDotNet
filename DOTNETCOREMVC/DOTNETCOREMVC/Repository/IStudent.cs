using ModelInDotNetCore.Models;

namespace ModelInDotNetCore.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();
        StudentModel getStudentById(int id);
    }
}
