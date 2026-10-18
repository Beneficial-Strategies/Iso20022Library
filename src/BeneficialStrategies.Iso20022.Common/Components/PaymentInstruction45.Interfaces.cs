// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction45 : IPaymentInstruction45
{
    ICashAccount40? IPaymentInstruction45.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification8? IPaymentInstruction45.ChargesAccountAgent => ChargesAccountAgent;
    IPartyIdentification272 IPaymentInstruction45.Creditor => Creditor;
    ICashAccount40 IPaymentInstruction45.CreditorAccount => CreditorAccount;
    IBranchAndFinancialInstitutionIdentification8 IPaymentInstruction45.CreditorAgent => CreditorAgent;
    ICashAccount40? IPaymentInstruction45.CreditorAgentAccount => CreditorAgentAccount;
    IPartyIdentification272? IPaymentInstruction45.CreditorSchemeIdentification => CreditorSchemeIdentification;
    IEnumerable<IDirectDebitTransactionInformation32> IPaymentInstruction45.DirectDebitTransactionInformation => DirectDebitTransactionInformation;
    IPaymentTypeInformation29? IPaymentInstruction45.PaymentTypeInformation => PaymentTypeInformation;
    IAdviceType1? IPaymentInstruction45.RequestedAdviceType => RequestedAdviceType;
    IPartyIdentification272? IPaymentInstruction45.UltimateCreditor => UltimateCreditor;
}
