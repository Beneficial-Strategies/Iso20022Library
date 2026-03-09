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
[IsoId("_iy9JkfNAEeqRfth943bvEA")]
[DisplayName("Corporate Event Narrative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateEventNarrative3
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
    [IsoId("_jGvoQfNAEeqRfth943bvEA")]
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
    
    
    #nullable disable
    
}
