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
/// Rating and source of the rating of the financial instrument.
/// </summary>
[IsoId("_6xRCcL_IEeuexrfMa3dl_Q")]
[DisplayName("Rating")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Rating2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Rating2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Rating2( System.String reqRating,MarketIdentification89 reqSourceOfRating )
    {
        Rating = reqRating;
        SourceOfRating = reqSourceOfRating;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the rating of the financial instrument.
    /// </summary>
    [IsoId("_Bwe3Ub_JEeuexrfMa3dl_Q")]
    [DisplayName("Rating")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ratg")]
    #endif
    [IsoXmlTag("Ratg")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax10Text Rating { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Rating { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Rating { get; init; } 
    #else
    public System.String Rating { get; set; } 
    #endif
    
    /// <summary>
    /// Agency, which provides rating services, for example, Moody&apos;s and S&amp;P.
    /// </summary>
    [IsoId("_D8xvwb_JEeuexrfMa3dl_Q")]
    [DisplayName("Source Of Rating")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcOfRatg")]
    #endif
    [IsoXmlTag("SrcOfRatg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarketIdentification89 SourceOfRating { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarketIdentification89 SourceOfRating { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification89 SourceOfRating { get; init; } 
    #else
    public MarketIdentification89 SourceOfRating { get; set; } 
    #endif
    
    
    #nullable disable
    
}
