// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the identification of the issuer of a security.
/// </summary>
[IsoId("_cD9apbQ0EemI67HK7aviyg")]
[DisplayName("Security Issuer")]
public record SecurityIssuer2
{
    /// <summary>
    /// Legal entity identification of the issuer of the security.
    /// </summary>
    [IsoId("_cIk00bQ0EemI67HK7aviyg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public OrganisationIdentification9Choice_? Identification { get; init; }

    /// <summary>
    /// Jurisdiction of the issuer of the security used as collateral. In case of securities issued by a foreign subsidiary, the jurisdiction of the ultimate parent company shall be reported or, if not known, jurisdiction of the subsidiary.
    /// </summary>
    [IsoId("_cIk007Q0EemI67HK7aviyg")]
    [DisplayName("Jurisdiction Country")]
    [IsoXmlTag("JursdctnCtry")]
    public required CountryCode JurisdictionCountry { get; init; }
}
