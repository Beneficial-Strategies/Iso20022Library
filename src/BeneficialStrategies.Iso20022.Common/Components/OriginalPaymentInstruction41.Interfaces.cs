// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record OriginalPaymentInstruction41 : IOriginalPaymentInstruction41
{
    IEnumerable<IPaymentReversalReason9> IOriginalPaymentInstruction41.ReversalReasonInformation => ReversalReasonInformation;
    IEnumerable<IPaymentTransaction134> IOriginalPaymentInstruction41.TransactionInformation => TransactionInformation;
}
