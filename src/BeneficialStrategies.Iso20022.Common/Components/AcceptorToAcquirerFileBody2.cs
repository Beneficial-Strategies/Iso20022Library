// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor To Acquirer File Body2.
/// </summary>
[IsoId("_XlWPcaE8Ee-MRKYsaX6JDg")]
[DisplayName("Acceptor To Acquirer File Body2")]
public record AcceptorToAcquirerFileBody2
{
    /// <summary>
    /// Batch Transfer.
    /// </summary>
    [DisplayName("Batch Transfer")]
    [IsoXmlTag("BtchTrf")]
    public CardPaymentBatchTransfer13? BatchTransfer { get; init; }

    /// <summary>
    /// Cancellation Advice.
    /// </summary>
    [DisplayName("Cancellation Advice")]
    [IsoXmlTag("CxlAdvc")]
    public AcceptorCancellationAdvice14? CancellationAdvice { get; init; }

    /// <summary>
    /// Completion Advice.
    /// </summary>
    [DisplayName("Completion Advice")]
    [IsoXmlTag("CmpltnAdvc")]
    public AcceptorCompletionAdvice14? CompletionAdvice { get; init; }
}
