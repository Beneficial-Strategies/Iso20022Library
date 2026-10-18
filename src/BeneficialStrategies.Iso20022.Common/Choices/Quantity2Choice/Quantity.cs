// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity2Choice
{
    /// <summary>
    /// Quantity of security.
    /// </summary>
    [IsoId("_Q0fWDtp-Ed-ak6NoX_4Aeg_50340271")]
    [DisplayName("Quantity")]
    public partial record Quantity : Quantity2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantity1Choice_ Value { get; init; }
    }
}
