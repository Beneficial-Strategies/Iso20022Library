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
[IsoId("_QfLNW9p-Ed-ak6NoX_4Aeg_617785517")]
[DisplayName("Unit Price")]
public partial record UnitPrice10
{
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_QfLNXNp-Ed-ak6NoX_4Aeg_617785904")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice10Code Type { get; init; } 
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_QfU-UNp-Ed-ak6NoX_4Aeg_1776540150")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; } 
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_QfU-Udp-Ed-ak6NoX_4Aeg_617785980")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceValue1 Value { get; init; } 
    
    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_QfU-Utp-Ed-ak6NoX_4Aeg_617786033")]
    [DisplayName("Price Method")]
    [IsoXmlTag("PricMtd")]
    public PriceMethod1Code? PriceMethod { get; init; } 
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_QfU-U9p-Ed-ak6NoX_4Aeg_617786335")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDaysAccrued { get; init; } 
    
    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_QfU-VNp-Ed-ak6NoX_4Aeg_617786465")]
    [DisplayName("Taxable Income Per Share")]
    [IsoXmlTag("TaxblIncmPerShr")]
    public ActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; } 
    
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_QfU-Vdp-Ed-ak6NoX_4Aeg_617786808")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; init; } 
    
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_QfU-Vtp-Ed-ak6NoX_4Aeg_-1416668608")]
    [DisplayName("Extended Taxable Income Per Share Calculated")]
    [IsoXmlTag("XtndedTaxblIncmPerShrClctd")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedTaxableIncomePerShareCalculated { get; init; } 
    
    /// <summary>
    /// Specifies the reason why the price is different from the current market price.
    /// </summary>
    [IsoId("_QfU-V9p-Ed-ak6NoX_4Aeg_-513409188")]
    [DisplayName("Price Difference Reason")]
    [IsoXmlTag("PricDiffRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PriceDifferenceReason { get; init; } 
    
    
    #nullable disable
    
}
