// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Receipt6.
/// </summary>
[IsoId("_QyTiIbq9Ee68nbz8Nl_hLQ")]
[DisplayName("Receipt6")]
public partial record Receipt6
{
    #nullable enable

    /// <summary>
    /// Original Message Identification.
    /// </summary>
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required OriginalMessageAndIssuer1 OriginalMessageIdentification { get; init; } 

    /// <summary>
    /// Original Payment Identification.
    /// </summary>
    [DisplayName("Original Payment Identification")]
    [IsoXmlTag("OrgnlPmtId")]
    public PaymentIdentification8Choice_? OriginalPaymentIdentification { get; init; } 

    /// <summary>
    /// Request Handling.
    /// </summary>
    [DisplayName("Request Handling")]
    [IsoXmlTag("ReqHdlg")]
    public ValueList<RequestHandling3> RequestHandling { get; init; } = [];

    
    #nullable disable
    
}
