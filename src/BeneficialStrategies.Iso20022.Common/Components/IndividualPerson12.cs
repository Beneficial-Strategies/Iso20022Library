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
[IsoId("_QB0i99p-Ed-ak6NoX_4Aeg_-1844077400")]
[DisplayName("Individual Person")]
public record IndividualPerson12
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QB0i-Np-Ed-ak6NoX_4Aeg_-1844077382")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_QB-T8Np-Ed-ak6NoX_4Aeg_-1844077365")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BirthDate { get; init; }

    /// <summary>
    /// Country and residential status of an individual, for example, non-pernament resident.
    /// </summary>
    [IsoId("_QB-T8dp-Ed-ak6NoX_4Aeg_-1844077075")]
    [DisplayName("Country And Residential Status")]
    [IsoXmlTag("CtryAndResdtlSts")]
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; }

    /// <summary>
    /// Alternative identification, for example, national registration identification number, passport number, or an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    [IsoId("_QB-T8tp-Ed-ak6NoX_4Aeg_-1844077056")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public GenericIdentification11? OtherIdentification { get; init; }
}
