// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransactionInformation23 : IDirectDebitTransactionInformation23
{
    IPaymentIdentification6 IDirectDebitTransactionInformation23.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation29? IDirectDebitTransactionInformation23.PaymentTypeInformation => PaymentTypeInformation;
    IDirectDebitTransaction10? IDirectDebitTransactionInformation23.DirectDebitTransaction => DirectDebitTransaction;
    IPartyIdentification135? IDirectDebitTransactionInformation23.UltimateCreditor => UltimateCreditor;
    IBranchAndFinancialInstitutionIdentification6 IDirectDebitTransactionInformation23.DebtorAgent => DebtorAgent;
    ICashAccount38? IDirectDebitTransactionInformation23.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification135 IDirectDebitTransactionInformation23.Debtor => Debtor;
    ICashAccount38 IDirectDebitTransactionInformation23.DebtorAccount => DebtorAccount;
    IPartyIdentification135? IDirectDebitTransactionInformation23.UltimateDebtor => UltimateDebtor;
    IPurpose2Choice? IDirectDebitTransactionInformation23.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> IDirectDebitTransactionInformation23.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation8? IDirectDebitTransactionInformation23.Tax => Tax;
    IEnumerable<IRemittanceLocation7> IDirectDebitTransactionInformation23.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation16? IDirectDebitTransactionInformation23.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> IDirectDebitTransactionInformation23.SupplementaryData => SupplementaryData;
}
