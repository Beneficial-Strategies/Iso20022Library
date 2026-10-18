// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalTransactionReference17 : IOriginalTransactionReference17
{
    IAmountType3Choice? IOriginalTransactionReference17.Amount => Amount;
    IPartyIdentification43? IOriginalTransactionReference17.CreditorSchemeIdentification => CreditorSchemeIdentification;
    ISettlementInstruction1? IOriginalTransactionReference17.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation25? IOriginalTransactionReference17.PaymentTypeInformation => PaymentTypeInformation;
    IMandateRelatedInformation9? IOriginalTransactionReference17.MandateRelatedInformation => MandateRelatedInformation;
    IRemittanceInformation6? IOriginalTransactionReference17.RemittanceInformation => RemittanceInformation;
    IPartyIdentification43? IOriginalTransactionReference17.UltimateDebtor => UltimateDebtor;
    IPartyIdentification43? IOriginalTransactionReference17.Debtor => Debtor;
    ICashAccount24? IOriginalTransactionReference17.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5? IOriginalTransactionReference17.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification5 IOriginalTransactionReference17.CreditorAgent => CreditorAgent;
    IPartyIdentification43 IOriginalTransactionReference17.Creditor => Creditor;
    ICashAccount24? IOriginalTransactionReference17.CreditorAccount => CreditorAccount;
    IPartyIdentification43? IOriginalTransactionReference17.UltimateCreditor => UltimateCreditor;
}
