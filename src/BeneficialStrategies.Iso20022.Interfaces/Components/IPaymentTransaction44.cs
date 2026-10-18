// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reference and status on the original transactions, included in the original instruction, to which the return message applies.
/// </summary>
[IsoId("_TOBE4SHLEeK1OvoXgbVMNg")]
public interface IPaymentTransaction44 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the returned transaction.|Usage: The instructing party is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    [IsoId("_Tik_sSHLEeK1OvoXgbVMNg")]
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    Max35Text? ReturnIdentification { get; }

    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_Tik_tSHLEeK1OvoXgbVMNg")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation3? OriginalGroupInformation { get; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_Tik_vSHLEeK1OvoXgbVMNg")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    Max35Text? OriginalInstructionIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_Tik_wSHLEeK1OvoXgbVMNg")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    Max35Text? OriginalEndToEndIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    [IsoId("_Tik_xSHLEeK1OvoXgbVMNg")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    Max35Text? OriginalTransactionIdentification { get; }

    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_Tik_ySHLEeK1OvoXgbVMNg")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    Max35Text? OriginalClearingSystemReference { get; }

    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_Tik_zSHLEeK1OvoXgbVMNg")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent in the returned transaction.
    /// </summary>
    [IsoId("_Tik_0SHLEeK1OvoXgbVMNg")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.||Usage: the InterbankSettlementDate is the interbank settlement date of the return message, and not of the original instruction.
    /// </summary>
    [IsoId("_Tik_2SHLEeK1OvoXgbVMNg")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the returned transaction.
    /// </summary>
    [IsoId("_Tik_4SHLEeK1OvoXgbVMNg")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_Tik_5SHLEeK1OvoXgbVMNg")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    BaseOneRate? ExchangeRate { get; }

    /// <summary>
    /// Amount of money asked or paid as compensation for the processing of the instruction.
    /// </summary>
    [IsoId("_Tik_7SHLEeK1OvoXgbVMNg")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the return message, not to the original instruction.
    /// </summary>
    [IsoId("_Tik_8SHLEeK1OvoXgbVMNg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the processing of the return transaction.
    /// </summary>
    [IsoId("_Tik_9SHLEeK1OvoXgbVMNg")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<ICharges2> ChargesInformation { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).||Usage: The instructing agent is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    [IsoId("_Tik_-SHLEeK1OvoXgbVMNg")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).||Usage: The instructed agent is the party receiving the return message and not the party that received the original instruction that is being returned.
    /// </summary>
    [IsoId("_TilAASHLEeK1OvoXgbVMNg")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructedAgent { get; }

    /// <summary>
    /// Provides detailed information on the return reason.
    /// </summary>
    [IsoId("_TilACSHLEeK1OvoXgbVMNg")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    IEnumerable<IPaymentReturnReason1> ReturnReasonInformation { get; }

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_TilADSHLEeK1OvoXgbVMNg")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    IOriginalTransactionReference16? OriginalTransactionReference { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_XNubuiHLEeK1OvoXgbVMNg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
