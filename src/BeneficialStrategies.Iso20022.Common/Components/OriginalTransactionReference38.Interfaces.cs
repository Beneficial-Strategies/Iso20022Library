// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalTransactionReference38 : IOriginalTransactionReference38
{
    IAmountType4Choice? IOriginalTransactionReference38.Amount => Amount;
    IDateAndDateTime2Choice? IOriginalTransactionReference38.RequestedExecutionDate => RequestedExecutionDate;
    IDateAndDateTime2Choice? IOriginalTransactionReference38.ExpiryDate => ExpiryDate;
    IPaymentCondition1? IOriginalTransactionReference38.PaymentCondition => PaymentCondition;
    IPaymentTypeInformation26? IOriginalTransactionReference38.PaymentTypeInformation => PaymentTypeInformation;
    ICreditTransferMandateData1? IOriginalTransactionReference38.MandateRelatedInformation => MandateRelatedInformation;
    IRemittanceInformation21? IOriginalTransactionReference38.RemittanceInformation => RemittanceInformation;
    IEnumerable<IDocument12> IOriginalTransactionReference38.EnclosedFile => EnclosedFile;
    IPartyIdentification135? IOriginalTransactionReference38.UltimateDebtor => UltimateDebtor;
    IPartyIdentification135? IOriginalTransactionReference38.Debtor => Debtor;
    ICashAccount40? IOriginalTransactionReference38.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6? IOriginalTransactionReference38.DebtorAgent => DebtorAgent;
    ICashAccount40? IOriginalTransactionReference38.DebtorAgentAccount => DebtorAgentAccount;
    IBranchAndFinancialInstitutionIdentification6 IOriginalTransactionReference38.CreditorAgent => CreditorAgent;
    ICashAccount40? IOriginalTransactionReference38.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification135 IOriginalTransactionReference38.Creditor => Creditor;
    ICashAccount40? IOriginalTransactionReference38.CreditorAccount => CreditorAccount;
    IPartyIdentification135? IOriginalTransactionReference38.UltimateCreditor => UltimateCreditor;
}
