// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.Framework;

/// <summary>
/// Marker for the per-line-item internal event records this package's fan-out consumers publish.
/// Not an ISO 20022 type — purely a MassTransit message-contract convenience so shared code can be
/// written once against this interface instead of against eight near-identical concrete types.
/// </summary>
public interface IIso20022FanOutEvent
{
    /// <summary>The originating raw message's own <c>Header.MessageIdentification</c>.</summary>
    string MessageIdentification { get; }
}
