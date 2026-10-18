// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction63 : ICreditTransferTransaction63
{
    IPartyIdentification272 ICreditTransferTransaction63.Creditor => Creditor;
    ICashAccount40? ICreditTransferTransaction63.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction63.CreditorAgent => CreditorAgent;
    ICashAccount40? ICreditTransferTransaction63.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification272 ICreditTransferTransaction63.Debtor => Debtor;
    ICashAccount40? ICreditTransferTransaction63.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction63.DebtorAgent => DebtorAgent;
    ICashAccount40? ICreditTransferTransaction63.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification272? ICreditTransferTransaction63.InitiatingParty => InitiatingParty;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction63.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction63.InstructionForNextAgent => InstructionForNextAgent;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction63.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount40? ICreditTransferTransaction63.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction63.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount40? ICreditTransferTransaction63.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction63.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount40? ICreditTransferTransaction63.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction63.PreviousInstructingAgent1 => PreviousInstructingAgent1;
    ICashAccount40? ICreditTransferTransaction63.PreviousInstructingAgent1Account => PreviousInstructingAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction63.PreviousInstructingAgent2 => PreviousInstructingAgent2;
    ICashAccount40? ICreditTransferTransaction63.PreviousInstructingAgent2Account => PreviousInstructingAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction63.PreviousInstructingAgent3 => PreviousInstructingAgent3;
    ICashAccount40? ICreditTransferTransaction63.PreviousInstructingAgent3Account => PreviousInstructingAgent3Account;
    IRemittanceInformation22? ICreditTransferTransaction63.RemittanceInformation => RemittanceInformation;
    ITaxData1? ICreditTransferTransaction63.Tax => Tax;
    IPartyIdentification272? ICreditTransferTransaction63.UltimateCreditor => UltimateCreditor;
    IPartyIdentification272? ICreditTransferTransaction63.UltimateDebtor => UltimateDebtor;
}
