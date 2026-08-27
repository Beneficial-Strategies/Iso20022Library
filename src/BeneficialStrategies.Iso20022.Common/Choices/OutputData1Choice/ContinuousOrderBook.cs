// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OutputData1Choice
{
    /// <summary>Data related to the continuous order books for the pre-trade output report.</summary>
    [IsoId("_YDzX8GIZEfCeoPFCHQnhvA")]
    [DisplayName("Continuous Order Book")]
    public record ContinuousOrderBook : OutputData1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("CntnsOrdrBook")]
        public required ContinuousOrderBookData1 Value { get; init; }
    }
}
