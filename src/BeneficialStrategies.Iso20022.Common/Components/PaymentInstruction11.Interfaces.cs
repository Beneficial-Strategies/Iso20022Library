// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction11 : IPaymentInstruction11
{
    IPaymentTypeInformation19? IPaymentInstruction11.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification43 IPaymentInstruction11.Debtor => Debtor;
    ICashAccount24? IPaymentInstruction11.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 IPaymentInstruction11.DebtorAgent => DebtorAgent;
    IPartyIdentification43? IPaymentInstruction11.UltimateDebtor => UltimateDebtor;
    IEnumerable<ICreditTransferTransaction10> IPaymentInstruction11.CreditTransferTransaction => CreditTransferTransaction;
}
