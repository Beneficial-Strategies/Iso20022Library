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
[IsoId("_-FuZYThfEeamLZQeccJa7w")]
[DisplayName("Unit Price")]
public partial record UnitPrice22
{
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_-euINzhfEeamLZQeccJa7w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice46Choice_ Type { get; init; } 
    
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    [IsoId("_-euIOzhfEeamLZQeccJa7w")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceValue1 Value { get; init; } 
    
    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_-euIPThfEeamLZQeccJa7w")]
    [DisplayName("Price Method")]
    [IsoXmlTag("PricMtd")]
    public PriceMethod1Code? PriceMethod { get; init; } 
    
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_-euIPzhfEeamLZQeccJa7w")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDaysAccrued { get; init; } 
    
    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_-euIRzhfEeamLZQeccJa7w")]
    [DisplayName("Taxable Income Per Share")]
    [IsoXmlTag("TaxblIncmPerShr")]
    public ActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; } 
    
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_-euISThfEeamLZQeccJa7w")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculated2Choice_? TaxableIncomePerShareCalculated { get; init; } 
    
    /// <summary>
    /// Reason why the price is different from the current market price.
    /// </summary>
    [IsoId("_-euITThfEeamLZQeccJa7w")]
    [DisplayName("Price Difference Reason")]
    [IsoXmlTag("PricDiffRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PriceDifferenceReason { get; init; } 
    
    
    #nullable disable
    
}
