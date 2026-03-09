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
/// Identification of a point of interaction.
/// </summary>
[IsoId("_9wj-QI4UEeW6h7rGyYlyTg")]
[DisplayName("Point Of Interaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PointOfInteraction6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PointOfInteraction6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PointOfInteraction6( System.String reqManufacturerIdentifier,System.String reqModel,System.String reqSerialNumber )
    {
        ManufacturerIdentifier = reqManufacturerIdentifier;
        Model = reqModel;
        SerialNumber = reqSerialNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifier of the terminal manufacturer.
    /// </summary>
    [IsoId("_ISnAsI4VEeW6h7rGyYlyTg")]
    [DisplayName("Manufacturer Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ManfctrIdr")]
    #endif
    [IsoXmlTag("ManfctrIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ManufacturerIdentifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ManufacturerIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ManufacturerIdentifier { get; init; } 
    #else
    public System.String ManufacturerIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of the terminal model.
    /// </summary>
    [IsoId("_K-fYII4VEeW6h7rGyYlyTg")]
    [DisplayName("Model")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mdl")]
    #endif
    [IsoXmlTag("Mdl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Model { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Model { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Model { get; init; } 
    #else
    public System.String Model { get; set; } 
    #endif
    
    /// <summary>
    /// Serial number of the terminal manufacturer.
    /// </summary>
    [IsoId("_N5OD4I4VEeW6h7rGyYlyTg")]
    [DisplayName("Serial Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrlNb")]
    #endif
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SerialNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SerialNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SerialNumber { get; init; } 
    #else
    public System.String SerialNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
