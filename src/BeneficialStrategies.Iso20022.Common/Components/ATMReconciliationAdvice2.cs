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
/// Information related to the reconciliation of an ATM.
/// </summary>
[IsoId("_MEvd0a47EeWRfYPBaeOY8w")]
[DisplayName("ATM Reconciliation Advice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMReconciliationAdvice2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMReconciliationAdvice2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMReconciliationAdvice2( ATMEnvironment10 reqEnvironment,ATMTransaction25 reqTransaction )
    {
        Environment = reqEnvironment;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the ATM.
    /// </summary>
    [IsoId("_MPxpIa47EeWRfYPBaeOY8w")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMEnvironment10 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMEnvironment10 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMEnvironment10 Environment { get; init; } 
    #else
    public ATMEnvironment10 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Command result for reinitialisation of the transaction counters.
    /// </summary>
    [IsoId("_MPxpI647EeWRfYPBaeOY8w")]
    [DisplayName("Command Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmdRslt")]
    #endif
    [IsoXmlTag("CmdRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommand8? CommandResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand8? CommandResult { get; init; } 
    #else
    public ATMCommand8? CommandResult { get; set; } 
    #endif
    
    /// <summary>
    /// Party which has requested the reconciliation.
    /// </summary>
    [IsoId("_MPxpJa47EeWRfYPBaeOY8w")]
    [DisplayName("Command Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmdCntxt")]
    #endif
    [IsoXmlTag("CmdCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommand9? CommandContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand9? CommandContext { get; init; } 
    #else
    public ATMCommand9? CommandContext { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the reconciliation request.
    /// </summary>
    [IsoId("_MPxpJ647EeWRfYPBaeOY8w")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMTransaction25 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMTransaction25 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTransaction25 Transaction { get; init; } 
    #else
    public ATMTransaction25 Transaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
