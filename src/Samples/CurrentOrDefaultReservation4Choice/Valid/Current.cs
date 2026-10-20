// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.CurrentOrDefaultReservation4Choice.Valid;

/// <summary>Valid samples of <c>Current</c> of <c>CurrentOrDefaultReservation4Choice</c>.</summary>
public static class Current
{
    /// <summary>A valid <c>Current</c> of <c>CurrentOrDefaultReservation4Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.CurrentOrDefaultReservation4Choice.ICurrent Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.CurrentOrDefaultReservation4Choice.ICurrent>(b => b
                .Set(x => x.Value).To(BeneficialStrategies.Iso20022.Samples.ReservationIdentification4.Valid.Standard.Minimal));
}
