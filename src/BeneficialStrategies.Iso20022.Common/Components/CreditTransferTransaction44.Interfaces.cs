// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction44 : ICreditTransferTransaction44
{
    IPaymentIdentification13 ICreditTransferTransaction44.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation28? ICreditTransferTransaction44.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransaction44.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? ICreditTransferTransaction44.SettlementTimeRequest => SettlementTimeRequest;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction44.PreviousInstructingAgent1 => PreviousInstructingAgent1;
    ICashAccount38? ICreditTransferTransaction44.PreviousInstructingAgent1Account => PreviousInstructingAgent1Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction44.PreviousInstructingAgent2 => PreviousInstructingAgent2;
    ICashAccount38? ICreditTransferTransaction44.PreviousInstructingAgent2Account => PreviousInstructingAgent2Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction44.PreviousInstructingAgent3 => PreviousInstructingAgent3;
    ICashAccount38? ICreditTransferTransaction44.PreviousInstructingAgent3Account => PreviousInstructingAgent3Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction44.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction44.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction44.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount38? ICreditTransferTransaction44.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction44.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount38? ICreditTransferTransaction44.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction44.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount38? ICreditTransferTransaction44.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction44.UltimateDebtor => UltimateDebtor;
    IBranchAndFinancialInstitutionIdentification6 ICreditTransferTransaction44.Debtor => Debtor;
    ICashAccount38? ICreditTransferTransaction44.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction44.DebtorAgent => DebtorAgent;
    ICashAccount38? ICreditTransferTransaction44.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction44.CreditorAgent => CreditorAgent;
    ICashAccount38? ICreditTransferTransaction44.CreditorAgentAccount => CreditorAgentAccount;
    IBranchAndFinancialInstitutionIdentification6 ICreditTransferTransaction44.Creditor => Creditor;
    ICashAccount38? ICreditTransferTransaction44.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction44.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction44.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction44.InstructionForNextAgent => InstructionForNextAgent;
    IPurpose2Choice? ICreditTransferTransaction44.Purpose => Purpose;
    IRemittanceInformation2? ICreditTransferTransaction44.RemittanceInformation => RemittanceInformation;
    ICreditTransferTransaction45? ICreditTransferTransaction44.UnderlyingCustomerCreditTransfer => UnderlyingCustomerCreditTransfer;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction44.SupplementaryData => SupplementaryData;
}
