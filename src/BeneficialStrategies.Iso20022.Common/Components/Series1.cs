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
/// Identification of a series.
/// </summary>
[IsoId("_ZD4mEEgQEea9YuSvQGoi-w")]
[DisplayName("Series")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Series1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Issue date of the fund series. It is typically applicable to a redemption order, subscription order confirmation or redemption order confirmation, but may be specified in the subscription order, if known.
    /// </summary>
    [IsoId("_Cf7MoJBsEeaGiLsfv6g8MA")]
    [DisplayName("Series Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrsDt")]
    #endif
    [IsoXmlTag("SrsDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat42Choice_? SeriesDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat42Choice_? SeriesDate { get; init; } 
    #else
    public DateFormat42Choice_? SeriesDate { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the fund series. It is typically applicable to a redemption order, subscription order confirmation or redemption order confirmation, but may be specified in the subscription, if known.
    /// </summary>
    [IsoId("_81Imc0gREea9YuSvQGoi-w")]
    [DisplayName("Series Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrsNm")]
    #endif
    [IsoXmlTag("SrsNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SeriesName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SeriesName { get; init; } 
    #else
    public System.String? SeriesName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
