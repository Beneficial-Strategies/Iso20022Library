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
/// Content of the Power-Off Card Reader Request message.
/// </summary>
[IsoId("_ybELUQ0cEeqUVL7sB4m7NA")]
[DisplayName("Device Poweroff Card Reader Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DevicePoweroffCardReaderRequest2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Maximum time to wait for the request processing in seconds.
    /// </summary>
    [IsoId("_ymIL0Q0cEeqUVL7sB4m7NA")]
    [DisplayName("Power Off Maximum Waiting Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrOffMaxWtgTm")]
    #endif
    [IsoXmlTag("PwrOffMaxWtgTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? PowerOffMaximumWaitingTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PowerOffMaximumWaitingTime { get; init; } 
    #else
    public System.UInt64? PowerOffMaximumWaitingTime { get; set; } 
    #endif
    
    /// <summary>
    /// Optional message before Power-Off.
    /// </summary>
    [IsoId("_ymIL0w0cEeqUVL7sB4m7NA")]
    [DisplayName("Display Output")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispOutpt")]
    #endif
    [IsoXmlTag("DispOutpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage7? DisplayOutput { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage7? DisplayOutput { get; init; } 
    #else
    public ActionMessage7? DisplayOutput { get; set; } 
    #endif
    
    
    #nullable disable
    
}
