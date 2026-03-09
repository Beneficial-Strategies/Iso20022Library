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
[IsoId("_N15HMS9AEeu125Ip9zFcsQ")]
[DisplayName("Device Input Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DeviceInputRequest3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DeviceInputRequest3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DeviceInputRequest3( InputData3 reqInputData )
    {
        InputData = reqInputData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information to display before input.
    /// </summary>
    [IsoId("_OC1-ES9AEeu125Ip9zFcsQ")]
    [DisplayName("Display Output")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispOutpt")]
    #endif
    [IsoXmlTag("DispOutpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage8? DisplayOutput { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage8? DisplayOutput { get; init; } 
    #else
    public ActionMessage8? DisplayOutput { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to an Input request.
    /// </summary>
    [IsoId("_OC1-Ey9AEeu125Ip9zFcsQ")]
    [DisplayName("Input Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptData")]
    #endif
    [IsoXmlTag("InptData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InputData3 InputData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InputData3 InputData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InputData3 InputData { get; init; } 
    #else
    public InputData3 InputData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
