// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransactionInformation28 : IDirectDebitTransactionInformation28
{
    IPaymentIdentification6 IDirectDebitTransactionInformation28.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation29? IDirectDebitTransactionInformation28.PaymentTypeInformation => PaymentTypeInformation;
    IDirectDebitTransaction11? IDirectDebitTransactionInformation28.DirectDebitTransaction => DirectDebitTransaction;
    IPartyIdentification135? IDirectDebitTransactionInformation28.UltimateCreditor => UltimateCreditor;
    IBranchAndFinancialInstitutionIdentification6 IDirectDebitTransactionInformation28.DebtorAgent => DebtorAgent;
    ICashAccount40? IDirectDebitTransactionInformation28.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification135 IDirectDebitTransactionInformation28.Debtor => Debtor;
    ICashAccount40 IDirectDebitTransactionInformation28.DebtorAccount => DebtorAccount;
    IPartyIdentification135? IDirectDebitTransactionInformation28.UltimateDebtor => UltimateDebtor;
    IPurpose2Choice? IDirectDebitTransactionInformation28.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> IDirectDebitTransactionInformation28.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation10? IDirectDebitTransactionInformation28.Tax => Tax;
    IEnumerable<IRemittanceLocation7> IDirectDebitTransactionInformation28.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation21? IDirectDebitTransactionInformation28.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> IDirectDebitTransactionInformation28.SupplementaryData => SupplementaryData;
}
