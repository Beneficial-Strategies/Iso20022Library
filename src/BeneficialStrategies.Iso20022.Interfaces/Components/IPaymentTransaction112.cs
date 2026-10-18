// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reference and status on the original transactions, included in the original instruction, to which the return message applies.
/// </summary>
[IsoId("_Ka6EIXL_EeidQ_AAdEzxQA")]
public interface IPaymentTransaction112 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the returned transaction.|Usage: The instructing party is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    [IsoId("_KlMBeXL_EeidQ_AAdEzxQA")]
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    Max35Text? ReturnIdentification { get; }

    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_KlMBe3L_EeidQ_AAdEzxQA")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation29? OriginalGroupInformation { get; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_KlMBfXL_EeidQ_AAdEzxQA")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    Max35Text? OriginalInstructionIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_KlMBf3L_EeidQ_AAdEzxQA")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    Max35Text? OriginalEndToEndIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    [IsoId("_KlMBgXL_EeidQ_AAdEzxQA")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    Max35Text? OriginalTransactionIdentification { get; }

    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_3PwiwXreEeidVZmeoasaWQ")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    UUIDv4Identifier? OriginalUETR { get; }

    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_KlMBg3L_EeidQ_AAdEzxQA")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    Max35Text? OriginalClearingSystemReference { get; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent, as provided in the original instruction.
    /// </summary>
    [IsoId("_KlMBhXL_EeidQ_AAdEzxQA")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// Usage: the OriginalInterbankSettlementDate is the interbank settlement date of the original instruction return message, and not of the return message.
    /// </summary>
    [IsoId("_KlMBh3L_EeidQ_AAdEzxQA")]
    [DisplayName("Original Interbank Settlement Date")]
    [IsoXmlTag("OrgnlIntrBkSttlmDt")]
    ISODate? OriginalInterbankSettlementDate { get; }

    /// <summary>
    /// Amount of money to be moved between the instructing agent and the instructed agent in the returned instruction.
    /// </summary>
    [IsoId("_KlMBiXL_EeidQ_AAdEzxQA")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.||Usage: the InterbankSettlementDate is the interbank settlement date of the return message, and not of the original instruction.
    /// </summary>
    [IsoId("_KlMBi3L_EeidQ_AAdEzxQA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// Usage: the SettlementPriority is the settlement priority of the return message, and not of the original instruction.
    /// </summary>
    [IsoId("_KlMBjXL_EeidQ_AAdEzxQA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    Priority3Code? SettlementPriority { get; }

    /// <summary>
    /// Provides information on the occurred settlement time(s) of the payment transaction.
    /// </summary>
    [IsoId("_1U0rwXRqEeiH1ZOt2UD8vQ")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    ISettlementDateTimeIndication1? SettlementTimeIndication { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the returned transaction.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_KlMBj3L_EeidQ_AAdEzxQA")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_KlMBkXL_EeidQ_AAdEzxQA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    BaseOneRate? ExchangeRate { get; }

    /// <summary>
    /// Amount of money asked or paid as compensation for the processing of the instruction.
    /// </summary>
    [IsoId("_KlMBk3L_EeidQ_AAdEzxQA")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the return message, not to the original instruction.
    /// </summary>
    [IsoId("_KlMBlXL_EeidQ_AAdEzxQA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the processing of the return transaction.
    /// </summary>
    [IsoId("_KlMBl3L_EeidQ_AAdEzxQA")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<ICharges7> ChargesInformation { get; }

    /// <summary>
    /// Unique reference, as assigned by the clearing system, to unambiguously identify the return instruction.
    /// </summary>
    [IsoId("_KlMBmXL_EeidQ_AAdEzxQA")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    Max35Text? ClearingSystemReference { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).||Usage: The instructing agent is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    [IsoId("_KlMBm3L_EeidQ_AAdEzxQA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification6? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).||Usage: The instructed agent is the party receiving the return message and not the party that received the original instruction that is being returned.
    /// </summary>
    [IsoId("_KlMBnXL_EeidQ_AAdEzxQA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification6? InstructedAgent { get; }

    /// <summary>
    /// Provides all parties (agents and non-agents) involved in a return transaction.
    /// </summary>
    [IsoId("_KlMBn3L_EeidQ_AAdEzxQA")]
    [DisplayName("Return Chain")]
    [IsoXmlTag("RtrChain")]
    ITransactionParties7? ReturnChain { get; }

    /// <summary>
    /// Provides detailed information on the return reason.
    /// </summary>
    [IsoId("_KlMBoXL_EeidQ_AAdEzxQA")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    IEnumerable<IPaymentReturnReason6> ReturnReasonInformation { get; }

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_KlMBo3L_EeidQ_AAdEzxQA")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    IOriginalTransactionReference28? OriginalTransactionReference { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KlMBpXL_EeidQ_AAdEzxQA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
