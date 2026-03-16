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
[IsoId("_ow34pfQ0EeqAradXpAelDQ")]
[DisplayName("Party Identification")]
public record PartyIdentification238
{
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_pEXcYfQ0EeqAradXpAelDQ")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public required PersonName3 NameAndAddress { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_pEXcY_Q0EeqAradXpAelDQ")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; }

    /// <summary>
    /// Natural person local identification and type.
    /// </summary>
    [IsoId("_pEXcZfQ0EeqAradXpAelDQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required NaturalPersonIdentification1 Identification { get; init; }

    /// <summary>
    /// Nationality of the person.
    /// </summary>
    [IsoId("_894vEvQ1EeqAradXpAelDQ")]
    [DisplayName("Nationality")]
    [IsoXmlTag("Ntlty")]
    public CountryCode? Nationality { get; init; }

    /// <summary>
    /// Date on which and place at which a born person is born.
    /// </summary>
    [IsoId("_894vE_Q1EeqAradXpAelDQ")]
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    public DateAndPlaceOfBirth2? DateAndPlaceOfBirth { get; init; }
}
