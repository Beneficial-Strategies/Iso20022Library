// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Search10.
/// </summary>
[IsoId("_3T9n8TEyEe6g-ffJsqGiSA")]
[DisplayName("Payment Search10")]
public record PaymentSearch10
{
    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// End To End Identification.
    /// </summary>
    [DisplayName("End To End Identification")]
    [IsoXmlTag("EndToEndId")]
    public ValueList<IsoMax35Text> EndToEndIdentification { get; init; } = [];

    /// <summary>
    /// Instructed Amount.
    /// </summary>
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ValueList<ActiveOrHistoricAmountRange2Choice_> InstructedAmount { get; init; } = [];

    /// <summary>
    /// Instructed Amount Currency.
    /// </summary>
    [DisplayName("Instructed Amount Currency")]
    [IsoXmlTag("InstdAmtCcy")]
    public ValueList<ActiveOrHistoricCurrencyCode> InstructedAmountCurrency { get; init; } = [];

    /// <summary>
    /// Instruction.
    /// </summary>
    [DisplayName("Instruction")]
    [IsoXmlTag("Instr")]
    public ValueList<Instruction1Code> Instruction { get; init; } = [];

    /// <summary>
    /// Interbank Settlement Amount.
    /// </summary>
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ValueList<ActiveAmountRange3Choice_> InterbankSettlementAmount { get; init; } = [];

    /// <summary>
    /// Interbank Settlement Amount Currency.
    /// </summary>
    [DisplayName("Interbank Settlement Amount Currency")]
    [IsoXmlTag("IntrBkSttlmAmtCcy")]
    public ValueList<ActiveCurrencyCode> InterbankSettlementAmountCurrency { get; init; } = [];

    /// <summary>
    /// Interbank Settlement Date.
    /// </summary>
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public ValueList<IsoISODate> InterbankSettlementDate { get; init; } = [];

    /// <summary>
    /// Message Identification.
    /// </summary>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public ValueList<IsoMax35Text> MessageIdentification { get; init; } = [];

    /// <summary>
    /// Parties.
    /// </summary>
    [DisplayName("Parties")]
    [IsoXmlTag("Pties")]
    public PaymentTransactionParty4? Parties { get; init; }

    /// <summary>
    /// Payment Identification.
    /// </summary>
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public ValueList<PaymentIdentification8Choice_> PaymentIdentification { get; init; } = [];

    /// <summary>
    /// Payment Method.
    /// </summary>
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public ValueList<PaymentOrigin1Choice_> PaymentMethod { get; init; } = [];

    /// <summary>
    /// Payment Type.
    /// </summary>
    [DisplayName("Payment Type")]
    [IsoXmlTag("PmtTp")]
    public ValueList<PaymentType4Choice_> PaymentType { get; init; } = [];

    /// <summary>
    /// Priority.
    /// </summary>
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public ValueList<Priority1Choice_> Priority { get; init; } = [];

    /// <summary>
    /// Processing Validity Time.
    /// </summary>
    [DisplayName("Processing Validity Time")]
    [IsoXmlTag("PrcgVldtyTm")]
    public ValueList<DateTimePeriod1Choice_> ProcessingValidityTime { get; init; } = [];

    /// <summary>
    /// Requested Execution Date.
    /// </summary>
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public ValueList<DateAndDateTimeSearch3Choice_> RequestedExecutionDate { get; init; } = [];

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public ValueList<InstructionStatusSearch5> Status { get; init; } = [];

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public ValueList<IsoMax35Text> TransactionIdentification { get; init; } = [];

    /// <summary>
    /// UETR.
    /// </summary>
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    public ValueList<IsoUUIDv4Identifier> UETR { get; init; } = [];
}
