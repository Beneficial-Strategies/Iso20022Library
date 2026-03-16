// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an identification of a person.
/// </summary>
[IsoId("_P_4pRtp-Ed-ak6NoX_4Aeg_-893603485")]
[DisplayName("Generic Person Identification")]
public record GenericPersonIdentification1
{
    /// <summary>
    /// Unique and unambiguous identification of a person.
    /// </summary>
    [IsoId("_P_4pR9p-Ed-ak6NoX_4Aeg_-740298453")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    [IsoId("_QACaQNp-Ed-ak6NoX_4Aeg_2131347934")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    public PersonIdentificationSchemeName1Choice_? SchemeName { get; init; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_QACaQdp-Ed-ak6NoX_4Aeg_-740298392")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
