// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference and reference issuer.
/// </summary>
[IsoId("_y96v4f1QEeixXcHVEYIW2g")]
[DisplayName("Additional Reference")]
public record AdditionalReference12
{
    /// <summary>
    /// Reference issued by a party to identify an instruction, transaction or a message.
    /// </summary>
    [IsoId("_zpXgo_1QEeixXcHVEYIW2g")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoRestrictedFINXMax35Text Reference { get; init; }

    /// <summary>
    /// Issuer of the reference.
    /// </summary>
    [IsoId("_zpXgpf1QEeixXcHVEYIW2g")]
    [DisplayName("Reference Issuer")]
    [IsoXmlTag("RefIssr")]
    public PartyIdentification192? ReferenceIssuer { get; init; }

    /// <summary>
    /// Name of the message.
    /// </summary>
    [IsoId("_zpXgp_1QEeixXcHVEYIW2g")]
    [DisplayName("Message Name")]
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoRestrictedFINXMax35Text? MessageName { get; init; }
}
