// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferCancellationRejectedStatus1Choice
{
    /// <summary>
    /// Reason of the rejected status.
    /// </summary>
    [IsoId("_U0fAs9p-Ed-ak6NoX_4Aeg_1742304027")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : TransferCancellationRejectedStatus1Choice_
    {
        /// <summary>
        /// Reason for a rejected status in structured form.
        /// </summary>
        [IsoId("_U0fAttp-Ed-ak6NoX_4Aeg_1814337906")]
        [DisplayName("Structured")]
        [IsoXmlTag("Strd")]
        public required CancellationRejectedReason1Code Structured { get; init; }

        /// <summary>
        /// Additional information about the reason for the rejected status in textual form.
        /// </summary>
        [IsoId("_U0fAt9p-Ed-ak6NoX_4Aeg_1814337864")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
