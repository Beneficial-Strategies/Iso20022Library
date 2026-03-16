// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Generic Person Identification2.
/// </summary>
[IsoId("__Aaz9TFLEe651u5xu3f5iw")]
[DisplayName("Generic Person Identification2")]
public record GenericPersonIdentification2
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax256Text Identification { get; init; }

    /// <summary>
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public IsoMax35Text? Issuer { get; init; }

    /// <summary>
    /// Scheme Name.
    /// </summary>
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    public PersonIdentificationSchemeName1Choice_? SchemeName { get; init; }
}
