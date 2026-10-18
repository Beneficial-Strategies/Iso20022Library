// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_g-JF4dcZEeqRFcf2R4bPBw")]
public interface IGroupHeader99 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party and sent to the next party in the chain, to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_g_r-B9cZEeqRFcf2R4bPBw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    Max35Text MessageIdentification { get; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_g_r-CdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    ISODateTime CreationDateTime { get; }

    /// <summary>
    /// User identification or any user key to be used to check whether the initiating party is allowed to initiate transactions from the account specified in the message.||Usage: The content is not of a technical nature, but reflects the organisational structure at the initiating side.|The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a party different from the initiating party.
    /// </summary>
    [IsoId("_g_r-C9cZEeqRFcf2R4bPBw")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    IEnumerable<IAuthorisation1Choice> Authorisation { get; }

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    [IsoId("_g_r-DdcZEeqRFcf2R4bPBw")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    BatchBookingIndicator? BatchBooking { get; }

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_g_r-D9cZEeqRFcf2R4bPBw")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    Max15NumericText NumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_g_r-EdcZEeqRFcf2R4bPBw")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    DecimalNumber? ControlSum { get; }

    /// <summary>
    /// Indicates whether the return applies to the whole group of transactions or to individual transactions within the original group(s).
    /// </summary>
    [IsoId("_g_r-E9cZEeqRFcf2R4bPBw")]
    [DisplayName("Group Return")]
    [IsoXmlTag("GrpRtr")]
    TrueFalseIndicator? GroupReturn { get; }

    /// <summary>
    /// Total amount of money moved between the instructing agent and the instructed agent in the return message.
    /// </summary>
    [IsoId("_g_r-FdcZEeqRFcf2R4bPBw")]
    [DisplayName("Total Returned Interbank Settlement Amount")]
    [IsoXmlTag("TtlRtrdIntrBkSttlmAmt")]
    ActiveCurrencyAndAmount? TotalReturnedInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_g_r-F9cZEeqRFcf2R4bPBw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the instructed agent is completed.
    /// </summary>
    [IsoId("_g_r-GdcZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    ISettlementInstruction11 SettlementInformation { get; }

    /// <summary>
    /// Specifies the type of the return transaction.
    /// </summary>
    [IsoId("_uH_acNitEeq5MfBBxQig1Q")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation28? PaymentTypeInformation { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).|Usage: The instructing agent is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    [IsoId("_g_r-G9cZEeqRFcf2R4bPBw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification6? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).|Usage: The instructed agent is the party receiving the return message and not the party that received the original instruction that is being returned.
    /// </summary>
    [IsoId("_g_r-HdcZEeqRFcf2R4bPBw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification6? InstructedAgent { get; }
}
