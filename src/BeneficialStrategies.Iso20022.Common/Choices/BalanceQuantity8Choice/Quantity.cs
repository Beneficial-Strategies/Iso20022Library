// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceQuantity8Choice
{
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_KuWBoznGEeWV5sr121Fc8A")]
    [DisplayName("Quantity")]
    public partial record Quantity : BalanceQuantity8Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantity1Choice_ Value { get; init; }
    }
}
