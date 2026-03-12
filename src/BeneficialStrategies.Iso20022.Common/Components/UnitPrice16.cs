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
[IsoId("_QfxqStp-Ed-ak6NoX_4Aeg_394298835")]
[DisplayName("Unit Price")]
public partial record UnitPrice16
{
    #nullable enable
    
    /// <summary>
    /// Type of price.
    /// </summary>
    [IsoId("_Qf60MNp-Ed-ak6NoX_4Aeg_-466354401")]
    [DisplayName("Unit Price Type")]
    [IsoXmlTag("UnitPricTp")]
    public required UnitPriceType1Choice_ UnitPriceType { get; init; } 
    
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    [IsoId("_Qf60Mdp-Ed-ak6NoX_4Aeg_394299267")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required PriceValue1 Value { get; init; } 
    
    /// <summary>
    /// Amount included in the NAV that corresponds to gains directly or indirectly derived from interest payment in the scope of the European Directive on taxation of savings income in the form of interest payments.
    /// </summary>
    [IsoId("_Qf60Mtp-Ed-ak6NoX_4Aeg_1724434450")]
    [DisplayName("Taxable Income Per Share")]
    [IsoXmlTag("TaxblIncmPerShr")]
    public ActiveCurrencyAnd13DecimalAmount? TaxableIncomePerShare { get; init; } 
    
    /// <summary>
    /// Taxable income per share calculated.
    /// </summary>
    [IsoId("_Qf60M9p-Ed-ak6NoX_4Aeg_205901546")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculatedType1Choice_? TaxableIncomePerShareCalculated { get; init; } 
    
    
    #nullable disable
    
}
