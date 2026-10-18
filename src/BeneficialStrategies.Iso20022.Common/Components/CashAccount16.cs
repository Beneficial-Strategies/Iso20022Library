// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICashAccount16"/>
[IsoId("_SOfO0dp-Ed-ak6NoX_4Aeg_-1249068086")]
[DisplayName("Cash Account")]
public partial record CashAccount16
{
    /// <inheritdoc cref="ICashAccount16.Identification"/>
    [IsoId("_SOfO0tp-Ed-ak6NoX_4Aeg_-1205661377")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification4Choice_ Identification { get; init; }

    /// <inheritdoc cref="ICashAccount16.Type"/>
    [IsoId("_SOfO09p-Ed-ak6NoX_4Aeg_-1249067501")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType2? Type { get; init; }

    /// <inheritdoc cref="ICashAccount16.Currency"/>
    [IsoId("_SOfO1Np-Ed-ak6NoX_4Aeg_-1249068056")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; }

    /// <inheritdoc cref="ICashAccount16.Name"/>
    [IsoId("_SOfO1dp-Ed-ak6NoX_4Aeg_-1249068025")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }
}
