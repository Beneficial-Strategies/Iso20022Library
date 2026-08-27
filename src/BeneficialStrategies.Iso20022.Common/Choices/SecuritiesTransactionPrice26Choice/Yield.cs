// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice26Choice
{
    /// <summary>Price expressed as a yield.</summary>
    [IsoId("_HT_WFa2kEfCfRtNoJv1jFQ")]
    [DisplayName("Yield")]
    public record Yield : SecuritiesTransactionPrice26Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Yld")]
        public required IsoPercentageRate Value { get; init; }
    }
}
