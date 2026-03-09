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
/// Provides additional information such as the taxation conditions.
/// </summary>
[IsoId("_UMGyGdp-Ed-ak6NoX_4Aeg_804947111")]
[DisplayName("Corporate Action Narrative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNarrative3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the entity making the offer and is different from the issuing company.
    /// </summary>
    [IsoId("_UMGyGtp-Ed-ak6NoX_4Aeg_1018863277")]
    [DisplayName("Offeror")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Offerr")]
    #endif
    [IsoXmlTag("Offerr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation3? Offeror { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation3? Offeror { get; init; } 
    #else
    public UpdatedAdditionalInformation3? Offeror { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the new name of a company following a name change.
    /// </summary>
    [IsoId("_UMGyG9p-Ed-ak6NoX_4Aeg_1284571115")]
    [DisplayName("New Company Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewCpnyNm")]
    #endif
    [IsoXmlTag("NewCpnyNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation3? NewCompanyName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation3? NewCompanyName { get; init; } 
    #else
    public UpdatedAdditionalInformation3? NewCompanyName { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the web address published for the event, that is, the address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_UMQjENp-Ed-ak6NoX_4Aeg_399242966")]
    [DisplayName("URL Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="URLAdr")]
    #endif
    [IsoXmlTag("URLAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedURLlnformation? URLAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedURLlnformation? URLAddress { get; init; } 
    #else
    public UpdatedURLlnformation? URLAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
