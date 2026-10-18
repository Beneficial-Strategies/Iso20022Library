// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction62 : ICreditTransferTransaction62
{
    IPaymentIdentification13 ICreditTransferTransaction62.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation28? ICreditTransferTransaction62.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransaction62.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? ICreditTransferTransaction62.SettlementTimeRequest => SettlementTimeRequest;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction62.PreviousInstructingAgent1 => PreviousInstructingAgent1;
    ICashAccount40? ICreditTransferTransaction62.PreviousInstructingAgent1Account => PreviousInstructingAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction62.PreviousInstructingAgent2 => PreviousInstructingAgent2;
    ICashAccount40? ICreditTransferTransaction62.PreviousInstructingAgent2Account => PreviousInstructingAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction62.PreviousInstructingAgent3 => PreviousInstructingAgent3;
    ICashAccount40? ICreditTransferTransaction62.PreviousInstructingAgent3Account => PreviousInstructingAgent3Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction62.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction62.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction62.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount40? ICreditTransferTransaction62.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction62.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount40? ICreditTransferTransaction62.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction62.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount40? ICreditTransferTransaction62.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction62.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction62.Debtor => Debtor;
    ICashAccount40? ICreditTransferTransaction62.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction62.DebtorAgent => DebtorAgent;
    ICashAccount40? ICreditTransferTransaction62.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction62.CreditorAgent => CreditorAgent;
    ICashAccount40? ICreditTransferTransaction62.CreditorAgentAccount => CreditorAgentAccount;
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction62.Creditor => Creditor;
    ICashAccount40? ICreditTransferTransaction62.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction62.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction62.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction62.InstructionForNextAgent => InstructionForNextAgent;
    IPurpose2Choice? ICreditTransferTransaction62.Purpose => Purpose;
    IRemittanceInformation2? ICreditTransferTransaction62.RemittanceInformation => RemittanceInformation;
    IEnumerable<ITransactionAllocation1> ICreditTransferTransaction62.UnderlyingAllocation => UnderlyingAllocation;
    ICreditTransferTransaction63? ICreditTransferTransaction62.UnderlyingCustomerCreditTransfer => UnderlyingCustomerCreditTransfer;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction62.SupplementaryData => SupplementaryData;
}
