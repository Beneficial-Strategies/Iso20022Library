// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of financial services to be used with this message of reconciliation. There is only one service: ReconciliationRequest.
/// </summary>
[IsoId("_990_obYBEfCUZfsQO4rYeA")]
[DisplayName("Reconciliation Request9")]
public record ReconciliationRequest9
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_9-u-lbYBEfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment82 Environment { get; init; }

    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_9-u-m7YBEfCUZfsQO4rYeA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required PaymentContext30 Context { get; init; }

    /// <summary>
    /// Content of the Reconciliation Request message.
    /// </summary>
    [IsoId("_9-u-obYBEfCUZfsQO4rYeA")]
    [DisplayName("Reconciliation Request Data")]
    [IsoXmlTag("RcncltnReqData")]
    public required ReconciliationRequestData1 ReconciliationRequestData { get; init; }

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_9-u-p7YBEfCUZfsQO4rYeA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
