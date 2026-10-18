// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxAuthorisation1"/>
[IsoId("_Pc3bx9p-Ed-ak6NoX_4Aeg_-197973580")]
[DisplayName("Tax Authorisation")]
public partial record TaxAuthorisation1
{
    /// <inheritdoc cref="ITaxAuthorisation1.Title"/>
    [IsoId("_Pc3byNp-Ed-ak6NoX_4Aeg_-197973519")]
    [DisplayName("Title")]
    [IsoXmlTag("Titl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Title { get; init; }

    /// <inheritdoc cref="ITaxAuthorisation1.Name"/>
    [IsoId("_PdBMwNp-Ed-ak6NoX_4Aeg_-197973549")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }
}
