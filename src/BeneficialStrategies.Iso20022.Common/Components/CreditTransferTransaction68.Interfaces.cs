// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction68 : ICreditTransferTransaction68
{
    IPartyIdentification272 ICreditTransferTransaction68.Creditor => Creditor;
    ICashAccount40? ICreditTransferTransaction68.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction68.CreditorAgent => CreditorAgent;
    ICashAccount40? ICreditTransferTransaction68.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification272 ICreditTransferTransaction68.Debtor => Debtor;
    ICashAccount40? ICreditTransferTransaction68.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction68.DebtorAgent => DebtorAgent;
    ICashAccount40? ICreditTransferTransaction68.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification272? ICreditTransferTransaction68.InitiatingParty => InitiatingParty;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction68.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction68.InstructionForNextAgent => InstructionForNextAgent;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction68.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount40? ICreditTransferTransaction68.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction68.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount40? ICreditTransferTransaction68.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction68.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount40? ICreditTransferTransaction68.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IPaymentIdentification13? ICreditTransferTransaction68.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation28? ICreditTransferTransaction68.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction68.PreviousInstructingAgent1 => PreviousInstructingAgent1;
    ICashAccount40? ICreditTransferTransaction68.PreviousInstructingAgent1Account => PreviousInstructingAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction68.PreviousInstructingAgent2 => PreviousInstructingAgent2;
    ICashAccount40? ICreditTransferTransaction68.PreviousInstructingAgent2Account => PreviousInstructingAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction68.PreviousInstructingAgent3 => PreviousInstructingAgent3;
    ICashAccount40? ICreditTransferTransaction68.PreviousInstructingAgent3Account => PreviousInstructingAgent3Account;
    IPurpose2Choice? ICreditTransferTransaction68.Purpose => Purpose;
    IRemittanceInformation22? ICreditTransferTransaction68.RemittanceInformation => RemittanceInformation;
    ITaxData1? ICreditTransferTransaction68.Tax => Tax;
    IPartyIdentification272? ICreditTransferTransaction68.UltimateCreditor => UltimateCreditor;
    IPartyIdentification272? ICreditTransferTransaction68.UltimateDebtor => UltimateDebtor;
}
