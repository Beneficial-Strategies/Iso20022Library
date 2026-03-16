// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details an individual country including its name and country code.
/// </summary>
[IsoId("_lv3_EYAMEeaYeOsLN4966A")]
[DisplayName("Securities Country Identification")]
public record SecuritiesCountryIdentification2
{
    /// <summary>
    /// Two character country code and country name as per ISO 3166.
    /// </summary>
    [IsoId("_l7Ja8YAMEeaYeOsLN4966A")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCodeAndName3 Country { get; init; }

    /// <summary>
    /// Flag which reflects if the country is a member of the EEA (European Economic Area) or not.
    /// </summary>
    [IsoId("_l7Ja84AMEeaYeOsLN4966A")]
    [DisplayName("EEA Country")]
    [IsoXmlTag("EEACtry")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator EEACountry { get; init; }

    /// <summary>
    /// Modification status for the record compared to the previous report.
    /// </summary>
    [IsoId("_l7Ja9YAMEeaYeOsLN4966A")]
    [DisplayName("Modification")]
    [IsoXmlTag("Mod")]
    public Modification1Code? Modification { get; init; }

    /// <summary>
    /// Details the validity of the specific record.
    /// </summary>
    [IsoId("_l7Ja94AMEeaYeOsLN4966A")]
    [DisplayName("Validity Period")]
    [IsoXmlTag("VldtyPrd")]
    public required Period4Choice_ ValidityPeriod { get; init; }

    /// <summary>
    /// Date when this record was last modified.
    /// </summary>
    [IsoId("_l7Ja-YAMEeaYeOsLN4966A")]
    [DisplayName("Last Updated")]
    [IsoXmlTag("LastUpdtd")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LastUpdated { get; init; }
}
