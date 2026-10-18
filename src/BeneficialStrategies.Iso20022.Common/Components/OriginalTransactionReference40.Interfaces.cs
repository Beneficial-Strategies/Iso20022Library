// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalTransactionReference40 : IOriginalTransactionReference40
{
    IAmountType4Choice? IOriginalTransactionReference40.Amount => Amount;
    IPartyIdentification272 IOriginalTransactionReference40.Creditor => Creditor;
    ICashAccount40? IOriginalTransactionReference40.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8 IOriginalTransactionReference40.CreditorAgent => CreditorAgent;
    ICashAccount40? IOriginalTransactionReference40.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification272? IOriginalTransactionReference40.Debtor => Debtor;
    ICashAccount40? IOriginalTransactionReference40.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8? IOriginalTransactionReference40.DebtorAgent => DebtorAgent;
    ICashAccount40? IOriginalTransactionReference40.DebtorAgentAccount => DebtorAgentAccount;
    IEnumerable<IDocument15> IOriginalTransactionReference40.EnclosedFile => EnclosedFile;
    IDateAndDateTime2Choice? IOriginalTransactionReference40.ExpiryDate => ExpiryDate;
    ICreditTransferMandateData1? IOriginalTransactionReference40.MandateRelatedInformation => MandateRelatedInformation;
    IPaymentCondition2? IOriginalTransactionReference40.PaymentCondition => PaymentCondition;
    IPaymentTypeInformation29? IOriginalTransactionReference40.PaymentTypeInformation => PaymentTypeInformation;
    IRemittanceInformation22? IOriginalTransactionReference40.RemittanceInformation => RemittanceInformation;
    IDateAndDateTime2Choice? IOriginalTransactionReference40.RequestedExecutionDate => RequestedExecutionDate;
    IPartyIdentification272? IOriginalTransactionReference40.UltimateCreditor => UltimateCreditor;
    IPartyIdentification272? IOriginalTransactionReference40.UltimateDebtor => UltimateDebtor;
}
