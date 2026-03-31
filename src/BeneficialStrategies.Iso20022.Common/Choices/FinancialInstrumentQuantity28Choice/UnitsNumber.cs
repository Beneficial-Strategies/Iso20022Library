// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity28Choice
{
    /// <summary>
    /// Number of investment fund units redeemed.
    /// </summary>
    [IsoId("_ZipfAThUEeaRwdGFv45qTQ")]
    [DisplayName("Units Number")]
    public record UnitsNumber : FinancialInstrumentQuantity28Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, for example 0.75 or 45.6.
        /// </summary>
        [IsoXmlTag("UnitsNb")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Value { get; init; }
    }
}
