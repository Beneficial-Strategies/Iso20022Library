// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_VybPpLIGEemux5trsZcCpw")]
[DisplayName("Party Identification")]
public record PartyIdentification225
{
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_VybPp7IGEemux5trsZcCpw")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public required PersonName1 NameAndAddress { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_VybPpbIGEemux5trsZcCpw")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; }

    /// <summary>
    /// Natural person local identification and type.
    /// </summary>
    [IsoId("_VybPprIGEemux5trsZcCpw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public NaturalPersonIdentification1? Identification { get; init; }
}
