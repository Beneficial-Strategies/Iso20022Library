// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction43 : ICreditTransferTransaction43
{
    IPaymentIdentification13 ICreditTransferTransaction43.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation28? ICreditTransferTransaction43.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransaction43.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? ICreditTransferTransaction43.SettlementTimeRequest => SettlementTimeRequest;
    IEnumerable<ICharges7> ICreditTransferTransaction43.ChargesInformation => ChargesInformation;
    ICreditTransferMandateData1? ICreditTransferTransaction43.MandateRelatedInformation => MandateRelatedInformation;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction43.PreviousInstructingAgent1 => PreviousInstructingAgent1;
    ICashAccount38? ICreditTransferTransaction43.PreviousInstructingAgent1Account => PreviousInstructingAgent1Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction43.PreviousInstructingAgent2 => PreviousInstructingAgent2;
    ICashAccount38? ICreditTransferTransaction43.PreviousInstructingAgent2Account => PreviousInstructingAgent2Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction43.PreviousInstructingAgent3 => PreviousInstructingAgent3;
    ICashAccount38? ICreditTransferTransaction43.PreviousInstructingAgent3Account => PreviousInstructingAgent3Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction43.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction43.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction43.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount38? ICreditTransferTransaction43.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction43.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount38? ICreditTransferTransaction43.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification6? ICreditTransferTransaction43.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount38? ICreditTransferTransaction43.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IPartyIdentification135? ICreditTransferTransaction43.UltimateDebtor => UltimateDebtor;
    IPartyIdentification135? ICreditTransferTransaction43.InitiatingParty => InitiatingParty;
    IPartyIdentification135 ICreditTransferTransaction43.Debtor => Debtor;
    ICashAccount38? ICreditTransferTransaction43.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6 ICreditTransferTransaction43.DebtorAgent => DebtorAgent;
    ICashAccount38? ICreditTransferTransaction43.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification6 ICreditTransferTransaction43.CreditorAgent => CreditorAgent;
    ICashAccount38? ICreditTransferTransaction43.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification135 ICreditTransferTransaction43.Creditor => Creditor;
    ICashAccount38? ICreditTransferTransaction43.CreditorAccount => CreditorAccount;
    IPartyIdentification135? ICreditTransferTransaction43.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction43.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction43.InstructionForNextAgent => InstructionForNextAgent;
    IPurpose2Choice? ICreditTransferTransaction43.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransaction43.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation8? ICreditTransferTransaction43.Tax => Tax;
    IEnumerable<IRemittanceLocation7> ICreditTransferTransaction43.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation16? ICreditTransferTransaction43.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction43.SupplementaryData => SupplementaryData;
}
