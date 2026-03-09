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
/// Taxable service charge amount conversions to host currency.
/// </summary>
[IsoId("_6QP-p5qlEeGSON8vddiWzQ_460369359")]
[DisplayName("Billing Services Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingServicesAmount2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingServicesAmount2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingServicesAmount2( AmountAndDirection34 reqHostAmount )
    {
        HostAmount = reqHostAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sum of the original charge host amount and the service tax host amount values. It represents the total charge for a service (including taxes) expressed in the host currency.
    /// </summary>
    [IsoId("_6QP-qJqlEeGSON8vddiWzQ_-1570575712")]
    [DisplayName("Host Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstAmt")]
    #endif
    [IsoXmlTag("HstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection34 HostAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection34 HostAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34 HostAmount { get; init; } 
    #else
    public AmountAndDirection34 HostAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of the original charge host amount and the service tax host amount values but expressed in the settlement currency.
    /// </summary>
    [IsoId("_6QZvoJqlEeGSON8vddiWzQ_-536702994")]
    [DisplayName("Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAmt")]
    #endif
    [IsoXmlTag("SttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection34? SettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34? SettlementAmount { get; init; } 
    #else
    public AmountAndDirection34? SettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of the original charge host amount and the service tax host amount values but expressed in the pricing currency.
    /// </summary>
    [IsoId("_6QZvoZqlEeGSON8vddiWzQ_1108564441")]
    [DisplayName("Pricing Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricgAmt")]
    #endif
    [IsoXmlTag("PricgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection34? PricingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34? PricingAmount { get; init; } 
    #else
    public AmountAndDirection34? PricingAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
