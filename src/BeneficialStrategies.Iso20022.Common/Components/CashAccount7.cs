// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICashAccount7"/>
[IsoId("_SOWE5dp-Ed-ak6NoX_4Aeg_1852119759")]
[DisplayName("Cash Account")]
public partial record CashAccount7
{
    /// <inheritdoc cref="ICashAccount7.Identification"/>
    [IsoId("_SOWE5tp-Ed-ak6NoX_4Aeg_-199286992")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification3Choice_ Identification { get; init; }

    /// <inheritdoc cref="ICashAccount7.Type"/>
    [IsoId("_SOWE59p-Ed-ak6NoX_4Aeg_-1087100330")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType2? Type { get; init; }

    /// <inheritdoc cref="ICashAccount7.Currency"/>
    [IsoId("_SOWE6Np-Ed-ak6NoX_4Aeg_-199287087")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; }

    /// <inheritdoc cref="ICashAccount7.Name"/>
    [IsoId("_SOfO0Np-Ed-ak6NoX_4Aeg_-199287052")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }
}
