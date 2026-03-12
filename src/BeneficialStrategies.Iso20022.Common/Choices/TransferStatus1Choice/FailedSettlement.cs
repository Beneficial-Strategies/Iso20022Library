// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransferStatus1Choice
{
    /// <summary>
    /// Status of the transfer is failed settlement, that is, settlement in the International Central Securities Depository (ICSD) or Central Securities Depository (CSD) failed.
    /// </summary>
    [IsoId("_o1CqrRwkEeOIveEnnb_1-A")]
    [DisplayName("Failed Settlement")]
    public partial record FailedSettlement : TransferStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the failed settlement status.
        /// </summary>
        [IsoId("_RR_KWNp-Ed-ak6NoX_4Aeg_1532242482")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public required IsoMax350Text Reason { get; init; } 
        
        /// <summary>
        /// Proprietary identification of the reason for the failed settlement status.
        /// </summary>
        [IsoId("_RR_KWdp-Ed-ak6NoX_4Aeg_1532242756")]
        [DisplayName("Data Source Scheme")]
        [IsoXmlTag("DataSrcSchme")]
        public required GenericIdentification1 DataSourceScheme { get; init; } 
        
        /// <summary>
        /// Indicates that there is no reason available or to report.
        /// </summary>
        [IsoId("_RR_KWtp-Ed-ak6NoX_4Aeg_2124998939")]
        [DisplayName("No Specified Reason")]
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode NoSpecifiedReason { get; init; } 
        
        
        #nullable disable
        
    }
}
