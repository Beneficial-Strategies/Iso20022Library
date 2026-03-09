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
/// Attributes of vehicle.
/// </summary>
[IsoId("_fX6l4PTaEeife6veM7daYw")]
[DisplayName("Vehicle")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Vehicle4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the classification of the vehicle (for example, economy, intermediate, luxury, etc.)
    /// </summary>
    [IsoId("_fX6l6PTaEeife6veM7daYw")]
    [DisplayName("Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Clss")]
    #endif
    [IsoXmlTag("Clss")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Class { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Class { get; init; } 
    #else
    public System.String? Class { get; set; } 
    #endif
    
    /// <summary>
    /// Brand or manufacturer of the vehicle.
    /// </summary>
    [IsoId("_fX6l7fTaEeife6veM7daYw")]
    [DisplayName("Make")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Make")]
    #endif
    [IsoXmlTag("Make")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? Make { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Make { get; init; } 
    #else
    public System.String? Make { get; set; } 
    #endif
    
    /// <summary>
    /// Product line of vehicle within the make. 
    /// </summary>
    [IsoId("_fX6l5_TaEeife6veM7daYw")]
    [DisplayName("Model")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mdl")]
    #endif
    [IsoXmlTag("Mdl")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? Model { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Model { get; init; } 
    #else
    public System.String? Model { get; set; } 
    #endif
    
    /// <summary>
    /// Registration number of vehicle.
    /// </summary>
    [IsoId("_fX6l4vTaEeife6veM7daYw")]
    [DisplayName("Registration Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnNb")]
    #endif
    [IsoXmlTag("RegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RegistrationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RegistrationNumber { get; init; } 
    #else
    public System.String? RegistrationNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
