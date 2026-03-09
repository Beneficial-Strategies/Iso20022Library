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
/// Identification of the place of safekeeping expressed as a code and a narrative description.
/// </summary>
[IsoId("_cj_8n5KQEeWHWpTQn1FFVg")]
[DisplayName("Safekeeping Place Type And Text")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SafekeepingPlaceTypeAndText15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SafekeepingPlaceTypeAndText15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SafekeepingPlaceTypeAndText15( SafekeepingPlace3Code reqSafekeepingPlaceType )
    {
        SafekeepingPlaceType = reqSafekeepingPlaceType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    [IsoId("_cj_8oZKQEeWHWpTQn1FFVg")]
    [DisplayName("Safekeeping Place Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlcTp")]
    #endif
    [IsoXmlTag("SfkpgPlcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SafekeepingPlace3Code SafekeepingPlaceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SafekeepingPlace3Code SafekeepingPlaceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlace3Code SafekeepingPlaceType { get; init; } 
    #else
    public SafekeepingPlace3Code SafekeepingPlaceType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the place of safekeeping.
    /// </summary>
    [IsoId("_cj_8qZKQEeWHWpTQn1FFVg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax30Text)]
    [StringLength(maximumLength: 30 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax30Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
