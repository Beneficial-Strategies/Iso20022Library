// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransactionInformation29 : IDirectDebitTransactionInformation29
{
    IPaymentIdentification13 IDirectDebitTransactionInformation29.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation27? IDirectDebitTransactionInformation29.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementDateTimeIndication1? IDirectDebitTransactionInformation29.SettlementTimeIndication => SettlementTimeIndication;
    IEnumerable<ICharges7> IDirectDebitTransactionInformation29.ChargesInformation => ChargesInformation;
    IDirectDebitTransaction11? IDirectDebitTransactionInformation29.DirectDebitTransaction => DirectDebitTransaction;
    IPartyIdentification135 IDirectDebitTransactionInformation29.Creditor => Creditor;
    ICashAccount40? IDirectDebitTransactionInformation29.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification6 IDirectDebitTransactionInformation29.CreditorAgent => CreditorAgent;
    ICashAccount40? IDirectDebitTransactionInformation29.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification135? IDirectDebitTransactionInformation29.UltimateCreditor => UltimateCreditor;
    IPartyIdentification135? IDirectDebitTransactionInformation29.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification6? IDirectDebitTransactionInformation29.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IDirectDebitTransactionInformation29.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification6? IDirectDebitTransactionInformation29.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount40? IDirectDebitTransactionInformation29.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification6? IDirectDebitTransactionInformation29.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount40? IDirectDebitTransactionInformation29.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification6? IDirectDebitTransactionInformation29.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount40? IDirectDebitTransactionInformation29.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IPartyIdentification135 IDirectDebitTransactionInformation29.Debtor => Debtor;
    ICashAccount40 IDirectDebitTransactionInformation29.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6 IDirectDebitTransactionInformation29.DebtorAgent => DebtorAgent;
    ICashAccount40? IDirectDebitTransactionInformation29.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification135? IDirectDebitTransactionInformation29.UltimateDebtor => UltimateDebtor;
    IPurpose2Choice? IDirectDebitTransactionInformation29.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> IDirectDebitTransactionInformation29.RegulatoryReporting => RegulatoryReporting;
    IEnumerable<IRemittanceLocation7> IDirectDebitTransactionInformation29.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation21? IDirectDebitTransactionInformation29.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> IDirectDebitTransactionInformation29.SupplementaryData => SupplementaryData;
}
