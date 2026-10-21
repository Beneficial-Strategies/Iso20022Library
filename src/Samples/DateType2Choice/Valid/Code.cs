// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.DateType2Choice.Valid;

/// <summary>Valid samples of <c>Code</c> of <c>DateType2Choice</c>.</summary>
public static class Code
{
    /// <summary>A valid <c>Code</c> of <c>DateType2Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.DateType2Choice.ICode Minimal =>
        IsoDataFactory.Make<Choices.DateType2Choice.ICode>(b => b
                    .Set(x => x.Value).To(ExternalDateType1Code.InvoiceDate));
}
