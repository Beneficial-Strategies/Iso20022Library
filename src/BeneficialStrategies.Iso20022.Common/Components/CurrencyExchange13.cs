// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICurrencyExchange13"/>
[IsoId("_M5wl0IW7EeiDBOVr6AJAFA")]
[DisplayName("Currency Exchange")]
public partial record CurrencyExchange13
{
    /// <inheritdoc cref="ICurrencyExchange13.SourceCurrency"/>
    [IsoId("_NF4WQYW7EeiDBOVr6AJAFA")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required ActiveCurrencyCode SourceCurrency { get; init; }

    /// <inheritdoc cref="ICurrencyExchange13.TargetCurrency"/>
    [IsoId("_NF4WQ4W7EeiDBOVr6AJAFA")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public required ActiveCurrencyCode TargetCurrency { get; init; }

    /// <inheritdoc cref="ICurrencyExchange13.ExchangeRate"/>
    [IsoId("_NF4WRYW7EeiDBOVr6AJAFA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; }

    /// <inheritdoc cref="ICurrencyExchange13.UnitCurrency"/>
    [IsoId("_NF4WSYW7EeiDBOVr6AJAFA")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public ActiveCurrencyCode? UnitCurrency { get; init; }
}
