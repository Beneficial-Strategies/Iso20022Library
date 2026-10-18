// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction2 : ICreditTransferTransaction2
{
    IPaymentIdentification3 ICreditTransferTransaction2.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation21? ICreditTransferTransaction2.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransaction2.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? ICreditTransferTransaction2.SettlementTimeRequest => SettlementTimeRequest;
    IEnumerable<ICharges2> ICreditTransferTransaction2.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction2.PreviousInstructingAgent => PreviousInstructingAgent;
    ICashAccount24? ICreditTransferTransaction2.PreviousInstructingAgentAccount => PreviousInstructingAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction2.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction2.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction2.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount24? ICreditTransferTransaction2.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction2.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount24? ICreditTransferTransaction2.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification5? ICreditTransferTransaction2.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount24? ICreditTransferTransaction2.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IPartyIdentification43? ICreditTransferTransaction2.UltimateDebtor => UltimateDebtor;
    IPartyIdentification43? ICreditTransferTransaction2.InitiatingParty => InitiatingParty;
    IPartyIdentification43 ICreditTransferTransaction2.Debtor => Debtor;
    ICashAccount24? ICreditTransferTransaction2.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction2.DebtorAgent => DebtorAgent;
    ICashAccount24? ICreditTransferTransaction2.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification5 ICreditTransferTransaction2.CreditorAgent => CreditorAgent;
    ICashAccount24? ICreditTransferTransaction2.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification43 ICreditTransferTransaction2.Creditor => Creditor;
    ICashAccount24? ICreditTransferTransaction2.CreditorAccount => CreditorAccount;
    IPartyIdentification43? ICreditTransferTransaction2.UltimateCreditor => UltimateCreditor;
    IEnumerable<IInstructionForCreditorAgent1> ICreditTransferTransaction2.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction2.InstructionForNextAgent => InstructionForNextAgent;
    IPurpose2Choice? ICreditTransferTransaction2.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransaction2.RegulatoryReporting => RegulatoryReporting;
    IEnumerable<IRemittanceLocation2> ICreditTransferTransaction2.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation7? ICreditTransferTransaction2.RemittanceInformation => RemittanceInformation;
}
