// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Account12Choice
{
    /// <summary>
    /// Tax Account.
    /// </summary>
    [DisplayName("Tax Account")]
    public record TaxAccount : Account12Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("TaxAcct")]
        public required CashAccountIdentification6Choice_ Value { get; init; }
    }
}
