// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus3Choice
{
    /// <summary>
    /// Reason for a rejected status in the report.
    /// </summary>
    [IsoId("_U3BXUNp-Ed-ak6NoX_4Aeg_456007921")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : RejectedStatus3Choice_
    {
        /// <summary>
        /// Reason for a rejected status in structured form.
        /// </summary>
        [IsoId("_U3LIVNp-Ed-ak6NoX_4Aeg_431072629")]
        [DisplayName("Structured")]
        [IsoXmlTag("Strd")]
        public required TransferRejectedStatusReason1Code Structured { get; init; }

        /// <summary>
        /// Additional information about the reason for the rejected status in textual form.
        /// </summary>
        [IsoId("_U3LIVdp-Ed-ak6NoX_4Aeg_431072681")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
