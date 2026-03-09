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
/// Assessment of securities credit and investment risk.
/// </summary>
[IsoId("_S1iAuNp-Ed-ak6NoX_4Aeg_-610008315")]
[DisplayName("Rating")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Rating1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Rating1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Rating1( System.String reqRatingScheme,System.DateTime reqValueDate,System.String reqValueIdentification )
    {
        RatingScheme = reqRatingScheme;
        ValueDate = reqValueDate;
        ValueIdentification = reqValueIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information regarding the entity that assigns the rating.
    /// </summary>
    [IsoId("_S1iAudp-Ed-ak6NoX_4Aeg_-1436888380")]
    [DisplayName("Rating Scheme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RatgSchme")]
    #endif
    [IsoXmlTag("RatgSchme")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RatingScheme { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RatingScheme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RatingScheme { get; init; } 
    #else
    public System.String RatingScheme { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time as from which the rating is valid.
    /// </summary>
    [IsoId("_S1iAutp-Ed-ak6NoX_4Aeg_-1436888328")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ValueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ValueDate { get; init; } 
    #else
    public System.DateTime ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the rating, which has been assigned to a security by a rating agency.
    /// </summary>
    [IsoId("_S1iAu9p-Ed-ak6NoX_4Aeg_-1436888268")]
    [DisplayName("Value Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValId")]
    #endif
    [IsoXmlTag("ValId")]
    [IsoSimpleType(IsoSimpleType.RatingValueIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRatingValueIdentifier ValueIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ValueIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ValueIdentification { get; init; } 
    #else
    public System.String ValueIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
