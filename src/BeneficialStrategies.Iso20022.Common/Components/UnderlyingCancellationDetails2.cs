// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the status of the cancellation of the underlying payments event.
/// </summary>
[IsoId("_ro9XFIEmEei51tn2YGQhvg")]
[DisplayName("Underlying Cancellation Details")]
public partial record UnderlyingCancellationDetails2
{
    #nullable enable
    
    /// <summary>
    /// Provides information from the cancellation request.
    /// </summary>
    [IsoId("_ro9XFYEmEei51tn2YGQhvg")]
    [DisplayName("Cancellation Request Details")]
    [IsoXmlTag("CxlReqDtls")]
    public CancellationRequest1? CancellationRequestDetails { get; init; } 
    
    /// <summary>
    /// Provides information from the cancellation response.
    /// </summary>
    [IsoId("_ro9XFoEmEei51tn2YGQhvg")]
    [DisplayName("Cancellation Response Details")]
    [IsoXmlTag("CxlRspnDtls")]
    public CancellationResponse1? CancellationResponseDetails { get; init; } 
    
    /// <summary>
    /// Specifies the status of the cancellation request.
    /// </summary>
    [IsoId("_ro9XF4EmEei51tn2YGQhvg")]
    [DisplayName("Cancellation Request Tracking Status")]
    [IsoXmlTag("CxlReqTrckgSts")]
    public PaymentCancellationStatusReason2Code? CancellationRequestTrackingStatus { get; init; } 
    
    
    #nullable disable
    
}
