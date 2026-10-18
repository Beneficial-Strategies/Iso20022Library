// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalTransactionReference35 : IOriginalTransactionReference35
{
    IAmountType4Choice? IOriginalTransactionReference35.Amount => Amount;
    IDateAndDateTime2Choice? IOriginalTransactionReference35.RequestedExecutionDate => RequestedExecutionDate;
    IPartyIdentification135? IOriginalTransactionReference35.CreditorSchemeIdentification => CreditorSchemeIdentification;
    ISettlementInstruction11? IOriginalTransactionReference35.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation27? IOriginalTransactionReference35.PaymentTypeInformation => PaymentTypeInformation;
    IMandateRelatedData2Choice? IOriginalTransactionReference35.MandateRelatedInformation => MandateRelatedInformation;
    IRemittanceInformation21? IOriginalTransactionReference35.RemittanceInformation => RemittanceInformation;
    IParty40Choice? IOriginalTransactionReference35.UltimateDebtor => UltimateDebtor;
    IParty40Choice? IOriginalTransactionReference35.Debtor => Debtor;
    ICashAccount40? IOriginalTransactionReference35.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6? IOriginalTransactionReference35.DebtorAgent => DebtorAgent;
    ICashAccount40? IOriginalTransactionReference35.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification6? IOriginalTransactionReference35.CreditorAgent => CreditorAgent;
    ICashAccount40? IOriginalTransactionReference35.CreditorAgentAccount => CreditorAgentAccount;
    IParty40Choice? IOriginalTransactionReference35.Creditor => Creditor;
    ICashAccount40? IOriginalTransactionReference35.CreditorAccount => CreditorAccount;
    IParty40Choice? IOriginalTransactionReference35.UltimateCreditor => UltimateCreditor;
    IPurpose2Choice? IOriginalTransactionReference35.Purpose => Purpose;
}
