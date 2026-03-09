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
/// Information about the wording for a demand guarantee, standby letter of credit or other undertaking.
/// </summary>
[IsoId("_94chlnltEeG7BsjMvd1mEw_-1148576989")]
[DisplayName("Undertaking Wording")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingWording1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Wording template for the undertaking content made available for use with certain governance rules or made available by particular institutions.
    /// </summary>
    [IsoId("_94chl3ltEeG7BsjMvd1mEw_-840429331")]
    [DisplayName("Model Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MdlForm")]
    #endif
    [IsoXmlTag("MdlForm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ModelFormIdentification1? ModelForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModelFormIdentification1? ModelForm { get; init; } 
    #else
    public ModelFormIdentification1? ModelForm { get; set; } 
    #endif
    
    /// <summary>
    /// Language of the standard wording provided by the issuer.
    /// </summary>
    [IsoId("_94mSkHltEeG7BsjMvd1mEw_1792554294")]
    [DisplayName("Requested Wording Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdWrdgLang")]
    #endif
    [IsoXmlTag("ReqdWrdgLang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO2ALanguageCode? RequestedWordingLanguage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RequestedWordingLanguage { get; init; } 
    #else
    public string? RequestedWordingLanguage { get; set; } 
    #endif
    
    /// <summary>
    /// Terms and conditions of the undertaking.
    /// </summary>
    [IsoId("_94mSkXltEeG7BsjMvd1mEw_-752831189")]
    [DisplayName("Undertaking Terms And Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgTermsAndConds")]
    #endif
    [IsoXmlTag("UdrtkgTermsAndConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Narrative1? UndertakingTermsAndConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Narrative1? UndertakingTermsAndConditions { get; init; } 
    #else
    public Narrative1? UndertakingTermsAndConditions { get; set; } 
    #endif
    
    
    #nullable disable
    
}
