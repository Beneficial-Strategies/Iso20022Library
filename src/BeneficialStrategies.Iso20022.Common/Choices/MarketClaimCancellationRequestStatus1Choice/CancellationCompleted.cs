// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimCancellationRequestStatus1Choice
{
    /// <summary>
    /// Provides status information related to an instruction cancellation request that is completed.
    /// </summary>
    [IsoId("_1TcqbNx4EeqESbVR5AloZQ")]
    [DisplayName("Cancellation Completed")]
    public record CancellationCompleted : MarketClaimCancellationRequestStatus1Choice_ { }
}
