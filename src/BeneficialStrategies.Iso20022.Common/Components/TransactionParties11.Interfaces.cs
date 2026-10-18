// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record TransactionParties11 : ITransactionParties11
{
    IParty50Choice ITransactionParties11.Creditor => Creditor;
    ICashAccount40? ITransactionParties11.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8? ITransactionParties11.CreditorAgent => CreditorAgent;
    ICashAccount40? ITransactionParties11.CreditorAgentAccount => CreditorAgentAccount;
    IParty50Choice ITransactionParties11.Debtor => Debtor;
    ICashAccount40? ITransactionParties11.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8? ITransactionParties11.DebtorAgent => DebtorAgent;
    ICashAccount40? ITransactionParties11.DebtorAgentAccount => DebtorAgentAccount;
    IParty50Choice? ITransactionParties11.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification8? ITransactionParties11.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount40? ITransactionParties11.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ITransactionParties11.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount40? ITransactionParties11.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ITransactionParties11.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount40? ITransactionParties11.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification8? ITransactionParties11.PreviousInstructingAgent1 => PreviousInstructingAgent1;
    ICashAccount40? ITransactionParties11.PreviousInstructingAgent1Account => PreviousInstructingAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ITransactionParties11.PreviousInstructingAgent2 => PreviousInstructingAgent2;
    ICashAccount40? ITransactionParties11.PreviousInstructingAgent2Account => PreviousInstructingAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ITransactionParties11.PreviousInstructingAgent3 => PreviousInstructingAgent3;
    ICashAccount40? ITransactionParties11.PreviousInstructingAgent3Account => PreviousInstructingAgent3Account;
    IParty50Choice? ITransactionParties11.UltimateCreditor => UltimateCreditor;
    IParty50Choice? ITransactionParties11.UltimateDebtor => UltimateDebtor;
}
