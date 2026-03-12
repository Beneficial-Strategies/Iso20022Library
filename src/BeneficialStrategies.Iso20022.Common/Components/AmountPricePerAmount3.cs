// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a ratio: Amount price per amount.|Example:|ISIN US629377AS17. Repurchase USD1087.17 cash for every USD1000 stock (NRG Energy Inc 8% Senior Notes 15/12/13).
/// </summary>
[IsoId("_WjDbVtp-Ed-ak6NoX_4Aeg_-441488167")]
[DisplayName("Amount Price Per Amount")]
public partial record AmountPricePerAmount3
{
    #nullable enable
    
    /// <summary>
    /// Type of amount price.
    /// </summary>
    [IsoId("_WjDbV9p-Ed-ak6NoX_4Aeg_1859334423")]
    [DisplayName("Amount Price Type")]
    [IsoXmlTag("AmtPricTp")]
    public required AmountPriceType1Code AmountPriceType { get; init; } 
    
    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_WjDbWNp-Ed-ak6NoX_4Aeg_16214062")]
    [DisplayName("Price Value")]
    [IsoXmlTag("PricVal")]
    public required RestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    
    /// <summary>
    /// The amount on which the price is based.
    /// </summary>
    [IsoId("_WjDbWdp-Ed-ak6NoX_4Aeg_-1977930644")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
