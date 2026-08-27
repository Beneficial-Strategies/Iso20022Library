// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PreTradeOutputReport1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Pre-trade input related data report.</summary>
    [IsoId("_OT79MGIVEfCeoPFCHQnhvA")]
    [DisplayName("Pre Trade Output Report 1 Choice")]
    [KnownType(typeof(PreTradeOutputReport1Choice.New))]
    [KnownType(typeof(PreTradeOutputReport1Choice.Cancellation))]
    [JsonDerivedType(typeof(PreTradeOutputReport1Choice.New))]
    [JsonDerivedType(typeof(PreTradeOutputReport1Choice.Cancellation))]
    public abstract record PreTradeOutputReport1Choice_
    {
    }
}
