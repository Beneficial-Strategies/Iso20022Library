// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.AcknowledgementDetails1Choice.Valid;

/// <summary>Valid samples of <c>PayInCallReference</c> of <c>AcknowledgementDetails1Choice</c>.</summary>
public static class PayInCallReference
{
    /// <summary>A valid <c>PayInCallReference</c> of <c>AcknowledgementDetails1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.AcknowledgementDetails1Choice.IPayInCallReference Minimal =>
        IsoDataFactory.Make<Choices.AcknowledgementDetails1Choice.IPayInCallReference>(b => b
                .Set(x => x.Value).To("PIC-001"));
}
