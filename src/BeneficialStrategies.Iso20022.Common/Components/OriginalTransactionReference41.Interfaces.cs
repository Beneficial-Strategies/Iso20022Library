// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalTransactionReference41 : IOriginalTransactionReference41
{
    IAmountType4Choice? IOriginalTransactionReference41.Amount => Amount;
    IDateAndDateTime2Choice? IOriginalTransactionReference41.RequestedExecutionDate => RequestedExecutionDate;
    IPartyIdentification272? IOriginalTransactionReference41.CreditorSchemeIdentification => CreditorSchemeIdentification;
    ISettlementInstruction15? IOriginalTransactionReference41.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation27? IOriginalTransactionReference41.PaymentTypeInformation => PaymentTypeInformation;
    IMandateRelatedData3Choice? IOriginalTransactionReference41.MandateRelatedInformation => MandateRelatedInformation;
    IRemittanceInformation22? IOriginalTransactionReference41.RemittanceInformation => RemittanceInformation;
    IParty50Choice? IOriginalTransactionReference41.UltimateDebtor => UltimateDebtor;
    IParty50Choice? IOriginalTransactionReference41.Debtor => Debtor;
    ICashAccount40? IOriginalTransactionReference41.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8? IOriginalTransactionReference41.DebtorAgent => DebtorAgent;
    ICashAccount40? IOriginalTransactionReference41.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification8? IOriginalTransactionReference41.CreditorAgent => CreditorAgent;
    ICashAccount40? IOriginalTransactionReference41.CreditorAgentAccount => CreditorAgentAccount;
    IParty50Choice? IOriginalTransactionReference41.Creditor => Creditor;
    ICashAccount40? IOriginalTransactionReference41.CreditorAccount => CreditorAccount;
    IParty50Choice? IOriginalTransactionReference41.UltimateCreditor => UltimateCreditor;
    IPurpose2Choice? IOriginalTransactionReference41.Purpose => Purpose;
    ICreditTransferTransaction63? IOriginalTransactionReference41.UnderlyingCustomerCreditTransfer => UnderlyingCustomerCreditTransfer;
}
