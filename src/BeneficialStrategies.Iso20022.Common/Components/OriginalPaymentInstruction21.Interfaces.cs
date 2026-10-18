// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction21 : IOriginalPaymentInstruction21
{
    IEnumerable<IPaymentReversalReason7> IOriginalPaymentInstruction21.ReversalReasonInformation => ReversalReasonInformation;
    IEnumerable<IPaymentTransaction77> IOriginalPaymentInstruction21.TransactionInformation => TransactionInformation;
}
