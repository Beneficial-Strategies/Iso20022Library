// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.CashAccountType2Choice.Valid;

/// <summary>Valid samples of <c>Proprietary</c> of <c>CashAccountType2Choice</c>.</summary>
public static class Proprietary
{
    /// <summary>A valid <c>Proprietary</c> of <c>CashAccountType2Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.CashAccountType2Choice.IProprietary Minimal =>
        IsoDataFactory.Make<Choices.CashAccountType2Choice.IProprietary>(b => b
                    .Set(x => x.Value).To("MYTYPE"));
}
