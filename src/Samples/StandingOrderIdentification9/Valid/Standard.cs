// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.StandingOrderIdentification9.Valid;

/// <summary>Valid samples of <c>Standard</c> of <c>StandingOrderIdentification9</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>Standard</c> of <c>StandingOrderIdentification9</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static IStandingOrderIdentification9 Minimal =>
        IsoDataFactory.Make<IStandingOrderIdentification9>(b2 => b2
                .Set(x2 => x2.Account).To(Samples.CashAccount40.Valid.Standard.Minimal));
}
