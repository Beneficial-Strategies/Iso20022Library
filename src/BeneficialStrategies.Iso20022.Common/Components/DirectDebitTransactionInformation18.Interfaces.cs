// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransactionInformation18 : IDirectDebitTransactionInformation18
{
    IPaymentIdentification1 IDirectDebitTransactionInformation18.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation24? IDirectDebitTransactionInformation18.PaymentTypeInformation => PaymentTypeInformation;
    IDirectDebitTransaction8? IDirectDebitTransactionInformation18.DirectDebitTransaction => DirectDebitTransaction;
    IPartyIdentification43? IDirectDebitTransactionInformation18.UltimateCreditor => UltimateCreditor;
    IBranchAndFinancialInstitutionIdentification5 IDirectDebitTransactionInformation18.DebtorAgent => DebtorAgent;
    ICashAccount24? IDirectDebitTransactionInformation18.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification43 IDirectDebitTransactionInformation18.Debtor => Debtor;
    ICashAccount24 IDirectDebitTransactionInformation18.DebtorAccount => DebtorAccount;
    IPartyIdentification43? IDirectDebitTransactionInformation18.UltimateDebtor => UltimateDebtor;
    IPurpose2Choice? IDirectDebitTransactionInformation18.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> IDirectDebitTransactionInformation18.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation3? IDirectDebitTransactionInformation18.Tax => Tax;
    IEnumerable<IRemittanceLocation4> IDirectDebitTransactionInformation18.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation10? IDirectDebitTransactionInformation18.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> IDirectDebitTransactionInformation18.SupplementaryData => SupplementaryData;
}
