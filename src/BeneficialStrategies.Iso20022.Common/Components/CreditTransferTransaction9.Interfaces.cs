// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction9 : ICreditTransferTransaction9
{
    IPaymentTypeInformation21? ICreditTransferTransaction9.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction9.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction9.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction9.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount24? ICreditTransferTransaction9.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction9.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount24? ICreditTransferTransaction9.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction9.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount24? ICreditTransferTransaction9.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction9.CreditorAgent => CreditorAgent;
    ICashAccount24? ICreditTransferTransaction9.CreditorAgentAccount => CreditorAgentAccount;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction9.Creditor => Creditor;
    ICashAccount24? ICreditTransferTransaction9.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction9.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent2> ICreditTransferTransaction9.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IDirectDebitTransactionInformation15> ICreditTransferTransaction9.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction9.SupplementaryData => SupplementaryData;
}
