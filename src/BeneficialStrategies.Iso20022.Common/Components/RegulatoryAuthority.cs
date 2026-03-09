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
/// Entity requiring the regulatory reporting information.
/// </summary>
[IsoId("_PbYOANp-Ed-ak6NoX_4Aeg_602491363")]
[DisplayName("Regulatory Authority")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegulatoryAuthority
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the entity requiring the regulatory reporting information.
    /// </summary>
    [IsoId("_PbYOAdp-Ed-ak6NoX_4Aeg_1073487607")]
    [DisplayName("Authority Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthrtyNm")]
    #endif
    [IsoXmlTag("AuthrtyNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AuthorityName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthorityName { get; init; } 
    #else
    public System.String? AuthorityName { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the entity requiring the regulatory reporting information.
    /// </summary>
    [IsoId("_PbYOAtp-Ed-ak6NoX_4Aeg_1100271075")]
    [DisplayName("Authority Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthrtyCtry")]
    #endif
    [IsoXmlTag("AuthrtyCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? AuthorityCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? AuthorityCountry { get; init; } 
    #else
    public string? AuthorityCountry { get; set; } 
    #endif
    
    
    #nullable disable
    
}
