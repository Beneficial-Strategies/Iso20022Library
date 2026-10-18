// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DirectDebitTransactionInformation33 : IDirectDebitTransactionInformation33
{
    IBranchAndFinancialInstitutionIdentification8 IDirectDebitTransactionInformation33.Debtor => Debtor;
    ICashAccount40? IDirectDebitTransactionInformation33.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8? IDirectDebitTransactionInformation33.DebtorAgent => DebtorAgent;
    ICashAccount40? IDirectDebitTransactionInformation33.DebtorAgentAccount => DebtorAgentAccount;
    IPaymentIdentification13 IDirectDebitTransactionInformation33.PaymentIdentification => PaymentIdentification;
    IPaymentTypeInformation28? IDirectDebitTransactionInformation33.PaymentTypeInformation => PaymentTypeInformation;
    IPurpose2Choice? IDirectDebitTransactionInformation33.Purpose => Purpose;
    IRemittanceInformation2? IDirectDebitTransactionInformation33.RemittanceInformation => RemittanceInformation;
    ISettlementDateTimeIndication1? IDirectDebitTransactionInformation33.SettlementTimeIndication => SettlementTimeIndication;
    ISettlementTimeRequest2? IDirectDebitTransactionInformation33.SettlementTimeRequest => SettlementTimeRequest;
    IBranchAndFinancialInstitutionIdentification8? IDirectDebitTransactionInformation33.UltimateDebtor => UltimateDebtor;
}
