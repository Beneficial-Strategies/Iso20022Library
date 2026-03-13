// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the payment transaction related to the underlying cover payment.
/// </summary>
[IsoId("_IEdxMD72EeiJbZ2wCAV0-w")]
[DisplayName("Cover Payment Event")]
public partial record CoverPaymentEvent1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_hx708T72EeiJbZ2wCAV0-w")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required PaymentStatus5 TransactionStatus { get; init; } 
    
    /// <summary>
    /// Identifies the party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_3QZFIT73EeiJbZ2wCAV0-w")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? Debtor { get; init; } 
    
    /// <summary>
    /// Identifies the agent(s) currently participating in a transaction.
    /// </summary>
    [IsoId("_8jCDcT73EeiJbZ2wCAV0-w")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public ValueList<PaymentEvent2> Agent { get; init; } = [];
    // ID for the above is _8jCDcT73EeiJbZ2wCAV0-w
    
    /// <summary>
    /// Identifies the party to which an amount of money is due.
    /// </summary>
    [IsoId("_FjBAwT75EeiJbZ2wCAV0-w")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? Creditor { get; init; } 
    
    /// <summary>
    /// Specifies the date and time at which the message enters the Gpi system.
    /// </summary>
    [IsoId("_SCO6gT75EeiJbZ2wCAV0-w")]
    [DisplayName("Initiation Time")]
    [IsoXmlTag("InitnTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime InitiationTime { get; init; } 
    
    /// <summary>
    /// Specifies the time at which the instructed bank reports that the transaction has been completed. 
    /// Usage:
    /// Date and time are based on the creation date of the status confirmation containing a final status ACSC.
    /// </summary>
    [IsoId("_TPcUgT75EeiJbZ2wCAV0-w")]
    [DisplayName("Completion Time")]
    [IsoXmlTag("CmpltnTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CompletionTime { get; init; } 
    
    /// <summary>
    /// Identifies the amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage:
    /// This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_VKfr8T75EeiJbZ2wCAV0-w")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; } 
    
    /// <summary>
    /// Identifies the last date and time at which the status of this transaction was updated.
    /// </summary>
    [IsoId("_YgUYQT75EeiJbZ2wCAV0-w")]
    [DisplayName("Last Update Time")]
    [IsoXmlTag("LastUpdTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime LastUpdateTime { get; init; } 
    
    
    #nullable disable
    
}
