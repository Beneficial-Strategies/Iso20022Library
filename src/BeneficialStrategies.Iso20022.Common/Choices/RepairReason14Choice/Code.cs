// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepairReason14Choice
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a repair or rejection status.
    /// </summary>
    [IsoId("_6P_aD5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : RepairReason14Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the settlement instruction has a repair status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RepairReason4Code Value { get; init; }
    }
}
