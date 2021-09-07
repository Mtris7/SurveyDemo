using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test.Entities
{
    public class Survey : BaseEntity
    {
        public string UserID { set; get; }
        public string Come { set; get; }
        public string UseLib { set; get; }
        public string KnowLib { set; get; }
        public string Purpose { set; get; }
        public string Reason { set; get; }
        public string TimeLibOpen { set; get; }
        public string Search { set; get; }
        public string InformationDatabase { set; get; }
        public string SearchDatabase { set; get; }
        public string InformationCategory { set; get; }
        public string ExactlyCategory { set; get; }
        public string InformationWebsite { set; get; }
        public string ExactlyWebsite { set; get; }
        public string SearchWebsite { set; get; }
        public string ReadEffective { set; get; }
        public string BorrowEffective { set; get; }
        public string ReferEffective { set; get; }
        public string InternetEffective { set; get; }
        public string PhotoEffective { set; get; }
        public string DifferentEffective { set; get; }
        public string SpaceReview { set; get; }
        public string SeatReview { set; get; }
        public string RoomReview { set; get; }
        public string DeviceReview { set; get; }
        public string InternetReview { set; get; }
        public string WifiReview { set; get; }
        public string ShelfReview { set; get; }
        public string AdditionReview { set; get; }
        public string DocumentVN { set; get; }
        public string DocumentEN { set; get; }
        public string DocumentJP { set; get; }
        public string DocumentCN { set; get; }
        public string DocumentKP { set; get; }
        public string DocumentDE { set; get; }
        public string ProjectDocument { set; get; }
        public string NewpaperDocument { set; get; }
        public string EbookDocument { set; get; }
        public string UpdateDocument { set; get; }
        public string EffectiveDocument { set; get; }
        public string DifferentDocument { set; get; }
        public string ManageAttitude { set; get; }
        public string ServiceAttitude { set; get; }
        public string DifferentAttitude { set; get; }
        public string ProcessInformation { set; get; }
        public string ProperProcedure { set; get; }
        public string DifferentProcedure { set; get; }
        public string SpeedLink { set; get; }
        public string EffectiveLink { set; get; }
        public string DifferentLink { set; get; }
        public string YourSatisfied { set; get; }
        public string NotSatisfied { set; get; }
        public string Feedback { set; get; }
    }

    public class BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public DateTime CreatedAt { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime UpdatedAt { get; set; }
    }
}

