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
/// Travel agency component provides details of travel agency, airline, or railway transactions. 
/// </summary>
[IsoId("_H51h0_PdEeihCvvpsmGI2w")]
[DisplayName("Travel Agency")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TravelAgency2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information describing the travel agency or party providing travel-related services. 
    /// </summary>
    [IsoId("_H51h1PPdEeihCvvpsmGI2w")]
    [DisplayName("Company")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cpny")]
    #endif
    [IsoXmlTag("Cpny")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification207? Company { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification207? Company { get; init; } 
    #else
    public PartyIdentification207? Company { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information about the travel package, excluding specific itinerary data. 
    /// </summary>
    [IsoId("_H51h1fPdEeihCvvpsmGI2w")]
    [DisplayName("Travel Package")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrvlPackg")]
    #endif
    [IsoXmlTag("TrvlPackg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TravelAgencyPackage1? TravelPackage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TravelAgencyPackage1? TravelPackage { get; init; } 
    #else
    public TravelAgencyPackage1? TravelPackage { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional travel details.
    /// </summary>
    [IsoId("_zllTkPPeEeihCvvpsmGI2w")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalData { get; init; } 
    #else
    public System.String? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
