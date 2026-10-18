// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction45 : ICreditTransferTransaction45
{
    IPartyIdentification135? ICreditTransferTransaction45.UltimateDebtor => UltimateDebtor;
    IPartyIdentification135? ICreditTransferTransaction45.InitiatingParty => InitiatingParty;
    IPartyIdentification135 ICreditTransferTransaction45.Debtor => Debtor;
    ICashAccount38? ICreditTransferTransaction45.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6 ICreditTransferTransaction45.DebtorAgent => DebtorAgent;
    ICashAccount38? ICreditTransferTransaction45.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction45.PreviousInstructingAgent1 => PreviousInstructingAgent1;
    ICashAccount38? ICreditTransferTransaction45.PreviousInstructingAgent1Account => PreviousInstructingAgent1Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction45.PreviousInstructingAgent2 => PreviousInstructingAgent2;
    ICashAccount38? ICreditTransferTransaction45.PreviousInstructingAgent2Account => PreviousInstructingAgent2Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction45.PreviousInstructingAgent3 => PreviousInstructingAgent3;
    ICashAccount38? ICreditTransferTransaction45.PreviousInstructingAgent3Account => PreviousInstructingAgent3Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction45.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount38? ICreditTransferTransaction45.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction45.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount38? ICreditTransferTransaction45.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction45.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount38? ICreditTransferTransaction45.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification6 ICreditTransferTransaction45.CreditorAgent => CreditorAgent;
    ICashAccount38? ICreditTransferTransaction45.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification135 ICreditTransferTransaction45.Creditor => Creditor;
    ICashAccount38? ICreditTransferTransaction45.CreditorAccount => CreditorAccount;
    IPartyIdentification135? ICreditTransferTransaction45.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction45.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction45.InstructionForNextAgent => InstructionForNextAgent;
    ITaxInformation8? ICreditTransferTransaction45.Tax => Tax;
    IRemittanceInformation16? ICreditTransferTransaction45.RemittanceInformation => RemittanceInformation;
}
