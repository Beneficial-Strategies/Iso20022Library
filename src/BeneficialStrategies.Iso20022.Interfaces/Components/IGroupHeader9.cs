// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_PtaZMNp-Ed-ak6NoX_4Aeg_-472629694")]
public interface IGroupHeader9 : IIsoComponent
{
    /// <summary>
    /// Point to point reference assigned by the instructing party and sent to the next party in the chain to unambiguously identify the message.||Usage: The instructing party has to make sure that &apos;MessageIdentification&apos; is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_PtaZMdp-Ed-ak6NoX_4Aeg_-1557438436")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    IsoMax35Text MessageIdentification { get; }

    /// <summary>
    /// Date and time at which a (group of) payment instruction(s) was created by the instructing party.
    /// </summary>
    [IsoId("_PtaZMtp-Ed-ak6NoX_4Aeg_-1557438366")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    IsoISODateTime CreationDateTime { get; }

    /// <summary>
    /// User identification or any user key that allows to check if the initiating party is allowed to initiate transactions from the account specified in the initiation.||Usage: the content is not of a technical nature, but reflects the organisational structure at the initiating side.|The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a different party than the initiating party.
    /// </summary>
    [IsoId("_PtaZM9p-Ed-ak6NoX_4Aeg_-1557438341")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    IEnumerable<string> Authorisation { get; }

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions in the message is requested.
    /// </summary>
    [IsoId("_PtaZNNp-Ed-ak6NoX_4Aeg_-1557438016")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    IsoBatchBookingIndicator? BatchBooking { get; }

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_PtaZNdp-Ed-ak6NoX_4Aeg_-1557437981")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    IsoMax15NumericText NumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_PtaZNtp-Ed-ak6NoX_4Aeg_-1557437903")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    IsoDecimalNumber? ControlSum { get; }

    /// <summary>
    /// Indicates whether the reversal applies to the whole group of transactions or to individual transactions within the original group.
    /// </summary>
    [IsoId("_PtaZN9p-Ed-ak6NoX_4Aeg_-1055967010")]
    [DisplayName("Group Reversal")]
    [IsoXmlTag("GrpRvsl")]
    IsoTrueFalseIndicator? GroupReversal { get; }

    /// <summary>
    /// Total reversed amount of money transferred between the instructing agent and the instructed agent in the reversal message.
    /// </summary>
    [IsoId("_PtaZONp-Ed-ak6NoX_4Aeg_-1557437826")]
    [DisplayName("Total Reversed Interbank Settlement Amount")]
    [IsoXmlTag("TtlRvsdIntrBkSttlmAmt")]
    CurrencyAndAmount? TotalReversedInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_PtaZOdp-Ed-ak6NoX_4Aeg_-1557437783")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    IsoISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the instructed agent is completed.
    /// </summary>
    [IsoId("_PtjjINp-Ed-ak6NoX_4Aeg_1834386927")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    ISettlementInformation1 SettlementInformation { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PtjjIdp-Ed-ak6NoX_4Aeg_-471705044")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification3? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PtjjItp-Ed-ak6NoX_4Aeg_-471705523")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification3? InstructedAgent { get; }
}
