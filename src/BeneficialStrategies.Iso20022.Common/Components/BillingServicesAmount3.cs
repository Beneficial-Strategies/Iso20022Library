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
[IsoId("_6QZvopqlEeGSON8vddiWzQ_-1627146001")]
[DisplayName("Billing Services Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingServicesAmount3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingServicesAmount3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingServicesAmount3( AmountAndDirection34 reqSourceAmount,AmountAndDirection34 reqHostAmount )
    {
        SourceAmount = reqSourceAmount;
        HostAmount = reqHostAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Represents the total of all taxable services in a specific tax region for a specific currency. For example, all taxable services for a tax region in Euro would be totalled here in the Euro currency.
    /// </summary>
    [IsoId("_6QZvo5qlEeGSON8vddiWzQ_1670748942")]
    [DisplayName("Source Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcAmt")]
    #endif
    [IsoXmlTag("SrcAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection34 SourceAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection34 SourceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34 SourceAmount { get; init; } 
    #else
    public AmountAndDirection34 SourceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Represents the total of all taxable services in a specific tax region for a specific currency and is a one-to-one relationship with total taxable charge of services, but represented in the host currency after conversion.
    /// </summary>
    [IsoId("_6QZvpJqlEeGSON8vddiWzQ_-1449027329")]
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
    
    
    #nullable disable
    
}
