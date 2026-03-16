// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Account10Choice
{
    /// <summary>
    /// Charges Account.
    /// </summary>
    [DisplayName("Charges Account")]
    public record ChargesAccount : Account10Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ChrgsAcct")]
        public required CashAccountIdentification5Choice_ Value { get; init; }
    }
}
