// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Notification Cancellation Rejection Reason2.
/// </summary>
[IsoId("_E6rONVvFEe6gDOpEK7Q4ig")]
[DisplayName("Notification Cancellation Rejection Reason2")]
public record NotificationCancellationRejectionReason2
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax350Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<RejectionReason11Format1Choice_> Reason { get; init; } = [];
}
