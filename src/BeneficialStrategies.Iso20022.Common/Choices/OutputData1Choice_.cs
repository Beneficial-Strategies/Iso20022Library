// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.OutputData1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Output data related to the pre-trade report.</summary>
    [IsoId("_AINhgGIZEfCeoPFCHQnhvA")]
    [DisplayName("Output Data 1 Choice")]
    [KnownType(typeof(OutputData1Choice.ContinuousOrderBook))]
    [KnownType(typeof(OutputData1Choice.AuctionTradingSystem))]
    [JsonDerivedType(typeof(OutputData1Choice.ContinuousOrderBook))]
    [JsonDerivedType(typeof(OutputData1Choice.AuctionTradingSystem))]
    public abstract record OutputData1Choice_
    {
    }
}
