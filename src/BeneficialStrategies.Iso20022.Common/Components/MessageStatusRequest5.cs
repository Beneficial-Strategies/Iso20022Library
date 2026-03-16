// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contents information to identify a previous exchange.
/// </summary>
[IsoId("_d_IAYU6tEeyGi9JAv6wq7Q")]
[DisplayName("Message Status Request")]
public record MessageStatusRequest5
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_eFo4EU6tEeyGi9JAv6wq7Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment78 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_eFo4E06tEeyGi9JAv6wq7Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext29 Context { get; init; }

    /// <summary>
    /// Identification of the previous exchange.
    /// </summary>
    [IsoId("_eFo4FU6tEeyGi9JAv6wq7Q")]
    [DisplayName("Message Status Request Data")]
    [IsoXmlTag("MsgStsReqData")]
    public required MessageStatusRequestData2 MessageStatusRequestData { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_eFo4F06tEeyGi9JAv6wq7Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
