// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification of an organisation.
/// </summary>
[IsoId("_QACaRdp-Ed-ak6NoX_4Aeg_-322320404")]
[DisplayName("Generic Organisation Identification")]
public record GenericOrganisationIdentification1
{
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    [IsoId("_QACaRtp-Ed-ak6NoX_4Aeg_-322320394")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_QACaR9p-Ed-ak6NoX_4Aeg_324738129")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    public OrganisationIdentificationSchemeName1Choice_? SchemeName { get; init; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_QACaSNp-Ed-ak6NoX_4Aeg_-322320342")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
