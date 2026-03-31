// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus3Choice
{
    /// <summary>
    /// Reason for the pending cancellation status.
    /// </summary>
    [IsoId("_lFW2nQFnEeG2HcWTGfYeDQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : PendingCancellationStatus3Choice_
    {
        /// <summary>
        /// Specifies the reason why the cancellation request is pending.
        /// </summary>
        [IsoId("_lFgAQQFnEeG2HcWTGfYeDQ")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required PendingCancellationReason1Choice_ ReasonCode { get; init; }

        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_lFgASwFnEeG2HcWTGfYeDQ")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
