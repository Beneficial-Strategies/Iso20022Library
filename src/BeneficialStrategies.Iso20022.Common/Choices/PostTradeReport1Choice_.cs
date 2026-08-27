// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PostTradeReport1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Post-trade related data report.</summary>
    [IsoId("_esL9AGIgEfCeoPFCHQnhvA")]
    [DisplayName("Post Trade Report 1 Choice")]
    [KnownType(typeof(PostTradeReport1Choice.New))]
    [KnownType(typeof(PostTradeReport1Choice.Cancellation))]
    [JsonDerivedType(typeof(PostTradeReport1Choice.New))]
    [JsonDerivedType(typeof(PostTradeReport1Choice.Cancellation))]
    public abstract record PostTradeReport1Choice_
    {
    }
}
