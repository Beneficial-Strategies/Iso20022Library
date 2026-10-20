// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SubBalanceQuantity5Choice
{
    /// <summary>
    /// Quantity of financial instrument in the sub-balance.
    /// </summary>
    [IsoId("_1BQsY4jvEeONZKAAW4pOaQ")]
    [DisplayName("Quantity")]
    public partial record Quantity : SubBalanceQuantity5Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantity1Choice_ Value { get; init; }
    }
}
