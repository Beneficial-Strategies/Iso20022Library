// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimCancellationRequestStatus1Choice
{
    /// <summary>
    /// Provides status information related to a cancellation request rejected for further processing due to system (data) reasons.
    /// </summary>
    [IsoId("_1Tcqadx4EeqESbVR5AloZQ")]
    [DisplayName("Rejected")]
    public partial record Rejected : MarketClaimCancellationRequestStatus1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectedStatus38Choice_ Value { get; init; }
    }
}
