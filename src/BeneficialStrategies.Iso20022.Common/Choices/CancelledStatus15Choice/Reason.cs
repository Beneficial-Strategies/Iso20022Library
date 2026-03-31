// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancelledStatus15Choice
{
    /// <summary>
    /// Reason for the cancelled status.
    /// </summary>
    [IsoId("_cgnRoZKQEeWHWpTQn1FFVg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : CancelledStatus15Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction or instruction cancellation has been cancelled.
        /// </summary>
        [IsoId("_cgnRsZKQEeWHWpTQn1FFVg")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required CancelledReason11Choice_ ReasonCode { get; init; }

        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_cgnRuZKQEeWHWpTQn1FFVg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
    }
}
