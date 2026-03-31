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
[IsoId("_N4g3EXETEea2e4bzJ8TyEw")]
[DisplayName("Additional Reference")]
public record AdditionalReference9
{
    /// <summary>
    /// Reference identifying a set of messages.
    /// </summary>
    [IsoId("_OeAw03ETEea2e4bzJ8TyEw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; }

    /// <summary>
    /// Issuer of the reference.
    /// </summary>
    [IsoId("_OeAw1XETEea2e4bzJ8TyEw")]
    [DisplayName("Reference Issuer")]
    [IsoXmlTag("RefIssr")]
    public PartyIdentification113? ReferenceIssuer { get; init; }

    /// <summary>
    /// Name of the message.
    /// </summary>
    [IsoId("_OeAw13ETEea2e4bzJ8TyEw")]
    [DisplayName("Message Name")]
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MessageName { get; init; }
}
