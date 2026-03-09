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
/// Customer security identification reference information.
/// </summary>
[IsoId("_ja7hEb5XEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Notification SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNotificationSD10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_jrS4Ub5XEeexmbB7KsjCwA")]
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
    /// Internal security identification as provided by the customer for the given security on the security of interest (SOI) import file.
    /// </summary>
    [IsoId("_jrS4U75XEeexmbB7KsjCwA")]
    [DisplayName("Customer Internal Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrIntlSctyId")]
    #endif
    [IsoXmlTag("CstmrIntlSctyId")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax16Text? CustomerInternalSecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerInternalSecurityIdentification { get; init; } 
    #else
    public System.String? CustomerInternalSecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Security identifier that is used to match the customer&apos;s SOI (Security of Interest) to the GCA VS Security Cross Reference.
    /// </summary>
    [IsoId("_jrS4W75XEeexmbB7KsjCwA")]
    [DisplayName("Security Of Interest Matching Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyOfIntrstMtchgScty")]
    #endif
    [IsoXmlTag("SctyOfIntrstMtchgScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification20? SecurityOfInterestMatchingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification20? SecurityOfInterestMatchingSecurity { get; init; } 
    #else
    public SecurityIdentification20? SecurityOfInterestMatchingSecurity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
