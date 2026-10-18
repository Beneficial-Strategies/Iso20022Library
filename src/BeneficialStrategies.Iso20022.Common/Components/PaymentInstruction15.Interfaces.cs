// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction15 : IPaymentInstruction15
{
    IPaymentTypeInformation24? IPaymentInstruction15.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification43 IPaymentInstruction15.Creditor => Creditor;
    ICashAccount24 IPaymentInstruction15.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification5 IPaymentInstruction15.CreditorAgent => CreditorAgent;
    ICashAccount24? IPaymentInstruction15.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification43? IPaymentInstruction15.UltimateCreditor => UltimateCreditor;
    ICashAccount24? IPaymentInstruction15.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification5? IPaymentInstruction15.ChargesAccountAgent => ChargesAccountAgent;
    IPartyIdentification43? IPaymentInstruction15.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IEnumerable<IDirectDebitTransactionInformation18> IPaymentInstruction15.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
}
