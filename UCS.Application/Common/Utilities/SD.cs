


using UCS.Domain.Entities;
namespace UCS.Application.Common.Utilities
{
    public class SD
    {
        public const string Role_Admin = "Admin";
        public const string Role_Professor = "Professor";
        public const string Role_Student = "Student";

        public static long GenerateUMID(IEnumerable<Student> allStudents)
        {
            long ans = 99000000;
            while (allStudents.Any(u=> u.UniqueMemberId == ans)){
                ans++;
            }
            return ans;
        }
    }
}
