// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransactionInformation32 : IDirectDebitTransactionInformation32
{
    IPartyIdentification272 IDirectDebitTransactionInformation32.Debtor => Debtor;
    ICashAccount40 IDirectDebitTransactionInformation32.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8 IDirectDebitTransactionInformation32.DebtorAgent => DebtorAgent;
    ICashAccount40? IDirectDebitTransactionInformation32.DebtorAgentAccount => DebtorAgentAccount;
    IDirectDebitTransaction12? IDirectDebitTransactionInformation32.DirectDebitTransaction => DirectDebitTransaction;
    IPaymentIdentification6 IDirectDebitTransactionInformation32.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation29? IDirectDebitTransactionInformation32.PaymentTypeInformation => PaymentTypeInformation;
    IPurpose2Choice? IDirectDebitTransactionInformation32.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> IDirectDebitTransactionInformation32.RegulatoryReporting => RegulatoryReporting;
    IEnumerable<IRemittanceLocation8> IDirectDebitTransactionInformation32.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation22? IDirectDebitTransactionInformation32.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> IDirectDebitTransactionInformation32.SupplementaryData => SupplementaryData;
    ITaxData1? IDirectDebitTransactionInformation32.Tax => Tax;
    IPartyIdentification272? IDirectDebitTransactionInformation32.UltimateCreditor => UltimateCreditor;
    IPartyIdentification272? IDirectDebitTransactionInformation32.UltimateDebtor => UltimateDebtor;
}
