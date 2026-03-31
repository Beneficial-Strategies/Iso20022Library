// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AgentDocumentIdentificationAndStatus1Choice
{
    /// <summary>
    /// Agent CA Notification Advice Identification And Status.
    /// </summary>
    [DisplayName("Agent CA Notification Advice Identification And Status")]
    public record AgentCANotificationAdviceIdentificationAndStatus
        : AgentDocumentIdentificationAndStatus1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AgtCANtfctnAdvcIdAndSts")]
        public required AgentNotificationIdentificationAndStatus1 Value { get; init; }
    }
}
