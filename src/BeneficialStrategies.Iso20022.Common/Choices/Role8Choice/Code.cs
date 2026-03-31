// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Role8Choice
{
    /// <summary>
    /// Role of the party in the activity expressed as a code.
    /// </summary>
    [IsoId("_h6lO0dyREeqKxsvOxFQHKA")]
    [DisplayName("Code")]
    public record Code : Role8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role of the party.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentFundRole8Code Value { get; init; }
    }
}
