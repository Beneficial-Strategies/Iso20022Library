// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of a notification advice.
/// </summary>
[IsoId("_9oQPEaUoEfCnE_wCEfCqTA")]
[DisplayName("Notification Rejection Reason3")]
public record NotificationRejectionReason3
{
    /// <summary>
    /// The rejection reason.
    /// </summary>
    [IsoId("_9vzBgaUoEfCnE_wCEfCqTA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [MinLength(1)]
    public ValueList<RejectionReason6Format2Choice_> Reason { get; init; } = [];

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_9vzBg6UoEfCnE_wCEfCqTA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
