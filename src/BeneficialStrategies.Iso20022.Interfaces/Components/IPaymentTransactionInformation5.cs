// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference and status information concerning the original transactions, included in the original instruction, to which the reversal message applies.
/// </summary>
[IsoId("_Prnpetp-Ed-ak6NoX_4Aeg_1832543398")]
public interface IPaymentTransactionInformation5 : IIsoComponent
{
    /// <summary>
    /// Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the reversed transaction.
    /// </summary>
    [IsoId("_Prnpe9p-Ed-ak6NoX_4Aeg_1833463637")]
    [DisplayName("Reversal Identification")]
    [IsoXmlTag("RvslId")]
    IsoMax35Text? ReversalIdentification { get; }

    /// <summary>
    /// Unique and unambiguous identifier of the original payment information block as assigned by the original sending party.
    /// </summary>
    [IsoId("_PrnpfNp-Ed-ak6NoX_4Aeg_1833463949")]
    [DisplayName("Original Payment Information Identification")]
    [IsoXmlTag("OrgnlPmtInfId")]
    IsoMax35Text? OriginalPaymentInformationIdentification { get; }

    /// <summary>
    /// Original unique instruction identification as assigned by an instructing party for an instructed party to unambiguously identify the original instruction.||Usage: the original instruction identification is the original point to point reference used between the instructing party and the instructed party to refer to the original instruction.
    /// </summary>
    [IsoId("_PrxacNp-Ed-ak6NoX_4Aeg_1833464026")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    IsoMax35Text? OriginalInstructionIdentification { get; }

    /// <summary>
    /// Original unique identification assigned by the initiating party to unambiguously identify the original transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
    /// </summary>
    [IsoId("_Prxacdp-Ed-ak6NoX_4Aeg_1833464069")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    IsoMax35Text? OriginalEndToEndIdentification { get; }

    /// <summary>
    /// Original identification of a transaction, as assigned by the first instructing agent and passed on, unchanged, throughout the entire interbank chain.
    /// </summary>
    [IsoId("_Prxactp-Ed-ak6NoX_4Aeg_1833464430")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    IsoMax35Text? OriginalTransactionIdentification { get; }

    /// <summary>
    /// Amount of money transferred between the instructing agent and the instructed agent in the original transaction.
    /// </summary>
    [IsoId("_Prxac9p-Ed-ak6NoX_4Aeg_1833464905")]
    [DisplayName("Original Interbank Settlement Amount")]
    [IsoXmlTag("OrgnlIntrBkSttlmAmt")]
    CurrencyAndAmount? OriginalInterbankSettlementAmount { get; }

    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent in the reversed transaction.
    /// </summary>
    [IsoId("_PrxadNp-Ed-ak6NoX_4Aeg_1833466463")]
    [DisplayName("Reversed Interbank Settlement Amount")]
    [IsoXmlTag("RvsdIntrBkSttlmAmt")]
    CurrencyAndAmount ReversedInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.||Usage: the InterbankSettlementDate is the interbank settlement date of the reversal message, and not of the original instruction.
    /// </summary>
    [IsoId("_Prxaddp-Ed-ak6NoX_4Aeg_1833465325")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    IsoISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the reversed transaction.
    /// </summary>
    [IsoId("_Prxadtp-Ed-ak6NoX_4Aeg_-918387251")]
    [DisplayName("Reversed Instructed Amount")]
    [IsoXmlTag("RvsdInstdAmt")]
    CurrencyAndAmount? ReversedInstructedAmount { get; }

    /// <summary>
    /// The factor used for conversion of an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_Prxad9p-Ed-ak6NoX_4Aeg_1833465887")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    IsoBaseOneRate? ExchangeRate { get; }

    /// <summary>
    /// Amount of money asked or paid as compensation for the processing of the instruction.
    /// </summary>
    [IsoId("_PrxaeNp-Ed-ak6NoX_4Aeg_1833465533")]
    [DisplayName("Compensation Amount")]
    [IsoXmlTag("CompstnAmt")]
    CurrencyAndAmount? CompensationAmount { get; }

    /// <summary>
    /// Specifies if the creditor and/or debtor will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the reversal message, not to the original instruction.
    /// </summary>
    [IsoId("_Prxaedp-Ed-ak6NoX_4Aeg_1833466308")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Transaction charges to be paid by the charge bearer for the reversal transaction.
    /// </summary>
    [IsoId("_Pr6kYNp-Ed-ak6NoX_4Aeg_1834388055")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    IEnumerable<IChargesInformation1> ChargesInformation { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_Pr6kYdp-Ed-ak6NoX_4Aeg_1835312473")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification3? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_Pr6kYtp-Ed-ak6NoX_4Aeg_1835311079")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification3? InstructedAgent { get; }

    /// <summary>
    /// Detailed information on the reversal reason.
    /// </summary>
    [IsoId("_Pr6kY9p-Ed-ak6NoX_4Aeg_14128664")]
    [DisplayName("Reversal Reason Information")]
    [IsoXmlTag("RvslRsnInf")]
    IEnumerable<IReversalReasonInformation1> ReversalReasonInformation { get; }

    /// <summary>
    /// Set of key elements of the original transaction being referred to.
    /// </summary>
    [IsoId("_Pr6kZNp-Ed-ak6NoX_4Aeg_1834389873")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    IOriginalTransactionReference1? OriginalTransactionReference { get; }
}
