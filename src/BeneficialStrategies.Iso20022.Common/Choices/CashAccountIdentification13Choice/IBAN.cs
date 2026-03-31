// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CashAccountIdentification13Choice
{
    /// <summary>
    /// IBAN.
    /// </summary>
    [DisplayName("IBAN")]
    public record IBAN : CashAccountIdentification13Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("IBAN")]
        public required IsoIBAN2007Identifier Value { get; init; }
    }
}
