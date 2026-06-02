// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification and status corporate action notification cancellation request sent by the agent.
/// </summary>
[IsoId("4a6116d2-b2ee-409f-85db-51032b983fe9")]
[DisplayName("Agent Notification Cancellation Identification And Status2")]
public record AgentNotificationCancellationIdentificationAndStatus2
{
    /// <summary>
    /// Unique identification of the document.
    /// </summary>
    [IsoId("c540e535-3ef8-407a-9b2c-c8a6f5a478e9")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Date/time of the creation of the document.
    /// </summary>
    [IsoId("250b0b22-8fb8-4265-bda2-35b8eb25590e")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Status of the corporate action cancellation request sent by the agent.
    /// </summary>
    [IsoId("0e7dd7a2-d588-49b7-9606-aa52b6ffad8a")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required NotificationCancellationRequestStatus2Choice Status { get; init; }
}
