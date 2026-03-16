// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlingCapacity8Choice
{
    /// <summary>
    /// Settlement capacity expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5m5ai5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : SettlingCapacity8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role of the party in the settlement of the transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlingCapacity2Code Value { get; init; }
    }
}
