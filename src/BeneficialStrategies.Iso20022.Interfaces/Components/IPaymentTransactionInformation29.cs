// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide reference and status information on the original transactions, included in the original instruction, to which the reversal message applies.
/// </summary>
[IsoId("_P3_Ridp-Ed-ak6NoX_4Aeg_-327433227")]
public interface IPaymentTransactionInformation29 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reversed transaction.|Usage: The instructing party is the party sending the reversal message and not the party that sent the original instruction that is being reversed.
    /// </summary>
    [IsoId("_P4JCgNp-Ed-ak6NoX_4Aeg_-327433196")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    Max35Text? ReversalIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_P4JCgdp-Ed-ak6NoX_4Aeg_-327432896")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    Max35Text? OriginalInstructionIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_P4JCgtp-Ed-ak6NoX_4Aeg_-327432835")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    Max35Text? OriginalEndToEndIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to umambiguously identify the transaction.
    /// </summary>
    [IsoId("_P4JCg9p-Ed-ak6NoX_4Aeg_-327432804")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    Max35Text? OriginalTransactionIdentification { get; }

    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_P4JChNp-Ed-ak6NoX_4Aeg_-1335418230")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    Max35Text? OriginalClearingSystemReference { get; }

    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_P4JChdp-Ed-ak6NoX_4Aeg_-327432743")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent in the reversed transaction.
    /// </summary>
    [IsoId("_P4JChtp-Ed-ak6NoX_4Aeg_-327432342")]
    [DisplayName("Reversed Interbank Settlement Amount")]
    [IsoXmlTag("RvsdIntrBkSttlmAmt")]
    ActiveCurrencyAndAmount ReversedInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.||Usage: The InterbankSettlementDate is the interbank settlement date of the reversal message, and not of the original instruction.
    /// </summary>
    [IsoId("_P4JCh9p-Ed-ak6NoX_4Aeg_-327432464")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the reversed transaction.
    /// </summary>
    [IsoId("_P4SMcNp-Ed-ak6NoX_4Aeg_-327432311")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_P4SMcdp-Ed-ak6NoX_4Aeg_-327432403")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    BaseOneRate? ExchangeRate { get; }

    /// <summary>
    /// Amount of money asked or paid as compensation for the processing of the instruction.
    /// </summary>
    [IsoId("_P4SMctp-Ed-ak6NoX_4Aeg_-327432433")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; }

    /// <summary>
    /// Specifies if the creditor and/or debtor will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the reversal message, not to the original instruction.
    /// </summary>
    [IsoId("_P4SMc9p-Ed-ak6NoX_4Aeg_-327432372")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the processing of the reversal transaction.
    /// </summary>
    [IsoId("_P4SMdNp-Ed-ak6NoX_4Aeg_-327432187")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<IChargesInformation5> ChargesInformation { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).||Usage: The instructing agent is the party sending the reversal message and not the party that sent the original instruction that is being reversed.
    /// </summary>
    [IsoId("_P4SMddp-Ed-ak6NoX_4Aeg_-327432218")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification4? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).||Usage: The instructed agent is the party receiving the reversal message and not the party that received the original instruction that is being reversed.
    /// </summary>
    [IsoId("_P4SMdtp-Ed-ak6NoX_4Aeg_-327431909")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification4? InstructedAgent { get; }

    /// <summary>
    /// Set of elements used to provide detailed information on the reversal reason.
    /// </summary>
    [IsoId("_P4SMd9p-Ed-ak6NoX_4Aeg_-327431940")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    IEnumerable<IReversalReasonInformation6> ReversalReasonInformation { get; }

    /// <summary>
    /// Set of key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_P4SMeNp-Ed-ak6NoX_4Aeg_-327432265")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    IOriginalTransactionReference13? OriginalTransactionReference { get; }
}
