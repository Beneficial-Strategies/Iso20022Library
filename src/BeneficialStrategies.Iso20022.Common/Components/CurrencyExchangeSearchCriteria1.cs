// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for currency exchange information.
/// </summary>
[IsoId("_IB771ZlZEeeE1Ya-LgRsuQ")]
[DisplayName("Currency Exchange Search Criteria")]
public partial record CurrencyExchangeSearchCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Currency of the amount to be converted in a currency conversion.
    /// </summary>
    [IsoId("_IJ8oUZlZEeeE1Ya-LgRsuQ")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required ActiveOrHistoricCurrencyCode SourceCurrency { get; init; } 
    
    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_IJ8oU5lZEeeE1Ya-LgRsuQ")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public required ActiveOrHistoricCurrencyCode TargetCurrency { get; init; } 
    
    
    #nullable disable
    
}
