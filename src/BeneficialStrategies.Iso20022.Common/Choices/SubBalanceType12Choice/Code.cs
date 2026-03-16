// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SubBalanceType12Choice
{
    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    [IsoId("_-w56EznXEeWV5sr121Fc8A")]
    [DisplayName("Code")]
    public record Code : SubBalanceType12Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the securities or investment fund balance.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesBalanceType7Code Value { get; init; }
    }
}
