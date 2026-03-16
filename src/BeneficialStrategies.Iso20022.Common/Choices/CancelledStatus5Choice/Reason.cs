// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancelledStatus5Choice
{
    /// <summary>
    /// Reason for the cancellation status.
    /// </summary>
    [IsoId("_5Piv0CzbEeOsiuMH68so7Q")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : CancelledStatus5Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction is cancelled.
        /// </summary>
        [IsoId("_-7YZ0SzyEeOsiuMH68so7Q")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required CancellationReason17Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_-7YZ2SzyEeOsiuMH68so7Q")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
