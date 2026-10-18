// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader124"/>
[IsoId("_5P03sTEyEe6g-ffJsqGiSA")]
[Description(@"Provides characteristics shared by all individual transactions included in the message.")]
[DisplayName("Group Header124")]
public partial record GroupHeader124
{
    /// <inheritdoc cref="IGroupHeader124.Authorisation"/>
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader124.ControlSum"/>
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader124.CreationDateTime"/>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader124.CreditorAgent"/>
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? CreditorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader124.DebtorAgent"/>
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DebtorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader124.ForwardingAgent"/>
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification8? ForwardingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader124.GroupReversal"/>
    [DisplayName("Group Reversal")]
    [IsoXmlTag("GrpRvsl")]
    public IsoTrueFalseIndicator? GroupReversal { get; init; }

    /// <inheritdoc cref="IGroupHeader124.InitiatingParty"/>
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification272? InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader124.MessageIdentification"/>
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader124.NumberOfTransactions"/>
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }
}
