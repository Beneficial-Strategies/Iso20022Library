// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus15Choice
{
    /// <summary>
    /// Specifies the reason of the cancellation status.
    /// </summary>
    [IsoId("_MPmoqTs9EeWRTLSN0i0tng")]
    [DisplayName("Reason")]
    public record Reason : CancellationStatus15Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction is cancelled.
        /// </summary>
        [IsoId("_MxX48Ts9EeWRTLSN0i0tng")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required CancellationReason21Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_MxX4-Ts9EeWRTLSN0i0tng")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
