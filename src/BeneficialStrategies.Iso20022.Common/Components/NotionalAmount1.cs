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
/// Indicates the reference amount from which contractual payments are determined and the schedule applicable to the payments.
/// </summary>
[IsoId("_WrPhgAbKEeqrW7Meu5r3kQ")]
[DisplayName("Notional Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NotionalAmount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NotionalAmount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NotionalAmount1( AmountAndDirection106 reqAmount )
    {
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference amount from which contractual payments are determined.
    /// Usage: In case of partial terminations, and amortisations and in case of contracts where the notional, due to the characteristics of the contract, varies over time, it shall reflect the remaining notional after the change took place.
    /// </summary>
    [IsoId("_aDpnwQbKEeqrW7Meu5r3kQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection106 Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection106 Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection106 Amount { get; init; } 
    #else
    public AmountAndDirection106 Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions negotiated in monetary amounts varying throughout the life of the transaction.
    /// </summary>
    [IsoId("_h7Os4eXtEemUbdOm9aOvMg")]
    [DisplayName("Schedule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Schdl")]
    #endif
    [IsoXmlTag("Schdl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Schedule3? Schedule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Schedule3? Schedule { get; init; } 
    #else
    public Schedule3? Schedule { get; set; } 
    #endif
    
    
    #nullable disable
    
}
