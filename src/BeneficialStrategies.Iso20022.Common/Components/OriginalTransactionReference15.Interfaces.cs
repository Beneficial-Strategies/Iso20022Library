// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalTransactionReference15 : IOriginalTransactionReference15
{
    IAmountType3Choice? IOriginalTransactionReference15.Amount => Amount;
    IPartyIdentification43? IOriginalTransactionReference15.CreditorSchemeIdentification => CreditorSchemeIdentification;
    ISettlementInformation16? IOriginalTransactionReference15.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation22? IOriginalTransactionReference15.PaymentTypeInformation => PaymentTypeInformation;
    IMandateRelatedInformation7? IOriginalTransactionReference15.MandateRelatedInformation => MandateRelatedInformation;
    IRemittanceInformation6? IOriginalTransactionReference15.RemittanceInformation => RemittanceInformation;
    IPartyIdentification43? IOriginalTransactionReference15.UltimateDebtor => UltimateDebtor;
    IPartyIdentification43? IOriginalTransactionReference15.Debtor => Debtor;
    ICashAccount16? IOriginalTransactionReference15.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5? IOriginalTransactionReference15.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification5 IOriginalTransactionReference15.CreditorAgent => CreditorAgent;
    IPartyIdentification43 IOriginalTransactionReference15.Creditor => Creditor;
    ICashAccount16? IOriginalTransactionReference15.CreditorAccount => CreditorAccount;
    IPartyIdentification43? IOriginalTransactionReference15.UltimateCreditor => UltimateCreditor;
}
