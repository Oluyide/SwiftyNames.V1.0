using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SwiftyNames.V1._0.Models
{
    public class NameChanger
    {
        //process1
        [Required]
        [Display(Name = "Country in which you want to apply this change of Name")]
        public string InwhichCountrydoyouwantToApplythisName { get; set; }

        [Required]
        [Display(Name = " Your Present Country")]
        public string YourPresentCountry { get; set; }

        //Process2
        [Required]
        [Display(Name = "Are you Married and seeking to change your maiden name?")]
        public string AreYouMarried { get; set; }
        [Required]
        [Display(Name = "Are you divorce and seeking to change your name back to your maiden name or former married name?")]
        public string Divorcepuporse { get; set; }
        [Required]
        [Display(Name = "Is the purpose of this name change to avoid any court order, legal action,debt od finacial obligation?")]
        public string Legalpuporse { get; set; }
        [Required]
        [Display(Name = "Have you ever been convicted of felony, or are there any criminal proceedings pending against you?")]
        public string haveyoubeenconvicted { get; set; }

        //Process3
        [Required]
        [Display(Name = "Your current name")]
        public string yourcurrentName { get; set; }

        [Required]
        [Display(Name = "Street")]
        public string street { get; set; }
        [Required]
        [Display(Name = "Country")]
        public string country { get; set; }
        [Required]
        [Display(Name = "State")]
        public string State { get; set; }
        [Required]
        [Display(Name = "Personal Phone Number")]
        public string PersonalPhoneNumber { get; set; }

        //Process4
        [Required]
        [Display(Name = "Proposed Name")]
        public string ProposedName { get; set; }

        [Required]
        [Display(Name = "Why are you changing your name")]
        public string WhyAreyouChangingYourName { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Upload Certificate,Affidavit or legal report backing your reason of change of Name")]
        public string UploadCertificates { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Upload ID Card")]
        public string IdCard { get; set; }
        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Please select your preffered leading National Daily(NewsPapers")]
        public string Preffered {get; set;}
        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Please do you want the newspaper deliver to a specific address")]
        public bool DoYouWhatItDelivered { get; set; }
        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Please do you want the newspaper deliver to an Embassy")]
        public bool DoYouWhatItDeliveredAtAnEmbassy { get; set; }
        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Please do you want the newspaper deliver to be delivered outside the Nigeria")]
        //public bool DoYouWhatItDeliveredAtAnEmbassy { get; set; }
        public string DeliveryAddress { get; set; }
       
    }
}