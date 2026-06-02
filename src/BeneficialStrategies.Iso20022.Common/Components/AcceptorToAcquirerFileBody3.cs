// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Messages that can be exchanged between an acceptor and an acquirer.
/// </summary>
[IsoId("_MpfZQbX2EfCUZfsQO4rYeA")]
[DisplayName("Acceptor To Acquirer File Body3")]
public record AcceptorToAcquirerFileBody3
{
    /// <summary>
    /// Information related to the completion advice.
    /// </summary>
    [IsoId("_Mqb0dbX2EfCUZfsQO4rYeA")]
    [DisplayName("Completion Advice")]
    [IsoXmlTag("CmpltnAdvc")]
    public AcceptorCompletionAdvice15? CompletionAdvice { get; init; }

    /// <summary>
    /// Information related to the cancellation advice.
    /// </summary>
    [IsoId("_Mqb0e7X2EfCUZfsQO4rYeA")]
    [DisplayName("Cancellation Advice")]
    [IsoXmlTag("CxlAdvc")]
    public AcceptorCancellationAdvice15? CancellationAdvice { get; init; }

    /// <summary>
    /// Card payment transactions from one or several data set of transactions.
    /// </summary>
    [IsoId("_Mqb0gbX2EfCUZfsQO4rYeA")]
    [DisplayName("Batch Transfer")]
    [IsoXmlTag("BtchTrf")]
    public CardPaymentBatchTransfer14? BatchTransfer { get; init; }
}
