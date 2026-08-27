// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PreTradeInputReport1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of a pre-trade input report either as a new report or as a cancellation report.</summary>
    [IsoId("_EasjQGF9EfC07JR6e2JJ-w")]
    [DisplayName("Pre Trade Input Report 1 Choice")]
    [KnownType(typeof(PreTradeInputReport1Choice.New))]
    [KnownType(typeof(PreTradeInputReport1Choice.Cancellation))]
    [JsonDerivedType(typeof(PreTradeInputReport1Choice.New))]
    [JsonDerivedType(typeof(PreTradeInputReport1Choice.Cancellation))]
    public abstract record PreTradeInputReport1Choice_
    {
    }
}
