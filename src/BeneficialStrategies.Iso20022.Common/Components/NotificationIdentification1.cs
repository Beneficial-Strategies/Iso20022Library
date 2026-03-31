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
[IsoId("_Q1YG3Np-Ed-ak6NoX_4Aeg_-1876431609")]
[DisplayName("Notification Identification")]
public record NotificationIdentification1
{
    /// <summary>
    /// Unique identifier of the last notification document (message) assigned by the sender of the document.
    /// </summary>
    [IsoId("_Q1h30Np-Ed-ak6NoX_4Aeg_-1718511350")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Date and time at which the last notification document (message) was created by the sender.
    /// </summary>
    [IsoId("_Q1h30dp-Ed-ak6NoX_4Aeg_-1700042031")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeChoice_? CreationDateTime { get; init; }
}
