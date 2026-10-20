// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.AcknowledgementDetails1Choice.Valid;

/// <summary>Valid samples of the <c>PayInScheduleReference</c> variant of <c>AcknowledgementDetails1Choice</c>.</summary>
public static class PayInScheduleReference
{
    /// <summary>The PayInScheduleReference variant of <c>AcknowledgementDetails1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.AcknowledgementDetails1Choice.IPayInScheduleReference Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.AcknowledgementDetails1Choice.IPayInScheduleReference>(b => b
                .Set(x => x.Value).To("PIS-001"));
}
