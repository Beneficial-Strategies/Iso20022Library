// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PostTradeData1Choice
{
    /// <summary>Information related to the post-trade of bonds.</summary>
    [IsoId("_03lukGIoEfCeoPFCHQnhvA")]
    [DisplayName("Bonds")]
    public record Bonds : PostTradeData1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Bds")]
        public required ExternalPostTradeBond1Code Value { get; init; }
    }
}
