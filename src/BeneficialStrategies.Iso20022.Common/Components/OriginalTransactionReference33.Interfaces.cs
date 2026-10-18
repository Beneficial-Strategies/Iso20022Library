// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalTransactionReference33 : IOriginalTransactionReference33
{
    IAmountType4Choice? IOriginalTransactionReference33.Amount => Amount;
    IDateAndDateTime2Choice? IOriginalTransactionReference33.RequestedExecutionDate => RequestedExecutionDate;
    IDateAndDateTime2Choice? IOriginalTransactionReference33.ExpiryDate => ExpiryDate;
    IPaymentCondition1? IOriginalTransactionReference33.PaymentCondition => PaymentCondition;
    IPaymentTypeInformation26? IOriginalTransactionReference33.PaymentTypeInformation => PaymentTypeInformation;
    ICreditTransferMandateData1? IOriginalTransactionReference33.MandateRelatedInformation => MandateRelatedInformation;
    IRemittanceInformation16? IOriginalTransactionReference33.RemittanceInformation => RemittanceInformation;
    IEnumerable<IDocument12> IOriginalTransactionReference33.EnclosedFile => EnclosedFile;
    IPartyIdentification135? IOriginalTransactionReference33.UltimateDebtor => UltimateDebtor;
    IPartyIdentification135? IOriginalTransactionReference33.Debtor => Debtor;
    ICashAccount38? IOriginalTransactionReference33.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6? IOriginalTransactionReference33.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification6 IOriginalTransactionReference33.CreditorAgent => CreditorAgent;
    IPartyIdentification135 IOriginalTransactionReference33.Creditor => Creditor;
    ICashAccount38? IOriginalTransactionReference33.CreditorAccount => CreditorAccount;
    IPartyIdentification135? IOriginalTransactionReference33.UltimateCreditor => UltimateCreditor;
}
