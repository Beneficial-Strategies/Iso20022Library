// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the payment instruction.
/// </summary>
[IsoId("_NZNuIZlPEee-Zps0fZQaFQ")]
[DisplayName("Payment Instruction")]
public record PaymentInstruction26
{
    /// <summary>
    /// Point to point reference, as assigned by the original initiating party, to unambiguously identify the original payment transaction message|Usage: this is the former TransactionReference.
    /// </summary>
    [IsoId("_NhZZs5lPEee-Zps0fZQaFQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the cash is at the disposal of the credit account owner, or ceases to be at the disposal of the debit account owner.
    /// </summary>
    [IsoId("_NhZZtZlPEee-Zps0fZQaFQ")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Detailed information about the status of a transfer.||.
    /// </summary>
    [IsoId("_NhZZt5lPEee-Zps0fZQaFQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public ValueList<PaymentStatus3> Status { get; init; } = [];

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_NhZZuZlPEee-Zps0fZQaFQ")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public Amount3Choice_? InstructedAmount { get; init; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_NhZZu5lPEee-Zps0fZQaFQ")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public Amount2Choice_? InterbankSettlementAmount { get; init; }

    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("_NhZZvZlPEee-Zps0fZQaFQ")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? Purpose { get; init; }

    /// <summary>
    /// Indicates the message or event from which an instruction has been initiated.
    /// </summary>
    [IsoId("_NhZZv5lPEee-Zps0fZQaFQ")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentOrigin1Choice_? PaymentMethod { get; init; }

    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.|.
    /// </summary>
    [IsoId("_NhZZwZlPEee-Zps0fZQaFQ")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityCode3Choice_? Priority { get; init; }

    /// <summary>
    /// Date and time range within which the payment instruction must be processed.|.
    /// </summary>
    [IsoId("_NhZZw5lPEee-Zps0fZQaFQ")]
    [DisplayName("Processing Validity Time")]
    [IsoXmlTag("PrcgVldtyTm")]
    public DateTimePeriod1Choice_? ProcessingValidityTime { get; init; }

    /// <summary>
    /// Copy of the original instruction, in free form text.
    /// </summary>
    [IsoId("_NhZZxZlPEee-Zps0fZQaFQ")]
    [DisplayName("Instruction Copy")]
    [IsoXmlTag("InstrCpy")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000, MinimumLength = 1)]
    public IsoMax20000Text? InstructionCopy { get; init; }

    /// <summary>
    /// Type, or nature, of the payment, such as express payment.|.
    /// </summary>
    [IsoId("_NhZZx5lPEee-Zps0fZQaFQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PaymentType4Choice_? Type { get; init; }

    /// <summary>
    /// Payment is a liquidity transfer order that has been executed automatically following a predefined or standing order.
    /// </summary>
    [IsoId("_NhZZyZlPEee-Zps0fZQaFQ")]
    [DisplayName("Generated Order")]
    [IsoXmlTag("GnrtdOrdr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GeneratedOrder { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.
    /// Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.
    /// Usage: This is the former PaymentInstructionReference.
    /// </summary>
    [IsoId("_NhZZy5lPEee-Zps0fZQaFQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionIdentification { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_NhZZzZlPEee-Zps0fZQaFQ")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
    /// Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction.
    /// It can be included in several messages related to the transaction.
    /// Usage: This is the former related reference.
    /// </summary>
    [IsoId("_NhZZz5lPEee-Zps0fZQaFQ")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? EndToEndIdentification { get; init; }

    /// <summary>
    /// Defines the party fields used to search for a payment.
    /// </summary>
    [IsoId("_NhZZ0ZlPEee-Zps0fZQaFQ")]
    [DisplayName("Parties")]
    [IsoXmlTag("Pties")]
    public PaymentTransactionParty2? Parties { get; init; }
}
