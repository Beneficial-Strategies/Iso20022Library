// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the identification and the creation date of a notification.
/// </summary>
[IsoId("_FZs_JbQYEeeKRKrD60ELBQ")]
[DisplayName("Notification Identification")]
public record NotificationIdentification5
{
    /// <summary>
    /// Unique identifier of the last notification document (message) assigned by the sender of the document.
    /// </summary>
    [IsoId("_FpB0cbQYEeeKRKrD60ELBQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Date and time at which the last notification document (message) was created by the sender.
    /// </summary>
    [IsoId("_FpB0ebQYEeeKRKrD60ELBQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTime2Choice_? CreationDateTime { get; init; }
}
