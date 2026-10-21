// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.ReservationIdentification4.Valid;

/// <summary>Valid samples of <c>Standard</c> of <c>ReservationIdentification4</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>Standard</c> of <c>ReservationIdentification4</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static IReservationIdentification4 Minimal =>
        IsoDataFactory.Make<IReservationIdentification4>(b2 => b2
                    .Set(x2 => x2.Type).To(Samples.ReservationType2Choice.Valid.Code.Minimal));
}
