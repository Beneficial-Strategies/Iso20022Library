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
/// Specifies what to do during shutdown.
/// </summary>
[IsoId("_MAEhwXGgEe2TbaNWBpRZpQ")]
[DisplayName("Device Poweroff Card Reader Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DevicePoweroffCardReaderRequest5
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
    [IsoId("_MGTFkXGgEe2TbaNWBpRZpQ")]
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
    [IsoId("_MGTsoXGgEe2TbaNWBpRZpQ")]
    [DisplayName("Display Output")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispOutpt")]
    #endif
    [IsoXmlTag("DispOutpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage10? DisplayOutput { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage10? DisplayOutput { get; init; } 
    #else
    public ActionMessage10? DisplayOutput { get; set; } 
    #endif
    
    
    #nullable disable
    
}
