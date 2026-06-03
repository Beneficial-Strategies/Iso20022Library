// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides pending status information for a notification advice.
/// </summary>
[IsoId("_c1zRMaUeEfCnE_wCEfCqTA")]
[DisplayName("Notification Pending Status1")]
public record NotificationPendingStatus1
{
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_c_AQgaUeEfCnE_wCEfCqTA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required PendingStatus1Format1Choice Status { get; init; }

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_c_AQg6UeEfCnE_wCEfCqTA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
