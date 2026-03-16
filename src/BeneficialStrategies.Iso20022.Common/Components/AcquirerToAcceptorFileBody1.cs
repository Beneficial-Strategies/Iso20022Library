// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer To Acceptor File Body1.
/// </summary>
[IsoId("_NY2n0JUSEe6YroSumzeMDQ")]
[DisplayName("Acquirer To Acceptor File Body1")]
public partial record AcquirerToAcceptorFileBody1
{
    #nullable enable

    /// <summary>
    /// Batch Transfer Response.
    /// </summary>
    [DisplayName("Batch Transfer Response")]
    [IsoXmlTag("BtchTrfRspn")]
    public CardPaymentBatchTransferResponse11? BatchTransferResponse { get; init; } 

    /// <summary>
    /// Cancellation Response.
    /// </summary>
    [DisplayName("Cancellation Response")]
    [IsoXmlTag("CxlRspn")]
    public AcceptorCancellationAdviceResponse12? CancellationResponse { get; init; } 

    /// <summary>
    /// Completion Advice Response.
    /// </summary>
    [DisplayName("Completion Advice Response")]
    [IsoXmlTag("CmpltnAdvcRspn")]
    public AcceptorCompletionAdviceResponse12? CompletionAdviceResponse { get; init; } 

    
    #nullable disable
    
}
