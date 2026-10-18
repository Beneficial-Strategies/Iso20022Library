// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_PvMh4tp-Ed-ak6NoX_4Aeg_-279444335")]
public interface IGroupHeader1 : IIsoComponent
{
    /// <summary>
    /// Point to point reference assigned by the instructing party and sent to the next party in the chain to unambiguously identify the message.||Usage: The instructing party has to make sure that &apos;MessageIdentification&apos; is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_PvMh49p-Ed-ak6NoX_4Aeg_907204266")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    IsoMax35Text MessageIdentification { get; }

    /// <summary>
    /// Date and time at which a (group of) payment instruction(s) was created by the instructing party.
    /// </summary>
    [IsoId("_PvMh5Np-Ed-ak6NoX_4Aeg_907205059")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    IsoISODateTime CreationDateTime { get; }

    /// <summary>
    /// User identification or any user key that allows to check if the initiating party is allowed to initiate transactions from the account specified in the initiation.||Usage: the content is not of a technical nature, but reflects the organisational structure at the initiating side. The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a different party than the initiating party.
    /// </summary>
    [IsoId("_PvMh5dp-Ed-ak6NoX_4Aeg_907205214")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    IEnumerable<string> Authorisation { get; }

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions in the message is requested.
    /// </summary>
    [IsoId("_PvMh5tp-Ed-ak6NoX_4Aeg_908125661")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    IsoBatchBookingIndicator? BatchBooking { get; }

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_PvMh59p-Ed-ak6NoX_4Aeg_908127633")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    IsoMax15NumericText NumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_PvMh6Np-Ed-ak6NoX_4Aeg_908128667")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    IsoDecimalNumber? ControlSum { get; }

    /// <summary>
    /// Indicates whether common accounting information in the transaction is included once for all transactions or repeated for each single transaction.
    /// </summary>
    [IsoId("_PvMh6dp-Ed-ak6NoX_4Aeg_-279443776")]
    [DisplayName("Grouping")]
    [IsoXmlTag("Grpg")]
    Grouping1Code Grouping { get; }

    /// <summary>
    /// Party initiating the payment. In the payment context, this can either be the debtor (in a credit transfer), the creditor (in a direct debit), or the party that initiates the payment on behalf of the debtor or creditor.
    /// </summary>
    [IsoId("_PvMh6tp-Ed-ak6NoX_4Aeg_-279443740")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    IPartyIdentification8 InitiatingParty { get; }

    /// <summary>
    /// Financial institution that receives the instruction from the initiating party and forwards it to the next agent in the payment chain for execution.
    /// </summary>
    [IsoId("_PvWS4Np-Ed-ak6NoX_4Aeg_-279443698")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    IBranchAndFinancialInstitutionIdentification3? ForwardingAgent { get; }
}
