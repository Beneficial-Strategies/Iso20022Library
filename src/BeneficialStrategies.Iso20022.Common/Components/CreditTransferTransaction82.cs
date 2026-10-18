// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction82"/>
[Description(@"Provides further details specific to the individual transaction(s) included in the message.")]
[IsoId("_eXCdsbpXEfCPZvweyV2nEg")]
[DisplayName("Credit Transfer Transaction82")]
public partial record CreditTransferTransaction82
{
    /// <inheritdoc cref="ICreditTransferTransaction82.PaymentIdentification"/>
    [IsoId("_eeABcbpXEfCPZvweyV2nEg")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification13 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.PaymentTypeInformation"/>
    [IsoId("_eeABc7pXEfCPZvweyV2nEg")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.InterbankSettlementAmount"/>
    [IsoId("_eeABdbpXEfCPZvweyV2nEg")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.InterbankSettlementDate"/>
    [IsoId("_eeABd7pXEfCPZvweyV2nEg")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.SettlementPriority"/>
    [IsoId("_eeABebpXEfCPZvweyV2nEg")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.SettlementTimeIndication"/>
    [IsoId("_eeABe7pXEfCPZvweyV2nEg")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.SettlementTimeRequest"/>
    [IsoId("_eeABfbpXEfCPZvweyV2nEg")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.ExpiryDateTime"/>
    [IsoId("_eeABf7pXEfCPZvweyV2nEg")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public IsoISODateTime? ExpiryDateTime { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.PaymentSignature"/>
    [IsoId("_eeABgbpXEfCPZvweyV2nEg")]
    [DisplayName("Payment Signature")]
    [IsoXmlTag("PmtSgntr")]
    public CryptographicKey1Choice_? PaymentSignature { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.PreviousInstructingAgent1"/>
    [IsoId("_eeABg7pXEfCPZvweyV2nEg")]
    [DisplayName("Previous Instructing Agent1")]
    [IsoXmlTag("PrvsInstgAgt1")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.PreviousInstructingAgent1Account"/>
    [IsoId("_eeABhbpXEfCPZvweyV2nEg")]
    [DisplayName("Previous Instructing Agent1 Account")]
    [IsoXmlTag("PrvsInstgAgt1Acct")]
    public CashAccount40? PreviousInstructingAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.PreviousInstructingAgent2"/>
    [IsoId("_eeABh7pXEfCPZvweyV2nEg")]
    [DisplayName("Previous Instructing Agent2")]
    [IsoXmlTag("PrvsInstgAgt2")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.PreviousInstructingAgent2Account"/>
    [IsoId("_eeABibpXEfCPZvweyV2nEg")]
    [DisplayName("Previous Instructing Agent2 Account")]
    [IsoXmlTag("PrvsInstgAgt2Acct")]
    public CashAccount40? PreviousInstructingAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.PreviousInstructingAgent3"/>
    [IsoId("_eeABi7pXEfCPZvweyV2nEg")]
    [DisplayName("Previous Instructing Agent3")]
    [IsoXmlTag("PrvsInstgAgt3")]
    public BranchAndFinancialInstitutionIdentification8? PreviousInstructingAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.PreviousInstructingAgent3Account"/>
    [IsoId("_eeABjbpXEfCPZvweyV2nEg")]
    [DisplayName("Previous Instructing Agent3 Account")]
    [IsoXmlTag("PrvsInstgAgt3Acct")]
    public CashAccount40? PreviousInstructingAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.InstructingAgent"/>
    [IsoId("_eeABj7pXEfCPZvweyV2nEg")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.InstructedAgent"/>
    [IsoId("_eeABkbpXEfCPZvweyV2nEg")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.IntermediaryAgent1"/>
    [IsoId("_eeABk7pXEfCPZvweyV2nEg")]
    [DisplayName("Intermediary Agent1")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.IntermediaryAgent1Account"/>
    [IsoId("_eeABlbpXEfCPZvweyV2nEg")]
    [DisplayName("Intermediary Agent1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount40? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.IntermediaryAgent2"/>
    [IsoId("_eeABl7pXEfCPZvweyV2nEg")]
    [DisplayName("Intermediary Agent2")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.IntermediaryAgent2Account"/>
    [IsoId("_eeABmbpXEfCPZvweyV2nEg")]
    [DisplayName("Intermediary Agent2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount40? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.IntermediaryAgent3"/>
    [IsoId("_eeABm7pXEfCPZvweyV2nEg")]
    [DisplayName("Intermediary Agent3")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification8? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.IntermediaryAgent3Account"/>
    [IsoId("_eeABnbpXEfCPZvweyV2nEg")]
    [DisplayName("Intermediary Agent3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount40? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.UltimateDebtor"/>
    [IsoId("_eeABn7pXEfCPZvweyV2nEg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public BranchAndFinancialInstitutionIdentification8? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.Debtor"/>
    [IsoId("_eeABobpXEfCPZvweyV2nEg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required BranchAndFinancialInstitutionIdentification8 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.DebtorAccount"/>
    [IsoId("_eeABo7pXEfCPZvweyV2nEg")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.DebtorAgent"/>
    [IsoId("_eeABpbpXEfCPZvweyV2nEg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.DebtorAgentAccount"/>
    [IsoId("_eeABp7pXEfCPZvweyV2nEg")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.CreditorAgent"/>
    [IsoId("_eeABqbpXEfCPZvweyV2nEg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.CreditorAgentAccount"/>
    [IsoId("_eeABq7pXEfCPZvweyV2nEg")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.Creditor"/>
    [IsoId("_eeABrbpXEfCPZvweyV2nEg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required BranchAndFinancialInstitutionIdentification8 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.CreditorAccount"/>
    [IsoId("_eeABr7pXEfCPZvweyV2nEg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.UltimateCreditor"/>
    [IsoId("_eeABsbpXEfCPZvweyV2nEg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public BranchAndFinancialInstitutionIdentification8? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.InstructionForCreditorAgent"/>
    [IsoId("_eeABs7pXEfCPZvweyV2nEg")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent3> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction82.InstructionForNextAgent"/>
    [IsoId("_eeABtbpXEfCPZvweyV2nEg")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction82.Purpose"/>
    [IsoId("_eeABt7pXEfCPZvweyV2nEg")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.RemittanceInformation"/>
    [IsoId("_eeABubpXEfCPZvweyV2nEg")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation2? RemittanceInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction82.UnderlyingAllocation"/>
    [IsoId("_eeABu7pXEfCPZvweyV2nEg")]
    [DisplayName("Underlying Allocation")]
    [IsoXmlTag("UndrlygAllcn")]
    public ValueList<TransactionAllocation2> UnderlyingAllocation { get; init; } = [];
}
