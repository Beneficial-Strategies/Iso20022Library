// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PostTradeReport1Choice
{
    /// <summary>Post-trade related data report.</summary>
    [IsoId("_w1AjkGIgEfCeoPFCHQnhvA")]
    [DisplayName("New")]
    public record New : PostTradeReport1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("New")]
        public required PostTradeReport1 Value { get; init; }
    }
}
