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
[IsoId("_RNE1Kdp-Ed-ak6NoX_4Aeg_-577369889")]
[DisplayName("Additional Reference")]
public record AdditionalReference2
{
    /// <summary>
    /// Business reference of a message assigned by the party issuing the message. This reference must be unique amongst all messages of the same name sent by the same party.
    /// </summary>
    [IsoId("_RNE1Ktp-Ed-ak6NoX_4Aeg_-248596875")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; }

    /// <summary>
    /// Issuer of the reference.
    /// </summary>
    [IsoId("_RNE1K9p-Ed-ak6NoX_4Aeg_-248596413")]
    [DisplayName("Reference Issuer")]
    [IsoXmlTag("RefIssr")]
    public PartyIdentification1Choice_? ReferenceIssuer { get; init; }

    /// <summary>
    /// Name of a message.
    /// </summary>
    [IsoId("_RNE1LNp-Ed-ak6NoX_4Aeg_-248596012")]
    [DisplayName("Message Name")]
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MessageName { get; init; }
}
