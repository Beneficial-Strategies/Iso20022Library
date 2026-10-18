// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_PtjjLNp-Ed-ak6NoX_4Aeg_1192802893")]
public interface IGroupHeader8 : IIsoComponent
{
    /// <summary>
    /// Point to point reference assigned by the instructing party and sent to the next party in the chain to unambiguously identify the message.||Usage: The instructing party has to make sure that &apos;MessageIdentification&apos; is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_PtjjLdp-Ed-ak6NoX_4Aeg_1192802937")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    IsoMax35Text MessageIdentification { get; }

    /// <summary>
    /// Date and time at which a (group of) payment instruction(s) was created by the instructing party.
    /// </summary>
    [IsoId("_PtjjLtp-Ed-ak6NoX_4Aeg_1192802971")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    IsoISODateTime CreationDateTime { get; }

    /// <summary>
    /// User identification or any user key that allows to check if the initiating party is allowed to initiate transactions from the account specified in the initiation.||Usage: the content is not of a technical nature, but reflects the organisational structure at the initiating side. The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a different party than the initiating party.
    /// </summary>
    [IsoId("_PttUINp-Ed-ak6NoX_4Aeg_1192803013")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    IEnumerable<string> Authorisation { get; }

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions in the message is requested.
    /// </summary>
    [IsoId("_PttUIdp-Ed-ak6NoX_4Aeg_1192803048")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    IsoBatchBookingIndicator? BatchBooking { get; }

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_PttUItp-Ed-ak6NoX_4Aeg_1192803066")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    IsoMax15NumericText NumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_PttUI9p-Ed-ak6NoX_4Aeg_1192803108")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    IsoDecimalNumber? ControlSum { get; }

    /// <summary>
    /// Indicates whether the reversal applies to the whole group of transactions or to individual transactions within the original group.
    /// </summary>
    [IsoId("_PttUJNp-Ed-ak6NoX_4Aeg_1192803126")]
    [DisplayName("Group Reversal")]
    [IsoXmlTag("GrpRvsl")]
    IsoTrueFalseIndicator? GroupReversal { get; }

    /// <summary>
    /// Party initiating the payment. In the payment context, this can either be the debtor (in a credit transfer), the creditor (in a direct debit), or the party that initiates the payment on behalf of the debtor or creditor.
    /// </summary>
    [IsoId("_Pt2eENp-Ed-ak6NoX_4Aeg_-1175099776")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    IPartyIdentification8? InitiatingParty { get; }

    /// <summary>
    /// Financial institution that receives the instruction from the initiating party and forwards it to the next agent in the payment chain.
    /// </summary>
    [IsoId("_Pt2eEdp-Ed-ak6NoX_4Aeg_-1175100054")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    IBranchAndFinancialInstitutionIdentification3? ForwardingAgent { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_Pt2eEtp-Ed-ak6NoX_4Aeg_-1906141875")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification3? DebtorAgent { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_Pt2eE9p-Ed-ak6NoX_4Aeg_2021264130")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification3? CreditorAgent { get; }
}
