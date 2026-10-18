// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction8 : ICreditTransferTransaction8
{
    IPaymentIdentification3 ICreditTransferTransaction8.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation21? ICreditTransferTransaction8.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransaction8.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? ICreditTransferTransaction8.SettlementTimeRequest => SettlementTimeRequest;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction8.PreviousInstructingAgent => PreviousInstructingAgent;
    ICashAccount24? ICreditTransferTransaction8.PreviousInstructingAgentAccount => PreviousInstructingAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction8.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction8.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction8.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount24? ICreditTransferTransaction8.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction8.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount24? ICreditTransferTransaction8.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction8.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount24? ICreditTransferTransaction8.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction8.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction8.Debtor => Debtor;
    ICashAccount24? ICreditTransferTransaction8.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction8.DebtorAgent => DebtorAgent;
    ICashAccount24? ICreditTransferTransaction8.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction8.CreditorAgent => CreditorAgent;
    ICashAccount24? ICreditTransferTransaction8.CreditorAgentAccount => CreditorAgentAccount;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction8.Creditor => Creditor;
    ICashAccount24? ICreditTransferTransaction8.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction8.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent2> ICreditTransferTransaction8.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction8.InstructionForNextAgent => InstructionForNextAgent;
    IRemittanceInformation2? ICreditTransferTransaction8.RemittanceInformation => RemittanceInformation;
    ICreditTransferTransaction3? ICreditTransferTransaction8.UnderlyingCustomerCreditTransfer => UnderlyingCustomerCreditTransfer;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction8.SupplementaryData => SupplementaryData;
}
