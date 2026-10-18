// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_Puv189p-Ed-ak6NoX_4Aeg_1445763661")]
public interface IGroupHeader3 : IIsoComponent
{
    /// <summary>
    /// Point to point reference assigned by the instructing party and sent to the next party in the chain to unambiguously identify the message.||Usage: The instructing party has to make sure that &apos;MessageIdentification&apos; is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_Puv19Np-Ed-ak6NoX_4Aeg_1445763680")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    Max35Text MessageIdentification { get; }

    /// <summary>
    /// Date and time at which a (group of) payment instruction(s) was created by the instructing party.
    /// </summary>
    [IsoId("_Puv19dp-Ed-ak6NoX_4Aeg_1445763799")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    ISODateTime CreationDateTime { get; }

    /// <summary>
    /// User identification or any user key that allows to check if the initiating party is allowed to initiate transactions from the account specified in the initiation.||Usage: the content is not of a technical nature, but reflects the organisational structure at the initiating side. The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a different party than the initiating party.
    /// </summary>
    [IsoId("_Puv19tp-Ed-ak6NoX_4Aeg_1445764082")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    IEnumerable<string> Authorisation { get; }

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions in the message is requested.
    /// </summary>
    [IsoId("_Puv199p-Ed-ak6NoX_4Aeg_1445764124")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    BatchBookingIndicator? BatchBooking { get; }

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_Puv1-Np-Ed-ak6NoX_4Aeg_1445764159")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    Max15NumericText NumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_Puv1-dp-Ed-ak6NoX_4Aeg_-1932144351")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    DecimalNumber? ControlSum { get; }

    /// <summary>
    /// Total amount of money transferred between instructing agent and instructed agent.
    /// </summary>
    [IsoId("_Puv1-tp-Ed-ak6NoX_4Aeg_1445764177")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    CurrencyAndAmount? TotalInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_Pu5m8Np-Ed-ak6NoX_4Aeg_1445764262")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the instructed agent is completed.
    /// </summary>
    [IsoId("_Pu5m8dp-Ed-ak6NoX_4Aeg_-1429748960")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    ISettlementInformation2 SettlementInformation { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_Pu5m8tp-Ed-ak6NoX_4Aeg_-454582771")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation4? PaymentTypeInformation { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_Pu5m89p-Ed-ak6NoX_4Aeg_1445764610")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification3? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_Pu5m9Np-Ed-ak6NoX_4Aeg_1445764341")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification3? InstructedAgent { get; }
}
