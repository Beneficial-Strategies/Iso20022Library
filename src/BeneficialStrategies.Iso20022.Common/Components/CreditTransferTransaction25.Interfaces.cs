// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction25 : ICreditTransferTransaction25
{
    IPaymentIdentification3 ICreditTransferTransaction25.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation21? ICreditTransferTransaction25.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransaction25.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? ICreditTransferTransaction25.SettlementTimeRequest => SettlementTimeRequest;
    IEnumerable<ICharges2> ICreditTransferTransaction25.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction25.PreviousInstructingAgent => PreviousInstructingAgent;
    ICashAccount24? ICreditTransferTransaction25.PreviousInstructingAgentAccount => PreviousInstructingAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction25.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction25.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction25.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount24? ICreditTransferTransaction25.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction25.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount24? ICreditTransferTransaction25.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction25.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount24? ICreditTransferTransaction25.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IPartyIdentification43? ICreditTransferTransaction25.UltimateDebtor => UltimateDebtor;
    IPartyIdentification43? ICreditTransferTransaction25.InitiatingParty => InitiatingParty;
    IPartyIdentification43 ICreditTransferTransaction25.Debtor => Debtor;
    ICashAccount24? ICreditTransferTransaction25.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction25.DebtorAgent => DebtorAgent;
    ICashAccount24? ICreditTransferTransaction25.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction25.CreditorAgent => CreditorAgent;
    ICashAccount24? ICreditTransferTransaction25.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification43 ICreditTransferTransaction25.Creditor => Creditor;
    ICashAccount24? ICreditTransferTransaction25.CreditorAccount => CreditorAccount;
    IPartyIdentification43? ICreditTransferTransaction25.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent1> ICreditTransferTransaction25.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction25.InstructionForNextAgent => InstructionForNextAgent;
    IPurpose2Choice? ICreditTransferTransaction25.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransaction25.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation3? ICreditTransferTransaction25.Tax => Tax;
    IEnumerable<IRemittanceLocation4> ICreditTransferTransaction25.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation11? ICreditTransferTransaction25.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction25.SupplementaryData => SupplementaryData;
}
