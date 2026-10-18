// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction17 : IPaymentInstruction17
{
    IPaymentTypeInformation19? IPaymentInstruction17.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification43 IPaymentInstruction17.Debtor => Debtor;
    ICashAccount24? IPaymentInstruction17.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 IPaymentInstruction17.DebtorAgent => DebtorAgent;
    IPartyIdentification43? IPaymentInstruction17.UltimateDebtor => UltimateDebtor;
    IEnumerable<ICreditTransferTransaction21> IPaymentInstruction17.CreditTransferTransaction => CreditTransferTransaction;
}
