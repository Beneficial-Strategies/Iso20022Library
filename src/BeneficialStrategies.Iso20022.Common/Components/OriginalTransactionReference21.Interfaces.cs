// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalTransactionReference21 : IOriginalTransactionReference21
{
    IAmountType4Choice? IOriginalTransactionReference21.Amount => Amount;
    IPaymentTypeInformation19? IOriginalTransactionReference21.PaymentTypeInformation => PaymentTypeInformation;
    IRemittanceInformation6? IOriginalTransactionReference21.RemittanceInformation => RemittanceInformation;
    IPartyIdentification43? IOriginalTransactionReference21.UltimateDebtor => UltimateDebtor;
    IPartyIdentification43? IOriginalTransactionReference21.Debtor => Debtor;
    ICashAccount24? IOriginalTransactionReference21.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5? IOriginalTransactionReference21.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification5 IOriginalTransactionReference21.CreditorAgent => CreditorAgent;
    IPartyIdentification43 IOriginalTransactionReference21.Creditor => Creditor;
    ICashAccount24? IOriginalTransactionReference21.CreditorAccount => CreditorAccount;
    IPartyIdentification43? IOriginalTransactionReference21.UltimateCreditor => UltimateCreditor;
}
