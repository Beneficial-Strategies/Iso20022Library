// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency conversion accepted by the customer, either to convert the amount to dispense in the base currency of the ATM, or to convert the total requested amount in the currency of the customer (so called dynamic currency conversion).
/// </summary>
[IsoId("_NQ4Zga16EeWMg5rOByfExw")]
[DisplayName("Currency Conversion")]
public partial record CurrencyConversion9
{
    #nullable enable
    
    /// <summary>
    /// Identification of the currency conversion operation.
    /// </summary>
    [IsoId("_Ncpkoa16EeWMg5rOByfExw")]
    [DisplayName("Currency Conversion Identification")]
    [IsoXmlTag("CcyConvsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CurrencyConversionIdentification { get; init; } 
    
    /// <summary>
    /// Currency into which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_Ncpko616EeWMg5rOByfExw")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public required CurrencyDetails2 TargetCurrency { get; init; } 
    
    /// <summary>
    /// Amount converted in the target currency, including commission and mark-up.
    /// </summary>
    [IsoId("_Ncpkpa16EeWMg5rOByfExw")]
    [DisplayName("Resulting Amount")]
    [IsoXmlTag("RsltgAmt")]
    public required ImpliedCurrencyAndAmount ResultingAmount { get; init; } 
    
    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the original amount into the resulting amount.
    /// </summary>
    [IsoId("_Ncpkp616EeWMg5rOByfExw")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate ExchangeRate { get; init; } 
    
    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the resulting amount into the original amount.
    /// </summary>
    [IsoId("_Ncpkq616EeWMg5rOByfExw")]
    [DisplayName("Inverted Exchange Rate")]
    [IsoXmlTag("NvrtdXchgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InvertedExchangeRate { get; init; } 
    
    /// <summary>
    /// Date and time at which the exchange rate has been quoted.
    /// </summary>
    [IsoId("_Ncpkra16EeWMg5rOByfExw")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; } 
    
    /// <summary>
    /// Validity limit of the exchange rate.
    /// </summary>
    [IsoId("_Ncpkr616EeWMg5rOByfExw")]
    [DisplayName("Valid Until")]
    [IsoXmlTag("VldUntil")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ValidUntil { get; init; } 
    
    /// <summary>
    /// Currency from which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_Ncpksa16EeWMg5rOByfExw")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required CurrencyDetails2 SourceCurrency { get; init; } 
    
    /// <summary>
    /// Original amount in the source currency.
    /// </summary>
    [IsoId("_Ncpks616EeWMg5rOByfExw")]
    [DisplayName("Original Amount")]
    [IsoXmlTag("OrgnlAmt")]
    public required ImpliedCurrencyAndAmount OriginalAmount { get; init; } 
    
    /// <summary>
    /// Commission or additional charges made as part of a currency conversion.
    /// </summary>
    [IsoId("_Ncpkta16EeWMg5rOByfExw")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public Commission19? CommissionDetails { get; init; } 
    
    /// <summary>
    /// Mark-up made as part of a currency conversion.
    /// </summary>
    [IsoId("_Ncpkt616EeWMg5rOByfExw")]
    [DisplayName("Mark Up Details")]
    [IsoXmlTag("MrkUpDtls")]
    public Commission18? MarkUpDetails { get; init; } 
    
    /// <summary>
    /// Card scheme declaration (disclaimer) to present to the cardholder.
    /// </summary>
    [IsoId("_Ncpkua16EeWMg5rOByfExw")]
    [DisplayName("Declaration Details")]
    [IsoXmlTag("DclrtnDtls")]
    public ActionMessage5? DeclarationDetails { get; init; } 
    
    
    #nullable disable
    
}
