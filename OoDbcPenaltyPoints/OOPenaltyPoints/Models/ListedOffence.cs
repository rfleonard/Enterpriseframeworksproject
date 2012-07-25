//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
//using System.ComponentModel.DataAnnotations;
namespace OOPenaltyPoints.Models
{


    [Table(Name = "ListedOffences")]
    public  class ListedOffence
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        //CC - removed LoName
        //[Column(DbType="NOT NULL")]
        //public string LoName { get; set; }
       

        //CC - updated Lo28days and Lo56days
        [Column(DbType = "NULL", CanBeNull = false)]//<-------- NULL
        public int Lo28Days { get; set; }
        [Column(DbType = "NULL", CanBeNull = false)]//<-------- NULL
        public int Lo56days { get; set; }

        //CC - removed LoCourtPoints
        //[Column(DbType = "NOT NULL")]
        //pubic int LoCourtPoints { get; set; }

        //CC - updated LoDesc
        [Column(DbType = "NULL")]
        public string LoDesc { get; set; }

        //CC - updated LoFine28 and LoFine56
        [Column(DbType = "NULL", CanBeNull = false)]//<-------- NULL
        public decimal LoFine28 { get; set; }
        [Column(DbType =  "NULL", CanBeNull = false )] //<-------- NULL
        public decimal LoFine56 { get; set; }
        
        //CC - new fields added
        [Column(DbType = "NULL")]
        public bool LoStatus { get; set; }
        [Column(DbType = "NOT NULL", CanBeNull = false)]
        public System.DateTime LoDateCreated { get; set; }
        [Column(DbType = "NOT NULL", CanBeNull = false)]
        public System.DateTime LoDateLastModified { get; set; }
        [Column(DbType = "NULL")]
        public bool LoMandatoryCourtAppearance { get; set; }

        //CC-commented out Ilits<DriverOffence> relationship
        //1:m
        //[Column(DbType = "NOT NULL")]
        //public virtual IList<DriverOffence> DriverOffences { get; set; }

         public ListedOffence()
        {
        }

        //CC - removed/updated parameters
         public ListedOffence(string _LoDesc, int _Lo28Days, int _Lo56days, decimal _LoFine28, decimal _LoFine56, bool _LoStatus, System.DateTime _LoDateCreated, System.DateTime _LoDateLastModified, bool _LoMandatoryCourtAppearance )
        {
            this.LoDesc=_LoDesc;
            this.Lo28Days =_Lo28Days;
            this.Lo56days=_Lo56days;
            this.LoFine28=_LoFine28;
            this.LoFine56=_LoFine56;
            this.LoStatus = _LoStatus;
            this.LoDateCreated = _LoDateCreated;
            this.LoDateLastModified = _LoDateLastModified;
            this.LoMandatoryCourtAppearance = _LoMandatoryCourtAppearance;
        }
    
    }
}
