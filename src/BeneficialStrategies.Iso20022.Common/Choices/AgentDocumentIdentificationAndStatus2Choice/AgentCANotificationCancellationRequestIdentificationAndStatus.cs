// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AgentDocumentIdentificationAndStatus2Choice
{
    /// <summary>Identification of the linked Agent CA Notification Cancellation Request for which a status is given.</summary>
    [IsoId("f32375ec-55d1-45cd-83a6-b96133925c9c")]
    [DisplayName("Agent CA Notification Cancellation Request Identification And Status")]
    public record AgentCANotificationCancellationRequestIdentificationAndStatus : AgentDocumentIdentificationAndStatus2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AgtCANtfctnCxlReqIdAndSts")]
        public required AgentNotificationCancellationIdentificationAndStatus2 Value { get; init; }
    }
}
