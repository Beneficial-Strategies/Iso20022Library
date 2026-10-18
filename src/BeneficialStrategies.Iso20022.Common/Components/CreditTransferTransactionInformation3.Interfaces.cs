// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransactionInformation3 : ICreditTransferTransactionInformation3
{
    IPaymentIdentification2 ICreditTransferTransactionInformation3.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation5? ICreditTransferTransactionInformation3.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransactionInformation3.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest1? ICreditTransferTransactionInformation3.SettlementTimeRequest => SettlementTimeRequest;
    IBranchAndFinancialInstitutionIdentification3? ICreditTransferTransactionInformation3.PreviousInstructingAgent => PreviousInstructingAgent;
    ICashAccount7? ICreditTransferTransactionInformation3.PreviousInstructingAgentAccount => PreviousInstructingAgentAccount;
    IBranchAndFinancialInstitutionIdentification3? ICreditTransferTransactionInformation3.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification3? ICreditTransferTransactionInformation3.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification3? ICreditTransferTransactionInformation3.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount7? ICreditTransferTransactionInformation3.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification3? ICreditTransferTransactionInformation3.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount7? ICreditTransferTransactionInformation3.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification3? ICreditTransferTransactionInformation3.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount7? ICreditTransferTransactionInformation3.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification3? ICreditTransferTransactionInformation3.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification3 ICreditTransferTransactionInformation3.Debtor => Debtor;
    ICashAccount7? ICreditTransferTransactionInformation3.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification3? ICreditTransferTransactionInformation3.DebtorAgent => DebtorAgent;
    ICashAccount7? ICreditTransferTransactionInformation3.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification3? ICreditTransferTransactionInformation3.CreditorAgent => CreditorAgent;
    ICashAccount7? ICreditTransferTransactionInformation3.CreditorAgentAccount => CreditorAgentAccount;
    IBranchAndFinancialInstitutionIdentification3 ICreditTransferTransactionInformation3.Creditor => Creditor;
    ICashAccount7? ICreditTransferTransactionInformation3.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification3? ICreditTransferTransactionInformation3.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent2> ICreditTransferTransactionInformation3.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransactionInformation3.InstructionForNextAgent => InstructionForNextAgent;
    IRemittanceInformation2? ICreditTransferTransactionInformation3.RemittanceInformation => RemittanceInformation;
}
