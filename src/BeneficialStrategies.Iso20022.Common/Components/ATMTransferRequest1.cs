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
/// Information related to the request of a fund transfer from an ATM.
/// </summary>
[IsoId("_KJLG0K4sEeWLdt0vLARX2Q")]
[DisplayName("ATM Transfer Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransferRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMTransferRequest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMTransferRequest1( ATMEnvironment11 reqEnvironment,ATMTransaction23 reqTransaction )
    {
        Environment = reqEnvironment;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment in which the fund transfer is performed.
    /// </summary>
    [IsoId("_QwCGEK4sEeWLdt0vLARX2Q")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMEnvironment11 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMEnvironment11 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMEnvironment11 Environment { get; init; } 
    #else
    public ATMEnvironment11 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the fund transfer is performed.
    /// </summary>
    [IsoId("_aevAAK4sEeWLdt0vLARX2Q")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMContext18? Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMContext18? Context { get; init; } 
    #else
    public ATMContext18? Context { get; set; } 
    #endif
    
    /// <summary>
    /// Transfer information for the transaction.
    /// </summary>
    [IsoId("_h8A0cK4tEeWLdt0vLARX2Q")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMTransaction23 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMTransaction23 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTransaction23 Transaction { get; init; } 
    #else
    public ATMTransaction23 Transaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
