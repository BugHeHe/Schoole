using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Mo.Models
{
    public partial class SchoolContext : DbContext
    {
        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<Chapter> Chapter { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<ClassSchedule> ClassSchedule { get; set; }
        public virtual DbSet<CreaditXi> CreaditXi { get; set; }
        public virtual DbSet<Credit> Credit { get; set; }
        public virtual DbSet<Da> Da { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<HaveaTalk> HaveaTalk { get; set; }
        public virtual DbSet<JiaTingZhuang> JiaTingZhuang { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Module> Module { get; set; }
        public virtual DbSet<Paper> Paper { get; set; }
        public virtual DbSet<PaperCount> PaperCount { get; set; }
        public virtual DbSet<PaperRule> PaperRule { get; set; }
        public virtual DbSet<PaperType> PaperType { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<PlatformSystem> PlatformSystem { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Result> Result { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleMenu> RoleMenu { get; set; }
        public virtual DbSet<RoleUser> RoleUser { get; set; }
        public virtual DbSet<RuleDetail> RuleDetail { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StuQueRecord> StuQueRecord { get; set; }
        public virtual DbSet<StuQueRecordDetail> StuQueRecordDetail { get; set; }
        public virtual DbSet<TextBook> TextBook { get; set; }
        public virtual DbSet<TurnOutForWork> TurnOutForWork { get; set; }
        public virtual DbSet<User> User { get; set; }

        // Unable to generate entity type for table 'dbo.PaperDetail'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=CHINA-20181115Q\MSSQLSERVER2;Database=School;uid=sa;pwd=sa");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>(entity =>
            {
                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.AnswerContent)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answer)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Answer__Question__778AC167");
            });

            modelBuilder.Entity<Chapter>(entity =>
            {
                entity.HasIndex(e => e.ChapterName)
                    .HasName("UQ__Chapter__66E6D4A3017C8791")
                    .IsUnique();

                entity.Property(e => e.ChapterId).HasColumnName("ChapterID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.ChapterName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Chapter)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Chapter__BookID__5FB337D6");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasIndex(e => e.ClassName)
                    .HasName("UQ__Class__F8BF561BA9591598")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("date");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.MasterId).HasColumnName("MasterID");

                entity.Property(e => e.TeacharId).HasColumnName("TeacharID");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.Class)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Class__GradeID__5812160E");

                entity.HasOne(d => d.Master)
                    .WithMany(p => p.ClassMaster)
                    .HasForeignKey(d => d.MasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Class__MasterID__5629CD9C");

                entity.HasOne(d => d.Teachar)
                    .WithMany(p => p.ClassTeachar)
                    .HasForeignKey(d => d.TeacharId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Class__TeacharID__571DF1D5");
            });

            modelBuilder.Entity<ClassSchedule>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.CreateTime).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassSchedule)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__ClassSche__Class__628FA481");

                entity.HasOne(d => d.PlaceNavigation)
                    .WithMany(p => p.ClassSchedule)
                    .HasForeignKey(d => d.Place)
                    .HasConstraintName("FK__ClassSche__Place__6383C8BA");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ClassSchedule)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__ClassSche__UserI__6477ECF3");
            });

            modelBuilder.Entity<CreaditXi>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.HasOne(d => d.Credit)
                    .WithMany(p => p.CreaditXi)
                    .HasForeignKey(d => d.CreditId)
                    .HasConstraintName("FK__CreaditXi__Credi__245D67DE");
            });

            modelBuilder.Entity<Credit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Credit)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__Credit__StudentI__2180FB33");
            });

            modelBuilder.Entity<Da>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.PlaceId).HasColumnName("PlaceID");

                entity.Property(e => e.Time).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Da)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__Da__ClassID__6754599E");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.Da)
                    .HasForeignKey(d => d.PlaceId)
                    .HasConstraintName("FK__Da__PlaceID__68487DD7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Da)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Da__UserID__693CA210");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasIndex(e => e.GradeName)
                    .HasName("UQ__Grade__4AA309AA096B0450")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GradeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HaveaTalk>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StuId).HasColumnName("StuID");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Stu)
                    .WithMany(p => p.HaveaTalk)
                    .HasForeignKey(d => d.StuId)
                    .HasConstraintName("FK__HaveaTalk__StuID__1EA48E88");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HaveaTalk)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__HaveaTalk__UserI__1DB06A4F");
            });

            modelBuilder.Entity<JiaTingZhuang>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Guan).HasMaxLength(20);

                entity.Property(e => e.Job).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Zhi).HasMaxLength(50);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.JiaTingZhuang)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__JiaTingZh__Stude__17F790F9");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.View)
                    .IsRequired()
                    .HasColumnName("view")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK__Menu__ModuleID__48CFD27E");
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.HasIndex(e => e.ModuleName)
                    .HasName("UQ__Module__EAC9AEC3DD6E2560")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.View)
                    .IsRequired()
                    .HasColumnName("view")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.PlatformSystem)
                    .WithMany(p => p.Module)
                    .HasForeignKey(d => d.PlatformSystemId)
                    .HasConstraintName("FK__Module__Platform__45F365D3");
            });

            modelBuilder.Entity<Paper>(entity =>
            {
                entity.HasIndex(e => e.PaperName)
                    .HasName("UQ__Paper__88C382086B6D5484")
                    .IsUnique();

                entity.Property(e => e.PaperId).HasColumnName("PaperID");

                entity.Property(e => e.ClassList)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorId).HasColumnName("CreatorID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.PaperName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RuleId).HasColumnName("RuleID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.Paper)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Paper__CreatorID__0D7A0286");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.Paper)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Paper__GradeID__09A971A2");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.Paper)
                    .HasForeignKey(d => d.RuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Paper__RuleID__0B91BA14");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Paper)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Paper__typeID__0A9D95DB");
            });

            modelBuilder.Entity<PaperCount>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.Time).HasColumnType("date");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.PaperCount)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__PaperCoun__Class__6C190EBB");
            });

            modelBuilder.Entity<PaperRule>(entity =>
            {
                entity.HasKey(e => e.RuleId);

                entity.HasIndex(e => e.RuleName)
                    .HasName("UQ__PaperRul__B88BAC0E51A2E8D0")
                    .IsUnique();

                entity.Property(e => e.RuleId).HasColumnName("RuleID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorId).HasColumnName("CreatorID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.RuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.PaperRule)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PaperRule__Creat__7C4F7684");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.PaperRule)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PaperRule__Grade__7B5B524B");
            });

            modelBuilder.Entity<PaperType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.HasIndex(e => e.TypeName)
                    .HasName("UQ__PaperTyp__D4E7DFA8F7670BF0")
                    .IsUnique();

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ__Place__737584F673D0724F")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlatformSystem>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ__Platform__737584F61A49854A")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Creation).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.ChapterId).HasColumnName("ChapterID");

                entity.Property(e => e.CheckId).HasColumnName("CheckID");

                entity.Property(e => e.CheckTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorId).HasColumnName("CreatorID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionTitle)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Question__BookID__6FE99F9F");

                entity.HasOne(d => d.Chapter)
                    .WithMany(p => p.Question)
                    .HasForeignKey(d => d.ChapterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Question__Chapte__70DDC3D8");

                entity.HasOne(d => d.Check)
                    .WithMany(p => p.QuestionCheck)
                    .HasForeignKey(d => d.CheckId)
                    .HasConstraintName("FK__Question__CheckI__73BA3083");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.QuestionCreator)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Question__Creato__71D1E811");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.Property(e => e.ResultId).HasColumnName("ResultID");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.HasOne(d => d.Record)
                    .WithMany(p => p.Result)
                    .HasForeignKey(d => d.RecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Result__RecordID__30C33EC3");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasIndex(e => e.RoleName)
                    .HasName("UQ__Role__8A2B6160846CA8D2")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('未描述')");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoleMenu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.RoleMenu)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK__RoleMenu__MenuId__4CA06362");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleMenu)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__RoleMenu__RoleId__4BAC3F29");
            });

            modelBuilder.Entity<RoleUser>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleUser)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__RoleUser__RoleID__412EB0B6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RoleUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__RoleUser__UserID__4222D4EF");
            });

            modelBuilder.Entity<RuleDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.ChapterId).HasColumnName("ChapterID");

                entity.Property(e => e.RuleId).HasColumnName("RuleID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.RuleDetail)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RuleDetai__BookI__01142BA1");

                entity.HasOne(d => d.Chapter)
                    .WithMany(p => p.RuleDetail)
                    .HasForeignKey(d => d.ChapterId)
                    .HasConstraintName("FK__RuleDetai__Chapt__02084FDA");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.RuleDetail)
                    .HasForeignKey(d => d.RuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RuleDetai__RuleI__00200768");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasIndex(e => e.CardId)
                    .HasName("UQ__Student__55FECD8F159C2C91")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('无')");

                entity.Property(e => e.Borndate).HasColumnType("date");

                entity.Property(e => e.CardId)
                    .IsRequired()
                    .HasColumnName("CardID")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.CreateTime).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinZu).HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.XueLi).HasMaxLength(100);

                entity.Property(e => e.ZhengMian).HasMaxLength(50);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__Student__ClassID__151B244E");
            });

            modelBuilder.Entity<StuQueRecord>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.PaperId).HasColumnName("PaperID");

                entity.Property(e => e.RecordTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StudetnId).HasColumnName("StudetnID");

                entity.HasOne(d => d.Paper)
                    .WithMany(p => p.StuQueRecord)
                    .HasForeignKey(d => d.PaperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StuQueRec__Paper__282DF8C2");

                entity.HasOne(d => d.Studetn)
                    .WithMany(p => p.StuQueRecord)
                    .HasForeignKey(d => d.StudetnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StuQueRec__Stude__2739D489");
            });

            modelBuilder.Entity<StuQueRecordDetail>(entity =>
            {
                entity.HasKey(e => e.RecordDetailId);

                entity.Property(e => e.RecordDetailId).HasColumnName("RecordDetailID");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.StuQueRecordDetail)
                    .HasForeignKey(d => d.AnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StuQueRec__Answe__2DE6D218");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.StuQueRecordDetail)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StuQueRec__Quest__2CF2ADDF");

                entity.HasOne(d => d.Record)
                    .WithMany(p => p.StuQueRecordDetail)
                    .HasForeignKey(d => d.RecordId)
                    .HasConstraintName("FK__StuQueRec__Recor__2BFE89A6");
            });

            modelBuilder.Entity<TextBook>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.HasIndex(e => e.BookName)
                    .HasName("UQ__TextBook__1579D5960E294448")
                    .IsUnique();

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.TextBook)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TextBook__GradeI__5BE2A6F2");
            });

            modelBuilder.Entity<TurnOutForWork>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TurnOutForWork)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__TurnOutFo__Stude__1AD3FDA4");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserCid)
                    .HasName("UQ__User__576B3B6C658262E9")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JoinTime).HasColumnType("date");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserCid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
