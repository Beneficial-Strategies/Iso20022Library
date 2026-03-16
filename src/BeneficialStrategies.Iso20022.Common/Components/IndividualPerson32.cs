// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_bpZkkTheEeamLZQeccJa7w")]
[DisplayName("Individual Person")]
public record IndividualPerson32
{
    /// <summary>
    /// Name by which the party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_cC1YQzheEeamLZQeccJa7w")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Date on which the person is born.
    /// </summary>
    [IsoId("_cC1YRTheEeamLZQeccJa7w")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BirthDate { get; init; }

    /// <summary>
    /// Country and residential status of the individual, for example, non-permanent resident.
    /// </summary>
    [IsoId("_cC1YRzheEeamLZQeccJa7w")]
    [DisplayName("Country And Residential Status")]
    [IsoXmlTag("CtryAndResdtlSts")]
    public CountryAndResidentialStatusType2? CountryAndResidentialStatus { get; init; }

    /// <summary>
    /// Alternative identification, for example, national registration identification number, passport number, or an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    [IsoId("_cC1YSTheEeamLZQeccJa7w")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public ValueList<GenericIdentification164> OtherIdentification { get; init; } = [];
}
