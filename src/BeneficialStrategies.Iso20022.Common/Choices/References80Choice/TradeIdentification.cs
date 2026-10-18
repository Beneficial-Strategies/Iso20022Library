// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References80Choice
{
    /// <inheritdoc cref="ITradeIdentification"/>
    [DisplayName("Trade Identification")]
    public partial record TradeIdentification : References80Choice_
    {
        /// <inheritdoc cref="ITradeIdentification.Value"/>
        [IsoXmlTag("TradId")]
        public required IsoMax35Text Value { get; init; }
    }
}
