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
/// Extension for identification of a party.
/// </summary>
[IsoId("_wNKtoDFREeGpgKb_ecoJPw")]
[DisplayName("Organisation Identification SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OrganisationIdentificationSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OrganisationIdentificationSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OrganisationIdentificationSD1( System.String reqLocalLanguageName )
    {
        LocalLanguageName = reqLocalLanguageName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_crO00FPIEeGs_NnqHXQZkw")]
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
    /// Name in the local language by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_hVxlNWzeEeGa9q9Mq4E7uA")]
    [DisplayName("Local Language Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclLangNm")]
    #endif
    [IsoXmlTag("LclLangNm")]
    [IsoSimpleType(IsoSimpleType.Max240Text)]
    [StringLength(maximumLength: 240 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax240Text LocalLanguageName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LocalLanguageName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LocalLanguageName { get; init; } 
    #else
    public System.String LocalLanguageName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
