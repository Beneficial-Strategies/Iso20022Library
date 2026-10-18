// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_s4rLAlkyEeGeoaLUQk__nA_-650190179")]
public interface IGroupHeader49 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_s4rLA1kyEeGeoaLUQk__nA_1977894367")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    IsoMax35Text MessageIdentification { get; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_s4-F8FkyEeGeoaLUQk__nA_-1790076986")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    IsoISODateTime CreationDateTime { get; }

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    [IsoId("_s5RA4FkyEeGeoaLUQk__nA_-1013322692")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    IsoBatchBookingIndicator? BatchBooking { get; }

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_s5RA4VkyEeGeoaLUQk__nA_-1684866988")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    IsoMax15NumericText NumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_s5RA4lkyEeGeoaLUQk__nA_729794668")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    IsoDecimalNumber? ControlSum { get; }

    /// <summary>
    /// Total amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_s5RA41kyEeGeoaLUQk__nA_-1695965765")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_s5ax4FkyEeGeoaLUQk__nA_718695891")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    IsoISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the instructed agent is completed.
    /// </summary>
    [IsoId("_s5j70FkyEeGeoaLUQk__nA_-338154809")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    ISettlementInstruction1 SettlementInformation { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_s5j70VkyEeGeoaLUQk__nA_-2129026367")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation21? PaymentTypeInformation { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_s5ts0FkyEeGeoaLUQk__nA_-1368261214")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_s5ts0VkyEeGeoaLUQk__nA_2091940249")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructedAgent { get; }
}
