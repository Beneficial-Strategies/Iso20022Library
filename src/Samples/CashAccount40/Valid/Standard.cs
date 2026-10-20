// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.CashAccount40.Valid;

/// <summary>Valid samples of <c>Standard</c> of <c>CashAccount40</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>Standard</c> of <c>CashAccount40</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Components.ICashAccount40 Minimal =>
        IsoDataFactory.Make<ICashAccount40>(b3 => b3
                    .Set(x3 => x3.Identification).To(BeneficialStrategies.Iso20022.Samples.AccountIdentification4Choice.Valid.IBAN.Maximal));
}
