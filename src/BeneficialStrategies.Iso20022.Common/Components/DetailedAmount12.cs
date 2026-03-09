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
/// Amounts of the withdrawal transaction.
/// </summary>
[IsoId("_gtlD0YokEeSaAcF2oE2GNQ")]
[DisplayName("Detailed Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedAmount12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedAmount12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedAmount12( ImpliedCurrencyAndAmount reqAmountToDispense )
    {
        AmountToDispense = reqAmountToDispense;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount to be dispensed by the ATM after the approval of the withdrawal transaction.
    /// </summary>
    [IsoId("_g6XipYokEeSaAcF2oE2GNQ")]
    [DisplayName("Amount To Dispense")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtToDspns")]
    #endif
    [IsoXmlTag("AmtToDspns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount AmountToDispense { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount AmountToDispense { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount AmountToDispense { get; init; } 
    #else
    public ImpliedCurrencyAndAmount AmountToDispense { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the amount to dispense when different from the base currency of the ATM.
    /// </summary>
    [IsoId("_8-oeoIokEeSaAcF2oE2GNQ")]
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
    /// Withdrawal fees, accepted by the customer.
    /// </summary>
    [IsoId("_NvDH0IolEeSaAcF2oE2GNQ")]
    [DisplayName("Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fees")]
    #endif
    [IsoXmlTag("Fees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount13? Fees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount13? Fees { get; init; } 
    #else
    public DetailedAmount13? Fees { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the donation.
    /// </summary>
    [IsoId("_g4F1QIolEeSaAcF2oE2GNQ")]
    [DisplayName("Donation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dontn")]
    #endif
    [IsoXmlTag("Dontn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount13? Donation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount13? Donation { get; init; } 
    #else
    public DetailedAmount13? Donation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
