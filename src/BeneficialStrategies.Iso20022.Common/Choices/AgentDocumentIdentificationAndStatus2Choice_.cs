// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the Identification and status of the corporate action notification advice or the notification cancellation request sent by the agent.
    /// </summary>
    [KnownType(typeof(AgentDocumentIdentificationAndStatus2Choice.AgentCANotificationAdviceIdentificationAndStatus))]
    [KnownType(typeof(AgentDocumentIdentificationAndStatus2Choice.AgentCANotificationCancellationRequestIdentificationAndStatus))]
    [JsonDerivedType(typeof(AgentDocumentIdentificationAndStatus2Choice.AgentCANotificationAdviceIdentificationAndStatus), nameof(AgentDocumentIdentificationAndStatus2Choice.AgentCANotificationAdviceIdentificationAndStatus))]
    [JsonDerivedType(typeof(AgentDocumentIdentificationAndStatus2Choice.AgentCANotificationCancellationRequestIdentificationAndStatus), nameof(AgentDocumentIdentificationAndStatus2Choice.AgentCANotificationCancellationRequestIdentificationAndStatus))]
    [IsoId("4c6dcfc0-1a9a-48f7-a6b5-ff1367607aa5")]
    [DisplayName("AgentDocumentIdentificationAndStatus2Choice")]
    public abstract record AgentDocumentIdentificationAndStatus2Choice_ { }
}
