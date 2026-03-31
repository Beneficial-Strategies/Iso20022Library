// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TimeFrame8Choice
{
    /// <summary>
    /// Number of days after the trade date (T) for the standard settlement timeframe.
    /// </summary>
    [IsoId("_cB3nQzgFEei6RvewLQWEqw")]
    [DisplayName("Trade Plus")]
    public record TradePlus : TimeFrame8Choice_
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
