// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction32"/>
[IsoId("_ZooK0YtlEee-OJ-wXSj3YQ")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction32
{
    /// <inheritdoc cref="ICreditTransferTransaction32.UltimateDebtor"/>
    [IsoId("_Zx_iQ4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification125? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.InitiatingParty"/>
    [IsoId("_Zx_iRYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification125? InitiatingParty { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.Debtor"/>
    [IsoId("_Zx_iR4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification125 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.DebtorAccount"/>
    [IsoId("_Zx_iSYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.DebtorAgent"/>
    [IsoId("_Zx_iS4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.DebtorAgentAccount"/>
    [IsoId("_Zx_iTYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.PreviousInstructingAgent1"/>
    [IsoId("_ns2ThotlEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.PreviousInstructingAgent1Account"/>
    [IsoId("_ns2Th4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent 1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount24? PreviousInstructingAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.PreviousInstructingAgent2"/>
    [IsoId("_ns2TiItlEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.PreviousInstructingAgent2Account"/>
    [IsoId("_ns2TiYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent 2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount24? PreviousInstructingAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.PreviousInstructingAgent3"/>
    [IsoId("_ns2TiotlEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.PreviousInstructingAgent3Account"/>
    [IsoId("_ns2Ti4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Previous Instructing Agent 3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount24? PreviousInstructingAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.IntermediaryAgent1"/>
    [IsoId("_Zx_iU4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.IntermediaryAgent1Account"/>
    [IsoId("_Zx_iVYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.IntermediaryAgent2"/>
    [IsoId("_Zx_iV4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.IntermediaryAgent2Account"/>
    [IsoId("_Zx_iWYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.IntermediaryAgent3"/>
    [IsoId("_Zx_iW4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.IntermediaryAgent3Account"/>
    [IsoId("_Zx_iXYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.CreditorAgent"/>
    [IsoId("_Zx_iX4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.CreditorAgentAccount"/>
    [IsoId("_Zx_iYYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.Creditor"/>
    [IsoId("_Zx_iY4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification125 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.CreditorAccount"/>
    [IsoId("_Zx_iZYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.UltimateCreditor"/>
    [IsoId("_Zx_iZ4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification125? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.InstructionForCreditorAgent"/>
    [IsoId("_Zx_iaYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction32.InstructionForNextAgent"/>
    [IsoId("_Zx_ia4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction32.Tax"/>
    [IsoId("_Zx_ibYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation6? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.RemittanceInformation"/>
    [IsoId("_Zx_ib4tlEee-OJ-wXSj3YQ")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation15? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction32.InstructedAmount"/>
    [IsoId("_Zx_icYtlEee-OJ-wXSj3YQ")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }
}
