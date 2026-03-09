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
/// Information related to the report from an ATM device.
/// </summary>
[IsoId("_FGk3EIreEeSvuOJS0mmL0g")]
[DisplayName("ATM Device Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMDeviceReport1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMDeviceReport1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMDeviceReport1( ATMEnvironment6 reqEnvironment,ATMStatus1 reqATMGlobalStatus )
    {
        Environment = reqEnvironment;
        ATMGlobalStatus = reqATMGlobalStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Aq3EQIrfEeSvuOJS0mmL0g")]
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
    /// Global status of the ATM.
    /// </summary>
    [IsoId("_FtzfEIryEeSvuOJS0mmL0g")]
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
    
    /// <summary>
    /// Result of a maintenance command performed by the ATM.
    /// </summary>
    [IsoId("_2agesIryEeSvuOJS0mmL0g")]
    [DisplayName("Command Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmdRslt")]
    #endif
    [IsoXmlTag("CmdRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommand2? CommandResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand2? CommandResult { get; init; } 
    #else
    public ATMCommand2? CommandResult { get; set; } 
    #endif
    
    /// <summary>
    /// Maintenance command which has requested the device report.
    /// </summary>
    [IsoId("_WAO9AIr4EeSvuOJS0mmL0g")]
    [DisplayName("Command Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmdCntxt")]
    #endif
    [IsoXmlTag("CmdCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommand3? CommandContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand3? CommandContext { get; init; } 
    #else
    public ATMCommand3? CommandContext { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to security commands.
    /// </summary>
    [IsoId("_tOsAoIr4EeSvuOJS0mmL0g")]
    [DisplayName("ATM Security Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMSctyCntxt")]
    #endif
    [IsoXmlTag("ATMSctyCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMSecurityContext1? ATMSecurityContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMSecurityContext1? ATMSecurityContext { get; init; } 
    #else
    public ATMSecurityContext1? ATMSecurityContext { get; set; } 
    #endif
    
    
    #nullable disable
    
}
