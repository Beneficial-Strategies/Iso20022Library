// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.AccountSchemeName1Choice.Valid;

/// <summary>Valid samples of the <c>Code</c> variant of <c>AccountSchemeName1Choice</c>.</summary>
public static class Code
{
    /// <summary>The Code variant of <c>AccountSchemeName1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.AccountSchemeName1Choice.ICode Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.AccountSchemeName1Choice.ICode>(b => b
                    .Set(x => x.Value).To(ExternalAccountIdentification1Code.BBANIdentifier));
}
