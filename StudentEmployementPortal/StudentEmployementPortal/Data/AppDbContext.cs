﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using StudentEmployementPortal.Models;
using System;

namespace StudentEmployementPortal.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Application> Application { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<JobPost> JobPosts { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }

        public DbSet<Referee> Referees { get; set; }
        public DbSet<WorkExperience> WorkExperience { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Faculty> Faculties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*modelBuilder.Entity<JobPost>()
            .HasOne(j => j.Department)
            .WithMany()
            .HasForeignKey(j => j.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<JobPost>()
            .HasOne(j => j.Faculty)
            .WithMany()
            .HasForeignKey(j => j.FacultyId)
            .OnDelete(DeleteBehavior.Restrict);*/

            modelBuilder.Entity<Faculty>().HasData(
                new Faculty { FacultyId = 1, FacultyName = "Faculty of Commerce, Law and Management" },
                new Faculty { FacultyId = 2, FacultyName = "Faculty of Engineering and the Built Environment" },
                new Faculty { FacultyId = 3, FacultyName = "Faculty of Health Sciences" },
                new Faculty { FacultyId = 4, FacultyName = "Faculty of Humanities" },
                new Faculty { FacultyId = 5, FacultyName = "Faculty of Science" }
            );

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "Accountancy", FacultyId = 1 },
                new Department { DepartmentId = 2, DepartmentName = "Business Sciences", FacultyId = 1 },
                new Department { DepartmentId = 3, DepartmentName = "Economics and Finance", FacultyId = 1 },
                new Department { DepartmentId = 4, DepartmentName = "Law", FacultyId = 1 },
                new Department { DepartmentId = 5, DepartmentName = "Wits Business School", FacultyId = 1 },
                new Department { DepartmentId = 6, DepartmentName = "Wits School of Governance", FacultyId = 1 },

                new Department { DepartmentId = 7, DepartmentName = "Architecture and Planning", FacultyId = 2 },
                new Department { DepartmentId = 8, DepartmentName = "Civil & Environmental Engineering", FacultyId = 2 },
                new Department { DepartmentId = 9, DepartmentName = "Chemical & Metallurgical Engineering", FacultyId = 2 },
                new Department { DepartmentId = 10, DepartmentName = "Construction Economics & Management", FacultyId = 2 },
                new Department { DepartmentId = 11, DepartmentName = "Electrical & Information Engineeringg", FacultyId = 2 },
                new Department { DepartmentId = 12, DepartmentName = "Mechanical, Industrial & Aeronautical Engineering", FacultyId = 2 },
                new Department { DepartmentId = 13, DepartmentName = "Mining Engineering", FacultyId = 2 },

                new Department { DepartmentId = 14, DepartmentName = "Anatomical Sciences", FacultyId = 3 },
                new Department { DepartmentId = 15, DepartmentName = "Clinical Medicine", FacultyId = 3 },
                new Department { DepartmentId = 16, DepartmentName = "Oral Health Sciences", FacultyId = 3 },
                new Department { DepartmentId = 17, DepartmentName = "Pathology", FacultyId = 3 },
                new Department { DepartmentId = 18, DepartmentName = "Physiology", FacultyId = 3 },
                new Department { DepartmentId = 19, DepartmentName = "Public Health", FacultyId = 3 },
                new Department { DepartmentId = 20, DepartmentName = "Therapeutic Sciences", FacultyId = 3 },

                new Department { DepartmentId = 21, DepartmentName = "Wits School of Arts", FacultyId = 4 },
                new Department { DepartmentId = 22, DepartmentName = "Wits School of Education", FacultyId = 4 },
                new Department { DepartmentId = 23, DepartmentName = "Human and Community Development", FacultyId = 4 },
                new Department { DepartmentId = 24, DepartmentName = "Literature, Language and Media", FacultyId = 4 },
                new Department { DepartmentId = 25, DepartmentName = "Social Sciences", FacultyId = 4 },

                new Department { DepartmentId = 26, DepartmentName = "Animal, Plant and Environmental Sciences", FacultyId = 5 },
                new Department { DepartmentId = 27, DepartmentName = "Chemistry", FacultyId = 5 },
                new Department { DepartmentId = 28, DepartmentName = "Computer Science and Applied Mathematics", FacultyId = 5 },
                new Department { DepartmentId = 29, DepartmentName = "Geography, Archaeology and Environmental Sciences", FacultyId = 5 },
                new Department { DepartmentId = 30, DepartmentName = "Geosciences", FacultyId = 5 },
                new Department { DepartmentId = 31, DepartmentName = "Mathematics", FacultyId = 5 },
                new Department { DepartmentId = 32, DepartmentName = "Molecular and Cell Biology", FacultyId = 5 },
                new Department { DepartmentId = 33, DepartmentName = "Physics", FacultyId = 5 },
                new Department { DepartmentId = 34, DepartmentName = "Statistics and Actuarial Science", FacultyId = 5 }
            );
        }
    }
}
