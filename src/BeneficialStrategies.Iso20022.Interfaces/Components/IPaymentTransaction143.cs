// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reference and status on the original transactions, included in the original instruction, to which the reversal message applies.
/// </summary>
[IsoId("_NqTfVxlWEe2Do_UtrNmb2g")]
public interface IPaymentTransaction143 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reversed transaction.|Usage: The instructing party is the party sending the reversal message and not the party that sent the original instruction that is being reversed.
    /// </summary>
    [IsoId("_N1HoNxlWEe2Do_UtrNmb2g")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    Max35Text? ReversalIdentification { get; }

    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_N1HoORlWEe2Do_UtrNmb2g")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation29? OriginalGroupInformation { get; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_N1HoOxlWEe2Do_UtrNmb2g")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    Max35Text? OriginalInstructionIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_N1HoPRlWEe2Do_UtrNmb2g")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    Max35Text? OriginalEndToEndIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    [IsoId("_N1HoPxlWEe2Do_UtrNmb2g")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    Max35Text? OriginalTransactionIdentification { get; }

    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_N1HoQRlWEe2Do_UtrNmb2g")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    UUIDv4Identifier? OriginalUETR { get; }

    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_N1HoQxlWEe2Do_UtrNmb2g")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    Max35Text? OriginalClearingSystemReference { get; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent, as provided in the original instruction.
    /// </summary>
    [IsoId("_N1HoRRlWEe2Do_UtrNmb2g")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; }

    /// <summary>
    /// Amount of money to be moved between the instructing agent and the instructed agent in the reversed instruction.
    /// </summary>
    [IsoId("_N1HoRxlWEe2Do_UtrNmb2g")]
    [DisplayName("Reversed Interbank Settlement Amount")]
    [IsoXmlTag("RvsdIntrBkSttlmAmt")]
    ActiveCurrencyAndAmount ReversedInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.||Usage: The InterbankSettlementDate is the interbank settlement date of the reversal message, and not of the original instruction.
    /// </summary>
    [IsoId("_N1HoSRlWEe2Do_UtrNmb2g")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// Usage: the SettlementPriority is the settlement priority of the reversal message, and not of the original instruction.
    /// </summary>
    [IsoId("_N1HoSxlWEe2Do_UtrNmb2g")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    Priority3Code? SettlementPriority { get; }

    /// <summary>
    /// Provides information on the occurred settlement time of the payment transaction.
    /// </summary>
    [IsoId("_N1HoTRlWEe2Do_UtrNmb2g")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    ISettlementDateTimeIndication1? SettlementTimeIndication { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the reversed transaction.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_N1HoTxlWEe2Do_UtrNmb2g")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_N1HoURlWEe2Do_UtrNmb2g")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    BaseOneRate? ExchangeRate { get; }

    /// <summary>
    /// Amount of money asked or paid as compensation for the processing of the instruction.
    /// </summary>
    [IsoId("_N1HoUxlWEe2Do_UtrNmb2g")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; }

    /// <summary>
    /// Specifies if the creditor and/or debtor will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the reversal message, not to the original instruction.
    /// </summary>
    [IsoId("_N1HoVRlWEe2Do_UtrNmb2g")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the processing of the reversal transaction.
    /// </summary>
    [IsoId("_N1HoVxlWEe2Do_UtrNmb2g")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<ICharges12> ChargesInformation { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).||Usage: The instructing agent is the party sending the reversal message and not the party that sent the original instruction that is being reversed.
    /// </summary>
    [IsoId("_N1HoWRlWEe2Do_UtrNmb2g")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification6? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).||Usage: The instructed agent is the party receiving the reversal message and not the party that received the original instruction that is being reversed.
    /// </summary>
    [IsoId("_N1HoWxlWEe2Do_UtrNmb2g")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification6? InstructedAgent { get; }

    /// <summary>
    /// Provides detailed information on the reversal reason.
    /// </summary>
    [IsoId("_N1HoXRlWEe2Do_UtrNmb2g")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    IEnumerable<IPaymentReversalReason9> ReversalReasonInformation { get; }

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_N1HoXxlWEe2Do_UtrNmb2g")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    IOriginalTransactionReference35? OriginalTransactionReference { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_N1HoYRlWEe2Do_UtrNmb2g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
