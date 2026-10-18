// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalTransactionReference44 : IOriginalTransactionReference44
{
    IAmountType4Choice? IOriginalTransactionReference44.Amount => Amount;
    IParty50Choice? IOriginalTransactionReference44.Creditor => Creditor;
    ICashAccount40? IOriginalTransactionReference44.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8? IOriginalTransactionReference44.CreditorAgent => CreditorAgent;
    ICashAccount40? IOriginalTransactionReference44.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification272? IOriginalTransactionReference44.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IParty50Choice? IOriginalTransactionReference44.Debtor => Debtor;
    ICashAccount40? IOriginalTransactionReference44.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8? IOriginalTransactionReference44.DebtorAgent => DebtorAgent;
    ICashAccount40? IOriginalTransactionReference44.DebtorAgentAccount => DebtorAgentAccount;
    IMandateRelatedData3Choice? IOriginalTransactionReference44.MandateRelatedInformation => MandateRelatedInformation;
    IPaymentTypeInformation27? IOriginalTransactionReference44.PaymentTypeInformation => PaymentTypeInformation;
    IPurpose2Choice? IOriginalTransactionReference44.Purpose => Purpose;
    IRemittanceInformation22? IOriginalTransactionReference44.RemittanceInformation => RemittanceInformation;
    IDateAndDateTime2Choice? IOriginalTransactionReference44.RequestedExecutionDate => RequestedExecutionDate;
    ISettlementInstruction15? IOriginalTransactionReference44.SettlementInformation => SettlementInformation;
    IParty50Choice? IOriginalTransactionReference44.UltimateCreditor => UltimateCreditor;
    IParty50Choice? IOriginalTransactionReference44.UltimateDebtor => UltimateDebtor;
    ICreditTransferTransaction68? IOriginalTransactionReference44.UnderlyingCustomerCreditTransfer => UnderlyingCustomerCreditTransfer;
    ICreditTransferTransaction69? IOriginalTransactionReference44.UnderlyingFinancialInstitutionCreditTransfer => UnderlyingFinancialInstitutionCreditTransfer;
}
