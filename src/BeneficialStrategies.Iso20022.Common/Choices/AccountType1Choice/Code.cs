// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountType1Choice
{
    /// <summary>
    /// Type of account expressed as a code.
    /// </summary>
    [IsoId("_o7Y0gBc8EeK5g-3oYI0_9Q")]
    [DisplayName("Code")]
    public record Code : AccountType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the cash account type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FundCashAccount3Code Value { get; init; }
    }
}
