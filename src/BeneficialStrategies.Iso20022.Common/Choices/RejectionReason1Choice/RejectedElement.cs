// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectionReason1Choice
{
    /// <summary>
    /// Specifies a rejection reason for each individual element of a report.
    /// </summary>
    [IsoId("_RJ8ootp-Ed-ak6NoX_4Aeg_1044987769")]
    [DisplayName("Rejected Element")]
    public partial record RejectedElement : RejectionReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Sequence number that allows to easily identify the element that is rejected.
        /// </summary>
        [IsoId("_RJy3ptp-Ed-ak6NoX_4Aeg_-1803784041")]
        [DisplayName("Element Sequence Number")]
        [IsoXmlTag("ElmtSeqNb")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber ElementSequenceNumber { get; init; } 
        
        /// <summary>
        /// Reason for rejecting an individual element.
        /// </summary>
        [IsoId("_RJy3p9p-Ed-ak6NoX_4Aeg_1481340627")]
        [DisplayName("Individual Rejection Reason")]
        [IsoXmlTag("IndvRjctnRsn")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        public required IsoMax140Text IndividualRejectionReason { get; init; } 
        
        
        #nullable disable
        
    }
}
