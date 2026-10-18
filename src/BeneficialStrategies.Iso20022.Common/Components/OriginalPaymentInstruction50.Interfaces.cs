// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction50 : IOriginalPaymentInstruction50
{
    IEnumerable<IPaymentReversalReason10> IOriginalPaymentInstruction50.ReversalReasonInformation => ReversalReasonInformation;
    IEnumerable<IPaymentTransaction156> IOriginalPaymentInstruction50.TransactionInformation => TransactionInformation;
}
