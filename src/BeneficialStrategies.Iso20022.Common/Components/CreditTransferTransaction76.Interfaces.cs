// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction76 : ICreditTransferTransaction76
{
    IPaymentIdentification6 ICreditTransferTransaction76.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation28? ICreditTransferTransaction76.PaymentTypeInformation => PaymentTypeInformation;
    IAmountType4Choice ICreditTransferTransaction76.Amount => Amount;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction76.PreviousInstructingAgent1 => PreviousInstructingAgent1;
    ICashAccount40? ICreditTransferTransaction76.PreviousInstructingAgent1Account => PreviousInstructingAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction76.PreviousInstructingAgent2 => PreviousInstructingAgent2;
    ICashAccount40? ICreditTransferTransaction76.PreviousInstructingAgent2Account => PreviousInstructingAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction76.PreviousInstructingAgent3 => PreviousInstructingAgent3;
    ICashAccount40? ICreditTransferTransaction76.PreviousInstructingAgent3Account => PreviousInstructingAgent3Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction76.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount40? ICreditTransferTransaction76.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction76.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount40? ICreditTransferTransaction76.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction76.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount40? ICreditTransferTransaction76.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction76.CreditorAgent => CreditorAgent;
    ICashAccount40? ICreditTransferTransaction76.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification272? ICreditTransferTransaction76.Creditor => Creditor;
    ICashAccount40? ICreditTransferTransaction76.CreditorAccount => CreditorAccount;
    IPartyIdentification272? ICreditTransferTransaction76.UltimateCreditor => UltimateCreditor;
    IInstructionForDebtorAgent1? ICreditTransferTransaction76.InstructionForDebtorAgent => InstructionForDebtorAgent;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction76.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IRegulatoryReporting10> ICreditTransferTransaction76.RegulatoryReporting => RegulatoryReporting;
    IEnumerable<IRemittanceLocation8> ICreditTransferTransaction76.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation22? ICreditTransferTransaction76.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction76.SupplementaryData => SupplementaryData;
}
