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
/// Information related to the result the output (display, print, input).
/// </summary>
[IsoId("_3CNXIN7EEeiwsev40qZGEQ")]
[DisplayName("Output Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OutputResult1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OutputResult1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OutputResult1( UserInterface4Code reqDeviceType,InformationQualify1Code reqInformationQualifier,ResponseType9 reqResponse )
    {
        DeviceType = reqDeviceType;
        InformationQualifier = reqInformationQualifier;
        Response = reqResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Logical device located on a Sale Terminal or a POI Terminal, in term of class of information to output.
    /// </summary>
    [IsoId("__Gk2MN7EEeiwsev40qZGEQ")]
    [DisplayName("Device Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvcTp")]
    #endif
    [IsoXmlTag("DvcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UserInterface4Code DeviceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UserInterface4Code DeviceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UserInterface4Code DeviceType { get; init; } 
    #else
    public UserInterface4Code DeviceType { get; set; } 
    #endif
    
    /// <summary>
    /// Qualification of the information to sent to an output logical device.
    /// </summary>
    [IsoId("_Eop-sN7FEeiwsev40qZGEQ")]
    [DisplayName("Information Qualifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfQlfr")]
    #endif
    [IsoXmlTag("InfQlfr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InformationQualify1Code InformationQualifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InformationQualify1Code InformationQualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InformationQualify1Code InformationQualifier { get; init; } 
    #else
    public InformationQualify1Code InformationQualifier { get; set; } 
    #endif
    
    /// <summary>
    /// Gives response for each peripheral.
    /// </summary>
    [IsoId("_LYGSMN7FEeiwsev40qZGEQ")]
    [DisplayName("Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspn")]
    #endif
    [IsoXmlTag("Rspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType9 Response { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType9 Response { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType9 Response { get; init; } 
    #else
    public ResponseType9 Response { get; set; } 
    #endif
    
    
    #nullable disable
    
}
