// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.InstrumentReport1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of an instrument report either as a new report or as a cancellation report.</summary>
    [IsoId("_FXkpwGFSEfC91ZUW7iS7ww")]
    [DisplayName("Instrument Report 1 Choice")]
    [KnownType(typeof(InstrumentReport1Choice.New))]
    [KnownType(typeof(InstrumentReport1Choice.Cancellation))]
    [JsonDerivedType(typeof(InstrumentReport1Choice.New))]
    [JsonDerivedType(typeof(InstrumentReport1Choice.Cancellation))]
    public abstract record InstrumentReport1Choice_
    {
    }
}
