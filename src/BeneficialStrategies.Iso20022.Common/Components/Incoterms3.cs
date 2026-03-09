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
/// Specifies the applicable Incoterm and associated location.
/// </summary>
[IsoId("_S5VCYwEcEeCQm6a_G2yO_w_154174815")]
[DisplayName("Incoterms")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Incoterms3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Incoterms3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Incoterms3( Incoterms4Choice_ reqIncotermsCode )
    {
        IncotermsCode = reqIncotermsCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the Incoterms.
    /// </summary>
    [IsoId("_S5VCZAEcEeCQm6a_G2yO_w_129737747")]
    [DisplayName("Incoterms Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncotrmsCd")]
    #endif
    [IsoXmlTag("IncotrmsCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Incoterms4Choice_ IncotermsCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Incoterms4Choice_ IncotermsCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Incoterms4Choice_ IncotermsCode { get; init; } 
    #else
    public Incoterms4Choice_ IncotermsCode { get; set; } 
    #endif
    
    /// <summary>
    /// Location where the Incoterms are actioned. Reference UN/ECE Recommendation 16 - LOCODE - Code for Trade and Transport Locations (www.unece.org/cefact/recommendations).
    /// </summary>
    [IsoId("_S5VCZQEcEeCQm6a_G2yO_w_-956736604")]
    [DisplayName("Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lctn")]
    #endif
    [IsoXmlTag("Lctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Location { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Location { get; init; } 
    #else
    public System.String? Location { get; set; } 
    #endif
    
    
    #nullable disable
    
}
