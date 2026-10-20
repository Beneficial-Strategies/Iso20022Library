// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.StandingOrderIdentification9.Valid;

/// <summary>Valid samples of <c>Standard</c> of <c>StandingOrderIdentification9</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>Standard</c> of <c>StandingOrderIdentification9</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Components.IStandingOrderIdentification9 Minimal =>
        IsoDataFactory.Make<IStandingOrderIdentification9>(b2 => b2
                .Set(x2 => x2.Account).To(BeneficialStrategies.Iso20022.Samples.CashAccount40.Valid.Standard.Minimal));
}
