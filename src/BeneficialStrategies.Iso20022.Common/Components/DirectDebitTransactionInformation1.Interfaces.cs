// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransactionInformation1 : IDirectDebitTransactionInformation1
{
    IPaymentIdentification1 IDirectDebitTransactionInformation1.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation2? IDirectDebitTransactionInformation1.PaymentTypeInformation => PaymentTypeInformation;
    IDirectDebitTransaction1? IDirectDebitTransactionInformation1.DirectDebitTransaction => DirectDebitTransaction;
    IPartyIdentification8? IDirectDebitTransactionInformation1.UltimateCreditor => UltimateCreditor;
    IBranchAndFinancialInstitutionIdentification3 IDirectDebitTransactionInformation1.DebtorAgent => DebtorAgent;
    ICashAccount7? IDirectDebitTransactionInformation1.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification8 IDirectDebitTransactionInformation1.Debtor => Debtor;
    ICashAccount7 IDirectDebitTransactionInformation1.DebtorAccount => DebtorAccount;
    IPartyIdentification8? IDirectDebitTransactionInformation1.UltimateDebtor => UltimateDebtor;
    IPurpose1Choice? IDirectDebitTransactionInformation1.Purpose => Purpose;
    IEnumerable<IRegulatoryReporting2> IDirectDebitTransactionInformation1.RegulatoryReporting => RegulatoryReporting;
    ITaxInformation2? IDirectDebitTransactionInformation1.Tax => Tax;
    IEnumerable<IRemittanceLocation1> IDirectDebitTransactionInformation1.RelatedRemittanceInformation => RelatedRemittanceInformation;
    IRemittanceInformation1? IDirectDebitTransactionInformation1.RemittanceInformation => RemittanceInformation;
}
