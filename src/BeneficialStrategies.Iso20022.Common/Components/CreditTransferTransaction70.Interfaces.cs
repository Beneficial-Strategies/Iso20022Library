// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CreditTransferTransaction70 : ICreditTransferTransaction70
{
    IAdditionalDateTime1? ICreditTransferTransaction70.AdditionalDateTime => AdditionalDateTime;
    ICurrencyExchange26? ICreditTransferTransaction70.AgreedRate => AgreedRate;
    IEnumerable<ICharges16> ICreditTransferTransaction70.ChargesInformation => ChargesInformation;
    IPartyIdentification272 ICreditTransferTransaction70.Creditor => Creditor;
    ICashAccount40? ICreditTransferTransaction70.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction70.CreditorAgent => CreditorAgent;
    ICashAccount40? ICreditTransferTransaction70.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification272 ICreditTransferTransaction70.Debtor => Debtor;
    ICashAccount40? ICreditTransferTransaction70.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8 ICreditTransferTransaction70.DebtorAgent => DebtorAgent;
    ICashAccount40? ICreditTransferTransaction70.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification272? ICreditTransferTransaction70.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction70.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction70.InstructingAgent => InstructingAgent;
    IEnumerable<IInstructionForCreditorAgent3> ICreditTransferTransaction70.InstructionForCreditorAgent => InstructionForCreditorAgent;
    IEnumerable<IInstructionForNextAgent1> ICreditTransferTransaction70.InstructionForNextAgent => InstructionForNextAgent;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction70.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount40? ICreditTransferTransaction70.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction70.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount40? ICreditTransferTransaction70.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction70.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount40? ICreditTransferTransaction70.IntermediaryAgent3Account => IntermediaryAgent3Account;
    ICreditTransferMandateData1? ICreditTransferTransaction70.MandateRelatedInformation => MandateRelatedInformation;
    IPaymentIdentification13 ICreditTransferTransaction70.PaymentIdentification => PaymentIdentification;
    ICryptographicKey1Choice? ICreditTransferTransaction70.PaymentSignature => PaymentSignature;
    IPaymentTypeInformation28? ICreditTransferTransaction70.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction70.PreviousInstructingAgent1 => PreviousInstructingAgent1;
    ICashAccount40? ICreditTransferTransaction70.PreviousInstructingAgent1Account => PreviousInstructingAgent1Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction70.PreviousInstructingAgent2 => PreviousInstructingAgent2;
    ICashAccount40? ICreditTransferTransaction70.PreviousInstructingAgent2Account => PreviousInstructingAgent2Account;
    IBranchAndFinancialInstitutionIdentification8? ICreditTransferTransaction70.PreviousInstructingAgent3 => PreviousInstructingAgent3;
    ICashAccount40? ICreditTransferTransaction70.PreviousInstructingAgent3Account => PreviousInstructingAgent3Account;
    IPurpose2Choice? ICreditTransferTransaction70.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> ICreditTransferTransaction70.RegulatoryReporting => RegulatoryReporting;
    IEnumerable<IRemittanceLocation8> ICreditTransferTransaction70.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation22? ICreditTransferTransaction70.RemittanceInformation => RemittanceInformation;
    ISettlementDateTimeIndication1? ICreditTransferTransaction70.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? ICreditTransferTransaction70.SettlementTimeRequest => SettlementTimeRequest;
    IEnumerable<ISupplementaryData1> ICreditTransferTransaction70.SupplementaryData => SupplementaryData;
    ITaxData1? ICreditTransferTransaction70.Tax => Tax;
    IPartyIdentification272? ICreditTransferTransaction70.UltimateCreditor => UltimateCreditor;
    IPartyIdentification272? ICreditTransferTransaction70.UltimateDebtor => UltimateDebtor;
}
