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
[IsoId("_U4XbKNp-Ed-ak6NoX_4Aeg_-49589526")]
[DisplayName("Unit Price")]
public partial record UnitPrice3
{
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_U4XbKdp-Ed-ak6NoX_4Aeg_173901731")]
    [DisplayName("Price Type")]
    [IsoXmlTag("PricTp")]
    public required TypeOfPrice2Code PriceType { get; init; } 
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_U4XbKtp-Ed-ak6NoX_4Aeg_173902002")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceValue1 Value { get; init; } 
    
    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_U4glENp-Ed-ak6NoX_4Aeg_173902033")]
    [DisplayName("Price Method")]
    [IsoXmlTag("PricMtd")]
    public PriceMethod1Code? PriceMethod { get; init; } 
    
    /// <summary>
    /// Interest that has accumulated between the most recent payment of interest and the sale of the financial instrument.
    /// </summary>
    [IsoId("_U4glEdp-Ed-ak6NoX_4Aeg_66170835")]
    [DisplayName("Accrued Interest NAV")]
    [IsoXmlTag("AcrdIntrstNAV")]
    public CurrencyAndAmount? AccruedInterestNAV { get; init; } 
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_U4glEtp-Ed-ak6NoX_4Aeg_107730858")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDaysAccrued { get; init; } 
    
    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_U4glE9p-Ed-ak6NoX_4Aeg_396874449")]
    [DisplayName("Taxable Income Per Share")]
    [IsoXmlTag("TaxblIncmPerShr")]
    public CurrencyAndAmount? TaxableIncomePerShare { get; init; } 
    
    
    #nullable disable
    
}
