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
[IsoId("_QB0i8dp-Ed-ak6NoX_4Aeg_-1580790160")]
[DisplayName("Individual Person")]
public record IndividualPerson9
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QB0i8tp-Ed-ak6NoX_4Aeg_-1573405523")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_QB0i89p-Ed-ak6NoX_4Aeg_-1573405499")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BirthDate { get; init; }

    /// <summary>
    /// Country and residential status of an individual, for example, non-pernament resident.
    /// </summary>
    [IsoId("_QB0i9Np-Ed-ak6NoX_4Aeg_-1573405482")]
    [DisplayName("Country And Residential Status")]
    [IsoXmlTag("CtryAndResdtlSts")]
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; }

    /// <summary>
    /// Beneficial owner or its designated agent certifies that it complies with any holding or investment restrictions or requirements of the fund.
    /// </summary>
    [IsoId("_QB0i9dp-Ed-ak6NoX_4Aeg_-1238166753")]
    [DisplayName("Beneficiary Certification Completion")]
    [IsoXmlTag("BnfcryCertfctnCmpltn")]
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; }

    /// <summary>
    /// Alternative identification, for example, national registration identification number, passport number, or an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    [IsoId("_QB0i9tp-Ed-ak6NoX_4Aeg_-1573405463")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public ValueList<GenericIdentification11> OtherIdentification { get; init; } = [];
}
