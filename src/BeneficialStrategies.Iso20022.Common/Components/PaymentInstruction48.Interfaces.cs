// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction48 : IPaymentInstruction48
{
    IAdviceType1? IPaymentInstruction48.RequestedAdviceType => RequestedAdviceType;
    IPaymentTypeInformation29? IPaymentInstruction48.PaymentTypeInformation => PaymentTypeInformation;
    IDateAndDateTime2Choice? IPaymentInstruction48.RequestedExecutionDate => RequestedExecutionDate;
    IDateAndDateTime2Choice? IPaymentInstruction48.ExpiryDate => ExpiryDate;
    IPaymentCondition2? IPaymentInstruction48.PaymentCondition => PaymentCondition;
    IPartyIdentification272 IPaymentInstruction48.Debtor => Debtor;
    ICashAccount40? IPaymentInstruction48.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8 IPaymentInstruction48.DebtorAgent => DebtorAgent;
    ICashAccount40? IPaymentInstruction48.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification272? IPaymentInstruction48.UltimateDebtor => UltimateDebtor;
    IEnumerable<ICreditTransferTransaction74> IPaymentInstruction48.CreditTransferTransaction => CreditTransferTransaction;
}
