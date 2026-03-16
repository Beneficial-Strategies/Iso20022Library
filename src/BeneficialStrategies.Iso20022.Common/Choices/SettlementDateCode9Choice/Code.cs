// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementDateCode9Choice
{
    /// <summary>
    /// Settlement date expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5TGUvZNLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : SettlementDateCode9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the date of settlement, in coded form.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementDate4Code Value { get; init; }
    }
}
