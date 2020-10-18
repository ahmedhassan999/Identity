using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityTest.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<AdditionalSupport> AdditionalSupport { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerContact> CustomerContact { get; set; }
        public virtual DbSet<Evaluation> Evaluation { get; set; }
        public virtual DbSet<HomeWork> HomeWork { get; set; }
        public virtual DbSet<LearningMethodology> LearningMethodology { get; set; }
        public virtual DbSet<Lesson> Lesson { get; set; }
        public virtual DbSet<LessonQuestion> LessonQuestion { get; set; }
        public virtual DbSet<Objective> Objective { get; set; }
        public virtual DbSet<PraparationDelivery> PraparationDelivery { get; set; }
        public virtual DbSet<PreparationRequest> PreparationRequest { get; set; }
        public virtual DbSet<PreparationRequestType> PreparationRequestType { get; set; }
        public virtual DbSet<PreprationRequestDetailes> PreprationRequestDetailes { get; set; }
        public virtual DbSet<QuestionTarget> QuestionTarget { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<Semester> Semester { get; set; }
        public virtual DbSet<Shipping> Shipping { get; set; }
        public virtual DbSet<Stage> Stage { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Strategy> Strategy { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<Url> Url { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
