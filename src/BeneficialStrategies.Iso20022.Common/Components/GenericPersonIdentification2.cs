// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGenericPersonIdentification2"/>
[IsoId("__Aaz9TFLEe651u5xu3f5iw")]
[DisplayName("Generic Person Identification2")]
public partial record GenericPersonIdentification2
{
    /// <inheritdoc cref="IGenericPersonIdentification2.Identification"/>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax256Text Identification { get; init; }

    /// <inheritdoc cref="IGenericPersonIdentification2.Issuer"/>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public IsoMax35Text? Issuer { get; init; }

    /// <inheritdoc cref="IGenericPersonIdentification2.SchemeName"/>
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    public PersonIdentificationSchemeName1Choice_? SchemeName { get; init; }
}
