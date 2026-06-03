// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification and status of the corporate action notification advice sent by the agent.
/// </summary>
[IsoId("_VT37YaUfEfCnE_wCEfCqTA")]
[DisplayName("Agent Notification Identification And Status2")]
public record AgentNotificationIdentificationAndStatus2
{
    /// <summary>
    /// Unique identification of the document.
    /// </summary>
    [IsoId("_VbdKEaUfEfCnE_wCEfCqTA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Date/time of the creation of the document.
    /// </summary>
    [IsoId("_VbdxIaUfEfCnE_wCEfCqTA")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public IsoISODateTime? CreationDateTime { get; init; }

    /// <summary>
    /// Status of the corporate action notification advice sent by the agent.
    /// </summary>
    [IsoId("_VbdxI6UfEfCnE_wCEfCqTA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required NotificationAdviceStatus4Choice_ Status { get; init; }
}
