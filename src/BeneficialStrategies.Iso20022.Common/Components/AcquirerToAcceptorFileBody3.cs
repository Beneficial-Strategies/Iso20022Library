// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Messages that can be exchanged between an acquirer and an acceptor.
/// </summary>
[IsoId("_8my8QbX2EfCUZfsQO4rYeA")]
[DisplayName("Acquirer To Acceptor File Body3")]
public record AcquirerToAcceptorFileBody3
{
    /// <summary>
    /// Information related to the completion advice response.
    /// </summary>
    [IsoId("_8ns7NbX2EfCUZfsQO4rYeA")]
    [DisplayName("Completion Advice Response")]
    [IsoXmlTag("CmpltnAdvcRspn")]
    public AcceptorCompletionAdviceResponse14? CompletionAdviceResponse { get; init; }

    /// <summary>
    /// Information related to the cancellation advice response.
    /// </summary>
    [IsoId("_8ns7O7X2EfCUZfsQO4rYeA")]
    [DisplayName("Cancellation Response")]
    [IsoXmlTag("CxlRspn")]
    public AcceptorCancellationAdviceResponse14? CancellationResponse { get; init; }

    /// <summary>
    /// Information related to the previously sent set of transaction.
    /// </summary>
    [IsoId("_8ns7QbX2EfCUZfsQO4rYeA")]
    [DisplayName("Batch Transfer Response")]
    [IsoXmlTag("BtchTrfRspn")]
    public CardPaymentBatchTransferResponse13? BatchTransferResponse { get; init; }
}
