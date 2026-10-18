// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalTransactionReference13 : IOriginalTransactionReference13
{
    IAmountType3Choice? IOriginalTransactionReference13.Amount => Amount;
    IPartyIdentification32? IOriginalTransactionReference13.CreditorSchemeIdentification => CreditorSchemeIdentification;
    ISettlementInformation13? IOriginalTransactionReference13.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation22? IOriginalTransactionReference13.PaymentTypeInformation => PaymentTypeInformation;
    IMandateRelatedInformation6? IOriginalTransactionReference13.MandateRelatedInformation => MandateRelatedInformation;
    IRemittanceInformation5? IOriginalTransactionReference13.RemittanceInformation => RemittanceInformation;
    IPartyIdentification32? IOriginalTransactionReference13.UltimateDebtor => UltimateDebtor;
    IPartyIdentification32? IOriginalTransactionReference13.Debtor => Debtor;
    ICashAccount16? IOriginalTransactionReference13.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification4? IOriginalTransactionReference13.DebtorAgent => DebtorAgent;
    ICashAccount16? IOriginalTransactionReference13.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification4? IOriginalTransactionReference13.CreditorAgent => CreditorAgent;
    ICashAccount16? IOriginalTransactionReference13.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification32? IOriginalTransactionReference13.Creditor => Creditor;
    ICashAccount16? IOriginalTransactionReference13.CreditorAccount => CreditorAccount;
    IPartyIdentification32? IOriginalTransactionReference13.UltimateCreditor => UltimateCreditor;
}
