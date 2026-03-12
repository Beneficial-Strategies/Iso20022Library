// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransferStatus1Choice
{
    /// <summary>
    /// Status of the transfer is in repair.
    /// </summary>
    [IsoId("_o1CqqxwkEeOIveEnnb_1-A")]
    [DisplayName("In Repair")]
    public partial record InRepair : TransferStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the in-repair status.
        /// </summary>
        [IsoId("_RR_KUdp-Ed-ak6NoX_4Aeg_1346286799")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public required IsoMax350Text Reason { get; init; } 
        
        /// <summary>
        /// Proprietary identification of the reason for the in-repair status.
        /// </summary>
        [IsoId("_RR_KUtp-Ed-ak6NoX_4Aeg_1062766459")]
        [DisplayName("Data Source Scheme")]
        [IsoXmlTag("DataSrcSchme")]
        public required GenericIdentification1 DataSourceScheme { get; init; } 
        
        /// <summary>
        /// Indicates that there is no reason available or to report.
        /// </summary>
        [IsoId("_RR_KU9p-Ed-ak6NoX_4Aeg_1062766424")]
        [DisplayName("No Specified Reason")]
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode NoSpecifiedReason { get; init; } 
        
        
        #nullable disable
        
    }
}
