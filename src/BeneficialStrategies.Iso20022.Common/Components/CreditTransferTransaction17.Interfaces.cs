// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction17 : ICreditTransferTransaction17
{
    IPaymentIdentification3 ICreditTransferTransaction17.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation21? ICreditTransferTransaction17.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransaction17.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? ICreditTransferTransaction17.SettlementTimeRequest => SettlementTimeRequest;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction17.PreviousInstructingAgent => PreviousInstructingAgent;
    ICashAccount24? ICreditTransferTransaction17.PreviousInstructingAgentAccount => PreviousInstructingAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction17.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction17.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction17.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount24? ICreditTransferTransaction17.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction17.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount24? ICreditTransferTransaction17.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction17.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount24? ICreditTransferTransaction17.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction17.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction17.Debtor => Debtor;
    ICashAccount24? ICreditTransferTransaction17.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction17.DebtorAgent => DebtorAgent;
    ICashAccount24? ICreditTransferTransaction17.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction17.CreditorAgent => CreditorAgent;
    ICashAccount24? ICreditTransferTransaction17.CreditorAgentAccount => CreditorAgentAccount;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction17.Creditor => Creditor;
    ICashAccount24? ICreditTransferTransaction17.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction17.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent2> ICreditTransferTransaction17.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction17.InstructionForNextAgent => InstructionForNextAgent;
    IRemittanceInformation2? ICreditTransferTransaction17.RemittanceInformation => RemittanceInformation;
    ICreditTransferTransaction18? ICreditTransferTransaction17.UnderlyingCustomerCreditTransfer => UnderlyingCustomerCreditTransfer;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction17.SupplementaryData => SupplementaryData;
}
