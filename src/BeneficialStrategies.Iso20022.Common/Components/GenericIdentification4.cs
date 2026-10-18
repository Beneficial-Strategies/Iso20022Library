// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGenericIdentification4"/>
[IsoId("_P-sWdNp-Ed-ak6NoX_4Aeg_-1687943043")]
[DisplayName("Generic Identification")]
public partial record GenericIdentification4
{
    /// <inheritdoc cref="IGenericIdentification4.Identification"/>
    [IsoId("_P-sWddp-Ed-ak6NoX_4Aeg_-1304682662")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <inheritdoc cref="IGenericIdentification4.IdentificationType"/>
    [IsoId("_P-sWdtp-Ed-ak6NoX_4Aeg_-1601134417")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text IdentificationType { get; init; }
}
