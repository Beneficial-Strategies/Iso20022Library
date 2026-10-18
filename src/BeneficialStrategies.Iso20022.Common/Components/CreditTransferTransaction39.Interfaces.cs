// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction39 : ICreditTransferTransaction39
{
    IPaymentIdentification7 ICreditTransferTransaction39.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation28? ICreditTransferTransaction39.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransaction39.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? ICreditTransferTransaction39.SettlementTimeRequest => SettlementTimeRequest;
    IEnumerable<ICharges7> ICreditTransferTransaction39.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction39.PreviousInstructingAgent1 => PreviousInstructingAgent1;
    ICashAccount38? ICreditTransferTransaction39.PreviousInstructingAgent1Account => PreviousInstructingAgent1Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction39.PreviousInstructingAgent2 => PreviousInstructingAgent2;
    ICashAccount38? ICreditTransferTransaction39.PreviousInstructingAgent2Account => PreviousInstructingAgent2Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction39.PreviousInstructingAgent3 => PreviousInstructingAgent3;
    ICashAccount38? ICreditTransferTransaction39.PreviousInstructingAgent3Account => PreviousInstructingAgent3Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction39.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction39.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction39.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount38? ICreditTransferTransaction39.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction39.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount38? ICreditTransferTransaction39.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction39.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount38? ICreditTransferTransaction39.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IPartyIdentification135? ICreditTransferTransaction39.UltimateDebtor => UltimateDebtor;
    IPartyIdentification135? ICreditTransferTransaction39.InitiatingParty => InitiatingParty;
    IPartyIdentification135 ICreditTransferTransaction39.Debtor => Debtor;
    ICashAccount38? ICreditTransferTransaction39.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6 ICreditTransferTransaction39.DebtorAgent => DebtorAgent;
    ICashAccount38? ICreditTransferTransaction39.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification6 ICreditTransferTransaction39.CreditorAgent => CreditorAgent;
    ICashAccount38? ICreditTransferTransaction39.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification135 ICreditTransferTransaction39.Creditor => Creditor;
    ICashAccount38? ICreditTransferTransaction39.CreditorAccount => CreditorAccount;
    IPartyIdentification135? ICreditTransferTransaction39.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent1> ICreditTransferTransaction39.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction39.InstructionForNextAgent => InstructionForNextAgent;
    IPurpose2Choice? ICreditTransferTransaction39.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransaction39.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation8? ICreditTransferTransaction39.Tax => Tax;
    IEnumerable<IRemittanceLocation7> ICreditTransferTransaction39.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation16? ICreditTransferTransaction39.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction39.SupplementaryData => SupplementaryData;
}
