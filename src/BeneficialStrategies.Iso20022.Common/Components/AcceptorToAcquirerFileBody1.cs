// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor To Acquirer File Body1.
/// </summary>
[IsoId("_V64L4JUVEe6YroSumzeMDQ")]
[DisplayName("Acceptor To Acquirer File Body1")]
public record AcceptorToAcquirerFileBody1
{
    /// <summary>
    /// Batch Transfer.
    /// </summary>
    [DisplayName("Batch Transfer")]
    [IsoXmlTag("BtchTrf")]
    public CardPaymentBatchTransfer12? BatchTransfer { get; init; }

    /// <summary>
    /// Cancellation Advice.
    /// </summary>
    [DisplayName("Cancellation Advice")]
    [IsoXmlTag("CxlAdvc")]
    public AcceptorCancellationAdvice13? CancellationAdvice { get; init; }

    /// <summary>
    /// Completion Advice.
    /// </summary>
    [DisplayName("Completion Advice")]
    [IsoXmlTag("CmpltnAdvc")]
    public AcceptorCompletionAdvice13? CompletionAdvice { get; init; }
}
