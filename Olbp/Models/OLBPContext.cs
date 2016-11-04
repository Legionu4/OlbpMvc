using System.Data.Entity;
using WebApplication9.Models;

namespace Olbp.Models
{
    public class OlbpContext:DbContext
    {
        public OlbpContext()
            : base("OLBPContext")
        {
        }
        public virtual DbSet<AbrilBarcodes> AbrilBarcodes { get; set; }
        public virtual DbSet<AbrilBarcodesetting> AbrilBarcodesetting { get; set; }
        //public virtual DbSet<AdditionalData> AdditionalData { get; set; }
        public virtual DbSet<ArmConfig> ArmConfig { get; set; }
        public virtual DbSet<ArmFieldConfigs> ArmFieldConfigs { get; set; }
        public virtual DbSet<ArmFieldNames> ArmFieldNames { get; set; }
        public virtual DbSet<Buildings> Buildings { get; set; }
        public virtual DbSet<Configuration> Configuration { get; set; }
        public virtual DbSet<Cpz> Cpz { get; set; }
        public virtual DbSet<DescriptionIds> DescriptionIds { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<ExternalService> ExternalService { get; set; }
        public virtual DbSet<ExtServiceUser> ExtServiceUser { get; set; }
        public virtual DbSet<ExtUserToOlbpUser> ExtUserToOlbpUser { get; set; }
        public virtual DbSet<FilesStats> FilesStats { get; set; }
        public virtual DbSet<FinanceSetttings> FinanceSetttings { get; set; }
        public virtual DbSet<Indexes> Indexes { get; set; }
        public virtual DbSet<Organisations> Organisations { get; set; }
        public virtual DbSet<Payers> Payers { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<PlAccounts> PlAccounts { get; set; }
        public virtual DbSet<PlCity> PlCity { get; set; }
        public virtual DbSet<PlatTemplateFields> PlatTemplateFields { get; set; }
        public virtual DbSet<PlatTemplates> PlatTemplates { get; set; }
        public virtual DbSet<Plats> Plats { get; set; }
        public virtual DbSet<PlatsTmp> PlatsTmp { get; set; }
        public virtual DbSet<PsopParams> PsopParams { get; set; }
        public virtual DbSet<ReducedPayers> ReducedPayers { get; set; }
        public virtual DbSet<Reestrs> Reestrs { get; set; }
        public virtual DbSet<ReestrsTemplates> ReestrsTemplates { get; set; }
        public virtual DbSet<ReestrsTmp> ReestrsTmp { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<ResendType> ResendType { get; set; }
        public virtual DbSet<RpayerLinks> RpayerLinks { get; set; }
        public virtual DbSet<ServGroup> ServGroup { get; set; }
        public virtual DbSet<ServGroupLinks> ServGroupLinks { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Streets> Streets { get; set; }
        public virtual DbSet<Tarifs> Tarifs { get; set; }
        public virtual DbSet<TempFieldToFunc> TempFieldToFunc { get; set; }
        public virtual DbSet<TemplateFieldAliases> TemplateFieldAliases { get; set; }
        public virtual DbSet<TemplateFields> TemplateFields { get; set; }
        public virtual DbSet<TemplateFunc> TemplateFunc { get; set; }
        public virtual DbSet<Templates> Templates { get; set; }
        public virtual DbSet<TemplatesType> TemplatesType { get; set; }
        public virtual DbSet<TerminalPayments> TerminalPayments { get; set; }
        public virtual DbSet<Terminals> Terminals { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersToServiceGroups> UsersToServiceGroups { get; set; }
        //public virtual DbSet<AbrilBarcodes> AbrilBarcodes { get; set; }
        //public virtual DbSet<AdditionalData> AdditionalData { get; set; }
        //public virtual DbSet<A> arm_config { get; set; }
        public virtual DbSet<Counters> Counters { get; set; }
        public virtual DbSet<FilesStatsTmp> FilesStatsTmp { get; set; }
        public virtual DbSet<LocalisationToCity> LocalisationToCity { get; set; }
        public virtual DbSet<NewPaymentsTmp> NewPaymentsTmp { get; set; }
        public virtual DbSet<OrgToCity> OrgToCity { get; set; }
        public virtual DbSet<PaymentBarcodes> PaymentBarcodes { get; set; }
        public virtual DbSet<PaymentsArchive> PaymentsArchive { get; set; }
        public virtual DbSet<PaymentsEdit> PaymentsEdit { get; set; }
        public virtual DbSet<PaymentsTmp> PaymentsTmp { get; set; }
        public virtual DbSet<PlannerConfigs> PlannerConfigs { get; set; }
        public virtual DbSet<PlannerLog> PlannerLog { get; set; }
        public virtual DbSet<ReportDefaults> ReportDefaults { get; set; }
        public virtual DbSet<ServicesToCity> ServicesToCity { get; set; }
        public virtual DbSet<UserToIndex> UserToIndex { get; set; }
        public virtual DbSet<UserToSpeedCodes> UserToSpeedCodes { get; set; }
    }
}