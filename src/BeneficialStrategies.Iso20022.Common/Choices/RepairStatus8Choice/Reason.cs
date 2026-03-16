// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepairStatus8Choice
{
    /// <summary>
    /// Specifies the reason of the repair status.
    /// </summary>
    [IsoId("_0ka00glIEeGATtfOBToyew_709869042")]
    [DisplayName("Reason")]
    public record Reason : RepairStatus8Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction/request has a repair status.
        /// </summary>
        [IsoId("_0kH54wlIEeGATtfOBToyew_829965227")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RepairReason1Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_0kH55AlIEeGATtfOBToyew_1562911088")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
