// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.AcknowledgementDetails1Choice.Valid;

/// <summary>Valid samples of the <c>PayInCallReference</c> variant of <c>AcknowledgementDetails1Choice</c>.</summary>
public static class PayInCallReference
{
    /// <summary>The PayInCallReference variant of <c>AcknowledgementDetails1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.AcknowledgementDetails1Choice.IPayInCallReference Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.AcknowledgementDetails1Choice.IPayInCallReference>(b => b
                .Set(x => x.Value).To("PIC-001"));
}
