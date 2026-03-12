// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information about an announcement.
/// </summary>
[IsoId("_RjH9odp-Ed-ak6NoX_4Aeg_245466411")]
[DisplayName("Corporate Action Notification Advice")]
public partial record CorporateActionNotificationAdvice1
{
    #nullable enable
    
    /// <summary>
    /// Provides detailed information about the corporate action event.
    /// </summary>
    [IsoId("_RjH9otp-Ed-ak6NoX_4Aeg_343360548")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public required CorporateAction2 CorporateActionDetails { get; init; } 
    
    /// <summary>
    /// Provides information about an option of a CA event.
    /// </summary>
    [IsoId("_RjH9o9p-Ed-ak6NoX_4Aeg_635191264")]
    [DisplayName("Corporate Action Option Details")]
    [IsoXmlTag("CorpActnOptnDtls")]
    public CorporateActionOption1? CorporateActionOptionDetails { get; init; } 
    
    
    #nullable disable
    
}
