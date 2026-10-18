// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalTransactionReference19 : IOriginalTransactionReference19
{
    IAmountType3Choice? IOriginalTransactionReference19.Amount => Amount;
    IPaymentTypeInformation19? IOriginalTransactionReference19.PaymentTypeInformation => PaymentTypeInformation;
    IRemittanceInformation6? IOriginalTransactionReference19.RemittanceInformation => RemittanceInformation;
    IPartyIdentification43? IOriginalTransactionReference19.UltimateDebtor => UltimateDebtor;
    IPartyIdentification43? IOriginalTransactionReference19.Debtor => Debtor;
    ICashAccount24? IOriginalTransactionReference19.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5? IOriginalTransactionReference19.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification5 IOriginalTransactionReference19.CreditorAgent => CreditorAgent;
    IPartyIdentification43 IOriginalTransactionReference19.Creditor => Creditor;
    ICashAccount24? IOriginalTransactionReference19.CreditorAccount => CreditorAccount;
    IPartyIdentification43? IOriginalTransactionReference19.UltimateCreditor => UltimateCreditor;
}
