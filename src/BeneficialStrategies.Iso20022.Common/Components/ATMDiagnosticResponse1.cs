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
/// Information related to the response of a diagnostic from an ATM manager.
/// </summary>
[IsoId("_XQgAsItpEeSDLd7nI4Quzw")]
[DisplayName("ATM Diagnostic Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMDiagnosticResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMDiagnosticResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMDiagnosticResponse1( ATMEnvironment6 reqEnvironment )
    {
        Environment = reqEnvironment;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the ATM.
    /// </summary>
    [IsoId("_nEQNUItpEeSDLd7nI4Quzw")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMEnvironment6 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMEnvironment6 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMEnvironment6 Environment { get; init; } 
    #else
    public ATMEnvironment6 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_rlVy4ItpEeSDLd7nI4Quzw")]
    [DisplayName("Command")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmd")]
    #endif
    [IsoXmlTag("Cmd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommand1? Command { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand1? Command { get; init; } 
    #else
    public ATMCommand1? Command { get; set; } 
    #endif
    
    
    #nullable disable
    
}
