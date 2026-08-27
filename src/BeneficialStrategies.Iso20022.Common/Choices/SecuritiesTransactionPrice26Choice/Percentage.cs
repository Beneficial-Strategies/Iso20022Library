// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice26Choice
{
    /// <summary>Price expressed as a rate, that is a percentage.</summary>
    [IsoId("_HT_WE62kEfCfRtNoJv1jFQ")]
    [DisplayName("Percentage")]
    public record Percentage : SecuritiesTransactionPrice26Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Pctg")]
        public required IsoPercentageRate Value { get; init; }
    }
}
