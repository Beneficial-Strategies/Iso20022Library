// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a payment.
/// </summary>
[IsoId("__oKQ-QKxEe2rHs6fbn9-0A")]
[DisplayName("Payment Search")]
public record PaymentSearch9
{
    /// <summary>
    /// Point to point reference, as assigned by the original initiating party, to unambiguously identify the original payment transaction message. |Usage: this is the former transaction reference.
    /// </summary>
    [IsoId("_ASwGHQKyEe2rHs6fbn9-0A")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public SimpleValueList<IsoMax35Text> MessageIdentification { get; init; } = [];

    /// <summary>
    /// Date and time at which the cash is at the disposal of the credit account owner, or ceases to be at the disposal of the debit account owner.
    /// </summary>
    [IsoId("_ASwGHwKyEe2rHs6fbn9-0A")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public ValueList<DateAndDateTimeSearch3Choice_> RequestedExecutionDate { get; init; } = [];

    /// <summary>
    /// Unique and unambiguous identifier for a payment instruction, as assigned by the clearing agent or the initiating party.
    /// </summary>
    [IsoId("_ASwGIQKyEe2rHs6fbn9-0A")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public ValueList<PaymentIdentification7Choice_> PaymentIdentification { get; init; } = [];

    /// <summary>
    /// Detailed information about the status of a transfer.
    /// </summary>
    [IsoId("_ASwGIwKyEe2rHs6fbn9-0A")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public ValueList<InstructionStatusSearch5> Status { get; init; } = [];

    /// <summary>
    /// Specifies the instructed amount(s) on which the query is performed.
    /// </summary>
    [IsoId("_ASwGJQKyEe2rHs6fbn9-0A")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ValueList<ActiveOrHistoricAmountRange2Choice_> InstructedAmount { get; init; } = [];

    /// <summary>
    /// Currency in which the instructed amount is expressed.
    /// </summary>
    [IsoId("_ASwGJwKyEe2rHs6fbn9-0A")]
    [DisplayName("Instructed Amount Currency")]
    [IsoXmlTag("InstdAmtCcy")]
    public SimpleValueList<ActiveOrHistoricCurrencyCode> InstructedAmountCurrency { get; init; } =
        [];

    /// <summary>
    /// Indicates whether the payment instruction is a debit or a credit.
    /// </summary>
    [IsoId("_ASwGKQKyEe2rHs6fbn9-0A")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Specifies the interbank settlement amount(s) on which the query is performed.
    /// </summary>
    [IsoId("_ASwGKwKyEe2rHs6fbn9-0A")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ValueList<ActiveAmountRange3Choice_> InterbankSettlementAmount { get; init; } = [];

    /// <summary>
    /// Currency in which the interbank settlement amount is expressed.
    /// </summary>
    [IsoId("_ASwGLQKyEe2rHs6fbn9-0A")]
    [DisplayName("Interbank Settlement Amount Currency")]
    [IsoXmlTag("IntrBkSttlmAmtCcy")]
    public SimpleValueList<ActiveCurrencyCode> InterbankSettlementAmountCurrency { get; init; } =
        [];

    /// <summary>
    /// Indicates the message or event from which an instruction has been initiated.
    /// </summary>
    [IsoId("_ASwGLwKyEe2rHs6fbn9-0A")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public ValueList<PaymentOrigin1Choice_> PaymentMethod { get; init; } = [];

    /// <summary>
    /// Instruction to pay an amount of money to an ultimate beneficiary, on behalf of an originator. This instruction may have to be forwarded several times to complete the settlement chain.
    /// </summary>
    [IsoId("_ASwGMQKyEe2rHs6fbn9-0A")]
    [DisplayName("Payment Type")]
    [IsoXmlTag("PmtTp")]
    public ValueList<PaymentType4Choice_> PaymentType { get; init; } = [];

    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.
    /// </summary>
    [IsoId("_ASwGMwKyEe2rHs6fbn9-0A")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public ValueList<Priority1Choice_> Priority { get; init; } = [];

    /// <summary>
    /// Date and time range within which the payment instruction must be processed.
    /// </summary>
    [IsoId("_ASwGNQKyEe2rHs6fbn9-0A")]
    [DisplayName("Processing Validity Time")]
    [IsoXmlTag("PrcgVldtyTm")]
    public ValueList<DateTimePeriod1Choice_> ProcessingValidityTime { get; init; } = [];

    /// <summary>
    /// Further information related to the processing of the payment instruction. The instruction can relate to a level of service between the bank and the customer, or give instructions to and for specific parties in the payment chain.
    /// </summary>
    [IsoId("_ASwGNwKyEe2rHs6fbn9-0A")]
    [DisplayName("Instruction")]
    [IsoXmlTag("Instr")]
    public SimpleValueList<Instruction1Code> Instruction { get; init; } = [];

    /// <summary>
    /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.|Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.|Usage: this is the former PaymentInstructionReference.
    /// </summary>
    [IsoId("_ASwGOQKyEe2rHs6fbn9-0A")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public SimpleValueList<IsoMax35Text> TransactionIdentification { get; init; } = [];

    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_VoE_cRlcEe2Do_UtrNmb2g")]
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    public SimpleValueList<IsoUUIDv4Identifier> UETR { get; init; } = [];

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.|Usage: this is the former InterbankValueDate.
    /// </summary>
    [IsoId("_ASwGOwKyEe2rHs6fbn9-0A")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public SimpleValueList<IsoISODate> InterbankSettlementDate { get; init; } = [];

    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.|Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction.|It can be included in several messages related to the transaction.|Usage: this is the former RelatedReference.
    /// </summary>
    [IsoId("_ASwGPQKyEe2rHs6fbn9-0A")]
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    public SimpleValueList<IsoMax35Text> EndToEndIdentification { get; init; } = [];

    /// <summary>
    /// Defines the party fields used to search for a payment.
    /// </summary>
    [IsoId("_ASwGPwKyEe2rHs6fbn9-0A")]
    [DisplayName("Parties")]
    [IsoXmlTag("Pties")]
    public PaymentTransactionParty3? Parties { get; init; }
}
