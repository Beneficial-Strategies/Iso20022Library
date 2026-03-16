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
[IsoId("_s9lgMFkyEeGeoaLUQk__nA_-1173772128")]
[DisplayName("Group Header")]
public record GroupHeader57
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_s9lgMVkyEeGeoaLUQk__nA_2010283749")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_s9lgMlkyEeGeoaLUQk__nA_512425699")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// User identification or any user key to be used to check whether the initiating party is allowed to initiate transactions from the account specified in the message.||Usage: The content is not of a technical nature, but reflects the organisational structure at the initiating side.|The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a party different from the initiating party.
    /// </summary>
    [IsoId("_s9lgM1kyEeGeoaLUQk__nA_1289179993")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    [IsoId("_s9vRMFkyEeGeoaLUQk__nA_-72758772")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_s9vRMVkyEeGeoaLUQk__nA_-1953064412")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_s9vRMlkyEeGeoaLUQk__nA_206510370")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Indicates whether the reversal applies to the whole group of transactions or to individual transactions within the original group.
    /// </summary>
    [IsoId("_s9vRM1kyEeGeoaLUQk__nA_-1673795270")]
    [DisplayName("Group Reversal")]
    [IsoXmlTag("GrpRvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GroupReversal { get; init; }

    /// <summary>
    /// Total amount of money moved between the instructing agent and the instructed agent in the reversal message.
    /// </summary>
    [IsoId("_s9vRNFkyEeGeoaLUQk__nA_-865494689")]
    [DisplayName("Total Reversed Interbank Settlement Amount")]
    [IsoXmlTag("TtlRvsdIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalReversedInterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_s95CMFkyEeGeoaLUQk__nA_1549166967")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the instructed agent is completed.
    /// </summary>
    [IsoId("_s95CMVkyEeGeoaLUQk__nA_-422506197")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInstruction1 SettlementInformation { get; init; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).||Usage: The instructing agent is the party sending the reversal message and not the party that sent the original instruction that is being reversed.
    /// </summary>
    [IsoId("_s-CMIFkyEeGeoaLUQk__nA_1744633256")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).||Usage: The instructed agent is the party receiving the reversal message and not the party that received the original instruction that is being reversed.
    /// </summary>
    [IsoId("_s-CMIVkyEeGeoaLUQk__nA_-1472313702")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }
}
