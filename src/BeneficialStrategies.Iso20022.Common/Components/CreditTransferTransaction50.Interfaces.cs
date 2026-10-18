// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction50 : ICreditTransferTransaction50
{
    IPaymentIdentification13 ICreditTransferTransaction50.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation28? ICreditTransferTransaction50.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransaction50.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? ICreditTransferTransaction50.SettlementTimeRequest => SettlementTimeRequest;
    IEnumerable<ICharges7> ICreditTransferTransaction50.ChargesInformation => ChargesInformation;
    ICreditTransferMandateData1? ICreditTransferTransaction50.MandateRelatedInformation => MandateRelatedInformation;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction50.PreviousInstructingAgent1 => PreviousInstructingAgent1;
    ICashAccount40? ICreditTransferTransaction50.PreviousInstructingAgent1Account => PreviousInstructingAgent1Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction50.PreviousInstructingAgent2 => PreviousInstructingAgent2;
    ICashAccount40? ICreditTransferTransaction50.PreviousInstructingAgent2Account => PreviousInstructingAgent2Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction50.PreviousInstructingAgent3 => PreviousInstructingAgent3;
    ICashAccount40? ICreditTransferTransaction50.PreviousInstructingAgent3Account => PreviousInstructingAgent3Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction50.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction50.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction50.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount40? ICreditTransferTransaction50.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction50.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount40? ICreditTransferTransaction50.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction50.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount40? ICreditTransferTransaction50.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IPartyIdentification135? ICreditTransferTransaction50.UltimateDebtor => UltimateDebtor;
    IPartyIdentification135? ICreditTransferTransaction50.InitiatingParty => InitiatingParty;
    IPartyIdentification135 ICreditTransferTransaction50.Debtor => Debtor;
    ICashAccount40? ICreditTransferTransaction50.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6 ICreditTransferTransaction50.DebtorAgent => DebtorAgent;
    ICashAccount40? ICreditTransferTransaction50.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification6 ICreditTransferTransaction50.CreditorAgent => CreditorAgent;
    ICashAccount40? ICreditTransferTransaction50.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification135 ICreditTransferTransaction50.Creditor => Creditor;
    ICashAccount40? ICreditTransferTransaction50.CreditorAccount => CreditorAccount;
    IPartyIdentification135? ICreditTransferTransaction50.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction50.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction50.InstructionForNextAgent => InstructionForNextAgent;
    IPurpose2Choice? ICreditTransferTransaction50.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransaction50.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation10? ICreditTransferTransaction50.Tax => Tax;
    IEnumerable<IRemittanceLocation7> ICreditTransferTransaction50.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation21? ICreditTransferTransaction50.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction50.SupplementaryData => SupplementaryData;
}
