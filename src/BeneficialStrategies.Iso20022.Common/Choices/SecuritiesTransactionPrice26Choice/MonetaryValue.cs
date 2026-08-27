// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice26Choice
{
    /// <summary>Price expressed as a monetary value.</summary>
    [IsoId("_HT_WEa2kEfCfRtNoJv1jFQ")]
    [DisplayName("Monetary Value")]
    public record MonetaryValue : SecuritiesTransactionPrice26Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("MntryVal")]
        public required AmountAndDirection61 Value { get; init; }
    }
}
