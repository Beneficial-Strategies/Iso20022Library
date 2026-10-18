// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction18"/>
[IsoId("_UV4eARfLEeSEFrADmEUU2w")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction18
{
    /// <inheritdoc cref="ICreditTransferTransaction18.UltimateDebtor"/>
    [IsoId("_UzWdMxfLEeSEFrADmEUU2w")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.InitiatingParty"/>
    [IsoId("_UzWdNRfLEeSEFrADmEUU2w")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public PartyIdentification43? InitiatingParty { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.Debtor"/>
    [IsoId("_UzWdNxfLEeSEFrADmEUU2w")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.DebtorAccount"/>
    [IsoId("_UzWdORfLEeSEFrADmEUU2w")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.DebtorAgent"/>
    [IsoId("_UzWdOxfLEeSEFrADmEUU2w")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.DebtorAgentAccount"/>
    [IsoId("_UzWdPRfLEeSEFrADmEUU2w")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.PreviousInstructingAgent"/>
    [IsoId("_UzWdPxfLEeSEFrADmEUU2w")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? PreviousInstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.PreviousInstructingAgentAccount"/>
    [IsoId("_UzWdQRfLEeSEFrADmEUU2w")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount24? PreviousInstructingAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.IntermediaryAgent1"/>
    [IsoId("_UzWdQxfLEeSEFrADmEUU2w")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.IntermediaryAgent1Account"/>
    [IsoId("_UzWdRRfLEeSEFrADmEUU2w")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.IntermediaryAgent2"/>
    [IsoId("_UzWdRxfLEeSEFrADmEUU2w")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.IntermediaryAgent2Account"/>
    [IsoId("_UzWdSRfLEeSEFrADmEUU2w")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.IntermediaryAgent3"/>
    [IsoId("_UzWdSxfLEeSEFrADmEUU2w")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.IntermediaryAgent3Account"/>
    [IsoId("_UzWdTRfLEeSEFrADmEUU2w")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.CreditorAgent"/>
    [IsoId("_UzWdTxfLEeSEFrADmEUU2w")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.CreditorAgentAccount"/>
    [IsoId("_UzWdURfLEeSEFrADmEUU2w")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.Creditor"/>
    [IsoId("_UzWdUxfLEeSEFrADmEUU2w")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.CreditorAccount"/>
    [IsoId("_UzWdVRfLEeSEFrADmEUU2w")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.UltimateCreditor"/>
    [IsoId("_UzWdVxfLEeSEFrADmEUU2w")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.InstructionForCreditorAgent"/>
    [IsoId("_MK8HwR8cEeSxevWRRWxNAg")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction18.InstructionForNextAgent"/>
    [IsoId("_ldXjYRfLEeSEFrADmEUU2w")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction18.Tax"/>
    [IsoId("_fxNjwR8cEeSxevWRRWxNAg")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.RemittanceInformation"/>
    [IsoId("_UzWdWRfLEeSEFrADmEUU2w")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation10? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction18.InstructedAmount"/>
    [IsoId("_UzWdWxfLEeSEFrADmEUU2w")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; }
}
