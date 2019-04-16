﻿using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendee>()
                .HasIndex(a => a.UserName)
                .IsUnique();

            modelBuilder.Entity<Session>()
                .Ignore(s => s.Duration);

            modelBuilder.Entity<ConferenceAttendee>()
                .HasKey(ca => new { ca.ConferenceID, ca.AttendeeID });

            modelBuilder.Entity<SessionSpeaker>()
                .HasKey(ss => new { ss.SessionId, ss.SpeakerId });

            modelBuilder.Entity<SessionTag>()
                .HasKey(st => new { st.SessionID, st.TagID });
        }

        public DbSet<Conference> Conferences { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<Track> Tracks { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Speaker> Speakers { get; set; }

        public DbSet<Attendee> Attendees { get; set; }
    }
}
