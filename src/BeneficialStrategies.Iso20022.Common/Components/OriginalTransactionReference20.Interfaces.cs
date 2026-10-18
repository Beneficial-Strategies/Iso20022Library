// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalTransactionReference20 : IOriginalTransactionReference20
{
    IAmountType4Choice? IOriginalTransactionReference20.Amount => Amount;
    IPartyIdentification43? IOriginalTransactionReference20.CreditorSchemeIdentification => CreditorSchemeIdentification;
    ISettlementInstruction1? IOriginalTransactionReference20.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation25? IOriginalTransactionReference20.PaymentTypeInformation => PaymentTypeInformation;
    IMandateRelatedInformation10? IOriginalTransactionReference20.MandateRelatedInformation => MandateRelatedInformation;
    IRemittanceInformation10? IOriginalTransactionReference20.RemittanceInformation => RemittanceInformation;
    IPartyIdentification43? IOriginalTransactionReference20.UltimateDebtor => UltimateDebtor;
    IPartyIdentification43? IOriginalTransactionReference20.Debtor => Debtor;
    ICashAccount24? IOriginalTransactionReference20.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5? IOriginalTransactionReference20.DebtorAgent => DebtorAgent;
    ICashAccount24? IOriginalTransactionReference20.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification5? IOriginalTransactionReference20.CreditorAgent => CreditorAgent;
    ICashAccount24? IOriginalTransactionReference20.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification43? IOriginalTransactionReference20.Creditor => Creditor;
    ICashAccount24? IOriginalTransactionReference20.CreditorAccount => CreditorAccount;
    IPartyIdentification43? IOriginalTransactionReference20.UltimateCreditor => UltimateCreditor;
}
