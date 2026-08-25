// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[Description(@"Set of characteristics shared by all individual transactions included in the message.")]
[IsoId("_54NtYTEyEe6g-ffJsqGiSA")]
[DisplayName("Group Header127")]
public record GroupHeader127
{
    /// <summary>
    /// User identification or any user key to be used to check whether the initiating party is allowed to initiate transactions from the account specified in the message.
    /// </summary>
    /// <remarks>
    /// Usage: The content is not of a technical nature, but reflects the organisational structure at the initiating side.
    /// The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a party different from the initiating party.
    /// </remarks>
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.
    /// </summary>
    /// <remarks>
    /// Usage: Batch booking is used to request and not order a possible batch booking.
    /// </remarks>
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Indicates whether the reversal applies to the whole group of transactions or to individual transactions within the original group.
    /// </summary>
    [DisplayName("Group Reversal")]
    [IsoXmlTag("GrpRvsl")]
    public IsoTrueFalseIndicator? GroupReversal { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    /// <remarks>
    /// Usage: The instructed agent is the party receiving the reversal message and not the party that received the original instruction that is being reversed.
    /// </remarks>
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedAgent { get; init; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    /// <remarks>
    /// Usage: The instructing agent is the party sending the reversal message and not the party that sent the original instruction that is being reversed.
    /// </remarks>
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructingAgent { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.
    /// </summary>
    /// <remarks>
    /// Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </remarks>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the instructed agent is completed.
    /// </summary>
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInstruction15 SettlementInformation { get; init; }

    /// <summary>
    /// Total amount of money moved between the instructing agent and the instructed agent in the reversal message.
    /// </summary>
    [DisplayName("Total Reversed Interbank Settlement Amount")]
    [IsoXmlTag("TtlRvsdIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalReversedInterbankSettlementAmount { get; init; }
}
