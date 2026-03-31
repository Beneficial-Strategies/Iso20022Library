// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SubBalanceType13Choice
{
    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    [IsoId("_5W51-ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : SubBalanceType13Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the securities or investment fund balance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesBalanceType12Code Value { get; init; }
    }
}
