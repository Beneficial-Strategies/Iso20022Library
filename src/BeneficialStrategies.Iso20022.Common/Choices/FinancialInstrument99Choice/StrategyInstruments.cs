// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument99Choice
{
    /// <summary>
    /// Strategy Instruments.
    /// </summary>
    [DisplayName("Strategy Instruments")]
    public record StrategyInstruments : FinancialInstrument99Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("StrtgyInstrms")]
        public required IsoISINOct2015Identifier Value { get; init; }
    }
}
