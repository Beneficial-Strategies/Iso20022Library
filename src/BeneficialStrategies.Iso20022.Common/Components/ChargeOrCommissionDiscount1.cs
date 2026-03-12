// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about discounts or waivers to charges and commissions.
/// </summary>
[IsoId("_zuNFIFiOEeaMNZxYNthMeA")]
[DisplayName("Charge Or Commission Discount")]
public partial record ChargeOrCommissionDiscount1
{
    #nullable enable
    
    /// <summary>
    /// Difference between the standard fee (charge/commission) amount and the applied fee (charge/commission) amount.
    /// EXAMPLE:
    /// Standard charge is EUR 100
    /// Discount is EUR 30
    /// Applied charge is EUR 70.
    /// </summary>
    [IsoId("_-PkLEliOEeaMNZxYNthMeA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; } 
    
    /// <summary>
    /// Difference between the standard fee (charge/commission) rate and the applied rate of the fee (charge/commission).
    /// EXAMPLE:
    /// Standard rate is 5%
    /// Discount rate is 3%
    /// Applied rate is 2%.
    /// </summary>
    [IsoId("_-PkLE1iOEeaMNZxYNthMeA")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; } 
    
    /// <summary>
    /// Form of the discount or rebate, for example, cash.
    /// </summary>
    [IsoId("_HTozoViPEeaMNZxYNthMeA")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public WaivingInstruction2Choice_? Basis { get; init; } 
    
    
    #nullable disable
    
}
