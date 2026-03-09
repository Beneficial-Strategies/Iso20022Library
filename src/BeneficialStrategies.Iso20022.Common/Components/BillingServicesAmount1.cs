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
[IsoId("_6QP-pJqlEeGSON8vddiWzQ_1984361507")]
[DisplayName("Billing Services Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingServicesAmount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingServicesAmount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingServicesAmount1( AmountAndDirection34 reqHostAmount )
    {
        HostAmount = reqHostAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sum of all the individual taxes on the service expressed in the host currency.
    /// </summary>
    [IsoId("_6QP-pZqlEeGSON8vddiWzQ_-123622265")]
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
    /// Amount of the tax obligation expressed in the tax region&apos;s pricing currency.|Usage: This is the same amount as carried in the host amount but allows the sender to optionally express the value in the pricing currency.
    /// </summary>
    [IsoId("_6QP-ppqlEeGSON8vddiWzQ_-1662410707")]
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
