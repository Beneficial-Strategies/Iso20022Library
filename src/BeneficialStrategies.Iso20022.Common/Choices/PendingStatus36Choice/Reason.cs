// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus36Choice
{
    /// <summary>
    /// Specifies the reason of the pending status.
    /// </summary>
    [IsoId("_kqRn2Tp5EeWVrPy0StzzSg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : PendingStatus36Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction has a pending status.
        /// </summary>
        [IsoId("_lJ0DgTp5EeWVrPy0StzzSg")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required PendingReason26Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_lJ0DiTp5EeWVrPy0StzzSg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
