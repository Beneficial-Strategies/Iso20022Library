// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction67 : ICreditTransferTransaction67
{
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction67.Creditor => Creditor;
    ICashAccount40? ICreditTransferTransaction67.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction67.CreditorAgent => CreditorAgent;
    ICashAccount40? ICreditTransferTransaction67.CreditorAgentAccount => CreditorAgentAccount;
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction67.Debtor => Debtor;
    ICashAccount40? ICreditTransferTransaction67.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction67.DebtorAgent => DebtorAgent;
    ICashAccount40? ICreditTransferTransaction67.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction67.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction67.InstructingAgent => InstructingAgent;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction67.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction67.InstructionForNextAgent => InstructionForNextAgent;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction67.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount40? ICreditTransferTransaction67.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction67.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount40? ICreditTransferTransaction67.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction67.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount40? ICreditTransferTransaction67.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IPaymentIdentification13 ICreditTransferTransaction67.PaymentIdentification => PaymentIdentification;
    ICryptographicKey1Choice? ICreditTransferTransaction67.PaymentSignature => PaymentSignature;
    IPaymentTypeInformation28? ICreditTransferTransaction67.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction67.PreviousInstructingAgent1 => PreviousInstructingAgent1;
    ICashAccount40? ICreditTransferTransaction67.PreviousInstructingAgent1Account => PreviousInstructingAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction67.PreviousInstructingAgent2 => PreviousInstructingAgent2;
    ICashAccount40? ICreditTransferTransaction67.PreviousInstructingAgent2Account => PreviousInstructingAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction67.PreviousInstructingAgent3 => PreviousInstructingAgent3;
    ICashAccount40? ICreditTransferTransaction67.PreviousInstructingAgent3Account => PreviousInstructingAgent3Account;
    IPurpose2Choice? ICreditTransferTransaction67.Purpose => Purpose;
    IRemittanceInformation2? ICreditTransferTransaction67.RemittanceInformation => RemittanceInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransaction67.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? ICreditTransferTransaction67.SettlementTimeRequest => SettlementTimeRequest;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction67.SupplementaryData => SupplementaryData;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction67.UltimateCreditor => UltimateCreditor;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction67.UltimateDebtor => UltimateDebtor;
    IEnumerable<ITransactionAllocation1> ICreditTransferTransaction67.UnderlyingAllocation => UnderlyingAllocation;
    ICreditTransferTransaction68? ICreditTransferTransaction67.UnderlyingCustomerCreditTransfer => UnderlyingCustomerCreditTransfer;
    ICreditTransferTransaction69? ICreditTransferTransaction67.UnderlyingFinancialInstitutionCreditTransfer => UnderlyingFinancialInstitutionCreditTransfer;
}
