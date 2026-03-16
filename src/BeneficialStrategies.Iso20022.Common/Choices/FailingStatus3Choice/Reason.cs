// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FailingStatus3Choice
{
    /// <summary>
    /// Specifies the reason of the FailingStatus.
    /// </summary>
    [IsoId("_vU-igf7qEeCvPoRGOxRobQ")]
    [DisplayName("Reason")]
    public record Reason : FailingStatus3Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction has a failing status.
        /// </summary>
        [IsoId("_72NnoxqEEeG38P9Gj2JZJw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required FailingReason3Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_72NnrRqEEeG38P9Gj2JZJw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
