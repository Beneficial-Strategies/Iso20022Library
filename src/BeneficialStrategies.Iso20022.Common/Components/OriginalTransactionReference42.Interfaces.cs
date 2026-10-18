// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalTransactionReference42 : IOriginalTransactionReference42
{
    IAmountType4Choice? IOriginalTransactionReference42.Amount => Amount;
    IParty50Choice? IOriginalTransactionReference42.Creditor => Creditor;
    ICashAccount40? IOriginalTransactionReference42.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8? IOriginalTransactionReference42.CreditorAgent => CreditorAgent;
    ICashAccount40? IOriginalTransactionReference42.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification272? IOriginalTransactionReference42.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IParty50Choice? IOriginalTransactionReference42.Debtor => Debtor;
    ICashAccount40? IOriginalTransactionReference42.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8? IOriginalTransactionReference42.DebtorAgent => DebtorAgent;
    ICashAccount40? IOriginalTransactionReference42.DebtorAgentAccount => DebtorAgentAccount;
    IMandateRelatedData3Choice? IOriginalTransactionReference42.MandateRelatedInformation => MandateRelatedInformation;
    IPaymentTypeInformation27? IOriginalTransactionReference42.PaymentTypeInformation => PaymentTypeInformation;
    IPurpose2Choice? IOriginalTransactionReference42.Purpose => Purpose;
    IRemittanceInformation22? IOriginalTransactionReference42.RemittanceInformation => RemittanceInformation;
    IDateAndDateTime2Choice? IOriginalTransactionReference42.RequestedExecutionDate => RequestedExecutionDate;
    ISettlementInstruction15? IOriginalTransactionReference42.SettlementInformation => SettlementInformation;
    IParty50Choice? IOriginalTransactionReference42.UltimateCreditor => UltimateCreditor;
    IParty50Choice? IOriginalTransactionReference42.UltimateDebtor => UltimateDebtor;
}
