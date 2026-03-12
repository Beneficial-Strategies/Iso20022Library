// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_4FQWwSVlEeWV8IT-SD_UOg")]
[DisplayName("Unit Price")]
public partial record UnitPrice21
{
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_4iRC5SVlEeWV8IT-SD_UOg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice31Choice_ Type { get; init; } 
    
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    [IsoId("_4iRC6SVlEeWV8IT-SD_UOg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceValue1 Value { get; init; } 
    
    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_4iRC6yVlEeWV8IT-SD_UOg")]
    [DisplayName("Price Method")]
    [IsoXmlTag("PricMtd")]
    public PriceMethod1Code? PriceMethod { get; init; } 
    
    /// <summary>
    /// Interest that has accumulated between the most recent payment of interest and the sale of the financial instrument.
    /// </summary>
    [IsoId("_4iRC7SVlEeWV8IT-SD_UOg")]
    [DisplayName("Accrued Interest NAV")]
    [IsoXmlTag("AcrdIntrstNAV")]
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestNAV { get; init; } 
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_4iRC7yVlEeWV8IT-SD_UOg")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDaysAccrued { get; init; } 
    
    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_4iRC9yVlEeWV8IT-SD_UOg")]
    [DisplayName("Taxable Income Per Share")]
    [IsoXmlTag("TaxblIncmPerShr")]
    public ActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; } 
    
    
    #nullable disable
    
}
