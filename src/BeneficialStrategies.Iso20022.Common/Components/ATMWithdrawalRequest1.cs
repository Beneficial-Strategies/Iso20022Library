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
/// Information related to the request of a withdrawal from an ATM.
/// </summary>
[IsoId("_U0PCoIn1EeS9F4Qrq_eaVA")]
[DisplayName("ATM Withdrawal Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMWithdrawalRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMWithdrawalRequest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMWithdrawalRequest1( ATMEnvironment1 reqEnvironment,ATMContext1 reqContext,ATMTransaction1 reqTransaction )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the withdrawal transaction.
    /// </summary>
    [IsoId("_oJHMoIn1EeS9F4Qrq_eaVA")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMEnvironment1 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMEnvironment1 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMEnvironment1 Environment { get; init; } 
    #else
    public ATMEnvironment1 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("_1pdaIIofEeSirOZJBRz_nA")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMContext1 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMContext1 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMContext1 Context { get; init; } 
    #else
    public ATMContext1 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Withdrawal transaction for which the authorisation is requested.
    /// </summary>
    [IsoId("_Ll608IohEeSirOZJBRz_nA")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMTransaction1 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMTransaction1 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTransaction1 Transaction { get; init; } 
    #else
    public ATMTransaction1 Transaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
