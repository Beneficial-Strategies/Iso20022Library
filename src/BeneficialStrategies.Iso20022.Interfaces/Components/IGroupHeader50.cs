// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_s53d0FkyEeGeoaLUQk__nA_1710000299")]
public interface IGroupHeader50 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_s53d0VkyEeGeoaLUQk__nA_-424500861")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    Max35Text MessageIdentification { get; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_s53d0lkyEeGeoaLUQk__nA_102495082")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    ISODateTime CreationDateTime { get; }

    /// <summary>
    /// User identification or any user key to be used to check whether the initiating party is allowed to initiate transactions from the account specified in the message.||Usage: The content is not of a technical nature, but reflects the organisational structure at the initiating side.|The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a party different from the initiating party.
    /// </summary>
    [IsoId("_s53d01kyEeGeoaLUQk__nA_-1558277363")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    IEnumerable<IAuthorisation1Choice> Authorisation { get; }

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    [IsoId("_s6AnwFkyEeGeoaLUQk__nA_856384293")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    BatchBookingIndicator? BatchBooking { get; }

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_s6AnwVkyEeGeoaLUQk__nA_-1569376140")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    Max15NumericText NumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_s6AnwlkyEeGeoaLUQk__nA_845285516")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    DecimalNumber? ControlSum { get; }

    /// <summary>
    /// Total amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_s6Anw1kyEeGeoaLUQk__nA_548614403")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_s6AnxFkyEeGeoaLUQk__nA_1075610346")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the instructed agent is completed.
    /// </summary>
    [IsoId("_s6KYwFkyEeGeoaLUQk__nA_715634298")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    ISettlementInstruction2 SettlementInformation { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_s6KYwVkyEeGeoaLUQk__nA_301208426")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation25? PaymentTypeInformation { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_s6KYwlkyEeGeoaLUQk__nA_1352341498")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_s6UJwFkyEeGeoaLUQk__nA_1008781041")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification5? InstructedAgent { get; }
}
