using Service;

namespace UniversityWPF.ViewModels
{
    public class SchedulerViewModel
    {
        private IAppointmentService _appointmentService;

        public SchedulerViewModel(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
    }
}
