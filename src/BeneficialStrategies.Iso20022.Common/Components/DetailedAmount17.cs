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
/// Details of the transfer transaction amounts.
/// </summary>
[IsoId("_pgqcMa4uEeWLdt0vLARX2Q")]
[DisplayName("Detailed Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedAmount17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedAmount17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedAmount17( ImpliedCurrencyAndAmount reqAmountToTransfer )
    {
        AmountToTransfer = reqAmountToTransfer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount to be transferred from the source account to the destination account.
    /// </summary>
    [IsoId("_pri2g64uEeWLdt0vLARX2Q")]
    [DisplayName("Amount To Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtToTrf")]
    #endif
    [IsoXmlTag("AmtToTrf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount AmountToTransfer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount AmountToTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount AmountToTransfer { get; init; } 
    #else
    public ImpliedCurrencyAndAmount AmountToTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the amount to be transferred.
    /// </summary>
    [IsoId("_pri2ha4uEeWLdt0vLARX2Q")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Transfer fees, accepted by the customer.
    /// </summary>
    [IsoId("_pri2h64uEeWLdt0vLARX2Q")]
    [DisplayName("Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fees")]
    #endif
    [IsoXmlTag("Fees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount18? Fees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount18? Fees { get; init; } 
    #else
    public DetailedAmount18? Fees { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the donation.
    /// </summary>
    [IsoId("_pri2ia4uEeWLdt0vLARX2Q")]
    [DisplayName("Donation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dontn")]
    #endif
    [IsoXmlTag("Dontn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount18? Donation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount18? Donation { get; init; } 
    #else
    public DetailedAmount18? Donation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
