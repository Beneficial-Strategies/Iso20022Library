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
/// Information related to the request to an ATM to contact the ATM manager.
/// </summary>
[IsoId("_nkIKwItqEeSDLd7nI4Quzw")]
[DisplayName("Host To ATM Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record HostToATMRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a HostToATMRequest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public HostToATMRequest1( ATMEnvironment9 reqEnvironment,MessageFunction8Code reqExpectedMessageFunction )
    {
        Environment = reqEnvironment;
        ExpectedMessageFunction = reqExpectedMessageFunction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the ATM.
    /// </summary>
    [IsoId("_FLX8cItrEeSDLd7nI4Quzw")]
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
    /// Identification of the entity issuing the command.
    /// </summary>
    [IsoId("_DovRwCydEeWT0qwwEKj7sA")]
    [DisplayName("Command Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmdId")]
    #endif
    [IsoXmlTag("CmdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    #else
    public ATMCommandIdentification1? CommandIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Message that have to be sent by the ATM.
    /// </summary>
    [IsoId("_WvQl0CvQEeW-qbryg71zJw")]
    [DisplayName("Expected Message Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdMsgFctn")]
    #endif
    [IsoXmlTag("XpctdMsgFctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageFunction8Code ExpectedMessageFunction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageFunction8Code ExpectedMessageFunction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageFunction8Code ExpectedMessageFunction { get; init; } 
    #else
    public MessageFunction8Code ExpectedMessageFunction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
