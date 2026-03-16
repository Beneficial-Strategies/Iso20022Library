// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus62Choice
{
    /// <summary>
    /// Specifies the reason of the pending status.
    /// </summary>
    [IsoId("_BjL86QpIEeup4r-PFG2T5Q")]
    [DisplayName("Reason")]
    public record Reason : PendingStatus62Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction has a pending status.
        /// </summary>
        [IsoId("_BwupoQpIEeup4r-PFG2T5Q")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required PendingReason58Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_BwupqQpIEeup4r-PFG2T5Q")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
