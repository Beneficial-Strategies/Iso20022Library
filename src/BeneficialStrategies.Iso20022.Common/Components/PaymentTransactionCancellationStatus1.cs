// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the status of the cancellation of a payment transaction.
/// </summary>
[IsoId("_jiiu0CX7Eei7VPGVFTQkxA")]
[DisplayName("Payment Transaction Cancellation Status")]
public partial record PaymentTransactionCancellationStatus1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of a cancellation request.
    /// </summary>
    [IsoId("_yenskCX7Eei7VPGVFTQkxA")]
    [DisplayName("Transaction Cancellation Status")]
    [IsoXmlTag("TxCxlSts")]
    public required CancellationIndividualStatus2Code TransactionCancellationStatus { get; init; } 
    
    
    #nullable disable
    
}
