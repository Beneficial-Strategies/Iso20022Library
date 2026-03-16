// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer To Acceptor File Body2.
/// </summary>
[IsoId("_j3JDIaE6Ee-MRKYsaX6JDg")]
[DisplayName("Acquirer To Acceptor File Body2")]
public partial record AcquirerToAcceptorFileBody2
{
    #nullable enable

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

    
    #nullable disable
    
}
