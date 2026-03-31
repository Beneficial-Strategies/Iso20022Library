// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Role2Choice
{
    /// <summary>
    /// Role of the party in the activity expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Qwm7lNp-Ed-ak6NoX_4Aeg_-1115232892")]
    [DisplayName("Code")]
    public record Code : Role2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role played by an actor in an investment fund transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentFundRole2Code Value { get; init; }
    }
}
