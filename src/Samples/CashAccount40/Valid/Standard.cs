// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.CashAccount40.Valid;

/// <summary>Valid samples of <c>Standard</c> of <c>CashAccount40</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>Standard</c> of <c>CashAccount40</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static ICashAccount40 Minimal =>
        IsoDataFactory.Make<ICashAccount40>(b3 => b3
                    .Set(x3 => x3.Identification).To(Samples.AccountIdentification4Choice.Valid.IBAN.Maximal));
}
