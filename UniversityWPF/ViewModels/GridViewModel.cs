using Service;

namespace UniversityWPF.ViewModels
{
    public class GridViewModel
    {
        private IStudentService _studentService;

        public GridViewModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
    }
}
