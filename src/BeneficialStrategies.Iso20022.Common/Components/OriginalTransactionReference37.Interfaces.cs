// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalTransactionReference37 : IOriginalTransactionReference37
{
    IAmountType4Choice? IOriginalTransactionReference37.Amount => Amount;
    IDateAndDateTime2Choice? IOriginalTransactionReference37.RequestedExecutionDate => RequestedExecutionDate;
    IDateAndDateTime2Choice? IOriginalTransactionReference37.ExpiryDate => ExpiryDate;
    IPaymentCondition1? IOriginalTransactionReference37.PaymentCondition => PaymentCondition;
    IPaymentTypeInformation26? IOriginalTransactionReference37.PaymentTypeInformation => PaymentTypeInformation;
    ICreditTransferMandateData1? IOriginalTransactionReference37.MandateRelatedInformation => MandateRelatedInformation;
    IRemittanceInformation21? IOriginalTransactionReference37.RemittanceInformation => RemittanceInformation;
    IEnumerable<IDocument12> IOriginalTransactionReference37.EnclosedFile => EnclosedFile;
    IPartyIdentification135? IOriginalTransactionReference37.UltimateDebtor => UltimateDebtor;
    IPartyIdentification135? IOriginalTransactionReference37.Debtor => Debtor;
    ICashAccount40? IOriginalTransactionReference37.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6? IOriginalTransactionReference37.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification6 IOriginalTransactionReference37.CreditorAgent => CreditorAgent;
    IPartyIdentification135 IOriginalTransactionReference37.Creditor => Creditor;
    ICashAccount40? IOriginalTransactionReference37.CreditorAccount => CreditorAccount;
    IPartyIdentification135? IOriginalTransactionReference37.UltimateCreditor => UltimateCreditor;
}
