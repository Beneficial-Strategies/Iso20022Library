// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity54Choice
{
    /// <summary>
    /// Quantity of financial instrument in units, original face amount or current face amount.
    /// </summary>
    [IsoId("_peZb-Ti7Eeydid5dcNPKvg")]
    [DisplayName("Quantity")]
    public partial record Quantity : Quantity54Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Qty")]
        public required FinancialInstrumentQuantity36Choice_ Value { get; init; }
    }
}
