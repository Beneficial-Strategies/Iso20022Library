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
/// Extension to identify an underlying security by proprietary or domestic identification scheme.
/// </summary>
[IsoId("_BzN9EDE4EeG99IlTgANSrw")]
[DisplayName("Other Identification 2 SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherIdentification2SD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OtherIdentification2SD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OtherIdentification2SD1( System.String reqAbbreviatedLocalLanguageSecurityName )
    {
        AbbreviatedLocalLanguageSecurityName = reqAbbreviatedLocalLanguageSecurityName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_j317kFO_EeGs_NnqHXQZkw")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Full and formal name of underlying securities in the local language.
    /// </summary>
    [IsoId("_r8BK0DE4EeG99IlTgANSrw")]
    [DisplayName("Local Language Security Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclLangSctyNm")]
    #endif
    [IsoXmlTag("LclLangSctyNm")]
    [IsoSimpleType(IsoSimpleType.Max240Text)]
    [StringLength(maximumLength: 240 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax240Text? LocalLanguageSecurityName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LocalLanguageSecurityName { get; init; } 
    #else
    public System.String? LocalLanguageSecurityName { get; set; } 
    #endif
    
    /// <summary>
    /// Abbreviated name of underlying securities in the local language. 
    /// In case of non-listed securities, it will be a full local language security name.
    ///  銘柄名（銘柄略称.
    /// </summary>
    [IsoId("_YUB3MGHCEeGknP6xAc4fKw")]
    [DisplayName("Abbreviated Local Language Security Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AbbrvtdLclLangSctyNm")]
    #endif
    [IsoXmlTag("AbbrvtdLclLangSctyNm")]
    [IsoSimpleType(IsoSimpleType.Max240Text)]
    [StringLength(maximumLength: 240 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax240Text AbbreviatedLocalLanguageSecurityName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AbbreviatedLocalLanguageSecurityName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AbbreviatedLocalLanguageSecurityName { get; init; } 
    #else
    public System.String AbbreviatedLocalLanguageSecurityName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
