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
/// Magnetic track or equivalent payment card data.
/// </summary>
[IsoId("_Sqk0swEcEeCQm6a_G2yO_w_184409498")]
[DisplayName("Track Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackData1( System.String reqTrackValue )
    {
        TrackValue = reqTrackValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Track number of the card.
    /// </summary>
    [IsoId("_Sqk0tAEcEeCQm6a_G2yO_w_-165337927")]
    [DisplayName("Track Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckNb")]
    #endif
    [IsoXmlTag("TrckNb")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact1NumericText? TrackNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TrackNumber { get; init; } 
    #else
    public System.String? TrackNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Card track content or equivalent.
    /// </summary>
    [IsoId("_Sqk0tQEcEeCQm6a_G2yO_w_-1883337047")]
    [DisplayName("Track Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckVal")]
    #endif
    [IsoXmlTag("TrckVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text TrackValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TrackValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TrackValue { get; init; } 
    #else
    public System.String TrackValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
