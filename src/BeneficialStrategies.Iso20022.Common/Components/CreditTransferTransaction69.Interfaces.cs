// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction69 : ICreditTransferTransaction69
{
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction69.Creditor => Creditor;
    ICashAccount40? ICreditTransferTransaction69.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction69.CreditorAgent => CreditorAgent;
    ICashAccount40? ICreditTransferTransaction69.CreditorAgentAccount => CreditorAgentAccount;
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction69.Debtor => Debtor;
    ICashAccount40? ICreditTransferTransaction69.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction69.DebtorAgent => DebtorAgent;
    ICashAccount40? ICreditTransferTransaction69.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction69.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction69.InstructingAgent => InstructingAgent;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction69.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction69.InstructionForNextAgent => InstructionForNextAgent;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction69.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount40? ICreditTransferTransaction69.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction69.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount40? ICreditTransferTransaction69.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction69.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount40? ICreditTransferTransaction69.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IPaymentIdentification13 ICreditTransferTransaction69.PaymentIdentification => PaymentIdentification;
    ICryptographicKey1Choice? ICreditTransferTransaction69.PaymentSignature => PaymentSignature;
    IPaymentTypeInformation28? ICreditTransferTransaction69.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction69.PreviousInstructingAgent1 => PreviousInstructingAgent1;
    ICashAccount40? ICreditTransferTransaction69.PreviousInstructingAgent1Account => PreviousInstructingAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction69.PreviousInstructingAgent2 => PreviousInstructingAgent2;
    ICashAccount40? ICreditTransferTransaction69.PreviousInstructingAgent2Account => PreviousInstructingAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction69.PreviousInstructingAgent3 => PreviousInstructingAgent3;
    ICashAccount40? ICreditTransferTransaction69.PreviousInstructingAgent3Account => PreviousInstructingAgent3Account;
    IPurpose2Choice? ICreditTransferTransaction69.Purpose => Purpose;
    IRemittanceInformation2? ICreditTransferTransaction69.RemittanceInformation => RemittanceInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransaction69.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? ICreditTransferTransaction69.SettlementTimeRequest => SettlementTimeRequest;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction69.UltimateCreditor => UltimateCreditor;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction69.UltimateDebtor => UltimateDebtor;
    IEnumerable<ITransactionAllocation1> ICreditTransferTransaction69.UnderlyingAllocation => UnderlyingAllocation;
}
