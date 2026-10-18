// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstructionInformation4 : IPaymentInstructionInformation4
{
    IPaymentTypeInformation20? IPaymentInstructionInformation4.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification32 IPaymentInstructionInformation4.Creditor => Creditor;
    ICashAccount16 IPaymentInstructionInformation4.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification4 IPaymentInstructionInformation4.CreditorAgent => CreditorAgent;
    ICashAccount16? IPaymentInstructionInformation4.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification32? IPaymentInstructionInformation4.UltimateCreditor => UltimateCreditor;
    ICashAccount16? IPaymentInstructionInformation4.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification4? IPaymentInstructionInformation4.ChargesAccountAgent => ChargesAccountAgent;
    IPartyIdentification32? IPaymentInstructionInformation4.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IEnumerable<IDirectDebitTransactionInformation9> IPaymentInstructionInformation4.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
}
