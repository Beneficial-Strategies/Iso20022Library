// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader75"/>
[IsoId("_ov3efbTgEeef0oKPLRNatg")]
[DisplayName("Group Header")]
public partial record GroupHeader75
{
    /// <inheritdoc cref="IGroupHeader75.MessageIdentification"/>
    [IsoId("_o3nFNbTgEeef0oKPLRNatg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader75.CreationDateTime"/>
    [IsoId("_o3nFN7TgEeef0oKPLRNatg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader75.Authorisation"/>
    [IsoId("_o3nFObTgEeef0oKPLRNatg")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader75.NumberOfTransactions"/>
    [IsoId("_o3nFO7TgEeef0oKPLRNatg")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader75.ControlSum"/>
    [IsoId("_o3nFPbTgEeef0oKPLRNatg")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader75.GroupReversal"/>
    [IsoId("_o3nFP7TgEeef0oKPLRNatg")]
    [DisplayName("Group Reversal")]
    [IsoXmlTag("GrpRvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GroupReversal { get; init; }

    /// <inheritdoc cref="IGroupHeader75.InitiatingParty"/>
    [IsoId("_o3nFQbTgEeef0oKPLRNatg")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification125? InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader75.ForwardingAgent"/>
    [IsoId("_o3nFQ7TgEeef0oKPLRNatg")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification5? ForwardingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader75.DebtorAgent"/>
    [IsoId("_o3nFRbTgEeef0oKPLRNatg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader75.CreditorAgent"/>
    [IsoId("_o3nFR7TgEeef0oKPLRNatg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }
}
