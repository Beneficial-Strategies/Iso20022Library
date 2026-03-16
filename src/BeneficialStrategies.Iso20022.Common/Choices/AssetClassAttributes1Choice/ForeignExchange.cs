// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassAttributes1Choice
{
    /// <summary>
    /// Asset class is a non-financial instrument of type foreign exchange.
    /// </summary>
    [IsoId("_id4oJu94EeW7gabYEJmWIA")]
    [DisplayName("Foreign Exchange")]
    public record ForeignExchange : AssetClassAttributes1Choice_
    {
        /// <summary>
        /// Underlying currency 2 of the currency pair (the currency 1 will be populated in the notional currency).
        /// </summary>
        [IsoId("_BDX3g8nZEeWpf-ImB_F2gQ")]
        [DisplayName("Other Notional Currency")]
        [IsoXmlTag("OthrNtnlCcy")]
        public required ActiveOrHistoricCurrencyCode OtherNotionalCurrency { get; init; }
    }
}
