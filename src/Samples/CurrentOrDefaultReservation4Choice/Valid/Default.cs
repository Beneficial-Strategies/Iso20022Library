// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.CurrentOrDefaultReservation4Choice.Valid;

/// <summary>Valid samples of <c>Default</c> of <c>CurrentOrDefaultReservation4Choice</c>.</summary>
public static class Default
{
    /// <summary>A valid <c>Default</c> of <c>CurrentOrDefaultReservation4Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.CurrentOrDefaultReservation4Choice.IDefault Minimal =>
        IsoDataFactory.Make<Choices.CurrentOrDefaultReservation4Choice.IDefault>(b => b
                .Set(x => x.Value).To(Samples.ReservationIdentification4.Valid.Standard.Minimal));
}
