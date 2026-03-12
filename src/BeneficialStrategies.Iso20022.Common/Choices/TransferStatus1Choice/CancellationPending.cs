// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransferStatus1Choice
{
    /// <summary>
    /// Status of the transfer is cancellation pending.
    /// </summary>
    [IsoId("_o1CqsBwkEeOIveEnnb_1-A")]
    [DisplayName("Cancellation Pending")]
    public partial record CancellationPending : TransferStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the cancellation pending status.
        /// </summary>
        [IsoId("_RSb2Q9p-Ed-ak6NoX_4Aeg_1032897423")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public required IsoMax350Text Reason { get; init; } 
        
        /// <summary>
        /// Proprietary identification of the reason for the cancellation pending status.
        /// </summary>
        [IsoId("_RSb2RNp-Ed-ak6NoX_4Aeg_1032897458")]
        [DisplayName("Data Source Scheme")]
        [IsoXmlTag("DataSrcSchme")]
        public required GenericIdentification1 DataSourceScheme { get; init; } 
        
        /// <summary>
        /// Indicates that there is no reason available or to report.
        /// </summary>
        [IsoId("_RSb2Rdp-Ed-ak6NoX_4Aeg_997378841")]
        [DisplayName("No Specified Reason")]
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode NoSpecifiedReason { get; init; } 
        
        
        #nullable disable
        
    }
}
