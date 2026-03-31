// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// References a related message or provides another reference, such as a pool reference, linking a set of messages. The party which issued the related reference may be the Sender of the referenced message or a party other than the Sender.
/// </summary>
[IsoId("_WIFWkNp-Ed-ak6NoX_4Aeg_-788758749")]
[DisplayName("Additional Reference")]
public record AdditionalReference5
{
    /// <summary>
    /// Business reference of a message assigned by the party issuing the message. This reference must be unique amongst all messages of the same name sent by the same party.
    /// </summary>
    [IsoId("_WIFWkdp-Ed-ak6NoX_4Aeg_-788758718")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoRestrictedFINMax16Text Reference { get; init; }

    /// <summary>
    /// Name of a message.
    /// </summary>
    [IsoId("_WIFWktp-Ed-ak6NoX_4Aeg_-788758410")]
    [DisplayName("Message Name")]
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public IsoRestrictedFINMax15Text? MessageName { get; init; }
}
