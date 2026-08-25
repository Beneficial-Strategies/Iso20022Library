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
[IsoId("_sVST0W9YEe-Mlpx0N5T4gg")]
[DisplayName("Group Header131")]
public record GroupHeader131
{
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
    /// Date and time on which the payment should be expired if it has not settled.
    /// </summary>
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public IsoISODateTime? ExpiryDateTime { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedAgent { get; init; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
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
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the instructed agent is completed.
    /// </summary>
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInstruction15 SettlementInformation { get; init; }

    /// <summary>
    /// Total amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }
}
