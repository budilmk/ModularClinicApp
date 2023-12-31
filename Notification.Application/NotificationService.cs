﻿
using SlotManagement.Services;
using Microsoft.Extensions.Logging;

namespace Notification.Module
{
    public class NotificationService : INotificationService
    {
        private readonly ILogger<NotificationService> _logger;
        private readonly ISlotService _slotService;
        public NotificationService(ISlotService slotService, ILogger<NotificationService> logger)
        {
            _slotService = slotService;
            _logger = logger;
        }

        public async Task CreateNotification(string patientName, Guid slotId)
        {
            _logger.LogInformation("Patient Name: ${PatientName}", patientName);
            _logger.LogInformation("Doctor Name: " + _slotService.GetDoctorNameBySlotId(slotId));
            _logger.LogInformation("Appointment Time: ${Time}", _slotService.GetAppointmentTimeBySlotId(slotId));

        }

   

    }
}