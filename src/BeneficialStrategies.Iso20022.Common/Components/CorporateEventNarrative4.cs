// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides disclaimer narrative information about the event.
/// </summary>
[IsoId("_qwMS0RreEeyhRdHRjakS2w")]
[DisplayName("Corporate Event Narrative")]
public partial record CorporateEventNarrative4
{
    #nullable enable
    
    /// <summary>
    /// Issuer’s disclaimer notice relative to the meeting announcement information provided. It may be ignored for automated processing.
    /// </summary>
    [IsoId("_rEmckRreEeyhRdHRjakS2w")]
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    public LanguageSpecifiedNarrative1? Disclaimer { get; init; } 
    
    /// <summary>
    /// Provides additional information from the account servicer or a service provider solely intended for the next immediate account holder to enable or facilitate event processing between parties.
    /// </summary>
    [IsoId("_pSdwkRreEeyhRdHRjakS2w")]
    [DisplayName("Processing Text For Next Intermediary")]
    [IsoXmlTag("PrcgTxtForNxtIntrmy")]
    [IsoSimpleType(IsoSimpleType.Max8000Text)]
    [StringLength(maximumLength: 8000 ,MinimumLength = 1)]
    public IsoMax8000Text? ProcessingTextForNextIntermediary { get; init; } 
    
    
    #nullable disable
    
}
