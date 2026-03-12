// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices.
/// </summary>
[IsoId("_Tgcl-dp-Ed-ak6NoX_4Aeg_-1124848708")]
[DisplayName("Corporate Action Price")]
public partial record CorporateActionPrice1
{
    #nullable enable
    
    /// <summary>
    /// 1. Price at which security will be purchased/sold if warrant is exercised, either as an actual amount or a percentage.|2. Price at which a bond is converted to underlying security either as an actual amount or a percentage.|3. Strike price of an option, represented either as an actual amount, a percentage or or a number of points above an index.
    /// </summary>
    [IsoId("_TgmW8Np-Ed-ak6NoX_4Aeg_-823780474")]
    [DisplayName("Exercise Price")]
    [IsoXmlTag("ExrcPric")]
    public PriceFormat4Choice_? ExercisePrice { get; init; } 
    
    /// <summary>
    /// Initial issue price of a financial instrument.
    /// </summary>
    [IsoId("_TgmW8dp-Ed-ak6NoX_4Aeg_-823780443")]
    [DisplayName("Issue Price")]
    [IsoXmlTag("IssePric")]
    public PriceFormat2Choice_? IssuePrice { get; init; } 
    
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_TgmW8tp-Ed-ak6NoX_4Aeg_-823780164")]
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat2Choice_? CashInLieuOfSharePrice { get; init; } 
    
    /// <summary>
    /// Amount included in the dividend/NAV that is identified as gains directly or indirectly derived from interest payments within the scope of the EU Savings directive.
    /// </summary>
    [IsoId("_TgmW89p-Ed-ak6NoX_4Aeg_-823780073")]
    [DisplayName("Taxable Income Per Dividend Share")]
    [IsoXmlTag("TaxblIncmPerDvddShr")]
    public AmountPrice1? TaxableIncomePerDividendShare { get; init; } 
    
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, eg, redemption price.
    /// </summary>
    [IsoId("_TgmW9Np-Ed-ak6NoX_4Aeg_-823780042")]
    [DisplayName("Generic Cash Price Received Per Product")]
    [IsoXmlTag("GncCshPricRcvdPerPdct")]
    public PriceFormat1Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    
    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount, eg, reinvestment price.
    /// </summary>
    [IsoId("_TgmW9dp-Ed-ak6NoX_4Aeg_-823780011")]
    [DisplayName("Generic Cash Price Paid Per Product")]
    [IsoXmlTag("GncCshPricPdPerPdct")]
    public PriceFormat2Choice_? GenericCashPricePaidPerProduct { get; init; } 
    
    /// <summary>
    /// Amount of money required per over-subscribed equity as defined by the issuer.
    /// </summary>
    [IsoId("_TgmW9tp-Ed-ak6NoX_4Aeg_-765598622")]
    [DisplayName("Over Subscription Deposit Price")]
    [IsoXmlTag("OverSbcptDpstPric")]
    public PriceFormat2Choice_? OverSubscriptionDepositPrice { get; init; } 
    
    
    #nullable disable
    
}
