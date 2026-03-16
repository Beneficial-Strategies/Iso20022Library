// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestorCapacity5Choice
{
    /// <summary>
    /// Investor capacity expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_5mtMZZNLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : InvestorCapacity5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies the type of investor. The rules that apply to each type of client are different.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Eligibility1Code Value { get; init; }
    }
}
