// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction74 : ICreditTransferTransaction74
{
    IPaymentIdentification6 ICreditTransferTransaction74.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation28? ICreditTransferTransaction74.PaymentTypeInformation => PaymentTypeInformation;
    IAmountType4Choice ICreditTransferTransaction74.Amount => Amount;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction74.PreviousInstructingAgent1 => PreviousInstructingAgent1;
    ICashAccount40? ICreditTransferTransaction74.PreviousInstructingAgent1Account => PreviousInstructingAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction74.PreviousInstructingAgent2 => PreviousInstructingAgent2;
    ICashAccount40? ICreditTransferTransaction74.PreviousInstructingAgent2Account => PreviousInstructingAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction74.PreviousInstructingAgent3 => PreviousInstructingAgent3;
    ICashAccount40? ICreditTransferTransaction74.PreviousInstructingAgent3Account => PreviousInstructingAgent3Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction74.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount40? ICreditTransferTransaction74.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction74.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount40? ICreditTransferTransaction74.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction74.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount40? ICreditTransferTransaction74.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction74.CreditorAgent => CreditorAgent;
    ICashAccount40? ICreditTransferTransaction74.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification272 ICreditTransferTransaction74.Creditor => Creditor;
    ICashAccount40? ICreditTransferTransaction74.CreditorAccount => CreditorAccount;
    IPartyIdentification272? ICreditTransferTransaction74.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction74.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IRegulatoryReporting10> ICreditTransferTransaction74.RegulatoryReporting => RegulatoryReporting;
    IEnumerable<IRemittanceLocation8> ICreditTransferTransaction74.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IEnumerable<IDocument15> ICreditTransferTransaction74.EnclosedFile => EnclosedFile;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction74.SupplementaryData => SupplementaryData;
}
