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
/// Provides details on the status of the cancellation of the underlying payments event.
/// </summary>
[IsoId("_ro9XFIEmEei51tn2YGQhvg")]
[DisplayName("Underlying Cancellation Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnderlyingCancellationDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information from the cancellation request.
    /// </summary>
    [IsoId("_ro9XFYEmEei51tn2YGQhvg")]
    [DisplayName("Cancellation Request Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlReqDtls")]
    #endif
    [IsoXmlTag("CxlReqDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationRequest1? CancellationRequestDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationRequest1? CancellationRequestDetails { get; init; } 
    #else
    public CancellationRequest1? CancellationRequestDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information from the cancellation response.
    /// </summary>
    [IsoId("_ro9XFoEmEei51tn2YGQhvg")]
    [DisplayName("Cancellation Response Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRspnDtls")]
    #endif
    [IsoXmlTag("CxlRspnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationResponse1? CancellationResponseDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationResponse1? CancellationResponseDetails { get; init; } 
    #else
    public CancellationResponse1? CancellationResponseDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of the cancellation request.
    /// </summary>
    [IsoId("_ro9XF4EmEei51tn2YGQhvg")]
    [DisplayName("Cancellation Request Tracking Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlReqTrckgSts")]
    #endif
    [IsoXmlTag("CxlReqTrckgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentCancellationStatusReason2Code? CancellationRequestTrackingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCancellationStatusReason2Code? CancellationRequestTrackingStatus { get; init; } 
    #else
    public PaymentCancellationStatusReason2Code? CancellationRequestTrackingStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
