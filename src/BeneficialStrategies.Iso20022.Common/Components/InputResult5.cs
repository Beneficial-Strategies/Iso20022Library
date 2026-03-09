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
/// Information related to the result the input.
/// </summary>
[IsoId("_WmjeoXGoEe2TbaNWBpRZpQ")]
[DisplayName("Input Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InputResult5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InputResult5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InputResult5( SaleCapabilities2Code reqDeviceType,InformationQualify1Code reqInformationQualifier,InputResultData5 reqInputResultData )
    {
        DeviceType = reqDeviceType;
        InformationQualifier = reqInformationQualifier;
        InputResultData = reqInputResultData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of Input device.
    /// </summary>
    [IsoId("_WtIAsXGoEe2TbaNWBpRZpQ")]
    [DisplayName("Device Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvcTp")]
    #endif
    [IsoXmlTag("DvcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SaleCapabilities2Code DeviceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SaleCapabilities2Code DeviceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SaleCapabilities2Code DeviceType { get; init; } 
    #else
    public SaleCapabilities2Code DeviceType { get; set; } 
    #endif
    
    /// <summary>
    /// Qualifies the type of given information.
    /// </summary>
    [IsoId("_WtIAs3GoEe2TbaNWBpRZpQ")]
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
    /// Data resulting of input after POI or Sale processing.
    /// </summary>
    [IsoId("_WtIAtXGoEe2TbaNWBpRZpQ")]
    [DisplayName("Input Result Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InptRsltData")]
    #endif
    [IsoXmlTag("InptRsltData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InputResultData5 InputResultData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InputResultData5 InputResultData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InputResultData5 InputResultData { get; init; } 
    #else
    public InputResultData5 InputResultData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
