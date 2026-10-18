// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransactionInformation34 : IDirectDebitTransactionInformation34
{
    IPaymentIdentification6 IDirectDebitTransactionInformation34.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation29? IDirectDebitTransactionInformation34.PaymentTypeInformation => PaymentTypeInformation;
    IDirectDebitTransaction12? IDirectDebitTransactionInformation34.DirectDebitTransaction => DirectDebitTransaction;
    IPartyIdentification272? IDirectDebitTransactionInformation34.UltimateCreditor => UltimateCreditor;
    IBranchAndFinancialInstitutionIdentification8 IDirectDebitTransactionInformation34.DebtorAgent => DebtorAgent;
    ICashAccount40? IDirectDebitTransactionInformation34.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification272 IDirectDebitTransactionInformation34.Debtor => Debtor;
    ICashAccount40 IDirectDebitTransactionInformation34.DebtorAccount => DebtorAccount;
    IPartyIdentification272? IDirectDebitTransactionInformation34.UltimateDebtor => UltimateDebtor;
    IPurpose2Choice? IDirectDebitTransactionInformation34.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting10> IDirectDebitTransactionInformation34.RegulatoryReporting => RegulatoryReporting;
    ITaxData1? IDirectDebitTransactionInformation34.Tax => Tax;
    IEnumerable<IRemittanceLocation8> IDirectDebitTransactionInformation34.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation26? IDirectDebitTransactionInformation34.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> IDirectDebitTransactionInformation34.SupplementaryData => SupplementaryData;
}
