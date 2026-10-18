// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction37 : IPaymentInstruction37
{
    IAdviceType1? IPaymentInstruction37.RequestedAdviceType => RequestedAdviceType;
    IPaymentTypeInformation29? IPaymentInstruction37.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification135 IPaymentInstruction37.Creditor => Creditor;
    ICashAccount38 IPaymentInstruction37.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification6 IPaymentInstruction37.CreditorAgent => CreditorAgent;
    ICashAccount38? IPaymentInstruction37.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification135? IPaymentInstruction37.UltimateCreditor => UltimateCreditor;
    ICashAccount38? IPaymentInstruction37.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification6? IPaymentInstruction37.ChargesAccountAgent => ChargesAccountAgent;
    IPartyIdentification135? IPaymentInstruction37.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IEnumerable<IDirectDebitTransactionInformation23> IPaymentInstruction37.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
}
