// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify a person or an organisation.
/// </summary>
[IsoId("_SknWpQEcEeCQm6a_G2yO_w_1079108132")]
[DisplayName("Party Identification")]
public record PartyIdentification45
{
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_SkxHoAEcEeCQm6a_G2yO_w_101594658")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Party8Choice_? Identification { get; init; }

    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_SkxHoQEcEeCQm6a_G2yO_w_1724426142")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address.
    /// </summary>
    [IsoId("_SkxHogEcEeCQm6a_G2yO_w_916289268")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public PostalAddress6? PostalAddress { get; init; }

    /// <summary>
    /// Country in which a person resides (the place of a person&apos;s home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_SkxHowEcEeCQm6a_G2yO_w_-1714903540")]
    [DisplayName("Country Of Residence")]
    [IsoXmlTag("CtryOfRes")]
    public CountryCode? CountryOfResidence { get; init; }

    /// <summary>
    /// Contact defined for this party.
    /// </summary>
    [IsoId("_SkxHpAEcEeCQm6a_G2yO_w_765689123")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public ValueList<Contacts3> ContactDetails { get; init; } = [];
}
