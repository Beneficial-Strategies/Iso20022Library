// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the details on the payment transaction.
/// </summary>
[IsoId("_j2uCAIaFEeiMm4lwapNmDA")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction101
{
    #nullable enable
    
    /// <summary>
    /// Contains the unique end to end transaction reference of a payment.
    /// </summary>
    [IsoId("_LXDOIYaFEeiMm4lwapNmDA")]
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public required IsoUUIDv4Identifier UETR { get; init; } 
    
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_LXDOIoaFEeiMm4lwapNmDA")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required PaymentStatus5 TransactionStatus { get; init; } 
    
    /// <summary>
    /// Provides details on the status of the cancellation of a payment transaction.
    /// </summary>
    [IsoId("_LXDOI4aFEeiMm4lwapNmDA")]
    [DisplayName("Cancellation Status")]
    [IsoXmlTag("CxlSts")]
    public PaymentTransactionCancellationStatus1? CancellationStatus { get; init; } 
    
    /// <summary>
    /// Specifies date and time at which the message enters the tracking system (for example gpi).
    /// </summary>
    [IsoId("_LXDOJIaFEeiMm4lwapNmDA")]
    [DisplayName("Initiation Time")]
    [IsoXmlTag("InitnTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime InitiationTime { get; init; } 
    
    /// <summary>
    /// Specifies the time at which the instructed bank reports that the transaction has been completed. 
    /// Usage:
    /// Date and time based on the creation date of the status confirmation containing a final status ACSC
    /// </summary>
    [IsoId("_LXDOJYaFEeiMm4lwapNmDA")]
    [DisplayName("Completion Time")]
    [IsoXmlTag("CmpltnTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CompletionTime { get; init; } 
    
    /// <summary>
    /// Specifies last date and time at which the status of this transaction was updated.
    /// </summary>
    [IsoId("_LXDOJoaFEeiMm4lwapNmDA")]
    [DisplayName("Last Update Time")]
    [IsoXmlTag("LastUpdTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime LastUpdateTime { get; init; } 
    
    /// <summary>
    /// Groups the information of an event, namely of a payment message or status confirmation update. It is repeated as many times as there are events to be returned.
    /// </summary>
    [IsoId("_LXDOJ4aFEeiMm4lwapNmDA")]
    [DisplayName("Payment Event")]
    [IsoXmlTag("PmtEvt")]
    public PaymentEvent7? PaymentEvent { get; init; } 
    
    
    #nullable disable
    
}
