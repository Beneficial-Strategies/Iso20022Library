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
/// Information related to the request of a diagnostic from an ATM.
/// </summary>
[IsoId("_ZlSuMa46EeWRfYPBaeOY8w")]
[DisplayName("ATM Diagnostic Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMDiagnosticRequest2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMDiagnosticRequest2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMDiagnosticRequest2( ATMEnvironment9 reqEnvironment,ATMStatus1 reqATMGlobalStatus )
    {
        Environment = reqEnvironment;
        ATMGlobalStatus = reqATMGlobalStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the ATM.
    /// </summary>
    [IsoId("_Zwgfsa46EeWRfYPBaeOY8w")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMEnvironment9 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMEnvironment9 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMEnvironment9 Environment { get; init; } 
    #else
    public ATMEnvironment9 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Global status of the ATM.
    /// </summary>
    [IsoId("_hAdfQK46EeWRfYPBaeOY8w")]
    [DisplayName("ATM Global Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMGblSts")]
    #endif
    [IsoXmlTag("ATMGblSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMStatus1 ATMGlobalStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMStatus1 ATMGlobalStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMStatus1 ATMGlobalStatus { get; init; } 
    #else
    public ATMStatus1 ATMGlobalStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
