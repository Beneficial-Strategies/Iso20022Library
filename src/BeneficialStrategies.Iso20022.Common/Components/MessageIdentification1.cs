// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a message by a unique identifier and the date and time when the message was created by the sender.
/// </summary>
[IsoId("_Q7pG5Np-Ed-ak6NoX_4Aeg_-967008570")]
[DisplayName("Message Identification")]
public record MessageIdentification1
{
    /// <summary>
    /// Identification of the message.
    /// </summary>
    [IsoId("_Q7pG5dp-Ed-ak6NoX_4Aeg_-936532675")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Date of creation of the message.
    /// </summary>
    [IsoId("_Q7pG5tp-Ed-ak6NoX_4Aeg_761825361")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }
}
