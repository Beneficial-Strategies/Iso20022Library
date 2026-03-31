// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus25Choice
{
    /// <summary>
    /// Specifies the reason of the cancellation status.
    /// </summary>
    [IsoId("_65Na8ffUEeiNZp_PtLohLw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : CancellationStatus25Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction is cancelled.
        /// </summary>
        [IsoId("_65Na__fUEeiNZp_PtLohLw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required CancellationReason37Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_65NbB_fUEeiNZp_PtLohLw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }
    }
}
