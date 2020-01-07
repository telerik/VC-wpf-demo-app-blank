using Service;

namespace UniversityWPF.ViewModels
{
    public class InputsViewModel
    {
        private IStudentService _studentService;
        private ITeacherService _teacherService;

        public InputsViewModel(IStudentService studentService,
                               ITeacherService teacherService)
        {
            _studentService = studentService;
            _teacherService = teacherService;
        }
    }
}
