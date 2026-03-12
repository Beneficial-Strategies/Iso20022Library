// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the details of the currency exchange.
/// </summary>
[IsoId("_6SCHWZqlEeGSON8vddiWzQ_1288197096")]
[DisplayName("Currency Exchange")]
public partial record CurrencyExchange6
{
    #nullable enable
    
    /// <summary>
    /// Currency from which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_6SCHWpqlEeGSON8vddiWzQ_1751600189")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required ActiveOrHistoricCurrencyCode SourceCurrency { get; init; } 
    
    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_6SCHW5qlEeGSON8vddiWzQ_-1782601954")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public required ActiveOrHistoricCurrencyCode TargetCurrency { get; init; } 
    
    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_6SCHXJqlEeGSON8vddiWzQ_491309707")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    
    /// <summary>
    /// Unique identification to unambiguously identify the foreign exchange contract.
    /// </summary>
    [IsoId("_6SL4UJqlEeGSON8vddiWzQ_1542442779")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max40Text)]
    [StringLength(maximumLength: 40 ,MinimumLength = 1)]
    public IsoMax40Text? Description { get; init; } 
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_6SL4UZqlEeGSON8vddiWzQ_1019397656")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public ActiveOrHistoricCurrencyCode? UnitCurrency { get; init; } 
    
    /// <summary>
    /// Further information on the exchange rate.
    /// </summary>
    [IsoId("_6SL4UpqlEeGSON8vddiWzQ_-301426210")]
    [DisplayName("Comments")]
    [IsoXmlTag("Cmnts")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Comments { get; init; } 
    
    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    [IsoId("_6SL4U5qlEeGSON8vddiWzQ_-813958820")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; } 
    
    
    #nullable disable
    
}
