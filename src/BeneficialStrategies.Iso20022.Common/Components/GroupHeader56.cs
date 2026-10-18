// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader56"/>
[IsoId("_s8i-Y1kyEeGeoaLUQk__nA_845535139")]
[DisplayName("Group Header")]
public partial record GroupHeader56
{
    /// <inheritdoc cref="IGroupHeader56.MessageIdentification"/>
    [IsoId("_s8svYFkyEeGeoaLUQk__nA_-518427658")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader56.CreationDateTime"/>
    [IsoId("_s8svYVkyEeGeoaLUQk__nA_8568285")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader56.Authorisation"/>
    [IsoId("_s815UFkyEeGeoaLUQk__nA_113778283")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Authorisation1Choice_> Authorisation { get; init; } = [];

    /// <inheritdoc cref="IGroupHeader56.NumberOfTransactions"/>
    [IsoId("_s815UVkyEeGeoaLUQk__nA_102679506")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IGroupHeader56.ControlSum"/>
    [IsoId("_s815UlkyEeGeoaLUQk__nA_-1777626134")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IGroupHeader56.GroupReversal"/>
    [IsoId("_s8_qUFkyEeGeoaLUQk__nA_-2025148337")]
    [DisplayName("Group Reversal")]
    [IsoXmlTag("GrpRvsl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? GroupReversal { get; init; }

    /// <inheritdoc cref="IGroupHeader56.InitiatingParty"/>
    [IsoId("_s8_qUVkyEeGeoaLUQk__nA_97555581")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification43? InitiatingParty { get; init; }

    /// <inheritdoc cref="IGroupHeader56.ForwardingAgent"/>
    [IsoId("_s9JbUFkyEeGeoaLUQk__nA_1212498919")]
    [DisplayName("Forwarding Agent")]
    [IsoXmlTag("FwdgAgt")]
    public BranchAndFinancialInstitutionIdentification5? ForwardingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader56.DebtorAgent"/>
    [IsoId("_s9JbUVkyEeGeoaLUQk__nA_1112653925")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader56.CreditorAgent"/>
    [IsoId("_s9JbUlkyEeGeoaLUQk__nA_-1285776647")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }
}
