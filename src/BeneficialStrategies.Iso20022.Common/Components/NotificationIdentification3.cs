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
[IsoId("_NmlK4UGZEeWqy4niLuXETA")]
[DisplayName("Notification Identification")]
public record NotificationIdentification3
{
    /// <summary>
    /// Unique identifier of the last notification document (message) assigned by the sender of the document.
    /// </summary>
    [IsoId("_N0j8g0GZEeWqy4niLuXETA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Date and time at which the last notification document (message) was created by the sender.
    /// </summary>
    [IsoId("_N0j8i0GZEeWqy4niLuXETA")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeChoice_? CreationDateTime { get; init; }
}
