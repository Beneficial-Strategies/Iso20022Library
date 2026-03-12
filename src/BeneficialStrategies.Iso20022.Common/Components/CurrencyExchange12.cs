// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the set of elements used to provide details of the currency exchange.
/// </summary>
[IsoId("_m_LIkCYNEei7VPGVFTQkxA")]
[DisplayName("Currency Exchange")]
public partial record CurrencyExchange12
{
    #nullable enable
    
    /// <summary>
    /// Specifies the currency from which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_m_LIkiYNEei7VPGVFTQkxA")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required ActiveOrHistoricCurrencyCode SourceCurrency { get; init; } 
    
    /// <summary>
    /// Specifies the currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_m_LvoyYNEei7VPGVFTQkxA")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public required ActiveOrHistoricCurrencyCode TargetCurrency { get; init; } 
    
    /// <summary>
    /// Specifies the factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// Usage: ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_m_LIkyYNEei7VPGVFTQkxA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    
    
    #nullable disable
    
}
