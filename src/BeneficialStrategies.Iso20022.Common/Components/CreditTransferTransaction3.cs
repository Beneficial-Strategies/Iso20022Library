// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction3"/>
[IsoId("_tTMj0FkyEeGeoaLUQk__nA_-1763021567")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction3
{
    /// <inheritdoc cref="ICreditTransferTransaction3.UltimateDebtor"/>
    [IsoId("_tTWU0FkyEeGeoaLUQk__nA_2100330002")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.InitiatingParty"/>
    [IsoId("_tTWU0VkyEeGeoaLUQk__nA_1028324943")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification43? InitiatingParty { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.Debtor"/>
    [IsoId("_tTWU0lkyEeGeoaLUQk__nA_-1159750587")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.DebtorAccount"/>
    [IsoId("_tTfewFkyEeGeoaLUQk__nA_-656514408")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.DebtorAgent"/>
    [IsoId("_tTfewVkyEeGeoaLUQk__nA_-538643423")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.DebtorAgentAccount"/>
    [IsoId("_tTfewlkyEeGeoaLUQk__nA_-791671138")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.PreviousInstructingAgent"/>
    [IsoId("_tTfew1kyEeGeoaLUQk__nA_82857282")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.PreviousInstructingAgentAccount"/>
    [IsoId("_tTpPwFkyEeGeoaLUQk__nA_71758505")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount24? PreviousInstructingAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.IntermediaryAgent1"/>
    [IsoId("_tTpPwVkyEeGeoaLUQk__nA_-1620421692")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.IntermediaryAgent1Account"/>
    [IsoId("_tTpPwlkyEeGeoaLUQk__nA_1473535656")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.IntermediaryAgent2"/>
    [IsoId("_tTpPw1kyEeGeoaLUQk__nA_1561166694")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.IntermediaryAgent2Account"/>
    [IsoId("_tTpPxFkyEeGeoaLUQk__nA_-282702295")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.IntermediaryAgent3"/>
    [IsoId("_tTzAwFkyEeGeoaLUQk__nA_42415212")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.IntermediaryAgent3Account"/>
    [IsoId("_tTzAwVkyEeGeoaLUQk__nA_-1014904828")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.CreditorAgent"/>
    [IsoId("_tT8KsFkyEeGeoaLUQk__nA_150512987")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.CreditorAgentAccount"/>
    [IsoId("_tT8KsVkyEeGeoaLUQk__nA_-1228169956")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.Creditor"/>
    [IsoId("_tT8KslkyEeGeoaLUQk__nA_1880507538")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.CreditorAccount"/>
    [IsoId("_tT8Ks1kyEeGeoaLUQk__nA_1817605635")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.UltimateCreditor"/>
    [IsoId("_tT8KtFkyEeGeoaLUQk__nA_1806506858")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.RemittanceInformation"/>
    [IsoId("_tUF7sFkyEeGeoaLUQk__nA_-1566297128")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation7? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction3.InstructedAmount"/>
    [IsoId("_tUF7sVkyEeGeoaLUQk__nA_835652269")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }
}
