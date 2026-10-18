// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransactionInformation12 : IDirectDebitTransactionInformation12
{
    IPaymentIdentification3 IDirectDebitTransactionInformation12.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation25? IDirectDebitTransactionInformation12.PaymentTypeInformation => PaymentTypeInformation;
    IEnumerable<ICharges2> IDirectDebitTransactionInformation12.ChargesInformation => ChargesInformation;
    IDirectDebitTransaction7? IDirectDebitTransactionInformation12.DirectDebitTransaction => DirectDebitTransaction;
    IPartyIdentification43 IDirectDebitTransactionInformation12.Creditor => Creditor;
    ICashAccount24? IDirectDebitTransactionInformation12.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification5 IDirectDebitTransactionInformation12.CreditorAgent => CreditorAgent;
    ICashAccount24? IDirectDebitTransactionInformation12.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification43? IDirectDebitTransactionInformation12.UltimateCreditor => UltimateCreditor;
    IPartyIdentification43? IDirectDebitTransactionInformation12.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification5? IDirectDebitTransactionInformation12.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IDirectDebitTransactionInformation12.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification5? IDirectDebitTransactionInformation12.IntermediaryAgent1 => IntermediaryAgent1;
    ICashAccount24? IDirectDebitTransactionInformation12.IntermediaryAgent1Account => IntermediaryAgent1Account;
    IBranchAndFinancialInstitutionIdentification5? IDirectDebitTransactionInformation12.IntermediaryAgent2 => IntermediaryAgent2;
    ICashAccount24? IDirectDebitTransactionInformation12.IntermediaryAgent2Account => IntermediaryAgent2Account;
    IBranchAndFinancialInstitutionIdentification5? IDirectDebitTransactionInformation12.IntermediaryAgent3 => IntermediaryAgent3;
    ICashAccount24? IDirectDebitTransactionInformation12.IntermediaryAgent3Account => IntermediaryAgent3Account;
    IPartyIdentification43 IDirectDebitTransactionInformation12.Debtor => Debtor;
    ICashAccount24 IDirectDebitTransactionInformation12.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 IDirectDebitTransactionInformation12.DebtorAgent => DebtorAgent;
    ICashAccount24? IDirectDebitTransactionInformation12.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification43? IDirectDebitTransactionInformation12.UltimateDebtor => UltimateDebtor;
    IPurpose2Choice? IDirectDebitTransactionInformation12.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> IDirectDebitTransactionInformation12.RegulatoryReporting => RegulatoryReporting;
    IEnumerable<IRemittanceLocation2> IDirectDebitTransactionInformation12.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation7? IDirectDebitTransactionInformation12.RemittanceInformation => RemittanceInformation;
}
