// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains detailed information from the cancellation request (for example an MT 192 or an MT 199).
/// </summary>
[IsoId("_a4UL4CBkEei5H9PsIMzTkw")]
[DisplayName("Cancellation Request")]
public partial record CancellationRequest1
{
    #nullable enable
    
    /// <summary>
    /// Contains information on the reason for the cancellation.
    /// </summary>
    [IsoId("_z10yUCBkEei5H9PsIMzTkw")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public required CancellationReason7Code CancellationReasonInformation { get; init; } 
    
    /// <summary>
    /// Specifies a contractual obligation of one party (indemnifier) to compensate for any loss occurred to the other party (indemnity holder). 
    /// </summary>
    [IsoId("_41rXgCBkEei5H9PsIMzTkw")]
    [DisplayName("Indemnity Agreement")]
    [IsoXmlTag("IndmntyAgrmt")]
    public PendingPaymentCancellationReason2Code? IndemnityAgreement { get; init; } 
    
    
    #nullable disable
    
}
