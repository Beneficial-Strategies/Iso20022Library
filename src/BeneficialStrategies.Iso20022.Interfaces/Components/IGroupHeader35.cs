// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_Pz9tKNp-Ed-ak6NoX_4Aeg_-1416527618")]
public interface IGroupHeader35 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_Pz9tKdp-Ed-ak6NoX_4Aeg_-1416527609")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    Max35Text MessageIdentification { get; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_Pz9tKtp-Ed-ak6NoX_4Aeg_-1416527557")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    ISODateTime CreationDateTime { get; }

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    [IsoId("_Pz9tK9p-Ed-ak6NoX_4Aeg_-1416527496")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    BatchBookingIndicator? BatchBooking { get; }

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_Pz9tLNp-Ed-ak6NoX_4Aeg_-1416527217")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    Max15NumericText NumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_P0HeINp-Ed-ak6NoX_4Aeg_-1416527156")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    DecimalNumber? ControlSum { get; }

    /// <summary>
    /// Total amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_P0HeIdp-Ed-ak6NoX_4Aeg_-1416527095")]
    [DisplayName("Total Interbank Settlement Amount")]
    [IsoXmlTag("TtlIntrBkSttlmAmt")]
    ActiveCurrencyAndAmount? TotalInterbankSettlementAmount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_P0HeItp-Ed-ak6NoX_4Aeg_-1416527064")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    ISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Specifies the details on how the settlement of the transaction(s) between the instructing agent and the instructed agent is completed.
    /// </summary>
    [IsoId("_P0HeI9p-Ed-ak6NoX_4Aeg_-1416527002")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    ISettlementInformation13 SettlementInformation { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_P0HeJNp-Ed-ak6NoX_4Aeg_-1416526662")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation23? PaymentTypeInformation { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_P0HeJdp-Ed-ak6NoX_4Aeg_-1416526693")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification4? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_P0HeJtp-Ed-ak6NoX_4Aeg_-1416526971")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification4? InstructedAgent { get; }
}
