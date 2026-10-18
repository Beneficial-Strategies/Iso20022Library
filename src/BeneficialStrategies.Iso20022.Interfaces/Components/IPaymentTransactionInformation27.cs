// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide reference and status information on the original transactions, included in the original instruction, to which the return message applies.
/// </summary>
[IsoId("_P5VVUdp-Ed-ak6NoX_4Aeg_225114103")]
public interface IPaymentTransactionInformation27 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the returned transaction.|Usage: The instructing party is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    [IsoId("_P5VVUtp-Ed-ak6NoX_4Aeg_225114352")]
    [DisplayName("Return Identification")]
    [IsoXmlTag("RtrId")]
    Max35Text? ReturnIdentification { get; }

    /// <summary>
    /// Set of elements used to provide information on the original messsage.
    /// </summary>
    [IsoId("_P5VVU9p-Ed-ak6NoX_4Aeg_225115792")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation3? OriginalGroupInformation { get; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_P5VVVNp-Ed-ak6NoX_4Aeg_225114412")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    Max35Text? OriginalInstructionIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_P5VVVdp-Ed-ak6NoX_4Aeg_225114473")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    Max35Text? OriginalEndToEndIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to umambiguously identify the transaction.
    /// </summary>
    [IsoId("_P5VVVtp-Ed-ak6NoX_4Aeg_225114783")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    Max35Text? OriginalTransactionIdentification { get; }

    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_P5VVV9p-Ed-ak6NoX_4Aeg_537745721")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    Max35Text? OriginalClearingSystemReference { get; }

    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_P5VVWNp-Ed-ak6NoX_4Aeg_225114813")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent in the returned transaction.
    /// </summary>
    [IsoId("_P5VVWdp-Ed-ak6NoX_4Aeg_225115028")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    ActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.||Usage: the InterbankSettlementDate is the interbank settlement date of the return message, and not of the original instruction.
    /// </summary>
    [IsoId("_P5efQNp-Ed-ak6NoX_4Aeg_225114874")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the returned transaction.
    /// </summary>
    [IsoId("_P5efQdp-Ed-ak6NoX_4Aeg_225115050")]
    [DisplayName("Returned Instructed Amount")]
    [IsoXmlTag("RtrdInstdAmt")]
    ActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_P5efQtp-Ed-ak6NoX_4Aeg_225114936")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    BaseOneRate? ExchangeRate { get; }

    /// <summary>
    /// Amount of money asked or paid as compensation for the processing of the instruction.
    /// </summary>
    [IsoId("_P5efQ9p-Ed-ak6NoX_4Aeg_225114905")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the return message, not to the original instruction.
    /// </summary>
    [IsoId("_P5efRNp-Ed-ak6NoX_4Aeg_225114966")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the processing of the return transaction.
    /// </summary>
    [IsoId("_P5efRdp-Ed-ak6NoX_4Aeg_225115360")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<IChargesInformation5> ChargesInformation { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).||Usage: The instructing agent is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    [IsoId("_P5efRtp-Ed-ak6NoX_4Aeg_225115421")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification4? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).||Usage: The instructed agent is the party receiving the return message and not the party that received the original instruction that is being returned.
    /// </summary>
    [IsoId("_P5efR9p-Ed-ak6NoX_4Aeg_225115452")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification4? InstructedAgent { get; }

    /// <summary>
    /// Set of elements used to provide detailed information on the return reason.
    /// </summary>
    [IsoId("_P5efSNp-Ed-ak6NoX_4Aeg_225115761")]
    [DisplayName("Return Reason Information")]
    [IsoXmlTag("RtrRsnInf")]
    IEnumerable<IReturnReasonInformation9> ReturnReasonInformation { get; }

    /// <summary>
    /// Set of key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_P5efSdp-Ed-ak6NoX_4Aeg_225115329")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    IOriginalTransactionReference13? OriginalTransactionReference { get; }
}
