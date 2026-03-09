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
/// Data related to a component of the POI.
/// </summary>
[IsoId("_LYLC4H1DEeCF8NjrBemJWQ_1913950683")]
[DisplayName("Point Of Interaction Component")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionComponent2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PointOfInteractionComponent2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PointOfInteractionComponent2( POIComponentType2Code reqPOIComponentType )
    {
        POIComponentType = reqPOIComponentType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of component belonging to a POI Terminal.
    /// </summary>
    [IsoId("_LYLC4X1DEeCF8NjrBemJWQ_1800111617")]
    [DisplayName("POI Component Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POICmpntTp")]
    #endif
    [IsoXmlTag("POICmpntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required POIComponentType2Code POIComponentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required POIComponentType2Code POIComponentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public POIComponentType2Code POIComponentType { get; init; } 
    #else
    public POIComponentType2Code POIComponentType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the software, hardware or system provider of the POI component.
    /// </summary>
    [IsoId("_LYUz4H1DEeCF8NjrBemJWQ_803039264")]
    [DisplayName("Manufacturer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ManfctrId")]
    #endif
    [IsoXmlTag("ManfctrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ManufacturerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ManufacturerIdentification { get; init; } 
    #else
    public System.String? ManufacturerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a model of POI component for a given manufacturer.
    /// </summary>
    [IsoId("_LYUz4X1DEeCF8NjrBemJWQ_-194033089")]
    [DisplayName("Model")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mdl")]
    #endif
    [IsoXmlTag("Mdl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Model { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Model { get; init; } 
    #else
    public System.String? Model { get; set; } 
    #endif
    
    /// <summary>
    /// Version of component belonging to a given model.
    /// </summary>
    [IsoId("_LYUz4n1DEeCF8NjrBemJWQ_-1191105442")]
    [DisplayName("Version Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VrsnNb")]
    #endif
    [IsoXmlTag("VrsnNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax16Text? VersionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VersionNumber { get; init; } 
    #else
    public System.String? VersionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Serial number of a component.
    /// </summary>
    [IsoId("_LYUz431DEeCF8NjrBemJWQ_2106789501")]
    [DisplayName("Serial Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrlNb")]
    #endif
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SerialNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SerialNumber { get; init; } 
    #else
    public System.String? SerialNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Unique approval number for a component, delivered by a certification body.
    /// Usage: More than one approval number could be present, when assigned by different bodies. The certification body identification must be provided within the approval number (for example at the beginning of the value).
    /// </summary>
    [IsoId("_LYUz5H1DEeCF8NjrBemJWQ_1109717148")]
    [DisplayName("Approval Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApprvlNb")]
    #endif
    [IsoXmlTag("ApprvlNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? ApprovalNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApprovalNumber { get; init; } 
    #else
    public System.String? ApprovalNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
