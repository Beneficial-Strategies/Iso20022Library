// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the discount information pertaining to the fleet transaction. 
/// </summary>
[IsoId("_G9Oy1vjDEeiJaN6-Lf-c_w")]
[DisplayName("Fleet Discount Totals")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FleetDiscountTotals1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total amount.
    /// </summary>
    [IsoId("_G9Oy2_jDEeiJaN6-Lf-c_w")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Fuel amount.
    /// </summary>
    [IsoId("_G9Oy2vjDEeiJaN6-Lf-c_w")]
    [DisplayName("Fuel Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FuelAmt")]
    #endif
    [IsoXmlTag("FuelAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? FuelAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? FuelAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? FuelAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Non-fuel amount.
    /// </summary>
    [IsoId("_G9Oy2fjDEeiJaN6-Lf-c_w")]
    [DisplayName("Non Fuel Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonFuelAmt")]
    #endif
    [IsoXmlTag("NonFuelAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? NonFuelAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? NonFuelAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? NonFuelAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
