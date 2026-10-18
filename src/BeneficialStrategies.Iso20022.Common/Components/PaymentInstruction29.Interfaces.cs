// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction29 : IPaymentInstruction29
{
    IPaymentTypeInformation29? IPaymentInstruction29.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification135 IPaymentInstruction29.Creditor => Creditor;
    ICashAccount38 IPaymentInstruction29.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification6 IPaymentInstruction29.CreditorAgent => CreditorAgent;
    ICashAccount38? IPaymentInstruction29.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification135? IPaymentInstruction29.UltimateCreditor => UltimateCreditor;
    ICashAccount38? IPaymentInstruction29.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification6? IPaymentInstruction29.ChargesAccountAgent => ChargesAccountAgent;
    IPartyIdentification135? IPaymentInstruction29.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IEnumerable<IDirectDebitTransactionInformation23> IPaymentInstruction29.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
}
