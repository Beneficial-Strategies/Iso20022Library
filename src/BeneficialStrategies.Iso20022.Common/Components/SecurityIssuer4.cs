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
[IsoId("_F_G3Z8guEeuGrNSsxk3B0A")]
[DisplayName("Security Issuer")]
public record SecurityIssuer4
{
    /// <summary>
    /// Legal entity identification of the issuer of the security.
    /// </summary>
    [IsoId("_GAfXccguEeuGrNSsxk3B0A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public OrganisationIdentification15Choice_? Identification { get; init; }

    /// <summary>
    /// Jurisdiction of the issuer of the security used as collateral. In case of securities issued by a foreign subsidiary, the jurisdiction of the ultimate parent company shall be reported or, if not known, jurisdiction of the subsidiary.
    /// </summary>
    [IsoId("_GAfXc8guEeuGrNSsxk3B0A")]
    [DisplayName("Jurisdiction Country")]
    [IsoXmlTag("JursdctnCtry")]
    public required CountryCode JurisdictionCountry { get; init; }
}
