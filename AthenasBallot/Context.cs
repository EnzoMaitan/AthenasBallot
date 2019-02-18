using AthenasBallot.Classes.Entities;
using Microsoft.EntityFrameworkCore;

namespace AthenasBallot
{
    public class Context : DbContext
    {
        public DbSet<Ballot> Ballots { get; private set; }
        public DbSet<BallotRegistry> BallotRegistries { get; private set; }
        public DbSet<Candidate> Candidates { get; private set; }
        public DbSet<CandidateProcess> CandidateProcesses { get; private set; }
        public DbSet<Party> Parties { get; private set; }
        public DbSet<Process> Processes { get; private set; }
        public DbSet<Voter> Voters { get; private set; }
        public DbSet<SystemOperator> SystemOperators { get; private set; }
        public DbSet<VoteRegistry> VoteRegistries { get; private set; }

        // public DbSet<User> Users { get; private set; }
        // public DbSet<Student> Students { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<CandidateProcess>()
                .HasKey(cp => new { cp.CandidateID, cp.ProcessID });

            modelBuilder
                .Entity<VoteRegistry>()
                .HasKey(vr => vr.Id);

            modelBuilder
                .Entity<BallotRegistry>()
                .HasKey(br => br.Id);

            modelBuilder
                .Entity<SystemOperator>()
                .HasDiscriminator<Role>("role");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Enzo\Documents\AthenasBallotDB.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
