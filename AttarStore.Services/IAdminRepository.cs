﻿using AttarStore.Entities;

namespace AttarStore.Services
{
    public interface IAdminRepository
    {
        Task<Admin> GetByAdmin(string username);
        Task<string> GetAdminRoleByUsername(string username);
        Task<Admin[]> GetAllAdmins();
        Task<Admin> GetAdminById(int id);
        Task AddAdmin(Admin admin);
        Task UpdateAdminAsync(Admin admin);
        Task<bool> EmailExists(string email);
        Task DeleteAdminAsync(int id);
        Task<Admin> GetByAdminEmail(string email);
        Task<string> UpdateAdminProfileAsync(int adminId, string name, string phoneNumber, string email);
        Task<bool> UpdateAdminPasswordAsync(int adminId, string currentPassword, string newPassword);
    }
}
