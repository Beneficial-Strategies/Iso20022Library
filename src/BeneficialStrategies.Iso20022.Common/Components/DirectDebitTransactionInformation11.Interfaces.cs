// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransactionInformation11 : IDirectDebitTransactionInformation11
{
    IPaymentIdentification1 IDirectDebitTransactionInformation11.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation24? IDirectDebitTransactionInformation11.PaymentTypeInformation => PaymentTypeInformation;
    IDirectDebitTransaction7? IDirectDebitTransactionInformation11.DirectDebitTransaction => DirectDebitTransaction;
    IPartyIdentification43? IDirectDebitTransactionInformation11.UltimateCreditor => UltimateCreditor;
    IBranchAndFinancialInstitutionIdentification5 IDirectDebitTransactionInformation11.DebtorAgent => DebtorAgent;
    ICashAccount24? IDirectDebitTransactionInformation11.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification43 IDirectDebitTransactionInformation11.Debtor => Debtor;
    ICashAccount24 IDirectDebitTransactionInformation11.DebtorAccount => DebtorAccount;
    IPartyIdentification43? IDirectDebitTransactionInformation11.UltimateDebtor => UltimateDebtor;
    IPurpose2Choice? IDirectDebitTransactionInformation11.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> IDirectDebitTransactionInformation11.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation3? IDirectDebitTransactionInformation11.Tax => Tax;
    IEnumerable<IRemittanceLocation2> IDirectDebitTransactionInformation11.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation7? IDirectDebitTransactionInformation11.RemittanceInformation => RemittanceInformation;
}
