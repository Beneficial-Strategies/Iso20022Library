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
[IsoId("_SfVHMNp-Ed-ak6NoX_4Aeg_813979411")]
[DisplayName("Safekeeping Place Type And Text")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SafekeepingPlaceTypeAndText2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SafekeepingPlaceTypeAndText2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SafekeepingPlaceTypeAndText2( SafekeepingPlace2Code reqSafekeepingPlaceType )
    {
        SafekeepingPlaceType = reqSafekeepingPlaceType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    [IsoId("_SfVHMdp-Ed-ak6NoX_4Aeg_813979454")]
    [DisplayName("Safekeeping Place Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlcTp")]
    #endif
    [IsoXmlTag("SfkpgPlcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SafekeepingPlace2Code SafekeepingPlaceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SafekeepingPlace2Code SafekeepingPlaceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlace2Code SafekeepingPlaceType { get; init; } 
    #else
    public SafekeepingPlace2Code SafekeepingPlaceType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the place of safekeeping.
    /// </summary>
    [IsoId("_SfVHMtp-Ed-ak6NoX_4Aeg_813979766")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
