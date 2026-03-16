// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingSettlementStatusChoice
{
    /// <summary>
    /// Reason for a pending status in the report.
    /// </summary>
    [IsoId("_U1POptp-Ed-ak6NoX_4Aeg_-485496729")]
    [DisplayName("Reason")]
    public record Reason : PendingSettlementStatusChoice_
    {
        /// <summary>
        /// Reason for a settlement pending status in structured form.
        /// </summary>
        [IsoId("_U1YYkdp-Ed-ak6NoX_4Aeg_-913088435")]
        [DisplayName("Structured")]
        [IsoXmlTag("Strd")]
        public required PendingSettlementStatusReason1Code Structured { get; init; }

        /// <summary>
        /// Additional information about the reason for the settlement pending status in textual form.
        /// </summary>
        [IsoId("_U1YYktp-Ed-ak6NoX_4Aeg_-888151424")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
