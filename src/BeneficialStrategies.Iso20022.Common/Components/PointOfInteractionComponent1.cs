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
/// Data related to a component of the POI performing the transaction.
/// </summary>
[IsoId("_TF_lcAEcEeCQm6a_G2yO_w_1888102349")]
[DisplayName("Point Of Interaction Component")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteractionComponent1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PointOfInteractionComponent1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PointOfInteractionComponent1( POIComponentType1Code reqPOIComponentType )
    {
        POIComponentType = reqPOIComponentType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of component belonging to a POI Terminal.
    /// </summary>
    [IsoId("_TGJWYAEcEeCQm6a_G2yO_w_1976021057")]
    [DisplayName("POI Component Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POICmpntTp")]
    #endif
    [IsoXmlTag("POICmpntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required POIComponentType1Code POIComponentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required POIComponentType1Code POIComponentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public POIComponentType1Code POIComponentType { get; init; } 
    #else
    public POIComponentType1Code POIComponentType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the software, hardware or system provider of the POI component.
    /// </summary>
    [IsoId("_TGJWYQEcEeCQm6a_G2yO_w_-1584000009")]
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
    [IsoId("_TGJWYgEcEeCQm6a_G2yO_w_409052691")]
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
    [IsoId("_TGJWYwEcEeCQm6a_G2yO_w_702199434")]
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
    [IsoId("_TGJWZAEcEeCQm6a_G2yO_w_-1015799686")]
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
    [IsoId("_TGJWZQEcEeCQm6a_G2yO_w_1420031608")]
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
