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
/// Content of the input response message.
/// </summary>
[IsoId("_M-bRUXGpEe2TbaNWBpRZpQ")]
[DisplayName("Device Input Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceInputResponse5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceInputResponse5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceInputResponse5( InputResult5 reqInputResult )
    {
        InputResult = reqInputResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Result of display request.
    /// </summary>
    [IsoId("_NErDQXGpEe2TbaNWBpRZpQ")]
    [DisplayName("Output Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutptRslt")]
    #endif
    [IsoXmlTag("OutptRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OutputResult2? OutputResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OutputResult2? OutputResult { get; init; } 
    #else
    public OutputResult2? OutputResult { get; set; } 
    #endif
    
    /// <summary>
    /// Result of input request.
    /// </summary>
    [IsoId("_NErDQ3GpEe2TbaNWBpRZpQ")]
    [DisplayName("Input Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptRslt")]
    #endif
    [IsoXmlTag("InptRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InputResult5 InputResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InputResult5 InputResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InputResult5 InputResult { get; init; } 
    #else
    public InputResult5 InputResult { get; set; } 
    #endif
    
    
    #nullable disable
    
}
