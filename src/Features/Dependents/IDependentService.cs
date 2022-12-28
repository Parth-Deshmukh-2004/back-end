﻿namespace DentallApp.Features.Dependents;

public interface IDependentService
{
    Task<Response<DtoBase>> CreateDependentAsync(int userId, DependentInsertDto dependentDto);
    Task<Response> RemoveDependentAsync(int dependentId, int userId);
    Task<Response> UpdateDependentAsync(int dependentId, int userId, DependentUpdateDto dependentDto);
}
