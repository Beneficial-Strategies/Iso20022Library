// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction33 : IPaymentTransaction33
{
    IEnumerable<IStatusReasonInformation9> IPaymentTransaction33.StatusReasonInformation => StatusReasonInformation;
    IEnumerable<ICharges2> IPaymentTransaction33.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification5? IPaymentTransaction33.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IPaymentTransaction33.InstructedAgent => InstructedAgent;
    IOriginalTransactionReference16? IPaymentTransaction33.OriginalTransactionReference => OriginalTransactionReference;
}
