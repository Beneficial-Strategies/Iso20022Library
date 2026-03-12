// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the instruction or request is cancelled.
/// </summary>
[IsoId("_jbmdMZkLEeWn2ur3BXxtdg")]
[DisplayName("Cancellation Reason")]
public partial record CancellationReason19
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction is cancelled.
    /// </summary>
    [IsoId("_jqCh0ZkLEeWn2ur3BXxtdg")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required CancellationReason24Choice_ Code { get; init; } 
    
    /// <summary>
    /// Provides the corporate action event identification of the event that triggered the cancellation.
    /// </summary>
    [IsoId("_jqCh2ZkLEeWn2ur3BXxtdg")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoRestrictedFINMax16Text? CorporateActionEventIdentification { get; init; } 
    
    
    #nullable disable
    
}
