// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGenericFinancialIdentification1"/>
[IsoId("_QALkM9p-Ed-ak6NoX_4Aeg_-2141717394")]
[DisplayName("Generic Financial Identification")]
public partial record GenericFinancialIdentification1
{
    /// <inheritdoc cref="IGenericFinancialIdentification1.Identification"/>
    [IsoId("_QALkNNp-Ed-ak6NoX_4Aeg_-2141717392")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <inheritdoc cref="IGenericFinancialIdentification1.SchemeName"/>
    [IsoId("_QALkNdp-Ed-ak6NoX_4Aeg_-2141717054")]
    [DisplayName("Scheme Name")]
    [IsoXmlTag("SchmeNm")]
    public FinancialIdentificationSchemeName1Choice_? SchemeName { get; init; }

    /// <inheritdoc cref="IGenericFinancialIdentification1.Issuer"/>
    [IsoId("_QALkNtp-Ed-ak6NoX_4Aeg_-2141717116")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
