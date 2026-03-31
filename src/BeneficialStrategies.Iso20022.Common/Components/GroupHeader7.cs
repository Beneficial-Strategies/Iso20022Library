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
[IsoId("_Pt2eGtp-Ed-ak6NoX_4Aeg_1753379922")]
[DisplayName("Group Header")]
public record GroupHeader7
{
    /// <summary>
    /// Point to point reference assigned by the instructing party and sent to the next party in the chain to unambiguously identify the message.||Usage: The instructing party has to make sure that &apos;MessageIdentification&apos; is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_Pt2eG9p-Ed-ak6NoX_4Aeg_1753379964")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the (group of) cancellation request(s) was created by the instructing party.
    /// </summary>
    [IsoId("_Pt2eHNp-Ed-ak6NoX_4Aeg_1753379999")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    [IsoId("_Pt2eHdp-Ed-ak6NoX_4Aeg_1753380319")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_PuAPENp-Ed-ak6NoX_4Aeg_1753380354")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Indicates whether the cancellation applies to a whole group of transactions or to individual transactions within the original group.
    /// </summary>
    [IsoId("_PuAPEdp-Ed-ak6NoX_4Aeg_-1720577362")]
    [DisplayName("Group Cancellation")]
    [IsoXmlTag("GrpCxl")]
    [IsoSimpleType(IsoSimpleType.GroupingIndicator)]
    public IsoGroupingIndicator? GroupCancellation { get; init; }

    /// <summary>
    /// Party initiating the payment. In the payment context, this can either be the debtor (in a credit transfer), the creditor (in a direct debit), or the party that initiates the payment on behalf of the debtor or creditor.
    /// </summary>
    [IsoId("_PuAPEtp-Ed-ak6NoX_4Aeg_-2024418513")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification8? InitiatingParty { get; init; }

    /// <summary>
    /// Financial institution that receives the instruction from the initiating party and forwards it to the next agent in the payment chain.
    /// </summary>
    [IsoId("_PuAPE9p-Ed-ak6NoX_4Aeg_-2110306077")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification3? ForwardingAgent { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_PuAPFNp-Ed-ak6NoX_4Aeg_2142182169")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_PuAPFdp-Ed-ak6NoX_4Aeg_-2126005376")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; }

    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PuAPFtp-Ed-ak6NoX_4Aeg_1754300524")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    [IsoId("_PuAPF9p-Ed-ak6NoX_4Aeg_1754300464")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }
}
