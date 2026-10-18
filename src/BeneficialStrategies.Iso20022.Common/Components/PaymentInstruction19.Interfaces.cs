// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction19 : IPaymentInstruction19
{
    IPaymentTypeInformation19? IPaymentInstruction19.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification43 IPaymentInstruction19.Debtor => Debtor;
    ICashAccount24? IPaymentInstruction19.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 IPaymentInstruction19.DebtorAgent => DebtorAgent;
    IPartyIdentification43? IPaymentInstruction19.UltimateDebtor => UltimateDebtor;
    IEnumerable<ICreditTransferTransaction22> IPaymentInstruction19.CreditTransferTransaction => CreditTransferTransaction;
}
