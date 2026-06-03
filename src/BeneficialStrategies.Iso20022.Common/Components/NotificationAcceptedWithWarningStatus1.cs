// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides accepted with warning status information for a notification advice.
/// </summary>
[IsoId("_rZVzIaUeEfCnE_wCEfCqTA")]
[DisplayName("Notification Accepted With Warning Status1")]
public record NotificationAcceptedWithWarningStatus1
{
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_rgwpwaUeEfCnE_wCEfCqTA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required AcceptedWithWarningStatus1Format1Choice_ Status { get; init; }

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_rgwpw6UeEfCnE_wCEfCqTA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
