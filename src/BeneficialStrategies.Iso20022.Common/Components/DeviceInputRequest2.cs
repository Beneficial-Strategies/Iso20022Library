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
/// Content of the Input Request message.
/// </summary>
[IsoId("_hExN4Q0cEeqUVL7sB4m7NA")]
[DisplayName("Device Input Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceInputRequest2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceInputRequest2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceInputRequest2( InputData2 reqInputData )
    {
        InputData = reqInputData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information to display before input.
    /// </summary>
    [IsoId("_hPwV4Q0cEeqUVL7sB4m7NA")]
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
    
    /// <summary>
    /// Information related to an Input request.
    /// </summary>
    [IsoId("_hPwV4w0cEeqUVL7sB4m7NA")]
    [DisplayName("Input Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptData")]
    #endif
    [IsoXmlTag("InptData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InputData2 InputData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InputData2 InputData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InputData2 InputData { get; init; } 
    #else
    public InputData2 InputData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
