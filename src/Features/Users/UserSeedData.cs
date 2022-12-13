﻿namespace DentallApp.Features.Users;

public static class UserSeedData
{
    private const string BasicUserEmail  = "basic_user@hotmail.com";
    private const string SecretaryEmail  = "secretary@hotmail.com";
    private const string DentistEmail    = "dentist@hotmail.com";
    private const string AdminEmail      = "admin@hotmail.com";
    private const string SuperAdminEmail = "superadmin@hotmail.com";
    private const string Password        = "$2a$10$60QnEiafBCLfVBMfQkExVeolyBxVHWcSQKTvkxVJj9FUozRpRP/GW";

    public static void CreateDefaultUserAccounts(this ModelBuilder builder, IWebHostEnvironment env)
    {
        if (!env.IsDevelopment())
            return;

        CreateBasicUserAccount(builder);
        CreateSecretaryAccount(builder);
        CreateDentistAccount(builder);
        CreateAdminAccount(builder);
        CreateSuperAdminAccount(builder);
    }

    private static void CreateBasicUserAccount(ModelBuilder builder)
    {
        builder.Entity<Person>()
               .AddSeedData(
                    new Person
                    {
                        Id = 1,
                        Document = "0923611701",
                        Names = "Roberto Emilio",
                        LastNames = "Placencio Pinto",
                        CellPhone = "0998994332",
                        Email = BasicUserEmail,
                        DateBirth = new DateTime(1999, 08, 27),
                        GenderId = GendersId.Male,
                    }
               );
        builder.Entity<User>()
               .AddSeedData(
                    new User
                    {
                        Id = 1,
                        UserName = BasicUserEmail,
                        Password = Password,
                        PersonId = 1
                    }
               );
        builder.Entity<UserRole>()
               .AddSeedData(
                    new UserRole
                    {
                        Id = 1,
                        UserId = 1,
                        RoleId = RolesId.BasicUser
                    }
               );
    }

    private static void CreateSecretaryAccount(ModelBuilder builder)
    {
        builder.Entity<Person>()
               .AddSeedData(
                    new Person
                    {
                        Id = 2,
                        Document = "0923611702",
                        Names = "María Consuelo",
                        LastNames = "Rodríguez Valencia",
                        CellPhone = "0998994333",
                        Email = SecretaryEmail,
                        DateBirth = new DateTime(1999, 07, 25),
                        GenderId = GendersId.Female,
                    }
               );
        builder.Entity<User>()
               .AddSeedData(
                    new User
                    {
                        Id = 2,
                        UserName = SecretaryEmail,
                        Password = Password,
                        PersonId = 2
                    }
               );
        builder.Entity<Employee>()
               .AddSeedData(
                    new Employee
                    {
                        Id = 1,
                        UserId = 2,
                        PersonId = 2,
                        OfficeId = 1,
                        PregradeUniversity = "UG",
                        PostgradeUniversity = "ESPOL"
                    }
               );
        builder.Entity<UserRole>()
               .AddSeedData(
                    new UserRole
                    {
                        Id = 2,
                        UserId = 2,
                        RoleId = RolesId.Secretary
                    }
               );
    }

    private static void CreateDentistAccount(ModelBuilder builder)
    {
        builder.Entity<Person>()
               .AddSeedData(
                    new Person
                    {
                        Id = 3,
                        Document = "0923611703",
                        Names = "Guillermo Oswaldo",
                        LastNames = "Rodríguez Rivera",
                        CellPhone = "0998994334",
                        Email = DentistEmail,
                        DateBirth = new DateTime(1999, 07, 21),
                        GenderId = GendersId.Male,
                    }
               );
        builder.Entity<User>()
               .AddSeedData(
                    new User
                    {
                        Id = 3,
                        UserName = DentistEmail,
                        Password = Password,
                        PersonId = 3
                    }
               );
        builder.Entity<Employee>()
               .AddSeedData(
                    new Employee
                    {
                        Id = 2,
                        UserId = 3,
                        PersonId = 3,
                        OfficeId = 1,
                        PregradeUniversity = "UG",
                        PostgradeUniversity = "ESPOL"
                    }
               );
        builder.Entity<UserRole>()
               .AddSeedData(
                    new UserRole
                    {
                        Id = 3,
                        UserId = 3,
                        RoleId = RolesId.Dentist
                    }
               );
    }

    private static void CreateAdminAccount(ModelBuilder builder)
    {
        builder.Entity<Person>()
               .AddSeedData(
                    new Person
                    {
                        Id = 4,
                        Document = "0923611704",
                        Names = "Jean Carlos",
                        LastNames = "Figueroa Lopéz",
                        CellPhone = "0998994335",
                        Email = AdminEmail,
                        DateBirth = new DateTime(1999, 09, 15),
                        GenderId = GendersId.Male,
                    }
               );
        builder.Entity<User>()
               .AddSeedData(
                    new User
                    {
                        Id = 4,
                        UserName = AdminEmail,
                        Password = Password,
                        PersonId = 4
                    }
               );
        builder.Entity<Employee>()
               .AddSeedData(
                    new Employee
                    {
                        Id = 3,
                        UserId = 4,
                        PersonId = 4,
                        OfficeId = 1,
                        PregradeUniversity = "UG",
                        PostgradeUniversity = "ESPOL"
                    }
               );
        builder.Entity<UserRole>()
               .AddSeedData(
                    new UserRole
                    {
                        Id = 4,
                        UserId = 4,
                        RoleId = RolesId.Admin
                    }
               );
    }

    private static void CreateSuperAdminAccount(ModelBuilder builder)
    {
        builder.Entity<Person>()
               .AddSeedData(
                    new Person
                    {
                        Id = 5,
                        Document = "0923611705",
                        Names = "David Sebastian",
                        LastNames = "Román Amariles",
                        CellPhone = "0998994336",
                        Email = SuperAdminEmail,
                        DateBirth = new DateTime(1999, 08, 27),
                        GenderId = GendersId.Male,
                    }
               );
        builder.Entity<User>()
               .AddSeedData(
                    new User
                    {
                        Id = 5,
                        UserName = SuperAdminEmail,
                        Password = Password,
                        PersonId = 5
                    }
               );
        builder.Entity<Employee>()
               .AddSeedData(
                    new Employee
                    {
                        Id = 4,
                        UserId = 5,
                        PersonId = 5,
                        OfficeId = 1,
                        PregradeUniversity = "UG",
                        PostgradeUniversity = "ESPOL"
                    }
               );
        builder.Entity<UserRole>()
               .AddSeedData(
                    new UserRole
                    {
                        Id = 5,
                        UserId = 5,
                        RoleId = RolesId.Superadmin
                    }
               );
    }
}
