using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HandsOnEFDbFirst.Entities
{
    public partial class EMIDSDBContext : DbContext
    {
        public EMIDSDBContext()
        {
        }

        public EMIDSDBContext(DbContextOptions<EMIDSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public virtual DbSet<ParticipantList> ParticipantLists { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-4O1D65I\\SQLEXPRESS;database=EMIDSDB;trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptCode)
                    .HasName("dept_pk");

                entity.ToTable("Department");

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Dept_Code")
                    .IsFixedLength(true);

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Dept_Name");
            });

            modelBuilder.Entity<EmployeeDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DeptCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Dept_Code")
                    .IsFixedLength(true);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.DeptCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.DeptCode)
                    .HasConstraintName("FK__EmployeeD__Dept___440B1D61");
            });

            modelBuilder.Entity<ParticipantList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ParticipantList");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OfficialEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParticipantId).HasColumnName("ParticipantID");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__product__DD37D91AFF39208E");

                entity.ToTable("product");

                entity.HasIndex(e => e.Pname, "UQ__product__1FC9734C771E9707")
                    .IsUnique();

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("pid");

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pname");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudId);

                entity.ToTable("Student");

                entity.Property(e => e.StudId).HasColumnName("stud_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.StudEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stud_email");

                entity.Property(e => e.StudFname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stud_fname");

                entity.Property(e => e.StudLname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("stud_lname");

                entity.Property(e => e.TelNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tel_no");
            });

            modelBuilder.Entity<Visit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("visits");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.VisitId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("visit_id");

                entity.Property(e => e.VisitedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("visited_at");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
