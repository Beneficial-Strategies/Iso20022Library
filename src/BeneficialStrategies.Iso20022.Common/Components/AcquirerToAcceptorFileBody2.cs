// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer To Acceptor File Body2.
/// </summary>
[IsoId("_j3JDIaE6Ee-MRKYsaX6JDg")]
[DisplayName("Acquirer To Acceptor File Body2")]
public record AcquirerToAcceptorFileBody2
{
    /// <summary>
    /// Batch Transfer Response.
    /// </summary>
    [DisplayName("Batch Transfer Response")]
    [IsoXmlTag("BtchTrfRspn")]
    public CardPaymentBatchTransferResponse12? BatchTransferResponse { get; init; }

    /// <summary>
    /// Cancellation Response.
    /// </summary>
    [DisplayName("Cancellation Response")]
    [IsoXmlTag("CxlRspn")]
    public AcceptorCancellationAdviceResponse13? CancellationResponse { get; init; }

    /// <summary>
    /// Completion Advice Response.
    /// </summary>
    [DisplayName("Completion Advice Response")]
    [IsoXmlTag("CmpltnAdvcRspn")]
    public AcceptorCompletionAdviceResponse13? CompletionAdviceResponse { get; init; }
}
