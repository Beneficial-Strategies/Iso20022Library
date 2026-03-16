// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Receipt7.
/// </summary>
[IsoId("_4lB5gVQBEe-Fk_N0FBjY0Q")]
[DisplayName("Receipt7")]
public record Receipt7
{
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
    public ValueList<RequestHandling4> RequestHandling { get; init; } = [];
}
