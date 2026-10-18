// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction23 : ICreditTransferTransaction23
{
    IPaymentIdentification3 ICreditTransferTransaction23.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation21? ICreditTransferTransaction23.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransaction23.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? ICreditTransferTransaction23.SettlementTimeRequest => SettlementTimeRequest;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction23.PreviousInstructingAgent => PreviousInstructingAgent;
    ICashAccount24? ICreditTransferTransaction23.PreviousInstructingAgentAccount => PreviousInstructingAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction23.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction23.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction23.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount24? ICreditTransferTransaction23.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction23.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount24? ICreditTransferTransaction23.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction23.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount24? ICreditTransferTransaction23.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction23.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction23.Debtor => Debtor;
    ICashAccount24? ICreditTransferTransaction23.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction23.DebtorAgent => DebtorAgent;
    ICashAccount24? ICreditTransferTransaction23.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction23.CreditorAgent => CreditorAgent;
    ICashAccount24? ICreditTransferTransaction23.CreditorAgentAccount => CreditorAgentAccount;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction23.Creditor => Creditor;
    ICashAccount24? ICreditTransferTransaction23.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction23.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent2> ICreditTransferTransaction23.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction23.InstructionForNextAgent => InstructionForNextAgent;
    IRemittanceInformation2? ICreditTransferTransaction23.RemittanceInformation => RemittanceInformation;
    ICreditTransferTransaction24? ICreditTransferTransaction23.UnderlyingCustomerCreditTransfer => UnderlyingCustomerCreditTransfer;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction23.SupplementaryData => SupplementaryData;
}
