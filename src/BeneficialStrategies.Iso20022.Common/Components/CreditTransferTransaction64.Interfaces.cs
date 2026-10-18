// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction64 : ICreditTransferTransaction64
{
    IEnumerable<ICharges16> ICreditTransferTransaction64.ChargesInformation => ChargesInformation;
    IPartyIdentification272 ICreditTransferTransaction64.Creditor => Creditor;
    ICashAccount40? ICreditTransferTransaction64.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction64.CreditorAgent => CreditorAgent;
    ICashAccount40? ICreditTransferTransaction64.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification272 ICreditTransferTransaction64.Debtor => Debtor;
    ICashAccount40? ICreditTransferTransaction64.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction64.DebtorAgent => DebtorAgent;
    ICashAccount40? ICreditTransferTransaction64.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification272? ICreditTransferTransaction64.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction64.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction64.InstructingAgent => InstructingAgent;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction64.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction64.InstructionForNextAgent => InstructionForNextAgent;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction64.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount40? ICreditTransferTransaction64.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction64.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount40? ICreditTransferTransaction64.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction64.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount40? ICreditTransferTransaction64.IntermediaryAgent3Account => IntermediaryAgent3Account;
    ICreditTransferMandateData1? ICreditTransferTransaction64.MandateRelatedInformation => MandateRelatedInformation;
    IPaymentIdentification13 ICreditTransferTransaction64.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation28? ICreditTransferTransaction64.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction64.PreviousInstructingAgent1 => PreviousInstructingAgent1;
    ICashAccount40? ICreditTransferTransaction64.PreviousInstructingAgent1Account => PreviousInstructingAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction64.PreviousInstructingAgent2 => PreviousInstructingAgent2;
    ICashAccount40? ICreditTransferTransaction64.PreviousInstructingAgent2Account => PreviousInstructingAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction64.PreviousInstructingAgent3 => PreviousInstructingAgent3;
    ICashAccount40? ICreditTransferTransaction64.PreviousInstructingAgent3Account => PreviousInstructingAgent3Account;
    IPurpose2Choice? ICreditTransferTransaction64.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransaction64.RegulatoryReporting => RegulatoryReporting;
    IEnumerable<IRemittanceLocation8> ICreditTransferTransaction64.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation22? ICreditTransferTransaction64.RemittanceInformation => RemittanceInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransaction64.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? ICreditTransferTransaction64.SettlementTimeRequest => SettlementTimeRequest;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction64.SupplementaryData => SupplementaryData;
    ITaxData1? ICreditTransferTransaction64.Tax => Tax;
    IPartyIdentification272? ICreditTransferTransaction64.UltimateCreditor => UltimateCreditor;
    IPartyIdentification272? ICreditTransferTransaction64.UltimateDebtor => UltimateDebtor;
}
