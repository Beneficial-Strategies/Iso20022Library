// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction4 : ICreditTransferTransaction4
{
    IPaymentIdentification3 ICreditTransferTransaction4.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation21? ICreditTransferTransaction4.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransaction4.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? ICreditTransferTransaction4.SettlementTimeRequest => SettlementTimeRequest;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction4.PreviousInstructingAgent => PreviousInstructingAgent;
    ICashAccount24? ICreditTransferTransaction4.PreviousInstructingAgentAccount => PreviousInstructingAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction4.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction4.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction4.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount24? ICreditTransferTransaction4.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction4.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount24? ICreditTransferTransaction4.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction4.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount24? ICreditTransferTransaction4.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction4.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction4.Debtor => Debtor;
    ICashAccount24? ICreditTransferTransaction4.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction4.DebtorAgent => DebtorAgent;
    ICashAccount24? ICreditTransferTransaction4.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction4.CreditorAgent => CreditorAgent;
    ICashAccount24? ICreditTransferTransaction4.CreditorAgentAccount => CreditorAgentAccount;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction4.Creditor => Creditor;
    ICashAccount24? ICreditTransferTransaction4.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction4.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent2> ICreditTransferTransaction4.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction4.InstructionForNextAgent => InstructionForNextAgent;
    IRemittanceInformation2? ICreditTransferTransaction4.RemittanceInformation => RemittanceInformation;
    ICreditTransferTransaction3? ICreditTransferTransaction4.UnderlyingCustomerCreditTransfer => UnderlyingCustomerCreditTransfer;
}
