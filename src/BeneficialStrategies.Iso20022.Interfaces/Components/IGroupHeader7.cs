// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
[IsoId("_Pt2eGtp-Ed-ak6NoX_4Aeg_1753379922")]
public interface IGroupHeader7 : IIsoComponent
{
    /// <summary>
    /// Point to point reference assigned by the instructing party and sent to the next party in the chain to unambiguously identify the message.||Usage: The instructing party has to make sure that &apos;MessageIdentification&apos; is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_Pt2eG9p-Ed-ak6NoX_4Aeg_1753379964")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    Max35Text MessageIdentification { get; }

    /// <summary>
    /// Date and time at which the (group of) cancellation request(s) was created by the instructing party.
    /// </summary>
    [IsoId("_Pt2eHNp-Ed-ak6NoX_4Aeg_1753379999")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    ISODateTime CreationDateTime { get; }

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_Pt2eHdp-Ed-ak6NoX_4Aeg_1753380319")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    Max15NumericText NumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_PuAPENp-Ed-ak6NoX_4Aeg_1753380354")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    DecimalNumber? ControlSum { get; }

    /// <summary>
    /// Indicates whether the cancellation applies to a whole group of transactions or to individual transactions within the original group.
    /// </summary>
    [IsoId("_PuAPEdp-Ed-ak6NoX_4Aeg_-1720577362")]
    [DisplayName("Group Cancellation")]
    [IsoXmlTag("GrpCxl")]
    GroupingIndicator? GroupCancellation { get; }

    /// <summary>
    /// Party initiating the payment. In the payment context, this can either be the debtor (in a credit transfer), the creditor (in a direct debit), or the party that initiates the payment on behalf of the debtor or creditor.
    /// </summary>
    [IsoId("_PuAPEtp-Ed-ak6NoX_4Aeg_-2024418513")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    IPartyIdentification8? InitiatingParty { get; }

    /// <summary>
    /// Financial institution that receives the instruction from the initiating party and forwards it to the next agent in the payment chain.
    /// </summary>
    [IsoId("_PuAPE9p-Ed-ak6NoX_4Aeg_-2110306077")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    IBranchAndFinancialInstitutionIdentification3? ForwardingAgent { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_PuAPFNp-Ed-ak6NoX_4Aeg_2142182169")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification3? DebtorAgent { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_PuAPFdp-Ed-ak6NoX_4Aeg_-2126005376")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification3? CreditorAgent { get; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PuAPFtp-Ed-ak6NoX_4Aeg_1754300524")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    IBranchAndFinancialInstitutionIdentification3? InstructingAgent { get; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PuAPF9p-Ed-ak6NoX_4Aeg_1754300464")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    IBranchAndFinancialInstitutionIdentification3? InstructedAgent { get; }
}
