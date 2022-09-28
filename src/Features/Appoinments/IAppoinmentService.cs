﻿namespace DentallApp.Features.Appoinments;

public interface IAppoinmentService
{
    Task<IEnumerable<AppoinmentGetByBasicUserDto>> GetAppoinmentsByUserIdAsync(int userId);
    Task<Response> CancelBasicUserAppointmentAsync(int appoinmentId, int currentUserId);
    Task<Response> CreateAppoinmentAsync(AppoinmentInsertDto appoinmentInsertDto);
    Task<Response> UpdateAppoinmentAsync(int id, ClaimsPrincipal currentEmployee, AppoinmentUpdateDto appoinmentUpdateDto);
    Task<Response> CancelAppointmentsAsync(ClaimsPrincipal currentEmployee, AppoinmentCancelDto appoinmentCancelDto);
    Task<IEnumerable<AppoinmentGetByEmployeeDto>> GetAppointmentsByOfficeIdAsync(int officeId, AppoinmentPostDateWithDentistDto appoinmentDto);
    Task<IEnumerable<AppoinmentGetByDentistDto>> GetAppointmentsByDentistIdAsync(int dentistId, AppoinmentPostDateDto appoinmentDto);
    Task<IEnumerable<AppoinmentScheduledGetByEmployeeDto>> GetScheduledAppointmentsByOfficeIdAsync(int officeId, AppoinmentPostDateWithDentistDto appoinmentDto);
    Task<IEnumerable<AppoinmentScheduledGetByDentistDto>> GetScheduledAppointmentsByDentistIdAsync(int dentistId, AppoinmentPostDateDto appoinmentDto);
}
