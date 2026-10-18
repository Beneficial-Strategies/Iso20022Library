// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reference and status on the original transactions, included in the original instruction, to which the return message applies.
/// </summary>
[IsoId("_buMPMdcZEeqRFcf2R4bPBw")]
public interface IPaymentTransaction133 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the returned transaction.|Usage: The instructing party is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    [IsoId("_bvqO19cZEeqRFcf2R4bPBw")]
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    IsoMax35Text? ReturnIdentification { get; }

    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_bvqO2dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation29? OriginalGroupInformation { get; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_bvqO29cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    IsoMax35Text? OriginalInstructionIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_bvqO3dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    IsoMax35Text? OriginalEndToEndIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    [IsoId("_bvqO39cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    IsoMax35Text? OriginalTransactionIdentification { get; }

    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_bvqO4dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    IsoUUIDv4Identifier? OriginalUETR { get; }

    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_bvqO49cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    IsoMax35Text? OriginalClearingSystemReference { get; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent, as provided in the original instruction.
    /// </summary>
    [IsoId("_bvqO5dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// Usage: the OriginalInterbankSettlementDate is the interbank settlement date of the original instruction return message, and not of the return message.
    /// </summary>
    [IsoId("_bvqO59cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Interbank Settlement Date")]
    [IsoXmlTag("OrgnlIntrBkSttlmDt")]
    IsoISODate? OriginalInterbankSettlementDate { get; }

    /// <summary>
    /// Specifies the type of the return transaction.
    /// </summary>
    [IsoId("_pV2nkdfxEeqoweZZxm4TPQ")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation28? PaymentTypeInformation { get; }

    /// <summary>
    /// Amount of money to be moved between the instructing agent and the instructed agent in the returned instruction.
    /// </summary>
    [IsoId("_bvqO6dcZEeqRFcf2R4bPBw")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.||Usage: the InterbankSettlementDate is the interbank settlement date of the return message, and not of the original instruction.
    /// </summary>
    [IsoId("_bvqO69cZEeqRFcf2R4bPBw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    IsoISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// Usage: the SettlementPriority is the settlement priority of the return message, and not of the original instruction.
    /// </summary>
    [IsoId("_bvqO7dcZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    Priority3Code? SettlementPriority { get; }

    /// <summary>
    /// Provides information on the occurred settlement time(s) of the payment transaction.
    /// </summary>
    [IsoId("_bvqO79cZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    ISettlementDateTimeIndication1? SettlementTimeIndication { get; }

    /// <summary>
    /// Provides information on the requested settlement time(s) of the payment instruction.
    /// </summary>
    [IsoId("_kAhdcdf4EeqoweZZxm4TPQ")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    ISettlementTimeRequest2? SettlementTimeRequest { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the returned transaction.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_bvqO8dcZEeqRFcf2R4bPBw")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_bvqO89cZEeqRFcf2R4bPBw")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    IsoBaseOneRate? ExchangeRate { get; }

    /// <summary>
    /// Amount of money asked or paid as compensation for the processing of the instruction.
    /// </summary>
    [IsoId("_bvqO9dcZEeqRFcf2R4bPBw")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the return message, not to the original instruction.
    /// </summary>
    [IsoId("_bvqO99cZEeqRFcf2R4bPBw")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the processing of the return transaction.
    /// </summary>
    [IsoId("_bvqO-dcZEeqRFcf2R4bPBw")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<ICharges7> ChargesInformation { get; }

    /// <summary>
    /// Unique reference, as assigned by the clearing system, to unambiguously identify the return instruction.
    /// </summary>
    [IsoId("_bvqO-9cZEeqRFcf2R4bPBw")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    IsoMax35Text? ClearingSystemReference { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).||Usage: The instructing agent is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    [IsoId("_bvqO_dcZEeqRFcf2R4bPBw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification6? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).||Usage: The instructed agent is the party receiving the return message and not the party that received the original instruction that is being returned.
    /// </summary>
    [IsoId("_bvqO_9cZEeqRFcf2R4bPBw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification6? InstructedAgent { get; }

    /// <summary>
    /// Provides all parties (agents and non-agents) involved in a return transaction.
    /// </summary>
    [IsoId("_bvqPAdcZEeqRFcf2R4bPBw")]
    [DisplayName("Return Chain")]
    [IsoXmlTag("RtrChain")]
    ITransactionParties10? ReturnChain { get; }

    /// <summary>
    /// Provides detailed information on the return reason.
    /// </summary>
    [IsoId("_bvqPA9cZEeqRFcf2R4bPBw")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    IEnumerable<IPaymentReturnReason6> ReturnReasonInformation { get; }

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_bvqPBdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    IOriginalTransactionReference36? OriginalTransactionReference { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bvqPB9cZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
