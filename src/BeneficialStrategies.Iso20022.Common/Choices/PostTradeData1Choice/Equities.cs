// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PostTradeData1Choice
{
    /// <summary>Information related to the post-trade of equities.</summary>
    [IsoId("_DyBGgGIpEfCeoPFCHQnhvA")]
    [DisplayName("Equities")]
    public record Equities : PostTradeData1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Eqts")]
        public required ExternalPostTradeEquity1Code Value { get; init; }
    }
}
