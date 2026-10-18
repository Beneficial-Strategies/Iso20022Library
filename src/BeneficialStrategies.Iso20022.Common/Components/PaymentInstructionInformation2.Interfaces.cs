// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstructionInformation2 : IPaymentInstructionInformation2
{
    IPaymentTypeInformation2? IPaymentInstructionInformation2.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification8 IPaymentInstructionInformation2.Creditor => Creditor;
    ICashAccount7 IPaymentInstructionInformation2.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification3 IPaymentInstructionInformation2.CreditorAgent => CreditorAgent;
    ICashAccount7? IPaymentInstructionInformation2.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification8? IPaymentInstructionInformation2.UltimateCreditor => UltimateCreditor;
    ICashAccount7? IPaymentInstructionInformation2.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification3? IPaymentInstructionInformation2.ChargesAccountAgent => ChargesAccountAgent;
    IEnumerable<IDirectDebitTransactionInformation1> IPaymentInstructionInformation2.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
}
