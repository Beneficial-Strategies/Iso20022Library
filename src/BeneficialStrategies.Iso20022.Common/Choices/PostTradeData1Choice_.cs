// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PostTradeData1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Information related to the post-trade related report.</summary>
    [IsoId("_nktjQGIoEfCeoPFCHQnhvA")]
    [DisplayName("Post Trade Data 1 Choice")]
    [KnownType(typeof(PostTradeData1Choice.Bonds))]
    [KnownType(typeof(PostTradeData1Choice.Derivatives))]
    [KnownType(typeof(PostTradeData1Choice.Equities))]
    [JsonDerivedType(typeof(PostTradeData1Choice.Bonds))]
    [JsonDerivedType(typeof(PostTradeData1Choice.Derivatives))]
    [JsonDerivedType(typeof(PostTradeData1Choice.Equities))]
    public abstract record PostTradeData1Choice_
    {
    }
}
