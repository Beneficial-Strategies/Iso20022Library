// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction18 : IPaymentInstruction18
{
    IPaymentTypeInformation24? IPaymentInstruction18.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification43 IPaymentInstruction18.Creditor => Creditor;
    ICashAccount24 IPaymentInstruction18.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification5 IPaymentInstruction18.CreditorAgent => CreditorAgent;
    ICashAccount24? IPaymentInstruction18.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification43? IPaymentInstruction18.UltimateCreditor => UltimateCreditor;
    ICashAccount24? IPaymentInstruction18.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification5? IPaymentInstruction18.ChargesAccountAgent => ChargesAccountAgent;
    IPartyIdentification43? IPaymentInstruction18.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IEnumerable<IDirectDebitTransactionInformation19> IPaymentInstruction18.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
}
