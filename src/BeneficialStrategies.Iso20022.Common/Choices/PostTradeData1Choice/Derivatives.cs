// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.PostTradeData1Choice
{
    /// <summary>Information related to the post-trade of derivatives.</summary>
    [IsoId("_l0gZ0GI8EfCeoPFCHQnhvA")]
    [DisplayName("Derivatives")]
    public record Derivatives : PostTradeData1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Derivs")]
        public required ExternalPostTradeDerivative1Code Value { get; init; }
    }
}
