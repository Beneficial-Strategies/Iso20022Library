// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reference and status on the original transactions, included in the original instruction, to which the reversal message applies.
/// </summary>
[IsoId("_I9FKERmJEeS15voCZPa1ZA")]
public interface IPaymentTransaction51 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reversed transaction.|Usage: The instructing party is the party sending the reversal message and not the party that sent the original instruction that is being reversed.
    /// </summary>
    [IsoId("_JWXz9xmJEeS15voCZPa1ZA")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    Max35Text? ReversalIdentification { get; }

    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_Vo0SAWQpEeST4ZKz9hIHPA")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation3? OriginalGroupInformation { get; }

    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_JWXz-RmJEeS15voCZPa1ZA")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    Max35Text? OriginalInstructionIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_JWXz-xmJEeS15voCZPa1ZA")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    Max35Text? OriginalEndToEndIdentification { get; }

    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    [IsoId("_JWXz_RmJEeS15voCZPa1ZA")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    Max35Text? OriginalTransactionIdentification { get; }

    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_JWXz_xmJEeS15voCZPa1ZA")]
    [DisplayName("Original Clearing System Reference")]
    [IsoXmlTag("OrgnlClrSysRef")]
    Max35Text? OriginalClearingSystemReference { get; }

    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_JWX0ARmJEeS15voCZPa1ZA")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    ActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent in the reversed transaction.
    /// </summary>
    [IsoId("_JWX0AxmJEeS15voCZPa1ZA")]
    [DisplayName("Reversed Interbank Settlement Amount")]
    [IsoXmlTag("RvsdIntrBkSttlmAmt")]
    ActiveCurrencyAndAmount ReversedInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.||Usage: The InterbankSettlementDate is the interbank settlement date of the reversal message, and not of the original instruction.
    /// </summary>
    [IsoId("_JWX0BRmJEeS15voCZPa1ZA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// Usage: the SettlementPriority is the settlement priority of the reversal message, and not of the original instruction.
    /// </summary>
    [IsoId("_4oZaoRmIEeS15voCZPa1ZA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    Priority3Code? SettlementPriority { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the reversed transaction.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_JWX0BxmJEeS15voCZPa1ZA")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    ActiveOrHistoricCurrencyAndAmount? ReversedInstructedAmount { get; }

    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_JWX0CRmJEeS15voCZPa1ZA")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    BaseOneRate? ExchangeRate { get; }

    /// <summary>
    /// Amount of money asked or paid as compensation for the processing of the instruction.
    /// </summary>
    [IsoId("_JWX0CxmJEeS15voCZPa1ZA")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    ActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; }

    /// <summary>
    /// Specifies if the creditor and/or debtor will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the reversal message, not to the original instruction.
    /// </summary>
    [IsoId("_JWX0DRmJEeS15voCZPa1ZA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the processing of the reversal transaction.
    /// </summary>
    [IsoId("_JWX0DxmJEeS15voCZPa1ZA")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<ICharges2> ChargesInformation { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).||Usage: The instructing agent is the party sending the reversal message and not the party that sent the original instruction that is being reversed.
    /// </summary>
    [IsoId("_JWX0ERmJEeS15voCZPa1ZA")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).||Usage: The instructed agent is the party receiving the reversal message and not the party that received the original instruction that is being reversed.
    /// </summary>
    [IsoId("_JWX0ExmJEeS15voCZPa1ZA")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructedAgent { get; }

    /// <summary>
    /// Provides detailed information on the reversal reason.
    /// </summary>
    [IsoId("_JWX0FRmJEeS15voCZPa1ZA")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    IEnumerable<IPaymentReversalReason7> ReversalReasonInformation { get; }

    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_JWX0FxmJEeS15voCZPa1ZA")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    IOriginalTransactionReference20? OriginalTransactionReference { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_JWX0GRmJEeS15voCZPa1ZA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
