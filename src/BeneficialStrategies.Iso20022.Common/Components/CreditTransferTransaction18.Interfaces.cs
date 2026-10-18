// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction18 : ICreditTransferTransaction18
{
    IPartyIdentification43? ICreditTransferTransaction18.UltimateDebtor => UltimateDebtor;
    IPartyIdentification43? ICreditTransferTransaction18.InitiatingParty => InitiatingParty;
    IPartyIdentification43 ICreditTransferTransaction18.Debtor => Debtor;
    ICashAccount24? ICreditTransferTransaction18.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction18.DebtorAgent => DebtorAgent;
    ICashAccount24? ICreditTransferTransaction18.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction18.PreviousInstructingAgent => PreviousInstructingAgent;
    ICashAccount24? ICreditTransferTransaction18.PreviousInstructingAgentAccount => PreviousInstructingAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction18.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount24? ICreditTransferTransaction18.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction18.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount24? ICreditTransferTransaction18.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction18.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount24? ICreditTransferTransaction18.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction18.CreditorAgent => CreditorAgent;
    ICashAccount24? ICreditTransferTransaction18.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification43 ICreditTransferTransaction18.Creditor => Creditor;
    ICashAccount24? ICreditTransferTransaction18.CreditorAccount => CreditorAccount;
    IPartyIdentification43? ICreditTransferTransaction18.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent1> ICreditTransferTransaction18.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction18.InstructionForNextAgent => InstructionForNextAgent;
    ITaxInformation3? ICreditTransferTransaction18.Tax => Tax;
    IRemittanceInformation10? ICreditTransferTransaction18.RemittanceInformation => RemittanceInformation;
}
