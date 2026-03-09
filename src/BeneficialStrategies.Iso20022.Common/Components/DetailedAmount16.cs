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
/// Amounts of the deposit transaction.
/// </summary>
[IsoId("_7175Qa4AEeWL1uap3dNhCQ")]
[DisplayName("Detailed Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedAmount16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Link to the account for multi-account deposit.
    /// </summary>
    [IsoId("_FgDOIK4BEeWL1uap3dNhCQ")]
    [DisplayName("Account Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSeqNb")]
    #endif
    [IsoXmlTag("AcctSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? AccountSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? AccountSequenceNumber { get; init; } 
    #else
    public System.UInt64? AccountSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the deposit to be made on the ATM after the approval of the deposit transaction.
    /// </summary>
    [IsoId("_8BHOga4AEeWL1uap3dNhCQ")]
    [DisplayName("Amount To Deposit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtToDpst")]
    #endif
    [IsoXmlTag("AmtToDpst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? AmountToDeposit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? AmountToDeposit { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? AmountToDeposit { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the amount to deposit when different from the base currency of the ATM.
    /// </summary>
    [IsoId("_8BHOg64AEeWL1uap3dNhCQ")]
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
    /// Cashback amount value.
    /// </summary>
    [IsoId("_RuWLUK-TEeWJvLRJ8PsD_w")]
    [DisplayName("Cash Back Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshBckAmt")]
    #endif
    [IsoXmlTag("CshBckAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? CashBackAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? CashBackAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? CashBackAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Deposit fees, accepted by the customer.
    /// </summary>
    [IsoId("_8BHOha4AEeWL1uap3dNhCQ")]
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
    [IsoId("_8BHOh64AEeWL1uap3dNhCQ")]
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
