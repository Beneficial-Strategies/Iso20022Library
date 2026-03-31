// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentAggregateBalance1Choice
{
    /// <summary>
    /// Balance of holdings.
    /// </summary>
    [IsoId("_oI2KMaCCEeOEyO7fCl8lLA")]
    [DisplayName("Holding Balance")]
    [IsoXmlTag("HldgBal")]
    public record HoldingBalance : FinancialInstrumentAggregateBalance1Choice_
    {
        /// <summary>
        /// Balance of settled transactions.
        /// </summary>
        [IsoId("_aA5_KqCCEeOEyO7fCl8lLA")]
        [DisplayName("Settled Balance")]
        [IsoXmlTag("SttldBal")]
        public FinancialInstrumentQuantity1Choice_? SettledBalance { get; init; }

        /// <summary>
        /// Balance of settled transactions and transactions pending settlement.
        /// </summary>
        [IsoId("_aA5_KaCCEeOEyO7fCl8lLA")]
        [DisplayName("Traded Balance")]
        [IsoXmlTag("TraddBal")]
        public FinancialInstrumentQuantity1Choice_? TradedBalance { get; init; }

        /// <summary>
        /// Breakdown of the balances of holdings into sub-balances.
        /// </summary>
        [IsoId("_aA5_K6CCEeOEyO7fCl8lLA")]
        [DisplayName("Balance Breakdown")]
        [IsoXmlTag("BalBrkdwn")]
        public SubBalanceBreakdown1? BalanceBreakdown { get; init; }
    }
}
