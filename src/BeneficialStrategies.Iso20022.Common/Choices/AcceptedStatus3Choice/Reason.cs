// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcceptedStatus3Choice
{
    /// <summary>
    /// Reason for the accepted status.
    /// </summary>
    [IsoId("_OkfuqSqAEeO3oOoGGWHH4A")]
    [DisplayName("Reason")]
    public record Reason : AcceptedStatus3Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction or instruction cancellation has been accepted.
        /// </summary>
        [IsoId("_O72esyqAEeO3oOoGGWHH4A")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required AcceptedReason3Choice_ ReasonCode { get; init; }

        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_O72euyqAEeO3oOoGGWHH4A")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
