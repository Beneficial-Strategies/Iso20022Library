// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.AccountIdentification4Choice.Valid;

/// <summary>Valid samples of the <c>IBAN</c> variant of <c>AccountIdentification4Choice</c>.</summary>
public static class IBAN
{
    /// <summary>The IBAN variant of <c>AccountIdentification4Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IIBAN Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IIBAN>(b => b
                    .Set(x => x.Value).To("DE89370400440532013000"));
}
