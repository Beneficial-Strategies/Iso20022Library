// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus8Choice
{
    /// <summary>
    /// Reason for the pending cancellation status.
    /// </summary>
    [IsoId("_86aTe5wtEeazcsnODTksnQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : PendingCancellationStatus8Choice_
    {
        /// <summary>
        /// Specifies the reason why the cancellation request is pending.
        /// </summary>
        [IsoId("_86aTjZwtEeazcsnODTksnQ")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required PendingCancellationReason6Choice_ ReasonCode { get; init; }

        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_86aTlZwtEeazcsnODTksnQ")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
    }
}
