// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the billing price of a service.
/// </summary>
[IsoId("_6TrGHJqlEeGSON8vddiWzQ_-1572616191")]
[DisplayName("Billing Price")]
public partial record BillingPrice1
{
    #nullable enable
    
    /// <summary>
    /// Currency code in which the unit price and original charge price are expressed.
    /// </summary>
    [IsoId("_6T03EJqlEeGSON8vddiWzQ_-1686455257")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Price per item or unit used to calculate the charge expressed in the pricing currency.
    /// </summary>
    [IsoId("_6T03EZqlEeGSON8vddiWzQ_1611439686")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public AmountAndDirection34? UnitPrice { get; init; } 
    
    /// <summary>
    /// Identifies how the charge was calculated. ||Usage: The absence of this code assumes that the charge is calculated as the product of (volume x unit price).
    /// </summary>
    [IsoId("_6T03EpqlEeGSON8vddiWzQ_1347426093")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    public BillingChargeMethod1Code? Method { get; init; } 
    
    /// <summary>
    /// Indicates that the charge calculation is based on a particular rule. The rule name is carried here and is defined by the trading partners.
    /// </summary>
    [IsoId("_6T03E5qlEeGSON8vddiWzQ_-937813392")]
    [DisplayName("Rule")]
    [IsoXmlTag("Rule")]
    [IsoSimpleType(IsoSimpleType.Max20Text)]
    [StringLength(maximumLength: 20 ,MinimumLength = 1)]
    public IsoMax20Text? Rule { get; init; } 
    
    
    #nullable disable
    
}
