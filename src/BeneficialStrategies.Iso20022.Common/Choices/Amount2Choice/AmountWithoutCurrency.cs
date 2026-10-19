// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Amount2Choice
{
    /// <summary>
    /// Number of monetary units specified in a currency where the unit of currency is implied by the context.
    /// </summary>
    [IsoId("_75DzlaMgEeCJ6YNENx4h-w_-106626338")]
    [DisplayName("Amount Without Currency")]
    public partial record AmountWithoutCurrency : Amount2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AmtWthtCcy")]
        public required ImpliedCurrencyAndAmount Value { get; init; }
    }
}
