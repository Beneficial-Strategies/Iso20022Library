// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransactionInformation22 : IDirectDebitTransactionInformation22
{
    IPaymentIdentification1 IDirectDebitTransactionInformation22.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation24? IDirectDebitTransactionInformation22.PaymentTypeInformation => PaymentTypeInformation;
    IDirectDebitTransaction9? IDirectDebitTransactionInformation22.DirectDebitTransaction => DirectDebitTransaction;
    IPartyIdentification43? IDirectDebitTransactionInformation22.UltimateCreditor => UltimateCreditor;
    IBranchAndFinancialInstitutionIdentification5 IDirectDebitTransactionInformation22.DebtorAgent => DebtorAgent;
    ICashAccount24? IDirectDebitTransactionInformation22.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification43 IDirectDebitTransactionInformation22.Debtor => Debtor;
    ICashAccount24 IDirectDebitTransactionInformation22.DebtorAccount => DebtorAccount;
    IPartyIdentification43? IDirectDebitTransactionInformation22.UltimateDebtor => UltimateDebtor;
    IPurpose2Choice? IDirectDebitTransactionInformation22.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting3> IDirectDebitTransactionInformation22.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation3? IDirectDebitTransactionInformation22.Tax => Tax;
    IEnumerable<IRemittanceLocation4> IDirectDebitTransactionInformation22.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation11? IDirectDebitTransactionInformation22.RemittanceInformation => RemittanceInformation;
    IEnumerable<ISupplementaryData1> IDirectDebitTransactionInformation22.SupplementaryData => SupplementaryData;
}
