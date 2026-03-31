// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxCapacityParty5Choice
{
    /// <summary>
    /// Party tax capacity expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5TKlaZNLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : TaxCapacityParty5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the tax role capacity of the instructing party.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxLiability1Code Value { get; init; }
    }
}
