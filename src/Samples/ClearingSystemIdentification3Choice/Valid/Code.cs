// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.ClearingSystemIdentification3Choice.Valid;

/// <summary>Valid samples of <c>Code</c> of <c>ClearingSystemIdentification3Choice</c>.</summary>
public static class Code
{
    /// <summary>A valid <c>Code</c> of <c>ClearingSystemIdentification3Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.ClearingSystemIdentification3Choice.ICode Minimal =>
        IsoDataFactory.Make<Choices.ClearingSystemIdentification3Choice.ICode>(b => b
                .Set(x => x.Value).To(ExternalCashClearingSystem1Code.EBAEuro1Step1));
}
