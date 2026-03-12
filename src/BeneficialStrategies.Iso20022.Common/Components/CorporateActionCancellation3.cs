// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate action event cancellation status and reason.
/// </summary>
[IsoId("_OgdE4SXaEeOFIcNWlDEvdQ")]
[DisplayName("Corporate Action Cancellation")]
public partial record CorporateActionCancellation3
{
    #nullable enable
    
    /// <summary>
    /// Specifies reasons for cancellation of a corporate action event.
    /// </summary>
    [IsoId("_O42WwSXaEeOFIcNWlDEvdQ")]
    [DisplayName("Cancellation Reason Code")]
    [IsoXmlTag("CxlRsnCd")]
    public required CorporateActionCancellationReason1Code CancellationReasonCode { get; init; } 
    
    /// <summary>
    /// Additional information about cancellation of a corporate action event.
    /// </summary>
    [IsoId("_O42WySXaEeOFIcNWlDEvdQ")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? CancellationReason { get; init; } 
    
    /// <summary>
    /// Specifies the status of the details of the event.
    /// </summary>
    [IsoId("_O42W0SXaEeOFIcNWlDEvdQ")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public required CorporateActionEventStatus1 ProcessingStatus { get; init; } 
    
    
    #nullable disable
    
}
