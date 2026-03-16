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
[IsoId("_qrF5Pc3iEee5nJBZsW8MFQ")]
[DisplayName("Notification Identification")]
public record NotificationIdentification6
{
    /// <summary>
    /// Unique identifier of the last notification document (message) assigned by the sender of the document.
    /// </summary>
    [IsoId("_qrF5P83iEee5nJBZsW8MFQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text Identification { get; init; }

    /// <summary>
    /// Date and time at which the last notification document (message) was created by the sender.
    /// </summary>
    [IsoId("_qrF5R83iEee5nJBZsW8MFQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTime2Choice_? CreationDateTime { get; init; }
}
