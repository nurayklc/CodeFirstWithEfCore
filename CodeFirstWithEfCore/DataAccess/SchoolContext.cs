﻿using CodeFirstWithEfCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstWithEfCore.DataAccess
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
