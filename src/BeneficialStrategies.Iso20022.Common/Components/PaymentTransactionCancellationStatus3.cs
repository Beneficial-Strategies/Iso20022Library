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
[IsoId("_UFAnxYEqEei51tn2YGQhvg")]
[DisplayName("Payment Transaction Cancellation Status")]
public partial record PaymentTransactionCancellationStatus3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of a cancellation request.
    /// </summary>
    [IsoId("_UFAnxoEqEei51tn2YGQhvg")]
    [DisplayName("Transaction Cancellation Status")]
    [IsoXmlTag("TxCxlSts")]
    public required CancellationIndividualStatus2Code TransactionCancellationStatus { get; init; } 
    
    /// <summary>
    /// Provides status reason with regards to the cancellation of the payment.
    /// </summary>
    [IsoId("_UFAnyYEqEei51tn2YGQhvg")]
    [DisplayName("Cancellation Status Reason Information")]
    [IsoXmlTag("CxlStsRsnInf")]
    public PaymentCancellationStatusReason3Code? CancellationStatusReasonInformation { get; init; } 
    
    /// <summary>
    /// Identifies the party that the case is assigned to. This is also the receiver of the message.
    /// </summary>
    [IsoId("_UFAnyIEqEei51tn2YGQhvg")]
    [DisplayName("Assignee")]
    [IsoXmlTag("Assgne")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier Assignee { get; init; } 
    
    /// <summary>
    /// Specifies the date and time at which the cancellation response message enters the tracking system and thus on which the status is provided.
    /// </summary>
    [IsoId("_UFAnx4EqEei51tn2YGQhvg")]
    [DisplayName("Cancellation Event Date Time")]
    [IsoXmlTag("CxlEvtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CancellationEventDateTime { get; init; } 
    
    
    #nullable disable
    
}
