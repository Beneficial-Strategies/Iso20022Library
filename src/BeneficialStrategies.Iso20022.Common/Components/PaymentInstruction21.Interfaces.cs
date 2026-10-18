// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction21 : IPaymentInstruction21
{
    IPaymentTypeInformation24? IPaymentInstruction21.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification43 IPaymentInstruction21.Creditor => Creditor;
    ICashAccount24 IPaymentInstruction21.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification5 IPaymentInstruction21.CreditorAgent => CreditorAgent;
    ICashAccount24? IPaymentInstruction21.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification43? IPaymentInstruction21.UltimateCreditor => UltimateCreditor;
    ICashAccount24? IPaymentInstruction21.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification5? IPaymentInstruction21.ChargesAccountAgent => ChargesAccountAgent;
    IPartyIdentification43? IPaymentInstruction21.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IEnumerable<IDirectDebitTransactionInformation22> IPaymentInstruction21.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
}
