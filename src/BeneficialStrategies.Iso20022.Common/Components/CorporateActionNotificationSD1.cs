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
[IsoId("_1Tg-ADL3EeKU9IrkkToqcw_-2108418056")]
[DisplayName("Corporate Action Notification SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNotificationSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionNotificationSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionNotificationSD1( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1Tg-ATL3EeKU9IrkkToqcw_1641834561")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Internal security identification as provided by the customer for the given security on the security of interest (SOI) import file.
    /// </summary>
    [IsoId("_1Tg-AjL3EeKU9IrkkToqcw_-48041887")]
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
    [IsoId("_1Tg-AzL3EeKU9IrkkToqcw_-1925537148")]
    [DisplayName("Security Of Interest Matching Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyOfIntrstMtchgScty")]
    #endif
    [IsoXmlTag("SctyOfIntrstMtchgScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification15? SecurityOfInterestMatchingSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification15? SecurityOfInterestMatchingSecurity { get; init; } 
    #else
    public SecurityIdentification15? SecurityOfInterestMatchingSecurity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
