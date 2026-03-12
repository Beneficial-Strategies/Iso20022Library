// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the discount information pertaining to the fleet transaction. 
/// </summary>
[IsoId("_G9Oy1vjDEeiJaN6-Lf-c_w")]
[DisplayName("Fleet Discount Totals")]
public partial record FleetDiscountTotals1
{
    #nullable enable
    
    /// <summary>
    /// Total amount.
    /// </summary>
    [IsoId("_G9Oy2_jDEeiJaN6-Lf-c_w")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    
    /// <summary>
    /// Fuel amount.
    /// </summary>
    [IsoId("_G9Oy2vjDEeiJaN6-Lf-c_w")]
    [DisplayName("Fuel Amount")]
    [IsoXmlTag("FuelAmt")]
    public ImpliedCurrencyAndAmount? FuelAmount { get; init; } 
    
    /// <summary>
    /// Non-fuel amount.
    /// </summary>
    [IsoId("_G9Oy2fjDEeiJaN6-Lf-c_w")]
    [DisplayName("Non Fuel Amount")]
    [IsoXmlTag("NonFuelAmt")]
    public ImpliedCurrencyAndAmount? NonFuelAmount { get; init; } 
    
    
    #nullable disable
    
}
