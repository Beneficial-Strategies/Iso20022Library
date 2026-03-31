// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TimeFrame5Choice
{
    /// <summary>
    /// An agreed number of days after the Trade date (T) used to define standard timeframes e.g T+3 settlement period. ||Where = T is the date that the price is applied to a transaction.
    /// </summary>
    [IsoId("_UAew7dp-Ed-ak6NoX_4Aeg_1005709854")]
    [DisplayName("Trade Plus")]
    public record TradePlus : TimeFrame5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as an integer.
        /// </summary>
        [IsoXmlTag("TPlus")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Value { get; init; }
    }
}
