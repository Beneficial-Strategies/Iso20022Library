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
[IsoId("_Ezqs8DtsEemIf7eyjCwinw")]
[DisplayName("Party Identification")]
public record PartyIdentification217
{
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_ZI12UztsEemIf7eyjCwinw")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public required PersonName3 NameAndAddress { get; init; }

    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_ZI12VDtsEemIf7eyjCwinw")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; }

    /// <summary>
    /// Natural person identification details.
    /// </summary>
    [IsoId("_ZI12VTtsEemIf7eyjCwinw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required NaturalPersonIdentification1 Identification { get; init; }

    /// <summary>
    /// Nationality of the person.
    /// </summary>
    [IsoId("_Bx0hAX1hEemTjI54yVVOfw")]
    [DisplayName("Nationality")]
    [IsoXmlTag("Ntlty")]
    public CountryCode? Nationality { get; init; }

    /// <summary>
    /// Date on which and place at which a person is born.
    /// </summary>
    [IsoId("_hnbAoX1hEemTjI54yVVOfw")]
    [DisplayName("Date And Place Of Birth")]
    [IsoXmlTag("DtAndPlcOfBirth")]
    public DateAndPlaceOfBirth2? DateAndPlaceOfBirth { get; init; }

    /// <summary>
    /// Type of investor.
    /// </summary>
    [IsoId("_Y7oMQIk1EemZteIrPMIV3g")]
    [DisplayName("Investor Type")]
    [IsoXmlTag("InvstrTp")]
    public InvestorType1Choice_? InvestorType { get; init; }

    /// <summary>
    /// Provides information about the ownership on an asset.
    /// </summary>
    [IsoId("_xi5zwYz1EemXJvzC2Wyt1g")]
    [DisplayName("Ownership")]
    [IsoXmlTag("Ownrsh")]
    public Ownership1? Ownership { get; init; }
}
