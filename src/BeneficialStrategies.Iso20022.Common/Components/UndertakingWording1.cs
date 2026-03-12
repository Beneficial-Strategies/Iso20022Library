// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the wording for a demand guarantee, standby letter of credit or other undertaking.
/// </summary>
[IsoId("_94chlnltEeG7BsjMvd1mEw_-1148576989")]
[DisplayName("Undertaking Wording")]
public partial record UndertakingWording1
{
    #nullable enable
    
    /// <summary>
    /// Wording template for the undertaking content made available for use with certain governance rules or made available by particular institutions.
    /// </summary>
    [IsoId("_94chl3ltEeG7BsjMvd1mEw_-840429331")]
    [DisplayName("Model Form")]
    [IsoXmlTag("MdlForm")]
    public ModelFormIdentification1? ModelForm { get; init; } 
    
    /// <summary>
    /// Language of the standard wording provided by the issuer.
    /// </summary>
    [IsoId("_94mSkHltEeG7BsjMvd1mEw_1792554294")]
    [DisplayName("Requested Wording Language")]
    [IsoXmlTag("ReqdWrdgLang")]
    public ISO2ALanguageCode? RequestedWordingLanguage { get; init; } 
    
    /// <summary>
    /// Terms and conditions of the undertaking.
    /// </summary>
    [IsoId("_94mSkXltEeG7BsjMvd1mEw_-752831189")]
    [DisplayName("Undertaking Terms And Conditions")]
    [IsoXmlTag("UdrtkgTermsAndConds")]
    public Narrative1? UndertakingTermsAndConditions { get; init; } 
    
    
    #nullable disable
    
}
