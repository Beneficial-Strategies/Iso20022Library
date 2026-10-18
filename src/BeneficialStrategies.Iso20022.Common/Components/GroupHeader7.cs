// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader7"/>
[IsoId("_Pt2eGtp-Ed-ak6NoX_4Aeg_1753379922")]
[DisplayName("Group Header")]
public partial record GroupHeader7
{
    /// <inheritdoc cref="IGroupHeader7.MessageIdentification"/>
    [IsoId("_Pt2eG9p-Ed-ak6NoX_4Aeg_1753379964")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader7.CreationDateTime"/>
    [IsoId("_Pt2eHNp-Ed-ak6NoX_4Aeg_1753379999")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader7.NumberOfTransactions"/>
    [IsoId("_Pt2eHdp-Ed-ak6NoX_4Aeg_1753380319")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader7.ControlSum"/>
    [IsoId("_PuAPENp-Ed-ak6NoX_4Aeg_1753380354")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader7.GroupCancellation"/>
    [IsoId("_PuAPEdp-Ed-ak6NoX_4Aeg_-1720577362")]
    [DisplayName("Group Cancellation")]
    [IsoXmlTag("GrpCxl")]
    [IsoSimpleType(IsoSimpleType.GroupingIndicator)]
    public IsoGroupingIndicator? GroupCancellation { get; init; }

    /// <inheritdoc cref="IGroupHeader7.InitiatingParty"/>
    [IsoId("_PuAPEtp-Ed-ak6NoX_4Aeg_-2024418513")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification8? InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader7.ForwardingAgent"/>
    [IsoId("_PuAPE9p-Ed-ak6NoX_4Aeg_-2110306077")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification3? ForwardingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader7.DebtorAgent"/>
    [IsoId("_PuAPFNp-Ed-ak6NoX_4Aeg_2142182169")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader7.CreditorAgent"/>
    [IsoId("_PuAPFdp-Ed-ak6NoX_4Aeg_-2126005376")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader7.InstructingAgent"/>
    [IsoId("_PuAPFtp-Ed-ak6NoX_4Aeg_1754300524")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader7.InstructedAgent"/>
    [IsoId("_PuAPF9p-Ed-ak6NoX_4Aeg_1754300464")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }
}
