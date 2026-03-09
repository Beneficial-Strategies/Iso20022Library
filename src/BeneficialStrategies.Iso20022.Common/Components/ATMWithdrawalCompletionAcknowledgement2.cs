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
/// Information related to the acknowledgement of an ATM withdrawal from the ATM manager.
/// </summary>
[IsoId("_eR-ZMa4NEeWZgJQOa6iKCQ")]
[DisplayName("ATM Withdrawal Completion Acknowledgement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMWithdrawalCompletionAcknowledgement2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMWithdrawalCompletionAcknowledgement2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMWithdrawalCompletionAcknowledgement2( AutomatedTellerMachine3 reqATM,ATMContext9 reqContext,ATMTransaction18 reqTransaction )
    {
        ATM = reqATM;
        Context = reqContext;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_ecj4ka4NEeWZgJQOa6iKCQ")]
    [DisplayName("ATM")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATM")]
    #endif
    [IsoXmlTag("ATM")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AutomatedTellerMachine3 ATM { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AutomatedTellerMachine3 ATM { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AutomatedTellerMachine3 ATM { get; init; } 
    #else
    public AutomatedTellerMachine3 ATM { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_ecj4k64NEeWZgJQOa6iKCQ")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMContext9 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMContext9 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMContext9 Context { get; init; } 
    #else
    public ATMContext9 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Acknowledgement of the withdrawal completion advice.
    /// </summary>
    [IsoId("_ecj4la4NEeWZgJQOa6iKCQ")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMTransaction18 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMTransaction18 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTransaction18 Transaction { get; init; } 
    #else
    public ATMTransaction18 Transaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
