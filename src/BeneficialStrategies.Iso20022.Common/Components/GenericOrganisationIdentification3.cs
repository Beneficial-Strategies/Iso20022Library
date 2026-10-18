// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGenericOrganisationIdentification3"/>
[IsoId("_bM2KRzFIEe651u5xu3f5iw")]
[DisplayName("Generic Organisation Identification3")]
public partial record GenericOrganisationIdentification3
{
    /// <inheritdoc cref="IGenericOrganisationIdentification3.Identification"/>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax256Text Identification { get; init; }

    /// <inheritdoc cref="IGenericOrganisationIdentification3.Issuer"/>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public IsoMax35Text? Issuer { get; init; }

    /// <inheritdoc cref="IGenericOrganisationIdentification3.SchemeName"/>
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    public OrganisationIdentificationSchemeName1Choice_? SchemeName { get; init; }
}
