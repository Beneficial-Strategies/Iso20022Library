// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References74Choice
{
    /// <inheritdoc cref="ITradeIdentification"/>
    [IsoId("_SiFNqSgaEey2k_sfZmJz4g")]
    [DisplayName("Trade Identification")]
    public partial record TradeIdentification : References74Choice_
    {
        /// <inheritdoc cref="ITradeIdentification.Value"/>
        [IsoXmlTag("TradId")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52, MinimumLength = 1)]
        public required IsoMax52Text Value { get; init; }
    }
}
