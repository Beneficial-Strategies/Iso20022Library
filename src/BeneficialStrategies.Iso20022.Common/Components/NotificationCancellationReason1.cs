// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the cancellation request.
/// </summary>
[IsoId("_32GNkSv_Eey3nPxW-HgLUw")]
[DisplayName("Notification Cancellation Reason")]
public record NotificationCancellationReason1
{
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_4LsqIyv_Eey3nPxW-HgLUw")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification135? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the cancellation.
    /// </summary>
    [IsoId("_4LsqJSv_Eey3nPxW-HgLUw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public NotificationCancellationReason1Choice_? Reason { get; init; }

    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_4LsqJyv_Eey3nPxW-HgLUw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
