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
[IsoId("_Pu5m-Np-Ed-ak6NoX_4Aeg_1836538935")]
[DisplayName("Group Header")]
public record GroupHeader2
{
    /// <summary>
    /// Point to point reference assigned by the instructing party and sent to the next party in the chain to unambiguously identify the message.||Usage: The instructing party has to make sure that &apos;MessageIdentification&apos; is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_Pu5m-dp-Ed-ak6NoX_4Aeg_1983380232")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which a (group of) payment instruction(s) was created by the instructing party.
    /// </summary>
    [IsoId("_Pu5m-tp-Ed-ak6NoX_4Aeg_2024935405")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions in the message is requested.
    /// </summary>
    [IsoId("_PvCw4Np-Ed-ak6NoX_4Aeg_2051718894")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_PvCw4dp-Ed-ak6NoX_4Aeg_-739754788")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_PvCw4tp-Ed-ak6NoX_4Aeg_547367153")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Total amount of money transferred between instructing agent and instructed agent.
    /// </summary>
    [IsoId("_PvCw49p-Ed-ak6NoX_4Aeg_65287942")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    public CurrencyAndAmount? TotalInterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_PvCw5Np-Ed-ak6NoX_4Aeg_-185452988")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the instructed agent is completed.
    /// </summary>
    [IsoId("_PvCw5dp-Ed-ak6NoX_4Aeg_1600410984")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public required SettlementInformation1 SettlementInformation { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_PvCw5tp-Ed-ak6NoX_4Aeg_-342847539")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation3? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PvCw59p-Ed-ak6NoX_4Aeg_1511874180")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PvCw6Np-Ed-ak6NoX_4Aeg_1757529426")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }
}
