// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus44Choice
{
    /// <summary>
    /// Reason for the pending status.
    /// </summary>
    [IsoId("_cgn4nZKQEeWHWpTQn1FFVg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : PendingStatus44Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction&apos;s processing is pending.
        /// </summary>
        [IsoId("_cgn4rZKQEeWHWpTQn1FFVg")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required PendingReason35Choice_ ReasonCode { get; init; }

        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_cgn4tZKQEeWHWpTQn1FFVg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
    }
}
