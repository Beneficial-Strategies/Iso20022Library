// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference to a related message or transaction.
/// </summary>
[IsoId("_CxGKASVIEeWI0orciOKunQ")]
[DisplayName("Additional Reference")]
public record AdditionalReference7
{
    /// <summary>
    /// Reference issued by a party to identify an instruction, transaction or a message.
    /// </summary>
    [IsoId("_DNgZMSVIEeWI0orciOKunQ")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; }

    /// <summary>
    /// Party that issued the reference.
    /// </summary>
    [IsoId("_DNgZMyVIEeWI0orciOKunQ")]
    [DisplayName("Reference Issuer")]
    [IsoXmlTag("RefIssr")]
    public PartyIdentification97Choice_? ReferenceIssuer { get; init; }

    /// <summary>
    /// Name of the message.
    /// </summary>
    [IsoId("_DNgZNSVIEeWI0orciOKunQ")]
    [DisplayName("Message Name")]
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MessageName { get; init; }
}
