// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the request.
/// </summary>
[IsoId("_IC3ysW4-EeiU9cctagi5ow")]
[DisplayName("Receipt")]
public partial record Receipt3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the original request message.
    /// </summary>
    [IsoId("_IMaJM24-EeiU9cctagi5ow")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required OriginalMessageAndIssuer1 OriginalMessageIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the original transaction identification, when the request for which the receipt is generated is a payment transaction.
    /// </summary>
    [IsoId("_IMaJNW4-EeiU9cctagi5ow")]
    [DisplayName("Original Payment Identification")]
    [IsoXmlTag("OrgnlPmtId")]
    public PaymentIdentification6Choice_? OriginalPaymentIdentification { get; init; } 
    
    /// <summary>
    /// Gives the status of the request.
    /// </summary>
    [IsoId("_IMaJN24-EeiU9cctagi5ow")]
    [DisplayName("Request Handling")]
    [IsoXmlTag("ReqHdlg")]
    public RequestHandling1? RequestHandling { get; init; } 
    
    
    #nullable disable
    
}
