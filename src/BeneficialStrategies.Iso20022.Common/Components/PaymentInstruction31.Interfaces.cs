// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction31 : IPaymentInstruction31
{
    IPaymentTypeInformation26? IPaymentInstruction31.PaymentTypeInformation => PaymentTypeInformation;
    IDateAndDateTime2Choice IPaymentInstruction31.RequestedExecutionDate => RequestedExecutionDate;
    IDateAndDateTime2Choice? IPaymentInstruction31.ExpiryDate => ExpiryDate;
    IPaymentCondition1? IPaymentInstruction31.PaymentCondition => PaymentCondition;
    IPartyIdentification135 IPaymentInstruction31.Debtor => Debtor;
    ICashAccount38? IPaymentInstruction31.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6 IPaymentInstruction31.DebtorAgent => DebtorAgent;
    IPartyIdentification135? IPaymentInstruction31.UltimateDebtor => UltimateDebtor;
    IEnumerable<ICreditTransferTransaction35> IPaymentInstruction31.CreditTransferTransaction => CreditTransferTransaction;
}
