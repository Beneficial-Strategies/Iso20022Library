// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestmentAccountType1Choice
{
    /// <summary>
    /// Investment account type expressed as a code.
    /// </summary>
    [IsoId("_SEzggBdLEeK5g-3oYI0_9Q")]
    [DisplayName("Code")]
    public record Code : InvestmentAccountType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the cash account type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FundCashAccount2Code Value { get; init; }
    }
}
