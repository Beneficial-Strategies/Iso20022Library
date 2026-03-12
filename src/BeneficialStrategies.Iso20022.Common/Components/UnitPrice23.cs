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
[IsoId("_cy2TMY4aEeeNN9vGwZc5aA")]
[DisplayName("Unit Price")]
public partial record UnitPrice23
{
    #nullable enable
    
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    [IsoId("_dBa6s44aEeeNN9vGwZc5aA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfPrice46Choice_ Type { get; init; } 
    
    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_dBa6tY4aEeeNN9vGwZc5aA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceValue1 Value { get; init; } 
    
    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_dBa6t44aEeeNN9vGwZc5aA")]
    [DisplayName("Price Method")]
    [IsoXmlTag("PricMtd")]
    public PriceMethod1Code? PriceMethod { get; init; } 
    
    /// <summary>
    /// Interest that has accumulated between the most recent payment of interest and the sale of the financial instrument.
    /// </summary>
    [IsoId("_dBa6uY4aEeeNN9vGwZc5aA")]
    [DisplayName("Accrued Interest NAV")]
    [IsoXmlTag("AcrdIntrstNAV")]
    public ActiveOrHistoricCurrencyAndAmount? AccruedInterestNAV { get; init; } 
    
    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_dBa6u44aEeeNN9vGwZc5aA")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDaysAccrued { get; init; } 
    
    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_dBa6w44aEeeNN9vGwZc5aA")]
    [DisplayName("Taxable Income Per Share")]
    [IsoXmlTag("TaxblIncmPerShr")]
    public ActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; } 
    
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_tQo7UY4aEeeNN9vGwZc5aA")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculated2Choice_? TaxableIncomePerShareCalculated { get; init; } 
    
    
    #nullable disable
    
}
