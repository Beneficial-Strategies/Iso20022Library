// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimCancellationRequestStatus1Choice
{
    /// <summary>
    /// Provides status information related to a pending cancellation request.
    /// </summary>
    [IsoId("_1Tcqa9x4EeqESbVR5AloZQ")]
    [DisplayName("Pending Cancellation")]
    public record PendingCancellation : MarketClaimCancellationRequestStatus1Choice_ { }
}
