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
/// Information related to the request of a key download from an ATM.
/// </summary>
[IsoId("_5pWRQItKEeSxlKlAGYErFg")]
[DisplayName("ATM Key Download Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMKeyDownloadRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMKeyDownloadRequest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMKeyDownloadRequest1( ATMEnvironment8 reqEnvironment,ATMSecurityContext2 reqATMSecurityContext,SecurityParameters4 reqATMSecurityParameters )
    {
        Environment = reqEnvironment;
        ATMSecurityContext = reqATMSecurityContext;
        ATMSecurityParameters = reqATMSecurityParameters;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the key download.
    /// </summary>
    [IsoId("_VenH8ItLEeSxlKlAGYErFg")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMEnvironment8 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMEnvironment8 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMEnvironment8 Environment { get; init; } 
    #else
    public ATMEnvironment8 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Result of a maintenance command performed by the ATM.
    /// </summary>
    [IsoId("_2oXXEItLEeSxlKlAGYErFg")]
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
    /// Security command in progress inside which the key download is requested.
    /// </summary>
    [IsoId("_6qdTgItLEeSxlKlAGYErFg")]
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
    /// Context of the ATM for the key download.
    /// </summary>
    [IsoId("_HaiTwItMEeSxlKlAGYErFg")]
    [DisplayName("ATM Security Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMSctyCntxt")]
    #endif
    [IsoXmlTag("ATMSctyCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMSecurityContext2 ATMSecurityContext { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMSecurityContext2 ATMSecurityContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMSecurityContext2 ATMSecurityContext { get; init; } 
    #else
    public ATMSecurityContext2 ATMSecurityContext { get; set; } 
    #endif
    
    /// <summary>
    /// Security parameters of the ATM for the initiated key download.
    /// </summary>
    [IsoId("_Y0pIQItOEeSxlKlAGYErFg")]
    [DisplayName("ATM Security Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMSctyParams")]
    #endif
    [IsoXmlTag("ATMSctyParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityParameters4 ATMSecurityParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityParameters4 ATMSecurityParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityParameters4 ATMSecurityParameters { get; init; } 
    #else
    public SecurityParameters4 ATMSecurityParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Random value from the host provided during a previous exchange.
    /// </summary>
    [IsoId("_bRViQItQEeSxlKlAGYErFg")]
    [DisplayName("Host Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HstChllng")]
    #endif
    [IsoXmlTag("HstChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? HostChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? HostChallenge { get; init; } 
    #else
    public System.Byte[]? HostChallenge { get; set; } 
    #endif
    
    
    #nullable disable
    
}
