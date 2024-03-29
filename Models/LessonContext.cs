﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace IFNMUSiteCore.Models
{
    public class LessonContext : DbContext
    {
        public DbSet<Week> Weeks { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<ScheduleDay> ScheduleDays { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Chair> Chairs { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Graphic> Graphics { get; set; }

             
        public LessonContext(DbContextOptions<LessonContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Answer>()
                .HasOne(p => p.Question)
                .WithMany(t => t.Answers)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}