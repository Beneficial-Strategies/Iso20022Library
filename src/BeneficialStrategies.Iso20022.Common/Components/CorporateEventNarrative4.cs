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
/// Provides disclaimer narrative information about the event.
/// </summary>
[IsoId("_qwMS0RreEeyhRdHRjakS2w")]
[DisplayName("Corporate Event Narrative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateEventNarrative4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Issuer’s disclaimer notice relative to the meeting announcement information provided. It may be ignored for automated processing.
    /// </summary>
    [IsoId("_rEmckRreEeyhRdHRjakS2w")]
    [DisplayName("Disclaimer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dsclmr")]
    #endif
    [IsoXmlTag("Dsclmr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageSpecifiedNarrative1? Disclaimer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LanguageSpecifiedNarrative1? Disclaimer { get; init; } 
    #else
    public LanguageSpecifiedNarrative1? Disclaimer { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information from the account servicer or a service provider solely intended for the next immediate account holder to enable or facilitate event processing between parties.
    /// </summary>
    [IsoId("_pSdwkRreEeyhRdHRjakS2w")]
    [DisplayName("Processing Text For Next Intermediary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgTxtForNxtIntrmy")]
    #endif
    [IsoXmlTag("PrcgTxtForNxtIntrmy")]
    [IsoSimpleType(IsoSimpleType.Max8000Text)]
    [StringLength(maximumLength: 8000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax8000Text? ProcessingTextForNextIntermediary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProcessingTextForNextIntermediary { get; init; } 
    #else
    public System.String? ProcessingTextForNextIntermediary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
