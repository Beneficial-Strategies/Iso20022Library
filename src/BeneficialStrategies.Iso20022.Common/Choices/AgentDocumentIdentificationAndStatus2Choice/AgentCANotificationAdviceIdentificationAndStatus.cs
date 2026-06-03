// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AgentDocumentIdentificationAndStatus2Choice
{
    /// <summary>Identification of the linked Agent CA Notification Advice for which a status is given.</summary>
    [IsoId("ebcab647-ffac-4281-98fd-0ead226e6af6")]
    [DisplayName("Agent CA Notification Advice Identification And Status")]
    public record AgentCANotificationAdviceIdentificationAndStatus : AgentDocumentIdentificationAndStatus2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AgtCANtfctnAdvcIdAndSts")]
        public required AgentNotificationIdentificationAndStatus2 Value { get; init; }
    }
}
