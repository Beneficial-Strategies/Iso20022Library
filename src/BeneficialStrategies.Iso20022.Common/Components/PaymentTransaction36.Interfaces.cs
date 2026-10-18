// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransaction36 : IPaymentTransaction36
{
    IEnumerable<ICharges2> IPaymentTransaction36.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification5? IPaymentTransaction36.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IPaymentTransaction36.InstructedAgent => InstructedAgent;
    IEnumerable<IPaymentReversalReason7> IPaymentTransaction36.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference16? IPaymentTransaction36.OriginalTransactionReference => OriginalTransactionReference;
}
